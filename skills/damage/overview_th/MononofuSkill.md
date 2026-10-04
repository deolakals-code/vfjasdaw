# สกิลโมโนโนฟุ (23 สกิล)

สรุปโดยรวมต่อสกิล: ตัวคูณดาเมจมาจากไหน / แยกอาวุธ / สถานะระหว่างท่า / บัพ / เชื่อมสกิลอื่น. วิธีอ่าน: [ENGINE.md](ENGINE.md)

### เฟลช (FlashDrawnSword) · uid 609
- ทรี: สกิลโมโนโนฟุ · เลเวลสูงสุด: 10 · อาวุธที่ใช้ได้: คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [ช่องที่ 1 ของอาร์เรย์ต่อฮิต] = **0** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [ช่องที่ 2 ของอาร์เรย์ต่อฮิต] `5 × Lv + 50` → Lv1 55 · Lv5 75 · Lv10 100 — เมื่อ (+เงื่อนไขอื่น)
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [ช่องที่ 3 ของอาร์เรย์ต่อฮิต] `fixAddDamage[2]` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ดาเมจคงที่ตีแรก (`FirstAttack`, AddConstant) `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ช่องที่ 1 ของอาร์เรย์ต่อฮิต] = **50%** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ช่องที่ 2 ของอาร์เรย์ต่อฮิต] [`5 × Lv + โบนัสคริสตัล#113[4] + 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ fixAddDamage.Length > 1 และ fixAddDamage.Length ≠ 0 และ skillRate.Length > 1 และ skillRate.Length ≠ 0] หรือ [`500 × Lv + 100 × โบนัสคริสตัล#113[4] + 10000 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ fixAddDamage.Length ≠ 0 และ skillRate.Length > 1 และ skillRate.Length ≤ 1 และ skillRate.Length ≠ 0] หรือ [`500 × Lv + 10000 %` → Lv1 10500% · Lv5 12500% · Lv10 15000% — เมื่อ fixAddDamage.Length ≠ 0 และ skillRate.Length > 1 และ skillRate.Length ≤ 1 และ skillRate.Length ≠ 0] — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ช่องที่ 3 ของอาร์เรย์ต่อฮิต] `(skillRate[2]) * 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณตีแรก (`FirstAttackRate`, AddRate) `PlayerAttackBase.calcFastAttackDamageRate(playerAction) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ปอมเมลสไตร์ค (StrikeBackOfSword) · uid 610
- ทรี: สกิลโมโนโนฟุ · เลเวลสูงสุด: 10 · อาวุธที่ใช้ได้: คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `10 × Lv + 100` → Lv1 110 · Lv5 150 · Lv10 200
  - ตัวคูณสกิล (`SkillRate`, AddRate) `5 × Lv + 100 %` → Lv1 105% · Lv5 125% · Lv10 150%
- สถานะผิดปกติที่ติดเป้า:
  - สตัน โอกาส `5 × Lv` → Lv1 5 · Lv5 25 · Lv10 50
  - อัมพาต โอกาส `5 × Lv + 50` → Lv1 55 · Lv5 75 · Lv10 100

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### พัลส์เบลด / สวิฟต์พัลส์เบลด (WaveBlade) · uid 611
- ทรี: สกิลโมโนโนฟุ · เลเวลสูงสุด: 10 · อาวุธที่ใช้ได้: คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target if class check passes)

