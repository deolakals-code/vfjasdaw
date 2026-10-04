# สกิลโกเล็ม (12 สกิล)

สรุปโดยรวมต่อสกิล: ตัวคูณดาเมจมาจากไหน / แยกอาวุธ / สถานะระหว่างท่า / บัพ / เชื่อมสกิลอื่น. วิธีอ่าน: [ENGINE.md](ENGINE.md)

### อัญเชิญโกเล็ม (CallGolem) · uid 577
- ทรี: สกิลโกเล็ม · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: โบว์กัน, ไม้เท้า, MainMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - (`MobLastDamageRate*` เข้าสูตรดาเมจที่มอนทำใส่ผู้เล่นใน `MobAttackBase.CalcLastDamage` — ค่านี้คือส่วนลดดาเมจที่ได้รับ; หน่วยและการรวมกับบัพอื่นยังไม่ยืนยัน — Inferred)
  - ตัวคูณดาเมจที่ได้รับจากมอน (หมวดบัพ) (`MobLastDamageRateBuf`) = `damageCut`

#### 4) บัพที่ได้จากสกิลนี้
- ความเร็วโจมตี % (`AspdRate`) = `aspdRate` — เมื่อ GolemBonus ≠ 0
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `golemType`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `CallGolemActionManager.BattleReservation` (GetSkillLv) — Battle Reservation — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `CallGolemActionManager.CalcMoveSpeed` (GetSkillLv) — calculate move speed — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `CallGolemNormalAttackAction.OnInitialize` (TryGetBuf) — CallGolemNormalAttackAction: initial values — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `GameManager.PlayerSkillUpdate` (GetSkillLv) — Player Skill Update — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `GameManager.ReceiveSummons` (GetSkillLv) — Receive Summons — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MainPlayer.PlayerDead` (ContainsBuffer) — Player Dead — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerSecondaryStatus.get_AtkMpRecovery` (TryGetBuf) — Atk Mp Recovery of MobaPlayerSecondaryStatus — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.get_AtkMpRecovery` (TryGetBuf) — Atk Mp Recovery of PlayerSecondaryStatus — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIExSkillManager.ExSkillList` (GetSkillLv) — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIGolemExSkillManager.<Start>d__30.MoveNext` (GetSkillLv) — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UISkillTreeManager.SkillTreeList` (GetSkillLv) — Code


---

### แลนเซอร์พลัส (LancerTypeImproved) · uid 578
- ทรี: สกิลโกเล็ม · เลเวลสูงสุด: 200 · อาวุธที่ใช้ได้: โบว์กัน, ไม้เท้า, MainMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: PowerResistBreaker (`PowerResistBreaker`) → Lv1 12 · Lv5 40 · Lv10 75 — Code
- พาสซีฟ/มาสเตอรี่: อัตราคริ (`Crt`) → Lv1 7 · Lv5 37 · Lv10 75 — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ชีลด์พลัส (ShieldTypeImproved) · uid 579
- ทรี: สกิลโกเล็ม · เลเวลสูงสุด: 200 · อาวุธที่ใช้ได้: โบว์กัน, ไม้เท้า, MainMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: เพิ่มเวลาจำกัด (`LimitTimeUp`) → Lv1 8 · Lv5 40 · Lv10 80 — Code
- พาสซีฟ/มาสเตอรี่: ค่าทั่วไป (`Value`) → Lv1 2 · Lv5 10 · Lv10 20 — Code
- ข้อความในเกม (คำอธิบาย): ระยะเวลาคงอยู่และระยะการลดความเสียหายของโกเล็มจะเพิ่มขึ้น — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### บัสเตอร์พลัส (BusterTypeImproved) · uid 580
- ทรี: สกิลโกเล็ม · เลเวลสูงสุด: 200 · อาวุธที่ใช้ได้: โบว์กัน, ไม้เท้า, MainMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: PowerResistBreaker (`PowerResistBreaker`) → Lv1 12 · Lv5 40 · Lv10 75 — Code
- พาสซีฟ/มาสเตอรี่: อัตราคริ (`Crt`) → Lv1 7 · Lv5 37 · Lv10 75 — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### เสริมพลังโจมตี (AttackPerformanceImprovement) · uid 581
- ทรี: สกิลโกเล็ม · เลเวลสูงสุด: 250 · อาวุธที่ใช้ได้: โบว์กัน, ไม้เท้า, MainMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ค่าทั่วไป (`Value`) → Lv1 2 · Lv5 10 · Lv10 20 — Code
- พาสซีฟ/มาสเตอรี่: ความแม่น (`Hit`) → Lv1 2 · Lv5 50 · Lv10 200 — Code

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `CallGolemNormalAttackAction.OnInitialize` (GetSkillLv) — CallGolemNormalAttackAction: initial values — Code


---

### เสริมพลังป้องกัน (ShieldPerformanceImprovement) · uid 582
- ทรี: สกิลโกเล็ม · เลเวลสูงสุด: 250 · อาวุธที่ใช้ได้: โบว์กัน, ไม้เท้า, MainMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ดาเมจสุดท้ายที่ได้รับจากมอน (`MobAttackLastDamageRate`) → Lv1 2 · Lv5 10 · Lv10 20 — Code
- พาสซีฟ/มาสเตอรี่: ค่าทั่วไป (`Value`) → Lv1 2 · Lv5 10 · Lv10 20 — Code
- ข้อความในเกม (คำอธิบาย): และระยะลดความเสียหายจะเพิ่มขึ้นตลอดเวลา — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### เสริมความเร็ว (SpeedPerformanceImprovement) · uid 583
- ทรี: สกิลโกเล็ม · เลเวลสูงสุด: 250 · อาวุธที่ใช้ได้: โบว์กัน, ไม้เท้า, MainMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ความเร็วโจมตี + (`Aspd`) → Lv1 1 · Lv5 5 · Lv10 10 — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ระเบิดเวทมนตร์ (MagicGrenade) · uid 584
- ทรี: สกิลโกเล็ม · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: โบว์กัน, โล่, MainHand
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (never (IsExpDefFluctuate=false))

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `constantDamage` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `skillRate %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระเบิดแสง (uid 586) ผ่าน `FlashGrenadeAction.OnInitialize` (GetSkillLv) — FlashGrenadeAction: initial values — Code
- ถูกอ่านโดย ระเบิดเยือกแข็ง (uid 585) ผ่าน `FreezeGrenadeAction.OnInitialize` (GetSkillLv) — FreezeGrenadeAction: initial values — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `GolemGrenadeSkillBase.GetMagicGrenadeParameter` (GetSkillLv) — Get Magic Grenade Parameter — Code


---

### ระเบิดเยือกแข็ง (FreezeGrenade) · uid 585
- ทรี: สกิลโกเล็ม · เลเวลสูงสุด: 200 · อาวุธที่ใช้ได้: โบว์กัน, โล่, MainHand
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (never (IsExpDefFluctuate=false))

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `constantDamage` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `skillRate %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- สถานะผิดปกติที่ติดเป้า:
  - แช่แข็ง โอกาส `10 × Lv` → Lv1 10 · Lv5 50 · Lv10 100
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: ระเบิดเวทมนตร์ (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (Lv17): เมื่อติดตั้งโล่จะต้านทานแช่แข็งได้ด้วยการต้านภาวะผิดปกติของคุณเอง — Text
- ข้อความในเกม (Lv254): ขณะสกิลชี่กงฟื้นฟูทำงานจะต้านทานแช่แข็ง — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล ระเบิดเวทมนตร์ (uid 584): `FreezeGrenadeAction.OnInitialize` (GetSkillLv) — FreezeGrenadeAction: initial values — Code
- ได้รับการเสริมจากสกิล ชี่กงฟื้นฟู (uid 1093): `FreezeGrenadeAction.ActionSkillEvent` (ContainsBuffer) — Action Skill Event — Code


---

### ระเบิดแสง (FlashGrenade) · uid 586
- ทรี: สกิลโกเล็ม · เลเวลสูงสุด: 250 · อาวุธที่ใช้ได้: โบว์กัน, โล่, MainHand
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (never (IsExpDefFluctuate=false))

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `constantDamage` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `skillRate %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- สถานะผิดปกติที่ติดเป้า:
  - ตาพร่า โอกาส `10 × Lv` → Lv1 10 · Lv5 50 · Lv10 100
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: ระเบิดเวทมนตร์ (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (Lv17): เมื่อติดตั้งโล่จะต้านทานตาพร่าได้ด้วยการต้านภาวะผิดปกติของคุณเอง — Text
- ข้อความในเกม (Lv254): ขณะสกิลชี่กงฟื้นฟูทำงานจะต้านทานตาพร่า — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล ระเบิดเวทมนตร์ (uid 584): `FlashGrenadeAction.OnInitialize` (GetSkillLv) — FlashGrenadeAction: initial values — Code
- ได้รับการเสริมจากสกิล ชี่กงฟื้นฟู (uid 1093): `FlashGrenadeAction.ActionSkillEvent` (ContainsBuffer) — Action Skill Event — Code


---

### บาเรียสกรีน (BarrierScreen) · uid 587
- ทรี: สกิลโกเล็ม · เลเวลสูงสุด: 200 · อาวุธที่ใช้ได้: โบว์กัน, โล่

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: เสริมบาเรีย (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (คำอธิบาย): *มีการโจมตีบางประเภทที่ไม่สามารถลดความเสียหายได้ — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- MP ฟื้นต่อการโจมตี % (`AttackMprecoveryUpRate`) = `atkMpHeal`
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `int(time)`

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล เสริมบาเรีย (uid 588): `BarrierScreenAction.ActionSkillEvent` (GetSkillLv) — Action Skill Event — Code
- ได้รับการเสริมจากสกิล เสริมบาเรีย (uid 588): `BarrierScreenAction.ActionStart` (GetSkillLv) — BarrierScreenAction: skill start — Code


---

### เสริมบาเรีย (BarrierScreenPerformanceImprovement) · uid 588
- ทรี: สกิลโกเล็ม · เลเวลสูงสุด: 250 · อาวุธที่ใช้ได้: โบว์กัน, โล่

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย บาเรียสกรีน (uid 587) ผ่าน `BarrierScreenAction.ActionSkillEvent` (GetSkillLv) — Action Skill Event — Code
- ถูกอ่านโดย บาเรียสกรีน (uid 587) ผ่าน `BarrierScreenAction.ActionStart` (GetSkillLv) — BarrierScreenAction: skill start — Code


---
