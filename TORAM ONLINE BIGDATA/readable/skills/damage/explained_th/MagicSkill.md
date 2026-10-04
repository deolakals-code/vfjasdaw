# สกิลเวทมนตร์ (`MagicSkill`) — คำอธิบายทีละสกิล (ภาษาไทย)

สร้างอัตโนมัติด้วย `scripts/render_explained_th.py` จาก `skill_reference.json` (ข้อมูลโค้ด client ชุดล่าสุด) ไม่มีข้อความเขียนมือ แก้ไฟล์นี้ตรง ๆ จะถูกเขียนทับ ตัวเลขทั้งหมดคำนวณจากโค้ด (Code) ความหมายของชื่อ field/บทบาทแปลจากชื่อในโค้ด (Inferred) ยังไม่ได้เทียบกับตัวเลขในเกม ข้อมูลดิบทุกเส้นทางอยู่ใน `../details/MagicSkill.md`

---

<!-- calc:preface -->
> **วิธีอ่านหัวข้อ "การคำนวณแบบตัวเลข"** (สร้างอัตโนมัติด้วย `scripts/render_calc_th.py` จาก `skill_reference.json` แก้มือจะถูกเขียนทับ)
> ดาเมจต่อฮิตเดินตามขั้น `SkillCalcTemplate/CalcStep` 0→40 ตามลำดับ (Code: `SkillCalcTemplate.GetDamage`) ขั้น `+` บวกเข้าดาเมจ ขั้น `×` คูณแล้วปัดเศษทิ้ง (int) ทันทีทุกขั้น
> ลำดับหลัก: ดาเมจฐาน(7) + คงที่สกิล(8) + คงที่บัพ(9) − ป้องกันเป้า(10) + ตีแรก(11) → ×คริ(13) → ×ธาตุ(15) → ×ตัวคูณสกิล(18) → ×ตีแรก(19) → ×เสถียร(21) → +คงที่ออโต้(22) → ×Proration(23) → ×ประเภท(24) → ×ดาเมจสุดท้าย(25) → … → เพดาน/ขั้นต่ำ(35–37)
> "ฮิต N" = template ดาเมจแต่ละก้อน (ทอยคริแยกกัน) แยกตามเมธอดและตัวแปรฮิตในโค้ด (`type`, `isFirst`, `attackCount` …) ชื่อฮิต/ส่วนมาจากชื่อในโค้ด (Inferred) ตัวเลขคำนวณจากโค้ด (Code) โดยตั้งเจม/บัพเสริม = 0
> ค่าหลายก้อนในขั้นเดียวกันแบบ "บวกเข้าช่อง" จะบวกกันก่อนคูณ ส่วน "ตั้งค่าทับ" แทนที่ค่าเดิม ค่าที่ขึ้นกับสเตตัสแสดงเป็นตัวอย่างที่ 100 / 255 (และ Lv สกิลอื่น 1 / 10) ใช้สูตรที่แนบไว้คำนวณค่าอื่นเอง
<!-- calc:preface-end -->

### เวทมนตร์:แอร์โรว์ / ธนูไฟ / ธนูน้ำ / ธนูลม / ธนูดิน / ธนูแสง / ธนูมืด (MagicArrow) · uid 97

<img src="../../icons/sk_097.png" width="40" alt="icon">

- ทรี: สกิลเวทมนตร์ (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `MagicArrowAction` · สถานะการแกะ: แกะครบจากโค้ด

> ยิงด้วยธนูเวทขนาดเล็ก
> จำนวนที่ยิงออกไปจะเพิ่มขึ้นตามเลเวล

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: *พลัง+25
- Lv15: *เพิ่มจำนวนครั้งการโจมตี

<!-- calc:begin uid=97 -->
#### การคำนวณแบบตัวเลข — MagicArrow (uid 97)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **90 + 5×Lv** → 95, 100, 105, 110, 115, 120, 125, 130, 135, 140 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก อุปกรณ์เวท และ `(isPlayer & 1) ≠ 0` หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท) และ `(isPlayer & 1) ≠ 0`]: **(65 + 6×Lv)%** → 71%, 77%, 83%, 89%, 95%, 101%, 107%, 113%, 119%, 125% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ไม้เท้า]: **(90 + 6×Lv)%** → 96%, 102%, 108%, 114%, 120%, 126%, 132%, 138%, 144%, 150% (Lv1…10)

**จำนวนฮิต / ตัวนับ**
- `damageCount` (ตั้งใน `OnInitialize`) [อาวุธหลัก อุปกรณ์เวท]: 4, 4, 5, 5, 6, 6, 7, 7, 8, 8 (Lv1…10)
- `LoopParam` (ตั้งใน `OnInitialize`) [อาวุธหลัก อุปกรณ์เวท]: 4, 4, 5, 5, 6, 6, 7, 7, 8, 8 (Lv1…10)
- `damageCount` (ตั้งใน `OnInitialize`) [อาวุธหลัก ไม้เท้า หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท/ไม้เท้า)]: 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 (Lv1…10)
- `LoopParam` (ตั้งใน `OnInitialize`) [อาวุธหลัก ไม้เท้า หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท/ไม้เท้า)]: 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 (Lv1…10)
- `damageCount` (ตั้งใน `InitializeOthers`): `motionSpeed`
- `LoopParam` (ตั้งใน `InitializeEnchantedSpell`) [อาวุธหลัก อุปกรณ์เวท และ `(isPlayer & 1) ≠ 0`]: 4, 4, 5, 5, 6, 6, 7, 7, 8, 8 (Lv1…10)
- `damageCount` (ตั้งใน `InitializeEnchantedSpell`) [อาวุธหลัก อุปกรณ์เวท และ `(isPlayer & 1) ≠ 0`]: 4, 4, 5, 5, 6, 6, 7, 7, 8, 8 (Lv1…10)
- `LoopParam` (ตั้งใน `InitializeEnchantedSpell`) [อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท) และ `(isPlayer & 1) ≠ 0`]: 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 (Lv1…10)
- `damageCount` (ตั้งใน `InitializeEnchantedSpell`) [อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท) และ `(isPlayer & 1) ≠ 0`]: 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 (Lv1…10)
<!-- calc:end -->

### เวทมนตร์:แจฟลิน / หอกเพลิง / หอกน้ำแข็ง / หอกวายุ / หอกศิลา / หอกศักดิ์สิทธิ์ / หอกอนธการ (MagicJabelin) · uid 98

<img src="../../icons/sk_098.png" width="40" alt="icon">

- ทรี: สกิลเวทมนตร์ (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: [N]เวทมนตร์:แอร์โรว์[F]ธนูไฟ[A]ธนูน้ำ[W]ธนูลม[E]ธนูดิน[L]ธนูแสง[D]ธนูมืด[N] · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `MagicJabelinAction` · สถานะการแกะ: แกะครบจากโค้ด

> ปล่อยหอกเวทขนาดใหญ่
> มีโอกาสทำให้เป้าหมายติดสภาวะผิดปกติ
> สภาวะนั้นจะเปลี่ยนไปตามธาตุ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท; ช่อง proration เป็นช่องตีปกติเมื่อเปิด ExSkill spell tuning (Rod), ไม่งั้นช่องเวท — เงื่อนไข: Magic: always
- Proration: ช่องที่เลือกตอนร่าย (กายภาพ/เวท) · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `abnormalRate` [อาวุธหลัก อุปกรณ์เวท]: 32, 40, 47, 55, 62, 70, 77, 85, 92, 100 (Lv1…10) %
- โอกาสติดสถานะ `abnormalRate` [อาวุธหลัก ไม้เท้า หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท/ไม้เท้า)]: 7, 15, 22, 30, 37, 45, 52, 60, 67, 75 (Lv1…10) %
- โอกาสติดสถานะ `abnormalRate` [อาวุธหลัก อุปกรณ์เวท และ `(isPlayer & 1) ≠ 0`]: 32, 40, 47, 55, 62, 70, 77, 85, 92, 100 (Lv1…10) %
- โอกาสติดสถานะ `abnormalRate` [อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท) และ `(isPlayer & 1) ≠ 0`]: 7, 15, 22, 30, 37, 45, 52, 60, 67, 75 (Lv1…10) %
- สถานะที่ทำให้ติด: ผงะ (Flinch)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: *พลัง+50
- Lv15: *อัตราติดสภาวะผิดปกติ+25%

<!-- calc:begin uid=98 -->
#### การคำนวณแบบตัวเลข — MagicJabelin (uid 98)
Proration: ช่อง `dynamic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **50 + 15×Lv** → 65, 80, 95, 110, 125, 140, 155, 170, 185, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก อุปกรณ์เวท และ `(isPlayer & 1) ≠ 0` หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท) และ `(isPlayer & 1) ≠ 0`]: **(150 + 10×Lv)%** → 160%, 170%, 180%, 190%, 200%, 210%, 220%, 230%, 240%, 250% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ไม้เท้า]: **(200 + 10×Lv)%** → 210%, 220%, 230%, 240%, 250%, 260%, 270%, 280%, 290%, 300% (Lv1…10)
<!-- calc:end -->

### เวทมนตร์:กำแพง / กำแพงอัคคี / ม่านวารี / กำแพงวายุ / เขตแดนปฐพี / เขตแดนศักดิ์สิทธิ์ / ประตูอสูร (MagicWall) · uid 99

<img src="../../icons/sk_099.png" width="40" alt="icon">

- ทรี: สกิลเวทมนตร์ (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: [N]เวทมนตร์:แอร์โรว์[F]ธนูไฟ[A]ธนูน้ำ[W]ธนูลม[E]ธนูดิน[L]ธนูแสง[D]ธนูมืด[N] · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `MagicWallAction` · สถานะการแกะ: แกะครบจากโค้ด

> สร้างกำแพงเวทขึ้นตรงปลายเท้า
> จะสร้างความเสียหายให้เป้าหมาย
> และผลักกระเด็นกลับไป

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: กระเด็น (KnockBack)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: *พลัง+30
- Lv15: *ระยะโจมตี (รัศมี)+1m

<!-- calc:begin uid=99 -->
#### การคำนวณแบบตัวเลข — MagicWall (uid 99)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **120 + 10×Lv** → 130, 140, 150, 160, 170, 180, 190, 200, 210, 220 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก อุปกรณ์เวท และ `(isPlayer & 1) ≠ 0`]: `(4 × Lv + baseINT // 10 + gemCart(106, [4]) + 80) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseINT` = แต้ม INT ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseINT (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ไม้เท้า หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท) และ `(isPlayer & 1) ≠ 0`]: **(80 + 4×Lv)%** → 84%, 88%, 92%, 96%, 100%, 104%, 108%, 112%, 116%, 120% (Lv1…10)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`!MobActionManagerBase.get_IsPlayerManaged(mobAction)` หรือ `MobActionManagerBase.get_IsPlayerManaged(mobAction)` และ `spellTuningWall ≠ 0` หรือ `MobActionManagerBase.get_IsPlayerManaged(mobAction)` และ `PlayerAttackBase.checkAbnormalPercent(this, 4, 100, playerAction)` และ `spellTuningWall = 0`]: `target.ExpDefMagic / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefMagic` = proration ช่อง Magic ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`!MobActionManagerBase.get_IsPlayerManaged(mobAction)` หรือ `MobActionManagerBase.get_IsPlayerManaged(mobAction)` และ `spellTuningWall ≠ 0` หรือ `MobActionManagerBase.get_IsPlayerManaged(mobAction)` และ `PlayerAttackBase.checkAbnormalPercent(this, 4, 100, playerAction)` และ `spellTuningWall = 0`]: `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_CharacterActionManagerBase` = ค่า Character Action Manager Base ของ MobActionManagerBase (ดูแท็บ Variables)

**จำนวนฮิต / ตัวนับ**
- `damageCount` (ตั้งใน `OnInitialize`) [อาวุธหลัก ไม้เท้า หรือ อาวุธหลัก อุปกรณ์เวท]: 15, 18, 18, 21, 21, 24, 24, 27, 27, 30 (Lv1…10)
- `LoopParam` (ตั้งใน `OnInitialize`) [อาวุธหลัก ไม้เท้า หรือ อาวุธหลัก อุปกรณ์เวท]: 15, 18, 18, 21, 21, 24, 24, 27, 27, 30 (Lv1…10)
- `damageCount` (ตั้งใน `OnInitialize`) [อาวุธหลัก ไม้เท้า หรือ อาวุธหลัก อุปกรณ์เวท]: 5, 6, 6, 7, 7, 8, 8, 9, 9, 10 (Lv1…10)
- `LoopParam` (ตั้งใน `OnInitialize`) [อาวุธหลัก ไม้เท้า หรือ อาวุธหลัก อุปกรณ์เวท]: 5, 6, 6, 7, 7, 8, 8, 9, 9, 10 (Lv1…10)
- `damageCount` (ตั้งใน `InitializeOthers`): `motionSpeed`
- `damageCount` (ตั้งใน `InitializeEnchantedSpell`) [อาวุธหลัก อุปกรณ์เวท และ `(isPlayer & 1) ≠ 0` หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท) และ `(isPlayer & 1) ≠ 0`]: 5, 6, 6, 7, 7, 8, 8, 9, 9, 10 (Lv1…10)
- `LoopParam` (ตั้งใน `InitializeEnchantedSpell`) [อาวุธหลัก อุปกรณ์เวท และ `(isPlayer & 1) ≠ 0` หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท) และ `(isPlayer & 1) ≠ 0`]: 5, 6, 6, 7, 7, 8, 8, 9, 9, 10 (Lv1…10)
<!-- calc:end -->