**ชื่อ/รูปแบบของสกิล (จากข้อความในเกม):** [N] พัลส์เบลด · [N2] สวิฟต์พัลส์เบลด

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `Lv + 30` → Lv1 31 · Lv5 35 · Lv10 40 — เมื่อ (+เงื่อนไขอื่น)
  - ดาเมจคงที่ตีแรก (`FirstAttack`, AddConstant) `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ช่องที่ 1 ของอาร์เรย์ต่อฮิต] `skillRate[0] %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ช่องที่ 2 ของอาร์เรย์ต่อฮิต] `skillRate[1] %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ช่องที่ 3 ของอาร์เรย์ต่อฮิต] `skillRate[2] %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณตีแรก (`FirstAttackRate`, AddRate) `PlayerAttackBase.calcFastAttackDamageRate(playerAction) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - หักป้องกันเป้า (`Def`, SetConstant) `-PlayerAttackBase.CalcPowerResistDamage(PlayerActionManagerBase.get_PlayerStatus(), int(((((max((int(MathUtil.DistanceToDisplayMeter(max((fsqrt((((UnityEngine.Transfor…(ย่อ)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `damageInvalid`

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล นุคิอุจิเซ็นโนเซ็น (uid 626): `WaveBladeAction.ActionPreparation` (TryGetBuf) — WaveBladeAction: preparation — Code


---

### บุชิโด (Bushido) · uid 612
- ทรี: สกิลโมโนโนฟุ · เลเวลสูงสุด: 10 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: HP สูงสุด (`MaxHp`) → Lv1 10 · Lv5 50 · Lv10 100 — Code
- พาสซีฟ/มาสเตอรี่: MP สูงสุด (`MaxMp`) → Lv1 10 · Lv5 50 · Lv10 100 — Code
- พาสซีฟ/มาสเตอรี่: ความแม่น (`Hit`) → Lv1 1 · Lv5 5 · Lv10 10 — Code
- พาสซีฟ/มาสเตอรี่: ATK % (`AtkRate`) = `int((Lv + 2) × vec(0x9999999a, 0x3fc99999)) + 1` — Code
- พาสซีฟ/มาสเตอรี่: ATK อาวุธ % (`EqAtkRate`) → Lv1 3 · Lv5 15 · Lv10 30 — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ทูแฮนด์ (WeaponInBothHands) · uid 613
- ทรี: สกิลโมโนโนฟุ · เลเวลสูงสุด: 10 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ความเสถียร (`Stable`) → Lv1 1 · Lv5 5 · Lv10 10 — Code
- พาสซีฟ/มาสเตอรี่: อัตราคริ (`Crt`) → Lv1 1 · Lv5 5 · Lv10 10 — Code
- พาสซีฟ/มาสเตอรี่: ความแม่น % (`HitRate`) → Lv1 1 · Lv5 5 · Lv10 10 — Code
- พาสซีฟ/มาสเตอรี่: ATK % (`AtkRate`) → Lv1 5 · Lv5 25 · Lv10 50 — Code
- พาสซีฟ/มาสเตอรี่: ATK อาวุธ % (`EqAtkRate`) → Lv1 1 · Lv5 5 · Lv10 10 — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ทริปเปิ้ลทรัสต์ (ThreeStageThrust) · uid 614
- ทรี: สกิลโมโนโนฟุ · เลเวลสูงสุด: 30 · อาวุธที่ใช้ได้: คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ AGIรวม
- **ดาเมจหลัก**
  - ดาเมจคงที่ตีแรก (`FirstAttack`, AddConstant) `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `20 × Lv + AGIรวม ÷ 5 + 150 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณตีแรก (`FirstAttackRate`, AddRate) `PlayerAttackBase.calcFastAttackDamageRate(playerAction) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ดาเมจคงที่สกิล (`SkillConstantDamage`) = `constantDamage`
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.ReceiveAttack` (GetSkillLv) — Receive Attack — Code


---

### มากาดาจิ (CutOffTheDisaster) · uid 615
- ทรี: สกิลโมโนโนฟุ · เลเวลสูงสุด: 30 · อาวุธที่ใช้ได้: คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), บัพ/มาสเตอรี่/สกิลอื่น
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `10 × Lv + 100` → Lv1 110 · Lv5 150 · Lv10 200
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **300** คงที่ทุก Lv
  - ดาเมจคงที่จากบัพ (`BufferConstantDamage`, SetConstant) = **0** คงที่ทุก Lv
  - ดาเมจคงที่ตีแรก (`FirstAttack`, AddConstant) `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `30 × Lv + 200 %` → Lv1 230% · Lv5 350% · Lv10 500%
  - ตัวคูณสกิล (`SkillRate`, AddRate) `int(0.5 × CountBufferBase.GetParam(20) × (25 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.HeavenlyStar, 1) + 150)) + 1300 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณตีแรก (`FirstAttackRate`, AddRate) `PlayerAttackBase.calcFastAttackDamageRate(playerAction) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: เท็นริวรันเซ (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (คำอธิบาย): ปัดการโจมตีของศัตรูและลดความเสียหายได้เพียง 1 ครั้ง — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: `PlayerActionManager.Damaged` — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล เท็นริวรันเซ (uid 620): `CutOffTheDisasterAction.OnInitialize` (GetSkillLv) — CutOffTheDisasterAction: initial values — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MercenaryActionManager.Damaged` (ContainsBuffer) — MercenaryActionManager: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.Damaged` (ContainsBuffer) — PlayerActionManager: on damaged — Code


---

### เมเคียวชิซุย (ClearAndSerene) · uid 616
- ทรี: สกิลโมโนโนฟุ · เลเวลสูงสุด: 30 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (Lv8): ค่าความเสียหายคริติคอลไม่ลดลง — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: `MobaPlayerSecondaryStatus.get_CriticalDmg` — Inferred

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerSecondaryStatus.get_CriticalDmg` (TryGetBuf) — Critical Dmg of MobaPlayerSecondaryStatus — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.CalcCriticalDmg` (TryGetBuf) — calculate critical dmg — Code


---

### ฮัซโซฮัปปะ (Okaranman) · uid 617
- ทรี: สกิลโมโนโนฟุ · เลเวลสูงสุด: 70 · อาวุธที่ใช้ได้: คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `2 × Lv + 130` → Lv1 132 · Lv5 140 · Lv10 150
  - ดาเมจคงที่ตีแรก (`FirstAttack`, AddConstant) `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณตีแรก (`FirstAttackRate`, AddRate) `PlayerAttackBase.calcFastAttackDamageRate(playerAction) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(proration ที่เก็บไว้ตอนร่าย[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ดาเมจหลัก** — isFirstAttck ≠ 0
  - ตัวคูณสกิล (`SkillRate`, AddRate) `change = 0 ? (Lv = 10 ? (10 × Lv < 90 ? 10 × Lv : 90) + 510 : (10 × Lv < 90 ? 10 × Lv : 90) + 210) : (Lv = 10 ? (10 × Lv < 90 ? 10 × Lv : 90) + 510 : (10 × Lv < 90 ? 1…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ดาเมจหลัก** — isFirstAttck = 0
  - ตัวคูณสกิล (`SkillRate`, AddRate) `change = 0 ? (10 × Lv < 90 ? 10 × Lv : 90) + 210 : (10 × Lv < 90 ? 10 × Lv : 90) + 310 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- คงกระพันตามเวลา PlayerActionManagerBase.get_AbnormalStatusManager() วินาที (ถอดเมื่อจบท่า/ครบเวลา) — Code · `ActionSkillEvent: AbnormalStateManager$$AddTimeInvincibility`
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `damageInvalid`

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ซังเทเซตเท็ตสึ (Zanteisettetsu) · uid 618
- ทรี: สกิลโมโนโนฟุ · เลเวลสูงสุด: 70 · อาวุธที่ใช้ได้: คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), บัพ/มาสเตอรี่/สกิลอื่น
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `10 × Lv` → Lv1 10 · Lv5 50 · Lv10 100
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `30 × Lv` → Lv1 30 · Lv5 150 · Lv10 300
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **300** คงที่ทุก Lv
  - ดาเมจคงที่จากบัพ (`BufferConstantDamage`, SetConstant) = **0** คงที่ทุก Lv
  - ดาเมจคงที่ตีแรก (`FirstAttack`, AddConstant) `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `20 × Lv + 100 %` → Lv1 120% · Lv5 200% · Lv10 300%
  - ตัวคูณสกิล (`SkillRate`, AddRate) `100 × Lv + 500 %` → Lv1 600% · Lv5 1000% · Lv10 1500%
  - ตัวคูณสกิล (`SkillRate`, AddRate) `int(0.5 × CountBufferBase.GetParam(20) × (25 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.HeavenlyStar, 1) + 150)) + 1300 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณตีแรก (`FirstAttackRate`, AddRate) `PlayerAttackBase.calcFastAttackDamageRate(playerAction) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- สถานะผิดปกติที่ติดเป้า:
  - เกราะแตก โอกาส `5 × Lv + 50` → Lv1 55 · Lv5 75 · Lv10 100
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: เท็นริวรันเซ (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล เท็นริวรันเซ (uid 620): `ZanteisettetsuAction.OnInitialize` (GetSkillLv) — ZanteisettetsuAction: initial values — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MercenaryActionManager.Damaged` (ContainsBuffer) — MercenaryActionManager: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.ReceiveDamaged` (ContainsBuffer) — Receive Damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.Damaged` (ContainsBuffer) — PlayerActionManager: on damaged — Code


---

### ชูคุจิ (Shukuchi) · uid 619
- ทรี: สกิลโมโนโนฟุ · เลเวลสูงสุด: 70 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ใช่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ตัวคูณตีปกติ % (`NormalAttackRate`) = **400** คงที่ทุก Lv — เมื่อ unannouncedDestination ≠ 0
- ตัวคูณตีปกติ % (`NormalAttackRate`) `5 × Lv` → Lv1 5 · Lv5 25 · Lv10 50 — เมื่อ unannouncedDestination = 0
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) `Lv × Lv ÷ 2` → Lv1 0 · Lv5 12 · Lv10 50

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล นุคิอุจิเซ็นโนเซ็น (uid 626): `ShukuchiAction.OnInitialize` (TryGetBuf) — ShukuchiAction: initial values — Code
- ได้รับการเสริมจากสกิล โฟรทแดช (uid 878): `ShukuchiAction.CanActivated` (ContainsBuffer) — predicate can activated — Code
- ถูกอ่านโดย CloningTechniqueAction (uid 1226) ผ่าน `CloningTechniqueAction.ActionStart` (GetSkillLv) — CloningTechniqueAction: skill start — Code
- ถูกอ่านโดย ลมกระโชกแรง (uid 631) ผ่าน `IchijhinnokazeAratame.InvokeShukuchi` (ContainsBuffer) — Invoke Shukuchi — Code
- ถูกอ่านโดย ลมกระโชกแรง (uid 631) ผ่าน `IchijhinnokazeAratame.InvokeShukuchi` (GetSkillLv) — Invoke Shukuchi — Code
- ถูกอ่านโดย IchijhinnokazeAttackAction (uid 637) ผ่าน `IchijhinnokazeAttackAction.ActionPreparation` (GetSkillLv) — IchijhinnokazeAttackAction: preparation — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `IchijhinnokazeBuf.Updata` (ContainsBuffer) — IchijhinnokazeBuf: per-tick update — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerBattleManager.AbnormalFear` (ContainsBuffer) — Abnormal Fear — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerBattleManager.OnBattleEnd` (ContainsBuffer) — On Battle End — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerBattleManager.<ShukuchiMoveWait>d__93.MoveNext` (GetSkillLv) — Move Next — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `NormalAttackAction.ActionPreparation` (ContainsBuffer) — NormalAttackAction: preparation — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `NormalAttackAction.calcPlayerToMobDamage` (TryGetBuf) — NormalAttackAction: player→mob damage template — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.AbnormalFear` (ContainsBuffer) — Abnormal Fear — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.OnBattleEnd` (ContainsBuffer) — On Battle End — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.<ShukuchiMoveWait>d__54.MoveNext` (GetSkillLv) — Move Next — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.get_AtkMpRecovery` (TryGetBuf) — Atk Mp Recovery of PlayerSecondaryStatus — Code


---

### เท็นริวรันเซ (HeavenlyStar) · uid 620
- ทรี: สกิลโมโนโนฟุ · เลเวลสูงสุด: 150 · อาวุธที่ใช้ได้: คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target if class check passes)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `10 × Lv` → Lv1 10 · Lv5 50 · Lv10 100
  - ดาเมจคงที่ตีแรก (`FirstAttack`, AddConstant) `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `25 × Lv + (25 × Lv + 150) × (System.Math.Min(CountBufferBase.GetParam(20), 3)) + 100 × (System.Math.Min(CountBufferBase.GetParam(20), 3)) + 250 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `skillRate + skillRate × (System.Math.Min(CountBufferBase.GetParam(20), 3)) + 100 × (System.Math.Min(CountBufferBase.GetParam(20), 3)) + 100` เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `skillRate + skillRate × System.Math.Min(CountBufferBase.GetParam(20), 3)`
    - ตัวปรับ `skillRate`: `skillRate + 100 × stackLevel + 100` เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `25 × Lv + (25 × Lv + 150) × System.Math.Min(CountBufferBase.GetParam(20), 3) + 150 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `skillRate`: `skillRate + skillRate × (System.Math.Min(CountBufferBase.GetParam(20), 3)) + 100 × (System.Math.Min(CountBufferBase.GetParam(20), 3)) + 100` เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `skillRate + skillRate × System.Math.Min(CountBufferBase.GetParam(20), 3)`
    - ตัวปรับ `skillRate`: `skillRate + 100 × stackLevel + 100` เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `25 × Lv + 100 × System.Math.Min(CountBufferBase.GetParam(20), 3) + 250 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `skillRate + skillRate × (System.Math.Min(CountBufferBase.GetParam(20), 3)) + 100 × (System.Math.Min(CountBufferBase.GetParam(20), 3)) + 100` เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `skillRate + skillRate × System.Math.Min(CountBufferBase.GetParam(20), 3)`
    - ตัวปรับ `skillRate`: `skillRate + 100 × stackLevel + 100` เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `25 × Lv + 150 %` → Lv1 175% · Lv5 275% · Lv10 400%
    - ตัวปรับ `skillRate`: `skillRate + skillRate × (System.Math.Min(CountBufferBase.GetParam(20), 3)) + 100 × (System.Math.Min(CountBufferBase.GetParam(20), 3)) + 100` เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `skillRate + skillRate × System.Math.Min(CountBufferBase.GetParam(20), 3)`
    - ตัวปรับ `skillRate`: `skillRate + 100 × stackLevel + 100` เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณตีแรก (`FirstAttackRate`, AddRate) `PlayerAttackBase.calcFastAttackDamageRate(playerAction) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย มากาดาจิ (uid 615) ผ่าน `CutOffTheDisasterAction.OnInitialize` (GetSkillLv) — CutOffTheDisasterAction: initial values — Code
- ถูกอ่านโดย คาสุมิเซ็ตสึเก็คคะ / เท็นริวรันเซ:ซันยุ (uid 624) ผ่าน `IllusionarySceneAction.OnInitialize` (GetSkillLv) — IllusionarySceneAction: initial values — Code
- ถูกอ่านโดย คาสุมิเซ็ตสึเก็คคะ / เท็นริวรันเซ:ซันยุ (uid 624) ผ่าน `IllusionarySceneAction.OnInitialize` (TryGetBuf) — IllusionarySceneAction: initial values — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerBattleManager.OnSkillActionEnd` (ContainsBuffer) — On Skill Action End — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.CalcCostMp` (ContainsBuffer) — Skill MP cost — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.CheckZeroActionDelay` (ContainsBuffer) — check zero action delay — Code
- ถูกอ่านโดย ซังเทเซตเท็ตสึ (uid 618) ผ่าน `ZanteisettetsuAction.OnInitialize` (GetSkillLv) — ZanteisettetsuAction: initial values — Code


---

### การิวเท็นเซ (FinishingTouch) · uid 621
- ทรี: สกิลโมโนโนฟุ · เลเวลสูงสุด: 150 · อาวุธที่ใช้ได้: คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **1000** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `fixAddDamage`: `10 × fixAddDamage` เมื่อ (+เงื่อนไขอื่น)
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **100** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `fixAddDamage`: `10 × fixAddDamage` เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `20 × Lv %` → Lv1 20% · Lv5 100% · Lv10 200%
    - ตัวปรับ `skillRate`: `((skillRate + ((PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[621].Count + (PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[621].Count << 2)) <…(ย่อ)` เมื่อ (+เงื่อนไขอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - (`MobLastDamageRate*` เข้าสูตรดาเมจที่มอนทำใส่ผู้เล่นใน `MobAttackBase.CalcLastDamage` — ค่านี้คือส่วนลดดาเมจที่ได้รับ; หน่วยและการรวมกับบัพอื่นยังไม่ยืนยัน — Inferred)
  - ตัวคูณดาเมจที่ได้รับจากมอน (หมวดบัพ) (`MobLastDamageRateBuf`) = `damageCut`

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `lastDamageRate`
- ตัวคูณตีแรก (`FirstAttackRate`) = `firstAttackRate`
- MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = `atkMpRecovery`
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.CalcBufferLastDamageRate` (TryGetBuf) — Last-damage rate from buffs/bonuses — Code
- ถูกอ่านโดย ชาโดว์เลสสแลช (uid 625) ผ่าน `ShadowlessSlashAction.ActionSkillEvent` (GetSkillLv) — Action Skill Event — Code
- ถูกอ่านโดย TenjhoTengeMusouSwordAction (uid 638) ผ่าน `TenjhoTengeMusouSwordAction.ActionStart` (TryGetBuf) — TenjhoTengeMusouSwordAction: skill start — Code
- ถูกอ่านโดย TenjhoTengeMusouSwordAction (uid 638) ผ่าน `TenjhoTengeMusouSwordAction.CheckActive` (GetSkillLv) — check active — Code
- ถูกอ่านโดย TenjhoTengeMusouSwordAction (uid 638) ผ่าน `TenjhoTengeMusouSwordAction.CheckActive` (TryGetBuf) — check active — Code


---

### ไคริกิรันชิน (WeirdnessOfGod) · uid 622
- ทรี: สกิลโมโนโนฟุ · เลเวลสูงสุด: 150 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: เบอร์เซิร์ก (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ATK + (`AtkUp`) = `atk`
- ตัวคูณตีปกติ % (`NormalAttackRate`) = `normalAttackRate`
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `registBreak`
- MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = `atkMpHeal`

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล เบอร์เซิร์ก (uid 46): `WeirdnessOfGodAction.ActionStart` (GetSkillLv) — WeirdnessOfGodAction: skill start — Code
- ได้รับการเสริมจากสกิล เบอร์เซิร์ก (uid 46): `WeirdnessOfGodAction.EffectiveAbnormalIgnition` (ContainsBuffer) — Effective Abnormal Ignition — Code
- ถูกอ่านโดย IchijhinnokazeAttackAction (uid 637) ผ่าน `IchijhinnokazeAttackAction.ActionPreparation` (GetSkillLv) — IchijhinnokazeAttackAction: preparation — Code
- ถูกอ่านโดย TenjhoTengeMusouSwordAction (uid 638) ผ่าน `TenjhoTengeMusouSwordAction.ActionPreparation` (GetSkillLv) — TenjhoTengeMusouSwordAction: preparation — Code
- ถูกอ่านโดย TenjhoTengeMusouSwordAction (uid 638) ผ่าน `TenjhoTengeMusouSwordAction.ActionPreparation` (TryGetBuf) — TenjhoTengeMusouSwordAction: preparation — Code


---

### คมดาบมายา (RepelBlade) · uid 623
- ทรี: สกิลโมโนโนฟุ · เลเวลสูงสุด: 70 · อาวุธที่ใช้ได้: MainKatana
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `10 × Lv + 100` → Lv1 110 · Lv5 150 · Lv10 200
  - ดาเมจคงที่ตีแรก (`FirstAttack`, AddConstant) `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `20 × Lv + 200 %` → Lv1 220% · Lv5 300% · Lv10 400%
  - ตัวคูณตีแรก (`FirstAttackRate`, AddRate) `PlayerAttackBase.calcFastAttackDamageRate(playerAction) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: การิวเท็นเซ (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ความแม่น % (`HitRate`) = `hitRate` — เมื่อ IsReelSuccess ≠ 0
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `hpHealRate` — เมื่อ IsReelSuccess ≠ 0
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `damageInvalid`

#### 5) เชื่อมกับสกิลอื่น
- สกิลนี้ใส่บัพของสกิล การิวเท็นเซ (uid 621) — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.CalcCostMp` (ContainsBuffer) — Skill MP cost — Code


---

### คาสุมิเซ็ตสึเก็คคะ / เท็นริวรันเซ:ซันยุ (IllusionaryScene) · uid 624
- ทรี: สกิลโมโนโนฟุ · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

**ชื่อ/รูปแบบของสกิล (จากข้อความในเกม):** [N] คาสุมิเซ็ตสึเก็คคะ · [N2] เท็นริวรันเซ:ซันยุ

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ DEXรวม
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `rangekiConstantDamage` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **200** คงที่ทุก Lv
  - ดาเมจคงที่ตีแรก (`FirstAttack`, AddConstant) `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `75 × Lv + 750 %` → Lv1 825% · Lv5 1125% · Lv10 1500%
  - ตัวคูณสกิล (`SkillRate`, AddRate) `((SkillBufferDataBase.GetParam(20)) < 1 ? 100 : (25 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.HeavenlyStar, 1) + 150) × (SkillBufferDataBa…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `finishSkillRate`: `finishSkillRate + 2 × DEXรวม ÷ 5`
  - ตัวคูณตีแรก (`FirstAttackRate`, AddRate) `PlayerAttackBase.calcFastAttackDamageRate(playerAction) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: เท็นริวรันเซ (Skill)

#### 3) ระหว่างใช้สกิล
- Super Armor: ไม่สะดุด/ไม่ถูกขัดเมื่อโดนตี จนกว่าจะเรียก EndSuperArmor — Code · `ActionSkillEvent: IllusionarySceneBuf$$EndSuperArmor`
- Super Armor: ไม่สะดุด/ไม่ถูกขัดเมื่อโดนตี (ธงบัพ isSuperArmor = 1) — Code · `IllusionarySceneBuf..ctor: set isSuperArmor`
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - (`MobLastDamageRate*` เข้าสูตรดาเมจที่มอนทำใส่ผู้เล่นใน `MobAttackBase.CalcLastDamage` — ค่านี้คือส่วนลดดาเมจที่ได้รับ; หน่วยและการรวมกับบัพอื่นยังไม่ยืนยัน — Inferred)
  - ตัวคูณดาเมจที่ได้รับจากมอน (หมวดบัพ) (`MobLastDamageRateBuf`) = `damageCutValue`
- ข้อความในเกม (คำอธิบาย): ลดความเสียหายที่ได้รับลงอย่างมากขณะใช้งาน — Text

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- สกิลนี้ใส่บัพของสกิล เท็นริวรันเซ (uid 620) — Code
- ได้รับการเสริมจากสกิล เท็นริวรันเซ (uid 620): `IllusionarySceneAction.OnInitialize` (GetSkillLv) — IllusionarySceneAction: initial values — Code
- ได้รับการเสริมจากสกิล เท็นริวรันเซ (uid 620): `IllusionarySceneAction.OnInitialize` (TryGetBuf) — IllusionarySceneAction: initial values — Code
- ถูกอ่านโดย แฟกทิสอาร์ม (uid 717) ผ่าน `FacticeArmeAction.ActionSkillEvent` (TryGetBuf) — Action Skill Event — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobAttackBase.CalcLastDamage` (TryGetBuf) — calculate last damage — Code


---

### ชาโดว์เลสสแลช (ShadowlessSlash) · uid 625
- ทรี: สกิลโมโนโนฟุ · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ AGI(ที่ลงเอง)/DEX(ที่ลงเอง)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **300** คงที่ทุก Lv
  - ดาเมจคงที่ตีแรก (`FirstAttack`, AddConstant) `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `50 × Lv + (AGI(ที่ลงเอง) + DEX(ที่ลงเอง)) ÷ 2 + 400 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณตีแรก (`FirstAttackRate`, AddRate) `PlayerAttackBase.calcFastAttackDamageRate(playerAction) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: การิวเท็นเซ (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ความแม่น % (`HitRate`) = `hitRate`
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `damageInvalid`

#### 5) เชื่อมกับสกิลอื่น
- สกิลนี้ใส่บัพของสกิล การิวเท็นเซ (uid 621) — Code
- ได้รับการเสริมจากสกิล การิวเท็นเซ (uid 621): `ShadowlessSlashAction.ActionSkillEvent` (GetSkillLv) — Action Skill Event — Code
- ถูกอ่านโดย TenjhoTengeMusouSwordAction (uid 638) ผ่าน `TenjhoTengeMusouSwordAction.CheckActive` (GetSkillLv) — check active — Code


---

### นุคิอุจิเซ็นโนเซ็น (UnannouncedDestination) · uid 626
- ทรี: สกิลโมโนโนฟุ · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: MainKatana

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย IchijhinnokazeAttackAction (uid 637) ผ่าน `IchijhinnokazeAttackAction.CheckSetunakenran` (GetSkillLv) — check setunakenran — Code
- ถูกอ่านโดย IchijhinnokazeAttackAction (uid 637) ผ่าน `IchijhinnokazeAttackAction.CheckSetunakenran` (TryGetBuf) — check setunakenran — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `NormalAttackAction.ActionPreparation` (TryGetBuf) — NormalAttackAction: preparation — Code
- ถูกอ่านโดย ชูคุจิ (uid 619) ผ่าน `ShukuchiAction.OnInitialize` (TryGetBuf) — ShukuchiAction: initial values — Code
- ถูกอ่านโดย พัลส์เบลด / สวิฟต์พัลส์เบลด (uid 611) ผ่าน `WaveBladeAction.ActionPreparation` (TryGetBuf) — WaveBladeAction: preparation — Code


---

### ดอนท์เลส (Inflexibility) · uid 627
- ทรี: สกิลโมโนโนฟุ · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: MainKatana

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 4) บัพที่ได้จากสกิลนี้
- ความแม่น + (`HitUp`) = `hit`
- ตัวคูณตีแรก (`FirstAttackRate`) = `firstAttackRate`
- BaseEqAtk (`BaseEqAtk`) = `baseEqAtk`
- ATK อาวุธ + (`EqAtk`) = `eqAtk`
- ความเร็วท่าทาง + (`MotionSpeed`) = `motionSpeed`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `EquipItemData.WeaponTypeCalculatorBase.CalcEqAtk` (TryGetBuf) — calculate eq atk — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `HeavenlyStarBuf.IllusionarySceneReset` (TryGetBuf) — Illusionary Scene Reset — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerSecondaryStatus.GetMotionSpeed` (TryGetBuf) — Get Motion Speed — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.CalcCostMp` (TryGetBuf) — Skill MP cost — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.GetCalcMotionSpeed` (TryGetBuf) — Get Calc Motion Speed — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `SwordMove.AddBuf` (TryGetBuf) — Add Buf — Code


---

### ลมมงคล (Mizukaze) · uid 628
- ทรี: สกิลโมโนโนฟุ · เลเวลสูงสุด: 30 · อาวุธที่ใช้ได้: คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ค่าเปอร์เซ็นต์ (`Percent`) → Lv1 10 · Lv5 50 · Lv10 100 — Code
- ข้อความในเกม (คำอธิบาย): หรือเมื่อหลบหลีก Avoid สำเร็จพลังโจมตีระยะใกล้/ — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv
- ดาเมจระยะใกล้ % (`ShortRangeRate`) = `Count × shortRangeDamageRate`
- ดาเมจคริ (`CrtDmg`) = `Count × criticalDamage`
- ความแม่น + (`HitUp`) = `Count × hit`

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ลมกระโชก / ลมสงบนิ่ง / ลมเหนือ / ลมตะวันออก / ลมตะวันตก / ลมใต้ / สี่ฤดูกาล (Ichijhinnokaze) · uid 629
- ทรี: สกิลโมโนโนฟุ · เลเวลสูงสุด: 70 · อาวุธที่ใช้ได้: คาตานะ

**ชื่อ/รูปแบบของสกิล (จากข้อความในเกม):** [N] ลมกระโชก · [N2] ลมสงบนิ่ง · [N3] ลมเหนือ · [N4] ลมตะวันออก · [N5] ลมตะวันตก · [N6] ลมใต้ · [N7] สี่ฤดูกาล

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- BaseEqAtk (`BaseEqAtk`) = `baseEqAtk`
- ATK + (`AtkUp`) = `atk`
- ค่าเปอร์เซ็นต์ทั่วไป (`Percent`) `10 × Lv` → Lv1 10 · Lv5 50 · Lv10 100
- ค่าทั่วไปตัวที่ 2 (`Value2`) = `activeSkill`
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `NowAttackMode`
- ATK % (`AtkUpRate`) = `atkRate`
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `EquipItemData.WeaponTypeCalculatorBase.CalcEqAtk` (TryGetBuf) — calculate eq atk — Code
- ถูกอ่านโดย ลมกรด (uid 630) ผ่าน `HayateAction.IsFailure` (ContainsBuffer) — predicate is failure — Code
- ถูกอ่านโดย IchijhinnokazeAttackAction (uid 637) ผ่าน `IchijhinnokazeAttackAction.CheckSetunakenran` (TryGetBuf) — check setunakenran — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `IchijhinnokazeBuf.CheckNormalAttackIchijhinnokaze` (GetSkillLv) — check normal attack ichijhinnokaze — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.GetSkillTargetType` (ContainsBuffer) — Get Skill Target Type — Code
- ถูกอ่านโดย TenjhoTengeMusouSwordAction (uid 638) ผ่าน `TenjhoTengeMusouSwordAction.CheckActive` (ContainsBuffer) — check active — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIFishingPanelManager.StartFishingResponse` (TryGetBuf) — Code

#### 6) ท่าที่ออกจากแพตเทิร์นของ Ichijhinnokaze (ลมกระโชก)
- สถานะตั้งรับ (IchijhinnokazeBuf) มีโหมด A/B/C (NowAttackMode = 0/1/2) ตัวนับสูงสุด 3 — Code
- คีย์ที่กดตอนอยู่ในสถานะนี้ ออกท่า 5 แบบ (action 637 IchijhinnokazeAttackAction): Nagi (凪), Kariwatashi, Hibari, Ibuki, Arahae — Code
- ชื่อไทยในเกม ลมสงบนิ่ง / ลมเหนือ / ลมตะวันออก / ลมตะวันตก / ลมใต้ ตรงกับ 5 ท่านี้ตามลำดับในโค้ด — Inferred (จับคู่ตามลำดับ ไม่ใช่ชื่อในโค้ด)
- ท่ารวม «สี่ฤดูกาล» = Setsunakenran (刹那絢爛): เปิดเมื่อถือคาตานะ + บัพ UnannouncedDestination เปิดอยู่ + บัพ Ichijhinnokaze อยู่ในโหมด activeSkill = 3 + มีเป้าหมาย — Code; การจับคู่ชื่อ «สี่ฤดูกาล» = Setsunakenran — Inferred
- ตอน Setsunakenran ท่าย่อยถูกบวกตัวคูณเพิ่ม (บวกเข้า skillRates): Kariwatashi +1200, Hibari +1550, Ibuki +1450, Arahae +1350 — Code
- โบนัสตามโหมด (ตาราง: โหมด A, ยังไม่มี Aratame): บวกเข้าท่านั้นๆ ตามสูตรด้านล่าง — Code
- สกิลเสริม Ichijhinnokaze Aratame (uid 631) บวกต่อ Lv: Nagi +50, Kariwatashi +30, Hibari +45, Ibuki +45, Arahae +35 — Code
  - Nagi (凪): `50 × Lv + 50 × Lv(Aratame) + 500 %` → Lv1 550 · Lv5 750 · Lv10 1000
  - Kariwatashi: `max(300 - 150 × โหมด, 0) + 20 × Lv + 30 × Lv(Aratame) + 400 %` → Lv1 720 · Lv5 800 · Lv10 900
  - Hibari: `100 × โหมด + 30 × Lv + 45 × Lv(Aratame) + 600 %` → Lv1 630 · Lv5 750 · Lv10 900
  - Ibuki: `50 × โหมด + 60 × Lv + 45 × Lv(Aratame) + 300 %` → Lv1 360 · Lv5 600 · Lv10 900
  - Arahae: `150 × โหมด + 20 × Lv + 35 × Lv(Aratame) + 500 %` → Lv1 520 · Lv5 600 · Lv10 700


---

### ลมกรด (Hayate) · uid 630
- ทรี: สกิลโมโนโนฟุ · เลเวลสูงสุด: 150 · อาวุธที่ใช้ได้: คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **400** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `60 × Lv %` → Lv1 60% · Lv5 300% · Lv10 600%
  - ตัวคูณสกิล (`SkillRate`, AddRate) `300 × min(int(0), 4) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ jumpElapsedTime ≥ 1

#### 3) ระหว่างใช้สกิล
- คงกระพัน (สถานะ Invincibility) ตั้งแต่เริ่มท่า จนถอดตอนจบท่า — เพดาน 5 วินาที — Code · `ActionSkillEvent: AbnormalStateManager$$AddInvincibilityTemporarilyInAction`
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (คำอธิบาย): หลบหนีจากวิกฤตได้ราวสายลมพัด(เฉพาะในสถานะลมกระโชกเท่านั้น) — Text
- ข้อความในเกม (คำอธิบาย): ระหว่างการกระโดดจะอยู่ในสถานะคงกระพัน — Text
- ข้อความในเกม (คำอธิบาย): พลังโจมตีเพิ่มขึ้นตามระยะเวลาที่คงกระพันแต่หากไม่มีเป้าหมายอยู่ที่จุดตกถึงพื้นจะ MISS — Text

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล ลมกระโชก / ลมสงบนิ่ง / ลมเหนือ / ลมตะวันออก / ลมตะวันตก / ลมใต้ / สี่ฤดูกาล (uid 629): `HayateAction.IsFailure` (ContainsBuffer) — predicate is failure — Code


---

### ลมกระโชกแรง (IchijhinnokazeAratame) · uid 631
- ทรี: สกิลโมโนโนฟุ · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 4) บัพที่ได้จากสกิลนี้
- ตัวคูณตีปกติ % (`NormalAttackRate`) = **400** คงที่ทุก Lv — เมื่อ unannouncedDestination ≠ 0
- ตัวคูณตีปกติ % (`NormalAttackRate`) `5 × Lv` → Lv1 5 · Lv5 25 · Lv10 50 — เมื่อ unannouncedDestination = 0
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) `Lv × Lv ÷ 2` → Lv1 0 · Lv5 12 · Lv10 50

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล ชูคุจิ (uid 619): `IchijhinnokazeAratame.InvokeShukuchi` (ContainsBuffer) — Invoke Shukuchi — Code
- ได้รับการเสริมจากสกิล ชูคุจิ (uid 619): `IchijhinnokazeAratame.InvokeShukuchi` (GetSkillLv) — Invoke Shukuchi — Code


---
