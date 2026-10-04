# สกิลครัชเชอร์ (`CrusherSkill`) — คำอธิบายทีละสกิล (ภาษาไทย)

สร้างอัตโนมัติด้วย `scripts/render_explained_th.py` จาก `skill_reference.json` (ข้อมูลโค้ด client ชุดล่าสุด) ไม่มีข้อความเขียนมือ แก้ไฟล์นี้ตรง ๆ จะถูกเขียนทับ ตัวเลขทั้งหมดคำนวณจากโค้ด (Code) ความหมายของชื่อ field/บทบาทแปลจากชื่อในโค้ด (Inferred) ยังไม่ได้เทียบกับตัวเลขในเกม ข้อมูลดิบทุกเส้นทางอยู่ใน `../details/CrusherSkill.md`

---

<!-- calc:preface -->
> **วิธีอ่านหัวข้อ "การคำนวณแบบตัวเลข"** (สร้างอัตโนมัติด้วย `scripts/render_calc_th.py` จาก `skill_reference.json` แก้มือจะถูกเขียนทับ)
> ดาเมจต่อฮิตเดินตามขั้น `SkillCalcTemplate/CalcStep` 0→40 ตามลำดับ (Code: `SkillCalcTemplate.GetDamage`) ขั้น `+` บวกเข้าดาเมจ ขั้น `×` คูณแล้วปัดเศษทิ้ง (int) ทันทีทุกขั้น
> ลำดับหลัก: ดาเมจฐาน(7) + คงที่สกิล(8) + คงที่บัพ(9) − ป้องกันเป้า(10) + ตีแรก(11) → ×คริ(13) → ×ธาตุ(15) → ×ตัวคูณสกิล(18) → ×ตีแรก(19) → ×เสถียร(21) → +คงที่ออโต้(22) → ×Proration(23) → ×ประเภท(24) → ×ดาเมจสุดท้าย(25) → … → เพดาน/ขั้นต่ำ(35–37)
> "ฮิต N" = template ดาเมจแต่ละก้อน (ทอยคริแยกกัน) แยกตามเมธอดและตัวแปรฮิตในโค้ด (`type`, `isFirst`, `attackCount` …) ชื่อฮิต/ส่วนมาจากชื่อในโค้ด (Inferred) ตัวเลขคำนวณจากโค้ด (Code) โดยตั้งเจม/บัพเสริม = 0
> ค่าหลายก้อนในขั้นเดียวกันแบบ "บวกเข้าช่อง" จะบวกกันก่อนคูณ ส่วน "ตั้งค่าทับ" แทนที่ค่าเดิม ค่าที่ขึ้นกับสเตตัสแสดงเป็นตัวอย่างที่ 100 / 255 (และ Lv สกิลอื่น 1 / 10) ใช้สูตรที่แนบไว้คำนวณค่าอื่นเอง
<!-- calc:preface-end -->

### กำปั้นผดุงคุณธรรม (ForefistPunch) · uid 1153

<img src="../../icons/sk_1153.png" width="40" alt="icon">

- ทรี: สกิลครัชเชอร์ (ขั้น 1) · เลเวลสูงสุด: 50 · อาวุธ: MainKnuckle · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `ForefistPunchAction` · สถานะการแกะ: แกะครบจากโค้ด

> หมัดตรงอันเฉียบคม
> เป้าหมายจะโดนโจมตีคริติคอล
> ระหว่างใช้ความเสียหายที่ได้รับจะลดลง 1 ครั้ง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `ForefistPunchBuf`: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = 25

<!-- calc:begin uid=1153 -->
#### การคำนวณแบบตัวเลข — ForefistPunch (uid 1153)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **200** → 200, 200, 200, 200, 200, 200, 200, 200, 200, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(200 + 20×Lv)%** → 220%, 240%, 260%, 280%, 300%, 320%, 340%, 360%, 380%, 400% (Lv1…10)
<!-- calc:end -->

### วิธีการหายใจ (BreathingMethod) · uid 1154

<img src="../../icons/sk_1154.png" width="40" alt="icon">

