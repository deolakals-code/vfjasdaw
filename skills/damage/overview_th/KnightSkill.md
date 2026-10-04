# สกิลอัศวิน (15 สกิล)

สรุปโดยรวมต่อสกิล: ตัวคูณดาเมจมาจากไหน / แยกอาวุธ / สถานะระหว่างท่า / บัพ / เชื่อมสกิลอื่น. วิธีอ่าน: [ENGINE.md](ENGINE.md)

### แอสเซาต์แอคแทค (AssaultAttack) · uid 513
- ทรี: สกิลอัศวิน · เลเวลสูงสุด: 15 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [มือเปล่า + มือรองที่ไม่ใช่ โล่ | ดาบมือเดียว + มือรองที่ไม่ใช่ โล่ | ดาบสองมือ + มือรองที่ไม่ใช่ โล่ | ธนู + มือรองที่ไม่ใช่ โล่ | โบว์กัน + มือรองที่ไม่ใช่ โล่ | ไม้เท้า + มือรองที่ไม่ใช่ โล่ | อุปกรณ์เวท + มือรองที่ไม่ใช่ โล่ | สนับมือ + มือรองที่ไม่ใช่ โล่ | ทวน + มือรองที่ไม่ใช่ โล่ | คาตานะ + มือรองที่ไม่ใช่ โล่] `5 × Lv` → Lv1 5 · Lv5 25 · Lv10 50
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [มือเปล่า + มือรอง โล่ | ดาบมือเดียว + มือรอง โล่ | ดาบสองมือ + มือรอง โล่ | ธนู + มือรอง โล่ | โบว์กัน + มือรอง โล่ | ไม้เท้า + มือรอง โล่ | อุปกรณ์เวท + มือรอง โล่ | สนับมือ + มือรอง โล่ | ทวน + มือรอง โล่ | คาตานะ + มือรอง โล่] `5 × Lv + 50` → Lv1 55 · Lv5 75 · Lv10 100
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มือเปล่า + มือรองที่ไม่ใช่ โล่ | ดาบมือเดียว + มือรองที่ไม่ใช่ โล่ | ดาบสองมือ + มือรองที่ไม่ใช่ โล่ | ธนู + มือรองที่ไม่ใช่ โล่ | โบว์กัน + มือรองที่ไม่ใช่ โล่ | ไม้เท้า + มือรองที่ไม่ใช่ โล่ | อุปกรณ์เวท + มือรองที่ไม่ใช่ โล่ | สนับมือ + มือรองที่ไม่ใช่ โล่ | ทวน + มือรองที่ไม่ใช่ โล่ | คาตานะ + มือรองที่ไม่ใช่ โล่] `10 × Lv + โบนัสคริสตัล#1002[4] + 25 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `skillRate`: `(skillRate + KnightWill.GetParam(PlayerStatusBase.get_SkillManager().SkillMasteryList[520], BonusType.AssaultAttackSkillRate, (WeaponType eq 17 ? 1 : 0)))` เมื่อ Lv = 10 (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มือเปล่า + มือรอง โล่ | ดาบมือเดียว + มือรอง โล่ | ดาบสองมือ + มือรอง โล่ | ธนู + มือรอง โล่ | โบว์กัน + มือรอง โล่ | ไม้เท้า + มือรอง โล่ | อุปกรณ์เวท + มือรอง โล่ | สนับมือ + มือรอง โล่ | ทวน + มือรอง โล่ | คาตานะ + มือรอง โล่] `10 × Lv + โบนัสคริสตัล#1002[4] + 50 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `skillRate`: `(skillRate + KnightWill.GetParam(PlayerStatusBase.get_SkillManager().SkillMasteryList[520], BonusType.AssaultAttackSkillRate, (WeaponType eq 17 ? 1 : 0)))` เมื่อ Lv = 10 (+เงื่อนไขอื่น)
- สถานะผิดปกติที่ติดเป้า:
  - ช้า โอกาส = **0** คงที่ทุก Lv
  - กระเด็น โอกาส = **0** คงที่ทุก Lv

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### โพรโวค (Provoke) · uid 514
- ทรี: สกิลอัศวิน · เลเวลสูงสุด: 15 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### แพรี่ (Parry) · uid 515
- ทรี: สกิลอัศวิน · เลเวลสูงสุด: 35 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: โอกาสทำงาน % (`Trigger`) → Lv1 5 · Lv5 25 · Lv10 30 — Code
- พาสซีฟ/มาสเตอรี่: ลดดาเมจที่ได้รับ % (`CutDmgRate`) → Lv1 10 · Lv5 10 · Lv10 20 — Code
- ข้อความในเกม (คำอธิบาย): มีโอกาสลดความเสียหายทางกายภาพ — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### เรจซอร์ด (RageSword) · uid 516
- ทรี: สกิลอัศวิน · เลเวลสูงสุด: 35 · อาวุธที่ใช้ได้: ดาบมือเดียว, ดาบสองมือ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ VITรวม, อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [ดาบมือเดียว + มือรองที่ไม่ใช่ โล่ | ดาบสองมือ + มือรองที่ไม่ใช่ โล่] `5 × Lv + 50` → Lv1 55 · Lv5 75 · Lv10 100
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [ดาบมือเดียว + มือรอง โล่ | ดาบสองมือ + มือรอง โล่] `5 × Lv + 150` → Lv1 155 · Lv5 175 · Lv10 200
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว + มือรองที่ไม่ใช่ โล่ | ดาบสองมือ + มือรองที่ไม่ใช่ โล่] `10 × Lv + โบนัสคริสตัล#1019[4] + 150 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `skillRate`: `(skillRate + KnightWill.GetParam(PlayerStatusBase.get_SkillManager().SkillMasteryList[520], BonusType.RageSwordSkillRate, (WeaponType eq 17 ? 1 : 0)))` เมื่อ Lv = 10 (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `skillRate + โบนัสคริสตัล#1019[4]`
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว + มือรอง โล่ | ดาบสองมือ + มือรอง โล่] `10 × Lv + VITรวม ÷ 2 + โบนัสคริสตัล#1019[4] + 180 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `skillRate`: `(skillRate + KnightWill.GetParam(PlayerStatusBase.get_SkillManager().SkillMasteryList[520], BonusType.RageSwordSkillRate, (WeaponType eq 17 ? 1 : 0)))` เมื่อ Lv = 10 (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `skillRate + โบนัสคริสตัล#1019[4]`

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.CalcCostMp` (ContainsBuffer) — Skill MP cost — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.RemoveAfterSkillBuf` (ContainsBuffer) — Remove After Skill Buf — Code


