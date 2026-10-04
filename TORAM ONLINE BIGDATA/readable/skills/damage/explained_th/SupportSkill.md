# สกิลสนับสนุน (`SupportSkill`) — คำอธิบายทีละสกิล (ภาษาไทย)

สร้างอัตโนมัติด้วย `scripts/render_explained_th.py` จาก `skill_reference.json` (ข้อมูลโค้ด client ชุดล่าสุด) ไม่มีข้อความเขียนมือ แก้ไฟล์นี้ตรง ๆ จะถูกเขียนทับ ตัวเลขทั้งหมดคำนวณจากโค้ด (Code) ความหมายของชื่อ field/บทบาทแปลจากชื่อในโค้ด (Inferred) ยังไม่ได้เทียบกับตัวเลขในเกม ข้อมูลดิบทุกเส้นทางอยู่ใน `../details/SupportSkill.md`

---

<!-- calc:preface -->
> **วิธีอ่านหัวข้อ "การคำนวณแบบตัวเลข"** (สร้างอัตโนมัติด้วย `scripts/render_calc_th.py` จาก `skill_reference.json` แก้มือจะถูกเขียนทับ)
> ดาเมจต่อฮิตเดินตามขั้น `SkillCalcTemplate/CalcStep` 0→40 ตามลำดับ (Code: `SkillCalcTemplate.GetDamage`) ขั้น `+` บวกเข้าดาเมจ ขั้น `×` คูณแล้วปัดเศษทิ้ง (int) ทันทีทุกขั้น
> ลำดับหลัก: ดาเมจฐาน(7) + คงที่สกิล(8) + คงที่บัพ(9) − ป้องกันเป้า(10) + ตีแรก(11) → ×คริ(13) → ×ธาตุ(15) → ×ตัวคูณสกิล(18) → ×ตีแรก(19) → ×เสถียร(21) → +คงที่ออโต้(22) → ×Proration(23) → ×ประเภท(24) → ×ดาเมจสุดท้าย(25) → … → เพดาน/ขั้นต่ำ(35–37)
> "ฮิต N" = template ดาเมจแต่ละก้อน (ทอยคริแยกกัน) แยกตามเมธอดและตัวแปรฮิตในโค้ด (`type`, `isFirst`, `attackCount` …) ชื่อฮิต/ส่วนมาจากชื่อในโค้ด (Inferred) ตัวเลขคำนวณจากโค้ด (Code) โดยตั้งเจม/บัพเสริม = 0
> ค่าหลายก้อนในขั้นเดียวกันแบบ "บวกเข้าช่อง" จะบวกกันก่อนคูณ ส่วน "ตั้งค่าทับ" แทนที่ค่าเดิม ค่าที่ขึ้นกับสเตตัสแสดงเป็นตัวอย่างที่ 100 / 255 (และ Lv สกิลอื่น 1 / 10) ใช้สูตรที่แนบไว้คำนวณค่าอื่นเอง
<!-- calc:preface-end -->

### ปฐมพยาบาล (FirstAidMastary) · uid 225

<img src="../../icons/sk_225.png" width="40" alt="icon">

