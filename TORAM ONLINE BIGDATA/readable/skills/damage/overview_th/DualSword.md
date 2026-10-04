# สกิลดาบคู่ (21 สกิล)

สรุปโดยรวมต่อสกิล: ตัวคูณดาเมจมาจากไหน / แยกอาวุธ / สถานะระหว่างท่า / บัพ / เชื่อมสกิลอื่น. วิธีอ่าน: [ENGINE.md](ENGINE.md)

### ดูเอลมาสเตอรี่ (DualMastery) · uid 641
- ทรี: สกิลดาบคู่ · เลเวลสูงสุด: 30 · อาวุธที่ใช้ได้: TwinSword

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ความแม่น % (`HitRate`) → Lv1 -52 · Lv5 -40 · Lv10 -25 — Code
- พาสซีฟ/มาสเตอรี่: อัตราคริ % (`CrtRate`) → Lv1 -52 · Lv5 -40 · Lv10 -25 — Code

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `EquipItemData.OneHundSwordCalculator.CalcSubAtk` (GetSkillLv) — calculate sub atk — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `EquipItemData.OneHundSwordCalculator.SubCalcStable` (GetSkillLv) — Sub Calc Stable — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `EquipItemData.OneHundSwordCalculator.calcAtkParam` (GetSkillLv) — calculate atk param — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `SkillManager.GetEquipEnableSkillList` (GetSkillLv) — Get Equip Enable Skill List — Code


---

### ทวินสแลช (TwinSlash) · uid 642
- ทรี: สกิลดาบคู่ · เลเวลสูงสุด: 30 · อาวุธที่ใช้ได้: TwinSword
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `10 × Lv + 100` → Lv1 110 · Lv5 150 · Lv10 200
  - ตัวคูณสกิล (`SkillRate`, AddRate) `10 × Lv + 150 %` → Lv1 160% · Lv5 200% · Lv10 250%
  - ตัวคูณคริเพิ่ม (`CriticalRate`, AddRate) `5 × Lv + โบนัสคริสตัล#109[2] + 50 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย แอร์สไลเซอร์ (uid 658) ผ่าน `AirSlicerAction.OnInitialize` (GetSkillLv) — AirSlicerAction: initial values — Code


---

### ครอสแพรี่ (ParryingSword) · uid 643
- ทรี: สกิลดาบคู่ · เลเวลสูงสุด: 30 · อาวุธที่ใช้ได้: TwinSword
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `5 × Lv + 50` → Lv1 55 · Lv5 75 · Lv10 100
  - ตัวคูณสกิล (`SkillRate`, AddRate) `Lv + โบนัสคริสตัล#110[4] + 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - ลดดาเมจกายภาพที่ได้รับ (`PowerDmgCut`) = `ParryingSwordBuf.calcDmgCut(this, Lv)`
  - ลดดาเมจเวทที่ได้รับ (`MagicDmgCut`) = `ParryingSwordBuf.calcDmgCut(this, Lv)`