- ทรี: สกิลครัชเชอร์ (ขั้น 1) · เลเวลสูงสุด: 50 · อาวุธ: สนับมือ · ธง: StarGem
- คลาสในโค้ด: `BreathingMethodAction` · สถานะการแกะ: แกะครบจากโค้ด

> วิธีจัดเตรียมลมหายใจอย่างรวดเร็ว
> ระหว่างใช้งาน HP ของตัวเองจะฟื้นฟูทันที
> ตอนใช้สกิลถัดไป HP ก็ยังฟื้นฟูอยู่
> พลังการฟื้นฟูของวิธีการหายใจจะลดต่ำลง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- MP ที่ใช้ [มีเจมคาร์ท 1037]: `mp - 100` — โดยที่ `mp` = `mp - 100` [มีเจมคาร์ท 1037]
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- ตัวอ่านสกิลนี้ `GazerShootAction.ActionHit` — GazerShootAction.ActionHit: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new BreathingMethodBuf, Id` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND longBonus ne 0 AND SkillManager.GetSkillLv(PlayerStatus… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GeoImpactAction.ActionPreparation` — GeoImpactAction: ขั้นเตรียมก่อนปล่อยสกิล: [set] `breathingMethodHeal` = `SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), Ski…` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.BreathingMethod, out) & 1) ne 0 AND Tr… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.CalcCostMp` — MP ที่ใช้ของสกิล: [call] `InflexibilityBuf$$CheckMpHalving` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Inflexibility), this` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill…; [call] `MultipleHuntBuf$$CheckMode` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt), SkillMode…` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill…; [set] `<CostMpType>k__BackingField` = `(CostMpType | 1)` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.RemoveAfterSkillBuf` — PlayerAttackBase.RemoveAfterSkillBuf: [call] `SkillBufferManager$$RemoveBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.BreathingMethod` เมื่อ (PlayerAttackBase.ContainsNotApplicableSkill(PlayerAttackBase.get_ActionID()) & 1) eq 0 AND (SkillBufferManager.Contain… (นิยามเต็มในแท็บ Variables)

### กลอเรียเทคชอต (GoliathTakeShot) · uid 1155

<img src="../../icons/sk_1155.png" width="40" alt="icon">

- ทรี: สกิลครัชเชอร์ (ขั้น 2) · เลเวลสูงสุด: 90 · อาวุธ: MainKnuckle · ต้องเรียนก่อน: กำปั้นผดุงคุณธรรม · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `GoliathTakeShotAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีศัตรูตัวฉกาจอย่างรุนแรง
> ชาร์จสกิล(เลเวล6)
> จะโจมตีในระยะที่แคบมาก
> ถ้าเลยเวลาที่ชาร์จนเต็มไปแล้ว
> พลังจะลดลง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- MP ที่ใช้: 500
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `GoliathTakeShotBuf`: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `chargeLevel` (ตัวนับที่เปลี่ยนตามเหตุการณ์)
- ตัวอ่านสกิลนี้ `GoliathTakeShotAction.OnInitialize` — GoliathTakeShotAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `mp` = `((SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Go…` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GoliathTakeShotAction.ReceivedAbnormal` — GoliathTakeShotAction.ReceivedAbnormal (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.GetSkillTargetType` — MobaPlayerActionManager.GetSkillTargetType: คืนค่า `MasterSkillDataManager.GetSkillMaster(Singleton<MasterSkillDataManager>.get_Instance(), SkillId.CloningTechnique).TargetType` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.GetSkillTargetType` — PlayerActionManager.GetSkillTargetType: คืนค่า `MasterSkillDataManager.GetSkillMaster(Singleton<MasterSkillDataManager>.get_Instance(), SkillId.CloningTechnique).TargetType` (11 กรณี) (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=1155 -->
#### การคำนวณแบบตัวเลข — GoliathTakeShot (uid 1155)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **500** → 500, 500, 500, 500, 500, 500, 500, 500, 500, 500 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `baseSkillRate`, กิ่งที่ 1 ของ `chargeSkillRate`]: ขึ้นกับ `chargeLevel` — สูตร `0.01 × (10 × Lv + 300) × chargeLevel + 8` — โดยที่ `chargeLevel` = `GoliathTakeShotBuf.GetParam(50)` หรือ `SkillIndividualFlag` ; `SkillIndividualFlag` = `GoliathTakeShotBuf.GetParam(50)`

  | chargeLevel | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | 1110% | 1120% | 1130% | 1140% | 1150% | 1160% | 1170% | 1180% | 1190% | 1200% |
  | 2 | 1420% | 1440% | 1460% | 1480% | 1500% | 1520% | 1540% | 1560% | 1580% | 1600% |
  | 3 | 1730% | 1760% | 1790% | 1820% | 1850% | 1880% | 1910% | 1940% | 1970% | 2000% |
  | 4 | 2040% | 2080% | 2120% | 2160% | 2200% | 2240% | 2280% | 2320% | 2360% | 2400% |
  | 5 | 2350% | 2400% | 2450% | 2500% | 2550% | 2600% | 2650% | 2700% | 2750% | 2800% |

  ระดับสูงสุดต่อเลเวลสกิล: Lv1=5, Lv2=5, Lv3=5, Lv4=5, Lv5=5, Lv6=5, Lv7=5, Lv8=5, Lv9=5, Lv10=5 (`–` = เลเวลนั้นชาร์จไม่ถึง)

- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`IsInstanceOf(actarAction, MercenaryActionManager) ≠ 1` หรือ `IsInstanceOf(actarAction, MercenaryActionManager) = 1` · กิ่งที่ 1 ของ `baseSkillRate`]: ขึ้นกับ `chargeLevel` — สูตร `0.01 × chargeSkillRate × chargeLevel + 8` — โดยที่ `chargeSkillRate` = `10 × Lv + 300` หรือ `(chargeSkillRate + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1158], 50))` [`IsInstanceOf(actarAction, MercenaryActionManager) ≠ 1` หรือ `IsInstanceOf(actarAction, MercenaryActionManager) = 1`] ; `chargeLevel` = `GoliathTakeShotBuf.GetParam(50)` หรือ `SkillIndividualFlag` ; `SkillIndividualFlag` = `GoliathTakeShotBuf.GetParam(50)`

  | chargeLevel | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | 1110% | 1120% | 1130% | 1140% | 1150% | 1160% | 1170% | 1180% | 1190% | 1200% |
  | 2 | 1420% | 1440% | 1460% | 1480% | 1500% | 1520% | 1540% | 1560% | 1580% | 1600% |
  | 3 | 1730% | 1760% | 1790% | 1820% | 1850% | 1880% | 1910% | 1940% | 1970% | 2000% |
  | 4 | 2040% | 2080% | 2120% | 2160% | 2200% | 2240% | 2280% | 2320% | 2360% | 2400% |
  | 5 | 2350% | 2400% | 2450% | 2500% | 2550% | 2600% | 2650% | 2700% | 2750% | 2800% |

  ระดับสูงสุดต่อเลเวลสกิล: Lv1=5, Lv2=5, Lv3=5, Lv4=5, Lv5=5, Lv6=5, Lv7=5, Lv8=5, Lv9=5, Lv10=5 (`–` = เลเวลนั้นชาร์จไม่ถึง)

- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`IsInstanceOf(actarAction, MercenaryActionManager) ≠ 1` หรือ `IsInstanceOf(actarAction, MercenaryActionManager) = 1` · กิ่งที่ 1 ของ `chargeSkillRate`]: ขึ้นกับ `chargeLevel` — สูตร `0.01 × baseSkillRate + 0.01 × (10 × Lv + 300) × chargeLevel` — โดยที่ `baseSkillRate` = `800` หรือ `(baseSkillRate + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1158], 50))` [`IsInstanceOf(actarAction, MercenaryActionManager) ≠ 1` หรือ `IsInstanceOf(actarAction, MercenaryActionManager) = 1`] ; `chargeLevel` = `GoliathTakeShotBuf.GetParam(50)` หรือ `SkillIndividualFlag` ; `SkillIndividualFlag` = `GoliathTakeShotBuf.GetParam(50)`

  | chargeLevel | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | 1110% | 1120% | 1130% | 1140% | 1150% | 1160% | 1170% | 1180% | 1190% | 1200% |
  | 2 | 1420% | 1440% | 1460% | 1480% | 1500% | 1520% | 1540% | 1560% | 1580% | 1600% |
  | 3 | 1730% | 1760% | 1790% | 1820% | 1850% | 1880% | 1910% | 1940% | 1970% | 2000% |
  | 4 | 2040% | 2080% | 2120% | 2160% | 2200% | 2240% | 2280% | 2320% | 2360% | 2400% |
  | 5 | 2350% | 2400% | 2450% | 2500% | 2550% | 2600% | 2650% | 2700% | 2750% | 2800% |

  ระดับสูงสุดต่อเลเวลสกิล: Lv1=5, Lv2=5, Lv3=5, Lv4=5, Lv5=5, Lv6=5, Lv7=5, Lv8=5, Lv9=5, Lv10=5 (`–` = เลเวลนั้นชาร์จไม่ถึง)

- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`IsInstanceOf(actarAction, MercenaryActionManager) ≠ 1` หรือ `IsInstanceOf(actarAction, MercenaryActionManager) = 1`]: ขึ้นกับ `chargeLevel` — สูตร `0.01 × baseSkillRate + 0.01 × chargeSkillRate × chargeLevel` — โดยที่ `baseSkillRate` = `800` หรือ `(baseSkillRate + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1158], 50))` [`IsInstanceOf(actarAction, MercenaryActionManager) ≠ 1` หรือ `IsInstanceOf(actarAction, MercenaryActionManager) = 1`] ; `chargeSkillRate` = `10 × Lv + 300` หรือ `(chargeSkillRate + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1158], 50))` [`IsInstanceOf(actarAction, MercenaryActionManager) ≠ 1` หรือ `IsInstanceOf(actarAction, MercenaryActionManager) = 1`] ; `chargeLevel` = `GoliathTakeShotBuf.GetParam(50)` หรือ `SkillIndividualFlag` ; `SkillIndividualFlag` = `GoliathTakeShotBuf.GetParam(50)`

  | chargeLevel | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | 1110% | 1120% | 1130% | 1140% | 1150% | 1160% | 1170% | 1180% | 1190% | 1200% |
  | 2 | 1420% | 1440% | 1460% | 1480% | 1500% | 1520% | 1540% | 1560% | 1580% | 1600% |
  | 3 | 1730% | 1760% | 1790% | 1820% | 1850% | 1880% | 1910% | 1940% | 1970% | 2000% |
  | 4 | 2040% | 2080% | 2120% | 2160% | 2200% | 2240% | 2280% | 2320% | 2360% | 2400% |
  | 5 | 2350% | 2400% | 2450% | 2500% | 2550% | 2600% | 2650% | 2700% | 2750% | 2800% |

  ระดับสูงสุดต่อเลเวลสกิล: Lv1=5, Lv2=5, Lv3=5, Lv4=5, Lv5=5, Lv6=5, Lv7=5, Lv8=5, Lv9=5, Lv10=5 (`–` = เลเวลนั้นชาร์จไม่ถึง)

<!-- calc:end -->

### ฟลายอิ้งคิก (FloatingKick) · uid 1156

<img src="../../icons/sk_1156.png" width="40" alt="icon">

- ทรี: สกิลครัชเชอร์ (ขั้น 2) · เลเวลสูงสุด: 90 · อาวุธ: สนับมือ · ต้องเรียนก่อน: วิธีการหายใจ · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `FloatingKickAction` · สถานะการแกะ: แกะครบจากโค้ด

> กระโดดลอยไปเตะจากระยะไกล
> ถ้าใช้แบบธรรมดาจะเพิ่มความรุนแรงให้โจมตีคริติคอล
> เมื่อใช้ระหว่างเคลื่อนที่จะเล็งตรงเป้า
> โจมตีคริติคอลจะเพิ่มขึ้นในระดับนึงเท่านั้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

<!-- calc:begin uid=1156 -->
#### การคำนวณแบบตัวเลข — FloatingKick (uid 1156)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **100 + 10×Lv** → 110, 120, 130, 140, 150, 160, 170, 180, 190, 200 (Lv1…10)
- ตัวคูณคริติคอลเพิ่ม (`CriticalRate`, ×, บวกเข้าช่อง) [`(!PlayerAttackBase.checkCriticalPercent(this, status.Critical, mobAction) ^ 1)` และ `(SkillCalcTemplate.get_Item(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 13) + (criticalDmgUp * 0.01)) ≤ 2` และ `inputDirection = 0`]: **(10 + 4×Lv)%** → 14%, 18%, 22%, 26%, 30%, 34%, 38%, 42%, 46%, 50% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate` หรือ `!InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance())` หรือ `InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance())`]: **(500 + 20×Lv)%** → 520%, 540%, 560%, 580%, 600%, 620%, 640%, 660%, 680%, 700% (Lv1…10)
<!-- calc:end -->

### คอมบิเนชั่น (Combination) · uid 1157

<img src="../../icons/sk_1157.png" width="40" alt="icon">

- ทรี: สกิลครัชเชอร์ (ขั้น 2) · เลเวลสูงสุด: 90 · อาวุธ: MainKnuckle · ต้องเรียนก่อน: วิธีการหายใจ · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `CombinationAction` · สถานะการแกะ: แกะครบจากโค้ด

> ออกหมัดต่อเนื่องอย่างรวดเร็ว
> สกิลนี้โจมตีด้วย[ความเคยชินตามปกติ]
> อัตราคริติคอลเพิ่มขึ้นตามสกิลเลเวลที่เพิ่มขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: ธรรมดา (SkillNormal)
- Proration: ช่องตีปกติ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

<!-- calc:begin uid=1157 -->
#### การคำนวณแบบตัวเลข — Combination (uid 1157)
Proration: ช่อง `Normal` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(100 + 10×Lv)%** → 110%, 120%, 130%, 140%, 150%, 160%, 170%, 180%, 190%, 200% (Lv1…10)
<!-- calc:end -->

### ก็อดแฮนด์ (GodHand) · uid 1158

<img src="../../icons/sk_1158.png" width="40" alt="icon">

- ทรี: สกิลครัชเชอร์ (ขั้น 3) · เลเวลสูงสุด: 170 · อาวุธ: MainKnuckle · ต้องเรียนก่อน: กลอเรียเทคชอต · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `GodHandAction` · สถานะการแกะ: แกะครบจากโค้ด

> หมัดปัดเป่าภัยพิบัติ
> ความเสียหายจะลดลงเสมอในขณะใช้งาน
> พลังของครัชเชอร์ที่ใช้ต่อจะเพิ่มขึ้น 60 วินาที
> หากโจมตีโดนหรือลดความเสียหายลงได้สำเร็จ
> 
> (สูงสุดไม่เกิน 3 สแทค)

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `GodHandBuf` ระยะเวลา `time` วินาที [`Lv > 9` หรือ `1 ge (10 - lv)` และ `Lv ≤ 9` หรือ `1 lt (10 - lv)` และ `2 ge (10 - lv)` และ `Lv ≤ 9`]: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `10 × stack × Lv` · ต้านสถานะผิดปกติ (`AbnormalRegist`) = `SkillMasteryBase.GetMasteryParam(MasteryId.Value)` · ตัวคูณดาเมจที่ได้รับจากมอน (หมวดบัพ) (`MobLastDamageRateBuf`) = `SkillMasteryBase.GetMasteryParam(MasteryId.CutDmgRate)` · ตัวคูณดาเมจที่ได้รับจากมอน (หมวดเฉพาะ) (`MobLastDamageRateUnique`) = 72
- ตัวอ่านสกิลนี้ `GazerShootAction.ActionPreparation` — GazerShootAction: ขั้นเตรียมก่อนปล่อยสกิล: [set] `skillRate` = `(skillRate + SkillBufferDataBase.GetParam(50))` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBuf…; [set] `physicsBreaker` = `((physicsBreaker * SkillBufferDataBase.GetParam(20)) + physicsBreaker)` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBuf… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GodHandAction.ActionHit` — GodHandAction.ActionHit (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MindimageSenjuAttackAction.ActionHit` — MindimageSenjuAttackAction.ActionHit: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.GodHand, [baseSkill+0x14], 60, 0, 0` เมื่อ IsInheritance ne 0 AND CharacterActionManagerBase.get_IsLocalDead() ne 844 AND CharacterActionManagerBase.get_IsLocalDe… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.ReceiveDamaged` — MobaPlayerActionManager.ReceiveDamaged (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerSecondaryStatus.get_AntiVirus` — ค่า Anti Virus ของ MobaPlayerSecondaryStatus: คืนค่า `(_t526 lt 100 ? _t526 : 100)` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.Damaged` — PlayerActionManager: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `SkillDamageData$$SetAbnormalType` = `damageData, AbnormalType.None, 0` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND (_t1315 & 1) ne 0 AND (_t1316 & 1) ne…; [call] `PlayerGameStatus$$SetLocalHp` = `PlayerStatusBase.get_GameStatus(), 1, 0` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND (SkillBufferManager.TryGetBuf(PlayerS…; [set] `<IsApparentDeath>k__BackingField` = `0` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND (SkillBufferManager.TryGetBuf(PlayerS… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.CalcAntiVirus` — คำนวณ anti virus (PlayerSecondaryStatus): คืนค่า `_t1560` (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=1158 -->
#### การคำนวณแบบตัวเลข — GodHand (uid 1158)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **40×Lv** → 40, 80, 120, 160, 200, 240, 280, 320, 360, 400 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **1000%** → 1000%, 1000%, 1000%, 1000%, 1000%, 1000%, 1000%, 1000%, 1000%, 1000% (Lv1…10)

**ค่าบัพที่ขึ้นกับจำนวน stack**

- บัพ `GodHandBuf` — `Value` ตามจำนวน `Count`: `10 × Count × Lv`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |
  | 2 | 20 | 40 | 60 | 80 | 100 | 120 | 140 | 160 | 180 | 200 |
  | 3 | 30 | 60 | 90 | 120 | 150 | 180 | 210 | 240 | 270 | 300 |
  | 4 | 40 | 80 | 120 | 160 | 200 | 240 | 280 | 320 | 360 | 400 |
  | 5 | 50 | 100 | 150 | 200 | 250 | 300 | 350 | 400 | 450 | 500 |
<!-- calc:end -->

### ผู้ทำลายล้าง (Destroyer) · uid 1159

<img src="../../icons/sk_1159.png" width="40" alt="icon">

- ทรี: สกิลครัชเชอร์ (ขั้น 3) · เลเวลสูงสุด: 170 · อาวุธ: สนับมือ · ต้องเรียนก่อน: คอมบิเนชั่น · ธง: StarGem
- คลาสในโค้ด: `DestroyerAction` · สถานะการแกะ: แกะครบจากโค้ด

> แก่นแท้แห่งการทำลายล้าง
> เมื่อเรียนรู้สกิลนี้แล้วจะมีผลเป็นพาสซีฟ
> เพิ่มปริมาณการฟื้นฟู HP ของวิธีการหายใจ เมื่อถึง Lv10 จะเพิ่มผลลด MP ที่ใช้กับสกิล
> ถ้าใช้กับสนับมือจะได้ผลลัพธ์ที่ดียิ่งขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `DestroyerBuf`: ATK อาวุธฐาน % (`BaseEqAtkUpRate`) = 5×Lv → 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10) · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = 2, 5, 7, 10, 12, 15, 17, 20, 22, 25 (Lv1…10) · ความเสถียร (`Stable`) = `(isMainKnuckleEquip eq 0 ? 0 : 0xfffffff6)` (ตัวนับที่เปลี่ยนตามเหตุการณ์)
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `EnchantedBurstAction.ActionHit` — EnchantedBurstAction.ActionHit: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new EnchantedBurstBuf, Id` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (flag & 1) ne 0 AND (SkillBufferManager.ContainsBuffer(… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EnchantedBurstAction.AddLocalStack` — EnchantedBurstAction.AddLocalStack: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new EnchantedBurstBuf, 0` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Kakei) & 1) eq 0 AND (SkillBuffer… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EnchantedSwordAction.ActionPreparation` — EnchantedSwordAction: ขั้นเตรียมก่อนปล่อยสกิล (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EquipItemData.WeaponTypeCalculatorBase.CalcEqAtk` — คำนวณ eq atk (WeaponTypeCalculatorBase): คืนค่า `(((_t282 // 100) + (_t277 + ItemData.get_Refine(WeaponTypeCalculatorBase.item))) + int(_t285))` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GeoImpactAction.calcPlayerToMobDamage` — GeoImpactAction: สูตรดาเมจผู้เล่น→มอนสเตอร์ (ใส่ค่าลง template) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GoliathTakeShotAction.EnemyDamage` — GoliathTakeShotAction.EnemyDamage (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MindimageSenjuAttackAction.CalcDamageGeoImpact` — คำนวณ damage geo impact (MindimageSenjuAttackAction) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.CalcCostMp` — MP ที่ใช้ของสกิล: คืนค่า `_t1395` (6 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ShellBreakAction.OnInitialize` — ShellBreakAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `breakPercent` = `_t1729` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Destroyer, out) & 1) ne 0 AND TryGetBu… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv16: [ผลลัพธ์ด้านล่างจะใช้ได้กับอาวุธหลักเท่านั้น] *ระหว่างได้รับผลของบัฟ ATK อาวุธจะเพิ่มขึ้น อัตราการลดการป้องกันที่เกิดจาก[เชลเบรค]จะเพิ่มขึ้นแต่ความเสถียรจะลดลง และจะไม่สามารถใช้งานผงะ/ล้มคว่ำ/หมดสติ/ผลักกระเด็นได้

### เทอราบลาสต์ (GeoImpact) · uid 1160

<img src="../../icons/sk_1160.png" width="40" alt="icon">

- ทรี: สกิลครัชเชอร์ (ขั้น 4) · เลเวลสูงสุด: 250 · อาวุธ: MainKnuckle · ต้องเรียนก่อน: ผู้ทำลายล้าง · ธง: StarGem
- คลาสในโค้ด: `GeoImpactAction` · สถานะการแกะ: แกะครบจากโค้ด

> ทักษะการบดขยี้แผ่นดินแล้วใช้หินที่ยกสูงขึ้นเป็นเกราะกำบัง
> สร้างความเสียหายให้กับพื้นที่โดยรอบ
> และสร้างบาเรีย 10 วินาทีตาม HP ที่ใช้ไป(ไม่สามารถบันทึกทับ)
> ถ้าผู้ทำลายล้างใช้งานอยู่และเป้าหมายติด"ลดการป้องกัน"
> จะการันตีคริติคอล

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `GeoImpactBuf` ระยะเวลา 10 วินาที: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `barrier` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `int(((barrier / hp) * 100))`
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 100 ตามที่ `GeoImpactBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `GeoImpactAction.ActionStart` — GeoImpactAction: ตอนเริ่มทำงานของสกิล: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new GeoImpactBuf, Id` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.GeoImpact) & 1) eq 0 AND PlayerSt… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv16: หากได้รับบัฟเพิ่มพลังโจมตีของก็อดแฮนด์ จะเพิ่มผลการฟื้นฟู MP เล็กน้อยให้กับ สกิลเทอราบลาสต์เมื่อโจมตีโดนเป้าหมาย

<!-- calc:begin uid=1160 -->
#### การคำนวณแบบตัวเลข — GeoImpact (uid 1160)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **700 + 10×Lv** → 710, 720, 730, 740, 750, 760, 770, 780, 790, 800 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate`]: `0.01 × System.Math.Max(baseSTR, baseAGI) + 0.6 × Lv + 9` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseSTR` = แต้ม STR ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseSTR; `baseAGI` = แต้ม AGI ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseAGI (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `skillRate`]: `0.01 × skillRate` — โดยที่ `skillRate` = `System.Math.Max(baseSTR, baseAGI) + 60 × Lv + 900` หรือ `(SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1158], 50) + skillRate)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
<!-- calc:end -->

### ร่างแกร่งดุจเทพ (GodRigidBody) · uid 1161

<img src="../../icons/sk_1161.png" width="40" alt="icon">

- ทรี: สกิลครัชเชอร์ (ขั้น 4) · เลเวลสูงสุด: 250 · อาวุธ: MainKnuckle · ต้องเรียนก่อน: ก็อดแฮนด์ · ธง: StarGem
- คลาสในโค้ด: `GodRigidBodyMastery` · สถานะการแกะ: แกะครบจากโค้ด

> ทำให้หัตถ์แห่งเทพสมบูรณ์พร้อม
> ระหว่างใช้ก็อดแฮนด์อัตราความเสียหายจะลดลง
> และต้านภาวะผิดปกติเพิ่มขึ้น
> นอกจากนี้ทุกครั้งที่ลดสำเร็จ MP จะฟื้นฟูเล็กน้อย(สูงสุด 2 ครั้ง)

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ลดดาเมจที่ได้รับ % (`CutDmgRate`): 90, 90, 90, 90, 90, 90, 90, 90, 90, 90 (Lv1…10)
- พาสซีฟ ค่าทั่วไป (`Value`): 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10)
- ตัวอ่านสกิลนี้ `GodHandBuf.DeathExemption` — GodHandBuf.DeathExemption: [set] `isDeathExemption` = `0` เมื่อ isSkillEnd eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.GodRigidBody, 1) ge 1 AND isDe… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GodHandBuf.Initalize` — GodHandBuf.Initalize: [set] `isDeathExemption` = `1` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.GodRigidBody, 1) ge 1 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GoliathTakeShotAction.EnemyDamage` — GoliathTakeShotAction.EnemyDamage (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv16: ถ้าเรียนรู้และมีสถานะร่างแกร่งดุจเทพแล้วใช้[ผู้ทำลายล้าง] การชาร์จ[กลอเรียเทคชอต]จะเพิ่มขึ้นเร็วขึ้น ทุกครั้งที่สร้างความเสียหายด้วยครัชเชอร์

### กีย์เซอร์ชู้ต (GazerShoot) · uid 1162

<img src="../../icons/sk_1162.png" width="40" alt="icon">

- ทรี: สกิลครัชเชอร์ (ขั้น 4) · เลเวลสูงสุด: 250 · อาวุธ: MainKnuckle · ต้องเรียนก่อน: ฟลายอิ้งคิก · ธง: StarGem
- คลาสในโค้ด: `GazerShootAction` · สถานะการแกะ: แกะครบจากโค้ด

> การกระโดดเตะที่รวดเร็วและทรงพลังอย่างน่าสะพรึงกลัว
> การแสดงผลของสกิลจะเปลี่ยนตามระยะใกล้/ไกล ถ้าใช้ในระยะไกล
> พลังจะเพิ่มขึ้นและเพิ่มการใช้วิธีการหายใจที่ได้เรียนรู้มา

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `BreathingMethodBuf`: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `nextHeal` (ตัวนับที่เปลี่ยนตามเหตุการณ์)
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่

<!-- calc:begin uid=1162 -->
#### การคำนวณแบบตัวเลข — GazerShoot (uid 1162)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) · ส่วน longBonus (`longBonus…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **200 + 10×Lv** → 210, 220, 230, 240, 250, 260, 270, 280, 290, 300 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate` · AGI รวม=100 หรือ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1158) ≠ 0` · AGI รวม=100]: **(950 + 10×Lv)%** → 960%, 970%, 980%, 990%, 1000%, 1010%, 1020%, 1030%, 1040%, 1050% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate` · AGI รวม=255 หรือ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1158) ≠ 0` · AGI รวม=255]: **(1027 + 10×Lv)%** → 1037%, 1047%, 1057%, 1067%, 1077%, 1087%, 1097%, 1107%, 1117%, 1127% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`startTargetDist ge MathUtil.DisplayMeterToDistance(8)` · กิ่งที่ 1 ของ `longBonusSkillRate`]: **(50×Lv)%** → 50%, 100%, 150%, 200%, 250%, 300%, 350%, 400%, 450%, 500% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`startTargetDist lt MathUtil.DisplayMeterToDistance(8)`]: **0%** → 0%, 0%, 0%, 0%, 0%, 0%, 0%, 0%, 0%, 0% (Lv1…10)
<!-- calc:end -->

