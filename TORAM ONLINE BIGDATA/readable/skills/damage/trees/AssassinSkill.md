# アサシンスキル (`AssassinSkill`)

15 entries. See ../README.md for how to read these blocks.

### แอสแซสซินสแทบ / ฟรอนท์สแทบ / ไซด์สแทบ / แบ็คสแทบ (AssassinStub) · uid 993

<img src="../../icons/sk_993.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 1) · **Type:** Attack · **Max Lv:** 15 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** NoMarketSearch, MercenaryCanUseSkill · **Client class:** `AssassinStubAction`

> โจมตีเป้าหมายหนึ่งครั้งอย่างหมายเอาชีวิต
> ประสิทธิภาพจะเปลี่ยนไปตามทิศทางการโจมตี
> จะแสดงพลังความสามารถได้มากที่สุดจากการเล็งทางด้านหลังของศัตรู

<details><summary>In-game level notes</summary>

- Lv18: [จะได้รับผลแบบเดียวกันเมื่อใช้คัมภีร์นินจูตสึ] *พลัง+50 สำหรับฟรอนท์สแทบ  * พลัง+100 สำหรับไซด์สแทบ *พลัง+300 สำหรับแบ็คสแต็บ

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05] | 2.08 | 2.11 | 2.14 | 2.17 | 2.2 | 2.23 | 2.26 | 2.29 | 2.32 | 2.35 |
| SkillRate × [!UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05] | 2.08 | 2.11 | 2.14 | 2.17 | 2.2 | 2.23 | 2.26 | 2.29 | 2.32 | 2.35 |
| SkillRate × [UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05] | 1.51 | 1.52 | 1.53 | 1.54 | 1.55 | 1.56 | 1.57 | 1.58 | 1.59 | 1.6 |
| Flat dmg + | 30 | 60 | 90 | 120 | 150 | 180 | 210 | 240 | 270 | 300 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(int((((((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) eq 0 ? 1 : (((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1))) * (((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1)))) + ((1) eq 0 ? SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) : (SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 100))))) / 100)` — UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05 & direction eq 1
- SkillRate × `(int((((((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) eq 0 ? 1 : (((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1))) * (((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1)))) + ((1) eq 0 ? SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) : (SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 100))))) / 100)` — !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05 & direction eq 1
- SkillRate × `(int((((((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) eq 0 ? 1 : (((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1))) * (((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1)))) + ((1) eq 0 ? SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) : (SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 100))))) / 100)` — !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05 & direction eq 1
- SkillRate × `(int((((((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) eq 0 ? 1 : (((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1))) * (((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1)))) + ((1) eq 0 ? SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) : (SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 100))))) / 100)` — UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05 & direction eq 1
- SkillRate × `(int((((((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) eq 0 ? 1 : (((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1))) * ((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1)))))) / 100)` — UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05
- SkillRate × `(int((((((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) eq 0 ? 1 : (((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1))) * ((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1)))))) / 100)` — !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05
- SkillRate × `(int((((((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) eq 0 ? 1 : (((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1))) * ((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1)))))) / 100)` — !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05
- SkillRate × `(int((((((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) eq 0 ? 1 : (((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1))) * ((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1)))))) / 100)` — UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05

**Role:** attack (deals damage) · buff (self)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `((Lv * 30))`
- `SkillRate` multiplies by (adds into): `(int((((((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) eq 0 ? 1 : (((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1))) * (((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1)))) + ((1) eq 0 ? SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) : (SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 100))))) / 100)` | `(int((((((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) eq 0 ? 1 : (((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1))) * ((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1)))))) / 100)` | `(int(((((BackstepBuf.GetParam(50) * 0.01) + 1) eq 0 ? 1 : ((BackstepBuf.GetParam(50) * 0.01) + 1)) * (((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1)))) + ((1) eq 0 ? SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) : (SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 100))))) / 100)`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 993

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (3 paths)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(4)`
- set `isEquipBonus` = `1` = 1 — when subWeapon == NinjutsuBook OR subWeapon != NinjutsuBook AND subWeapon == ShortSword
- set `fixAddDamage` = `(Lv * 30)` → Lv1..10: [30, 60, 90, 120, 150, 180, 210, 240, 270, 300]

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionPreparation`** (24 paths)

- set `direction` = `2` = 2 — when UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05
- set `skillRate` = `((isEquipBonus eq 0 ? 105 : 205) + (Lv + (Lv << 1)))` — when UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05
- set `SkillIndividualFlag` = `2` = 2 — when UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05
- set `skillRate` = `((((isEquipBonus eq 0 ? 105 : 205) + (Lv + (Lv << 1))) + gemCart(1004[4])) + AssassinationSecrets.GetAssassinStubSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1), PlayerActionManagerBase.get_PlayerStatus()))` — when !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05
- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))` — when !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05
- set `skillRate` = `(((isEquipBonus eq 0 ? 105 : 205) + (Lv + (Lv << 1))) + gemCart(1004[4]))` — when !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05
- set `direction` = `0` = 0 — when UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05
- set `skillRate` = `((Lv + (isEquipBonus eq 0 ? 0 : 50)) + 100)` — when UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05
- set `SkillIndividualFlag` = `0` = 0 — when UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05
- set `skillRate` = `((((Lv + (isEquipBonus eq 0 ? 0 : 50)) + 100) + gemCart(1004[4])) + AssassinationSecrets.GetAssassinStubSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1), PlayerActionManagerBase.get_PlayerStatus()))` — when !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05
- set `skillRate` = `(((Lv + (isEquipBonus eq 0 ? 0 : 50)) + 100) + gemCart(1004[4]))` — when !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05
- set `direction` = `1` = 1 — when UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05
- set `skillRate` = `((isEquipBonus eq 0 ? 110 : 410) + (Lv + (Lv << 3)))` — when UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05
- set `SkillIndividualFlag` = `1` = 1 — when UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05
- set `skillRate` = `((((isEquipBonus eq 0 ? 110 : 410) + (Lv + (Lv << 3))) + gemCart(1004[4])) + AssassinationSecrets.GetAssassinStubSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1), PlayerActionManagerBase.get_PlayerStatus()))` — when !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05
- calls `AssassinStubBuf..ctor` = `.ctor(Lv, gemCart(1004[2]))` — when !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new AssassinStubBuf, Id)` — when !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05
- set `skillRate` = `(((isEquipBonus eq 0 ? 110 : 410) + (Lv + (Lv << 3))) + gemCart(1004[4]))` — when !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05

**`calcPlayerToMobDamage`** (24 paths)

- set `stubRate` = `((((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) eq 0 ? 1 : (((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)))`
- set `skillRate` = `int((((((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) eq 0 ? 1 : (((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1))) * (skillRate + (isEquipBonus eq 0 ? SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) : (SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 100)))))` — when direction eq 1
- template `AddRate[SkillRate]` = `(int((((((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) eq 0 ? 1 : (((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1))) * (skillRate + (isEquipBonus eq 0 ? SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) : (SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 100))))) / 100)` — when direction eq 1
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(995)`
- info `templates` = `1`
- set `skillRate` = `int((((((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) eq 0 ? 1 : (((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1))) * skillRate))`
- template `AddRate[SkillRate]` = `(int((((((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) eq 0 ? 1 : (((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1))) * skillRate)) / 100)`
- set `stubRate` = `(((BackstepBuf.GetParam(50) * 0.01) + 1) eq 0 ? 1 : ((BackstepBuf.GetParam(50) * 0.01) + 1))`
- set `skillRate` = `int(((((BackstepBuf.GetParam(50) * 0.01) + 1) eq 0 ? 1 : ((BackstepBuf.GetParam(50) * 0.01) + 1)) * (skillRate + (isEquipBonus eq 0 ? SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) : (SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 100)))))` — when direction eq 1
- template `AddRate[SkillRate]` = `(int(((((BackstepBuf.GetParam(50) * 0.01) + 1) eq 0 ? 1 : ((BackstepBuf.GetParam(50) * 0.01) + 1)) * (skillRate + (isEquipBonus eq 0 ? SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) : (SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 100))))) / 100)` — when direction eq 1
- set `skillRate` = `int(((((BackstepBuf.GetParam(50) * 0.01) + 1) eq 0 ? 1 : ((BackstepBuf.GetParam(50) * 0.01) + 1)) * skillRate))`
- template `AddRate[SkillRate]` = `(int(((((BackstepBuf.GetParam(50) * 0.01) + 1) eq 0 ? 1 : ((BackstepBuf.GetParam(50) * 0.01) + 1)) * skillRate)) / 100)`
- set `stubRate` = `(((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1) eq 0 ? 1 : ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1))`
- set `skillRate` = `int(((((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1) eq 0 ? 1 : ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) * (skillRate + (isEquipBonus eq 0 ? SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) : (SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 100)))))` — when direction eq 1
- template `AddRate[SkillRate]` = `(int(((((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1) eq 0 ? 1 : ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) * (skillRate + (isEquipBonus eq 0 ? SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) : (SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 100))))) / 100)` — when direction eq 1
- set `skillRate` = `int(((((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1) eq 0 ? 1 : ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) * skillRate))`
- template `AddRate[SkillRate]` = `(int(((((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1) eq 0 ? 1 : ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) * skillRate)) / 100)`
- set `stubRate` = `1` = 1
- set `skillRate` = `int((skillRate + (isEquipBonus eq 0 ? SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) : (SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 100))))` — when direction eq 1
- template `AddRate[SkillRate]` = `(int((skillRate + (isEquipBonus eq 0 ? SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) : (SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 100)))) / 100)` — when direction eq 1
- set `skillRate` = `int(skillRate)`
- template `AddRate[SkillRate]` = `(int(skillRate) / 100)`

**`OnEnd`** (3 paths)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(993)` — when UnityEngine.Object.op_Inequality(playerAction) AND hasBuff(993)

**`GetLocalizeKey`** (1 path)

- set `direction` = `direction`

**`<ActionPreparation>b__28_0`** (5 paths)

- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(999, PlayerStatusBase.get_SkillManager().SkillMasteryList[999].skillData.Level, stubRate)` — when direction eq 1 OR (SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().skillBufList[999], 50) * 0.01) le stubRate AND direction eq 1

</details>

**Buffs**

**Buff `AssassinStubBuf`**
- `HitRate` = `(hitUp)` _(when BuffEffectActive ne 0)_
- `HitRate` = `0` _(when BuffEffectActive eq 0)_
- Buff fields set in the constructor (all recovered):
  - `hitUp` = `hitUp`
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:AssassinStubBuf$$.ctor<-AssassinStubAction$$ActionPreparation` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

<details><summary>Effect applied in `AssassinStubAction$$OnEnd` (2 guarded paths)</summary>

- always
  - calls `SkillBufferManager$$RemoveSelfBuffer`, `PlayerAttackBase$$OnEnd`
- always
  - calls `PlayerAttackBase$$OnEnd`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `AssassinStubAction$$OnEnd (ContainsBuffer)`

---

### อีเวชัน (Evolution) · uid 994

<img src="../../icons/sk_994.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 1) · **Type:** Support · **Max Lv:** 15 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** NoMarketSearch, MercenaryCanUseSkill · **Client class:** `EvolutionAction`

> สกิลเพิ่มความสามารถในการหลบหลีก
> เพิ่มอัตราการหลบหลีกชั่วขณะ
> เมื่อใช้จะปลดสถานะผิดปกติ "เชื่องช้า"

<details><summary>In-game level notes</summary>

- Lv18: [จะได้รับผลแบบเดียวกันเมื่อใช้คัมภีร์นินจูตสึ] *2x ระยะเวลาแสดงผล *หลบหลีก +10

</details>

**Role:** buff (self) · buff (party / others)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 994

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (2 paths)

- calls `EvolutionBuf..ctor` = `.ctor(Lv, 0, subWeaponType)`
- calls `SkillBufferManager.AddBuffer` = `AddBuffer(new EvolutionBuf, 0)`
- calls `AbnormalStateManager.RemoveAbnormalState` = `RemoveAbnormalState(11)` — when AbnormalStateManager.Contains(PlayerActionManagerBase.get_AbnormalStatusManager(), 11)

</details>

**Buffs**

**Buff `EvolutionBuf`**
- Duration: `((Lv + 20) + (Lv + 20))` s [itemType eq 23 OR itemType eq 18 AND itemType ne 23]; `(Lv + 20)` s [itemType ne 18 AND itemType ne 23]

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flee | 11 | 12 | 13 | 14 | 15 | 16 | 17 | 18 | 19 | 20 |
| FleeRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |

- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `flee` = `(Lv + 10)` → Lv1..10 [11, 12, 13, 14, 15, 16, 17, 18, 19, 20] when itemType eq 23 OR itemType eq 18 AND itemType ne 23
  - `flee` = `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] when itemType ne 18 AND itemType ne 23
  - `fleeRate` = `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] when itemType eq 23 OR itemType eq 18 AND itemType ne 23 OR itemType ne 18 AND itemType ne 23
  - `isViewSelfIcon` = `(isSelf & 1)` when itemType eq 23 OR itemType eq 18 AND itemType ne 23 OR itemType ne 18 AND itemType ne 23
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `SetViewSelfIcon`: `isViewSelfIcon`=(flag & 1)
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:EvolutionBuf$$.ctor<-EvolutionAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

---

### เวนอมอินเจค (VenomInject) · uid 1001

<img src="../../icons/sk_1001.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 1) · **Type:** Buffer · **Max Lv:** 15 · **Weapons:** ShortSword, NinjutsuScroll, MainHand · **Flags:** NoMarketSearch · **Client class:** `VenomInjectAction`

> ทักษะลอบสังหารเคลือบพิษที่อาวุธ
> ใช้ HP ของตัวเองเพื่อเพิ่มโอกาสติดพิษร้าย
> ระหว่างการโจมตีปกติ อัตราการติด
> จะเปลี่ยนไปตามประสิทธิภาพของ
> ดาบสั้น/ม้วนคัมภีร์นินจูตสึ, คริติคอลและ Graze

<details><summary>In-game level notes</summary>

- Lv10: *อัตราติดพิษเพิ่มขึ้นตามสกิลเลเวล
- Lv9: *อัตราติดพิษเพิ่มขึ้นตามสกิลเลเวล
- Lv254: **อัตราติดพิษเพิ่มขึ้นตามสกิลเลเวล

</details>

**Role:** buff (self) · modifies normal-attack behaviour

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1001

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**`ActionHit`** (4 paths)

- calls `VenomInjectBuf..ctor` = `.ctor(Lv, SkillBufferDataBase.GetParam(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1001), 20), EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator))` — when TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1001) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new VenomInjectBuf, Id)` — when UnityEngine.Object.op_Inequality(actarAction) OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1001) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- calls `VenomInjectBuf..ctor` = `.ctor(Lv, 0, EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator))` — when UnityEngine.Object.op_Inequality(actarAction)

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

</details>

**Buffs**

**Buff `VenomInjectBuf`**
- **Modifies normal attacks**: `NormalAttackAction` looks this buff up while it builds the normal-attack damage / hit logic.
- Buff hook methods: `Prev`
- `Percent` = `CountBufferBase.GetParam(this, id)` _(when BuffEffectActive eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Percent | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |

- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `percent` = `((Lv + (Lv << 2)) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100] when ((1 << weaponType) & 1537) ne 0 AND weaponType ls 10
  - `percent` = `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] when weaponType hi 10 OR ((1 << weaponType) & 1537) eq 0 AND weaponType ls 10
  - `Count` = `(Max lt (addCount + lv) ? Max : (addCount + lv))` when weaponType hi 10 OR ((1 << weaponType) & 1537) eq 0 AND weaponType ls 10 OR ((1 << weaponType) & 1537) ne 0 AND weaponType ls 10
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:VenomInjectBuf$$.ctor<-VenomInjectAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `Next`, `NextSkip`, `Prev`, `PrevSkip`, `get_Count`, `get_Max`, `get_Peak`, `set_Count`, `set_Max`
- `Count` = `(0)`
- Buff fields set in the constructor (all recovered):
  - `Count` = `0`
  - `Max` = `max`
- Hook `set_Count`: `Count`=value
- Hook `set_Max`: `Max`=value
- Hook `Next`: `Count`=System.Math.Min((Count + 1), Max)
- Hook `NextSkip`: `Count`=System.Math.Min((Count + count), Max)
- Hook `Prev`: `Count`=System.Math.Max((Count - 1), 0)
- Hook `PrevSkip`: `Count`=System.Math.Max((Count - count), 0)

<details><summary>Effect applied in `NormalAttackAction$$PossibilityAbnormalState` (3 guarded paths)</summary>

- always
  - returns `0x165d9d4(meta(0x39744c8, AbnormalType[]_TypeInfo), 1, ?x2, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165d9d4`
- always
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165d9d4`, `0x165db8c`
- always
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$PossibilityAbnormalState`

</details>

<details><summary>Effect applied in `VenomInjectAction$$CalcPercent` (62 guarded paths)</summary>

- when `SkillLv(1001) ge 1` AND `(critical & 1) ne 0` AND `(glaze & 1) eq 0`
  - returns `((((([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) lt 10 ? ([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) : 10) * SkillLv(1001)) lt 100 ? ((([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) lt 10 ? ([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) : 10) * SkillLv(1001)) : 100) << (critical & 1))`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_Weapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
- when `SkillLv(1001) ge 1` AND `(critical & 1) ne 0` AND `(glaze & 1) ne 0`
  - returns `(((([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) lt 10 ? ([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) : 10) * SkillLv(1001)) lt 100 ? ((([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) lt 10 ? ([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) : 10) * SkillLv(1001)) : 100)`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_Weapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
- when `SkillLv(1001) ge 1` AND `(critical & 1) eq 0` AND `(glaze & 1) ne 0`
  - returns `((((((([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) lt 10 ? ([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) : 10) * SkillLv(1001)) lt 100 ? ((([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) lt 10 ? ([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) : 10) * SkillLv(1001)) : 100) << (critical & 1)) lt 0 ? (((((([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) lt 10 ? ([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) : 10) * SkillLv(1001)) lt 100 ? ((([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) lt 10 ? ([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) : 10) * SkillLv(1001)) : 100) << (critical & 1)) + 1) : ((((([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) lt 10 ? ([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) : 10) * SkillLv(1001)) lt 100 `
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_Weapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
- when `SkillLv(1001) ge 1` AND `(critical & 1) eq 0` AND `(glaze & 1) eq 0`
  - returns `((((([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) lt 10 ? ([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) : 10) * SkillLv(1001)) lt 100 ? ((([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) lt 10 ? ([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) : 10) * SkillLv(1001)) : 100) << (critical & 1))`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_Weapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
- when `SkillLv(1001) ge 1` AND `(critical & 1) ne 0` AND `(glaze & 1) eq 0`
  - returns `((((SkillLv(1001) + (SkillLv(1001) << 2)) << 1) lt 100 ? ((SkillLv(1001) + (SkillLv(1001) << 2)) << 1) : 100) << (critical & 1))`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_Weapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
- when `SkillLv(1001) ge 1` AND `(critical & 1) ne 0` AND `(glaze & 1) ne 0`
  - returns `(((SkillLv(1001) + (SkillLv(1001) << 2)) << 1) lt 100 ? ((SkillLv(1001) + (SkillLv(1001) << 2)) << 1) : 100)`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_Weapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
- when `SkillLv(1001) ge 1` AND `(critical & 1) eq 0` AND `(glaze & 1) ne 0`
  - returns `((((((SkillLv(1001) + (SkillLv(1001) << 2)) << 1) lt 100 ? ((SkillLv(1001) + (SkillLv(1001) << 2)) << 1) : 100) << (critical & 1)) lt 0 ? (((((SkillLv(1001) + (SkillLv(1001) << 2)) << 1) lt 100 ? ((SkillLv(1001) + (SkillLv(1001) << 2)) << 1) : 100) << (critical & 1)) + 1) : ((((SkillLv(1001) + (SkillLv(1001) << 2)) << 1) lt 100 ? ((SkillLv(1001) + (SkillLv(1001) << 2)) << 1) : 100) << (critical & 1))) >> 1)`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_Weapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
- when `SkillLv(1001) ge 1` AND `(critical & 1) eq 0` AND `(glaze & 1) eq 0`
  - returns `((((SkillLv(1001) + (SkillLv(1001) << 2)) << 1) lt 100 ? ((SkillLv(1001) + (SkillLv(1001) << 2)) << 1) : 100) << (critical & 1))`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_Weapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `NormalAttackAction$$PossibilityAbnormalState (ContainsBuffer)`
- `VenomInjectAction$$CalcPercent (GetSkillLv)`

---

### แบ็คสเต็ป (Backstep) · uid 995

<img src="../../icons/sk_995.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 2) · **Type:** Special · **Max Lv:** 35 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** [N]แอสแซสซินสแทบ[F]ฟรอนท์สแทบ[S]ไซด์สแทบ[B]แบ็คสแทบ[N] · **Flags:** NoMarketSearch, MercenaryCanUseSkill · **Client class:** `BackstepAction`

> สกิลหลบหลีกอย่างว่องไว
> เมื่อเคลื่อนย้ายในระยะทางที่กำหนดได้สำเร็จ
> เพิ่มพลังโจมตีของแอสแซสซินสแทบที่จะใช้ถัดไป
> MP จะเพิ่มขึ้นเล็กน้อย
> เมื่อใช้ให้เข้ากับสัญญาณเตือนโจมตีของมอนสเตอร์

<details><summary>In-game level notes</summary>

- Lv18: [จะได้รับผลแบบเดียวกันเมื่อใช้คัมภีร์นินจูตสึ] *ปริมาณฟื้นฟู MP เป็น 2 เท่า

</details>

**Role:** buff (self)

This action never changes monster proration: IsExpDefFluctuate=false.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Loop / hit-repeat count** (`LoopParam`): `int((UnityEngine.Quaternion.Internal_MakePositive(0).y * 100))` _(when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) lt MathUtil.DisplayMeterToDistance(3) AND MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) ge MathUtil.DisplayMeterToDistance(3) AND MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) OR !MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) lt MathUtil.DisplayMeterToDistance(3))_

