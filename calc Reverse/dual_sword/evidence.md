# Dual Sword skill tree — evidence

Binary: S1 (`libil2cpp.so`, Android). Class layouts: D1 (`dump.cs`). RVA = file offset + 0x4000 for code.
`.rodata` constants live in the first LOAD segment, where file offset = VA.

## Tools (all offline)

| File | Purpose |
|---|---|
| `D:\toram_re\dis2.py` | annotated disassembly: `this.` field names, vtable slots (vtable base `+0x138`, 16 bytes/slot), interface methods, float constants, `CalcStep` names on `SkillCalcTemplate` calls |
| `D:\toram_re\sem.py` | filters a dump to the lines that matter (`-r` = raw minus IL2CPP boilerplate) |
| `D:\toram_re\callers.py` | direct BL/B callers of an RVA |
| `D:\toram_re\fields.sh` | own fields of a class from `dump.cs` |
| `D:\toram_re\dual\*.txt` | full annotated dumps of every class below |

Reproduce, for example: `python D:\toram_re\dis2.py TwinSlashAction$$calcPlayerToMobDamage`.

## 1. Engine

| Item | Where | What was read |
|---|---|---|
| `CalcStep` type table | `SkillCalcTemplate.checkType` 0x21FF484 → 34 × int32 at VA 0x949384 (steps 7..40) | Constant: 7,8,9,10,11,22,30,35,36,37. Check: 12,14,31,32,38,39 (0..6 default Check). Value: 33. Rate: the rest |
| Defaults | `SkillCalcTemplate..ctor` 0x21F789C | 41 slots; MinusDamageCheck = 1.0 (slot 12), GuardPower = 25 (slot 33), WeakElementDamageCheck = 0 (slot 14) |
| Add vs Set | `AddRate` 0x21F7A74, `AddConstant` 0x21F7BA0, `SetRate` 0x21F92A4, `SetConstant` 0x21FA944 | Add = `slot = slot + BindingVariable(v)` (`op_Addition` 0x21FF2A8), or new if null; Set = replace; wrong type throws ArgumentException |
| `GetDamage` | 0x21FF504 | loop `x20 = 0..0x28`; Rate: `fmul s8,s8,s9; fcvtzs` (0x21FF81C); crit gate `CheckStepResult(6)` then `fcsel s9, s9, 1.0` (0x21FF808); Constant: `fadd s8, s0, s9` (0x21FFC68), step 30 with `d<0` starts from 0 (0x21FFC5C); 35 min (0x21FFA5C); 36 max (0x21FF8C0); guard `d*GuardPower/100` (0x21FF77C); end `d<=0 → 1` (0x21FFDC4) |
| `TemplateAssignment` | wrappers 0x2074378 / 0x2074380 / 0x207439C → main 0x206BBB0 | HitState bits: 0 crit, 1 secure hit, 2 ignore avoid, 3 ignore guard. Step fills listed in formula.md §1.1 (AddConstant [BaseDamage] 0x206BD84, [Def] 0x206BDD4, [BufferConstantDamage] 0x206BE1C/0x206BE40, AddRate [CriticalRate] 0x206C1C4, [StableRate] 0x206C280, [ExpRate] 0x206C2B4, [LastDamageRate] 0x206C3A0/0x206C418/0x206C5D8/0x206C878, [DistanceResistRate] 0x206C434, [TypeDamageRate] 0x206C4B0, [GemDamageRate] 0x206C4DC). No write to steps 8, 11, 18, 19 |
| Base damage | virtual `calcBaseDamage` 0x20733B0 (vtable +0x698) | dual test: `tbnz [sp+0x14] bit15` (eqLimit) at 0x2073C80, `SubWeaponItemType == 10` at 0x2073CB0; `ATK + SubAtk*SubStable/100 + Lv − mobLv` 0x2073CC4..0x2073CE0; `(100 − cut)/100` 0x2073D00; interface slots: Atk 14, Matk 16, SubAtk 39, SubStable 40, SubMatk 41 |
| Static helpers | `calcDualBaseDamage` 0x2073E9C, `calcBaseDamage(int…)` 0x2073EF8 | same formulas as a standalone function |
| Pierce | `CalcRegistDamage` 0x2074DBC → `CalcPowerResistDamage` 0x2070E2C | `DEF*(1 − min(1, addResist + bPowerResistBreaker% + buff(0x48)*0.01))`; TemplateAssignment negates it (0x206BDC0) |
| First attack | `calcFastAttackDamage` 0x2073F40, `calcFastAttackDamageRate` 0x2074014 | bFirstAttack (BonusType 111) / 100 + GodspeedLocus param 30 + 10 (both 1H swords, 0x207419C) + SkillBufferParam(FirstAttackRate 0x2D) + bFirstAttackRate (112); Ichijhinnokaze (0x275) → 100 |
| Hits | `templateToDamageData` 0x206C8D0 → `DamageData.createMultiHitDamage` 0x248B084 | `sdiv w24, dmg, count; msub` remainder spread +1 (0x248B10C) |
| Multi-template | `templateToDamageData(IEnumerable)` 0x20756FC | one SkillDamageData per template, Sum of damages |
| Buffer ÷ n | `SetBufferConstantDamage` 0x2076EA8 | `BufferConstantDamage = (int)(v / n)` |
| Distance resist | `CalcDistanceResistRate` 0x2071958 | 1.0 unless MonsterProperty 15 |
| Meters | `MathUtil.DisplayMeterToDistance` 0x262424C | `fadd s0, s0, s0` (×2) |

Enums used: `SkillBufferId` (GetParam ids), `MasteryId`, `BonusType`, `ItemDBData.ItemType` (10 OneHandSword, 17 Shield, 15 Magictool), `ElementType`, `AbnormalType` (7 Blindness, 9 Freeze, 4 KnockBack) — all from D1.

## 2. Skill classes (RVAs)

| Class | Methods |
|---|---|
| TwinSlashAction (642) | OnInitialize `0x22239E4`, calcPlayerToMobDamage `0x2223D08` |
| ParryingSwordAction (643) | OnInitialize `0x221CA4C`, calcPlayerToMobDamage `0x221CC84` |
| ParryingSwordBuf | .ctor `0x2340D2C`, GetParam `0x2340DBC` |
| StepReactorbuf (644) | .ctor `0x234723C`, GetParam `0x23472D0` |
| DualMastery (641) | GetMasteryParam `0x23592EC` |
| DualSwordTechnique (645) | GetMasteryParam `0x2359358` |
| AirSlideAction (646) | OnInitialize `0x221355C`, calcPlayerToMobDamage `0x2213C88` → calcFirstDamage `0x2213C9C` / calcAnyDamage `0x22142C4` |
| DragoonSwordAction (647) | OnInitialize `0x2216F88`, calcPlayerToMobDamage `0x22178F8` |
| GodspeedLocus (648) | GetMasteryParam `0x235AC84`, CalcFirstAttackRate `0x235AD9C` |
| PhantomRaveAction (649) | OnInitialize `0x221D350`, calcPlayerToMobDamage `0x221DF58`, CalcPhantomRaveLastDamageRate `0x221E388`, CreateMultiDamage `0x221E690`, LunaDitherStartInterruptableInitialize `0x221E8FC` |
| PhiloEclairBuf (650) | .ctor `0x23418F0`, GetParam `0x2341A18` |
| PhiloEclailAttackAction (650) | OnInitialize `0x221EA08`, calcPlayerToMobDamage `0x221ED78` |
| WrapAroundAction (651) | OnInitialize `0x231C2D8`, calcPlayerToMobDamage `0x231C8C0` |
| WrapAroundBuf | .ctor `0x2349F20`, GetParam `0x2349F6C` |
| ShiningClothAction (652) | OnInitialize `0x221F604`, calcPlayerToMobDamage `0x2220124` |
| SturmLeaperAction (653) | OnInitialize `0x222099C`, calcPlayerToMobDamage `0x2221144`, buff lambda `<ActionStart>b__1` `0x22216E4` |
| SturmLeaperBuf | .ctor `0x2347AC0`, GetParam `0x2347B4C` |
| SaberAuraBuf (654) | .ctor `0x2343A28`, GetParam `0x2343C18` |
| ArkSaber (657) | CalcConstantDamage `0x2356ECC` (called from TemplateAssignment 0x206BE2C) |
| ArkSaberBuf | .ctor `0x231D068`, GetParam `0x231D0CC` |
| LunaDitherStarAction (655) | OnInitialize `0x22195E0`, calcPlayerToMobDamage `0x221AF6C` |
| LunaDitherStarBladeRainAction | OnInitialize `0x221B904`, calcPlayerToMobDamage `0x221C28C` |
| LunaDitherStarBuf | .ctor `0x2339C48` |
| TwinBusterBladeAction (656) | OnInitialize `0x2221B94`, ActionSkillEvent `0x22229E0` (2nd rate scaling at 0x2222E58), calcPlayerToMobDamage `0x2222FD8` |
| AirSlicerAction (658) | OnInitialize `0x2211E44`, calcPlayerToMobDamage `0x2212238`, CalcFirstDamage `0x2212638`, CalcSecondDamage `0x22127FC` |
| ArialSlayAction (659) | OnInitialize `0x2214B8C`, calcPlayerToMobDamage `0x22157E0` |
| ArialSlayBuf | .ctor `0x231CEB8`, GetParam `0x231CFAC` |
| HorizontalCutAction (660) | OnInitialize `0x2218068`, calcFirstDamage `0x2218BF4`, calcSecondDamage `0x2218DBC` |
| BladeStingerAction (661) | OnInitialize `0x2216110`, ActionPreparation `0x22166A4`, calcPlayerToMobDamage `0x2216858` |

## 3. Key instructions per skill

| Skill | Instructions (RVA: meaning) |
|---|---|
| Twin Slash | 0x2223A84..0x2223AC8: `rate=(10*Lv+150)/100`, `fix=10*Lv+100`, `crt=5*Lv+50`; 0x2223B04 gem 0x6D value[2] added then `/100`; 0x2223EA8 AddRate[SkillRate], 0x2223EC0 AddConstant[SkillConstantDamage], 0x2223ED4 AddRate[CriticalRate]; templateToDamageData count 1 (0x2223EF0) |
| Parrying Sword | 0x221CAE4..0x221CB74: `Lv+100` + gem 0x6E v4, `/100`; `fix = 5*Lv+50`; count 2 (0x221CE58) |
| Air Slide | 0x221360C..0x2213660: `2.5*Lv` +125 (first), `2*Lv+30` (rest), `fix = 5*Lv+50`; 0x221374C damageCount 4; 0x22140BC / 0x22146D8 SetRate[ExpRate] from `targetExpRegister`; blind 0x2213810 `floor(2.5*Lv)+15` |
| Dragoon Sword | 0x2217078: `20*Lv+200`; 0x2217114: `fix=20*Lv+100`; crit gem 0x2217A4C → `w23=1`; FirstAttack 0x2217D74/0x2217D94; count 2 |
| Godspeed Locus | 0x235ACA4 `param30 = Lv+5`; AGI vector loop 0x235ACB4 (constant (0,1,2,3) at 0x946360, `i<5?1:2`) |
| Phantom Rave | 0x221D428: `20*Lv+500`; 0x221D4A8 `freeze=10*Lv`, `fix=20*Lv`; 0x221E19C `x(change?2:1)`; SetRate[LastDamageRate] 0x221E1E8 / 0x221E248; StandardHitCount 6 (.ctor 0x221E96C); DeathDamage 999999999 (`0x3B9AC9FF`) 0x221E6E8 / 0x221E7D4 |
| Flash Blast (attack) | 0x221EB90..0x221EBF0: `15*Lv+50` (+50 if main is 1H), radius 4/5 m; `fix=10*Lv+100`; eqLimit `isDual<<15` 0x221F188; crit without WrapAround (0x28B) / ClearAndSerene (0x268) 0x221EFD4..0x221F090 |
| Shining Cross | 0x221F6C4..0x221F6D0: `10*Lv+300`, `fix=20*Lv+100`; STR/AGI/DEX ÷ (4 or 5) 0x221F938; distance 0x22203F4..0x2220444 `max(rate − clamp(50m−200,0,400), 100)`; 2 templates (0x2220684) |
| Storm Reaper | 0x2220A3C: `10*Lv+400`, `fix=10*Lv+100`; 0x2220A84 `base DEX/100*Lv`; buff rate 0x22217E0..0x2221994 `clamp(round(d)/9, 0.1, 1)`; buff .ctor 0x2347AF4 `10*Lv*rate` |
| Luna Dither Star | 0x221976C `50*Lv+500`; 0x2219814 `DEX/1.5`; `fix=400` 0x221981C; HitState 0x221B25C..0x221B27C; count 2 |
| Blade Rain | 0x221B954 `5*Lv+250`, resistBreaker `5*Lv`; `addRegist` passed as w6 0x221C54C; SetRate[ExpRate] 0x221C5D0 |
| Twin Buster Blade | 0x2221C5C `75*Lv`, `fix=30*Lv`, 2nd = 500 (0x43FA0000); 0x2221CF8 `+(AGI+DEX)/2`; isCritical = 1 (0x2223228, 0x222337C); 2nd rate 0x2222E48..0x2222E74 `min(2000, rate + 0.5*STR*N)` |
| Air Slicer | 0x2211F68 GetSkillLv(646), 0x22120B4 GetSkillLv(642); 0x2212004 `3b + a`; 0x2212040 `DEX/10*Lv`; 0x22120C8 `100*Lv+500`; 0x2212138 `crit=(5T+50)/2`; 2nd distance 0x22129D8..0x2212A48; crit bonus 0x2212AC0 `lsl` by Blind |
| Arial Slay | 1H sub branch 0x2214CD4..0x2214D90 `100*Lv + max(STR,AGI,DEX)/2`; other 0x2214E64 `50*Lv + max(DEX, STR)`; `fix=20*Lv+100` 0x2214E88 |
| Horizontal Cut | 0x2218234 `10*Lv + DEX + 900`, `fix=60*Lv`; dual halves 0x2218250..0x221826C; 2nd 0x22182D4..0x22182F4 `50*Lv + max(STR,AGI)/2`, `30*Lv` |
| Blade Stinger | 0x2216200..0x2216218 `40*Lv+300`, `fix=100`, `pierce=4*Lv+10`; ActionPreparation 0x22167DC..0x2216804 `P>=101 → min(10P−1000,500)`; graze gate `CheckStepResult(4)` 0x2216A4C; Def override 0x2216B14 |
| Ark Saber constant | 0x2356FF0..0x23570E4 |

## 4. Checks

| Check | Result |
|---|---|
| Skill ids ↔ classes | `SkillId` enum 641..661 names match the class names; each `*Buf.get_SkillId` returns the matching id (e.g. SturmLeaperBuf 0x28D = 653) |
| Descriptions (`skills.csv` Thai text) vs code | agree in direction: Twin Slash "crit damage higher" ↔ CriticalRate add; Twin Buster Blade "high crit chance" ↔ forced crit; Shining Cross "closer = more damage" ↔ distance penalty; Blade Stinger "no graze → more pierce, excess pierce → more power" ↔ graze gate + bonus; Air Slicer notes (Spinning Slash level, Twin Slash crit, Blind, 8 m+) ↔ S/T/Blind/`ceil(d)−7` |
| In-game damage | not done |
