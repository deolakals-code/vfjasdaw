# สกิลนักบวช (`PriestSkill`) — คำอธิบายทีละสกิล (ภาษาไทย)

สร้างอัตโนมัติด้วย `scripts/render_explained_th.py` จาก `skill_reference.json` (ข้อมูลโค้ด client ชุดล่าสุด) ไม่มีข้อความเขียนมือ แก้ไฟล์นี้ตรง ๆ จะถูกเขียนทับ ตัวเลขทั้งหมดคำนวณจากโค้ด (Code) ความหมายของชื่อ field/บทบาทแปลจากชื่อในโค้ด (Inferred) ยังไม่ได้เทียบกับตัวเลขในเกม ข้อมูลดิบทุกเส้นทางอยู่ใน `../details/PriestSkill.md`

---

<!-- calc:preface -->
> **วิธีอ่านหัวข้อ "การคำนวณแบบตัวเลข"** (สร้างอัตโนมัติด้วย `scripts/render_calc_th.py` จาก `skill_reference.json` แก้มือจะถูกเขียนทับ)
> ดาเมจต่อฮิตเดินตามขั้น `SkillCalcTemplate/CalcStep` 0→40 ตามลำดับ (Code: `SkillCalcTemplate.GetDamage`) ขั้น `+` บวกเข้าดาเมจ ขั้น `×` คูณแล้วปัดเศษทิ้ง (int) ทันทีทุกขั้น
> ลำดับหลัก: ดาเมจฐาน(7) + คงที่สกิล(8) + คงที่บัพ(9) − ป้องกันเป้า(10) + ตีแรก(11) → ×คริ(13) → ×ธาตุ(15) → ×ตัวคูณสกิล(18) → ×ตีแรก(19) → ×เสถียร(21) → +คงที่ออโต้(22) → ×Proration(23) → ×ประเภท(24) → ×ดาเมจสุดท้าย(25) → … → เพดาน/ขั้นต่ำ(35–37)
> "ฮิต N" = template ดาเมจแต่ละก้อน (ทอยคริแยกกัน) แยกตามเมธอดและตัวแปรฮิตในโค้ด (`type`, `isFirst`, `attackCount` …) ชื่อฮิต/ส่วนมาจากชื่อในโค้ด (Inferred) ตัวเลขคำนวณจากโค้ด (Code) โดยตั้งเจม/บัพเสริม = 0
> ค่าหลายก้อนในขั้นเดียวกันแบบ "บวกเข้าช่อง" จะบวกกันก่อนคูณ ส่วน "ตั้งค่าทับ" แทนที่ค่าเดิม ค่าที่ขึ้นกับสเตตัสแสดงเป็นตัวอย่างที่ 100 / 255 (และ Lv สกิลอื่น 1 / 10) ใช้สูตรที่แนบไว้คำนวณค่าอื่นเอง
<!-- calc:preface-end -->

### เบลส (Bless) · uid 833

<img src="../../icons/sk_833.png" width="40" alt="icon">

- ทรี: สกิลนักบวช (ขั้น 1) · เลเวลสูงสุด: 15 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `BlessAction` · สถานะการแกะ: แกะครบจากโค้ด

> ฟื้นฟู HP เล็กน้อยชั่วขณะ
> ปริมาณฟื้นฟูและระยะเวลาจะเพิ่มขึ้นตามเลเวล

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, บัพปาร์ตี้/ผู้อื่น
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `BlessBuf` ระยะเวลา `time` วินาที
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: *INT มีผลต่อปริมาณการฟื้นฟู *ปริมาณ MATK มีผลต่อปริมาณการฟื้นฟู+1%

### โฮลี่ฟิสท์ (HollyFist) · uid 834

<img src="../../icons/sk_834.png" width="40" alt="icon">

- ทรี: สกิลนักบวช (ขั้น 1) · เลเวลสูงสุด: 15 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `HolyFistAction` · สถานะการแกะ: แกะครบจากโค้ด

> อัดศัตรูด้วยหมัดพลังแสง
> สร้างความเสียหายทางกายภาพและเวทพร้อมกัน
> สกิลนี้เป็น[สกิลกายภาพ]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 2 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: *พลังเวท×2 *พลังเวทจะเพิ่มมากกว่าค่า INT ของตัวเอง
- Lv16: *พลังกายภาพ×2 *พลังกายภาพจะเพิ่มมากกว่าค่า STR ของตัวเอง