**Proration:** slot `none`, mode `never (IsExpDefFluctuate=false)`, attack type `None`, action id 995

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionStart`** (13 paths)

- set `LoopParam` = `int((UnityEngine.Quaternion.Internal_MakePositive(0).y * 100))` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) lt MathUtil.DisplayMeterToDistance(3) AND MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) ge MathUtil.DisplayMeterToDistance(3) AND MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) OR !MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) lt MathUtil.DisplayMeterToDistance(3)
- set `SkillIndividualFlag` = `(SkillIndividualFlag | 1)` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) lt MathUtil.DisplayMeterToDistance(3) AND MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) OR !PlayerAttackBase.IsBlank(this) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) lt MathUtil.DisplayMeterToDistance(3) AND MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) lt MathUtil.DisplayMeterToDistance(3) AND MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05
- set `SkillIndividualFlag` = `((SkillIndividualFlag | 1) | 2)` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) ge MathUtil.DisplayMeterToDistance(3) AND MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) OR !PlayerAttackBase.IsBlank(this) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) ge MathUtil.DisplayMeterToDistance(3) AND MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) ge MathUtil.DisplayMeterToDistance(3) AND MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05
- calls `BackstepBuf..ctor` = `.ctor(Lv)` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) ge MathUtil.DisplayMeterToDistance(3) AND MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) OR !MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) ge MathUtil.DisplayMeterToDistance(3) OR !PlayerAttackBase.IsBlank(this) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) ge MathUtil.DisplayMeterToDistance(3) AND MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new BackstepBuf, Id)` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) ge MathUtil.DisplayMeterToDistance(3) AND MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) OR !MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) ge MathUtil.DisplayMeterToDistance(3) OR !PlayerAttackBase.IsBlank(this) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) ge MathUtil.DisplayMeterToDistance(3) AND MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05
- set `SkillIndividualFlag` = `(SkillIndividualFlag | 2)` — when !MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) ge MathUtil.DisplayMeterToDistance(3) OR !MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) AND !PlayerAttackBase.IsBlank(this) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) ge MathUtil.DisplayMeterToDistance(3) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) AND !PlayerAttackBase.IsBlank(this) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) ge MathUtil.DisplayMeterToDistance(3) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05

</details>

**Buffs**

**Buff `BackstepBuf`**
- `Value` = `0` _(when BuffEffectActive eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |

- Buff fields set in the constructor (all recovered):
  - `attackRate` = `((Lv << 2) + lv)` → Lv1..10 [5, 10, 15, 20, 25, 30, 35, 40, 45, 50]
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:BackstepBuf$$.ctor<-BackstepAction$$ActionStart` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

---

### เซียรัม (Sierram) · uid 996

<img src="../../icons/sk_996.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 2) · **Type:** Support · **Max Lv:** 35 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** อีเวชัน · **Flags:** NoMarketSearch, MercenaryCanUseSkill · **Client class:** `SierramAction`

> สกิลระงับความเจ็บปวด
> จะลดความเสียหายที่มีอย่างต่อเนื่องของพิษและไหม้ไฟชั่วระยะเวลาหนึ่ง

<details><summary>In-game level notes</summary>

- Lv18: [จะได้รับผลแบบเดียวกันเมื่อใช้คัมภีร์นินจูตสึ] *ระยะเวลาแสดงผล x3

</details>

**Role:** buff (self) · buff (party / others)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `0` = 0

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 996

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `CastTime` = `0` = 0

**`ActionHit`** (2 paths)

- calls `SierramBuf..ctor` = `.ctor(Lv, 0, EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator))` — when UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.AddBuffer` = `AddBuffer(new SierramBuf, 0)` — when UnityEngine.Object.op_Inequality(actarAction)

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

</details>

**Buffs**

**Buff `SierramBuf`**
- Duration: `((Lv + 10) * 3)` s [subWeapon == NinjutsuBook OR subWeapon != NinjutsuBook AND subWeapon == ShortSword]; `(Lv + 10)` s [subWeapon != NinjutsuBook AND subWeapon != ShortSword]

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 27 | 30 | 32 | 35 | 37 | 40 | 42 | 45 | 47 | 50 |
| Value2 | 12 | 14 | 16 | 18 | 20 | 22 | 24 | 26 | 28 | 30 |

- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `BuffEffectActive` = `1` = 1 when subWeapon == NinjutsuBook OR subWeapon != NinjutsuBook AND subWeapon != ShortSword OR subWeapon != NinjutsuBook AND subWeapon == ShortSword
  - `BufEffectTakeUid` = `-1` = -1 when subWeapon == NinjutsuBook OR subWeapon != NinjutsuBook AND subWeapon != ShortSword OR subWeapon != NinjutsuBook AND subWeapon == ShortSword
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] when subWeapon == NinjutsuBook OR subWeapon != NinjutsuBook AND subWeapon != ShortSword OR subWeapon != NinjutsuBook AND subWeapon == ShortSword
  - `IsSelfAction` = `(self & 1)` when subWeapon == NinjutsuBook OR subWeapon != NinjutsuBook AND subWeapon != ShortSword OR subWeapon != NinjutsuBook AND subWeapon == ShortSword
  - `reducePoisonDamage` = `int(((Lv * 2.5) + 25))` → Lv1..10 [27, 30, 32, 35, 37, 40, 42, 45, 47, 50] when subWeapon == NinjutsuBook OR subWeapon != NinjutsuBook AND subWeapon != ShortSword OR subWeapon != NinjutsuBook AND subWeapon == ShortSword
  - `reduceIgnitionDamage` = `((Lv << 1) + 10)` → Lv1..10 [12, 14, 16, 18, 20, 22, 24, 26, 28, 30] when subWeapon == NinjutsuBook OR subWeapon != NinjutsuBook AND subWeapon != ShortSword OR subWeapon != NinjutsuBook AND subWeapon == ShortSword
  - `isViewSelfIcon` = `(self & 1)` when subWeapon == NinjutsuBook OR subWeapon != NinjutsuBook AND subWeapon != ShortSword OR subWeapon != NinjutsuBook AND subWeapon == ShortSword
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
- Hook `SetViewSelfIcon`: `isViewSelfIcon`=(flag & 1)

---

### พิษกัดกร่อน (CorrosivePoison) · uid 1002

<img src="../../icons/sk_1002.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 35 · **Weapons:** ShortSword, NinjutsuScroll, MainHand · **Requires:** เวนอมอินเจค · **Flags:** NoMarketSearch · **Client class:** `CorrosivePoison` (passive mastery)

> เวนอมอินเจคทำให้เพิ่มพิษร้ายซ้อนกันได้
> ถ้าเพิ่มพิษร้ายโดยการซ้อน(สูงสุด+2)
> การโจมตีของผู้เล่นอาจทำให้
> เกิดความเสียหายจากพิษร้ายได้ด้วย

**Role:** passive mastery

<details><summary>Effect applied in `CorrosivePoison$$CalcCorrosivePoison` (9 guarded paths)</summary>

- when `(AbnormalStateManager.TryGetAbnormalStateData(EnemyMobActionManagerBase.get_AbnormalStateManager(mobAction, 0, damageData, poisonType), 5, stkp(-56), 0) & 1) ne 0` AND `TryGetAbnormalStateData.out2() ne 0` AND `SkillLv(1002) ge 1` AND `SkillLv(1002) ne 1`
  - returns `1`
  - calls `EnemyMobActionManagerBase$$get_AbnormalStateManager`, `AbnormalStateManager$$TryGetAbnormalStateData`, `AbnormalPoisonData$$CheckMaxPoisonLevel`, `AbnormalPoisonData$$get_PoisonLevel`, `VenomInjectAction$$CalcPercent`, `UnityEngine.Random$$Range`, `AbnormalPoisonData$$get_PoisonLevel`, `AbnormalPoisonData$$get_PoisonLevel`
- when `(AbnormalStateManager.TryGetAbnormalStateData(EnemyMobActionManagerBase.get_AbnormalStateManager(mobAction, 0, damageData, poisonType), 5, stkp(-56), 0) & 1) ne 0` AND `TryGetAbnormalStateData.out2() ne 0` AND `SkillLv(1002) ge 1` AND `SkillLv(1002) ne 1`
  - returns `0`
  - calls `EnemyMobActionManagerBase$$get_AbnormalStateManager`, `AbnormalStateManager$$TryGetAbnormalStateData`, `AbnormalPoisonData$$CheckMaxPoisonLevel`, `AbnormalPoisonData$$get_PoisonLevel`, `VenomInjectAction$$CalcPercent`, `UnityEngine.Random$$Range`, `AbnormalPoisonData$$get_PoisonLevel`, `AbnormalPoisonData$$get_PoisonLevel`
- when `(AbnormalStateManager.TryGetAbnormalStateData(EnemyMobActionManagerBase.get_AbnormalStateManager(mobAction, 0, damageData, poisonType), 5, stkp(-56), 0) & 1) ne 0` AND `TryGetAbnormalStateData.out2() ne 0` AND `SkillLv(1002) ge 1` AND `SkillLv(1002) ne 1`
  - returns `1`
  - calls `EnemyMobActionManagerBase$$get_AbnormalStateManager`, `AbnormalStateManager$$TryGetAbnormalStateData`, `AbnormalPoisonData$$CheckMaxPoisonLevel`, `AbnormalPoisonData$$get_PoisonLevel`, `VenomInjectAction$$CalcPercent`, `UnityEngine.Random$$Range`, `AbnormalPoisonData$$get_PoisonLevel`
- when `(AbnormalStateManager.TryGetAbnormalStateData(EnemyMobActionManagerBase.get_AbnormalStateManager(mobAction, 0, damageData, poisonType), 5, stkp(-56), 0) & 1) ne 0` AND `TryGetAbnormalStateData.out2() ne 0` AND `SkillLv(1002) ge 1` AND `SkillLv(1002) ne 1`
  - returns `0`
  - calls `EnemyMobActionManagerBase$$get_AbnormalStateManager`, `AbnormalStateManager$$TryGetAbnormalStateData`, `AbnormalPoisonData$$CheckMaxPoisonLevel`, `AbnormalPoisonData$$get_PoisonLevel`, `VenomInjectAction$$CalcPercent`, `UnityEngine.Random$$Range`
- when `(AbnormalStateManager.TryGetAbnormalStateData(EnemyMobActionManagerBase.get_AbnormalStateManager(mobAction, 0, damageData, poisonType), 5, stkp(-56), 0) & 1) ne 0` AND `TryGetAbnormalStateData.out2() ne 0` AND `SkillLv(1002) ge 1` AND `SkillLv(1002) eq 1`
  - returns `1`
  - calls `EnemyMobActionManagerBase$$get_AbnormalStateManager`, `AbnormalStateManager$$TryGetAbnormalStateData`, `AbnormalPoisonData$$CheckMaxPoisonLevel`, `AbnormalPoisonData$$get_PoisonLevel`, `VenomInjectAction$$CalcPercent`, `UnityEngine.Random$$Range`, `AbnormalPoisonData$$get_PoisonLevel`, `AbnormalPoisonData$$get_PoisonLevel`
- when `(AbnormalStateManager.TryGetAbnormalStateData(EnemyMobActionManagerBase.get_AbnormalStateManager(mobAction, 0, damageData, poisonType), 5, stkp(-56), 0) & 1) ne 0` AND `TryGetAbnormalStateData.out2() ne 0` AND `SkillLv(1002) ge 1` AND `SkillLv(1002) eq 1`
  - returns `0`
  - calls `EnemyMobActionManagerBase$$get_AbnormalStateManager`, `AbnormalStateManager$$TryGetAbnormalStateData`, `AbnormalPoisonData$$CheckMaxPoisonLevel`, `AbnormalPoisonData$$get_PoisonLevel`, `VenomInjectAction$$CalcPercent`, `UnityEngine.Random$$Range`, `AbnormalPoisonData$$get_PoisonLevel`, `AbnormalPoisonData$$get_PoisonLevel`
- when `(AbnormalStateManager.TryGetAbnormalStateData(EnemyMobActionManagerBase.get_AbnormalStateManager(mobAction, 0, damageData, poisonType), 5, stkp(-56), 0) & 1) ne 0` AND `TryGetAbnormalStateData.out2() ne 0` AND `SkillLv(1002) ge 1` AND `SkillLv(1002) eq 1`
  - returns `1`
  - calls `EnemyMobActionManagerBase$$get_AbnormalStateManager`, `AbnormalStateManager$$TryGetAbnormalStateData`, `AbnormalPoisonData$$CheckMaxPoisonLevel`, `AbnormalPoisonData$$get_PoisonLevel`, `VenomInjectAction$$CalcPercent`, `UnityEngine.Random$$Range`, `AbnormalPoisonData$$get_PoisonLevel`
- when `(AbnormalStateManager.TryGetAbnormalStateData(EnemyMobActionManagerBase.get_AbnormalStateManager(mobAction, 0, damageData, poisonType), 5, stkp(-56), 0) & 1) ne 0` AND `TryGetAbnormalStateData.out2() ne 0` AND `SkillLv(1002) ge 1` AND `SkillLv(1002) eq 1`
  - returns `0`
  - calls `EnemyMobActionManagerBase$$get_AbnormalStateManager`, `AbnormalStateManager$$TryGetAbnormalStateData`, `AbnormalPoisonData$$CheckMaxPoisonLevel`, `AbnormalPoisonData$$get_PoisonLevel`, `VenomInjectAction$$CalcPercent`, `UnityEngine.Random$$Range`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `CorrosivePoison$$CalcCorrosivePoison (GetSkillLv)`

---

### ฟูเนวินเด (FuneVinte) · uid 997

<img src="../../icons/sk_997.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 3) · **Type:** Attack · **Max Lv:** 125 · **Weapons:** ShortSword, NinjutsuScroll · **Requires:** แบ็คสเต็ป · **Flags:** NoMarketSearch, MercenaryCanUseSkill · **Client class:** `FuneVinteAction`

