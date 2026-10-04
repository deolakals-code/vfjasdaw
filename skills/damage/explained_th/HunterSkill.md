# สกิลฮันเตอร์ (`HunterSkill`) — คำอธิบายทีละสกิล (ภาษาไทย)

สร้างอัตโนมัติด้วย `scripts/render_explained_th.py` จาก `skill_reference.json` (ข้อมูลโค้ด client ชุดล่าสุด) ไม่มีข้อความเขียนมือ แก้ไฟล์นี้ตรง ๆ จะถูกเขียนทับ ตัวเลขทั้งหมดคำนวณจากโค้ด (Code) ความหมายของชื่อ field/บทบาทแปลจากชื่อในโค้ด (Inferred) ยังไม่ได้เทียบกับตัวเลขในเกม ข้อมูลดิบทุกเส้นทางอยู่ใน `../details/HunterSkill.md`

---

<!-- calc:preface -->
> **วิธีอ่านหัวข้อ "การคำนวณแบบตัวเลข"** (สร้างอัตโนมัติด้วย `scripts/render_calc_th.py` จาก `skill_reference.json` แก้มือจะถูกเขียนทับ)
> ดาเมจต่อฮิตเดินตามขั้น `SkillCalcTemplate/CalcStep` 0→40 ตามลำดับ (Code: `SkillCalcTemplate.GetDamage`) ขั้น `+` บวกเข้าดาเมจ ขั้น `×` คูณแล้วปัดเศษทิ้ง (int) ทันทีทุกขั้น
> ลำดับหลัก: ดาเมจฐาน(7) + คงที่สกิล(8) + คงที่บัพ(9) − ป้องกันเป้า(10) + ตีแรก(11) → ×คริ(13) → ×ธาตุ(15) → ×ตัวคูณสกิล(18) → ×ตีแรก(19) → ×เสถียร(21) → +คงที่ออโต้(22) → ×Proration(23) → ×ประเภท(24) → ×ดาเมจสุดท้าย(25) → … → เพดาน/ขั้นต่ำ(35–37)
> "ฮิต N" = template ดาเมจแต่ละก้อน (ทอยคริแยกกัน) แยกตามเมธอดและตัวแปรฮิตในโค้ด (`type`, `isFirst`, `attackCount` …) ชื่อฮิต/ส่วนมาจากชื่อในโค้ด (Inferred) ตัวเลขคำนวณจากโค้ด (Code) โดยตั้งเจม/บัพเสริม = 0
> ค่าหลายก้อนในขั้นเดียวกันแบบ "บวกเข้าช่อง" จะบวกกันก่อนคูณ ส่วน "ตั้งค่าทับ" แทนที่ค่าเดิม ค่าที่ขึ้นกับสเตตัสแสดงเป็นตัวอย่างที่ 100 / 255 (และ Lv สกิลอื่น 1 / 10) ใช้สูตรที่แนบไว้คำนวณค่าอื่นเอง
<!-- calc:preface-end -->

### แตะ (KickBack) · uid 545

<img src="../../icons/sk_545.png" width="40" alt="icon">

- ทรี: สกิลฮันเตอร์ (ขั้น 1) · เลเวลสูงสุด: 15 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `KickBackAction` · สถานะการแกะ: แกะครบจากโค้ด

> เตะศัตรูให้กระเด็นห่างออกไป
> สร้างความเสียหายให้เป้าหมายและผลักกระเด็นออกไป

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `knockBackPercent`: **90 + Lv** → 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 (Lv1…10) %
- สถานะที่ทำให้ติด: กระเด็น (KnockBack)

<!-- calc:begin uid=545 -->
#### การคำนวณแบบตัวเลข — KickBack (uid 545)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **10×Lv** → 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `skillRate` — โดยที่ `skillRate` = `(10 × Lv + (Lv > 5 ? 10 × Lv - 50 : 0) + baseSTR ÷ 2) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
<!-- calc:end -->

### กับดักนิทรา (SleepTrap) · uid 549

<img src="../../icons/sk_549.png" width="40" alt="icon">

- ทรี: สกิลฮันเตอร์ (ขั้น 1) · เลเวลสูงสุด: 15 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: StarGem
- คลาสในโค้ด: `SleepTrapAction` · สถานะการแกะ: แกะครบจากโค้ด

> วางกับดักที่มีแก๊สยาสลบ
> มีโอกาสทำให้เป้าหมาย[หลับ]เมื่อเหยียบโดน
> ไม่สามารถติดตั้งที่เท้าได้โดยตรง
> มีโอกาสถูกทำลายด้วยการโจมตีในวงกว้าง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ, วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `abnormalPercent` [`(0 | (subWeapon == Arrow ? 1 : 0)) ≠ 0` หรือ อาวุธหลัก โบว์กัน และ `((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ≠ 0`]: 70, 80, 80, 80, 80, 90, 90, 90, 90, 100 (Lv1…10) %
- โอกาสติดสถานะ `abnormalPercent` [`(0 | (subWeapon == Arrow ? 1 : 0)) = 0` หรือ อาวุธหลัก โบว์กัน และ `((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) = 0`]: 50, 60, 60, 60, 60, 70, 70, 70, 70, 80 (Lv1…10) %
- สถานะที่ทำให้ติด: หลับ (Sleep)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv19: *DEX มีผลต่อพลัง *ระยะโจมตี (รัศมี)+1m *อัตราติดหลับ+20% *ฟื้นฟู MP เมื่อวางกับดัก+100

<!-- calc:begin uid=549 -->
#### การคำนวณแบบตัวเลข — SleepTrap (uid 549)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **50 + 5×Lv** → 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`(0 | (subWeapon == Arrow ? 1 : 0)) ≠ 0` หรือ อาวุธหลัก โบว์กัน และ `((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ≠ 0`]: `(Lv + baseDEX ÷ 2) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`(0 | (subWeapon == Arrow ? 1 : 0)) = 0` หรือ อาวุธหลัก โบว์กัน และ `((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) = 0`]: **(Lv)%** → 1%, 2%, 3%, 4%, 5%, 6%, 7%, 8%, 9%, 10% (Lv1…10)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `ActionStart`) [`failTrapper ≠ 0`]: 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 (Lv1…10)
<!-- calc:end -->

### โฮมมิ่งช็อต (HomingShot) · uid 554

<img src="../../icons/sk_554.png" width="40" alt="icon">

- ทรี: สกิลฮันเตอร์ (ขั้น 1) · เลเวลสูงสุด: 15 · อาวุธ: ธนู, โบว์กัน · ธง: StarGem
- คลาสในโค้ด: `HomingShotAction` · สถานะการแกะ: แกะครบจากโค้ด

