# สกิลเมจิกเบลด (`MagicBladeSkill`) — คำอธิบายทีละสกิล (ภาษาไทย)

สร้างอัตโนมัติด้วย `scripts/render_explained_th.py` จาก `skill_reference.json` (ข้อมูลโค้ด client ชุดล่าสุด) ไม่มีข้อความเขียนมือ แก้ไฟล์นี้ตรง ๆ จะถูกเขียนทับ ตัวเลขทั้งหมดคำนวณจากโค้ด (Code) ความหมายของชื่อ field/บทบาทแปลจากชื่อในโค้ด (Inferred) ยังไม่ได้เทียบกับตัวเลขในเกม ข้อมูลดิบทุกเส้นทางอยู่ใน `../details/MagicBladeSkill.md`

---

<!-- calc:preface -->
> **วิธีอ่านหัวข้อ "การคำนวณแบบตัวเลข"** (สร้างอัตโนมัติด้วย `scripts/render_calc_th.py` จาก `skill_reference.json` แก้มือจะถูกเขียนทับ)
> ดาเมจต่อฮิตเดินตามขั้น `SkillCalcTemplate/CalcStep` 0→40 ตามลำดับ (Code: `SkillCalcTemplate.GetDamage`) ขั้น `+` บวกเข้าดาเมจ ขั้น `×` คูณแล้วปัดเศษทิ้ง (int) ทันทีทุกขั้น
> ลำดับหลัก: ดาเมจฐาน(7) + คงที่สกิล(8) + คงที่บัพ(9) − ป้องกันเป้า(10) + ตีแรก(11) → ×คริ(13) → ×ธาตุ(15) → ×ตัวคูณสกิล(18) → ×ตีแรก(19) → ×เสถียร(21) → +คงที่ออโต้(22) → ×Proration(23) → ×ประเภท(24) → ×ดาเมจสุดท้าย(25) → … → เพดาน/ขั้นต่ำ(35–37)
> "ฮิต N" = template ดาเมจแต่ละก้อน (ทอยคริแยกกัน) แยกตามเมธอดและตัวแปรฮิตในโค้ด (`type`, `isFirst`, `attackCount` …) ชื่อฮิต/ส่วนมาจากชื่อในโค้ด (Inferred) ตัวเลขคำนวณจากโค้ด (Code) โดยตั้งเจม/บัพเสริม = 0
> ค่าหลายก้อนในขั้นเดียวกันแบบ "บวกเข้าช่อง" จะบวกกันก่อนคูณ ส่วน "ตั้งค่าทับ" แทนที่ค่าเดิม ค่าที่ขึ้นกับสเตตัสแสดงเป็นตัวอย่างที่ 100 / 255 (และ Lv สกิลอื่น 1 / 10) ใช้สูตรที่แนบไว้คำนวณค่าอื่นเอง
<!-- calc:preface-end -->

### เมจิกวอริเออร์มาสเตอรี่ (KnowledgeOfMagicWarriorMastary) · uid 865

<img src="../../icons/sk_865.png" width="40" alt="icon">