> แก่นแท้สกิลของกลุ่มนักฆ่าที่สืบทอดต่อกันมา
> ใช้ MP ทั้งหมดเพื่อโจมตีเป้าหมาย
> เพิ่มปริมาณการฟื้นฟู MP สูงขึ้นจนกว่าจะใช้สกิลถัดไป
> ถ้าไม่ถูกเล็งเป้าเฮทของตัวเองจะลดน้อยลงเป็นอย่างมาก

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 550 | 600 | 650 | 700 | 750 | 800 | 850 | 900 | 950 | 1000 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv + (Lv << 2)) << 1) + ((PlayerAttackBase.get_Mp() // 100) * ((int((AssassinationSecrets.GetFuneVinteMpSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1), PlayerActionManagerBase.get_PlayerStatus()))) + 60) + (Lv << 2))))) / 100)` — !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction)
- SkillRate × `(((((Lv + (Lv << 2)) << 1) + ((PlayerAttackBase.get_Mp() // 100) * ((int((AssassinationSecrets.GetFuneVinteMpSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1), PlayerActionManagerBase.get_PlayerStatus()))) + 60) + (Lv << 2))))) / 100)` — !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND UnityEngine.Object.op_Inequality(actarAction)

**Role:** attack (deals damage) · buff (self)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv * 50) + 500))`
- `SkillRate` multiplies by (adds into): `(((((Lv + (Lv << 2)) << 1) + ((PlayerAttackBase.get_Mp() // 100) * ((int((AssassinationSecrets.GetFuneVinteMpSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1), PlayerActionManagerBase.get_PlayerStatus()))) + 60) + (Lv << 2))))) / 100)`

**Mechanics recovered from code**

- **MP cost** (`mp`): `PlayerAttackBase.CalcCostMp(this, actarAction)`; `0` = 0 _(when comboType eq 4)_; `0` = 0 _(when (SkillComboState.get_CurrentComboType(_currentSkillCombo) & 255) eq 4)_
- **MP cost** (`costMp`): `PlayerAttackBase.CalcCostMp(this, actarAction)`; `0` = 0 _(when comboType eq 4)_; `0` = 0 _(when (SkillComboState.get_CurrentComboType(_currentSkillCombo) & 255) eq 4)_
- **Loop / hit-repeat count** (`LoopParam`): `int((MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)) * 100))`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 997

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(3)`
- set `fixAddDamage` = `((Lv * 50) + 500)` → Lv1..10: [550, 600, 650, 700, 750, 800, 850, 900, 950, 1000]
- set `mp` = `PlayerAttackBase.CalcCostMp(this, actarAction)`
- set `costMp` = `PlayerAttackBase.CalcCostMp(this, actarAction)`

**`SetComboType`** (2 paths)

- set `mp` = `0` = 0 — when comboType eq 4
- set `costMp` = `0` = 0 — when comboType eq 4

**`ActionPreparation`** (8 paths)

- set `targetDeadlyPoison` = `(MobBuffManager.Contains(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target)), 14) & 1)` — when !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND UnityEngine.Object.op_Inequality(actarAction)
- set `skillRate` = `(((Lv + (Lv << 2)) << 1) + ((PlayerAttackBase.get_Mp() // 100) * ((int((AssassinationSecrets.GetFuneVinteMpSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1), PlayerActionManagerBase.get_PlayerStatus()))) + 60) + (Lv << 2))))` — when !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction)
- set `skillRate` = `(((Lv + (Lv << 2)) << 1) + ((PlayerAttackBase.get_Mp() // 100) * (60 + (Lv << 2))))` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND UnityEngine.Object.op_Inequality(actarAction)

**`ActionStart`** (12 paths)

- set `moveDir` = `((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) / fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))))` — when PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 OR !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND PlayerAttackBase.IsBlank(this) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05
- set `moveDir.y` = `((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) / fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))))` — when PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 OR !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND PlayerAttackBase.IsBlank(this) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05
- set `moveDir.z` = `((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) / fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))))` — when PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 OR !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND PlayerAttackBase.IsBlank(this) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05
- set `LoopParam` = `int((MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)) * 100))`
- calls `FuneVinteBuf..ctor` = `.ctor(Lv)` — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) le 1e-05
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new FuneVinteBuf, Id)` — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) le 1e-05
- set `moveDir` = `UnityEngine.Vector3.static+0x0` — when PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) le 1e-05 OR !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND PlayerAttackBase.IsBlank(this) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) le 1e-05 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) le 1e-05
- set `moveDir.y` = `UnityEngine.Vector3.static+0x4` — when PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) le 1e-05 OR !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND PlayerAttackBase.IsBlank(this) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) le 1e-05 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) le 1e-05
- set `moveDir.z` = `UnityEngine.Vector3.static+0x8` — when PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) le 1e-05 OR !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND PlayerAttackBase.IsBlank(this) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) le 1e-05 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) le 1e-05

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1
- set `moveDir` = `UnityEngine.Vector3.static+0x0`
- set `moveDir.y` = `UnityEngine.Vector3.static+0x4`
- set `moveDir.z` = `UnityEngine.Vector3.static+0x8`

**`calcPlayerToMobDamage`** (2 paths)

- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction)`
- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- info `templates` = `1`

**`RecalcCostMp`** (2 paths)

- set `mp` = `0` = 0 — when (SkillComboState.get_CurrentComboType(_currentSkillCombo) & 255) eq 4
- set `costMp` = `0` = 0 — when (SkillComboState.get_CurrentComboType(_currentSkillCombo) & 255) eq 4
- set `mp` = `PlayerAttackBase.CalcCostMp(this, playerAction)` — when (SkillComboState.get_CurrentComboType(_currentSkillCombo) & 255) ne 4
- set `costMp` = `PlayerAttackBase.CalcCostMp(this, playerAction)` — when (SkillComboState.get_CurrentComboType(_currentSkillCombo) & 255) ne 4

</details>

**Buffs**

**Buff `FuneVinteBuf`**
- `AttackMprecoveryUp` = `0` _(when BuffEffectActive eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| AttackMprecoveryUp | 10 | 10 | 10 | 10 | 10 | 20 | 20 | 20 | 20 | 20 |

- Buff fields set in the constructor (all recovered):
  - `atkMpRecovery` = `(Lv hi 5 ? 20 : 10)` → Lv1..10 [10, 10, 10, 10, 10, 20, 20, 20, 20, 20]
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:FuneVinteBuf$$.ctor<-FuneVinteAction$$ActionStart` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

<details><summary>Effect applied in `PlayerAttackBase$$RemoveAfterSkillBuf` (300 guarded paths, truncated)</summary>

- when `TryGetValue.out2() ne 0` AND `PlayerAttackBase.get_ActionID() ne 517`
  - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 1129, 0, ?x3)`
  - set `_motionSpeed` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `appliedQuicklyMotionSpeedValue` = `255`
  - set `appliedQuicklyType` = `(((appliedQuicklyType | 2) | 16) | 8)`
  - calls `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$ContainsNotApplicableSkill`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `virtual PlayerAttackBase.get_ActionID`
- when `TryGetValue.out2() ne 0` AND `PlayerAttackBase.get_ActionID() ne 517`
  - returns `SkillBufferManager.TryGetBuf(?blr, 1129, stkp(-88), 0)`
  - set `_motionSpeed` = `((SkillActionBase.get_MotionSpeed(this, 0, ?mi, ?x3) - CharacterActionManagerBase.set_DefaultMoveSpeed()) gt 50 ? (SkillActionBase.get_MotionSpeed(this, 0, ?mi, ?x3) - CharacterActionManagerBase.set_DefaultMoveSpeed()) : 50)`
  - set `appliedQuicklyMotionSpeedValue` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `appliedQuicklyType` = `((appliedQuicklyType | 2) | 16)`
  - calls `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$ContainsNotApplicableSkill`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `virtual PlayerAttackBase.get_ActionID`
- when `TryGetValue.out2() ne 0` AND `PlayerAttackBase.get_ActionID() ne 517`
  - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 1129, 0, ?x3)`
  - set `_motionSpeed` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `appliedQuicklyMotionSpeedValue` = `255`
  - set `appliedQuicklyType` = `(((appliedQuicklyType | 2) | 16) | 8)`
  - calls `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$ContainsNotApplicableSkill`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `virtual PlayerAttackBase.get_ActionID`
- when `TryGetValue.out2() ne 0` AND `PlayerAttackBase.get_ActionID() ne 517`
  - returns `SkillBufferManager.TryGetBuf(?blr, 1129, stkp(-88), 0)`
  - set `_motionSpeed` = `((SkillActionBase.get_MotionSpeed(this, 0, ?mi, ?x3) - CharacterActionManagerBase.set_DefaultMoveSpeed()) gt 50 ? (SkillActionBase.get_MotionSpeed(this, 0, ?mi, ?x3) - CharacterActionManagerBase.set_DefaultMoveSpeed()) : 50)`
  - set `appliedQuicklyMotionSpeedValue` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `appliedQuicklyType` = `((appliedQuicklyType | 2) | 16)`
  - calls `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$ContainsNotApplicableSkill`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `virtual PlayerAttackBase.get_ActionID`
- when `TryGetValue.out2() ne 0` AND `PlayerAttackBase.get_ActionID() ne 517`
  - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 1129, 0, ?x3)`
  - set `_motionSpeed` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `appliedQuicklyMotionSpeedValue` = `255`
  - set `appliedQuicklyType` = `(((appliedQuicklyType | 2) | 16) | 8)`
  - calls `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$ContainsNotApplicableSkill`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `virtual PlayerAttackBase.get_ActionID`
- when `TryGetValue.out2() ne 0` AND `PlayerAttackBase.get_ActionID() ne 517`
  - returns `SkillBufferManager.TryGetBuf(?blr, 1129, stkp(-88), 0)`
  - set `_motionSpeed` = `((SkillActionBase.get_MotionSpeed(this, 0, ?mi, ?x3) - CharacterActionManagerBase.set_DefaultMoveSpeed()) gt 50 ? (SkillActionBase.get_MotionSpeed(this, 0, ?mi, ?x3) - CharacterActionManagerBase.set_DefaultMoveSpeed()) : 50)`
  - set `appliedQuicklyMotionSpeedValue` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `appliedQuicklyType` = `((appliedQuicklyType | 2) | 16)`
  - calls `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$ContainsNotApplicableSkill`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `virtual PlayerAttackBase.get_ActionID`
- when `TryGetValue.out2() ne 0` AND `PlayerAttackBase.get_ActionID() ne 517`
  - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 1129, 0, ?x3)`
  - set `_motionSpeed` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `appliedQuicklyMotionSpeedValue` = `255`
  - set `appliedQuicklyType` = `(((appliedQuicklyType | 2) | 16) | 8)`
  - calls `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$ContainsNotApplicableSkill`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `virtual PlayerAttackBase.get_ActionID`
- when `TryGetValue.out2() ne 0` AND `PlayerAttackBase.get_ActionID() ne 517`
  - returns `SkillBufferManager.TryGetBuf(?blr, 1129, stkp(-88), 0)`
  - set `_motionSpeed` = `((SkillActionBase.get_MotionSpeed(this, 0, ?mi, ?x3) - CharacterActionManagerBase.set_DefaultMoveSpeed()) gt 50 ? (SkillActionBase.get_MotionSpeed(this, 0, ?mi, ?x3) - CharacterActionManagerBase.set_DefaultMoveSpeed()) : 50)`
  - set `appliedQuicklyMotionSpeedValue` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `appliedQuicklyType` = `((appliedQuicklyType | 2) | 16)`
  - calls `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$ContainsNotApplicableSkill`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `virtual PlayerAttackBase.get_ActionID`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `PlayerAttackBase$$RemoveAfterSkillBuf (ContainsBuffer)`

---

### ละทิ้ง (Abandonment) · uid 998

<img src="../../icons/sk_998.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 125 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เซียรัม · **Flags:** NoMarketSearch · **Client class:** `Abandonment` (passive mastery)

> เพิ่มความสามารถในการหลบหลีกของตัวเองจนเกินขีดจำกัด
> ลดความแม่นที่มีของมอนสเตอร์ลงต่ำสุด
> ทำให้หลบหลีกได้ดีกว่าเดิม
> เพิ่มพลังของแอสแซสซินสแทบ

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| LastDmgRate | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |
| Hit | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


---

### เวนอมสแนทช (VenomSnatch) · uid 1003

<img src="../../icons/sk_1003.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 3) · **Type:** Attack · **Max Lv:** 125 · **Weapons:** ShortSword, NinjutsuScroll, MainHand · **Requires:** พิษกัดกร่อน · **Flags:** NoMarketSearch · **Client class:** `VenomSnatchAction`

> ช่วงชิงพิษกัดกร่อนเป้าหมาย
> ฟื้นฟู HP และสถานะพิษของตัวเอง
> 
> ถ้าเป็นพิษร้ายที่อัพเกรดจะฟื้นฟู MP ด้วย
> ถ้าไม่มีพิษที่สามารถกำจัดออกจาก
> ตัวเองได้จะได้รับผลการป้องกัน

**Role:** buff (self)

This action never changes monster proration: IsExpDefFluctuate=false.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Effect radius (Unity units)** (`Radius`): `MathUtil.DisplayMeterToDistance(12)`

**Proration:** slot `none`, mode `never (IsExpDefFluctuate=false)`, attack type `None`, action id 1003

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `Radius` = `MathUtil.DisplayMeterToDistance(12)`
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`

**`ActionPreparation`** (1 path)

- set `mainTarget` = `UnityEngine.GameObject.get_transform(target)`

**`CheckCollectionAbnormalPoisonTarget`** (4 paths)

- set `collectingPoisonTarget` = `UnityEngine.GameObject.GetComponent<MobActionManagerBase>(actorAction.battleManager.mainTargetData.Target)` — when AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(actorAction.battleManager.mainTargetData.Target)), 5) AND UnityEngine.Object.op_Inequality(actorAction.battleManager.mainTargetData.Target) OR !AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(actorAction.battleManager.mainTargetData.Target)), 5) AND AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(actorAction.battleManager.mainTargetData.Target)), 248) AND UnityEngine.Object.op_Inequality(actorAction.battleManager.mainTargetData.Target)
- set `+0x12c` = `0` = 0
- set `collectingPoisonTarget` = `0` = 0 — when !UnityEngine.Object.op_Inequality(actorAction.battleManager.mainTargetData.Target) OR !AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(actorAction.battleManager.mainTargetData.Target)), 248) AND !AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(actorAction.battleManager.mainTargetData.Target)), 5) AND UnityEngine.Object.op_Inequality(actorAction.battleManager.mainTargetData.Target)

**`BattleResult`** (17 paths)