> ยิงลูกธนูเวทมนตร์ติดตามที่แฝงการคุกคาม
> สกิลนี้โจมตีด้วย 'ความเคยชินทั่วไป'
> ยิ่งเลเวลสูงขึ้นเท่าไหร่จำนวนที่ยิงก็จะยิ่งเพิ่มมากขึ้น
> ฟื้นฟู MP เล็กน้อยเมื่อโจมตีโดนเป้าหมาย 

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 6 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: ธรรมดา (SkillNormal)
- Proration: ช่องตีปกติ · เปลี่ยนค่าทุกฮิต
- โอกาสติดสถานะ `hitPercent`: 1, 4, 9, 16, 25, 36, 49, 64, 81, 100 (Lv1…10) %

**โน้ตในเกม (ข้อความจากเกม):**
- Lv19: *พลังสกิล+200 *ฟื้นฟู MP 2 เท่า *เจาะทะลุ Avoid (ยกเว้น Avoid พิเศษ เช่น ในอีเว้นท์หรือกลไกต่างๆ)

<!-- calc:begin uid=554 -->
#### การคำนวณแบบตัวเลข — HomingShot (uid 554)
Proration: ช่อง `Normal` โหมด `every_hit + class check`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `arrowNum ≠ 0`**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [อาวุธหลัก ลูกธนู/โบว์กัน และ `1 ≥ arrowNum` และ `PlayerAttackBase.ExistWeaponType(playerAction, 19)` หรือ อาวุธหลัก ลูกธนู/โบว์กัน และ `!PlayerAttackBase.ExistWeaponType(playerAction, 19)` และ `1 ≥ arrowNum` และ `isBowgunHunter` หรือ อาวุธหลัก ลูกธนู/โบว์กัน และ `!PlayerAttackBase.ExistWeaponType(playerAction, 19)` และ `1 ≥ arrowNum` และ ไม่ `isBowgunHunter`]: **200** → 200, 200, 200, 200, 200, 200, 200, 200, 200, 200 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [อาวุธหลัก โบว์กัน และ ไม่ `isBowgunHunter` และ `1 ≥ arrowNum` และ `PlayerAttackBase.ExistWeaponType(playerAction, 19)` หรือ อาวุธหลัก โบว์กัน และ ไม่ `isBowgunHunter` และ `!PlayerAttackBase.ExistWeaponType(playerAction, 19)` และ `1 ≥ arrowNum` หรือ อาวุธหลัก โบว์กัน และ `(subWeapon != Null ? 1 : 0) = 0` และ `1 ≥ arrowNum` และ `PlayerAttackBase.ExistWeaponType(playerAction, 19)` หรือ อาวุธหลัก โบว์กัน และ `(subWeapon != Null ? 1 : 0) = 0` และ `!PlayerAttackBase.ExistWeaponType(playerAction, 19)` และ `1 ≥ arrowNum` และ …]: **0** → 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`1 ≥ arrowNum` และ `PlayerAttackBase.ExistWeaponType(playerAction, 19)` หรือ `!PlayerAttackBase.ExistWeaponType(playerAction, 19)` และ `1 ≥ arrowNum` และ `isBowgunHunter` หรือ `!PlayerAttackBase.ExistWeaponType(playerAction, 19)` และ `1 ≥ arrowNum` และ ไม่ `isBowgunHunter`]: **(10×Lv)%** → 10%, 20%, 30%, 40%, 50%, 60%, 70%, 80%, 90%, 100% (Lv1…10)

**จำนวนฮิต / ตัวนับ**
- `arrowNum` (ตั้งใน `OnInitialize`): 1, 1, 1, 1, 2, 2, 2, 2, 2, 3 (Lv1…10)
<!-- calc:end -->

### ซันไรส์แอร์โรว์ (SunriseArrow) · uid 546

<img src="../../icons/sk_546.png" width="40" alt="icon">

- ทรี: สกิลฮันเตอร์ (ขั้น 2) · เลเวลสูงสุด: 35 · อาวุธ: ธนู, โบว์กัน · ต้องเรียนก่อน: แตะ · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `SunriseArrowAction` · สถานะการแกะ: แกะครบจากโค้ด

> ยิงด้วยพลังสุริยะ
> โจมตีสร้างความเสียหายให้เป้าหมายโดยตรง
> ถ้าเป้าหมายหลับอยู่พลังโจมตีจะเพิ่มเป็น 2 เท่า

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

**โน้ตในเกม (ข้อความจากเกม):**
- Lv19: *พลังจะเพิ่มมากกว่าค่า DEX ของตัวเอง *ระยะโจมตี (แนวนอน)+1m

<!-- calc:begin uid=546 -->
#### การคำนวณแบบตัวเลข — SunriseArrow (uid 546)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **180 + 2×Lv** → 182, 184, 186, 188, 190, 192, 194, 196, 198, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`(0 | (subWeapon == Arrow ? 1 : 0)) ≠ 0` หรือ อาวุธหลัก โบว์กัน และ `((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ≠ 0` · DEX รวม=100]: **(200 + 10×Lv)%** → 210%, 220%, 230%, 240%, 250%, 260%, 270%, 280%, 290%, 300% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`(0 | (subWeapon == Arrow ? 1 : 0)) ≠ 0` หรือ อาวุธหลัก โบว์กัน และ `((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ≠ 0` · DEX รวม=255]: **(355 + 10×Lv)%** → 365%, 375%, 385%, 395%, 405%, 415%, 425%, 435%, 445%, 455% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`(0 | (subWeapon == Arrow ? 1 : 0)) = 0` หรือ อาวุธหลัก โบว์กัน และ `((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) = 0`]: **(100 + 10×Lv)%** → 110%, 120%, 130%, 140%, 150%, 160%, 170%, 180%, 190%, 200% (Lv1…10)
<!-- calc:end -->

### กับดักล่าสัตว์ (SteelTrap) · uid 550

<img src="../../icons/sk_550.png" width="40" alt="icon">

- ทรี: สกิลฮันเตอร์ (ขั้น 2) · เลเวลสูงสุด: 35 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: กับดักนิทรา
- คลาสในโค้ด: `SteelTrapAction` · สถานะการแกะ: แกะครบจากโค้ด

> ติดตั้งกับดักสัตว์ มีโอกาสทำให้เป้าหมาย[หยุดนิ่ง]เมื่อเหยียบโดน
> ไม่สามารถติดตั้งที่เท้าได้โดยตรง
> มีโอกาสถูกทำลายด้วยการโจมตีในวงกว้าง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ, วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `abnormalPercent` [`(0 | (subWeapon == Arrow ? 1 : 0)) ≠ 0` หรือ อาวุธหลัก โบว์กัน และ `((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ≠ 0`]: 70, 80, 80, 80, 80, 90, 90, 90, 90, 100 (Lv1…10) %
- โอกาสติดสถานะ `abnormalPercent` [`(0 | (subWeapon == Arrow ? 1 : 0)) = 0` หรือ อาวุธหลัก โบว์กัน และ `((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) = 0`]: 50, 60, 60, 60, 60, 70, 70, 70, 70, 80 (Lv1…10) %
- สถานะที่ทำให้ติด: หยุดนิ่ง (Stop)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv19: *DEX มีผลต่อพลัง *ระยะโจมตี (รัศมี)+1m *อัตราติดหยุดนิ่ง+20% *ฟื้นฟู MP เมื่อวางกับดัก+100