- ทรี: สกิลเมจิกเบลด (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: SubMagictool · ธง: NoMarketSearch
- คลาสในโค้ด: `KnowledgeOfMagicWarriorMastary` · สถานะการแกะ: แกะครบจากโค้ด

> ลดการลดลงของ ATK เมื่อติดตั้งอุปกรณ์เวทมนตร์
> MATK และ CSPD เพิ่มขึ้นเล็กน้อย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ความเร็วร่าย % (`CspdRate`): `System.Math.Max(Lv - 5, 0) + Lv`
- พาสซีฟ ความเร็วร่าย + (`Cspd`): 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10)
- พาสซีฟ MATK (`Matk`): `System.Math.Max(Lv - 5, 0) + 2 × Lv`
- พาสซีฟ ATK % (`AtkRate`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: *ลดการลดลงของ ATK ลงอีก 5%

### อีเทอร์แฟลร์ (EtherFlare) · uid 866

<img src="../../icons/sk_866.png" width="40" alt="icon">

- ทรี: สกิลเมจิกเบลด (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: SubMagictool · ธง: NoMarketSearch, MercenaryCanUseSkill
- คลาสในโค้ด: `EtherFlareAction` · สถานะการแกะ: แกะครบจากโค้ด

> เวทมนตร์โจมตีแบบง่ายที่นักรบก็สามารถใช้ได้
> มีโอกาสติด'ไหม้ไฟ'หากสำเร็จจะฟื้นฟู MP โจมตี
> ได้ชั่วขณะ ถ้าตัวเองมีธาตุที่เป็นจุดอ่อน
> พลังของสกิลจะเพิ่มขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท; กายภาพเมื่อมีบัฟ 867 — เงื่อนไข: Magic: no buff 867 (conversion = 0); Physics: buff 867 active (conversion = 1)
- Proration: ช่องที่เลือกตอนร่าย (กายภาพ/เวท) · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: ไฟไหม้ (Ignition)
- บัพ `EtherFlareBuf` ระยะเวลา 20 วินาที [`(isGemCart & 1) ≠ 0`] / 10 วินาที [`(isGemCart & 1) = 0`]: MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = 5, 10, 10, 10, 10, 15, 15, 15, 15, 20 (Lv1…10)
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่

<!-- calc:begin uid=866 -->
#### การคำนวณแบบตัวเลข — EtherFlare (uid 866)
Proration: ช่อง `dynamic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`EtherFlareAction.get_AttackType() = 2` และ `SkillUtil.CheckWeakElemet(SkillUtil.GetWeakElement(target.Element), target.Element)` หรือ `EtherFlareAction.get_AttackType() ≠ 2` และ `SkillUtil.CheckWeakElemet(SkillUtil.GetWeakElement(target.Element), target.Element)`]: `2 × fixAddDamage` — โดยที่ `fixAddDamage` = `2 × fixAddDamage` [`EtherFlareAction.get_AttackType() = 2` และ `SkillUtil.CheckWeakElemet(SkillUtil.GetWeakElement(target.Element), target.Element)` หรือ `EtherFlareAction.get_AttackType() ≠ 2` และ `SkillUtil.CheckWeakElemet(SkillUtil.GetWeakElement(target.Element), target.Element)`] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`!SkillUtil.CheckWeakElemet(SkillUtil.GetWeakElement(target.Element), target.Element)` และ `EtherFlareAction.get_AttackType() = 2` หรือ `!SkillUtil.CheckWeakElemet(SkillUtil.GetWeakElement(target.Element), target.Element)` และ `EtherFlareAction.get_AttackType() ≠ 2`]: `fixAddDamage` — โดยที่ `fixAddDamage` = `2 × fixAddDamage` [`EtherFlareAction.get_AttackType() = 2` และ `SkillUtil.CheckWeakElemet(SkillUtil.GetWeakElement(target.Element), target.Element)` หรือ `EtherFlareAction.get_AttackType() ≠ 2` และ `SkillUtil.CheckWeakElemet(SkillUtil.GetWeakElement(target.Element), target.Element)`] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `skillRate / 100` — โดยที่ `skillRate` = `max(baseINT, baseSTR) + 250` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
<!-- calc:end -->

### เดรนบาเรีย (DrainBarrier) · uid 875

<img src="../../icons/sk_875.png" width="40" alt="icon">

- ทรี: สกิลเมจิกเบลด (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: อุปกรณ์เวท · ธง: NoMarketSearch
- คลาสในโค้ด: `DrainBarrierAction` · สถานะการแกะ: แกะครบจากโค้ด

> เทคนิคการป้องกันที่แปลงพลังเวทมนตร์ผ่านบาเรีย
> 
> ลดความเสียหายทางกายภาพ/เวทมนตร์
> ที่ได้รับระหว่างเปิดใช้และฟื้นฟู MP เล็กน้อย
> เมื่อความเสียหายทางเวทลดลงจะเพิ่มปริมาณการฟื้นฟู

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, บัพปาร์ตี้/ผู้อื่น
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `DrainBarrierBuf`: ลดดาเมจกายภาพที่ได้รับ (`PowerDmgCut`) = 9×Lv → 9, 18, 27, 36, 45, 54, 63, 72, 81, 90 (Lv1…10) · ลดดาเมจเวทที่ได้รับ (`MagicDmgCut`) = 9×Lv → 9, 18, 27, 36, 45, 54, 63, 72, 81, 90 (Lv1…10)
- บัพ `EnchantedBurstBuf`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `flag` = `(flag & 0xfffff7ff)`
- บัพ `DrainRecallBuf` ระยะเวลา 2×Lv → 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 (Lv1…10) วินาที: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `mainWeapon = 14 ? A ÷ 2 : A`
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่

### คอนเวอร์ชั่น (Conversion) · uid 867

<img src="../../icons/sk_867.png" width="40" alt="icon">

- ทรี: สกิลเมจิกเบลด (ขั้น 2) · เลเวลสูงสุด: 60 · อาวุธ: ดาบมือเดียว, ดาบสองมือ, โบว์กัน, สนับมือ · ต้องเรียนก่อน: เมจิกวอริเออร์มาสเตอรี่ · ธง: NoMarketSearch
- คลาสในโค้ด: `ConversionAction` · สถานะการแกะ: แกะครบจากโค้ด

> เมื่อติดตั้งดาบมือเดียว, ดาบสองมือ, โบว์กัน, สนับมือ
> ATK ของอาวุธจะเพิ่มไปที่ MATK
> เหมือนไม้เท้าและอุปกรณ์เวทมนตร์

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, พาสซีฟ
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `ConversionBuf`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `ConversionAction.ActionHit` — ConversionAction.ActionHit: [call] `SkillBufferManager$$RemoveBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Conversion` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new ConversionBuf, Id` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ElementSlashAction.OnInitialize` — ElementSlashAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `conversion` = `(SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Con…` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EnchantedBurstAction.OnInitialize` — EnchantedBurstAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `conversion` = `(SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Con…` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EnchantedSwordAction.OnInitialize` — EnchantedSwordAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `conversion` = `(SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Con…` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EquipItemData.WeaponTypeCalculatorBase.CalcMatk` — คำนวณ matk (WeaponTypeCalculatorBase): [call] `ConversionAction$$CheckApplicationConversion` = `EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.Conversion, 1) ge 1 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EtherFlareAction.OnInitialize` — EtherFlareAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `conversion` = `(SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Con…` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `UnionSwordAction.OnInitialize` — UnionSwordAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `conversion` = `(SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Con…` (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv15: [ผลนี้ใช้ได้เฉพาะกับดาบมือเดียว/โบว์กัน/สนับมือเท่านั้น]  สามารถเพิ่มสกิลไปที่ช็อตคัทเพื่อใช้งานได้ ระหว่างผลของคอนเวอชันธาตุอาวุธกับธาตุเวทมนตร์ เฉพาะสกิลเมจิกเบลดจะสลับกัน สามารถยกเลิกได้เมื่อใช้คอนเวอชันอีกครั้ง
- Lv16: *ปริมาณการสะท้อน ATK อาวุธที่มีต่อ MATK จะลดลงครึ่งหนึ่ง

### เอเลเม้นต์สแลช (ElementSlash) · uid 868

<img src="../../icons/sk_868.png" width="40" alt="icon">

- ทรี: สกิลเมจิกเบลด (ขั้น 2) · เลเวลสูงสุด: 60 · อาวุธ: SubMagictool · ต้องเรียนก่อน: อีเทอร์แฟลร์ · ธง: NoMarketSearch, MercenaryCanUseSkill
- คลาสในโค้ด: `ElementSlashAction` · สถานะการแกะ: แกะครบจากโค้ด

> ฟันศัตรูด้วยดาบเวทมนตร์
> มีโอกาสทำให้เป้าหมายติด[อ่อนแอ]
> 
> ระยะการโจมตีของสกิลนี้ขึ้นอยู่กับ
> อุปกรณ์เวทเสริมที่สวมใส่อยู่

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท; กายภาพเมื่อมีบัฟ 867 — เงื่อนไข: Magic: no buff 867 (conversion = 0); Physics: buff 867 active (conversion = 1)
- Proration: ช่องที่เลือกตอนร่าย (กายภาพ/เวท) · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: ล่มสลาย (Collapse)

<!-- calc:begin uid=868 -->
#### การคำนวณแบบตัวเลข — ElementSlash (uid 868)
Proration: ช่อง `dynamic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **50 + 15×Lv** → 65, 80, 95, 110, 125, 140, 155, 170, 185, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `skillRate / 100` — โดยที่ `skillRate` = `50 × Lv + max(baseSTR, baseINT) / 12.5 × Lv + 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
<!-- calc:end -->

### เทเลพอร์ต (Teleport) · uid 876

<img src="../../icons/sk_876.png" width="40" alt="icon">

- ทรี: สกิลเมจิกเบลด (ขั้น 2) · เลเวลสูงสุด: 60 · อาวุธ: อุปกรณ์เวท · ต้องเรียนก่อน: เดรนบาเรีย · ธง: NoMarketSearch
- คลาสในโค้ด: `TeleportAction` · สถานะการแกะ: แกะครบจากโค้ด

> เทคนิคการหลบหลีกโดยเปลี่ยนตำแหน่งแบบฉับพลัน
> 
> หากกดปุ่มไปในทิศทางใดขณะเทเลพอร์ต
> ก็จะเคลื่อนที่ไปในทิศทางนั้นทันที

**ทำงานยังไง (จากโค้ด):**
- บทบาท: แอ็กชันระบบ/อรรถประโยชน์
- MP ที่ใช้ [อาวุธหลัก ดาบมือเดียว]: `mp - 100` — โดยที่ `mp` = `mp - 100` [อาวุธหลัก ดาบมือเดียว]
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: *MP ที่ใช้-100

### เรโซแนนซ์ (Resonance) · uid 869

<img src="../../icons/sk_869.png" width="40" alt="icon">

- ทรี: สกิลเมจิกเบลด (ขั้น 3) · เลเวลสูงสุด: 120 · อาวุธ: SubMagictool · ต้องเรียนก่อน: คอนเวอร์ชั่น · ธง: NoMarketSearch
- คลาสในโค้ด: `ResonanceAction` · สถานะการแกะ: แกะครบจากโค้ด

> เสียงสะท้อนของพลังชีวิตและพลังเวทมนตร์
> เพิ่มสเตตัสด้วยการแรนดอมเป็นเวลา 30 วินาที
> และทำให้ค่า HPและ MP ในปัจจุบันมีความสมดุลกัน
> ไม่สามารถใช้ซ้อนทับกันได้
> จะใช้ไม่ได้ถ้า HP สูงสุดน้อยกว่า MP สูงสุด

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `ResonanceBuf` ระยะเวลา 30 วินาที: ATK + (`AtkUp`) = `int((2 × refine + 2 × lv) × resist)` · MATK + (`MatkUp`) = `int((2 × refine + 2 × lv) × resist)` · ความแม่น + (`HitUp`) = `hit` · ความเร็วโจมตี + (`Aspd`) = `int((50 × refine + 25 × Lv) × resist)` · ความเร็วร่าย + (`CspdUp`) = `int((50 × refine + 25 × Lv) × resist)` · อัตราคริ + (`CrtUp`) = `critical`

### เอนชานท์ซอร์ด / เอนชานท์บลาสซอร์ด (EnchantedSword) · uid 870

<img src="../../icons/sk_870.png" width="40" alt="icon">

- ทรี: สกิลเมจิกเบลด (ขั้น 3) · เลเวลสูงสุด: 120 · อาวุธ: ดาบมือเดียว, ดาบสองมือ, โบว์กัน, สนับมือ · ต้องเรียนก่อน: เอเลเม้นต์สแลช · ธง: NoMarketSearch, MercenaryCanUseSkill
- คลาสในโค้ด: `EnchantedSwordAction` · สถานะการแกะ: แกะครบจากโค้ด

> พลังธาตุกลายเป็นดาบแทงศัตรูโดยไม่เกี่ยวกับธาตุของตัวเอง
> โจมตีด้วยธาตุที่เป็นจุดอ่อนของศัตรูด้วยดาบมือเดียวหรือดาบสองมือ
> อัตราคริติคอลเวลาปกติ (กายภาพ) จะขึ้นอยู่กับ
> ประสิทธิภาพของอุปกรณ์เวทมนตร์
> และเวทเจาะเข้าจะเพิ่มขึ้นตอนใช้เวทมนตร์

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 7 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ; เวทเมื่อมีบัฟ 867 (กลับด้านกับ 866) — เงื่อนไข: Physics: no buff 867 (conversion = 0); Magic: buff 867 active (conversion = 1)
- Proration: ช่องที่เลือกตอนร่าย (กายภาพ/เวท) · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `EnchantedSwordBuf` ระยะเวลา Lv → 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10) วินาที

<!-- calc:begin uid=870 -->
#### การคำนวณแบบตัวเลข — EnchantedSword (uid 870)
Proration: ช่อง `dynamic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `attackCount ge 1`**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [อาวุธหลัก ดาบมือเดียว และ `EnchantedSwordAction.get_AttackType() = 2` และ `PlayerAttackBase.CheckSkillIndividualFlag(this, 1)` หรือ อาวุธหลัก ดาบมือเดียว และ `EnchantedSwordAction.get_AttackType() ≠ 2` และ `IsInstanceOf(PlayerStatusBase.get_BattleStatus(), PlayerSecondaryStatus) ≠ 1` และ `PlayerAttackBase.CheckSkillIndividualFlag(this, 1)`]: **300** → 300, 300, 300, 300, 300, 300, 300, 300, 300, 300 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบมือเดียว และ `EnchantedSwordAction.get_AttackType() = 2` และ `PlayerAttackBase.CheckSkillIndividualFlag(this, 1)` หรือ อาวุธหลัก ดาบมือเดียว และ `EnchantedSwordAction.get_AttackType() ≠ 2` และ `IsInstanceOf(PlayerStatusBase.get_BattleStatus(), PlayerSecondaryStatus) ≠ 1` และ `PlayerAttackBase.CheckSkillIndividualFlag(this, 1)`]: **(400 + 60×Lv)%** → 460%, 520%, 580%, 640%, 700%, 760%, 820%, 880%, 940%, 1000% (Lv1…10)

**ฮิต 2: `CalcDamage` (ดาเมจ (เมธอดเสริม))**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **300** → 300, 300, 300, 300, 300, 300, 300, 300, 300, 300 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(400 + 60×Lv)%** → 460%, 520%, 580%, 640%, 700%, 760%, 820%, 880%, 940%, 1000% (Lv1…10)
<!-- calc:end -->

### เดรนรีคอล (DrainRecall) · uid 877

<img src="../../icons/sk_877.png" width="40" alt="icon">

- ทรี: สกิลเมจิกเบลด (ขั้น 3) · เลเวลสูงสุด: 120 · อาวุธ: SubMagictool · ต้องเรียนก่อน: เทเลพอร์ต · ธง: NoMarketSearch
- คลาสในโค้ด: `DrainRecall` · สถานะการแกะ: แกะครบจากโค้ด

> เมื่อลดความเสียหายด้วยเดรนบาเรียสำเร็จ
> จะได้รับการฟื้นฟู MP อย่างต่อเนื่องเพิ่มเติม
> ปริมาณการฟื้นฟูจะเปลี่ยนตามค่าที่ได้รับจากเดรนบาเรีย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, พาสซีฟ
- บัพ `DrainRecallBuf` ระยะเวลา 2×Lv → 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 (Lv1…10) วินาที: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `mainWeapon = 14 ? A ÷ 2 : A`
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `DrainRecall.AddBuf` — DrainRecall.AddBuf: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new DrainRecallBuf, 0` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.DrainRecall, 1) ge 1 AND EquipItemData.get_SubWeap… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: *ปริมาณการฟื้นฟู MP-50%

### เอนชานท์สเปล (EnchantedSpell) · uid 871

<img src="../../icons/sk_871.png" width="40" alt="icon">

- ทรี: สกิลเมจิกเบลด (ขั้น 4) · เลเวลสูงสุด: 180 · อาวุธ: SubMagictool · ต้องเรียนก่อน: เรโซแนนซ์ · ธง: NoMarketSearch
- คลาสในโค้ด: `EnchantedSpell` · สถานะการแกะ: แกะครบจากโค้ด

> เวทมนตร์พิเศษที่ติดคาถาไว้กับอาวุธล่วงหน้า
> มีเวทมนตร์บางส่วนที่สามารถเปิดใช้งาน
> ร่วมกับการกระทำบางอย่างได้
> ระยะเวลาในการเปิดใช้งานจะขึ้นอยู่กับสกิลที่ใช้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, พาสซีฟ
- บัพ `EnchantedSpellBuf` ระยะเวลา `time` วินาที
- ตัวอ่านสกิลนี้ `PlayerAttackBase.CheckEnchantedSpellMpLessInvoke` — ตรวจ enchanted spell mp less invoke (PlayerAttackBase): [call] `SkillUtil$$CheckSkillEquipLimit` = `PlayerStatusBase.get_EquipItemData(), MasterSkillDataManager.GetSkillMaster(Singleton<Mas…` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.EnchantedSpell, 1) ge 1 AND IPlayerStatusCalculato…; [set] `<SkillParam>k__BackingField` = `(SkillParam | 2048)` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.EnchantedSpell, 1) ge 1 AND IPlayerStatusCalculato… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ReceiveSupportResult.OnEventPlayerSupport` — ReceiveSupportResult.OnEventPlayerSupport: [call] `SkillFactory$$CreateSkill` = `supportData.Value` เมื่อ (SkillUtil.CheckDanceSkill(skillId) & 1) ne 0 AND supportData.Value ne -1 AND skillId gt 833 AND skillId le 943 AND ski…; [call] `PlayerBattleManager$$StartEnchantedSpellSkill` = `PlayerDataManager.get_PlayerActionManager(PlayerDataManager.GetPlayerDataManager()).battl…` เมื่อ (SkillUtil.CheckDanceSkill(skillId) & 1) ne 0 AND supportData.Value ne -1 AND skillId gt 833 AND skillId le 943 AND ski…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new EnchantedSpellBuf, 0` เมื่อ (SkillUtil.CheckDanceSkill(skillId) & 1) ne 0 AND supportData.Value ne -1 AND skillId gt 833 AND skillId le 943 AND ski… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv15: [สกิลเวทมนตร์ที่อาจเปิดใช้งานอีกครั้ง]เวทมนตร์:แอร์โรว์ *เวทมนตร์:แอร์โรว์ *เวทมนตร์:แจฟลิน *เวทมนตร์:กำแพง *เวทมนตร์:แลนซ์ *เวทมนตร์:บลาส *ธาตุตอนใช้งานจะขึ้นอยู่กับอุปกรณ์เวทมนตร์ที่ติดตั้งอยู่

### เอนชานท์บลาส / เอนชานท์อกรา (EnchantedBurst) · uid 872

<img src="../../icons/sk_872.png" width="40" alt="icon">

- ทรี: สกิลเมจิกเบลด (ขั้น 4) · เลเวลสูงสุด: 180 · อาวุธ: ดาบสองมือ, SubMagictool · ต้องเรียนก่อน: [N]เอนชานท์ซอร์ด[N2]เอนชานท์บลาสซอร์ด[N] · ธง: NoMarketSearch
- คลาสในโค้ด: `EnchantedBurstAction` · สถานะการแกะ: แกะครบจากโค้ด

> พลังธาตุที่สะสมอยู่จะถูกปลดปล่อยออกมา
> พลังจะเพิ่มขึ้น(สูงสุด 3)และทำให้ติดสถานะ'อ่อนแอ'
> ถ้าเอนชานท์ซอร์ดโจมตีเข้าเป้า
> ยิ่งใช้พลังสะสมมากเท่าไรก็จะยิ่งได้รับ
> ผลของเอนชานท์ซอร์ดนานขึ้นเท่านั้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท; กายภาพเมื่อมีบัฟ 867 — เงื่อนไข: Magic: no buff 867 (conversion = 0); Physics: buff 867 active (conversion = 1)
- Proration: ช่องที่เลือกตอนร่าย (กายภาพ/เวท) · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: ล่มสลาย (Collapse)
- บัพ `EnchantedBurstBuf`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `flag` = `(flag & 0xfffff7ff)`
- บัพ `EnchantedBurstSwordBuf` ระยะเวลา `(stack & 255) × (stack & 255) × (Lv + 4)` วินาที
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `DrainBarrierAction.DamageFunction` — DrainBarrierAction.DamageFunction: [call] `EnchantedBurstAction$$AddLocalStack` = `PlayerActionManagerBase.get_PlayerStatus(), 875, TryGetBuf<object>.out2(PlayerStatusBase.…` เมื่อ (SkillActionBase.op_Equality(mobAttack, 0) & 1) eq 0 AND (SkillBufferManager.TryGetBuf<DrainBarrierBuf>(PlayerStatusBas…; [call] `SkillBufferManager$$AddBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new EnchantedBurstBuf, 0` เมื่อ responseData.AttackType ne 3 AND (SkillBufferManager.TryGetBuf<DrainBarrierBuf>(PlayerStatusBase.get_SkillBufferManager…; [call] `EnchantedBurstBuf$$AddStack` = `((SkillBufferManager.TryGetBuf<EnchantedBurstBuf>(PlayerStatusBase.get_SkillBufferManager…` เมื่อ responseData.AttackType ne 3 AND (SkillBufferManager.TryGetBuf<DrainBarrierBuf>(PlayerStatusBase.get_SkillBufferManager… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EnchantedBurstAction.AddLocalStack` — EnchantedBurstAction.AddLocalStack: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new EnchantedBurstBuf, 0` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Kakei) & 1) eq 0 AND (SkillBuffer… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EnchantedSwordAction.ActionHit` — EnchantedSwordAction.ActionHit: [set] `enchantedBurstStack` = `1` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManag…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.EnchantedBurst, SkillManager.GetSkillL…` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManag… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EnchantedSwordAction.ReceiveAttackResult` — EnchantedSwordAction.ReceiveAttackResult: [call] `EnchantedSwordAction$$CheckEnchantedBurst` = `PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager())` เมื่อ SkillManager.GetSkillLv(PlayerDataManager.get_SkillManager(PlayerDataManager.GetPlayerDataManager()), SkillId.Enchanted…; [call] `EnchantedBurstBuf$$AddStack` = `PlayerStatusBase.get_SkillBufferManager().skillBufList[SkillId.EnchantedBurst], 870, skil…` เมื่อ SkillManager.GetSkillLv(PlayerDataManager.get_SkillManager(PlayerDataManager.GetPlayerDataManager()), SkillId.Enchanted… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PhotonListener.OnActionMobAttack` — PhotonListener.OnActionMobAttack: [call] `EnchantedBurstBuf$$AddStack` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.EnchantedBurst), 875, To…` เมื่อ FieldManager.get_RoomType(Singleton<FieldManager>.get_Instance(game, returnCode, archetypeType)) ne 15 AND FieldManager… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv15: [ผลนี้ใช้ได้กับอุปกรณ์เวทย์มนตร์เสริมเท่านั้น]  หากธาตุอาวุธถูกเปลี่ยนด้วยผลของคอนเวอชัน จะเป็นการโจมตีทางกายภาพที่ไม่ใช้พลังสะสมและ จะมอบผลที่ทำให้เกิดการฟื้นฟู MP แก่ผู้เล่นที่โจมตีเป้าหมาย

<!-- calc:begin uid=872 -->
#### การคำนวณแบบตัวเลข — EnchantedBurst (uid 872)
Proration: ช่อง `dynamic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`((flag | EnchantedBurstAction.get_AttackType() eq 1 ? 1 : 0))` และ `EnchantedBurstAction.get_AttackType() ≠ 1` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 15` และ `GameManager.get_IsConnect(Singleton<GameManager>.get_Instance())` และ … หรือ `((flag | EnchantedBurstAction.get_AttackType() eq 1 ? 1 : 0))` และ `EnchantedBurstAction.get_AttackType() ≠ 1` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 15` และ `GameManager.get_IsConnect(Singleton<GameManager>.get_Instance())` และ … หรือ `((flag | !EnchantedBurstAction.get_AttackType() eq 1 ? 1 : 0))` และ `EnchantedBurstAction.get_AttackType() ≠ 1` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 15` และ `GameManager.get_IsConnect(Singleton<GameManager>.get_Instance())` และ …]: `((((int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function / 2.5)) lt 300 ? int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function / 2.5)) : 300) * EnchantedBurstBuf.GetPayStack(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 872))) + 100))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `EquipItemData.get_SubWeapon` = ค่า Sub Weapon ของ EquipItemData; `PlayerStatusBase.get_EquipItemData` = ค่า Equip Item Data ของ PlayerStatusBase; `EnchantedBurstBuf.GetPayStack` = EnchantedBurstBuf.GetPayStack; `PlayerStatusBase.get_SkillBufferManager` = ค่า Skill Buffer Manager ของ PlayerStatusBase (ดูแท็บ Variables)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`EnchantedBurstAction.get_AttackType() ≠ 1` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 15` และ `GameManager.get_IsConnect(Singleton<GameManager>.get_Instance())` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 872) = 0` หรือ `EnchantedBurstAction.get_AttackType() ≠ 1` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 15` และ `GameManager.get_IsConnect(Singleton<GameManager>.get_Instance())` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 872) ≠ 0` และ … หรือ `EnchantedBurstAction.get_AttackType() ≠ 1` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 15` และ `GameManager.get_IsConnect(Singleton<GameManager>.get_Instance())` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 872) ≠ 0` และ …]: `((((int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function / 2.5)) lt 300 ? int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function / 2.5)) : 300) * bufStack) + 100))` — โดยที่ `bufStack` = `EnchantedBurstBuf.GetPayStack(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 872))` [`((flag | EnchantedBurstAction.get_AttackType() eq 1 ? 1 : 0))` และ `EnchantedBurstAction.get_AttackType() = 1` และ `GameManager.get_IsConnect(Singleton<GameManager>.get_Instance())` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 872) ≠ 0` หรือ `((flag | EnchantedBurstAction.get_AttackType() eq 1 ? 1 : 0))` และ `EnchantedBurstAction.get_AttackType() ≠ 1` และ `GameManager.get_IsConnect(Singleton<GameManager>.get_Instance())` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 872) ≠ 0` หรือ `((flag | !EnchantedBurstAction.get_AttackType() eq 1 ? 1 : 0))` และ `EnchantedBurstAction.get_AttackType() = 1` และ `GameManager.get_IsConnect(Singleton<GameManager>.get_Instance())` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 872) ≠ 0` และ …] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `EquipItemData.get_SubWeapon` = ค่า Sub Weapon ของ EquipItemData; `PlayerStatusBase.get_EquipItemData` = ค่า Equip Item Data ของ PlayerStatusBase (ดูแท็บ Variables)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`EnchantedBurstAction.get_AttackType() = 1` และ `GameManager.get_IsConnect(Singleton<GameManager>.get_Instance())` หรือ `EnchantedBurstAction.get_AttackType() ≠ 1` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 15` และ `GameManager.get_IsConnect(Singleton<GameManager>.get_Instance())` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 872) = 0`]: **100** → 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(1000 + 50×Lv)%** → 1050%, 1100%, 1150%, 1200%, 1250%, 1300%, 1350%, 1400%, 1450%, 1500% (Lv1…10)
<!-- calc:end -->

### โฟรทแดช (FloatDash) · uid 878

<img src="../../icons/sk_878.png" width="40" alt="icon">

- ทรี: สกิลเมจิกเบลด (ขั้น 4) · เลเวลสูงสุด: 180 · อาวุธ: SubMagictool · ต้องเรียนก่อน: เดรนรีคอล · ธง: NoMarketSearch
- คลาสในโค้ด: `FloatDashAction` · สถานะการแกะ: แกะครบจากโค้ด

> ใช้อุปกรณ์เวทมนตร์ฉุกเฉินเพื่อบินด้วยความเร็วสูง 10 วินาที
> ความเร็วในการเคลื่อนที่จะเพิ่มขึ้นเป็นอย่างมาก
> แต่ไม่สามารถทำการโจมตีปกติได้อีก
> เมื่อเปิดใช้บางสกิลจะทำให้ผลสิ้นสุดลง
> และการใช้ MP ของสกิลที่เปิดใช้จะลดลงครึ่งหนึ่ง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `FloatDashBuf`: ความเร็วเคลื่อนที่ (`MoveSpeed`) = `moveSpeed` · หลบ + (`AvoidUp`) = `avoid` · หลบ + (`Flee`) = `flee`
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.NextSkillReserve` — MobaPlayerActionManager.NextSkillReserve (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.TargetMobBattleReserve` — MobaPlayerActionManager.TargetMobBattleReserve (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.get_MoveSpeed` — ค่า Move Speed ของ MobaPlayerActionManager: คืนค่า `_t1117` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerBattleManager.OnSkillActionEnd` — MobaPlayerBattleManager.OnSkillActionEnd: [call] `MobaPlayerActionManager$$SetNextSkill` = `actionManager, 0` เมื่อ (SkillActionBase.get_IsChatLog() & 1) eq 0 AND (SkillActionBase.get_IsSupport() & 1) ne 0 AND (BattleManagerBase.get_Is… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.Update` — PlayerActionManager.Update (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.get_MoveSpeed` — ค่า Move Speed ของ PlayerActionManager: คืนค่า `_t1348` (3 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.targetMobBattleReserve` — PlayerActionManager.targetMobBattleReserve (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.CalcCostMp` — MP ที่ใช้ของสกิล: [call] `InflexibilityBuf$$CheckMpHalving` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Inflexibility), this` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill…; [call] `MultipleHuntBuf$$CheckMode` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt), SkillMode…` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill…; [set] `<CostMpType>k__BackingField` = `(CostMpType | 1)` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.OnSkillActionEnd` — PlayerBattleManager.OnSkillActionEnd: [call] `PlayerActionManager$$SetNextSkill` = `actionManager, 0` เมื่อ (SkillActionBase.get_IsChatLog() & 1) eq 0 AND (SkillActionBase.get_IsSupport() & 1) ne 0 AND (BattleManagerBase.get_Is… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ShukuchiAction.CanActivated` — เงื่อนไข can activated (ShukuchiAction): [call] `ShukuchiAction$$CheckInBlackHole` = `UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(battle))` เมื่อ battle.IsDelay eq 0 AND (AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), AbnormalType.Stop)… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- LvNone: 10$0$*ลบภาวะผิดปกติ 'เชื่องช้า' 'หยุดนิ่ง' เมื่อเปิดใช้งาน

### ดูอัลบริงเกอร์ (DualBringer) · uid 873

<img src="../../icons/sk_873.png" width="40" alt="icon">

- ทรี: สกิลเมจิกเบลด (ขั้น 5) · เลเวลสูงสุด: 260 · อาวุธ: SubMagictool · ต้องเรียนก่อน: เอนชานท์สเปล · ธง: NoMarketSearch
- คลาสในโค้ด: `DualBringerAction` · สถานะการแกะ: แกะครบจากโค้ด

> ระยะเวลาของผลที่ได้ขึ้นอยู่กับ
> ประสิทธิภาพของอุปกรณ์เวทมนตร์
> ทำให้ ATK และ MATK อยู่ในสภาวะที่สูงขึ้น
> และเมื่อโจมตีเป้าหมายที่อ่อนแอจะได้รับโบนัสที่คริติคอลฮิต
> ผลของสกิลนี้มีไว้สำหรับสกิลเมจิกเบลดเท่านั้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `DualBringerBuf` ระยะเวลา `max((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function // 5), 10)` วินาที [`EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 15`] / `max(LeftTime, 10)` วินาที [`EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 15`]: ดาเมจคริเวท (`MagicCrtDamage`) = 2, 5, 7, 10, 12, 15, 17, 20, 22, 25 (Lv1…10)
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `DualBringerAction.TryGetElemntType` — DualBringerAction.TryGetElemntType: คืนค่า `1` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MagicBurstAction.ActionHit` — MagicBurstAction.ActionHit: [call] `EnchantedBurstAction$$AddLocalStack` = `PlayerActionManagerBase.get_PlayerStatus(), PlayerAttackBase.get_ActionID(), Id` เมื่อ enchantedBurstStack eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBufferManager.Contai… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MagicCannonAction.ActionHit` — MagicCannonAction.ActionHit: [call] `EnchantedBurstAction$$AddLocalStack` = `PlayerActionManagerBase.get_PlayerStatus(), PlayerAttackBase.get_ActionID(), Id` เมื่อ enchantedBurstStack eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBufferManager.Contai… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MagicFallAction.ActionHit` — MagicFallAction.ActionHit: [call] `EnchantedBurstAction$$AddLocalStack` = `PlayerActionManagerBase.get_PlayerStatus(), PlayerAttackBase.get_ActionID(), Id` เมื่อ enchantedBurstStack eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBufferManager.Contai… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MagicFinawAction.ActionHit` — MagicFinawAction.ActionHit: [call] `EnchantedBurstAction$$AddLocalStack` = `PlayerActionManagerBase.get_PlayerStatus(), PlayerAttackBase.get_ActionID(), Id` เมื่อ addHate eq 0 AND enchantedBurstStack eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBuf… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: *มีผลต่อสกิลเวทด้วยเช่นกัน *สกิลเวทที่จะมีธาตุตามอุปกรณ์เวทมนตร์ *เอนชานท์บลาสจะสะสมได้ด้วยสกิลเวทที่กำหนด
- Lv15: [ผลนี้ใช้ได้กับอุปกรณ์เวทย์มนตร์เสริมเท่านั้น]  ยิ่งเรียนรู้สกิลเมจิกเบลดมากเท่าไหร่ การขยายผลของสกิลนี้ก็จะยิ่งสูงขึ้น *สูงสุดไม่เกิน 10 สกิล

### ยูเนียนซอร์ด / รียูเนียนซอร์ด (UnionSword) · uid 874

<img src="../../icons/sk_874.png" width="40" alt="icon">

- ทรี: สกิลเมจิกเบลด (ขั้น 5) · เลเวลสูงสุด: 260 · อาวุธ: ดาบสองมือ, SubMagictool · ต้องเรียนก่อน: [N]เอนชานท์บลาส[N2]เอนชานท์อกรา[N] · ธง: NoMarketSearch
- คลาสในโค้ด: `UnionSwordAction` · สถานะการแกะ: แกะครบจากโค้ด

> กวัดแกว่งดาบยักษ์ที่สร้างขึ้นจากพลังเวทมนตร์
> โจมตีเป็นวงกว้างด้วยเทคนิคลับเป็นเส้นตรง
> ถ้าได้รับผลจากการเสริมความแข็งแกร่ง
> ด้วยเอนชานท์บลาสเวลาของเอฟเฟกต์นั้น
> จะถูกเผาผลาญไปเพื่อเปิดใช้งานอย่างรวดเร็ว

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ; เวทเมื่อมีบัฟ 867 (กลับด้านกับ 866) — เงื่อนไข: Physics: no buff 867 (conversion = 0); Magic: buff 867 active (conversion = 1)
- Proration: ช่องที่เลือกตอนร่าย (กายภาพ/เวท) · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: None (None)
- บัพ `UnionSwordBuf`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `MobAttackBase.CalcLastDamage` — คำนวณ last damage (MobAttackBase): คืนค่า `((SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.ArkSaber, out) & 1) eq 0 ? ((_t983 & 1) eq 0 ? ((_t982 & 1) eq 0 ? _t997 : _t…` (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=874 -->
#### การคำนวณแบบตัวเลข — UnionSword (uid 874)
Proration: ช่อง `dynamic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) · ส่วน ครั้งที่ 2 (`second…`), ครั้งแรก (`first…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`UnionSwordAction.get_AttackType() = 2` และ `isReUnionSword` หรือ `UnionSwordAction.get_AttackType() ≠ 2` และ `isReUnionSword` หรือ ไม่ `isReUnionSword`]: **500** → 500, 500, 500, 500, 500, 500, 500, 500, 500, 500 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`UnionSwordAction.get_AttackType() = 2` และ `isReUnionSword` หรือ `UnionSwordAction.get_AttackType() ≠ 2` และ `isReUnionSword`]: **(2000 + 100×Lv)%** → 2100%, 2200%, 2300%, 2400%, 2500%, 2600%, 2700%, 2800%, 2900%, 3000% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [ไม่ `isReUnionSword`]: **(1000 + 50×Lv)%** → 1050%, 1100%, 1150%, 1200%, 1250%, 1300%, 1350%, 1400%, 1450%, 1500% (Lv1…10)

**ใช้ร่วมทุกฮิตของ ฮิตรีแอ็กชัน (`HitReactionAssign`)**
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical)` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobBuffer.GuardUpBuff.get_GuardUpval` = ค่า Guard Upval ของ GuardUpBuff; `TryGetBuff.buff` = TryGetBuff.buff; `MobActionManagerBase.get_BuffManager` = ค่า Buff Manager ของ MobActionManagerBase (ดูแท็บ Variables)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) = 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: **25** → 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 (Lv1…10)
<!-- calc:end -->

### เมจิกสกิน (MagicSkin) · uid 879

<img src="../../icons/sk_879.png" width="40" alt="icon">

- ทรี: สกิลเมจิกเบลด (ขั้น 5) · เลเวลสูงสุด: 260 · อาวุธ: SubMagictool · ต้องเรียนก่อน: โฟรทแดช · ธง: NoMarketSearch
- คลาสในโค้ด: `MagicSkin` · สถานะการแกะ: แกะครบจากโค้ด

> ค่าถลุงของอุปกรณ์เวทมนตร์มีผลต่อ
> การลดความเสียหายเช่นเดียวกับค่าถลุงของโล่
> และยิ่งเหลือค่า MP มากเท่าไหร่ก็จะยิ่ง
> ลดความเสียหายทางกายภาพ/เวทมนตร์ได้มากขึ้นเท่านั้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, พาสซีฟ
- บัพ `MagicSkinBuf` ระยะเวลา 120 วินาที
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- พาสซีฟ ดาเมจสุดท้ายที่ได้รับจากมอน (`MobAttackLastDamageRate`): 25, 50, 75, 100, 125, 150, 175, 200, 225, 250 (Lv1…10)
- พาสซีฟ ค่าเปอร์เซ็นต์ (`Percent`): 1, 4, 9, 16, 25, 36, 49, 64, 81, 100 (Lv1…10)
- ตัวอ่านสกิลนี้ `EquipItemData.CalcEqDef` — คำนวณ eq def (EquipItemData): คืนค่า `((_t248 + ItemData.get_Refine(EquipItemData.get_Option(this))) + ItemData.get_Refine(EquipItemData.get_Body(this)))` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MagicSkin.DamageAdjustment` — MagicSkin.DamageAdjustment: [call] `SkillUtil$$CheckSkillEquipLimit` = `PlayerStatusBase.get_EquipItemData(), PlayerStatusBase.get_SkillManager().SkillMasteryLis…` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.MagicSkin) & 1) eq 0 AND (SkillBu…; [call] `MathUtil$$CheckPercent` = `SkillMasteryBase.GetMasteryParam(MasteryId.Percent)` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.MagicSkin) & 1) eq 0 AND (SkillBu…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new MagicSkinBuf, 0` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.MagicSkin) & 1) eq 0 AND (SkillBu… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MagicSkin.GetMobAttackLastDamageRate` — MagicSkin.GetMobAttackLastDamageRate: คืนค่า `_t825` (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv15: [ผลนี้ใช้ได้กับอุปกรณ์เวทย์มนตร์เสริมเท่านั้น]  หากได้รับความเสียหายถึงชีวิตซึ่งเกิน HP สูงสุด มีโอกาสที่จะเหลือ 1HP แต่เมื่อเปิดใช้ไปครั้งหนึ่งแล้วจะไม่สามารถ ใช้งานได้อีกชั่วระยะเวลาหนึ่ง ผลการลดความเสียหายจาก MP ที่เหลือ ก็จะหายไปชั่วขณะเช่นกัน

