# สกิลยิง (25 สกิล)

สรุปโดยรวมต่อสกิล: ตัวคูณดาเมจมาจากไหน / แยกอาวุธ / สถานะระหว่างท่า / บัพ / เชื่อมสกิลอื่น. วิธีอ่าน: [ENGINE.md](ENGINE.md)

### พาวเวอร์ชู้ต (PowerShoot) · uid 65
- ทรี: สกิลยิง · เลเวลสูงสุด: 10 · อาวุธที่ใช้ได้: ธนู, โบว์กัน, ลูกธนู
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `8 × Lv + 50` → Lv1 58 · Lv5 90 · Lv10 130
  - ตัวคูณสกิล (`SkillRate`, AddRate) `5 × Lv + โบนัสคริสตัล#103[4] + 125 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `skillRate + โบนัสคริสตัล#103[4]` เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `5 × Lv + 125 %` → Lv1 130% · Lv5 150% · Lv10 175% — เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `skillRate + โบนัสคริสตัล#103[4]` เมื่อ (+เงื่อนไขอื่น)
- สถานะผิดปกติที่ติดเป้า:
  - ล้มคว่ำ [ธนู] โอกาส `3 × Lv + 60` → Lv1 63 · Lv5 75 · Lv10 90
  - ล้มคว่ำ [โบว์กัน] โอกาส `3 × Lv - 20` → Lv1 -17 · Lv5 -5 · Lv10 10
  - ล้มคว่ำ [ลูกธนู] โอกาส `3 × Lv + 20` → Lv1 23 · Lv5 35 · Lv10 50

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### บูลส์อาย (OneWheel) · uid 66
- ทรี: สกิลยิง · เลเวลสูงสุด: 10 · อาวุธที่ใช้ได้: ธนู, โบว์กัน, ลูกธนู
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `4 × Lv + 30` → Lv1 34 · Lv5 50 · Lv10 70 — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ธนู] [`5 × Lv + โบนัสคริสตัล#104[4] + 50 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ difBreakPercent.Length > 2 และ difBreakPercent.Length ≠ 0 และ difBreakPercent.Length ≠ 1] หรือ [`5 × Lv + โบนัสคริสตัล#104[4] + 25 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ difBreakPercent.Length = 0] — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [โบว์กัน] `5 × Lv + โบนัสคริสตัล#104[4] + 25 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ลูกธนู] `5 × Lv + โบนัสคริสตัล#104[4] + 25 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### มีบาช็อต (MeebaShot) · uid 67
- ทรี: สกิลยิง · เลเวลสูงสุด: 10 · อาวุธที่ใช้ได้: ธนู, โบว์กัน, ลูกธนู
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ DEX(ที่ลงเอง), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `5 × Lv + 50` → Lv1 55 · Lv5 75 · Lv10 100
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ธนู + มือรอง ลูกธนู | ลูกธนู + มือรอง ลูกธนู] `5 × Lv + 100 %` → Lv1 105% · Lv5 125% · Lv10 150%
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ธนู + มือรองที่ไม่ใช่ ลูกธนู | โบว์กัน + มือรองที่ไม่ใช่ ลูกธนู | ลูกธนู + มือรองที่ไม่ใช่ ลูกธนู] `skillRate %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [โบว์กัน + มือรอง ลูกธนู] `5 × Lv + 150 %` → Lv1 155% · Lv5 175% · Lv10 200%
  - ตัวคูณสกิล (`SkillRate`, AddRate) `DEX(ที่ลงเอง) + 50 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
- สถานะผิดปกติที่ติดเป้า:
  - ช้า [ธนู + มือรอง ลูกธนู] โอกาส `2 × Lv + 80` → Lv1 82 · Lv5 90 · Lv10 100
  - ช้า [ธนู + มือรองที่ไม่ใช่ ลูกธนู | โบว์กัน + มือรองที่ไม่ใช่ ลูกธนู] โอกาส `slowPercent` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ช้า [โบว์กัน + มือรอง ลูกธนู] โอกาส `2 × Lv + 20` → Lv1 22 · Lv5 30 · Lv10 40
  - ช้า [ลูกธนู] โอกาส `2 × Lv + 50` → Lv1 52 · Lv5 60 · Lv10 70

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `HuntingOneNormalAttackAction.calcPlayerToMobDamage` (GetSkillLv) — HuntingOneNormalAttackAction: player→mob damage template — Code


---

### ชู้ตมาสเตอรี่ (ShootMastary) · uid 68
- ทรี: สกิลยิง · เลเวลสูงสุด: 10 · อาวุธที่ใช้ได้: ธนู, โบว์กัน

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ATK อาวุธ % (`EqAtkRate`) → Lv1 3 · Lv5 15 · Lv10 30 — Code
- พาสซีฟ/มาสเตอรี่: ATK % (`AtkRate`) → Lv1 1 · Lv5 1 · Lv10 2 — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### สเนคแอคแทค (HideAttack) · uid 69
- ทรี: สกิลยิง · เลเวลสูงสุด: 10 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ควิกโหลดเดอร์ (uid 85) ผ่าน `QuickLoaderAction.ActionHit` (GetSkillLv) — Action Hit — Code


---

### แอร์โรว์เรน (ArrowRain) · uid 70
- ทรี: สกิลยิง · เลเวลสูงสุด: 30 · อาวุธที่ใช้ได้: ธนู, โบว์กัน, ลูกธนู
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `10 × int(0.5 × Lv) + 50` → Lv1 50 · Lv5 70 · Lv10 100
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ธนู | ลูกธนู] [`5 × int(0.5 × Lv) + 105 %` → Lv1 105% · Lv5 115% · Lv10 130% — เมื่อ Lv ≥ 2] หรือ [= **100%** คงที่ทุก Lv — เมื่อ Lv < 2]
  - ตัวคูณสกิล (`SkillRate`, AddRate) [โบว์กัน] [`5 × int(0.5 × Lv) + 175 %` → Lv1 175% · Lv5 185% · Lv10 200% — เมื่อ Lv ≥ 2] หรือ [= **170%** คงที่ทุก Lv — เมื่อ Lv < 2]
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(proration ที่เก็บไว้ตอนร่าย[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### พาราไลซิสช็อต (ParalysisShot) · uid 71
- ทรี: สกิลยิง · เลเวลสูงสุด: 30 · อาวุธที่ใช้ได้: ธนู, โบว์กัน, ลูกธนู
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ DEX(ที่ลงเอง), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `20 × Lv + 100` → Lv1 120 · Lv5 200 · Lv10 300
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ธนู + มือรอง ลูกธนู] `5 × Lv + 210 %` → Lv1 215% · Lv5 235% · Lv10 260%
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ธนู + มือรองที่ไม่ใช่ ลูกธนู | โบว์กัน + มือรองที่ไม่ใช่ ลูกธนู | ลูกธนู + มือรองที่ไม่ใช่ ลูกธนู] `skillRate %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [โบว์กัน + มือรอง ลูกธนู] `5 × Lv + 260 %` → Lv1 265% · Lv5 285% · Lv10 310%
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ลูกธนู + มือรอง ลูกธนู] `5 × Lv + 110 %` → Lv1 115% · Lv5 135% · Lv10 160%
  - ตัวคูณสกิล (`SkillRate`, AddRate) `DEX(ที่ลงเอง) + 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