<!-- calc:begin uid=550 -->
#### การคำนวณแบบตัวเลข — SteelTrap (uid 550)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **50 + 5×Lv** → 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`(0 | (subWeapon == Arrow ? 1 : 0)) ≠ 0` หรือ อาวุธหลัก โบว์กัน และ `((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ≠ 0`]: `(Lv + baseDEX ÷ 2) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`(0 | (subWeapon == Arrow ? 1 : 0)) = 0` หรือ อาวุธหลัก โบว์กัน และ `((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) = 0`]: **(Lv)%** → 1%, 2%, 3%, 4%, 5%, 6%, 7%, 8%, 9%, 10% (Lv1…10)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `ActionStart`) [`failTrapper ≠ 0`]: 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 (Lv1…10)
<!-- calc:end -->

### ดีเทคชั่น (Detection) · uid 553

<img src="../../icons/sk_553.png" width="40" alt="icon">

- ทรี: สกิลฮันเตอร์ (ขั้น 2) · เลเวลสูงสุด: 35 · อาวุธ: ธนู, โบว์กัน · ต้องเรียนก่อน: โฮมมิ่งช็อต
- คลาสในโค้ด: `DetectionAction` · สถานะการแกะ: แกะครบจากโค้ด

> ความสามารถในการรับรู้ถึงอันตรายในธรรมชาติ
> ลดเฮทของตัวเองและ
> เพิ่มอัตราคริติคอลเล็กน้อย 40 วินาที
> เอฟเฟกต์จะสิ้นสุดลงเมื่อตกเป็นเป้าหมาย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `DetectionBuf` ระยะเวลา 40 วินาที: อัตราคริ + (`CrtUp`) = Lv → 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
- ตัวอ่านสกิลนี้ `EnemyMobActionManagerBase.InitManagedMob` — EnemyMobActionManagerBase.InitManagedMob: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Detection` เมื่อ (UnityEngine.Object.op_Inequality(battleManager, 0) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(UnityEngine.GameObj…; [call] `PlayerBattleManager$$StartDetectionDecoyShooter` = `[UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>(Target)+0x30]` เมื่อ (UnityEngine.Object.op_Inequality(battleManager, 0) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(UnityEngine.GameObj… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobObjectManager.ReceiveMobaMobChangeHateManager` — MobObjectManager.ReceiveMobaMobChangeHateManager: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Detection` เมื่อ mobs.IsValid ge 1 AND 0 lo mobs.IsValid AND (Toram.Common.ArchetypeUid.IsArchetype(out, 0) & 1) ne 0 AND (SkillBufferMa…; [call] `MobaPlayerBattleManager$$StartDetectionDecoyShooter` = `PlayerDataManager.get_PlayerActionManager(playerDataManager).battleManager` เมื่อ mobs.IsValid ge 1 AND 0 lo mobs.IsValid AND (Toram.Common.ArchetypeUid.IsArchetype(out, 0) & 1) ne 0 AND (SkillBufferMa… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerSecondaryStatus.GetCrtConstant` — MobaPlayerSecondaryStatus.GetCrtConstant: คืนค่า `_t1164` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PhotonListener.OnActionPartyChangeHateMine` — PhotonListener.OnActionPartyChangeHateMine: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Detection` เมื่อ (PartyManager.get_IsParty(Singleton<PartyManager>.get_Instance()) & 1) ne 0 AND (Toram.Common.ArchetypeUid.op_Equality(…; [call] `PlayerBattleManager$$StartDetectionDecoyShooter` = `PlayerDataManager.get_PlayerActionManager(PlayerDataManager.GetPlayerDataManager()).battl…` เมื่อ (PartyManager.get_IsParty(Singleton<PartyManager>.get_Instance()) & 1) ne 0 AND (Toram.Common.ArchetypeUid.op_Equality(…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Detection` เมื่อ (PartyManager.get_IsParty(Singleton<PartyManager>.get_Instance()) & 1) ne 0 AND (Toram.Common.ArchetypeUid.op_Equality(… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PhotonListener.OnActionRoomChangeHateMine` — PhotonListener.OnActionRoomChangeHateMine: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Detection` เมื่อ (Toram.Common.ArchetypeUid.op_Equality(archetype.ArchetypeUid, PlayerDataManager.GetPlayerDataManager().archetypeUid) &…; [call] `PlayerBattleManager$$StartDetectionDecoyShooter` = `PlayerDataManager.get_PlayerActionManager(PlayerDataManager.GetPlayerDataManager()).battl…` เมื่อ (Toram.Common.ArchetypeUid.op_Equality(archetype.ArchetypeUid, PlayerDataManager.GetPlayerDataManager().archetypeUid) &…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Detection` เมื่อ (Toram.Common.ArchetypeUid.op_Equality(archetype.ArchetypeUid, PlayerDataManager.GetPlayerDataManager().archetypeUid) &… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.GetCrtConstant` — PlayerSecondaryStatus.GetCrtConstant: คืนค่า `_t1629` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.GetDisplayBonusCalcHate` — PlayerSecondaryStatus.GetDisplayBonusCalcHate: คืนค่า `int(frintp((fcvt(((_t1651 + 1) * 100)) + -0.5)))` (2 กรณี) (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv12: [จะได้รับเอฟเฟกต์แบบเดียวกันถ้าใช้กับโบว์กัน] *เมื่อเอฟเฟกต์สิ้นสุดลงด้วยการตกเป็นเป้าหมาย จะใช้สกิลยิง "เดคอยชูตเตอร์" โดยอัตโนมัติ

### เมจิคแอร์โรว์ (ForceArrow) · uid 547

<img src="../../icons/sk_547.png" width="40" alt="icon">

- ทรี: สกิลฮันเตอร์ (ขั้น 3) · เลเวลสูงสุด: 125 · อาวุธ: ธนู, โบว์กัน · ต้องเรียนก่อน: ซันไรส์แอร์โรว์
- คลาสในโค้ด: `ForceArrow` · สถานะการแกะ: แกะครบจากโค้ด

> เทคนิคอัพเกรดพลังโจมตีให้ลูกธนูด้วยเวทมนตร์
> การฟื้นฟู ATK อาวุธและ MP โจมตีจะเพิ่มขึ้นเล็กน้อย
> การโจมตีปกติจะถูกอัพเกรดตาม MATK
> ผลลัพธ์ที่ได้จะหมดลง เมื่อใช้การโจมตีปกติตามจำนวนครั้งที่กำหนด

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, เพิ่มดาเมจตีปกติ
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `ForceArrowBuf`: ATK อาวุธ % (`EqAtkUpRate`) = 0, 1, 1, 2, 2, 3, 3, 4, 4, 5 (Lv1…10) · MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = `(int((Lv * 0.5)) + ((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 19 ? 1 : 0) | (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 0 ? 1 : 0)))` · ดาเมจคงที่ตีปกติ (`NormalAttackConstantDamage`) = `Lvรวม + int(0.1 × Matkรวม)` · ดาเมจคงที่ตีปกติ (`NormalAttackConstantDamage`) = `Lvรวม + Matkรวม` · MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = `(int((Lv * 0.5)) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 19 ? 1 : 0))`
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = (((arrow gt 0 ? 1 : 0) << 1) + lv) ตามที่ `ForceArrowBuf` ส่งให้ตัวสร้างของ `บัพฐาน`

**โน้ตในเกม (ข้อความจากเกม):**
- Lv19: *ปริมาณ MATK มีผลต่อพลังการโจมตีปกติ+90% *ฟื้นฟู MP โจมตี+1 *เพิ่มจำนวนครั้งผลที่ได้รับ

### ทุ่นระเบิด (Explossive) · uid 551

<img src="../../icons/sk_551.png" width="40" alt="icon">

- ทรี: สกิลฮันเตอร์ (ขั้น 3) · เลเวลสูงสุด: 125 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: กับดักล่าสัตว์
- คลาสในโค้ด: `ExplossiveAction` · สถานะการแกะ: แกะครบจากโค้ด

> ติดตั้งกับระเบิด
> มีโอกาสเล็กน้อยที่จะทำให้เป้าหมาย[ไหม้ไฟ]เมื่อเหยียบโดน
> ไม่สามารถติดตั้งที่เท้าโดยตรงได้
> อาจโดนทำลายด้วยการโจมตีในบริเวณกว้าง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ, วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: ไฟไหม้ (Ignition)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv19: *DEX กับ TEC มีผลต่อพลัง *ระยะโจมตี (รัศมี)+1m *อัตราติดไหม้ไฟ+80% *ฟื้นฟู MP เมื่อวางกับดัก+100

<!-- calc:begin uid=551 -->
#### การคำนวณแบบตัวเลข — Explossive (uid 551)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **100 + 30×Lv** → 130, 160, 190, 220, 250, 280, 310, 340, 370, 400 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`(0 | (subWeapon == Arrow ? 1 : 0)) ≠ 0` หรือ อาวุธหลัก โบว์กัน และ `((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ≠ 0`]: `(60 × Lv + 2 × baseTEC + 2 × baseDEX + 200) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseTEC` = แต้ม TEC ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseTEC; `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`(0 | (subWeapon == Arrow ? 1 : 0)) = 0` หรือ อาวุธหลัก โบว์กัน และ `((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) = 0`]: **(200 + 60×Lv)%** → 260%, 320%, 380%, 440%, 500%, 560%, 620%, 680%, 740%, 800% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(20000 + 6000×Lv)%** → 26000%, 32000%, 38000%, 44000%, 50000%, 56000%, 62000%, 68000%, 74000%, 80000% (Lv1…10)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `ActionStart`) [`failTrapper ≠ 0`]: 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 (Lv1…10)
<!-- calc:end -->

### ไซโคลนแอร์โรว์ (CycloneArrow) · uid 556

<img src="../../icons/sk_556.png" width="40" alt="icon">

- ทรี: สกิลฮันเตอร์ (ขั้น 3) · เลเวลสูงสุด: 125 · อาวุธ: ธนู · ต้องเรียนก่อน: ดีเทคชั่น
- คลาสในโค้ด: `CycloneArrowAction` · สถานะการแกะ: แกะครบจากโค้ด

> สกิลการยิงธนูที่ห่อหุ้มด้วยวายุเพื่อสร้างทอร์นาโด
> แม้พลังจะต่ำแต่มีโอกาสทำให้เป้าหมาย "ผงะ"
> และดูดกลืนมอนสเตอร์ที่อยู่โดยรอบ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: ผงะ (Flinch), Suction (Suction)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv19: *พลังจะเพิ่มมากกว่าค่า DEX ของตัวเอง *ระยะโจมตี (รัศมี) 2 เท่า

<!-- calc:begin uid=556 -->
#### การคำนวณแบบตัวเลข — CycloneArrow (uid 556)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **100** → 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ลูกธนู · DEX รวม=100]: **(50 + 10×Lv)%** → 60%, 70%, 80%, 90%, 100%, 110%, 120%, 130%, 140%, 150% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ลูกธนู · DEX รวม=255]: **(127 + 10×Lv)%** → 137%, 147%, 157%, 167%, 177%, 187%, 197%, 207%, 217%, 227% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ ลูกธนู)]: **(10×Lv)%** → 10%, 20%, 30%, 40%, 50%, 60%, 70%, 80%, 90%, 100% (Lv1…10)
<!-- calc:end -->

### ฮันเตอร์ครอสโบ (BowgunHunter) · uid 557

<img src="../../icons/sk_557.png" width="40" alt="icon">

- ทรี: สกิลฮันเตอร์ (ขั้น 3) · เลเวลสูงสุด: 125 · อาวุธ: โบว์กัน · ต้องเรียนก่อน: ดีเทคชั่น
- คลาสในโค้ด: `BowgunHunter` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่มความเก่งกาจในการล่า
> ฮันเตอร์สกิลยังคงแสดงผล
> แม้ว่าจะติดตั้งตัวช่วยอื่นนอกจากลูกธนู
> เพิ่ม ATK ของโบว์กันตามสกิลเลเวล

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ATK อาวุธ % (`EqAtkRate`): 2, 5, 7, 10, 12, 15, 17, 20, 22, 25 (Lv1…10)

### แซทเทิลไลท์แอร์โรว์ (SatelliteArrow) · uid 548

<img src="../../icons/sk_548.png" width="40" alt="icon">

- ทรี: สกิลฮันเตอร์ (ขั้น 4) · เลเวลสูงสุด: 205 · อาวุธ: ธนู, โบว์กัน · ต้องเรียนก่อน: เมจิคแอร์โรว์ · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `SatelliteArrowAction` · สถานะการแกะ: แกะครบจากโค้ด

> เป็นเทคนิคที่ต้องใช้ความสามารถมากเพื่อโจมตีเป้าหมายจากมุมสูง
> เนื่องจากต้องใช้เวลาในการเล็งโจมตีเป้าหมาย
> จึงต้องการเทคนิคระดับสูงในการโจมตีให้เข้าเป้า

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

**โน้ตในเกม (ข้อความจากเกม):**
- Lv19: *DEX มีผลต่อพลัง *ระยะโจมตี (รัศมี)+0.5m

<!-- calc:begin uid=548 -->
#### การคำนวณแบบตัวเลข — SatelliteArrow (uid 548)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **300** → 300, 300, 300, 300, 300, 300, 300, 300, 300, 300 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`(0 | (subWeapon == Arrow ? 1 : 0)) ≠ 0` หรือ อาวุธหลัก โบว์กัน และ `((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ≠ 0` · DEX รวม=100]: **(600 + 50×Lv)%** → 650%, 700%, 750%, 800%, 850%, 900%, 950%, 1000%, 1050%, 1100% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`(0 | (subWeapon == Arrow ? 1 : 0)) ≠ 0` หรือ อาวุธหลัก โบว์กัน และ `((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ≠ 0` · DEX รวม=255]: **(755 + 50×Lv)%** → 805%, 855%, 905%, 955%, 1005%, 1055%, 1105%, 1155%, 1205%, 1255% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`(0 | (subWeapon == Arrow ? 1 : 0)) = 0` หรือ อาวุธหลัก โบว์กัน และ `((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) = 0`]: **(500 + 50×Lv)%** → 550%, 600%, 650%, 700%, 750%, 800%, 850%, 900%, 950%, 1000% (Lv1…10)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `target.ExpDefSkill / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefSkill` = proration ช่อง Skill ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_CharacterActionManagerBase` = ค่า Character Action Manager Base ของ MobActionManagerBase (ดูแท็บ Variables)

**จำนวนฮิต / ตัวนับ**
- `damageCount` (ตั้งใน `OnInitialize`): 1, 1, 1, 1, 2, 2, 2, 2, 3, 3 (Lv1…10)
- `LoopParam` (ตั้งใน `OnInitialize`): 1, 1, 1, 1, 2, 2, 2, 2, 3, 3 (Lv1…10)
- `damageCount` (ตั้งใน `InitializeOthers`): `motionSpeed`
<!-- calc:end -->

### กับดักความมืด (BlankTrap) · uid 552

<img src="../../icons/sk_552.png" width="40" alt="icon">

- ทรี: สกิลฮันเตอร์ (ขั้น 4) · เลเวลสูงสุด: 205 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ทุ่นระเบิด · ธง: StarGem
- คลาสในโค้ด: `BlankTrapAction` · สถานะการแกะ: แกะครบจากโค้ด

> ติดตั้งกับดักดูดพลัง
> มีโอกาสเล็กน้อยที่จะทำให้เป้าหมาย[เฉื่อยชา]เมื่อเหยียบโดน
> ไม่สามารถติดตั้งที่เท้าโดยตรงได้
> อาจโดนทำลายได้ด้วยการโจมตีในบริเวณกว้าง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ, วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `abnormalPercent` [`(0 | (subWeapon == Arrow ? 1 : 0)) ≠ 0` หรือ อาวุธหลัก โบว์กัน และ `((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ≠ 0`]: 70, 80, 80, 80, 80, 90, 90, 90, 90, 100 (Lv1…10) %
- โอกาสติดสถานะ `abnormalPercent` [`(0 | (subWeapon == Arrow ? 1 : 0)) = 0` หรือ อาวุธหลัก โบว์กัน และ `((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) = 0`]: 50, 60, 60, 60, 60, 70, 70, 70, 70, 80 (Lv1…10) %
- สถานะที่ทำให้ติด: อ่อนแอ (Weak)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv19: *DEX มีผลต่อพลัง *ระยะโจมตี (รัศมี)+1m *อัตราติดเฉื่อยชา+20% *ฟื้นฟู MP เมื่อวางกับดัก+100

<!-- calc:begin uid=552 -->
#### การคำนวณแบบตัวเลข — BlankTrap (uid 552)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **50 + 5×Lv** → 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`(0 | (subWeapon == Arrow ? 1 : 0)) ≠ 0` หรือ อาวุธหลัก โบว์กัน และ `((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ≠ 0`]: `(Lv + baseDEX) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`(0 | (subWeapon == Arrow ? 1 : 0)) = 0` หรือ อาวุธหลัก โบว์กัน และ `((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) = 0`]: **(Lv)%** → 1%, 2%, 3%, 4%, 5%, 6%, 7%, 8%, 9%, 10% (Lv1…10)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `ActionStart`) [`failTrapper ≠ 0`]: 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 (Lv1…10)
<!-- calc:end -->

### เวอร์ติคัลแอร์ (VerticalAir) · uid 555

<img src="../../icons/sk_555.png" width="40" alt="icon">

- ทรี: สกิลฮันเตอร์ (ขั้น 4) · เลเวลสูงสุด: 205 · อาวุธ: ธนู · ต้องเรียนก่อน: ไซโคลนแอร์โรว์
- คลาสในโค้ด: `VerticalAirAction` · สถานะการแกะ: แกะครบจากโค้ด

> สกิลลูกธนูมรณะผสมผสานระหว่างหลบหลีกและตอบโต้
> จำนวนการโจมตีจะเพิ่มขึ้นตามระยะห่าง
> (สูงสุด 3 ครั้ง)
> ติด "คงกระพัน" ให้ตัวเองเมื่อเปิดใช้สกิล

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 6 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

**โน้ตในเกม (ข้อความจากเกม):**
- Lv19: *เพิ่มอาวุธเจาะเข้าเมื่อโจมตีครั้งที่ 2 *เพิ่มอาวุธเจาะเข้าเมื่อโจมตีครั้งที่ 3

<!-- calc:begin uid=555 -->
#### การคำนวณแบบตัวเลข — VerticalAir (uid 555)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `ช่อง [0] ของอาร์เรย์ต่อฮิต`**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`0 lo fixAddDamage.Length` และ `0 lo physicsResist.Length` และ `0 lo skillRate.Length`]: **250** → 250, 250, 250, 250, 250, 250, 250, 250, 250, 250 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`0 hs fixAddDamage.Length` และ `0 lo physicsResist.Length` และ `0 lo skillRate.Length` หรือ `0 lo fixAddDamage.Length` และ `0 lo physicsResist.Length` และ `0 lo skillRate.Length`]: **(300 + 45×Lv)%** → 345%, 390%, 435%, 480%, 525%, 570%, 615%, 660%, 705%, 750% (Lv1…10)
- ค่าอื่นของฮิตนี้ `physicsResist[0]`: 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 (Lv1…10)

**ฮิต 2: `calcPlayerToMobDamage` (ดาเมจหลัก) — `ช่อง [1] ของอาร์เรย์ต่อฮิต`**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`0 lo fixAddDamage.Length` และ `0 lo physicsResist.Length` และ `0 lo skillRate.Length` และ `1 lo fixAddDamage.Length` และ …]: **100** → 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`0 lo fixAddDamage.Length` และ `0 lo physicsResist.Length` และ `0 lo skillRate.Length` และ `1 hs fixAddDamage.Length` และ … หรือ `0 lo fixAddDamage.Length` และ `0 lo physicsResist.Length` และ `0 lo skillRate.Length` และ `1 lo fixAddDamage.Length` และ …]: **(200 + 30×Lv)%** → 230%, 260%, 290%, 320%, 350%, 380%, 410%, 440%, 470%, 500% (Lv1…10)
- ค่าอื่นของฮิตนี้ `physicsResist[1]`: [ไม่ใส่ ลูกธนู] 2, 5, 7, 10, 12, 15, 17, 20, 22, 25 · [ใส่ ลูกธนู] 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10)

**ฮิต 3: `calcPlayerToMobDamage` (ดาเมจหลัก) — `ช่อง [2] ของอาร์เรย์ต่อฮิต`**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`0 lo fixAddDamage.Length` และ `0 lo physicsResist.Length` และ `0 lo skillRate.Length` และ `1 lo fixAddDamage.Length` และ …]: **50** → 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`0 lo fixAddDamage.Length` และ `0 lo physicsResist.Length` และ `0 lo skillRate.Length` และ `1 lo fixAddDamage.Length` และ … หรือ `0 lo fixAddDamage.Length` และ `0 lo physicsResist.Length` และ `0 lo skillRate.Length` และ `1 lo fixAddDamage.Length` และ …]: **(100 + 15×Lv)%** → 115%, 130%, 145%, 160%, 175%, 190%, 205%, 220%, 235%, 250% (Lv1…10)
- ค่าอื่นของฮิตนี้ `physicsResist[2]`: [ไม่ใส่ ลูกธนู] 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 · [ใส่ ลูกธนู] 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10)

