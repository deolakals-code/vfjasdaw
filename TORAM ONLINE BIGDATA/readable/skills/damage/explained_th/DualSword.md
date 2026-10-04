# สกิลดาบคู่ (`DualSword`) — คำอธิบายทีละสกิล (ภาษาไทย)

สร้างอัตโนมัติด้วย `scripts/render_explained_th.py` จาก `skill_reference.json` (ข้อมูลโค้ด client ชุดล่าสุด) ไม่มีข้อความเขียนมือ แก้ไฟล์นี้ตรง ๆ จะถูกเขียนทับ ตัวเลขทั้งหมดคำนวณจากโค้ด (Code) ความหมายของชื่อ field/บทบาทแปลจากชื่อในโค้ด (Inferred) ยังไม่ได้เทียบกับตัวเลขในเกม ข้อมูลดิบทุกเส้นทางอยู่ใน `../details/DualSword.md`

---

<!-- calc:preface -->
> **วิธีอ่านหัวข้อ "การคำนวณแบบตัวเลข"** (สร้างอัตโนมัติด้วย `scripts/render_calc_th.py` จาก `skill_reference.json` แก้มือจะถูกเขียนทับ)
> ดาเมจต่อฮิตเดินตามขั้น `SkillCalcTemplate/CalcStep` 0→40 ตามลำดับ (Code: `SkillCalcTemplate.GetDamage`) ขั้น `+` บวกเข้าดาเมจ ขั้น `×` คูณแล้วปัดเศษทิ้ง (int) ทันทีทุกขั้น
> ลำดับหลัก: ดาเมจฐาน(7) + คงที่สกิล(8) + คงที่บัพ(9) − ป้องกันเป้า(10) + ตีแรก(11) → ×คริ(13) → ×ธาตุ(15) → ×ตัวคูณสกิล(18) → ×ตีแรก(19) → ×เสถียร(21) → +คงที่ออโต้(22) → ×Proration(23) → ×ประเภท(24) → ×ดาเมจสุดท้าย(25) → … → เพดาน/ขั้นต่ำ(35–37)
> "ฮิต N" = template ดาเมจแต่ละก้อน (ทอยคริแยกกัน) แยกตามเมธอดและตัวแปรฮิตในโค้ด (`type`, `isFirst`, `attackCount` …) ชื่อฮิต/ส่วนมาจากชื่อในโค้ด (Inferred) ตัวเลขคำนวณจากโค้ด (Code) โดยตั้งเจม/บัพเสริม = 0
> ค่าหลายก้อนในขั้นเดียวกันแบบ "บวกเข้าช่อง" จะบวกกันก่อนคูณ ส่วน "ตั้งค่าทับ" แทนที่ค่าเดิม ค่าที่ขึ้นกับสเตตัสแสดงเป็นตัวอย่างที่ 100 / 255 (และ Lv สกิลอื่น 1 / 10) ใช้สูตรที่แนบไว้คำนวณค่าอื่นเอง
<!-- calc:preface-end -->

### ดูเอลมาสเตอรี่ (DualMastery) · uid 641

<img src="../../icons/sk_641.png" width="40" alt="icon">

- ทรี: สกิลดาบคู่ (ขั้น 1) · เลเวลสูงสุด: 30 · อาวุธ: TwinSword · ธง: StarGem
- คลาสในโค้ด: `DualMastery` · สถานะการแกะ: แกะครบจากโค้ด

