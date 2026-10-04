# สกิลมาร์เชียล (22 สกิล)

สรุปโดยรวมต่อสกิล: ตัวคูณดาเมจมาจากไหน / แยกอาวุธ / สถานะระหว่างท่า / บัพ / เชื่อมสกิลอื่น. วิธีอ่าน: [ENGINE.md](ENGINE.md)

### สแมช (Smash) · uid 129
- ทรี: สกิลมาร์เชียล · เลเวลสูงสุด: 10 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ AGIรวม
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [`5 × Lv + AGIรวม ÷ 10 + 25` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] หรือ [`5 × Lv` → Lv1 5 · Lv5 25 · Lv10 50]
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`5 × Lv + โบนัสคริสตัล#107[4] + 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] หรือ [`2 × Lv + 50 %` → Lv1 52% · Lv5 60% · Lv10 70%]
- สถานะผิดปกติที่ติดเป้า:
  - ผงะ โอกาส [`(Lv > 5 ? 75 : 50) + 25` → Lv1 75 · Lv5 75 · Lv10 100] หรือ [`Lv > 5 ? 75 : 50` → Lv1 50 · Lv5 50 · Lv10 75]

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### บาช (Bash) · uid 130
- ทรี: สกิลมาร์เชียล · เลเวลสูงสุด: 10 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ AGIรวม
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [`10 × Lv + AGIรวม ÷ 5 + 50` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] หรือ [`10 × Lv` → Lv1 10 · Lv5 50 · Lv10 100]
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`5 × Lv + AGIรวม ÷ 5 + 200 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] หรือ [`5 × Lv + 100 %` → Lv1 105% · Lv5 125% · Lv10 150%]
- สถานะผิดปกติที่ติดเป้า:
  - สตัน โอกาส [`(Lv > 5 ? 50 : 25) + AGIรวม ÷ 10 + 25` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] หรือ [`Lv > 5 ? 50 : 25` → Lv1 25 · Lv5 25 · Lv10 50]

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### โซนิคเวฟ (SonicWave) · uid 131
- ทรี: สกิลมาร์เชียล · เลเวลสูงสุด: 10 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [`5 × Lv + 25` → Lv1 30 · Lv5 50 · Lv10 75] หรือ [`5 × Lv` → Lv1 5 · Lv5 25 · Lv10 50]
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`2.5 × Lv + โบนัสคริสตัล#108[4] + 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] หรือ [`2.5 × Lv + 75 %` → Lv1 77.5% · Lv5 87.5% · Lv10 100%]
- สถานะผิดปกติที่ติดเป้า:
  - ล้มคว่ำ โอกาส [`5 × Lv + 50` → Lv1 55 · Lv5 75 · Lv10 100] หรือ [`5 × Lv` → Lv1 5 · Lv5 25 · Lv10 50]

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### มาร์เชียลมาสเตอรี่ (MarshallMastary) · uid 132
- ทรี: สกิลมาร์เชียล · เลเวลสูงสุด: 10 · อาวุธที่ใช้ได้: MainKnuckle

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ATK อาวุธ % (`EqAtkRate`) → Lv1 3 · Lv5 15 · Lv10 30 — Code
- พาสซีฟ/มาสเตอรี่: ATK % (`AtkRate`) → Lv1 1 · Lv5 1 · Lv10 2 — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### แอกราเวท (OneChance) · uid 133
- ทรี: สกิลมาร์เชียล · เลเวลสูงสุด: 10 · อาวุธที่ใช้ได้: สนับมือ, MainHand

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: โอกาสทำงาน % (`Trigger`) → Lv1 14 · Lv5 30 · Lv10 50 — Code
- พาสซีฟ/มาสเตอรี่: ตัวคูณสกิล (`SkillRate`) → Lv1 27 · Lv5 37 · Lv10 50 — Code
- พาสซีฟ/มาสเตอรี่: ค่าทั่วไป (`Value`) → Lv1 0 · Lv5 2 · Lv10 5 — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### เชลเบรค (ShellBreak) · uid 134
- ทรี: สกิลมาร์เชียล · เลเวลสูงสุด: 30 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [`10 × Lv + 200` → Lv1 210 · Lv5 250 · Lv10 300] หรือ [`10 × Lv + 50` → Lv1 60 · Lv5 100 · Lv10 150]
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `(2 × IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction)) - 2 × target.Level) > -101 ? min((2 × IMobStatusCalculator.CalcDef(MobActionMana…(ย่อ)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`5 × Lv + 150 %` → Lv1 155% · Lv5 175% · Lv10 200%] หรือ [`5 × Lv + 100 %` → Lv1 105% · Lv5 125% · Lv10 150%]
  - ตัวคูณสกิล (`SkillRate`, AddRate) `(2 × IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction)) - 2 × target.Level) > -101 ? min((2 × IMobStatusCalculator.CalcDef(MobActionMana…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- สถานะผิดปกติที่ติดเป้า:
  - เกราะแตก [มือเปล่า | ดาบมือเดียว | ดาบสองมือ | ธนู | โบว์กัน | ไม้เท้า | อุปกรณ์เวท | ทวน | คาตานะ] โอกาส [`SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1159), SkillBufferId.Value) + โบนัสคริสตัล#208[2] + int(1.5 × Lv) + 10` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`โบนัสคริสตัล#208[2] + int(1.5 × Lv) + 10` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)]
  - เกราะแตก [สนับมือ] โอกาส [`SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1159), SkillBufferId.Value) + โบนัสคริสตัล#208[2] + int(1.5 × Lv) + 35` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`โบนัสคริสตัล#208[2] + int(1.5 × Lv) + 35` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)]

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (คำอธิบาย): โจมตีผ่านเกราะแข็งได้อย่างง่ายดาย — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล ผู้ทำลายล้าง (uid 1159): `ShellBreakAction.OnInitialize` (TryGetBuf) — ShellBreakAction: initial values — Code