**ใช้ร่วมทุกฮิตของ ฮิตรีแอ็กชัน (`HitReactionAssign`)**
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical)` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobBuffer.GuardUpBuff.get_GuardUpval` = ค่า Guard Upval ของ GuardUpBuff; `TryGetBuff.buff` = TryGetBuff.buff; `MobActionManagerBase.get_BuffManager` = ค่า Buff Manager ของ MobActionManagerBase (ดูแท็บ Variables)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) = 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: **25** → 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 (Lv1…10)

**จำนวนฮิต / ตัวนับ**
- `damageCount` (ตั้งใน `InitializeOthers`): `SkillIndividualFlag` — โดยที่ `SkillIndividualFlag` = `System.Math.Min(MobActionManagerBase.get_PlayerMeterDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)) ÷ 4 + 1, 3)`
- `damageCount` (ตั้งใน `ActionPreparation`): `System.Math.Min(MobActionManagerBase.get_PlayerMeterDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)) ÷ 4 + 1, 3)`
<!-- calc:end -->

### มัลติเพิลฮันท์ / วูปสไนเปอร์ / สไนเปอร์วอลเลย์ / วันแฮนด์ช็อต / ชาร์ปชูตเตอร์ (MultipleHunt) · uid 558

<img src="../../icons/sk_558.png" width="40" alt="icon">