- calls `VenomSnatchAction.CalcHpHealValue` = `CalcHpHealValue(PlayerActionManagerBase.get_PlayerStatus(), ?ubfx)` — when (flag & 255) eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND VenomSnatchAction.CalcHpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) ge 1 AND VenomSnatchAction.CalcMpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) ge 1 OR (flag & 255) eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) lt 1 AND VenomSnatchAction.CalcHpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) ge 1 AND VenomSnatchAction.CalcMpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) ge 1 OR (flag & 255) eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND VenomSnatchAction.CalcHpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) ge 1 AND VenomSnatchAction.CalcMpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) lt 1
- calls `VenomSnatchAction.CalcMpHealValue` = `CalcMpHealValue(PlayerActionManagerBase.get_PlayerStatus(), ?ubfx)` — when (flag & 255) eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND VenomSnatchAction.CalcHpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) ge 1 AND VenomSnatchAction.CalcMpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) ge 1 OR (flag & 255) eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) lt 1 AND VenomSnatchAction.CalcHpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) ge 1 AND VenomSnatchAction.CalcMpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) ge 1 OR (flag & 255) eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND VenomSnatchAction.CalcHpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) ge 1 AND VenomSnatchAction.CalcMpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) lt 1
- calls `VenomSnatchBuf..ctor` = `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), ?ubfx)` — when (flag & 255) eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND VenomSnatchAction.CalcHpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) ge 1 AND VenomSnatchAction.CalcMpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) ge 1 OR (flag & 255) eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND VenomSnatchAction.CalcHpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) ge 1 AND VenomSnatchAction.CalcMpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) lt 1 OR (flag & 255) eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND VenomSnatchAction.CalcHpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) lt 1 AND VenomSnatchAction.CalcMpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) ge 1
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new VenomSnatchBuf, 0)` — when (flag & 255) eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND VenomSnatchAction.CalcHpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) ge 1 AND VenomSnatchAction.CalcMpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) ge 1 OR (flag & 255) eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND VenomSnatchAction.CalcHpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) ge 1 AND VenomSnatchAction.CalcMpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) lt 1 OR (flag & 255) eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND VenomSnatchAction.CalcHpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) lt 1 AND VenomSnatchAction.CalcMpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) ge 1

**`GiveVaccinations`** (5 paths)

- calls `SkillBufferManager.RemoveBuffer` = `RemoveBuffer(231)` — when (TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 231).effectType - 1) ls 1 AND RecoveryBuf.CreateVenomSnatchBuf(poisonLevel).LeftTime gt TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 231).LeftTime AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 231) ne 0
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(RecoveryBuf.CreateVenomSnatchBuf(poisonLevel), 0)`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

</details>

**Buffs**

**Buff `VenomSnatchBuf`**
- `Value` = `(poisonLevel)` _(when BuffEffectActive ne 0)_
- `Value` = `CountBufferBase.GetParam(this, id)` _(when BuffEffectActive eq 0)_
- Buff fields set in the constructor (all recovered):
  - `poisonLevel` = `poisonLevel`
  - `Count` = `poisonLevel`
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:VenomSnatchBuf$$.ctor<-VenomSnatchAction$$BattleResult` (no direct constructor call in the skill's own code).
- Buff hook methods: `Next`, `NextSkip`, `Prev`, `PrevSkip`, `get_Count`, `get_Max`, `get_Peak`, `set_Count`, `set_Max`
- `Count` = `(0)`
- Buff fields set in the constructor (all recovered):
  - `Count` = `0`
  - `Max` = `max`
- Hook `set_Count`: `Count`=value
- Hook `set_Max`: `Max`=value
- Hook `Next`: `Count`=System.Math.Min((Count + 1), Max)
- Hook `NextSkip`: `Count`=System.Math.Min((Count + count), Max)
- Hook `Prev`: `Count`=System.Math.Max((Count - 1), 0)
- Hook `PrevSkip`: `Count`=System.Math.Max((Count - count), 0)

<details><summary>Effect applied in `DeathReceptionAction$$IsFailure` (2 guarded paths)</summary>

- always
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
- always
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`

</details>

<details><summary>Effect applied in `VenomSnatchAction$$BattleResult` (17 guarded paths)</summary>

- when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) ge 1`
  - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryHp`, `Singleton<object>$$get_Instance`
- when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) lt 1`
  - returns `SkillLv(1004)`
  - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryHp`, `Singleton<object>$$get_Instance`
- when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) ge 1`
  - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryHp`, `0x165db78`
- when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) lt 1`
  - returns `SkillLv(1004)`
  - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryHp`
- when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) ge 1`
  - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryMp`, `0x165db78`
- when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) lt 1`
  - returns `SkillLv(1004)`
  - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryMp`
- when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) ge 1`
  - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `0x165db78`, `VenomSnatchBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
- when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) lt 1`
  - returns `SkillLv(1004)`
  - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `DeathReceptionAction$$IsFailure (ContainsBuffer)`
- `VenomSnatchAction$$BattleResult (GetSkillLv)`

---

### ซิคาเรียส (Seekerius) · uid 999

<img src="../../icons/sk_999.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 4) · **Type:** Mastery · **Max Lv:** 205 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** แบ็คสเต็ป · **Flags:** NoMarketSearch · **Client class:** `Seekerius` (passive mastery)

> เพิ่มพลังของแบ็คสแทบแบบถาวร
> นอกจากนี้ถ้าใช้แบ็คสแทบสำเร็จ
> เมื่อได้รับความเสียหายจากATKและอาวุธเจาะเข้าที่อัพเกรดขึ้นเล็กน้อย
> จะทำให้บรรเทาลงและการอัพเกรดจะสิ้นสุด

**Role:** buff (self) · passive mastery

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| LastDmgRate | 15 | 30 | 45 | 60 | 75 | 90 | 105 | 120 | 135 | 150 |


**Buffs**

**Buff `SeekeriusBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `30` s
- `Value` = `int(((rate) * 100))`
- `MobLastDamageRateBuf` = `(int(((Lv + 10) * rate)))`

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| AtkUp | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |
| PowerResistBreaker | 16 | 17 | 18 | 19 | 20 | 21 | 22 | 23 | 24 | 25 |

- Buff fields set in the constructor (all recovered):
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
  - `stubRate` = `rate`
  - `damageCut` = `int(((Lv + 10) * rate))`
  - `IsDamageCancel` = `1` = 1
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `atkUp` = `((Lv + (Lv << 2)) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100] when val eq 1
  - `atkUp` = `((Lv << 2) + lv)` → Lv1..10 [5, 10, 15, 20, 25, 30, 35, 40, 45, 50] when val ne 1
  - `powerResistBreaker` = `(Lv + 15)` → Lv1..10 [16, 17, 18, 19, 20, 21, 22, 23, 24, 25] when val eq 1
  - `powerResistBreaker` = `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] when val ne 1
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

---

### ชาโดว์วอล์ค (ShadowWalk) · uid 1000

<img src="../../icons/sk_1000.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 4) · **Type:** Buffer · **Max Lv:** 205 · **Weapons:** ShortSword, NinjutsuScroll · **Requires:** ละทิ้ง · **Flags:** NoMarketSearch · **Client class:** `ShadowWalkAction`

> ถ้าตัวเองไม่ได้ถูกเล็งเป็นเป้าหมายในระยะเวลาสั้นๆ
> ผลการโจมตีเพิ่มจะเปลี่ยนตาม Avoid (ระยะยิงขึ้นอยู่กับอาวุธ)
> การโจมตีเพิ่มจะถูกอัพเกรดด้วยการกระทำที่เจาะจงแต่ถ้าได้รับ
> ความเสียหายขณะถูกเล็งการอัพเกรดจะถูกรีเซ็ตและไม่สามารถใช้งานได้อีก

<details><summary>In-game level notes</summary>

- Lv18: [จะได้รับผลแบบเดียวกันเมื่อใช้คัมภีร์นินจูตสึ] จะอัพเกรดเพิ่มการโจมตีเมื่อใช้ Avoid, แอสแซสซินสแทบ แบ็คสเต็ป (เฉพาะที่สำเร็จ)  ถ้าค่าอัพเกรดตั้งแต่ 10 ขึ้นไป เมื่อได้รับความเสียหายระหว่าง Avoid จะใช้ค่าอัพเกรดเพื่ออัพเกรดเพิ่มการโจมตีให้มากขึ้นอีก

</details>

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1000

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (1 path)

