# สกิลหอกวายุ (22 สกิล)

สรุปโดยรวมต่อสกิล: ตัวคูณดาเมจมาจากไหน / แยกอาวุธ / สถานะระหว่างท่า / บัพ / เชื่อมสกิลอื่น. วิธีอ่าน: [ENGINE.md](ENGINE.md)

### เฟลชสเต็ป (FlashStub) · uid 961
- ทรี: สกิลหอกวายุ · เลเวลสูงสุด: 10 · อาวุธที่ใช้ได้: ดาบมือเดียว, ทวน
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, SetConstant) `5 × Lv + 50` → Lv1 55 · Lv5 75 · Lv10 100
  - ตัวคูณสกิล (`SkillRate`, SetRate) `5 × Lv + โบนัสคริสตัล#111[4] + 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### แคนนอนสเปียร์ (CannonSpear) · uid 962
- ทรี: สกิลหอกวายุ · เลเวลสูงสุด: 10 · อาวุธที่ใช้ได้: ทวน
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `10 × Lv + 100` → Lv1 110 · Lv5 150 · Lv10 200 — เมื่อ skillRate.Length ≠ 0 หรือ skillRate.Length ≠ 0 (+เงื่อนไขอื่น) หรือ skillRate.Length > 1
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `target`: `target`
  - Proration (`ExpRate`, SetRate) `(proration ที่เก็บไว้ตอนร่าย[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ดาเมจหลัก** — isFristAttck ≠ 0
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ช่องที่ 1 ของอาร์เรย์ต่อฮิต] `Lv + 40 %` → Lv1 41% · Lv5 45% · Lv10 50% — เมื่อ skillRate.Length ≠ 0
- **ดาเมจหลัก** — isFristAttck = 0
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ช่องที่ 2 ของอาร์เรย์ต่อฮิต] `10 × Lv + 150 %` → Lv1 160% · Lv5 200% · Lv10 250% — เมื่อ skillRate.Length > 1
- สถานะผิดปกติที่ติดเป้า:
  - ผงะ โอกาส `โบนัสคริสตัล#112[2]` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### เดดลี่สเปียร์ (DeadlySpear) · uid 963
- ทรี: สกิลหอกวายุ · เลเวลสูงสุด: 10 · อาวุธที่ใช้ได้: ดาบมือเดียว, ทวน
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, SetConstant) `3 × Lv + 80` → Lv1 83 · Lv5 95 · Lv10 110
  - ตัวคูณสกิล (`SkillRate`, SetRate) [ดาบมือเดียว] `5 × (Lv > 2 ? Lv : 2) + 100 %` → Lv1 110% · Lv5 125% · Lv10 150%
  - ตัวคูณสกิล (`SkillRate`, SetRate) [ทวน] `5 × (Lv > 2 ? Lv : 2) + 120 %` → Lv1 130% · Lv5 145% · Lv10 170%

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.ReceiveAttack` (GetSkillLv) — Receive Attack — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.CalcCostMp` (ContainsBuffer) — Skill MP cost — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.RemoveAfterSkillBuf` (ContainsBuffer) — Remove After Skill Buf — Code


---

### ฮัลเบิร์ทมาสเตอรี่ (HalberdMastery) · uid 964
- ทรี: สกิลหอกวายุ · เลเวลสูงสุด: 10 · อาวุธที่ใช้ได้: ทวน

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ATK อาวุธ % (`EqAtkRate`) → Lv1 3 · Lv5 15 · Lv10 30 — Code
- พาสซีฟ/มาสเตอรี่: ATK % (`AtkRate`) → Lv1 1 · Lv5 2 · Lv10 3 — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ควิกออร่า (QuickAura) · uid 965
- ทรี: สกิลหอกวายุ · เลเวลสูงสุด: 10 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ดราก้อนเทล (DragonTail) · uid 966
- ทรี: สกิลหอกวายุ · เลเวลสูงสุด: 30 · อาวุธที่ใช้ได้: ทวน
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(proration ที่เก็บไว้ตอนร่าย[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ดาเมจหลัก** — isFristAttck = 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `15 × Lv + 50` → Lv1 65 · Lv5 125 · Lv10 200
  - ตัวคูณสกิล (`SkillRate`, AddRate) `20 × Lv + โบนัสคริสตัล#212[4] + 200 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ดาเมจหลัก** — isFristAttck ≠ 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **100** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `3 × Lv + 70 %` → Lv1 73% · Lv5 85% · Lv10 100%
