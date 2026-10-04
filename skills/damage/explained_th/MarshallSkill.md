# สกิลมาร์เชียล (`MarshallSkill`) — คำอธิบายทีละสกิล (ภาษาไทย)

สร้างอัตโนมัติด้วย `scripts/render_explained_th.py` จาก `skill_reference.json` (ข้อมูลโค้ด client ชุดล่าสุด) ไม่มีข้อความเขียนมือ แก้ไฟล์นี้ตรง ๆ จะถูกเขียนทับ ตัวเลขทั้งหมดคำนวณจากโค้ด (Code) ความหมายของชื่อ field/บทบาทแปลจากชื่อในโค้ด (Inferred) ยังไม่ได้เทียบกับตัวเลขในเกม ข้อมูลดิบทุกเส้นทางอยู่ใน `../details/MarshallSkill.md`

---

<!-- calc:preface -->
> **วิธีอ่านหัวข้อ "การคำนวณแบบตัวเลข"** (สร้างอัตโนมัติด้วย `scripts/render_calc_th.py` จาก `skill_reference.json` แก้มือจะถูกเขียนทับ)
> ดาเมจต่อฮิตเดินตามขั้น `SkillCalcTemplate/CalcStep` 0→40 ตามลำดับ (Code: `SkillCalcTemplate.GetDamage`) ขั้น `+` บวกเข้าดาเมจ ขั้น `×` คูณแล้วปัดเศษทิ้ง (int) ทันทีทุกขั้น
> ลำดับหลัก: ดาเมจฐาน(7) + คงที่สกิล(8) + คงที่บัพ(9) − ป้องกันเป้า(10) + ตีแรก(11) → ×คริ(13) → ×ธาตุ(15) → ×ตัวคูณสกิล(18) → ×ตีแรก(19) → ×เสถียร(21) → +คงที่ออโต้(22) → ×Proration(23) → ×ประเภท(24) → ×ดาเมจสุดท้าย(25) → … → เพดาน/ขั้นต่ำ(35–37)
> "ฮิต N" = template ดาเมจแต่ละก้อน (ทอยคริแยกกัน) แยกตามเมธอดและตัวแปรฮิตในโค้ด (`type`, `isFirst`, `attackCount` …) ชื่อฮิต/ส่วนมาจากชื่อในโค้ด (Inferred) ตัวเลขคำนวณจากโค้ด (Code) โดยตั้งเจม/บัพเสริม = 0
> ค่าหลายก้อนในขั้นเดียวกันแบบ "บวกเข้าช่อง" จะบวกกันก่อนคูณ ส่วน "ตั้งค่าทับ" แทนที่ค่าเดิม ค่าที่ขึ้นกับสเตตัสแสดงเป็นตัวอย่างที่ 100 / 255 (และ Lv สกิลอื่น 1 / 10) ใช้สูตรที่แนบไว้คำนวณค่าอื่นเอง
<!-- calc:preface-end -->

### สแมช (Smash) · uid 129

<img src="../../icons/sk_129.png" width="40" alt="icon">

- ทรี: สกิลมาร์เชียล (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `SmashAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีศัตรูอย่างเต็มแรง
> มีโอกาสทำให้เป้าหมาย[ผงะ]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `flinchPercent`: 75, 75, 75, 75, 75, 100, 100, 100, 100, 100 (Lv1…10) %
- โอกาสติดสถานะ `flinchPercent`: 50, 50, 50, 50, 50, 75, 75, 75, 75, 75 (Lv1…10) %
- สถานะที่ทำให้ติด: ผงะ (Flinch)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv16: *พลัง+50 *พลังสกิล+25 *อัตราติดผงะ+25%

<!-- calc:begin uid=129 -->
#### การคำนวณแบบตัวเลข — Smash (uid 129)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [กิ่งที่ 1 ของ `fixAddDamage` · AGI รวม=100]: **35 + 5×Lv** → 40, 45, 50, 55, 60, 65, 70, 75, 80, 85 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [กิ่งที่ 1 ของ `fixAddDamage` · AGI รวม=255]: **50 + 5×Lv** → 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [กิ่งที่ 2 ของ `fixAddDamage`]: **5×Lv** → 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate`]: **(100 + 5×Lv)%** → 105%, 110%, 115%, 120%, 125%, 130%, 135%, 140%, 145%, 150% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `skillRate`]: **(50 + 2×Lv)%** → 52%, 54%, 56%, 58%, 60%, 62%, 64%, 66%, 68%, 70% (Lv1…10)
<!-- calc:end -->

### บาช (Bash) · uid 130

<img src="../../icons/sk_130.png" width="40" alt="icon">