### เมจิกมาสเตอรี่ (MagicMastary) · uid 100

<img src="../../icons/sk_100.png" width="40" alt="icon">

- ทรี: สกิลเวทมนตร์ (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: ไม้เท้า, MainMagictool · ธง: StarGem
- คลาสในโค้ด: `MagicMastary` · สถานะการแกะ: แกะครบจากโค้ด

> ใช้อุปกรณ์เวทได้ชำนาญขึ้น
> เพิ่มพลังโจมตีเมื่อใช้ไม้เท้า
> หรืออุปกรณ์เวท

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ATK อาวุธ % (`EqAtkRate`): 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 (Lv1…10)
- พาสซีฟ MATK % (`MatkRate`): 1, 1, 1, 1, 1, 1, 2, 2, 2, 2 (Lv1…10)

### ชาร์จ MP (Charging) · uid 101

<img src="../../icons/sk_101.png" width="40" alt="icon">

- ทรี: สกิลเวทมนตร์ (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: StarGem
- คลาสในโค้ด: `ChargingAction` · สถานะการแกะ: แกะครบจากโค้ด

> ฟื้นฟู MP ด้วยการชาร์จพลังเวท
> ใช้เวลาชาร์จน้อยลงเมื่อเลเวลเพิ่มขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `ChargingBuf`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `MaximuyzerAction.ActionStart` — MaximuyzerAction: ตอนเริ่มทำงานของสกิล (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MaximuyzerSwitchingBuff.ConverterMaximuyzerSwitching` — MaximuyzerSwitchingBuff.ConverterMaximuyzerSwitching: คืนค่า `_t834` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.RemoveAfterSkillBuf` — PlayerAttackBase.RemoveAfterSkillBuf: [call] `SkillBufferManager$$RemoveBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Charging` เมื่อ (PlayerAttackBase.ContainsNotApplicableSkill(PlayerAttackBase.get_ActionID()) & 1) eq 0 AND (SkillBufferManager.Contain… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: *ใช้เวลาชาร์จน้อยลง
- Lv15: *ใช้เวลาชาร์จน้อยลงเล็กน้อย ฟื้นฟู MP+50

### เวทมนตร์:แลนซ์  / วัลแคน  / ไอซ์ซิเคิล / สลาตัน / ปืนใหญ่ศิลา / แสงสังหาร / สุริยคราส (MagicLancer) · uid 102

<img src="../../icons/sk_102.png" width="40" alt="icon">

- ทรี: สกิลเวทมนตร์ (ขั้น 2) · เลเวลสูงสุด: 30 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: [N]เวทมนตร์:แจฟลิน[F]หอกเพลิง[A]หอกน้ำแข็ง[W]หอกวายุ[E]หอกศิลา[L]หอกศักดิ์สิทธิ์[D]หอกอนธการ[N] · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `MagicLancerAction` · สถานะการแกะ: แกะครบจากโค้ด

> ยิงหอกเวทต่อเนื่อง
> จำนวนที่ยิงออกไปจะเพิ่มขึ้นตามเลเวล
> มีโอกาสทำให้เป้าหมาย[หยุดนิ่ง]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ, วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `stopPercent` [อาวุธหลัก ไม้เท้า และ `spellTuningLancer ≠ 0` หรือ อาวุธหลัก ไม้เท้า และ `ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ≠ 0` และ `TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ≠ 0`]: **30 + 6×Lv** → 36, 42, 48, 54, 60, 66, 72, 78, 84, 90 (Lv1…10) %
- โอกาสติดสถานะ `stopPercent` [อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท/ไม้เท้า) และ `spellTuningLancer ≠ 0` หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท/ไม้เท้า) และ `ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ≠ 0` และ `TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ≠ 0`]: **10 + 2×Lv** → 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 (Lv1…10) %
- โอกาสติดสถานะ `stopPercent` [อาวุธหลัก อุปกรณ์เวท และ `((20 - gemCart(205[2])) & 0x80000000) ≠ 0` และ `(isPlayer & 1) ≠ 0` หรือ อาวุธหลัก อุปกรณ์เวท และ `((20 - gemCart(205[2])) & 0x80000000) = 0` และ `(isPlayer & 1) ≠ 0`]: **90 + 18×Lv** → 108, 126, 144, 162, 180, 198, 216, 234, 252, 270 (Lv1…10) %
- สถานะที่ทำให้ติด: หยุดนิ่ง (Stop)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: *พลัง+150 *พลังจะเพิ่มมากกว่าค่า INT ของตัวเอง *อัตราติดหยุดนิ่งx3
- Lv15: *พลังจะเพิ่มมากกว่าค่า INT ของตัวเอง *เพิ่มจำนวนครั้งการโจมตี *อัตราติดหยุดนิ่งx3

<!-- calc:begin uid=102 -->
#### การคำนวณแบบตัวเลข — MagicLancer (uid 102)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **300 + 4×Lv** → 304, 308, 312, 316, 320, 324, 328, 332, 336, 340 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก อุปกรณ์เวท และ `((20 - gemCart(205[2])) & 0x80000000) ≠ 0` และ `(isPlayer & 1) ≠ 0` หรือ อาวุธหลัก อุปกรณ์เวท และ `((20 - gemCart(205[2])) & 0x80000000) = 0` และ `(isPlayer & 1) ≠ 0` · INT รวม=100]: **(270 + 15×Lv)%** → 285%, 300%, 315%, 330%, 345%, 360%, 375%, 390%, 405%, 420% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก อุปกรณ์เวท และ `((20 - gemCart(205[2])) & 0x80000000) ≠ 0` และ `(isPlayer & 1) ≠ 0` หรือ อาวุธหลัก อุปกรณ์เวท และ `((20 - gemCart(205[2])) & 0x80000000) = 0` และ `(isPlayer & 1) ≠ 0` · INT รวม=255]: **(301 + 15×Lv)%** → 316%, 331%, 346%, 361%, 376%, 391%, 406%, 421%, 436%, 451% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท) และ `((20 - gemCart(205[2])) & 0x80000000) ≠ 0` และ `(isPlayer & 1) ≠ 0` หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท) และ `((20 - gemCart(205[2])) & 0x80000000) = 0` และ `(isPlayer & 1) ≠ 0`]: **(250 + 15×Lv)%** → 265%, 280%, 295%, 310%, 325%, 340%, 355%, 370%, 385%, 400% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ไม้เท้า และ `spellTuningLancer ≠ 0` หรือ อาวุธหลัก ไม้เท้า และ `ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ≠ 0` และ `TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ≠ 0` · INT รวม=100]: **(420 + 15×Lv)%** → 435%, 450%, 465%, 480%, 495%, 510%, 525%, 540%, 555%, 570% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ไม้เท้า และ `spellTuningLancer ≠ 0` หรือ อาวุธหลัก ไม้เท้า และ `ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ≠ 0` และ `TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ≠ 0` · INT รวม=255]: **(451 + 15×Lv)%** → 466%, 481%, 496%, 511%, 526%, 541%, 556%, 571%, 586%, 601% (Lv1…10)

**จำนวนฮิต / ตัวนับ**
- `damageCount` (ตั้งใน `OnInitialize`) [อาวุธหลัก อุปกรณ์เวท และ `spellTuningLancer ≠ 0` หรือ อาวุธหลัก อุปกรณ์เวท และ `ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ≠ 0` และ `TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ≠ 0`]: 4, 4, 4, 4, 4, 5, 5, 5, 5, 5 (Lv1…10)
- `LoopParam` (ตั้งใน `OnInitialize`) [อาวุธหลัก อุปกรณ์เวท และ `spellTuningLancer ≠ 0` หรือ อาวุธหลัก อุปกรณ์เวท และ `ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ≠ 0` และ `TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ≠ 0`]: 4, 4, 4, 4, 4, 5, 5, 5, 5, 5 (Lv1…10)
- `damageCount` (ตั้งใน `OnInitialize`) [อาวุธหลัก ไม้เท้า และ `spellTuningLancer ≠ 0` หรือ อาวุธหลัก ไม้เท้า และ `ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ≠ 0` และ `TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ≠ 0`]: 2, 2, 2, 2, 2, 3, 3, 3, 3, 3 (Lv1…10)
- `LoopParam` (ตั้งใน `OnInitialize`) [อาวุธหลัก ไม้เท้า และ `spellTuningLancer ≠ 0` หรือ อาวุธหลัก ไม้เท้า และ `ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ≠ 0` และ `TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ≠ 0`]: 2, 2, 2, 2, 2, 3, 3, 3, 3, 3 (Lv1…10)
- `LoopParam` (ตั้งใน `InitializeOthers`): `motionSpeed`
- `damageCount` (ตั้งใน `InitializeEnchantedSpell`) [อาวุธหลัก อุปกรณ์เวท และ `((20 - gemCart(205[2])) & 0x80000000) ≠ 0` และ `(isPlayer & 1) ≠ 0` หรือ อาวุธหลัก อุปกรณ์เวท และ `((20 - gemCart(205[2])) & 0x80000000) = 0` และ `(isPlayer & 1) ≠ 0`]: 4, 4, 4, 4, 4, 5, 5, 5, 5, 5 (Lv1…10)
- `LoopParam` (ตั้งใน `InitializeEnchantedSpell`) [อาวุธหลัก อุปกรณ์เวท และ `((20 - gemCart(205[2])) & 0x80000000) ≠ 0` และ `(isPlayer & 1) ≠ 0` หรือ อาวุธหลัก อุปกรณ์เวท และ `((20 - gemCart(205[2])) & 0x80000000) = 0` และ `(isPlayer & 1) ≠ 0`]: 4, 4, 4, 4, 4, 5, 5, 5, 5, 5 (Lv1…10)
- `damageCount` (ตั้งใน `InitializeEnchantedSpell`) [อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท) และ `((20 - gemCart(205[2])) & 0x80000000) ≠ 0` และ `(isPlayer & 1) ≠ 0` หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท) และ `((20 - gemCart(205[2])) & 0x80000000) = 0` และ `(isPlayer & 1) ≠ 0`]: 2, 2, 2, 2, 2, 3, 3, 3, 3, 3 (Lv1…10)
- `LoopParam` (ตั้งใน `InitializeEnchantedSpell`) [อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท) และ `((20 - gemCart(205[2])) & 0x80000000) ≠ 0` และ `(isPlayer & 1) ≠ 0` หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท) และ `((20 - gemCart(205[2])) & 0x80000000) = 0` และ `(isPlayer & 1) ≠ 0`]: 2, 2, 2, 2, 2, 3, 3, 3, 3, 3 (Lv1…10)
<!-- calc:end -->

