# สกิลโล่ (`ShieldSkill`) — คำอธิบายทีละสกิล (ภาษาไทย)

สร้างอัตโนมัติด้วย `scripts/render_explained_th.py` จาก `skill_reference.json` (ข้อมูลโค้ด client ชุดล่าสุด) ไม่มีข้อความเขียนมือ แก้ไฟล์นี้ตรง ๆ จะถูกเขียนทับ ตัวเลขทั้งหมดคำนวณจากโค้ด (Code) ความหมายของชื่อ field/บทบาทแปลจากชื่อในโค้ด (Inferred) ยังไม่ได้เทียบกับตัวเลขในเกม ข้อมูลดิบทุกเส้นทางอยู่ใน `../details/ShieldSkill.md`

---

<!-- calc:preface -->
> **วิธีอ่านหัวข้อ "การคำนวณแบบตัวเลข"** (สร้างอัตโนมัติด้วย `scripts/render_calc_th.py` จาก `skill_reference.json` แก้มือจะถูกเขียนทับ)
> ดาเมจต่อฮิตเดินตามขั้น `SkillCalcTemplate/CalcStep` 0→40 ตามลำดับ (Code: `SkillCalcTemplate.GetDamage`) ขั้น `+` บวกเข้าดาเมจ ขั้น `×` คูณแล้วปัดเศษทิ้ง (int) ทันทีทุกขั้น
> ลำดับหลัก: ดาเมจฐาน(7) + คงที่สกิล(8) + คงที่บัพ(9) − ป้องกันเป้า(10) + ตีแรก(11) → ×คริ(13) → ×ธาตุ(15) → ×ตัวคูณสกิล(18) → ×ตีแรก(19) → ×เสถียร(21) → +คงที่ออโต้(22) → ×Proration(23) → ×ประเภท(24) → ×ดาเมจสุดท้าย(25) → … → เพดาน/ขั้นต่ำ(35–37)
> "ฮิต N" = template ดาเมจแต่ละก้อน (ทอยคริแยกกัน) แยกตามเมธอดและตัวแปรฮิตในโค้ด (`type`, `isFirst`, `attackCount` …) ชื่อฮิต/ส่วนมาจากชื่อในโค้ด (Inferred) ตัวเลขคำนวณจากโค้ด (Code) โดยตั้งเจม/บัพเสริม = 0
> ค่าหลายก้อนในขั้นเดียวกันแบบ "บวกเข้าช่อง" จะบวกกันก่อนคูณ ส่วน "ตั้งค่าทับ" แทนที่ค่าเดิม ค่าที่ขึ้นกับสเตตัสแสดงเป็นตัวอย่างที่ 100 / 255 (และ Lv สกิลอื่น 1 / 10) ใช้สูตรที่แนบไว้คำนวณค่าอื่นเอง
<!-- calc:preface-end -->

### ชีลด์มาสเตอรี่ (ShieldMastary) · uid 257

<img src="../../icons/sk_257.png" width="40" alt="icon">

- ทรี: สกิลโล่ (ขั้น 1) · เลเวลสูงสุด: 5 · อาวุธ: โล่ · ธง: StarGem
- คลาสในโค้ด: `ShieldMastary` · สถานะการแกะ: แกะครบจากโค้ด

> อัพเกรดความเร็วการโจมตีเมื่อติดตั้งโล่

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ความเร็วโจมตี % (`AspdRate`): 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10)

### โพรเทคชั่น (Protection) · uid 263

<img src="../../icons/sk_263.png" width="40" alt="icon">

- ทรี: สกิลโล่ (ขั้น 1) · เลเวลสูงสุด: 5 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `ProtectionAction` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่มความต้านทานทางกายภาพให้สมาชิกปาร์ตี้ชั่วขณะ
> แต่การต้านทานเวทจะลดลง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, บัพปาร์ตี้/ผู้อื่น
- MP ที่ใช้ [`EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 17`]: `mp - 200` — โดยที่ `mp` = `mp - 200` [`EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 17`]
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `AegisBuf` ระยะเวลา 60×Lv → 60, 120, 180, 240, 300, 360, 420, 480, 540, 600 (Lv1…10) วินาที: ลดดาเมจเวทที่ได้รับ (`MagicDmgCut`) = 10, 10, 15, 15, 15, 20, 20, 20, 25, 25 (Lv1…10) · ลดดาเมจกายภาพที่ได้รับ (`PowerDmgCut`) = -35, -35, -30, -30, -30, -25, -25, -25, -20, -20 (Lv1…10)
- บัพ `ProtectionBuf` ระยะเวลา 60×Lv → 60, 120, 180, 240, 300, 360, 420, 480, 540, 600 (Lv1…10) วินาที: ลดดาเมจกายภาพที่ได้รับ (`PowerDmgCut`) = 10, 10, 15, 15, 15, 20, 20, 20, 25, 25 (Lv1…10) · ลดดาเมจเวทที่ได้รับ (`MagicDmgCut`) = -35, -35, -30, -30, -30, -25, -25, -25, -20, -20 (Lv1…10)
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `AegisAction.ActionHit` — AegisAction.ActionHit: [call] `SkillBufferManager$$AddBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new ProtectionBuf, 0` เมื่อ (GemCartBufferManager.ContainsBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1036) & 1) ne 0 AND SkillManager.GetSki… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv17: *MP ที่ใช้-200

### ชีลด์บาช (ShieldBash) · uid 258

<img src="../../icons/sk_258.png" width="40" alt="icon">

- ทรี: สกิลโล่ (ขั้น 2) · เลเวลสูงสุด: 20 · อาวุธ: โล่ · ต้องเรียนก่อน: ชีลด์มาสเตอรี่ · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `ShieldBashAction` · สถานะการแกะ: แกะครบจากโค้ด

> อัดด้วยโล่เต็มแรง
> มีโอกาสทำให้เป้าหมาย[หมดสติ]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `stunPercent`: 77, 80, 82, 85, 87, 90, 92, 95, 97, 100 (Lv1…10) %
- สถานะที่ทำให้ติด: สตัน (Stun)

<!-- calc:begin uid=258 -->
#### การคำนวณแบบตัวเลข — ShieldBash (uid 258)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **50 + 5×Lv** → 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): 1%, 3%, 4%, 6%, 7%, 9%, 10%, 12%, 13%, 15% (Lv1…10)
  - สูตร: `skillRate` — โดยที่ `skillRate` = `int(1.5 × Lv) / 100`
<!-- calc:end -->

### ฟอร์ชชีลด์ (ForceShield) · uid 259

<img src="../../icons/sk_259.png" width="40" alt="icon">

- ทรี: สกิลโล่ (ขั้น 2) · เลเวลสูงสุด: 20 · อาวุธ: โล่ · ต้องเรียนก่อน: ชีลด์มาสเตอรี่
- คลาสในโค้ด: `ForceShield` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่ม DEF และการต้านทานอาวุธ
> เมื่อติดตั้งโล่

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ DEF (`Def`): 6, 8, 9, 11, 12, 14, 15, 17, 18, 20 (Lv1…10)
- พาสซีฟ HP สูงสุด (`MaxHp`): 50, 100, 150, 200, 250, 300, 350, 400, 450, 500 (Lv1…10)
- พาสซีฟ ลดดาเมจที่ได้รับ % (`CutDmgRate`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
- พาสซีฟ DEF % (`DefRate`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)

### อีจิส (Aegis) · uid 264

<img src="../../icons/sk_264.png" width="40" alt="icon">

- ทรี: สกิลโล่ (ขั้น 2) · เลเวลสูงสุด: 20 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: โพรเทคชั่น · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `AegisAction` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่มการต้านทานเวทให้สมาชิกปาร์ตี้ชั่วขณะ
> แต่ความต้านทานทางกายภาพจะลดลง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, บัพปาร์ตี้/ผู้อื่น
- MP ที่ใช้ [`EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 17`]: `mp - 200` — โดยที่ `mp` = `mp - 200` [`EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 17`]
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `AegisBuf` ระยะเวลา 60×Lv → 60, 120, 180, 240, 300, 360, 420, 480, 540, 600 (Lv1…10) วินาที: ลดดาเมจเวทที่ได้รับ (`MagicDmgCut`) = 10, 10, 15, 15, 15, 20, 20, 20, 25, 25 (Lv1…10) · ลดดาเมจกายภาพที่ได้รับ (`PowerDmgCut`) = -35, -35, -30, -30, -30, -25, -25, -25, -20, -20 (Lv1…10)
- บัพ `ProtectionBuf` ระยะเวลา 60×Lv → 60, 120, 180, 240, 300, 360, 420, 480, 540, 600 (Lv1…10) วินาที: ลดดาเมจกายภาพที่ได้รับ (`PowerDmgCut`) = 10, 10, 15, 15, 15, 20, 20, 20, 25, 25 (Lv1…10) · ลดดาเมจเวทที่ได้รับ (`MagicDmgCut`) = -35, -35, -30, -30, -30, -25, -25, -25, -20, -20 (Lv1…10)
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `ProtectionAction.ActionHit` — ProtectionAction.ActionHit: [call] `SkillBufferManager$$AddBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new AegisBuf, 0` เมื่อ (GemCartBufferManager.ContainsBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1036) & 1) ne 0 AND SkillManager.GetSki… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv17: *MP ที่ใช้-200

### ชีลด์อัปเปอร์คัต (ShieldUpper) · uid 266

<img src="../../icons/sk_266.png" width="40" alt="icon">

- ทรี: สกิลโล่ (ขั้น 2) · เลเวลสูงสุด: 20 · อาวุธ: โล่ · ต้องเรียนก่อน: ชีลด์มาสเตอรี่
- คลาสในโค้ด: `ShieldUpperAction` · สถานะการแกะ: แกะครบจากโค้ด

> เสยหมัดอย่างรุนแรงพร้อมโล่
> มีโอกาสที่เป้าหมายจะติด [ล้มคว่ำ]
> ความเสียหายที่ได้รับจะลดลง
> และเปิดใช้ Guard โดยอัตโนมัติระหว่างใช้สกิลนี้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: ล้มคว่ำ (Tumble)
- บัพ `ShieldUpperBuf`: ตัวคูณดาเมจที่ได้รับจากมอน (หมวดเฉพาะ) (`MobLastDamageRateUnique`) = `min(2 × Lv + lv + Lv × shieldRefine // 5 + 39, 99)`
- ตัวอ่านสกิลนี้ `MobAttackBase.CalcLastDamage` — คำนวณ last damage (MobAttackBase): คืนค่า `((SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.ArkSaber, out) & 1) eq 0 ? ((_t983 & 1) eq 0 ? ((_t982 & 1) eq 0 ? _t997 : _t…` (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=266 -->
#### การคำนวณแบบตัวเลข — ShieldUpper (uid 266)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **100** → 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` หรือ `!PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` หรือ `PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction)` และ `PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` หรือ `!AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(mobAction), 2)` และ `!PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction)` และ `PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` · ค่าตีบวก (Refine)=0]: **(15×Lv)%** → 15%, 30%, 45%, 60%, 75%, 90%, 105%, 120%, 135%, 150% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(mobAction), 2)` และ `!PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction)` และ `PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` · ค่าตีบวก (Refine)=15]: **(30×Lv)%** → 30%, 60%, 90%, 120%, 150%, 180%, 210%, 240%, 270%, 300% (Lv1…10)

**ใช้ร่วมทุกฮิตของ ฮิตรีแอ็กชัน (`HitReactionAssign`)**
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical)` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobBuffer.GuardUpBuff.get_GuardUpval` = ค่า Guard Upval ของ GuardUpBuff; `TryGetBuff.buff` = TryGetBuff.buff; `MobActionManagerBase.get_BuffManager` = ค่า Buff Manager ของ MobActionManagerBase (ดูแท็บ Variables)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) = 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: **25** → 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 (Lv1…10)
<!-- calc:end -->

### ชีลด์แคนนอน (ShieldCannon) · uid 260

<img src="../../icons/sk_260.png" width="40" alt="icon">

- ทรี: สกิลโล่ (ขั้น 3) · เลเวลสูงสุด: 50 · อาวุธ: โล่ · ต้องเรียนก่อน: ชีลด์บาช · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `ShieldCannonAction` · สถานะการแกะ: แกะครบจากโค้ด

> ขว้างโล่ออกไปเต็มแรงเหมือนกระสุนปืนใหญ่
> มีโอกาสทำให้เป้าหมายหมดสติ
> ถ้าทำให้หมดสติสำเร็จพลังโจมตีจะเพิ่มขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `stunPercent`: **10×Lv** → 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10) %
- สถานะที่ทำให้ติด: สตัน (Stun)

<!-- calc:begin uid=260 -->
#### การคำนวณแบบตัวเลข — ShieldCannon (uid 260)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3)` และ `!PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction)` และ `PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` · กิ่งที่ 1 ของ `fixAddDamage`]: `int(((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255) / 5 + 1) × baseVIT) + 10 × Lv + 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseVIT` = แต้ม VIT ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseVIT; `ItemData.get_Refine` = ค่า Refine ของ ItemData; `EquipItemData.get_SubWeapon` = ค่า Sub Weapon ของ EquipItemData; `PlayerStatusBase.get_EquipItemData` = ค่า Equip Item Data ของ PlayerStatusBase (ดูแท็บ Variables)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3)` และ `!PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction)` และ `PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)`]: `int(((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255) / 5 + 1) × baseVIT) + fixAddDamage` — โดยที่ `fixAddDamage` = `10 × Lv + 100` หรือ `int(((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255) / 5 + 1) × baseVIT) + fixAddDamage` [`!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3)` และ `!PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction)` และ `PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)`] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseVIT` = แต้ม VIT ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseVIT; `ItemData.get_Refine` = ค่า Refine ของ ItemData; `EquipItemData.get_SubWeapon` = ค่า Sub Weapon ของ EquipItemData; `PlayerStatusBase.get_EquipItemData` = ค่า Equip Item Data ของ PlayerStatusBase (ดูแท็บ Variables)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` หรือ `!PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` หรือ `AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3)` และ `PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` · กิ่งที่ 1 ของ `fixAddDamage` หรือ `!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3)` และ `!PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction)` และ `PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ … หรือ `!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3)` และ `!PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction)` และ `PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ … หรือ `!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3)` และ `!PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction)` และ `PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ …]: **100 + 10×Lv** → 110, 120, 130, 140, 150, 160, 170, 180, 190, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` หรือ `!PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` หรือ `AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3)` และ `PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` · กิ่งที่ 1 ของ `skillRate` หรือ `!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3)` และ `!PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction)` และ `PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ … หรือ `!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3)` และ `!PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction)` และ `PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ … หรือ `!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3)` และ `!PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction)` และ `PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ … หรือ `!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3)` และ `!PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction)` และ `PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` · กิ่งที่ 1 ของ `skillRate` · ค่าตีบวก (Refine)=0 หรือ `!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3)` และ `!PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction)` และ `PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` · ค่าตีบวก (Refine)=0]: **(50 + 10×Lv)%** → 60%, 70%, 80%, 90%, 100%, 110%, 120%, 130%, 140%, 150% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3)` และ `!PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction)` และ `PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` · กิ่งที่ 1 ของ `skillRate` · ค่าตีบวก (Refine)=15 หรือ `!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3)` และ `!PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction)` และ `PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` · ค่าตีบวก (Refine)=15]: **(750 + 150×Lv)%** → 900%, 1050%, 1200%, 1350%, 1500%, 1650%, 1800%, 1950%, 2100%, 2250% (Lv1…10)

**ใช้ร่วมทุกฮิตของ ฮิตรีแอ็กชัน (`HitReactionAssign`)**
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical)` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobBuffer.GuardUpBuff.get_GuardUpval` = ค่า Guard Upval ของ GuardUpBuff; `TryGetBuff.buff` = TryGetBuff.buff; `MobActionManagerBase.get_BuffManager` = ค่า Buff Manager ของ MobActionManagerBase (ดูแท็บ Variables)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) = 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: **25** → 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 (Lv1…10)
<!-- calc:end -->

### เมจิกคัลชีลด์ (MagicalShield) · uid 261

<img src="../../icons/sk_261.png" width="40" alt="icon">

