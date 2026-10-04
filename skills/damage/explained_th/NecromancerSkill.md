# สกิลเนโครแมนเซอร์ (`NecromancerSkill`) — คำอธิบายทีละสกิล (ภาษาไทย)

สร้างอัตโนมัติด้วย `scripts/render_explained_th.py` จาก `skill_reference.json` (ข้อมูลโค้ด client ชุดล่าสุด) ไม่มีข้อความเขียนมือ แก้ไฟล์นี้ตรง ๆ จะถูกเขียนทับ ตัวเลขทั้งหมดคำนวณจากโค้ด (Code) ความหมายของชื่อ field/บทบาทแปลจากชื่อในโค้ด (Inferred) ยังไม่ได้เทียบกับตัวเลขในเกม ข้อมูลดิบทุกเส้นทางอยู่ใน `../details/NecromancerSkill.md`

---

<!-- calc:preface -->
> **วิธีอ่านหัวข้อ "การคำนวณแบบตัวเลข"** (สร้างอัตโนมัติด้วย `scripts/render_calc_th.py` จาก `skill_reference.json` แก้มือจะถูกเขียนทับ)
> ดาเมจต่อฮิตเดินตามขั้น `SkillCalcTemplate/CalcStep` 0→40 ตามลำดับ (Code: `SkillCalcTemplate.GetDamage`) ขั้น `+` บวกเข้าดาเมจ ขั้น `×` คูณแล้วปัดเศษทิ้ง (int) ทันทีทุกขั้น
> ลำดับหลัก: ดาเมจฐาน(7) + คงที่สกิล(8) + คงที่บัพ(9) − ป้องกันเป้า(10) + ตีแรก(11) → ×คริ(13) → ×ธาตุ(15) → ×ตัวคูณสกิล(18) → ×ตีแรก(19) → ×เสถียร(21) → +คงที่ออโต้(22) → ×Proration(23) → ×ประเภท(24) → ×ดาเมจสุดท้าย(25) → … → เพดาน/ขั้นต่ำ(35–37)
> "ฮิต N" = template ดาเมจแต่ละก้อน (ทอยคริแยกกัน) แยกตามเมธอดและตัวแปรฮิตในโค้ด (`type`, `isFirst`, `attackCount` …) ชื่อฮิต/ส่วนมาจากชื่อในโค้ด (Inferred) ตัวเลขคำนวณจากโค้ด (Code) โดยตั้งเจม/บัพเสริม = 0
> ค่าหลายก้อนในขั้นเดียวกันแบบ "บวกเข้าช่อง" จะบวกกันก่อนคูณ ส่วน "ตั้งค่าทับ" แทนที่ค่าเดิม ค่าที่ขึ้นกับสเตตัสแสดงเป็นตัวอย่างที่ 100 / 255 (และ Lv สกิลอื่น 1 / 10) ใช้สูตรที่แนบไว้คำนวณค่าอื่นเอง
<!-- calc:preface-end -->

### เกรฟดิกเกอร์ (GlaiveTigger) · uid 1121

<img src="../../icons/sk_1121.png" width="40" alt="icon">