<!-- calc:begin uid=834 -->
#### การคำนวณแบบตัวเลข — HollyFist (uid 834)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) · ส่วน magic (`magic…`), physics (`physics…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **50 + 5×Lv** → 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `magicSkillRate` หรือ กิ่งที่ 2 ของ `physicsSkillRate`]: **(50 + 5×Lv)%** → 55%, 60%, 65%, 70%, 75%, 80%, 85%, 90%, 95%, 100% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `magicSkillRate` · INT รวม=100 หรือ กิ่งที่ 1 ของ `physicsSkillRate` · STR รวม=100]: **(200 + 10×Lv)%** → 210%, 220%, 230%, 240%, 250%, 260%, 270%, 280%, 290%, 300% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `magicSkillRate` · INT รวม=255 หรือ กิ่งที่ 1 ของ `physicsSkillRate` · STR รวม=255]: **(355 + 10×Lv)%** → 365%, 375%, 385%, 395%, 405%, 415%, 425%, 435%, 445%, 455% (Lv1…10)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `ExtensionMethod.ExSkillData.SkillDataExtentionMethod.GetTargetExpRate(1, PlayerAttackBase.get_ActionID(), เป้า)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `ExtensionMethod.ExSkillData.SkillDataExtentionMethod.GetTargetExpRate` = ค่า proration ปัจจุบันของมอนในช่องที่สกิลใช้ (ExpRate); `PlayerAttackBase.get_ActionID` = ค่า Action ID ของ PlayerAttackBase; `MobActionManagerBase.get_MobBattleStatus` = ค่า Mob Battle Status ของ MobActionManagerBase (ดูแท็บ Variables)
<!-- calc:end -->

### ร็อดสทับ (RodStub) · uid 841

<img src="../../icons/sk_841.png" width="40" alt="icon">

- ทรี: สกิลนักบวช (ขั้น 1) · เลเวลสูงสุด: 15 · อาวุธ: ไม้เท้า
- คลาสในโค้ด: `RodStubAction` · สถานะการแกะ: แกะครบจากโค้ด

> ตีอย่างแรงด้วยไม้เท้า
> ยิ่ง STR สูงเท่าไหร่ก็จะยิ่งมองข้ามพลังป้องกันของเป้าหมาย
> มีโอกาสทำให้เป้าหมาย[ผงะ]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: ผงะ (Flinch)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv17: *อัตราติดผงะ+25%

<!-- calc:begin uid=841 -->
#### การคำนวณแบบตัวเลข — RodStub (uid 841)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **100** → 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [STR รวม=100]: **(290 + Lv)%** → 291%, 292%, 293%, 294%, 295%, 296%, 297%, 298%, 299%, 300% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [STR รวม=255]: **(445 + Lv)%** → 446%, 447%, 448%, 449%, 450%, 451%, 452%, 453%, 454%, 455% (Lv1…10)
<!-- calc:end -->

### กลอเรีย (Gloria) · uid 835

<img src="../../icons/sk_835.png" width="40" alt="icon">

- ทรี: สกิลนักบวช (ขั้น 2) · เลเวลสูงสุด: 35 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: เบลส · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `GloriaAction` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่ม DEF/MDEF ในระยะเวลาสั้นๆ
> และเพิ่มการฟื้นฟู  Guard ขณะติดตั้งโล่

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, บัพปาร์ตี้/ผู้อื่น
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `GloriaBuf` ระยะเวลา 30 วินาที: DEF % (`DefRate`) = 51, 56, 63, 74, 87, 104, 123, 146, 171, 200 (Lv1…10) · MDEF % (`MdefRate`) = 51, 56, 63, 74, 87, 104, 123, 146, 171, 200 (Lv1…10) · อัตราการ์ด % (`GuardRate`) = `guard`
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `PetStatus.get_GuardDelay` — ค่า Guard Delay ของ PetStatus: คืนค่า `max(_t644, 0)` (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: *การฟื้นฟู Guard ของผู้ที่ใช้โล่จะได้รับผลจากการเพิ่มขึ้นของสกิลนี้

### โฮลี่ไลท์ (HollyLight) · uid 836

<img src="../../icons/sk_836.png" width="40" alt="icon">

- ทรี: สกิลนักบวช (ขั้น 2) · เลเวลสูงสุด: 35 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: โฮลี่ฟิสท์ · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `HolyLightActin` · สถานะการแกะ: แกะครบจากโค้ด

> ลงทัณฑ์เหล่าร้ายด้วยพลังศักดิ์สิทธิ์
> ใช้เวทธาตุแสงสร้างความเสียหายกับเป้าหมาย
> และฟื้นฟู HP ของตัวเองเล็กน้อย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ฟื้นฟู
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- ตัวอ่านสกิลนี้ `MobaPlayerBattleManager.StartHolyBiblePursuitAttack` — MobaPlayerBattleManager.StartHolyBiblePursuitAttack: [call] `HolyBibleBuf$$OnAction` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.HolyBible)` เมื่อ (UnityEngine.Object.op_Equality(targetActionManager, 0) & 1) eq 0 AND (CharacterActionManagerBase.get_IsDeadOrLocalDead… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.StartHolyBiblePursuitAttack` — PlayerBattleManager.StartHolyBiblePursuitAttack: [call] `HolyBibleBuf$$OnAction` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.HolyBible)` เมื่อ (UnityEngine.Object.op_Equality(targetActionManager, 0) & 1) eq 0 AND (CharacterActionManagerBase.get_IsDeadOrLocalDead… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: *พลัง+100 *พลังจะเพิ่มมากกว่าค่า INT ของตัวเอง
- Lv15: *ขีดจำกัดปริมาณการฟื้นฟู HP จะเพิ่มมากกว่าค่า INT ของตัวเอง

<!-- calc:begin uid=836 -->
#### การคำนวณแบบตัวเลข — HollyLight (uid 836)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **200** → 200, 200, 200, 200, 200, 200, 200, 200, 200, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก อุปกรณ์เวท และ `(isPlayer & 1) ≠ 0` หรือ อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท) และ `(isPlayer & 1) ≠ 0`]: **(100 + 15×Lv)%** → 115%, 130%, 145%, 160%, 175%, 190%, 205%, 220%, 235%, 250% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `skillRate` · INT รวม=100]: **(400 + 15×Lv)%** → 415%, 430%, 445%, 460%, 475%, 490%, 505%, 520%, 535%, 550% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `skillRate` · INT รวม=255]: **(710 + 15×Lv)%** → 725%, 740%, 755%, 770%, 785%, 800%, 815%, 830%, 845%, 860% (Lv1…10)
<!-- calc:end -->

### เอ็กซอร์ซิสต์ (Exorcism) · uid 842

<img src="../../icons/sk_842.png" width="40" alt="icon">

- ทรี: สกิลนักบวช (ขั้น 2) · เลเวลสูงสุด: 35 · อาวุธ: ไม้เท้า, โล่ · ต้องเรียนก่อน: โฮลี่ไลท์
- คลาสในโค้ด: `ExorcismAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีด้วยเวทมนตร์ธาตุแสงไปบริเวณรอบๆ
> ลด MP ที่ใช้ในสกิลถัดไปลงครึ่งหนึ่ง
> 
> ถ้าใช้กับธาตุมืดจะทรงพลังมากยิ่งขึ้น
> มีโอกาสทำให้ "ตาลาย/ตาพร่า/หวาดกลัว" อย่างใดอย่างหนึ่ง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: `abnormalType`
- บัพ `ExorcismBuf`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `PlayerAttackBase.CalcCostMp` — MP ที่ใช้ของสกิล: [call] `InflexibilityBuf$$CheckMpHalving` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Inflexibility), this` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill…; [call] `MultipleHuntBuf$$CheckMode` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt), SkillMode…` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill…; [set] `<CostMpType>k__BackingField` = `(CostMpType | 1)` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.RemoveAfterSkillBuf` — PlayerAttackBase.RemoveAfterSkillBuf: [call] `SkillBufferManager$$RemoveBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Exorcism` เมื่อ (PlayerAttackBase.ContainsNotApplicableSkill(PlayerAttackBase.get_ActionID()) & 1) eq 0 AND (SkillBufferManager.Contain… (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=842 -->
#### การคำนวณแบบตัวเลข — Exorcism (uid 842)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `target.Element = 6 ? fixAddDamage + 100 : fixAddDamage` — โดยที่ `fixAddDamage` = `10 × Lv` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.Element` = ธาตุของมอน (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `(target.Element = 6 ? skillRate + 400 : skillRate) / 100` — โดยที่ `skillRate` = `20 × Lv + 0.5 × STRรวม` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.Element` = ธาตุของมอน (ดูแท็บ Variables)
<!-- calc:end -->

### เอนเชนส์เบลส (BlessStrengthen) · uid 837

<img src="../../icons/sk_837.png" width="40" alt="icon">

- ทรี: สกิลนักบวช (ขั้น 3) · เลเวลสูงสุด: 125 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: กลอเรีย
- คลาสในโค้ด: `BlessStrengthen` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่มพลังฟื้นฟูของ[เบลส]
> ในกรณีที่มีเบลสเลเวล 10
> จะเพิ่มระยะเวลา, ปริมาณที่ฟื้นฟู และโบนัสไม้เท้าให้มากยิ่งขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- ตัวอ่านสกิลนี้ `BlessAction.OnInitialize` — BlessAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `count` = `(_t96 - 1)` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.BlessStrengthen, 1) gt 0; [set] `count` = `((int((Lv / 3)) + 1) - 1)` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.BlessStrengthen, 1) le 0 (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: *ปริมาณ MATK มีผลต่อปริมาณการฟื้นฟู+1% ในกรณีที่สกิลเลเวลของเบลสเป็น 10 INT มีผลต่อปริมาณการฟื้นฟู

### อีเธอร์บาเรีย (EtherCoat) · uid 838

<img src="../../icons/sk_838.png" width="40" alt="icon">

- ทรี: สกิลนักบวช (ขั้น 3) · เลเวลสูงสุด: 125 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: โฮลี่ไลท์ · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `EtherCoatAction` · สถานะการแกะ: แกะครบจากโค้ด

> กางบาเรียเพื่อดูดซับแรงจากการโจมตี
> เพิ่มความต้านทานสภาวะผิดปกติ[ผงะ]
> ในเวลาระยะเวลาสั้้นๆ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, บัพปาร์ตี้/ผู้อื่น
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `EtherCoatBuf` ระยะเวลา 5 วินาที: ต้านสถานะผิดปกติ (`AbnormalRegist`) = 50 + 5×Lv → 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 (Lv1…10) · MATK % (`MAtkUpRate`) = -8, -8, -8, -7, -7, -7, -6, -6, -6, -5 (Lv1…10)
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่

### โฮลี่ไบเบิ้ล (HolyBible) · uid 843

<img src="../../icons/sk_843.png" width="40" alt="icon">

- ทรี: สกิลนักบวช (ขั้น 3) · เลเวลสูงสุด: 125 · อาวุธ: ดาบมือเดียว, ไม้เท้า, สนับมือ · ต้องเรียนก่อน: เอ็กซอร์ซิสต์
- คลาสในโค้ด: `HolyBibleAction` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่มต้านทานธาตุมืดเล็กน้อยเป็นเวลา 10 นาที
> ถ้าสร้างความเสียหายด้วยเวทมนตร์ให้กับเป้าหมายที่ไม่ใช่ธาตุแสง
> มีโอกาสที่จะใช้โฮลี่ไลท์ที่เรียนรู้มาแล้วเพิ่ม
> *มีโอกาสที่จะสร้างความเสียหายให้ธาตุแสงด้วย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `HolyBibleBuf` ระยะเวลา 600 วินาที: ค่าเปอร์เซ็นต์ทั่วไป (`Percent`) = 27, 30, 32, 35, 37, 40, 42, 45, 47, 50 (Lv1…10) · ดาเมจธาตุมืดที่ได้รับ % (`ReceiveDarkElementDmgRate`) = Lv → 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
- ตัวอ่านสกิลนี้ `HolyBibleAction.ActionHit` — HolyBibleAction.ActionHit: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.HolyBible, Lv, 0, 0, Id` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MindimageSenjuSupportAction.ActionHit` — MindimageSenjuSupportAction.ActionHit: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.HolyBible, [baseSkill+0x14], 0, 0, Id` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND SendSupport ne 0 AND CharacterActionManagerBase.get_IsL… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerBattleManager.StartHolyBiblePursuitAttack` — MobaPlayerBattleManager.StartHolyBiblePursuitAttack: [call] `MathUtil$$CheckPercent` = `(SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), Sk…` เมื่อ (UnityEngine.Object.op_Equality(targetActionManager, 0) & 1) eq 0 AND (CharacterActionManagerBase.get_IsDeadOrLocalDead…; [call] `SkillFactory$$CreateSkill` = `SkillId.HolyLightPursuit` เมื่อ (UnityEngine.Object.op_Equality(targetActionManager, 0) & 1) eq 0 AND (CharacterActionManagerBase.get_IsDeadOrLocalDead…; [call] `HolyBibleBuf$$OnAction` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.HolyBible)` เมื่อ (UnityEngine.Object.op_Equality(targetActionManager, 0) & 1) eq 0 AND (CharacterActionManagerBase.get_IsDeadOrLocalDead… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.StartHolyBiblePursuitAttack` — PlayerBattleManager.StartHolyBiblePursuitAttack: [call] `MathUtil$$CheckPercent` = `(SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), Sk…` เมื่อ (UnityEngine.Object.op_Equality(targetActionManager, 0) & 1) eq 0 AND (CharacterActionManagerBase.get_IsDeadOrLocalDead…; [call] `SkillFactory$$CreateSkill` = `SkillId.HolyLightPursuit` เมื่อ (UnityEngine.Object.op_Equality(targetActionManager, 0) & 1) eq 0 AND (CharacterActionManagerBase.get_IsDeadOrLocalDead…; [call] `HolyBibleBuf$$OnAction` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.HolyBible)` เมื่อ (UnityEngine.Object.op_Equality(targetActionManager, 0) & 1) eq 0 AND (CharacterActionManagerBase.get_IsDeadOrLocalDead… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: *โฮลี่ไลท์ที่ใช้จะมีผลกับโบนัสไม้เท้า
- Lv15: *ลดเวลาที่จะใช้โฮลี่ไลท์อีกครั้งลงครึ่งหนึ่ง
- Lv17: *อัตราการใช้โฮลี่ไลท์จะเป็น 2 เท่า

### ไฮเนสฮีล (HighnessHeal) · uid 839

<img src="../../icons/sk_839.png" width="40" alt="icon">

- ทรี: สกิลนักบวช (ขั้น 4) · เลเวลสูงสุด: 205 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: เอนเชนส์เบลส · ธง: StarGem
- คลาสในโค้ด: `HighnessHealAction` · สถานะการแกะ: แกะครบจากโค้ด

> ฟื้นฟู HP ของตัวเองและเพื่อนที่อยู่รอบๆ
> ไม่เหมือนฮีลของสกิลสนับสนุนตรงที่
> ไม่มีผลทำให้คืนชีพได้เร็วขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: แอ็กชันระบบ/อรรถประโยชน์
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration

### พรีเอล (Priere) · uid 840

<img src="../../icons/sk_840.png" width="40" alt="icon">

- ทรี: สกิลนักบวช (ขั้น 4) · เลเวลสูงสุด: 205 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: อีเธอร์บาเรีย · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `PriereAction` · สถานะการแกะ: แกะครบจากโค้ด

> ตั้งจิตอธิษฐานเพื่อเพิ่มพลังเวท
> จะเพิ่ม MATK ได้ชั่วขณะ
> เมื่อใช้งานมีโอกาสที่จะหายจากสภาวะ [อ่อนแอ]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, บัพปาร์ตี้/ผู้อื่น
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `PriereBuf` ระยะเวลา 65 + Lv → 66, 67, 68, 69, 70, 71, 72, 73, 74, 75 (Lv1…10) วินาที [`EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 15` และ `EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type = 14` หรือ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 15` และ `EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type = 14`] / 15 + Lv → 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 (Lv1…10) วินาที [`((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? 1 : 0) | 0) = 1` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 15` และ `EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 14` หรือ `((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? 1 : 0) | 0) ≠ 1` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 15` และ `EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 14` หรือ `((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? 1 : 0) | 1) = 1` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 15` และ `EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 14`]: MATK % (`MAtkUpRate`) = Lv → 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: *ระยะเวลาแสดงผล+50s
- Lv15: *UP ปริมาณการเพิ่ม MATK
- Lv17: *มีโอกาสหายจากภาวะอ่อนแอ+25%

### เนเมซิส (Nemesis) · uid 844

<img src="../../icons/sk_844.png" width="40" alt="icon">

- ทรี: สกิลนักบวช (ขั้น 4) · เลเวลสูงสุด: 205 · อาวุธ: ดาบมือเดียว, ไม้เท้า, สนับมือ · ต้องเรียนก่อน: โฮลี่ไบเบิ้ล
- คลาสในโค้ด: `NemesisAction` · สถานะการแกะ: แกะครบจากโค้ด

> สร้างความเสียหายทางกายภาพและ
> กำหนดเป้าหมายที่จะโดนทัณฑ์สวรรค์
> 
> ถ้าอยู่ในสถานะที่โดนทัณฑ์สวรรค์สแต็คจะถูกสะสม
> เมื่อใช้งานสกิลนี้อีกครั้ง ขอบเขตการโจมตีด้วยเวทมนตร์
> จะเพิ่มตามจำนวนสแต็คที่สะสม

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, เปลี่ยนรูปแบบการโจมตี (อนุมานจาก hook ของบัพ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: ฮิตแรกกายภาพ; ฮิตระยะถัดไป (NextRangeHit) เป็นเวท — เงื่อนไข: Physics: isFirst = 1 (ActionPreparation); Magic: isFirst = 0 (NextRangeHit)
- Proration: ช่องที่เลือกตอนร่าย (กายภาพ/เวท) · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `NemesisBuf` ระยะเวลา 20×Lv → 20, 40, 60, 80, 100, 120, 140, 160, 180, 200 (Lv1…10) วินาที [`EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 17`] / 10×Lv → 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10) วินาที [`EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 17`]: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 20 ตามที่ `NemesisBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `BCollaboBossActionManager.Damaged` — BCollaboBossActionManager: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `NemesisBuf$$CheckPlayerAttackDamaged` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Nemesis), UnityEngine.Co…` เมื่อ (EnemyMobActionManagerBase.get_IsDead() & 1) eq 0 AND IsValid ne 0 AND (EnemyMobActionManagerBase.CheckCurrentPatternDa… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EnemyMobActionManagerBase.Damaged` — EnemyMobActionManagerBase: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `NemesisBuf$$CheckPlayerAttackDamaged` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Nemesis), UnityEngine.Co…` เมื่อ (EnemyMobActionManagerBase.get_IsDead() & 1) eq 0 AND IsValid ne 0 AND damageData.HitType ne 0 AND (UnityEngine.Object.… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EnemyMobActionManagerBase.SetHyperModeStatus` — EnemyMobActionManagerBase.SetHyperModeStatus: [call] `NemesisBuf$$ChangeHyperMode` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Nemesis), UnityEngine.Co…` เมื่อ (UnityEngine.Object.op_Inequality(hyperModeManager, 0) & 1) ne 0 AND (SkillBufferManager.TryGetBuf(PlayerStatusBase.get… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ExorcismAction.ActionStart` — ExorcismAction: ตอนเริ่มทำงานของสกิล: [set] `isNemesisBuf` = `(SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Nem…` เมื่อ (SkillParam & 16) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0; [set] `isNemesisBuf` = `(SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Nem…` เมื่อ (SkillParam & 16) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) eq 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GuildRaidBossMobActionManager.Damaged` — GuildRaidBossMobActionManager: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `NemesisBuf$$CheckPlayerAttackDamaged` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Nemesis), UnityEngine.Co…` เมื่อ (EnemyMobActionManagerBase.get_IsDead() & 1) eq 0 AND IsValid ne 0 AND damageData.HitType ne 0 AND (UnityEngine.Object.… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MindimageSenjuAttackAction.ActionStart` — MindimageSenjuAttackAction: ตอนเริ่มทำงานของสกิล: [set] `isNemesisBuf` = `(SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Nem…` เมื่อ CharacterActionManagerBase.get_IsLocalDead() eq 842 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaOtherPlayerActionManager.Damaged` — MobaOtherPlayerActionManager: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `NemesisBuf$$CheckPlayerAttackDamaged` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Nemesis), UnityEngine.Co…` เมื่อ (UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>(actor, action, damageDat… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.AddAbnormalState` — MobaPlayerActionManager.AddAbnormalState: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Nemesis` เมื่อ (type - 1) hi 10 AND type eq 18 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), Skill… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.ReceiveAttack` — MobaPlayerActionManager.ReceiveAttack: [call] `NemesisBuf$$CheckPlayerAttackDamaged` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Nemesis), UnityEngine.Co…` เมื่อ GetServerHitTypeV2.reactionType(mobResponseData.HitType) ne 1 AND GetServerHitTypeV2.hitType(mobResponseData.HitType) n… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerBattleManager.StartHolyBiblePursuitAttack` — MobaPlayerBattleManager.StartHolyBiblePursuitAttack (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `NemesisAction.Damaged` — NemesisAction: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `NemesisAction.OnInitialize` — NemesisAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `<SubElement>k__BackingField` = `PlayerStatusBase.GetEquipSubWeaponElement(PlayerActionManagerBase.get_PlayerStatus())` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Nemesis) & 1) ne 0 AND PlayerAtta…; [set] `<IsValidDualElement>k__BackingField` = `1` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Nemesis) & 1) ne 0 AND PlayerAtta… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.AddAbnormalState` — PlayerActionManager.AddAbnormalState: คืนค่า `1` (3 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.StartHolyBiblePursuitAttack` — PlayerBattleManager.StartHolyBiblePursuitAttack (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ScoreAttackBossActionManager.Damaged` — ScoreAttackBossActionManager: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `NemesisBuf$$CheckPlayerAttackDamaged` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Nemesis), UnityEngine.Co…` เมื่อ (EnemyMobActionManagerBase.get_IsDead() & 1) eq 0 AND IsValid ne 0 AND (EnemyMobActionManagerBase.CheckCurrentPatternDa… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: [ไม่ว่าจะใช้ไม้เท้าหรือสนับมือก็มีรายละเอียดเหมือนกัน] จะมีเส้นที่เชื่อมโยงกับเป้าหมายที่โดนทัณฑ์สวรรค์แสดงขึ้นมา ถ้าอยู่ห่างกันเกินไปทัณฑ์สวรรค์จะถูกยกเลิก  สแต็คจะเพิ่มขึ้นเมื่อโจมตีโดนเป้าหมายที่มีเส้นเชื่อมโยงอยู่ หรือตอนที่ถูกโจมตี ถ้าอยู่ในสภาวะนิ่งเงียบสแต๊คที่สะสมมาจะหายไป
- Lv10: [ไม่ว่าจะใช้ไม้เท้าหรือสนับมือก็มีรายละเอียดเหมือนกัน] เมื่อใช้บัฟของสกิลนี้ผลข้อจำกัดเรื่อง ธาตุของเอ็กซอร์ซิสต์กับโฮลี่ไบเบิ้ลจะหายไป และเพิ่มธาตุคู่(อุปกรณ์เวทมนตร์)
- Lv15: *ระยะ (รัศมี) ของการโจมตีด้วยเวทย์มนตร์+2.5m
- Lv17: *พลังจะเพิ่มขึ้นตามค่า STR ของตัวเอง เวลาที่มีผลเพิ่มเป็น 2 เท่า

<!-- calc:begin uid=844 -->
#### การคำนวณแบบตัวเลข — Nemesis (uid 844)
Proration: ช่อง `dynamic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `isFirst ≠ 0` · ส่วน เป้าหลัก (`target…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **60×Lv** → 60, 120, 180, 240, 300, 360, 420, 480, 540, 600 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `targetSkillRate` · STR รวม=100]: **1100%** → 1100%, 1100%, 1100%, 1100%, 1100%, 1100%, 1100%, 1100%, 1100%, 1100% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `targetSkillRate` · STR รวม=255]: **1255%** → 1255%, 1255%, 1255%, 1255%, 1255%, 1255%, 1255%, 1255%, 1255%, 1255% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `targetSkillRate`]: **1000%** → 1000%, 1000%, 1000%, 1000%, 1000%, 1000%, 1000%, 1000%, 1000%, 1000% (Lv1…10)

**ใช้ร่วมทุกฮิตของ ดาเมจหลัก**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`!PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction)` หรือ `criticalAttackCount lt SkillActionBase.get_AttackCount(this)`]: **60×Lv** → 60, 120, 180, 240, 300, 360, 420, 480, 540, 600 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`!PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction)` หรือ `criticalAttackCount lt SkillActionBase.get_AttackCount(this)`]: **30×Lv** → 30, 60, 90, 120, 150, 180, 210, 240, 270, 300 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction)` หรือ `criticalAttackCount lt SkillActionBase.get_AttackCount(this)` · กิ่งที่ 1 ของ `targetSkillRate` · STR รวม=100]: **1100%** → 1100%, 1100%, 1100%, 1100%, 1100%, 1100%, 1100%, 1100%, 1100%, 1100% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction)` หรือ `criticalAttackCount lt SkillActionBase.get_AttackCount(this)` · กิ่งที่ 1 ของ `targetSkillRate` · STR รวม=255]: **1255%** → 1255%, 1255%, 1255%, 1255%, 1255%, 1255%, 1255%, 1255%, 1255%, 1255% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction)` หรือ `criticalAttackCount lt SkillActionBase.get_AttackCount(this)` · กิ่งที่ 2 ของ `targetSkillRate`]: **1000%** → 1000%, 1000%, 1000%, 1000%, 1000%, 1000%, 1000%, 1000%, 1000%, 1000% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction)` หรือ `criticalAttackCount lt SkillActionBase.get_AttackCount(this)` · กิ่งที่ 1 ของ `targetSkillRate` · INT รวม=100 หรือ `!PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction)` หรือ `criticalAttackCount lt SkillActionBase.get_AttackCount(this)` · กิ่งที่ 2 ของ `targetSkillRate` · INT รวม=100]: **550%** → 550%, 550%, 550%, 550%, 550%, 550%, 550%, 550%, 550%, 550% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction)` หรือ `criticalAttackCount lt SkillActionBase.get_AttackCount(this)` · กิ่งที่ 1 ของ `targetSkillRate` · INT รวม=255 หรือ `!PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction)` หรือ `criticalAttackCount lt SkillActionBase.get_AttackCount(this)` · กิ่งที่ 2 ของ `targetSkillRate` · INT รวม=255]: **627.5%** → 627.5%, 627.5%, 627.5%, 627.5%, 627.5%, 627.5%, 627.5%, 627.5%, 627.5%, 627.5% (Lv1…10)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`!PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction)` หรือ `criticalAttackCount lt SkillActionBase.get_AttackCount(this)`]: `target.ExpDefMagic / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefMagic` = proration ช่อง Magic ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`!PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction)` หรือ `criticalAttackCount lt SkillActionBase.get_AttackCount(this)`]: `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_CharacterActionManagerBase` = ค่า Character Action Manager Base ของ MobActionManagerBase (ดูแท็บ Variables)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `InitializeOthers`): `motionSpeed`
- `LoopParam` (ตั้งใน `ActionPreparation`): `SkillBufferDataBase.GetParam(CheckNemesisBuf.buf(this + 312, actarAction), 20)`
- `LoopParam` (ตั้งใน `ActionPreparation`): 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 (Lv1…10)
<!-- calc:end -->