- ข้อความในเกม (คำอธิบาย): หลบการโจมตีของศัตรูพร้อมตอบโต้กลับ — Text
- ข้อความในเกม (คำอธิบาย): ลดความเสียหายจากการโจมตีทางกายภาพและเวทมนตร์ระหว่างใช้สกิล — Text
- ข้อความในเกม (คำอธิบาย): เร่ง ATK กับ ASPD เมื่อลดความเสียหายสำเร็จเป็นเวลา 30 วินาที — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ATK % (`AtkUpRate`) `Lv` → Lv1 1 · Lv5 5 · Lv10 10 — เมื่อ ParrySuccess ≠ 0
- ความเร็วโจมตี % (`AspdRate`) `10 × Lv` → Lv1 10 · Lv5 50 · Lv10 100 — เมื่อ ParrySuccess ≠ 0

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### รีเฟล็กซ์ (StepReactor) · uid 644
- ทรี: สกิลดาบคู่ · เลเวลสูงสุด: 30 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - หลบ + (`AvoidUp`) `2 × Lv + 10` → Lv1 12 · Lv5 20 · Lv10 30
  - MDEF % (`MdefRate`) `Lv - 100` → Lv1 -99 · Lv5 -95 · Lv10 -90
  - DEF % (`DefRate`) `Lv - 100` → Lv1 -99 · Lv5 -95 · Lv10 -90

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ควบคุมดาบคู่ (DualSwordTechnique) · uid 645
- ทรี: สกิลดาบคู่ · เลเวลสูงสุด: 30 · อาวุธที่ใช้ได้: TwinSword

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ความแม่น % (`HitRate`) → Lv1 8 · Lv5 20 · Lv10 35 — Code
- พาสซีฟ/มาสเตอรี่: อัตราคริ % (`CrtRate`) → Lv1 8 · Lv5 20 · Lv10 35 — Code
- พาสซีฟ/มาสเตอรี่: ความเร็วโจมตี + (`Aspd`) → Lv1 50 · Lv5 250 · Lv10 500 — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### สปินนิ่งสแลช (AirSlide) · uid 646
- ทรี: สกิลดาบคู่ · เลเวลสูงสุด: 50 · อาวุธที่ใช้ได้: TwinSword
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ฮิต 1**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `5 × Lv + 50` → Lv1 55 · Lv5 75 · Lv10 100
  - ตัวคูณสกิล (`SkillRate`, AddRate) `int(2.5 × Lv) + โบนัสคริสตัล#210[4] + 125 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(proration ที่เก็บไว้ตอนร่าย[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ฮิตถัดไป**
  - ตัวคูณสกิล (`SkillRate`, AddRate) `2 × Lv + โบนัสคริสตัล#210[4] + 30 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(proration ที่เก็บไว้ตอนร่าย[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- สถานะผิดปกติที่ติดเป้า:
  - กระเด็น โอกาส = **100** คงที่ทุก Lv
  - ตาบอด โอกาส `int(2.5 × Lv) + 15` → Lv1 17 · Lv5 27 · Lv10 40

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย แอร์สไลเซอร์ (uid 658) ผ่าน `AirSlicerAction.OnInitialize` (GetSkillLv) — AirSlicerAction: initial values — Code


---

### ชาร์จจิ้งสแลช (DragoonSword) · uid 647
- ทรี: สกิลดาบคู่ · เลเวลสูงสุด: 50 · อาวุธที่ใช้ได้: TwinSword
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `20 × Lv + 100` → Lv1 120 · Lv5 200 · Lv10 300
  - ดาเมจคงที่ตีแรก (`FirstAttack`, AddConstant) `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `20 × Lv + โบนัสคริสตัล#211[4] + 200 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณตีแรก (`FirstAttackRate`, AddRate) `PlayerAttackBase.calcFastAttackDamageRate(playerAction) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(proration ที่เก็บไว้ตอนร่าย[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### เร็วดุจเทพ (GodspeedLocus) · uid 648
- ทรี: สกิลดาบคู่ · เลเวลสูงสุด: 50 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ตัวคูณตีแรก (`FirstAttackRate`) → Lv1 6 · Lv5 10 · Lv10 15 — Code
- พาสซีฟ/มาสเตอรี่: AGI (`Agi`) = **0** คงที่ทุก Lv — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### แฟนทอมสแลช / แฟนทอมอิคลิพส์ (PhantomRave) · uid 649
- ทรี: สกิลดาบคู่ · เลเวลสูงสุด: 90 · อาวุธที่ใช้ได้: TwinSword
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

