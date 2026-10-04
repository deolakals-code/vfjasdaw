# สกิลพาร์ทิซาน (`PartisanSkill`) — คำอธิบายทีละสกิล (ภาษาไทย)

สร้างอัตโนมัติด้วย `scripts/render_explained_th.py` จาก `skill_reference.json` (ข้อมูลโค้ด client ชุดล่าสุด) ไม่มีข้อความเขียนมือ แก้ไฟล์นี้ตรง ๆ จะถูกเขียนทับ ตัวเลขทั้งหมดคำนวณจากโค้ด (Code) ความหมายของชื่อ field/บทบาทแปลจากชื่อในโค้ด (Inferred) ยังไม่ได้เทียบกับตัวเลขในเกม ข้อมูลดิบทุกเส้นทางอยู่ใน `../details/PartisanSkill.md`

---

<!-- calc:preface -->
> **วิธีอ่านหัวข้อ "การคำนวณแบบตัวเลข"** (สร้างอัตโนมัติด้วย `scripts/render_calc_th.py` จาก `skill_reference.json` แก้มือจะถูกเขียนทับ)
> ดาเมจต่อฮิตเดินตามขั้น `SkillCalcTemplate/CalcStep` 0→40 ตามลำดับ (Code: `SkillCalcTemplate.GetDamage`) ขั้น `+` บวกเข้าดาเมจ ขั้น `×` คูณแล้วปัดเศษทิ้ง (int) ทันทีทุกขั้น
> ลำดับหลัก: ดาเมจฐาน(7) + คงที่สกิล(8) + คงที่บัพ(9) − ป้องกันเป้า(10) + ตีแรก(11) → ×คริ(13) → ×ธาตุ(15) → ×ตัวคูณสกิล(18) → ×ตีแรก(19) → ×เสถียร(21) → +คงที่ออโต้(22) → ×Proration(23) → ×ประเภท(24) → ×ดาเมจสุดท้าย(25) → … → เพดาน/ขั้นต่ำ(35–37)
> "ฮิต N" = template ดาเมจแต่ละก้อน (ทอยคริแยกกัน) แยกตามเมธอดและตัวแปรฮิตในโค้ด (`type`, `isFirst`, `attackCount` …) ชื่อฮิต/ส่วนมาจากชื่อในโค้ด (Inferred) ตัวเลขคำนวณจากโค้ด (Code) โดยตั้งเจม/บัพเสริม = 0
> ค่าหลายก้อนในขั้นเดียวกันแบบ "บวกเข้าช่อง" จะบวกกันก่อนคูณ ส่วน "ตั้งค่าทับ" แทนที่ค่าเดิม ค่าที่ขึ้นกับสเตตัสแสดงเป็นตัวอย่างที่ 100 / 255 (และ Lv สกิลอื่น 1 / 10) ใช้สูตรที่แนบไว้คำนวณค่าอื่นเอง
<!-- calc:preface-end -->

### Lบูมเมอแรง / เลเพจบูมเมอแรง (L_Boomerang) · uid 673

<img src="../../icons/sk_673.png" width="40" alt="icon">