- สถานะผิดปกติที่ติดเป้า:
  - อัมพาต [ธนู + มือรอง ลูกธนู] โอกาส `2 × Lv + 90` → Lv1 92 · Lv5 100 · Lv10 110
  - อัมพาต [ธนู + มือรองที่ไม่ใช่ ลูกธนู | ลูกธนู + มือรอง ลูกธนู] โอกาส `2 × Lv + 70` → Lv1 72 · Lv5 80 · Lv10 90
  - อัมพาต [โบว์กัน + มือรอง ลูกธนู | ลูกธนู + มือรองที่ไม่ใช่ ลูกธนู] โอกาส `2 × Lv + 50` → Lv1 52 · Lv5 60 · Lv10 70
  - อัมพาต [โบว์กัน + มือรองที่ไม่ใช่ ลูกธนู] โอกาส `2 × Lv + 30` → Lv1 32 · Lv5 40 · Lv10 50

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ความเสถียร (`Stable`) `Lv` → Lv1 1 · Lv5 5 · Lv10 10

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `HuntingOneNormalAttackAction.calcPlayerToMobDamage` (GetSkillLv) — HuntingOneNormalAttackAction: player→mob damage template — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.ReceiveAttack` (GetSkillLv) — Receive Attack — Code


---

### ลองเรนจ์ (LongRangeMastary) · uid 72
- ทรี: สกิลยิง · เลเวลสูงสุด: 30 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ดาเมจสุดท้าย % (`LastDmgRate`) → Lv1 1 · Lv5 5 · Lv10 10 — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### สไนป์ (Sniping) · uid 73
- ทรี: สกิลยิง · เลเวลสูงสุด: 70 · อาวุธที่ใช้ได้: ธนู, โบว์กัน, ลูกธนู
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `10 × Lv + 300` → Lv1 310 · Lv5 350 · Lv10 400
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ธนู] `10 × Lv + 900 %` → Lv1 910% · Lv5 950% · Lv10 1000%
  - ตัวคูณสกิล (`SkillRate`, AddRate) [โบว์กัน] `10 × Lv + 1000 %` → Lv1 1010% · Lv5 1050% · Lv10 1100%
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ลูกธนู] `10 × Lv + 700 %` → Lv1 710% · Lv5 750% · Lv10 800%
- สถานะผิดปกติที่ติดเป้า:
  - เกราะแตก [ธนู] โอกาส `2 × Lv + 80` → Lv1 82 · Lv5 90 · Lv10 100
  - เกราะแตก [โบว์กัน] โอกาส `2 × Lv - 10` → Lv1 -8 · Lv5 0 · Lv10 10
  - เกราะแตก [ลูกธนู] โอกาส `2 × Lv + 50` → Lv1 52 · Lv5 60 · Lv10 70

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- อัตราคริ + (`CrtUp`) = `-critical`
- ความเสถียร (`Stable`) = `stable`

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### สโมคดัส (SmokeDust) · uid 74
- ทรี: สกิลยิง · เลเวลสูงสุด: 70 · อาวุธที่ใช้ได้: ธนู, โบว์กัน, ลูกธนู
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ DEX(ที่ลงเอง), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `30 × Lv + 200` → Lv1 230 · Lv5 350 · Lv10 500
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ธนู + มือรอง ลูกธนู] `5 × Lv + 320 %` → Lv1 325% · Lv5 345% · Lv10 370%
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ธนู + มือรองที่ไม่ใช่ ลูกธนู | โบว์กัน + มือรองที่ไม่ใช่ ลูกธนู | ลูกธนู + มือรองที่ไม่ใช่ ลูกธนู] `skillRate %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [โบว์กัน + มือรอง ลูกธนู] `5 × Lv + 370 %` → Lv1 375% · Lv5 395% · Lv10 420%
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ลูกธนู + มือรอง ลูกธนู] `5 × Lv + 120 %` → Lv1 125% · Lv5 145% · Lv10 170%
  - ตัวคูณสกิล (`SkillRate`, AddRate) `DEX(ที่ลงเอง) + 200 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
- สถานะผิดปกติที่ติดเป้า:
  - ตาบอด [ธนู + มือรอง ลูกธนู] โอกาส `2 × Lv + 90` → Lv1 92 · Lv5 100 · Lv10 110
  - ตาบอด [ธนู + มือรองที่ไม่ใช่ ลูกธนู | ลูกธนู + มือรอง ลูกธนู] โอกาส `2 × Lv + 70` → Lv1 72 · Lv5 80 · Lv10 90
  - ตาบอด [โบว์กัน + มือรอง ลูกธนู | ลูกธนู + มือรองที่ไม่ใช่ ลูกธนู] โอกาส `2 × Lv + 50` → Lv1 52 · Lv5 60 · Lv10 70
  - ตาบอด [โบว์กัน + มือรองที่ไม่ใช่ ลูกธนู] โอกาส `2 × Lv + 30` → Lv1 32 · Lv5 40 · Lv10 50

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ความแม่น + (`HitUp`) `int(0.5 × Lv × Lv) + 5 × Lv` → Lv1 5 · Lv5 37 · Lv10 100

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `HuntingOneNormalAttackAction.calcPlayerToMobDamage` (GetSkillLv) — HuntingOneNormalAttackAction: player→mob damage template — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.ReceiveAttack` (GetSkillLv) — Receive Attack — Code


---

