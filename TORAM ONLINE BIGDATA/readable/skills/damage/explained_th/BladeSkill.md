# สกิลดาบ (`BladeSkill`) — คำอธิบายทีละสกิล (ภาษาไทย)

สร้างอัตโนมัติด้วย `scripts/render_explained_th.py` จาก `skill_reference.json` (ข้อมูลโค้ด client ชุดล่าสุด) ไม่มีข้อความเขียนมือ แก้ไฟล์นี้ตรง ๆ จะถูกเขียนทับ ตัวเลขทั้งหมดคำนวณจากโค้ด (Code) ความหมายของชื่อ field/บทบาทแปลจากชื่อในโค้ด (Inferred) ยังไม่ได้เทียบกับตัวเลขในเกม ข้อมูลดิบทุกเส้นทางอยู่ใน `../details/BladeSkill.md`

---

<!-- calc:preface -->
> **วิธีอ่านหัวข้อ "การคำนวณแบบตัวเลข"** (สร้างอัตโนมัติด้วย `scripts/render_calc_th.py` จาก `skill_reference.json` แก้มือจะถูกเขียนทับ)
> ดาเมจต่อฮิตเดินตามขั้น `SkillCalcTemplate/CalcStep` 0→40 ตามลำดับ (Code: `SkillCalcTemplate.GetDamage`) ขั้น `+` บวกเข้าดาเมจ ขั้น `×` คูณแล้วปัดเศษทิ้ง (int) ทันทีทุกขั้น
> ลำดับหลัก: ดาเมจฐาน(7) + คงที่สกิล(8) + คงที่บัพ(9) − ป้องกันเป้า(10) + ตีแรก(11) → ×คริ(13) → ×ธาตุ(15) → ×ตัวคูณสกิล(18) → ×ตีแรก(19) → ×เสถียร(21) → +คงที่ออโต้(22) → ×Proration(23) → ×ประเภท(24) → ×ดาเมจสุดท้าย(25) → … → เพดาน/ขั้นต่ำ(35–37)
> "ฮิต N" = template ดาเมจแต่ละก้อน (ทอยคริแยกกัน) แยกตามเมธอดและตัวแปรฮิตในโค้ด (`type`, `isFirst`, `attackCount` …) ชื่อฮิต/ส่วนมาจากชื่อในโค้ด (Inferred) ตัวเลขคำนวณจากโค้ด (Code) โดยตั้งเจม/บัพเสริม = 0
> ค่าหลายก้อนในขั้นเดียวกันแบบ "บวกเข้าช่อง" จะบวกกันก่อนคูณ ส่วน "ตั้งค่าทับ" แทนที่ค่าเดิม ค่าที่ขึ้นกับสเตตัสแสดงเป็นตัวอย่างที่ 100 / 255 (และ Lv สกิลอื่น 1 / 10) ใช้สูตรที่แนบไว้คำนวณค่าอื่นเอง
<!-- calc:preface-end -->

### ฮาร์ดฮิต (HardHit) · uid 33

<img src="../../icons/sk_033.png" width="40" alt="icon">

- ทรี: สกิลดาบ (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: ดาบมือเดียว, ดาบสองมือ · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `HardHitAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีศัตรูด้วยอาวุธอย่างรุนแรง
> มีโอกาสทำให้เป้าหมาย[ผงะ]ได้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `flinchPercent` [อาวุธหลัก ดาบสองมือ หรือ อาวุธหลักอื่น (ไม่ใช่ ดาบมือเดียว/ดาบสองมือ)]: 10, 14, 19, 23, 28, 32, 37, 41, 46, 50 (Lv1…10) %
- โอกาสติดสถานะ `flinchPercent` [อาวุธหลัก ดาบมือเดียว]: 60, 64, 69, 73, 78, 82, 87, 91, 96, 100 (Lv1…10) %
- สถานะที่ทำให้ติด: ผงะ (Flinch)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: [ได้รับผลแบบเดียวกันเมื่อใช้กับดาบคู่]  *อัตราติดผงะ+50%
- Lv11: *พลัง+50

<!-- calc:begin uid=33 -->
#### การคำนวณแบบตัวเลข — HardHit (uid 33)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **50 + 5×Lv** → 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบสองมือ]: **(150 + 5×Lv)%** → 155%, 160%, 165%, 170%, 175%, 180%, 185%, 190%, 195%, 200% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบมือเดียว หรือ อาวุธหลักอื่น (ไม่ใช่ ดาบมือเดียว/ดาบสองมือ)]: **(100 + 5×Lv)%** → 105%, 110%, 115%, 120%, 125%, 130%, 135%, 140%, 145%, 150% (Lv1…10)
<!-- calc:end -->

### แอสทิวท์ (Astute) · uid 34

<img src="../../icons/sk_034.png" width="40" alt="icon">

- ทรี: สกิลดาบ (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: ดาบมือเดียว, ดาบสองมือ · ต้องเรียนก่อน: ฮาร์ดฮิต · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `AstuteAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีศัตรูอย่างรุนแรงด้วยท่วงท่าอันรวดเร็ว
> อัตราคริติคอล+25% เมื่อใช้สกิลสำเร็จ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- MP ที่ใช้ [อาวุธหลัก ดาบมือเดียว]: 100
- MP ที่ใช้ [อาวุธหลัก ดาบสองมือ]: 200
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `AstuteBuf` ระยะเวลา 5, 5, 5, 5, 5, 10, 10, 10, 10, 10 (Lv1…10) วินาที: อัตราคริ + (`CrtUp`) = 25
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.ReceiveAttack` — MobaPlayerActionManager.ReceiveAttack: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new AstuteBuf, 0` เมื่อ GetServerHitTypeV2.reactionType(mobResponseData.HitType) ne 1 AND GetServerHitTypeV2.hitType(mobResponseData.HitType) n… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PetStatus.get_Critical` — ค่า Critical ของ PetStatus: คืนค่า `(int((_t597 * (int((PetStatus.get_Crt(this) / 3.4)) + 25))) + _t601)` (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: [ได้รับผลแบบเดียวกันเมื่อใช้กับดาบคู่]  *MP ที่ใช้-100
- Lv11: *พลัง+50 *เพิ่มค่าความเสียหายคริติคอลที่ได้จากบัฟ

<!-- calc:begin uid=34 -->
#### การคำนวณแบบตัวเลข — Astute (uid 34)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **150 + 5×Lv** → 155, 160, 165, 170, 175, 180, 185, 190, 195, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบมือเดียว]: **(150 + 10×Lv)%** → 160%, 170%, 180%, 190%, 200%, 210%, 220%, 230%, 240%, 250% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบสองมือ]: **(200 + 10×Lv)%** → 210%, 220%, 230%, 240%, 250%, 260%, 270%, 280%, 290%, 300% (Lv1…10)
<!-- calc:end -->

### โซนิคเบรด (AccelBlade) · uid 35

<img src="../../icons/sk_035.png" width="40" alt="icon">

- ทรี: สกิลดาบ (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: ดาบมือเดียว, ดาบสองมือ · ต้องเรียนก่อน: ฮาร์ดฮิต · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `AccelBladeAction` · สถานะการแกะ: แกะครบจากโค้ด

> เข้าประชิดศัตรูแล้วใช้อาวุธแทง
> ระยะโจมตีและอัตราคริติคอลจะเพิ่มขึ้นเมื่อเลเวลสูงขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `AccelBladeBuf` ระยะเวลา `time` วินาที
- ตัวอ่านสกิลนี้ `AccelBladeAction.OnInitialize` — AccelBladeAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `rank` = `1` เมื่อ PlayerAttackBase.GetWeaponType(actarAction) ne 11 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBuff…; [set] `rangeRad` = `2` เมื่อ PlayerAttackBase.GetWeaponType(actarAction) ne 11 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBuff…; [set] `rank` = `1` เมื่อ PlayerAttackBase.GetWeaponType(actarAction) eq 11 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBuff… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: [ได้รับผลแบบเดียวกันเมื่อใช้กับดาบคู่]  *ระยะห่างที่สามารถใช้ได้+4m *เพิ่มปริมาณการเพิ่มอัตราคริติคอล
- Lv11: *พลัง+50 *ระยะโจมตี (แนวนอน)+2m

<!-- calc:begin uid=35 -->
#### การคำนวณแบบตัวเลข — AccelBlade (uid 35)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **100 + 5×Lv** → 105, 110, 115, 120, 125, 130, 135, 140, 145, 150 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบมือเดียว และ มีบัพ Aspd หรือ อาวุธหลัก ดาบมือเดียว และ ไม่มีบัพ Aspd หรือ อาวุธหลักอื่น (ไม่ใช่ ดาบมือเดียว/ดาบสองมือ) และ มีบัพ Aspd หรือ `ActionRange = inf` และ `rank ≠ 0`]: **(100 + 5×Lv)%** → 105%, 110%, 115%, 120%, 125%, 130%, 135%, 140%, 145%, 150% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบสองมือ และ มีบัพ Aspd หรือ อาวุธหลัก ดาบสองมือ และ ไม่มีบัพ Aspd]: **(150 + 5×Lv)%** → 155%, 160%, 165%, 170%, 175%, 180%, 185%, 190%, 195%, 200% (Lv1…10)
<!-- calc:end -->

### ซอร์ดมาสเตอรี่ (BladeMastery) · uid 36

<img src="../../icons/sk_036.png" width="40" alt="icon">

- ทรี: สกิลดาบ (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: ดาบมือเดียว, ดาบสองมือ · ธง: StarGem
- คลาสในโค้ด: `BladeMastery` · สถานะการแกะ: แกะครบจากโค้ด

> ใช้ดาบได้ชำนาญมากขึ้น
> พลังโจมตีจะมากขึ้นเมื่อโจมตีด้วยดาบมือเดียวหรือดาบสองมือ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ATK อาวุธ % (`EqAtkRate`): 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 (Lv1…10)
- พาสซีฟ ATK % (`AtkRate`): 1, 1, 1, 1, 1, 1, 2, 2, 2, 2 (Lv1…10)

### ควิกสแลช (SpeedyBladeMastery) · uid 37

<img src="../../icons/sk_037.png" width="40" alt="icon">

- ทรี: สกิลดาบ (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: ดาบมือเดียว, ดาบสองมือ · ต้องเรียนก่อน: ซอร์ดมาสเตอรี่ · ธง: StarGem
- คลาสในโค้ด: `SpeedyBladeMastery` · สถานะการแกะ: แกะครบจากโค้ด

> ลดการเคลื่อนไหวที่ไร้ประโยชน์
> ทำให้โจมตีได้อย่างรวดเร็ว
> เมื่อใช้ดาบมือเดียวหรือดาบสองมือ 

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ความเร็วโจมตี + (`Aspd`): 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10)
- พาสซีฟ ความเร็วโจมตี % (`AspdRate`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)

### แฮมเมอร์สแลม (HammerDown) · uid 52

<img src="../../icons/sk_052.png" width="40" alt="icon">

- ทรี: สกิลดาบ (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: ดาบสองมือ · ธง: StarGem
- คลาสในโค้ด: `HammerDownAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีแบบกระแทกลงในระยะแคบ
> โดยมีศูนย์กลางอยู่ที่เป้าหมาย
> การันตีคริติคอลกับเป้าหมาย
> ที่ติดสถานะผิดปกติเช่นผงะ
> หากใช้ต่อเนื่อง MP ที่ใช้จะกลายเป็น 0

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- MP ที่ใช้ [มีบัพ Percent]: 0
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ; เป็นธรรมดาเมื่อเข้าเงื่อนไขบัฟตอนเตรียมสกิล — เงื่อนไข: Physics: default (ctor); Normal: ActionPreparation: buff-active branch sets attackType=3
- Proration: ช่องที่เลือกตอนร่าย (กายภาพ/เวท) · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `HammerDownBuf`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `HammerDownAction.ActionPreparation` — HammerDownAction: ขั้นเตรียมก่อนปล่อยสกิล: [set] `continuousUse` = `1` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBuf…; [set] `attackType` = `3` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBuf… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `HammerDownAction.OnInitialize` — HammerDownAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `baseMp` = `0` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.HammerDown) & 1) ne 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.RemoveAfterSkillBuf` — PlayerAttackBase.RemoveAfterSkillBuf: [call] `SkillBufferManager$$RemoveBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.HammerDown` เมื่อ (PlayerAttackBase.ContainsNotApplicableSkill(PlayerAttackBase.get_ActionID()) & 1) eq 0 AND (SkillBufferManager.Contain… (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=52 -->
#### การคำนวณแบบตัวเลข — HammerDown (uid 52)
Proration: ช่อง `dynamic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **100** → 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `skillRate / 100` — โดยที่ `skillRate` = `5 × Lv + VITรวม + baseSTR // 5 + 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`continuousUse ≠ 0`]: **1** → 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 (Lv1…10)
<!-- calc:end -->

### ทริกเกอร์สแลช (TriggerSlash) · uid 38

<img src="../../icons/sk_038.png" width="40" alt="icon">

- ทรี: สกิลดาบ (ขั้น 2) · เลเวลสูงสุด: 30 · อาวุธ: ดาบมือเดียว, ดาบสองมือ · ต้องเรียนก่อน: แอสทิวท์ · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `TriggerSlashAction` · สถานะการแกะ: แกะครบจากโค้ด

> ใส่พลังลงไปที่ดาบอย่างเต็มที่เมื่อฟันศัตรู
> เพิ่มอัตราการฟื้นฟู MP จนกว่าจะใช้สกิลต่อไป
> และเคลื่อนไหวได้เร็วขึ้น 1 ครั้งเมื่อใช้สกิล

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- MP ที่ใช้: 400, 400, 400, 400, 300, 300, 300, 300, 300, 200 (Lv1…10)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `TriggerSlashBuf`: MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = 2×Lv → 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 (Lv1…10) · ความเร็วท่าทาง + (`MotionSpeed`) = 50

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: [ได้รับผลแบบเดียวกันเมื่อใช้กับดาบคู่]  *เล็งตรงเป้า
- Lv11: *พลัง+100

<!-- calc:begin uid=38 -->
#### การคำนวณแบบตัวเลข — TriggerSlash (uid 38)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **200 + 10×Lv** → 210, 220, 230, 240, 250, 260, 270, 280, 290, 300 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `skillRate` — โดยที่ `skillRate` = `(mainWeapon = TwoHandSword ? 5 × Lv + 250 : 5 × Lv + 150) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
<!-- calc:end -->

