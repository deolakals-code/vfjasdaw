# สกิลนักบวช (15 สกิล)

สรุปโดยรวมต่อสกิล: ตัวคูณดาเมจมาจากไหน / แยกอาวุธ / สถานะระหว่างท่า / บัพ / เชื่อมสกิลอื่น. วิธีอ่าน: [ENGINE.md](ENGINE.md)

### เบลส (Bless) · uid 833
- ทรี: สกิลนักบวช · เลเวลสูงสุด: 15 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: เอนเชนส์เบลส (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล เอนเชนส์เบลส (uid 837): `BlessAction.OnInitialize` (GetSkillLv) — BlessAction: initial values — Code


---

### โฮลี่ฟิสท์ (HollyFist) · uid 834
- ทรี: สกิลนักบวช · เลเวลสูงสุด: 15 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ INTรวม/STRรวม
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `5 × Lv + 50` → Lv1 55 · Lv5 75 · Lv10 100
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`5 × Lv + 50 %` → Lv1 55% · Lv5 75% · Lv10 100%] หรือ [`10 × Lv + INTรวม + 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)]
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`10 × Lv + STRรวม + 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] หรือ [`5 × Lv + 50 %` → Lv1 55% · Lv5 75% · Lv10 100%]
  - Proration (`ExpRate`, SetRate) `ExtensionMethod.ExSkillData.SkillDataExtentionMethod.GetTargetExpRate(SkillAttackType.Physics, PlayerAttackBase.get_ActionID(), MobActionManagerBase.get_MobBattleStatu…(ย่อ)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### กลอเรีย (Gloria) · uid 835
- ทรี: สกิลนักบวช · เลเวลสูงสุด: 35 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - DEF % (`DefRate`) = `defUpRate`
  - MDEF % (`MdefRate`) = `defUpRate`
  - อัตราการ์ด % (`GuardRate`) = `guardUp`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PetStatus.get_GuardDelay` (ContainsBuffer) — Guard Delay of PetStatus — Code


---

### โฮลี่ไลท์ (HollyLight) · uid 836
- ทรี: สกิลนักบวช · เลเวลสูงสุด: 35 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ INTรวม
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [= **200** คงที่ทุก Lv] หรือ [= **200** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)]
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`15 × Lv + 100 %` → Lv1 115% · Lv5 175% · Lv10 250%] หรือ [`15 × Lv + 2 × INTรวม + 200 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] หรือ [`15 × Lv + 100 %` → Lv1 115% · Lv5 175% · Lv10 250% — เมื่อ (+เงื่อนไขอื่น)]

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ? — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerBattleManager.StartHolyBiblePursuitAttack` (GetSkillLv) — Start Holy Bible Pursuit Attack — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.StartHolyBiblePursuitAttack` (GetSkillLv) — Start Holy Bible Pursuit Attack — Code


---

### เอนเชนส์เบลส (BlessStrengthen) · uid 837
- ทรี: สกิลนักบวช · เลเวลสูงสุด: 125 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย เบลส (uid 833) ผ่าน `BlessAction.OnInitialize` (GetSkillLv) — BlessAction: initial values — Code


---

### อีเธอร์บาเรีย (EtherCoat) · uid 838
- ทรี: สกิลนักบวช · เลเวลสูงสุด: 125 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - ต้านสถานะผิดปกติ (`AbnormalRegist`) `5 × Lv + 50` → Lv1 55 · Lv5 75 · Lv10 100
- ข้อความในเกม (คำอธิบาย): เพิ่มความต้านทานสภาวะผิดปกติ[ผงะ] — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- MATK % (`MAtkUpRate`) `int(0.3 × Lv) - 8` → Lv1 -8 · Lv5 -7 · Lv10 -5

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ไฮเนสฮีล (HighnessHeal) · uid 839
- ทรี: สกิลนักบวช · เลเวลสูงสุด: 205 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### พรีเอล (Priere) · uid 840
- ทรี: สกิลนักบวช · เลเวลสูงสุด: 205 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- MATK % (`MAtkUpRate`) = `mAtkUpRate`

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ร็อดสทับ (RodStub) · uid 841
- ทรี: สกิลนักบวช · เลเวลสูงสุด: 15 · อาวุธที่ใช้ได้: ไม้เท้า
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ STRรวม, อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **100** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `Lv + STRรวม + 190 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- สถานะผิดปกติที่ติดเป้า:
  - ผงะ [ไม้เท้า + มือรองที่ไม่ใช่ โล่] โอกาส `5 × Lv + 25` → Lv1 30 · Lv5 50 · Lv10 75
  - ผงะ [ไม้เท้า + มือรอง โล่] โอกาส `5 × Lv + 50` → Lv1 55 · Lv5 75 · Lv10 100

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### เอ็กซอร์ซิสต์ (Exorcism) · uid 842
- ทรี: สกิลนักบวช · เลเวลสูงสุด: 35 · อาวุธที่ใช้ได้: ไม้เท้า, โล่
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ STRรวม
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `target.Element = 6 ? 10 × Lv + 100 : 10 × Lv` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `target.Element = 6 ? (20 × Lv + 0.5 × STRรวม) + 400 : (20 × Lv + 0.5 × STRรวม) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล เนเมซิส (uid 844): `ExorcismAction.ActionStart` (ContainsBuffer) — ExorcismAction: skill start — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.CalcCostMp` (ContainsBuffer) — Skill MP cost — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.RemoveAfterSkillBuf` (ContainsBuffer) — Remove After Skill Buf — Code


---

### โฮลี่ไบเบิ้ล (HolyBible) · uid 843
- ทรี: สกิลนักบวช · เลเวลสูงสุด: 125 · อาวุธที่ใช้ได้: ดาบมือเดียว, ไม้เท้า, สนับมือ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - ReceiveDarkElementDmgRate (`ReceiveDarkElementDmgRate`) = `darkElementDmgRate`
- ข้อความในเกม (คำอธิบาย): เพิ่มต้านทานธาตุมืดเล็กน้อยเป็นเวลา 10 นาที — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: `MobaPlayerBattleManager.StartHolyBiblePursuitAttack`, `PlayerBattleManager.StartHolyBiblePursuitAttack` — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ค่าเปอร์เซ็นต์ทั่วไป (`Percent`) = `activePercent`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย MindimageSenjuSupportAction (uid 158) ผ่าน `MindimageSenjuSupportAction.ActionHit` (TryGetBuf) — Action Hit — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerBattleManager.StartHolyBiblePursuitAttack` (TryGetBuf) — Start Holy Bible Pursuit Attack — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.StartHolyBiblePursuitAttack` (TryGetBuf) — Start Holy Bible Pursuit Attack — Code


---

### เนเมซิส (Nemesis) · uid 844
- ทรี: สกิลนักบวช · เลเวลสูงสุด: 205 · อาวุธที่ใช้ได้: ดาบมือเดียว, ไม้เท้า, สนับมือ
- ประเภทดาเมจ: ฮิตแรกกายภาพ; ฮิตระยะถัดไป (NextRangeHit) เป็นเวท · Proration: dynamic (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ INTรวม/STRรวม
- **ดาเมจหลัก** — isFirst ≠ 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `60 × Lv` → Lv1 60 · Lv5 300 · Lv10 600
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`min(STRรวม + 1000, 1500) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] หรือ [= **1000%** คงที่ทุก Lv]
- **ดาเมจหลัก** — criticalAttackCount = -1 และ criticalAttackCount ≥ 1 และ isFirst = 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `(isFirst = 0 ? 1 : 0) ≠ 0 ? 30 × Lv : 60 × Lv` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`(isFirst = 0 ? 1 : 0) ≠ 0 ? min(0.5 × INTรวม + 500, 750) : min(STRรวม + 1000, 1500) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] หรือ [`(isFirst = 0 ? 1 : 0) ≠ 0 ? min(0.5 × INTรวม + 500, 750) : 1000 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] — เมื่อ (+เงื่อนไขอื่น)
  - Proration (`ExpRate`, SetRate) `proration ช่องเวทของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - Proration (`ExpRate`, SetRate) `(proration ที่เก็บไว้ตอนร่าย[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
- **ดาเมจหลัก** — isFirst = 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `(isFirst = 0 ? 1 : 0) ≠ 0 ? 30 × Lv : 60 × Lv` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`(isFirst = 0 ? 1 : 0) ≠ 0 ? min(0.5 × INTรวม + 500, 750) : min(STRรวม + 1000, 1500) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] หรือ [`(isFirst = 0 ? 1 : 0) ≠ 0 ? min(0.5 × INTรวม + 500, 750) : 1000 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] — เมื่อ (+เงื่อนไขอื่น)
  - Proration (`ExpRate`, SetRate) `proration ช่องเวทของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - Proration (`ExpRate`, SetRate) `(proration ที่เก็บไว้ตอนร่าย[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `BCollaboBossActionManager.Damaged` (TryGetBuf) — BCollaboBossActionManager: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `EnemyMobActionManagerBase.Damaged` (TryGetBuf) — EnemyMobActionManagerBase: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `EnemyMobActionManagerBase.SetHyperModeStatus` (TryGetBuf) — Set Hyper Mode Status — Code
- ถูกอ่านโดย เอ็กซอร์ซิสต์ (uid 842) ผ่าน `ExorcismAction.ActionStart` (ContainsBuffer) — ExorcismAction: skill start — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `GuildRaidBossMobActionManager.Damaged` (TryGetBuf) — GuildRaidBossMobActionManager: on damaged — Code
- ถูกอ่านโดย MindimageSenjuAttackAction (uid 159) ผ่าน `MindimageSenjuAttackAction.ActionStart` (ContainsBuffer) — MindimageSenjuAttackAction: skill start — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaOtherPlayerActionManager.Damaged` (TryGetBuf) — MobaOtherPlayerActionManager: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.AddAbnormalState` (ContainsBuffer) — Add Abnormal State — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.ReceiveAttack` (TryGetBuf) — Receive Attack — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerBattleManager.StartHolyBiblePursuitAttack` (ContainsBuffer) — Start Holy Bible Pursuit Attack — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.AddAbnormalState` (ContainsBuffer) — Add Abnormal State — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.StartHolyBiblePursuitAttack` (ContainsBuffer) — Start Holy Bible Pursuit Attack — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `ScoreAttackBossActionManager.Damaged` (TryGetBuf) — ScoreAttackBossActionManager: on damaged — Code


---

### แอสพิสโซล (AspisSeoul) · uid 845
- ทรี: สกิลนักบวช · เลเวลสูงสุด: 285 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ข้อความในเกม (Lv255): ถ้าอยู่ในปาร์ตี้จะเพิ่มเปอร์เซ็นต์ต้านทานความเสียหาย — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล รีคัฟเวอรี่ (uid 231): `AspisSeoul.ReceiveSupportEvent` (ContainsBuffer) — Receive Support Event — Code


---

### คำสอนศักดิ์สิทธิ์ (SacredTeachings) · uid 846
- ทรี: สกิลนักบวช · เลเวลสูงสุด: 285 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv
- ค่าทั่วไปตัวที่ 2 (`Value2`) = `localOverHealValue` — เมื่อ (+เงื่อนไขอื่น)
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `overHealValue` — เมื่อ (+เงื่อนไขอื่น)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### โฮลี่เกรซ (HolyGrace) · uid 847
- ทรี: สกิลนักบวช · เลเวลสูงสุด: 285 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MainPlayer.PlayerDead` (ContainsBuffer) — Player Dead — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.<HolyGracePursuitAttack>d__148.MoveNext` (GetSkillLv) — Move Next — Code


---
