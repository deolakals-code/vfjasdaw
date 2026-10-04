# สกิลมือเปล่า (12 สกิล)

สรุปโดยรวมต่อสกิล: ตัวคูณดาเมจมาจากไหน / แยกอาวุธ / สถานะระหว่างท่า / บัพ / เชื่อมสกิลอื่น. วิธีอ่าน: [ENGINE.md](ENGINE.md)

### ความชำนาญการสู้มือเปล่า (BarehandMastery) · uid 1089
- ทรี: สกิลมือเปล่า · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: มือเปล่า, SubWeaponExclusion

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ATK อาวุธ % (`EqAtkRate`) → Lv1 10 · Lv5 50 · Lv10 100 — Code

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `Max`
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ฟื้นคืนชีพ (uid 1099) ผ่าน `Revival.CheckRevival` (TryGetBuf) — check revival — Code
- ถูกอ่านโดย ฟื้นคืนชีพ (uid 1099) ผ่าน `Revival.OnActionMobDamage` (TryGetBuf) — On Action Mob Damage — Code


---

### ชาร์จพลังชี่กง (CollectQigong) · uid 1090
- ทรี: สกิลมือเปล่า · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: มือเปล่า, SubWeaponExclusion

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ATK + (`AtkUp`) `Count × Lv × Lv × Lv ÷ 100` → Lv1 0 · Lv5 1 · Lv10 10
- ความเสถียร (`Stable`) `5 × Lv` → Lv1 5 · Lv5 25 · Lv10 50 — เมื่อ Count ≥ 1
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.get_AtkMpRecovery` (TryGetBuf) — Atk Mp Recovery of PlayerSecondaryStatus — Code
- ถูกอ่านโดย ฟื้นคืนชีพ (uid 1099) ผ่าน `Revival.OnActionMobDamage` (TryGetBuf) — On Action Mob Damage — Code


---

### ซีซ่าแสลชเชอร์ (FuriousEfforts) · uid 1091
- ทรี: สกิลมือเปล่า · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: มือเปล่า, SubWeaponExclusion

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ตัวคูณตีปกติ % (`NormalAttackRate`) = `normalAttackDamageUpRate × Count`
- ดาเมจคงที่ตีปกติ (`NormalAttackConstantDamage`) `5 × Count × Lv` → Lv1 5 · Lv5 25 · Lv10 50
- ความเร็วโจมตี + (`Aspd`) = **-2850** คงที่ทุก Lv
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv
- อัตราคริ + (`CrtUp`) `Count × Lv` → Lv1 1 · Lv5 5 · Lv10 10

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `BCollaboBossActionManager.Damaged` (ContainsBuffer) — BCollaboBossActionManager: on damaged — Code
- ถูกอ่านโดย สะเทือนโลกา (uid 1098) ผ่าน `EarthShatteringAction.ActionSkillEvent` (TryGetBuf) — Action Skill Event — Code
- ถูกอ่านโดย สะเทือนโลกา (uid 1098) ผ่าน `EarthShatteringAction.ActionStart` (ContainsBuffer) — EarthShatteringAction: skill start — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `EarthShatteringBuf.GetBufferEffectAppendParameter` (ContainsBuffer) — Get Buffer Effect Append Parameter — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `EnemyMobActionManagerBase.Damaged` (ContainsBuffer) — EnemyMobActionManagerBase: on damaged — Code
- ถูกอ่านโดย ซีซ่าแสลชเชอร์อัลติมา (uid 1095) ผ่าน `FuriousEffortsExtreme.Damaged` (ContainsBuffer) — FuriousEffortsExtreme: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `GuildRaidBossMobActionManager.Damaged` (ContainsBuffer) — GuildRaidBossMobActionManager: on damaged — Code
- ถูกอ่านโดย ฟื้นคืนชีพ (uid 1099) ผ่าน `Revival.OnActionMobDamage` (TryGetBuf) — On Action Mob Damage — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `ScoreAttackBossActionManager.Damaged` (ContainsBuffer) — ScoreAttackBossActionManager: on damaged — Code
- ถูกอ่านโดย ซ่อนเร้นตัวตน (uid 1100) ผ่าน `SelfDisclosure.UpdateCristaBonus` (ContainsBuffer) — Update Crista Bonus — Code


---

### วายุโหมคลื่นกระหน่ำ (StormAndUrge) · uid 1092
- ทรี: สกิลมือเปล่า · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: มือเปล่า, SubWeaponExclusion

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: วายุโหมคลื่นกระหน่ำอัลติมา (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ความแม่น + (`HitUp`) `Count × Lv × Lv` → Lv1 1 · Lv5 25 · Lv10 100
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `moveSpeed`
- ความเร็วโจมตี + (`Aspd`) `100 × Count × Lv` → Lv1 100 · Lv5 500 · Lv10 1000
- MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) `int(0.2 × Count × Lv)` → Lv1 0 · Lv5 1 · Lv10 2
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- สกิลนี้ใส่บัพของสกิล วายุโหมคลื่นกระหน่ำอัลติมา (uid 1096) — Code
- ได้รับการเสริมจากสกิล วายุโหมคลื่นกระหน่ำอัลติมา (uid 1096): `StormAndUrgeAction.ActionSkillEvent` (GetSkillLv) — Action Skill Event — Code
- ถูกอ่านโดย สะเทือนโลกา (uid 1098) ผ่าน `EarthShatteringAction.ActionSkillEvent` (TryGetBuf) — Action Skill Event — Code
- ถูกอ่านโดย สะเทือนโลกา (uid 1098) ผ่าน `EarthShatteringAction.ActionStart` (ContainsBuffer) — EarthShatteringAction: skill start — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `EarthShatteringBuf.GetBufferEffectAppendParameter` (ContainsBuffer) — Get Buffer Effect Append Parameter — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.get_MoveSpeed` (ContainsBuffer) — Move Speed of MobaPlayerActionManager — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.get_MoveSpeed` (ContainsBuffer) — Move Speed of PlayerActionManager — Code
- ถูกอ่านโดย ฟื้นคืนชีพ (uid 1099) ผ่าน `Revival.OnActionMobDamage` (TryGetBuf) — On Action Mob Damage — Code
- ถูกอ่านโดย ซ่อนเร้นตัวตน (uid 1100) ผ่าน `SelfDisclosure.UpdateCristaBonus` (ContainsBuffer) — Update Crista Bonus — Code


---

### ชี่กงฟื้นฟู (HealQigong) · uid 1093
- ทรี: สกิลมือเปล่า · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: มือเปล่า, SubWeaponExclusion

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - (`MobLastDamageRate*` เข้าสูตรดาเมจที่มอนทำใส่ผู้เล่นใน `MobAttackBase.CalcLastDamage` — ค่านี้คือส่วนลดดาเมจที่ได้รับ; หน่วยและการรวมกับบัพอื่นยังไม่ยืนยัน — Inferred)
  - MobLastDamageRateUnique (`MobLastDamageRateUnique`) `int((0.5 × Lv + 4.5) × Count)` → Lv1 5 · Lv5 7 · Lv10 9
- ข้อความในเกม (คำอธิบาย): เมื่อถูกโจมตีจะใช้ชี่กงเพื่อลดความเสียหายให้เบาลง — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ค่าเปอร์เซ็นต์ทั่วไป (`Percent`) = `percent`
- ATK % (`AtkUpRate`) `int(2.5 × Lv) - 100` → Lv1 -98 · Lv5 -88 · Lv10 -75
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย สะเทือนโลกา (uid 1098) ผ่าน `EarthShatteringAction.ActionSkillEvent` (ContainsBuffer) — Action Skill Event — Code
- ถูกอ่านโดย สะเทือนโลกา (uid 1098) ผ่าน `EarthShatteringAction.ActionStart` (ContainsBuffer) — EarthShatteringAction: skill start — Code
- ถูกอ่านโดย ระเบิดแสง (uid 586) ผ่าน `FlashGrenadeAction.ActionSkillEvent` (ContainsBuffer) — Action Skill Event — Code
- ถูกอ่านโดย ระเบิดเยือกแข็ง (uid 585) ผ่าน `FreezeGrenadeAction.ActionSkillEvent` (ContainsBuffer) — Action Skill Event — Code
- ถูกอ่านโดย ฟื้นคืนชีพ (uid 1099) ผ่าน `Revival.CheckRevival` (ContainsBuffer) — check revival — Code
- ถูกอ่านโดย ฟื้นคืนชีพ (uid 1099) ผ่าน `Revival.OnActionMobDamage` (GetSkillLv) — On Action Mob Damage — Code
- ถูกอ่านโดย ซ่อนเร้นตัวตน (uid 1100) ผ่าน `SelfDisclosure.UpdateCristaBonus` (ContainsBuffer) — Update Crista Bonus — Code


---

### ชาร์จพลังชี่กงอัลติมา (CollectQigongExtreme) · uid 1094
- ทรี: สกิลมือเปล่า · เลเวลสูงสุด: 100 · อาวุธที่ใช้ได้: มือเปล่า, SubWeaponExclusion

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ค่าเปอร์เซ็นต์ (`Percent`) → Lv1 1 · Lv5 5 · Lv10 10 — Code
- พาสซีฟ/มาสเตอรี่: ค่าทั่วไป (`Value`) → Lv1 0 · Lv5 2 · Lv10 5 — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ซีซ่าแสลชเชอร์อัลติมา (FuriousEffortsExtreme) · uid 1095
- ทรี: สกิลมือเปล่า · เลเวลสูงสุด: 100 · อาวุธที่ใช้ได้: มือเปล่า, SubWeaponExclusion

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ตัวคูณสกิล (`SkillRate`) → Lv1 2 · Lv5 10 · Lv10 20 — Code

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `lastDamageRate`

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล ซีซ่าแสลชเชอร์ (uid 1091): `FuriousEffortsExtreme.Damaged` (ContainsBuffer) — FuriousEffortsExtreme: on damaged — Code


---

### วายุโหมคลื่นกระหน่ำอัลติมา (StormAndUrgeExtreme) · uid 1096
- ทรี: สกิลมือเปล่า · เลเวลสูงสุด: 100 · อาวุธที่ใช้ได้: มือเปล่า, SubWeaponExclusion

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 4) บัพที่ได้จากสกิลนี้
- ค่าเปอร์เซ็นต์ทั่วไป (`Percent`) = `percent`
- เจาะกายภาพ (`PowerResistBreaker`) = `powerResistBreaker`
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `avoidStackHeal`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.CalcCostMp` (ContainsBuffer) — Skill MP cost — Code
- ถูกอ่านโดย วายุโหมคลื่นกระหน่ำ (uid 1092) ผ่าน `StormAndUrgeAction.ActionSkillEvent` (GetSkillLv) — Action Skill Event — Code


---

### การปะทะของจิตวิญญาณ (CollisionOfFightingSpirit) · uid 1097
- ทรี: สกิลมือเปล่า · เลเวลสูงสุด: 100 · อาวุธที่ใช้ได้: มือเปล่า, SubWeaponExclusion

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ดาเมจสุดท้าย % (`LastDmgRate`) → Lv1 1 · Lv5 5 · Lv10 10 — Code
- พาสซีฟ/มาสเตอรี่: ค่าเปอร์เซ็นต์ (`Percent`) → Lv1 2 · Lv5 12 · Lv10 25 — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### สะเทือนโลกา (EarthShattering) · uid 1098
- ทรี: สกิลมือเปล่า · เลเวลสูงสุด: 250 · อาวุธที่ใช้ได้: มือเปล่า, SubWeaponExclusion

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: ความชำนาญการสู้มือเปล่า (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ค่าเปอร์เซ็นต์ทั่วไป (`Percent`) = `element`
- เจาะกายภาพ (`PowerResistBreaker`) = `powerResist`
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `barrier`
- ความเสถียร (`Stable`) = `stable`
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `Value`

#### 5) เชื่อมกับสกิลอื่น
- สกิลนี้ใส่บัพของสกิล ความชำนาญการสู้มือเปล่า (uid 1089) — Code
- ได้รับการเสริมจากสกิล ซีซ่าแสลชเชอร์ (uid 1091): `EarthShatteringAction.ActionSkillEvent` (TryGetBuf) — Action Skill Event — Code
- ได้รับการเสริมจากสกิล ซีซ่าแสลชเชอร์ (uid 1091): `EarthShatteringAction.ActionStart` (ContainsBuffer) — EarthShatteringAction: skill start — Code
- ได้รับการเสริมจากสกิล วายุโหมคลื่นกระหน่ำ (uid 1092): `EarthShatteringAction.ActionSkillEvent` (TryGetBuf) — Action Skill Event — Code
- ได้รับการเสริมจากสกิล วายุโหมคลื่นกระหน่ำ (uid 1092): `EarthShatteringAction.ActionStart` (ContainsBuffer) — EarthShatteringAction: skill start — Code
- ได้รับการเสริมจากสกิล ชี่กงฟื้นฟู (uid 1093): `EarthShatteringAction.ActionSkillEvent` (ContainsBuffer) — Action Skill Event — Code
- ได้รับการเสริมจากสกิล ชี่กงฟื้นฟู (uid 1093): `EarthShatteringAction.ActionStart` (ContainsBuffer) — EarthShatteringAction: skill start — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `EquipMagicBarrierBuf.CheckTakeOver` (TryGetBuf) — check take over — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `EquipMagicBarrierBuf.GetBarrierValue` (TryGetBuf) — Get Barrier Value — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `EquipPhysicalBarrierBuf.CheckTakeOver` (TryGetBuf) — check take over — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `EquipPhysicalBarrierBuf.GetBarrierValue` (TryGetBuf) — Get Barrier Value — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MagicBarrier.Calc` (TryGetBuf) — calculate  — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `NormalAttackAction.ActionPreparation` (ContainsBuffer) — NormalAttackAction: preparation — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PhysicalBarrier.Calc` (TryGetBuf) — calculate  — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `ReceiveSupportResult.OnActionPlayerSupport` (ContainsBuffer) — On Action Player Support — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `ReceiveSupportResult.OnActionPlayerSupport` (GetSkillLv) — On Action Player Support — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `SkillBufferManager.Update` (TryGetBuf) — Update — Code


---

### ฟื้นคืนชีพ (Revival) · uid 1099
- ทรี: สกิลมือเปล่า · เลเวลสูงสุด: 250 · อาวุธที่ใช้ได้: มือเปล่า, SubWeaponExclusion

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ค่าทั่วไป (`Value`) → Lv1 0 · Lv5 0 · Lv10 1 — Code
- พาสซีฟ/มาสเตอรี่: ค่าเปอร์เซ็นต์ (`Percent`) → Lv1 1 · Lv5 25 · Lv10 100 — Code

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล ความชำนาญการสู้มือเปล่า (uid 1089): `Revival.CheckRevival` (TryGetBuf) — check revival — Code
- ได้รับการเสริมจากสกิล ความชำนาญการสู้มือเปล่า (uid 1089): `Revival.OnActionMobDamage` (TryGetBuf) — On Action Mob Damage — Code
- ได้รับการเสริมจากสกิล ชาร์จพลังชี่กง (uid 1090): `Revival.OnActionMobDamage` (TryGetBuf) — On Action Mob Damage — Code
- ได้รับการเสริมจากสกิล ซีซ่าแสลชเชอร์ (uid 1091): `Revival.OnActionMobDamage` (TryGetBuf) — On Action Mob Damage — Code
- ได้รับการเสริมจากสกิล วายุโหมคลื่นกระหน่ำ (uid 1092): `Revival.OnActionMobDamage` (TryGetBuf) — On Action Mob Damage — Code
- ได้รับการเสริมจากสกิล ชี่กงฟื้นฟู (uid 1093): `Revival.CheckRevival` (ContainsBuffer) — check revival — Code
- ได้รับการเสริมจากสกิล ชี่กงฟื้นฟู (uid 1093): `Revival.OnActionMobDamage` (GetSkillLv) — On Action Mob Damage — Code


---

### ซ่อนเร้นตัวตน (SelfDisclosure) · uid 1100
- ทรี: สกิลมือเปล่า · เลเวลสูงสุด: 250 · อาวุธที่ใช้ได้: มือเปล่า, SubWeaponExclusion

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ค่าทั่วไป (`Value`) → Lv1 1200 · Lv5 2000 · Lv10 3000 — Code
- พาสซีฟ/มาสเตอรี่: ค่าเปอร์เซ็นต์ (`Percent`) → Lv1 0 · Lv5 2 · Lv10 5 — Code
- พาสซีฟ/มาสเตอรี่: หลบ (`Avoid`) → Lv1 10 · Lv5 50 · Lv10 100 — Code
- พาสซีฟ/มาสเตอรี่: พลังการ์ด (`GuardPower`) → Lv1 500 · Lv5 2500 · Lv10 5000 — Code
- พาสซีฟ/มาสเตอรี่: อัตราการ์ด (`Guard`) → Lv1 7 · Lv5 15 · Lv10 25 — Code

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล ซีซ่าแสลชเชอร์ (uid 1091): `SelfDisclosure.UpdateCristaBonus` (ContainsBuffer) — Update Crista Bonus — Code
- ได้รับการเสริมจากสกิล วายุโหมคลื่นกระหน่ำ (uid 1092): `SelfDisclosure.UpdateCristaBonus` (ContainsBuffer) — Update Crista Bonus — Code
- ได้รับการเสริมจากสกิล ชี่กงฟื้นฟู (uid 1093): `SelfDisclosure.UpdateCristaBonus` (ContainsBuffer) — Update Crista Bonus — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIExSkillManager.ExSkillList` (GetSkillLv) — Code


---
