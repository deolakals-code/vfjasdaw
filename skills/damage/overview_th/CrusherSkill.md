# สกิลครัชเชอร์ (10 สกิล)

สรุปโดยรวมต่อสกิล: ตัวคูณดาเมจมาจากไหน / แยกอาวุธ / สถานะระหว่างท่า / บัพ / เชื่อมสกิลอื่น. วิธีอ่าน: [ENGINE.md](ENGINE.md)

### กำปั้นผดุงคุณธรรม (ForefistPunch) · uid 1153
- ทรี: สกิลครัชเชอร์ · เลเวลสูงสุด: 50 · อาวุธที่ใช้ได้: MainKnuckle
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **200** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `20 × Lv + 200 %` → Lv1 220% · Lv5 300% · Lv10 400%
    - ตัวปรับ `skillRate`: `(skillRate + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1158], SkillBufferId.Value))` เมื่อ (+เงื่อนไขอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (คำอธิบาย): ระหว่างใช้ความเสียหายที่ได้รับจะลดลง 1 ครั้ง — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = **25** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### วิธีการหายใจ (BreathingMethod) · uid 1154
- ทรี: สกิลครัชเชอร์ · เลเวลสูงสุด: 50 · อาวุธที่ใช้ได้: สนับมือ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย กีย์เซอร์ชู้ต (uid 1162) ผ่าน `GazerShootAction.ActionHit` (GetSkillLv) — Action Hit — Code
- ถูกอ่านโดย เทอราบลาสต์ (uid 1160) ผ่าน `GeoImpactAction.ActionPreparation` (TryGetBuf) — GeoImpactAction: preparation — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.CalcCostMp` (ContainsBuffer) — Skill MP cost — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.RemoveAfterSkillBuf` (ContainsBuffer) — Remove After Skill Buf — Code


---

### กลอเรียเทคชอต (GoliathTakeShot) · uid 1155
- ทรี: สกิลครัชเชอร์ · เลเวลสูงสุด: 90 · อาวุธที่ใช้ได้: MainKnuckle
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **500** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`(10 × Lv + 300) × GoliathTakeShotBuf.GetParam(50) + 800 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] หรือ [`(10 × Lv + 300) × GoliathTakeShotBuf.GetParam(50) + 800 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)]
    - ตัวปรับ `baseSkillRate`: `(baseSkillRate + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1158], SkillBufferId.Value))` เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `chargeSkillRate`: `(chargeSkillRate + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1158], SkillBufferId.Value))` เมื่อ (+เงื่อนไขอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `chargeLevel`

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล ผู้ทำลายล้าง (uid 1159): `GoliathTakeShotAction.EnemyDamage` (ContainsBuffer) — สกิล Goliath Take Shot อ่านเลเวลสกิลนี้ตอนทำดาเมจใส่ศัตรู (ผลต่อชาร์จ/ดาเมจ ดู README ของสกิลนั้น) — Code
- ได้รับการเสริมจากสกิล ร่างแกร่งดุจเทพ (uid 1161): `GoliathTakeShotAction.EnemyDamage` (GetSkillLv) — สกิล Goliath Take Shot อ่านเลเวลสกิลนี้ตอนทำดาเมจใส่ศัตรู (ผลต่อชาร์จ/ดาเมจ ดู README ของสกิลนั้น) — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.GetSkillTargetType` (ContainsBuffer) — Get Skill Target Type — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.GetSkillTargetType` (ContainsBuffer) — Get Skill Target Type — Code


---

### ฟลายอิ้งคิก (FloatingKick) · uid 1156
- ทรี: สกิลครัชเชอร์ · เลเวลสูงสุด: 90 · อาวุธที่ใช้ได้: สนับมือ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `10 × Lv + 100` → Lv1 110 · Lv5 150 · Lv10 200
  - ตัวคูณสกิล (`SkillRate`, AddRate) `20 × Lv + 500 %` → Lv1 520% · Lv5 600% · Lv10 700%
    - ตัวปรับ `skillRate`: `(skillRate + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1158], SkillBufferId.Value))` เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณคริเพิ่ม (`CriticalRate`, AddRate) `4 × Lv + 10 %` → Lv1 14% · Lv5 30% · Lv10 50% — เมื่อ inputDirection = 0 (+เงื่อนไขอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### คอมบิเนชั่น (Combination) · uid 1157
- ทรี: สกิลครัชเชอร์ · เลเวลสูงสุด: 90 · อาวุธที่ใช้ได้: MainKnuckle
- ประเภทดาเมจ: ธรรมดา (SkillNormal) · Proration: ช่องตีปกติ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ตัวคูณสกิล (`SkillRate`, AddRate) `10 × Lv + 100 %` → Lv1 110% · Lv5 150% · Lv10 200%
    - ตัวปรับ `skillRate`: `(skillRate + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1158], SkillBufferId.Value))` เมื่อ (+เงื่อนไขอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ก็อดแฮนด์ (GodHand) · uid 1158
- ทรี: สกิลครัชเชอร์ · เลเวลสูงสุด: 170 · อาวุธที่ใช้ได้: MainKnuckle
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `40 × Lv` → Lv1 40 · Lv5 200 · Lv10 400
  - ตัวคูณสกิล (`SkillRate`, AddRate) = **1000%** คงที่ทุก Lv
    - ตัวปรับ `skillRate`: `(skillRate + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1158], SkillBufferId.Value))` เมื่อ (+เงื่อนไขอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: ร่างแกร่งดุจเทพ (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - (`MobLastDamageRate*` เข้าสูตรดาเมจที่มอนทำใส่ผู้เล่นใน `MobAttackBase.CalcLastDamage` — ค่านี้คือส่วนลดดาเมจที่ได้รับ; หน่วยและการรวมกับบัพอื่นยังไม่ยืนยัน — Inferred)
  - ต้านสถานะผิดปกติ (`AbnormalRegist`) = `ค่า Value ของมาสเตอรี่` — เมื่อ isSkillEnd = 0
  - ตัวคูณดาเมจที่ได้รับจากมอน (หมวดบัพ) (`MobLastDamageRateBuf`) = `ค่า CutDmgRate ของมาสเตอรี่` — เมื่อ isSkillEnd = 0
  - MobLastDamageRateUnique (`MobLastDamageRateUnique`) = `damageDownRate` — เมื่อ isSkillEnd = 0
- ข้อความในเกม (คำอธิบาย): ความเสียหายจะลดลงเสมอในขณะใช้งาน — Text
- ข้อความในเกม (คำอธิบาย): หากโจมตีโดนหรือลดความเสียหายลงได้สำเร็จ — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: `MobaPlayerActionManager.ReceiveDamaged`, `MobaPlayerActionManager.ReceiveDamaged`, `MobaPlayerSecondaryStatus.get_AntiVirus`, `PlayerActionManager.Damaged` — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) `10 × Count × Lv` → Lv1 10 · Lv5 50 · Lv10 100

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล ร่างแกร่งดุจเทพ (uid 1161): `GodHandBuf.DeathExemption` (GetSkillLv) — ตอนจะตายระหว่างบัพ ก็อดแฮนด์ ถ้าเรียนสกิลนี้และยังมีสิทธิ์ จะรอดตาย แล้วสิทธิ์หมด (isDeathExemption → 0) — Code
- ได้รับการเสริมจากสกิล ร่างแกร่งดุจเทพ (uid 1161): `GodHandBuf.Initalize` (GetSkillLv) — เมื่อเริ่มบัพ ก็อดแฮนด์ ถ้าเรียนสกิลนี้ ตั้งสิทธิ์ «รอดตาย 1 ครั้ง» (isDeathExemption = 1) — Code
- ถูกอ่านโดย กีย์เซอร์ชู้ต (uid 1162) ผ่าน `GazerShootAction.ActionPreparation` (TryGetBuf) — GazerShootAction: preparation — Code
- ถูกอ่านโดย MindimageSenjuAttackAction (uid 159) ผ่าน `MindimageSenjuAttackAction.ActionHit` (TryGetBuf) — Action Hit — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.ReceiveDamaged` (GetSkillLv) — Receive Damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.ReceiveDamaged` (TryGetBuf) — Receive Damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerSecondaryStatus.get_AntiVirus` (TryGetBuf) — Anti Virus of MobaPlayerSecondaryStatus — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.Damaged` (TryGetBuf) — PlayerActionManager: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.CalcAntiVirus` (TryGetBuf) — calculate anti virus — Code

#### 6) ลดดาเมจระหว่างก็อดแฮนด์ (จากบัพ GodHandBuf)
- ขณะบัพทำงาน (isSkillEnd = 0): `MobLastDamageRateUnique` = damageDownRate (ตั้งใน GodHandBuf..ctor ตามค่า lv ของบัพ) — Code
- damageDownRate ตามค่า lv ที่ส่งเข้าบัพ (1…10): 90, 90, 90, 90, 90, 90, 45, 57, 72, 90 — Code (lv 7/8/9 ต่ำกว่า lv 10 และ lv ≤ 6 = 90: รูปแบบนี้ผิดปกติ จึงไม่ฟันธงว่าคือเลเวลสกิลโดยตรง — Inferred)
- ถ้าเรียนร่างแกร่งดุจเทพ (GodRigidBody, uid 1161): `MobLastDamageRateBuf` = CutDmgRate ของมาสเตอรี่ = 90 ขณะ isSkillEnd = 0 — Code
- MobAttackBase.CalcLastDamage อ่าน GodHandBuf.GetParam(5) (= Unique) และ GetParam(6) (= Buf เมื่อมี GodRigidBody) และเลือกค่าที่มากกว่าเมื่อเทียบกับแหล่งลดดาเมจอื่น — Inferred จากรูปแบบ `a >= b ? a : b` ใน CalcLastDamage
- สถานะตายแล้วรอด 1 ครั้ง (DeathExemption) และต้านสถานะผิดปกติ (AbnormalRegist = ค่า Value ของ GodRigidBody) อยู่ในหัวข้อ 5 และ 3 — Code


---

### ผู้ทำลายล้าง (Destroyer) · uid 1159
- ทรี: สกิลครัชเชอร์ · เลเวลสูงสุด: 170 · อาวุธที่ใช้ได้: สนับมือ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- BaseEqAtkUpRate (`BaseEqAtkUpRate`) `5 × Lv` → Lv1 5 · Lv5 25 · Lv10 50 — เมื่อ isMainKnuckleEquip ≠ 0
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) `int(2.5 × Lv)` → Lv1 2 · Lv5 12 · Lv10 25 — เมื่อ isMainKnuckleEquip ≠ 0
- ความเสถียร (`Stable`) = `isMainKnuckleEquip = 0 ? 0 : 0xfffffff6`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย เอนชานท์บลาส / เอนชานท์อกรา (uid 872) ผ่าน `EnchantedBurstAction.ActionHit` (ContainsBuffer) — Action Hit — Code
- ถูกอ่านโดย เอนชานท์บลาส / เอนชานท์อกรา (uid 872) ผ่าน `EnchantedBurstAction.AddLocalStack` (ContainsBuffer) — Add Local Stack — Code
- ถูกอ่านโดย เอนชานท์ซอร์ด / เอนชานท์บลาสซอร์ด (uid 870) ผ่าน `EnchantedSwordAction.ActionPreparation` (ContainsBuffer) — EnchantedSwordAction: preparation — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `EquipItemData.WeaponTypeCalculatorBase.CalcEqAtk` (TryGetBuf) — calculate eq atk — Code
- ถูกอ่านโดย เทอราบลาสต์ (uid 1160) ผ่าน `GeoImpactAction.calcPlayerToMobDamage` (ContainsBuffer) — GeoImpactAction: player→mob damage template — Code
- ถูกอ่านโดย กลอเรียเทคชอต (uid 1155) ผ่าน `GoliathTakeShotAction.EnemyDamage` (ContainsBuffer) — สกิล Goliath Take Shot อ่านเลเวลสกิลนี้ตอนทำดาเมจใส่ศัตรู (ผลต่อชาร์จ/ดาเมจ ดู README ของสกิลนั้น) — Code
- ถูกอ่านโดย MindimageSenjuAttackAction (uid 159) ผ่าน `MindimageSenjuAttackAction.CalcDamageGeoImpact` (ContainsBuffer) — calculate damage geo impact — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.CalcCostMp` (GetSkillLv) — Skill MP cost — Code
- ถูกอ่านโดย เชลเบรค (uid 134) ผ่าน `ShellBreakAction.OnInitialize` (TryGetBuf) — ShellBreakAction: initial values — Code


---

### เทอราบลาสต์ (GeoImpact) · uid 1160
- ทรี: สกิลครัชเชอร์ · เลเวลสูงสุด: 250 · อาวุธที่ใช้ได้: MainKnuckle
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ AGI(ที่ลงเอง)/STR(ที่ลงเอง)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `10 × Lv + 700` → Lv1 710 · Lv5 750 · Lv10 800
  - ตัวคูณสกิล (`SkillRate`, AddRate) `System.Math.Max(STR(ที่ลงเอง), AGI(ที่ลงเอง)) + 60 × Lv + 900 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `skillRate`: `(SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1158], SkillBufferId.Value) + skillRate)`

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (คำอธิบาย): ทักษะการบดขยี้แผ่นดินแล้วใช้หินที่ยกสูงขึ้นเป็นเกราะกำบัง — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `barrier`
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล วิธีการหายใจ (uid 1154): `GeoImpactAction.ActionPreparation` (TryGetBuf) — GeoImpactAction: preparation — Code
- ได้รับการเสริมจากสกิล ผู้ทำลายล้าง (uid 1159): `GeoImpactAction.calcPlayerToMobDamage` (ContainsBuffer) — GeoImpactAction: player→mob damage template — Code


---

### ร่างแกร่งดุจเทพ (GodRigidBody) · uid 1161
- ทรี: สกิลครัชเชอร์ · เลเวลสูงสุด: 250 · อาวุธที่ใช้ได้: MainKnuckle

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ลดดาเมจที่ได้รับ % (`CutDmgRate`) = **90** คงที่ทุก Lv — Code
- พาสซีฟ/มาสเตอรี่: ค่าทั่วไป (`Value`) → Lv1 5 · Lv5 25 · Lv10 50 — Code
- ข้อความในเกม (คำอธิบาย): ระหว่างใช้ก็อดแฮนด์อัตราความเสียหายจะลดลง — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ก็อดแฮนด์ (uid 1158) ผ่าน `GodHandBuf.DeathExemption` (GetSkillLv) — ตอนจะตายระหว่างบัพ ก็อดแฮนด์ ถ้าเรียนสกิลนี้และยังมีสิทธิ์ จะรอดตาย แล้วสิทธิ์หมด (isDeathExemption → 0) — Code
- ถูกอ่านโดย ก็อดแฮนด์ (uid 1158) ผ่าน `GodHandBuf.Initalize` (GetSkillLv) — เมื่อเริ่มบัพ ก็อดแฮนด์ ถ้าเรียนสกิลนี้ ตั้งสิทธิ์ «รอดตาย 1 ครั้ง» (isDeathExemption = 1) — Code
- ถูกอ่านโดย กลอเรียเทคชอต (uid 1155) ผ่าน `GoliathTakeShotAction.EnemyDamage` (GetSkillLv) — สกิล Goliath Take Shot อ่านเลเวลสกิลนี้ตอนทำดาเมจใส่ศัตรู (ผลต่อชาร์จ/ดาเมจ ดู README ของสกิลนั้น) — Code


---

### กีย์เซอร์ชู้ต (GazerShoot) · uid 1162
- ทรี: สกิลครัชเชอร์ · เลเวลสูงสุด: 250 · อาวุธที่ใช้ได้: MainKnuckle
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ AGIรวม
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `10 × Lv + 200` → Lv1 210 · Lv5 250 · Lv10 300
  - ตัวคูณสกิล (`SkillRate`, AddRate) `10 × Lv + AGIรวม ÷ 2 + 900 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `skillRate`: `skillRate + SkillBufferDataBase.GetParam(50)` เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`50 × Lv %` → Lv1 50% · Lv5 250% · Lv10 500%] หรือ [= **0%** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)] — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) = **0%** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: วิธีการหายใจ (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `nextHeal`

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล วิธีการหายใจ (uid 1154): `GazerShootAction.ActionHit` (GetSkillLv) — Action Hit — Code
- ได้รับการเสริมจากสกิล ก็อดแฮนด์ (uid 1158): `GazerShootAction.ActionPreparation` (TryGetBuf) — GazerShootAction: preparation — Code


---