- ทรี: สกิลเนโครแมนเซอร์ (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: NoMarketSearch
- คลาสในโค้ด: `GlaiveTiggerAction` · สถานะการแกะ: แกะครบจากโค้ด

> เปิดสุสานแห่งจินตนาการเพื่อเตรียมใช้วิชาเนโครแมนเซอร์
> 
> เมื่ออยู่ในสุสานจะเริ่มสะสมสแต็ควิญญาณ
> ถ้าออกจากสุสานวิญญาณจะค่อยๆ หายไป

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, วางวัตถุ/กับดัก/อัญเชิญ
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `GlaiveTiggerBuf`: ค่าเปอร์เซ็นต์ทั่วไป (`Percent`) = `int(((Lv * 0.1) * Count))` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0` · ค่าเปอร์เซ็นต์ทั่วไป (`Percent`) = `CountBufferBase.GetParam(this, id)` · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `System.Linq.Enumerable.Count<SkillActionBase>(SkillActionManager.get_PlaceSkilList(skillActionManager), GlaiveTiggerBuf.<>c.<>9__11_0)` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0` · ต้านสถานะผิดปกติ (`AbnormalRegist`) = `int(((Lv * 0.05) * Count))` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0` · ต้านสถานะผิดปกติ (`AbnormalRegist`) = `CountBufferBase.GetParam(this, id)`
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 99 ตามที่ `GlaiveTiggerBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `GlaiveTiggerAction.<>c__DisplayClass24_0.<ActionStart>b__0` — <>c__DisplayClass24_0.<ActionStart>b__0: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new GlaiveTiggerBuf, [<>c__DisplayClass24_0.<>…` เมื่อ (_t360 & 1) ne 0 AND <>c__DisplayClass24_0.weaponType eq 14 AND (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_Skil… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GlaiveTiggerAction.InitializeOthers` — GlaiveTiggerAction.InitializeOthers (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GlaiveTiggerBuf.SetCountValue` — GlaiveTiggerBuf.SetCountValue: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new GlaiveTiggerBuf, 0` เมื่อ (UnityEngine.Object.op_Equality(playerAction, 0) & 1) eq 0 AND value ne 0 AND (SkillBufferManager.TryGetBuf(PlayerStatu…; [call] `GlaiveTiggerBuf$$SetCount` = `((SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.GlaiveT…` เมื่อ (UnityEngine.Object.op_Equality(playerAction, 0) & 1) eq 0 AND value ne 0; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.GlaiveTigger` เมื่อ (UnityEngine.Object.op_Equality(playerAction, 0) & 1) eq 0 AND value eq 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerSecondaryStatus.get_AntiVirus` — ค่า Anti Virus ของ MobaPlayerSecondaryStatus: คืนค่า `(_t526 lt 100 ? _t526 : 100)` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PhantomMissileAction.ActionPreparation` — PhantomMissileAction: ขั้นเตรียมก่อนปล่อยสกิล: [set] `<SkillIndividualFlag>k__BackingField` = `System.Math.Min(SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBuff…` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_Skil…; [set] `<LoopParam>k__BackingField` = `(System.Math.Min(SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBuf…` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_Skil… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PhantomMissileAction.IsFailure` — เงื่อนไข is failure (PhantomMissileAction): คืนค่า `(PlayerAttackBase.IsFailure(this, status, missType) & 1)` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.CalcAntiVirus` — คำนวณ anti virus (PlayerSecondaryStatus): คืนค่า `_t1560` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.get_AtkMpRecovery` — ค่า Atk Mp Recovery ของ PlayerSecondaryStatus: คืนค่า `0` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SummonSkeletonAction.ActionPreparation` — SummonSkeletonAction: ขั้นเตรียมก่อนปล่อยสกิล (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SummonSkeletonAction.IsFailure` — เงื่อนไข is failure (SummonSkeletonAction): คืนค่า `1` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `TombAction.ActionPreparation` — TombAction: ขั้นเตรียมก่อนปล่อยสกิล: [set] `<LoopParam>k__BackingField` = `System.Math.Min((SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBuf…` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (SkillBuf…; [set] `<SkillIndividualFlag>k__BackingField` = `System.Math.Min((SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBuf…` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (SkillBuf… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: ไม่ว่าจะเป็นสกิลเลเวลใดก็จะได้รับสแต็ควิญญาณทุกวินาที จำนวนสแต็ควิญญาณที่คุณได้รับจะเพิ่มการฟื้นฟู MP การโจมตี และความต้านทานต่อสภาวะผิดปกติ  การฟื้นฟู MP การโจมตีต่อจำนวนสแต็ควิญญาณและ ความต้านทานต่อสภาวะผิดปกติจะเพิ่มขึ้นตามเลเวลสกิล

<!-- calc:begin uid=1121 -->
#### การคำนวณแบบตัวเลข — GlaiveTigger (uid 1121)

**ค่าบัพที่ขึ้นกับจำนวน stack**

- บัพ `GlaiveTiggerBuf` — `Percent` ตามจำนวน `Count`: `int(0.1 × Lv × Count)`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 1 |
  | 2 | 0 | 0 | 0 | 0 | 1 | 1 | 1 | 1 | 1 | 2 |
  | 3 | 0 | 0 | 0 | 1 | 1 | 1 | 2 | 2 | 2 | 3 |
  | 4 | 0 | 0 | 1 | 1 | 2 | 2 | 2 | 3 | 3 | 4 |
  | 5 | 0 | 1 | 1 | 2 | 2 | 3 | 3 | 4 | 4 | 5 |

- บัพ `GlaiveTiggerBuf` — `Value` ตามจำนวน `Count`: `จำนวนเป้าในลิสต์ที่ตรงเงื่อนไข`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |

- บัพ `GlaiveTiggerBuf` — `AbnormalRegist` ตามจำนวน `Count`: `int(0.05 × Lv × Count)`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 |
  | 2 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 1 |
  | 3 | 0 | 0 | 0 | 0 | 0 | 0 | 1 | 1 | 1 | 1 |
  | 4 | 0 | 0 | 0 | 0 | 1 | 1 | 1 | 1 | 1 | 2 |
  | 5 | 0 | 0 | 0 | 1 | 1 | 1 | 1 | 2 | 2 | 2 |
<!-- calc:end -->

### ทูม (Tomb) · uid 1122

<img src="../../icons/sk_1122.png" width="40" alt="icon">

- ทรี: สกิลเนโครแมนเซอร์ (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: NoMarketSearch
- คลาสในโค้ด: `TombAction` · สถานะการแกะ: แกะครบจากโค้ด

> เนโครแมนเซอร์ที่ใช้ศิลาหน้าหลุมศพโจมตี
> สร้างความเสียหายทางกายภาพแก่เป้าหมาย
> เมื่อ VIT มากกว่า 50 จะเพิ่มโอกาสทำให้เป้าหมาย[ล้มคว่ำ]
> หากใช้สแต็ควิญญาณx3 จะเพิ่มการโจมตีบริเวณโดยรอบ
> สามารถเปิดใช้งานพร้อมกันได้สูงสุด 3 ครั้ง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `abnormalPercent`: `System.Math.Min(20 × baseVIT // 50, 100)` %
- สถานะที่ทำให้ติด: ล้มคว่ำ (Tumble)

<!-- calc:begin uid=1122 -->
#### การคำนวณแบบตัวเลข — Tomb (uid 1122)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`(SkillActionBase.get_AttackCount(this) & 255) ≠ 0`]: **30×Lv** → 30, 60, 90, 120, 150, 180, 210, 240, 270, 300 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`(SkillActionBase.get_AttackCount(this) & 255) = 0`]: **300** → 300, 300, 300, 300, 300, 300, 300, 300, 300, 300 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`(SkillActionBase.get_AttackCount(this) & 255) ≠ 0`]: **(150 + 10×Lv)%** → 160%, 170%, 180%, 190%, 200%, 210%, 220%, 230%, 240%, 250% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`(SkillActionBase.get_AttackCount(this) & 255) = 0`]: **250%** → 250%, 250%, 250%, 250%, 250%, 250%, 250%, 250%, 250%, 250% (Lv1…10)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `target.ExpDefSkill / 100` — โดยที่ `target` = `UnityEngine.GameObject.get_transform(target)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefSkill` = proration ช่อง Skill ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpRegister[mobAction] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `InitializeOthers`): `motionSpeed`
- `LoopParam` (ตั้งใน `ActionPreparation`) [`System.Math.Min((SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121), 20) // 3), 3) ≥ 1` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121) ≠ 0` หรือ `System.Math.Min((SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121), 20) // 3), 3) < 1` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121) ≠ 0`]: `System.Math.Min(SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121), 20) // 3, 3)`
<!-- calc:end -->

### แฟนทอมมิสไซล์ (PhantomMissile) · uid 1123

<img src="../../icons/sk_1123.png" width="40" alt="icon">

- ทรี: สกิลเนโครแมนเซอร์ (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: ไม้เท้า · ต้องเรียนก่อน: เกรฟดิกเกอร์ · ธง: NoMarketSearch
- คลาสในโค้ด: `PhantomMissileAction` · สถานะการแกะ: แกะครบจากโค้ด

> เนโครแมนเซอร์ที่โจมตีด้วยการปล่อยวิญญาณชั่วร้าย
> ใช้สแต็ควิญญาณ (สูงสุด 10)
> เพื่อสร้างความเสียหายเวทมนตร์แก่เป้าหมาย
> ยิ่งใช้วิญญาณมากขึ้นจะยิ่งเพิ่มระยะเวลา (จำนวน HIT)
> ทุกครั้งที่ติดคริติคอล(เกณฑ์ทางกายภาพ)พลังจะเพิ่มขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 6 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

<!-- calc:begin uid=1123 -->
#### การคำนวณแบบตัวเลข — PhantomMissile (uid 1123)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`(LoopParam + 1) ≥ 1` และ `1 ge (LoopParam + 1)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6)` และ `targetMagicExp = 0` หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6)` และ `(LoopParam + 1) ≥ 1` และ `1 ge (LoopParam + 1)` และ `targetMagicExp = 0` หรือ `(LoopParam + 1) ≥ 1` และ `1 ge (LoopParam + 1)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6)` และ `targetMagicExp ≠ 0`]: **500** → 500, 500, 500, 500, 500, 500, 500, 500, 500, 500 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`(LoopParam + 1) ≥ 1` และ `1 ge (LoopParam + 1)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6)` และ `targetMagicExp = 0` หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6)` และ `(LoopParam + 1) ≥ 1` และ `1 ge (LoopParam + 1)` และ `targetMagicExp = 0` หรือ `(LoopParam + 1) ≥ 1` และ `1 ge (LoopParam + 1)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6)` และ `targetMagicExp ≠ 0` · กิ่งที่ 1 ของ `skillRate` หรือ `(LoopParam + 1) ≥ 1` และ `1 ge (LoopParam + 1)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6)` และ `targetMagicExp = 0` หรือ `(LoopParam + 1) ≥ 1` และ `1 ge (LoopParam + 1)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6)` และ `targetMagicExp ≠ 0`]: **100%** → 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`(LoopParam + 1) ≥ 1` และ `1 lt (LoopParam + 1)` และ `2 ge (LoopParam + 1)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6)` และ … หรือ `(LoopParam + 1) ≥ 1` และ `1 lt (LoopParam + 1)` และ `2 ge (LoopParam + 1)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6)` และ … หรือ `(LoopParam + 1) ≥ 1` และ `1 lt (LoopParam + 1)` และ `2 lt (LoopParam + 1)` และ `3 ge (LoopParam + 1)` และ … · กิ่งที่ 1 ของ `skillRate` หรือ `(LoopParam + 1) ≥ 1` และ `1 ge (LoopParam + 1)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6)` และ `targetMagicExp = 0` และ … หรือ `(LoopParam + 1) ≥ 1` และ `1 ge (LoopParam + 1)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6)` และ `targetMagicExp = 0` และ … หรือ `(LoopParam + 1) ≥ 1` และ `1 ge (LoopParam + 1)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6)` และ `targetMagicExp ≠ 0` และ …]: **(100 + 10×Lv)%** → 110%, 120%, 130%, 140%, 150%, 160%, 170%, 180%, 190%, 200% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`(LoopParam + 1) ≥ 1` และ `1 lt (LoopParam + 1)` และ `2 lt (LoopParam + 1)` และ `3 ge (LoopParam + 1)` และ … หรือ `(LoopParam + 1) ≥ 1` และ `1 lt (LoopParam + 1)` และ `2 lt (LoopParam + 1)` และ `3 lt (LoopParam + 1)` และ … หรือ `(LoopParam + 1) ≥ 1` และ `1 lt (LoopParam + 1)` และ `2 lt (LoopParam + 1)` และ `3 ge (LoopParam + 1)` และ … · กิ่งที่ 1 ของ `skillRate` หรือ `(LoopParam + 1) ≥ 1` และ `1 ge (LoopParam + 1)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6)` และ `targetMagicExp = 0` และ … หรือ `(LoopParam + 1) ≥ 1` และ `1 ge (LoopParam + 1)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6)` และ `targetMagicExp = 0` และ … หรือ `(LoopParam + 1) ≥ 1` และ `1 ge (LoopParam + 1)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6)` และ `targetMagicExp ≠ 0` และ …]: **(100 + 20×Lv)%** → 120%, 140%, 160%, 180%, 200%, 220%, 240%, 260%, 280%, 300% (Lv1…10)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`(LoopParam + 1) ≥ 1` และ `1 ge (LoopParam + 1)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6)` และ `targetMagicExp = 0` หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6)` และ `(LoopParam + 1) ≥ 1` และ `1 ge (LoopParam + 1)` และ `targetMagicExp = 0` หรือ `(LoopParam + 1) ≥ 1` และ `1 lt (LoopParam + 1)` และ `2 ge (LoopParam + 1)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6)` และ …]: `target.ExpDefMagic / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefMagic` = proration ช่อง Magic ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`(LoopParam + 1) ≥ 1` และ `1 ge (LoopParam + 1)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6)` และ `targetMagicExp ≠ 0` หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6)` และ `(LoopParam + 1) ≥ 1` และ `1 ge (LoopParam + 1)` และ `targetMagicExp ≠ 0` หรือ `(LoopParam + 1) ≥ 1` และ `1 lt (LoopParam + 1)` และ `2 ge (LoopParam + 1)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6)` และ …]: `targetMagicExp / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `ActionPreparation`) [`TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121) ≠ 0`]: `System.Math.Min(SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121), 20), 10) - 1`
- `LoopParam` (ตั้งใน `InitializeOthers`): `motionSpeed`
<!-- calc:end -->

### พลั่วชั้นดี (GoodQualityShovel) · uid 1124

<img src="../../icons/sk_1124.png" width="40" alt="icon">

- ทรี: สกิลเนโครแมนเซอร์ (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: ไม้เท้า · ต้องเรียนก่อน: เกรฟดิกเกอร์ · ธง: NoMarketSearch
- คลาสในโค้ด: `GoodQualityShovel` · สถานะการแกะ: แกะครบจากโค้ด

> เมื่อใช้สกิล[ขุดหลุมศพ]เป็นครั้งแรก
> จะได้รับสแต็ควิญญาณเพิ่ม
> 
> และถึงจะออกห่างจากสุสานไปเล็กน้อย
> สแต็ควิญญาณจะยังคงเพิ่มขึ้นต่อไป

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ค่าทั่วไป (`Value`): 6, 12, 18, 24, 30, 36, 42, 48, 53, 60 (Lv1…10)

### สกัลเชคเกอร์ (SkullShaker) · uid 1125

<img src="../../icons/sk_1125.png" width="40" alt="icon">

- ทรี: สกิลเนโครแมนเซอร์ (ขั้น 2) · เลเวลสูงสุด: 205 · อาวุธ: ไม้เท้า, ทวน · ต้องเรียนก่อน: ทูม · ธง: NoMarketSearch
- คลาสในโค้ด: `SkullShakerAction` · สถานะการแกะ: แกะครบจากโค้ด

> ใช้ไม้เท้าฟาดเข้าที่กลางศีรษะ
> สร้างความเสียหายทางกายภาพแก่เป้าหมาย
> มีโอกาสที่เป้าหมายจะ[ตาลาย]ยิ่งโจมตีโดนมาก
> พลังโจมตีและโอกาสทำให้[หมดสติ]จะยิ่งเพิ่มขึ้น
> ถ้าทำให้เป้าหมายหมดสติได้สำเร็จจะถูกรีเซ็ต

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `dizzyPercent`: `System.Math.Min(baseSTR // 5 + 5 × Lv, 100)` %
- โอกาสติดสถานะ `stunPercent`: `10 × MobBuffBase.GetValue()` %
- สถานะที่ทำให้ติด: มึนงง (Dizzy), สตัน (Stun)

<!-- calc:begin uid=1125 -->
#### การคำนวณแบบตัวเลข — SkullShaker (uid 1125)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `fixAddDamage` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `skillRate / 100` — โดยที่ `skillRate` = `(WeaponType = 14 ? int(7.5 × Lv) + 25 : int(7.5 × Lv)) × MobBuffBase.GetValue() + skillRate` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
<!-- calc:end -->

### บลัดสตีล (BloodSteel) · uid 1126

<img src="../../icons/sk_1126.png" width="40" alt="icon">

- ทรี: สกิลเนโครแมนเซอร์ (ขั้น 2) · เลเวลสูงสุด: 205 · อาวุธ: ไม้เท้า · ต้องเรียนก่อน: แฟนทอมมิสไซล์ · ธง: NoMarketSearch
- คลาสในโค้ด: `BloodSteelAction` · สถานะการแกะ: แกะครบจากโค้ด

> เนโครแมนซีที่ทำให้เกิดคำสาปดูดเลือด
> ดูดซับความเสียหายที่สร้างให้เป้าหมายบางส่วนกลับมาเป็น HP
> ระวังว่ามีโอกาศที่จะดูดซับสภาวะผิดปกติมาด้วย
> เพิ่มโอกาสที่จะทำให้เป้าหมาย[ผงะ]เมื่อ VIT เกิน 50
> คำสาปจะถูกยกเลิกทันทีเมื่อโจมตีจากระยะไกล

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, ทำให้ติดสถานะผิดปกติ, เปลี่ยนรูปแบบการโจมตี (อนุมานจาก hook ของบัพ), เปลี่ยนการทำงานของตีปกติ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: ผงะ (Flinch)
- บัพ `BloodSteelBuf` ระยะเวลา 12×Lv → 12, 24, 36, 48, 60, 72, 84, 96, 108, 120 (Lv1…10) วินาที
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `EnemyMobActionManagerBase.SetHyperModeStatus` — EnemyMobActionManagerBase.SetHyperModeStatus: [call] `BloodSteelBuf$$ChangeHyperMode` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.BloodSteel), UnityEngine…` เมื่อ (UnityEngine.Object.op_Inequality(hyperModeManager, 0) & 1) ne 0 AND (SkillBufferManager.TryGetBuf(PlayerStatusBase.get… (นิยามเต็มในแท็บ Variables)

### ซัมมอนสเกเลตัน (SummonSkeleton) · uid 1127

<img src="../../icons/sk_1127.png" width="40" alt="icon">

- ทรี: สกิลเนโครแมนเซอร์ (ขั้น 2) · เลเวลสูงสุด: 205 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: เกรฟดิกเกอร์ · ธง: NoMarketSearch
- คลาสในโค้ด: `SummonSkeletonAction` · สถานะการแกะ: แกะครบจากโค้ด

> ใช้สแต็ควิญญาณx3เพื่อเรียกอัศวินโครงกระดูก
> (ไม่เกินครั้งละ 3 ตัว)
> อัศวินโครงกระดูกจะโจมตีระยะประชิด
> และจะระเบิดหายไปเมื่อมีการโจมตีโดยรอบ
> พลังโจมตีถูกกำหนดโดย ATK หรือ MATK ที่สูงกว่า

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องตีปกติ · ไม่เปลี่ยนค่า proration
- ตัวอ่านสกิลนี้ `GlaiveTiggerBuf..ctor` — .ctor (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.HarvestSummonSkeleton` — PlayerBattleManager.HarvestSummonSkeleton (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.StartSummonSkeletonBomb` — PlayerBattleManager.StartSummonSkeletonBomb (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=1127 -->
#### การคำนวณแบบตัวเลข — SummonSkeleton (uid 1127)
Proration: ช่อง `Normal` โหมด `never (IsExpDefFluctuate=false)`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(10×Lv)%** → 10%, 20%, 30%, 40%, 50%, 60%, 70%, 80%, 90%, 100% (Lv1…10)
<!-- calc:end -->

### ฮาร์เวสต์ (Harvest) · uid 1128

<img src="../../icons/sk_1128.png" width="40" alt="icon">

- ทรี: สกิลเนโครแมนเซอร์ (ขั้น 2) · เลเวลสูงสุด: 205 · อาวุธ: ไม้เท้า · ต้องเรียนก่อน: พลั่วชั้นดี · ธง: NoMarketSearch
- คลาสในโค้ด: `Harvest` · สถานะการแกะ: แกะครบจากโค้ด

> ฟื้นฟู HP และ MP เล็กน้อยทันทีเมื่อกำจัดมอนสเตอร์
> (เปิดใช้งานหนึ่งครั้งต่อวินาที)
> 
> ถ้าเรียนรู้สกิล[ซัมมอนสเกลตัน]แล้ว
> จะเรียกอัศวินโครงกระดูกออกมาเมื่อฟื้นฟู
> (จำนวนไม่เกินขีดจำกัดสูงสุด)

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ

### เดนเจอร์เชค (DengerShake) · uid 1129

<img src="../../icons/sk_1129.png" width="40" alt="icon">

- ทรี: สกิลเนโครแมนเซอร์ (ขั้น 3) · เลเวลสูงสุด: 260 · อาวุธ: ไม้เท้า, ทวน · ต้องเรียนก่อน: สกัลเชคเกอร์ · ธง: NoMarketSearch
- คลาสในโค้ด: `DengerShakeAction` · สถานะการแกะ: แกะครบจากโค้ด

> เทคนิคการใช้พลองที่ปรับเปลี่ยนได้ตามสถานการณ์
> โจมตีทางกายภาพเพิ่มเติมได้โดยการกดคีย์ ใช้เพิ่มอีก 100 MP
> ข้างหน้า (พลังสูง), ซ้ายขวา (ลดความเสียหาย), ข้างหลัง (แบ็คสเต็ป)

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `DengerShakeBuf`: ความเร็วท่าทาง + (`MotionSpeed`) = 50
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `PlayerAttackBase.RemoveAfterSkillBuf` — PlayerAttackBase.RemoveAfterSkillBuf: [set] `_motionSpeed` = `SkillBufferDataBase.GetParam(0)` เมื่อ (PlayerAttackBase.ContainsNotApplicableSkill(PlayerAttackBase.get_ActionID()) & 1) eq 0 AND (SkillBufferManager.TryGetB…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.DengerShake` เมื่อ (PlayerAttackBase.ContainsNotApplicableSkill(PlayerAttackBase.get_ActionID()) & 1) eq 0 AND (SkillBufferManager.TryGetB…; [set] `appliedQuicklyMotionSpeedValue` = `255` เมื่อ (PlayerAttackBase.ContainsNotApplicableSkill(PlayerAttackBase.get_ActionID()) & 1) eq 0 AND (SkillBufferManager.TryGetB… (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=1129 -->
#### การคำนวณแบบตัวเลข — DengerShake (uid 1129)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `ช่อง [0] ของอาร์เรย์ต่อฮิต`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`skillRate.Length ≠ 0`]: `(skillRate[0] / 100)` — โดยที่ `skillRate[0]` = `baseSTR ÷ 2 + 750` [`skillRate.Length ≤ 1` และ `skillRate.Length ≠ 0` หรือ `skillRate.Length > 1` และ `skillRate.Length ≤ 2` และ `skillRate.Length ≠ 0` หรือ `skillRate.Length = 3` และ `skillRate.Length > 1` และ `skillRate.Length > 2` และ `skillRate.Length ≠ 0`] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**ใช้ร่วมทุกฮิตของ ดาเมจหลัก**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`skillRate.Length ≠ 0` หรือ `attackDir lo skillRate.Length`]: **100** → 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance())` และ `IsOtherPlayer = 0` และ `PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100)` และ `param = 100` และ …]: `(skillRate[(1)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance())` และ `IsOtherPlayer = 0` และ `PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100)` และ `param = 100` และ …]: `(skillRate[(2)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance())` และ `IsOtherPlayer = 0` และ `PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100)` และ `param = 100` และ …]: `(skillRate[(3)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance())` และ `IsOtherPlayer = 0` และ `PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100)` และ `param = 100` และ …]: `(skillRate[(0)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`skillRate.Length ≠ 0` หรือ `attackDir lo skillRate.Length`]: `target.ExpDefSkill / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefSkill` = proration ช่อง Skill ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`skillRate.Length ≠ 0` หรือ `attackDir lo skillRate.Length`]: `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_CharacterActionManagerBase` = ค่า Character Action Manager Base ของ MobActionManagerBase (ดูแท็บ Variables)
<!-- calc:end -->

### โซลสตรีม (SoulStream) · uid 1130

<img src="../../icons/sk_1130.png" width="40" alt="icon">

- ทรี: สกิลเนโครแมนเซอร์ (ขั้น 3) · เลเวลสูงสุด: 260 · อาวุธ: ไม้เท้า · ต้องเรียนก่อน: บลัดสตีล · ธง: NoMarketSearch
- คลาสในโค้ด: `SoulStreamAction` · สถานะการแกะ: แกะครบจากโค้ด

> เนโครแมนซีที่ยิงปืนใหญ่อนุภาควิญญาณ
> โจมตีเป้าหมายด้วยเวทมนตร์  อัตราทำให้[เฉื่อยชา]
> เพิ่มขึ้นตามสแต็ควิญญาณที่ใช้ไปพร้อมกับฟื้นฟู MP
> สแต็ควิญญาณที่ใช้จะขึ้นอยู่กับจำนวน
> MP ที่ใช้ไปในขณะที่ร่าย(สูงสุด 20 )

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ, วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: อ่อนแอ (Weak)

<!-- calc:begin uid=1130 -->
#### การคำนวณแบบตัวเลข — SoulStream (uid 1130)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **450 + 45×Lv** → 495, 540, 585, 630, 675, 720, 765, 810, 855, 900 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate`]: `(100 × Lv + baseINT) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseINT` = แต้ม INT ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseINT (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`(max((status.MaxMp - (PlayerStatusBase.get_GameStatus().localExMp + PlayerStatusBase.get_GameStatus().localMp)), 0) // 100) gt TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121).Count` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121) ≠ 0`]: `skillRate / 100` — โดยที่ `skillRate` = `100 × Lv + baseINT` หรือ `((TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121).Count * 75) + skillRate)` [`(max((status.MaxMp - (PlayerStatusBase.get_GameStatus().localExMp + PlayerStatusBase.get_GameStatus().localMp)), 0) // 100) gt TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121).Count` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121) ≠ 0`] หรือ `(((max((MaxMpรวม - (PlayerStatusBase.get_GameStatus().localExMp + PlayerStatusBase.get_GameStatus().localMp)), 0) // 100) * 75) + skillRate)` [`(max((status.MaxMp - (PlayerStatusBase.get_GameStatus().localExMp + PlayerStatusBase.get_GameStatus().localMp)), 0) // 100) le TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121).Count` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121) ≠ 0`] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
<!-- calc:end -->

### ซัมมอนเดโมนิก (SummonDemonic) · uid 1131

<img src="../../icons/sk_1131.png" width="40" alt="icon">

- ทรี: สกิลเนโครแมนเซอร์ (ขั้น 3) · เลเวลสูงสุด: 260 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ซัมมอนสเกเลตัน · ธง: NoMarketSearch
- คลาสในโค้ด: `SummonDemonicAction` · สถานะการแกะ: แกะครบจากโค้ด

> ทำพันธสัญญากับปีศาจ
> ประสิทธิภาพจะเปลี่ยนไปตามปริมาณ MP ที่ใช้ทำสัญญา
> ปีศาจจะดูด HP ของผู้ร่ายเพื่อแลกกับการโจมตีในแต่ละครั้ง
> สามารถยุติสัญญากับปีศาจได้โดยการใช้สกิลนี้อีกครั้ง
> หากสถานการณ์เลวร้ายอาจเกิดการทรยศหักหลัง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- MP ที่ใช้ [มีบัพ 1131 SummonDemonic]: 0
- MP ที่ใช้ [ไม่มีบัพ 1131 SummonDemonic]: `max(min(PlayerAttackBase.CalcCostMp(this, playerAction), 2000), 100)`
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `SummonDemonicBuf`: HP สูงสุด % (`MaxHpUpRate`) = `maxHpRate` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `summonMp` (ตัวนับที่เปลี่ยนตามเหตุการณ์)
- ตัวอ่านสกิลนี้ `GameManager.ReceiveSummons` — GameManager.ReceiveSummons (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MainPlayer.PlayerDead` — MainPlayer.PlayerDead: [call] `SkillBufferManager$$RemoveBuffer` = `SkillBufferManager, SkillId.SummonDemonic` เมื่อ (AutoMemberManager.TryGetAutoMember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 15, Toram.Common.Archet… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PhotonListener.OnActionPartyChangeHateActor` — PhotonListener.OnActionPartyChangeHateActor: [call] `SummonDemonicAction$$ChangeHateManaged` = `PlayerDataManager.get_PlayerActionManager(PlayerDataManager.GetPlayerDataManager())` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.SummonDemonic) & 1) ne 0 AND mobL… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PhotonListener.OnActionPartyChangeHateMine` — PhotonListener.OnActionPartyChangeHateMine (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PhotonListener.OnActionRoomChangeHateActor` — PhotonListener.OnActionRoomChangeHateActor: [call] `SummonDemonicAction$$ChangeHateManaged` = `PlayerDataManager.get_PlayerActionManager(PlayerDataManager.GetPlayerDataManager())` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.SummonDemonic) & 1) ne 0 AND mobL… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PhotonListener.OnActionRoomChangeHateMine` — PhotonListener.OnActionRoomChangeHateMine (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.Damaged` — PlayerActionManager: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `ExSkillSummonDemonic$$CheckAbility` = `TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(playerDataManager), 1…` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(Pl…; [call] `PlayerGameStatus$$SetLocalHp` = `PlayerStatusBase.get_GameStatus(), 1, 0` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(Pl… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ReceiveSupportResult.OnActionPlayerSupport` — ReceiveSupportResult.OnActionPlayerSupport: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.SummonDemonic` เมื่อ skillId gt 709 AND skillId gt 1025 AND skillId gt 1039 AND skillId gt 1090 AND (skillId - 1091) hs 3 AND (skillId & 0xf… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ReceiveSupportResult.OnEventNpcSupport` — ReceiveSupportResult.OnEventNpcSupport (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ReceiveSupportResult.OnEventPlayerSupport` — ReceiveSupportResult.OnEventPlayerSupport (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SummonDemonicAI..ctor` — .ctor (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SummonDemonicAction.ChangeHateManaged` — SummonDemonicAction.ChangeHateManaged: [call] `SummonDemonicMember$$Remove` = `TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 1…` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.SummonDemonic) & 1) ne 0 AND Unit…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.SummonDemonic` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.SummonDemonic) & 1) ne 0 AND Unit… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SummonDemonicAction.IsFailure` — เงื่อนไข is failure (SummonDemonicAction): คืนค่า `PlayerAttackBase.IsFailure(this, status, missType)` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SummonDemonicAction.calcCostMp` — คำนวณ cost mp (SummonDemonicAction): [set] `mp` = `0` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.SummonDemonic) & 1) ne 0; [set] `costMp` = `0` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.SummonDemonic) & 1) ne 0; [set] `mp` = `((_t1874 // 100) * 100)` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.SummonDemonic) & 1) eq 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SummonDemonicActionManager.BattleReservSpecialAttack` — SummonDemonicActionManager.BattleReservSpecialAttack (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SummonDemonicActionManager.BattleReserveNormalAttack` — SummonDemonicActionManager.BattleReserveNormalAttack (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SummonDemonicAttackAction.ActionHit` — SummonDemonicAttackAction.ActionHit (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SummonDemonicAttackAction.OnInitialize` — SummonDemonicAttackAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `constantDamage` = `(_t1876 >> 1)` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.SummonDemonic, out) & 1) ne 0 AND TryG…; [set] `skillRate` = `((SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), S…` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.SummonDemonic, out) & 1) ne 0 AND TryG…; [set] `_motionSpeed` = `100` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.SummonDemonic, out) & 1) ne 0 AND TryG… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SummonDemonicSpecialAttack.ActionHit` — SummonDemonicSpecialAttack.ActionHit (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SummonDemonicSpecialAttack.OnInitialize` — SummonDemonicSpecialAttack: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `constantDamage` = `SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), Ski…` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.SummonDemonic, out) & 1) ne 0 AND TryG…; [set] `skillRate` = `(int((SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(…` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.SummonDemonic, out) & 1) ne 0 AND TryG…; [set] `_motionSpeed` = `100` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.SummonDemonic, out) & 1) ne 0 AND TryG… (นิยามเต็มในแท็บ Variables)

### แผนตลบหลัง (MatchPump) · uid 1132

<img src="../../icons/sk_1132.png" width="40" alt="icon">

- ทรี: สกิลเนโครแมนเซอร์ (ขั้น 3) · เลเวลสูงสุด: 260 · อาวุธ: ไม้เท้า · ต้องเรียนก่อน: ฮาร์เวสต์ · ธง: NoMarketSearch
- คลาสในโค้ด: `MatchPump` · สถานะการแกะ: แกะครบจากโค้ด

> อัศวินโครงกระดูกที่ระเบิดหายไปแล้ว
> ก็มีโอกาสได้รับผลของสกิล[ฮาร์เวสต์ ]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ

