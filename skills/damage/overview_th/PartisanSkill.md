# สกิลพาร์ทิซาน (9 สกิล)

สรุปโดยรวมต่อสกิล: ตัวคูณดาเมจมาจากไหน / แยกอาวุธ / สถานะระหว่างท่า / บัพ / เชื่อมสกิลอื่น. วิธีอ่าน: [ENGINE.md](ENGINE.md)

### Lบูมเมอแรง / เลเพจบูมเมอแรง (L_Boomerang) · uid 673
- ทรี: สกิลพาร์ทิซาน · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: ดาบสองมือ
- ประเภทดาเมจ: ธรรมดา (SkillNormal) · Proration: ช่องตีปกติ (first_hit_per_target)

**ชื่อ/รูปแบบของสกิล (จากข้อความในเกม):** [N] Lบูมเมอแรง · [N2] เลเพจบูมเมอแรง

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ DEX(ที่ลงเอง)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **200** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`25 × SkillManager.GetSkillLv((PlayerStatusBase.get_SkillManager()), SkillId.L_Boomerang3, 1) + 25 × SkillManager.GetSkillLv((PlayerStatusBase.get_SkillManager()), Skil…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`25 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.L_Boomerang2, 1) + DEX(ที่ลงเอง) + 25 × Lv + 400 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`25 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.L_Boomerang3, 1) + DEX(ที่ลงเอง) + 25 × Lv + 400 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`DEX(ที่ลงเอง) + 25 × Lv + 200 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]
  - Proration (`ExpRate`, SetRate) `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefNormal / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(targetExpList[mobAction] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: LบูมเมอแรงII / เลเพจบูมเมอแรงII (Skill), LบูมเมอแรงIII / เลเพจบูมเมอแรงIII (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล LบูมเมอแรงII / เลเพจบูมเมอแรงII (uid 674): `L_BoomerangAction.OnInitialize` (GetSkillLv) — L_BoomerangAction: initial values — Code
- ได้รับการเสริมจากสกิล LบูมเมอแรงIII / เลเพจบูมเมอแรงIII (uid 675): `L_BoomerangAction.OnInitialize` (GetSkillLv) — L_BoomerangAction: initial values — Code
- ถูกอ่านโดย LบูมเมอแรงII / เลเพจบูมเมอแรงII (uid 674) ผ่าน `L_Boomerang2Action.ActionPreparation` (ContainsBuffer) — L_Boomerang2Action: preparation — Code
- ถูกอ่านโดย LบูมเมอแรงII / เลเพจบูมเมอแรงII (uid 674) ผ่าน `L_Boomerang2Action.OnInitialize` (GetSkillLv) — L_Boomerang2Action: initial values — Code
- ถูกอ่านโดย LบูมเมอแรงIII / เลเพจบูมเมอแรงIII (uid 675) ผ่าน `L_Boomerang3Action.ActionPreparation` (ContainsBuffer) — L_Boomerang3Action: preparation — Code
- ถูกอ่านโดย LบูมเมอแรงIII / เลเพจบูมเมอแรงIII (uid 675) ผ่าน `L_Boomerang3Action.OnInitialize` (GetSkillLv) — L_Boomerang3Action: initial values — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `SkillBufferManager.UpdateBoomerangBuf` (GetSkillLv) — Update Boomerang Buf — Code


---

### LบูมเมอแรงII / เลเพจบูมเมอแรงII (L_Boomerang2) · uid 674
- ทรี: สกิลพาร์ทิซาน · เลเวลสูงสุด: 160 · อาวุธที่ใช้ได้: ดาบสองมือ
- ประเภทดาเมจ: ธรรมดา (SkillNormal) · Proration: ช่องตีปกติ (first_hit_per_target)

**ชื่อ/รูปแบบของสกิล (จากข้อความในเกม):** [N] LบูมเมอแรงII · [N2] เลเพจบูมเมอแรงII

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ DEX(ที่ลงเอง)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **100** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`(25 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.L_Boomerang, 1) + DEX(ที่ลงเอง) + 25 × Lv + ((SkillManager.GetSkillLv(PlayerStatusBase.get_S…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`(DEX(ที่ลงเอง) + 25 × Lv + ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.L_Boomerang3, 1)) > 0 ? 25 × (SkillManager.GetSkillLv(PlayerStatusBas…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]
  - Proration (`ExpRate`, SetRate) `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefNormal / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(targetExpList[mobAction] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: Lบูมเมอแรง / เลเพจบูมเมอแรง (Skill), LบูมเมอแรงIII / เลเพจบูมเมอแรงIII (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- สกิลนี้ใส่บัพของสกิล Lบูมเมอแรง / เลเพจบูมเมอแรง (uid 673) — Code
- ได้รับการเสริมจากสกิล Lบูมเมอแรง / เลเพจบูมเมอแรง (uid 673): `L_Boomerang2Action.ActionPreparation` (ContainsBuffer) — L_Boomerang2Action: preparation — Code
- ได้รับการเสริมจากสกิล Lบูมเมอแรง / เลเพจบูมเมอแรง (uid 673): `L_Boomerang2Action.OnInitialize` (GetSkillLv) — L_Boomerang2Action: initial values — Code
- ได้รับการเสริมจากสกิล LบูมเมอแรงIII / เลเพจบูมเมอแรงIII (uid 675): `L_Boomerang2Action.OnInitialize` (GetSkillLv) — L_Boomerang2Action: initial values — Code
- ถูกอ่านโดย LบูมเมอแรงIII / เลเพจบูมเมอแรงIII (uid 675) ผ่าน `L_Boomerang3Action.OnInitialize` (GetSkillLv) — L_Boomerang3Action: initial values — Code
- ถูกอ่านโดย Lบูมเมอแรง / เลเพจบูมเมอแรง (uid 673) ผ่าน `L_BoomerangAction.OnInitialize` (GetSkillLv) — L_BoomerangAction: initial values — Code


---

### LบูมเมอแรงIII / เลเพจบูมเมอแรงIII (L_Boomerang3) · uid 675
- ทรี: สกิลพาร์ทิซาน · เลเวลสูงสุด: 250 · อาวุธที่ใช้ได้: ดาบสองมือ
- ประเภทดาเมจ: ธรรมดา (SkillNormal) · Proration: ช่องตีปกติ (first_hit_per_target)

**ชื่อ/รูปแบบของสกิล (จากข้อความในเกม):** [N] LบูมเมอแรงIII · [N2] เลเพจบูมเมอแรงIII

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ DEX(ที่ลงเอง)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **400** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`25 × SkillManager.GetSkillLv((PlayerStatusBase.get_SkillManager()), SkillId.L_Boomerang2, 1) + 25 × SkillManager.GetSkillLv((PlayerStatusBase.get_SkillManager()), Skil…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`25 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.L_Boomerang, 1) + DEX(ที่ลงเอง) + 25 × Lv + 400 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`25 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.L_Boomerang2, 1) + DEX(ที่ลงเอง) + 25 × Lv + 400 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`DEX(ที่ลงเอง) + 25 × Lv + 200 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]
  - Proration (`ExpRate`, SetRate) `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefNormal / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(targetExpList[mobAction] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: Lบูมเมอแรง / เลเพจบูมเมอแรง (Skill), LบูมเมอแรงII / เลเพจบูมเมอแรงII (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- สกิลนี้ใส่บัพของสกิล Lบูมเมอแรง / เลเพจบูมเมอแรง (uid 673) — Code
- ได้รับการเสริมจากสกิล Lบูมเมอแรง / เลเพจบูมเมอแรง (uid 673): `L_Boomerang3Action.ActionPreparation` (ContainsBuffer) — L_Boomerang3Action: preparation — Code
- ได้รับการเสริมจากสกิล Lบูมเมอแรง / เลเพจบูมเมอแรง (uid 673): `L_Boomerang3Action.OnInitialize` (GetSkillLv) — L_Boomerang3Action: initial values — Code
- ได้รับการเสริมจากสกิล LบูมเมอแรงII / เลเพจบูมเมอแรงII (uid 674): `L_Boomerang3Action.OnInitialize` (GetSkillLv) — L_Boomerang3Action: initial values — Code
- ถูกอ่านโดย LบูมเมอแรงII / เลเพจบูมเมอแรงII (uid 674) ผ่าน `L_Boomerang2Action.OnInitialize` (GetSkillLv) — L_Boomerang2Action: initial values — Code
- ถูกอ่านโดย Lบูมเมอแรง / เลเพจบูมเมอแรง (uid 673) ผ่าน `L_BoomerangAction.OnInitialize` (GetSkillLv) — L_BoomerangAction: initial values — Code


---

### Nดราก้อนทูธ / นีโน่ดราก้อนทูธ (N_DragonTooth) · uid 676
- ทรี: สกิลพาร์ทิซาน · เลเวลสูงสุด: 250 · อาวุธที่ใช้ได้: ทวน
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

**ชื่อ/รูปแบบของสกิล (จากข้อความในเกม):** [N] Nดราก้อนทูธ · [N2] นีโน่ดราก้อนทูธ

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ฮิต 1**
  - ตัวคูณสกิล (`SkillRate`, AddRate) `75 × Lv %` → Lv1 75% · Lv5 375% · Lv10 750%
- **ฮิต 2**
  - ตัวคูณสกิล (`SkillRate`, AddRate) `max(75 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.DragonTooth, 1), 0) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: ดราก้อนทูธ (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (Lv9): หากใช้สกิลสำเร็จโดยไม่ได้รับความเสียหายจะฟื้นฟู MP เล็กน้อย — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) `2 × Lv` → Lv1 2 · Lv5 10 · Lv10 20

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล ดราก้อนทูธ (uid 972): `N_DragonToothAction.OnInitialize` (GetSkillLv) — N_DragonToothAction: initial values — Code


---

### ฮีลลิ่งช็อต (HealingShot) · uid 677
- ทรี: สกิลพาร์ทิซาน · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: ธนู, โบว์กัน

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: โซลฮันเตอร์ / เดธรีปเปอร์ (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล โซลฮันเตอร์ / เดธรีปเปอร์ (uid 1063): `HealingShotAction.CheckPayHp` (GetSkillLv) — HealingShotAction: can the HP cost be paid — Code


---

### ลับคมลูกศร (ArrowSharpening) · uid 678
- ทรี: สกิลพาร์ทิซาน · เลเวลสูงสุด: 160 · อาวุธที่ใช้ได้: ธนู, โบว์กัน

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- เจาะกายภาพ (`PowerResistBreaker`) = `max(int(STR(ที่ลงเอง) / 50 × Lv), Lv)`
- CrtDamageUpRate (`CrtDamageUpRate`) = `max(int(DEX(ที่ลงเอง) / 25 × Lv), Lv)`
- อัตราคริ % (`CrtUpRate`) = `max(int(DEX(ที่ลงเอง) / 10 × Lv), Lv)`
- ความเร็วท่าทาง + (`MotionSpeed`) = `max(int(AGI(ที่ลงเอง) / 100 × Lv), Lv)`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerSecondaryStatus.GetCrtRate` (TryGetBuf) — Get Crt Rate — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerSecondaryStatus.GetMotionSpeed` (TryGetBuf) — Get Motion Speed — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerSecondaryStatus.get_CriticalDmg` (TryGetBuf) — Critical Dmg of MobaPlayerSecondaryStatus — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.CalcCriticalDmg` (TryGetBuf) — calculate critical dmg — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.GetCalcMotionSpeed` (TryGetBuf) — Get Calc Motion Speed — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.GetCrtRate` (TryGetBuf) — Get Crt Rate — Code


---

### สัญชาตญาณการอยู่รอด (SurvivalInstinct) · uid 679
- ทรี: สกิลพาร์ทิซาน · เลเวลสูงสุด: 250 · อาวุธที่ใช้ได้: ธนู, โบว์กัน

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - HP สูงสุด + (`MaxHpUp`) `500 × Lv` → Lv1 500 · Lv5 2500 · Lv10 5000
  - HP สูงสุด % (`MaxHpUpRate`) `Lv` → Lv1 1 · Lv5 5 · Lv10 10
  - RateDamageResist (`RateDamageResist`) `int(2.5 × Lv)` → Lv1 2 · Lv5 12 · Lv10 25
- ข้อความในเกม (คำอธิบาย): อัตราส่วนการลดความเสียหายจะเพิ่มขึ้น — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: `MobAttackBase.CalcLastDamage` — Inferred

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobAttackBase.CalcLastDamage` (TryGetBuf) — calculate last damage — Code


---

### ค้ำจุนแนวหน้า (MaintainingTheFront) · uid 680
- ทรี: สกิลพาร์ทิซาน · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: ค้ำจุนแนวหน้าII (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `physicalBarrier`
- ค่าเปอร์เซ็นต์ทั่วไป (`Percent`) = `magicBarrier`
- ความเกลียดชัง % (`HateRate`) = `hateRate`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `EquipMagicBarrierBuf.CheckTakeOver` (TryGetBuf) — check take over — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `EquipMagicBarrierBuf.GetBarrierValue` (TryGetBuf) — Get Barrier Value — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `EquipPhysicalBarrierBuf.CheckTakeOver` (TryGetBuf) — check take over — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `EquipPhysicalBarrierBuf.GetBarrierValue` (TryGetBuf) — Get Barrier Value — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.StartRangeHateAttack` (GetSkillLv) — Start Range Hate Attack — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.GetDisplayBonusCalcHate` (TryGetBuf) — Get Display Bonus Calc Hate — Code


---

### ค้ำจุนแนวหน้าII (MaintainingTheFront2) · uid 681
- ทรี: สกิลพาร์ทิซาน · เลเวลสูงสุด: 160 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: HP สูงสุด (`MaxHp`) → Lv1 100 · Lv5 500 · Lv10 1000 — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---
