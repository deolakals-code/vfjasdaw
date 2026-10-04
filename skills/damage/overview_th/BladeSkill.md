# สกิลดาบ (24 สกิล)

สรุปโดยรวมต่อสกิล: ตัวคูณดาเมจมาจากไหน / แยกอาวุธ / สถานะระหว่างท่า / บัพ / เชื่อมสกิลอื่น. วิธีอ่าน: [ENGINE.md](ENGINE.md)

### ฮาร์ดฮิต (HardHit) · uid 33
- ทรี: สกิลดาบ · เลเวลสูงสุด: 10 · อาวุธที่ใช้ได้: ดาบมือเดียว, ดาบสองมือ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `5 × Lv + 50` → Lv1 55 · Lv5 75 · Lv10 100
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว] `5 × Lv + โบนัสคริสตัล#101[4] + 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบสองมือ] `5 × Lv + โบนัสคริสตัล#101[4] + 150 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- สถานะผิดปกติที่ติดเป้า:
  - ผงะ [ดาบมือเดียว] โอกาส `int(floor(4.5 × Lv + 0.5)) + 55` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ผงะ [ดาบสองมือ] โอกาส `int(floor(4.5 × Lv + 0.5)) + 5` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### แอสทิวท์ (Astute) · uid 34
- ทรี: สกิลดาบ · เลเวลสูงสุด: 10 · อาวุธที่ใช้ได้: ดาบมือเดียว, ดาบสองมือ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `5 × Lv + 150` → Lv1 155 · Lv5 175 · Lv10 200
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว] `10 × Lv + 150 %` → Lv1 160% · Lv5 200% · Lv10 250%
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบสองมือ] `10 × Lv + 200 %` → Lv1 210% · Lv5 250% · Lv10 300%

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- อัตราคริ + (`CrtUp`) = **25** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.ReceiveAttack` (GetSkillLv) — Receive Attack — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PetStatus.get_Critical` (ContainsBuffer) — Critical of PetStatus — Code


---

### โซนิคเบรด (AccelBlade) · uid 35
- ทรี: สกิลดาบ · เลเวลสูงสุด: 10 · อาวุธที่ใช้ได้: ดาบมือเดียว, ดาบสองมือ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `5 × Lv + 100` → Lv1 105 · Lv5 125 · Lv10 150
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว] `5 × Lv + 100 %` → Lv1 105% · Lv5 125% · Lv10 150%
    - ตัวปรับ `skillRate`: `(skillRate + min(((((MathUtil.DistanceToDisplayMeter(ActionRange) mi MathUtil.DisplayDistance(0, ?mi, UnityEngine.Transform.get_position(UnityEngine.Component.get_tran…(ย่อ)` เมื่อ ActionRange = inf และ rank ≠ 0 (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบสองมือ] `5 × Lv + 150 %` → Lv1 155% · Lv5 175% · Lv10 200%
    - ตัวปรับ `skillRate`: `(skillRate + min(((((MathUtil.DistanceToDisplayMeter(ActionRange) mi MathUtil.DisplayDistance(0, ?mi, UnityEngine.Transform.get_position(UnityEngine.Component.get_tran…(ย่อ)` เมื่อ ActionRange = inf และ rank ≠ 0 (+เงื่อนไขอื่น)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ซอร์ดมาสเตอรี่ (BladeMastery) · uid 36