### สไปรัลแอร์ (SpiralAir) · uid 39

<img src="../../icons/sk_039.png" width="40" alt="icon">

- ทรี: สกิลดาบ (ขั้น 2) · เลเวลสูงสุด: 30 · อาวุธ: ดาบมือเดียว, ดาบสองมือ · ต้องเรียนก่อน: โซนิคเบรด · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `SpiralAirAction` · สถานะการแกะ: แกะครบจากโค้ด

> แทงอย่างเฉียบคมพร้อมสร้างมีดสูญญากาศ
> ถ้าสไปรัลแอร์โจมตีเข้าเป้า
> ค่าความเสียหายคริติคอลจะเพิ่มขึ้นชั่วขณะ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 6 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `SpiralAirBuf` ระยะเวลา Lv → 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10) วินาที: ดาเมจคริ + (`CrtDamageUp`) = `criticalDamage`
- ตัวอ่านสกิลนี้ `MobaPlayerSecondaryStatus.get_CriticalDmg` — ค่า Critical Dmg ของ MobaPlayerSecondaryStatus: คืนค่า `_t609` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.CalcCriticalDmg` — คำนวณ critical dmg (PlayerSecondaryStatus): คืนค่า `(int((_t1571 * (((PlayerSecondaryStatus.get_Str(this) * 0.2) + max(((PlayerSecondaryStatus.get_Agi(this) - PlayerSecondaryStatus.get_Str(this)) * 0.1), 0)) + 1…` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SpiralAirAction.ReceiveMobaAttack` — SpiralAirAction.ReceiveMobaAttack: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new SpiralAirBuf, attackResponseData.LocalId` เมื่อ attackResponseData.SkillId eq 39 AND ((IPlayerStatusCalculator.get_Dex(PlayerStatusBase.get_SecondaryStatus()) // (60 -…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new SpiralAirBuf, attackResponseData.LocalId` เมื่อ attackResponseData.SkillId eq 39 AND EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipIt… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: *เพิ่มค่าความเสียหายคริติคอลที่ได้จากบัฟ(ยกเว้นดาบคู่)
- Lv11: *พลัง+50

<!-- calc:begin uid=39 -->
#### การคำนวณแบบตัวเลข — SpiralAir (uid 39)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `hitCount ge 1`**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `fixAddDamage` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบสองมือ]: **(25 + 6×Lv)%** → 31%, 37%, 43%, 49%, 55%, 61%, 67%, 73%, 79%, 85% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ ดาบสองมือ)]: **(20 + 6×Lv)%** → 26%, 32%, 38%, 44%, 50%, 56%, 62%, 68%, 74%, 80% (Lv1…10)
- ความเสถียร (`StableRate`, ×, ตั้งค่าทับ): `PlayerAttackBase.CalcStable(SpiralAirAction.get_AttackType(), Stableรวม, SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new, SkillCalcTemplate, playerAction, mobAction), 4) & 1, PlayerActionManagerBase.get_PlayerStatus())` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Stable` = ความเสถียร (Stability) %; `SpiralAirAction.get_AttackType` = ค่า Attack Type ของ SpiralAirAction; `SkillCalcTemplate.CheckStepResult` = ตรวจ step result (SkillCalcTemplate); `PlayerAttackBase.HitReactionAssign` = PlayerAttackBase.HitReactionAssign; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
- ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, ×, ตั้งค่าทับ): `PlayerAttackBase.CalcLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus(), SpiralAirAction.get_AttackType())` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.CalcLastDamageRate` = ตัวคูณดาเมจสุดท้ายรวม (บัพ + มาสเตอรี + เจม + Double Throw ...); `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `SpiralAirAction.get_AttackType` = ค่า Attack Type ของ SpiralAirAction (ดูแท็บ Variables)

**ใช้ร่วมทุกฮิตของ ฮิตรีแอ็กชัน (`HitReactionAssign`)**
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical)` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobBuffer.GuardUpBuff.get_GuardUpval` = ค่า Guard Upval ของ GuardUpBuff; `TryGetBuff.buff` = TryGetBuff.buff; `MobActionManagerBase.get_BuffManager` = ค่า Buff Manager ของ MobActionManagerBase (ดูแท็บ Variables)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) = 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: **25** → 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 (Lv1…10)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `OnInitialize`): 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 (Lv1…10)
<!-- calc:end -->

### ซอร์ดเทคนิก (BladeMasterMastery) · uid 40

<img src="../../icons/sk_040.png" width="40" alt="icon">

- ทรี: สกิลดาบ (ขั้น 2) · เลเวลสูงสุด: 30 · อาวุธ: ดาบมือเดียว, ดาบสองมือ · ต้องเรียนก่อน: ควิกสแลช
- คลาสในโค้ด: `BladeMasterMastery` · สถานะการแกะ: แกะครบจากโค้ด

> เรียนแก่นแท้แห่งดาบ
> เพิ่มพลังโจมตีให้สกิลดาบ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ดาเมจสุดท้าย % (`LastDmgRate`): 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 (Lv1…10)

### คลีฟวิงแอคแทค (CleaveAttack) · uid 53

<img src="../../icons/sk_053.png" width="40" alt="icon">

- ทรี: สกิลดาบ (ขั้น 2) · เลเวลสูงสุด: 30 · อาวุธ: ดาบสองมือ · ต้องเรียนก่อน: แฮมเมอร์สแลม
- คลาสในโค้ด: `CleaveAttackAction` · สถานะการแกะ: แกะครบจากโค้ด

> กวัดแกว่งดาบในแนวนอนเพื่อจัดการคู่ต่อสู้หลายคน
> ถ้ามีตั้งแต่ 2 เป้าหมายขึ้นไป
> พลังจะเพิ่มขึ้นตามสัดส่วน
> และจะฟื้นฟู MP ที่ใช้ไป

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

<!-- calc:begin uid=53 -->
#### การคำนวณแบบตัวเลข — CleaveAttack (uid 53)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) · ส่วน โบนัส (`bonus…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [VIT รวม=100]: **250 + 15×Lv** → 265, 280, 295, 310, 325, 340, 355, 370, 385, 400 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [VIT รวม=255]: **405 + 15×Lv** → 420, 435, 450, 465, 480, 495, 510, 525, 540, 555 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `bonusSkillRate` · STR รวม=100 หรือ `IsOtherPlayer = 0` และ `param = 100` และ `targetNum ≤ 0` หรือ `IsOtherPlayer = 0` และ `PlayerAttackBase.get_Mp() le (targetNum * 100)` และ `param = 100` และ `targetNum > 0` หรือ `IsOtherPlayer = 0` และ `PlayerAttackBase.get_Mp() gt (targetNum * 100)` และ `param = 100` และ `targetNum > 0` · STR รวม=100]: **(200 + 10×Lv)%** → 210%, 220%, 230%, 240%, 250%, 260%, 270%, 280%, 290%, 300% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `bonusSkillRate` · STR รวม=255 หรือ `IsOtherPlayer = 0` และ `param = 100` และ `targetNum ≤ 0` หรือ `IsOtherPlayer = 0` และ `PlayerAttackBase.get_Mp() le (targetNum * 100)` และ `param = 100` และ `targetNum > 0` หรือ `IsOtherPlayer = 0` และ `PlayerAttackBase.get_Mp() gt (targetNum * 100)` และ `param = 100` และ `targetNum > 0` · STR รวม=255]: **(277 + 10×Lv)%** → 287%, 297%, 307%, 317%, 327%, 337%, 347%, 357%, 367%, 377% (Lv1…10)
<!-- calc:end -->

### รัมเพจ (Rampage) · uid 41

<img src="../../icons/sk_041.png" width="40" alt="icon">

- ทรี: สกิลดาบ (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: ดาบมือเดียว, ดาบสองมือ · ต้องเรียนก่อน: ทริกเกอร์สแลช
- คลาสในโค้ด: `RampageAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีต่อเนื่องด้วยพลังอันดุเดือด
> เพิ่มพลังการโจมตีธรรมดา 10 ครั้ง
> เมื่อโจมตีครบ 10 ครั้งแล้วจะทำการโจมตีอย่างรุนแรง
> ไม่สามารถใช้ซ้อนกันได้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `RampageBuf` ระยะเวลา 600 วินาที: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `isFinish` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `isFinish` = `1`; Next(): `isFinish` = `0`; Next(): `LeftTime` = `0` · ค่าทั่วไปตัวที่ 2 (`Value2`) = 3, 5, 7, 9, 11, 13, 16, 19, 22, 25 (Lv1…10)
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 11 ตามที่ `RampageBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `GemCartBuffer.BerserkSuppressionBuff.Exemption` — BerserkSuppressionBuff.Exemption: [call] `MathUtil$$CheckPercent` = `((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.Berserk, 1) + (Ski…` เมื่อ (GemCartBufferManager.ContainsBuffer(PlayerStatusBase.get_GemCartBuffManager(), 401) & 1) ne 0 AND (SkillBufferManager.… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `NormalAttackAction.OnInitialize` — NormalAttackAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `<SkillIndividualFlag>k__BackingField` = `(SkillIndividualFlag | 2)` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Rampage, out) & 1) ne 0 AND (PlayerAtt…; [set] `<SkillIndividualFlag>k__BackingField` = `(SkillIndividualFlag | 1)` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Rampage, out) & 1) ne 0 AND (PlayerAtt… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.get_AtkMpRecovery` — ค่า Atk Mp Recovery ของ PlayerSecondaryStatus: คืนค่า `0` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `RampageAction.ReceivedAbnormal` — RampageAction.ReceivedAbnormal: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Rampage` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Rampage, out) & 1) ne 0 AND (SkillBuff… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: [ได้รับผลแบบเดียวกันเมื่อใช้กับดาบคู่]  *พลังโจมตีปกติ+5 - +50
- Lv11: *พลังโจมตีครั้งสุดท้าย+400

### ซอร์ดเทมเพสต์ (SwordTempest) · uid 42

<img src="../../icons/sk_042.png" width="40" alt="icon">

- ทรี: สกิลดาบ (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: ดาบมือเดียว, ดาบสองมือ · ต้องเรียนก่อน: สไปรัลแอร์ · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `SwordTempestAction` · สถานะการแกะ: แกะครบจากโค้ด

> ฟันอย่างรุนแรงจนทำให้เกิดลมพายุ
> พายุหมุนจะสร้างความเสียหายอย่างต่อเนื่อง
> ศัตรูจะถูกดูดเข้ามาหนึ่งครั้ง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 2 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: Suction (Suction)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: [ได้รับผลแบบเดียวกันเมื่อใช้กับดาบคู่]  *พลังพายุหมุนเพิ่มขึ้นตามค่า DEX
- Lv11: *พลังกระสุน+100 *พลังกระสุนเพิ่มขึ้นตามค่า STR

<!-- calc:begin uid=42 -->
#### การคำนวณแบบตัวเลข — SwordTempest (uid 42)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcFirstDamage`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type = 11` และ มีเจมคาร์ท 301 หรือ ไม่มีเจมคาร์ท 301 และ `PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type = 11`]: `(10 × Lv + baseSTR // 5 + 250) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseSTR` = แต้ม STR ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseSTR (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type = 10` และ `PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type ≠ 11` และ มีเจมคาร์ท 301 หรือ ไม่มีเจมคาร์ท 301 และ `PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type = 10` และ `PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type ≠ 11` หรือ `PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type ≠ 10` และ `PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type ≠ 11` และ มีเจมคาร์ท 301]: **(150 + 10×Lv)%** → 160%, 170%, 180%, 190%, 200%, 210%, 220%, 230%, 240%, 250% (Lv1…10)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `target.ExpDefSkill / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefSkill` = proration ช่อง Skill ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_CharacterActionManagerBase` = ค่า Character Action Manager Base ของ MobActionManagerBase (ดูแท็บ Variables)

**ฮิต 2: `calcAnyDamage` (ฮิตถัดไป (ใช้ร่วมทุกฮิตหลังฮิตแรก))**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **80** → 80, 80, 80, 80, 80, 80, 80, 80, 80, 80 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type = 10` และ `PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type ≠ 11` และ มีเจมคาร์ท 301 หรือ ไม่มีเจมคาร์ท 301 และ `PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type = 10` และ `PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type ≠ 11`]: `(5 × Lv + baseDEX // 5 + 50) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type = 11` และ มีเจมคาร์ท 301 หรือ ไม่มีเจมคาร์ท 301 และ `PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type = 11` หรือ `PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type ≠ 10` และ `PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type ≠ 11` และ มีเจมคาร์ท 301]: **(50 + 5×Lv)%** → 55%, 60%, 65%, 70%, 75%, 80%, 85%, 90%, 95%, 100% (Lv1…10)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `target.ExpDefSkill / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefSkill` = proration ช่อง Skill ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_CharacterActionManagerBase` = ค่า Character Action Manager Base ของ MobActionManagerBase (ดูแท็บ Variables)

**จำนวนฮิต / ตัวนับ**
- `damageCount` (ตั้งใน `OnInitialize`) [`PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type = 11` และ มีเจมคาร์ท 301 หรือ `PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type = 10` และ `PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type ≠ 11` และ มีเจมคาร์ท 301 หรือ `PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type ≠ 10` และ `PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type ≠ 11` และ มีเจมคาร์ท 301]: 3, 3, 4, 4, 5, 5, 6, 6, 7, 7 (Lv1…10)
- `LoopParam` (ตั้งใน `OnInitialize`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
- `damageCount` (ตั้งใน `OnInitialize`) [ไม่มีเจมคาร์ท 301 และ `PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type = 11` หรือ ไม่มีเจมคาร์ท 301 และ `PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type = 10` และ `PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type ≠ 11` หรือ ไม่มีเจมคาร์ท 301 และ `PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type ≠ 10` และ `PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type ≠ 11`]: 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 (Lv1…10)
- `damageCount` (ตั้งใน `InitializeOthers`): `int(0.5 × motionSpeed + 0.5) + 1`
<!-- calc:end -->

### วอร์คราย (WarCry) · uid 43

<img src="../../icons/sk_043.png" width="40" alt="icon">

- ทรี: สกิลดาบ (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ควิกสแลช · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `WarCryAction` · สถานะการแกะ: แกะครบจากโค้ด

> คำรามเพื่อเพิ่มความมุ่งมั่น
> เพิ่ม ATK ชั่วขณะ
> และช่วยถอนสภาวะ[หวาดกลัว]ระหว่างสกิลแสดงผล

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, บัพปาร์ตี้/ผู้อื่น
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `WarCryBuf` ระยะเวลา `val & 255 = 10 ? Lv + 65 : Lv + 15` วินาที: ATK % (`AtkUpRate`) = `(val = 11 ? 5 : 0) + Lv`
- ตัวอ่านสกิลนี้ `KnightStanceBuf.GetFearResistValue` — KnightStanceBuf.GetFearResistValue: คืนค่า `((Lv + (Lv << 2)) << 1)` (2 กรณี) (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: [ได้รับผลแบบเดียวกันเมื่อใช้กับดาบคู่]  *ระยะแสดงผล+50 วิ
- Lv11: *เพิ่มปริมาณการเพิ่ม ATK

### ฟาสต์แอคแทค (FastAttack) · uid 47

<img src="../../icons/sk_047.png" width="40" alt="icon">

- ทรี: สกิลดาบ (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: ดาบมือเดียว, ดาบสองมือ · ธง: NoMarketSearch, MercenaryCanUseSkill
- คลาสในโค้ด: `FastAttackAction` · สถานะการแกะ: แกะครบจากโค้ด

> ลูกเตะที่ทำท่าน่าจะเจ็บแสบ
> สกิลนี้โจมตีด้วย[ความเคยชินตามปกติ]
> ถ้าสกิลเลเวลเต็มเมื่อไหร่จะเพิ่มผลลัพธ์ให้
> MP ที่ใช้ของสกิลถัดไปลดลง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ
- MP ที่ใช้ [อาวุธหลัก ดาบมือเดียว และ อาวุธรอง ดาบมือเดียว]: 200
- MP ที่ใช้ [อาวุธหลัก ดาบสองมือ หรือ อาวุธหลักอื่น (ไม่ใช่ ดาบมือเดียว/ดาบสองมือ) หรือ อาวุธหลัก ดาบมือเดียว และ อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว)]: 300
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: ธรรมดา (SkillNormal)
- Proration: ช่องตีปกติ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: ล้มคว่ำ (Tumble)
- บัพ `FastAttackBuf`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `PlayerAttackBase.CalcCostMp` — MP ที่ใช้ของสกิล: [call] `InflexibilityBuf$$CheckMpHalving` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Inflexibility), this` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill…; [call] `MultipleHuntBuf$$CheckMode` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt), SkillMode…` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill…; [set] `<CostMpType>k__BackingField` = `(CostMpType | 1)` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.RemoveAfterSkillBuf` — PlayerAttackBase.RemoveAfterSkillBuf: [call] `SkillBufferManager$$RemoveBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.FastAttack` เมื่อ (PlayerAttackBase.ContainsNotApplicableSkill(PlayerAttackBase.get_ActionID()) & 1) eq 0 AND (SkillBufferManager.Contain… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: *MP ที่ใช้-100 *มีโอกาสทำให้เป้าหมายล้มคว่ำ

<!-- calc:begin uid=47 -->
#### การคำนวณแบบตัวเลข — FastAttack (uid 47)
Proration: ช่อง `Normal` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): 12, 27, 48, 75, 108, 147, 192, 243, 300, 300 (Lv1…10)
  - สูตร: `fixAddDamage` — โดยที่ `fixAddDamage` = `System.Math.Min(300, 3 × (Lv + 1) × (Lv + 1))`
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบมือเดียว และ อาวุธรอง ดาบมือเดียว · AGI รวม=100 หรือ อาวุธหลัก ดาบมือเดียว และ อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว) · DEX รวม=100 หรือ อาวุธหลัก ดาบสองมือ · STR รวม=100]: 30%, 35%, 40%, 45%, 50%, 55%, 60%, 65%, 70%, 70% (Lv1…10)
  - สูตร: `(System.Math.Min(50, 5 × Lv + 5) + AGIรวม // 5) / 100`
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบมือเดียว และ อาวุธรอง ดาบมือเดียว · AGI รวม=255 หรือ อาวุธหลัก ดาบมือเดียว และ อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว) · DEX รวม=255 หรือ อาวุธหลัก ดาบสองมือ · STR รวม=255]: 61%, 66%, 71%, 76%, 81%, 86%, 91%, 96%, 101%, 101% (Lv1…10)
  - สูตร: `(System.Math.Min(50, 5 × Lv + 5) + AGIรวม // 5) / 100`
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ ดาบมือเดียว/ดาบสองมือ)]: 10%, 15%, 20%, 25%, 30%, 35%, 40%, 45%, 50%, 50% (Lv1…10)
  - สูตร: `System.Math.Min(50, 5 × Lv + 5) / 100`
<!-- calc:end -->

### สตรอมเบลซ (StormBlazer) · uid 54

<img src="../../icons/sk_054.png" width="40" alt="icon">

- ทรี: สกิลดาบ (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: ดาบสองมือ · ต้องเรียนก่อน: คลีฟวิงแอคแทค
- คลาสในโค้ด: `StormBlazerAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีศัตรูเป็นเส้นตรงด้วยใบมีดสุญญากาศ
> พลังลมจะสะสมเมื่อโจมตีปกติ
> 
> พลังลมจะถูกใช้เมื่อเปิดใช้งานสกิล
> พลัง/ระยะการโจมตี/การฟื้นฟู MP
> จะเพิ่มขึ้นตามจำนวนที่ใช้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `StormBlazerBuf`: บัพนับสแตก (สืบจาก `CountBufferBase`): ตัวนับ `Count` เริ่ม 0 เพิ่มทีละ 1 ด้วย `Next()` และสูงสุด ((bDex // 25) + 10); โค้ดอื่นอ่านจำนวนสแตกผ่านพารามิเตอร์ `Count` (ดูค่าที่ใช้จริงในสูตรของสกิลที่อ้างถึง)
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = ((bDex // 25) + 10) ตามที่ `StormBlazerBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `StormBlazerAction.StackStormBlazer` — StormBlazerAction.StackStormBlazer: [call] `SkillUtil$$CheckSkillEquipLimit` = `PlayerStatusBase.get_EquipItemData(), MasterSkillDataManager.GetSkillMaster(Singleton<Mas…` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.StormBlazer, 1) ge 1; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new StormBlazerBuf, 0` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.StormBlazer, 1) ge 1 AND (SkillUtil.CheckSkillEqui… (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=54 -->
#### การคำนวณแบบตัวเลข — StormBlazer (uid 54)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [VIT รวม=100]: **200 + 10×Lv** → 210, 220, 230, 240, 250, 260, 270, 280, 290, 300 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [VIT รวม=255]: **355 + 10×Lv** → 365, 375, 385, 395, 405, 415, 425, 435, 445, 455 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate` หรือ `StormBlazerBuf.Pay(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 54)) ≥ 1` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 54) ≠ 0` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 54).IsEnd ≠ 0` และ มีเจมคาร์ท 309 หรือ ไม่มีเจมคาร์ท 309 และ `StormBlazerBuf.Pay(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 54)) ≥ 1` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 54) ≠ 0` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 54).IsEnd ≠ 0` หรือ `StormBlazerBuf.Pay(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 54)) ≥ 1` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 54) ≠ 0` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 54).IsEnd = 0` และ มีเจมคาร์ท 309]: **(50 + 5×Lv)%** → 55%, 60%, 65%, 70%, 75%, 80%, 85%, 90%, 95%, 100% (Lv1…10)
<!-- calc:end -->