### ควิกดรอ (QuickDraw) · uid 75
- ทรี: สกิลยิง · เลเวลสูงสุด: 70 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: โอกาสทำงาน % (`Trigger`) → Lv1 3 · Lv5 15 · Lv10 30 — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ครอสสเฟียร์ (CrossFire) · uid 76
- ทรี: สกิลยิง · เลเวลสูงสุด: 150 · อาวุธที่ใช้ได้: ธนู, โบว์กัน
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ DEX(ที่ลงเอง), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก** — type = 0 และ type ≠ 1 และ type ≠ 2
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `10 × Lv + 300` → Lv1 310 · Lv5 350 · Lv10 400
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ธนู] [`(50 × Lv + DEX(ที่ลงเอง) ÷ 5 + 450) × SkillBufferDataBase.GetParam(50) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`(50 × Lv + DEX(ที่ลงเอง) ÷ 5 + 450) × SkillBufferDataBase.GetParam(50) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`(50 × Lv + DEX(ที่ลงเอง) ÷ 5 + 450) × (SkillBufferDataBase.GetParam(50) + 1) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ chargeLevel < maxChargeLevel (+เงื่อนไขอื่น); (+เงื่อนไขอื่น)] หรือ [`(50 × Lv + DEX(ที่ลงเอง) ÷ 5 + 450) × (SkillIndividualFlag + 1) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ chargeLevel < maxChargeLevel (+เงื่อนไขอื่น)] หรือ [`(50 × Lv + DEX(ที่ลงเอง) ÷ 5 + 450) × SkillBufferDataBase.GetParam(50) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`(50 × Lv + DEX(ที่ลงเอง) ÷ 5 + 450) × SkillIndividualFlag %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]
    - ตัวปรับ `chargeLevel`: `chargeLevel + 1` เมื่อ chargeLevel < maxChargeLevel (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [โบว์กัน] [`(50 × Lv + 400) × SkillBufferDataBase.GetParam(50) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`(50 × Lv + 400) × SkillBufferDataBase.GetParam(50) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`(50 × Lv + 400) × (SkillBufferDataBase.GetParam(50) + 1) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ chargeLevel < maxChargeLevel (+เงื่อนไขอื่น); (+เงื่อนไขอื่น)] หรือ [`(50 × Lv + 400) × (SkillIndividualFlag + 1) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ chargeLevel < maxChargeLevel (+เงื่อนไขอื่น)] หรือ [`(50 × Lv + 400) × SkillBufferDataBase.GetParam(50) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`(50 × Lv + 400) × SkillIndividualFlag %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]
    - ตัวปรับ `chargeLevel`: `chargeLevel + 1` เมื่อ chargeLevel < maxChargeLevel (+เงื่อนไขอื่น)
- **ดาเมจหลัก** — type ≠ 2
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(proration ที่เก็บไว้ตอนร่าย[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ดาเมจหลัก** — type ≠ 0 และ type ≠ 1 และ type ≠ 2
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **0** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) = **0%** คงที่ทุก Lv
- **ดาเมจหลัก** — type = 1 และ type ≠ 2
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `10 × Lv + 300` → Lv1 310 · Lv5 350 · Lv10 400
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ธนู] = **200%** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) [โบว์กัน] = **300%** คงที่ทุก Lv
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: เดคอยชูตเตอร์ (Skill)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `chargeLevel`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.GetSkillTargetType` (ContainsBuffer) — Get Skill Target Type — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.GetSkillTargetType` (ContainsBuffer) — Get Skill Target Type — Code


---

### อาร์มเบรค (ArmBreak) · uid 77
- ทรี: สกิลยิง · เลเวลสูงสุด: 150 · อาวุธที่ใช้ได้: ธนู, โบว์กัน, ลูกธนู
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ DEX(ที่ลงเอง), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `40 × Lv + 300` → Lv1 340 · Lv5 500 · Lv10 700
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ธนู + มือรอง ลูกธนู] `5 × Lv + 430 %` → Lv1 435% · Lv5 455% · Lv10 480%
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ธนู + มือรองที่ไม่ใช่ ลูกธนู | โบว์กัน + มือรองที่ไม่ใช่ ลูกธนู | ลูกธนู + มือรองที่ไม่ใช่ ลูกธนู] `skillRate %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [โบว์กัน + มือรอง ลูกธนู] `5 × Lv + 480 %` → Lv1 485% · Lv5 505% · Lv10 530%
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ลูกธนู + มือรอง ลูกธนู] `5 × Lv + 130 %` → Lv1 135% · Lv5 155% · Lv10 180%
  - ตัวคูณสกิล (`SkillRate`, AddRate) `DEX(ที่ลงเอง) + 300 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
- สถานะผิดปกติที่ติดเป้า:
  - อ่อนแอ [ธนู + มือรอง ลูกธนู] โอกาส `2 × Lv + 90` → Lv1 92 · Lv5 100 · Lv10 110
  - อ่อนแอ [ธนู + มือรองที่ไม่ใช่ ลูกธนู | ลูกธนู + มือรอง ลูกธนู] โอกาส `2 × Lv + 70` → Lv1 72 · Lv5 80 · Lv10 90
  - อ่อนแอ [โบว์กัน + มือรอง ลูกธนู | ลูกธนู + มือรองที่ไม่ใช่ ลูกธนู] โอกาส `2 × Lv + 50` → Lv1 52 · Lv5 60 · Lv10 70
  - อ่อนแอ [โบว์กัน + มือรองที่ไม่ใช่ ลูกธนู] โอกาส `2 × Lv + 30` → Lv1 32 · Lv5 40 · Lv10 50

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `HuntingOneNormalAttackAction.calcPlayerToMobDamage` (GetSkillLv) — HuntingOneNormalAttackAction: player→mob damage template — Code


---

### เดคอยชูตเตอร์ (DecoyShooter) · uid 78
- ทรี: สกิลยิง · เลเวลสูงสุด: 150 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: ไม่มีประเภท (None) · Proration: none (never (ExpType None: no proration slot))

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก** — isFirst = 0
  - ตัวคูณสกิล (`SkillRate`, AddRate) `โบนัสคริสตัล#402[4] + int(GemCartBufferManager.GetNormalAttackRate(PlayerStatusBase.get_GemCartBuffManager())) + 8 × Lv + 20 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefNormal / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerBattleManager.StartDetectionDecoyShooter` (GetSkillLv) — Start Detection Decoy Shooter — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.StartDetectionDecoyShooter` (GetSkillLv) — Start Detection Decoy Shooter — Code


---

### เดสทอลก์ช็อต (DeathTorqueShot) · uid 79
- ทรี: สกิลยิง · เลเวลสูงสุด: 70 · อาวุธที่ใช้ได้: ธนู, โบว์กัน
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ DEXรวม/STRรวม, อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **200** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ธนู] `10 × Lv + (DEXรวม + STRรวม) ÷ 2 + 500 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [โบว์กัน] `10 × Lv + DEXรวม + 500 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (คำอธิบาย): เทคนิคการยิงที่เจาะเกราะที่แข็งแกร่ง — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ความแม่น % (`HitRate`) = `-hitRate`
- อัตราคริ + (`CrtUp`) = `critical`

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### รีโทรเกรดชอท (JumpbackShot) · uid 80
- ทรี: สกิลยิง · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: ธนู
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ DEX(ที่ลงเอง)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **300** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `50 × Lv + DEX(ที่ลงเอง) + 500 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (Lv12): ลดอัตราหลบหลีกของเป้าหมายที่ถูกหมายหัว — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: `MobaPlayerBattleManager.PursuitJumpbackShotAttack`, `MobaPlayerBattleManager.PursuitJumpbackShotAttack`, `PlayerBattleManager.PursuitJumpbackShotAttack`, `PlayerBattleManager.PursuitJumpbackShotAttack` — Inferred

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerBattleManager.PursuitJumpbackShotAttack` (GetSkillLv) — Pursuit Jumpback Shot Attack — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerBattleManager.PursuitJumpbackShotAttack` (TryGetBuf) — Pursuit Jumpback Shot Attack — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.PursuitJumpbackShotAttack` (GetSkillLv) — Pursuit Jumpback Shot Attack — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.PursuitJumpbackShotAttack` (TryGetBuf) — Pursuit Jumpback Shot Attack — Code


---