- ทรี: สกิลสนับสนุน (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: StarGem
- คลาสในโค้ด: `FirstAidMastary` · สถานะการแกะ: แกะครบจากโค้ด

> ประสิทธิภาพของ[ปฐมพยาบาล]ในเมนูสนับสนุนเพิ่มขึ้น
> เวลาที่ใช้รอในการคืนชีพลดลงอย่างมาก

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ

### ไลฟ์รีคัฟเวอรี่ (LifeRecovery) · uid 226

<img src="../../icons/sk_226.png" width="40" alt="icon">

- ทรี: สกิลสนับสนุน (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: StarGem
- คลาสในโค้ด: `LifeRecoveryAction` · สถานะการแกะ: แกะครบจากโค้ด

> สร้างพื้นที่สำหรับฟื้นฟู HP อย่างต่อเนื่อง
> 
> DEF ของผู้ใช้จะลดลง
> และผลลัพธ์จะหมดไปเมื่อได้รับความเสียหาย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, สร้างพื้นที่ (วง/เพลง)
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `LifeRecoveryBuf`: ตัวคูณดาเมจที่ได้รับจากมอน (หมวดบัพ) (`MobLastDamageRateBuf`) = 200 − 10×Lv → 190, 180, 170, 160, 150, 140, 130, 120, 110, 100 (Lv1…10) · HP ฟื้นธรรมชาติ + (`HpRecoveryUp`) = `System.Math.Max(0, val) + 4 × Lv + 10`
- บัพ `CircleBufferBase` ระยะเวลา 900 วินาที [`(self & 1) ≠ 0`] / `time` วินาที [`(self & 1) = 0`]
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.CalcHpRecovery` — คำนวณ hp recovery (PlayerSecondaryStatus): คืนค่า `((_t1576 & 1) ne 0 ? 0 : (int((_t1577 * _t712)) + _t1578))` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.get_HpRecovery` — ค่า Hp Recovery ของ PlayerSecondaryStatus: คืนค่า `(SkillBufferDataBase.GetParam(15) + int(_t712))` (2 กรณี) (นิยามเต็มในแท็บ Variables)

### มานารีชาร์จ (ManaRecharge) · uid 227

<img src="../../icons/sk_227.png" width="40" alt="icon">

- ทรี: สกิลสนับสนุน (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: StarGem
- คลาสในโค้ด: `ManaRechargeAction` · สถานะการแกะ: แกะครบจากโค้ด

> สร้างพื้นที่สำหรับฟื้นฟู MP อย่างต่อเนื่อง
> 
> ATK ของผู้ใช้จะลดลง
> และผลลัพธ์ที่เกิดจะหมดไปเมื่อได้รับความเสียหาย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, สร้างพื้นที่ (วง/เพลง)
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `ManaRechargeBuf`: ลดดาเมจสุดท้ายที่ทำ % (`LastDmgDownRate`) = 47, 45, 42, 40, 37, 35, 32, 30, 27, 25 (Lv1…10) · MP ฟื้นธรรมชาติ + (`MpRecoveryUp`) = `int(1.5 × Lv) + int(0.1 × System.Math.Max(0, val)) + 10`
- บัพ `CircleBufferBase` ระยะเวลา 900 วินาที [`(self & 1) ≠ 0`] / `time` วินาที [`(self & 1) = 0`]
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.CalcMpRecovery` — คำนวณ mp recovery (PlayerSecondaryStatus): คืนค่า `(int((_t1585 * _t753)) + _t1586)` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.get_MpRecovery` — ค่า Mp Recovery ของ PlayerSecondaryStatus: คืนค่า `(SkillBufferDataBase.GetParam(17) + int(_t753))` (2 กรณี) (นิยามเต็มในแท็บ Variables)

### มินิฮีล (PetitHeal) · uid 228

<img src="../../icons/sk_228.png" width="40" alt="icon">

- ทรี: สกิลสนับสนุน (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: StarGem
- คลาสในโค้ด: `PutitHealAction` · สถานะการแกะ: แกะครบจากโค้ด

> ฟื้นฟู HP ให้เป้าหมายเล็กน้อย
> และจะช่วยลดเวลาคืนชีพให้สั้นลง
> เมื่อเป้าหมายอยู่ในระหว่างรอคืนชีพ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: ฟื้นฟู
- MP ที่ใช้ [`SkillIndividualFlag = 1`]: 0
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- ตัวอ่านสกิลนี้ `RecoveryAction.OnInitialize` — RecoveryAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [call] `SkillFactory$$CreateSkill` = `SkillId.PetitHeal`; [set] `hpHeal` = `((GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_G…` เมื่อ (SkillActionBase.op_Inequality(SkillFactory.CreateSkill(SkillId.PetitHeal), 0) & 1) ne 0 AND SkillManager.GetSkillLv(Pl…; [set] `<SkillIndividualFlag>k__BackingField` = `((GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_G…` เมื่อ (SkillActionBase.op_Inequality(SkillFactory.CreateSkill(SkillId.PetitHeal), 0) & 1) ne 0 AND SkillManager.GetSkillLv(Pl… (นิยามเต็มในแท็บ Variables)

### เบรฟออร่า (BraveAura) · uid 229

<img src="../../icons/sk_229.png" width="40" alt="icon">

- ทรี: สกิลสนับสนุน (ขั้น 2) · เลเวลสูงสุด: 30 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ไลฟ์รีคัฟเวอรี่
- คลาสในโค้ด: `BraveAuraAction` · สถานะการแกะ: แกะครบจากโค้ด

> สร้างพื้นที่เพิ่ม ATK กับประสิทธิภาพอาวุธ
> 
> อัตราความแม่นของผู้ใช้จะลดลง
> และผลลัพธ์จะหมดไปเมื่อได้รับความเสียหาย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, สร้างพื้นที่ (วง/เพลง)
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `BraveAuraBuf`: ดาเมจสุดท้ายที่ทำ % (`LastDmgUpRate`) = 2×Lv → 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 (Lv1…10) · ATK อาวุธ % (`EqAtkUpRate`) = 10 + 2×Lv → 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 (Lv1…10) · ความแม่น % (`HitRate`) = -73, -70, -68, -65, -63, -60, -58, -55, -53, -50 (Lv1…10)

### เมจิกบาเรีย (MagicBarrier) · uid 230

<img src="../../icons/sk_230.png" width="40" alt="icon">

- ทรี: สกิลสนับสนุน (ขั้น 2) · เลเวลสูงสุด: 30 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: มานารีชาร์จ
- คลาสในโค้ด: `MagicBarrierAction` · สถานะการแกะ: แกะครบจากโค้ด

> สร้างพื้นที่ DEF กับประสิทธิภาพของอุปกรณ์ป้องกัน
> 
> อัตราหลบหลีกของผู้ใช้จะลดลง
> และผลลัพธ์จะหมดไปเมื่อได้รับความเสียหาย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, สร้างพื้นที่ (วง/เพลง)
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `MagicBarrierBuf`: MDEF % (`MdefRate`) = 10 + 2×Lv → 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 (Lv1…10) · DEF % (`DefRate`) = 10 + 2×Lv → 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 (Lv1…10) · หลบ % (`FleeRate`) = -73, -70, -68, -65, -63, -60, -58, -55, -53, -50 (Lv1…10) · ตัวคูณดาเมจที่ได้รับจากมอน (หมวดซัพพอร์ต) (`MobLastDamageRateSupport`) = 2×Lv → 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 (Lv1…10)

### รีคัฟเวอรี่ (Recovery) · uid 231

<img src="../../icons/sk_231.png" width="40" alt="icon">

- ทรี: สกิลสนับสนุน (ขั้น 2) · เลเวลสูงสุด: 30 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: มินิฮีล
- คลาสในโค้ด: `RecoveryAction` · สถานะการแกะ: แกะครบจากโค้ด

> รักษาสภาวะผิดปกติให้เป้าหมาย 1 ชนิด
> ถ้าไม่มีสภาวะผิดปกติที่สามารถรักษาได้
> จะมีผลบัฟช่วยรักษาสภาวะผิดปกติได้ 1 ชนิดชั่วขณะ
> เมื่อรักษาสภาวะผิดปกติสำเร็จจะฟื้นฟู MP ของผู้ใช้ขึ้นเล็กน้อย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, ฟื้นฟู
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `RecoveryBuf`: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = 1, 4, 9, 16, 25, 36, 49, 64, 81, 100 (Lv1…10)
- ตัวอ่านสกิลนี้ `AspisSeoul.ReceiveSupportEvent` — AspisSeoul.ReceiveSupportEvent: [call] `RecoveryBuf$$CreateAspisSeoulBuf` = `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.AspisSeoul, 1), (sup…` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.AspisSeoul, 1) ge 1 AND (SkillBufferManager.Contai…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), RecoveryBuf.CreateAspisSeoulBuf(SkillManager.G…` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.AspisSeoul, 1) ge 1 AND (SkillBufferManager.Contai… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `AutoMemberActionManager.AddAbnormalState` — AutoMemberActionManager.AddAbnormalState: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Recovery` เมื่อ (force & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Recovery) & … (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MercenaryActionManager.AddAbnormalState` — MercenaryActionManager.AddAbnormalState: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Recovery` เมื่อ (force & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Recovery) & … (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `OtherPlayerActionManager.AddAbnormalState` — OtherPlayerActionManager.AddAbnormalState: [call] `AbnormalStateManager$$AddAbnormalState` = `abnormalStateManager, type, time, resist, localId, (force & 1), new System.Action<Abnorma…` เมื่อ IsPartyMember ne 0 AND (force & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Recovery` เมื่อ IsPartyMember ne 0 AND (force & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PetMemberActionManager.AddAbnormalState` — PetMemberActionManager.AddAbnormalState: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Recovery` เมื่อ (force & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Recovery) & … (นิยามเต็มในแท็บ Variables)

### ไฮไซเคิล (HighCycle) · uid 232

<img src="../../icons/sk_232.png" width="40" alt="icon">

- ทรี: สกิลสนับสนุน (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: เบรฟออร่า
- คลาสในโค้ด: `HighCycleAction` · สถานะการแกะ: แกะครบจากโค้ด

> สร้างพื้นที่ที่ทำให้ร่ายเวทและชาร์จได้เร็วขึ้น
> 
> การฟื้นฟู MP ของผู้ใช้จะลดลง
> และผลลัพธ์จะหมดไปเมื่อได้รับความเสียหาย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, สร้างพื้นที่ (วง/เพลง)
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `HighCycleBuf`: ความเร็วร่าย % (`CspdUpRate`) = 25×Lv → 25, 50, 75, 100, 125, 150, 175, 200, 225, 250 (Lv1…10) · MP ฟื้นธรรมชาติ + (`MpRecoveryUp`) = `50.5 - 2.5 × Lv = -inf ? 0x80000000 : int(-(50.5 - 2.5 × Lv))` · MP ฟื้นต่อการโจมตี % (`AttackMprecoveryUpRate`) = `90.5 - 1.5 × Lv = -inf ? 0x80000000 : int(-(90.5 - 1.5 × Lv))` · ความเร็วร่าย + (`CspdUp`) = 50 + 50×Lv → 100, 150, 200, 250, 300, 350, 400, 450, 500, 550 (Lv1…10)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.CalcMpRecovery` — คำนวณ mp recovery (PlayerSecondaryStatus): คืนค่า `(int((_t1585 * _t753)) + _t1586)` (2 กรณี) (นิยามเต็มในแท็บ Variables)

### อิมมูนิตี้ (DiseasetSeal) · uid 233

<img src="../../icons/sk_233.png" width="40" alt="icon">

- ทรี: สกิลสนับสนุน (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: เมจิกบาเรีย
- คลาสในโค้ด: `DiseasetSealAction` · สถานะการแกะ: แกะครบจากโค้ด

> สร้างพื้นที่ป้องกันสภาวะผิดปกติ
> 
> ความเร็วในการโจมตีของผู้ใช้จะลดลง
> และผลลัพธ์จะหมดไปเมื่อได้รับความเสียหาย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, สร้างพื้นที่ (วง/เพลง)
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `DiseasetSealBuf`: ต้านสถานะผิดปกติ (`AbnormalRegist`) = 20 + 3×Lv → 23, 26, 29, 32, 35, 38, 41, 44, 47, 50 (Lv1…10) · ความเร็วโจมตี % (`AspdRate`) = -1000 + 75×Lv → -925, -850, -775, -700, -625, -550, -475, -400, -325, -250 (Lv1…10)

### แซงจูรี่ (Sanctuary) · uid 234

<img src="../../icons/sk_234.png" width="40" alt="icon">

- ทรี: สกิลสนับสนุน (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: รีคัฟเวอรี่
- คลาสในโค้ด: `SanctuaryAction` · สถานะการแกะ: แกะครบจากโค้ด

> สร้างอาณาเขตศักดิ์สิทธิ์เพื่อปกป้องพวกพ้อง
> ผู้เล่นที่อยู่ในอาณาเขตศักดิ์สิทธิ์จะได้รับความเสียหายลดลง
> ปริมาณที่ลดลงจะขึ้นอยู่กับ HP สูงสุดของแต่ละคน
> และไม่สามารถลดได้หากความเสียหายนั้นรุนแรงเกินไป

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, วางวัตถุ/กับดัก/อัญเชิญ
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `SanctuaryBuf` ระยะเวลา 2 วินาที: ต้านเพดานดาเมจ (`LimitRegistDamage`) = 5, 6, 6, 7, 7, 8, 8, 9, 9, 10 (Lv1…10) · ตัวคูณดาเมจที่ได้รับจากมอน (หมวดเฉพาะ) (`MobLastDamageRateUnique`) = 30, 30, 30, 50, 50, 50, 70, 70, 70, 90 (Lv1…10)

<!-- calc:begin uid=234 -->
#### การคำนวณแบบตัวเลข — Sanctuary (uid 234)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `OnInitialize`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
<!-- calc:end -->

### ควิกโมชั่น (QuickMotion) · uid 235

<img src="../../icons/sk_235.png" width="40" alt="icon">

- ทรี: สกิลสนับสนุน (ขั้น 4) · เลเวลสูงสุด: 150 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ไฮไซเคิล
- คลาสในโค้ด: `QuickMotionAction` · สถานะการแกะ: แกะครบจากโค้ด

> สร้างพื้นที่เพิ่มความเร็วการโจมตี
> 
> MP ที่ใช้สำหรับสกิลของผู้ใช้จะลดลง
> และผลลัพธ์จะหมดไปเมื่อได้รับความเสียหาย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, สร้างพื้นที่ (วง/เพลง)
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `QuickMotionBuf`: ความเร็วโจมตี % (`AspdRate`) = 25×Lv → 25, 50, 75, 100, 125, 150, 175, 200, 225, 250 (Lv1…10) · ความเร็วโจมตี + (`Aspd`) = 100 + 100×Lv → 200, 300, 400, 500, 600, 700, 800, 900, 1000, 1100 (Lv1…10) · MP ฟื้นต่อการโจมตี % (`AttackMprecoveryUpRate`) = -100 + 3×Lv → -97, -94, -91, -88, -85, -82, -79, -76, -73, -70 (Lv1…10)

### ฟาสต์รีเอคชั่น (HighReaction) · uid 236

<img src="../../icons/sk_236.png" width="40" alt="icon">

- ทรี: สกิลสนับสนุน (ขั้น 4) · เลเวลสูงสุด: 150 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: อิมมูนิตี้
- คลาสในโค้ด: `HighReactionAction` · สถานะการแกะ: แกะครบจากโค้ด

> สร้างพื้นที่เพิ่มการฟื้นฟู Guard และ Avoid
> 
> ผู้ใช้จะร่ายเวทย์ได้ช้าลง
> และผลจะสิ้นสุดลงเมื่อได้รับความเสียหาย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, สร้างพื้นที่ (วง/เพลง)
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `HighReactionBuf`: อัตราการ์ด (`Guard`) = 10 + Lv → 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 (Lv1…10) · หลบ + (`AvoidUp`) = Lv → 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10) · ความเร็วร่าย % (`CspdUpRate`) = -1000 + 75×Lv → -925, -850, -775, -700, -625, -550, -475, -400, -325, -250 (Lv1…10)

### ฮีล (Heal) · uid 237

<img src="../../icons/sk_237.png" width="40" alt="icon">

- ทรี: สกิลสนับสนุน (ขั้น 4) · เลเวลสูงสุด: 150 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: แซงจูรี่
- คลาสในโค้ด: `HealAction` · สถานะการแกะ: แกะครบจากโค้ด

> ฟื้นฟู HP เป้าหมาย
> ถ้าใช้กับผู้เล่นที่ไม่สามารถต่อสู้ได้
> จะทำให้ฟื้นคืนชีพเร็วขึ้นเล็กน้อย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: ฟื้นฟู
- MP ที่ใช้: 300
- MP ที่ใช้ [`SkillIndividualFlag = 1`]: 0
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration

