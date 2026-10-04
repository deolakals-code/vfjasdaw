# สกิลมีดสั้น (13 สกิล)

สรุปโดยรวมต่อสกิล: ตัวคูณดาเมจมาจากไหน / แยกอาวุธ / สถานะระหว่างท่า / บัพ / เชื่อมสกิลอื่น. วิธีอ่าน: [ENGINE.md](ENGINE.md)

### สไปก์ดาร์ต (SpikeDart) · uid 290
- ทรี: สกิลมีดสั้น · เลเวลสูงสุด: 20 · อาวุธที่ใช้ได้: มีด
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ DEX(ที่ลงเอง)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `Lv + 10` → Lv1 11 · Lv5 15 · Lv10 20
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `status.SubEqAtk ÷ 5` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [= **75%** คงที่ทุก Lv — เมื่อ Lv ≠ 0 (+เงื่อนไขอื่น)] หรือ [= **42%** คงที่ทุก Lv — เมื่อ Lv ≠ 0 (+เงื่อนไขอื่น)] หรือ [= **47%** คงที่ทุก Lv — เมื่อ Lv ≠ 0 (+เงื่อนไขอื่น)] หรือ [= **4700%** คงที่ทุก Lv — เมื่อ Lv ≠ 0 (+เงื่อนไขอื่น)] หรือ [= **65%** คงที่ทุก Lv — เมื่อ Lv = 0]
  - ตัวคูณสกิล (`SkillRate`, AddRate) `DEX(ที่ลงเอง) ÷ (20 - Lv) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, SetRate) `100 × PlayerAttackBase.CalcLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus(), SpikeDartAction.get_AttackType()) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ MobaMode = 0 (+เงื่อนไขอื่น)
  - ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, AddRate) `-(100 × MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90))) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ MobaMode = 0 (+เงื่อนไขอื่น)
- สถานะผิดปกติที่ติดเป้า:
  - ช้า โอกาส `5 × Lv + 50` → Lv1 55 · Lv5 75 · Lv10 100

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### พอยซั่นแดกเกอร์ (PoisonDagger) · uid 291
- ทรี: สกิลมีดสั้น · เลเวลสูงสุด: 20 · อาวุธที่ใช้ได้: มีด
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ INT(ที่ลงเอง)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `10 × Lv + 100` → Lv1 110 · Lv5 150 · Lv10 200
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `status.SubAtk` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `int(2.5 × Lv) + 50 %` → Lv1 52% · Lv5 62% · Lv10 75%
  - ตัวคูณสกิล (`SkillRate`, AddRate) `INT(ที่ลงเอง) ÷ (11 - Lv) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, SetRate) `100 × PlayerAttackBase.CalcLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus(), PoisonDaggerAction.get_AttackType()) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ MobaMode = 0 (+เงื่อนไขอื่น)
  - ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, AddRate) `-(100 × MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90))) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ MobaMode = 0 (+เงื่อนไขอื่น)