- ทรี: สกิลดาบ · เลเวลสูงสุด: 10 · อาวุธที่ใช้ได้: ดาบมือเดียว, ดาบสองมือ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ATK อาวุธ % (`EqAtkRate`) → Lv1 3 · Lv5 15 · Lv10 30 — Code
- พาสซีฟ/มาสเตอรี่: ATK % (`AtkRate`) → Lv1 1 · Lv5 1 · Lv10 2 — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ควิกสแลช (SpeedyBladeMastery) · uid 37
- ทรี: สกิลดาบ · เลเวลสูงสุด: 10 · อาวุธที่ใช้ได้: ดาบมือเดียว, ดาบสองมือ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ความเร็วโจมตี + (`Aspd`) → Lv1 10 · Lv5 50 · Lv10 100 — Code
- พาสซีฟ/มาสเตอรี่: ความเร็วโจมตี % (`AspdRate`) → Lv1 1 · Lv5 5 · Lv10 10 — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ทริกเกอร์สแลช (TriggerSlash) · uid 38
- ทรี: สกิลดาบ · เลเวลสูงสุด: 30 · อาวุธที่ใช้ได้: ดาบมือเดียว, ดาบสองมือ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `10 × Lv + 200` → Lv1 210 · Lv5 250 · Lv10 300
  - ตัวคูณสกิล (`SkillRate`, AddRate) `mainWeapon = TwoHandSword ? 5 × Lv + 250 : 5 × Lv + 150 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) `2 × Lv` → Lv1 2 · Lv5 10 · Lv10 20
- ความเร็วท่าทาง + (`MotionSpeed`) = **50** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### สไปรัลแอร์ (SpiralAir) · uid 39
- ทรี: สกิลดาบ · เลเวลสูงสุด: 30 · อาวุธที่ใช้ได้: ดาบมือเดียว, ดาบสองมือ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก** — hitCount ≥ 1
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `fixAddDamage` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว] `6 × Lv + โบนัสคริสตัล#202[4] + 20 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบสองมือ] `6 × Lv + โบนัสคริสตัล#202[4] + 25 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, SetRate) `100 × PlayerAttackBase.CalcLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus(), SpiralAirAction.get_AttackType()) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ความเสถียร (`StableRate`, SetRate) `100 × PlayerAttackBase.CalcStable(SpiralAirAction.get_AttackType(), status.Stable, SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new, Skil…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- CrtDamageUp (`CrtDamageUp`) = `criticalDamage`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerSecondaryStatus.get_CriticalDmg` (TryGetBuf) — Critical Dmg of MobaPlayerSecondaryStatus — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.CalcCriticalDmg` (TryGetBuf) — calculate critical dmg — Code


---