**ชื่อ/รูปแบบของสกิล (จากข้อความในเกม):** [N] แฟนทอมสแลช · [N2] แฟนทอมอิคลิพส์

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `20 × Lv + 200` → Lv1 220 · Lv5 300 · Lv10 400
  - ตัวคูณสกิล (`SkillRate`, AddRate) `100 × (20 × Lv + โบนัสคริสตัล#305[4] + 500) / 100 × (change = 0 ? 1 : 2) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `change`: `change`
  - ตัวคูณสกิล (`SkillRate`, SetRate) `20 × Lv + โบนัสคริสตัล#305[4] + 500 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, SetRate) `100 × CalcPhantomRaveLastDamageRate.out2(this, (PlayerActionManagerBase.get_PlayerStatus()), (PlayerActionManagerBase.get_PlayerStatus())) - 100 × MobPropertyLifeReduc…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, SetRate) `100 × CalcPhantomRaveLastDamageRate.out3(this, (PlayerActionManagerBase.get_PlayerStatus()), (PlayerActionManagerBase.get_PlayerStatus())) - 100 × MobPropertyLifeReduc…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, SetRate) `100 × CalcPhantomRaveLastDamageRate.out2(this, (PlayerActionManagerBase.get_PlayerStatus()), (PlayerActionManagerBase.get_PlayerStatus())) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, SetRate) `100 × CalcPhantomRaveLastDamageRate.out3(this, (PlayerActionManagerBase.get_PlayerStatus()), (PlayerActionManagerBase.get_PlayerStatus())) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- สถานะผิดปกติที่ติดเป้า:
  - แช่แข็ง โอกาส [`10 × Lv` → Lv1 10 · Lv5 50 · Lv10 100] หรือ [= **0** คงที่ทุก Lv]

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### แฟลชบลาส (PhiloEclair) · uid 650
- ทรี: สกิลดาบคู่ · เลเวลสูงสุด: 90 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - จำนวนหลบสะสม (`AvoidStack`) = `avoidStack`

#### 4) บัพที่ได้จากสกิลนี้
- ATK อาวุธ % (`EqAtkUpRate`) = `eqAtkRate`
- ตัวคูณตีแรก (`FirstAttackRate`) = `firstAttackRate`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `AvoidActionManager.CheckActivatePhiloEclair` (ContainsBuffer) — check activate philo eclair — Code


---

### ชาโดว์สเต็ป (WrapAround) · uid 651
- ทรี: สกิลดาบคู่ · เลเวลสูงสุด: 90 · อาวุธที่ใช้ได้: TwinSword

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ลูนาดิธเธอร์สตาร์ (uid 655) ผ่าน `LunaDitherStarAction.ActionSkillEvent` (GetSkillLv) — Action Skill Event — Code


---

### ไชน์นิ่งครอส / เบลซซิ่งไชน์นิ่งครอส (ShiningCloth) · uid 652
- ทรี: สกิลดาบคู่ · เลเวลสูงสุด: 170 · อาวุธที่ใช้ได้: TwinSword
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

**ชื่อ/รูปแบบของสกิล (จากข้อความในเกม):** [N] ไชน์นิ่งครอส · [N2] เบลซซิ่งไชน์นิ่งครอส

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ AGIรวม/DEXรวม/STRรวม
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `20 × Lv + 100` → Lv1 120 · Lv5 200 · Lv10 300
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`max(10 × Lv + AGIรวม ÷ 4 + STRรวม ÷ 4 + DEXรวม ÷ 4 - System.Math.Max(0, System.Math.Min(400, 50 × MobActionManagerBase.get_PlayerMeterDistance(mobAction) - 200)) + 300…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`max(10 × Lv + AGIรวม ÷ 5 + STRรวม ÷ 5 + DEXรวม ÷ 5 - System.Math.Max(0, System.Math.Min(400, 50 × MobActionManagerBase.get_PlayerMeterDistance(mobAction) - 200)) + 300…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]
    - ตัวปรับ `skillRate`: `max(skillRate - System.Math.Max(0, System.Math.Min(400, 50 × MobActionManagerBase.get_PlayerMeterDistance(mobAction) - 200)), 100)`

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล ลูนาดิธเธอร์สตาร์ (uid 655): `ShiningClothAction.OnInitialize` (ContainsBuffer) — ShiningClothAction: initial values — Code