- ทรี: สกิลฮันเตอร์ (ขั้น 4) · เลเวลสูงสุด: 205 · อาวุธ: โบว์กัน · ต้องเรียนก่อน: ฮันเตอร์ครอสโบ
- คลาสในโค้ด: `MultipleHuntAction` · สถานะการแกะ: แกะครบจากโค้ด

> สกิลการล่าโดยใช้อาวุธเสริม
> เมื่อเปิดใช้สกิลนี้โดยไม่ได้ใช้ดาบสั้น, อุปกรณ์เวทมนตร์ หรือโล่
> จะสร้างความเสียหายให้กับเป้าหมายและ
> ยิ่งอาวุธเจาะเข้าของตัวเองสูงเท่าไหร่
> ก็จะยิ่งมีโอกาสทำให้เกิด "ลดการป้องกัน" มากเท่านั้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 4 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: ตามโหมด: Wolf Assault/Chasse Garde/Sharp Snipe = กายภาพ, High Rain Snipe = เวท — เงื่อนไข: Physics: InitializeWolfAssault / ChasseGarde / SharpSnipe; Magic: InitializeHighRainSnipe
- Proration: ช่องที่เลือกตอนร่าย (กายภาพ/เวท) · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `abnormalPercent`: `baseDEX // 10 + 5 × Lv + INTรวม // 5` %
- โอกาสติดสถานะ `abnormalPercent`: `2 × BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51) + 10` %
- สถานะที่ทำให้ติด: หยุดนิ่ง (Stop), เกราะแตก (Breaking)
- บัพ `MultipleHuntBuf`: ดาเมจระยะใกล้ % (`ShortRangeRate`) = 10 · ลดดาเมจเวทที่ได้รับ (`MagicDmgCut`) = `damageResist` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ลดดาเมจกายภาพที่ได้รับ (`PowerDmgCut`) = `damageResist` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · อัตราคริ + (`CrtUp`) = -35 + Lv → -34, -33, -32, -31, -30, -29, -28, -27, -26, -25 (Lv1…10) · ตัวคูณดาเมจที่ได้รับจากมอน (หมวดเฉพาะ) (`MobLastDamageRateUnique`) = 72
- ตัวอ่านสกิลนี้ `BCollaboBossActionManager.Damaged` — BCollaboBossActionManager: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `MultipleHuntBuf$$CheckMode` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt), SkillMode…` เมื่อ (EnemyMobActionManagerBase.get_IsDead() & 1) eq 0 AND IsValid ne 0 AND (EnemyMobActionManagerBase.CheckCurrentPatternDa…; [call] `MultipleHuntBuf$$CheckMode` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt), SkillMode…` เมื่อ (EnemyMobActionManagerBase.get_IsDead() & 1) eq 0 AND IsValid ne 0 AND (EnemyMobActionManagerBase.CheckCurrentPatternDa… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EnemyMobActionManagerBase.Damaged` — EnemyMobActionManagerBase: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `MultipleHuntBuf$$CheckMode` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt), SkillMode…` เมื่อ (EnemyMobActionManagerBase.get_IsDead() & 1) eq 0 AND IsValid ne 0 AND damageData.HitType ne 0 AND (UnityEngine.Object.…; [call] `MultipleHuntBuf$$CheckMode` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt), SkillMode…` เมื่อ (EnemyMobActionManagerBase.get_IsDead() & 1) eq 0 AND IsValid ne 0 AND damageData.HitType ne 0 AND (UnityEngine.Object.… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobAttackBase.CalcLastDamage` — คำนวณ last damage (MobAttackBase): [call] `MultipleHuntBuf$$CheckMode` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt), SkillMode…` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt, out) & 1) ne 0 AND TryGe…; [call] `MultipleHuntBuf$$CheckMode` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt), SkillMode…` เมื่อ (_t853 & 1) ne 0 AND PlayerStatusBase.get_SkillBufferManager().skillBufList[SkillId.GodHand].isSkillEnd eq 0 AND (MobAt…; [call] `MultipleHuntBuf$$CheckMode` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt), SkillMode…` เมื่อ (_t853 & 1) ne 0 AND PlayerStatusBase.get_SkillBufferManager().skillBufList[SkillId.GodHand].isSkillEnd eq 0 AND (MobAt… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MultipleHuntAction.<>c__DisplayClass37_0.<ActionStart>b__0` — <>c__DisplayClass37_0.<ActionStart>b__0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MultipleHuntAction.ActionStart` — MultipleHuntAction: ตอนเริ่มทำงานของสกิล: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt, Lv, 0, mode, 0` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND mode eq 0; [call] `MultipleHuntBuf$$StartSkill` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt)` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND mode eq 2…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt, Lv, 0, mode, 0` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND mode eq 2… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.Damaged` — PlayerActionManager: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.ActionStart` — PlayerAttackBase: ตอนเริ่มทำงานของสกิล: [call] `MultipleHuntBuf$$CheckMode` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt), SkillMode…` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt, out) & 1) ne 0 AND TryGe…; [call] `MultipleHuntBuf$$CheckMode` = `0, SkillMode.ChasseGarde` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt, out) & 1) ne 0 AND TryGe… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.CalcCostMp` — MP ที่ใช้ของสกิล: [call] `MultipleHuntBuf$$CheckMode` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt), SkillMode…` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt, out) & 1) ne 0 AND TryGe…; [call] `MultipleHuntBuf$$CheckMode` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt), SkillMode…` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill…; [call] `MultipleHuntBuf$$CheckMode` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt), SkillMode…` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv15: ควบคุมและยิงเป้าหมายด้วยเวทมนตร์  สร้างความเสียหายทางเวทแก่เป้าหมาย มีโอกาสติด[หยุดนิ่ง] โจมตีโดยรอบอย่างต่อเนื่อง (ความเสียหายกายภาพ) เมื่อนั้นเป้าหมายที่หยุดนิ่งจะการันตีคริติคอล
- Lv17: ยิงโดยถือโล่ไว้ด้านหน้า  พลังเพิ่มตามค่า VIT ของตัวเอง ลดความเสียหายที่ได้รับระหว่างสกิลแสดงผล หากใช้สกิลสำเร็จ ผลการฟื้นฟู HP จะเพิ่มความเสียหายของสกิลเป็นเวลา 10 วินาที
- Lv18: หลังซุ่มโจมตีด้วยดาบสั้นจะโจมตีด้วยธนูโดยอัตโนมัติ  พลังเพิ่มตามค่า AGI ของตัวเอง ลดการใช้ MP ลงครึ่งหนึ่งของสกิลที่ใช้ถัดไป และพลังโจมตีระยะใกล้จะเพิ่มขึ้นเล็กน้อย

<!-- calc:begin uid=558 -->
#### การคำนวณแบบตัวเลข — MultipleHunt (uid 558)
Proration: ช่อง `dynamic` โหมด `first_hit_per_target`

**ฮิต 1: `calcDamageWolfAssault` (ส่วน WolfAssault)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **200** → 200, 200, 200, 200, 200, 200, 200, 200, 200, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate`]: `(SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) + AGIรวม + 50 × Lv + 500) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Agi` = AGI สุดท้าย; `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.SkillRate` = ตัวคูณสกิล (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 4 ของ `skillRate`]: `(SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) + VITรวม + 25 × Lv + 750) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Vit` = VIT สุดท้าย; `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.SkillRate` = ตัวคูณสกิล (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `skillRate` · AGI รวม=100]: **(600 + 50×Lv)%** → 650%, 700%, 750%, 800%, 850%, 900%, 950%, 1000%, 1050%, 1100% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `skillRate` · AGI รวม=255]: **(755 + 50×Lv)%** → 805%, 855%, 905%, 955%, 1005%, 1055%, 1105%, 1155%, 1205%, 1255% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 3 ของ `skillRate`]: **(75×Lv)%** → 75%, 150%, 225%, 300%, 375%, 450%, 525%, 600%, 675%, 750% (Lv1…10)