### ซอร์ดเทคนิก (BladeMasterMastery) · uid 40
- ทรี: สกิลดาบ · เลเวลสูงสุด: 30 · อาวุธที่ใช้ได้: ดาบมือเดียว, ดาบสองมือ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ดาเมจสุดท้าย % (`LastDmgRate`) → Lv1 2 · Lv5 10 · Lv10 20 — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### รัมเพจ (Rampage) · uid 41
- ทรี: สกิลดาบ · เลเวลสูงสุด: 70 · อาวุธที่ใช้ได้: ดาบมือเดียว, ดาบสองมือ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `isFinish`
- ค่าทั่วไปตัวที่ 2 (`Value2`) `(Lv > 6 ? Lv : 6) + 2 × Lv - 5` → Lv1 3 · Lv5 11 · Lv10 25
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล เบอร์เซิร์ก (uid 46): `RampageAction.ReceivedAbnormal` (ContainsBuffer) — Received Abnormal — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `GemCartBuffer.BerserkSuppressionBuff.Exemption` (ContainsBuffer) — Exemption — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `NormalAttackAction.OnInitialize` (TryGetBuf) — NormalAttackAction: initial values — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.get_AtkMpRecovery` (TryGetBuf) — Atk Mp Recovery of PlayerSecondaryStatus — Code


---

### ซอร์ดเทมเพสต์ (SwordTempest) · uid 42
- ทรี: สกิลดาบ · เลเวลสูงสุด: 70 · อาวุธที่ใช้ได้: ดาบมือเดียว, ดาบสองมือ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ DEX(ที่ลงเอง)/STR(ที่ลงเอง), อาวุธหลัก/รองที่ถือ
- **ฮิต 1**
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว] `10 × Lv + 150 %` → Lv1 160% · Lv5 200% · Lv10 250%
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบสองมือ] `10 × Lv + STR(ที่ลงเอง) ÷ 5 + 250 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(proration ที่เก็บไว้ตอนร่าย[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ฮิตถัดไป**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **80** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว] `5 × Lv + DEX(ที่ลงเอง) ÷ 5 + 50 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบสองมือ] `5 × Lv + 50 %` → Lv1 55% · Lv5 75% · Lv10 100%
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(proration ที่เก็บไว้ตอนร่าย[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- สถานะผิดปกติที่ติดเป้า:
  - Suction โอกาส `MobActionManagerBase.get_IsBoss(mobAction) ? 50 : 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### วอร์คราย (WarCry) · uid 43
- ทรี: สกิลดาบ · เลเวลสูงสุด: 70 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: ไนท์วีล (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ATK % (`AtkUpRate`) = `(equip = 11 ? 5 : 0) + Lv`

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล ไนท์วีล (uid 520): `WarCryAction.ActionPreparation` (GetSkillLv) — WarCryAction: preparation — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `KnightStanceBuf.GetFearResistValue` (ContainsBuffer) — Get Fear Resist Value — Code


---

### เมเทโอเบรคเกอร์ (MeteorBreaker) · uid 44
- ทรี: สกิลดาบ · เลเวลสูงสุด: 150 · อาวุธที่ใช้ได้: ดาบมือเดียว, ดาบสองมือ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ DEX(ที่ลงเอง)/STR(ที่ลงเอง), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก** — isFirstAttack ≠ 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `20 × Lv + 400` → Lv1 420 · Lv5 500 · Lv10 600
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว] `20 × Lv + 400 %` → Lv1 420% · Lv5 500% · Lv10 600%
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบสองมือ] `20 × Lv + STR(ที่ลงเอง) ÷ 10 + 600 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ดาเมจหลัก**
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ดาเมจหลัก** — isFirstAttack = 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **0** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว + มือรองที่ไม่ใช่ ดาบมือเดียว] `50 × Lv + DEX(ที่ลงเอง) ÷ 2 + 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบคู่ (ดาบมือเดียว 2 เล่ม) | ดาบสองมือ] `50 × Lv + 100 %` → Lv1 150% · Lv5 350% · Lv10 600%
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ ตัวที่โดนคือเป้าหลัก
- สถานะผิดปกติที่ติดเป้า:
  - มึนงง [ดาบมือเดียว] โอกาส `int(0.5 × Lv) + 2 × Lv + 75` → Lv1 77 · Lv5 87 · Lv10 100
  - มึนงง [ดาบสองมือ] โอกาส `int(0.5 × Lv) + 2 × Lv` → Lv1 2 · Lv5 12 · Lv10 25

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- คงกระพัน (สถานะ Invincibility) ตั้งแต่เริ่มท่า จนถอดตอนจบท่า — เพดาน 2 วินาที — Code · `ActionStart: AbnormalStateManager$$AddInvincibilityTemporarilyInAction`
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (คำอธิบาย): มีสถานะคงกระพันระหว่างใช้สกิล — Text

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### บัสตาร์ดเบลด (BusterBlade) · uid 45
- ทรี: สกิลดาบ · เลเวลสูงสุด: 150 · อาวุธที่ใช้ได้: ดาบมือเดียว, ดาบสองมือ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ DEX(ที่ลงเอง)/STR(ที่ลงเอง), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `30 × Lv` → Lv1 30 · Lv5 150 · Lv10 300
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว + มือรองที่ไม่ใช่ ดาบมือเดียว] [`75 × Lv + 2 × (DEX(ที่ลงเอง) ÷ 2) + 20 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.AuraBlade, 1) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`75 × Lv + DEX(ที่ลงเอง) ÷ 2 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบคู่ (ดาบมือเดียว 2 เล่ม)] [`75 × Lv + 20 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.AuraBlade, 1) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`75 × Lv %` → Lv1 75% · Lv5 375% · Lv10 750% — เมื่อ (+เงื่อนไขอื่น)]
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบสองมือ] `75 × Lv + STR(ที่ลงเอง) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: ออร่าเบลด (Skill)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ATK อาวุธ % (`EqAtkUpRate`) = `eqAtkRate`

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล ออร่าเบลด (uid 50): `BusterBladeAction.OnInitialize` (GetSkillLv) — BusterBladeAction: initial values — Code
- ถูกอ่านโดย ทวินบัสตาร์ดเบลด (uid 656) ผ่าน `TwinBusterBladeAction.ActionStart` (ContainsBuffer) — TwinBusterBladeAction: skill start — Code
- ถูกอ่านโดย ทวินบัสตาร์ดเบลด (uid 656) ผ่าน `TwinBusterBladeAction.ActionStart` (GetSkillLv) — TwinBusterBladeAction: skill start — Code


---

### เบอร์เซิร์ก (Berserk) · uid 46
- ทรี: สกิลดาบ · เลเวลสูงสุด: 150 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - MDEF % (`MdefRate`) = `-max(defRate - damageCount × reduceValue, 0)`
  - DEF % (`DefRate`) = `-max(defRate - damageCount × reduceValue, 0)`

#### 4) บัพที่ได้จากสกิลนี้
- ตัวคูณตีปกติ % (`NormalAttackRate`) = `normalAttackRate`
- ความเสถียร (`Stable`) = `-max(stable - damageCount × reduceValue, 0)`
- ความเร็วโจมตี % (`AspdRate`) = `aspdRate`
- ความเร็วโจมตี + (`Aspd`) = `aspd`
- อัตราคริ + (`CrtUp`) = `critical`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `AutoMemberActionManager.Damaged` (ContainsBuffer) — AutoMemberActionManager: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `GemCartBuffer.BerserkSuppressionBuff.Exemption` (ContainsBuffer) — Exemption — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `GemCartBuffer.BerserkSuppressionBuff.Exemption` (GetSkillLv) — Exemption — Code
- ถูกอ่านโดย ฮอร์ริซอนคัท (uid 660) ผ่าน `HorizontalCutAction.Damaged` (ContainsBuffer) — HorizontalCutAction: on damaged — Code
- ถูกอ่านโดย ฮอร์ริซอนคัท (uid 660) ผ่าน `HorizontalCutAction.Damaged` (GetSkillLv) — HorizontalCutAction: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MercenaryActionManager.Damaged` (ContainsBuffer) — MercenaryActionManager: on damaged — Code
- ถูกอ่านโดย รัมเพจ (uid 41) ผ่าน `RampageAction.ReceivedAbnormal` (ContainsBuffer) — Received Abnormal — Code
- ถูกอ่านโดย แซครีไฟซ์ (uid 1058) ผ่าน `SacrificeAction.ActionStart` (GetSkillLv) — SacrificeAction: skill start — Code
- ถูกอ่านโดย แซครีไฟซ์ (uid 1058) ผ่าน `SacrificeAction.StrengthPayHp` (ContainsBuffer) — Strength Pay Hp — Code
- ถูกอ่านโดย ไคริกิรันชิน (uid 622) ผ่าน `WeirdnessOfGodAction.ActionStart` (GetSkillLv) — WeirdnessOfGodAction: skill start — Code
- ถูกอ่านโดย ไคริกิรันชิน (uid 622) ผ่าน `WeirdnessOfGodAction.EffectiveAbnormalIgnition` (ContainsBuffer) — Effective Abnormal Ignition — Code


---

### ฟาสต์แอคแทค (FastAttack) · uid 47
- ทรี: สกิลดาบ · เลเวลสูงสุด: 70 · อาวุธที่ใช้ได้: ดาบมือเดียว, ดาบสองมือ
- ประเภทดาเมจ: ธรรมดา (SkillNormal) · Proration: ช่องตีปกติ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ AGIรวม/DEXรวม/STRรวม, อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `System.Math.Min(300, 3 × (Lv + 1) × (Lv + 1))` → Lv1 12 · Lv5 108 · Lv10 300
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว + มือรองที่ไม่ใช่ ดาบมือเดียว] `System.Math.Min(50, 5 × Lv + 5) + DEXรวม ÷ 5 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบคู่ (ดาบมือเดียว 2 เล่ม)] `System.Math.Min(50, 5 × Lv + 5) + AGIรวม ÷ 5 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบสองมือ] `System.Math.Min(50, 5 × Lv + 5) + STRรวม ÷ 5 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- สถานะผิดปกติที่ติดเป้า:
  - ล้มคว่ำ [ดาบมือเดียว + มือรองที่ไม่ใช่ ดาบมือเดียว | ดาบสองมือ] โอกาส `percent` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ล้มคว่ำ [ดาบคู่ (ดาบมือเดียว 2 เล่ม)] โอกาส `5 × Lv + 50` → Lv1 55 · Lv5 75 · Lv10 100

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.CalcCostMp` (ContainsBuffer) — Skill MP cost — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.RemoveAfterSkillBuf` (ContainsBuffer) — Remove After Skill Buf — Code


