# สกิลสไปรท์ (18 สกิล)

สรุปโดยรวมต่อสกิล: ตัวคูณดาเมจมาจากไหน / แยกอาวุธ / สถานะระหว่างท่า / บัพ / เชื่อมสกิลอื่น. วิธีอ่าน: [ENGINE.md](ENGINE.md)

### ออโต้ดีไวซ์ (AutoDevice) · uid 705
- ทรี: สกิลสไปรท์ · เลเวลสูงสุด: 50 · อาวุธที่ใช้ได้: MainMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ค่าเปอร์เซ็นต์ทั่วไป (`Percent`) `5 × Lv` → Lv1 5 · Lv5 25 · Lv10 50
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) `15 - Lv` → Lv1 14 · Lv5 10 · Lv10 5

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.Update` (TryGetBuf) — Update — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.Update` (TryGetBuf) — Update — Code


---

### เอ็กเพรสเอด (RushAid) · uid 706
- ทรี: สกิลสไปรท์ · เลเวลสูงสุด: 90 · อาวุธที่ใช้ได้: MainMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - (`MobLastDamageRate*` เข้าสูตรดาเมจที่มอนทำใส่ผู้เล่นใน `MobAttackBase.CalcLastDamage` — ค่านี้คือส่วนลดดาเมจที่ได้รับ; หน่วยและการรวมกับบัพอื่นยังไม่ยืนยัน — Inferred)
  - ตัวคูณดาเมจที่ได้รับจากมอน (หมวดบัพ) (`MobLastDamageRateBuf`) `10 × Lv` → Lv1 10 · Lv5 50 · Lv10 100 — เมื่อ resistCount ≥ 1
- พาสซีฟ/มาสเตอรี่: ลดดาเมจที่ได้รับ % (`CutDmgRate`) → Lv1 10 · Lv5 50 · Lv10 100 — Code
- พาสซีฟ/มาสเตอรี่: ค่าทั่วไป (`Value`) → Lv1 0 · Lv5 1 · Lv10 2 — Code
- ข้อความในเกม (คำอธิบาย): และลดความเสียหายที่ได้รับตามจำนวนครั้งที่กำหนด — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: `MobAttackBase.CalcLastDamage`, `PlayerActionManager.Damaged` — Inferred

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobAttackBase.CalcLastDamage` (TryGetBuf) — calculate last damage — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.Damaged` (TryGetBuf) — PlayerActionManager: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.get_MoveSpeed` (ContainsBuffer) — Move Speed of PlayerActionManager — Code


---

### เคาน์เตอร์ฟอร์ส (CounterForce) · uid 707
- ทรี: สกิลสไปรท์ · เลเวลสูงสุด: 90 · อาวุธที่ใช้ได้: MainMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `AutoMemberActionManager.Damaged` (TryGetBuf) — AutoMemberActionManager: on damaged — Code
- ถูกอ่านโดย CounterForceAttackAction (uid 735) ผ่าน `CounterForceAttackAction.OnEnd` (TryGetBuf) — On End — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `FamiliaActionManager.Damaged` (TryGetBuf) — FamiliaActionManager: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MercenaryActionManager.Damaged` (TryGetBuf) — MercenaryActionManager: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.Damaged` (TryGetBuf) — MobaPlayerActionManager: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.ReceiveDamaged` (TryGetBuf) — Receive Damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerBattleManager.StartCounterForceAttack` (GetSkillLv) — Start Counter Force Attack — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `OtherPlayer.OnActionMobAttack` (TryGetBuf) — On Action Mob Attack — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PetMemberActionManager.Damaged` (TryGetBuf) — PetMemberActionManager: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.Damaged` (TryGetBuf) — PlayerActionManager: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.StartCounterForceAttack` (GetSkillLv) — Start Counter Force Attack — Code


---