**ฮิต 2: `calcDamageHighRainSnipe` (ส่วน HighRainSnipe) — `hitCount ≠ 0` · ส่วน ครั้งที่ 2 (`second…`)**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(500 + 25×Lv)%** → 525%, 550%, 575%, 600%, 625%, 650%, 675%, 700%, 725%, 750% (Lv1…10)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `target.ExpDefSkill / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefSkill` = proration ช่อง Skill ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_CharacterActionManagerBase` = ค่า Character Action Manager Base ของ MobActionManagerBase (ดูแท็บ Variables)

**ฮิต 3: `calcDamageHighRainSnipe` (ส่วน HighRainSnipe) — `hitCount = 0`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate`]: `(SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) + AGIรวม + 50 × Lv + 500) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Agi` = AGI สุดท้าย; `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.SkillRate` = ตัวคูณสกิล (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 4 ของ `skillRate`]: `(SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) + VITรวม + 25 × Lv + 750) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Vit` = VIT สุดท้าย; `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.SkillRate` = ตัวคูณสกิล (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `skillRate` · AGI รวม=100]: **(600 + 50×Lv)%** → 650%, 700%, 750%, 800%, 850%, 900%, 950%, 1000%, 1050%, 1100% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `skillRate` · AGI รวม=255]: **(755 + 50×Lv)%** → 805%, 855%, 905%, 955%, 1005%, 1055%, 1105%, 1155%, 1205%, 1255% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 3 ของ `skillRate`]: **(75×Lv)%** → 75%, 150%, 225%, 300%, 375%, 450%, 525%, 600%, 675%, 750% (Lv1…10)