- calls `ShadowWalkBuf..ctor` = `.ctor(Lv, actarAction)`
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new ShadowWalkBuf, Id)`

</details>

**Buffs**

**Buff `ShadowWalkBuf`**
- Buff hook methods: `SyncStackCount`, `get_InvincibilityLocalId`, `get_IsInRange`, `get_IsInvalidDamage`, `get_IsManual`, `set_InvincibilityLocalId`, `set_IsInRange`, `set_IsInvalidDamage`, `set_IsManual`
- Buff fields set in the constructor (all recovered):
  - `playerAction` = `player`
- Hook `set_IsInvalidDamage`: `IsInvalidDamage`=(value & 1)
- Hook `set_IsInRange`: `IsInRange`=(value & 1)
- Hook `set_IsManual`: `IsManual`=(value & 1)
- Hook `set_InvincibilityLocalId`: `InvincibilityLocalId`=value
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
- Hook `SyncStackCount`: `Count`=(stack lt 0 ? 0 : (Max lt stack ? Max : stack))
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:ShadowWalkBuf$$.ctor<-ShadowWalkAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `Next`, `NextSkip`, `Prev`, `PrevSkip`, `get_Count`, `get_Max`, `get_Peak`, `set_Count`, `set_Max`
- `Count` = `(0)`
- Buff fields set in the constructor (all recovered):
  - `Count` = `0`
  - `Max` = `max`
- Hook `set_Count`: `Count`=value
- Hook `set_Max`: `Max`=value
- Hook `Next`: `Count`=System.Math.Min((Count + 1), Max)
- Hook `NextSkip`: `Count`=System.Math.Min((Count + count), Max)
- Hook `Prev`: `Count`=System.Math.Max((Count - 1), 0)
- Hook `PrevSkip`: `Count`=System.Math.Max((Count - count), 0)

<details><summary>Effect applied in `MobaPlayerActionManager$$ReceiveDamaged` (297 guarded paths, truncated)</summary>

- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `UnityEngine.Object.op_Inequality([[battleManager+0x48]+0x20], 0, 0, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `BattleManagerBase.TargetData.SetTarget([battleManager+0x58], UnityEngine.Component.get_gameObject(otherPlayer, 0, ?x2, ?x3), UnityEngine.Component.GetComponent<object>(otherPlayer, meta(0x3982c60, Method$UnityEngine.Component.GetComponent<CharacterActionManagerBase>()), ?x2, ?x3), 0)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `MobaDuelAbilityManager.ContaintsAbility([playerStatus+0x90], 27, 0, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `UnityEngine.Object.op_Inequality([[battleManager+0x48]+0x20], 0, 0, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `BattleManagerBase.TargetData.SetTarget([battleManager+0x58], UnityEngine.Component.get_gameObject(otherPlayer, 0, ?x2, ?x3), UnityEngine.Component.GetComponent<object>(otherPlayer, meta(0x3982c60, Method$UnityEngine.Component.GetComponent<CharacterActionManagerBase>()), ?x2, ?x3), 0)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `MobaDuelAbilityManager.ContaintsAbility([playerStatus+0x90], 27, 0, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `UnityEngine.Object.op_Inequality([[battleManager+0x48]+0x20], 0, 0, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `MobaPlayerActionManager$$ReceiveDamaged (TryGetBuf)`

---

### เดธรีเซฟชัน (DeathReception) · uid 1004

<img src="../../icons/sk_1004.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 4) · **Type:** Attack · **Max Lv:** 205 · **Weapons:** ShortSword, NinjutsuScroll, MainHand · **Requires:** เวนอมสแนทช · **Flags:** NoMarketSearch · **Client class:** `DeathReceptionAction`

> ใช้พิษที่ช่วงชิงมาด้วยเวนอมสแนทชจะสร้าง
> ความเสียหายและดีบัฟพิษร้ายแก่เป้าหมาย
> นอกจากนี้จะสร้างความเสียหายเพิ่มเติม
> ก่อให้เกิดพิษต่อพื้นที่โดยรอบขึ้นอยู่กับพิษที่ใช้

<details><summary>In-game level notes</summary>

- Lv10: *พลังเพิ่มตามค่า DEX ของตัวเอง *อาวุธเจาะเข้า+25%
- Lv254: *พลังเพิ่มตามเลเวลของตัวเอง *อาวุธเจาะเข้า+25%

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + [UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) eq 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) ne 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction)))] | 30 | 60 | 90 | 120 | 150 | 180 | 210 | 240 | 270 | 300 |
| Flat dmg + [!UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 2 AND poisonLevel ne 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel ne 1 AND poisonLevel ne 2] | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((((((Lv * 25) + 250) + status.Dex) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500))) / 100)` — EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword & UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) eq 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) ne 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction)))
- SkillRate × `((((((Lv * 25) + 250) + status.Dex) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500))) / 100)` — EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword & UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) eq 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) ne 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction)))
- SkillRate × `((((((Lv * 25) + 250) + status.Dex) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500))) / 100)` — EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword & UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) eq 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) ne 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction)))
- SkillRate × `((((((Lv * 25) + 250) + status.Dex) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500))) / 100)` — EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon != OneHandSword & UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) eq 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) ne 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction)))
- SkillRate × `(((((((Lv * 25) + 250) + status.Dex) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500)) * 0.5)) / 100)` — EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword & !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 2 AND poisonLevel ne 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel ne 1 AND poisonLevel ne 2
- SkillRate × `(((((((Lv * 25) + 250) + status.Dex) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500)) * 0.5)) / 100)` — EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword & !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 2 AND poisonLevel ne 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel ne 1 AND poisonLevel ne 2
- SkillRate × `(((((((Lv * 25) + 250) + status.Dex) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500)) * 0.5)) / 100)` — EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword & !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 2 AND poisonLevel ne 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel ne 1 AND poisonLevel ne 2
- SkillRate × `(((((((Lv * 25) + 250) + status.Dex) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500)) * 0.5)) / 100)` — EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon != OneHandSword & !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 2 AND poisonLevel ne 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel ne 1 AND poisonLevel ne 2

**Role:** attack (deals damage) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `((Lv * 30))` | `(0)`
- `SkillRate` multiplies by (adds into): `((((((Lv * 25) + 250) + status.Dex) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500))) / 100)` | `(((((((Lv * 25) + 250) + status.Dex) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500)) * 0.5)) / 100)`

**Mechanics recovered from code**

- **Attack range** (`attackRange`): `MathUtil.DisplayMeterToDistance(8)`
- **Range-dependent multiplier (%)** (`rangeSkillRate`): `(((((Lv * 25) + 250) + status.Dex) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500)) * 0.5)` _(when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword)_; `((((Lv * 25) + 250) + status.Dex) * 0.5)` _(when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword)_; `(((((Lv * 25) + 250) + status.Dex) + (int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function * 0.8)) lt 500 ? int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function * 0.8)) : 500)) * 0.5)` _(when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword)_

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1004

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (12 paths)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(7)`
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `singleSkillRate` = `((((Lv * 25) + 250) + status.Dex) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500))` — when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword
- set `singleConstantDamage` = `(Lv * 30)` → Lv1..10: [30, 60, 90, 120, 150, 180, 210, 240, 270, 300]
- set `attackRange` = `MathUtil.DisplayMeterToDistance(8)`
- set `singleResistBreaker` = `(singleResistBreaker + 25)` — when mainWeapon == Null OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1090) ne 0 AND mainWeapon == Null OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1090) eq 0 AND mainWeapon == Null
- set `rangeConstantDamage` = `0` = 0 — when mainWeapon == Null OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1090) ne 0 AND mainWeapon == Null OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 23 AND mainWeapon != Null AND mainWeapon == Halberd
- set `rangeSkillRate` = `(((((Lv * 25) + 250) + status.Dex) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500)) * 0.5)` — when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword
- set `singleSkillRate` = `(((Lv * 25) + 250) + status.Dex)` — when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword
- set `rangeSkillRate` = `((((Lv * 25) + 250) + status.Dex) * 0.5)` — when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword
- set `singleSkillRate` = `((((Lv * 25) + 250) + status.Dex) + (int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function * 0.8)) lt 500 ? int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function * 0.8)) : 500))` — when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword
- set `rangeSkillRate` = `(((((Lv * 25) + 250) + status.Dex) + (int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function * 0.8)) lt 500 ? int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function * 0.8)) : 500)) * 0.5)` — when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword
- set `singleSkillRate` = `(((Lv * 25) + 250) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500))` — when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon != OneHandSword
- set `rangeSkillRate` = `((((Lv * 25) + 250) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500)) * 0.5)` — when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon != OneHandSword
- set `singleSkillRate` = `((Lv * 25) + 250)` → Lv1..10: [275, 300, 325, 350, 375, 400, 425, 450, 475, 500] — when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon != OneHandSword
- set `rangeSkillRate` = `(((Lv * 25) + 250) * 0.5)` → Lv1..10: [137.5, 150.0, 162.5, 175.0, 187.5, 200.0, 212.5, 225.0, 237.5, 250.0] — when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon != OneHandSword
- set `singleSkillRate` = `(((Lv * 25) + 250) + (int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function * 0.8)) lt 500 ? int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function * 0.8)) : 500))` — when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon != OneHandSword
- set `rangeSkillRate` = `((((Lv * 25) + 250) + (int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function * 0.8)) lt 500 ? int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function * 0.8)) : 500)) * 0.5)` — when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon != OneHandSword
- set `singleSkillRate` = `((((Lv * 25) + 250) + baseAGI) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500))` — when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Null AND mainWeapon == Halberd
- set `rangeSkillRate` = `(((((Lv * 25) + 250) + baseAGI) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500)) * 0.5)` — when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Null AND mainWeapon == Halberd
- set `singleSkillRate` = `(((Lv * 25) + 250) + baseAGI)` — when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Null AND mainWeapon == Halberd
- set `rangeSkillRate` = `((((Lv * 25) + 250) + baseAGI) * 0.5)` — when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Null AND mainWeapon == Halberd
- set `singleSkillRate` = `((((Lv * 25) + 250) + baseAGI) + (int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function * 0.8)) lt 500 ? int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function * 0.8)) : 500))` — when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 23 AND mainWeapon != Null AND mainWeapon == Halberd
- set `rangeSkillRate` = `(((((Lv * 25) + 250) + baseAGI) + (int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function * 0.8)) lt 500 ? int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function * 0.8)) : 500)) * 0.5)` — when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 23 AND mainWeapon != Null AND mainWeapon == Halberd
- set `singleSkillRate` = `((((Lv * 25) + 250) + (status.Lv * 1.25)) + TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1090).Count)` — when TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1090) ne 0 AND mainWeapon == Null
- set `rangeSkillRate` = `(((((Lv * 25) + 250) + (status.Lv * 1.25)) + TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1090).Count) * 0.5)` — when TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1090) ne 0 AND mainWeapon == Null
- set `singleSkillRate` = `(((Lv * 25) + 250) + (status.Lv * 1.25))` — when mainWeapon == Null OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1090) eq 0 AND mainWeapon == Null
- set `rangeSkillRate` = `((((Lv * 25) + 250) + (status.Lv * 1.25)) * 0.5)` — when mainWeapon == Null

**`ActionPreparation`** (8 paths)

- set `mainTarget` = `UnityEngine.GameObject.get_transform(target)`
- set `attackPos.y` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y`
- set `attackPos.z` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z`
- set `actorPlayerAction` = `actarAction` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1007, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1007, 1) lt 1 AND UnityEngine.Object.op_Inequality(actarAction)
- set `singleSkillRate` = `(singleSkillRate + PoisonMixer.GetDeathReceptionSingleAttackSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1007, 1), PlayerActionManagerBase.get_PlayerStatus()))` — when !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1007, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1007, 1) ge 1 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1003) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1007, 1) ge 1 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1003) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `rangeSkillRate` = `(rangeSkillRate + PoisonMixer.GetDeathReceptionRangeAttackSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1007, 1), PlayerActionManagerBase.get_PlayerStatus()))` — when !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1007, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1007, 1) ge 1 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1003) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1007, 1) ge 1 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1003) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `poisonLevel` = `SkillBufferDataBase.GetParam(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1003), 50)` — when !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1007, 1) ge 1 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1003) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1007, 1) lt 1 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1003) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `singleResistBreaker` = `((SkillBufferDataBase.GetParam(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1003), 50) * 25) + singleResistBreaker)` — when !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1007, 1) ge 1 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1003) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1007, 1) lt 1 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1003) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(1003)` — when !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1007, 1) ge 1 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1003) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1007, 1) lt 1 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1003) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)

**`CheckRangeHit`** (21 paths)

- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(5, 100, actorPlayerAction)` — when !FieldManager.get_IsMoRoom(Singleton<FieldManager>.get_Instance()) AND !MobActionManagerBase.get_IsDeadOrLocalDead(UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)) AND !PartyManager.get_IsParty(Singleton<PartyManager>.get_Instance()) AND !UnityEngine.Object.op_Equality(mainTarget, targetTransform) AND (((UnityEngine.Transform.get_position(targetTransform).x - attackPos) * (UnityEngine.Transform.get_position(targetTransform).x - attackPos)) + ((UnityEngine.Transform.get_position(targetTransform).z - attackPos.z) * (UnityEngine.Transform.get_position(targetTransform).z - attackPos.z))) le ((attackRange + size) * (attackRange + size)) AND MobActionManagerBase.HasPlayerHate(UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)) AND PlayerAttackBase.checkAbnormalPercent(this, 5, 100, actorPlayerAction) AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - attackPos.y), size) OR !FieldManager.get_IsMoRoom(Singleton<FieldManager>.get_Instance()) AND !MobActionManagerBase.get_IsDeadOrLocalDead(UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)) AND !PartyManager.get_IsParty(Singleton<PartyManager>.get_Instance()) AND !PlayerAttackBase.checkAbnormalPercent(this, 5, 100, actorPlayerAction) AND !UnityEngine.Object.op_Equality(mainTarget, targetTransform) AND (((UnityEngine.Transform.get_position(targetTransform).x - attackPos) * (UnityEngine.Transform.get_position(targetTransform).x - attackPos)) + ((UnityEngine.Transform.get_position(targetTransform).z - attackPos.z) * (UnityEngine.Transform.get_position(targetTransform).z - attackPos.z))) le ((attackRange + size) * (attackRange + size)) AND MobActionManagerBase.HasPlayerHate(UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)) AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - attackPos.y), size) OR !MobActionManagerBase.get_IsDeadOrLocalDead(UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)) AND !UnityEngine.Object.op_Equality(mainTarget, targetTransform) AND (((UnityEngine.Transform.get_position(targetTransform).x - attackPos) * (UnityEngine.Transform.get_position(targetTransform).x - attackPos)) + ((UnityEngine.Transform.get_position(targetTransform).z - attackPos.z) * (UnityEngine.Transform.get_position(targetTransform).z - attackPos.z))) le ((attackRange + size) * (attackRange + size)) AND FieldManager.get_IsMoRoom(Singleton<FieldManager>.get_Instance()) AND MobActionManagerBase.GetHate(UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)) AND MobActionManagerBase.HasPlayerHate(UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)) AND PlayerAttackBase.checkAbnormalPercent(this, 5, 100, actorPlayerAction) AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - attackPos.y), size)
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(5, VenomInjectAction.CalcPercent(PlayerActionManagerBase.get_PlayerStatus(), (SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, actorPlayerAction, UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)), 6) & 1), (SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, actorPlayerAction, UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)), 4) & 1)), actorPlayerAction)` — when !MobActionManagerBase.GetHate(UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)) AND !MobActionManagerBase.get_IsDeadOrLocalDead(UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)) AND !UnityEngine.Object.op_Equality(mainTarget, targetTransform) AND (((UnityEngine.Transform.get_position(targetTransform).x - attackPos) * (UnityEngine.Transform.get_position(targetTransform).x - attackPos)) + ((UnityEngine.Transform.get_position(targetTransform).z - attackPos.z) * (UnityEngine.Transform.get_position(targetTransform).z - attackPos.z))) le ((attackRange + size) * (attackRange + size)) AND FieldManager.get_IsMoRoom(Singleton<FieldManager>.get_Instance()) AND PlayerAttackBase.checkAbnormalPercent(this, 5, VenomInjectAction.CalcPercent(PlayerActionManagerBase.get_PlayerStatus(), (SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, actorPlayerAction, UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)), 6) & 1), (SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, actorPlayerAction, UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)), 4) & 1)), actorPlayerAction) AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - attackPos.y), size) OR !MobActionManagerBase.GetHate(UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)) AND !MobActionManagerBase.get_IsDeadOrLocalDead(UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)) AND !PlayerAttackBase.checkAbnormalPercent(this, 5, VenomInjectAction.CalcPercent(PlayerActionManagerBase.get_PlayerStatus(), (SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, actorPlayerAction, UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)), 6) & 1), (SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, actorPlayerAction, UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)), 4) & 1)), actorPlayerAction) AND !UnityEngine.Object.op_Equality(mainTarget, targetTransform) AND (((UnityEngine.Transform.get_position(targetTransform).x - attackPos) * (UnityEngine.Transform.get_position(targetTransform).x - attackPos)) + ((UnityEngine.Transform.get_position(targetTransform).z - attackPos.z) * (UnityEngine.Transform.get_position(targetTransform).z - attackPos.z))) le ((attackRange + size) * (attackRange + size)) AND FieldManager.get_IsMoRoom(Singleton<FieldManager>.get_Instance()) AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - attackPos.y), size) OR !FieldManager.get_IsMoRoom(Singleton<FieldManager>.get_Instance()) AND !MobActionManagerBase.GetHate(UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)) AND !MobActionManagerBase.get_IsDeadOrLocalDead(UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)) AND !UnityEngine.Object.op_Equality(mainTarget, targetTransform) AND (((UnityEngine.Transform.get_position(targetTransform).x - attackPos) * (UnityEngine.Transform.get_position(targetTransform).x - attackPos)) + ((UnityEngine.Transform.get_position(targetTransform).z - attackPos.z) * (UnityEngine.Transform.get_position(targetTransform).z - attackPos.z))) le ((attackRange + size) * (attackRange + size)) AND PartyManager.get_IsParty(Singleton<PartyManager>.get_Instance()) AND PlayerAttackBase.checkAbnormalPercent(this, 5, VenomInjectAction.CalcPercent(PlayerActionManagerBase.get_PlayerStatus(), (SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, actorPlayerAction, UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)), 6) & 1), (SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, actorPlayerAction, UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)), 4) & 1)), actorPlayerAction) AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - attackPos.y), size)

**`calcPlayerToMobDamage`** (15 paths)

- set `UnmanagedHitTake` = `1` = 1
- template `AddRate[SkillRate]` = `(singleSkillRate / 100)` — when UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) eq 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) ne 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction)))
- template `AddConstant[SkillConstantDamage]` = `singleConstantDamage` — when UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) eq 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) ne 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction)))
- calls `DeadlyPoisonDebuff..ctor` = `.ctor(Toram.Common.ArchetypeUid.get_Id(stkp(-56)), poisonLevel)` — when (poisonLevel & 0x80000000) eq 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction)))
- info `templates` = `1` — when UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) eq 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) ne 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction)))
- template `AddRate[SkillRate]` = `(rangeSkillRate / 100)` — when !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 2 AND poisonLevel ne 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel ne 1 AND poisonLevel ne 2
- template `AddConstant[SkillConstantDamage]` = `rangeConstantDamage` — when !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 2 AND poisonLevel ne 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel ne 1 AND poisonLevel ne 2
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(5, 0)` — when !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 2 AND poisonLevel ne 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel ne 1 AND poisonLevel ne 2