### ไมโครฮีล (ClineHeal) · uid 708
- ทรี: สกิลสไปรท์ · เลเวลสูงสุด: 170 · อาวุธที่ใช้ได้: MainMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### เอนฮานซ์ (Enhance) · uid 709
- ทรี: สกิลสไปรท์ · เลเวลสูงสุด: 170 · อาวุธที่ใช้ได้: MainMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ATK + (`AtkUp`) = `atkUp`
- MATK + (`MatkUp`) = `matkUp`
- ดาเมจสุดท้ายที่ทำ % (`LastDmgUpRate`) `Lv` → Lv1 1 · Lv5 5 · Lv10 10

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### แอสเทิลแลนซ์ (AstralLance) · uid 710
- ทรี: สกิลสไปรท์ · เลเวลสูงสุด: 170 · อาวุธที่ใช้ได้: MainMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย AstralLanceAttackAction (uid 734) ผ่าน `AstralLanceAttackAction.ActionStart` (TryGetBuf) — AstralLanceAttackAction: skill start — Code
- ถูกอ่านโดย AstralLanceAttackAction (uid 734) ผ่าน `AstralLanceAttackAction.OnEnd` (TryGetBuf) — On End — Code
- ถูกอ่านโดย เมจิกวัลแคน (uid 714) ผ่าน `MagicBalkanAction.ActionSkillEvent` (TryGetBuf) — Action Skill Event — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerBattleManager.OnSkillActionStart` (TryGetBuf) — On Skill Action Start — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerBattleManager.OnSkillActionStartSummonSkeleton` (TryGetBuf) — On Skill Action Start Summon Skeleton — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerBattleManager.StartAstralLanceAttack` (GetSkillLv) — Start Astral Lance Attack — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.OnSkillActionStart` (TryGetBuf) — On Skill Action Start — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.OnSkillActionStartSummonSkeleton` (TryGetBuf) — On Skill Action Start Summon Skeleton — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.StartAstralLanceAttack` (GetSkillLv) — Start Astral Lance Attack — Code


---