> สามารถติดตั้งดาบมือเดียว 2 เล่มพร้อมกัน
> ลดการลดลงของอัตราความแม่นและ
> อัตราคริติคอลเมื่อเลเวลเพิ่มขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ความแม่น % (`HitRate`): -52, -49, -46, -43, -40, -37, -34, -31, -28, -25 (Lv1…10)
- พาสซีฟ อัตราคริ % (`CrtRate`): -52, -49, -46, -43, -40, -37, -34, -31, -28, -25 (Lv1…10)
- ตัวอ่านสกิลนี้ `EquipItemData.OneHundSwordCalculator.CalcSubAtk` — คำนวณ sub atk (OneHundSwordCalculator): คืนค่า `_t257` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EquipItemData.OneHundSwordCalculator.SubCalcStable` — OneHundSwordCalculator.SubCalcStable: คืนค่า `_t258` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EquipItemData.OneHundSwordCalculator.calcAtkParam` — คำนวณ atk param (OneHundSwordCalculator): คืนค่า `(int((((_t259 & 1) eq 0 ? atkRate : ((SkillMasteryBase.GetMasteryParam(MasteryId.AtkRate) / 100) + atkRate)) * ((_t261 + _t262) + (_t263 << 1)))) + atk)` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SkillManager.GetEquipEnableSkillList` — SkillManager.GetEquipEnableSkillList: คืนค่า `new System.Collections.Generic.List<SkillId>` (นิยามเต็มในแท็บ Variables)

### ทวินสแลช (TwinSlash) · uid 642

<img src="../../icons/sk_642.png" width="40" alt="icon">

- ทรี: สกิลดาบคู่ (ขั้น 1) · เลเวลสูงสุด: 30 · อาวุธ: TwinSword · ต้องเรียนก่อน: ดูเอลมาสเตอรี่ · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `TwinSlashAction` · สถานะการแกะ: แกะครบจากโค้ด

> ฟันด้วยดาบมือเดียว 2 เล่ม
> ความเสียหายจากคริติคอลจะสูงกว่าปกติ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- ตัวอ่านสกิลนี้ `AirSlicerAction.OnInitialize` — AirSlicerAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...) (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=642 -->
#### การคำนวณแบบตัวเลข — TwinSlash (uid 642)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **100 + 10×Lv** → 110, 120, 130, 140, 150, 160, 170, 180, 190, 200 (Lv1…10)
- ตัวคูณคริติคอลเพิ่ม (`CriticalRate`, ×, บวกเข้าช่อง): **(50 + 5×Lv)%** → 55%, 60%, 65%, 70%, 75%, 80%, 85%, 90%, 95%, 100% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(150 + 10×Lv)%** → 160%, 170%, 180%, 190%, 200%, 210%, 220%, 230%, 240%, 250% (Lv1…10)
<!-- calc:end -->

### ครอสแพรี่ (ParryingSword) · uid 643

<img src="../../icons/sk_643.png" width="40" alt="icon">

- ทรี: สกิลดาบคู่ (ขั้น 1) · เลเวลสูงสุด: 30 · อาวุธ: TwinSword · ต้องเรียนก่อน: ดูเอลมาสเตอรี่ · ธง: StarGem
- คลาสในโค้ด: `ParryingSwordAction` · สถานะการแกะ: แกะครบจากโค้ด

> หลบการโจมตีของศัตรูพร้อมตอบโต้กลับ
> ลดความเสียหายจากการโจมตีทางกายภาพและเวทมนตร์ระหว่างใช้สกิล
> เร่ง ATK กับ ASPD เมื่อลดความเสียหายสำเร็จเป็นเวลา 30 วินาที

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: None (None)
- บัพ `ParryingSwordBuf` ระยะเวลา 0 วินาที: ATK % (`AtkUpRate`) = Lv → 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10) · ลดดาเมจกายภาพที่ได้รับ (`PowerDmgCut`) = `ParryingSwordBuf.calcDmgCut(this, Lv)` · ลดดาเมจเวทที่ได้รับ (`MagicDmgCut`) = `ParryingSwordBuf.calcDmgCut(this, Lv)` · ความเร็วโจมตี % (`AspdRate`) = 10×Lv → 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10)
- ตัวอ่านสกิลนี้ `ParryingSwordAction.Damaged` — ParryingSwordAction: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `SkillDamageData$$SetAbnormalType` = `damageData, AbnormalType.None, 0` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.ParryingSword, out) & 1) ne 0 AND TryG… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ParryingSwordBuf.Parry` — ParryingSwordBuf.Parry (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=643 -->
#### การคำนวณแบบตัวเลข — ParryingSword (uid 643)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **50 + 5×Lv** → 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(100 + Lv)%** → 101%, 102%, 103%, 104%, 105%, 106%, 107%, 108%, 109%, 110% (Lv1…10)
<!-- calc:end -->

### รีเฟล็กซ์ (StepReactor) · uid 644

<img src="../../icons/sk_644.png" width="40" alt="icon">

- ทรี: สกิลดาบคู่ (ขั้น 1) · เลเวลสูงสุด: 30 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ดูเอลมาสเตอรี่ · ธง: StarGem
- คลาสในโค้ด: `StepReactorAction` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่มการฟื้นฟู Avoid ในเวลาสั้นๆ
> DEF/MDEF จะลดลงจำนวนมาก

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, บัพปาร์ตี้/ผู้อื่น
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `StepReactorbuf` ระยะเวลา `time` วินาที: หลบ + (`AvoidUp`) = 10 + 2×Lv → 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 (Lv1…10) · MDEF % (`MdefRate`) = -100 + Lv → -99, -98, -97, -96, -95, -94, -93, -92, -91, -90 (Lv1…10) · DEF % (`DefRate`) = -100 + Lv → -99, -98, -97, -96, -95, -94, -93, -92, -91, -90 (Lv1…10)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: *ระยะเวลาแสดงผล+90 วิ

### ควบคุมดาบคู่ (DualSwordTechnique) · uid 645

<img src="../../icons/sk_645.png" width="40" alt="icon">

- ทรี: สกิลดาบคู่ (ขั้น 1) · เลเวลสูงสุด: 30 · อาวุธ: TwinSword · ต้องเรียนก่อน: ดูเอลมาสเตอรี่ · ธง: StarGem
- คลาสในโค้ด: `DualSwordTechnique` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่ม ASPD ของดาบคู่
> และลดข้อเสียของดาบคู่ลงด้วย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ความแม่น % (`HitRate`): 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 (Lv1…10)
- พาสซีฟ อัตราคริ % (`CrtRate`): 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 (Lv1…10)
- พาสซีฟ ความเร็วโจมตี + (`Aspd`): 50, 100, 150, 200, 250, 300, 350, 400, 450, 500 (Lv1…10)

### สปินนิ่งสแลช (AirSlide) · uid 646

<img src="../../icons/sk_646.png" width="40" alt="icon">

- ทรี: สกิลดาบคู่ (ขั้น 2) · เลเวลสูงสุด: 50 · อาวุธ: TwinSword · ต้องเรียนก่อน: ทวินสแลช · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `AirSlideAction` · สถานะการแกะ: แกะครบจากโค้ด

> ฟันศัตรูที่อยู่รอบตัวให้กระเด็นออกไป\ธาตุคู่(ดาบมือเดียว)
> หลังการโจมตีคาไมทาจิจะสร้างความเสียหายต่อเนื่อง
> มีโอกาสทำให้เป้าหมาย[มืดบอด] 

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ, วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 2 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `blindPercent`: 17, 20, 22, 25, 27, 30, 32, 35, 37, 40 (Lv1…10) %
- สถานะที่ทำให้ติด: กระเด็น (KnockBack), ตาบอด (Blindness)
- ตัวอ่านสกิลนี้ `AirSlicerAction.OnInitialize` — AirSlicerAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `percent` = `(int((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.AirSlide, 1) *…`; [set] `firstFixAddDamage` = `((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.AirSlide, 1) + (Sk…` (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=646 -->
#### การคำนวณแบบตัวเลข — AirSlide (uid 646)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcFirstDamage`**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **50 + 5×Lv** → 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): 127%, 130%, 132%, 135%, 137%, 140%, 142%, 145%, 147%, 150% (Lv1…10)
  - สูตร: `skillRateFirst` — โดยที่ `skillRateFirst` = `(int(2.5 × Lv) + gemCart(210, [4]) + 125) / 100`
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `target.ExpDefSkill / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefSkill` = proration ช่อง Skill ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_CharacterActionManagerBase` = ค่า Character Action Manager Base ของ MobActionManagerBase (ดูแท็บ Variables)

**ฮิต 2: `calcAnyDamage` (ฮิตถัดไป (ใช้ร่วมทุกฮิตหลังฮิตแรก))**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(30 + 2×Lv)%** → 32%, 34%, 36%, 38%, 40%, 42%, 44%, 46%, 48%, 50% (Lv1…10)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `target.ExpDefSkill / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefSkill` = proration ช่อง Skill ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_CharacterActionManagerBase` = ค่า Character Action Manager Base ของ MobActionManagerBase (ดูแท็บ Variables)

**จำนวนฮิต / ตัวนับ**
- `damageCount` (ตั้งใน `OnInitialize`): 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 (Lv1…10)
- `LoopParam` (ตั้งใน `OnInitialize`): 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 (Lv1…10)
<!-- calc:end -->

### ชาร์จจิ้งสแลช (DragoonSword) · uid 647

<img src="../../icons/sk_647.png" width="40" alt="icon">

- ทรี: สกิลดาบคู่ (ขั้น 2) · เลเวลสูงสุด: 50 · อาวุธ: TwinSword · ต้องเรียนก่อน: ครอสแพรี่ · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `DragoonSwordAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีศัตรูด้วยดาบ 2 เล่ม
> โจมตีเป้าหมายที่ผ่านเป็นทางตรง
> จะได้รับผลโบนัสจากฟันครั้งแรก

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

<!-- calc:begin uid=647 -->
#### การคำนวณแบบตัวเลข — DragoonSword (uid 647)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **100 + 20×Lv** → 120, 140, 160, 180, 200, 220, 240, 260, 280, 300 (Lv1…10)
- ดาเมจคงที่ตีแรก (`FirstAttack`, +): `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamage` = ดาเมจคงที่ของ Fast Attack (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(200 + 20×Lv)%** → 220%, 240%, 260%, 280%, 300%, 320%, 340%, 360%, 380%, 400% (Lv1…10)
- ตัวคูณตีแรก (`FirstAttackRate`, ×, บวกเข้าช่อง): `PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamageRate` = ตัวคูณของ Fast Attack (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `target.ExpDefSkill / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefSkill` = proration ช่อง Skill ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_CharacterActionManagerBase` = ค่า Character Action Manager Base ของ MobActionManagerBase (ดูแท็บ Variables)
<!-- calc:end -->

### เร็วดุจเทพ (GodspeedLocus) · uid 648

<img src="../../icons/sk_648.png" width="40" alt="icon">

- ทรี: สกิลดาบคู่ (ขั้น 2) · เลเวลสูงสุด: 50 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ควบคุมดาบคู่
- คลาสในโค้ด: `GodspeedLocus` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่ม AGI และพลังโจมตีของฟันครั้งแรก
> (โจมตีครั้งแรก/Avoidแอคแทค/หลังใช้สกิลที่กำหนด)

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ตัวคูณตีแรก (`FirstAttackRate`): 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 (Lv1…10)
- พาสซีฟ AGI (`Agi`): 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 (Lv1…10)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: *พลังโจมตีด้วยอาวุธ+10%

### แฟนทอมสแลช / แฟนทอมอิคลิพส์ (PhantomRave) · uid 649

<img src="../../icons/sk_649.png" width="40" alt="icon">

- ทรี: สกิลดาบคู่ (ขั้น 3) · เลเวลสูงสุด: 90 · อาวุธ: TwinSword · ต้องเรียนก่อน: สปินนิ่งสแลช · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `PhantomRaveAction` · สถานะการแกะ: แกะครบจากโค้ด

> ฟันอย่างรวดเร็วจนตาเปล่ามองไม่เห็นนับครั้งไม่ถ้วน
> ธาตุคู่(ดาบมือเดียว)
> ติดสถานะไร้พ่ายระหว่างใช้สกิลแต่มีโอกาสยกเลิกสถานะจากการเคลื่อนไหวคาแรคเตอร์
> มีโอกาสทำให้มอนสเตอร์ที่อ่อนแอนอกเหนือจากบอสตายทันที
> มีโอกาสทำให้เป้าหมายถูก[แช่แข็ง]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ
- MP ที่ใช้: 400
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: แช่แข็ง (Freeze)
- บัพ `DoubleThrowBuf` ระยะเวลา 30 − 1×Lv → 29, 28, 27, 26, 25, 24, 23, 22, 21, 20 (Lv1…10) วินาที [`(coolTime & 1) ≠ 0`]

<!-- calc:begin uid=649 -->
#### การคำนวณแบบตัวเลข — PhantomRave (uid 649)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `change = 0`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(500 + 20×Lv)%** → 520%, 540%, 560%, 580%, 600%, 620%, 640%, 660%, 680%, 700% (Lv1…10)

**ฮิต 2: `calcPlayerToMobDamage` (ดาเมจหลัก) — `change ≠ 0`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(1000 + 40×Lv)%** → 1040%, 1080%, 1120%, 1160%, 1200%, 1240%, 1280%, 1320%, 1360%, 1400% (Lv1…10)

**ใช้ร่วมทุกฮิตของ ดาเมจหลัก**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **200 + 20×Lv** → 220, 240, 260, 280, 300, 320, 340, 360, 380, 400 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, ตั้งค่าทับ): **(500 + 20×Lv)%** → 520%, 540%, 560%, 580%, 600%, 620%, 640%, 660%, 680%, 700% (Lv1…10)
- ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, ×, ตั้งค่าทับ) [`TryGetProperties<object>.out2(mobAction, 90) ≠ 0`]: `CalcPhantomRaveLastDamageRate.out2(this, A, A) - MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90))` · `A = PlayerActionManagerBase.get_PlayerStatus()` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `CalcPhantomRaveLastDamageRate.out2` = CalcPhantomRaveLastDamageRate.out2; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `MobPropertyLifeReduceDamage.CalcReduceLastDamageRate` = คำนวณ reduce last damage rate (MobPropertyLifeReduceDamage) (ดูแท็บ Variables)
- ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, ×, ตั้งค่าทับ) [`TryGetProperties<object>.out2(mobAction, 90) ≠ 0`]: `CalcPhantomRaveLastDamageRate.out3(this, A, A) - MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90))` · `A = PlayerActionManagerBase.get_PlayerStatus()` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `CalcPhantomRaveLastDamageRate.out3` = CalcPhantomRaveLastDamageRate.out3; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `MobPropertyLifeReduceDamage.CalcReduceLastDamageRate` = คำนวณ reduce last damage rate (MobPropertyLifeReduceDamage) (ดูแท็บ Variables)
- ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, ×, ตั้งค่าทับ): `CalcPhantomRaveLastDamageRate.out2(this, A, A)` · `A = PlayerActionManagerBase.get_PlayerStatus()` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `CalcPhantomRaveLastDamageRate.out2` = CalcPhantomRaveLastDamageRate.out2; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
- ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, ×, ตั้งค่าทับ): `CalcPhantomRaveLastDamageRate.out3(this, A, A)` · `A = PlayerActionManagerBase.get_PlayerStatus()` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `CalcPhantomRaveLastDamageRate.out3` = CalcPhantomRaveLastDamageRate.out3; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
<!-- calc:end -->