---

### ชัทเอาท์ (ShutOut) · uid 48
- ทรี: สกิลดาบ · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: ดาบมือเดียว, ดาบสองมือ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ AGI(ที่ลงเอง)/DEX(ที่ลงเอง), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [ดาบมือเดียว + มือรองที่ไม่ใช่ ดาบมือเดียว | ดาบสองมือ] = **100** คงที่ทุก Lv
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [ดาบคู่ (ดาบมือเดียว 2 เล่ม)] = **200** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว + มือรองที่ไม่ใช่ ดาบมือเดียว] `DEX(ที่ลงเอง) ÷ 2 + 500 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบคู่ (ดาบมือเดียว 2 เล่ม)] `AGI(ที่ลงเอง) ÷ 4 + 500 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบสองมือ] `100 × Lv + 500 %` → Lv1 600% · Lv5 1000% · Lv10 1500%
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว + มือรองที่ไม่ใช่ ดาบมือเดียว] `150 × Lv + DEX(ที่ลงเอง) ÷ 2 + 500 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ bleed ≠ 0 (+เงื่อนไขอื่น) หรือ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบคู่ (ดาบมือเดียว 2 เล่ม)] `150 × Lv + AGI(ที่ลงเอง) ÷ 4 + 500 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ bleed ≠ 0 (+เงื่อนไขอื่น) หรือ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบสองมือ] = **500%** คงที่ทุก Lv — เมื่อ bleed ≠ 0 (+เงื่อนไขอื่น) หรือ (+เงื่อนไขอื่น)
  - หักป้องกันเป้า (`Def`, SetConstant) `-ShutOutAction.CalcBonusResistDamage(this, PlayerActionManagerBase.get_PlayerStatus(), MobActionManagerBase.get_MobBattleStatus(mobAction))` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ bleed ≠ 0 (+เงื่อนไขอื่น) หรือ (+เงื่อนไขอื่น)
- สถานะผิดปกติที่ติดเป้า:
  - เลือดไหล โอกาส = **100** คงที่ทุก Lv

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ลูนาร์สแลช (MoonSlash) · uid 49
- ทรี: สกิลดาบ · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: ดาบมือเดียว, ดาบสองมือ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ INT(ที่ลงเอง)/STRรวม, อาวุธหลัก/รองที่ถือ
- **CalcFirstDamageData**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **400** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) = **1000%** คงที่ทุก Lv
- **CalcSecondDamageData**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `INT(ที่ลงเอง) ÷ 2` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `0.1 × STRรวม × Lv %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- สถานะผิดปกติที่ติดเป้า:
  - Tiredness [ดาบมือเดียว + มือรองที่ไม่ใช่ ดาบมือเดียว | ดาบสองมือ] โอกาส `5 × Lv + DEX(ที่ลงเอง) ÷ 10 - 1` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Tiredness [ดาบคู่ (ดาบมือเดียว 2 เล่ม)] โอกาส `(5 × Lv + DEX(ที่ลงเอง) ÷ 10 - 1) ÷ 2` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ออร่าเบลด (AuraBlade) · uid 50
- ทรี: สกิลดาบ · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: ดาบมือเดียว, ดาบสองมือ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **200** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `100 × Lv + 500 %` → Lv1 600% · Lv5 1000% · Lv10 1500%

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `lastDamageRate`
- PhysicalPursuitSkillRate (`PhysicalPursuitSkillRate`) = `percent`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย บัสตาร์ดเบลด (uid 45) ผ่าน `BusterBladeAction.OnInitialize` (GetSkillLv) — BusterBladeAction: initial values — Code
- ถูกอ่านโดย PhysicalPursuitAction (uid 11) ผ่าน `PhysicalPursuitAction.calcPlayerToMobDamage` (TryGetBuf) — PhysicalPursuitAction: player→mob damage template — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.ApplyAuraBlade` (TryGetBuf) — Apply Aura Blade — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.PursuitAttack` (ContainsBuffer) — Pursuit Attack — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIPlayerStatusDetailPanel.CalcPhysicalPursuitValue` (TryGetBuf) — Code