---

### สตอร์มรีปเปอร์ / ออร์บิทรีปเปอร์ (SturmLeaper) · uid 653
- ทรี: สกิลดาบคู่ · เลเวลสูงสุด: 170 · อาวุธที่ใช้ได้: TwinSword
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

**ชื่อ/รูปแบบของสกิล (จากข้อความในเกม):** [N] สตอร์มรีปเปอร์ · [N2] ออร์บิทรีปเปอร์

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ DEX(ที่ลงเอง)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `10 × Lv + 100` → Lv1 110 · Lv5 150 · Lv10 200
  - ดาเมจคงที่ตีแรก (`FirstAttack`, AddConstant) `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `10 × Lv + DEX(ที่ลงเอง) ÷ 25 × Lv + 400 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณตีแรก (`FirstAttackRate`, AddRate) `PlayerAttackBase.calcFastAttackDamageRate(playerAction) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- คงกระพัน (สถานะ Invincibility) ตั้งแต่เริ่มท่า จนถอดตอนจบท่า — เพดาน 2 วินาที — Code · `ActionStart: AbnormalStateManager$$AddInvincibilityTemporarilyInAction`
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (คำอธิบาย): ติดคงกระพันขณะถอยห่าง — Text

#### 4) บัพที่ได้จากสกิลนี้
- ดาเมจระยะใกล้ % (`ShortRangeRate`) = `shortRange`
- ดาเมจระยะไกล % (`LongRangeRate`) = `longRange`
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### เซเบอร์ออร่า (SaberAura) · uid 654
- ทรี: สกิลดาบคู่ · เลเวลสูงสุด: 170 · อาวุธที่ใช้ได้: TwinSword

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv
- ความแม่น + (`HitUp`) = `Count × hitUp` — เมื่อ bufferEnd = 0
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `moveSpeed` — เมื่อ bufferEnd = 0
- ความเร็วโจมตี % (`AspdRate`) = `Count × aspdRate` — เมื่อ bufferEnd = 0
- MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = `Count × atkMpHeal` — เมื่อ bufferEnd = 0
- อัตราคริ + (`CrtUp`) = `Count × critical` — เมื่อ bufferEnd = 0

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล อาร์คเซเบอร์ (uid 657): `SaberAuraAction.ActionHit` (TryGetBuf) — Action Hit — Code
- ถูกอ่านโดย อาร์คเซเบอร์ (uid 657) ผ่าน `ArkSaberAction.ActionHit` (TryGetBuf) — Action Hit — Code
- ถูกอ่านโดย อาร์คเซเบอร์ (uid 657) ผ่าน `ArkSaberAction.ActionStart` (TryGetBuf) — ArkSaberAction: skill start — Code
- ถูกอ่านโดย อาร์คเซเบอร์ (uid 657) ผ่าน `ArkSaberAction.ConverterArkSaberSkillId` (TryGetBuf) — Converter Ark Saber Skill Id — Code
- ถูกอ่านโดย อาร์คเซเบอร์ (uid 657) ผ่าน `ArkSaberAction.IsFailure` (TryGetBuf) — predicate is failure — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.SupportReserve` (TryGetBuf) — Support Reserve — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.get_MoveSpeed` (ContainsBuffer) — Move Speed of MobaPlayerActionManager — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.get_MoveSpeed` (ContainsBuffer) — Move Speed of PlayerActionManager — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIActiveBaseShortcutButton.SkillButton` (ContainsBuffer) — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIGLShortcutButton.LabelUpdate` (ContainsBuffer) — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIGLShortcutButton.Update` (ContainsBuffer) — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIShortcutListButton.OnSkillCostCheck` (ContainsBuffer) — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIShortcutListButton.SetSkillButton` (ContainsBuffer) — Code


---

### ลูนาดิธเธอร์สตาร์ (LunaDitherStar) · uid 655
- ทรี: สกิลดาบคู่ · เลเวลสูงสุด: 250 · อาวุธที่ใช้ได้: TwinSword
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ DEXรวม
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **400** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)
  - ดาเมจคงที่ตีแรก (`FirstAttack`, AddConstant) `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `DEXรวม / 1.5 + 50 × Lv + 500 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณตีแรก (`FirstAttackRate`, AddRate) `PlayerAttackBase.calcFastAttackDamageRate(playerAction) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: ชาโดว์สเต็ป (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- อัตราคริ % (`CrtUpRate`) = `crtRate`
- MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) `Lv` → Lv1 1 · Lv5 5 · Lv10 10
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล ชาโดว์สเต็ป (uid 651): `LunaDitherStarAction.ActionSkillEvent` (GetSkillLv) — Action Skill Event — Code
- ได้รับการเสริมจากสกิล LunaDitherStarBladeRainAction (uid 671): `LunaDitherStarAction.ReceivedAbnormal` (ContainsBuffer) — Received Abnormal — Code
- ถูกอ่านโดย ไชน์นิ่งครอส / เบลซซิ่งไชน์นิ่งครอส (uid 652) ผ่าน `ShiningClothAction.OnInitialize` (ContainsBuffer) — ShiningClothAction: initial values — Code