**ฮิต 4: `calcDamageChasseGarde` (ส่วน ChasseGarde)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **200** → 200, 200, 200, 200, 200, 200, 200, 200, 200, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate`]: `(SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) + AGIรวม + 50 × Lv + 500) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Agi` = AGI สุดท้าย; `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.SkillRate` = ตัวคูณสกิล (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 4 ของ `skillRate`]: `(SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) + VITรวม + 25 × Lv + 750) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Vit` = VIT สุดท้าย; `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.SkillRate` = ตัวคูณสกิล (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `skillRate` · AGI รวม=100]: **(600 + 50×Lv)%** → 650%, 700%, 750%, 800%, 850%, 900%, 950%, 1000%, 1050%, 1100% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `skillRate` · AGI รวม=255]: **(755 + 50×Lv)%** → 805%, 855%, 905%, 955%, 1005%, 1055%, 1105%, 1155%, 1205%, 1255% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 3 ของ `skillRate`]: **(75×Lv)%** → 75%, 150%, 225%, 300%, 375%, 450%, 525%, 600%, 675%, 750% (Lv1…10)

**ฮิต 5: `calcDamageSharpSnipe` (ส่วน SharpSnipe)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **200** → 200, 200, 200, 200, 200, 200, 200, 200, 200, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate`]: `(SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) + AGIรวม + 50 × Lv + 500) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Agi` = AGI สุดท้าย; `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.SkillRate` = ตัวคูณสกิล (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 4 ของ `skillRate`]: `(SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) + VITรวม + 25 × Lv + 750) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Vit` = VIT สุดท้าย; `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.SkillRate` = ตัวคูณสกิล (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `skillRate` · AGI รวม=100]: **(600 + 50×Lv)%** → 650%, 700%, 750%, 800%, 850%, 900%, 950%, 1000%, 1050%, 1100% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `skillRate` · AGI รวม=255]: **(755 + 50×Lv)%** → 805%, 855%, 905%, 955%, 1005%, 1055%, 1105%, 1155%, 1205%, 1255% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 3 ของ `skillRate`]: **(75×Lv)%** → 75%, 150%, 225%, 300%, 375%, 450%, 525%, 600%, 675%, 750% (Lv1…10)

