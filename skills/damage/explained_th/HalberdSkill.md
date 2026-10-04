# สกิลหอกวายุ (`HalberdSkill`) — คำอธิบายทีละสกิล (ภาษาไทย)

สร้างอัตโนมัติด้วย `scripts/render_explained_th.py` จาก `skill_reference.json` (ข้อมูลโค้ด client ชุดล่าสุด) ไม่มีข้อความเขียนมือ แก้ไฟล์นี้ตรง ๆ จะถูกเขียนทับ ตัวเลขทั้งหมดคำนวณจากโค้ด (Code) ความหมายของชื่อ field/บทบาทแปลจากชื่อในโค้ด (Inferred) ยังไม่ได้เทียบกับตัวเลขในเกม ข้อมูลดิบทุกเส้นทางอยู่ใน `../details/HalberdSkill.md`

---

<!-- calc:preface -->
> **วิธีอ่านหัวข้อ "การคำนวณแบบตัวเลข"** (สร้างอัตโนมัติด้วย `scripts/render_calc_th.py` จาก `skill_reference.json` แก้มือจะถูกเขียนทับ)
> ดาเมจต่อฮิตเดินตามขั้น `SkillCalcTemplate/CalcStep` 0→40 ตามลำดับ (Code: `SkillCalcTemplate.GetDamage`) ขั้น `+` บวกเข้าดาเมจ ขั้น `×` คูณแล้วปัดเศษทิ้ง (int) ทันทีทุกขั้น
> ลำดับหลัก: ดาเมจฐาน(7) + คงที่สกิล(8) + คงที่บัพ(9) − ป้องกันเป้า(10) + ตีแรก(11) → ×คริ(13) → ×ธาตุ(15) → ×ตัวคูณสกิล(18) → ×ตีแรก(19) → ×เสถียร(21) → +คงที่ออโต้(22) → ×Proration(23) → ×ประเภท(24) → ×ดาเมจสุดท้าย(25) → … → เพดาน/ขั้นต่ำ(35–37)
> "ฮิต N" = template ดาเมจแต่ละก้อน (ทอยคริแยกกัน) แยกตามเมธอดและตัวแปรฮิตในโค้ด (`type`, `isFirst`, `attackCount` …) ชื่อฮิต/ส่วนมาจากชื่อในโค้ด (Inferred) ตัวเลขคำนวณจากโค้ด (Code) โดยตั้งเจม/บัพเสริม = 0
> ค่าหลายก้อนในขั้นเดียวกันแบบ "บวกเข้าช่อง" จะบวกกันก่อนคูณ ส่วน "ตั้งค่าทับ" แทนที่ค่าเดิม ค่าที่ขึ้นกับสเตตัสแสดงเป็นตัวอย่างที่ 100 / 255 (และ Lv สกิลอื่น 1 / 10) ใช้สูตรที่แนบไว้คำนวณค่าอื่นเอง
<!-- calc:preface-end -->

### เฟลชสเต็ป (FlashStub) · uid 961

<img src="../../icons/sk_961.png" width="40" alt="icon">

- ทรี: สกิลหอกวายุ (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: ดาบมือเดียว, ทวน · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `FlashStubAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีศัตรูอย่างแม่นยำด้วยการเคลื่อนไหวที่รวดเร็ว

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

**โน้ตในเกม (ข้อความจากเกม):**
- Lv9: *เพิ่มความเร็วในการใช้

<!-- calc:begin uid=961 -->
#### การคำนวณแบบตัวเลข — FlashStub (uid 961)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +, ตั้งค่าทับ): **50 + 5×Lv** → 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, ตั้งค่าทับ): **(100 + 5×Lv)%** → 105%, 110%, 115%, 120%, 125%, 130%, 135%, 140%, 145%, 150% (Lv1…10)
<!-- calc:end -->

### แคนนอนสเปียร์ (CannonSpear) · uid 962

<img src="../../icons/sk_962.png" width="40" alt="icon">

- ทรี: สกิลหอกวายุ (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: ทวน · ต้องเรียนก่อน: เฟลชสเต็ป · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `CannonSpearAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีด้วยการปาหอกวายุ
> ระยะโจมตีจะเพิ่มขึ้นเมื่อเลเวลเพิ่มขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: ผงะ (Flinch)

<!-- calc:begin uid=962 -->
#### การคำนวณแบบตัวเลข — CannonSpear (uid 962)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `ช่อง [0] ของอาร์เรย์ต่อฮิต`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`skillRate.Length ≠ 0`]: **(40 + Lv)%** → 41%, 42%, 43%, 44%, 45%, 46%, 47%, 48%, 49%, 50% (Lv1…10)

**ฮิต 2: `calcPlayerToMobDamage` (ดาเมจหลัก) — `ช่อง [1] ของอาร์เรย์ต่อฮิต`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`skillRate.Length > 1`]: **(150 + 10×Lv)%** → 160%, 170%, 180%, 190%, 200%, 210%, 220%, 230%, 240%, 250% (Lv1…10)

**ใช้ร่วมทุกฮิตของ ดาเมจหลัก**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`skillRate.Length ≠ 0` หรือ `skillRate.Length > 1`]: **100 + 10×Lv** → 110, 120, 130, 140, 150, 160, 170, 180, 190, 200 (Lv1…10)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`skillRate.Length ≠ 0` หรือ `skillRate.Length = 0` หรือ `skillRate.Length > 1`]: `target.ExpDefSkill / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefSkill` = proration ช่อง Skill ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`skillRate.Length ≠ 0` หรือ `skillRate.Length = 0` หรือ `skillRate.Length > 1`]: `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_CharacterActionManagerBase` = ค่า Character Action Manager Base ของ MobActionManagerBase (ดูแท็บ Variables)
<!-- calc:end -->

### เดดลี่สเปียร์ (DeadlySpear) · uid 963

<img src="../../icons/sk_963.png" width="40" alt="icon">

- ทรี: สกิลหอกวายุ (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: ดาบมือเดียว, ทวน · ต้องเรียนก่อน: เฟลชสเต็ป · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `DeadlySpearAction` · สถานะการแกะ: แกะครบจากโค้ด

> แทงศัตรูได้แม่นยำและสร้างความเสียหายอย่างรุนแรง
> แม้การใช้สกิลกินเวลานานแต่จะเพิกเฉยต่อการป้องกันได้ในระดับหนึ่ง
> ทำให้มีโอกาสมากที่จะเกิดความเสียหายจากคริติคอลอย่างรุนแรง
> ถ้าสกิลนี้ติดคริติคอล จะลดการ MP ที่ใช้ของสกิลถัดไปลงครึ่งหนึ่ง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `criticalPercent` [อาวุธหลัก ดาบมือเดียว]: 50 %
- โอกาสติดสถานะ `criticalPercent` [อาวุธหลักอื่น (ไม่ใช่ ดาบมือเดียว)]: 300 %
- บัพ `DeadlySpearBuf`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.ReceiveAttack` — MobaPlayerActionManager.ReceiveAttack (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.CalcCostMp` — MP ที่ใช้ของสกิล: [call] `InflexibilityBuf$$CheckMpHalving` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Inflexibility), this` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill…; [call] `MultipleHuntBuf$$CheckMode` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt), SkillMode…` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill…; [set] `<CostMpType>k__BackingField` = `(CostMpType | 1)` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.RemoveAfterSkillBuf` — PlayerAttackBase.RemoveAfterSkillBuf: [call] `SkillBufferManager$$RemoveBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear` เมื่อ (PlayerAttackBase.ContainsNotApplicableSkill(PlayerAttackBase.get_ActionID()) & 1) eq 0 AND (SkillBufferManager.Contain… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv9: *พลัง+20
- Lv10: *ลดอัตราคริติคอล

<!-- calc:begin uid=963 -->
#### การคำนวณแบบตัวเลข — DeadlySpear (uid 963)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +, ตั้งค่าทับ): **80 + 3×Lv** → 83, 86, 89, 92, 95, 98, 101, 104, 107, 110 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, ตั้งค่าทับ) [อาวุธหลัก ดาบมือเดียว]: 110%, 110%, 115%, 120%, 125%, 130%, 135%, 140%, 145%, 150% (Lv1…10)
  - สูตร: `(5 × (Lv > 2 ? Lv : 2) + 100) / 100`
- ตัวคูณสกิล (`SkillRate`, ×, ตั้งค่าทับ) [อาวุธหลักอื่น (ไม่ใช่ ดาบมือเดียว)]: 130%, 130%, 135%, 140%, 145%, 150%, 155%, 160%, 165%, 170% (Lv1…10)
  - สูตร: `(5 × (Lv > 2 ? Lv : 2) + 120) / 100`
<!-- calc:end -->

### ฮัลเบิร์ทมาสเตอรี่ (HalberdMastery) · uid 964

<img src="../../icons/sk_964.png" width="40" alt="icon">

- ทรี: สกิลหอกวายุ (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: ทวน · ธง: StarGem
- คลาสในโค้ด: `HalberdMastery` · สถานะการแกะ: แกะครบจากโค้ด

> ใช้หอกวายุได้ชำนาญขึ้น
> เพิ่มพลังโจมตีเมื่อใช้หอกวายุ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ATK อาวุธ % (`EqAtkRate`): 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 (Lv1…10)
- พาสซีฟ ATK % (`AtkRate`): 1, 1, 2, 2, 2, 2, 2, 3, 3, 3 (Lv1…10)

### ควิกออร่า (QuickAura) · uid 965

<img src="../../icons/sk_965.png" width="40" alt="icon">

- ทรี: สกิลหอกวายุ (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: StarGem
- คลาสในโค้ด: `QuickAuraAction` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่มความเร็วของตัวเองด้วยพลังใจ
> ใช้ HP แทน MP ในใช้สกิล
> ASPD จะเพิ่มขึ้นชั่วขณะ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพปาร์ตี้/ผู้อื่น
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration

**โน้ตในเกม (ข้อความจากเกม):**
- Lv9: *HP ที่ใช้-5% *ระยะเวลาแสดงผล+120 วิ

### ดราก้อนเทล (DragonTail) · uid 966

<img src="../../icons/sk_966.png" width="40" alt="icon">

- ทรี: สกิลหอกวายุ (ขั้น 2) · เลเวลสูงสุด: 30 · อาวุธ: ทวน · ต้องเรียนก่อน: แคนนอนสเปียร์ · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `DragonTailAction` · สถานะการแกะ: แกะครบจากโค้ด

> ควงหอกวายุกวาดล้างศัตรู
> ลดความเสียหายที่ได้รับ (2 ครั้ง) ระหว่างใช้สกิล
> มีโอกาสทำให้เป้าหมาย[ล้มคว่ำ]
> สร้างความเสียหายให้บอสไม่ได้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `tumblePercent`: **10×Lv** → 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10) %
- สถานะที่ทำให้ติด: ล้มคว่ำ (Tumble)
- บัพ `DragonTailBuf`: ตัวคูณดาเมจที่ได้รับจากมอน (หมวดเฉพาะ) (`MobLastDamageRateUnique`) = 10×Lv → 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10)
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่

<!-- calc:begin uid=966 -->
#### การคำนวณแบบตัวเลข — DragonTail (uid 966)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `isFristAttck ≠ 0` · ส่วน ครั้งแรก (สะกดผิดในโค้ด) (`frist…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **100** → 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(70 + 3×Lv)%** → 73%, 76%, 79%, 82%, 85%, 88%, 91%, 94%, 97%, 100% (Lv1…10)

