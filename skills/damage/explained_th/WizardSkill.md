# สกิลจอมเวทย์ (`WizardSkill`) — คำอธิบายทีละสกิล (ภาษาไทย)

สร้างอัตโนมัติด้วย `scripts/render_explained_th.py` จาก `skill_reference.json` (ข้อมูลโค้ด client ชุดล่าสุด) ไม่มีข้อความเขียนมือ แก้ไฟล์นี้ตรง ๆ จะถูกเขียนทับ ตัวเลขทั้งหมดคำนวณจากโค้ด (Code) ความหมายของชื่อ field/บทบาทแปลจากชื่อในโค้ด (Inferred) ยังไม่ได้เทียบกับตัวเลขในเกม ข้อมูลดิบทุกเส้นทางอยู่ใน `../details/WizardSkill.md`

---

<!-- calc:preface -->
> **วิธีอ่านหัวข้อ "การคำนวณแบบตัวเลข"** (สร้างอัตโนมัติด้วย `scripts/render_calc_th.py` จาก `skill_reference.json` แก้มือจะถูกเขียนทับ)
> ดาเมจต่อฮิตเดินตามขั้น `SkillCalcTemplate/CalcStep` 0→40 ตามลำดับ (Code: `SkillCalcTemplate.GetDamage`) ขั้น `+` บวกเข้าดาเมจ ขั้น `×` คูณแล้วปัดเศษทิ้ง (int) ทันทีทุกขั้น
> ลำดับหลัก: ดาเมจฐาน(7) + คงที่สกิล(8) + คงที่บัพ(9) − ป้องกันเป้า(10) + ตีแรก(11) → ×คริ(13) → ×ธาตุ(15) → ×ตัวคูณสกิล(18) → ×ตีแรก(19) → ×เสถียร(21) → +คงที่ออโต้(22) → ×Proration(23) → ×ประเภท(24) → ×ดาเมจสุดท้าย(25) → … → เพดาน/ขั้นต่ำ(35–37)
> "ฮิต N" = template ดาเมจแต่ละก้อน (ทอยคริแยกกัน) แยกตามเมธอดและตัวแปรฮิตในโค้ด (`type`, `isFirst`, `attackCount` …) ชื่อฮิต/ส่วนมาจากชื่อในโค้ด (Inferred) ตัวเลขคำนวณจากโค้ด (Code) โดยตั้งเจม/บัพเสริม = 0
> ค่าหลายก้อนในขั้นเดียวกันแบบ "บวกเข้าช่อง" จะบวกกันก่อนคูณ ส่วน "ตั้งค่าทับ" แทนที่ค่าเดิม ค่าที่ขึ้นกับสเตตัสแสดงเป็นตัวอย่างที่ 100 / 255 (และ Lv สกิลอื่น 1 / 10) ใช้สูตรที่แนบไว้คำนวณค่าอื่นเอง
<!-- calc:preface-end -->

### แฟมิเรีย (Familia) · uid 1025

<img src="../../icons/sk_1025.png" width="40" alt="icon">

- ทรี: สกิลจอมเวทย์ (ขั้น 1) · เลเวลสูงสุด: 15 · อาวุธ: ไม้เท้า, อุปกรณ์เวท, SubMagictool · ธง: StarGem
- คลาสในโค้ด: `FamiliaAction` · สถานะการแกะ: แกะครบจากโค้ด

> เรียกปีศาจรับใช้ออกมา ระหว่างการเรียก
> MATK กับ MP สูงสุด และเวทไล่โจมตีจะเพิ่มขึ้นเล็กน้อย
> ถ้าข้ารับใช้โดนโจมตีอาจจะหนีไปได้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `FamiliaBuf`: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = 5×Lv → 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10) · MATK + (`MatkUp`) = `(((int((Lv * 2.5))) * (status).Lv) // 100)` · MP สูงสุด + (`MaxMpUp`) = `maxMp`
- ตัวอ่านสกิลนี้ `BlizzardAction.IsFailure` — เงื่อนไข is failure (BlizzardAction): คืนค่า `PlayerAttackBase.IsFailure(this, status, missType)` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `CrystalLaserAction.IsFailure` — เงื่อนไข is failure (CrystalLaserAction): คืนค่า `PlayerAttackBase.IsFailure(this, status, missType)` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GameManager.ReceiveSummons` — GameManager.ReceiveSummons: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerDataManager.get_SkillBufferManager(playerManager), SkillId.Familia` เมื่อ response.SkillId eq 1025 AND response.SupportData.Time gt 0; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerDataManager.get_SkillBufferManager(playerManager), SkillId.Familia` เมื่อ response.SkillId eq 1032 AND response.SupportData.Time gt 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `HighFamiliaAction.IsFailure` — เงื่อนไข is failure (HighFamiliaAction): คืนค่า `PlayerAttackBase.IsFailure(this, status, missType)` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `LightningAction.IsFailure` — เงื่อนไข is failure (LightningAction): คืนค่า `PlayerAttackBase.IsFailure(this, status, missType)` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ManaCrystalAction.IsFailure` — เงื่อนไข is failure (ManaCrystalAction): คืนค่า `PlayerAttackBase.IsFailure(this, status, missType)` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MeteorStrikeAction.IsFailure` — เงื่อนไข is failure (MeteorStrikeAction): คืนค่า `PlayerAttackBase.IsFailure(this, status, missType)` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.PursuitAttack` — PlayerBattleManager.PursuitAttack (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SkillBufferManager.AlignLearningSkillBuffer` — SkillBufferManager.AlignLearningSkillBuffer (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `StoneSkinAction.IsFailure` — เงื่อนไข is failure (StoneSkinAction): คืนค่า `1` (2 กรณี) (นิยามเต็มในแท็บ Variables)

### มานาคริสตัล (ManaCrystal) · uid 1026

<img src="../../icons/sk_1026.png" width="40" alt="icon">

- ทรี: สกิลจอมเวทย์ (ขั้น 1) · เลเวลสูงสุด: 15 · อาวุธ: ไม้เท้า, อุปกรณ์เวท, SubMagictool · ต้องเรียนก่อน: แฟมิเรีย
- คลาสในโค้ด: `ManaCrystalAction` · สถานะการแกะ: แกะครบจากโค้ด

> คาถาใช้สร้างผลึกที่สามารถฟื้นฟูพลังเวทได้
> ฟื้นฟู MP ได้เล็กน้อยจากการใช้ผลึกที่ปรากฏออกมา
> เวลาใช้สกิลยิ่งอยู่ห่างจากปีศาจรับใช้
> ก็จะใช้เวลาร่ายนานยิ่งขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `ManaCrystalBuf`: ตัวนับ/stack (`Count`) = `System.Collections.Generic.Dictionary<int, object>.get_Count((new System.Collections.Generic.Dictionary<int, ManaCrystalBuf.Invoker>), meta(0x39aa0b8, Method$System.Collections.Generic.Dictionary<int, ManaCrystalBuf.Invoker>.get_Count()))`
- ตัวอ่านสกิลนี้ `CrystalLaserAction.ActionSkillEvent` — CrystalLaserAction.ActionSkillEvent (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `CrystalLaserAction.ActionStart` — CrystalLaserAction: ตอนเริ่มทำงานของสกิล: [call] `ManaCrystalBuf$$StartCrystalLaser` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.ManaCrystal), (this + 31…` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBuf…; [set] `attackDir` = `((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - St…` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBuf…; [set] `attackDir.y` = `((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - cr…` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBuf… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `CrystalLaserAction.OnEnd` — CrystalLaserAction.OnEnd (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.StartCatsDropItem` — PlayerBattleManager.StartCatsDropItem: [call] `MathUtil$$CheckPercent` = `SkillMasteryBase.GetMasteryParam(MasteryId.Percent)` เมื่อ [new System.Collections.Generic.List<int>+0x18] lo [[new System.Collections.Generic.List<int>+0x10]+0x18] AND ([new Sys…; [call] `MathUtil$$CheckPercent` = `SkillMasteryBase.GetMasteryParam(MasteryId.Percent)` เมื่อ [new System.Collections.Generic.List<int>+0x18] hs [[new System.Collections.Generic.List<int>+0x10]+0x18] AND [new Syst…; [call] `MathUtil$$CheckPercent` = `SkillMasteryBase.GetMasteryParam(MasteryId.Percent)` เมื่อ (System.Collections.Generic.List<int>.Contains(new System.Collections.Generic.List<int>, PlayerAttackBase.get_ActionID(… (นิยามเต็มในแท็บ Variables)

### คาสต์มาสเตอรี่ (CastMastery) · uid 1033

<img src="../../icons/sk_1033.png" width="40" alt="icon">

- ทรี: สกิลจอมเวทย์ (ขั้น 1) · เลเวลสูงสุด: 15 · อาวุธ: ไม้เท้า, MainMagictool · ธง: StarGem
- คลาสในโค้ด: `CastMastery` · สถานะการแกะ: แกะครบจากโค้ด

> รวบรวมภูมิปัญญาเพื่อเร่งการร่ายเวท
> สูญเสีย ATK เพื่อแลกกับการเพิ่มขึ้นของ CSPD
> ตามสถานะการเรียนรู้ของสกิลจอมเวทย์
> *พลังโจมตีของปีศาจรับใช้ไม่ลดลง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ATK % (`AtkRate`): 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 (Lv1…10)
- พาสซีฟ ความเร็วร่าย + (`Cspd`): `this.allWizardSkillLevel × Lv`
- พาสซีฟ ความเร็วร่าย % (`CspdRate`): `this.learnWizardSkillNum × (Lv ÷ 2) + Lv`

### ไลท์นิ่ง (Lightning) · uid 1027

<img src="../../icons/sk_1027.png" width="40" alt="icon">

- ทรี: สกิลจอมเวทย์ (ขั้น 2) · เลเวลสูงสุด: 35 · อาวุธ: ไม้เท้า, อุปกรณ์เวท, SubMagictool · ต้องเรียนก่อน: แฟมิเรีย
- คลาสในโค้ด: `LightningAction` · สถานะการแกะ: แกะครบจากโค้ด

> คำสั่งให้ปีศาจรับใช้เวทสายฟ้า
> โจมตีเป้าหมายด้วยเวทธาตุลม
> มีโอกาสทำให้เป้าหมายติด[อัมพาต]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ, วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: อัมพาต (Paralysis)

<!-- calc:begin uid=1027 -->
#### การคำนวณแบบตัวเลข — Lightning (uid 1027)
Proration: ช่อง `Magic` โหมด `first_hit_per_target if class check passes`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **80** → 80, 80, 80, 80, 80, 80, 80, 80, 80, 80 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `(30 × Lv + HighFamiliaAction.GetLightningPowerUpValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1032, 1)) + 400) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `HighFamiliaAction.GetLightningPowerUpValue` = HighFamiliaAction.GetLightningPowerUpValue; `SkillManager.GetSkillLv` = เลเวลของสกิลที่ผู้เล่นเรียน; `PlayerStatusBase.get_SkillManager` = ค่า Skill Manager ของ PlayerStatusBase; `SkillId.HighFamilia` = ไฮแฟมิเรีย (ดูแท็บ Variables)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `InitializeHighFamilia`): 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 (Lv1…10)
<!-- calc:end -->

### บลิซซาร์ด (Blizzard) · uid 1028

<img src="../../icons/sk_1028.png" width="40" alt="icon">

- ทรี: สกิลจอมเวทย์ (ขั้น 2) · เลเวลสูงสุด: 35 · อาวุธ: ไม้เท้า, อุปกรณ์เวท, SubMagictool · ต้องเรียนก่อน: แฟมิเรีย
- คลาสในโค้ด: `BlizzardAction` · สถานะการแกะ: แกะครบจากโค้ด

> คำสั่งให้ปีศาจรับใช้เวทพายุหิมะโจมตี
> สร้างความเสียหายต่อเนื่องด้วยเวทธาตุน้ำเป็นบริเวณกว้าง
> มีโอกาสทำให้เป้าหมายติด[แช่แข็ง]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ, วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: แช่แข็ง (Freeze)

<!-- calc:begin uid=1028 -->
#### การคำนวณแบบตัวเลข — Blizzard (uid 1028)
Proration: ช่อง `Magic` โหมด `first_hit_per_target if class check passes`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **100** → 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `skillRate / 100` — โดยที่ `skillRate` = `HighFamiliaAction.GetBlizzardPowerUpValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1032, 1)) + 5 × Lv + 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `target.ExpDefMagic / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefMagic` = proration ช่อง Magic ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_CharacterActionManagerBase` = ค่า Character Action Manager Base ของ MobActionManagerBase (ดูแท็บ Variables)

**จำนวนฮิต / ตัวนับ**
- `maxAttackCount` (ตั้งใน `OnInitialize`): 3, 3, 3, 4, 4, 4, 5, 5, 5, 6 (Lv1…10)
- `LoopParam` (ตั้งใน `InitializeHighFamilia`): 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 (Lv1…10)
<!-- calc:end -->

### คริสตัลเลเซอร์ (CrystalLaser) · uid 1034

<img src="../../icons/sk_1034.png" width="40" alt="icon">

- ทรี: สกิลจอมเวทย์ (ขั้น 2) · เลเวลสูงสุด: 35 · อาวุธ: ไม้เท้า, MainMagictool · ต้องเรียนก่อน: มานาคริสตัล
- คลาสในโค้ด: `CrystalLaserAction` · สถานะการแกะ: แกะครบจากโค้ด

> ยิงมานาจากมานาคริสตัลเป็นเส้นตรงเพื่อโจมตี
> ฟื้นฟู MP ของสมาชิกปาร์ตี้ในระยะโจมตีเล็กน้อย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

<!-- calc:begin uid=1034 -->
#### การคำนวณแบบตัวเลข — CrystalLaser (uid 1034)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +, ตั้งค่าทับ): **200** → 200, 200, 200, 200, 200, 200, 200, 200, 200, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, ตั้งค่าทับ): **(700 + 30×Lv)%** → 730%, 760%, 790%, 820%, 850%, 880%, 910%, 940%, 970%, 1000% (Lv1…10)
<!-- calc:end -->

### เมเทโอสตอร์มสไตร์ค (MeteorStrike) · uid 1029

<img src="../../icons/sk_1029.png" width="40" alt="icon">

- ทรี: สกิลจอมเวทย์ (ขั้น 3) · เลเวลสูงสุด: 125 · อาวุธ: ไม้เท้า, อุปกรณ์เวท, SubMagictool · ต้องเรียนก่อน: บลิซซาร์ด
- คลาสในโค้ด: `MeteorStrikeAction` · สถานะการแกะ: แกะครบจากโค้ด

>  คำสั่งให้ปีศาจรับใช้เวทอุกกาบาต
> อุกกาบาต 3 ก้อนจะตกสู่เป้าหมายที่อยู่ใกล้
> มีโอกาสทำให้เป้าหมายติด[ไหม้ไฟ]และ[ตาลาย]
> ขอเตือนว่าความแม่นนั้นขึ้นอยู่กับดวง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ, วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `ignitionPercent`: **50 + 5×Lv** → 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 (Lv1…10) %
- โอกาสติดสถานะ `dizzyPercent`: **5×Lv** → 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10) %
- สถานะที่ทำให้ติด: ไฟไหม้ (Ignition), มึนงง (Dizzy)

<!-- calc:begin uid=1029 -->
#### การคำนวณแบบตัวเลข — MeteorStrike (uid 1029)
Proration: ช่อง `Magic` โหมด `first_hit_per_target if class check passes`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **300** → 300, 300, 300, 300, 300, 300, 300, 300, 300, 300 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `skillRate / 100` — โดยที่ `skillRate` = `HighFamiliaAction.GetMeteorStrikePowerUpValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1032, 1)) + 100 × Lv + 500` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `target.ExpDefMagic / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefMagic` = proration ช่อง Magic ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_CharacterActionManagerBase` = ค่า Character Action Manager Base ของ MobActionManagerBase (ดูแท็บ Variables)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `OnInitialize`): `LUKรวม`
- `LoopParam` (ตั้งใน `InitializeHighFamilia`): `luk` — โดยที่ `luk` = `LUKรวม` หรือ `motionSpeed`
<!-- calc:end -->

### สโตนสกิล (StoneSkin) · uid 1030

<img src="../../icons/sk_1030.png" width="40" alt="icon">

- ทรี: สกิลจอมเวทย์ (ขั้น 3) · เลเวลสูงสุด: 125 · อาวุธ: ไม้เท้า, อุปกรณ์เวท, SubMagictool · ต้องเรียนก่อน: มานาคริสตัล
- คลาสในโค้ด: `StoneSkinAction` · สถานะการแกะ: แกะครบจากโค้ด

>  คำสั่งให้ปีศาจรับใช้เวทป้องกัน
> จะติดบาเรียลดความเสียหายได้ในระดับหนึ่งแต่
> ความเสียหายจากไหม้ไฟและพิษจะเพิ่มมากขึ้น(ข้อเสีย)
> ไม่สามารถใช้ซ้อนกันได้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `StoneSkinBuf` ระยะเวลา `time` วินาที: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `barrier` (ตัวนับที่เปลี่ยนตามเหตุการณ์)

### โอเวอร์ลิมิต (OverLimit) · uid 1035

<img src="../../icons/sk_1035.png" width="40" alt="icon">

- ทรี: สกิลจอมเวทย์ (ขั้น 3) · เลเวลสูงสุด: 125 · อาวุธ: ไม้เท้า, MainMagictool · ต้องเรียนก่อน: คริสตัลเลเซอร์
- คลาสในโค้ด: `OverLimitAction` · สถานะการแกะ: แกะครบจากโค้ด

> เทคนิคลับเพื่อเพิ่มพลังธาตุเป็นเวลา 90 วินาที
> สำหรับทุกพลังธาตุ(เฉพาะเวทมนตร์)ยกเว้นไร้ธาตุ
> แต่ CSPD จะลดลงและ 1% ของ Max HP จะหายไปทุกครั้งที่ร่ายเวท

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `OverLimitBuf`: ความเร็วร่าย + (`CspdUp`) = `SkillMasteryBase.GetMasteryParam(MasteryId.Cspd) - 1000` · ความเร็วร่าย + (`CspdUp`) = -1000 · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `SkillMasteryBase.GetMasteryParam(MasteryId.Value) + Lv` · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = Lv → 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)

### อิมพีเรียลเรย์[PN]อิมพีเรียลบลาสท์[PF]อิมพีเรียลไฟร์[PA]อิมพีเรียลฟรีซ[PW]อิมพีเรียลโกลม[PE]อิมพีเรียลเปตรา[PL]อิมพีเรียลโฮลี่[PD]อิมพีเรียลชาโดว์ (ImperialRay) · uid 1031

<img src="../../icons/sk_1031.png" width="40" alt="icon">

- ทรี: สกิลจอมเวทย์ (ขั้น 4) · เลเวลสูงสุด: 205 · อาวุธ: ไม้เท้า, อุปกรณ์เวท, SubMagictool · ต้องเรียนก่อน: เมเทโอสตอร์มสไตร์ค
- คลาสในโค้ด: `ImperialRayAction` · สถานะการแกะ: แกะครบจากโค้ด

> เทคนิคการโจมตีด้วยการระเบิดพลังเวทมนตร์ที่ถูกบีบอัด
> ถ้าโดนไล่โจมตีด้วยสกิลเฉพาะเช่นสกิลเวทมนตร์
> จะเกิดการระเบิดครั้งใหญ่จากพลังเวท
> การระเบิดครั้งใหญ่จะติดคริติคอลแน่นอน
> ธาตุที่เป็นจุดอ่อนจะติดอ่อนแอ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · ไม่เปลี่ยนค่า proration
- บัพ `ImperialRayBuf`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `MobaPlayerBattleManager.PursuitImperialRayAttack` — MobaPlayerBattleManager.PursuitImperialRayAttack: [call] `ImperialRayBuf$$CheckMob` = `PlayerStatusBase.get_SkillBufferManager().skillBufList[SkillId.ImperialRay], EnemyMobActi…` เมื่อ (_t1127 & 1) ne 0; [call] `SkillFactory$$CreateSkill` = `SkillId.ImperialRayAttack` เมื่อ (_t1127 & 1) ne 0 AND (ImperialRayBuf.CheckMob(PlayerStatusBase.get_SkillBufferManager().skillBufList[SkillId.ImperialR…; [call] `ImperialRayPursuitAction$$SetParameter` = `SkillFactory.CreateSkill(SkillId.ImperialRayAttack), element, (critical & 1)` เมื่อ (_t1127 & 1) ne 0 AND (ImperialRayBuf.CheckMob(PlayerStatusBase.get_SkillBufferManager().skillBufList[SkillId.ImperialR… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.PursuitImperialRayAttack` — PlayerBattleManager.PursuitImperialRayAttack: [call] `ImperialRayBuf$$CheckMob` = `PlayerStatusBase.get_SkillBufferManager().skillBufList[SkillId.ImperialRay], EnemyMobActi…` เมื่อ (_t1127 & 1) ne 0; [call] `SkillFactory$$CreateSkill` = `SkillId.ImperialRayAttack` เมื่อ (_t1127 & 1) ne 0 AND (ImperialRayBuf.CheckMob(PlayerStatusBase.get_SkillBufferManager().skillBufList[SkillId.ImperialR…; [call] `ImperialRayPursuitAction$$SetParameter` = `SkillFactory.CreateSkill(SkillId.ImperialRayAttack), element, (critical & 1)` เมื่อ (_t1127 & 1) ne 0 AND (ImperialRayBuf.CheckMob(PlayerStatusBase.get_SkillBufferManager().skillBufList[SkillId.ImperialR… (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=1031 -->
#### การคำนวณแบบตัวเลข — ImperialRay (uid 1031)
Proration: ช่อง `Magic` โหมด `never (IsExpDefFluctuate=false)`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **200 + 20×Lv** → 220, 240, 260, 280, 300, 320, 340, 360, 380, 400 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ไม้เท้า หรือ อาวุธหลัก อุปกรณ์เวท หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท/ไม้เท้า)]: `(50 × Lv + SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) + 500) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.SkillRate` = ตัวคูณสกิล (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ไม้เท้า หรือ อาวุธหลัก อุปกรณ์เวท หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท/ไม้เท้า)]: **(500 + 50×Lv)%** → 550%, 600%, 650%, 700%, 750%, 800%, 850%, 900%, 950%, 1000% (Lv1…10)
<!-- calc:end -->

### ไฮแฟมิเรีย (HighFamilia) · uid 1032

<img src="../../icons/sk_1032.png" width="40" alt="icon">

- ทรี: สกิลจอมเวทย์ (ขั้น 4) · เลเวลสูงสุด: 205 · อาวุธ: ไม้เท้า, อุปกรณ์เวท, SubMagictool · ต้องเรียนก่อน: สโตนสกิล
- คลาสในโค้ด: `HighFamiliaAction` · สถานะการแกะ: แกะครบจากโค้ด

> อัญเชิญปีศาจรับใช้ ทำให้มันเกิดอารมณ์แปรปรวน
> ร่ายเวทไลท์นิ่ง,บลิซซาร์ด,เมเทโอสตอร์มสไตร์ค
> ออกมาแบบสุ่มชั่วระยะเวลาหนึ่ง
> ประสิทธิภาพของปีศาจรับใช้ สกิลที่ปล่อย
> ะขึ้นอยู่กับระดับการเรียนรู้ของตัวเอง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `HighFamiliaBuf`: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = 5×Lv → 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10) · MATK + (`MatkUp`) = `(((int((Lv * 2.5))) * (status).Lv) // 100)` · MP สูงสุด + (`MaxMpUp`) = `maxMp`
- ตัวอ่านสกิลนี้ `BlizzardAction.IsFailure` — เงื่อนไข is failure (BlizzardAction): คืนค่า `PlayerAttackBase.IsFailure(this, status, missType)` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `BlizzardAction.OnInitialize` — BlizzardAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `skillRate` = `(HighFamiliaAction.GetBlizzardPowerUpValue(SkillManager.GetSkillLv(PlayerStatusBase.get_S…` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `CrystalLaserAction.IsFailure` — เงื่อนไข is failure (CrystalLaserAction): คืนค่า `PlayerAttackBase.IsFailure(this, status, missType)` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `FamiliaActionManager.UpdateHighFamilia` — FamiliaActionManager.UpdateHighFamilia (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `LightningAction.IsFailure` — เงื่อนไข is failure (LightningAction): คืนค่า `PlayerAttackBase.IsFailure(this, status, missType)` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `LightningAction.calcPlayerToMobDamage` — LightningAction: สูตรดาเมจผู้เล่น→มอนสเตอร์ (ใส่ค่าลง template): [tpl] `AddRate[SkillRate]` = `((((Lv * 30) + 400) + HighFamiliaAction.GetLightningPowerUpValue(SkillManager.GetSkillLv(…` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ManaCrystalAction.IsFailure` — เงื่อนไข is failure (ManaCrystalAction): คืนค่า `PlayerAttackBase.IsFailure(this, status, missType)` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MeteorStrikeAction.IsFailure` — เงื่อนไข is failure (MeteorStrikeAction): คืนค่า `PlayerAttackBase.IsFailure(this, status, missType)` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MeteorStrikeAction.OnInitialize` — MeteorStrikeAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `skillRate` = `(HighFamiliaAction.GetMeteorStrikePowerUpValue(SkillManager.GetSkillLv(PlayerStatusBase.g…` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.PursuitAttack` — PlayerBattleManager.PursuitAttack (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `StoneSkinAction.IsFailure` — เงื่อนไข is failure (StoneSkinAction): คืนค่า `1` (2 กรณี) (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: [รับเอฟเฟกต์เดียวกันเมื่อใช้กับอุปกรณ์เวทมนตร์] เมื่อระดับสกิลเพิ่มขึ้นพลังของ ไลท์นิ่ง,บลิซซาร์ด,เมเทโอสตอร์มสไตร์คจะเพิ่มขึ้น

### ซอร์ดเซอรีไกด์ (MagicalGuidance) · uid 1036

<img src="../../icons/sk_1036.png" width="40" alt="icon">

- ทรี: สกิลจอมเวทย์ (ขั้น 4) · เลเวลสูงสุด: 205 · อาวุธ: ไม้เท้า, MainMagictool · ต้องเรียนก่อน: โอเวอร์ลิมิต
- คลาสในโค้ด: `MagicalGuidance` · สถานะการแกะ: แกะครบจากโค้ด

> ลดการสูญเสีย CSPD เนื่องจากโอเวอร์ลิมิต
> และเพิ่มพลังธาตุให้มากขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ค่าทั่วไป (`Value`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
- พาสซีฟ ความเร็วร่าย + (`Cspd`): 50, 100, 150, 200, 250, 300, 350, 400, 450, 500 (Lv1…10)

### ของที่แมวทำหล่น (CatsDropItem) · uid 1037

<img src="../../icons/sk_1037.png" width="40" alt="icon">

- ทรี: สกิลจอมเวทย์ (ขั้น 5) · เลเวลสูงสุด: 285 · อาวุธ: ไม้เท้า, MainMagictool · ต้องเรียนก่อน: ไฮแฟมิเรีย
- คลาสในโค้ด: `CatsDropItem` · สถานะการแกะ: แกะครบจากโค้ด

> ถ้าเหลือก็ทิ้งไว้เมี๊ยว
> เมื่อปีศาจรับใช้ร่ายเวทสำเร็จ
> มีโอกาสที่สกิล[มานาคริสตัล]จะถูกติดตั้ง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ค่าเปอร์เซ็นต์ (`Percent`): 1, 4, 9, 16, 25, 36, 49, 64, 81, 100 (Lv1…10)

### การวิจัยเวทมนตร์ (MagicResearch) · uid 1038

<img src="../../icons/sk_1038.png" width="40" alt="icon">

- ทรี: สกิลจอมเวทย์ (ขั้น 5) · เลเวลสูงสุด: 285 · อาวุธ: ไม้เท้า, อุปกรณ์เวท, SubMagictool · ต้องเรียนก่อน: [N]อิมพีเรียลเรย์[PN]อิมพีเรียลบลาสท์[PF]อิมพีเรียลไฟร์[PA]อิมพีเรียลฟรีซ[PW]อิมพีเรียลโกลม[PE]อิมพีเรียลเปตรา[PL]อิมพีเรียลโฮลี่[PD]อิมพีเรียลชาโดว์[N]
- คลาสในโค้ด: `MagicResearch` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่มความเข้าใจเวทมนตร์ให้ลึกซึ้งผ่านการวิจัย
> เพิ่มพลังของสกิล[อิมพีเรียลเรย์]
> และลดเวลาที่ปีศาจรับใช้ร่ายเวท

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ความเร็วร่าย + (`Cspd`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
- พาสซีฟ ค่าทั่วไป (`Value`): 40, 80, 120, 160, 200, 240, 280, 320, 360, 400 (Lv1…10)
- พาสซีฟ ตัวคูณสกิล (`SkillRate`): 20, 40, 60, 80, 100, 120, 140, 160, 180, 200 (Lv1…10)

### ชิฟท์ (Shift) · uid 1039

<img src="../../icons/sk_1039.png" width="40" alt="icon">

- ทรี: สกิลจอมเวทย์ (ขั้น 5) · เลเวลสูงสุด: 285 · อาวุธ: ไม้เท้า, MainMagictool · ต้องเรียนก่อน: ซอร์ดเซอรีไกด์
- คลาสในโค้ด: `ShiftAction` · สถานะการแกะ: แกะครบจากโค้ด

> ซ่อนตัวในชั้นมิติเพื่อหลบหนีวิกฤต
> ระหว่างชิฟท์จะไม่สามารถโจมตี และสูญเสียMPอย่างต่อเนื่อง
> แต่จะอยู่ในสถานะคงกระพันตลอด
> และลบค่าเฮทของตนเองออกไป
> ไม่สามารถแสดงผลเมื่อตัวเองถูกเล็งเป้า

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- MP ที่ใช้ [มีบัพ 1039 Shift]: 0
- MP ที่ใช้ [ไม่มีบัพ 1039 Shift]: 200
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `ShiftBuf`: บัพนับสแตก (สืบจาก `CountBufferBase`): ตัวนับ `Count` เริ่ม 0 เพิ่มทีละ 1 ด้วย `Next()` และสูงสุด 99; โค้ดอื่นอ่านจำนวนสแตกผ่านพารามิเตอร์ `Count` (ดูค่าที่ใช้จริงในสูตรของสกิลที่อ้างถึง)
- บัพ `ShiftMotionSpeedBuf` ระยะเวลา `min(buf.LeftTime + (int(Lv × Lv / 5 + 0.5) + 10) × count, 60)` วินาที: ความเร็วท่าทาง + (`MotionSpeed`) = `min(baseINT ÷ 100, 5) + 10`
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 99 ตามที่ `ShiftBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `AvoidActionManager.CheckAvoidStart` — ตรวจ avoid start (AvoidActionManager): [call] `AvoidActionManager$$CheckActivateMirageStep` = `this` เมื่อ AvoidActionManager.get_AvoidType(this) ne 2 AND (AvoidActionManager.CheckAvoidEquip(this) & 1) ne 0 AND (IGuardAction.g…; [call] `AvoidActionManager$$CheckPenetrator` = `this` เมื่อ AvoidActionManager.get_AvoidType(this) ne 2 AND (AvoidActionManager.CheckAvoidEquip(this) & 1) ne 0 AND (IGuardAction.g…; [call] `AvoidActionManager$$CheckActivateMirageStep` = `this` เมื่อ AvoidActionManager.get_AvoidType(this) ne 2 AND (AvoidActionManager.CheckAvoidEquip(this) & 1) ne 0 AND (IGuardAction.g… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `BattleManagerBase.BattleEntry` — BattleManagerBase.BattleEntry: คืนค่า `0` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `BattleManagerBase.SupportEntry` — BattleManagerBase.SupportEntry: คืนค่า `0` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GuardActionManager.CheckGuardStart` — ตรวจ guard start (GuardActionManager): คืนค่า `_t378` (3 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.BattleReserve` — MobaPlayerActionManager.BattleReserve: [call] `CaptureManager$$CheckCaptureEnable` = `Singleton<CaptureManager>.get_Instance(), UnityEngine.GameObject.GetComponent<EnemyMobAct…` เมื่อ (MobaPlayerActionManager.get_IsInputLock(this) & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_Sk…; [call] `CaptureManager$$CheckCaptureEnable` = `Singleton<CaptureManager>.get_Instance(), UnityEngine.GameObject.GetComponent<EnemyMobAct…` เมื่อ (MobaPlayerActionManager.get_IsInputLock(this) & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_Sk…; [call] `SkillComboManager$$CheckCombo` = `ComboManager, _t1072, PlayerStatusBase.GetEquipSkill(MobaPlayerActionManager.get_PlayerSt…` เมื่อ (MobaPlayerActionManager.get_IsInputLock(this) & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_Sk… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.Damaged` — MobaPlayerActionManager: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.OnActionButton` — MobaPlayerActionManager.OnActionButton: [set] `externalTarget` = `0` เมื่อ (MobaPlayerActionManager.get_IsInputLock(this) & 1) eq 0 AND type eq 1 AND (SkillBufferManager.ContainsBuffer(PlayerSta… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.SupportReserve` — MobaPlayerActionManager.SupportReserve (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerBattleManager.StartAutoDeviceAttack` — MobaPlayerBattleManager.StartAutoDeviceAttack: [call] `SkillFactory$$CreateSkill` = `733, buf.Level, actionManager` เมื่อ IsDelay eq 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Shift) & 1) eq 0…; [call] `AutoDeviceAttackAction$$SetDelayFunc` = `SkillFactory.CreateSkill(SkillId.AutoDeviceAttack, buf.Level, actionManager), new System.…` เมื่อ IsDelay eq 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Shift) & 1) eq 0… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.BattleReserve` — PlayerActionManager.BattleReserve: [call] `CaptureManager$$CheckCaptureEnable` = `Singleton<CaptureManager>.get_Instance(), UnityEngine.GameObject.GetComponent<EnemyMobAct…` เมื่อ (PlayerActionManager.get_IsInputLock(this) & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillB…; [call] `SkillComboManager$$CheckCombo` = `ComboManager, _t1307, PlayerStatusBase.GetEquipSkill(PlayerActionManager.get_PlayerStatus…` เมื่อ (PlayerActionManager.get_IsInputLock(this) & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillB…; [call] `SkillComboState$$EnoughTenacityCost` = `ComboManager.comboState, PlayerActionManager.get_PlayerStatus()` เมื่อ (PlayerActionManager.get_IsInputLock(this) & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillB… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.Damaged` — PlayerActionManager: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.OnActionButton` — PlayerActionManager.OnActionButton: คืนค่า `1` (5 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.SupportReserve` — PlayerActionManager.SupportReserve (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.StartAutoDeviceAttack` — PlayerBattleManager.StartAutoDeviceAttack: [call] `SkillFactory$$CreateSkill` = `733, buf.Level, actionManager` เมื่อ IsDelay eq 0 AND (SkillBufferManager.CheckSong(PlayerStatusBase.get_SkillBufferManager()) & 1) eq 0 AND (SkillBufferMan…; [call] `AutoDeviceAttackAction$$SetDelayFunc` = `SkillFactory.CreateSkill(SkillId.AutoDeviceAttack, buf.Level, actionManager), new System.…` เมื่อ IsDelay eq 0 AND (SkillBufferManager.CheckSong(PlayerStatusBase.get_SkillBufferManager()) & 1) eq 0 AND (SkillBufferMan… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ReceiveSupportResult.OnEventPlayerSupport` — ReceiveSupportResult.OnEventPlayerSupport: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerDataManager.get_SkillBufferManager(PlayerDataManager.GetPlayerDataManager()), new S…` เมื่อ (skillId & 0xffff) ne 1000 AND (skillId & 0xffff) eq 1039 AND supportData.HealMp eq 0 AND (SkillBufferManager.TryGetBuf…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerDataManager.get_SkillBufferManager(PlayerDataManager.GetPlayerDataManager()), Skill…` เมื่อ (skillId & 0xffff) ne 1000 AND (skillId & 0xffff) eq 1039 AND supportData.HealMp eq 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ShiftAction.OnInitialize` — ShiftAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `mp` = `0` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Shift) & 1) ne 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ShiftAction.ReceiveSupport` — ShiftAction.ReceiveSupport: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new ShiftMotionSpeedBuf, 0` เมื่อ resultData.Flag eq 2 AND (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Shift, out) &…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Shift` เมื่อ resultData.Flag eq 2 AND (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Shift, out) &… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: [จะได้รับผลแบบเดียวกันเมื่อใช้อุปกรณ์เวทมนตร์] ระหว่างชิฟท์ถ้าหลบหลีกความเสียหายจะได้รับ บัฟเพิ่มความเร็วการเคลื่อนที่ตามจำนวนครั้งนั้น(สูงสุด 60 วินาที)