---

### เอิร์ธไบด์ (EarthBind) · uid 135
- ทรี: สกิลมาร์เชียล · เลเวลสูงสุด: 30 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ AGIรวม
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [`5 × Lv + 25` → Lv1 30 · Lv5 50 · Lv10 75] หรือ [`5 × Lv` → Lv1 5 · Lv5 25 · Lv10 50]
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`int(2.5 × Lv) + AGIรวม ÷ 5 + โบนัสคริสตัล#209[2] + 125 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] หรือ [`int(2.5 × Lv) + 100 %` → Lv1 102% · Lv5 112% · Lv10 125%]
- สถานะผิดปกติที่ติดเป้า:
  - หยุดนิ่ง โอกาส [`5 × Lv + 50` → Lv1 55 · Lv5 75 · Lv10 100] หรือ [`5 × Lv` → Lv1 5 · Lv5 25 · Lv10 50]

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### อัดกระแทก (StrongChase) · uid 136
- ทรี: สกิลมาร์เชียล · เลเวลสูงสุด: 30 · อาวุธที่ใช้ได้: สนับมือ, MainHand

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ตัวคูณสกิล (`SkillRate`) → Lv1 5 · Lv5 25 · Lv10 50 — Code
- พาสซีฟ/มาสเตอรี่: PowerResistBreaker (`PowerResistBreaker`) → Lv1 5 · Lv5 25 · Lv10 50 — Code
- พาสซีฟ/มาสเตอรี่: ความแม่น % (`HitRate`) → Lv1 1 · Lv5 5 · Lv10 10 — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### เฮวี่สแมช (HeavySmash) · uid 137
- ทรี: สกิลมาร์เชียล · เลเวลสูงสุด: 70 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), บัพ/มาสเตอรี่/สกิลอื่น
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [`10 × Lv + 200` → Lv1 210 · Lv5 250 · Lv10 300] หรือ [`10 × Lv + 100` → Lv1 110 · Lv5 150 · Lv10 200]
  - ดาเมจคงที่จากบัพ (`BufferConstantDamage`, SetConstant) = **0** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `15 × Lv + 100 %` → Lv1 115% · Lv5 175% · Lv10 250%
  - ตัวคูณสกิล (`SkillRate`, AddRate) = **150%** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) = **500%** คงที่ทุก Lv
- สถานะผิดปกติที่ติดเป้า:
  - อ่อนแอ โอกาส [`3 × Lv + 70` → Lv1 73 · Lv5 85 · Lv10 100] หรือ [`3 × Lv + 20` → Lv1 23 · Lv5 35 · Lv10 50]

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ทริปเปิ้ลคิก (TryArts) · uid 138
- ทรี: สกิลมาร์เชียล · เลเวลสูงสุด: 70 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `2 × Lv + 25` → Lv1 27 · Lv5 35 · Lv10 45 — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มือเปล่า + มือรอง สนับมือ | ดาบมือเดียว + มือรอง สนับมือ | ดาบสองมือ + มือรอง สนับมือ | ธนู + มือรอง สนับมือ | โบว์กัน + มือรอง สนับมือ | ไม้เท้า + มือรอง สนับมือ | อุปกรณ์เวท + มือรอง สนับมือ | สนับมือ | ทวน + มือรอง สนับมือ | คาตานะ + มือรอง สนับมือ] [`10 × Lv + 200 %` → Lv1 210% · Lv5 250% · Lv10 300%] หรือ [`10 × Lv + 100 %` → Lv1 110% · Lv5 150% · Lv10 200%] — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มือเปล่า + มือรองที่ไม่ใช่ สนับมือ | ดาบมือเดียว + มือรองที่ไม่ใช่ สนับมือ | ดาบสองมือ + มือรองที่ไม่ใช่ สนับมือ | ธนู + มือรองที่ไม่ใช่ สนับมือ | โบว์กัน + มือรองที่ไม่ใช่ สนับมือ | ไม้เท้า + มือรองที่ไม่ใช่ สนับมือ | อุปกรณ์เวท + มือรองที่ไม่ใช่ สนับมือ | ทวน + มือรองที่ไม่ใช่ สนับมือ | คาตานะ + มือรองที่ไม่ใช่ สนับมือ] `10 × Lv + 100 %` → Lv1 110% · Lv5 150% · Lv10 200% — เมื่อ (+เงื่อนไขอื่น)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### มาร์เชียลดิสซิพลิน (UnarmedTecnique) · uid 139
- ทรี: สกิลมาร์เชียล · เลเวลสูงสุด: 70 · อาวุธที่ใช้ได้: สนับมือ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ความเร็วโจมตี + (`Aspd`) → Lv1 10 · Lv5 50 · Lv10 100 — Code
- พาสซีฟ/มาสเตอรี่: ความเร็วโจมตี % (`AspdRate`) → Lv1 1 · Lv5 5 · Lv10 10 — Code
- พาสซีฟ/มาสเตอรี่: ดาเมจสุดท้าย % (`LastDmgRate`) → Lv1 1 · Lv5 5 · Lv10 10 — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### เชอริออต (Chariot) · uid 140
- ทรี: สกิลมาร์เชียล · เลเวลสูงสุด: 150 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ AGI(ที่ลงเอง), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [มือเปล่า | ดาบมือเดียว | ดาบสองมือ | ธนู | โบว์กัน | ไม้เท้า | อุปกรณ์เวท | ทวน | คาตานะ] `20 × Lv + 50` → Lv1 70 · Lv5 150 · Lv10 250 — เมื่อ IsInheritance = 0 หรือ IsInheritance = 0 (+เงื่อนไขอื่น)
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [สนับมือ] `20 × Lv + 300` → Lv1 320 · Lv5 400 · Lv10 500 — เมื่อ IsInheritance = 0 หรือ IsInheritance = 0 (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มือเปล่า | ดาบมือเดียว | ดาบสองมือ | ธนู | โบว์กัน | ไม้เท้า | อุปกรณ์เวท | ทวน | คาตานะ] `min(Lv + 990, 1760) %` → Lv1 991% · Lv5 995% · Lv10 1000% — เมื่อ IsInheritance = 0 หรือ IsInheritance = 0 (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [สนับมือ] `min(Lv + AGI(ที่ลงเอง) + 1240, 1760) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ IsInheritance = 0 หรือ IsInheritance = 0 (+เงื่อนไขอื่น)
- สถานะผิดปกติที่ติดเป้า:
  - หวาดกลัว [มือเปล่า | ดาบมือเดียว | ดาบสองมือ | ธนู | โบว์กัน | ไม้เท้า | อุปกรณ์เวท | ทวน | คาตานะ] โอกาส `int(MobActionManagerBase.get_IsBoss(mobAction) ? 2.5 × Lv : 5 × Lv)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - หวาดกลัว [สนับมือ] โอกาส `int(MobActionManagerBase.get_IsBoss(mobAction) ? 2.5 × Lv + 25 : 5 × Lv + 50)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล อาชูร่าออร่า (uid 145): `ChariotAction.OnInitialize` (TryGetBuf) — ChariotAction: initial values — Code