### เรเซอร์เรคชั่น (Resurrection) · uid 711
- ทรี: สกิลสไปรท์ · เลเวลสูงสุด: 250 · อาวุธที่ใช้ได้: MainMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### สเตบิไลซ์ (Stabilis) · uid 712
- ทรี: สกิลสไปรท์ · เลเวลสูงสุด: 250 · อาวุธที่ใช้ได้: MainMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `stableRecovery`
- อัตราคริ % (`CrtUpRate`) `4 × Lv` → Lv1 4 · Lv5 20 · Lv10 40
- ตัวนับ/stack (`Count`) `Lv` → Lv1 1 · Lv5 5 · Lv10 10
- อัตราคริ + (`CrtUp`) `Lv + 5` → Lv1 6 · Lv5 10 · Lv10 15

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerSecondaryStatus.GetCrtConstant` (TryGetBuf) — Get Crt Constant — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerSecondaryStatus.GetCrtRate` (TryGetBuf) — Get Crt Rate — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PetSkillActionBase.CalcStable` (TryGetBuf) — calculate stable — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PetStatus.get_Critical` (TryGetBuf) — Critical of PetStatus — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.CalcStable` (TryGetBuf) — Stability multiplier — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.GetCrtConstant` (TryGetBuf) — Get Crt Constant — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.GetCrtRate` (TryGetBuf) — Get Crt Rate — Code


---

### สไปรท์ชีลด์ (SpriteShield) · uid 713
- ทรี: สกิลสไปรท์ · เลเวลสูงสุด: 250 · อาวุธที่ใช้ได้: MainMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: โซลฮันเตอร์ / เดธรีปเปอร์ (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - (`MobLastDamageRate*` เข้าสูตรดาเมจที่มอนทำใส่ผู้เล่นใน `MobAttackBase.CalcLastDamage` — ค่านี้คือส่วนลดดาเมจที่ได้รับ; หน่วยและการรวมกับบัพอื่นยังไม่ยืนยัน — Inferred)
  - ตัวคูณดาเมจที่ได้รับจากมอน (หมวดซัพพอร์ต) (`MobLastDamageRateSupport`) = **50** คงที่ทุก Lv
- ข้อความในเกม (คำอธิบาย): ลดความเสียหายและโอกาสในการติด — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: `MobaPlayerActionManager.Damaged`, `MobaPlayerActionManager.ReceiveDamaged`, `MobaPlayerSecondaryStatus.get_AntiVirus`, `PlayerActionManager.Damaged` — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) `Lv × Lv` → Lv1 1 · Lv5 25 · Lv10 100
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล โซลฮันเตอร์ / เดธรีปเปอร์ (uid 1063): `SpriteShieldAction.CheckPayHp` (GetSkillLv) — SpriteShieldAction: can the HP cost be paid — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.Damaged` (TryGetBuf) — MobaPlayerActionManager: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.ReceiveDamaged` (TryGetBuf) — Receive Damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerSecondaryStatus.get_AntiVirus` (TryGetBuf) — Anti Virus of MobaPlayerSecondaryStatus — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.AddEventAbnormal` (ContainsBuffer) — Add Event Abnormal — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.Damaged` (TryGetBuf) — PlayerActionManager: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.CalcAntiVirus` (TryGetBuf) — calculate anti virus — Code


---

### เมจิกวัลแคน (MagicBalkan) · uid 714
- ทรี: สกิลสไปรท์ · เลเวลสูงสุด: 250 · อาวุธที่ใช้ได้: MainMagictool
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (never (IsExpDefFluctuate=false))

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, SetConstant) [= **0** คงที่ทุก Lv] หรือ [= **100** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)]
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`5 × Lv + 50 %` → Lv1 55% · Lv5 75% · Lv10 100%] หรือ [`System.Math.Max(0xffffffec × (damageCount + 1) ÷ 5 + 10 × Lv + 200, 10) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`(5 × damageCount + 10) × Lv + 50 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]
  - MinDamage (`MinDamage`, SetConstant) = **1** คงที่ทุก Lv

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล แอสเทิลแลนซ์ (uid 710): `MagicBalkanAction.ActionSkillEvent` (TryGetBuf) — Action Skill Event — Code


---

### อิกนิชั่น (Ignition) · uid 715
- ทรี: สกิลสไปรท์ · เลเวลสูงสุด: 50 · อาวุธที่ใช้ได้: MainMagictool
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **100** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `System.Math.Min(60 × Lv + status.EqAtk, 1200) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ความเสถียร (`StableRate`, SetRate) `100 × PlayerAttackBase.CalcStable(IgnitionAction.get_AttackType(), int(0.4 × status.Stable), SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- สถานะผิดปกติที่ติดเป้า:
  - ล่มสลาย โอกาส `5 × SkillManager.GetSkillTreeLv(PlayerStatusBase.get_SkillManager(), SkillTreeType.SpriteSkill, 0) + DEX(ที่ลงเอง) ÷ 10 + 2 × Lv + Lv ÷ 2` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### อาร์เดดราค (Aldedrak) · uid 716
- ทรี: สกิลสไปรท์ · เลเวลสูงสุด: 90 · อาวุธที่ใช้ได้: MainMagictool
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ DEX(ที่ลงเอง)/INT(ที่ลงเอง)
- **ดาเมจหลัก** — state ≠ 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **300** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `35 × Lv + (DEX(ที่ลงเอง) + INT(ที่ลงเอง)) ÷ 2 + 350 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- สถานะผิดปกติที่ติดเป้า:
  - หยุดนิ่ง โอกาส = **100** คงที่ทุก Lv

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### แฟกทิสอาร์ม (FacticeArme) · uid 717
- ทรี: สกิลสไปรท์ · เลเวลสูงสุด: 170 · อาวุธที่ใช้ได้: MainMagictool
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ AGIรวม/DEXรวม
- **ดาเมจหลัก** — type = 3
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `4.5 × Lv × Lv` → Lv1 4.5 · Lv5 112.5 · Lv10 450
  - ตัวคูณสกิล (`SkillRate`, AddRate) `75 × (AGIรวม + DEXรวม + 750) / 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ดาเมจหลัก** — type = 0 และ type ≠ 3
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `4.5 × Lv × Lv` → Lv1 4.5 · Lv5 112.5 · Lv10 450
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `1.5 × Lv × Lv` → Lv1 1.5 · Lv5 37.5 · Lv10 150
  - ตัวคูณสกิล (`SkillRate`, AddRate) `75 × (AGIรวม + DEXรวม + 750) / 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `25 × (AGIรวม + DEXรวม + 750) / 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ดาเมจหลัก** — type = 4 และ type ≠ 0 และ type ≠ 3
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `4.5 × Lv × Lv` → Lv1 4.5 · Lv5 112.5 · Lv10 450
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `1.5 × Lv × Lv` → Lv1 1.5 · Lv5 37.5 · Lv10 150
  - ตัวคูณสกิล (`SkillRate`, AddRate) `75 × (AGIรวม + DEXรวม + 750) / 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `25 × (AGIรวม + DEXรวม + 750) / 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ดาเมจหลัก** — type ≠ 0 และ type ≠ 3 และ type ≠ 4
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `6 × Lv × Lv` → Lv1 6 · Lv5 150 · Lv10 600
  - ตัวคูณสกิล (`SkillRate`, AddRate) `AGIรวม + DEXรวม + 750 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- Super Armor: ไม่สะดุด/ไม่ถูกขัดเมื่อโดนตี จนกว่าจะเรียก EndSuperArmor — Code · `ActionSkillEvent: IllusionarySceneBuf$$EndSuperArmor`
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล คาสุมิเซ็ตสึเก็คคะ / เท็นริวรันเซ:ซันยุ (uid 624): `FacticeArmeAction.ActionSkillEvent` (TryGetBuf) — Action Skill Event — Code