- ทรี: สกิลโล่ (ขั้น 3) · เลเวลสูงสุด: 50 · อาวุธ: โล่ · ต้องเรียนก่อน: ฟอร์ชชีลด์
- คลาสในโค้ด: `MagicalShield` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่ม MDEF และการต้านทานเวทย์
> เมื่อติดตั้งโล่

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ลดดาเมจที่ได้รับ % (`CutDmgRate`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
- พาสซีฟ MDEF % (`MdefRate`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
- พาสซีฟ MDEF (`Mdef`): 6, 8, 9, 11, 12, 14, 15, 17, 18, 20 (Lv1…10)
- พาสซีฟ HP สูงสุด (`MaxHp`): 50, 100, 150, 200, 250, 300, 350, 400, 450, 500 (Lv1…10)

### ดูอัลชีลด์ (PairOfShields) · uid 267

<img src="../../icons/sk_267.png" width="40" alt="icon">

- ทรี: สกิลโล่ (ขั้น 3) · เลเวลสูงสุด: 50 · อาวุธ: โล่ · ต้องเรียนก่อน: ชีลด์อัปเปอร์คัต
- คลาสในโค้ด: `PairOfShieldsAction` · สถานะการแกะ: แกะครบจากโค้ด

> เจตจำนงอันแรงกล้าจะกลายเป็นป้อมปราการที่แข็งแกร่ง
> ติดตั้งโล่คู่
> และรักษาสถานะ Guard ระหว่างการต่อสู้
> หากติดตั้งเกราะหนักจะเพิ่มระยะ Guard
> และลดช่วงเวลาการโจมตีปกติ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, เปลี่ยนรูปแบบการโจมตี (อนุมานจาก hook ของบัพ), เพิ่มดาเมจตีปกติ
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `PairOfShieldsBuf` ระยะเวลา `LeftTime + (ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255)` วินาที [`EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 17`]: ตัวคูณตีปกติ % (`NormalAttackRate`) = `baseVIT // 5 + 10 × Lv` · ความแม่น + (`HitUp`) = `((hit + EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function))` · ความเร็วโจมตี % (`AspdRate`) = `aspdRate + ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()))`
- ตัวอ่านสกิลนี้ `BeragelungAction.IsFailure` — เงื่อนไข is failure (BeragelungAction): คืนค่า `PlayerAttackBase.IsFailure(this, status, missType)` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GuardActionManager.CheckGuardStart` — ตรวจ guard start (GuardActionManager): คืนค่า `_t378` (3 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GuardActionManager.CheckPairOfShields` — ตรวจ pair of shields (GuardActionManager): [call] `PlayerStatusBase$$CheckBodyAbility` = `PlayerActionManagerBase.get_PlayerStatus(), ArmorAbility.Heavy` เมื่อ IsGuard eq 0 AND EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCa…; [call] `MobEventScriptAttack$$CheckGuard` = `action` เมื่อ IsGuard eq 0 AND EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCa… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GuardActionManager.CheckPairOfShieldsGuard` — ตรวจ pair of shields guard (GuardActionManager): คืนค่า `(SkillActionBase.get_ActionID() eq 267 ? 1 : 0)` (3 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `NormalAttackAction.OnInitialize` — NormalAttackAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `<ActionRange>k__BackingField` = `_t1209` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.PairOfShields, out) & 1) ne 0 AND Equi…; [set] `<SkillIndividualFlag>k__BackingField` = `(((SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.K…` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.PairOfShields, out) & 1) ne 0 AND Equi… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.Damaged` — PlayerActionManager: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.SuccessAddAbnormal` — PlayerActionManager.SuccessAddAbnormal (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.CheckZeroActionDelay` — ตรวจ zero action delay (PlayerBattleManager): [call] `PlayerStatusBase$$CheckBodyAbility` = `PlayerActionManagerBase.get_PlayerStatus(), ArmorAbility.Heavy` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.PairOfShields) & 1) ne 0 (นิยามเต็มในแท็บ Variables)

### การ์ดสไตร์ค (GuardStrike) · uid 262

<img src="../../icons/sk_262.png" width="40" alt="icon">

- ทรี: สกิลโล่ (ขั้น 4) · เลเวลสูงสุด: 110 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ชีลด์แคนนอน
- คลาสในโค้ด: `GuardStrikeAction` · สถานะการแกะ: แกะครบจากโค้ด

> ต้านทานการโจมตีของศัตรูพร้อมโจมตีกลับ
> สร้างความเสียหายให้ศัตรูเมื่อ Guard ทำงาน
> พลังโจมตีจะเพิ่มตามพลัง Guard และค่าการถลุงของโล่

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), พาสซีฟ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: ไม่มีประเภท (None)
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- พาสซีฟ ตัวคูณโจมตีสกิล (`SkillAttackRate`): 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv17: *เพิ่มพลัง Guard ไปที่พลัง *ค่าการตีบวกของโล่มีผลต่อพลังสกิล

<!-- calc:begin uid=262 -->
#### การคำนวณแบบตัวเลข — GuardStrike (uid 262)
Proration: ช่อง `none` โหมด `never (IsExpDefFluctuate=false)`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +, ตั้งค่าทับ) [อาวุธรอง โล่ · ค่าตีบวก (Refine)=0 หรือ อาวุธรองอื่น (ไม่ใช่ โล่)]: **10×Lv** → 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +, ตั้งค่าทับ) [อาวุธรอง โล่ · ค่าตีบวก (Refine)=15]: **900 + 10×Lv** → 910, 920, 930, 940, 950, 960, 970, 980, 990, 1000 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, ตั้งค่าทับ) [อาวุธรอง โล่]: `(10 × Lv + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 46)) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `BonusManager.GetBonusValue` = ผลรวมโบนัส BonusType (ค่าคงที่) จากอุปกรณ์/บัพ; `PlayerStatusBase.get_BonusManager` = ค่า Bonus Manager ของ PlayerStatusBase; `BonusType.bGuardPower` = โบนัส «พลัง Guard+ค่า%» (id 46 ตรงกับข้อความไอเทม) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, ตั้งค่าทับ) [อาวุธรองอื่น (ไม่ใช่ โล่)]: **(10×Lv)%** → 10%, 20%, 30%, 40%, 50%, 60%, 70%, 80%, 90%, 100% (Lv1…10)
<!-- calc:end -->

### การ์เดียน (Guardian) · uid 265

<img src="../../icons/sk_265.png" width="40" alt="icon">

- ทรี: สกิลโล่ (ขั้น 4) · เลเวลสูงสุด: 100 · อาวุธ: โล่ · ต้องเรียนก่อน: อีจิส
- คลาสในโค้ด: `GuardianAction` · สถานะการแกะ: แกะครบจากโค้ด

> สร้างพื้นที่ลดความเสียหาย
> เพิ่มการฟื้นฟู Guard ของตัวเอง พลังโจมตีจะลดลง
> ตามจำนวนคนที่ปกป้อง แต่ค่าเฮทจะเพิ่มขึ้นจำนวนมาก
> ยิ่งค่าการถลุงสูงค่าความเสียหายก็จะยิ่งลดมาก

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `GuardianBuf` ระยะเวลา 40, 50, 60, 70, 80, 100, 120, 140, 160, 180 (Lv1…10) วินาที [`(self & 1) ≠ 0`]: ความเกลียดชัง % (`HateRate`) = `(Num * (int((Lv * 1.5)) + 15))` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · อัตราการ์ด (`Guard`) = `(Refine + 15)` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = `(Num * (int((Lv * 0.33)) + 2))` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · MATK % (`MAtkUpRate`) = `(((Lv << 1) - 30) * Num)` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ATK % (`AtkUpRate`) = `(Num * (int((Lv * 1.5)) - 20))` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ตัวคูณดาเมจที่ได้รับจากมอน (หมวดซัพพอร์ต) (`MobLastDamageRateSupport`) = `(Refine + (int((Lv * 1.5)) + 20))` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = 5 + Lv → 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 (Lv1…10) · ความเกลียดชัง % (`HateRate`) = `(((Lv - (Lv << 2)) - (Refine << 1)) - 30)` (ตัวนับที่เปลี่ยนตามเหตุการณ์)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.GetDisplayBonusCalcHate` — PlayerSecondaryStatus.GetDisplayBonusCalcHate: คืนค่า `int(frintp((fcvt(((_t1651 + 1) * 100)) + -0.5)))` (2 กรณี) (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv17: [ค่าการตีของโล่จะมีผลทำให้ผลลัพธ์ด้านล่างแข็งแกร่งยิ่งขึ้น] *เพิ่มการฟื้นฟู Guard ที่ได้จากบัฟของพวกพ้องที่ได้รับการปกป้องจากสกิลนี้ *เพิ่มความสามารถในการลดเฮทของพวกพ้องที่ได้รับการปกป้องจากสกิลนี้

### รีแพร์ชีลด์ (ShieldRepair) · uid 268

<img src="../../icons/sk_268.png" width="40" alt="icon">

- ทรี: สกิลโล่ (ขั้น 4) · เลเวลสูงสุด: 110 · อาวุธ: โล่ · ต้องเรียนก่อน: ดูอัลชีลด์
- คลาสในโค้ด: `ShieldRepairAction` · สถานะการแกะ: แกะครบจากโค้ด

> ซ่อมแซมโล่และฟื้นฟูความทนทาน
> 
> ฟื้นฟูพลัง Guard ที่ใช้ไป
> ฟื้นฟู MP ตามการฟื้นฟู Guard

**ทำงานยังไง (จากโค้ด):**
- บทบาท: แอ็กชันระบบ/อรรถประโยชน์
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration

### บาลาเกรุง (Beragelung) · uid 269

<img src="../../icons/sk_269.png" width="40" alt="icon">

- ทรี: สกิลโล่ (ขั้น 5) · เลเวลสูงสุด: 225 · อาวุธ: โล่ · ต้องเรียนก่อน: รีแพร์ชีลด์
- คลาสในโค้ด: `BeragelungAction` · สถานะการแกะ: แกะครบจากโค้ด

> การโจมตีด้วยโล่คู่ที่ใช้ได้ระหว่างใช้สกิล "ดูอัลชีลด์" เท่านั้น
> 
> โจมตีวงกว้าง 2 ครั้งและจบสกิลดูอัลชีลด์
> เพิ่มความเสียหายให้กับเป้าหมายที่เคลื่อนที่ไม่ได้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `BeragelungBuf`: ดาเมจสุดท้ายที่ทำ % (`LastDmgUpRate`) = `lastDamageRate` · MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = `attackMpRecovery`
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่

**โน้ตในเกม (ข้อความจากเกม):**
- Lv17: ทำให้เคลื่อนที่ไม่ได้หมายถึง [ผงะ], [ล้มคว่ำ] และ [หมดสติ]  ติดดีบัฟให้กับเป้าหมายเมื่อติดตั้งเกราะหนัก ดีบัฟจะอยู่ต่อเนื่อง 15 วินาที ลดต้านทานคริติคอลตามเลเวลบาลาเกรุง เพิ่มความเสียหายที่ทำได้และการฟื้นฟู MP การโจมตี หากเป้าหมายถูกทำให้เคลื่อนที่ไม่ได้

<!-- calc:begin uid=269 -->
#### การคำนวณแบบตัวเลข — Beragelung (uid 269)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `constantDamage + (shieldRefine // 5 + 1) × baseVIT` — โดยที่ `constantDamage` = `10 × Lv + 100` ; `shieldRefine` = `ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255` [`EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 17`] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseVIT` = แต้ม VIT ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseVIT (ดูแท็บ Variables)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **100 + 10×Lv** → 110, 120, 130, 140, 150, 160, 170, 180, 190, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(600 + 52.5×Lv)%** → 652.5%, 705%, 757.5%, 810%, 862.5%, 915%, 967.5%, 1020%, 1072.5%, 1125% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(400 + 35×Lv)%** → 435%, 470%, 505%, 540%, 575%, 610%, 645%, 680%, 715%, 750% (Lv1…10)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefSkill / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `localExpDefSkill` = proration ปัจจุบันของมอนในช่องสกิลกายภาพ (%); `MobActionManagerBase.get_MobStatus` = ค่า Mob Status ของ MobActionManagerBase (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpList[mobAction] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
<!-- calc:end -->

### ラスティール / ラースバーン · uid 270

<img src="../../icons/sk_270.png" width="40" alt="icon">

- ทรี: สกิลโล่ (ขั้น 5) · เลเวลสูงสุด: 225 · อาวุธ: โล่ · ต้องเรียนก่อน: การ์เดียน · ธง: CanNotUse
- ไม่มีโค้ดฝั่ง client (`flag CanNotUse (system/unreleased)`)

> No Info Data...

**ทำงานยังไง (จากโค้ด):**
- บทบาท: ไม่มีคลาสแอ็กชันฝั่ง client