---

### แกลดดีเอท (Gladiate) · uid 51
- ทรี: สกิลดาบ · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: ดาบมือเดียว, ดาบสองมือ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - (`MobLastDamageRate*` เข้าสูตรดาเมจที่มอนทำใส่ผู้เล่นใน `MobAttackBase.CalcLastDamage` — ค่านี้คือส่วนลดดาเมจที่ได้รับ; หน่วยและการรวมกับบัพอื่นยังไม่ยืนยัน — Inferred)
  - ตัวคูณดาเมจที่ได้รับจากมอน (หมวดบัพ) (`MobLastDamageRateBuf`) = `damageReduction`
- ข้อความในเกม (คำอธิบาย): ลดความเสียหายที่ได้รับตามจำนวนครั้งที่กำหนด — Text
- ข้อความในเกม (คำอธิบาย): เป็นเวลา 10 วินาที MP จะฟื้นฟูเล็กน้อยเมื่อลดความเสียหาย — Text
- ข้อความในเกม (Lv10): ปริมาณการฟื้นฟู MP จะเพิ่มขึ้นเมื่อความเสียหายลดลง — Text
- ข้อความในเกม (Lv10): ปริมาณการฟื้นฟู MP จะลดลงครึ่งหนึ่งเมื่อความเสียหายลดลง — Text
- ข้อความในเกม (Lv10): การลดความเสียหายเพิ่มเป็น 2 เท่า — Text
- ข้อความในเกม (Lv11): ปริมาณการฟื้นฟู MP จะเพิ่มขึ้นเล็กน้อยเมื่อความเสียหายลดลง — Text
- ข้อความในเกม (Lv11): การลดความเสียหายเพิ่มเป็น 2 เท่า — Text
- ข้อความในเกม (Lv17): การลดความเสียหายเพิ่มเป็น 2 เท่า — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: `MobAttackBase.CalcLastDamage` — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobAttackBase.CalcLastDamage` (TryGetBuf) — calculate last damage — Code


---

### แฮมเมอร์สแลม (HammerDown) · uid 52
- ทรี: สกิลดาบ · เลเวลสูงสุด: 10 · อาวุธที่ใช้ได้: ดาบสองมือ
- ประเภทดาเมจ: กายภาพ; เป็นธรรมดาเมื่อเข้าเงื่อนไขบัฟตอนเตรียมสกิล · Proration: dynamic (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ STR(ที่ลงเอง)/VITรวม
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **100** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `5 × Lv + VITรวม + STR(ที่ลงเอง) ÷ 5 + 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) = **1** คงที่ทุก Lv — เมื่อ continuousUse ≠ 0

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.RemoveAfterSkillBuf` (ContainsBuffer) — Remove After Skill Buf — Code


---

### คลีฟวิงแอคแทค (CleaveAttack) · uid 53
- ทรี: สกิลดาบ · เลเวลสูงสุด: 30 · อาวุธที่ใช้ได้: ดาบสองมือ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ STRรวม/VITรวม
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `VITรวม + 15 × Lv + 150` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `min(10 × Lv + STRรวม ÷ 2 + 150, 1000) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `bonusSkillRate`: `bonusSkillRate × targetNum` เมื่อ (IsOtherPlayer = 0 และ param = 100 และ targetNum ≤ 0) หรือ (IsOtherPlayer = 0 และ param = 100 และ targetNum > 0 (+เงื่อนไขอื่น))

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### สตรอมเบลซ (StormBlazer) · uid 54
- ทรี: สกิลดาบ · เลเวลสูงสุด: 70 · อาวุธที่ใช้ได้: ดาบสองมือ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ VITรวม
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `VITรวม + 10 × Lv + 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `5 × Lv + 50 %` → Lv1 55% · Lv5 75% · Lv10 100%
    - ตัวปรับ `skillRate`: `skillRate × StormBlazerBuf.Pay(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 54))` เมื่อ (+เงื่อนไขอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### การ์ดเบลด (GuardyBlade) · uid 55
- ทรี: สกิลดาบ · เลเวลสูงสุด: 150 · อาวุธที่ใช้ได้: ดาบสองมือ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - ลดดาเมจกายภาพที่ได้รับ (`PowerDmgCut`) = `physicsResist`
  - ลดดาเมจเวทที่ได้รับ (`MagicDmgCut`) = `magicResist`
- ข้อความในเกม (คำอธิบาย): เป็นเวลา 70 วินาที ความต้านทานกายภาพ/เวท — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: `MobAttackBase.SetAbnormalEffect` — Inferred

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `EquipItemData.CalcEqDef` (ContainsBuffer) — calculate eq def — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobAttackBase.SetAbnormalEffect` (ContainsBuffer) — Set Abnormal Effect — Code