- สถานะผิดปกติที่ติดเป้า:
  - ล้มคว่ำ โอกาส `10 × Lv` → Lv1 10 · Lv5 50 · Lv10 100

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - (`MobLastDamageRate*` เข้าสูตรดาเมจที่มอนทำใส่ผู้เล่นใน `MobAttackBase.CalcLastDamage` — ค่านี้คือส่วนลดดาเมจที่ได้รับ; หน่วยและการรวมกับบัพอื่นยังไม่ยืนยัน — Inferred)
  - MobLastDamageRateUnique (`MobLastDamageRateUnique`) = `damageCut`
- ข้อความในเกม (คำอธิบาย): ลดความเสียหายที่ได้รับ (2 ครั้ง) ระหว่างใช้สกิล — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### วานิชเรย์ (PunishRay) · uid 967
- ทรี: สกิลหอกวายุ · เลเวลสูงสุด: 30 · อาวุธที่ใช้ได้: ดาบมือเดียว, ทวน
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ INTรวม
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `fixAddDamage` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `mainWeapon = Halberd ? 2 × Lv × Lv + 50 : Lv × Lv + 25 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `INTรวม ÷ 4 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ดาเมจฐาน (`BaseDamage`, SetConstant) `PlayerAttackBase.calcBaseDamage(playerAction, mobAction, 1, [skillMaster+0x24], PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), m…(ย่อ)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- อัตราคริ + (`CrtUp`) = `critical[max(Count)]` — เมื่อ (+เงื่อนไขอื่น)
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.ReceiveAttack` (GetSkillLv) — Receive Attack — Code


---