**`ActionSkillEvent`** (3 paths)

- set `attackPos.y` = `UnityEngine.Transform.get_position(mainTarget).y` — when UnityEngine.Object.op_Inequality(mainTarget) AND param eq 100
- set `attackPos.z` = `UnityEngine.Transform.get_position(mainTarget).z` — when UnityEngine.Object.op_Inequality(mainTarget) AND param eq 100

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`via PlayerAttackBase$$HitReactionAssign`** (3467 paths)

- calls `MathUtil.CheckPercent` = `CheckPercent()` — when !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) ne 0 AND MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3 OR !MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) ne 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) eq 0 AND MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3
- template `SetCalcValue[GuardPower]` = `System.Math.Max(0, (25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4))))` — when !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) ne 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) eq 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (False & 1) eq 0 AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType ne 2 AND comboType ne 3
- template `SetCalcValue[GuardPower]` = `25` — when !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) ne 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) eq 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (False & 1) eq 0 AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType ne 2 AND comboType ne 3

</details>

<details><summary>Effect applied in `FuneVinteAction$$ActionPreparation` (6 guarded paths)</summary>

- when `SkillLv(1004) ge 1` AND `SkillLv(1005) ge 1`
  - returns `?blr`
  - set `targetDeadlyPoison` = `(MobBuffManager.Contains(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.GameObject.GetComponent<object>(target, meta(0x397f3d0, Method$UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>()), ?x2, ?x3), 0, ?x2, ?x3), 14, 0,`
  - set `skillRate` = `(((Lv + (Lv << 2)) << 1) + ((?blr // 100) * ((int(fcvt(AssassinationSecrets.GetFuneVinteMpSkillRate(SkillLv(1005), ?blr, 0, ?x3))) + 60) + (Lv << 2))))`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$get_BuffManager`, `MobBuffManager$$Contains`, `AssassinationSecrets$$GetFuneVinteMpSkillRate`
- when `SkillLv(1004) ge 1` AND `SkillLv(1005) lt 1`
  - returns `?blr`
  - set `targetDeadlyPoison` = `(MobBuffManager.Contains(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.GameObject.GetComponent<object>(target, meta(0x397f3d0, Method$UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>()), ?x2, ?x3), 0, ?x2, ?x3), 14, 0,`
  - set `skillRate` = `(((Lv + (Lv << 2)) << 1) + ((?blr // 100) * (60 + (Lv << 2))))`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$get_BuffManager`, `MobBuffManager$$Contains`
- when `SkillLv(1004) ge 1` AND `SkillLv(1005) ge 1`
  - returns `?blr`
  - set `skillRate` = `(((Lv + (Lv << 2)) << 1) + ((?blr // 100) * ((int(fcvt(AssassinationSecrets.GetFuneVinteMpSkillRate(SkillLv(1005), ?blr, 0, ?x3))) + 60) + (Lv << 2))))`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `UnityEngine.GameObject$$GetComponent<object>`, `AssassinationSecrets$$GetFuneVinteMpSkillRate`
- when `SkillLv(1004) ge 1` AND `SkillLv(1005) lt 1`
  - returns `?blr`
  - set `skillRate` = `(((Lv + (Lv << 2)) << 1) + ((?blr // 100) * (60 + (Lv << 2))))`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `UnityEngine.GameObject$$GetComponent<object>`
- when `SkillLv(1004) lt 1` AND `SkillLv(1005) ge 1`
  - returns `?blr`
  - set `skillRate` = `(((Lv + (Lv << 2)) << 1) + ((?blr // 100) * ((int(fcvt(AssassinationSecrets.GetFuneVinteMpSkillRate(SkillLv(1005), ?blr, 0, ?x3))) + 60) + (Lv << 2))))`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `AssassinationSecrets$$GetFuneVinteMpSkillRate`
- when `SkillLv(1004) lt 1` AND `SkillLv(1005) lt 1`
  - returns `?blr`
  - set `skillRate` = `(((Lv + (Lv << 2)) << 1) + ((?blr // 100) * (60 + (Lv << 2))))`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`

</details>

<details><summary>Effect applied in `VenomSnatchAction$$BattleResult` (16 guarded paths)</summary>

- when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) ge 1`
  - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryHp`, `Singleton<object>$$get_Instance`
- when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) lt 1`
  - returns `SkillLv(1004)`
  - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryHp`, `Singleton<object>$$get_Instance`
- when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) ge 1`
  - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryHp`, `0x165db78`
- when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) lt 1`
  - returns `SkillLv(1004)`
  - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryHp`
- when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) ge 1`
  - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryMp`, `0x165db78`
- when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) lt 1`
  - returns `SkillLv(1004)`
  - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryMp`
- when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) ge 1`
  - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `0x165db78`, `VenomSnatchBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
- when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) lt 1`
  - returns `SkillLv(1004)`
  - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `FuneVinteAction$$ActionPreparation (GetSkillLv)`
- `VenomSnatchAction$$BattleResult (GetSkillLv)`

---

### เคล็ดลับลอบสังหาร (AssassinationSecrets) · uid 1005

<img src="../../icons/sk_1005.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 285 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ฟูเนวินเด · **Flags:** NoMarketSearch · **Client class:** `AssassinationSecrets` (passive mastery)

> เพิ่มความเข้าใจในทักษะการลอบสังหาร
> เพิ่มพลังของสกิล[แอสแซสซินสแทบ]และสกิล[ฟิวเนวินเต้]

<details><summary>In-game level notes</summary>

- Lv18: [จะได้รับผลแบบเดียวกันเมื่อใช้คัมภีร์นินจูตสึ] *พลังของแอสแซสซินสแทบจะเพิ่มขึ้นอีก

</details>

**Role:** passive mastery

<details><summary>Effect applied in `FuneVinteAction$$ActionPreparation` (6 guarded paths)</summary>

- when `SkillLv(1004) ge 1` AND `SkillLv(1005) ge 1`
  - returns `?blr`
  - set `targetDeadlyPoison` = `(MobBuffManager.Contains(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.GameObject.GetComponent<object>(target, meta(0x397f3d0, Method$UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>()), ?x2, ?x3), 0, ?x2, ?x3), 14, 0,`
  - set `skillRate` = `(((Lv + (Lv << 2)) << 1) + ((?blr // 100) * ((int(fcvt(AssassinationSecrets.GetFuneVinteMpSkillRate(SkillLv(1005), ?blr, 0, ?x3))) + 60) + (Lv << 2))))`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$get_BuffManager`, `MobBuffManager$$Contains`, `AssassinationSecrets$$GetFuneVinteMpSkillRate`
- when `SkillLv(1004) ge 1` AND `SkillLv(1005) lt 1`
  - returns `?blr`
  - set `targetDeadlyPoison` = `(MobBuffManager.Contains(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.GameObject.GetComponent<object>(target, meta(0x397f3d0, Method$UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>()), ?x2, ?x3), 0, ?x2, ?x3), 14, 0,`
  - set `skillRate` = `(((Lv + (Lv << 2)) << 1) + ((?blr // 100) * (60 + (Lv << 2))))`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$get_BuffManager`, `MobBuffManager$$Contains`
- when `SkillLv(1004) ge 1` AND `SkillLv(1005) ge 1`
  - returns `?blr`
  - set `skillRate` = `(((Lv + (Lv << 2)) << 1) + ((?blr // 100) * ((int(fcvt(AssassinationSecrets.GetFuneVinteMpSkillRate(SkillLv(1005), ?blr, 0, ?x3))) + 60) + (Lv << 2))))`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `UnityEngine.GameObject$$GetComponent<object>`, `AssassinationSecrets$$GetFuneVinteMpSkillRate`
- when `SkillLv(1004) ge 1` AND `SkillLv(1005) lt 1`
  - returns `?blr`
  - set `skillRate` = `(((Lv + (Lv << 2)) << 1) + ((?blr // 100) * (60 + (Lv << 2))))`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `UnityEngine.GameObject$$GetComponent<object>`
- when `SkillLv(1004) lt 1` AND `SkillLv(1005) ge 1`
  - returns `?blr`
  - set `skillRate` = `(((Lv + (Lv << 2)) << 1) + ((?blr // 100) * ((int(fcvt(AssassinationSecrets.GetFuneVinteMpSkillRate(SkillLv(1005), ?blr, 0, ?x3))) + 60) + (Lv << 2))))`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `AssassinationSecrets$$GetFuneVinteMpSkillRate`
- when `SkillLv(1004) lt 1` AND `SkillLv(1005) lt 1`
  - returns `?blr`
  - set `skillRate` = `(((Lv + (Lv << 2)) << 1) + ((?blr // 100) * (60 + (Lv << 2))))`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`

</details>

<details><summary>Effect applied in `AssassinStubAction$$ActionPreparation` (8 guarded paths)</summary>

- when `SkillLv(1005) ge 1`
  - set `direction` = `2`
  - set `skillRate` = `((((isEquipBonus eq 0 ? 105 : 205) + (Lv + (Lv << 1))) + GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(?blr, 1004, 0, ?x3), 4, 0, ?x3)) + AssassinationSecrets.GetAssassinStubSkillRate(SkillManager.GetSkillLv(?blr, 1005, 1`
  - set `SkillIndividualFlag` = `2`
  - set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, UnityEngine.GameObject.GetComponent<object>(target, meta(0x3973fb0, Method$UnityEngine.GameObject.GetComponent<MobActionManagerBase>()), ?x2, ?x3), 0)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_forward`, `MathUtil$$RelativeXZAngle`
- when `SkillLv(1005) lt 1`
  - set `direction` = `2`
  - set `skillRate` = `(((isEquipBonus eq 0 ? 105 : 205) + (Lv + (Lv << 1))) + GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(?blr, 1004, 0, ?x3), 4, 0, ?x3))`
  - set `SkillIndividualFlag` = `2`
  - set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, UnityEngine.GameObject.GetComponent<object>(target, meta(0x3973fb0, Method$UnityEngine.GameObject.GetComponent<MobActionManagerBase>()), ?x2, ?x3), 0)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_forward`, `MathUtil$$RelativeXZAngle`
- when `SkillLv(1005) ge 1`
  - set `direction` = `0`
  - set `skillRate` = `((((Lv + (isEquipBonus eq 0 ? 0 : 50)) + 100) + GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(?blr, 1004, 0, ?x3), 4, 0, ?x3)) + AssassinationSecrets.GetAssassinStubSkillRate(SkillLv(1005), ?bl`
  - set `SkillIndividualFlag` = `0`
  - set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, UnityEngine.GameObject.GetComponent<object>(target, meta(0x3973fb0, Method$UnityEngine.GameObject.GetComponent<MobActionManagerBase>()), ?x2, ?x3), 0)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_forward`, `MathUtil$$RelativeXZAngle`
- when `SkillLv(1005) lt 1`
  - set `direction` = `0`
  - set `skillRate` = `(((Lv + (isEquipBonus eq 0 ? 0 : 50)) + 100) + GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(?blr, 1004, 0, ?x3), 4, 0, ?x3))`
  - set `SkillIndividualFlag` = `0`
  - set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, UnityEngine.GameObject.GetComponent<object>(target, meta(0x3973fb0, Method$UnityEngine.GameObject.GetComponent<MobActionManagerBase>()), ?x2, ?x3), 0)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_forward`, `MathUtil$$RelativeXZAngle`
- when `SkillLv(1005) ge 1`
  - set `direction` = `0`
  - set `skillRate` = `((((Lv + (isEquipBonus eq 0 ? 0 : 50)) + 100) + GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(?blr, 1004, 0, ?x3), 4, 0, ?x3)) + AssassinationSecrets.GetAssassinStubSkillRate(SkillLv(1005), ?bl`
  - set `SkillIndividualFlag` = `0`
  - set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, UnityEngine.GameObject.GetComponent<object>(target, meta(0x3973fb0, Method$UnityEngine.GameObject.GetComponent<MobActionManagerBase>()), ?x2, ?x3), 0)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_forward`, `MathUtil$$RelativeXZAngle`
- when `SkillLv(1005) lt 1`
  - set `direction` = `0`
  - set `skillRate` = `(((Lv + (isEquipBonus eq 0 ? 0 : 50)) + 100) + GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(?blr, 1004, 0, ?x3), 4, 0, ?x3))`
  - set `SkillIndividualFlag` = `0`
  - set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, UnityEngine.GameObject.GetComponent<object>(target, meta(0x3973fb0, Method$UnityEngine.GameObject.GetComponent<MobActionManagerBase>()), ?x2, ?x3), 0)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_forward`, `MathUtil$$RelativeXZAngle`
- when `SkillLv(1005) ge 1`
  - set `direction` = `1`
  - set `skillRate` = `((((isEquipBonus eq 0 ? 110 : 410) + (Lv + (Lv << 3))) + GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(?blr, 1004, 0, ?x3), 4, 0, ?x3)) + AssassinationSecrets.GetAssassinStubSkillRate(SkillManager.GetSkillLv(?blr, 1005, 1`
  - set `SkillIndividualFlag` = `1`
  - set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, UnityEngine.GameObject.GetComponent<object>(target, meta(0x3973fb0, Method$UnityEngine.GameObject.GetComponent<MobActionManagerBase>()), ?x2, ?x3), 0)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_forward`, `MathUtil$$RelativeXZAngle`
- when `SkillLv(1005) lt 1`
  - set `direction` = `1`
  - set `skillRate` = `(((isEquipBonus eq 0 ? 110 : 410) + (Lv + (Lv << 3))) + GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(?blr, 1004, 0, ?x3), 4, 0, ?x3))`
  - set `SkillIndividualFlag` = `1`
  - set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, UnityEngine.GameObject.GetComponent<object>(target, meta(0x3973fb0, Method$UnityEngine.GameObject.GetComponent<MobActionManagerBase>()), ?x2, ?x3), 0)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_forward`, `MathUtil$$RelativeXZAngle`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `AssassinStubAction$$ActionPreparation (GetSkillLv)`
- `FuneVinteAction$$ActionPreparation (GetSkillLv)`

---

### แอสเซาท์เชส (AssaultChase) · uid 1006

<img src="../../icons/sk_1006.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 5) · **Type:** Buffer · **Max Lv:** 285 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ชาโดว์วอล์ค · **Flags:** NoMarketSearch · **Client class:** `AssaultChaseAction`

> เมื่อได้รับผลของบัฟใหม่จะฟื้นฟูAvoid 50%
> ลดปริมาณการใช้Avoidที่มุ่งไปยัง(หรือรอบๆ)เป้าหมาย
> ที่โจมตีเป็นเวลา 180 วินาที
> เมื่อจำนวนAvoidที่เหลืออยู่เป็น 0 ผลของบัฟจะสิ้นสุดลงเช่นกัน

<details><summary>In-game level notes</summary>

- Lv255: เมื่อหลบหลีกด้วย Avoid ได้สำเร็จในขณะที่ บัฟทำงานอยู่จะเพิ่มผลทำให้พลังโจมตีระยะใกล้เพิ่มขึ้น  เพิ่มผล Avoid ในท่าเปิดใช้งานของ แอสเซาท์เชสเฉพาะสกิลเลเวล 10 เท่านั้น
- Lv18: [จะได้รับผลแบบเดียวกันเมื่อใช้คัมภีร์นินจูตสึ] *ลดการใช้ของ Avoid ลงอีก *เพิ่มจำนวนพลังโจมตีระยะใกล้เมื่อ Avoid สำเร็จ (ขีดจำกัดสูงสุดยังคงไม่เปลี่ยนแปลง)

</details>

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1006

<details><summary>Recovered formulas (per method)</summary>

**`ActionHit`** (2 paths)

- calls `AssaultChaseBuf..ctor` = `.ctor(Lv, PlayerActionManagerBase.get_PlayerStatus())` — when UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new AssaultChaseBuf, Id)` — when UnityEngine.Object.op_Inequality(actarAction)

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

</details>

**Buffs**

**Buff `AssaultChaseBuf`**
- Buff hook methods: `AvoidSuccess`
- Duration: `180` s [EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 18 OR EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 23 AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 18 OR EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 18 AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 23]
- `ShortRangeRate` = `(0)` _(when BuffEffectActive ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 2750 | 3000 | 3250 | 3500 | 3750 | 4000 | 4250 | 4500 | 4750 | 5000 |

- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `shortRangeRate` = `0` when EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 18 OR EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 23 AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 18 OR EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 18 AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 23
  - `isShortRangeRateBonus` = `1` = 1 when EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 18 OR EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 23 AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 18
  - `isShortRangeRateBonus` = `0` when EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 18 AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 23
  - `avoidConsumptionReductionValue` = `int((((Lv * 2.5) + 25) * 100))` → Lv1..10 [2750, 3000, 3250, 3500, 3750, 4000, 4250, 4500, 4750, 5000] when EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 18 OR EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 23 AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 18
  - `avoidConsumptionReductionValue` = `int(((Lv * 2.5) * 100))` → Lv1..10 [250, 500, 750, 1000, 1250, 1500, 1750, 2000, 2250, 2500] when EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 18 AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 23
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `AvoidSuccess`: `shortRangeRate`=(((isShortRangeRateBonus ne 0 ? 2 : 1) + shortRangeRate) lt 10 ? ((isShortRangeRateBonus ne 0 ? 2 : 1) + shortRangeRate) : 10)
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:AssaultChaseBuf$$.ctor<-AssaultChaseAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

<details><summary>Effect applied in `AssaultChaseAction$$CheckAssaultChase` (3 guarded paths)</summary>

- always
  - returns `0`
- always
  - returns `(1 | (0 | (int(MathUtil.DistanceToDisplayMeter(0, [((vtab(UnityEngine.GameObject.GetComponent<object>([[[playerAction+0x30]+0x48]+0x18], meta(0x3973fb0, Method$UnityEngine.GameObject.GetComponent<MobActionManagerBase>()), ?x2, ?x3)) + ([(meta(0) + 8)+0x0] << 4)) + 312)+0x8], ?x2, ?x3)) lt 8 ? 1 : 0)))`
  - calls `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Quaternion$$AngleAxis`, `UnityEngine.Quaternion$$op_Multiply`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`
- always
  - returns `0`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `AssaultChaseAction$$CheckAssaultChase (ContainsBuffer)`

---

### นักปรุงยาพิษ (PoisonMixer) · uid 1007

<img src="../../icons/sk_1007.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 285 · **Weapons:** ShortSword, NinjutsuScroll, MainHand · **Requires:** เดธรีเซฟชัน · **Flags:** NoMarketSearch · **Client class:** `PoisonMixer` (passive mastery)

> เพิ่มระยะเวลาภาวะผิดปกติของ[พิษ]
> และพลังของสกิล[เดธรีเซฟชัน]
> มีโอกาสทำให้ติดพิษจากความเสียหายที่เกิดจากพิษร้าย
> เพิ่ม(การพึ่งพาเวนอมอินเจค) 

**Role:** passive mastery

<details><summary>Effect applied in `DeathReceptionAction$$ActionPreparation` (6 guarded paths)</summary>

- when `SkillLv(1007) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 1003, stkp(-56), meta(0x39a7e98, Method$SkillBufferManager.TryGetBuf<VenomSnatchBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
  - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 1003, 0, ?x3)`
  - set `mainTarget` = `UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3)`
  - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `+0x12c` = `?v1`
  - set `+0x130` = `?v2`
  - set `actorPlayerAction` = `actarAction`
  - set `singleSkillRate` = `(singleSkillRate + PoisonMixer.GetDeathReceptionSingleAttackSkillRate(SkillLv(1007), ?blr, 0, ?x3))`
  - set `rangeSkillRate` = `(rangeSkillRate + PoisonMixer.GetDeathReceptionRangeAttackSkillRate(SkillLv(1007), ?blr, 0, ?x3))`
  - set `poisonLevel` = `SkillBufferDataBase.GetParam(TryGetBuf<object>.out2(), 50, 0, ?x3)`
  - set `singleResistBreaker` = `((SkillBufferDataBase.GetParam(TryGetBuf<object>.out2(), 50, 0, ?x3) * 25) + singleResistBreaker)`
  - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `0x165d8dc`, `UnityEngine.Transform$$get_position`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `PoisonMixer$$GetDeathReceptionSingleAttackSkillRate`, `PoisonMixer$$GetDeathReceptionRangeAttackSkillRate`
- when `SkillLv(1007) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 1003, stkp(-56), meta(0x39a7e98, Method$SkillBufferManager.TryGetBuf<VenomSnatchBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() eq 0`
  - set `mainTarget` = `UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3)`
  - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `+0x12c` = `?v1`
  - set `+0x130` = `?v2`
  - set `actorPlayerAction` = `actarAction`
  - set `singleSkillRate` = `(singleSkillRate + PoisonMixer.GetDeathReceptionSingleAttackSkillRate(SkillLv(1007), ?blr, 0, ?x3))`
  - set `rangeSkillRate` = `(rangeSkillRate + PoisonMixer.GetDeathReceptionRangeAttackSkillRate(SkillLv(1007), ?blr, 0, ?x3))`
  - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `0x165d8dc`, `UnityEngine.Transform$$get_position`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `PoisonMixer$$GetDeathReceptionSingleAttackSkillRate`, `PoisonMixer$$GetDeathReceptionRangeAttackSkillRate`
- when `SkillLv(1007) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 1003, stkp(-56), meta(0x39a7e98, Method$SkillBufferManager.TryGetBuf<VenomSnatchBuf>())) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf<object>(?blr, 1003, stkp(-56), meta(0x39a7e98, Method$SkillBufferManager.TryGetBuf<VenomSnatchBuf>()))`
  - set `mainTarget` = `UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3)`
  - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `+0x12c` = `?v1`
  - set `+0x130` = `?v2`
  - set `actorPlayerAction` = `actarAction`
  - set `singleSkillRate` = `(singleSkillRate + PoisonMixer.GetDeathReceptionSingleAttackSkillRate(SkillLv(1007), ?blr, 0, ?x3))`
  - set `rangeSkillRate` = `(rangeSkillRate + PoisonMixer.GetDeathReceptionRangeAttackSkillRate(SkillLv(1007), ?blr, 0, ?x3))`
  - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `0x165d8dc`, `UnityEngine.Transform$$get_position`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `PoisonMixer$$GetDeathReceptionSingleAttackSkillRate`, `PoisonMixer$$GetDeathReceptionRangeAttackSkillRate`
- when `SkillLv(1007) lt 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 1003, stkp(-56), meta(0x39a7e98, Method$SkillBufferManager.TryGetBuf<VenomSnatchBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
  - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 1003, 0, ?x3)`
  - set `mainTarget` = `UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3)`
  - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `+0x12c` = `?v1`
  - set `+0x130` = `?v2`
  - set `actorPlayerAction` = `actarAction`
  - set `poisonLevel` = `SkillBufferDataBase.GetParam(TryGetBuf<object>.out2(), 50, 0, ?x3)`
  - set `singleResistBreaker` = `((SkillBufferDataBase.GetParam(TryGetBuf<object>.out2(), 50, 0, ?x3) * 25) + singleResistBreaker)`
  - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `0x165d8dc`, `UnityEngine.Transform$$get_position`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `SkillBufferDataBase$$GetParam`, `SkillBufferManager$$RemoveSelfBuffer`
- when `SkillLv(1007) lt 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 1003, stkp(-56), meta(0x39a7e98, Method$SkillBufferManager.TryGetBuf<VenomSnatchBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() eq 0`
  - set `mainTarget` = `UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3)`
  - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `+0x12c` = `?v1`
  - set `+0x130` = `?v2`
  - set `actorPlayerAction` = `actarAction`
  - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `0x165d8dc`, `UnityEngine.Transform$$get_position`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `0x165db84`
- when `SkillLv(1007) lt 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 1003, stkp(-56), meta(0x39a7e98, Method$SkillBufferManager.TryGetBuf<VenomSnatchBuf>())) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf<object>(?blr, 1003, stkp(-56), meta(0x39a7e98, Method$SkillBufferManager.TryGetBuf<VenomSnatchBuf>()))`
  - set `mainTarget` = `UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3)`
  - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `+0x12c` = `?v1`
  - set `+0x130` = `?v2`
  - set `actorPlayerAction` = `actarAction`
  - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `0x165d8dc`, `UnityEngine.Transform$$get_position`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `DeathReceptionAction$$ActionPreparation (GetSkillLv)`

---