### พาราโบลาแคนนอน (ParabolaCannon) · uid 81
- ทรี: สกิลยิง · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: ธนู, โบว์กัน, ลูกธนู
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ DEX(ที่ลงเอง)/DEXรวม
- **ดาเมจหลัก** — state ≠ 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **400** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `25 × Lv + DEX(ที่ลงเอง) + 1000 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ดาเมจหลัก** — state = 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `40 × Lv` → Lv1 40 · Lv5 200 · Lv10 400
  - ตัวคูณสกิล (`SkillRate`, AddRate) `25 × Lv + DEXรวม + 750 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- สถานะผิดปกติที่ติดเป้า:
  - ใบ้ โอกาส `state = 0 ? int(2.5 × Lv) : 4 × int(2.5 × Lv)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ทวินสตอร์ม (TwinStorm) · uid 82
- ทรี: สกิลยิง · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: โบว์กัน

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ตัวคูณตีปกติ % (`NormalAttackRate`) = `normalAttackRate` — เมื่อ isTwinStorm ≠ 0
- MoveSpeed (`MoveSpeed`) = `moveSpeed` — เมื่อ isTwinStorm ≠ 0
- ดาเมจคงที่ตีปกติ (`NormalAttackConstantDamage`) = `normalAttackConstant` — เมื่อ isTwinStorm ≠ 0
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `updateNextAttackCount`
- ความเสถียร (`Stable`) = `effectiveStable`
- ความเร็วโจมตี + (`Aspd`) = `aspd` — เมื่อ isTwinStorm ≠ 0
- ดาเมจสุดท้ายที่ทำ % (`LastDmgUpRate`) = `effectiveLastDamageRate`
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.get_MoveSpeed` (TryGetBuf) — Move Speed of MobaPlayerActionManager — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `NormalAttackAction.Damaged` (TryGetBuf) — NormalAttackAction: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `NormalAttackAction.OnInitialize` (TryGetBuf) — NormalAttackAction: initial values — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.get_MoveSpeed` (TryGetBuf) — Move Speed of PlayerActionManager — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIFishingPanelManager.StartFishingResponse` (TryGetBuf) — Code


---

### ซามูไรอาร์เชอรี (SamuraiArchery) · uid 83
- ทรี: สกิลยิง · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: SubKatana

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย เอเลเมนท์สตาร์ทเตอร์ (uid 86) ผ่าน `ElementReach.CheckActiveSamuraiArcherySubElement` (GetSkillLv) — check active samurai archery sub element — Code
- ถูกอ่านโดย เอเลเมนท์สตาร์ทเตอร์ (uid 86) ผ่าน `ElementReach.SetSubElement` (GetSkillLv) — Set Sub Element — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `GameManager.PlayerSkillUpdate` (GetSkillLv) — Player Skill Update — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `NormalAttackAction.Damaged` (TryGetBuf) — NormalAttackAction: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerStatusBase.SetEquip` (GetSkillLv) — Set Equip — Code


---

### แวนควิชเชอร์ (Conquester) · uid 84
- ทรี: สกิลยิง · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: ธนู, โบว์กัน
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ DEX(ที่ลงเอง)/INT(ที่ลงเอง), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **1200** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ธนู + มือรอง อุปกรณ์เวท | โบว์กัน + มือรอง อุปกรณ์เวท] `100 × Lv + INT(ที่ลงเอง) + 500 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `skillRate`: `2 × skillRate` เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ธนู + มือรองที่ไม่ใช่ อุปกรณ์เวท | โบว์กัน + มือรองที่ไม่ใช่ อุปกรณ์เวท] `100 × Lv + DEX(ที่ลงเอง) + 500 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `skillRate`: `2 × skillRate` เมื่อ (+เงื่อนไขอื่น)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ควิกโหลดเดอร์ (QuickLoader) · uid 85
- ทรี: สกิลยิง · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: ธนู, โบว์กัน

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: สเนคแอคแทค (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ความเร็วท่าทาง + (`MotionSpeed`) = `motionSpeed` — เมื่อ quickSpeed ≠ 0
- ความเร็วท่าทาง + (`MotionSpeed`) = `CountBufferBase.GetParam(this, id)` — เมื่อ BuffEffectActive = 0
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล สเนคแอคแทค (uid 69): `QuickLoaderAction.ActionHit` (GetSkillLv) — Action Hit — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.RemoveAfterSkillBuf` (TryGetBuf) — Remove After Skill Buf — Code


---