- สถานะผิดปกติที่ติดเป้า:
  - พิษ โอกาส `int(2.5 × Lv) + 75` → Lv1 77 · Lv5 87 · Lv10 100

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### แกตติ้งไนฟ์ (GatlingKnife) · uid 292
- ทรี: สกิลมีดสั้น · เลเวลสูงสุด: 50 · อาวุธที่ใช้ได้: มีด
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ AGI(ที่ลงเอง)/DEX(ที่ลงเอง)/STR(ที่ลงเอง)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `2 × Lv + 20` → Lv1 22 · Lv5 30 · Lv10 40
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `status.SubEqAtk` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `10 × int(0.75 × Lv - 0.75) + 40 %` → Lv1 40% · Lv5 70% · Lv10 100%
  - ตัวคูณสกิล (`SkillRate`, AddRate) `(AGI(ที่ลงเอง) + STR(ที่ลงเอง) + DEX(ที่ลงเอง)) ÷ 30 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, SetRate) `100 × PlayerAttackBase.CalcLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus(), GatlingKnifeAction.get_AttackType()) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ MobaMode = 0 (+เงื่อนไขอื่น)
  - ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, AddRate) `-(100 × MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90))) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ MobaMode = 0 (+เงื่อนไขอื่น)
- **ดาเมจหลัก** — damageCount ≥ 1 และ damageCount < 1
  - ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, AddRate) `-(100 × MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90))) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ MobaMode = 0 (+เงื่อนไขอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ดับเบิ้ลสแทบ (DoubleThrow) · uid 293
- ทรี: สกิลมีดสั้น · เลเวลสูงสุด: 50 · อาวุธที่ใช้ได้: มีด

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: โอกาสทำงาน % (`Trigger`) = `?addv` — Code

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `AvoidActionManager.DoubleThrowAvoid` (ContainsBuffer) — Double Throw Avoid — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `AvoidActionManager.DoubleThrowAvoid` (GetSkillLv) — Double Throw Avoid — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.OnSkillActionDamaged` (TryGetBuf) — On Skill Action Damaged — Code


---

### อเมซซิ่งโธร์ว (ThreateningThorwArts) · uid 294
- ทรี: สกิลมีดสั้น · เลเวลสูงสุด: 110 · อาวุธที่ใช้ได้: มีด

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: โอกาสทำงาน % (`Trigger`) = `id ≠ 26 ? 3 × Lv : 1` — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### โธร์วไนฟ์ (Throwing) · uid 295
- ทรี: สกิลมีดสั้น · เลเวลสูงสุด: 5 · อาวุธที่ใช้ได้: มีด
- ประเภทดาเมจ: กายภาพ; เลเวล 10 เป็นธรรมดา · Proration: dynamic (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ตัวคูณสกิล (`SkillRate`, AddRate) `4 × Lv + 10 %` → Lv1 14% · Lv5 30% · Lv10 50%
  - ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, SetRate) `100 × PlayerAttackBase.CalcLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus(), ThrowingAction.get_AttackType()) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ MobaMode = 0 (+เงื่อนไขอื่น)
  - ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, AddRate) `-(100 × MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90))) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ MobaMode = 0 (+เงื่อนไขอื่น)
  - ดาเมจคงที่สุดท้าย (`LastConstantDamage`, AddConstant) `status.SubEqAtk` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### แซคเคิลอาร์ม (SecondArm) · uid 296
- ทรี: สกิลมีดสั้น · เลเวลสูงสุด: 5 · อาวุธที่ใช้ได้: มีด

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: โอกาสทำงาน % (`Trigger`) → Lv1 5 · Lv5 25 · Lv10 50 — Code
- พาสซีฟ/มาสเตอรี่: ตัวคูณสกิล (`SkillRate`) = **25** คงที่ทุก Lv — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### อินเทนซีฟไนฟ์ (IntenseKnife) · uid 297
- ทรี: สกิลมีดสั้น · เลเวลสูงสุด: 20 · อาวุธที่ใช้ได้: มีด

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: โอกาสทำงาน % (`Trigger`) → Lv1 5 · Lv5 25 · Lv10 50 — Code
- พาสซีฟ/มาสเตอรี่: ตัวคูณสกิล (`SkillRate`) = **25** คงที่ทุก Lv — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### เมลเบรคเกอร์ (MailBreaker) · uid 298
- ทรี: สกิลมีดสั้น · เลเวลสูงสุด: 110 · อาวุธที่ใช้ได้: มีด

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: โอกาสทำงาน % (`Trigger`) → Lv1 14 · Lv5 30 · Lv10 50 — Code
- พาสซีฟ/มาสเตอรี่: ค่าเปอร์เซ็นต์ (`Percent`) → Lv1 1 · Lv5 5 · Lv10 10 — Code

#### 4) บัพที่ได้จากสกิลนี้
- อัตราคริ + (`CrtUp`) = `critical`
- MP ฟื้นต่อการโจมตี % (`AttackMprecoveryUpRate`) = **100** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ไนฟ์คอมแบท (KnifeCombat) · uid 299
- ทรี: สกิลมีดสั้น · เลเวลสูงสุด: 50 · อาวุธที่ใช้ได้: มีด
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มีด + มือรองที่ไม่ใช่ มีด] = **100%** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มีด + มือรอง มีด] `100 + EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, SetRate) `100 × PlayerAttackBase.CalcLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus(), KnifeCombatAction.get_AttackType()) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ MobaMode = 0 (+เงื่อนไขอื่น)
  - ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, AddRate) `-(100 × MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90))) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ MobaMode = 0 (+เงื่อนไขอื่น)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ตัวคูณตีปกติ % (`NormalAttackRate`) = `normalAtkRate`
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `100 - avoidStackRegist`
- MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = `atkMpRecovery`
- อัตราคริ + (`CrtUp`) = `crtUp`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `AvoidActionManager.AvoidMove` (TryGetBuf) — Avoid Move — Code
- ถูกอ่านโดย ฟินเชอร์ไนฟ์ / ไนฟ์สไตล์ (uid 300) ผ่าน `FlinchKnifeAction.ActionStart` (GetSkillLv) — FlinchKnifeAction: skill start — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerBattleManager.OnSkillActionEnd` (ContainsBuffer) — On Skill Action End — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerSecondaryStatus.GetCrtConstant` (TryGetBuf) — Get Crt Constant — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `NormalAttackAction.OnInitialize` (ContainsBuffer) — NormalAttackAction: initial values — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.RemoveAfterSkillBuf` (ContainsBuffer) — Remove After Skill Buf — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.CheckZeroActionDelay` (ContainsBuffer) — check zero action delay — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.GetCrtConstant` (TryGetBuf) — Get Crt Constant — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIFishingPanelManager.StartFishingResponse` (TryGetBuf) — Code