- ทรี: สกิลมาร์เชียล (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: สแมช · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `BashAction` · สถานะการแกะ: แกะครบจากโค้ด

> ยิงเข้าที่ศรีษะอย่างรุนแรง
> มีโอกาสทำให้เป้าหมาย[หมดสติ]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `stunPercent`: [AGI รวม=100] 60, 60, 60, 60, 60, 85, 85, 85, 85, 85 · [AGI รวม=255] 75, 75, 75, 75, 75, 100, 100, 100, 100, 100 (Lv1…10) %
- โอกาสติดสถานะ `stunPercent`: 25, 25, 25, 25, 25, 50, 50, 50, 50, 50 (Lv1…10) %
- สถานะที่ทำให้ติด: สตัน (Stun)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv16: *พลัง+50 *พลังสกิล+50 *อัตราติดหมดสติ+25%

<!-- calc:begin uid=130 -->
#### การคำนวณแบบตัวเลข — Bash (uid 130)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [กิ่งที่ 1 ของ `fixAddDamage` · AGI รวม=100]: **70 + 10×Lv** → 80, 90, 100, 110, 120, 130, 140, 150, 160, 170 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [กิ่งที่ 1 ของ `fixAddDamage` · AGI รวม=255]: **101 + 10×Lv** → 111, 121, 131, 141, 151, 161, 171, 181, 191, 201 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [กิ่งที่ 2 ของ `fixAddDamage`]: **10×Lv** → 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate` · AGI รวม=100]: **(220 + 5×Lv)%** → 225%, 230%, 235%, 240%, 245%, 250%, 255%, 260%, 265%, 270% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate` · AGI รวม=255]: **(251 + 5×Lv)%** → 256%, 261%, 266%, 271%, 276%, 281%, 286%, 291%, 296%, 301% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `skillRate`]: **(100 + 5×Lv)%** → 105%, 110%, 115%, 120%, 125%, 130%, 135%, 140%, 145%, 150% (Lv1…10)
<!-- calc:end -->

### โซนิคเวฟ (SonicWave) · uid 131

<img src="../../icons/sk_131.png" width="40" alt="icon">

- ทรี: สกิลมาร์เชียล (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: สแมช · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `SonicWaveAction` · สถานะการแกะ: แกะครบจากโค้ด

> ปล่อยคลื่นพลังโจมตี
> มีโอกาสทำให้เป้าหมาย[ล้มคว่ำ]
> จะโจมตีได้ไกลขึ้นตามเลเวลที่เพิ่มขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `tumblePercent`: **50 + 5×Lv** → 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 (Lv1…10) %
- โอกาสติดสถานะ `tumblePercent`: **5×Lv** → 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10) %
- สถานะที่ทำให้ติด: ล้มคว่ำ (Tumble)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv16: *พลัง+25 *พลังสกิล+25 *ระยะห่างที่สามารถใช้ได้+4m *อัตราติดล้มคว่ำ+50%

<!-- calc:begin uid=131 -->
#### การคำนวณแบบตัวเลข — SonicWave (uid 131)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [กิ่งที่ 1 ของ `fixAddDamage`]: **25 + 5×Lv** → 30, 35, 40, 45, 50, 55, 60, 65, 70, 75 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [กิ่งที่ 2 ของ `fixAddDamage`]: **5×Lv** → 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate`]: **(100 + 2.5×Lv)%** → 102.5%, 105%, 107.5%, 110%, 112.5%, 115%, 117.5%, 120%, 122.5%, 125% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `skillRate`]: **(75 + 2.5×Lv)%** → 77.5%, 80%, 82.5%, 85%, 87.5%, 90%, 92.5%, 95%, 97.5%, 100% (Lv1…10)
<!-- calc:end -->

### มาร์เชียลมาสเตอรี่ (MarshallMastary) · uid 132

<img src="../../icons/sk_132.png" width="40" alt="icon">

- ทรี: สกิลมาร์เชียล (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: MainKnuckle · ธง: StarGem
- คลาสในโค้ด: `MarshallMastary` · สถานะการแกะ: แกะครบจากโค้ด

> ใช้สนับมือได้ชำนาญขึ้น
> เพิ่มพลังโจมตีเมื่อใช้สนับมือ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ATK อาวุธ % (`EqAtkRate`): 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 (Lv1…10)
- พาสซีฟ ATK % (`AtkRate`): 1, 1, 1, 1, 1, 1, 2, 2, 2, 2 (Lv1…10)

### แอกราเวท (OneChance) · uid 133

<img src="../../icons/sk_133.png" width="40" alt="icon">

- ทรี: สกิลมาร์เชียล (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: สนับมือ, MainHand · ธง: StarGem
- คลาสในโค้ด: `OneChance` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีศัตรูซ้ำทันทีภายในพริบตา
> มีโอกาสสร้างความเสียหายให้ศัตรูเพิ่ม
> จากการโจมตีด้วยสนับมือปกติ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ โอกาสทำงาน % (`Trigger`): 14, 18, 22, 26, 30, 34, 38, 42, 46, 50 (Lv1…10)
- พาสซีฟ ตัวคูณสกิล (`SkillRate`): 27, 30, 32, 35, 37, 40, 42, 45, 47, 50 (Lv1…10)
- พาสซีฟ ค่าทั่วไป (`Value`): 0, 1, 1, 2, 2, 3, 3, 4, 4, 5 (Lv1…10)

### เชลเบรค (ShellBreak) · uid 134

<img src="../../icons/sk_134.png" width="40" alt="icon">

- ทรี: สกิลมาร์เชียล (ขั้น 2) · เลเวลสูงสุด: 30 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: บาช · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `ShellBreakAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีผ่านเกราะแข็งได้อย่างง่ายดาย
> เพิ่มความเสียหายตามพลังป้องกันของเป้าหมาย
> มีโอกาสเล็กน้อยที่จะทำให้เป้าหมายติดสภาวะ[ลดการป้องกัน]
> จะฟื้นฟู MP ได้เมื่อทำสำเร็จ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `breakPercent` [`EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) = 16` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1159) ≠ 0`]: `SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1159), 50) + gemCart(208, [2]) + int(1.5 × Lv) + 35` %
- โอกาสติดสถานะ `disDefParcent`: **5×Lv** → 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10) %
- โอกาสติดสถานะ `breakPercent` [`EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) = 16`]: 36, 38, 39, 41, 42, 44, 45, 47, 48, 50 (Lv1…10) %
- โอกาสติดสถานะ `breakPercent` [`EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) ≠ 16` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1159) ≠ 0`]: `SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1159), 50) + gemCart(208, [2]) + int(1.5 × Lv) + 10` %
- โอกาสติดสถานะ `breakPercent` [`EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) ≠ 16`]: 11, 13, 14, 16, 17, 19, 20, 22, 23, 25 (Lv1…10) %
- สถานะที่ทำให้ติด: เกราะแตก (Breaking)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv16: *พลัง+50 *พลังสกิล+150 *เพิ่มอาวุธเจาะเข้า  [เอฟเฟกต์ต่อไปนี้ใช้กับอุปกรณ์หลักเท่านั้น] *อัตราลดการป้องกัน+25%

<!-- calc:begin uid=134 -->
#### การคำนวณแบบตัวเลข — ShellBreak (uid 134)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `A > -101 ? min(A, 500) : -100` · `A = 2 × DEFของเป้า - 2 × target.Level` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.Level` = เลเวลมอนสเตอร์; `target.Level` = เลเวลมอนสเตอร์; `IMobStatusCalculator.CalcDef` = DEF มอนหลังคำนวณ; `MobActionManagerBase.get_MobBattleStatus` = ค่า Mob Battle Status ของ MobActionManagerBase (ดูแท็บ Variables)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [กิ่งที่ 1 ของ `fixAddDamage`]: **200 + 10×Lv** → 210, 220, 230, 240, 250, 260, 270, 280, 290, 300 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [กิ่งที่ 2 ของ `fixAddDamage`]: **50 + 10×Lv** → 60, 70, 80, 90, 100, 110, 120, 130, 140, 150 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `(A > -101 ? min(A, 500) : -100) / 100` · `A = 2 × DEFของเป้า - 2 × target.Level` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.Level` = เลเวลมอนสเตอร์; `target.Level` = เลเวลมอนสเตอร์; `IMobStatusCalculator.CalcDef` = DEF มอนหลังคำนวณ; `MobActionManagerBase.get_MobBattleStatus` = ค่า Mob Battle Status ของ MobActionManagerBase (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate`]: **(150 + 5×Lv)%** → 155%, 160%, 165%, 170%, 175%, 180%, 185%, 190%, 195%, 200% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `skillRate`]: **(100 + 5×Lv)%** → 105%, 110%, 115%, 120%, 125%, 130%, 135%, 140%, 145%, 150% (Lv1…10)
<!-- calc:end -->

### เอิร์ธไบด์ (EarthBind) · uid 135

<img src="../../icons/sk_135.png" width="40" alt="icon">

- ทรี: สกิลมาร์เชียล (ขั้น 2) · เลเวลสูงสุด: 30 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: โซนิคเวฟ · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `EarthBindAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีศัตรูโดยรอบด้วยการทำให้แผ่นดินสั่นสะเทือน
> มีโอกาสทำให้เป้าหมาย[หยุดนิ่ง]
> ฟื้นฟู HP เล็กน้อยเมื่อโจมตีโดนเป้าหมาย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `stopPercent`: **50 + 5×Lv** → 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 (Lv1…10) %
- โอกาสติดสถานะ `stopPercent`: **5×Lv** → 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10) %
- สถานะที่ทำให้ติด: หยุดนิ่ง (Stop)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv16: *พลัง+25 *พลังสกิล+25 *ระยะโจมตี (รัศมี)+1.5m *อัตราติดหยุดนิ่ง+50% ฟื้นฟูค่าสูงสุด HP+500 ด้วยเอิร์ธไบด์

<!-- calc:begin uid=135 -->
#### การคำนวณแบบตัวเลข — EarthBind (uid 135)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [กิ่งที่ 1 ของ `fixAddDamage`]: **25 + 5×Lv** → 30, 35, 40, 45, 50, 55, 60, 65, 70, 75 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [กิ่งที่ 2 ของ `fixAddDamage`]: **5×Lv** → 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate` · AGI รวม=100]: 147%, 150%, 152%, 155%, 157%, 160%, 162%, 165%, 167%, 170% (Lv1…10)
  - สูตร: `(int(2.5 × Lv) + AGIรวม // 5 + gemCart(209, [2]) + 125) / 100`
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate` · AGI รวม=255]: 178%, 181%, 183%, 186%, 188%, 191%, 193%, 196%, 198%, 201% (Lv1…10)
  - สูตร: `(int(2.5 × Lv) + AGIรวม // 5 + gemCart(209, [2]) + 125) / 100`
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `skillRate`]: 102%, 105%, 107%, 110%, 112%, 115%, 117%, 120%, 122%, 125% (Lv1…10)
  - สูตร: `(int(2.5 × Lv) + 100) / 100`
<!-- calc:end -->

### อัดกระแทก (StrongChase) · uid 136

<img src="../../icons/sk_136.png" width="40" alt="icon">

- ทรี: สกิลมาร์เชียล (ขั้น 2) · เลเวลสูงสุด: 30 · อาวุธ: สนับมือ, MainHand · ต้องเรียนก่อน: แอกราเวท
- คลาสในโค้ด: `StrongChase` · สถานะการแกะ: แกะครบจากโค้ด