### แฟลชบลาส (PhiloEclair) · uid 650

<img src="../../icons/sk_650.png" width="40" alt="icon">

- ทรี: สกิลดาบคู่ (ขั้น 3) · เลเวลสูงสุด: 90 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: รีเฟล็กซ์
- คลาสในโค้ด: `PhiloEclairAction` · สถานะการแกะ: แกะครบจากโค้ด

> ธาตุคู่(ดาบมือเดียว)
> เพิ่มพลังโจมตีฟันครั้งแรกชั่วขณะ
> เพิ่มเคาน์เตอร์แอทแทคเมื่อ Avoid
> จะทำงานเมื่อใช้สกิล[ชาโดว์สเต็ป]ด้วย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, บัพปาร์ตี้/ผู้อื่น
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `PhiloEclairBuf` ระยะเวลา 120 วินาที [`isDualSword`] / 20 วินาที [ไม่ `isDualSword`]: ATK อาวุธ % (`EqAtkUpRate`) = 25 · ตัวคูณตีแรก (`FirstAttackRate`) = Lv → 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10) · จำนวนหลบสะสม (`AvoidStack`) = 0, 0, 0, 0, 1000, 1000, 1000, 1000, 1000, 2000 (Lv1…10)
- ตัวอ่านสกิลนี้ `AvoidActionManager.CheckActivatePhiloEclair` — ตรวจ activate philo eclair (AvoidActionManager): คืนค่า `(FieldRayPick.GetFallDelta(charaMove.fieldRay, out, UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(charaMove)).x, 0) & 1)` (2 กรณี) (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: *เพิ่มปริมาณการเพิ่มบัฟ ATK อาวุธ *เวลาแสดงผล+100s
- Lv10: *พลัง+50 *ระยะโจมตี (รัศมี)+1m

### ชาโดว์สเต็ป (WrapAround) · uid 651

<img src="../../icons/sk_651.png" width="40" alt="icon">

- ทรี: สกิลดาบคู่ (ขั้น 3) · เลเวลสูงสุด: 90 · อาวุธ: TwinSword · ต้องเรียนก่อน: ชาร์จจิ้งสแลช · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `WrapAroundAction` · สถานะการแกะ: แกะครบจากโค้ด

> เคลื่อนย้ายไปอยู่ข้างหลังศัตรูอย่างรวดเร็ว
> เพิ่มการฟื้นฟู MP จนกว่าจะใช้สกิลถัดไป
> เพิ่มอัตราคริติคอลของการโจมตีด้วยสกิล 1 ครั้ง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- MP ที่ใช้: 400, 400, 300, 300, 300, 300, 200, 200, 200, 200 (Lv1…10)
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- ตัวอ่านสกิลนี้ `LunaDitherStarAction.ActionSkillEvent` — LunaDitherStarAction.ActionSkillEvent: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new WrapAroundBuf, Id` เมื่อ param ne 101 AND param eq 100 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillManager.GetSkil… (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=651 -->
#### การคำนวณแบบตัวเลข — WrapAround (uid 651)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `ActionStart`): `int(1.5 × CharacterActionManagerBase.get_Size())`
<!-- calc:end -->

### ไชน์นิ่งครอส / เบลซซิ่งไชน์นิ่งครอส (ShiningCloth) · uid 652

<img src="../../icons/sk_652.png" width="40" alt="icon">

- ทรี: สกิลดาบคู่ (ขั้น 4) · เลเวลสูงสุด: 170 · อาวุธ: TwinSword · ต้องเรียนก่อน: ชาโดว์สเต็ป · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `ShiningClothAction` · สถานะการแกะ: แกะครบจากโค้ด

> ดาบคู่แห่งแสงตัดผ่านความมืดมิด
> ธาตุคู่(ดาบมือเดียว)
> ยิ่งเข้าไปใกล้ศัตรูจะยิ่งสร้างความเสียหายได้เพิ่มขึ้น
> ฟื้นฟู MP ถ้าติดคริติคอล เมื่อติดบัฟจะฟื้นฟู HP เล็กน้อย
> บัฟนี้จะไม่มีการทับซ้อนกัน

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 2 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `ShiningClothBuf` ระยะเวลา 9 วินาที

<!-- calc:begin uid=652 -->
#### การคำนวณแบบตัวเลข — ShiningCloth (uid 652)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **100 + 20×Lv** → 120, 140, 160, 180, 200, 220, 240, 260, 280, 300 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [มีบัพ 655 LunaDitherStar]: `max(10 × Lv + AGIรวม // 4 + STRรวม // 4 + DEXรวม // 4 - System.Math.Max(0, System.Math.Min(400, 50 × MobActionManagerBase.get_PlayerMeterDistance(mobAction) - 200)) + 300, 100) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Agi` = AGI สุดท้าย; `status.Str` = STR สุดท้าย (หลังอุปกรณ์/บัพ/พาสซีฟ); `status.Dex` = DEX สุดท้าย; `MobActionManagerBase.get_PlayerMeterDistance` = ค่า Player Meter Distance ของ MobActionManagerBase (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [ไม่มีบัพ 655 LunaDitherStar]: `max(10 × Lv + AGIรวม // 5 + STRรวม // 5 + DEXรวม // 5 - System.Math.Max(0, System.Math.Min(400, 50 × MobActionManagerBase.get_PlayerMeterDistance(mobAction) - 200)) + 300, 100) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Agi` = AGI สุดท้าย; `status.Str` = STR สุดท้าย (หลังอุปกรณ์/บัพ/พาสซีฟ); `status.Dex` = DEX สุดท้าย; `MobActionManagerBase.get_PlayerMeterDistance` = ค่า Player Meter Distance ของ MobActionManagerBase (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 3 ของ `skillRate`]: `max(skillRate - System.Math.Max(0, System.Math.Min(400, 50 × MobActionManagerBase.get_PlayerMeterDistance(mobAction) - 200)), 100) / 100` — โดยที่ `skillRate` = `10 × Lv + AGIรวม // 4 + STRรวม // 4 + DEXรวม // 4 + 300` [มีบัพ 655 LunaDitherStar] หรือ `10 × Lv + AGIรวม // 5 + STRรวม // 5 + DEXรวม // 5 + 300` [ไม่มีบัพ 655 LunaDitherStar] หรือ `max(skillRate - System.Math.Max(0, System.Math.Min(400, 50 × MobActionManagerBase.get_PlayerMeterDistance(mobAction) - 200)), 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_PlayerMeterDistance` = ค่า Player Meter Distance ของ MobActionManagerBase (ดูแท็บ Variables)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `OnInitialize`): `SubElement` — โดยที่ `SubElement` = `motionSpeed`
<!-- calc:end -->

### สตอร์มรีปเปอร์ / ออร์บิทรีปเปอร์ (SturmLeaper) · uid 653

<img src="../../icons/sk_653.png" width="40" alt="icon">

- ทรี: สกิลดาบคู่ (ขั้น 4) · เลเวลสูงสุด: 170 · อาวุธ: TwinSword · ต้องเรียนก่อน: แฟลชบลาส · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `SturmLeaperAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีศัตรูและกระโดดถอยกลับอย่างรวดเร็ว
> พลังโจมตีระยะใกล้ของสกิลที่ใช้ถัดไป
> จะเพิ่มขึ้นตามระยะถอยห่าง
> ติดคงกระพันขณะถอยห่าง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 2 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `SturmLeaperBuf`: ดาเมจระยะไกล % (`LongRangeRate`) = `int((8 × Lv + 2 × lv) × rate) ÷ 2`
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 1 ตามที่ `SturmLeaperBuf` ส่งให้ตัวสร้างของ `บัพฐาน`

<!-- calc:begin uid=653 -->
#### การคำนวณแบบตัวเลข — SturmLeaper (uid 653)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **100 + 10×Lv** → 110, 120, 130, 140, 150, 160, 170, 180, 190, 200 (Lv1…10)
- ดาเมจคงที่ตีแรก (`FirstAttack`, +): `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamage` = ดาเมจคงที่ของ Fast Attack (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `skillRate / 100` — โดยที่ `skillRate` = `10 × Lv + baseDEX // 25 × Lv + 400` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณตีแรก (`FirstAttackRate`, ×, บวกเข้าช่อง): `PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamageRate` = ตัวคูณของ Fast Attack (ดูแท็บ Variables)
<!-- calc:end -->

### เซเบอร์ออร่า (SaberAura) · uid 654

<img src="../../icons/sk_654.png" width="40" alt="icon">

- ทรี: สกิลดาบคู่ (ขั้น 4) · เลเวลสูงสุด: 170 · อาวุธ: TwinSword · ต้องเรียนก่อน: เร็วดุจเทพ
- คลาสในโค้ด: `SaberAuraAction` · สถานะการแกะ: แกะครบจากโค้ด

> ดาบคู่เปล่งประกายแสงศักดิ์สิทธิ์
> เพิ่มความเร็วการเคลื่อนไหวและสเตตัสต่างๆ
> ใช้ HP อย่างต่อเนื่อง ถ้าใช้ไม่ได้เมื่อไหร่ผลจะสิ้นสุดลง
> ใช้ทับซ้อนกันไม่ได้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `SaberAuraBuf`: ตัวนับ/stack (`Count`) = 1 · ความแม่น + (`HitUp`) = 5×Lv → 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10) · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = 100 · ความเร็วโจมตี % (`AspdRate`) = 10×Lv → 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10) · MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 (Lv1…10) · อัตราคริ + (`CrtUp`) = 2, 5, 7, 10, 12, 15, 17, 20, 22, 25 (Lv1…10)
- ตัวอ่านสกิลนี้ `ArkSaberAction.ActionHit` — ArkSaberAction.ActionHit: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.SaberAura` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_Skil… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ArkSaberAction.ActionStart` — ArkSaberAction: ตอนเริ่มทำงานของสกิล: [set] `level` = `[TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.SaberAura)+0x20]` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_Skil… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ArkSaberAction.ConverterArkSaberSkillId` — ArkSaberAction.ConverterArkSaberSkillId: คืนค่า `_t12` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ArkSaberAction.IsFailure` — เงื่อนไข is failure (ArkSaberAction): คืนค่า `(PlayerAttackBase.IsFailure(this, status, missType) & 1)` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.SupportReserve` — MobaPlayerActionManager.SupportReserve (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.get_MoveSpeed` — ค่า Move Speed ของ MobaPlayerActionManager: คืนค่า `_t1117` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.get_MoveSpeed` — ค่า Move Speed ของ PlayerActionManager: คืนค่า `_t1348` (3 กรณี) (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=654 -->
#### การคำนวณแบบตัวเลข — SaberAura (uid 654)

**ค่าบัพที่ขึ้นกับจำนวน stack**

- บัพ `SaberAuraBuf` — `HitUp` ตามจำนวน `Count`: `Count × hitUp`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |

- บัพ `SaberAuraBuf` — `AspdRate` ตามจำนวน `Count`: `Count × aspdRate`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |

- บัพ `SaberAuraBuf` — `AttackMprecoveryUp` ตามจำนวน `Count`: `Count × atkMpHeal`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |

- บัพ `SaberAuraBuf` — `CrtUp` ตามจำนวน `Count`: `Count × critical`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |
<!-- calc:end -->

### เอเลียสลีย์ (ArialSlay) · uid 659

<img src="../../icons/sk_659.png" width="40" alt="icon">

- ทรี: สกิลดาบคู่ (ขั้น 4) · เลเวลสูงสุด: 170 · อาวุธ: ดาบมือเดียว, TwinSword · ต้องเรียนก่อน: เร็วดุจเทพ
- คลาสในโค้ด: `ArialSlayAction` · สถานะการแกะ: แกะครบจากโค้ด

> ฟันรัวขณะหลอกล่อศัตรู
> เมื่อใช้ในคอมโบ(ยกเว้นครั้งแรก)
> จะใช้ MP 100
> 
> สามารถเคลื่อนที่ได้ขณะใช้สกิล

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ
- MP ที่ใช้ [`combo.index ≥ 1`]: 100
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ; เวทเมื่อถือ magic tool มือรอง — เงื่อนไข: Physics: default (ctor); Magic: OnInitialize: sub weapon is a magic tool
- Proration: ช่องที่เลือกตอนร่าย (กายภาพ/เวท) · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: None (None)
- บัพ `ArialSlayBuf` ระยะเวลา 5 วินาที [`EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 10` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 17`]: ตัวคูณดาเมจที่ได้รับจากมอน (หมวดบัพ) (`MobLastDamageRateBuf`) = `System.Math.Min(2 × (ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255), 30)`
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `ArialSlayAction.Damaged` — ArialSlayAction: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `SkillDamageData$$SetAbnormalType` = `damageData, AbnormalType.None, 0` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.ArialSlay) & 1) ne 0 AND EquipIte… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobAttackBase.CalcLastDamage` — คำนวณ last damage (MobAttackBase): คืนค่า `((SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.ArkSaber, out) & 1) eq 0 ? ((_t983 & 1) eq 0 ? ((_t982 & 1) eq 0 ? _t997 : _t…` (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv16: [ได้รับผลแบบเดียวกันเมื่อใช้กับมีดสั้น] เปิดใช้งานในสภาวะรวดเร็ว
- Lv17: ระหว่างใช้งานจะได้รับการต้านทานความเสียหายและ ต้านทานผลกระทบที่ทำให้ไม่สามารถเคลื่อนไหวได้ตามค่าถลุง  เมื่อใช้สกิล "เอเลียสลีย์" ผลของสกิล "ฟาเรส" จะยังคงอยู่
- Lv15: *สามารถเปิดใช้งานได้แม้ว่าเป้าหมายจะอยู่ห่างออกไป และเปลี่ยนเป็นความเสียหายเวทมนตร์
- Lv19: [จะได้รับผลแบบเดียวกันเมื่อใช้คัมภีร์นินจูตสึ] *สามารถเปิดใช้งานได้แม้ว่าเป้าหมายจะอยู่ห่างออกไป
- Lv10: 5MP เฮทของตัวเองจะลดลงอย่างมากเป็นเวลา 5 วินาที

<!-- calc:begin uid=659 -->
#### การคำนวณแบบตัวเลข — ArialSlay (uid 659)
Proration: ช่อง `dynamic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **100 + 20×Lv** → 120, 140, 160, 180, 200, 220, 240, 260, 280, 300 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `skillRate / 100` — โดยที่ `skillRate` = `50 × Lv + System.Math.Max(DEXรวม, baseSTR)` [อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว) และ `(subWeaponType | 2) = 18`] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
<!-- calc:end -->

### ลูนาดิธเธอร์สตาร์ (LunaDitherStar) · uid 655

<img src="../../icons/sk_655.png" width="40" alt="icon">

- ทรี: สกิลดาบคู่ (ขั้น 5) · เลเวลสูงสุด: 250 · อาวุธ: TwinSword · ต้องเรียนก่อน: [N]ไชน์นิ่งครอส[N2]เบลซซิ่งไชน์นิ่งครอส[N]
- คลาสในโค้ด: `LunaDitherStarAction` · สถานะการแกะ: แกะครบจากโค้ด

> เงาจันทร์เปล่งประกาย ธาตุคู่(ดาบมือเดียว)
> หลังใช้งานถ้ากดปุ่มเคลื่อนที่ถอยหลังจะถอยกลับทันที
> และแทงศัตรูด้วยดาบแสงจันทร์

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- MP ที่ใช้: 400
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `WrapAroundBuf`: อัตราคริ % (`CrtUpRate`) = 20×Lv → 20, 40, 60, 80, 100, 120, 140, 160, 180, 200 (Lv1…10) · MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = Lv → 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 1 ตามที่ `WrapAroundBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `ShiningClothAction.OnInitialize` — ShiningClothAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `change` = `1` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.LunaDitherStar) & 1) ne 0; [set] `<SkillIndividualFlag>k__BackingField` = `0x10000` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.LunaDitherStar) & 1) ne 0; [set] `skillRate` = `(((Lv * 10) + 300) + _t1730)` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.LunaDitherStar) & 1) ne 0 (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=655 -->
#### การคำนวณแบบตัวเลข — LunaDitherStar (uid 655)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) · ส่วน cross (`cross…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **400** → 400, 400, 400, 400, 400, 400, 400, 400, 400, 400 (Lv1…10)
- ดาเมจคงที่ตีแรก (`FirstAttack`, +): `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamage` = ดาเมจคงที่ของ Fast Attack (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [DEX รวม=100]: **(566.67 + 50×Lv)%** → 616.67%, 666.67%, 716.67%, 766.67%, 816.67%, 866.67%, 916.67%, 966.67%, 1016.67%, 1066.67% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [DEX รวม=255]: **(670 + 50×Lv)%** → 720%, 770%, 820%, 870%, 920%, 970%, 1020%, 1070%, 1120%, 1170% (Lv1…10)
- ตัวคูณตีแรก (`FirstAttackRate`, ×, บวกเข้าช่อง): `PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamageRate` = ตัวคูณของ Fast Attack (ดูแท็บ Variables)
<!-- calc:end -->

### ทวินบัสตาร์ดเบลด (TwinBusterBlade) · uid 656

<img src="../../icons/sk_656.png" width="40" alt="icon">

- ทรี: สกิลดาบคู่ (ขั้น 5) · เลเวลสูงสุด: 250 · อาวุธ: TwinSword · ต้องเรียนก่อน: [N]ไชน์นิ่งครอส[N2]เบลซซิ่งไชน์นิ่งครอส[N]
- คลาสในโค้ด: `TwinBusterBladeAction` · สถานะการแกะ: แกะครบจากโค้ด

> ฟันต่อเนื่องสองครั้งพร้อมออร่า
> เป็นการโจมตีสองครั้งที่มีโอกาสติดคริติคอลสูง
> 
> ครั้งที่ 1 จะฟันเป้าหมายอย่างต่อเนื่อง
> ครั้งที่ 2 โจมตีแบบวงกว้างความแรง
> จะเพิ่มขึ้นตามจำนวนเป้าหมายที่ถูกโจมตี

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: ถ้าเรียนรู้บัสตาร์ดเบลดแล้วจะได้รับผลของบัฟที่เหมือนกัน

<!-- calc:begin uid=656 -->
#### การคำนวณแบบตัวเลข — TwinBusterBlade (uid 656)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `lineAttack ≠ 0` · ส่วน ครั้งที่ 2 (`second…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **30×Lv** → 30, 60, 90, 120, 150, 180, 210, 240, 270, 300 (Lv1…10)
- ดาเมจคงที่ตีแรก (`FirstAttack`, +): `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamage` = ดาเมจคงที่ของ Fast Attack (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `secondSkillRate` หรือ `IsOtherPlayer = 0` และ `isExorcism` และ `param = 100`]: **500%** → 500%, 500%, 500%, 500%, 500%, 500%, 500%, 500%, 500%, 500% (Lv1…10)
- ตัวคูณตีแรก (`FirstAttackRate`, ×, บวกเข้าช่อง): `PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamageRate` = ตัวคูณของ Fast Attack (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefSkill / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `localExpDefSkill` = proration ปัจจุบันของมอนในช่องสกิลกายภาพ (%); `MobActionManagerBase.get_MobStatus` = ค่า Mob Status ของ MobActionManagerBase (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpList[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_CharacterActionManagerBase` = ค่า Character Action Manager Base ของ MobActionManagerBase (ดูแท็บ Variables)

**ฮิต 2: `calcPlayerToMobDamage` (ดาเมจหลัก) — `lineAttack = 0` · ส่วน ครั้งแรก (`first…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **30×Lv** → 30, 60, 90, 120, 150, 180, 210, 240, 270, 300 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `firstSkillRate / 100` — โดยที่ `firstSkillRate` = `75 × Lv + (baseDEX + baseAGI) ÷ 2` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
<!-- calc:end -->

### อาร์คเซเบอร์ (ArkSaber) · uid 657

<img src="../../icons/sk_657.png" width="40" alt="icon">

- ทรี: สกิลดาบคู่ (ขั้น 5) · เลเวลสูงสุด: 250 · อาวุธ: TwinSword · ต้องเรียนก่อน: เซเบอร์ออร่า
- คลาสในโค้ด: `ArkSaberAction` · สถานะการแกะ: แกะครบจากโค้ด

> สกิลพิเศษที่สามารถเปิดใช้งานระหว่างใช้เซเบอร์ออร่า
> ช่วยฟื้นฟู HP และจำนวน Avoid
> การใช้ MP นอกเหนือจากสกิลเวทมนตร์จะลดลงครึ่งหนึ่งเสมอ
> พร้อมกับอัตราคริติคอลที่เพิ่มขึ้นเป็นอย่างมาก
> แต่ถ้าโดนศัตรูโจมตีล่ะก็...

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, พาสซีฟ
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `ArkSaberBuf` ระยะเวลา `max(3 × count, 10)` วินาที: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = 80 · MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = 2×Lv → 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 (Lv1…10) · ตัวนับ/stack (`Count`) = `count` · อัตราคริ + (`CrtUp`) = 10×Lv → 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10)
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `ArkSaber.CalcConstantDamage` — คำนวณ constant damage (ArkSaber): คืนค่า `max(_t10, 0)` (3 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ArkSaberAction.ConverterArkSaberSkillId` — ArkSaberAction.ConverterArkSaberSkillId: คืนค่า `_t12` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobAttackBase.CalcLastDamage` — คำนวณ last damage (MobAttackBase): [set] `arkSaberMpDamage` = `_t1000` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.ArkSaber, out) & 1) ne 0 AND TryGetBuf…; [set] `arkSaberMpDamage` = `0` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.ArkSaber, out) & 1) ne 0 AND TryGetBuf… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.SupportReserve` — MobaPlayerActionManager.SupportReserve (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerSecondaryStatus.GetCrtConstant` — MobaPlayerSecondaryStatus.GetCrtConstant: คืนค่า `_t1164` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.CalcCostMp` — MP ที่ใช้ของสกิล: [call] `InflexibilityBuf$$CheckMpHalving` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Inflexibility), this` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill…; [call] `MultipleHuntBuf$$CheckMode` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt), SkillMode…` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill…; [set] `<CostMpType>k__BackingField` = `(CostMpType | 1)` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.RemoveAfterSkillBuf` — PlayerAttackBase.RemoveAfterSkillBuf (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerDataManager.OnSkillBuffEnd` — PlayerDataManager.OnSkillBuffEnd: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerDataManager.get_SkillBufferManager(this), SkillId.ArkSaber` เมื่อ endEvnet.SkillId gt 627 AND (endEvnet.SkillId & 0xffff) le 894 AND (endEvnet.SkillId & 0xffff) eq 657 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.GetCrtConstant` — PlayerSecondaryStatus.GetCrtConstant: คืนค่า `_t1629` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SaberAuraAction.ActionHit` — SaberAuraAction.ActionHit: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.ArkSaber` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_Skil… (นิยามเต็มในแท็บ Variables)

### แอร์สไลเซอร์ (AirSlicer) · uid 658

<img src="../../icons/sk_658.png" width="40" alt="icon">

- ทรี: สกิลดาบคู่ (ขั้น 5) · เลเวลสูงสุด: 250 · อาวุธ: TwinSword · ต้องเรียนก่อน: สปินนิ่งสแลช
- คลาสในโค้ด: `AirSlicerAction` · สถานะการแกะ: แกะครบจากโค้ด

> เทคนิคปลดปล่อยคมดาบแห่งสายลม
> ธาตุคู่(ดาบมือเดียว)ถ้ากำลังเปิดใช้สปินนิ่งสแลชที่เท้า
> เมื่อกดปุ่มเคลื่อนที่ไปข้างหน้าจะใช้อีก 200MP เพื่อเพิ่มการโจมอันทรงพลัง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 2 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ; ช่อง proration เป็นช่องเวท (ctor expType=2) — เงื่อนไข: Physics: always
- Proration: ช่องที่เลือกตอนร่าย (กายภาพ/เวท) · เปลี่ยนค่าทุกฮิต
- สถานะที่ทำให้ติด: ตาบอด (Blindness)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: *พลังของแอร์สไลเซอร์ขึ้นอยู่กับเลเวลของสปินนิ่งสแลชที่มี  *การโจมตีเพิ่มเติมจะถูกเสริมด้วยความเสียหายคริติคอลของทวินสแลชที่เรียนรู้ และจะเพิ่มขึ้นอีกเมื่อเป้าหมายอยู่ในสภาวะมืดบอด แต่ยิ่งห่าง (ตั้งแต่ 8 เมตรขึ้นไป) ค่าที่ได้ก็จะยิ่งน้อยลง

<!-- calc:begin uid=658 -->
#### การคำนวณแบบตัวเลข — AirSlicer (uid 658)
Proration: ช่อง `dynamic` โหมด `every_hit + class check`

**ฮิต 1: `CalcFirstDamage` · ส่วน ครั้งแรก (`first…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [Lv สกิล 646 AirSlide=1]: **55** → 55, 55, 55, 55, 55, 55, 55, 55, 55, 55 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [Lv สกิล 646 AirSlide=10]: **100** → 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `firstSkillRate / 100` — โดยที่ `firstSkillRate` = `4 × gemCart(210, [4]) + 6 × A + int(2.5 × A) + baseDEX // 10 × Lv + 215` (`A = SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1)`) (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**ฮิต 2: `CalcSecondDamage` · ส่วน ครั้งที่ 2 (`second…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **20×Lv** → 20, 40, 60, 80, 100, 120, 140, 160, 180, 200 (Lv1…10)
- ตัวคูณคริติคอลเพิ่ม (`CriticalRate`, ×, บวกเข้าช่อง): `max((criticalDamageUp << (AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 7) & 1)) - min(10 × max(int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7, 0), 50), 0) / 100` — โดยที่ `criticalDamageUp` = `(A < 0 ? 5 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) + 51 : A) ÷ 2` (`A = 5 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) + 50`) (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `AbnormalStateManager.Contains` = ตัวละคร/มอนกำลังติดสถานะผิดปกตินี้อยู่หรือไม่; `MobActionManagerBase.get_AbnormalStateManager` = ค่า Abnormal State Manager ของ MobActionManagerBase; `MathUtil.DistanceToDisplayMeter` = MathUtil.DistanceToDisplayMeter; `AbnormalType.Blindness` = ตาบอด (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `secondSkillRateBonus`]: `(max(baseSTR × (A < 100 ? 100 - A : 0) / 100, 0) + secondSkillRate) / 100` · `A = 20 × max(int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7, 0)` — โดยที่ `secondSkillRate` = `100 × Lv + 500` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseSTR` = แต้ม STR ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseSTR; `MathUtil.DistanceToDisplayMeter` = MathUtil.DistanceToDisplayMeter (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `secondSkillRateBonus`]: `(max(secondSkillRateBonus × (A < 100 ? 100 - A : 0) / 100, 0) + secondSkillRate) / 100` · `A = 20 × max(int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7, 0)` — โดยที่ `secondSkillRate` = `100 × Lv + 500` ; `secondSkillRateBonus` = `baseSTR` หรือ `max(secondSkillRateBonus × (A < 100 ? 100 - A : 0) / 100, 0)` (`A = 20 × max(int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7, 0)`) (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MathUtil.DistanceToDisplayMeter` = MathUtil.DistanceToDisplayMeter (ดูแท็บ Variables)
<!-- calc:end -->

### ฮอร์ริซอนคัท (HorizontalCut) · uid 660

<img src="../../icons/sk_660.png" width="40" alt="icon">

- ทรี: สกิลดาบคู่ (ขั้น 5) · เลเวลสูงสุด: 250 · อาวุธ: ดาบมือเดียว, TwinSword · ต้องเรียนก่อน: เอเลียสลีย์
- คลาสในโค้ด: `HorizontalCutAction` · สถานะการแกะ: แกะครบจากโค้ด

> ฟันกลับอย่างรวดเร็วแบบไม่ให้ศัตรูได้ตั้งตัว
> ลด MP ที่ใช้ของสกิลถัดไปลงครึ่งหนึ่ง
> ถ้าใช้เป็นสกิลเริ่มต้นของคอมโบต้องใช้ 300 MP
> ถ้าใช้งานที่จุดสิ้นสุดของคอมโบ MP ที่จำเป็นจะกลายเป็น 0
> ระหว่างใช้สกิลหากถูกโจมตีจะล้มคว่ำ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- MP ที่ใช้ [`combo.index eq (SkillComboLine.get_Count(combo.comboLine) - 1)` หรือ `combo.index = 0` และ `combo.index ne (SkillComboLine.get_Count(combo.comboLine) - 1)`]: `combo.index = SkillComboLine.get_Count(combo.comboLine) - 1 ? 0 : 300`
- ดาเมจ: สร้าง template ดาเมจ 2 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · ไม่เปลี่ยนค่า proration
- บัพ `HorizontalCutBuf`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `PlayerAttackBase.RemoveAfterSkillBuf` — PlayerAttackBase.RemoveAfterSkillBuf: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.HorizontalCut` เมื่อ (PlayerAttackBase.ContainsNotApplicableSkill(PlayerAttackBase.get_ActionID()) & 1) eq 0 AND (SkillBufferManager.Contain… (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=660 -->
#### การคำนวณแบบตัวเลข — HorizontalCut (uid 660)
Proration: ช่อง `Skill` โหมด `never (IsExpDefFluctuate=false)`

**ฮิต 1: `calcFirstDamage`**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [อาวุธรอง ดาบมือเดียว]: **30×Lv** → 30, 60, 90, 120, 150, 180, 210, 240, 270, 300 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว) และ `isDualSword` หรือ อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว) และ ไม่ `isDualSword`]: **60×Lv** → 60, 120, 180, 240, 300, 360, 420, 480, 540, 600 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรอง ดาบมือเดียว · DEX รวม=100]: **(500 + 5×Lv)%** → 505%, 510%, 515%, 520%, 525%, 530%, 535%, 540%, 545%, 550% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรอง ดาบมือเดียว · DEX รวม=255]: **(577 + 5×Lv)%** → 582%, 587%, 592%, 597%, 602%, 607%, 612%, 617%, 622%, 627% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว) และ `isDualSword` หรือ อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว) และ ไม่ `isDualSword` · DEX รวม=100]: **(1000 + 10×Lv)%** → 1010%, 1020%, 1030%, 1040%, 1050%, 1060%, 1070%, 1080%, 1090%, 1100% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว) และ `isDualSword` หรือ อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว) และ ไม่ `isDualSword` · DEX รวม=255]: **(1155 + 10×Lv)%** → 1165%, 1175%, 1185%, 1195%, 1205%, 1215%, 1225%, 1235%, 1245%, 1255% (Lv1…10)