---

### รัช (Rush) · uid 141
- ทรี: สกิลมาร์เชียล · เลเวลสูงสุด: 150 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ AGI(ที่ลงเอง), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [มือเปล่า | ดาบมือเดียว | ดาบสองมือ | ธนู | โบว์กัน | ไม้เท้า | อุปกรณ์เวท | ทวน | คาตานะ] [`20 × Lv + 200` → Lv1 220 · Lv5 300 · Lv10 400] หรือ [`20 × Lv` → Lv1 20 · Lv5 100 · Lv10 200]
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [สนับมือ] `20 × Lv + 200` → Lv1 220 · Lv5 300 · Lv10 400
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มือเปล่า | ดาบมือเดียว | ดาบสองมือ | ธนู | โบว์กัน | ไม้เท้า | อุปกรณ์เวท | ทวน | คาตานะ] [`min(40 × Lv + 2 × AGI(ที่ลงเอง) + 500, 1920) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] หรือ [`min(40 × Lv + 300, 1920) %` → Lv1 340% · Lv5 500% · Lv10 700%]
  - ตัวคูณสกิล (`SkillRate`, AddRate) [สนับมือ] `min(40 × Lv + 2 × AGI(ที่ลงเอง) + 500, 1920) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ความเร็วท่าทาง + (`MotionSpeed`) = `motionSpeed`

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### จักรา (Chakra) · uid 142
- ทรี: สกิลมาร์เชียล · เลเวลสูงสุด: 150 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (คำอธิบาย): เพิ่มบัฟเพื่อลดความเสียหายที่ได้รับครั้งถัดไป — Text
- ข้อความในเกม (Lv16): เพิ่มพลังการลดความเสียหาย — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย เอเนอร์จี้คอนโทรล (uid 147) ผ่าน `KakeiAction.Damaged` (GetSkillLv) — KakeiAction: on damaged — Code


---

### สไลด์ดิ้ง (Sliding) · uid 143
- ทรี: สกิลมาร์เชียล · เลเวลสูงสุด: 70 · อาวุธที่ใช้ได้: MainKnuckle

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ความแม่น + (`HitUp`) = `hit`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.RemoveAfterSkillBuf` (ContainsBuffer) — Remove After Skill Buf — Code


---

### แอบสแตรกต์อาร์ม (MindimageSenju) · uid 144
- ทรี: สกิลมาร์เชียล · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: สนับมือ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `AvoidActionManager.CheckMindimageSenju` (ContainsBuffer) — check mindimage senju — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `AvoidActionManager.CheckMindimageSenju` (GetSkillLv) — check mindimage senju — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MindimageSenjuSkillBase.CheckInheritance` (ContainsBuffer) — check inheritance — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MindimageSenjuSkillBase.CheckInheritance` (GetSkillLv) — check inheritance — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerBattleManager.StartMindimageSenju` (GetSkillLv) — Start Mindimage Senju — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.StartMindimageSenju` (GetSkillLv) — Start Mindimage Senju — Code


---

### อาชูร่าออร่า (AshuraAura) · uid 145
- ทรี: สกิลมาร์เชียล · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: สนับมือ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- คงกระพันตามช่วงของแอนิเมชันท่า (motion) จนกว่าท่าจบ — Code · `ActionSkillEvent: AbnormalStateManager$$AddSkillMotionInvincibility`
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (คำอธิบาย): ขณะใช้งาน ATK จะเพิ่มขึ้นและลดความเสียหายด้วยการใช้ MP — Text

#### 4) บัพที่ได้จากสกิลนี้
- ดาเมจคงที่สกิล (`SkillConstantDamage`) = `constantDamage`
- ดาเมจคงที่ตีปกติ (`NormalAttackConstantDamage`) = `constantDamage`
- อัตราคริ + (`CrtUp`) = `critical`
- ดาเมจสุดท้ายที่ทำ % (`LastDmgUpRate`) = `lastDamageRate` — เมื่อ IsActive ≠ 0
- ดาเมจสุดท้ายที่ทำ % (`LastDmgUpRate`) = `lastDamageRateOffVer` — เมื่อ IsActive = 0
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย AshuraAuraAttackAction (uid 157) ผ่าน `AshuraAuraAttackAction.OnInitialize` (TryGetBuf) — AshuraAuraAttackAction: initial values — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `AvoidActionManager.InvalidAshuraAuraAttack` (TryGetBuf) — Invalid Ashura Aura Attack — Code
- ถูกอ่านโดย เชอริออต (uid 140) ผ่าน `ChariotAction.OnInitialize` (TryGetBuf) — ChariotAction: initial values — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `GuardActionManager.CheckGuard` (TryGetBuf) — check guard — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `GuardActionManager.<StartManualGuard>d__91.MoveNext` (TryGetBuf) — Move Next — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.ReceiveDamaged` (TryGetBuf) — Receive Damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerBattleManager.CheckAshuraAuraAttackStart` (TryGetBuf) — check ashura aura attack start — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerBattleManager.CheckAshuraAuraAttackStop` (TryGetBuf) — check ashura aura attack stop — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerBattleManager.OnSkillActionStart` (TryGetBuf) — On Skill Action Start — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerBattleManager.OnSkillActionStartSummonSkeleton` (TryGetBuf) — On Skill Action Start Summon Skeleton — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerBattleManager.StartAshuraAuraAttack` (GetSkillLv) — Start Ashura Aura Attack — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerSecondaryStatus.GetCrtConstant` (TryGetBuf) — Get Crt Constant — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerSecondaryStatus.get_AntiVirus` (TryGetBuf) — Anti Virus of MobaPlayerSecondaryStatus — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.Damaged` (TryGetBuf) — PlayerActionManager: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.CalcCostMp` (TryGetBuf) — Skill MP cost — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.CheckAshuraAuraAttackStart` (TryGetBuf) — check ashura aura attack start — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.CheckAshuraAuraAttackStop` (TryGetBuf) — check ashura aura attack stop — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.OnSkillActionStart` (TryGetBuf) — On Skill Action Start — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.OnSkillActionStartSummonSkeleton` (TryGetBuf) — On Skill Action Start Summon Skeleton — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.StartAshuraAuraAttack` (GetSkillLv) — Start Ashura Aura Attack — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.CalcAntiVirus` (TryGetBuf) — calculate anti virus — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.GetCrtConstant` (TryGetBuf) — Get Crt Constant — Code


---

### เฟลชบลิงค์ (FlashArts) · uid 146
- ทรี: สกิลมาร์เชียล · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: สนับมือ
- ประเภทดาเมจ: ธรรมดา (SkillNormal) · Proration: ช่องตีปกติ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ AGI(ที่ลงเอง)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **100** คงที่ทุก Lv — เมื่อ maxAttackCount ≥ 1 (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `30 × Lv + AGI(ที่ลงเอง) ÷ 4 + 300 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ maxAttackCount ≥ 1 (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `15 × Lv + 0.5 × (AGI(ที่ลงเอง) ÷ 4) + 150 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ maxAttackCount ≥ 1 (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `7.5 × Lv + 0.25 × (AGI(ที่ลงเอง) ÷ 4) + 75 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ maxAttackCount ≥ 1 (+เงื่อนไขอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ดาเมจระยะใกล้ % (`ShortRangeRate`) = `shortRangeRate`
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### เอเนอร์จี้คอนโทรล (Kakei) · uid 147
- ทรี: สกิลมาร์เชียล · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: สนับมือ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: จักรา (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - (`MobLastDamageRate*` เข้าสูตรดาเมจที่มอนทำใส่ผู้เล่นใน `MobAttackBase.CalcLastDamage` — ค่านี้คือส่วนลดดาเมจที่ได้รับ; หน่วยและการรวมกับบัพอื่นยังไม่ยืนยัน — Inferred)
  - ลดดาเมจฐาน (`BaseDamageCut`) = `baseDamageCut`
  - ตัวคูณดาเมจที่ได้รับจากมอน (หมวดซัพพอร์ต) (`MobLastDamageRateSupport`) = `baseDamageCutRate`

#### 4) บัพที่ได้จากสกิลนี้
- MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = `attckMpRecovery`
- BaseEqAtkUpRate (`BaseEqAtkUpRate`) = `directEqAtk`
- ความเสถียร (`Stable`) = `stable`

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล จักรา (uid 142): `KakeiAction.Damaged` (GetSkillLv) — KakeiAction: on damaged — Code
- ถูกอ่านโดย เอนชานท์บลาส / เอนชานท์อกรา (uid 872) ผ่าน `EnchantedBurstAction.ActionHit` (ContainsBuffer) — Action Hit — Code
- ถูกอ่านโดย เอนชานท์บลาส / เอนชานท์อกรา (uid 872) ผ่าน `EnchantedBurstAction.AddLocalStack` (ContainsBuffer) — Add Local Stack — Code
- ถูกอ่านโดย เอนชานท์ซอร์ด / เอนชานท์บลาสซอร์ด (uid 870) ผ่าน `EnchantedSwordAction.ActionPreparation` (ContainsBuffer) — EnchantedSwordAction: preparation — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `EquipItemData.WeaponTypeCalculatorBase.CalcEqAtk` (TryGetBuf) — calculate eq atk — Code


---

### แนบพิงภูเขา (Thieshankai) · uid 148
- ทรี: สกิลมาร์เชียล · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: สนับมือ, MainHand
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **500** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `25 × Lv + 750 %` → Lv1 775% · Lv5 875% · Lv10 1000%
- สถานะผิดปกติที่ติดเป้า:
  - สตัน โอกาส = **100** คงที่ทุก Lv

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (คำอธิบาย): ถ้าศัตรูต้านทานหมดสติได้ — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) `min(Count × Lv, 500)` → Lv1 1 · Lv5 5 · Lv10 10
- ค่าทั่วไปตัวที่ 2 (`Value2`) = `triggerRate`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `NormalAttackAction.CheckOneChance` (TryGetBuf) — check one chance — Code


---

### กระทืบพสุธา (Shinkyaku) · uid 149
- ทรี: สกิลมาร์เชียล · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: สนับมือ, MainHand
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **300** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `25 × Lv + 750 %` → Lv1 775% · Lv5 875% · Lv10 1000%
- สถานะผิดปกติที่ติดเป้า:
  - ผงะ โอกาส `10 × Lv` → Lv1 10 · Lv5 50 · Lv10 100

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### หมุนปัด / ขากงจักร (Senfutsu) · uid 150
- ทรี: สกิลมาร์เชียล · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: สนับมือ, MainHand
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

**ชื่อ/รูปแบบของสกิล (จากข้อความในเกม):** [N] หมุนปัด · [N2] ขากงจักร

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `fixAddDamage[vtab(0x165da70(System.Collections.IEnumerator#1(System.Array.GetEnumerator(System.Enum.GetValues(System.Type.GetTypeFromHandle(meta(0x39a89c8, SenfutsuAct…(ย่อ)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `(skillRate[vtab(0x165da70(System.Collections.IEnumerator#1(System.Array.GetEnumerator(System.Enum.GetValues(System.Type.GetTypeFromHandle(meta(0x39a89c8, SenfutsuActio…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `InstallationBlackHolePattern.CheckSuctionHit` (ContainsBuffer) — check suction hit — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `InstallationMoveBlackHolePattern.CheckSuctionHit` (ContainsBuffer) — check suction hit — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobAttackBase.SetAbnormalEffect` (ContainsBuffer) — Set Abnormal Effect — Code


---