### วอร์ครายสทรักเกิ้ล (AdversityRoar) · uid 968
- ทรี: สกิลหอกวายุ · เลเวลสูงสุด: 30 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ไดฟ์อิมแพ็ค (DiveImpact) · uid 969
- ทรี: สกิลหอกวายุ · เลเวลสูงสุด: 70 · อาวุธที่ใช้ได้: ทวน
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ INTรวม/STRรวม
- **ดาเมจหลัก**
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(proration ที่เก็บไว้ตอนร่าย[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ดาเมจหลัก** — isFirstAttck = 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **0** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `40 × Lv + INTรวม + 200 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ดาเมจหลัก** — isFirstAttck ≠ 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `20 × Lv + 200` → Lv1 220 · Lv5 300 · Lv10 400
  - ตัวคูณสกิล (`SkillRate`, AddRate) `STRรวม / 2.5 + 20 × Lv + 200 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- สถานะผิดปกติที่ติดเป้า:
  - ตาพร่า โอกาส `10 × Lv` → Lv1 10 · Lv5 50 · Lv10 100

#### 3) ระหว่างใช้สกิล
- คงกระพัน (สถานะ Invincibility) ตั้งแต่เริ่มท่า จนถอดตอนจบท่า — เพดาน 3 วินาที — Code · `ActionStart: AbnormalStateManager$$AddInvincibilityTemporarilyInAction`
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### สไตร์คสเต็ป (StrikeStub) · uid 970
- ทรี: สกิลหอกวายุ · เลเวลสูงสุด: 70 · อาวุธที่ใช้ได้: ดาบมือเดียว, ทวน
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ STRรวม, อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [ดาบมือเดียว] = **100** คงที่ทุก Lv
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [ทวน] = **200** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ดาบมือเดียว] `100 × (Lv + 190) / 100 + 100 × 10 × Lv / 100 %` → Lv1 201% · Lv5 245% · Lv10 300% — เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `skillRate + abnormalRate` เมื่อ damageCount ≥ 1 (+เงื่อนไขอื่น) หรือ damageCount < 1 (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ทวน] `100 × (Lv + 190) / 100 + 100 × 20 × Lv / 100 %` → Lv1 211% · Lv5 295% · Lv10 400% — เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `skillRate + abnormalRate` เมื่อ damageCount ≥ 1 (+เงื่อนไขอื่น) หรือ damageCount < 1 (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `STRรวม ÷ 5 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `Lv + 190 %` → Lv1 191% · Lv5 195% · Lv10 200% — เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `skillRate + abnormalRate` เมื่อ damageCount ≥ 1 (+เงื่อนไขอื่น) หรือ damageCount < 1 (+เงื่อนไขอื่น)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### คริติคอลสเปียร์ (HandlingSatisfaction) · uid 971
- ทรี: สกิลหอกวายุ · เลเวลสูงสุด: 70 · อาวุธที่ใช้ได้: ทวน

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: อัตราคริ % (`CrtRate`) → Lv1 0 · Lv5 2 · Lv10 5 — Code
- พาสซีฟ/มาสเตอรี่: อัตราคริ (`Crt`) → Lv1 1 · Lv5 3 · Lv10 5 — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ดราก้อนทูธ (DragonTooth) · uid 972
- ทรี: สกิลหอกวายุ · เลเวลสูงสุด: 150 · อาวุธที่ใช้ได้: ทวน
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ฮิต 1**
  - ตัวคูณสกิล (`SkillRate`, AddRate) `75 × Lv %` → Lv1 75% · Lv5 375% · Lv10 750%
- **ฮิต 2**
  - ตัวคูณสกิล (`SkillRate`, AddRate) = **750%** คงที่ทุก Lv

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย Nดราก้อนทูธ / นีโน่ดราก้อนทูธ (uid 676) ผ่าน `N_DragonToothAction.OnInitialize` (GetSkillLv) — N_DragonToothAction: initial values — Code


---

### โครนอสไดรฟ์ (CronosDrive) · uid 973
- ทรี: สกิลหอกวายุ · เลเวลสูงสุด: 150 · อาวุธที่ใช้ได้: ทวน
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `40 × Lv` → Lv1 40 · Lv5 200 · Lv10 400
  - ตัวคูณสกิล (`SkillRate`, AddRate) `50 × Lv + 100 %` → Lv1 150% · Lv5 350% · Lv10 600%

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย อินฟิไนท์ไดเมนชัน (uid 977) ผ่าน `DimensionTillAction.ActionHit` (ContainsBuffer) — Action Hit — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerBattleManager.ReceiveSkillMotionEnd` (GetSkillLv) — Receive Skill Motion End — Code


---

### เทพลมกรด (HandlingerOfGodspeed) · uid 974
- ทรี: สกิลหอกวายุ · เลเวลสูงสุด: 150 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - หลบ + (`AvoidUp`) = `avoid`
  - ลดดาเมจเวทที่ได้รับ (`MagicDmgCut`) = `cverlayCount × (HandlingerOfGodspeedBuf.GetGodSpearHandlingParam(this, id) - magicResist)`
  - ลดดาเมจกายภาพที่ได้รับ (`PowerDmgCut`) = `cverlayCount × (HandlingerOfGodspeedBuf.GetGodSpearHandlingParam(this, id) - physicsResist)`
- ข้อความในเกม (คำอธิบาย): ลดต้านทานอาวุธ/ต้านทานเวทย์ลงเป็นจำนวนมาก — Text
- ข้อความในเกม (Lv9): ลดการลดลงของต้านทานอาวุธ — Text
- ข้อความในเกม (Lv9): ลดการลดลงของต้านทานเวทย์ — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- MP สูงสุด + (`MaxMpUp`) = `-maxMp`
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `cverlayCount`
- ความเร็วโจมตี + (`Aspd`) = `aspd`
- MotionSpeedRate (`MotionSpeedRate`) = `actionSpeed`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย GodSpearHandling1Action (uid 991) ผ่าน `GodSpearHandling1Action.ActionHit` (GetSkillLv) — Action Hit — Code
- ถูกอ่านโดย GodSpearHandling1Action (uid 991) ผ่าน `GodSpearHandling1Action.IsFailure` (GetSkillLv) — predicate is failure — Code
- ถูกอ่านโดย GodSpearHandling1Action (uid 991) ผ่าน `GodSpearHandling1Action.IsFailure` (TryGetBuf) — predicate is failure — Code
- ถูกอ่านโดย GodSpearHandling2Action (uid 990) ผ่าน `GodSpearHandling2Action.ActionHit` (GetSkillLv) — Action Hit — Code
- ถูกอ่านโดย GodSpearHandling2Action (uid 990) ผ่าน `GodSpearHandling2Action.IsFailure` (GetSkillLv) — predicate is failure — Code
- ถูกอ่านโดย GodSpearHandling2Action (uid 990) ผ่าน `GodSpearHandling2Action.IsFailure` (TryGetBuf) — predicate is failure — Code
- ถูกอ่านโดย GodSpearHandling3Action (uid 989) ผ่าน `GodSpearHandling3Action.ActionHit` (GetSkillLv) — Action Hit — Code
- ถูกอ่านโดย GodSpearHandling3Action (uid 989) ผ่าน `GodSpearHandling3Action.IsFailure` (GetSkillLv) — predicate is failure — Code
- ถูกอ่านโดย GodSpearHandling3Action (uid 989) ผ่าน `GodSpearHandling3Action.IsFailure` (TryGetBuf) — predicate is failure — Code


---

### บัสเตอร์แลนซ์ / แพนิกบัสเตอร์แลนซ์ (BusterLunce) · uid 975
- ทรี: สกิลหอกวายุ · เลเวลสูงสุด: 70 · อาวุธที่ใช้ได้: ทวน
- ประเภทดาเมจ: กายภาพ; เวทเมื่อเป็นท่า Punish Ray · Proration: dynamic (first_hit_per_target)

**ชื่อ/รูปแบบของสกิล (จากข้อความในเกม):** [N] บัสเตอร์แลนซ์ · [P] แพนิกบัสเตอร์แลนซ์

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ AGIรวม/STRรวม
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **100** คงที่ทุก Lv
    - ตัวปรับ `fixAddDamage`: `fixAddDamage + 100` เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`((((500 + (((AGIรวม + STRรวม) lt 0 ? ((AGIรวม + STRรวม) + 1) : (AGIรวม + STRรวม)) >> 1))) - (((100 - (Lv + (Lv << 2)))) * max((((MathUtil.DistanceToDisplayMeter((MathU…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] หรือ [`((((500 + (((AGIรวม + STRรวม) lt 0 ? ((AGIรวม + STRรวม) + 1) : (AGIรวม + STRรวม)) >> 1))) - (((100 - (Lv + (Lv << 2)))) * max((((MathUtil.DistanceToDisplayMeter((-1)) …(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)]
    - ตัวปรับ `skillRate`: `(skillRate + ((PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[967].Level + (PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[967].Level << 2)) <<…(ย่อ)` เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `distanceAttenuation`: `distanceAttenuation - 25` เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `attenuationStartDist`: `attenuationStartDist + 3`
  - Proration (`ExpRate`, SetRate) `ExtensionMethod.ExSkillData.SkillDataExtentionMethod.GetTargetExpRate(BusterLanceAction.get_AttackType(), PlayerAttackBase.get_ActionID(), MobActionManagerBase.get_Mob…(ย่อ)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ดราโกนิกชาร์จ (DragonicCharge) · uid 976
- ทรี: สกิลหอกวายุ · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: ทวน
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ตัวคูณสกิล (`SkillRate`, SetRate) [`(isFirst = 0 ? 50 × Lv + 500 : 50 × Lv + 500) × (5 × [_currentSkillCombo+0x18] / 100 + 1) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] หรือ [`(isFirst = 0 ? 50 × Lv + 500 : 50 × Lv + 500) × (5 × [_currentSkillCombo+0x18] / 100 + 1) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] หรือ [`(isFirst = 0 ? 50 × Lv + 500 : 50 × Lv + 500) × (SkillBufferDataBase.GetParam(20) / 100 + 1) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ ActionRange ≠ -1 (+เงื่อนไขอื่น)] หรือ [`(isFirst = 0 ? 50 × Lv + 500 : 50 × Lv + 500) × (0 / 100 + 1) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ ActionRange ≠ -1 (+เงื่อนไขอื่น)]
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `target`: `target`
    - ตัวปรับ `target`: `target`
  - Proration (`ExpRate`, SetRate) `(proration ที่เก็บไว้ตอนร่าย[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ดาเมจหลัก** — isFirst = 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, SetConstant) `30 × Lv` → Lv1 30 · Lv5 150 · Lv10 300
  - หักป้องกันเป้า (`Def`, SetConstant) [`-int((1 - min(max((min(20 × int(MathUtil.DistanceToDisplayMeter(MobActionManagerBase.get_PlayerDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(targe…(ย่อ)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ ActionRange ≠ -1 (+เงื่อนไขอื่น)] หรือ [`-int((1 - min(max((10 × int(MathUtil.DistanceToDisplayMeter(MobActionManagerBase.get_PlayerDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, p…(ย่อ)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น) หรือ ActionRange ≠ -1 (+เงื่อนไขอื่น)] — เมื่อ (+เงื่อนไขอื่น) หรือ abnormalType = 0 (+เงื่อนไขอื่น) หรือ abnormalType ≠ 0 (+เงื่อนไขอื่น)
  - หักป้องกันเป้า (`Def`, SetConstant) `-int(IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction)))` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น) หรือ abnormalType = 0 (+เงื่อนไขอื่น) หรือ abnormalType ≠ 0 (+เงื่อนไขอื่น)
- **ดาเมจหลัก** — isFirst ≠ 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, SetConstant) = **300** คงที่ทุก Lv

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = `int(chargeValue)`

#### 5) เชื่อมกับสกิลอื่น
- สกิลนี้ใส่บัพของสกิล 987 (uid 987) — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `GuardActionManager.CheckGuardStart` (TryGetBuf) — check guard start — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManagerBase.InMobAttackArea` (TryGetBuf) — In Mob Attack Area — Code


---

### อินฟิไนท์ไดเมนชัน (DimensionTill) · uid 977
- ทรี: สกิลหอกวายุ · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: ทวน
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (never (IsExpDefFluctuate=false))

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ AGI(ที่ลงเอง)/STR(ที่ลงเอง)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, SetConstant) `20 × Lv` → Lv1 20 · Lv5 100 · Lv10 200 — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, SetRate) `(AGI(ที่ลงเอง) + STR(ที่ลงเอง)) ÷ 5 + 400 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
- สถานะผิดปกติที่ติดเป้า:
  - ตาพร่า โอกาส `AGI(ที่ลงเอง) ÷ 10 + 5 × Lv` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล โครนอสไดรฟ์ (uid 973): `DimensionTillAction.ActionHit` (ContainsBuffer) — Action Hit — Code


---

### ออลไมทีวีลด์ (GodSpearHandling) · uid 978
- ทรี: สกิลหอกวายุ · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: ทวน

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ตอนโดนดาเมจ มีโอกาสติดคงกระพัน 2 วินาที: โอกาส % = int(AGI(ที่ลงเอง) ÷ 3.5) + 2×Lv + 10, ต้องถือทวน (Halberd) เป็นอาวุธหลัก, ใช้ได้ไม่เกิน 1 ครั้งต่อ 10 วินาที (เวลาจริง) — Code · `GodSpearHandlingMastary.CheckEffectiveIveinvincible + HandlingerOfGodspeedBuf.DamageFunction -> AddTimeInvincibility(2, 0)`
- พาสซีฟ/มาสเตอรี่: ดาเมจสุดท้าย % (`LastDmgRate`) → Lv1 1 · Lv5 5 · Lv10 10 — Code
- ข้อความในเกม (คำอธิบาย): ลดปริมาณการลดลงของค่าต้านทานต่างๆ ที่เกิดจากสกิล[เทพลมกรด] — Text
- ข้อความในเกม (คำอธิบาย): เมื่อได้รับความเสียหายมีโอกาสคงกระพัน(ขึ้นอยู่กับค่าAGI) — Text

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย GodSpearHandling1Action (uid 991) ผ่าน `GodSpearHandling1Action.IsFailure` (GetSkillLv) — predicate is failure — Code
- ถูกอ่านโดย GodSpearHandling2Action (uid 990) ผ่าน `GodSpearHandling2Action.IsFailure` (GetSkillLv) — predicate is failure — Code
- ถูกอ่านโดย GodSpearHandling3Action (uid 989) ผ่าน `GodSpearHandling3Action.IsFailure` (GetSkillLv) — predicate is failure — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `SkillManager.GetAvailableSkill` (GetSkillLv) — Get Available Skill — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIComboWindow.Initialize` (GetSkillLv) — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIComboWindow.SetSkillTreeButton` (GetSkillLv) — Code


---

### ทอร์นาโดแลนซ์ (TornadoLance) · uid 979
- ทรี: สกิลหอกวายุ · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: ทวน

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - FleeRate (`FleeRate`) = **10** คงที่ทุก Lv
- ข้อความในเกม (Lv9): อัตราหลบหลีกจะเพิ่มขึ้นตามค่าที่สูญเสียไป — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: `MobAttackBase.CalcHit`, `MobaPlayerSecondaryStatus.get_CriticalDmg` — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ค่าเปอร์เซ็นต์ทั่วไป (`Percent`) = `int(pursuitPercent × Count)`
- CrtDamageUp (`CrtDamageUp`) = `int(crtDamageUp × Count)`
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MagicPursuit.Calc` (TryGetBuf) — calculate  — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobAttackBase.CalcHit` (ContainsBuffer) — calculate hit — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobEventScriptAttack.CalcHit` (TryGetBuf) — calculate hit — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerSecondaryStatus.get_CriticalDmg` (TryGetBuf) — Critical Dmg of MobaPlayerSecondaryStatus — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PhysicalPursuit.Calc` (TryGetBuf) — calculate  — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.CalcStable` (TryGetBuf) — Stability multiplier — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.ChackCorrectHit` (TryGetBuf) — Chack Correct Hit — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.CalcCriticalDmg` (TryGetBuf) — calculate critical dmg — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.get_CurrectHit` (TryGetBuf) — Currect Hit of PlayerSecondaryStatus — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `ReceiveBattleResult.AttackMobaMob` (GetSkillLv) — Attack Moba Mob — Code


---

### บลิทซ์ไปก์ (BlitzPike) · uid 980
- ทรี: สกิลหอกวายุ · เลเวลสูงสุด: 70 · อาวุธที่ใช้ได้: ทวน
- ประเภทดาเมจ: กายภาพ; ช่อง proration เป็นช่องเวท (ExpType const 2) · Proration: ช่องเวท (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ INT(ที่ลงเอง)/INTรวม/STR(ที่ลงเอง)
- **CalcFirstDamageData**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [ช่องที่ 1 ของอาร์เรย์ต่อฮิต] = **300** คงที่ทุก Lv — เมื่อ fixAddDamage.Length ≠ 0 และ skillRate.Length ≠ 0
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ช่องที่ 1 ของอาร์เรย์ต่อฮิต] [`10 × Lv + 10 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.ThorHammer, 1) + STR(ที่ลงเอง) ÷ 2 + 300 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ fixAddDamage.Length > 1 และ fixAddDamage.Length ≠ 0 และ skillRate.Length ≠ 0 และ skillRate.Length ≠ 1 (+เงื่อนไขอื่น)] หรือ [`10 × Lv + 300 %` → Lv1 310% · Lv5 350% · Lv10 400% — เมื่อ (skillRate.Length = 1 และ skillRate.Length ≠ 0) หรือ (fixAddDamage.Length = 0 และ skillRate.Length ≠ 0 และ skillRate.Length ≠ 1) หรือ (fixAddDamage.Length ≤ 1 แ] — เมื่อ (fixAddDamage.Length ≠ 0 และ skillRate.Length ≠ 0 (+เงื่อนไขอื่น)) หรือ skillRate.Length ≠ 0
  - Proration (`ExpRate`, SetRate) `exp / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ fixAddDamage.Length ≠ 0 และ skillRate.Length ≠ 0
- **CalcSecondDamageData**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [ช่องที่ 2 ของอาร์เรย์ต่อฮิต] `INTรวม ÷ 2` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ fixAddDamage.Length > 1 และ skillRate.Length > 1
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ช่องที่ 2 ของอาร์เรย์ต่อฮิต] [`30 × Lv + 10 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.ThorHammer, 1) + INT(ที่ลงเอง) ÷ 2 + 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ fixAddDamage.Length > 1 และ fixAddDamage.Length ≠ 0 และ skillRate.Length > 1 และ skillRate.Length ≠ 0 และ skillRate.Length ≠ 1 (+เงื่อนไขอื่น)] หรือ [`30 × Lv + 100 %` → Lv1 130% · Lv5 250% · Lv10 400% — เมื่อ (fixAddDamage.Length = 0 และ skillRate.Length ≠ 0 และ skillRate.Length ≠ 1) หรือ (fixAddDamage.Length ≤ 1 และ fixAddDamage.Length ≠ 0 และ skillRate.Length ≠ 0 แ] — เมื่อ skillRate.Length > 1
  - Proration (`ExpRate`, SetRate) `exp / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ fixAddDamage.Length > 1 และ skillRate.Length > 1
- สถานะผิดปกติที่ติดเป้า:
  - อัมพาต โอกาส `INT(ที่ลงเอง) ÷ 10 + 5 × Lv` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: ธอร์แฮมเมอร์ (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `int(100 × intervalTimer)`
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- สกิลนี้ใส่บัพของสกิล 987 (uid 987) — Code
- ได้รับการเสริมจากสกิล ธอร์แฮมเมอร์ (uid 982): `BlitzPikeAction.OnInitialize` (GetSkillLv) — BlitzPikeAction: initial values — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `SkillBufferManager.UpdateIndividualBuf` (TryGetBuf) — Update Individual Buf — Code


---

### ไลท์นิ่งเฮล (LightningHail) · uid 981
- ทรี: สกิลหอกวายุ · เลเวลสูงสุด: 150 · อาวุธที่ใช้ได้: ทวน
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ INTรวม
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `10 × Lv + 100` → Lv1 110 · Lv5 150 · Lv10 200
  - ตัวคูณสกิล (`SkillRate`, AddRate) `INTรวม ÷ 10 + 20 × int(0.5 × Lv) + 75 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `proration ช่องเวทของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(proration ที่เก็บไว้ตอนร่าย[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- คงกระพัน (สถานะ Invincibility) ตั้งแต่เริ่มท่า จนถอดตอนจบท่า — เพดาน 3 วินาที — Code · `ActionStart: AbnormalStateManager$$AddInvincibilityTemporarilyInAction`
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (คำอธิบาย): ตัวเองจะติดคงกระพันเมื่อเปิดใช้สกิล — Text

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) `int(0.5 × Lv) + 3` → Lv1 3 · Lv5 5 · Lv10 8

#### 5) เชื่อมกับสกิลอื่น
- สกิลนี้ใส่บัพของสกิล 987 (uid 987) — Code
- ได้รับการเสริมจากสกิล ธอร์แฮมเมอร์ (uid 982): `LightningHailAction.ActionStart` (GetSkillLv) — LightningHailAction: skill start — Code


---

### ธอร์แฮมเมอร์ (ThorHammer) · uid 982
- ทรี: สกิลหอกวายุ · เลเวลสูงสุด: 240 · อาวุธที่ใช้ได้: ทวน
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ INTรวม, บัพ/มาสเตอรี่/สกิลอื่น
- **ดาเมจหลัก**
  - Proration (`ExpRate`, SetRate) `proration ช่องเวทของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(proration ที่เก็บไว้ตอนร่าย[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ดาเมจหลัก** — nowAttackCount ≠ 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `(((Level ของบัพ ไลท์นิ่งเฮล * 10) + 100))` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ดาเมจคงที่จากบัพ (`BufferConstantDamage`, SetConstant) = **0** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `(pursuitHitCount + 1) * (((((Level ของบัพ ไลท์นิ่งเฮล >> 1) * 20) + (INTรวม ÷ 10)) + 75)) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `pursuitHitCount`: `pursuitHitCount ≥ 7 ? 8 : pursuitHitCount + 1` เมื่อ nowAttackCount ≥ 1
- **ดาเมจหลัก** — nowAttackCount = 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **400** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `50 × Lv + 1000 %` → Lv1 1050% · Lv5 1250% · Lv10 1500%

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ตัวคูณโจมตีไล่ตามเวท (`MagiclPursuitSkillRate`) `10 × Lv` → Lv1 10 · Lv5 50 · Lv10 100
- เจาะเวท (`MagicResistBreaker`) `2 × Lv` → Lv1 2 · Lv5 10 · Lv10 20
- ความแม่น + (`HitUp`) = `INT(ที่ลงเอง) × Lv ÷ 10`

#### 5) เชื่อมกับสกิลอื่น
- สกิลนี้ใส่บัพของสกิล 987 (uid 987) — Code
- ถูกอ่านโดย บลิทซ์ไปก์ (uid 980) ผ่าน `BlitzPikeAction.OnInitialize` (GetSkillLv) — BlitzPikeAction: initial values — Code
- ถูกอ่านโดย ไลท์นิ่งเฮล (uid 981) ผ่าน `LightningHailAction.ActionStart` (GetSkillLv) — LightningHailAction: skill start — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.PursuitAttack` (ContainsBuffer) — Pursuit Attack — Code


---