---

### ออร์คสแลช (Orgaslash) · uid 56
- ทรี: สกิลดาบ · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: ดาบสองมือ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: สถานะ DEXรวม/STR(ที่ลงเอง)/VIT(ที่ลงเอง)
- **ดาเมจหลัก** — singleAttack ≠ 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `DEXรวม` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `VIT(ที่ลงเอง) + STR(ที่ลงเอง) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `singleAttackSkillRate`: `singleAttackSkillRate + buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), BonusType.bPowerResistBreaker) + 8 × ((Orgaslas…(ย่อ)` เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `singleAttackSkillRate`: `singleAttackSkillRate + buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), BonusType.bPowerResistBreaker) + 8 × ((Orgaslas…(ย่อ)` เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `singleAttackSkillRate`: `singleAttackSkillRate + buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), BonusType.bPowerResistBreaker) - 100` เมื่อ (+เงื่อนไขอื่น)
- **ดาเมจหลัก**
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(targetExpList[mobAction] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ดาเมจหลัก** — singleAttack = 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `explosionConstantDamage` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `explosionSkillRate %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `explosionSkillRate`: `explosionSkillRate × (OrgaslashBuf.Pay(new, OrgaslashBuf) & 255)` เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `explosionSkillRate`: `explosionSkillRate × (OrgaslashBuf.Pay(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 56)) & 255)` เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `explosionSkillRate`: `0` เมื่อ (+เงื่อนไขอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `GameManager.ReceivesSupportDelay` (GetSkillLv) — Receives Support Delay — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobAttackBase.CalcLastDamage` (TryGetBuf) — calculate last damage — Code


---