### เอเลเมนท์สตาร์ทเตอร์ (ElementReach) · uid 86
- ทรี: สกิลยิง · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: ธนู, โบว์กัน

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล ซามูไรอาร์เชอรี (uid 83): `ElementReach.CheckActiveSamuraiArcherySubElement` (GetSkillLv) — check active samurai archery sub element — Code
- ได้รับการเสริมจากสกิล ซามูไรอาร์เชอรี (uid 83): `ElementReach.SetSubElement` (GetSkillLv) — Set Sub Element — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `GameManager.PlayerSkillUpdate` (GetSkillLv) — Player Skill Update — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerStatusBase.SetEquip` (GetSkillLv) — Set Equip — Code


---

### คู่หูนักล่า (HuntingOne) · uid 87
- ทรี: สกิลยิง · เลเวลสูงสุด: 150 · อาวุธที่ใช้ได้: ธนู, โบว์กัน

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `GameManager.ReceiveSummons` (GetSkillLv) — Receive Summons — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `HuntingOneActionManager.BattleReservation` (GetSkillLv) — Battle Reservation — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `HuntingOneActionManager.SupportResevation` (GetSkillLv) — Support Resevation — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIExSkillManager.ExSkillList` (GetSkillLv) — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UISkillTreeManager.SkillTreeList` (GetSkillLv) — Code


---

### เจาะทะลุ (Penetrator) · uid 88
- ทรี: สกิลยิง · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: ธนู, โบว์กัน
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ DEX(ที่ลงเอง)/STR(ที่ลงเอง)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **600** คงที่ทุก Lv — เมื่อ isFireFailure = 0 และ target.AvoidProbability ≤ 99 (+เงื่อนไขอื่น)
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `int(status.Lv)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (isFireFailure = 0 และ target.AvoidProbability ≤ 99 (+เงื่อนไขอื่น)) หรือ isFireFailure = 0 (+เงื่อนไขอื่น)
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `int(0.75 × IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction)))` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (isFireFailure = 0 และ target.AvoidProbability ≤ 99 (+เงื่อนไขอื่น)) หรือ isFireFailure = 0 (+เงื่อนไขอื่น)
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `int(0.5 × IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction)))` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (isFireFailure = 0 และ target.AvoidProbability ≤ 99 (+เงื่อนไขอื่น)) หรือ isFireFailure = 0 (+เงื่อนไขอื่น)
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `int(0.25 × IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction)))` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (isFireFailure = 0 และ target.AvoidProbability ≤ 99 (+เงื่อนไขอื่น)) หรือ isFireFailure = 0 (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `25 × Lv + max(STR(ที่ลงเอง), DEX(ที่ลงเอง)) ÷ 2 + 1000 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ isFireFailure = 0 และ target.AvoidProbability ≤ 99 (+เงื่อนไขอื่น)
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ isFireFailure = 0 และ target.AvoidProbability ≤ 99 (+เงื่อนไขอื่น)

#### 3) ระหว่างใช้สกิล
- คงกระพันตามเวลา PlayerActionManagerBase.get_AbnormalStatusManager() วินาที (ถอดเมื่อจบท่า/ครบเวลา) (เฉพาะ WeaponType = 13) — Code · `ActionSkillEvent: AbnormalStateManager$$AddTimeInvincibility`
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (คำอธิบาย): พาวเวอร์ช็อตทะลวงเกราะศัตรู — Text
- ข้อความในเกม (Lv13): เมื่อเริ่มหรือกลับมาชาร์จตัวเองจะติดคงกระพัน 1.5 วินาที — Text
- ข้อความในเกม (Lv13): คงกระพันจะหายไปเมื่อใช้สกิล — Text

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ไวด์สเปรด (WideSpread) · uid 89
- ทรี: สกิลยิง · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: ธนู, โบว์กัน
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **200** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ธนู] `10 × Lv + 200 %` → Lv1 210% · Lv5 250% · Lv10 300%
  - ตัวคูณสกิล (`SkillRate`, AddRate) [โบว์กัน] `10 × Lv + 200 %` → Lv1 210% · Lv5 250% · Lv10 300%
    - ตัวปรับ `skillRate`: `2 × skillRate` เมื่อ (+เงื่อนไขอื่น)
  - Proration (`ExpRate`, SetRate) `(targetExpList[mobAction].Exp / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ความแม่น % (`HitRate`) = `([hitRate+0x24] - 1) × hitRate`

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---