---

### สแลชรีปเปอร์ (SlashReaper) · uid 718
- ทรี: สกิลสไปรท์ · เลเวลสูงสุด: 250 · อาวุธที่ใช้ได้: MainMagictool
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (custom_check + class check)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- **ดาเมจหลัก** — state < constDamage.Length และ state < skillRate.Length และ state ≠ 2
  - ตัวคูณสกิล (`SkillRate`, AddRate) `skillRate[state] %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ดาเมจหลัก** — state = 2 และ state < skillRate.Length
  - ตัวคูณสกิล (`SkillRate`, AddRate) `skillRate[state] %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ดาเมจหลัก** — state < constDamage.Length และ state < skillRate.Length
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `constDamage[state]` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.GetSkillTargetType` (TryGetBuf) — Get Skill Target Type — Code


---

### สไปรท์อัพเกรด (EnhanceSprite) · uid 719
- ทรี: สกิลสไปรท์ · เลเวลสูงสุด: 300 · อาวุธที่ใช้ได้: MainMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### รีเทค (Retake) · uid 720
- ทรี: สกิลสไปรท์ · เลเวลสูงสุด: 300 · อาวุธที่ใช้ได้: MainMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.Damaged` (TryGetBuf) — PlayerActionManager: on damaged — Code


---

### คาตาลาโบมัส (Catarabomos) · uid 721
- ทรี: สกิลสไปรท์ · เลเวลสูงสุด: 300 · อาวุธที่ใช้ได้: MainMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### เลเบนส์กลานซ์ (LebenGlanz) · uid 722
- ทรี: สกิลสไปรท์ · เลเวลสูงสุด: 300 · อาวุธที่ใช้ได้: MainMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = `attackMpRecovery`

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---
