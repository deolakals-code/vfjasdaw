# สกิลอีเวนต์/คอลแลบ (5 สกิล)

สรุปโดยรวมต่อสกิล: ตัวคูณดาเมจมาจากไหน / แยกอาวุธ / สถานะระหว่างท่า / บัพ / เชื่อมสกิลอื่น. วิธีอ่าน: [ENGINE.md](ENGINE.md)

### เอ็กซ์โพชั่น (Explosion) · uid 1281
- ทรี: สกิลอีเวนต์/คอลแลบ · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [= **1000** คงที่ทุก Lv] หรือ [= **100** คงที่ทุก Lv]
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`300 × System.Math.Max(PlayerAttackBase.CalcCostMp(this, actarAction), 100) ÷ 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] หรือ [`100 × System.Math.Max(PlayerAttackBase.CalcCostMp(this, actarAction), 100) ÷ 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)]

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ไลท์ออฟเซเบอร์ (LightOfSaber) · uid 1282
- ทรี: สกิลอีเวนต์/คอลแลบ · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [= **600** คงที่ทุก Lv] หรือ [= **300** คงที่ทุก Lv]
  - ตัวคูณสกิล (`SkillRate`, AddRate) [= **700%** คงที่ทุก Lv] หรือ [= **350%** คงที่ทุก Lv]
    - ตัวปรับ `skillRate`: `skillRate - 100 × PartyManager.get_PartyMemberNum(Singleton<PartyManager>.get_Instance()) + 100` เมื่อ (+เงื่อนไขอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### Morning Star (MorningStar) · uid 1283
- ทรี: สกิลอีเวนต์/คอลแลบ · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **100** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`30 × Lv + status.Lv ÷ 4 + 300 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] หรือ [`30 × Lv + status.Lv ÷ 4 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] — เมื่อ (+เงื่อนไขอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - (`MobLastDamageRate*` เข้าสูตรดาเมจที่มอนทำใส่ผู้เล่นใน `MobAttackBase.CalcLastDamage` — ค่านี้คือส่วนลดดาเมจที่ได้รับ; หน่วยและการรวมกับบัพอื่นยังไม่ยืนยัน — Inferred)
  - ตัวคูณดาเมจที่ได้รับจากมอน (หมวดบัพ) (`MobLastDamageRateBuf`) = `damageCut`

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (DivaCheering) · uid 1284
- ทรี: สกิลอีเวนต์/คอลแลบ · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 4) บัพที่ได้จากสกิลนี้
- ความเร็วร่าย + (`CspdUp`) = `cspd`
- ดาเมจสุดท้ายที่ทำ % (`LastDmgUpRate`) = `lastDamageRate`
- ความเร็วโจมตี + (`Aspd`) = `aspd`
- MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = `atkMpHeal`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `NewWaveRoomData.ReceiveMinusHateEvent` (ContainsBuffer) — Receive Minus Hate Event — Code


---

### ดราก้อนสเลฟ / ดราก้อนสเลฟ (DragSlave) · uid 1285
- ทรี: สกิลอีเวนต์/คอลแลบ · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target)

**ชื่อ/รูปแบบของสกิล (จากข้อความในเกม):** [N] ดราก้อนสเลฟ · [N2] ดราก้อนสเลฟ

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- **ดาเมจหลัก** — first = 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `50 × PlayerAttackBase.get_Mp() ÷ 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`(int(((((PlayerSecondaryStatus.CalcBaseMaxMp(PlayerStatusBase.get_SecondaryStatus()) / 20) * 0.5) * (PlayerAttackBase.CalcCostMp(this, actarAction) / 200)) + (((Player…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] หรือ [`int(((((PlayerSecondaryStatus.CalcBaseMaxMp(PlayerStatusBase.get_SecondaryStatus()) / 20) * 0.5) * (PlayerAttackBase.CalcCostMp(this, actarAction) / 200)) + (((PlayerS…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)]
  - Proration (`ExpRate`, SetRate) `proration ช่องเวทของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(targetMagicExpList[MobActionManagerBase.get_gameObject(mobAction)] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - โบนัสธาตุ (`ElementBonusRate`, AddRate) = **0.25** คงที่ทุก Lv — เมื่อ target.Element = 7
- สถานะผิดปกติที่ติดเป้า:
  - ล่มสลาย โอกาส = **100** คงที่ทุก Lv
  - เกราะแตก โอกาส `min(PlayerAttackBase.CalcCostMp(this, actarAction) ÷ 10, 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---