### เมเทโอเบรคเกอร์ (MeteorBreaker) · uid 44

<img src="../../icons/sk_044.png" width="40" alt="icon">

- ทรี: สกิลดาบ (ขั้น 4) · เลเวลสูงสุด: 150 · อาวุธ: ดาบมือเดียว, ดาบสองมือ · ต้องเรียนก่อน: ทริกเกอร์สแลช · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `MeteoBreakerAction` · สถานะการแกะ: แกะครบจากโค้ด

> การโจมตีอันแข็งแกร่งราวกับดาวตก
> เป้าหมายมีโอกาสโดน "ตาลาย" และ
> เพิ่มการโจมตีบริเวณโดยรอบเมื่อถึงพื้น
> มีสถานะคงกระพันระหว่างใช้สกิล

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `abnormalPercent` [อาวุธหลัก ดาบมือเดียว และ อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว) หรือ อาวุธหลัก ดาบมือเดียว และ อาวุธรอง ดาบมือเดียว]: 77, 80, 82, 85, 87, 90, 92, 95, 97, 100 (Lv1…10) %
- โอกาสติดสถานะ `abnormalPercent` [อาวุธหลัก ดาบสองมือ หรือ อาวุธหลักอื่น (ไม่ใช่ ดาบมือเดียว/ดาบสองมือ)]: 2, 5, 7, 10, 12, 15, 17, 20, 22, 25 (Lv1…10) %
- สถานะที่ทำให้ติด: มึนงง (Dizzy)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: *พลังโจมตีขั้นที่ 2 เพิ่มขึ้นตามค่า DEX *อัตราติดตาลาย+75%
- Lv10: *อัตราติดตาลาย+75%
- Lv11: *พลังโจมตีขั้นที่ 1+200 *พลังโจมตีขั้นที่ 1 เพิ่มขึ้นตามค่า STR

<!-- calc:begin uid=44 -->
#### การคำนวณแบบตัวเลข — MeteorBreaker (uid 44)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `isFirstAttack ≠ 0` · ส่วน เป้าหลัก (`target…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **400 + 20×Lv** → 420, 440, 460, 480, 500, 520, 540, 560, 580, 600 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบสองมือ]: `(20 × Lv + baseSTR // 10 + 600) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseSTR` = แต้ม STR ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseSTR (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ ดาบมือเดียว/ดาบสองมือ) หรือ อาวุธหลัก ดาบมือเดียว และ อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว) หรือ อาวุธหลัก ดาบมือเดียว และ อาวุธรอง ดาบมือเดียว]: **(400 + 20×Lv)%** → 420%, 440%, 460%, 480%, 500%, 520%, 540%, 560%, 580%, 600% (Lv1…10)

**ฮิต 2: `calcPlayerToMobDamage` (ดาเมจหลัก) — `isFirstAttack = 0` · ส่วน ระยะ (`range…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **0** → 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบมือเดียว และ อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว)]: `(50 × Lv + baseDEX ÷ 2 + 100) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบสองมือ หรือ อาวุธหลักอื่น (ไม่ใช่ ดาบมือเดียว/ดาบสองมือ) หรือ อาวุธหลัก ดาบมือเดียว และ อาวุธรอง ดาบมือเดียว]: **(100 + 50×Lv)%** → 150%, 200%, 250%, 300%, 350%, 400%, 450%, 500%, 550%, 600% (Lv1…10)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `targetExpRegister / 100` — โดยที่ `targetExpRegister` = `target.ExpDefSkill` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**ใช้ร่วมทุกฮิตของ ดาเมจหลัก**
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `target.ExpDefSkill / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefSkill` = proration ช่อง Skill ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
<!-- calc:end -->