- ทรี: สกิลพาร์ทิซาน (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: ดาบสองมือ · ธง: NoMarketSearch
- คลาสในโค้ด: `L_BoomerangAction` · สถานะการแกะ: แกะครบจากโค้ด

> ขว้างดาบบูมเมอแรงของเลเพจ
> โจมตีเฉพาะเป้าหมายเท่านั้น
> เมื่อไปถึงระยะหนึ่งจะย้อนกลับมา
> และมีโอกาสโจมตีเป้าหมายอีกครั้ง
> สกิลนี้จะไม่สร้างความเสียหายหากไม่มีบูมเมอแรง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: ธรรมดา (SkillNormal)
- Proration: ช่องตีปกติ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `BoomerangBuf`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `L_Boomerang2Action.ActionPreparation` — L_Boomerang2Action: ขั้นเตรียมก่อนปล่อยสกิล: [call] `SkillBufferManager$$RemoveBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.L_Boomerang` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBuf…; [set] `<SkillIndividualFlag>k__BackingField` = `1` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBuf… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `L_Boomerang2Action.OnInitialize` — L_Boomerang2Action: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `skillRate` = `(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.L_Boomerang, 1) *…` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.L_Boomerang, 1) ge 1 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `L_Boomerang3Action.ActionPreparation` — L_Boomerang3Action: ขั้นเตรียมก่อนปล่อยสกิล: [call] `SkillBufferManager$$RemoveBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.L_Boomerang` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBuf…; [set] `isMpHeal` = `1` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBuf…; [set] `isPlace` = `1` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBuf… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `L_Boomerang3Action.OnInitialize` — L_Boomerang3Action: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `skillRate` = `(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.L_Boomerang, 1) *…` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.L_Boomerang, 1) ge 1; [set] `skillRate` = `(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.L_Boomerang2, 1) …` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.L_Boomerang2, 1) ge 1 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `L_BoomerangAction.ActionPreparation` — L_BoomerangAction: ขั้นเตรียมก่อนปล่อยสกิล: [call] `SkillBufferManager$$RemoveBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.L_Boomerang` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBuf…; [set] `<SkillIndividualFlag>k__BackingField` = `1` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBuf… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SkillBufferManager.UpdateBoomerangBuf` — SkillBufferManager.UpdateBoomerangBuf (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=673 -->
#### การคำนวณแบบตัวเลข — L_Boomerang (uid 673)
Proration: ช่อง `Normal` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **200** → 200, 200, 200, 200, 200, 200, 200, 200, 200, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 674 L_Boomerang2 ≥ 1` และ `Lv สกิล 675 L_Boomerang3 ≥ 1`]: `(25 × SkillManager.GetSkillLv(A, 675, 1) + 25 × SkillManager.GetSkillLv(A, 674, 1) + baseDEX + 25 × Lv + 600) / 100` · `A = PlayerStatusBase.get_SkillManager()` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `SkillManager.GetSkillLv` = เลเวลของสกิลที่ผู้เล่นเรียน; `PlayerStatusBase.get_SkillManager` = ค่า Skill Manager ของ PlayerStatusBase; `SkillId.L_Boomerang3` = LบูมเมอแรงIII เลเพจบูมเมอแรงIII; `SkillId.L_Boomerang2` = LบูมเมอแรงII เลเพจบูมเมอแรงII (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 674 L_Boomerang2 ≥ 1` และ `Lv สกิล 675 L_Boomerang3 < 1`]: `(25 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) + baseDEX + 25 × Lv + 400) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `SkillManager.GetSkillLv` = เลเวลของสกิลที่ผู้เล่นเรียน; `PlayerStatusBase.get_SkillManager` = ค่า Skill Manager ของ PlayerStatusBase; `SkillId.L_Boomerang2` = LบูมเมอแรงII เลเพจบูมเมอแรงII (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 674 L_Boomerang2 < 1` และ `Lv สกิล 675 L_Boomerang3 ≥ 1`]: `(25 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) + baseDEX + 25 × Lv + 400) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `SkillManager.GetSkillLv` = เลเวลของสกิลที่ผู้เล่นเรียน; `PlayerStatusBase.get_SkillManager` = ค่า Skill Manager ของ PlayerStatusBase; `SkillId.L_Boomerang3` = LบูมเมอแรงIII เลเพจบูมเมอแรงIII (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 674 L_Boomerang2 < 1` และ `Lv สกิล 675 L_Boomerang3 < 1`]: `(baseDEX + 25 × Lv + 200) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefNormal / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `localExpDefNormal` = proration ปัจจุบันของมอนในช่องตีปกติ (%, เริ่ม 100, ถูกบีบอยู่ระหว่าง ; `MobActionManagerBase.get_MobStatus` = ค่า Mob Status ของ MobActionManagerBase (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpList[mobAction] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
<!-- calc:end -->

### ฮีลลิ่งช็อต (HealingShot) · uid 677

<img src="../../icons/sk_677.png" width="40" alt="icon">

- ทรี: สกิลพาร์ทิซาน (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: ธนู, โบว์กัน · ธง: NoMarketSearch
- คลาสในโค้ด: `HealingShotAction` · สถานะการแกะ: แกะครบจากโค้ด

> ใช้ HP ของตัวเอง (ขั้นต่ำ 100)
> เพื่อยิงลูกธนูฟื้นฟูตรงไปยัง
> สมาชิกปาร์ตี้ที่อยู่ไกลที่สุดปริมาณการฟื้นฟูจะแตกต่างกันไปสำหรับ
> ทหารรับจ้าง, พาร์ทเนอร์และสัตว์เลี้ยง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `SoulHuntBuf`: บัพนับสแตก (สืบจาก `CountBufferBase`): ตัวนับ `Count` เริ่ม 0 เพิ่มทีละ 1 ด้วย `Next()` และสูงสุด 10; โค้ดอื่นอ่านจำนวนสแตกผ่านพารามิเตอร์ `Count` (ดูค่าที่ใช้จริงในสูตรของสกิลที่อ้างถึง)
- บัพ `HealingShotBuf` ระยะเวลา `time` วินาที
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 10 ตามที่ `SoulHuntBuf` ส่งให้ตัวสร้างของ `บัพฐาน`

### ค้ำจุนแนวหน้า (MaintainingTheFront) · uid 680

<img src="../../icons/sk_680.png" width="40" alt="icon">

- ทรี: สกิลพาร์ทิซาน (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: NoMarketSearch
- คลาสในโค้ด: `MaintainingTheFrontAction` · สถานะการแกะ: แกะครบจากโค้ด

> ความมุ่งมั่นที่ตั้งใจจะไม่ถอยกลับ
> เพิ่มเฮทให้กับตัวเองและ
> ปริมาณเฮทจะเพิ่มขึ้นอีก 60 วินาที
> จะได้รับบาเรียอาวุธเพิ่มตาม
> จำนวนสมาชิกที่ไม่ใช่เป้าหมาย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `MaintainingTheFrontBuf`: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `100 × noTargetMemberNum × Lv` · ค่าเปอร์เซ็นต์ทั่วไป (`Percent`) = `100 × noTargetMemberNum × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 681, 1)` · ความเกลียดชัง % (`HateRate`) = 2×Lv → 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 (Lv1…10)
- ตัวอ่านสกิลนี้ `EquipMagicBarrierBuf.CheckTakeOver` — ตรวจ take over (EquipMagicBarrierBuf): คืนค่า `(_t321 gt 0 ? 1 : 0)` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EquipMagicBarrierBuf.GetBarrierValue` — EquipMagicBarrierBuf.GetBarrierValue: คืนค่า `_t323` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EquipPhysicalBarrierBuf.CheckTakeOver` — ตรวจ take over (EquipPhysicalBarrierBuf): คืนค่า `(_t327 gt 0 ? 1 : 0)` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EquipPhysicalBarrierBuf.GetBarrierValue` — EquipPhysicalBarrierBuf.GetBarrierValue: คืนค่า `_t328` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.StartRangeHateAttack` — PlayerBattleManager.StartRangeHateAttack: คืนค่า `1` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.GetDisplayBonusCalcHate` — PlayerSecondaryStatus.GetDisplayBonusCalcHate: คืนค่า `int(frintp((fcvt(((_t1651 + 1) * 100)) + -0.5)))` (2 กรณี) (นิยามเต็มในแท็บ Variables)

### LบูมเมอแรงII / เลเพจบูมเมอแรงII (L_Boomerang2) · uid 674

<img src="../../icons/sk_674.png" width="40" alt="icon">

- ทรี: สกิลพาร์ทิซาน (ขั้น 2) · เลเวลสูงสุด: 160 · อาวุธ: ดาบสองมือ · ต้องเรียนก่อน: [N]Lบูมเมอแรง[N2]เลเพจบูมเมอแรง[N] · ธง: NoMarketSearch
- คลาสในโค้ด: `L_Boomerang2Action` · สถานะการแกะ: แกะครบจากโค้ด

> ขว้างบูมเมอแรงขณะถอยหลังได้
> แต่พลังจะลดน้อยลง
> ถ้าไม่มีบูมเมอแรงจะทำได้แค่ถอยหลังเท่านั้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: ธรรมดา (SkillNormal)
- Proration: ช่องตีปกติ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- ตัวอ่านสกิลนี้ `L_Boomerang3Action.OnInitialize` — L_Boomerang3Action: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `skillRate` = `(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.L_Boomerang2, 1) …` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.L_Boomerang2, 1) ge 1 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `L_BoomerangAction.OnInitialize` — L_BoomerangAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `skillRate` = `(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.L_Boomerang2, 1) …` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.L_Boomerang2, 1) ge 1 (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=674 -->
#### การคำนวณแบบตัวเลข — L_Boomerang2 (uid 674)
Proration: ช่อง `Normal` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **100** → 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 673 L_Boomerang ≥ 1`]: `((25 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) + baseDEX + 25 × Lv + (A > 0 ? 25 × A + 200 : 0) + 400) ÷ 2) / 100` · `A = SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `SkillManager.GetSkillLv` = เลเวลของสกิลที่ผู้เล่นเรียน; `PlayerStatusBase.get_SkillManager` = ค่า Skill Manager ของ PlayerStatusBase; `SkillId.L_Boomerang` = Lบูมเมอแรง เลเพจบูมเมอแรง …(+1) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 673 L_Boomerang < 1`]: `((baseDEX + 25 × Lv + (A > 0 ? 25 × A + 200 : 0) + 200) ÷ 2) / 100` · `A = SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `SkillManager.GetSkillLv` = เลเวลของสกิลที่ผู้เล่นเรียน; `PlayerStatusBase.get_SkillManager` = ค่า Skill Manager ของ PlayerStatusBase; `SkillId.L_Boomerang3` = LบูมเมอแรงIII เลเพจบูมเมอแรงIII (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefNormal / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `localExpDefNormal` = proration ปัจจุบันของมอนในช่องตีปกติ (%, เริ่ม 100, ถูกบีบอยู่ระหว่าง ; `MobActionManagerBase.get_MobStatus` = ค่า Mob Status ของ MobActionManagerBase (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpList[mobAction] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `ActionStart`) [`isPlace` หรือ ไม่ `isPlace`]: `int((UnityEngine.Quaternion.Internal_MakePositive(0).y * 100))`
<!-- calc:end -->

### ลับคมลูกศร (ArrowSharpening) · uid 678

<img src="../../icons/sk_678.png" width="40" alt="icon">

- ทรี: สกิลพาร์ทิซาน (ขั้น 2) · เลเวลสูงสุด: 160 · อาวุธ: ธนู, โบว์กัน · ต้องเรียนก่อน: ฮีลลิ่งช็อต · ธง: NoMarketSearch
- คลาสในโค้ด: `ArrowSharpeningAction` · สถานะการแกะ: แกะครบจากโค้ด

> อัพเกรดการโจมตีปกติครั้งถัดไป
> 
> STR เพิ่มอาวุธเจาะเข้า
> AGI เพิ่มความเร็วการเคลื่อนที่
> DEX เพิ่มคริติคอลฮิต

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `ArrowSharpeningBuf`: เจาะกายภาพ (`PowerResistBreaker`) = `max(int(baseSTR / 50 × Lv), Lv)` · ดาเมจคริ % (`CrtDamageUpRate`) = `max(int(baseDEX / 25 × Lv), Lv)` · อัตราคริ % (`CrtUpRate`) = `max(int(baseDEX / 10 × Lv), Lv)` · ความเร็วท่าทาง + (`MotionSpeed`) = `max(int(baseAGI / 100 × Lv), Lv)`
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `MobaPlayerSecondaryStatus.GetCrtRate` — MobaPlayerSecondaryStatus.GetCrtRate: คืนค่า `((SkillBufferManager.TryGetBuf(MobaPlayerStatus.get_SkillBufferManager(), SkillId.ArrowSharpening, out) & 1) eq 0 ? _t1173 : (_t1173 + (SkillBufferDataBase.Get…` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerSecondaryStatus.GetMotionSpeed` — MobaPlayerSecondaryStatus.GetMotionSpeed: คืนค่า `(100 - _t518)` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerSecondaryStatus.get_CriticalDmg` — ค่า Critical Dmg ของ MobaPlayerSecondaryStatus: คืนค่า `_t609` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.CalcCriticalDmg` — คำนวณ critical dmg (PlayerSecondaryStatus): คืนค่า `(int((_t1571 * (((PlayerSecondaryStatus.get_Str(this) * 0.2) + max(((PlayerSecondaryStatus.get_Agi(this) - PlayerSecondaryStatus.get_Str(this)) * 0.1), 0)) + 1…` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.GetCalcMotionSpeed` — PlayerSecondaryStatus.GetCalcMotionSpeed: คืนค่า `_t1597` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.GetCrtRate` — PlayerSecondaryStatus.GetCrtRate: คืนค่า `((SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.ArrowSharpening, out) & 1) eq 0 ? _t1638 : (_t1638 + (SkillBufferDataBase.Get…` (นิยามเต็มในแท็บ Variables)

### ค้ำจุนแนวหน้าII (MaintainingTheFront2) · uid 681

<img src="../../icons/sk_681.png" width="40" alt="icon">

- ทรี: สกิลพาร์ทิซาน (ขั้น 2) · เลเวลสูงสุด: 160 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ค้ำจุนแนวหน้า · ธง: NoMarketSearch
- คลาสในโค้ด: `MaintainingTheFrontMastery` · สถานะการแกะ: แกะครบจากโค้ด

> เมื่อได้รับบาเรียอาวุธด้วยสกิล "ค้ำจุนแนวหน้า"
> จะได้รับบาเรียเวทด้วยและ HP สูงสุด
> จะเพิ่มขึ้นอย่างถาวรเมื่อเรียนรู้สกิล
> มีผลเป็นพาสซีฟ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ HP สูงสุด (`MaxHp`): 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 (Lv1…10)
- ตัวอ่านสกิลนี้ `MaintainingTheFrontBuf..ctor` — .ctor (นิยามเต็มในแท็บ Variables)

### LบูมเมอแรงIII / เลเพจบูมเมอแรงIII (L_Boomerang3) · uid 675

<img src="../../icons/sk_675.png" width="40" alt="icon">

- ทรี: สกิลพาร์ทิซาน (ขั้น 3) · เลเวลสูงสุด: 250 · อาวุธ: ดาบสองมือ · ต้องเรียนก่อน: [N]LบูมเมอแรงII[N2]เลเพจบูมเมอแรงII[N] · ธง: NoMarketSearch
- คลาสในโค้ด: `L_Boomerang3Action` · สถานะการแกะ: แกะครบจากโค้ด

> อัตราคริติคอลและอาวุธเจาะเข้าจะเพิ่มขึ้น
> บูมเมอแรงจะไล่ตามเป้าหมายมันจะกลับมา
> หลังจากไปได้ระยะหนึ่งหรือชนกับสิ่งกีดขวาง
> และมีโอกาสที่จะโจมตีเป้าหมายอีกครั้ง
> สกิลนี้จะไม่สร้างความเสียหายหากไม่มีบูมเมอแรง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: ธรรมดา (SkillNormal)
- Proration: ช่องตีปกติ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- ตัวอ่านสกิลนี้ `L_Boomerang2Action.OnInitialize` — L_Boomerang2Action: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `L_BoomerangAction.OnInitialize` — L_BoomerangAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `skillRate` = `(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.L_Boomerang3, 1) …` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.L_Boomerang3, 1) ge 1 (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=675 -->
#### การคำนวณแบบตัวเลข — L_Boomerang3 (uid 675)
Proration: ช่อง `Normal` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **400** → 400, 400, 400, 400, 400, 400, 400, 400, 400, 400 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 673 L_Boomerang ≥ 1` และ `Lv สกิล 674 L_Boomerang2 ≥ 1`]: `(25 × SkillManager.GetSkillLv(A, 674, 1) + 25 × SkillManager.GetSkillLv(A, 673, 1) + baseDEX + 25 × Lv + 600) / 100` · `A = PlayerStatusBase.get_SkillManager()` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `SkillManager.GetSkillLv` = เลเวลของสกิลที่ผู้เล่นเรียน; `PlayerStatusBase.get_SkillManager` = ค่า Skill Manager ของ PlayerStatusBase; `SkillId.L_Boomerang2` = LบูมเมอแรงII เลเพจบูมเมอแรงII; `SkillId.L_Boomerang` = Lบูมเมอแรง เลเพจบูมเมอแรง (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 673 L_Boomerang ≥ 1` และ `Lv สกิล 674 L_Boomerang2 < 1`]: `(25 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) + baseDEX + 25 × Lv + 400) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `SkillManager.GetSkillLv` = เลเวลของสกิลที่ผู้เล่นเรียน; `PlayerStatusBase.get_SkillManager` = ค่า Skill Manager ของ PlayerStatusBase; `SkillId.L_Boomerang` = Lบูมเมอแรง เลเพจบูมเมอแรง (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 673 L_Boomerang < 1` และ `Lv สกิล 674 L_Boomerang2 ≥ 1`]: `(25 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) + baseDEX + 25 × Lv + 400) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `SkillManager.GetSkillLv` = เลเวลของสกิลที่ผู้เล่นเรียน; `PlayerStatusBase.get_SkillManager` = ค่า Skill Manager ของ PlayerStatusBase; `SkillId.L_Boomerang2` = LบูมเมอแรงII เลเพจบูมเมอแรงII (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 673 L_Boomerang < 1` และ `Lv สกิล 674 L_Boomerang2 < 1`]: `(baseDEX + 25 × Lv + 200) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefNormal / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `localExpDefNormal` = proration ปัจจุบันของมอนในช่องตีปกติ (%, เริ่ม 100, ถูกบีบอยู่ระหว่าง ; `MobActionManagerBase.get_MobStatus` = ค่า Mob Status ของ MobActionManagerBase (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpList[mobAction] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
<!-- calc:end -->

### Nดราก้อนทูธ / นีโน่ดราก้อนทูธ (N_DragonTooth) · uid 676

<img src="../../icons/sk_676.png" width="40" alt="icon">

- ทรี: สกิลพาร์ทิซาน (ขั้น 3) · เลเวลสูงสุด: 250 · อาวุธ: ทวน · ธง: NoMarketSearch
- คลาสในโค้ด: `N_DragonToothAction` · สถานะการแกะ: แกะครบจากโค้ด

> ดราก้อนทูธที่คิดค้นโดยนีโน่
> โจมตีเป้าหมายและเคลื่อนที่ไปข้างหลัง
> เพิ่มพลังเจาะเข้าของสกิลที่ใช้ถัดไปเล็กน้อย
> เพิ่มพลังขึ้นอีกเมื่อเรียนสกิล"ดราก้อนทูธ"

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 2 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `N_DragonToothBuf`: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = 2×Lv → 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 (Lv1…10)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv9: หากใช้สกิลสำเร็จโดยไม่ได้รับความเสียหายจะฟื้นฟู MP เล็กน้อย ปริมาณการฟื้นฟู MP จะเพิ่มขึ้นตามระยะถอยห่างด้วยการกดปุ่ม และขึ้นอยู่กับเลเวลที่เรียนรู้ของสกิลดราก้อนทูธ

<!-- calc:begin uid=676 -->
#### การคำนวณแบบตัวเลข — N_DragonTooth (uid 676)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcFirstDamage` · ส่วน ครั้งแรก (`first…`)**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(75×Lv)%** → 75%, 150%, 225%, 300%, 375%, 450%, 525%, 600%, 675%, 750% (Lv1…10)

**ฮิต 2: `calcSecondDamage` · ส่วน ครั้งที่ 2 (`second…`)**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [Lv สกิล 972 DragonTooth=1]: **75%** → 75%, 75%, 75%, 75%, 75%, 75%, 75%, 75%, 75%, 75% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [Lv สกิล 972 DragonTooth=10]: **750%** → 750%, 750%, 750%, 750%, 750%, 750%, 750%, 750%, 750%, 750% (Lv1…10)
<!-- calc:end -->

### สัญชาตญาณการอยู่รอด (SurvivalInstinct) · uid 679

<img src="../../icons/sk_679.png" width="40" alt="icon">

- ทรี: สกิลพาร์ทิซาน (ขั้น 3) · เลเวลสูงสุด: 250 · อาวุธ: ธนู, โบว์กัน · ต้องเรียนก่อน: ลับคมลูกศร · ธง: NoMarketSearch
- ไม่มีคลาสของตัวเอง ผลอยู่ในโค้ดที่อ่านสกิลนี้ (`no action class; effect applied in consumer code (see page)`)

> เมื่อสมาชิกปาร์ตี้ตาย HP สูงสุดและ
> อัตราส่วนการลดความเสียหายจะเพิ่มขึ้น
> *ไม่เปิดใช้งานในบางสถานการณ์

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, พาสซีฟ, ไม่มีคลาสแอ็กชันฝั่ง client
- บัพ `SurvivalInstinctBuf` ระยะเวลา 20 วินาที: HP สูงสุด + (`MaxHpUp`) = 500×Lv → 500, 1000, 1500, 2000, 2500, 3000, 3500, 4000, 4500, 5000 (Lv1…10) · HP สูงสุด % (`MaxHpUpRate`) = Lv → 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10) · ตัวคูณดาเมจที่ได้รับ (`RateDamageResist`) = 2, 5, 7, 10, 12, 15, 17, 20, 22, 25 (Lv1…10)
- ตัวอ่านสกิลนี้ `MobAttackBase.CalcLastDamage` — คำนวณ last damage (MobAttackBase): คืนค่า `((SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.ArkSaber, out) & 1) eq 0 ? ((_t983 & 1) eq 0 ? ((_t982 & 1) eq 0 ? _t997 : _t…` (นิยามเต็มในแท็บ Variables)