---

### ฟินเชอร์ไนฟ์ / ไนฟ์สไตล์ (FlinchKnife) · uid 300
- ทรี: สกิลมีดสั้น · เลเวลสูงสุด: 110 · อาวุธที่ใช้ได้: มีด
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

**ชื่อ/รูปแบบของสกิล (จากข้อความในเกม):** [N] ฟินเชอร์ไนฟ์ · [F] ไนฟ์สไตล์

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `30 × Lv` → Lv1 30 · Lv5 150 · Lv10 300
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มีด + มือรองที่ไม่ใช่ มีด] `20 × Lv + 200 %` → Lv1 220% · Lv5 300% · Lv10 400%
    - ตัวปรับ `skillRate`: `2 × skillRate` เมื่อ (+เงื่อนไขอื่น) หรือ isFightingKnife ≠ 0 (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มีด + มือรอง มีด] `((Lv * 20) + 200) + ((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).F…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `skillRate`: `2 × skillRate` เมื่อ (+เงื่อนไขอื่น) หรือ isFightingKnife ≠ 0 (+เงื่อนไขอื่น)
- สถานะผิดปกติที่ติดเป้า:
  - ผงะ โอกาส `20 × Lv < 100 ? 20 × Lv : 100` → Lv1 20 · Lv5 100 · Lv10 100
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: ไนฟ์คอมแบท (Skill)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ตัวคูณตีปกติ % (`NormalAttackRate`) = `normalAtkRate`
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `100 - avoidStackRegist`
- MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = `atkMpRecovery`
- อัตราคริ + (`CrtUp`) = `crtUp`

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล ไนฟ์คอมแบท (uid 299): `FlinchKnifeAction.ActionStart` (GetSkillLv) — FlinchKnifeAction: skill start — Code


---

### เครซี่แดกเกอร์ (CrazyDagger) · uid 301
- ทรี: สกิลมีดสั้น · เลเวลสูงสุด: 225 · อาวุธที่ใช้ได้: มีด
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_and_flag)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **200** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น) หรือ MobaMode ≠ 0 (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มีด + มือรองที่ไม่ใช่ มีด] `((((Lv << 4) - Lv) + 50)) * System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น) หรือ MobaMode ≠ 0 (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มีด + มือรอง มีด] `((((GetSubWeaponType.item(actarAction).Function ÷ 10) lt 50 ? (GetSubWeaponType.item(actarAction).Function ÷ 10) : 50) + (((Lv << 4) - Lv) + 50))) * System.Linq.Enumer…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น) หรือ MobaMode ≠ 0 (+เงื่อนไขอื่น)
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น) หรือ MobaMode ≠ 0 (+เงื่อนไขอื่น)
  - Proration (`ExpRate`, SetRate) `(proration ที่เก็บไว้ตอนร่าย[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น) หรือ MobaMode ≠ 0 (+เงื่อนไขอื่น)
  - ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, SetRate) `100 × PlayerAttackBase.CalcLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus(), CrazyDaggerAction.get_AttackType()) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ MobaMode = 0 (+เงื่อนไขอื่น)
  - ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, AddRate) `-(100 × MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90))) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ MobaMode = 0 (+เงื่อนไขอื่น)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย CrazyDaggerPursuitAction (uid 319) ผ่าน `CrazyDaggerPursuitAction.OnInitialize` (TryGetBuf) — CrazyDaggerPursuitAction: initial values — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `NormalAttackAction.ActionPreparation` (TryGetBuf) — NormalAttackAction: preparation — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `NormalAttackAction.Damaged` (TryGetBuf) — NormalAttackAction: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.ActionStart` (TryGetBuf) — PlayerAttackBase: skill start — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `SkillBufferManager.UpdateIndividualBuf` (TryGetBuf) — Update Individual Buf — Code


---

### วีลไบต์ (WheelBite) · uid 302
- ทรี: สกิลมีดสั้น · เลเวลสูงสุด: 225 · อาวุธที่ใช้ได้: มีด
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **400** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `25 × Lv + 750 %` → Lv1 775% · Lv5 875% · Lv10 1000%
- **คำนวณใหม่เมื่อเป้าหลบ**
  - ตัวคูณสกิล (`SkillRate`, AddRate) `(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function << 1) lt 1000 ? (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - หักป้องกันเป้า (`Def`, SetConstant) = **0** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: ไนฟ์คอมแบท (Skill)

#### 3) ระหว่างใช้สกิล
- คงกระพันตามเวลา PlayerStatusBase.get_AbnormalStatusManager() วินาที (ถอดเมื่อจบท่า/ครบเวลา) — Code · `DamageAvoid: AbnormalStateManager$$AddTimeInvincibility`
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - (`MobLastDamageRate*` เข้าสูตรดาเมจที่มอนทำใส่ผู้เล่นใน `MobAttackBase.CalcLastDamage` — ค่านี้คือส่วนลดดาเมจที่ได้รับ; หน่วยและการรวมกับบัพอื่นยังไม่ยืนยัน — Inferred)
  - MobLastDamageRateUnique (`MobLastDamageRateUnique`) `10 × Lv` → Lv1 10 · Lv5 50 · Lv10 100
- ข้อความในเกม (คำอธิบาย): เทคนิคการใช้ดาบสั้นที่ผสานการหลบหลีกและการลอบจู่โจม — Text
- ข้อความในเกม (คำอธิบาย): ลดความเสียหายที่ได้รับขณะเคลื่อนที่พร้อมพุ่งเข้าประชิด — Text
- ข้อความในเกม (Lv9): เมื่อลดความเสียหายสำเร็จจะไม่ติดคงกระพัน — Text

#### 4) บัพที่ได้จากสกิลนี้
- ตัวคูณตีปกติ % (`NormalAttackRate`) = `normalAtkRate`
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `100 - avoidStackRegist`
- MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = `atkMpRecovery`
- อัตราคริ + (`CrtUp`) = `crtUp`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobAttackBase.CalcLastDamage` (TryGetBuf) — calculate last damage — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobAttackBase.InvalidDamage` (TryGetBuf) — Invalid Damage — Code


---