### บัสตาร์ดเบลด (BusterBlade) · uid 45

<img src="../../icons/sk_045.png" width="40" alt="icon">

- ทรี: สกิลดาบ (ขั้น 4) · เลเวลสูงสุด: 150 · อาวุธ: ดาบมือเดียว, ดาบสองมือ · ต้องเรียนก่อน: สไปรัลแอร์ · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `BusterBladeAction` · สถานะการแกะ: แกะครบจากโค้ด

> รวบรวมออร่าและฟันอย่างต่อเนื่อง
> เพิ่ม ATK อาวุธไม่กี่วินาทีเมื่อใช้บัสตาร์ดเบลดสำเร็จ
> ฟื้นฟู HP จำนวนเล็กน้อยเมื่อติดบัฟ
> บัฟนี้จะไม่มีการทับซ้อนกัน

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `BusterBladeBuf` ระยะเวลา 10 วินาที: ATK อาวุธ % (`EqAtkUpRate`) = `min(Lv + shildRefine, 25)`
- ตัวอ่านสกิลนี้ `BusterBladeAction.<>c__DisplayClass22_0.<ActionStart>b__0` — <>c__DisplayClass22_0.<ActionStart>b__0: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.BusterBlade, [<>c__DisplayClass22_0.<>…` เมื่อ (cancel & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.BusterBlade… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `BusterBladeAction.ActionStart` — BusterBladeAction: ตอนเริ่มทำงานของสกิล (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `TwinBusterBladeAction.<>c__DisplayClass39_0.<ActionStart>b__0` — <>c__DisplayClass39_0.<ActionStart>b__0: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.BusterBlade, <>c__DisplayClass39_0.sLv…` เมื่อ (cancel & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.BusterBlade… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `TwinBusterBladeAction.ActionStart` — TwinBusterBladeAction: ตอนเริ่มทำงานของสกิล (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: *พลังเพิ่มขึ้นตามค่า DEX *ปริมาณการฟื้นฟู HP เพิ่มขึ้นตาม VIT
- Lv10: *ปริมาณการฟื้นฟู HP เพิ่มขึ้นตาม VIT
- Lv11: *พลังเพิ่มขึ้นตามค่า STR
- Lv17: *อาวุธATKและปริมาณการฟื้นฟู HP เพิ่มขึ้นตามประสิทธิภาพของโล่

<!-- calc:begin uid=45 -->
#### การคำนวณแบบตัวเลข — BusterBlade (uid 45)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **30×Lv** → 30, 60, 90, 120, 150, 180, 210, 240, 270, 300 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบมือเดียว และ อาวุธรอง โล่ และ `Lv สกิล 50 AuraBlade ≥ 1` หรือ อาวุธหลัก ดาบมือเดียว และ อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว/โล่) และ `Lv สกิล 50 AuraBlade ≥ 1`]: `(75 × Lv + 2 × (baseDEX ÷ 2) + 20 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 50, 1)) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX …(+3) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบมือเดียว และ อาวุธรอง โล่ และ `Lv สกิล 50 AuraBlade < 1` หรือ อาวุธหลัก ดาบมือเดียว และ อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว/โล่) และ `Lv สกิล 50 AuraBlade < 1`]: `(75 × Lv + baseDEX ÷ 2) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบมือเดียว และ อาวุธรอง ดาบมือเดียว และ `Lv สกิล 50 AuraBlade ≥ 1` · Lv สกิล 50 AuraBlade=1]: **(20 + 75×Lv)%** → 95%, 170%, 245%, 320%, 395%, 470%, 545%, 620%, 695%, 770% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบมือเดียว และ อาวุธรอง ดาบมือเดียว และ `Lv สกิล 50 AuraBlade ≥ 1` · Lv สกิล 50 AuraBlade=10]: **(200 + 75×Lv)%** → 275%, 350%, 425%, 500%, 575%, 650%, 725%, 800%, 875%, 950% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ ดาบมือเดียว/ดาบสองมือ) และ อาวุธรอง โล่ หรือ อาวุธหลักอื่น (ไม่ใช่ ดาบมือเดียว/ดาบสองมือ) และ อาวุธรองอื่น (ไม่ใช่ โล่) หรือ อาวุธหลัก ดาบมือเดียว และ อาวุธรอง ดาบมือเดียว และ `Lv สกิล 50 AuraBlade < 1`]: **(75×Lv)%** → 75%, 150%, 225%, 300%, 375%, 450%, 525%, 600%, 675%, 750% (Lv1…10)
<!-- calc:end -->

### เบอร์เซิร์ก (Berserk) · uid 46

<img src="../../icons/sk_046.png" width="40" alt="icon">

- ทรี: สกิลดาบ (ขั้น 4) · เลเวลสูงสุด: 150 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: วอร์คราย
- คลาสในโค้ด: `BerserkAction` · สถานะการแกะ: แกะครบจากโค้ด

> ละทิ้งการขบคิดและกวัดแกว่งอาวุธดังนักรบคลั่ง
> เพิ่มการโจมตีปกติ/ความเร็วการโจมตี/อัตราคริติคอลชั่วขณะ
> และลดความเสถียร/DEF/MDEF ลงเป็นจำนวนมาก
> ระหว่างแสดงผลรัมเพจจะไม่ถูกลบออกจากสภาวะผิดปกติ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, เพิ่มดาเมจตีปกติ
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `BerserkBuf` ระยะเวลา 10 วินาที: ตัวคูณตีปกติ % (`NormalAttackRate`) = 10×Lv → 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10) · ความเสถียร (`Stable`) = `-max((stable - (damageCount * reduceValue)), 0)` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ความเร็วโจมตี % (`AspdRate`) = 10×Lv → 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10) · ความเร็วโจมตี + (`Aspd`) = 100×Lv → 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 (Lv1…10) · MDEF % (`MdefRate`) = `-max((defRate - (damageCount * reduceValue)), 0)` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · DEF % (`DefRate`) = `-max((defRate - (damageCount * reduceValue)), 0)` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · อัตราคริ + (`CrtUp`) = 2, 5, 7, 10, 12, 15, 17, 20, 22, 25 (Lv1…10)
- ตัวอ่านสกิลนี้ `AutoMemberActionManager.Damaged` — AutoMemberActionManager: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Rampage` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND (CharacterActionManagerBase.get_IsLoc…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Rampage` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND (CharacterActionManagerBase.get_IsLoc… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GemCartBuffer.BerserkSuppressionBuff.Exemption` — BerserkSuppressionBuff.Exemption: [call] `MathUtil$$CheckPercent` = `((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.Berserk, 1) + (Ski…` เมื่อ (GemCartBufferManager.ContainsBuffer(PlayerStatusBase.get_GemCartBuffManager(), 401) & 1) ne 0 AND (SkillBufferManager.… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `HorizontalCutAction.Damaged` — HorizontalCutAction: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `MathUtil$$CheckPercent` = `((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.Berserk, 1) + (Ski…` เมื่อ (SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) & 1) eq 0 AND SkillActionBase.get_ActionID()…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Rampage` เมื่อ (SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) & 1) eq 0 AND SkillActionBase.get_ActionID()…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Rampage` เมื่อ (SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) & 1) eq 0 AND SkillActionBase.get_ActionID()… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MercenaryActionManager.Damaged` — MercenaryActionManager: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Rampage` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(Pl…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Rampage` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(Pl…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Rampage` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND damageData.AbnormalType ne 0 AND dama… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `RampageAction.ReceivedAbnormal` — RampageAction.ReceivedAbnormal: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Rampage` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Rampage, out) & 1) ne 0 AND (SkillBuff… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SacrificeAction.ActionStart` — SacrificeAction: ตอนเริ่มทำงานของสกิล: [call] `MathUtil$$CheckPercent` = `((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.Berserk, 1) + (Ski…` เมื่อ (UnityEngine.Object.op_Equality(actarAction, 0) & 1) eq 0 AND (GemCartBufferManager.ContainsBuffer(PlayerStatusBase.get…; [set] `<SkillIndividualFlag>k__BackingField` = `1` เมื่อ (UnityEngine.Object.op_Equality(actarAction, 0) & 1) eq 0 AND (GemCartBufferManager.ContainsBuffer(PlayerStatusBase.get… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SacrificeAction.StrengthPayHp` — SacrificeAction.StrengthPayHp: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Rampage` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (CharacterActionManagerBase.AddAbnormalState(UnityEngin… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `WeirdnessOfGodAction.ActionStart` — WeirdnessOfGodAction: ตอนเริ่มทำงานของสกิล: [call] `MathUtil$$CheckPercent` = `((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.Berserk, 1) + (Ski…` เมื่อ (UnityEngine.Object.op_Equality(actarAction, 0) & 1) eq 0 AND (GemCartBufferManager.ContainsBuffer(PlayerStatusBase.get…; [set] `flag` = `(flag | 1)` เมื่อ (UnityEngine.Object.op_Equality(actarAction, 0) & 1) eq 0 AND (GemCartBufferManager.ContainsBuffer(PlayerStatusBase.get… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `WeirdnessOfGodAction.EffectiveAbnormalIgnition` — WeirdnessOfGodAction.EffectiveAbnormalIgnition: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Rampage` เมื่อ (SkillActionBase.op_Equality(skill, 0) & 1) eq 0 AND PlayerAttackBase.get_ActionID() eq 622 AND (CharacterActionManager… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: *ลดการลดลงของความเสถียร *ลดการลดลงของ DEF(ยกเว้นดาบคู่) *ลดการลดลงของ MDEF(ยกเว้นดาบคู่) *ระยะเวลา +20 วินาที
- Lv11: *เพิ่มปริมาณการเพิ่มอัตราคริติคอล *ลดการลดลงของความเสถียร *ระยะเวลาแสดงผล +20 วินาที

### การ์ดเบลด (GuardyBlade) · uid 55

<img src="../../icons/sk_055.png" width="40" alt="icon">

- ทรี: สกิลดาบ (ขั้น 4) · เลเวลสูงสุด: 150 · อาวุธ: ดาบสองมือ · ต้องเรียนก่อน: สตรอมเบลซ
- คลาสในโค้ด: `GuardyBladeAction` · สถานะการแกะ: แกะครบจากโค้ด

> เทคนิคการป้องกันโดยใช้ดาบสองมือ
> เป็นเวลา 70 วินาที ความต้านทานกายภาพ/เวท
> และประสิทธิภาพ Guard จะเพิ่มขึ้น
> 
> ฟื้นฟูพลัง Guard เล็กน้อยเมื่อใช้บัฟ
> การฟื้นฟูนี้จะไม่ถูกใช้งานโดยการบันทึกทับ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `GuardyBladeBuf` ระยะเวลา 70 วินาที: ลดดาเมจกายภาพที่ได้รับ (`PowerDmgCut`) = 2×Lv → 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 (Lv1…10) · ลดดาเมจเวทที่ได้รับ (`MagicDmgCut`) = Lv → 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `EquipItemData.CalcEqDef` — คำนวณ eq def (EquipItemData): คืนค่า `((_t248 + ItemData.get_Refine(EquipItemData.get_Option(this))) + ItemData.get_Refine(EquipItemData.get_Body(this)))` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobAttackBase.SetAbnormalEffect` — MobAttackBase.SetAbnormalEffect (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv11: *ระหว่างแสดงผลค่าถลุงอาวุธจะใช้เป็นค่าถลุงโล่ *การฟื้นฟูพลัง Guard จะได้รับอิทธิพลจากค่า VIT และไม่สามารถฟื้นฟูได้มากกว่า 100% *เมื่อจัสการ์ดสำเร็จภาวะผิดปกติประเภทเคลื่อนไหวไม่ได้จะไม่มีผล *ถ้าอยู่ในสภาวะการ์ดแครชผลของบัฟจะสิ้นสุดทันที และไม่สามารถใช้งานได้อีกจนกว่าจะฟื้นฟูจากสภาวะแครชได้

### ชัทเอาท์ (ShutOut) · uid 48

<img src="../../icons/sk_048.png" width="40" alt="icon">

- ทรี: สกิลดาบ (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: ดาบมือเดียว, ดาบสองมือ · ต้องเรียนก่อน: รัมเพจ
- คลาสในโค้ด: `ShutOutAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีอย่างไร้ปราณี
> ถ้าเป้าหมายไม่อยู่ในสภาวะผงะ/ล้มคว่ำ/หมดสติหรือเลือดออก
> จะเพิ่มความเสียหายและติด[เลือดออก]ให้เป้าหมาย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: เลือดไหล (Bleed)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: *พลังเพิ่มขึ้นอีกตามค่า DEX ของตัวเอง
- Lv10: *พลังเพิ่มขึ้นอีกตามค่า AGI ของตัวเอง
- Lv11: *พลังพื้นฐานจะเพิ่มขึ้นตามสกิลเลเวล แต่พลังจะเพิ่มขึ้นน้อยมากเมื่อตรงตามเงื่อนไข

<!-- calc:begin uid=48 -->
#### การคำนวณแบบตัวเลข — ShutOut (uid 48)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) · ส่วน โบนัส (`bonus…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [อาวุธหลัก ดาบมือเดียว และ อาวุธรอง ดาบมือเดียว]: **200** → 200, 200, 200, 200, 200, 200, 200, 200, 200, 200 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [อาวุธหลัก ดาบสองมือ หรือ อาวุธหลักอื่น (ไม่ใช่ ดาบมือเดียว/ดาบสองมือ) หรือ อาวุธหลัก ดาบมือเดียว และ อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว)]: **100** → 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 (Lv1…10)
- หักป้องกันเป้า (`Def`, +, ตั้งค่าทับ) [`MobActionManagerBase.get_AbnormalStateManager(mobAction).IsActionLock ≠ 0` และ `bleed ≠ 0` หรือ `(MobActionManagerBase.get_AbnormalStateManager(mobAction).IsActionLock & 1) ≠ 0` และ `MobActionManagerBase.get_AbnormalStateManager(mobAction).IsActionLock = 0`]: `-ShutOutAction.CalcBonusResistDamage(this, PlayerActionManagerBase.get_PlayerStatus(), เป้า)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `ShutOutAction.CalcBonusResistDamage` = คำนวณ bonus resist damage (ShutOutAction); `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `MobActionManagerBase.get_MobBattleStatus` = ค่า Mob Battle Status ของ MobActionManagerBase (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบมือเดียว และ อาวุธรอง ดาบมือเดียว]: `(baseAGI ÷ 4 + 500) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseAGI` = แต้ม AGI ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseAGI; `baseAGI` = แต้ม AGI ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseAGI; `baseAGI` = แต้ม AGI ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseAGI (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบมือเดียว และ อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว)]: `(baseDEX ÷ 2 + 500) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบมือเดียว และ อาวุธรอง ดาบมือเดียว และ `MobActionManagerBase.get_AbnormalStateManager(mobAction).IsActionLock ≠ 0` และ `bleed ≠ 0` หรือ อาวุธหลัก ดาบมือเดียว และ อาวุธรอง ดาบมือเดียว และ `(MobActionManagerBase.get_AbnormalStateManager(mobAction).IsActionLock & 1) ≠ 0` และ `MobActionManagerBase.get_AbnormalStateManager(mobAction).IsActionLock = 0`]: `(150 × Lv + baseAGI ÷ 4 + 500) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseAGI` = แต้ม AGI ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseAGI; `baseAGI` = แต้ม AGI ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseAGI; `baseAGI` = แต้ม AGI ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseAGI (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบมือเดียว และ อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว) และ `MobActionManagerBase.get_AbnormalStateManager(mobAction).IsActionLock ≠ 0` และ `bleed ≠ 0` หรือ อาวุธหลัก ดาบมือเดียว และ อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว) และ `(MobActionManagerBase.get_AbnormalStateManager(mobAction).IsActionLock & 1) ≠ 0` และ `MobActionManagerBase.get_AbnormalStateManager(mobAction).IsActionLock = 0`]: `(150 × Lv + baseDEX ÷ 2 + 500) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ ดาบมือเดียว/ดาบสองมือ) หรือ อาวุธหลัก ดาบสองมือ และ `MobActionManagerBase.get_AbnormalStateManager(mobAction).IsActionLock ≠ 0` และ `bleed ≠ 0` หรือ อาวุธหลัก ดาบสองมือ และ `(MobActionManagerBase.get_AbnormalStateManager(mobAction).IsActionLock & 1) ≠ 0` และ `MobActionManagerBase.get_AbnormalStateManager(mobAction).IsActionLock = 0`]: **500%** → 500%, 500%, 500%, 500%, 500%, 500%, 500%, 500%, 500%, 500% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบสองมือ]: **(500 + 100×Lv)%** → 600%, 700%, 800%, 900%, 1000%, 1100%, 1200%, 1300%, 1400%, 1500% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ ดาบมือเดียว/ดาบสองมือ) และ `MobActionManagerBase.get_AbnormalStateManager(mobAction).IsActionLock ≠ 0` และ `bleed ≠ 0` หรือ อาวุธหลักอื่น (ไม่ใช่ ดาบมือเดียว/ดาบสองมือ) และ `(MobActionManagerBase.get_AbnormalStateManager(mobAction).IsActionLock & 1) ≠ 0` และ `MobActionManagerBase.get_AbnormalStateManager(mobAction).IsActionLock = 0`]: **(500 + 150×Lv)%** → 650%, 800%, 950%, 1100%, 1250%, 1400%, 1550%, 1700%, 1850%, 2000% (Lv1…10)
<!-- calc:end -->

### ลูนาร์สแลช (MoonSlash) · uid 49

<img src="../../icons/sk_049.png" width="40" alt="icon">

- ทรี: สกิลดาบ (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: ดาบมือเดียว, ดาบสองมือ · ต้องเรียนก่อน: เมเทโอเบรคเกอร์
- คลาสในโค้ด: `MoonSlashAction` · สถานะการแกะ: แกะครบจากโค้ด

> ฟาดฟันเป้าหมายและดาบเวทมนตร์
> จะสร้างความเสียหายเพิ่มหลังจากนั้นเล็กน้อย
> 
> ดาบเวทมนตร์อาจทำให้ติดสภาวะ[เหนื่อยล้า]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 2 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: Tiredness (Tiredness)
- บัพ `MoonSlashBuf`: บัพนับสแตก (สืบจาก `CountBufferBase`): ตัวนับ `Count` เริ่ม 0 เพิ่มทีละ 1 ด้วย `Next()` และสูงสุด 9; โค้ดอื่นอ่านจำนวนสแตกผ่านพารามิเตอร์ `Count` (ดูค่าที่ใช้จริงในสูตรของสกิลที่อ้างถึง)
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 9 ตามที่ `MoonSlashBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `MoonSlashAction.ReceiveMobaAttack` — MoonSlashAction.ReceiveMobaAttack: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new MoonSlashBuf, 0` เมื่อ (Toram.Common.Actions.ActionAppendData.Contains(response.AppendData, 49) & 1) ne 0 AND (SkillBufferManager.TryGetBuf(Pl… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv11: จะเกิดการโจมตีเพิ่มเมื่อใช้สกิลโจมตีอื่น การโจมตีเพิ่มนี้ไม่สามารถทำให้ติดสภาวะเหนื่อยล้า แต่อัตราคริติคอลจะสูงขึ้นตามสกิลเลเวล

<!-- calc:begin uid=49 -->
#### การคำนวณแบบตัวเลข — MoonSlash (uid 49)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `CalcFirstDamageData` · ส่วน ครั้งแรก (`first…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **400** → 400, 400, 400, 400, 400, 400, 400, 400, 400, 400 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **1000%** → 1000%, 1000%, 1000%, 1000%, 1000%, 1000%, 1000%, 1000%, 1000%, 1000% (Lv1…10)

**ฮิต 2: `CalcSecondDamageData` · ส่วน ครั้งที่ 2 (`second…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `secondFixAddDamage` — โดยที่ `secondFixAddDamage` = `baseINT ÷ 2` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [STR รวม=100]: **(10×Lv)%** → 10%, 20%, 30%, 40%, 50%, 60%, 70%, 80%, 90%, 100% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [STR รวม=255]: **(25.5×Lv)%** → 25.5%, 51%, 76.5%, 102%, 127.5%, 153%, 178.5%, 204%, 229.5%, 255% (Lv1…10)
<!-- calc:end -->

### ออร่าเบลด (AuraBlade) · uid 50

<img src="../../icons/sk_050.png" width="40" alt="icon">

- ทรี: สกิลดาบ (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: ดาบมือเดียว, ดาบสองมือ · ต้องเรียนก่อน: บัสตาร์ดเบลด
- คลาสในโค้ด: `AuraBladeAction` · สถานะการแกะ: แกะครบจากโค้ด

> ฟาดฟันด้วยดาบที่มีออร่าล้อมรอบ
> พลังของสกิลถัดไปที่ใช้จะเพิ่ม 1.2 เท่า
> โจมตีระยะประชิดเพิ่ม 100% ระหว่างที่ใช้งาน

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `AuraBladeBuf` ระยะเวลา 40 วินาที: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `lastDamageRate` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ตัวคูณโจมตีไล่ตามกายภาพ (`PhysicalPursuitSkillRate`) = `percent` (ตัวนับที่เปลี่ยนตามเหตุการณ์)
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `BusterBladeAction.<>c__DisplayClass22_0.<ActionStart>b__0` — <>c__DisplayClass22_0.<ActionStart>b__0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `BusterBladeAction.OnInitialize` — BusterBladeAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `skillRate` = `(_t111 + _t113)` เมื่อ PlayerAttackBase.GetWeaponType(actarAction, out) eq 10 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(),… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PhysicalPursuitAction.calcPlayerToMobDamage` — PhysicalPursuitAction: สูตรดาเมจผู้เล่น→มอนสเตอร์ (ใส่ค่าลง template) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.ApplyAuraBlade` — PlayerAttackBase.ApplyAuraBlade: [set] `auraBladeLastDamageRate` = `SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), Ski…` เมื่อ (SkillParam & 1296) eq 0 AND (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.AuraBlade…; [call] `AuraBladeBuf$$CheckPersistent` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.AuraBlade)` เมื่อ (SkillParam & 1296) eq 0 AND (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.AuraBlade…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.AuraBlade` เมื่อ (SkillParam & 1296) eq 0 AND (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.AuraBlade… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.PursuitAttack` — PlayerBattleManager.PursuitAttack: [call] `MathUtil$$CheckPercent` = `(SkillMasteryBase.GetMasteryParam(MasteryId.Percent) + 25)` เมื่อ (System.Linq.Enumerable.Any<SkillActionBase.DamageData>(action.targetDamageData, PlayerBattleManager.<>c.<>9__112_0) & …; [call] `MathUtil$$CheckPercent` = `25` เมื่อ (System.Linq.Enumerable.Any<SkillActionBase.DamageData>(action.targetDamageData, PlayerBattleManager.<>c.<>9__112_0) & … (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: *บัฟจะไม่ถูกใช้ *บัฟของออร่าเบลดจะเพิ่มขึ้น 10 วินาที เมื่อได้รับบัฟของสกิล[บัสตาร์ดเบลด] *พลังของบัสตาร์ดเบลดเพิ่มขึ้นตาม Lv ที่เรียนรู้
- Lv10: *พลังของสกิลถัดไปที่ใช้จะแข็งแกร่งขึ้นอีก 1.1 เท่า
- Lv11: *โจมตีระยะประชิดเพิ่มที่ได้รับจะลดลงเหลือ 50% *พลังของสกิลถัดไปที่ใช้จะแข็งแกร่งขึ้นอีก 1.3 เท่า

<!-- calc:begin uid=50 -->
#### การคำนวณแบบตัวเลข — AuraBlade (uid 50)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`maxAttackCount ≥ 2` หรือ `maxAttackCount < 2`]: **200** → 200, 200, 200, 200, 200, 200, 200, 200, 200, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`maxAttackCount ≥ 2` หรือ `maxAttackCount < 2`]: **(500 + 100×Lv)%** → 600%, 700%, 800%, 900%, 1000%, 1100%, 1200%, 1300%, 1400%, 1500% (Lv1…10)

**จำนวนฮิต / ตัวนับ**
- `maxAttackCount` (ตั้งใน `OnInitialize`) [อาวุธหลัก ดาบมือเดียว]: 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 (Lv1…10)
- `maxAttackCount` (ตั้งใน `ActionPreparation`) [อาวุธหลัก ดาบมือเดียว และ มีเจมคาร์ท 1041]: 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 (Lv1…10)
- `damageCount` (ตั้งใน `NextRangeHit`): `damageCount + 1`
<!-- calc:end -->

### แกลดดีเอท (Gladiate) · uid 51

<img src="../../icons/sk_051.png" width="40" alt="icon">

- ทรี: สกิลดาบ (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: ดาบมือเดียว, ดาบสองมือ · ต้องเรียนก่อน: เบอร์เซิร์ก
- คลาสในโค้ด: `GladiateAction` · สถานะการแกะ: แกะครบจากโค้ด

> ลดความเสียหายที่ได้รับตามจำนวนครั้งที่กำหนด
> เป็นเวลา 10 วินาที MP จะฟื้นฟูเล็กน้อยเมื่อลดความเสียหาย
> 
> จะฟื้นฟู 10 MP ต่อจำนวนครั้งที่เหลือเมื่อเวลาหมดลง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `GladiateBuf`: ตัวคูณดาเมจที่ได้รับจากมอน (หมวดบัพ) (`MobLastDamageRateBuf`) = `2 × damageReduction`
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = Lv ตามที่ `GladiateBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `MobAttackBase.CalcLastDamage` — คำนวณ last damage (MobAttackBase): คืนค่า `((SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.ArkSaber, out) & 1) eq 0 ? ((_t983 & 1) eq 0 ? ((_t982 & 1) eq 0 ? _t997 : _t…` (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: *ปริมาณการฟื้นฟู MP จะเพิ่มขึ้นเมื่อความเสียหายลดลง
- Lv10: *ปริมาณการฟื้นฟู MP จะลดลงครึ่งหนึ่งเมื่อความเสียหายลดลง *การลดความเสียหายเพิ่มเป็น 2 เท่า
- Lv11: *ปริมาณการฟื้นฟู MP จะเพิ่มขึ้นเล็กน้อยเมื่อความเสียหายลดลง *การลดความเสียหายเพิ่มเป็น 2 เท่า
- Lv17: *การลดความเสียหายเพิ่มเป็น 2 เท่า

### ออร์คสแลช (Orgaslash) · uid 56

<img src="../../icons/sk_056.png" width="40" alt="icon">

- ทรี: สกิลดาบ (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: ดาบสองมือ · ต้องเรียนก่อน: การ์ดเบลด
- คลาสในโค้ด: `OrgaslashAction` · สถานะการแกะ: แกะครบจากโค้ด

> สร้างความเสียหายให้กับเป้าหมาย
> และหลังจากนั้นครู่หนึ่งจะเกิดการระเบิดที่
> เท้าของเป้าหมายสร้างความเสียหายเพิ่มเติม
> เมื่อเข้าเงื่อนไขจะสะสมพลังปีศาจ
> และจะใช้พลังปีศาจเปิดใช้งานสกิล
> เพื่อเพิ่มพลังและผลของบัฟ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ, เปลี่ยนการทำงานของตีปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: None (None)
- บัพ `OrgaslashBuf`: บัพนับสแตก (สืบจาก `CountBufferBase`): ตัวนับ `Count` เริ่ม 0 เพิ่มทีละ 1 ด้วย `Next()` และสูงสุด 20; โค้ดอื่นอ่านจำนวนสแตกผ่านพารามิเตอร์ `Count` (ดูค่าที่ใช้จริงในสูตรของสกิลที่อ้างถึง)
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 20 ตามที่ `OrgaslashBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `GameManager.ReceivesSupportDelay` — GameManager.ReceivesSupportDelay: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerDataManager.get_SkillBufferManager(playerManager), new OrgaslashBuf, 0` เมื่อ (skillId & 0xffff) le 721 AND (skillId & 0xffff) le 230 AND (skillId & 0xffff) eq 56 AND (SkillBufferManager.TryGetBuf<… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobAttackBase.CalcLastDamage` — คำนวณ last damage (MobAttackBase): [call] `OrgaslashBuf$$CheckValidEffect` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Orgaslash)` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Orgaslash, out) & 1) ne 0 AND TryGetBu…; [call] `PlayerAttackBase$$CheckSkillIndividualFlag` = `SkillActionManagerBase.get_CurrentSkill(), 2` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Orgaslash, out) & 1) ne 0 AND TryGetBu…; [call] `OrgaslashBuf$$CheckValidEffect` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Orgaslash)` เมื่อ (_t853 & 1) ne 0 AND PlayerStatusBase.get_SkillBufferManager().skillBufList[SkillId.GodHand].isSkillEnd eq 0 AND (MobAt… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `OrgaslashAction.CheckStack` — ตรวจ stack (OrgaslashAction): คืนค่า `(OrgaslashAction.CheckStack(playerAction, out) & 1)`; [call] `SkillUtil$$CheckSkillEquipLimit` = `PlayerStatusBase.get_EquipItemData(), MasterSkillDataManager.GetSkillMaster(Singleton<Mas…` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.Orgaslash, 1) ge 1 (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv11: *พลังปีศาจสะสมเมื่อการต่อสู้เริ่มต้น/ เหยียบพื้นเตือน/จัสการ์ดสำเร็จ(สูงสุด20)  *ประสิทธิภาพของรัมเพจเพิ่มขึ้นระหว่างบัฟแสดงผล *ฟื้นฟู HP เล็กน้อยขึ้นอยู่กับ MP ที่ใช้ระหว่างบัฟแสดงผล

<!-- calc:begin uid=56 -->
#### การคำนวณแบบตัวเลข — Orgaslash (uid 56)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `singleAttack ≠ 0` · ส่วน โจมตีเดี่ยว (`singleAttack…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [DEX รวม=100]: **100** → 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [DEX รวม=255]: **255** → 255, 255, 255, 255, 255, 255, 255, 255, 255, 255 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `singleAttackSkillRate`]: `(baseVIT + baseSTR) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseVIT` = แต้ม VIT ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseVIT; `baseSTR` = แต้ม STR ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseSTR (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`((buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) + ((((OrgaslashBuf.Pay(new OrgaslashBuf) & 255) << 2) + OrgaslashBuf.Pay(new OrgaslashBuf)) << 1)) ≥ 101`]: `singleAttackSkillRate / 100` — โดยที่ `singleAttackSkillRate` = `baseVIT + baseSTR` หรือ `singleAttackSkillRate + buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51) + 8 × (A & 255) + 2 × A - 100` (`A = OrgaslashBuf.Pay(new, OrgaslashBuf)`) [`((buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) + ((((OrgaslashBuf.Pay(new OrgaslashBuf) & 255) << 2) + OrgaslashBuf.Pay(new OrgaslashBuf)) << 1)) ≥ 101`] หรือ `singleAttackSkillRate + buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51) + 8 × (A & 255) + 2 × A - 100` (`A = OrgaslashBuf.Pay(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 56))`) [`((buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) + ((((OrgaslashBuf.Pay(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 56)) & 255) << 2) + OrgaslashBuf.Pay(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 56))) << 1)) ≥ 101` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 56) ≠ 0`] หรือ `singleAttackSkillRate + buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51) - 100` [`(buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) ≥ 101`] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**ฮิต 2: `calcPlayerToMobDamage` (ดาเมจหลัก) — `singleAttack = 0` · ส่วน explosion (`explosion…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `explosionConstantDamage` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`((buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) + ((((OrgaslashBuf.Pay(new OrgaslashBuf) & 255) << 2) + OrgaslashBuf.Pay(new OrgaslashBuf)) << 1)) ≥ 101` หรือ `((buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) + ((((OrgaslashBuf.Pay(new OrgaslashBuf) & 255) << 2) + OrgaslashBuf.Pay(new OrgaslashBuf)) << 1)) < 101`]: `explosionSkillRate / 100` — โดยที่ `explosionSkillRate` = `explosionSkillRate × (OrgaslashBuf.Pay(new, OrgaslashBuf) & 255)` [`((buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) + ((((OrgaslashBuf.Pay(new OrgaslashBuf) & 255) << 2) + OrgaslashBuf.Pay(new OrgaslashBuf)) << 1)) ≥ 101` หรือ `((buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) + ((((OrgaslashBuf.Pay(new OrgaslashBuf) & 255) << 2) + OrgaslashBuf.Pay(new OrgaslashBuf)) << 1)) < 101`] หรือ `explosionSkillRate × (OrgaslashBuf.Pay(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 56)) & 255)` [`((buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) + ((((OrgaslashBuf.Pay(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 56)) & 255) << 2) + OrgaslashBuf.Pay(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 56))) << 1)) ≥ 101` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 56) ≠ 0` หรือ `((buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) + ((((OrgaslashBuf.Pay(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 56)) & 255) << 2) + OrgaslashBuf.Pay(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 56))) << 1)) < 101` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 56) ≠ 0`] หรือ `0` [`(buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) ≥ 101` หรือ `(buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) < 101`] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**ใช้ร่วมทุกฮิตของ ฮิตรีแอ็กชัน (`HitReactionAssign`)**
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical)` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobBuffer.GuardUpBuff.get_GuardUpval` = ค่า Guard Upval ของ GuardUpBuff; `TryGetBuff.buff` = TryGetBuff.buff; `MobActionManagerBase.get_BuffManager` = ค่า Buff Manager ของ MobActionManagerBase (ดูแท็บ Variables)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) = 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: **25** → 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 (Lv1…10)

**ใช้ร่วมทุกฮิตของ ดาเมจหลัก**
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `target.ExpDefSkill / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefSkill` = proration ช่อง Skill ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpList[mobAction] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
<!-- calc:end -->

