# Boss difficulty scaling — evidence

Source IDs (`S1`, `D1`, ...) are defined in [`../_sources.md`](../_sources.md).
Addresses are RVAs in S1; file offset = RVA − 0x4000.

## 1. Class layout (D1 `dump.cs`, TypeDefIndex 11280)

```
// Namespace: Toram.Common.Rooms
public static class BossDifficultyLevelMethods
{
    private static float[] HpRate;            // static +0x00
    private static float[] StatusRate;        // static +0x08
    private static float[] AttackRate;        // static +0x10
    private static int[]   LvRate;            // static +0x18
    private static float[] FlinchResistRate;  // static +0x20
    private static float[] TumbleResistRate;  // static +0x28
    private static float[] StunResistRate;    // static +0x30
    private static float[] ExpRate;           // static +0x38
    private static float[] PartsExpRate;      // static +0x40
    private static int[]   DropRate;          // static +0x48

    RVA 0x36D6470  private static int   CheckDifficulty(int difficulty)
    RVA 0x36D648C  public  static short GetLevel(short lv, int difficulty)
    RVA 0x36D6540  public  static int   GetExp(int exp, int partsExp, int difficulty)
    RVA 0x36D6630  public  static int   GetHpRate(int param, int difficulty)
    RVA 0x36D66F4  public  static int   GetStatusRate(int param, int difficulty)
    RVA 0x36D67B8  public  static int   GetAttackRate(int param, int difficulty)
    RVA 0x36D687C  public  static float GetFlinchResistTime(float param, int difficulty)
    RVA 0x36D695C  public  static float GetTumbleResistTime(float param, int difficulty)
    RVA 0x36D6A3C  public  static float GetStunResistTime(float param, int difficulty)
    RVA 0x36D6B1C  private static void  .cctor()
}
```

Difficulty enum (metadata constants D2/D4): `UIBossSymbolManager/DifficultyState` = Easy −1, Normal 0, Hard 1, Lunatic 2, Ultimate 3.
Thai UI text (`System_th`): `BossMenuDifficultyLunaticMode` = "Nightmare".

## 2. Table values: `.cctor` → blobs

`.cctor` (RVA 0x36D6B1C) creates each array with `il2cpp_array_new(<type>, 5)` then calls
`System.Runtime.CompilerServices.RuntimeHelpers.InitializeArray` with a field handle, and stores the array into the static slot.
Field handles were resolved through R_AARCH64_RELATIVE relocations in S1 to `script.json` (D1) names.

| Static | Pointer slot → handle | Blob field (`<PrivateImplementationDetails>`) | Raw 20 bytes (D2 = D4) | Decoded |
|---|---|---|---|---|
| +0x00 HpRate | 0x39E66F0 → 0x3B36450 | `91D17E03631EE203…F39006B` | `cdcccc3d0000803f000000400000a04000002041` | f32: 0.1, 1, 2, 5, 10 |
| +0x08 StatusRate | 0x39E66F8 → 0x3B36498 | `D6759493533D00F3…97F1177` | `cdcccc3d0000803f00000040000080400000c040` | f32: 0.1, 1, 2, 4, 6 |
| +0x10 AttackRate | 0x39E6700 → 0x3B364C0 | `EE8665C3D0442570…D58A7C82` | `0000003f0000803f00000040000080400000c040` | f32: 0.5, 1, 2, 4, 6 |
| +0x18 LvRate | 0x39E6708 → 0x3B36470 | `AA8203F4CE7B9529…A9C6A20E` | `f6ffffff000000000a0000001400000028000000` | i32: −10, 0, 10, 20, 40 |
| +0x20 FlinchResistRate | 0x39E6710 → 0x3B36440 | `7954096DFB5A3E87…FE9B5ED82` | `0000000000000000000040400000c04000001041` | f32: 0, 0, 3, 6, 9 |
| +0x28 TumbleResistRate | 0x39E6718 → 0x3B36458 | `9B765DA20F714ED6…BDA45F1F` | `00000000000000000000c0400000404100009041` | f32: 0, 0, 6, 12, 18 |
| +0x30 StunResistRate | 0x39E6720 → 0x3B36418 | `136DA6061319116F…023544E36` | `0000000000000000000020410000a0410000f041` | f32: 0, 0, 10, 20, 30 |
| +0x38 ExpRate | 0x39E66F0 → 0x3B36450 | same blob as HpRate | `cdcccc3d0000803f000000400000a04000002041` | f32: 0.1, 1, 2, 5, 10 |
| +0x40 PartsExpRate | 0x39E6730 → 0x3B36488 | `D2E19F1902B2ED17…4B4C9E4212` | `cdcccc3d0000803f0000803f0000803f0000803f` | f32: 0.1, 1, 1, 1, 1 |
| +0x48 DropRate | 0x39E6728 → 0x3B36438 | `44C917837CCF9EC0…D6F96B8EBB` | `a6ffffff0000000064000000c800000090010000` | i32: −90, 0, 100, 200, 400 |

Store instructions that fix the static offsets, e.g.:

```
0x36D6D98  bl  RuntimeHelpers.InitializeArray      ; handle from x25 = slot 0x39E66F0
0x36D6DA8  str x19, [x0, #0x38]!                    ; -> ExpRate
0x36D6DC0  ldr x8, [x8, #0x730]                     ; slot 0x39E6730
0x36D6DE0  str x19, [x0, #0x40]!                    ; -> PartsExpRate
0x36D6DF8  ldr x8, [x8, #0x728]                     ; slot 0x39E6728
0x36D6E28  str x19, [x0, #0x48]!                    ; -> DropRate
```

Full blob names are in `metadata/constants.tsv` (type `<PrivateImplementationDetails>`, kind `blob20`).