**ฮิต 2: `calcPlayerToMobDamage` (ดาเมจหลัก) — `isFristAttck = 0` · ส่วน ครั้งที่ 2 (`second…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **50 + 15×Lv** → 65, 80, 95, 110, 125, 140, 155, 170, 185, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(200 + 20×Lv)%** → 220%, 240%, 260%, 280%, 300%, 320%, 340%, 360%, 380%, 400% (Lv1…10)

**ใช้ร่วมทุกฮิตของ ดาเมจหลัก**
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `target.ExpDefSkill / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefSkill` = proration ช่อง Skill ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_CharacterActionManagerBase` = ค่า Character Action Manager Base ของ MobActionManagerBase (ดูแท็บ Variables)
<!-- calc:end -->

### วานิชเรย์ (PunishRay) · uid 967

<img src="../../icons/sk_967.png" width="40" alt="icon">

- ทรี: สกิลหอกวายุ (ขั้น 2) · เลเวลสูงสุด: 30 · อาวุธ: ดาบมือเดียว, ทวน · ต้องเรียนก่อน: เดดลี่สเปียร์ · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `PunishRayAction` · สถานะการแกะ: แกะครบจากโค้ด

> ใช้หอกวายุร่ายเวทแทนไม้เท้า
> พลังโจมตีเวทมนตร์ที่ศัตรูได้รับจะขึ้นอยู่กับ ATK
> อัตราคริติคอลของ 3 สกิลถัดไปจะเพิ่มขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `PunishRayBuf`: อัตราคริ + (`CrtUp`) = `critical[max(Count)]` (ตัวนับที่เปลี่ยนตามเหตุการณ์)
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 3 ตามที่ `PunishRayBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.ReceiveAttack` — MobaPlayerActionManager.ReceiveAttack: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.PunishRay, SkillManager.GetSkillLv(Pla…` เมื่อ GetServerHitTypeV2.reactionType(mobResponseData.HitType) ne 1 AND GetServerHitTypeV2.hitType(mobResponseData.HitType) n… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv9: *พลัง×2

<!-- calc:begin uid=967 -->
#### การคำนวณแบบตัวเลข — PunishRay (uid 967)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) · ส่วน โบนัส (`bonus…`)**
- ดาเมจฐาน (`BaseDamage`, +, ตั้งค่าทับ): `PlayerAttackBase.calcBaseDamage(playerAction, mobAction, 1, [skillMaster+0x24], PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) & 1)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcBaseDamage` = ดาเมจฐาน = (ATK/MATK + ผลต่างเลเวลผู้เล่น-มอน [+ ATK อาวุธรอง×ความเสถี; `PlayerAttackBase.CheckMagicCritical` = ตรวจ magic critical (PlayerAttackBase); `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `fixAddDamage` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `skillRate` — โดยที่ `skillRate` = `(mainWeapon = Halberd ? 2 × Lv × Lv + 50 : Lv × Lv + 25) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [INT รวม=100]: **25%** → 25%, 25%, 25%, 25%, 25%, 25%, 25%, 25%, 25%, 25% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [INT รวม=255]: **63%** → 63%, 63%, 63%, 63%, 63%, 63%, 63%, 63%, 63%, 63% (Lv1…10)

**ค่าบัพที่ขึ้นกับจำนวน stack**

- บัพ `PunishRayBuf` — `CrtUp` ตามจำนวน `Count`: `critical[max(Count)]`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |
<!-- calc:end -->

### วอร์ครายสทรักเกิ้ล (AdversityRoar) · uid 968

<img src="../../icons/sk_968.png" width="40" alt="icon">

- ทรี: สกิลหอกวายุ (ขั้น 2) · เลเวลสูงสุด: 30 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ควิกออร่า
- คลาสในโค้ด: `AdversityRoarAction` · สถานะการแกะ: แกะครบจากโค้ด

> ตะโกนขอชีวิตในตอนตกภาวะที่นั่งลำบาก
> ฟื้นฟู MP ได้เล็กน้อย
> ยิ่งปริมาณ HP ที่มีน้อยเท่าไหร่ปริมาณการฟื้นฟูจะยิ่งเพิ่มมากขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: แอ็กชันระบบ/อรรถประโยชน์
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration

**โน้ตในเกม (ข้อความจากเกม):**
- Lv9: *เวลาชาร์จน้อยลง

### ไดฟ์อิมแพ็ค (DiveImpact) · uid 969

<img src="../../icons/sk_969.png" width="40" alt="icon">

- ทรี: สกิลหอกวายุ (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: ทวน · ต้องเรียนก่อน: ดราก้อนเทล · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `DiveImpactAction` · สถานะการแกะ: แกะครบจากโค้ด

> ใช้หอกกระแทกผืนดินให้แตกเป็นผุยผง
> หลังใช้สกิลจะทำให้จุดที่โจมตีเกิดการระเบิด เพิ่มค่าความเสียหาย
> และมีโอกาสทำให้เป้าหมายติด "ตาพร่า" 
> ตัวเองจะติดไร้พ่ายระหว่างใช้สกิล

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ, วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `flashPercent`: **10×Lv** → 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10) %
- สถานะที่ทำให้ติด: ตาพร่า (Flash)

<!-- calc:begin uid=969 -->
#### การคำนวณแบบตัวเลข — DiveImpact (uid 969)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `isFirstAttck ≠ 0` · ส่วน ครั้งแรก (สะกดผิดในโค้ด) (`frist…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`isEquipConvergenceGemCart` หรือ ไม่ `isEquipConvergenceGemCart`]: **200 + 20×Lv** → 220, 240, 260, 280, 300, 320, 340, 360, 380, 400 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [STR รวม=100]: **(240 + 20×Lv)%** → 260%, 280%, 300%, 320%, 340%, 360%, 380%, 400%, 420%, 440% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [STR รวม=255]: **(302 + 20×Lv)%** → 322%, 342%, 362%, 382%, 402%, 422%, 442%, 462%, 482%, 502% (Lv1…10)

**ฮิต 2: `calcPlayerToMobDamage` (ดาเมจหลัก) — `isFirstAttck = 0` · ส่วน ครั้งที่ 2 (`second…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`isEquipConvergenceGemCart` หรือ ไม่ `isEquipConvergenceGemCart`]: **0** → 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [INT รวม=100]: **(300 + 40×Lv)%** → 340%, 380%, 420%, 460%, 500%, 540%, 580%, 620%, 660%, 700% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [INT รวม=255]: **(455 + 40×Lv)%** → 495%, 535%, 575%, 615%, 655%, 695%, 735%, 775%, 815%, 855% (Lv1…10)

**ใช้ร่วมทุกฮิตของ ดาเมจหลัก**
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`isEquipConvergenceGemCart` หรือ ไม่ `isEquipConvergenceGemCart`]: `target.ExpDefSkill / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefSkill` = proration ช่อง Skill ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`isEquipConvergenceGemCart` หรือ ไม่ `isEquipConvergenceGemCart`]: `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_CharacterActionManagerBase` = ค่า Character Action Manager Base ของ MobActionManagerBase (ดูแท็บ Variables)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `InitializeOthers`): `motionSpeed`
- `LoopParam` (ตั้งใน `ActionStart`): `int(20 × SkillActionBase.get_MotionSpeed(this) / 100)`
<!-- calc:end -->

### สไตร์คสเต็ป (StrikeStub) · uid 970

<img src="../../icons/sk_970.png" width="40" alt="icon">

- ทรี: สกิลหอกวายุ (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: ดาบมือเดียว, ทวน · ต้องเรียนก่อน: เดดลี่สเปียร์ · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `StrikeStubAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีศัตรูด้วยการเคลื่อนไหวอย่างรวดเร็ว
> ค่าความเสียหายจะเพิ่มขึ้นเมื่อเป้าหมายติดสภาวะผิดปกติ
> มีโอกาสเกิดคริติคอลได้ยาก

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `criticalPercent` [อาวุธหลัก ทวน หรือ อาวุธหลักอื่น (ไม่ใช่ ทวน/ดาบมือเดียว)]: **100 − 5×Lv** → 95, 90, 85, 80, 75, 70, 65, 60, 55, 50 (Lv1…10) %
- โอกาสติดสถานะ `abnormalRate` [อาวุธหลัก ทวน]: **0.2×Lv** → 0.2, 0.4, 0.6, 0.8, 1, 1.2, 1.4, 1.6, 1.8, 2 (Lv1…10) %
- โอกาสติดสถานะ `abnormalRate` [อาวุธหลัก ดาบมือเดียว หรือ อาวุธหลักอื่น (ไม่ใช่ ทวน/ดาบมือเดียว)]: **0.1×Lv** → 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1 (Lv1…10) %
- โอกาสติดสถานะ `criticalPercent` [อาวุธหลัก ดาบมือเดียว]: **50 − 2.5×Lv** → 47.5, 45, 42.5, 40, 37.5, 35, 32.5, 30, 27.5, 25 (Lv1…10) %

**โน้ตในเกม (ข้อความจากเกม):**
- Lv9: *พลังสกิล+300 *ค่าความเสียหายของสภาวะผิดปกติx2
- Lv10: *ลดอัตราคริติคอล

<!-- calc:begin uid=970 -->
#### การคำนวณแบบตัวเลข — StrikeStub (uid 970)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) · ส่วน โบนัส (`bonus…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [อาวุธหลัก ทวน]: **200** → 200, 200, 200, 200, 200, 200, 200, 200, 200, 200 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [อาวุธหลัก ดาบมือเดียว หรือ อาวุธหลักอื่น (ไม่ใช่ ทวน/ดาบมือเดียว)]: **100** → 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [STR รวม=100]: **20%** → 20%, 20%, 20%, 20%, 20%, 20%, 20%, 20%, 20%, 20% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [STR รวม=255]: **51%** → 51%, 51%, 51%, 51%, 51%, 51%, 51%, 51%, 51%, 51% (Lv1…10)

**ใช้ร่วมทุกฮิตของ ดาเมจหลัก**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ทวน และ `AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ≥ 1` และ `IsInstanceOf(playerAction, PlayerActionManager) ≠ 1` หรือ อาวุธหลัก ทวน และ `AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ≥ 1` และ `IsInstanceOf(playerAction, PlayerActionManager) = 1`]: **(190 + 21×Lv)%** → 211%, 232%, 253%, 274%, 295%, 316%, 337%, 358%, 379%, 400% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบมือเดียว และ `AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ≥ 1` และ `IsInstanceOf(playerAction, PlayerActionManager) ≠ 1` หรือ อาวุธหลัก ดาบมือเดียว และ `AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ≥ 1` และ `IsInstanceOf(playerAction, PlayerActionManager) = 1` หรือ อาวุธหลักอื่น (ไม่ใช่ ทวน/ดาบมือเดียว) และ `AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ≥ 1` และ `IsInstanceOf(playerAction, PlayerActionManager) ≠ 1` หรือ อาวุธหลักอื่น (ไม่ใช่ ทวน/ดาบมือเดียว) และ `AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ≥ 1` และ `IsInstanceOf(playerAction, PlayerActionManager) = 1` · กิ่งที่ 1 ของ `skillRate` หรือ อาวุธหลัก ดาบมือเดียว และ `AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ≥ 1` และ `IsInstanceOf(playerAction, PlayerActionManager) ≠ 1` หรือ อาวุธหลักอื่น (ไม่ใช่ ทวน/ดาบมือเดียว) และ `AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ≥ 1` และ `IsInstanceOf(playerAction, PlayerActionManager) ≠ 1` หรือ อาวุธหลัก ดาบมือเดียว และ `AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ≥ 1` และ `IsInstanceOf(playerAction, PlayerActionManager) = 1` หรือ อาวุธหลักอื่น (ไม่ใช่ ทวน/ดาบมือเดียว) และ `AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ≥ 1` และ `IsInstanceOf(playerAction, PlayerActionManager) = 1`]: **(190 + 11×Lv)%** → 201%, 212%, 223%, 234%, 245%, 256%, 267%, 278%, 289%, 300% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) < 1` และ `IsInstanceOf(playerAction, PlayerActionManager) ≠ 1` หรือ `AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) < 1` และ `IsInstanceOf(playerAction, PlayerActionManager) = 1` · กิ่งที่ 1 ของ `skillRate` หรือ `AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ≥ 1` และ `IsInstanceOf(playerAction, PlayerActionManager) ≠ 1` และ `AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) < 1` หรือ `AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ≥ 1` และ `IsInstanceOf(playerAction, PlayerActionManager) = 1` และ `AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) < 1`]: **(190 + Lv)%** → 191%, 192%, 193%, 194%, 195%, 196%, 197%, 198%, 199%, 200% (Lv1…10)
<!-- calc:end -->

### คริติคอลสเปียร์ (HandlingSatisfaction) · uid 971

<img src="../../icons/sk_971.png" width="40" alt="icon">

- ทรี: สกิลหอกวายุ (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: ทวน · ต้องเรียนก่อน: ฮัลเบิร์ทมาสเตอรี่
- คลาสในโค้ด: `HandlingSatisfactionMastary` · สถานะการแกะ: แกะครบจากโค้ด

> เรียนเคล็ดวิชาหอกวายุ
> อัตราคริติคอลจะเพิ่มขึ้นเมื่อติดตั้งหอกวายุ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ อัตราคริ % (`CrtRate`): 0, 1, 1, 2, 2, 3, 3, 4, 4, 5 (Lv1…10)
- พาสซีฟ อัตราคริ (`Crt`): 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 (Lv1…10)

### บัสเตอร์แลนซ์ / แพนิกบัสเตอร์แลนซ์ (BusterLunce) · uid 975

<img src="../../icons/sk_975.png" width="40" alt="icon">

- ทรี: สกิลหอกวายุ (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: ทวน · ธง: NoMarketSearch, MercenaryCanUseSkill
- คลาสในโค้ด: `BusterLanceAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีระยะไกลด้วยการขวางหอก
> ยิ่งห่างมากพลังโจมตีจะยิ่งต่ำลง
> ถ้าทำเงื่อนไขครบถ้วนสกิลจะเปลี่ยนไป
> การลดทอนระยะทางก็จะคลายลงเช่นกัน

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ; เวทเมื่อเป็นท่า Punish Ray — เงื่อนไข: Physics: isPunishRay = 0; Magic: isPunishRay = 1 (ActionPreparation conditions)
- Proration: ช่องที่เลือกตอนร่าย (กายภาพ/เวท) · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

<!-- calc:begin uid=975 -->
#### การคำนวณแบบตัวเลข — BusterLunce (uid 975)
Proration: ช่อง `dynamic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [กิ่งที่ 1 ของ `fixAddDamage` หรือ `!AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13)`]: **100** → 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `ActionRange`, กิ่งที่ 1 ของ `skillRate`, กิ่งที่ 1 ของ `distanceAttenuation`]: `((((((500 + (((AGIรวม + STRรวม) lt 0 ? ((AGIรวม + STRรวม) + 1) : (AGIรวม + STRรวม)) >> 1))) - (((100 - (Lv + (Lv << 2)))) * max((((MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))) pl 100 ? min((((500 + (((AGIรวม + STRรวม) lt 0 ? ((AGIรวม + STRรวม) + 1) : (AGIรวม + STRรวม)) >> 1))) - (((100 - (Lv + (Lv << 2)))) * max((((MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))), 855) : 100) + gemCartRate) / 100)` — โดยที่ `attenuationStartDist` = `attenuationStartDist + 3` ; `gemCartRate` = `gemCart(1044, [4])` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Agi` = AGI สุดท้าย; `status.Str` = STR สุดท้าย (หลังอุปกรณ์/บัพ/พาสซีฟ); `status.Agi` = AGI สุดท้าย; `status.Str` = STR สุดท้าย (หลังอุปกรณ์/บัพ/พาสซีฟ); `status.Agi` = AGI สุดท้าย; `status.Str` = STR สุดท้าย (หลังอุปกรณ์/บัพ/พาสซีฟ) …(+9) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13)` · กิ่งที่ 1 ของ `ActionRange`, กิ่งที่ 1 ของ `skillRate`]: `((((((500 + (((AGIรวม + STRรวม) lt 0 ? ((AGIรวม + STRรวม) + 1) : (AGIรวม + STRรวม)) >> 1))) - (distanceAttenuation * max((((MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))) pl 100 ? min((((500 + (((AGIรวม + STRรวม) lt 0 ? ((AGIรวม + STRรวม) + 1) : (AGIรวม + STRรวม)) >> 1))) - (distanceAttenuation * max((((MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))), 855) : 100) + gemCartRate) / 100)` — โดยที่ `distanceAttenuation` = `100 - 5 × Lv` หรือ `distanceAttenuation - 25` [`!AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13)`] ; `attenuationStartDist` = `attenuationStartDist + 3` ; `gemCartRate` = `gemCart(1044, [4])` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Agi` = AGI สุดท้าย; `status.Str` = STR สุดท้าย (หลังอุปกรณ์/บัพ/พาสซีฟ); `status.Agi` = AGI สุดท้าย; `status.Str` = STR สุดท้าย (หลังอุปกรณ์/บัพ/พาสซีฟ); `status.Agi` = AGI สุดท้าย; `status.Str` = STR สุดท้าย (หลังอุปกรณ์/บัพ/พาสซีฟ) …(+9) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13)` · กิ่งที่ 1 ของ `ActionRange`, กิ่งที่ 1 ของ `distanceAttenuation`]: `((((skillRate - (((100 - (Lv + (Lv << 2)))) * max((((MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))) pl 100 ? min((skillRate - (((100 - (Lv + (Lv << 2)))) * max((((MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))), 855) : 100) + gemCartRate) / 100)` — โดยที่ `skillRate` = `(AGIรวม + STRรวม) ÷ 2 + 500` หรือ `(skillRate + ((PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[967].Level + (PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[967].Level << 2)) << 1))` [`!AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13)`] ; `attenuationStartDist` = `attenuationStartDist + 3` ; `gemCartRate` = `gemCart(1044, [4])` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MathUtil.DistanceToDisplayMeter` = MathUtil.DistanceToDisplayMeter; `MathUtil.DisplayMeterToDistance` = MathUtil.DisplayMeterToDistance; `MobActionManagerBase.get_PlayerMeterDistance` = ค่า Player Meter Distance ของ MobActionManagerBase (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13)` · กิ่งที่ 1 ของ `ActionRange`]: `((((skillRate - (distanceAttenuation * max((((MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))) pl 100 ? min((skillRate - (distanceAttenuation * max((((MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))), 855) : 100) + gemCartRate) / 100)` — โดยที่ `skillRate` = `(AGIรวม + STRรวม) ÷ 2 + 500` หรือ `(skillRate + ((PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[967].Level + (PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[967].Level << 2)) << 1))` [`!AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13)`] ; `distanceAttenuation` = `100 - 5 × Lv` หรือ `distanceAttenuation - 25` [`!AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13)`] ; `attenuationStartDist` = `attenuationStartDist + 3` ; `gemCartRate` = `gemCart(1044, [4])` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MathUtil.DistanceToDisplayMeter` = MathUtil.DistanceToDisplayMeter; `MathUtil.DisplayMeterToDistance` = MathUtil.DisplayMeterToDistance; `MobActionManagerBase.get_PlayerMeterDistance` = ค่า Player Meter Distance ของ MobActionManagerBase (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `ActionRange`, กิ่งที่ 1 ของ `skillRate`, กิ่งที่ 1 ของ `distanceAttenuation`]: `((((((500 + (((AGIรวม + STRรวม) lt 0 ? ((AGIรวม + STRรวม) + 1) : (AGIรวม + STRรวม)) >> 1))) - (((100 - (Lv + (Lv << 2)))) * max((((MathUtil.DistanceToDisplayMeter((-1)) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter((-1)) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))) pl 100 ? min((((500 + (((AGIรวม + STRรวม) lt 0 ? ((AGIรวม + STRรวม) + 1) : (AGIรวม + STRรวม)) >> 1))) - (((100 - (Lv + (Lv << 2)))) * max((((MathUtil.DistanceToDisplayMeter((-1)) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter((-1)) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))), 855) : 100) + gemCartRate) / 100)` — โดยที่ `attenuationStartDist` = `attenuationStartDist + 3` ; `gemCartRate` = `gemCart(1044, [4])` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Agi` = AGI สุดท้าย; `status.Str` = STR สุดท้าย (หลังอุปกรณ์/บัพ/พาสซีฟ); `status.Agi` = AGI สุดท้าย; `status.Str` = STR สุดท้าย (หลังอุปกรณ์/บัพ/พาสซีฟ); `status.Agi` = AGI สุดท้าย; `status.Str` = STR สุดท้าย (หลังอุปกรณ์/บัพ/พาสซีฟ) …(+8) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13)` · กิ่งที่ 2 ของ `ActionRange`, กิ่งที่ 1 ของ `skillRate`]: `((((((500 + (((AGIรวม + STRรวม) lt 0 ? ((AGIรวม + STRรวม) + 1) : (AGIรวม + STRรวม)) >> 1))) - (distanceAttenuation * max((((MathUtil.DistanceToDisplayMeter((-1)) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter((-1)) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))) pl 100 ? min((((500 + (((AGIรวม + STRรวม) lt 0 ? ((AGIรวม + STRรวม) + 1) : (AGIรวม + STRรวม)) >> 1))) - (distanceAttenuation * max((((MathUtil.DistanceToDisplayMeter((-1)) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter((-1)) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))), 855) : 100) + gemCartRate) / 100)` — โดยที่ `distanceAttenuation` = `100 - 5 × Lv` หรือ `distanceAttenuation - 25` [`!AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13)`] ; `attenuationStartDist` = `attenuationStartDist + 3` ; `gemCartRate` = `gemCart(1044, [4])` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Agi` = AGI สุดท้าย; `status.Str` = STR สุดท้าย (หลังอุปกรณ์/บัพ/พาสซีฟ); `status.Agi` = AGI สุดท้าย; `status.Str` = STR สุดท้าย (หลังอุปกรณ์/บัพ/พาสซีฟ); `status.Agi` = AGI สุดท้าย; `status.Str` = STR สุดท้าย (หลังอุปกรณ์/บัพ/พาสซีฟ) …(+8) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13)` · กิ่งที่ 2 ของ `ActionRange`, กิ่งที่ 1 ของ `distanceAttenuation`]: `((((skillRate - (((100 - (Lv + (Lv << 2)))) * max((((MathUtil.DistanceToDisplayMeter((-1)) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter((-1)) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))) pl 100 ? min((skillRate - (((100 - (Lv + (Lv << 2)))) * max((((MathUtil.DistanceToDisplayMeter((-1)) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter((-1)) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))), 855) : 100) + gemCartRate) / 100)` — โดยที่ `skillRate` = `(AGIรวม + STRรวม) ÷ 2 + 500` หรือ `(skillRate + ((PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[967].Level + (PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[967].Level << 2)) << 1))` [`!AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13)`] ; `attenuationStartDist` = `attenuationStartDist + 3` ; `gemCartRate` = `gemCart(1044, [4])` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MathUtil.DistanceToDisplayMeter` = MathUtil.DistanceToDisplayMeter; `MobActionManagerBase.get_PlayerMeterDistance` = ค่า Player Meter Distance ของ MobActionManagerBase (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13)` · กิ่งที่ 2 ของ `ActionRange`]: `((((skillRate - (distanceAttenuation * max((((MathUtil.DistanceToDisplayMeter((-1)) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter((-1)) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))) pl 100 ? min((skillRate - (distanceAttenuation * max((((MathUtil.DistanceToDisplayMeter((-1)) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter((-1)) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))), 855) : 100) + gemCartRate) / 100)` — โดยที่ `skillRate` = `(AGIรวม + STRรวม) ÷ 2 + 500` หรือ `(skillRate + ((PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[967].Level + (PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[967].Level << 2)) << 1))` [`!AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13)`] ; `distanceAttenuation` = `100 - 5 × Lv` หรือ `distanceAttenuation - 25` [`!AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13)`] ; `attenuationStartDist` = `attenuationStartDist + 3` ; `gemCartRate` = `gemCart(1044, [4])` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MathUtil.DistanceToDisplayMeter` = MathUtil.DistanceToDisplayMeter; `MobActionManagerBase.get_PlayerMeterDistance` = ค่า Player Meter Distance ของ MobActionManagerBase (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `ExtensionMethod.ExSkillData.SkillDataExtentionMethod.GetTargetExpRate(BusterLanceAction.get_AttackType(), PlayerAttackBase.get_ActionID(), เป้า)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `ExtensionMethod.ExSkillData.SkillDataExtentionMethod.GetTargetExpRate` = ค่า proration ปัจจุบันของมอนในช่องที่สกิลใช้ (ExpRate); `BusterLanceAction.get_AttackType` = ค่า Attack Type ของ BusterLanceAction; `PlayerAttackBase.get_ActionID` = ค่า Action ID ของ PlayerAttackBase; `MobActionManagerBase.get_MobBattleStatus` = ค่า Mob Battle Status ของ MobActionManagerBase (ดูแท็บ Variables)
<!-- calc:end -->

### บลิทซ์ไปก์ (BlitzPike) · uid 980

<img src="../../icons/sk_980.png" width="40" alt="icon">

- ทรี: สกิลหอกวายุ (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: ทวน · ต้องเรียนก่อน: วานิชเรย์
- คลาสในโค้ด: `BlitzPikeAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีด้วยสายฟ้าลมกรดอย่างรวดเร็ว
> เมื่อเปิดใช้งานในระยะใกล้มีโอกาสทำให้ติด "อัมพาต"
> เป้าหมายที่ติดอัมพาตจะถูกโจมตีด้วยเวทมนตร์
> เมื่อเปิดใช้งานในระยะไกลจะเรียกหอกสายฟ้าออกมา
> และโจมตีเป้าหมายที่เข้ามาใกล้โดยอัตโนมัติ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ, วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 2 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ; ช่อง proration เป็นช่องเวท (ExpType const 2) — เงื่อนไข: Physics: always (OnInitialize / CalcFirst/SecondDamageData)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: อัมพาต (Paralysis)
- บัพ `BlitzPikeBuf`: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `int((intervalTimer * 100))` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Prev(): `intervalTimer` = `1`
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `SkillBufferManager.UpdateIndividualBuf` — SkillBufferManager.UpdateIndividualBuf: [call] `SkillBufferManager$$RemoveBuffer` = `this, SkillId.BlitzPike` เมื่อ (SkillBufferManager.TryGetBuf(this, SkillId.BlitzPike, out) & 1) ne 0 AND TryGetBuf.buf(this, SkillId.BlitzPike) ne 0 A… (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=980 -->
#### การคำนวณแบบตัวเลข — BlitzPike (uid 980)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `CalcFirstDamageData` — `ช่อง [0] ของอาร์เรย์ต่อฮิต`**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`fixAddDamage.Length ≠ 0` และ `skillRate.Length ≠ 0`]: **300** → 300, 300, 300, 300, 300, 300, 300, 300, 300, 300 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 982 ThorHammer ≥ 1` และ `fixAddDamage.Length > 1` และ `fixAddDamage.Length ≠ 0` และ `skillRate.Length > 1` และ … หรือ `Lv สกิล 982 ThorHammer ≥ 1` และ `fixAddDamage.Length > 1` และ `fixAddDamage.Length ≠ 0` และ `skillRate.Length ≤ 1` และ …]: `(10 × Lv + 10 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 982, 1) + baseSTR ÷ 2 + 300) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseSTR` = แต้ม STR ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseSTR; `baseSTR` = แต้ม STR ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseSTR; `baseSTR` = แต้ม STR ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseSTR; `SkillManager.GetSkillLv` = เลเวลของสกิลที่ผู้เล่นเรียน; `PlayerStatusBase.get_SkillManager` = ค่า Skill Manager ของ PlayerStatusBase; `SkillId.ThorHammer` = ธอร์แฮมเมอร์ (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`skillRate.Length = 1` และ `skillRate.Length ≠ 0` และ `fixAddDamage.Length ≠ 0` หรือ `skillRate.Length = 1` และ `skillRate.Length ≠ 0` และ `fixAddDamage.Length = 0` หรือ `fixAddDamage.Length = 0` และ `skillRate.Length ≠ 0` และ `skillRate.Length ≠ 1` หรือ `fixAddDamage.Length ≤ 1` และ `fixAddDamage.Length ≠ 0` และ `skillRate.Length ≠ 0` และ `skillRate.Length ≠ 1`]: **(300 + 10×Lv)%** → 310%, 320%, 330%, 340%, 350%, 360%, 370%, 380%, 390%, 400% (Lv1…10)

**ฮิต 2: `CalcSecondDamageData` — `ช่อง [1] ของอาร์เรย์ต่อฮิต`**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`fixAddDamage.Length > 1` และ `skillRate.Length > 1` · INT รวม=100]: **50** → 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`fixAddDamage.Length > 1` และ `skillRate.Length > 1` · INT รวม=255]: **127** → 127, 127, 127, 127, 127, 127, 127, 127, 127, 127 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 982 ThorHammer ≥ 1` และ `fixAddDamage.Length > 1` และ `fixAddDamage.Length ≠ 0` และ `skillRate.Length > 1` และ …]: `(30 × Lv + 10 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 982, 1) + baseINT ÷ 2 + 100) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseINT` = แต้ม INT ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseINT; `baseINT` = แต้ม INT ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseINT; `baseINT` = แต้ม INT ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseINT; `SkillManager.GetSkillLv` = เลเวลของสกิลที่ผู้เล่นเรียน; `PlayerStatusBase.get_SkillManager` = ค่า Skill Manager ของ PlayerStatusBase; `SkillId.ThorHammer` = ธอร์แฮมเมอร์ (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`fixAddDamage.Length = 0` และ `skillRate.Length ≠ 0` และ `skillRate.Length ≠ 1` และ `fixAddDamage.Length > 1` และ … หรือ `fixAddDamage.Length = 0` และ `skillRate.Length ≠ 0` และ `skillRate.Length ≠ 1` และ `fixAddDamage.Length ≤ 1` และ … หรือ `fixAddDamage.Length ≤ 1` และ `fixAddDamage.Length ≠ 0` และ `skillRate.Length ≠ 0` และ `skillRate.Length ≠ 1` และ … หรือ `Lv สกิล 982 ThorHammer < 1` และ `fixAddDamage.Length > 1` และ `fixAddDamage.Length ≠ 0` และ `skillRate.Length ≠ 0` และ …]: **(100 + 30×Lv)%** → 130%, 160%, 190%, 220%, 250%, 280%, 310%, 340%, 370%, 400% (Lv1…10)

**ใช้ร่วมทุกฮิตของ ฮิต 1**
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`fixAddDamage.Length ≠ 0` และ `skillRate.Length ≠ 0`]: `exp / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**ใช้ร่วมทุกฮิตของ ฮิต 2**
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`fixAddDamage.Length > 1` และ `skillRate.Length > 1`]: `exp / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
<!-- calc:end -->

### ดราก้อนทูธ (DragonTooth) · uid 972

<img src="../../icons/sk_972.png" width="40" alt="icon">

- ทรี: สกิลหอกวายุ (ขั้น 4) · เลเวลสูงสุด: 150 · อาวุธ: ทวน · ต้องเรียนก่อน: ดราก้อนเทล · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `DragonToothAction` · สถานะการแกะ: แกะครบจากโค้ด

> กระโจนพุ่งเข้าใส่แล้วโจมตีเป้าหมาย
> หลังจากใช้สกิลสำเร็จจะกลับไปอยู่ที่เดิม
> เพิ่มอัตราการโจมตีทะลุพลังป้องกัน​และอัตราคริติคอลในระดับสูง
> แต่ไม่มีบวกโบนัสพลังสกิล

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 2 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: None (None)
- ตัวอ่านสกิลนี้ `N_DragonToothAction.OnInitialize` — N_DragonToothAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `secondSkillRate` = `(max((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.DragonTooth, 1…`; [set] `mpRecovery` = `((max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.DragonTooth, 1…` (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=972 -->
#### การคำนวณแบบตัวเลข — DragonTooth (uid 972)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcFirstDamage`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(75×Lv)%** → 75%, 150%, 225%, 300%, 375%, 450%, 525%, 600%, 675%, 750% (Lv1…10)

**ฮิต 2: `calcSecondDamage`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **750%** → 750%, 750%, 750%, 750%, 750%, 750%, 750%, 750%, 750%, 750% (Lv1…10)
<!-- calc:end -->

### โครนอสไดรฟ์ (CronosDrive) · uid 973

<img src="../../icons/sk_973.png" width="40" alt="icon">

- ทรี: สกิลหอกวายุ (ขั้น 4) · เลเวลสูงสุด: 150 · อาวุธ: ทวน · ต้องเรียนก่อน: สไตร์คสเต็ป · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `CronosDriveAction` · สถานะการแกะ: แกะครบจากโค้ด

> ท่าลับที่ทำให้แทงทะลุซ้ำๆ กันได้หลายครั้ง
> จะสร้างความเสียหายกับมอนสเตอร์ที่เป็นเป้าหมายอย่างต่อเนื่อง
> พร้อมฟื้นฟู MP ให้ตัวเองเล็กน้อยเป็นเวลาหลายวินาที

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `CronosDriveBuf` ระยะเวลา `int(Lv = 0 ? 0 : 0.5 × ?ands - 0.5) + 5` วินาที [`Lv ≠ 10`] / 10 วินาที [`Lv = 10`]
- ตัวอ่านสกิลนี้ `DimensionTillAction.ActionHit` — DimensionTillAction.ActionHit: [set] `isCronosDriveBuf` = `(SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Cro…` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerBattleManager.ReceiveSkillMotionEnd` — MobaPlayerBattleManager.ReceiveSkillMotionEnd: [call] `SkillFactory$$CreateSkill` = `SkillId.CronosDrivePursuit` เมื่อ (NormalAttackAction.IsNormalAttack(response.SkillId) & 1) eq 0 AND response.SkillId eq 973 AND (response.Flag & 1) ne 0…; [call] `CronosDrivePursuitAction$$SetParameter` = `SkillFactory.CreateSkill(SkillId.CronosDrivePursuit), new SkillCalcTemplate, (response.Sk…` เมื่อ (NormalAttackAction.IsNormalAttack(response.SkillId) & 1) eq 0 AND response.SkillId eq 973 AND (response.Flag & 1) ne 0…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.CronosDrive, SkillManager.GetSkillLv(P…` เมื่อ (NormalAttackAction.IsNormalAttack(response.SkillId) & 1) eq 0 AND response.SkillId eq 973 AND (response.Flag & 1) ne 0… (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=973 -->
#### การคำนวณแบบตัวเลข — CronosDrive (uid 973)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **40×Lv** → 40, 80, 120, 160, 200, 240, 280, 320, 360, 400 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(100 + 50×Lv)%** → 150%, 200%, 250%, 300%, 350%, 400%, 450%, 500%, 550%, 600% (Lv1…10)

**ใช้ร่วมทุกฮิตของ ฮิตรีแอ็กชัน (`HitReactionAssign`)**
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical)` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobBuffer.GuardUpBuff.get_GuardUpval` = ค่า Guard Upval ของ GuardUpBuff; `TryGetBuff.buff` = TryGetBuff.buff; `MobActionManagerBase.get_BuffManager` = ค่า Buff Manager ของ MobActionManagerBase (ดูแท็บ Variables)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) = 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: **25** → 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 (Lv1…10)
<!-- calc:end -->

### เทพลมกรด (HandlingerOfGodspeed) · uid 974

<img src="../../icons/sk_974.png" width="40" alt="icon">

- ทรี: สกิลหอกวายุ (ขั้น 4) · เลเวลสูงสุด: 150 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: วอร์ครายสทรักเกิ้ล
- คลาสในโค้ด: `HandlingerOfGodspeedAction` · สถานะการแกะ: แกะครบจากโค้ด

> ใช้ MP สูงสุดและปล่อยพลังซ้อนกันได้ไม่เกิน 3 ครั้ง
> อัพเกรด ASPD/ความเร็วการเคลื่อนที่/การฟื้นฟู Avoid ในระยะเวลาสั้นๆ
> ลดต้านทานอาวุธ/ต้านทานเวทย์ลงเป็นจำนวนมาก
> ผลจะสิ้นสุดลงเมื่อได้รับความเสียหาย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `HandlingerOfGodspeedBuf` ระยะเวลา 10 + 2×Lv → 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 (Lv1…10) วินาที: หลบ + (`AvoidUp`) = `avoid` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · MP สูงสุด + (`MaxMpUp`) = `-maxMp` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `cverlayCount` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ความเร็วโจมตี + (`Aspd`) = `aspd` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ลดดาเมจเวทที่ได้รับ (`MagicDmgCut`) = `(cverlayCount * (HandlingerOfGodspeedBuf.GetGodSpearHandlingParam(this, id) - magicResist))` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ลดดาเมจกายภาพที่ได้รับ (`PowerDmgCut`) = `(cverlayCount * (HandlingerOfGodspeedBuf.GetGodSpearHandlingParam(this, id) - physicsResist))` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ความเร็วท่าทาง % (`MotionSpeedRate`) = `actionSpeed` (ตัวนับที่เปลี่ยนตามเหตุการณ์)
- ตัวอ่านสกิลนี้ `GodSpearHandling1Action.ActionHit` — GodSpearHandling1Action.ActionHit: [call] `HandlingerOfGodspeedBuf$$UpdateParam` = `PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[SkillId.HandlingerOfGodspeed],…` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManag…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.HandlingerOfGodspeed, SkillManager.Get…` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManag…; [call] `HandlingerOfGodspeedBuf$$UpdateParam` = `_t364, WeaponType, 1, SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillI…` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManag… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GodSpearHandling1Action.IsFailure` — เงื่อนไข is failure (GodSpearHandling1Action): คืนค่า `1` (3 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GodSpearHandling2Action.ActionHit` — GodSpearHandling2Action.ActionHit: [call] `HandlingerOfGodspeedBuf$$UpdateParam` = `PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[SkillId.HandlingerOfGodspeed],…` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManag…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.HandlingerOfGodspeed, SkillManager.Get…` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManag…; [call] `HandlingerOfGodspeedBuf$$UpdateParam` = `_t364, WeaponType, 2, SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillI…` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManag… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GodSpearHandling2Action.IsFailure` — เงื่อนไข is failure (GodSpearHandling2Action): คืนค่า `1` (3 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GodSpearHandling3Action.ActionHit` — GodSpearHandling3Action.ActionHit: [call] `HandlingerOfGodspeedBuf$$UpdateParam` = `PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[SkillId.HandlingerOfGodspeed],…` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManag…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.HandlingerOfGodspeed, SkillManager.Get…` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManag…; [call] `HandlingerOfGodspeedBuf$$UpdateParam` = `_t364, WeaponType, 3, SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillI…` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManag… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GodSpearHandling3Action.IsFailure` — เงื่อนไข is failure (GodSpearHandling3Action): คืนค่า `1` (3 กรณี) (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv9: *เพิ่มปริมาณการเพิ่ม ASPD *ลดการลดลงของต้านทานอาวุธ ลดการลดลงของต้านทานเวทย์ ระยะเวลาแสดงผล +30 วินาที

### ไลท์นิ่งเฮล (LightningHail) · uid 981

<img src="../../icons/sk_981.png" width="40" alt="icon">

- ทรี: สกิลหอกวายุ (ขั้น 4) · เลเวลสูงสุด: 150 · อาวุธ: ทวน · ต้องเรียนก่อน: บลิทซ์ไปก์
- คลาสในโค้ด: `LightningHailAction` · สถานะการแกะ: แกะครบจากโค้ด

> เรียกพายุสายฟ้าจำนวนมากฟาดใส่ศัตรู
> สร้างความเสียหายเวทมนตร์รอบตัวเป้าหมาย
> หากเป้าหมายติดอัมพาตจะโจมตีได้แม่นยำยิ่งขึ้น
> ตัวเองจะติดคงกระพันเมื่อเปิดใช้สกิล

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `LightningHailBuf`: ตัวนับ/stack (`Count`) = 3, 4, 4, 5, 5, 6, 6, 7, 7, 8 (Lv1…10)
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่

<!-- calc:begin uid=981 -->
#### การคำนวณแบบตัวเลข — LightningHail (uid 981)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **100 + 10×Lv** → 110, 120, 130, 140, 150, 160, 170, 180, 190, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [INT รวม=100]: 85%, 105%, 105%, 125%, 125%, 145%, 145%, 165%, 165%, 185% (Lv1…10)
  - สูตร: `skillRate / 100` — โดยที่ `skillRate` = `INTรวม // 10 + 20 × int(0.5 × Lv) + 75`
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [INT รวม=255]: 100%, 120%, 120%, 140%, 140%, 160%, 160%, 180%, 180%, 200% (Lv1…10)
  - สูตร: `skillRate / 100` — โดยที่ `skillRate` = `INTรวม // 10 + 20 × int(0.5 × Lv) + 75`
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `target.ExpDefMagic / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefMagic` = proration ช่อง Magic ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_CharacterActionManagerBase` = ค่า Character Action Manager Base ของ MobActionManagerBase (ดูแท็บ Variables)

**จำนวนฮิต / ตัวนับ**
- `attackNum` (ตั้งใน `OnInitialize`): 3, 4, 4, 5, 5, 6, 6, 7, 7, 8 (Lv1…10)
- `LoopParam` (ตั้งใน `OnInitialize`): 3, 4, 4, 5, 5, 6, 6, 7, 7, 8 (Lv1…10)
- `LoopParam` (ตั้งใน `InitializeOthers`): `motionSpeed`
- `LoopParam` (ตั้งใน `ActionStart`) [`attackNum ≥ 1` หรือ `attackNum < 1`]: `LoopParam + 100`
- `attackNum` (ตั้งใน `OtherPlayerAttackStartReceive`): `LoopParam - 100 × LoopParam // 100`
<!-- calc:end -->

### ดราโกนิกชาร์จ (DragonicCharge) · uid 976

<img src="../../icons/sk_976.png" width="40" alt="icon">

- ทรี: สกิลหอกวายุ (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: ทวน · ต้องเรียนก่อน: ดราก้อนทูธ
- คลาสในโค้ด: `DragonicChargeAction` · สถานะการแกะ: แกะครบจากโค้ด

> ปลดปล่อยความพิโรธแห่งมังกร
> จะใช้งานต่อเมื่อชาร์จจนเต็มหรือมีการเคลื่อนไหว
> การสะสมจะมากขึ้นเมื่อสัมผัสได้ถึงอันตรายขณะชาร์จ
> 
> ระวังจะโจมตีพลาดเป้าเพราะระยะจู่โจมมีเพียง 8 เมตรเท่านั้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `abnormalPercent` [`GemCartBufferManager.GetTalentElementType(PlayerStatusBase.get_GemCartBuffManager()) = 0` หรือ `GemCartBufferManager.GetTalentElementType(PlayerStatusBase.get_GemCartBuffManager()) ≠ 0`]: 1, 4, 9, 16, 25, 36, 49, 64, 81, 100 (Lv1…10) %
- สถานะที่ทำให้ติด: `abnormalType`
- บัพ `DragonicChargeBuf`: ตัวนับ/stack (`Count`) = `int(chargeValue)` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`
- ตัวอ่านสกิลนี้ `DragonicChargeAction.ActionSkillEvent` — DragonicChargeAction.ActionSkillEvent: [set] `powerRegist` = `(((_t219 << 1) << 1) lt 100 ? ((_t219 << 1) << 1) : 100)` เมื่อ [_currentSkillCombo+0x18] le 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND ActionRange ne -1 AN…; [set] `chargeValue` = `SkillBufferDataBase.GetParam(20)` เมื่อ [_currentSkillCombo+0x18] le 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND ActionRange ne -1 AN…; [set] `chargeValue` = `0` เมื่อ [_currentSkillCombo+0x18] le 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND ActionRange ne -1 AN… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `DragonicChargeAction.ActionSkillEventIfMoveIndex` — DragonicChargeAction.ActionSkillEventIfMoveIndex: [set] `chargeSkip` = `0` เมื่อ IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne …; [set] `chargeSkip` = `1` เมื่อ IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne … (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GuardActionManager.CheckGuardStart` — ตรวจ guard start (GuardActionManager): คืนค่า `_t378` (3 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManagerBase.InMobAttackArea` — PlayerActionManagerBase.InMobAttackArea (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=976 -->
#### การคำนวณแบบตัวเลข — DragonicCharge (uid 976)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `isFirst ≠ 0` · ส่วน เป้าหลัก (`target…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +, ตั้งค่าทับ): **300** → 300, 300, 300, 300, 300, 300, 300, 300, 300, 300 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, ตั้งค่าทับ): ขึ้นกับ `chargeValue` — สูตร `targetSkillRate × (chargeValue / 100 + 1) / 100` — โดยที่ `targetSkillRate` = `50 × Lv + 500` ; `chargeValue` = `5 × SkillIndividualFlag` หรือ `5 × [_currentSkillCombo+0x18]` หรือ `SkillBufferDataBase.GetParam(20)` [`ActionRange ≠ -1` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 976) ≠ 0`] หรือ `0` [`ActionRange ≠ -1`] ; `SkillIndividualFlag` = `[_currentSkillCombo+0x18]`

  | chargeValue | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 0 | 550% | 600% | 650% | 700% | 750% | 800% | 850% | 900% | 950% | 1000% |
  | 25 | 687.5% | 750% | 812.5% | 875% | 937.5% | 1000% | 1062.5% | 1125% | 1187.5% | 1250% |
  | 50 | 825% | 900% | 975% | 1050% | 1125% | 1200% | 1275% | 1350% | 1425% | 1500% |
  | 75 | 962.5% | 1050% | 1137.5% | 1225% | 1312.5% | 1400% | 1487.5% | 1575% | 1662.5% | 1750% |
  | 100 | 1100% | 1200% | 1300% | 1400% | 1500% | 1600% | 1700% | 1800% | 1900% | 2000% |

**ฮิต 2: `calcPlayerToMobDamage` (ดาเมจหลัก) — `isFirst = 0` · ส่วน ระยะ (`range…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +, ตั้งค่าทับ): **30×Lv** → 30, 60, 90, 120, 150, 180, 210, 240, 270, 300 (Lv1…10)
- หักป้องกันเป้า (`Def`, +, ตั้งค่าทับ) [`ActionRange ≠ -1` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 976) ≠ 0` และ `(IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction)) & 0x80000000) = 0`]: `-int((1 - min(max((min(20 × int(MathUtil.DistanceToDisplayMeter(MobActionManagerBase.get_PlayerDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)))), 100) + PlayerStatusBase.GetBonusValueWithBuf(A, 51) + DragonToothResistBreaker) ÷ 2, DragonToothResistBreaker + PlayerStatusBase.GetBonusValueWithBuf(A, 52)) / 100, 1)) × MDEFของเป้า)` · `A = PlayerActionManagerBase.get_PlayerStatus()` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MathUtil.DistanceToDisplayMeter` = MathUtil.DistanceToDisplayMeter; `MobActionManagerBase.get_PlayerDistance` = ค่า Player Distance ของ MobActionManagerBase; `PlayerStatusBase.GetBonusValueWithBuf` = PlayerStatusBase.GetBonusValueWithBuf; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `IMobStatusCalculator.CalcMdef` = MDEF มอนหลังคำนวณ; `MobActionManagerBase.get_MobBattleStatus` = ค่า Mob Battle Status ของ MobActionManagerBase …(+2) (ดูแท็บ Variables)
- หักป้องกันเป้า (`Def`, +, ตั้งค่าทับ) [`(IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction)) & 0x80000000) = 0`]: `-int((1 - min(max((10 × int(MathUtil.DistanceToDisplayMeter(MobActionManagerBase.get_PlayerDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)))) + PlayerStatusBase.GetBonusValueWithBuf(A, 51) + DragonToothResistBreaker) ÷ 2, DragonToothResistBreaker + PlayerStatusBase.GetBonusValueWithBuf(A, 52)) / 100, 1)) × MDEFของเป้า)` · `A = PlayerActionManagerBase.get_PlayerStatus()` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MathUtil.DistanceToDisplayMeter` = MathUtil.DistanceToDisplayMeter; `MobActionManagerBase.get_PlayerDistance` = ค่า Player Distance ของ MobActionManagerBase; `PlayerStatusBase.GetBonusValueWithBuf` = PlayerStatusBase.GetBonusValueWithBuf; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `IMobStatusCalculator.CalcMdef` = MDEF มอนหลังคำนวณ; `MobActionManagerBase.get_MobBattleStatus` = ค่า Mob Battle Status ของ MobActionManagerBase …(+2) (ดูแท็บ Variables)
- หักป้องกันเป้า (`Def`, +, ตั้งค่าทับ) [`(IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction)) & 0x80000000) ≠ 0`]: `-int(MDEFของเป้า)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `IMobStatusCalculator.CalcMdef` = MDEF มอนหลังคำนวณ; `MobActionManagerBase.get_MobBattleStatus` = ค่า Mob Battle Status ของ MobActionManagerBase (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, ตั้งค่าทับ): ขึ้นกับ `chargeValue` — สูตร `rangeSkillRate × (chargeValue / 100 + 1) / 100` — โดยที่ `rangeSkillRate` = `50 × Lv + 500` ; `chargeValue` = `5 × SkillIndividualFlag` หรือ `5 × [_currentSkillCombo+0x18]` หรือ `SkillBufferDataBase.GetParam(20)` [`ActionRange ≠ -1` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 976) ≠ 0`] หรือ `0` [`ActionRange ≠ -1`] ; `SkillIndividualFlag` = `[_currentSkillCombo+0x18]`

  | chargeValue | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 0 | 550% | 600% | 650% | 700% | 750% | 800% | 850% | 900% | 950% | 1000% |
  | 25 | 687.5% | 750% | 812.5% | 875% | 937.5% | 1000% | 1062.5% | 1125% | 1187.5% | 1250% |
  | 50 | 825% | 900% | 975% | 1050% | 1125% | 1200% | 1275% | 1350% | 1425% | 1500% |
  | 75 | 962.5% | 1050% | 1137.5% | 1225% | 1312.5% | 1400% | 1487.5% | 1575% | 1662.5% | 1750% |
  | 100 | 1100% | 1200% | 1300% | 1400% | 1500% | 1600% | 1700% | 1800% | 1900% | 2000% |

**ใช้ร่วมทุกฮิตของ ดาเมจหลัก**
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `target.ExpDefSkill / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefSkill` = proration ช่อง Skill ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_CharacterActionManagerBase` = ค่า Character Action Manager Base ของ MobActionManagerBase (ดูแท็บ Variables)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `ActionStart`): 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 (Lv1…10)
- `LoopParam` (ตั้งใน `ActionStart`): 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 (Lv1…10)
<!-- calc:end -->

### อินฟิไนท์ไดเมนชัน (DimensionTill) · uid 977

<img src="../../icons/sk_977.png" width="40" alt="icon">

- ทรี: สกิลหอกวายุ (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: ทวน · ต้องเรียนก่อน: โครนอสไดรฟ์
- คลาสในโค้ด: `DimensionTillAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีซ้ำๆ ด้วยหอกผ่านห้วงมิติแห่งเวลา
> ทำการโจมตีซ้ำๆ เป็นวงกว้างรอบเป้าหมาย
> มีโอกาสทำให้ติดสภาวะ[ตาพร่า]
> ถ้ามีผลของโครนอสไดรฟ์อยู่จะเพิ่มการฟื้นฟู MP

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ, วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · ไม่เปลี่ยนค่า proration
- โอกาสติดสถานะ `flashPercent`: `baseAGI ÷ 10 + 5 × Lv` %
- สถานะที่ทำให้ติด: ตาพร่า (Flash)

<!-- calc:begin uid=977 -->
#### การคำนวณแบบตัวเลข — DimensionTill (uid 977)
Proration: ช่อง `Skill` โหมด `never (IsExpDefFluctuate=false)`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +, ตั้งค่าทับ) [`(hitCount - ((hitCount // splitHitCount) * splitHitCount)) = 0`]: **20×Lv** → 20, 40, 60, 80, 100, 120, 140, 160, 180, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, ตั้งค่าทับ) [`(hitCount - ((hitCount // splitHitCount) * splitHitCount)) = 0`]: `skillRate / 100` — โดยที่ `skillRate` = `(baseAGI + baseSTR) // 5 + 400` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `InitializeOthers`): `motionSpeed`
- `hitCount` (ตั้งใน `ActionHit`): `hitCount + 1`
<!-- calc:end -->

### ออลไมทีวีลด์ (GodSpearHandling) · uid 978

<img src="../../icons/sk_978.png" width="40" alt="icon">

- ทรี: สกิลหอกวายุ (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: ทวน · ต้องเรียนก่อน: เทพลมกรด
- คลาสในโค้ด: `GodSpearHandlingMastary` · สถานะการแกะ: แกะครบจากโค้ด

> ลดปริมาณการลดลงของค่าต้านทานต่างๆ ที่เกิดจากสกิล[เทพลมกรด]
> เมื่อได้รับความเสียหายมีโอกาสคงกระพัน(ขึ้นอยู่กับค่าAGI)
> (เกิดขึ้นได้ไม่เกิน 1 ครั้งต่อ 10 วินาที)
> เพิ่มพลังโจมตีกายภาพของสกิลหอกวายุ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ดาเมจสุดท้าย % (`LastDmgRate`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
- ตัวอ่านสกิลนี้ `GodSpearHandling1Action.IsFailure` — เงื่อนไข is failure (GodSpearHandling1Action): คืนค่า `1` (3 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GodSpearHandling2Action.IsFailure` — เงื่อนไข is failure (GodSpearHandling2Action): คืนค่า `1` (3 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GodSpearHandling3Action.IsFailure` — เงื่อนไข is failure (GodSpearHandling3Action): คืนค่า `1` (3 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SkillManager.GetAvailableSkill` — SkillManager.GetAvailableSkill: [call] `SkillUtil$$CheckSkillEquipLimit` = `PlayerStatusBase.get_EquipItemData(), [_t1839+0x10]` เมื่อ skillId ge 33 AND (skillId & 0xffff) ne 1247 AND ((skillId & 0xffff) - 989) lo 3 AND SkillManager.GetSkillLv(this, Skil…; [call] `SkillFactory$$CreateSkill` = `skillId, SkillManager.GetSkillLv(this, SkillId.GodSpearHandling, (?mvn & 1)), playerAction` เมื่อ skillId ge 33 AND (skillId & 0xffff) ne 1247 AND ((skillId & 0xffff) - 989) lo 3 AND SkillManager.GetSkillLv(this, Skil… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv9: เมื่อเรียนรู้ Lv 1 จะสามารถใช้ "ออลไมทีวีลด์III" ได้ เมื่อเรียนรู้ Lv 5 จะสามารถใช้ "ออลไมทีวีลด์II" ได้ เมื่อเรียนรู้ Lv 10 จะสามารถใช้ "ออลไมทีวีลด์I" ได้  เมื่อใช้IIจะใช้เทพลมกรดได้ 2 ครั้ง ทันทีถึงจะใช้ซ้ำก็ไม่สะสมเพิ่ม สามารถใช้Iหลังใช้IIเพื่อลดเอฟเฟกต์ได้

### ทอร์นาโดแลนซ์ (TornadoLance) · uid 979

<img src="../../icons/sk_979.png" width="40" alt="icon">

- ทรี: สกิลหอกวายุ (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: ทวน · ต้องเรียนก่อน: คริติคอลสเปียร์
- คลาสในโค้ด: `TornadoLanceMastary` · สถานะการแกะ: แกะครบจากโค้ด

> ได้รับพลังทอร์นาโด 1 หน่วย
> เมื่อโจมตีเข้าเป้าด้วยฮัลเบิร์ทสกิล
> 
> ยิ่งชาร์จพลังทอร์นาโดหอกวายุก็จะยิ่งแข็งแกร่ง
> พลังทอร์นาโดจะหายไปครึ่งหนึ่งหากถูกโจมตี

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, พาสซีฟ
- บัพ `TornadoLanceBuf` ระยะเวลา 100 วินาที: ค่าเปอร์เซ็นต์ทั่วไป (`Percent`) = `int((pursuitPercent * Count))` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `count`; Next(): `LeftTime` = `100` · ดาเมจคริ + (`CrtDamageUp`) = `int((crtDamageUp * Count))` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `count`; Next(): `LeftTime` = `100` · ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `count`; Next(): `LeftTime` = `100` · หลบ % (`FleeRate`) = `((Count + (Count << 2)) << 1)` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `count`; Next(): `LeftTime` = `100` · ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `count`; Next(): `LeftTime` = `100`
- ตัวอ่านสกิลนี้ `MagicPursuit.Calc` — คำนวณ (MagicPursuit): คืนค่า `0` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobAttackBase.CalcHit` — คำนวณ hit (MobAttackBase): [set] `tornadoLanceFree` = `1` เมื่อ IsInstanceOf(mobAction, HighRaidBossActionManager) ne 1 AND IsInstanceOf(mobAction, HighRaidMobActionManager) ne 1 AND …; [set] `tornadoLanceFree` = `1` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.TornadoLance) & 1) ne 0; [set] `tornadoLanceFree` = `1` เมื่อ IsInstanceOf(mobAction, HighRaidBossActionManager) ne 1 AND IsInstanceOf(mobAction, HighRaidMobActionManager) ne 1 AND … (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobEventScriptAttack.CalcHit` — คำนวณ hit (MobEventScriptAttack): [call] `TornadoLanceBuf$$CheckHitMobAttack` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.TornadoLance)` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.TornadoLance, out) & 1) ne 0 AND TryGe…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.TornadoLance` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.TornadoLance, out) & 1) ne 0 AND TryGe… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerSecondaryStatus.get_CriticalDmg` — ค่า Critical Dmg ของ MobaPlayerSecondaryStatus: คืนค่า `_t609` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PhysicalPursuit.Calc` — คำนวณ (PhysicalPursuit): คืนค่า `0` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.CalcStable` — ตัวคูณความเสถียรของดาเมจ (กายภาพ/เวท): คืนค่า `(type hs 2 && type ne 3 && type ne 2 ? 0 : SkillActionBase.CalcMagicStablePercent(_t1472, _t1473))` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.ChackCorrectHit` — PlayerAttackBase.ChackCorrectHit: คืนค่า `1` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.CalcCriticalDmg` — คำนวณ critical dmg (PlayerSecondaryStatus): คืนค่า `(int((_t1571 * (((PlayerSecondaryStatus.get_Str(this) * 0.2) + max(((PlayerSecondaryStatus.get_Agi(this) - PlayerSecondaryStatus.get_Str(this)) * 0.1), 0)) + 1…` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.get_CurrectHit` — ค่า Currect Hit ของ PlayerSecondaryStatus: คืนค่า `(GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 15), GemCartBufferId.Value) eq 0 ? _t1657 : 100)` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ReceiveBattleResult.AttackMobaMob` — ReceiveBattleResult.AttackMobaMob: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerDataManager.get_SkillBufferManager(PlayerDataManager.GetPlayerDataManager()), new T…` เมื่อ response.MobaMobList.Length ge 1 AND 0 lo response.MobaMobList.Length AND (([response.MobaMobList.Position+0x19] eq 0 ?… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv9: [พลังทอร์นาโด] ยิ่งสะสมได้มาเท่าไหร่ก็จะยิ่งเพิ่มรับประกันการโจมตีของหอกวายุ อัตราการโจมตีเพิ่มและโจมตีคริติคอล  เมื่อสูญเสียพลังทอร์นาโดตอนโดนโจมตี อัตราหลบหลีกจะเพิ่มขึ้นตามค่าที่สูญเสียไป

<!-- calc:begin uid=979 -->
#### การคำนวณแบบตัวเลข — TornadoLance (uid 979)

**ค่าบัพที่ขึ้นกับจำนวน stack**

- บัพ `TornadoLanceBuf` — `Percent` ตามจำนวน `Count`: `int(pursuitPercent × Count)`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |

- บัพ `TornadoLanceBuf` — `CrtDamageUp` ตามจำนวน `Count`: `int(crtDamageUp × Count)`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |

- บัพ `TornadoLanceBuf` — `FleeRate` ตามจำนวน `Count`: `10 × Count`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | 10 | 10 | 10 | 10 | 10 | 10 | 10 | 10 | 10 | 10 |
  | 2 | 20 | 20 | 20 | 20 | 20 | 20 | 20 | 20 | 20 | 20 |
  | 3 | 30 | 30 | 30 | 30 | 30 | 30 | 30 | 30 | 30 | 30 |
  | 4 | 40 | 40 | 40 | 40 | 40 | 40 | 40 | 40 | 40 | 40 |
  | 5 | 50 | 50 | 50 | 50 | 50 | 50 | 50 | 50 | 50 | 50 |
<!-- calc:end -->

### ธอร์แฮมเมอร์ (ThorHammer) · uid 982

<img src="../../icons/sk_982.png" width="40" alt="icon">

- ทรี: สกิลหอกวายุ (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: ทวน · ต้องเรียนก่อน: ไลท์นิ่งเฮล
- คลาสในโค้ด: `ThorHammerAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีด้วยเวทมนตร์สายฟ้าขนาดใหญ่การันตีคริติคอล
> แต่พลังโจมตีกระจายตามจำนวนเป้าหมายที่โดน
> หลังจากเปิดใช้งานจะเพิ่มการโจมตีเวทมนตร์ เวทเจาะเข้า
> และอัตราความแม่นของตัวเองในช่วงระยะเวลาหนึ่ง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ, วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: None (None)
- บัพ `ThorHammerBuf`: ตัวคูณโจมตีไล่ตามเวท (`MagiclPursuitSkillRate`) = 10×Lv → 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10) · เจาะเวท (`MagicResistBreaker`) = 2×Lv → 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 (Lv1…10) · ความแม่น + (`HitUp`) = `baseINT × Lv // 10`
- ตัวอ่านสกิลนี้ `BlitzPikeAction.OnInitialize` — BlitzPikeAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `skillRate[0]` = `(_t98 + ((PlayerStatusBase.get_PrimaryStatus().str lt 0 ? (PlayerStatusBase.get_PrimarySt…` เมื่อ skillRate.Length ne 0 AND skillRate.Length ne 1 AND fixAddDamage.Length ne 0 AND fixAddDamage.Length hi 1 AND SkillMana…; [set] `skillRate[1]` = `(_t99 + ((PlayerStatusBase.get_PrimaryStatus().int lt 0 ? (PlayerStatusBase.get_PrimarySt…` เมื่อ skillRate.Length ne 0 AND skillRate.Length ne 1 AND fixAddDamage.Length ne 0 AND fixAddDamage.Length hi 1 AND SkillMana… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `LightningHailAction.ActionStart` — LightningHailAction: ตอนเริ่มทำงานของสกิล: [set] `isThorHammer` = `(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.ThorHammer, 1) gt 0…` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBuf…; [set] `isThorHammer` = `(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.ThorHammer, 1) gt 0…` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBuf… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.PursuitAttack` — PlayerBattleManager.PursuitAttack (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ThorHammerAction.ReceivedAbnormal` — ThorHammerAction.ReceivedAbnormal: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.ThorHammer` เมื่อ (abnormalType - 1) ls 2 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.ThorH… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv9: การเพิ่มของอัตราความแม่นขึ้นอยู่กับค่า INT ของตัวเอง  เมื่อใช้สกิล "ไลท์นิ่งเฮล" จะทิ้งร่องรอยไหม้จากฟ้าผ่า เมื่อใช้ร่วมกับสกิลธอร์แฮมเมอร์จะเพิ่มความเสียหายเวทมนตร์

<!-- calc:begin uid=982 -->
#### การคำนวณแบบตัวเลข — ThorHammer (uid 982)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `nowAttackCount ≠ 0` · ส่วน ไล่ตาม (`pursuit…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `pursuitFixDamage` — โดยที่ `pursuitFixDamage` = `((TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)).Level * 10) + 100)` [`(SkillBufferManager.TryGetBuf<LightningHailBuf>PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344))` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) ≠ 0`] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ดาเมจคงที่จากบัพ (`BufferConstantDamage`, +, ตั้งค่าทับ): **0** → 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `(pursuitHitCount + 1) × pursuitSkillRate / 100` — โดยที่ `pursuitSkillRate` = `((((TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)).Level >> 1) * 20) + (INTรวม // 10)) + 75)` [`(SkillBufferManager.TryGetBuf<LightningHailBuf>PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344))` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) ≠ 0`] ; `pursuitHitCount` = `pursuitHitCount ≥ 7 ? 8 : pursuitHitCount + 1` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**ฮิต 2: `calcPlayerToMobDamage` (ดาเมจหลัก) — `nowAttackCount = 0`**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **400** → 400, 400, 400, 400, 400, 400, 400, 400, 400, 400 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(1000 + 50×Lv)%** → 1050%, 1100%, 1150%, 1200%, 1250%, 1300%, 1350%, 1400%, 1450%, 1500% (Lv1…10)

**ใช้ร่วมทุกฮิตของ ดาเมจหลัก**
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `target.ExpDefMagic / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefMagic` = proration ช่อง Magic ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_CharacterActionManagerBase` = ค่า Character Action Manager Base ของ MobActionManagerBase (ดูแท็บ Variables)

**จำนวนฮิต / ตัวนับ**
- `damageCount` (ตั้งใน `OnInitialize`): 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 (Lv1…10)
- `LoopParam` (ตั้งใน `OnInitialize`): 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 (Lv1…10)
- `damageCount` (ตั้งใน `ActionStart`) [`(SkillBufferManager.TryGetBuf<LightningHailBuf>PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344))` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) ≠ 0`]: `SkillBufferDataBase.GetParam(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 981, this + 344), 20) + damageCount`
- `LoopParam` (ตั้งใน `ActionStart`) [`(SkillBufferManager.TryGetBuf<LightningHailBuf>PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344))` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) ≠ 0`]: `SkillBufferDataBase.GetParam(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 981, this + 344), 20) + damageCount`
- `damageCount` (ตั้งใน `InitializeOthers`): `motionSpeed`
<!-- calc:end -->