---

### N$Pดีเฟนส์$F$เพอร์เฟกต์ดีเฟนส์ (P_Deffence) · uid 517
- ทรี: สกิลอัศวิน · เลเวลสูงสุด: 125 · อาวุธที่ใช้ได้: โล่

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobAttackBase.InvalidDamage` (ContainsBuffer) — Invalid Damage — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobAttackPlayerSelfDestruct.calcMobToPlayerDamage` (ContainsBuffer) — calculate mob to player damage — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.Damaged` (ContainsBuffer) — MobaPlayerActionManager: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.ReceiveDamaged` (ContainsBuffer) — Receive Damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.Damaged` (ContainsBuffer) — PlayerActionManager: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.RemoveAfterSkillBuf` (ContainsBuffer) — Remove After Skill Buf — Code


---

### ไบด์สไตร์ค (BindStrike) · uid 518
- ทรี: สกิลอัศวิน · เลเวลสูงสุด: 125 · อาวุธที่ใช้ได้: ดาบมือเดียว, ดาบสองมือ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ VITรวม, อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [ดาบมือเดียว + มือรองที่ไม่ใช่ โล่ | ดาบสองมือ + มือรองที่ไม่ใช่ โล่] `10 × Lv + 50` → Lv1 60 · Lv5 100 · Lv10 150
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [ดาบมือเดียว + มือรอง โล่ | ดาบสองมือ + มือรอง โล่] `10 × Lv + 200` → Lv1 210 · Lv5 250 · Lv10 300
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว + มือรองที่ไม่ใช่ โล่ | ดาบสองมือ + มือรองที่ไม่ใช่ โล่] `5 × Lv + VITรวม + 450 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ isEquipShield ≠ 0 (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `(skillRate + KnightWill.GetParam(PlayerStatusBase.get_SkillManager().SkillMasteryList[520], BonusType.BindStrikeSkillRate, (EquipItemData.WeaponTypeCalculatorBase.get_…(ย่อ)` เมื่อ Lv = 10 (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว + มือรอง โล่ | ดาบสองมือ + มือรอง โล่] `5 × Lv + 2 × VITรวม + 600 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ isEquipShield ≠ 0 (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `(skillRate + KnightWill.GetParam(PlayerStatusBase.get_SkillManager().SkillMasteryList[520], BonusType.BindStrikeSkillRate, (EquipItemData.WeaponTypeCalculatorBase.get_…(ย่อ)` เมื่อ Lv = 10 (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว + มือรองที่ไม่ใช่ โล่ | ดาบสองมือ + มือรองที่ไม่ใช่ โล่] `5 × Lv + 450 %` → Lv1 455% · Lv5 475% · Lv10 500% — เมื่อ isEquipShield = 0 หรือ isEquipShield ≠ 0 (+เงื่อนไขอื่น) หรือ isEquipShield = 0 (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `(skillRate + KnightWill.GetParam(PlayerStatusBase.get_SkillManager().SkillMasteryList[520], BonusType.BindStrikeSkillRate, (EquipItemData.WeaponTypeCalculatorBase.get_…(ย่อ)` เมื่อ Lv = 10 (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว + มือรอง โล่ | ดาบสองมือ + มือรอง โล่] `5 × Lv + VITรวม + 600 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ isEquipShield = 0 หรือ isEquipShield ≠ 0 (+เงื่อนไขอื่น) หรือ isEquipShield = 0 (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `(skillRate + KnightWill.GetParam(PlayerStatusBase.get_SkillManager().SkillMasteryList[520], BonusType.BindStrikeSkillRate, (EquipItemData.WeaponTypeCalculatorBase.get_…(ย่อ)` เมื่อ Lv = 10 (+เงื่อนไขอื่น)
- สถานะผิดปกติที่ติดเป้า:
  - สตัน โอกาส `10 × Lv` → Lv1 10 · Lv5 50 · Lv10 100
  - หยุดนิ่ง โอกาส `10 × Lv` → Lv1 10 · Lv5 50 · Lv10 100

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ฟาเรส (Fearless) · uid 519
- ทรี: สกิลอัศวิน · เลเวลสูงสุด: 205 · อาวุธที่ใช้ได้: โล่

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - (`MobLastDamageRate*` เข้าสูตรดาเมจที่มอนทำใส่ผู้เล่นใน `MobAttackBase.CalcLastDamage` — ค่านี้คือส่วนลดดาเมจที่ได้รับ; หน่วยและการรวมกับบัพอื่นยังไม่ยืนยัน — Inferred)
  - ตัวคูณดาเมจที่ได้รับจากมอน (หมวดบัพ) (`MobLastDamageRateBuf`) = `int(baseRateDmgDownRate × Count)` — เมื่อ (+เงื่อนไขอื่น)
- ข้อความในเกม (คำอธิบาย): อัตราส่วนการลดความเสียหาย — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- เจาะกายภาพ (`PowerResistBreaker`) = `Count × baseResist` — เมื่อ (+เงื่อนไขอื่น)
- ตัวคูณตีปกติ % (`NormalAttackRate`) = `Count × baseNormalAtkUpRate` — เมื่อ (+เงื่อนไขอื่น)
- ความเร็วโจมตี + (`Aspd`) = `Count × baseAspdUp` — เมื่อ (+เงื่อนไขอื่น)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย เอเลียสลีย์ (uid 659) ผ่าน `ArialSlayAction.ActionStart` (ContainsBuffer) — ArialSlayAction: skill start — Code


---

### ไนท์วีล (KnightWill) · uid 520
- ทรี: สกิลอัศวิน · เลเวลสูงสุด: 205 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `CallGolemNormalAttackAction.ActionPreparation` (GetSkillLv) — CallGolemNormalAttackAction: preparation — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `HuntingOneNormalAttackAction.ActionPreparation` (GetSkillLv) — HuntingOneNormalAttackAction: preparation — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.ActionPreparation` (GetSkillLv) — PlayerAttackBase: preparation — Code
- ถูกอ่านโดย วอร์คราย (uid 43) ผ่าน `WarCryAction.ActionPreparation` (GetSkillLv) — WarCryAction: preparation — Code


---

### ไนท์สแตนซ์ (KnightStance) · uid 521
- ทรี: สกิลอัศวิน · เลเวลสูงสุด: 15 · อาวุธที่ใช้ได้: ดาบมือเดียว

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: ไนท์ฮีล (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - RateDamageResist (`RateDamageResist`) = `(damageResist << (EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator) eq 17 ? 1 : 0))`
- ข้อความในเกม (Lv17): ระหว่างใช้[วอร์คราย]จะเพิ่มความต้านทานหวาดกลัว — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: `MobAttackBase.CalcLastDamage`, `MobAttackBase.SetAbnormalEffect`, `MobaPlayerActionManager.ReceiveDamaged`, `MobaPlayerSecondaryStatus.get_Vit`, `PlayerActionManager.DamagedKnightHeal` — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ความเกลียดชัง % (`HateRate`) = `hateRate + Lv` — เมื่อ (+เงื่อนไขอื่น)
- ความเกลียดชัง % (`HateRate`) = `hateRate` — เมื่อ (+เงื่อนไขอื่น)
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `stack`
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล ไนท์ฮีล (uid 524): `KnightStanceAction.ActionHit` (GetSkillLv) — Action Hit — Code
- ถูกอ่านโดย ไนท์ฮีล (uid 524) ผ่าน `KnightHeal.Damaged` (ContainsBuffer) — KnightHeal: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobAttackBase.CalcLastDamage` (TryGetBuf) — calculate last damage — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobAttackBase.SetAbnormalEffect` (TryGetBuf) — Set Abnormal Effect — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.ReceiveDamaged` (TryGetBuf) — Receive Damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerSecondaryStatus.get_Vit` (TryGetBuf) — Vit of MobaPlayerSecondaryStatus — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PhotonListener.OnActionMobAttack` (TryGetBuf) — On Action Mob Attack — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.DamagedKnightHeal` (ContainsBuffer) — Damaged Knight Heal — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.GetDisplayBonusCalcHate` (TryGetBuf) — Get Display Bonus Calc Hate — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.get_Vit` (TryGetBuf) — Vit of PlayerSecondaryStatus — Code


---

### โซนิคทรัสต์ (SonicThrust) · uid 522
- ทรี: สกิลอัศวิน · เลเวลสูงสุด: 35 · อาวุธที่ใช้ได้: ดาบมือเดียว
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ DEXรวม, อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **200** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว + มือรองที่ไม่ใช่ โล่] `15 × Lv + 150 %` → Lv1 165% · Lv5 225% · Lv10 300%
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว + มือรอง โล่] `15 × Lv + DEXรวม + 150 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- สถานะผิดปกติที่ติดเป้า:
  - ล้มคว่ำ โอกาส `10 × Lv` → Lv1 10 · Lv5 50 · Lv10 100

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (Lv17): ถ้าผลของล้มคว่ำถูกป้องกันเนื่องจากเวลาต้านทาน จะฟื้นพู MP ขึ้นมาเล็กน้อย — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### เรเวอเนีย (Levenir) · uid 523
- ทรี: สกิลอัศวิน · เลเวลสูงสุด: 125 · อาวุธที่ใช้ได้: ดาบมือเดียว
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (never (IsExpDefFluctuate=false))

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ DEX(ที่ลงเอง)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `40 × Lv` → Lv1 40 · Lv5 200 · Lv10 400 — เมื่อ maxAttackCount ≥ 1 (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `10 × Lv + 2 × DEX(ที่ลงเอง) + 500 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ maxAttackCount ≥ 1 (+เงื่อนไขอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.Damaged` (GetSkillLv) — PlayerActionManager: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.Damaged` (TryGetBuf) — PlayerActionManager: on damaged — Code


---

### ไนท์ฮีล (KnightHeal) · uid 524
- ทรี: สกิลอัศวิน · เลเวลสูงสุด: 205 · อาวุธที่ใช้ได้: ดาบมือเดียว

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ค่าเปอร์เซ็นต์ (`Percent`) → Lv1 1 · Lv5 5 · Lv10 10 — Code

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล ไนท์สแตนซ์ (uid 521): `KnightHeal.Damaged` (ContainsBuffer) — KnightHeal: on damaged — Code
- ถูกอ่านโดย ไนท์สแตนซ์ (uid 521) ผ่าน `KnightStanceAction.ActionHit` (GetSkillLv) — Action Hit — Code


---

### อาฟเตอร์ชีลด์ (AfterShield) · uid 525
- ทรี: สกิลอัศวิน · เลเวลสูงสุด: 285 · อาวุธที่ใช้ได้: ดาบมือเดียว

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - (`MobLastDamageRate*` เข้าสูตรดาเมจที่มอนทำใส่ผู้เล่นใน `MobAttackBase.CalcLastDamage` — ค่านี้คือส่วนลดดาเมจที่ได้รับ; หน่วยและการรวมกับบัพอื่นยังไม่ยืนยัน — Inferred)
  - ตัวคูณดาเมจที่ได้รับจากมอน (หมวดบัพ) (`MobLastDamageRateBuf`) = `5 × int(LeftTime)` — เมื่อ IsCooltime = 0
- พาสซีฟ/มาสเตอรี่: NormalResist (`NormalResist`) → Lv1 1 · Lv5 5 · Lv10 10 — Code
- ข้อความในเกม (คำอธิบาย): จะลดความเสียหายลงได้ช่วงเวลาหนึ่ง — Text
- ข้อความในเกม (คำอธิบาย): และถ้าเรียนรู้จะเพิ่มต้านทานไร้ธาตุเล็กน้อยแบบถาวร — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: `MobAttackBase.CalcLastDamage` — Inferred

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobAttackBase.CalcLastDamage` (TryGetBuf) — calculate last damage — Code


---

### บลิงค์ซอร์ด (BlinkSword) · uid 526
- ทรี: สกิลอัศวิน · เลเวลสูงสุด: 285 · อาวุธที่ใช้ได้: ดาบมือเดียว
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ VIT(ที่ลงเอง)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **200** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `75 × Lv + VIT(ที่ลงเอง) + 500 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ isEquipShield ≠ 0 (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `skillRate + VIT(ที่ลงเอง)` เมื่อ isEquipShield ≠ 0 (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `75 × Lv + 500 %` → Lv1 575% · Lv5 875% · Lv10 1250% — เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `skillRate + VIT(ที่ลงเอง)` เมื่อ isEquipShield ≠ 0 (+เงื่อนไขอื่น)
- สถานะผิดปกติที่ติดเป้า:
  - ผงะ โอกาส `int(4.5 × Lv) + 5` → Lv1 9 · Lv5 27 · Lv10 50

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - RateDamageResist (`RateDamageResist`) = `rateDamageResist`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobAttackBase.CalcLastDamage` (TryGetBuf) — calculate last damage — Code


---

### ไนท์เพลดจ์ (KnightPledge) · uid 527
- ทรี: สกิลอัศวิน · เลเวลสูงสุด: 285 · อาวุธที่ใช้ได้: ดาบมือเดียว

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - (`MobLastDamageRate*` เข้าสูตรดาเมจที่มอนทำใส่ผู้เล่นใน `MobAttackBase.CalcLastDamage` — ค่านี้คือส่วนลดดาเมจที่ได้รับ; หน่วยและการรวมกับบัพอื่นยังไม่ยืนยัน — Inferred)
  - KnockbackDistReduceRate (`KnockbackDistReduceRate`) = `knockbackDistReduceRate` — เมื่อ isEffective ≠ 0
  - MobLastDamageRateUnique (`MobLastDamageRateUnique`) = `totalReduceValue ÷ effectiveNum` — เมื่อ isEffective ≠ 0
- ข้อความในเกม (คำอธิบาย): เพิ่มพลังโจมตีภายในพื้นที่และเพิ่มต้านทานความเสียหาย — Text
- ข้อความในเกม (Lv10): หากลดความเสียหายจากการโจมตีแบบผลักกระเด็นในพื้นที่ — Text
- ข้อความในเกม (Lv10): พลังโจมตีจะเพิ่มขึ้น ความเสียหายจะลดลง — Text
- ข้อความในเกม (Lv17): ความต้านทานผลักกระเด็นเพิ่มขึ้นอีก — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: `MobAttackBase.CalcLastDamage` — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv
- ค่าทั่วไปตัวที่ 2 (`Value2`) = `effectiveNum` — เมื่อ isEffective ≠ 0
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `selfBufData.totalReduceValue`
- ตัวคูณดาเมจสุดท้าย (ทศนิยม) (`LastDamageRateDecimal`) = `100 × lastDamageRate ÷ effectiveNum` — เมื่อ isEffective ≠ 0

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobAttackBase.CalcLastDamage` (TryGetBuf) — calculate last damage — Code


---