### เวทมนตร์:บลาส / เอ็กซ์โพลชั่น  / แอบโซลูทซีโร่ / แอร์โรว์บลาส / จีโออิมแพ็ค / ไชน์นิ่งบลาส / อีวิลบลาส (MagicBlast) · uid 103

<img src="../../icons/sk_103.png" width="40" alt="icon">

- ทรี: สกิลเวทมนตร์ (ขั้น 2) · เลเวลสูงสุด: 30 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: [N]เวทมนตร์:กำแพง[F]กำแพงอัคคี[A]ม่านวารี[W]กำแพงวายุ[E]เขตแดนปฐพี[L]เขตแดนศักดิ์สิทธิ์[D]ประตูอสูร[N] · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `MagicBlastAction` · สถานะการแกะ: แกะครบจากโค้ด

> รวบรวมพลังเวทสร้างระเบิดขนาดใหญ่
> มีโอกาสทำให้เป้าหมายติดสภาวะผิดปกติ
> สภาวะนั้นจะเปลี่ยนไปตามธาตุ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `abnormalRate` [อาวุธหลัก อุปกรณ์เวท]: **10 + Lv** → 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 (Lv1…10) %
- โอกาสติดสถานะ `abnormalRate` [อาวุธหลัก อุปกรณ์เวท]: **50 + 5×Lv** → 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 (Lv1…10) %
- โอกาสติดสถานะ `abnormalRate` [อาวุธหลัก ไม้เท้า หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท/ไม้เท้า)]: **Lv** → 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10) %
- โอกาสติดสถานะ `abnormalRate` [อาวุธหลัก ไม้เท้า หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท/ไม้เท้า)]: **5×Lv** → 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10) %
- โอกาสติดสถานะ `abnormalRate` [อาวุธหลัก อุปกรณ์เวท และ `(isPlayer & 1) ≠ 0`]: **50 + 5×Lv** → 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 (Lv1…10) %
- โอกาสติดสถานะ `abnormalRate` [อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท) และ `(isPlayer & 1) ≠ 0`]: **5×Lv** → 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10) %
- สถานะที่ทำให้ติด: ผงะ (Flinch)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: *พลัง+150 *พลังจะเพิ่มมากกว่าค่า INT ของตัวเอง
- Lv15: *พลังจะเพิ่มมากกว่าค่า INT ของตัวเอง *อัตราติดสภาวะผิดปกติ+50% *ระยะโจมตี (รัศมี)+2m

<!-- calc:begin uid=103 -->
#### การคำนวณแบบตัวเลข — MagicBlast (uid 103)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **180 + 20×Lv** → 200, 220, 240, 260, 280, 300, 320, 340, 360, 380 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก อุปกรณ์เวท · INT รวม=100 หรือ อาวุธหลัก อุปกรณ์เวท และ `(isPlayer & 1) ≠ 0` · INT รวม=100]: **(720 + 30×Lv)%** → 750%, 780%, 810%, 840%, 870%, 900%, 930%, 960%, 990%, 1020% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก อุปกรณ์เวท · INT รวม=255 หรือ อาวุธหลัก อุปกรณ์เวท และ `(isPlayer & 1) ≠ 0` · INT รวม=255]: **(751 + 30×Lv)%** → 781%, 811%, 841%, 871%, 901%, 931%, 961%, 991%, 1021%, 1051% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท) และ `(isPlayer & 1) ≠ 0`]: **(700 + 30×Lv)%** → 730%, 760%, 790%, 820%, 850%, 880%, 910%, 940%, 970%, 1000% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ไม้เท้า · INT รวม=100]: **(870 + 30×Lv)%** → 900%, 930%, 960%, 990%, 1020%, 1050%, 1080%, 1110%, 1140%, 1170% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ไม้เท้า · INT รวม=255]: **(901 + 30×Lv)%** → 931%, 961%, 991%, 1021%, 1051%, 1081%, 1111%, 1141%, 1171%, 1201% (Lv1…10)
<!-- calc:end -->

### เชนแคสต์ (ChainCast) · uid 104

<img src="../../icons/sk_104.png" width="40" alt="icon">

- ทรี: สกิลเวทมนตร์ (ขั้น 2) · เลเวลสูงสุด: 30 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ชาร์จ MP
- คลาสในโค้ด: `ChainCast` · สถานะการแกะ: แกะครบจากโค้ด

> ร่ายเวทได้อย่างมีประสิทธิภาพ
> ร่ายได้เร็วขึ้นหลังใช้ "เวทมนตร์:แอร์โรว์"
> 
> เอฟเฟกต์เพิ่มเติมจะได้รับจากไม้เท้าหรืออุปกรณ์เวทมนตร์ (หลัก)

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, พาสซีฟ
- บัพ `ChainCastBuf`: ความเร็วท่าทาง % (`MotionSpeedRate`) = 5×Lv → 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10)
- บัพ `ChainCastStackBuf`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); Next(): `LeftTime` = `30` · ความเร็วท่าทาง + (`MotionSpeed`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); Next(): `LeftTime` = `30` · MATK + (`MatkUp`) = `((Count * Lv) << (EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 15 ? 1 : 0))` (ตัวนับที่เปลี่ยนตามเหตุการณ์); Next(): `LeftTime` = `30` · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `((Count * Lv) << (EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 14 ? 1 : 0))` (ตัวนับที่เปลี่ยนตามเหตุการณ์); Next(): `LeftTime` = `30` · ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); Next(): `LeftTime` = `30`

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: ทุกครั้งที่โจมตีด้วยสกิลโจมตีที่มีระยะเวลาร่ายเวทย์เวลา ในการร่ายจะสั้นลง MATK เพิ่มขึ้นเล็กน้อยและความเสถียร เวทมนต์จะเพิ่มขึ้น สามารถรับเอฟเฟกต์นี้ได้สูงสุด 10 ครั้ง
- Lv15: ทุกครั้งที่โจมตีด้วยสกิลโจมตีที่มีระยะเวลาร่ายเวทย์ เวลาในการร่ายจะสั้นลง MATK เพิ่มขึ้นและความเสถียร เวทมนต์จะเพิ่มขึ้นเล็กน้อยสามารถรับเอฟเฟกต์นี้ได้สูงสุด 10 ครั้ง

<!-- calc:begin uid=104 -->
#### การคำนวณแบบตัวเลข — ChainCast (uid 104)

**ค่าบัพที่ขึ้นกับจำนวน stack**

- บัพ `ChainCastStackBuf` — `MatkUp` ตามจำนวน `Count`: `Count × Lv << (EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData()) = 15 ? 1 : 0)`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |

- บัพ `ChainCastStackBuf` — `Value` ตามจำนวน `Count`: `Count × Lv << (EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData()) = 14 ? 1 : 0)`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |
<!-- calc:end -->

### เมจิคไนฟ์ (MagicKnife) · uid 117

<img src="../../icons/sk_117.png" width="40" alt="icon">

- ทรี: สกิลเวทมนตร์ (ขั้น 2) · เลเวลสูงสุด: 30 · อาวุธ: ไม้เท้า · ต้องเรียนก่อน: เมจิกมาสเตอรี่
- คลาสในโค้ด: `MagicKnifeAction` · สถานะการแกะ: แกะครบจากโค้ด

> ใช้มีดสั้นเวทมนตร์ยับยั้งศัตรู
> สกิลนี้โจมตีด้วย[ความเคยชินตามปกติ]
> เล็งตรงเป้าและเมื่อโจมตีเข้าเป้าจะฟื้นฟู MP เล็กน้อย
> เมื่อถึง Lv10 โจมตีเพิ่มและโจมตีด้วยความเคยชินตามปกติจะเพิ่มขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 3 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: ธรรมดา (SkillNormal)
- Proration: ช่องตีปกติ · สกิลเช็กเองว่าจะเปลี่ยนค่าหรือไม่

<!-- calc:begin uid=117 -->
#### การคำนวณแบบตัวเลข — MagicKnife (uid 117)
Proration: ช่อง `Normal` โหมด `custom_check`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): 70%, 80%, 90%, 100%, 110%, 120%, 130%, 140%, 150%, 150% (Lv1…10)
  - สูตร: `skillRate / 100` — โดยที่ `skillRate` = `System.Math.Min(10 × Lv + 60, 150)`

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `ActionStart`): `int(MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)))`
<!-- calc:end -->

### เวทมนตร์:อิมแพ็ค (MagicImpact) · uid 105

<img src="../../icons/sk_105.png" width="40" alt="icon">

- ทรี: สกิลเวทมนตร์ (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: [N]เวทมนตร์:แลนซ์ [F]วัลแคน [A]ไอซ์ซิเคิล[W]สลาตัน[E]ปืนใหญ่ศิลา[L]แสงสังหาร[D]สุริยคราส[N] · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `MagicImpactAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีศัตรูรอบบริเวณด้วยพลังคลื่นทำลายล้าง
> ลดการใช้ MP ลงครึ่งหนึ่งเมื่อใช้สกิลถัดไป
> ประสิทธิภาพของสกิลจะลดลงเมื่อใช้อย่างต่อเนื่อง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท; ช่อง proration เป็นช่องสกิลกายภาพเมื่อมีเจมคาร์ท 403, ไม่งั้นช่องเวท — เงื่อนไข: Magic: always
- Proration: ช่องที่เลือกตอนร่าย (กายภาพ/เวท) · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `abnormalRate` [อาวุธหลัก ไม้เท้า และ `PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) > 0` และ มีบัพ 105 MagicImpact หรือ อาวุธหลัก ไม้เท้า และ `PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) ≤ 0` และ มีบัพ 105 MagicImpact หรือ อาวุธหลัก อุปกรณ์เวท และ `PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) > 0` และ มีบัพ 105 MagicImpact]: **Lv** → 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10) %
- โอกาสติดสถานะ `abnormalRate` [อาวุธหลัก อุปกรณ์เวท และ ไม่มีบัพ 105 MagicImpact และ `(ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 105) & 256) ≠ 0` และ `PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) > 0` และ … หรือ อาวุธหลัก อุปกรณ์เวท และ ไม่มีบัพ 105 MagicImpact และ `(ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 105) & 256) ≠ 0` และ `PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) ≤ 0` และ … หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท/ไม้เท้า) และ ไม่มีบัพ 105 MagicImpact และ `(ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 105) & 256) ≠ 0` และ `PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) > 0` และ …]: **50 + 5×Lv** → 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 (Lv1…10) %
- โอกาสติดสถานะ `abnormalRate` [อาวุธหลัก อุปกรณ์เวท และ ไม่มีบัพ 105 MagicImpact และ `TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) = 0` หรือ อาวุธหลัก อุปกรณ์เวท และ ไม่มีบัพ 105 MagicImpact และ `PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) > 0` หรือ อาวุธหลัก อุปกรณ์เวท และ ไม่มีบัพ 105 MagicImpact และ `PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) ≤ 0`]: **15 + 5×Lv** → 20, 25, 30, 35, 40, 45, 50, 55, 60, 65 (Lv1…10) %
- โอกาสติดสถานะ `abnormalRate` [อาวุธหลัก ไม้เท้า และ ไม่มีบัพ 105 MagicImpact และ `(ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 105) & 256) ≠ 0` และ `PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) > 0` และ … หรือ อาวุธหลัก ไม้เท้า และ ไม่มีบัพ 105 MagicImpact และ `(ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 105) & 256) ≠ 0` และ `PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) ≤ 0` และ …]: **75 + 5×Lv** → 80, 85, 90, 95, 100, 105, 110, 115, 120, 125 (Lv1…10) %
- โอกาสติดสถานะ `abnormalRate` [อาวุธหลัก ไม้เท้า และ ไม่มีบัพ 105 MagicImpact และ `TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) = 0` หรือ อาวุธหลัก ไม้เท้า และ ไม่มีบัพ 105 MagicImpact และ `PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) > 0` หรือ อาวุธหลัก ไม้เท้า และ ไม่มีบัพ 105 MagicImpact และ `PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) ≤ 0`]: **40 + 5×Lv** → 45, 50, 55, 60, 65, 70, 75, 80, 85, 90 (Lv1…10) %
- โอกาสติดสถานะ `abnormalRate` [อาวุธหลัก อุปกรณ์เวท และ `(isPlayer & 1) ≠ 0` และ `isUseMagicImpact` หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท) และ `(isPlayer & 1) ≠ 0` และ `isUseMagicImpact`]: **Lv** → 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10) %
- โอกาสติดสถานะ `abnormalRate` [อาวุธหลัก อุปกรณ์เวท และ `(isPlayer & 1) ≠ 0` และ ไม่ `isUseMagicImpact` หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท) และ `(isPlayer & 1) ≠ 0` และ ไม่ `isUseMagicImpact`]: **15 + 5×Lv** → 20, 25, 30, 35, 40, 45, 50, 55, 60, 65 (Lv1…10) %
- สถานะที่ทำให้ติด: ล้มคว่ำ (Tumble)
- บัพ `MagicImpactBuf`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `MagicImpactAction.OnInitialize` — MagicImpactAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `isUseMagicImpact` = `1` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.MagicImpact) & 1) ne 0; [set] `abnormalRate` = `Lv` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.MagicImpact) & 1) ne 0; [set] `skillRate` = `((Lv + (Lv << 2)) << 1)` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.MagicImpact) & 1) ne 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.RemoveAfterSkillBuf` — PlayerAttackBase.RemoveAfterSkillBuf: [call] `SkillBufferManager$$RemoveBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.MagicImpact` เมื่อ (PlayerAttackBase.ContainsNotApplicableSkill(PlayerAttackBase.get_ActionID()) & 1) eq 0 AND (SkillBufferManager.Contain… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: *อัตราติดล้มคว่ำ+25%
- Lv15: *พลัง+250

<!-- calc:begin uid=105 -->
#### การคำนวณแบบตัวเลข — MagicImpact (uid 105)
Proration: ช่อง `dynamic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [อาวุธหลัก อุปกรณ์เวท และ `(isPlayer & 1) ≠ 0` และ `isUseMagicImpact` หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท) และ `(isPlayer & 1) ≠ 0` และ `isUseMagicImpact` หรือ อาวุธหลัก อุปกรณ์เวท และ `(isPlayer & 1) ≠ 0` และ ไม่ `isUseMagicImpact` หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท) และ `(isPlayer & 1) ≠ 0` และ ไม่ `isUseMagicImpact`]: **100 + 10×Lv** → 110, 120, 130, 140, 150, 160, 170, 180, 190, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก อุปกรณ์เวท และ `(isPlayer & 1) ≠ 0` และ `isUseMagicImpact` หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท) และ `(isPlayer & 1) ≠ 0` และ `isUseMagicImpact`]: **(10×Lv)%** → 10%, 20%, 30%, 40%, 50%, 60%, 70%, 80%, 90%, 100% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก อุปกรณ์เวท และ ไม่มีบัพ 105 MagicImpact และ `(ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 105) & 256) ≠ 0` และ `PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) > 0` และ … หรือ อาวุธหลัก อุปกรณ์เวท และ ไม่มีบัพ 105 MagicImpact และ `(ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 105) & 256) ≠ 0` และ `PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) ≤ 0` และ …]: **(500 + 25×Lv)%** → 525%, 550%, 575%, 600%, 625%, 650%, 675%, 700%, 725%, 750% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก อุปกรณ์เวท และ `(isPlayer & 1) ≠ 0` และ ไม่ `isUseMagicImpact`]: **(250 + 25×Lv)%** → 275%, 300%, 325%, 350%, 375%, 400%, 425%, 450%, 475%, 500% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท) และ `(isPlayer & 1) ≠ 0` และ ไม่ `isUseMagicImpact`]: **(25×Lv)%** → 25%, 50%, 75%, 100%, 125%, 150%, 175%, 200%, 225%, 250% (Lv1…10)
<!-- calc:end -->

### เวทมนตร์:สตรอม / ไฟเออร์สตรอม / โฟรเซนไซโคลน / ธันเดอร์สตรอม / แซนด์สตรอม / ลักซ์วอร์เทคซ์ / อีวิวเทมเพสต์ (MagicStorm) · uid 106

<img src="../../icons/sk_106.png" width="40" alt="icon">

- ทรี: สกิลเวทมนตร์ (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: [N]เวทมนตร์:บลาส[F]เอ็กซ์โพลชั่น [A]แอบโซลูทซีโร่[W]แอร์โรว์บลาส[E]จีโออิมแพ็ค[L]ไชน์นิ่งบลาส[D]อีวิลบลาส[N] · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `MagicStormAction` · สถานะการแกะ: แกะครบจากโค้ด

> เวทมนตร์สร้างพายุหมุน
> สร้างความเสียหายด้วยการดูดศัตรูเข้าไป
> ศัตรูที่มีความแข็งแกร่งอาจไม่ถูกดูด

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: Suction (Suction)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: *พลัง+100
- Lv15: *ระยะโจมตี (รัศมี)+2m

<!-- calc:begin uid=106 -->
#### การคำนวณแบบตัวเลข — MagicStorm (uid 106)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **420** → 420, 420, 420, 420, 420, 420, 420, 420, 420, 420 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก อุปกรณ์เวท และ `spellTuningStorm ≠ 0` หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท/ไม้เท้า) และ `spellTuningStorm ≠ 0` หรือ อาวุธหลัก อุปกรณ์เวท และ `ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 106) ≠ 0` และ `TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ≠ 0`]: **(310 + 4×Lv)%** → 314%, 318%, 322%, 326%, 330%, 334%, 338%, 342%, 346%, 350% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก อุปกรณ์เวท และ `(isPlayer & 1) ≠ 0` หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท) และ `(isPlayer & 1) ≠ 0`]: **(130 + 2×Lv)%** → 132%, 134%, 136%, 138%, 140%, 142%, 144%, 146%, 148%, 150% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ไม้เท้า และ `spellTuningStorm ≠ 0` หรือ อาวุธหลัก ไม้เท้า และ `ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 106) ≠ 0` และ `TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ≠ 0`]: **(410 + 4×Lv)%** → 414%, 418%, 422%, 426%, 430%, 434%, 438%, 442%, 446%, 450% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ไม้เท้า และ `spellTuningStorm = 0` หรือ อาวุธหลัก ไม้เท้า และ `ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 106) = 0` และ `TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ≠ 0`]: **(230 + 2×Lv)%** → 232%, 234%, 236%, 238%, 240%, 242%, 244%, 246%, 248%, 250% (Lv1…10)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `target.ExpDefMagic / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefMagic` = proration ช่อง Magic ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_CharacterActionManagerBase` = ค่า Character Action Manager Base ของ MobActionManagerBase (ดูแท็บ Variables)

**จำนวนฮิต / ตัวนับ**
- `damageCount` (ตั้งใน `OnInitialize`) [อาวุธหลัก ไม้เท้า และ `spellTuningStorm ≠ 0` หรือ อาวุธหลัก ไม้เท้า และ `spellTuningStorm = 0` หรือ อาวุธหลัก ไม้เท้า และ `ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 106) ≠ 0` และ `TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ≠ 0`]: 1, 2, 2, 3, 3, 4, 4, 5, 5, 6 (Lv1…10)
- `LoopParam` (ตั้งใน `OnInitialize`) [อาวุธหลัก ไม้เท้า และ `spellTuningStorm ≠ 0` หรือ อาวุธหลัก ไม้เท้า และ `spellTuningStorm = 0` หรือ อาวุธหลัก ไม้เท้า และ `ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 106) ≠ 0` และ `TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ≠ 0`]: 1, 2, 2, 3, 3, 4, 4, 5, 5, 6 (Lv1…10)
- `damageCount` (ตั้งใน `InitializeOthers`): `motionSpeed`
- `LoopParam` (ตั้งใน `InitializeOthers`): `motionSpeed`
- `hitCount` (ตั้งใน `OtherPlayerSkillEventReceive`) [`(skillEventId & 0xffff) = 1`]: `LoopParam`
- `hitCount` (ตั้งใน `AddHitCount`): `hitCount + 1`
<!-- calc:end -->

### พาวเวอร์เวฟ (PowerWave) · uid 107

<img src="../../icons/sk_107.png" width="40" alt="icon">