> อัพเกรดพลังโจมตีของการโจมตีที่ไม่รุนแรง
> 
> เพิ่มความแม่นของตัวเอง
> และเพิ่มพลังโจมตีของ[แอกราเวท]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ตัวคูณสกิล (`SkillRate`): 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10)
- พาสซีฟ เจาะกายภาพ (`PowerResistBreaker`): 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10)
- พาสซีฟ ความแม่น % (`HitRate`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv16: [เอฟเฟกต์ต่อไปนี้ใช้กับอุปกรณ์หลักเท่านั้น] *เพิ่มความแม่นขึ้นไปอีก *ได้รับอาวุธเจาะเข้าตามระดับสกิลเลเวล เพื่อเพิ่มความเสียหายของแอกราเวท

### เฮวี่สแมช (HeavySmash) · uid 137

<img src="../../icons/sk_137.png" width="40" alt="icon">

- ทรี: สกิลมาร์เชียล (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: เชลเบรค · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `HeavySmashAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีศัตรูอย่างเต็มแรง
> มีโอกาสทำให้เป้าหมาย[เฉื่อยชา]
> ถ้าเป้าหมายอยู่ในสภาวะ[ลดการป้องกัน]
> จะได้รับความเสียหายเพิ่มขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 3 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `weakPercent`: **70 + 3×Lv** → 73, 76, 79, 82, 85, 88, 91, 94, 97, 100 (Lv1…10) %
- โอกาสติดสถานะ `weakPercent`: **20 + 3×Lv** → 23, 26, 29, 32, 35, 38, 41, 44, 47, 50 (Lv1…10) %
- สถานะที่ทำให้ติด: อ่อนแอ (Weak)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv16: *พลัง+150 พลังสกิล+100 ค่าความเสียหายเพิ่มเติม+500 *อัตราติดเฉื่อยชา+50%

<!-- calc:begin uid=137 -->
#### การคำนวณแบบตัวเลข — HeavySmash (uid 137)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [กิ่งที่ 1 ของ `fixAddDamage`]: **200 + 10×Lv** → 210, 220, 230, 240, 250, 260, 270, 280, 290, 300 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [กิ่งที่ 2 ของ `fixAddDamage`]: **100 + 10×Lv** → 110, 120, 130, 140, 150, 160, 170, 180, 190, 200 (Lv1…10)
- ดาเมจคงที่จากบัพ (`BufferConstantDamage`, +, ตั้งค่าทับ) [`AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10)`]: **0** → 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(100 + 15×Lv)%** → 115%, 130%, 145%, 160%, 175%, 190%, 205%, 220%, 235%, 250% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **150%** → 150%, 150%, 150%, 150%, 150%, 150%, 150%, 150%, 150%, 150% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **500%** → 500%, 500%, 500%, 500%, 500%, 500%, 500%, 500%, 500%, 500% (Lv1…10)
<!-- calc:end -->

### ทริปเปิ้ลคิก (TryArts) · uid 138

<img src="../../icons/sk_138.png" width="40" alt="icon">

- ทรี: สกิลมาร์เชียล (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: เอิร์ธไบด์ · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `TryArtsAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีเป้าหมายอย่างรวดเร็วสามครั้งซ้อน
> อัตราคริติคอลเพิ่มสูงกว่าปกติ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 6 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

**โน้ตในเกม (ข้อความจากเกม):**
- Lv16: *พลัง+300 *พลังสกิล+75 *เพิ่มอัตราคริติคอล

<!-- calc:begin uid=138 -->
#### การคำนวณแบบตัวเลข — TryArts (uid 138)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`0 lo criticalPercent.Length` และ `1 hs criticalPercent.Length` หรือ `0 lo criticalPercent.Length` และ `1 lo criticalPercent.Length` และ `2 lo criticalPercent.Length` หรือ `0 lo criticalPercent.Length` และ `1 lo criticalPercent.Length` และ `2 hs criticalPercent.Length`]: **25 + 2×Lv** → 27, 29, 31, 33, 35, 37, 39, 41, 43, 45 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก สนับมือ และ `0 lo criticalPercent.Length` และ `1 hs criticalPercent.Length` หรือ อาวุธหลัก สนับมือ และ `0 lo criticalPercent.Length` และ `1 lo criticalPercent.Length` และ `2 lo criticalPercent.Length` หรือ อาวุธหลัก สนับมือ และ `0 lo criticalPercent.Length` และ `1 lo criticalPercent.Length` และ `2 hs criticalPercent.Length` หรือ อาวุธหลักอื่น (ไม่ใช่ สนับมือ) และ อาวุธรอง สนับมือ และ `0 lo criticalPercent.Length` และ `1 hs criticalPercent.Length` หรือ …(เงื่อนไขเต็มดูใน details)]: **(200 + 10×Lv)%** → 210%, 220%, 230%, 240%, 250%, 260%, 270%, 280%, 290%, 300% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`0 lo criticalPercent.Length` และ `1 hs criticalPercent.Length` หรือ `0 lo criticalPercent.Length` และ `1 lo criticalPercent.Length` และ `2 lo criticalPercent.Length` หรือ `0 lo criticalPercent.Length` และ `1 lo criticalPercent.Length` และ `2 hs criticalPercent.Length` · กิ่งที่ 2 ของ `skillRate`]: **(100 + 10×Lv)%** → 110%, 120%, 130%, 140%, 150%, 160%, 170%, 180%, 190%, 200% (Lv1…10)
<!-- calc:end -->

### มาร์เชียลดิสซิพลิน (UnarmedTecnique) · uid 139

<img src="../../icons/sk_139.png" width="40" alt="icon">

- ทรี: สกิลมาร์เชียล (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: สนับมือ · ต้องเรียนก่อน: มาร์เชียลมาสเตอรี่
- คลาสในโค้ด: `UnarmedTecnique` · สถานะการแกะ: แกะครบจากโค้ด

> เข้าถึงแก่นวิธีการใช้สนับมืออย่างลึกซึ้ง
> เพิ่มความเร็วการโจมตีเมื่อใช้สนับมือ
> และมีโอกาสเพิ่มพลังโจมตีด้วยสกิลต่อสู้เพิ่มขึ้นเล็กน้อย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ความเร็วโจมตี + (`Aspd`): 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10)
- พาสซีฟ ความเร็วโจมตี % (`AspdRate`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
- พาสซีฟ ดาเมจสุดท้าย % (`LastDmgRate`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)

### สไลด์ดิ้ง (Sliding) · uid 143

<img src="../../icons/sk_143.png" width="40" alt="icon">

- ทรี: สกิลมาร์เชียล (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: MainKnuckle · ธง: NoMarketSearch
- คลาสในโค้ด: `SlidingAction` · สถานะการแกะ: แกะครบจากโค้ด

> ลดระยะห่างด้วยการสไลด์
> เข้าไปใกล้เป้าหมายด้วยความเร็วสูง
> จะเพิ่มอัตราความแม่นให้สกิลที่ใช้ถัดไป

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `SlidingBuf`: ความแม่น + (`HitUp`) = 1, 4, 9, 16, 25, 36, 49, 64, 81, 100 (Lv1…10)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.RemoveAfterSkillBuf` — PlayerAttackBase.RemoveAfterSkillBuf: [call] `SkillBufferManager$$RemoveBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Sliding` เมื่อ (PlayerAttackBase.ContainsNotApplicableSkill(PlayerAttackBase.get_ActionID()) & 1) eq 0 AND (SkillBufferManager.Contain… (นิยามเต็มในแท็บ Variables)

### เชอริออต (Chariot) · uid 140

<img src="../../icons/sk_140.png" width="40" alt="icon">

- ทรี: สกิลมาร์เชียล (ขั้น 4) · เลเวลสูงสุด: 150 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: เฮวี่สแมช · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `ChariotAction` · สถานะการแกะ: แกะครบจากโค้ด

> การยิงพลังที่กักเก็บอยู่ในตัวคาแรคเตอร์
> มีโอกาสทำให้เป้าหมาย[หวาดกลัว]ได้
> ใช้เวลาชาร์จน้อยลงตามสกิลเลเวล

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `abnormalPercent` [อาวุธหลัก สนับมือ]: **50 + 5×Lv** → 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 (Lv1…10) %
- โอกาสติดสถานะ `abnormalPercent` [อาวุธหลักอื่น (ไม่ใช่ สนับมือ) หรือ อาวุธหลัก สนับมือ]: **5×Lv** → 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10) %
- โอกาสติดสถานะ `abnormalPercent` [`IsInheritance = 0` และ `PlayerAttackBase.checkAbnormalPercent(this, 13, int((MobActionManagerBase.get_IsBoss(mobAction) ? (abnormalPercent * 0.5) : abnormalPercent)), playerAction)` หรือ `IsInheritance = 0` และ `PlayerAttackBase.checkAbnormalPercent(this, 13, int((!MobActionManagerBase.get_IsBoss(mobAction) ? (abnormalPercent * 0.5) : abnormalPercent)), playerAction)`]: `int(MobActionManagerBase.get_IsBoss(mobAction) ? 0.5 × abnormalPercent : abnormalPercent)` — โดยที่ `abnormalPercent` = `5 × Lv + 50` [อาวุธหลัก สนับมือ] หรือ `5 × Lv` [อาวุธหลักอื่น (ไม่ใช่ สนับมือ) หรือ อาวุธหลัก สนับมือ] หรือ `int(MobActionManagerBase.get_IsBoss(mobAction) ? 0.5 × abnormalPercent : abnormalPercent)` [`IsInheritance = 0` และ `PlayerAttackBase.checkAbnormalPercent(this, 13, int((MobActionManagerBase.get_IsBoss(mobAction) ? (abnormalPercent * 0.5) : abnormalPercent)), playerAction)` หรือ `IsInheritance = 0` และ `PlayerAttackBase.checkAbnormalPercent(this, 13, int((!MobActionManagerBase.get_IsBoss(mobAction) ? (abnormalPercent * 0.5) : abnormalPercent)), playerAction)`] %
- สถานะที่ทำให้ติด: หวาดกลัว (Fear)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv16: *พลัง +250 *พลังเพิ่มขึ้นตาม AGI *พลังสกิล +250 เวลาชาร์จ -1 วินาที *อัตราติดหวาดกลัว +50% *เปลี่ยนเป็นพื้นที่โจมตี

<!-- calc:begin uid=140 -->
#### การคำนวณแบบตัวเลข — Chariot (uid 140)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [อาวุธหลัก สนับมือ และ `IsInheritance = 0`]: **300 + 20×Lv** → 320, 340, 360, 380, 400, 420, 440, 460, 480, 500 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [อาวุธหลักอื่น (ไม่ใช่ สนับมือ) และ `IsInheritance = 0` หรือ อาวุธหลัก สนับมือ และ `IsInheritance = 0`]: **50 + 20×Lv** → 70, 90, 110, 130, 150, 170, 190, 210, 230, 250 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก สนับมือ และ `IsInheritance = 0`]: `min(Lv + baseAGI + 1240, 1760) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseAGI` = แต้ม AGI ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseAGI (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ สนับมือ) และ `IsInheritance = 0` หรือ อาวุธหลัก สนับมือ และ `IsInheritance = 0`]: **(990 + Lv)%** → 991%, 992%, 993%, 994%, 995%, 996%, 997%, 998%, 999%, 1000% (Lv1…10)
<!-- calc:end -->

### รัช (Rush) · uid 141

<img src="../../icons/sk_141.png" width="40" alt="icon">

- ทรี: สกิลมาร์เชียล (ขั้น 4) · เลเวลสูงสุด: 150 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ทริปเปิ้ลคิก · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `RushAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีต่อเนื่องอย่างรวดเร็ว
> ความเร็วการเคลื่อนที่เพิ่มขึ้นชั่วขณะ
> รวมถึงการใช้รัช

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `RushBuf` ระยะเวลา 10 วินาที: ความเร็วท่าทาง + (`MotionSpeed`) = `int(0.3 × Lv) + 2 << (isKnuckle & 1)`

**โน้ตในเกม (ข้อความจากเกม):**
- LvNone: *พลังสกิล  +250 *พลังเพิ่มขึ้นตาม AGI *เพิ่มปริมาณการเพิ่มความเร็วการเคลื่อนที่ของผลบัฟ

<!-- calc:begin uid=141 -->
#### การคำนวณแบบตัวเลข — Rush (uid 141)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [กิ่งที่ 1 ของ `fixAddDamage`]: **200 + 20×Lv** → 220, 240, 260, 280, 300, 320, 340, 360, 380, 400 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [อาวุธหลักอื่น (ไม่ใช่ สนับมือ)]: **20×Lv** → 20, 40, 60, 80, 100, 120, 140, 160, 180, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate`]: `min(40 × Lv + 2 × baseAGI + 500, 1920) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseAGI` = แต้ม AGI ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseAGI (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ สนับมือ)]: **(300 + 40×Lv)%** → 340%, 380%, 420%, 460%, 500%, 540%, 580%, 620%, 660%, 700% (Lv1…10)
<!-- calc:end -->

### จักรา (Chakra) · uid 142

<img src="../../icons/sk_142.png" width="40" alt="icon">

- ทรี: สกิลมาร์เชียล (ขั้น 4) · เลเวลสูงสุด: 150 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: มาร์เชียลดิสซิพลิน · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `ChakraAction` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่มบัฟเพื่อลดความเสียหายที่ได้รับครั้งถัดไป
> ฟื้นฟู MP เล็กน้อยชั่วขณะ
> เพิ่มการฟื้นฟู MP โจมตีเล็กน้อยระหว่างแสดงผล
> และมีผลต่อสมาชิกในปาร์ตี้ด้วยเช่นกัน

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- ตัวอ่านสกิลนี้ `KakeiAction.Damaged` — KakeiAction: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Chakra` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.KakeiDeffence, out) & 1) ne 0 AND (Ski…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new ChakraBuf, 0` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.KakeiDeffence, out) & 1) ne 0 AND (Ski… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv16: *ปริมาณฟื้นฟู MP +50 เพิ่มพลังการลดความเสียหาย *ระยะเวลาแสดงผล +10 วินาที

### แอบสแตรกต์อาร์ม (MindimageSenju) · uid 144

<img src="../../icons/sk_144.png" width="40" alt="icon">

- ทรี: สกิลมาร์เชียล (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: สนับมือ · ต้องเรียนก่อน: เชอริออต
- คลาสในโค้ด: `MindimageSenju` · สถานะการแกะ: แกะครบจากโค้ด

> สามารถใช้งาน Avoid แบบ(แมนนวลเท่านั้น)
> ในระหว่างใช้สกิลต่อสู้บางอย่าง
> เมื่อใช้งานไปครั้งหนึ่งแล้วต้องรอสักพักจึงจะใช้งานได้อีก
> ไม่สามารถใช้งานได้กับบางสกิลทีมีการเคลื่อนไหวเป็นพิเศษ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- ตัวอ่านสกิลนี้ `AvoidActionManager.CheckMindimageSenju` — ตรวจ mindimage senju (AvoidActionManager): [call] `SkillUtil$$CheckSkillEquipLimit` = `PlayerStatusBase.get_EquipItemData(), MasterSkillDataManager.GetSkillMaster(Singleton<Mas…` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.MindimageSenju) & 1) eq 0 AND Ski…; [call] `PlayerAttackBase$$CheckSkillParamFlag` = `SkillActionManagerBase.get_CurrentSkill(), 0x2000` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.MindimageSenju) & 1) eq 0 AND Ski…; [call] `PlayerAttackBase$$CheckSkillParamFlag` = `SkillActionManagerBase.get_CurrentSkill(), 0x2000` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.MindimageSenju) & 1) eq 0 AND Ski… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MindimageSenjuAttackAction.<>c__DisplayClass82_0.<ActionStart>b__0` — <>c__DisplayClass82_0.<ActionStart>b__0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MindimageSenjuSkillBase.CheckInheritance` — ตรวจ inheritance (MindimageSenjuSkillBase): คืนค่า `0` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MindimageSenjuSupportAction.<>c__DisplayClass57_0.<ActionStart>b__0` — <>c__DisplayClass57_0.<ActionStart>b__0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerBattleManager.StartMindimageSenju` — MobaPlayerBattleManager.StartMindimageSenju: [call] `SkillFactory$$CreateSkill` = `158` เมื่อ (UnityEngine.Object.op_Equality(playerAction, 0) & 1) eq 0 AND (UnityEngine.Object.op_Equality(PlayerStatusBase.get_Ski…; [call] `MindimageSenjuSkillBase$$SetBaseSkill` = `SkillFactory.CreateSkill(SkillId.MindimageSenjuSupport), baseSkill` เมื่อ (UnityEngine.Object.op_Equality(playerAction, 0) & 1) eq 0 AND (UnityEngine.Object.op_Equality(PlayerStatusBase.get_Ski…; [call] `SkillActionBase$$SetMainTarget` = `SkillFactory.CreateSkill(SkillId.MindimageSenjuSupport), playerAction` เมื่อ (UnityEngine.Object.op_Equality(playerAction, 0) & 1) eq 0 AND (UnityEngine.Object.op_Equality(PlayerStatusBase.get_Ski… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.StartMindimageSenju` — PlayerBattleManager.StartMindimageSenju: [call] `SkillFactory$$CreateSkill` = `158` เมื่อ (UnityEngine.Object.op_Equality(playerAction, 0) & 1) eq 0 AND (UnityEngine.Object.op_Equality(PlayerStatusBase.get_Ski…; [call] `MindimageSenjuSkillBase$$SetBaseSkill` = `SkillFactory.CreateSkill(SkillId.MindimageSenjuSupport), baseSkill` เมื่อ (UnityEngine.Object.op_Equality(playerAction, 0) & 1) eq 0 AND (UnityEngine.Object.op_Equality(PlayerStatusBase.get_Ski…; [call] `SkillActionBase$$SetMainTarget` = `SkillFactory.CreateSkill(SkillId.MindimageSenjuSupport), playerAction` เมื่อ (UnityEngine.Object.op_Equality(playerAction, 0) & 1) eq 0 AND (UnityEngine.Object.op_Equality(PlayerStatusBase.get_Ski… (นิยามเต็มในแท็บ Variables)

### อาชูร่าออร่า (AshuraAura) · uid 145

<img src="../../icons/sk_145.png" width="40" alt="icon">

- ทรี: สกิลมาร์เชียล (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: สนับมือ · ต้องเรียนก่อน: รัช
- คลาสในโค้ด: `AshuraAuraAction` · สถานะการแกะ: แกะครบจากโค้ด

> ปลดปล่อยพลังเทพมารที่ซ่อนเร้นอยู่ภายใน
> ขณะใช้งาน ATK จะเพิ่มขึ้นและลดความเสียหายด้วยการใช้ MP
> แต่ในทางกลับกันจะสูญเสียการฟื้นฟู MP การโจมตี
> และ MP ที่ใช้จะเพิ่มขึ้นทั้งหมด
> ยกเว้นมาร์เชียลกับครัชเชอร์

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, เปลี่ยนรูปแบบการโจมตี (อนุมานจาก hook ของบัพ), เพิ่มดาเมจตีปกติ
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `AshuraAuraBuf`: ดาเมจคงที่สกิล (`SkillConstantDamage`) = 20×Lv → 20, 40, 60, 80, 100, 120, 140, 160, 180, 200 (Lv1…10) · ดาเมจคงที่ตีปกติ (`NormalAttackConstantDamage`) = 20×Lv → 20, 40, 60, 80, 100, 120, 140, 160, 180, 200 (Lv1…10) · อัตราคริ + (`CrtUp`) = 6, 15, 21, 30, 36, 45, 51, 60, 66, 75 (Lv1…10) · ดาเมจสุดท้ายที่ทำ % (`LastDmgUpRate`) = 10
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 40 ตามที่ `AshuraAuraBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `AshuraAuraAction.ActionSkillEvent` — AshuraAuraAction.ActionSkillEvent: [call] `SkillBufferManager$$RemoveBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.AshuraAura` เมื่อ param eq 100 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBufferManager.TryGetBuf(PlayerSt…; [call] `AbnormalStateManager$$RemoveSkillMotionInvincibility` = `PlayerActionManagerBase.get_AbnormalStatusManager(), SkillId.AshuraAura` เมื่อ param eq 100 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBufferManager.TryGetBuf(PlayerSt…; [call] `SkillBufferManager$$RemoveBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.AshuraAura` เมื่อ param eq 100 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `AshuraAuraAction.ActionStart` — AshuraAuraAction: ตอนเริ่มทำงานของสกิล: [set] `<SkillIndividualFlag>k__BackingField` = `([TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.AshuraAura)+0x28] eq 0…` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBuf…; [set] `<CurrentTake>k__BackingField` = `new SkillLinkedTake` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBuf…; [set] `<SkillIndividualFlag>k__BackingField` = `0` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBuf… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `AshuraAuraAction.Damaged` — AshuraAuraAction: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `AshuraAuraBuf$$PayMp` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.AshuraAura), 100` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.AshuraAura, out) & 1) ne 0 AND PlayerS… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `AshuraAuraAttackAction.OnInitialize` — AshuraAuraAttackAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `<CurrentTake>k__BackingField` = `new SkillLinkedTake` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.AshuraAura, out) & 1) ne 0 AND TryGetB…; [set] `<ActionRange>k__BackingField` = `-1` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.AshuraAura, out) & 1) ne 0 AND TryGetB… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `AvoidActionManager.InvalidAshuraAuraAttack` — AvoidActionManager.InvalidAshuraAuraAttack (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ChariotAction.OnInitialize` — ChariotAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `<SkillIndividualFlag>k__BackingField` = `1` เมื่อ (PlayerAttackBase.ExistWeaponType(actarAction, ItemType.Knuckle) & 1) ne 0 AND (SkillBufferManager.TryGetBuf(PlayerStat…; [set] `<SkillIndividualFlag>k__BackingField` = `1` เมื่อ (PlayerAttackBase.ExistWeaponType(actarAction, ItemType.Knuckle) & 1) eq 0 AND (SkillBufferManager.TryGetBuf(PlayerStat… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GuardActionManager.<StartManualGuard>d__91.MoveNext` — <StartManualGuard>d__91.MoveNext: คืนค่า `1` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GuardActionManager.CheckGuard` — ตรวจ guard (GuardActionManager): คืนค่า `((GuardActionManager.get_GuardType(this) eq 2) || (GuardActionManager.get_GuardType(this) ne 2) ? 0 : _t375)` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.ReceiveDamaged` — MobaPlayerActionManager.ReceiveDamaged (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerBattleManager.CheckAshuraAuraAttackStart` — ตรวจ ashura aura attack start (MobaPlayerBattleManager): คืนค่า `1` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerBattleManager.CheckAshuraAuraAttackStop` — ตรวจ ashura aura attack stop (MobaPlayerBattleManager): คืนค่า `((SkillUtil.CheckPursuitAttack(action) & 1) eq 0 && SkillActionBase.get_ActionID() eq 0 ? SkillActionBase.get_ActionID() : _t1119)` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerBattleManager.OnSkillActionStart` — MobaPlayerBattleManager.OnSkillActionStart: [call] `AshuraAuraBuf$$StartSkill` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.AshuraAura), action` เมื่อ (UnityEngine.Object.op_Implicit(target) & 1) ne 0 AND SkillActionBase.get_ActionID() ne 1218 AND SkillActionBase.get_Ac…; [call] `AshuraAuraBuf$$StartSkill` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.AshuraAura), action` เมื่อ (UnityEngine.Object.op_Implicit(target) & 1) ne 0 AND SkillActionBase.get_ActionID() ne 1218 AND SkillActionBase.get_Ac…; [call] `AshuraAuraBuf$$StartSkill` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.AshuraAura), action` เมื่อ (UnityEngine.Object.op_Implicit(target) & 1) ne 0 AND SkillActionBase.get_ActionID() ne 1218 AND SkillActionBase.get_Ac… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerBattleManager.OnSkillActionStartSummonSkeleton` — MobaPlayerBattleManager.OnSkillActionStartSummonSkeleton: [call] `AshuraAuraBuf$$StartSkill` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.AshuraAura), action` เมื่อ (PlayerStatusBase.PaySkillMp(MobaPlayerActionManager.get_PlayerStatus(), SkillActionBase.get_Mp()) & 1) ne 0 AND (Skill…; [call] `AshuraAuraBuf$$StartSkill` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.AshuraAura), action` เมื่อ (PlayerStatusBase.PaySkillMp(MobaPlayerActionManager.get_PlayerStatus(), SkillActionBase.get_Mp()) & 1) eq 0 AND (Skill… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerBattleManager.StartAshuraAuraAttack` — MobaPlayerBattleManager.StartAshuraAuraAttack: [call] `SkillFactory$$CreateSkill` = `SkillId.AshuraAuraAttack` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.AshuraAura, 1) ge 1 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerSecondaryStatus.GetCrtConstant` — MobaPlayerSecondaryStatus.GetCrtConstant: คืนค่า `_t1164` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerSecondaryStatus.get_AntiVirus` — ค่า Anti Virus ของ MobaPlayerSecondaryStatus: คืนค่า `(_t526 lt 100 ? _t526 : 100)` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.Damaged` — PlayerActionManager: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `AshuraAuraBuf$$PayMp` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.AshuraAura), 100` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND (SkillBufferManager.TryGetBuf(PlayerS… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.CalcCostMp` — MP ที่ใช้ของสกิล: [call] `AshuraAuraBuf$$CheckMpIncrease` = `this` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.AshuraAura, out) & 1) ne 0; [set] `<CostMpType>k__BackingField` = `(((AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), AbnormalTy…` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.AshuraAura, out) & 1) ne 0 AND (Ashura…; [call] `AshuraAuraBuf$$CheckMpIncrease` = `this` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.CheckAshuraAuraAttackStart` — ตรวจ ashura aura attack start (PlayerBattleManager): คืนค่า `1` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.CheckAshuraAuraAttackStop` — ตรวจ ashura aura attack stop (PlayerBattleManager): คืนค่า `((PlayerBattleManager.IsPersuitAction(this, action) & 1) eq 0 && SkillActionBase.get_ActionID() eq 0 ? SkillActionBase.get_ActionID() : _t1543)` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.OnSkillActionStart` — PlayerBattleManager.OnSkillActionStart: [call] `AshuraAuraBuf$$StartSkill` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.AshuraAura), action` เมื่อ (UnityEngine.Object.op_Implicit(target) & 1) ne 0 AND SkillActionBase.get_ActionID() ne 1218 AND SkillActionBase.get_Ac… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.OnSkillActionStartSummonSkeleton` — PlayerBattleManager.OnSkillActionStartSummonSkeleton: [call] `AshuraAuraBuf$$StartSkill` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.AshuraAura), action` เมื่อ (PlayerBattleManager.ActionStartSkillMpLess(this, action, out) & 1) eq 0 AND (SkillBufferManager.TryGetBuf(PlayerStatus… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.StartAshuraAuraAttack` — PlayerBattleManager.StartAshuraAuraAttack: [call] `SkillFactory$$CreateSkill` = `SkillId.AshuraAuraAttack` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.AshuraAura, 1) ge 1 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.CalcAntiVirus` — คำนวณ anti virus (PlayerSecondaryStatus): คืนค่า `_t1560` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.GetCrtConstant` — PlayerSecondaryStatus.GetCrtConstant: คืนค่า `_t1629` (นิยามเต็มในแท็บ Variables)

### เฟลชบลิงค์ (FlashArts) · uid 146

<img src="../../icons/sk_146.png" width="40" alt="icon">

- ทรี: สกิลมาร์เชียล (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: สนับมือ · ต้องเรียนก่อน: ทริปเปิ้ลคิก
- คลาสในโค้ด: `FlashArtsAction` · สถานะการแกะ: แกะครบจากโค้ด

> ส่งจินตภาพออกไปเพื่อโจมตี
> สกิลนี้โจมตีด้วย 'ความเคยชินทั่วไป'
> จำนวน HIT จะเพิ่มตามจำนวน Avoid ที่สะสม
> 
> พลังของการโจมตีระยะใกล้ในครั้งถัดไปจะเพิ่มขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, บัพปาร์ตี้/ผู้อื่น
- ดาเมจ: สร้าง template ดาเมจ 6 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: ธรรมดา (SkillNormal)
- Proration: ช่องตีปกติ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `FlashArtsBuf`: ดาเมจระยะใกล้ % (`ShortRangeRate`) = Lv → 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10) · ตัวนับ/stack (`Count`) = `Count`
- บัพ `NextAttackBufferBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่

<!-- calc:begin uid=146 -->
#### การคำนวณแบบตัวเลข — FlashArts (uid 146)
Proration: ช่อง `Normal` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`1 ≥ maxAttackCount` และ `maxAttackCount ≥ 1` หรือ `1 < maxAttackCount` และ `2 ≥ maxAttackCount` และ `maxAttackCount ≥ 1` หรือ `1 < maxAttackCount` และ `2 < maxAttackCount` และ `3 ≥ maxAttackCount` และ `maxAttackCount ≥ 1`]: **100** → 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก สนับมือ และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) = 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1` และ `1 ≥ maxAttackCount` และ … หรือ อาวุธหลัก สนับมือ และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) = 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1` และ `1 < maxAttackCount` และ … หรือ อาวุธหลัก สนับมือ และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) = 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1` และ `1 < maxAttackCount` และ … หรือ อาวุธหลักอื่น (ไม่ใช่ สนับมือ) และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) = 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1` และ `1 ≥ maxAttackCount` และ … หรือ …(เงื่อนไขเต็มดูใน details)]: `(30 × Lv + baseAGI ÷ 4 + 300) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseAGI` = แต้ม AGI ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseAGI; `baseAGI` = แต้ม AGI ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseAGI; `baseAGI` = แต้ม AGI ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseAGI (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก สนับมือ และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) = 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1` และ `1 < maxAttackCount` และ … หรือ อาวุธหลัก สนับมือ และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) = 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1` และ `1 < maxAttackCount` และ … หรือ อาวุธหลัก สนับมือ และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) = 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1` และ `1 < maxAttackCount` และ … หรือ อาวุธหลักอื่น (ไม่ใช่ สนับมือ) และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) = 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1` และ `1 < maxAttackCount` และ … หรือ …(เงื่อนไขเต็มดูใน details)]: `(15 × Lv + 0.5 × (baseAGI ÷ 4) + 150) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseAGI` = แต้ม AGI ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseAGI; `baseAGI` = แต้ม AGI ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseAGI; `baseAGI` = แต้ม AGI ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseAGI (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก สนับมือ และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) = 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1` และ `1 < maxAttackCount` และ … หรือ อาวุธหลัก สนับมือ และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) = 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1` และ `1 < maxAttackCount` และ … หรือ อาวุธหลักอื่น (ไม่ใช่ สนับมือ) และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) = 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1` และ `1 < maxAttackCount` และ … หรือ อาวุธหลักอื่น (ไม่ใช่ สนับมือ) และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) = 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1` และ `1 < maxAttackCount` และ … หรือ …(เงื่อนไขเต็มดูใน details)]: `(7.5 × Lv + 0.25 × (baseAGI ÷ 4) + 75) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseAGI` = แต้ม AGI ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseAGI; `baseAGI` = แต้ม AGI ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseAGI; `baseAGI` = แต้ม AGI ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseAGI (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก สนับมือ และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) ≠ 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1` และ `1 ≥ maxAttackCount` และ … หรือ อาวุธหลัก สนับมือ และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) ≠ 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1` และ `1 < maxAttackCount` และ … หรือ อาวุธหลัก สนับมือ และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) ≠ 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1` และ `1 < maxAttackCount` และ … หรือ อาวุธหลักอื่น (ไม่ใช่ สนับมือ) และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) ≠ 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1` และ `1 ≥ maxAttackCount` และ … หรือ …(เงื่อนไขเต็มดูใน details)]: **(300 + 30×Lv)%** → 330%, 360%, 390%, 420%, 450%, 480%, 510%, 540%, 570%, 600% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก สนับมือ และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) ≠ 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1` และ `1 < maxAttackCount` และ … หรือ อาวุธหลัก สนับมือ และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) ≠ 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1` และ `1 < maxAttackCount` และ … หรือ อาวุธหลัก สนับมือ และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) ≠ 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1` และ `1 < maxAttackCount` และ … หรือ อาวุธหลักอื่น (ไม่ใช่ สนับมือ) และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) ≠ 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1` และ `1 < maxAttackCount` และ … หรือ …(เงื่อนไขเต็มดูใน details)]: **(150 + 15×Lv)%** → 165%, 180%, 195%, 210%, 225%, 240%, 255%, 270%, 285%, 300% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก สนับมือ และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) ≠ 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1` และ `1 < maxAttackCount` และ … หรือ อาวุธหลัก สนับมือ และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) ≠ 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1` และ `1 < maxAttackCount` และ … หรือ อาวุธหลักอื่น (ไม่ใช่ สนับมือ) และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) ≠ 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1` และ `1 < maxAttackCount` และ … หรือ อาวุธหลักอื่น (ไม่ใช่ สนับมือ) และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) ≠ 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1` และ `1 < maxAttackCount` และ … หรือ …(เงื่อนไขเต็มดูใน details)]: **(75 + 7.5×Lv)%** → 82.5%, 90%, 97.5%, 105%, 112.5%, 120%, 127.5%, 135%, 142.5%, 150% (Lv1…10)