### แอสพิสโซล (AspisSeoul) · uid 845

<img src="../../icons/sk_845.png" width="40" alt="icon">

- ทรี: สกิลนักบวช (ขั้น 5) · เลเวลสูงสุด: 285 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: พรีเอล
- คลาสในโค้ด: `AspisSeoul` · สถานะการแกะ: แกะครบจากโค้ด

> โล่แห่งศรัทธา
> ได้รับผลการลดเปอร์เซ็นต์ความเสียหาย
> ที่มุ่งเป้าไปหาตัวเองแบบถาวร
> และได้รับผลการป้องกันสถานะผิดปกติในบางช่วงเวลา

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, พาสซีฟ, เปลี่ยนการทำงานของตีปกติ
- บัพ `AspisSeoulBuf` ระยะเวลา 3×Lv → 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 (Lv1…10) วินาที
- ตัวอ่านสกิลนี้ `AspisSeoul.GetRateDamageResist` — AspisSeoul.GetRateDamageResist: คืนค่า `((_t15 * int((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.AspisSeoul, 1) * 0.5))) + SkillManager.GetSkillLv(PlayerStatusBase.get_Skill…` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `AspisSeoul.ReceiveSupportEvent` — AspisSeoul.ReceiveSupportEvent: [call] `RecoveryBuf$$CreateAspisSeoulBuf` = `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.AspisSeoul, 1), (sup…` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.AspisSeoul, 1) ge 1 AND (SkillBufferManager.Contai…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), RecoveryBuf.CreateAspisSeoulBuf(SkillManager.G…` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.AspisSeoul, 1) ge 1 AND (SkillBufferManager.Contai… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv255: ถ้าอยู่ในปาร์ตี้จะเพิ่มเปอร์เซ็นต์ต้านทานความเสียหาย ขึ้นอยู่กับจำนวนสมาชิกPTที่รอดชีวิต(สูงสุด 3 คน)  ได้ผลการป้องกันเมื่อฟื้นฟูจากภาวะผิดปกติตามธรรมชาติ และเมื่อเริ่มต่อสู้กับบอส

### คำสอนศักดิ์สิทธิ์ (SacredTeachings) · uid 846

<img src="../../icons/sk_846.png" width="40" alt="icon">

- ทรี: สกิลนักบวช (ขั้น 5) · เลเวลสูงสุด: 285 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ไฮเนสฮีล
- คลาสในโค้ด: `SacredTeachings` · สถานะการแกะ: แกะครบจากโค้ด

> เมื่อใช้สกิลฟื้นฟูจะได้รับHPชั่วคราว
> ที่เกินกว่าค่าHPสูงสุดในปัจจุบัน(*)
> เมื่อได้รับHPชั่วคราวATKและMATK
> จะเพิ่มขึ้นเล็กน้อยตามค่านั้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, พาสซีฟ
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 100 ตามที่ `SacredTeachingsBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- บัพ `SacredTeachingsBuf`: ค่าทั่วไปตัวที่ 2 (`Value2`) = `localOverHealValue` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `overHealValue` (ตัวนับที่เปลี่ยนตามเหตุการณ์)
- ตัวอ่านสกิลนี้ `SacredTeachings.ReceiveHpHeal` — SacredTeachings.ReceiveHpHeal: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new SacredTeachingsBuf, 0` เมื่อ (System.Linq.Enumerable.Contains<Int32Enum>(SacredTeachings.TargetHealSkills, skillId) & 1) ne 0 AND SkillManager.GetSk…; [call] `SacredTeachingsBuf$$SetOverHeal` = `_t1723, supportData.Value, IPlayerStatusCalculator.get_MaxHp(PlayerStatusBase.get_Seconda…` เมื่อ (System.Linq.Enumerable.Contains<Int32Enum>(SacredTeachings.TargetHealSkills, skillId) & 1) ne 0 AND SkillManager.GetSk… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv255: (*)เมื่อค่าHPสูงสุดรวมกับHPชั่วคราวเกิน 99,999 HPชั่วคราวจะถูกตัดทิ้ง

### โฮลี่เกรซ (HolyGrace) · uid 847

<img src="../../icons/sk_847.png" width="40" alt="icon">

- ทรี: สกิลนักบวช (ขั้น 5) · เลเวลสูงสุด: 285 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: เนเมซิส
- คลาสในโค้ด: `HolyGraceAction` · สถานะการแกะ: แกะครบจากโค้ด

> สวรรค์ประทานพรให้ผู้บริสุทธิ์และพิพากษาเหล่าอธรรม
> เมื่อพลังชีวิตหมดจะทำให้ปาร์ตี้สามารถรักษาผล
> ของไอเท็มได้หนึ่งครั้งในระยะเวลาที่กำหนด
> นอกจากนี้การใช้ MP ของสกิลที่ถัดจาก
> ผู้ร่ายโฮลี่เกรซจะลดลงครึ่งหนึ่ง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `HolyGraceBuf` ระยะเวลา 10×Lv → 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10) วินาที
- บัพ `HolyGraceNextSkillMpHalvingBuf` ระยะเวลา 10×Lv → 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10) วินาที
- บัพ `NextAttackBufferBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `MainPlayer.PlayerDead` — MainPlayer.PlayerDead: [call] `PlayerStatusBase$$UpdateEffectiveDeadItemDuration` = `PlayerStatus, 1` เมื่อ (SkillBufferManager.ContainsBuffer(SkillBufferManager, SkillId.HolyGrace) & 1) ne 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.<HolyGracePursuitAttack>d__148.MoveNext` — <HolyGracePursuitAttack>d__148.MoveNext: [call] `HolyGracePursuitAttackAction$$CheckHate` = `?stack` เมื่อ <HolyGracePursuitAttack>d__148.<>1__state eq 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId…; [call] `SkillFactory$$CreateSkill` = `863` เมื่อ <HolyGracePursuitAttack>d__148.<>1__state eq 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId…; [call] `HolyGracePursuitAttackAction$$CheckHate` = `?stack` เมื่อ <HolyGracePursuitAttack>d__148.<>1__state eq 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv14: [จะได้รับผลแบบเดียวกันเมื่อใช้อุปกรณ์เวทมนตร์ (หลัก)]  ถ้าผลของ[สกิลที่ใช้ถัดไปจะลดMPที่ใช้ลงครึ่งหนึ่ง] ถูกใช้โดยบัฟสกิลที่กำหนด จะสร้างความเสียหาย ทางเวทให้กับมอนสเตอร์ทุกตัวในการต่อสู้ที่คุณเข้าร่วม