**ใช้ร่วมทุกฮิตของ calcDamageHighRainSnipe**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **200** → 200, 200, 200, 200, 200, 200, 200, 200, 200, 200 (Lv1…10)

**จำนวนฮิต / ตัวนับ**
- `hitCount` (ตั้งใน `NextRangeHit`): `hitCount + 1`
<!-- calc:end -->

### แคมฟลาจ (Camouflage) · uid 559

<img src="../../icons/sk_559.png" width="40" alt="icon">

- ทรี: สกิลฮันเตอร์ (ขั้น 5) · เลเวลสูงสุด: 285 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: กับดักความมืด
- คลาสในโค้ด: `CamouflageAction` · สถานะการแกะ: แกะครบจากโค้ด

> ลดค่าเฮทลงอย่างมากขึ้นอยู่กับ MP ที่ใช้
> และเพิ่ม ATK กับอัตราคริติคอลเป็นเวลา 180 วินาที
> 
> ถ้าตกเป็นเป้าหมายระหว่างได้รับผลลัพธ์
> ผลของพรางตัวจะหายไปและหมดสติ(*)

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, พาสซีฟ
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `CamouflageBuf`: ATK + (`AtkUp`) = `2 × int(Lvรวม / 20 × Lv)` · ATK + (`AtkUp`) = `int(Lvรวม / 20 × Lv)` · อัตราคริ + (`CrtUp`) = `criticalUp // (EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData()) = 13 ? 2 : 1)`
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- พาสซีฟ อัตราคริ (`Crt`): 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 (Lv1…10)
- ตัวอ่านสกิลนี้ `MobaPlayerSecondaryStatus.GetCrtConstant` — MobaPlayerSecondaryStatus.GetCrtConstant: คืนค่า `_t1164` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.GetCrtConstant` — PlayerSecondaryStatus.GetCrtConstant: คืนค่า `_t1629` (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv255: (*)ถ้าไม่ได้อยู่ในปาร์ตี้จะไม่หมดสติ
- Lv12: *ครึ่งหนึ่งของ [ลดค่าเฮทตาม MP ที่ใช้] ของแคมฟลาจที่เรียนรู้ เป็นผลพาสซีฟที่ติดตัวเสมอแม้จะไม่ได้เปิดใช้งานสกิล  *เวลาหมดสติที่เกิดจากแคมฟลาจจะลดลงครึ่งหนึ่ง
- Lv13: *ครึ่งหนึ่งของ[เพิ่มอัตราคริติคอล] ของแคมฟลาจที่เรียนรู้ เป็นผลพาสซีฟที่ติดตัวเสมอแม้จะไม่ได้เปิดใช้งานสกิล  *เวลาหมดสติที่เกิดจากแคมฟลาจจะลดลงครึ่งหนึ่ง

### ความรู้ของนักล่า (HuntersKnowledge) · uid 560

<img src="../../icons/sk_560.png" width="40" alt="icon">

- ทรี: สกิลฮันเตอร์ (ขั้น 5) · เลเวลสูงสุด: 285 · อาวุธ: โบว์กัน · ต้องเรียนก่อน: [N]มัลติเพิลฮันท์[W]วูปสไนเปอร์[H]สไนเปอร์วอลเลย์[G]วันแฮนด์ช็อต[S]ชาร์ปชูตเตอร์[N]
- คลาสในโค้ด: `HuntersKnowledge` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่มพลังของสกิล[มัลติเพิลฮันท์]
> ที่เกี่ยวกับความรู้เรื่องอุปกรณ์ล่าสัตว์

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ตัวคูณสกิล (`SkillRate`): 25, 50, 75, 100, 125, 150, 175, 200, 225, 250 (Lv1…10)
- พาสซีฟ อัตราคริ (`Crt`): 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 (Lv1…10)

### โฟกัส (Focus) · uid 561

<img src="../../icons/sk_561.png" width="40" alt="icon">

- ทรี: สกิลฮันเตอร์ (ขั้น 5) · เลเวลสูงสุด: 285 · อาวุธ: ธนู, โบว์กัน · ต้องเรียนก่อน: แซทเทิลไลท์แอร์โรว์
- คลาสในโค้ด: `FocusAction` · สถานะการแกะ: แกะครบจากโค้ด

> ออกคำสั่งล่า
> หมายหัวศัตรูเป็นเป้าหมาย
> 
> เพิ่มพลังโจมตีระยะไกล
> ต่อเป้าหมายที่กำหนด(รวมสมาชิก PT)

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, บัพปาร์ตี้/ผู้อื่น
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `FocusBuf`: ดาเมจระยะไกล % (`LongRangeRate`) = `int(0.5 × debuf.Level + 0.5)` · ดาเมจระยะใกล้ % (`ShortRangeRate`) = `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 561, 1) ÷ 2`
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `FocusBuf..ctor` — .ctor (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv12: เป้าหมายจะถูกยิงเร็วขึ้นด้วยสกิล[แซทเทิลไลท์แอร์โรว์] และจะเล็งเป้าหมายใหม่ทุกครั้งที่โจมตี
- Lv13: หลังจากยิงเป้าหมายด้วย[แซทเทิลไลท์แอร์โรว์] ครั้งแรกไปแล้วจะยิงครั้งถัดไปได้เร็วขึ้น
- Lv18: [ได้รับผลแบบเดียวกันเมื่อใช้กับโล่]  *เพิ่ม “พลังโจมตีระยะใกล้กับเป้าหมาย” ด้วยผลของบัฟ (ตั้งแต่สกิลเลเวล 2)