**ฮิต 2: `calcSecondDamage` · ส่วน ครั้งที่ 2 (`second…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **30×Lv** → 30, 60, 90, 120, 150, 180, 210, 240, 270, 300 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `secondSkillRate / 100` — โดยที่ `secondSkillRate` = `50 × Lv + max(baseSTR, baseAGI) ÷ 2` [อาวุธรอง ดาบมือเดียว] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
<!-- calc:end -->

### เบลดสตริงเกอร์ (BladeStinger) · uid 661

<img src="../../icons/sk_661.png" width="40" alt="icon">

- ทรี: สกิลดาบคู่ (ขั้น 5) · เลเวลสูงสุด: 250 · อาวุธ: ดาบมือเดียว, TwinSword · ต้องเรียนก่อน: เอเลียสลีย์
- คลาสในโค้ด: `BladeStingerAction` · สถานะการแกะ: แกะครบจากโค้ด

> พุ่งตรงเข้าไปแทงอย่างรวดเร็ว
> ถ้าไม่ Graze จะทำให้พลังเจาะเข้าพิ่มขึ้น
> พลังโจมตีเพิ่มขึ้นอีกตามพลังเจาะเข้าที่เกินค่าสูงสุด

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 3 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

<!-- calc:begin uid=661 -->
#### การคำนวณแบบตัวเลข — BladeStinger (uid 661)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) · ส่วน เพิ่ม (`add…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `SubWeaponType = 10` หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `SubWeaponType ≠ 10` หรือ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `SubWeaponType = 10`]: **100** → 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 (Lv1…10)
- หักป้องกันเป้า (`Def`, +, ตั้งค่าทับ) [`!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `SubWeaponType = 10` หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `SubWeaponType ≠ 10`]: `-PlayerAttackBase.CalcRegistDamage(this, 1, PlayerActionManagerBase.get_PlayerStatus(), เป้า)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.CalcRegistDamage` = ค่า DEF/MDEF ของมอนที่หักออก (หลังหัก pierce); `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `MobActionManagerBase.get_MobBattleStatus` = ค่า Mob Battle Status ของ MobActionManagerBase (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรอง ดาบมือเดียว และ `((buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) + physicsResistBreaker) ≥ 101` และ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `SubWeaponType = 10` หรือ อาวุธรอง ดาบมือเดียว และ `((buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) + physicsResistBreaker) ≥ 101` และ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `SubWeaponType ≠ 10`]: `(min(10 × buffParam(PowerResistBreaker) + 10 × BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51) + 10 × physicsResistBreaker - 1000, 500) + 40 × Lv + 300) / 100` — โดยที่ `physicsResistBreaker` = `4 × Lv + 10` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `BonusManager.GetBonusValue` = ผลรวมโบนัส BonusType (ค่าคงที่) จากอุปกรณ์/บัพ; `PlayerStatusBase.get_BonusManager` = ค่า Bonus Manager ของ PlayerStatusBase; `BonusType.bPowerResistBreaker` = โบนัส «อาวุธเจาะเข้า+ค่า%» (id 51 ตรงกับข้อความไอเทม) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว) และ `((buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) + physicsResistBreaker) ≥ 101` และ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `SubWeaponType = 10` หรือ อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว) และ `((buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) + physicsResistBreaker) ≥ 101` และ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `SubWeaponType ≠ 10`]: `(min(10 × buffParam(PowerResistBreaker) + 10 × BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51) + 10 × physicsResistBreaker - 1000, 500) + DEXรวม + 40 × Lv + 300) / 100` — โดยที่ `physicsResistBreaker` = `4 × Lv + 10` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Dex` = DEX สุดท้าย; `BonusManager.GetBonusValue` = ผลรวมโบนัส BonusType (ค่าคงที่) จากอุปกรณ์/บัพ; `PlayerStatusBase.get_BonusManager` = ค่า Bonus Manager ของ PlayerStatusBase; `BonusType.bPowerResistBreaker` = โบนัส «อาวุธเจาะเข้า+ค่า%» (id 51 ตรงกับข้อความไอเทม) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`((buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) + physicsResistBreaker) ≥ 101` และ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `SubWeaponType = 10`]: `(min(10 × buffParam(PowerResistBreaker) + 10 × BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51) + 10 × physicsResistBreaker - 1000, 500) + secondSkillRateBase) / 100` — โดยที่ `physicsResistBreaker` = `4 × Lv + 10` ; `secondSkillRateBase` = `AGIรวม + 300` [อาวุธรอง ดาบมือเดียว] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `BonusManager.GetBonusValue` = ผลรวมโบนัส BonusType (ค่าคงที่) จากอุปกรณ์/บัพ; `PlayerStatusBase.get_BonusManager` = ค่า Bonus Manager ของ PlayerStatusBase; `BonusType.bPowerResistBreaker` = โบนัส «อาวุธเจาะเข้า+ค่า%» (id 51 ตรงกับข้อความไอเทม) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรอง ดาบมือเดียว และ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `SubWeaponType = 10` หรือ อาวุธรอง ดาบมือเดียว และ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `SubWeaponType ≠ 10` · กิ่งที่ 1 ของ `addSkillRate` หรือ อาวุธรอง ดาบมือเดียว และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `SubWeaponType = 10` หรือ อาวุธรอง ดาบมือเดียว และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `SubWeaponType ≠ 10`]: **(300 + 40×Lv)%** → 340%, 380%, 420%, 460%, 500%, 540%, 580%, 620%, 660%, 700% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว) และ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `SubWeaponType = 10` หรือ อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว) และ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `SubWeaponType ≠ 10` · กิ่งที่ 1 ของ `addSkillRate` · DEX รวม=100 หรือ อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว) และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `SubWeaponType = 10` หรือ อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว) และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `SubWeaponType ≠ 10` · DEX รวม=100]: **(400 + 40×Lv)%** → 440%, 480%, 520%, 560%, 600%, 640%, 680%, 720%, 760%, 800% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว) และ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `SubWeaponType = 10` หรือ อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว) และ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `SubWeaponType ≠ 10` · กิ่งที่ 1 ของ `addSkillRate` · DEX รวม=255 หรือ อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว) และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `SubWeaponType = 10` หรือ อาวุธรองอื่น (ไม่ใช่ ดาบมือเดียว) และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `SubWeaponType ≠ 10` · DEX รวม=255]: **(555 + 40×Lv)%** → 595%, 635%, 675%, 715%, 755%, 795%, 835%, 875%, 915%, 955% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `SubWeaponType = 10` · กิ่งที่ 1 ของ `addSkillRate` · AGI รวม=100 หรือ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `SubWeaponType = 10` · AGI รวม=100]: **400%** → 400%, 400%, 400%, 400%, 400%, 400%, 400%, 400%, 400%, 400% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `SubWeaponType = 10` · กิ่งที่ 1 ของ `addSkillRate` · AGI รวม=255 หรือ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `SubWeaponType = 10` · AGI รวม=255]: **555%** → 555%, 555%, 555%, 555%, 555%, 555%, 555%, 555%, 555%, 555% (Lv1…10)
<!-- calc:end -->