- ทรี: สกิลเวทมนตร์ (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: เชนแคสต์
- คลาสในโค้ด: `PowerWave` · สถานะการแกะ: แกะครบจากโค้ด

> ยิงคลื่นเวทมนตร์เมื่อการโจมตีปกติโจมตีไปไม่ถึง
> ใช้ได้ในระยะ 5m หรือน้อยกว่า
> จะเพิ่มขึ้นได้ถึง 10m ตามการเพิ่มของเลเวล
> การฟื้นฟู MP โจมตีจะใช้ได้กับสกิลนี้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- ตัวอ่านสกิลนี้ `GemCartBuffer.PowerWaveChangeBuff.OnGetValue` — PowerWaveChangeBuff.OnGetValue: คืนค่า `(_t355 >> 1)` (2 กรณี) (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: *พลัง+40 ระยะห่างที่สามารถใช้ได้+2m
- Lv15: *พลัง+70

### เวทมนตร์:อีเกล (MagicEgel) · uid 111

<img src="../../icons/sk_111.png" width="40" alt="icon">

- ทรี: สกิลเวทมนตร์ (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: ไม้เท้า, MainMagictool · ธง: NoMarketSearch
- คลาสในโค้ด: `MagicEgelAction` · สถานะการแกะ: แกะครบจากโค้ด

> แสงแห่งการปกปักษ์
> นอกจากตอนร่ายเวทมนตร์:อีเกล
> หรือหลังจากได้รับความเสียหายจะมีการโจมตี
> ด้วยเวทออกไปในช่วงเวลาที่เจาะจง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, เปลี่ยนการทำงานของตีปกติ
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `MagicEgelBuf`: บัพนับสแตก (สืบจาก `CountBufferBase`): ตัวนับ `Count` เริ่ม 0 เพิ่มทีละ 1 ด้วย `Next()` และสูงสุด Lv; โค้ดอื่นอ่านจำนวนสแตกผ่านพารามิเตอร์ `Count` (ดูค่าที่ใช้จริงในสูตรของสกิลที่อ้างถึง)
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = Lv ตามที่ `MagicEgelBuf` ส่งให้ตัวสร้างของ `บัพฐาน`

### คาดาร์เอเล็คซิโอ (KadarElexio) · uid 118

<img src="../../icons/sk_118.png" width="40" alt="icon">

- ทรี: สกิลเวทมนตร์ (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: ไม้เท้า · ต้องเรียนก่อน: เมจิคไนฟ์
- คลาสในโค้ด: `KadarElexioAction` · สถานะการแกะ: แกะครบจากโค้ด

> เทคนิคต้องห้ามที่สร้างภาระหนักหน่วงแก่จิตใจและร่างกาย
> ใช้ HP ปัจจุบันและ HP สูงสุด (ค่าสุ่ม) เพื่อลด MP ที่ใช้
> ในสกิลถัดไปลงครึ่งหนึ่งและรับประกันคริติคอล
> ถ้าใช้งานซ้ำๆ จนรับภาระหนักเกินไปก็คงจะ...

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, เปลี่ยนการทำงานของตีปกติ
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 100 ตามที่ `KadarElexioBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- บัพ `KadarElexioBuf`: HP สูงสุด % (`MaxHpUpRate`) = `-Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ค่าทั่วไปตัวที่ 2 (`Value2`) = `overloadValue` · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `isStack` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ดาเมจสุดท้ายที่ทำ % (`LastDmgUpRate`) = `(Count lt overloadValue ? Count : overloadValue)` (ตัวนับที่เปลี่ยนตามเหตุการณ์)
- ตัวอ่านสกิลนี้ `MobaPlayerBattleManager.OnBattleActive` — MobaPlayerBattleManager.OnBattleActive (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerBattleManager.OnBattleEnd` — MobaPlayerBattleManager.OnBattleEnd (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.<>c__DisplayClass111_0.<ActionPreparation>b__0` — <>c__DisplayClass111_0.<ActionPreparation>b__0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.ActionPreparation` — PlayerAttackBase: ขั้นเตรียมก่อนปล่อยสกิล (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.CalcCostMp` — MP ที่ใช้ของสกิล: คืนค่า `_t1395` (6 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.TemplateAssignment` — ใส่ค่าเอนจินลงทุกสเต็ปของ template (BaseDamage, Def, Crit, Stable, ExpRate, LastDamage ...): คืนค่า `PlayerAttackBase.TemplateAssignment(this, template, playerAction, mobAction)`; [call] `KadarElexioBuf$$CheckCritical` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.KadarElexio), PlayerAtta…` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.KadarElexio, out) & 1) ne 0 AND EquipI… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.OnBattleActive` — PlayerBattleManager.OnBattleActive (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.OnBattleEnd` — PlayerBattleManager.OnBattleEnd (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ReceiveSupportResult.OnEventPlayerSupport` — ReceiveSupportResult.OnEventPlayerSupport: [call] `KadarElexioBuf$$CreateOverloadStart` = `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.KadarElexio, 1), Pla…` เมื่อ (SkillUtil.CheckDanceSkill(skillId) & 1) eq 0 AND (skillId & 0xffff) le 708 AND (skillId & 0xffff) le 263 AND (skillId …; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), TryGetBuf<object>.out2(PlayerStatusBase.get_Sk…` เมื่อ (SkillUtil.CheckDanceSkill(skillId) & 1) eq 0 AND (skillId & 0xffff) le 708 AND (skillId & 0xffff) le 263 AND (skillId …; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.KadarElexio` เมื่อ (SkillUtil.CheckDanceSkill(skillId) & 1) eq 0 AND (skillId & 0xffff) le 708 AND (skillId & 0xffff) le 263 AND (skillId … (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: ตอนได้รับภาระจากพลังเวท (HP สูงสุดลดลงจากสกิลนี้) เมื่อเวลาผ่านไปพลังของสกิลเวทจะเพิ่มขึ้นทีละเล็กน้อย เมื่อผลของคาดาร์เอเล็คซิโอ เช่น ตอนพลังชีวิตหมด หรือย้ายแผนที่ หมดลงการเพิ่มพลังจะถูกรีเซ็ต

<!-- calc:begin uid=118 -->
#### การคำนวณแบบตัวเลข — KadarElexio (uid 118)

**ค่าบัพที่ขึ้นกับจำนวน stack**

- บัพ `KadarElexioBuf` — `MaxHpUpRate` ตามจำนวน `Count`: `-Count`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | -1 | -1 | -1 | -1 | -1 | -1 | -1 | -1 | -1 | -1 |
  | 2 | -2 | -2 | -2 | -2 | -2 | -2 | -2 | -2 | -2 | -2 |
  | 3 | -3 | -3 | -3 | -3 | -3 | -3 | -3 | -3 | -3 | -3 |
  | 4 | -4 | -4 | -4 | -4 | -4 | -4 | -4 | -4 | -4 | -4 |
  | 5 | -5 | -5 | -5 | -5 | -5 | -5 | -5 | -5 | -5 | -5 |

- บัพ `KadarElexioBuf` — `LastDmgUpRate` ตามจำนวน `Count`: `min(Count, overloadValue)`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |
<!-- calc:end -->

### เวทมนตร์: ไฟนอล (MagicFinaw) · uid 108

<img src="../../icons/sk_108.png" width="40" alt="icon">

- ทรี: สกิลเวทมนตร์ (ขั้น 4) · เลเวลสูงสุด: 150 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: เวทมนตร์:อิมแพ็ค · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `MagicFinawAction` · สถานะการแกะ: แกะครบจากโค้ด

> เวทมนตร์โจมตีที่มีผลในพื้นที่กว้าง
> ศัตรูที่อยู่ใกล้จุดศูนย์กลางของระยะโจมตีจะโดนพลังโจมตีอย่างรุนแรง
> ใช้เวลาร่ายนาน ไม่สามารถลดเวลาร่ายด้วย CSPD ได้
> เฮทจะเกิดขึ้นตามปกติระหว่างร่าย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: SystemAddHate (SystemAddHate)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: *พลัง +750 *พลังเพิ่มขึ้นตามค่า INT
- Lv15: *พลังเพิ่มขึ้นตามค่า INT *4x ระยะโจมตี (รัศมี) สำหรับ HIT ที่ 1 *2x ระยะโจมตี (รัศมี) สำหรับ HIT ที่ 2 และ 3

<!-- calc:begin uid=108 -->
#### การคำนวณแบบตัวเลข — MagicFinaw (uid 108)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcFinawData` (ส่วน FinawData)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`damageCount lo fixAddDamage.Length` และ `damageCount lo skillRate.Length`]: `fixAddDamage[damageCount]` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`damageCount lo fixAddDamage.Length` และ `damageCount lo skillRate.Length` หรือ `damageCount hs fixAddDamage.Length` และ `damageCount lo skillRate.Length`]: `skillRate[damageCount]` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`damageCount hs skillRate.Length` หรือ `damageCount lo fixAddDamage.Length` และ `damageCount lo skillRate.Length` หรือ `damageCount hs fixAddDamage.Length` และ `damageCount lo skillRate.Length`]: `target.ExpDefMagic / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefMagic` = proration ช่อง Magic ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`damageCount hs skillRate.Length` หรือ `damageCount lo fixAddDamage.Length` และ `damageCount lo skillRate.Length` หรือ `damageCount hs fixAddDamage.Length` และ `damageCount lo skillRate.Length`]: `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_CharacterActionManagerBase` = ค่า Character Action Manager Base ของ MobActionManagerBase (ดูแท็บ Variables)

**จำนวนฮิต / ตัวนับ**
- `damageCount` (ตั้งใน `NextRangeHit`) [`addHate = 0`]: `damageCount + 1`
<!-- calc:end -->

### เวทมนตร์: บลาส / เฮลอินเฟรูโน่ / อีเทอนอลบลิซซาร์ด / ฟอร์สเทมเพสต์ / เทิร์นกราวิตี้ / พันนิชเมนท์ / อีคลิปส์ (MagicBurst) · uid 109

<img src="../../icons/sk_109.png" width="40" alt="icon">

- ทรี: สกิลเวทมนตร์ (ขั้น 4) · เลเวลสูงสุด: 150 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: [N]เวทมนตร์:สตรอม[F]ไฟเออร์สตรอม[A]โฟรเซนไซโคลน[W]ธันเดอร์สตรอม[E]แซนด์สตรอม[L]ลักซ์วอร์เทคซ์[D]อีวิวเทมเพสต์[N] · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `MagicBurstAction` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่มพลังเวทมนตร์และยิงออกไป
> ทำให้คงกระพันเมื่อเปิดใช้สกิล
> มีโอกาสผลักกระเด็นมอนสเตอร์ยกเว้นบอส
> ยิ่งใช้สกิลเวทเวลาร่ายก็จะยิ่งสั้นลง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `abnormalPercent`: **10×Lv** → 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10) %
- สถานะที่ทำให้ติด: กระเด็น (KnockBack)
- บัพ `MagicBurstBuf`: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `innerCount` (ตัวนับที่เปลี่ยนตามเหตุการณ์); Next(): `innerCount` = `(innerCount hs 7 ? 8 : (innerCount + 1))`; NextSkip(): `innerCount` = `((innerCount + count) lt 8 ? (innerCount + count) : 8)`
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 8 ตามที่ `MagicBurstBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `MagicBurstAction.AddStack` — MagicBurstAction.AddStack: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new MagicBurstBuf, 0` เมื่อ (UnityEngine.Object.op_Equality(playerAction, 0) & 1) eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManage…; [call] `MagicBurstBuf$$UpdateMaxValue` = `((SkillBufferManager.TryGetBuf<MagicBurstBuf>(PlayerStatusBase.get_SkillBufferManager(), …` เมื่อ (UnityEngine.Object.op_Equality(playerAction, 0) & 1) eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManage…; [call] `MagicBurstBuf$$UpdateMaxValue` = `((SkillBufferManager.TryGetBuf<MagicBurstBuf>(PlayerStatusBase.get_SkillBufferManager(), …` เมื่อ (UnityEngine.Object.op_Equality(playerAction, 0) & 1) eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManage… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: *พลังจะเพิ่มมากกว่าค่า INT ของตัวเอง *เพิ่มเวลาคงกระพัน
- Lv15: *พลังจะเพิ่มมากกว่าค่า INT ของตัวเอง *ระยะโจมตีสูงสุดเพิ่มตามสกิลเลเวล  *ถ้ามีอุปกรณ์เวทมนตร์ (หลัก)จะเพิ่มเวลาคงกระพัน

<!-- calc:begin uid=109 -->
#### การคำนวณแบบตัวเลข — MagicBurst (uid 109)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **200 + 30×Lv** → 230, 260, 290, 320, 350, 380, 410, 440, 470, 500 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ไม้เท้า]: `(60 × Lv + baseINT + 1500) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseINT` = แต้ม INT ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseINT (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก อุปกรณ์เวท]: `(60 × Lv + baseINT ÷ 2 + 1500) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseINT` = แต้ม INT ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseINT; `baseINT` = แต้ม INT ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseINT; `baseINT` = แต้ม INT ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseINT (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท/ไม้เท้า)]: **(1500 + 60×Lv)%** → 1560%, 1620%, 1680%, 1740%, 1800%, 1860%, 1920%, 1980%, 2040%, 2100% (Lv1…10)
<!-- calc:end -->

### แม็กซ์ไมเซอร์ (Maximuyzer) · uid 110

<img src="../../icons/sk_110.png" width="40" alt="icon">

- ทรี: สกิลเวทมนตร์ (ขั้น 4) · เลเวลสูงสุด: 150 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: พาวเวอร์เวฟ
- คลาสในโค้ด: `MaximuyzerAction` · สถานะการแกะ: แกะครบจากโค้ด

> ฟื้นฟู MP จำนวนมากด้วยการเพิ่มพลังเวทมนตร์ชั่วขณะ
> เวลาร่ายจะเร็วขึ้นเมื่อเลเวลเพิ่มขึ้น
> ถ้าใช้ชาร์จ MP ก่อนสกิลนี้เวลาร่ายสูงสุดจะลดลง
> ตามสกิลเลเวลของชาร์จ MP เมื่อใช้ไม้เท้าหรืออุปกรณ์เวทมนตร์

**ทำงานยังไง (จากโค้ด):**
- บทบาท: แอ็กชันระบบ/อรรถประโยชน์
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- ตัวอ่านสกิลนี้ `ChargingAction.ActionSkillEvent` — ChargingAction.ActionSkillEvent: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Charging, Lv, Id` เมื่อ IsOtherPlayer eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (PlayerAttackBase.CheckSkillPara… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MindimageSenjuSupportAction.ActionSkillEvent` — MindimageSenjuSupportAction.ActionSkillEvent: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Charging, [baseSkill+0x14], Id` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillActionBase.op_Inequality(baseSkill, 0) & 1) ne 0 … (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: *ปริมาณฟื้นฟู MP +500
- Lv15: *ปริมาณฟื้นฟู MP +700

### สเปลทูนนิ่ง (SpellTurning) · uid 119

<img src="../../icons/sk_119.png" width="40" alt="icon">

- ทรี: สกิลเวทมนตร์ (ขั้น 4) · เลเวลสูงสุด: 150 · อาวุธ: ไม้เท้า, MainMagictool · ต้องเรียนก่อน: คาดาร์เอเล็คซิโอ
- ไม่มีคลาสของตัวเอง ผลอยู่ในโค้ดที่อ่านสกิลนี้ (`no action class; effect applied in consumer code (see page)`)

> ความรู้ในการปรับแต่งเวทมนตร์ตามความถนัด
> สามารถปรับแต่งสกิลเวทมนตร์บางอย่างได้ถึงเลเวล 3 ของสกิลทรี
> 
> *ไม่ส่งผลต่อเอนชานท์สเปล  

**ทำงานยังไง (จากโค้ด):**
- บทบาท: ไม่มีคลาสแอ็กชันฝั่ง client
- ตัวอ่านสกิลนี้ `ExSkillSpellTuning.get_IsEnable` — ค่า Is Enable ของ ExSkillSpellTuning: [call] `SkillUtil$$CheckSkillEquipLimit` = `PlayerStatusBase.get_EquipItemData(), MasterSkillDataManager.GetSkillMaster(Singleton<Mas…` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.SpellTurning, 1) ge 1 AND ExSkillSpellTuning.get_M… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ExSkillSpellTuning.get_MaxPoint` — ค่า Max Point ของ ExSkillSpellTuning: คืนค่า `0` (2 กรณี) (นิยามเต็มในแท็บ Variables)

### เวทมนตร์:เมจิกแคนนอน (MagicCannon) · uid 112

<img src="../../icons/sk_112.png" width="40" alt="icon">

- ทรี: สกิลเวทมนตร์ (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: [N]เวทมนตร์: บลาส[F]เฮลอินเฟรูโน่[A]อีเทอนอลบลิซซาร์ด[W]ฟอร์สเทมเพสต์[E]เทิร์นกราวิตี้[L]พันนิชเมนท์[D]อีคลิปส์[N]
- คลาสในโค้ด: `MagicCannonAction` · สถานะการแกะ: แกะครบจากโค้ด

> ปืนใหญ่เวทมตร์กวาดล้างศัตรูเป็นเส้นตรง(ชาร์จสกิล)
> ยิ่งชาร์จพลังและจำนวน HIT ก็จะยิ่งเพิ่มขึ้น
> การชาร์จจะเร็วขึ้นเมื่อใช้สกิลที่ต้องร่ายเวทมนตร์
> เมื่อชาร์จเกิน 100% โอกาสในการเจาะเกราะจะเพิ่มโอกาสในการเจาะ Guard

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- MP ที่ใช้ [อาวุธหลัก ไม้เท้า และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ≠ 0` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ≠ 0` หรือ อาวุธหลัก อุปกรณ์เวท และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ≠ 0` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ≠ 0` หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท/ไม้เท้า) และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ≠ 0` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ≠ 0`]: 700
- ดาเมจ: สร้าง template ดาเมจ 6 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `guardIgnorePercent` [`!PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)` และ `SkillBufferDataBase.GetParam(20) < 1` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ≠ 0` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ≠ 0` หรือ `!PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)` และ `((LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) : 5) ≥ 1` และ `SkillBufferDataBase.GetParam(20) ≥ 1` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ≠ 0` และ … หรือ `!PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)` และ `((LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) : 5) < 1` และ `SkillBufferDataBase.GetParam(20) ≥ 1` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ≠ 0` และ …]: `max(min(SkillBufferDataBase.GetParam(20) - 100, 100), 0)` %
- ตัวอ่านสกิลนี้ `MagicCannonAction.ActionStart` — MagicCannonAction: ตอนเริ่มทำงานของสกิล: [set] `<SkillIndividualFlag>k__BackingField` = `SkillBufferDataBase.GetParam(20)` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (PlayerAt…; [set] `fixAddDamage` = `((WeaponType eq 15 ? (SkillBufferDataBase.GetParam(20) + (SkillBufferDataBase.GetParam(20…` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (PlayerAt…; [set] `<LoopParam>k__BackingField` = `_t805` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (PlayerAt… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MagicCannonAction.OnInitialize` — MagicCannonAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `mp` = `700` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MagicCannon, out) & 1) ne 0 AND TryGet… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.GetSkillTargetType` — MobaPlayerActionManager.GetSkillTargetType: คืนค่า `MasterSkillDataManager.GetSkillMaster(Singleton<MasterSkillDataManager>.get_Instance(), SkillId.CloningTechnique).TargetType` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.GetSkillTargetType` — PlayerActionManager.GetSkillTargetType: คืนค่า `MasterSkillDataManager.GetSkillMaster(Singleton<MasterSkillDataManager>.get_Instance(), SkillId.CloningTechnique).TargetType` (11 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.MagicCannonCharge` — PlayerAttackBase.MagicCannonCharge (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerDataManager.OnAbnormalDamage` — PlayerDataManager.OnAbnormalDamage: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerDataManager.get_SkillBufferManager(this), SkillId.MagicCannon` เมื่อ response.AbnormalState eq 37 AND (SkillBufferManager.TryGetBuf(PlayerDataManager.get_SkillBufferManager(this), SkillId.… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SkillChargeAction.ReceiveSupport` — SkillChargeAction.ReceiveSupport: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.MagicCannon` เมื่อ response.Value ne 718 AND response.Value eq 112 AND returnCode ne 0; [call] `MagicCannonBuf$$Start` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MagicCannon)` เมื่อ response.Value ne 718 AND response.Value eq 112 AND returnCode eq 0 AND (SkillBufferManager.TryGetBuf(PlayerStatusBase.… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: *พลังเพิ่มขึ้นตาม INT
- Lv15: *เพิ่มโบนัสการชาร์จสำหรับพลังสกิล *เพิ่มระยะโจมตี

<!-- calc:begin uid=112 -->
#### การคำนวณแบบตัวเลข — MagicCannon (uid 112)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `ช่อง [0] ของอาร์เรย์ต่อฮิต`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ไม้เท้า และ `0 lo skillRate.Length` และ `target.GuardProbability ≤ 99` หรือ อาวุธหลัก ไม้เท้า และ `0 lo skillRate.Length` และ `target.GuardProbability > 99` · กิ่งที่ 1 ของ `baseSkillRate`]: `((baseINT + (((Lv + (Lv << 1))) * skillRate[0])) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseINT` = แต้ม INT ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseINT (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ไม้เท้า และ `0 lo skillRate.Length` และ `target.GuardProbability ≤ 99` หรือ อาวุธหลัก ไม้เท้า และ `0 lo skillRate.Length` และ `target.GuardProbability > 99` · กิ่งที่ 2 ของ `baseSkillRate`]: `((baseINT + ((lastUsedSkill.baseSkillRate) * skillRate[0])) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseINT` = แต้ม INT ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseINT (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ ไม้เท้า) และ `0 lo skillRate.Length` และ `target.GuardProbability ≤ 99` หรือ อาวุธหลักอื่น (ไม่ใช่ ไม้เท้า) และ `0 lo skillRate.Length` และ `target.GuardProbability > 99` · กิ่งที่ 1 ของ `baseSkillRate`]: `((((Lv + (Lv << 1))) * skillRate[0]) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ ไม้เท้า) และ `0 lo skillRate.Length` และ `target.GuardProbability ≤ 99` หรือ อาวุธหลักอื่น (ไม่ใช่ ไม้เท้า) และ `0 lo skillRate.Length` และ `target.GuardProbability > 99` · กิ่งที่ 2 ของ `baseSkillRate`]: `(((lastUsedSkill.baseSkillRate) * skillRate[0]) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**ฮิต 2: `calcPlayerToMobDamage` (ดาเมจหลัก) — `LoopParam ge 1`, `attackCount lt LoopParam`**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [อาวุธหลัก ไม้เท้า และ `0 lo skillRate.Length` และ `target.GuardProbability ≤ 99` หรือ อาวุธหลัก ไม้เท้า และ `0 lo skillRate.Length` และ `target.GuardProbability > 99` หรือ อาวุธหลักอื่น (ไม่ใช่ ไม้เท้า) และ `0 lo skillRate.Length` และ `target.GuardProbability ≤ 99` · กิ่งที่ 1 ของ `fixAddDamage` หรือ อาวุธหลัก ไม้เท้า และ `!PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)` และ `SkillBufferDataBase.GetParam(20) < 1` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ≠ 0` และ … หรือ อาวุธหลัก ไม้เท้า และ `!PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)` และ `SkillBufferDataBase.GetParam(20) < 1` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ≠ 0` และ … หรือ อาวุธหลักอื่น (ไม่ใช่ ไม้เท้า) และ `!PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)` และ `SkillBufferDataBase.GetParam(20) < 1` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ≠ 0` และ … หรือ อาวุธหลัก ไม้เท้า และ `!PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)` และ `((LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) : 5) ≥ 1` และ `SkillBufferDataBase.GetParam(20) ≥ 1` และ … หรือ …(เงื่อนไขเต็มดูใน details)]: **700** → 700, 700, 700, 700, 700, 700, 700, 700, 700, 700 (Lv1…10)

**ฮิต 3: `calcPlayerToMobDamage` (ดาเมจหลัก) — `ช่อง [1] ของอาร์เรย์ต่อฮิต`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ไม้เท้า และ `0 lo skillRate.Length` และ `1 lo skillRate.Length` และ `target.GuardProbability ≤ 99` หรือ อาวุธหลัก ไม้เท้า และ `0 lo skillRate.Length` และ `1 lo skillRate.Length` และ `target.GuardProbability > 99` · กิ่งที่ 1 ของ `baseSkillRate`]: `((baseINT + (((Lv + (Lv << 1))) * skillRate[1])) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseINT` = แต้ม INT ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseINT (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ไม้เท้า และ `0 lo skillRate.Length` และ `1 lo skillRate.Length` และ `target.GuardProbability ≤ 99` หรือ อาวุธหลัก ไม้เท้า และ `0 lo skillRate.Length` และ `1 lo skillRate.Length` และ `target.GuardProbability > 99` · กิ่งที่ 2 ของ `baseSkillRate`]: `((baseINT + ((lastUsedSkill.baseSkillRate) * skillRate[1])) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseINT` = แต้ม INT ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseINT (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ ไม้เท้า) และ `0 lo skillRate.Length` และ `1 lo skillRate.Length` และ `target.GuardProbability ≤ 99` หรือ อาวุธหลักอื่น (ไม่ใช่ ไม้เท้า) และ `0 lo skillRate.Length` และ `1 lo skillRate.Length` และ `target.GuardProbability > 99` · กิ่งที่ 1 ของ `baseSkillRate`]: `((((Lv + (Lv << 1))) * skillRate[1]) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ ไม้เท้า) และ `0 lo skillRate.Length` และ `1 lo skillRate.Length` และ `target.GuardProbability ≤ 99` หรือ อาวุธหลักอื่น (ไม่ใช่ ไม้เท้า) และ `0 lo skillRate.Length` และ `1 lo skillRate.Length` และ `target.GuardProbability > 99` · กิ่งที่ 2 ของ `baseSkillRate`]: `(((lastUsedSkill.baseSkillRate) * skillRate[1]) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**ฮิต 4: `calcPlayerToMobDamage` (ดาเมจหลัก) — `ช่อง [2] ของอาร์เรย์ต่อฮิต`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ไม้เท้า และ `0 lo skillRate.Length` และ `1 lo skillRate.Length` และ `2 lo skillRate.Length` และ … หรือ อาวุธหลัก ไม้เท้า และ `0 lo skillRate.Length` และ `1 lo skillRate.Length` และ `2 lo skillRate.Length` และ … · กิ่งที่ 1 ของ `baseSkillRate`]: `((baseINT + (((Lv + (Lv << 1))) * skillRate[2])) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseINT` = แต้ม INT ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseINT (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ไม้เท้า และ `0 lo skillRate.Length` และ `1 lo skillRate.Length` และ `2 lo skillRate.Length` และ … หรือ อาวุธหลัก ไม้เท้า และ `0 lo skillRate.Length` และ `1 lo skillRate.Length` และ `2 lo skillRate.Length` และ … · กิ่งที่ 2 ของ `baseSkillRate`]: `((baseINT + ((lastUsedSkill.baseSkillRate) * skillRate[2])) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseINT` = แต้ม INT ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseINT (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ ไม้เท้า) และ `0 lo skillRate.Length` และ `1 lo skillRate.Length` และ `2 lo skillRate.Length` และ … หรือ อาวุธหลักอื่น (ไม่ใช่ ไม้เท้า) และ `0 lo skillRate.Length` และ `1 lo skillRate.Length` และ `2 lo skillRate.Length` และ … · กิ่งที่ 1 ของ `baseSkillRate`]: `((((Lv + (Lv << 1))) * skillRate[2]) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ ไม้เท้า) และ `0 lo skillRate.Length` และ `1 lo skillRate.Length` และ `2 lo skillRate.Length` และ … หรือ อาวุธหลักอื่น (ไม่ใช่ ไม้เท้า) และ `0 lo skillRate.Length` และ `1 lo skillRate.Length` และ `2 lo skillRate.Length` และ … · กิ่งที่ 2 ของ `baseSkillRate`]: `(((lastUsedSkill.baseSkillRate) * skillRate[2]) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `OnInitialize`): 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 (Lv1…10)
- `LoopParam` (ตั้งใน `InitializeOthers`): `motionSpeed`
- `LoopParam` (ตั้งใน `ActionStart`) [`!PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)` และ `SkillBufferDataBase.GetParam(20) < 1` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ≠ 0` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ≠ 0` หรือ `!PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)` และ `((LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) : 5) ≥ 1` และ `SkillBufferDataBase.GetParam(20) ≥ 1` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ≠ 0` และ … หรือ `!PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)` และ `((LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) : 5) < 1` และ `SkillBufferDataBase.GetParam(20) ≥ 1` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ≠ 0` และ …]: `min(LoopParam + A - (SkillBufferDataBase.GetParam(20) - 20 × A = 0 ? 1 : 0), 5)` · `A = SkillBufferDataBase.GetParam(20) // 20`
- `LoopParam` (ตั้งใน `InitializeChronosShift`): `lastUsedSkill.LoopParam`
<!-- calc:end -->

### เวทมนตร์:แครช / เมเทโอเรน / เฮล / ฟลูกูไรต์ / ร็อคฟอล / เมเทโอไลท์ / คอสมอส (MagicFall) · uid 113

<img src="../../icons/sk_113.png" width="40" alt="icon">

- ทรี: สกิลเวทมนตร์ (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: [N]เวทมนตร์:สตรอม[F]ไฟเออร์สตรอม[A]โฟรเซนไซโคลน[W]ธันเดอร์สตรอม[E]แซนด์สตรอม[L]ลักซ์วอร์เทคซ์[D]อีวิวเทมเพสต์[N]
- คลาสในโค้ด: `MagicFallAction` · สถานะการแกะ: แกะครบจากโค้ด

> เวทที่ใช้เรียกอุกกาบาต 3 ก้อนเล็ก
> เมื่อโจมตีอุกกาบาตแต่ละก้อน
> อาจจะตกลงมาอีกไม่เกิน 2 ครั้งด้วยพลังที่ลดลง
> แต่จะแลกมาด้วยโอกาสคริติคอลตายตัวที่เพิ่มขึ้น
> และมีโอกาสสูงที่จะทำให้เกิด[ลดการป้องกัน]หรือ[ตาลาย]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: มึนงง (Dizzy), เกราะแตก (Breaking)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: *พลังเพิ่มขึ้นตาม INT *เพิ่มอัตราการติดสภาวะผิดปกติ *ระยะโจมตี(รัศมี)+0.5m
- Lv15: *เพิ่มอัตราการติดสภาวะผิดปกติอย่างมาก *ระยะโจมตี(รัศมี)+1.5m

<!-- calc:begin uid=113 -->
#### การคำนวณแบบตัวเลข — MagicFall (uid 113)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`((currentMeteorNumber - 1) // 3) lo criticalBonus.Length` และ `((currentMeteorNumber - 1) // 3) lo skillRate.Length` และ `gemCartLv ≥ 1` หรือ `((currentMeteorNumber - 1) // 3) lo criticalBonus.Length` และ `((currentMeteorNumber - 1) // 3) lo skillRate.Length` และ `gemCartLv < 1`]: **400** → 400, 400, 400, 400, 400, 400, 400, 400, 400, 400 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`(param - 101) > 98` และ `(param - 200) ≤ 99` และ `param = 200` และ `param ≠ 100` และ … หรือ `(param - 101) > 98` และ `(param - 200) ≤ 99` และ `param = 200` และ `param ≠ 100` และ …]: `(skillRate[((currentMeteorNumber - 1) // 3)] / 100)` — โดยที่ `currentMeteorNumber` = `currentMeteorNumber + 1` [`(param - 101) > 98` และ `(param - 200) ≤ 99` และ `param = 200` และ `param ≠ 100`] หรือ `(param & 65535) - 200 × (param & 65535) // 200` [`(param - 101) > 98` และ `(param - 200) ≤ 99` และ `param ≠ 100` และ `param ≠ 200`] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`(param - 101) > 98` และ `(param - 200) ≤ 99` และ `param ≠ 100` และ `param ≠ 200` และ … หรือ `(param - 101) > 98` และ `(param - 200) ≤ 99` และ `param ≠ 100` และ `param ≠ 200` และ …]: `(skillRate[(((((param & 0xffff) - (((param & 0xffff) // 200) * 200))) - 1) // 3)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`((currentMeteorNumber - 1) // 3) lo criticalBonus.Length` และ `((currentMeteorNumber - 1) // 3) lo skillRate.Length` และ `gemCartLv ≥ 1` หรือ `((currentMeteorNumber - 1) // 3) lo criticalBonus.Length` และ `((currentMeteorNumber - 1) // 3) lo skillRate.Length` และ `gemCartLv < 1`]: `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefMagic / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `localExpDefMagic` = proration ปัจจุบันของมอนในช่องเวท (%); `MobActionManagerBase.get_MobStatus` = ค่า Mob Status ของ MobActionManagerBase (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`((currentMeteorNumber - 1) // 3) lo criticalBonus.Length` และ `((currentMeteorNumber - 1) // 3) lo skillRate.Length` และ `gemCartLv ≥ 1` หรือ `((currentMeteorNumber - 1) // 3) lo criticalBonus.Length` และ `((currentMeteorNumber - 1) // 3) lo skillRate.Length` และ `gemCartLv < 1`]: `(targetExpList[mobAction] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `ActionStart`) [`GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv ≥ 1` และ `PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)` หรือ `!PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)` และ `GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv ≥ 1`]: `int(5 × max(MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)), 3))`
- `LoopParam` (ตั้งใน `ActionStart`) [`GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv < 1` และ `PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)` หรือ `!PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)` และ `GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv < 1`]: `int(10 × max(MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)), 3))`
<!-- calc:end -->

### โครนอสชิฟท์ (ChronosShift) · uid 114

<img src="../../icons/sk_114.png" width="40" alt="icon">

- ทรี: สกิลเวทมนตร์ (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: MainMagictool · ต้องเรียนก่อน: เวทมนตร์: ไฟนอล
- คลาสในโค้ด: `ChronosShiftAction` · สถานะการแกะ: แกะครบจากโค้ด

> วิชาต้องห้ามใช้ย้อนเวลาเพื่อกลับไปใช้เวทมนตร์
> จะทำให้ใช้สกิลเวทที่ใช้เป็นครั้งสุดท้ายได้ทันทีอีกครั้ง
> เมื่อใช้สกิลนี้แล้ว
> จะไม่สามารถใช้ได้อีกในช่วงระยะเวลาหนึ่ง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- MP ที่ใช้ [`SkillActionBase.op_Equality(saveSkill)` หรือ `!SkillActionBase.op_Equality(saveSkill)` และ `isCoolDown`]: 0
- MP ที่ใช้ [`!SkillActionBase.op_Equality(saveSkill)` และ ไม่ `isCoolDown`]: `SkillActionBase.get_Mp()`
- ประเภทดาเมจ: เวทเป็นค่าเริ่มต้น; ก๊อปประเภทจากสกิลล่าสุดที่เก็บไว้ — เงื่อนไข: Magic: default (ctor); copy: InitializeChronosShift: = saveSkill.AttackType when a skill is saved and not on cooldown
- Proration: ช่องที่เลือกตอนร่าย (กายภาพ/เวท) · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `ChronosShiftBuf` ระยะเวลา 0 วินาที
- ตัวอ่านสกิลนี้ `ChronosShiftAction.OnInitialize` — ChronosShiftAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `isCoolDown` = `[TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.ChronosShift)+0x28]` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.ChronosShift, out) & 1) ne 0 AND TryGe… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobAttackBase.CalcLastDamage` — คำนวณ last damage (MobAttackBase): คืนค่า `((SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.ArkSaber, out) & 1) eq 0 ? ((_t983 & 1) eq 0 ? ((_t982 & 1) eq 0 ? _t997 : _t…` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.GetSkillTargetType` — MobaPlayerActionManager.GetSkillTargetType: คืนค่า `MasterSkillDataManager.GetSkillMaster(Singleton<MasterSkillDataManager>.get_Instance(), SkillId.CloningTechnique).TargetType` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.GetSkillTargetType` — PlayerActionManager.GetSkillTargetType: คืนค่า `MasterSkillDataManager.GetSkillMaster(Singleton<MasterSkillDataManager>.get_Instance(), SkillId.CloningTechnique).TargetType` (11 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.<>c__DisplayClass118_0.<RegistChronosShift>b__0` — <>c__DisplayClass118_0.<RegistChronosShift>b__0: [set] `buf` = `new ChronosShiftBuf` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.ChronosShift, (this + 24)) & 1) eq 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.RegistChronosShift` — PlayerAttackBase.RegistChronosShift: [call] `SkillUtil$$CheckSkillEquipLimit` = `PlayerStatusBase.get_EquipItemData(), MasterSkillDataManager.GetSkillMaster(Singleton<Mas…` เมื่อ PlayerAttackBase.get_ActionID() ne 114 AND (+0x109 & 4) eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillMana…; [call] `ChronosShiftBuf$$StartCoolDown` = `new PlayerAttackBase.<>c__DisplayClass118_0.buf` เมื่อ PlayerAttackBase.get_ActionID() ne 114 AND (+0x109 & 4) eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillMana… (นิยามเต็มในแท็บ Variables)

### แรพพิดชาร์จ (RapidCharge) · uid 115

<img src="../../icons/sk_115.png" width="40" alt="icon">

- ทรี: สกิลเวทมนตร์ (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: ไม้เท้า, อุปกรณ์เวท · ต้องเรียนก่อน: แม็กซ์ไมเซอร์
- คลาสในโค้ด: `RapidCharge` · สถานะการแกะ: แกะครบจากโค้ด

> เร่งความเร็วในการชาร์จ MP ได้เล็กน้อย (สูงสุด Lv5)
> เมื่อใช่แม็กซ์ไมเซอร์ต่อจะเพิ่มประสิทธิภาพให้
> MATK และเวทเจาะเข้า(สูงสุด50%)
> *ตั้งแต่ Lv6 ขึ้นไปจะเป็นการขยายเวลาการบัฟเท่านั้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, พาสซีฟ
- บัพ `RapidChargeBuf` ระยะเวลา 40, 40, 40, 40, 40, 50, 60, 70, 80, 90 (Lv1…10) วินาที [`(buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52)) ≥ 51` หรือ `((heal // 50) + (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52))) ≥ 51` และ `(buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52)) < 51` หรือ `((heal // 50) + (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52))) < 51` และ `(buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52)) < 51`]: MATK + (`MatkUp`) = `5 × heal // 50 + 5 × buffParam(MagicResistBreaker) + 5 × BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52) + heal // 10 - 250` · เจาะเวท (`MagicResistBreaker`) = `max(50 - buffParam(MagicResistBreaker) - BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52), 0)`
- พาสซีฟ ค่าทั่วไป (`Value`): 2, 4, 6, 8, 10, 10, 10, 10, 10, 10 (Lv1…10)
- ตัวอ่านสกิลนี้ `ReceiveSupportResult.OnActionPlayerSupport` — ReceiveSupportResult.OnActionPlayerSupport: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerDataManager.get_SkillBufferManager(PlayerDataManager.GetPlayerDataManager()), Skill…` เมื่อ skillId le 709 AND skillId le 142 AND skillId gt 55 AND skillId le 110 AND (skillId & 0xffff) ne 101 AND (skillId & 0xf…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerDataManager.get_SkillBufferManager(PlayerDataManager.GetPlayerDataManager()), new R…` เมื่อ skillId le 709 AND skillId le 142 AND skillId gt 55 AND skillId le 110 AND (skillId & 0xffff) ne 101 AND (skillId & 0xf… (นิยามเต็มในแท็บ Variables)

### เอนชานท์บาเรีย (MagicProtection) · uid 116

<img src="../../icons/sk_116.png" width="40" alt="icon">

- ทรี: สกิลเวทมนตร์ (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: ไม้เท้า, MainMagictool · ต้องเรียนก่อน: แม็กซ์ไมเซอร์
- คลาสในโค้ด: `MagicProtectionAction` · สถานะการแกะ: แกะครบจากโค้ด

> วิชาป้องกันตัวเองด้วยการสร้างเขตอาคมส่วนตัว
> ภายในเขตอาคมจะรับความเสียหายที่เกิดขึ้นแทน
> นอกจากนี้ยังลบล้างผงะและลด MP เฮท
> หากฟื้นฟู MP ในเขตอาคม HP ของเขตอาคมจะถูกฟื้นฟูด้วย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, ทำให้ติดสถานะผิดปกติ
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- สถานะที่ทำให้ติด: None (None)
- บัพ `MagicProtectionBuf`: ความเร็วท่าทาง + (`MotionSpeed`) = 2, 5, 7, 10, 12, 15, 17, 20, 22, 25 (Lv1…10) · ตัวคูณดาเมจที่ได้รับจากมอน (หมวดเฉพาะ) (`MobLastDamageRateUnique`) = 25 + 5×Lv → 30, 35, 40, 45, 50, 55, 60, 65, 70, 75 (Lv1…10) · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `barrierHp` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `barrierHp` (ตัวนับที่เปลี่ยนตามเหตุการณ์)
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 100 ตามที่ `MagicProtectionBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `MaximuyzerAction.ActionStart` — MaximuyzerAction: ตอนเริ่มทำงานของสกิล: [set] `<CastTime>k__BackingField` = `0` เมื่อ (PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) & 1) eq 0 AND (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_Sk…; [set] `<SkillIndividualFlag>k__BackingField` = `(SkillIndividualFlag | 4)` เมื่อ (PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) & 1) eq 0 AND (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_Sk… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MaximuyzerSwitchingBuff.ConverterMaximuyzerSwitching` — MaximuyzerSwitchingBuff.ConverterMaximuyzerSwitching: คืนค่า `_t834` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobAttackBase.CalcLastDamage` — คำนวณ last damage (MobAttackBase): คืนค่า `((SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.ArkSaber, out) & 1) eq 0 ? ((_t983 & 1) eq 0 ? ((_t982 & 1) eq 0 ? _t997 : _t…` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerSecondaryStatus.GetMotionSpeed` — MobaPlayerSecondaryStatus.GetMotionSpeed: คืนค่า `(100 - _t518)` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.GetCalcMotionSpeed` — PlayerSecondaryStatus.GetCalcMotionSpeed: คืนค่า `_t1597` (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: [ได้รับผลแบบเดียวกันเมื่อใช้กับอุปกรณ์เวทมนตร์] *HP ของเขตอาคมจะเพิ่มขึ้นตามค่า INT และประสิทธิภาพอาวุธ *จะแปรผันตั้งแต่ 50-100% ขึ้นอยู่กับประเภทความเสียหาย *ความเสียหายที่ได้รับจะลดลงอย่างมากเมื่ออยู่ในเขตอาคม *ความเร็วการเคลื่อนที่จะเพิ่มขึ้นเมื่ออยู่ในเขตอาคม *เคาท์ของเวทมนตร์: บลาสจะเพิ่มขึ้นอย่างมากภายในเขตอาคม *เวลาร่ายเวทมนตร์: ไฟนอลจะสั้นลงเมื่ออยู่ในเขตอาคม

### เวทมนตร์:เรเซอร์ (MagicLazer) · uid 120

<img src="../../icons/sk_120.png" width="40" alt="icon">

- ทรี: สกิลเวทมนตร์ (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: ดาบมือเดียว, ไม้เท้า, MainMagictool · ต้องเรียนก่อน: เวทมนตร์: ไฟนอล
- คลาสในโค้ด: `MagicLazerAction` · สถานะการแกะ: แกะครบจากโค้ด

> สกิลที่ช่วยลดความซับซ้อนของเวทมนตร์
> ทำให้ผู้ใช้ปลดปล่อยพลังเวทย์ได้ตามทักษะที่มี
> เมื่อเปิดใช้พลังจะเพิ่มขึ้นตาม MP ที่เหลืออยู่
> มีโอกาสเล็กน้อยที่จะทำให้ติดภาวะผิดปกติตาม(ธาตุอาวุธ)
> และหลังเปิดใช้งานจะเพิ่มเวทเจาะเข้าของตัวเองเล็กน้อย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `abnormalRate` [อาวุธหลัก ไม้เท้า หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท/ดาบมือเดียว/ไม้เท้า)]: **2×Lv** → 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 (Lv1…10) %
- โอกาสติดสถานะ `abnormalRate` [อาวุธหลัก อุปกรณ์เวท]: **3×Lv** → 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 (Lv1…10) %
- โอกาสติดสถานะ `abnormalRate` [อาวุธหลัก ดาบมือเดียว]: **Lv** → 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10) %
- สถานะที่ทำให้ติด: หยุดนิ่ง (Stop)
- บัพ `MagicLazerBuf` ระยะเวลา 10 วินาที: เจาะเวท (`MagicResistBreaker`) = `isEquipRod & 1 ≠ 0 ? 15 : 10`
- ตัวอ่านสกิลนี้ `MagicLazerAction.ActionPreparation` — MagicLazerAction: ขั้นเตรียมก่อนปล่อยสกิล: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.MagicLazer` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (PlayerAttackBase.CheckSkillParamFlag(this, SkillParamF…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.MagicLazer` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (PlayerAttackBase.CheckSkillParamFlag(this, SkillParamF… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: *เวทเจาะเข้าเพิ่มขึ้นเล็กน้อย
- Lv15: *อัตราติดภาวะผิดปกติ 1.5 เท่า
- Lv10: *อัตราติดภาวะผิดปกติลดลงครึ่งหนึ่ง

<!-- calc:begin uid=120 -->
#### การคำนวณแบบตัวเลข — MagicLazer (uid 120)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ไม้เท้า]: `(75 × Lv + baseDEX ÷ 2 + MagicLazerAction.GetAddSkillRate(this)) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `MagicLazerAction.GetAddSkillRate` = MagicLazerAction.GetAddSkillRate (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบมือเดียว หรือ อาวุธหลัก อุปกรณ์เวท หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท/ดาบมือเดียว/ไม้เท้า)]: `(75 × Lv + MagicLazerAction.GetAddSkillRate(this)) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MagicLazerAction.GetAddSkillRate` = MagicLazerAction.GetAddSkillRate (ดูแท็บ Variables)
<!-- calc:end -->