---

### ทวินบัสตาร์ดเบลด (TwinBusterBlade) · uid 656
- ทรี: สกิลดาบคู่ · เลเวลสูงสุด: 250 · อาวุธที่ใช้ได้: TwinSword
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ AGI(ที่ลงเอง)/DEX(ที่ลงเอง)/STR(ที่ลงเอง)
- **ดาเมจหลัก** — lineAttack ≠ 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `30 × Lv` → Lv1 30 · Lv5 150 · Lv10 300
  - ดาเมจคงที่ตีแรก (`FirstAttack`, AddConstant) `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) = **500%** คงที่ทุก Lv
    - ตัวปรับ `secondSkillRate`: `min(secondSkillRate + 0.5 × STR(ที่ลงเอง) × (min(maxDebufCount, MobBuffManager.GetDebuffCount(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.Component.GetCompon…(ย่อ)` เมื่อ IsOtherPlayer = 0 และ isExorcism ≠ 0 และ param = 100 (+เงื่อนไขอื่น)
    - ตัวปรับ `secondSkillRate`: `min(secondSkillRate + 0.5 × min(maxDebufCount, MobBuffManager.GetDebuffCount(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.Component.GetComponent<EnemyMobActio…(ย่อ)` เมื่อ IsOtherPlayer = 0 และ isExorcism ≠ 0 และ param = 100 (+เงื่อนไขอื่น)
    - ตัวปรับ `secondSkillRate`: `min(secondSkillRate + 0.5 × STR(ที่ลงเอง) × (debufCount + 1), 2000)` เมื่อ IsOtherPlayer = 0 และ isExorcism ≠ 0 และ param = 100 (+เงื่อนไขอื่น)
    - ตัวปรับ `secondSkillRate`: `min(secondSkillRate + 0.5 × debufCount + 0.5, 2000)` เมื่อ IsOtherPlayer = 0 และ isExorcism ≠ 0 และ param = 100 (+เงื่อนไขอื่น)
    - ตัวปรับ `secondSkillRate`: `min(secondSkillRate + 0.5 × STR(ที่ลงเอง) × (TwinBusterBladeAction.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), MobActionManagerBase.get_transform(?…(ย่อ)` เมื่อ IsOtherPlayer = 0 และ isExorcism = 0 และ param = 100 (+เงื่อนไขอื่น)
    - ตัวปรับ `secondSkillRate`: `min(secondSkillRate + 0.5 × (TwinBusterBladeAction.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), MobActionManagerBase.get_transform(?stack), MobActio…(ย่อ)` เมื่อ IsOtherPlayer = 0 และ isExorcism = 0 และ param = 100 (+เงื่อนไขอื่น)
    - ตัวปรับ `secondSkillRate`: `min(secondSkillRate, 2000)` เมื่อ IsOtherPlayer = 0 และ isExorcism = 0 และ param = 100 (+เงื่อนไขอื่น)
    - ตัวปรับ `secondSkillRate`: `min(secondSkillRate, 2000)` เมื่อ IsOtherPlayer = 0 และ isExorcism = 0 และ param = 100 (+เงื่อนไขอื่น)
  - ตัวคูณตีแรก (`FirstAttackRate`, AddRate) `PlayerAttackBase.calcFastAttackDamageRate(playerAction) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefSkill / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(targetExpList[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ดาเมจหลัก** — lineAttack = 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `30 × Lv` → Lv1 30 · Lv5 150 · Lv10 300 — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `75 × Lv + (DEX(ที่ลงเอง) + AGI(ที่ลงเอง)) ÷ 2 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: บัสตาร์ดเบลด (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- สกิลนี้ใส่บัพของสกิล บัสตาร์ดเบลด (uid 45) — Code
- ได้รับการเสริมจากสกิล บัสตาร์ดเบลด (uid 45): `TwinBusterBladeAction.ActionStart` (ContainsBuffer) — TwinBusterBladeAction: skill start — Code
- ได้รับการเสริมจากสกิล บัสตาร์ดเบลด (uid 45): `TwinBusterBladeAction.ActionStart` (GetSkillLv) — TwinBusterBladeAction: skill start — Code


---

### อาร์คเซเบอร์ (ArkSaber) · uid 657
- ทรี: สกิลดาบคู่ · เลเวลสูงสุด: 250 · อาวุธที่ใช้ได้: TwinSword

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `barrierValue`
- MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = `atkMpRecovery`
- ตัวนับ/stack (`Count`) = `count`
- อัตราคริ + (`CrtUp`) = `critical`

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล เซเบอร์ออร่า (uid 654): `ArkSaberAction.ActionHit` (TryGetBuf) — Action Hit — Code
- ได้รับการเสริมจากสกิล เซเบอร์ออร่า (uid 654): `ArkSaberAction.ActionStart` (TryGetBuf) — ArkSaberAction: skill start — Code
- ได้รับการเสริมจากสกิล เซเบอร์ออร่า (uid 654): `ArkSaberAction.ConverterArkSaberSkillId` (TryGetBuf) — Converter Ark Saber Skill Id — Code
- ได้รับการเสริมจากสกิล เซเบอร์ออร่า (uid 654): `ArkSaberAction.IsFailure` (TryGetBuf) — predicate is failure — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobAttackBase.CalcLastDamage` (TryGetBuf) — calculate last damage — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.SupportReserve` (GetSkillLv) — Support Reserve — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerSecondaryStatus.GetCrtConstant` (TryGetBuf) — Get Crt Constant — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.CalcCostMp` (ContainsBuffer) — Skill MP cost — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.RemoveAfterSkillBuf` (ContainsBuffer) — Remove After Skill Buf — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerDataManager.OnSkillBuffEnd` (TryGetBuf) — On Skill Buff End — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.GetCrtConstant` (TryGetBuf) — Get Crt Constant — Code
- ถูกอ่านโดย เซเบอร์ออร่า (uid 654) ผ่าน `SaberAuraAction.ActionHit` (TryGetBuf) — Action Hit — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIActiveBaseShortcutButton.SkillButton` (GetSkillLv) — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIGLShortcutButton.LabelUpdate` (GetSkillLv) — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIShortcutListButton.OnSkillCostCheck` (ContainsBuffer) — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIShortcutListButton.OnSkillCostCheck` (GetSkillLv) — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIShortcutListButton.SetSkillButton` (GetSkillLv) — Code


---

### แอร์สไลเซอร์ (AirSlicer) · uid 658
- ทรี: สกิลดาบคู่ · เลเวลสูงสุด: 250 · อาวุธที่ใช้ได้: TwinSword
- ประเภทดาเมจ: กายภาพ; ช่อง proration เป็นช่องเวท (ctor expType=2) · Proration: Magic (ctor sets expType=2) (every_hit + class check)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ STR(ที่ลงเอง)
- **ฮิต 1**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `5 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.AirSlide, 1) + 50` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `4 × โบนัสคริสตัล#210[4] + 6 × (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.AirSlide, 1)) + int(2.5 × (SkillManager.GetSkillLv(PlayerStatusBase…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ฮิต 2**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `20 × Lv` → Lv1 20 · Lv5 100 · Lv10 200
  - ตัวคูณสกิล (`SkillRate`, AddRate) `max(STR(ที่ลงเอง) × ((20 × max(int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7, 0)) < 100 ? 100 - (20 × max(int(MathUtil.DistanceToDisplayMeter(startTargetDi…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `secondSkillRateBonus`: `max(secondSkillRateBonus × ((20 × max(int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7, 0)) < 100 ? 100 - (20 × max(int(MathUtil.DistanceToDisplayMeter(startT…(ย่อ)`
  - ตัวคูณคริเพิ่ม (`CriticalRate`, AddRate) `max((((5 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.TwinSlash, 1) + 50) < 0 ? 5 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- สถานะผิดปกติที่ติดเป้า:
  - ตาบอด โอกาส `int(2.5 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.AirSlide, 1)) + 15` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: สปินนิ่งสแลช (Skill), ทวินสแลช (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล ทวินสแลช (uid 642): `AirSlicerAction.OnInitialize` (GetSkillLv) — AirSlicerAction: initial values — Code
- ได้รับการเสริมจากสกิล สปินนิ่งสแลช (uid 646): `AirSlicerAction.OnInitialize` (GetSkillLv) — AirSlicerAction: initial values — Code


---

### เอเลียสลีย์ (ArialSlay) · uid 659
- ทรี: สกิลดาบคู่ · เลเวลสูงสุด: 170 · อาวุธที่ใช้ได้: ดาบมือเดียว, TwinSword
- ประเภทดาเมจ: กายภาพ; เวทเมื่อถือ magic tool มือรอง · Proration: dynamic (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ DEXรวม/STR(ที่ลงเอง), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `fixAddDamage` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว + มือรองที่ไม่ใช่ มีด] `skillRate %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว + มือรอง มีด] `50 × Lv + System.Math.Max(DEXรวม, STR(ที่ลงเอง)) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - (`MobLastDamageRate*` เข้าสูตรดาเมจที่มอนทำใส่ผู้เล่นใน `MobAttackBase.CalcLastDamage` — ค่านี้คือส่วนลดดาเมจที่ได้รับ; หน่วยและการรวมกับบัพอื่นยังไม่ยืนยัน — Inferred)
  - ตัวคูณดาเมจที่ได้รับจากมอน (หมวดบัพ) (`MobLastDamageRateBuf`) = `System.Math.Min(2 × (ItemData.get_Refine(subWeapon) & 255), 30)` — เมื่อ subWeapon.Type = 17
- ข้อความในเกม (คำอธิบาย): สามารถเคลื่อนที่ได้ขณะใช้สกิล — Text
- ข้อความในเกม (Lv17): ระหว่างใช้งานจะได้รับการต้านทานความเสียหายและ — Text
- ข้อความในเกม (Lv17): ต้านทานผลกระทบที่ทำให้ไม่สามารถเคลื่อนไหวได้ตามค่าถลุง — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: `MobAttackBase.CalcLastDamage` — Inferred

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล ฟาเรส (uid 519): `ArialSlayAction.ActionStart` (ContainsBuffer) — ArialSlayAction: skill start — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobAttackBase.CalcLastDamage` (TryGetBuf) — calculate last damage — Code


---

### ฮอร์ริซอนคัท (HorizontalCut) · uid 660
- ทรี: สกิลดาบคู่ · เลเวลสูงสุด: 250 · อาวุธที่ใช้ได้: ดาบมือเดียว, TwinSword
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (never (IsExpDefFluctuate=false))

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ AGI(ที่ลงเอง)/DEXรวม/STR(ที่ลงเอง), อาวุธหลัก/รองที่ถือ
- **ฮิต 1**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [ดาบมือเดียว + มือรองที่ไม่ใช่ ดาบมือเดียว] `60 × Lv` → Lv1 60 · Lv5 300 · Lv10 600
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [ดาบคู่ (ดาบมือเดียว 2 เล่ม)] `60 × Lv ÷ 2` → Lv1 30 · Lv5 150 · Lv10 300
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว + มือรองที่ไม่ใช่ ดาบมือเดียว] `10 × Lv + DEXรวม + 900 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบคู่ (ดาบมือเดียว 2 เล่ม)] `(10 × Lv + DEXรวม + 900) ÷ 2 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ฮิต 2**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [ดาบมือเดียว + มือรองที่ไม่ใช่ ดาบมือเดียว] `secondFixDamage` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [ดาบคู่ (ดาบมือเดียว 2 เล่ม)] `30 × Lv` → Lv1 30 · Lv5 150 · Lv10 300
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว + มือรองที่ไม่ใช่ ดาบมือเดียว] `secondSkillRate %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบคู่ (ดาบมือเดียว 2 เล่ม)] `50 × Lv + max(STR(ที่ลงเอง), AGI(ที่ลงเอง)) ÷ 2 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: เบอร์เซิร์ก (Skill)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล เบอร์เซิร์ก (uid 46): `HorizontalCutAction.Damaged` (ContainsBuffer) — HorizontalCutAction: on damaged — Code
- ได้รับการเสริมจากสกิล เบอร์เซิร์ก (uid 46): `HorizontalCutAction.Damaged` (GetSkillLv) — HorizontalCutAction: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.RemoveAfterSkillBuf` (ContainsBuffer) — Remove After Skill Buf — Code


---

### เบลดสตริงเกอร์ (BladeStinger) · uid 661
- ทรี: สกิลดาบคู่ · เลเวลสูงสุด: 250 · อาวุธที่ใช้ได้: ดาบมือเดียว, TwinSword
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ AGIรวม/DEXรวม, อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **100** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว + มือรองที่ไม่ใช่ ดาบมือเดียว] [`DEXรวม + 40 × Lv + 300 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] หรือ [`min(10 × buffParam(PowerResistBreaker) + 10 × BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), BonusType.bPowerResistBreaker) + 40 × Lv - 900, 500) + DE…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบคู่ (ดาบมือเดียว 2 เล่ม)] [`40 × Lv + 300 %` → Lv1 340% · Lv5 500% · Lv10 700%] หรือ [`min(10 × buffParam(PowerResistBreaker) + 10 × BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), BonusType.bPowerResistBreaker) + 40 × Lv - 900, 500) + 40…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`AGIรวม + 300 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] หรือ [`min(10 × buffParam(PowerResistBreaker) + 10 × BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), BonusType.bPowerResistBreaker) + 40 × Lv - 900, 500) + AG…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว + มือรองที่ไม่ใช่ ดาบมือเดียว] `DEXรวม + 40 × Lv + 300 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบคู่ (ดาบมือเดียว 2 เล่ม)] `40 × Lv + 300 %` → Lv1 340% · Lv5 500% · Lv10 700% — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `AGIรวม + 300 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - หักป้องกันเป้า (`Def`, SetConstant) `-PlayerAttackBase.CalcRegistDamage(this, SkillAttackType.Physics, PlayerActionManagerBase.get_PlayerStatus(), MobActionManagerBase.get_MobBattleStatus(mobAction))` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---