**จำนวนฮิต / ตัวนับ**
- `maxAttackCount` (ตั้งใน `OnInitialize`) [อาวุธหลัก สนับมือ และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) = 16` และ `IsInstanceOf(actarAction, MobaPlayerActionManager) = 1` และ `IsInstanceOf(actarAction, PlayerActionManager) ≠ 1` หรือ อาวุธหลัก สนับมือ และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) ≠ 16` และ `IsInstanceOf(actarAction, MobaPlayerActionManager) = 1` และ `IsInstanceOf(actarAction, PlayerActionManager) ≠ 1` หรือ อาวุธหลักอื่น (ไม่ใช่ สนับมือ) และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) = 16` และ `IsInstanceOf(actarAction, MobaPlayerActionManager) = 1` และ `IsInstanceOf(actarAction, PlayerActionManager) ≠ 1`]: `int(0.5 × AvoidActionManager.get_AvoidCount([actarAction.battleManager+0xa8])) + 1`
- `maxAttackCount` (ตั้งใน `OnInitialize`) [อาวุธหลัก สนับมือ และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) = 16` และ `IsInstanceOf(actarAction, MobaPlayerActionManager) ≠ 1` และ `IsInstanceOf(actarAction, PlayerActionManager) ≠ 1` หรือ อาวุธหลัก สนับมือ และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) ≠ 16` และ `IsInstanceOf(actarAction, MobaPlayerActionManager) ≠ 1` และ `IsInstanceOf(actarAction, PlayerActionManager) ≠ 1` หรือ อาวุธหลักอื่น (ไม่ใช่ สนับมือ) และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) = 16` และ `IsInstanceOf(actarAction, MobaPlayerActionManager) ≠ 1` และ `IsInstanceOf(actarAction, PlayerActionManager) ≠ 1`]: 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 (Lv1…10)
- `maxAttackCount` (ตั้งใน `OnInitialize`) [อาวุธหลัก สนับมือ และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) = 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1` หรือ อาวุธหลัก สนับมือ และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) ≠ 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1` หรือ อาวุธหลักอื่น (ไม่ใช่ สนับมือ) และ `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) = 16` และ `IsInstanceOf(actarAction, PlayerActionManager) = 1`]: `int(0.5 × AvoidActionManager.get_AvoidCount([actarAction.battleManager+0xa0])) + 1`
<!-- calc:end -->