## 3. Method bodies (D3)

### CheckDifficulty — index clamp

```
0x36D6470  cmp   w0, #3
0x36D6474  mov   w8, #3
0x36D6478  csel  w8, w0, w8, lt        ; min(d, 3)
0x36D647C  cmp   w8, #0
0x36D6480  csinv w8, w8, wzr, ge       ; d < 0 -> -1
0x36D6484  add   w0, w8, #1            ; index 0..4
```
The same clamp is inlined in every getter below.

### GetLevel — additive

```
0x36D64EC  ldr   x8, [x8, #0x18]       ; LvRate
0x36D6514  ldr   w8, [x8, #0x20]       ; LvRate[i]
0x36D651C  add   w8, w8, w19, uxth     ; + lv
0x36D6528  cmp   w9, #1
0x36D652C  csinc w0, w8, wzr, ge       ; result < 1 -> 1
```

### GetHpRate / GetStatusRate / GetAttackRate — multiply, truncate

```
GetHpRate      0x36D6690 ldr x8, [x8]        ; HpRate (+0x00)
GetStatusRate  0x36D6754 ldr x8, [x8, #8]    ; StatusRate (+0x08)
GetAttackRate  0x36D6818 ldr x8, [x8, #0x10] ; AttackRate (+0x10)
common tail:   ldr s0, [x8, #0x20]           ; rate[i]
               scvtf s1, w19                 ; (float)param
               fmul s0, s0, s1
               fcvtzs w8, s0                 ; truncate toward zero
               fcmp s0, +inf ; csel w0, INT_MIN, w8, eq
```

### GetExp — two tables

```
0x36D6560  mov w19, w1                 ; partsExp
0x36D6564  mov w20, w0                 ; exp
0x36D65A4  ldr x8, [x10, #0x38]        ; ExpRate
0x36D65C8  ldr x10, [x10, #0x40]       ; PartsExpRate
0x36D65F0  fmul s0, s0, s1             ; ExpRate[i] * exp
0x36D65FC  fmul s1, s2, s1             ; PartsExpRate[i] * partsExp
0x36D660C  fadd s0, s0, s1
0x36D6610  fcvtzs w8, s0
```

### GetFlinchResistTime (Tumble/Stun identical, tables +0x28/+0x30) — max

```
0x36D68DC  ldr  x8, [x8, #0x20]        ; FlinchResistRate
0x36D6904  ldr  s0, [x9, #0x20]        ; rate[i]
0x36D6908  fcmp s0, s8                 ; s8 = param
0x36D690C  b.le 0x36D6940              ; rate <= param -> return param
0x36D693C  ldr  s8, [x8, #0x20]        ; else return rate
```

Tumble: `0x36D69BC ldr x8, [x8, #0x28]`, `0x36D69E8 fcmp s0, s8`, `0x36D69EC b.le`.
Stun: `0x36D6A9C ldr x8, [x8, #0x30]`, `0x36D6AC8 fcmp s0, s8`, `0x36D6ACC b.le`.

## 4. Who uses which table (D3, scan of every BL/B in the executable segment of S1)

| Method | Callers |
|---|---|
| GetHpRate | `BossMobBattleStatus.get_MaxHp` (tail call), `FieldScriptManager.OnBossNameCommnad`, `UIBossSymbolManager/UIBossRaidSymbolManager/UINCollaborationEnterManager/UINaCollaborationEnterManager.OpenBossDataWindow` |
| GetLevel | `BossMobBattleStatus.get_Level`, `FieldScriptManager.OnBossNameCommnad`, boss result/raid UI (13 call sites) |
| GetStatusRate | `BossMobBattleStatus.get_NecessaryHit / get_Def / get_MagicDef`, `MobPartsStatus.get_NecessaryHit / get_Def / get_MagicDef` |
| GetAttackRate | `MobAttackBase.CalcBaseAttack`, `MobEventScriptAttack.CalcBaseAttack`, `SelfInjuryPattern..ctor`, `MobAttackBase.CalcFlee` (tail call) |
| GetExp | the four `OpenBossDataWindow` methods (EXP shown in the difficulty menu) |
| GetFlinch/Tumble/StunResistTime | `BossMobActionManager.ResistCollection` (tail calls) |
| DropRate | no reader in the client |

`BossMobBattleStatus` getters with no call into this class (not scaled): CutAttack, CutMagicAttack, GuardProbability,
AvoidProbability, Element, MoveSpeed, Persona, PersonaValue, DamagePercent, NecessaryFleePercent, StablePercent,
ExpDefNormal/Skill/Magic.

## 5. Checks

| Check | Result |
|---|---|
| S1 not packed | exec segment entropy 6.62, 142,875 RET — see `_sources.md` |
| Blobs identical on Android (D4) and PC (D2) | 9/9 byte-identical |
| In-game | Krust (uuid 587, map 24100) Normal Lv178 HP 3,500,000 → formula Ultimate Lv218 HP 35,000,000; seen in game: Lv218, 35,000,000 |
| Community wiki (toram.fandom.com, Difficulty System) | Easy Lv −10 HP ×0.1, Hard Lv +10 HP ×2: agree. Wiki "Hard EXP ×1.5" disagrees with ExpRate (×2) |

## 6. Reproduce

```
python D:\toram_re\dis_android.py 0x36d6b1c 0x36d6470 0x36d648c 0x36d6540 0x36d6630 0x36d66f4 0x36d67b8 0x36d687c
grep "<PrivateImplementationDetails>" "metadata/constants.tsv" | grep -E "91D17E03|D6759493|EE8665C3|AA8203F4|7954096D|9B765DA2|136DA606|44C91783|D2E19F19"
```
Output table: `monsters/boss_difficulty.csv` (generated by `scripts/export_monsters.py`).