### เอเนอร์จี้คอนโทรล (Kakei) · uid 147

<img src="../../icons/sk_147.png" width="40" alt="icon">

- ทรี: สกิลมาร์เชียล (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: สนับมือ · ต้องเรียนก่อน: จักรา
- คลาสในโค้ด: `KakeiAction` · สถานะการแกะ: แกะครบจากโค้ด

> ควบคุมการไหลเวียนของพลังและนำมาใช้
> ความเสียหายที่ได้รับเป็น 0 ระหว่างใช้สกิล
> และได้รับบัฟของจักรา ยกเว้นการฟื้นฟู MP
> การใช้งานจักราจะไม่เกิน Lv ของเอเนอร์จี้คอนโทรลที่เรียนรู้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `ChakraBuf` ระยะเวลา 20 + Lv → 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 (Lv1…10) วินาที [`(isKnuckle & 1) ≠ 0`] / 10 + Lv → 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 (Lv1…10) วินาที [`(isKnuckle & 1) = 0`]: MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = 1, 2, 3, 4, 5, 7, 9, 11, 13, 15 (Lv1…10) · ลดดาเมจฐาน (`BaseDamageCut`) = `baseDamageCut` · ตัวคูณดาเมจที่ได้รับจากมอน (หมวดซัพพอร์ต) (`MobLastDamageRateSupport`) = 30 + 2×Lv → 32, 34, 36, 38, 40, 42, 44, 46, 48, 50 (Lv1…10)
- บัพ `KakeiBuf` ระยะเวลา 30, 32, 35, 39, 45, 51, 59, 68, 78, 90 (Lv1…10) วินาที: ความเสถียร (`Stable`) = 10
- บัพ `KakeiDeffenceBuf`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `EnchantedBurstAction.ActionHit` — EnchantedBurstAction.ActionHit: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new EnchantedBurstBuf, Id` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (flag & 1) ne 0 AND (SkillBufferManager.ContainsBuffer(… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EnchantedBurstAction.AddLocalStack` — EnchantedBurstAction.AddLocalStack: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new EnchantedBurstBuf, 0` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Kakei) & 1) eq 0 AND (SkillBuffer… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EnchantedSwordAction.ActionPreparation` — EnchantedSwordAction: ขั้นเตรียมก่อนปล่อยสกิล (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EquipItemData.WeaponTypeCalculatorBase.CalcEqAtk` — คำนวณ eq atk (WeaponTypeCalculatorBase): คืนค่า `(((_t282 // 100) + (_t277 + ItemData.get_Refine(WeaponTypeCalculatorBase.item))) + int(_t285))` (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv16: [ผลต่อไปนี้ใช้ได้กับอุปกรณ์หลักเท่านั้น] เมื่อสำเร็จ ATK อาวุธและความเสถียรจะเพิ่มขึ้นชั่วขณะ การเพิ่ม ATK อาวุธเมื่อรวมกับ[ผู้ทำลายล้าง]จะไม่เกิน+50%

### แนบพิงภูเขา (Thieshankai) · uid 148

<img src="../../icons/sk_148.png" width="40" alt="icon">

- ทรี: สกิลมาร์เชียล (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: สนับมือ, MainHand · ต้องเรียนก่อน: เชอริออต
- คลาสในโค้ด: `ThieshankaiAction` · สถานะการแกะ: แกะครบจากโค้ด

> พุ่งชนด้วยหลังอย่างรุนแรง
> มีโอกาสทำให้ศัตรู "หมดสติ"
> 
> ถ้าศัตรูต้านทานหมดสติได้
> จะได้รับบัฟเพิ่มพลังให้กับสกิล "แอกราเวท"

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `stunPercent` [อาวุธหลัก สนับมือ]: 100 %
- โอกาสติดสถานะ `stunPercent` [อาวุธหลัก มือเปล่า]: **30 + 7×Lv** → 37, 44, 51, 58, 65, 72, 79, 86, 93, 100 (Lv1…10) %
- โอกาสติดสถานะ `stunPercent` [อาวุธหลักอื่น (ไม่ใช่ สนับมือ/มือเปล่า)]: **7×Lv** → 7, 14, 21, 28, 35, 42, 49, 56, 63, 70 (Lv1…10) %
- สถานะที่ทำให้ติด: สตัน (Stun)
- บัพ `ThieshankaiBuf` ระยะเวลา `second` วินาที: ตัวนับ/stack (`Count`) = 1 · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = Lv → 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10) · ค่าทั่วไปตัวที่ 2 (`Value2`) = `isMainKnuckle & 1 ≠ 0 ? 200 : 150`
- ตัวอ่านสกิลนี้ `NormalAttackAction.CheckOneChance` — ตรวจ one chance (NormalAttackAction): คืนค่า `(_t1204 & 1)` (3 กรณี) (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=148 -->
#### การคำนวณแบบตัวเลข — Thieshankai (uid 148)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **500** → 500, 500, 500, 500, 500, 500, 500, 500, 500, 500 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก สนับมือ]: **(750 + 25×Lv)%** → 775%, 800%, 825%, 850%, 875%, 900%, 925%, 950%, 975%, 1000% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก มือเปล่า หรือ อาวุธหลักอื่น (ไม่ใช่ สนับมือ/มือเปล่า) · AGI รวม=100, DEX รวม=100]: **(850 + 25×Lv)%** → 875%, 900%, 925%, 950%, 975%, 1000%, 1025%, 1050%, 1075%, 1100% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก มือเปล่า หรือ อาวุธหลักอื่น (ไม่ใช่ สนับมือ/มือเปล่า) · AGI รวม=100, DEX รวม=255 หรือ อาวุธหลัก มือเปล่า หรือ อาวุธหลักอื่น (ไม่ใช่ สนับมือ/มือเปล่า) · AGI รวม=255, DEX รวม=100 หรือ อาวุธหลัก มือเปล่า หรือ อาวุธหลักอื่น (ไม่ใช่ สนับมือ/มือเปล่า) · AGI รวม=255, DEX รวม=255]: **(1005 + 25×Lv)%** → 1030%, 1055%, 1080%, 1105%, 1130%, 1155%, 1180%, 1205%, 1230%, 1255% (Lv1…10)

**ค่าบัพที่ขึ้นกับจำนวน stack**

- บัพ `ThieshankaiBuf` — `Value` ตามจำนวน `Count`: `min(Count × Lv, 500)`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
  | 2 | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |
  | 3 | 3 | 6 | 9 | 12 | 15 | 18 | 21 | 24 | 27 | 30 |
  | 4 | 4 | 8 | 12 | 16 | 20 | 24 | 28 | 32 | 36 | 40 |
  | 5 | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |
<!-- calc:end -->

### กระทืบพสุธา (Shinkyaku) · uid 149

<img src="../../icons/sk_149.png" width="40" alt="icon">

- ทรี: สกิลมาร์เชียล (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: สนับมือ, MainHand · ต้องเรียนก่อน: เอิร์ธไบด์
- คลาสในโค้ด: `ShinkyakuAction` · สถานะการแกะ: แกะครบจากโค้ด

> กระทืบพื้นด้วยแรงมหาศาลเพื่อทำให้ศัตรูเสียหลัก
> มีโอกาสทำให้ศัตรู "ผงะ"
> MP จะฟื้นฟูอย่างมากเมื่อทำให้ผงะได้สำเร็จ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `flinchPercent`: **10×Lv** → 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10) %
- โอกาสติดสถานะ `ignoreAvoidPercent` [อาวุธหลักอื่น (ไม่ใช่ สนับมือ) และ `(mainWeaponType | 16) = 16` หรือ อาวุธหลักอื่น (ไม่ใช่ สนับมือ) และ `(mainWeaponType | 16) ≠ 16`]: **5×Lv** → 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10) %
- สถานะที่ทำให้ติด: ผงะ (Flinch)

<!-- calc:begin uid=149 -->
#### การคำนวณแบบตัวเลข — Shinkyaku (uid 149)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **300** → 300, 300, 300, 300, 300, 300, 300, 300, 300, 300 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก สนับมือ]: **(750 + 25×Lv)%** → 775%, 800%, 825%, 850%, 875%, 900%, 925%, 950%, 975%, 1000% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ สนับมือ) และ `(mainWeaponType | 16) = 16` หรือ อาวุธหลักอื่น (ไม่ใช่ สนับมือ) และ `(mainWeaponType | 16) ≠ 16` · DEX รวม=100, STR รวม=100]: **(850 + 25×Lv)%** → 875%, 900%, 925%, 950%, 975%, 1000%, 1025%, 1050%, 1075%, 1100% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ สนับมือ) และ `(mainWeaponType | 16) = 16` หรือ อาวุธหลักอื่น (ไม่ใช่ สนับมือ) และ `(mainWeaponType | 16) ≠ 16` · DEX รวม=100, STR รวม=255 หรือ อาวุธหลักอื่น (ไม่ใช่ สนับมือ) และ `(mainWeaponType | 16) = 16` หรือ อาวุธหลักอื่น (ไม่ใช่ สนับมือ) และ `(mainWeaponType | 16) ≠ 16` · DEX รวม=255, STR รวม=100 หรือ อาวุธหลักอื่น (ไม่ใช่ สนับมือ) และ `(mainWeaponType | 16) = 16` หรือ อาวุธหลักอื่น (ไม่ใช่ สนับมือ) และ `(mainWeaponType | 16) ≠ 16` · DEX รวม=255, STR รวม=255]: **(1005 + 25×Lv)%** → 1030%, 1055%, 1080%, 1105%, 1130%, 1155%, 1180%, 1205%, 1230%, 1255% (Lv1…10)
<!-- calc:end -->

### หมุนปัด / ขากงจักร (Senfutsu) · uid 150

<img src="../../icons/sk_150.png" width="40" alt="icon">

- ทรี: สกิลมาร์เชียล (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: สนับมือ, MainHand · ต้องเรียนก่อน: รัช
- คลาสในโค้ด: `SenfutsuAction` · สถานะการแกะ: แกะครบจากโค้ด

> ใช้ลูกเตะเพื่อทำให้ศัตรูเสียสมดุล
> เป้าหมายจะติด "ล้มคว่ำ"
> 
> ถ้าทำให้ "ล้มคว่ำ" สำเร็จจะทำการโจมตีต่อเนื่อง
> และได้รับบัฟชั่วขณะ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 3 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `SenfutsuBuf` ระยะเวลา `second` วินาที
- ตัวอ่านสกิลนี้ `InstallationBlackHolePattern.CheckSuctionHit` — ตรวจ suction hit (InstallationBlackHolePattern): คืนค่า `0` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `InstallationMoveBlackHolePattern.CheckSuctionHit` — ตรวจ suction hit (InstallationMoveBlackHolePattern): คืนค่า `0` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobAttackBase.SetAbnormalEffect` — MobAttackBase.SetAbnormalEffect (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv255: เมื่อได้รับบัฟจำนวน Avoid จะฟื้นฟูเล็กน้อย บัฟจะคงอยู่ไม่นานและระหว่างที่มีผลจะป้องกันเชื่องช้า หยุดนิ่ง การโจมตีด้วยการดูดเพื่อขัดขวางการเคลื่อนไหว

<!-- calc:begin uid=150 -->
#### การคำนวณแบบตัวเลข — Senfutsu (uid 150)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `fixAddDamage[vtab(0x165da70(System.Collections.IEnumerator#1(System.Array.GetEnumerator(System.Enum.GetValues(System.Type.GetTypeFromHandle(meta(0x39a89c8, SenfutsuAction.STATE_var))))), meta(0x39a89d0, SenfutsuAction.STATE_TypeInfo)))]` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `skillRate[vtab(0x165da70(System.Collections.IEnumerator#1(System.Array.GetEnumerator(System.Enum.GetValues(System.Type.GetTypeFromHandle(meta(0x39a89c8, SenfutsuAction.STATE_var))))), meta(0x39a89d0, SenfutsuAction.STATE_TypeInfo)))]` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
<!-- calc:end -->

