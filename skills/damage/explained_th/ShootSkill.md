# สกิลยิง (`ShootSkill`) — คำอธิบายทีละสกิล (ภาษาไทย)

สร้างอัตโนมัติด้วย `scripts/render_explained_th.py` จาก `skill_reference.json` (ข้อมูลโค้ด client ชุดล่าสุด) ไม่มีข้อความเขียนมือ แก้ไฟล์นี้ตรง ๆ จะถูกเขียนทับ ตัวเลขทั้งหมดคำนวณจากโค้ด (Code) ความหมายของชื่อ field/บทบาทแปลจากชื่อในโค้ด (Inferred) ยังไม่ได้เทียบกับตัวเลขในเกม ข้อมูลดิบทุกเส้นทางอยู่ใน `../details/ShootSkill.md`

---

<!-- calc:preface -->
> **วิธีอ่านหัวข้อ "การคำนวณแบบตัวเลข"** (สร้างอัตโนมัติด้วย `scripts/render_calc_th.py` จาก `skill_reference.json` แก้มือจะถูกเขียนทับ)
> ดาเมจต่อฮิตเดินตามขั้น `SkillCalcTemplate/CalcStep` 0→40 ตามลำดับ (Code: `SkillCalcTemplate.GetDamage`) ขั้น `+` บวกเข้าดาเมจ ขั้น `×` คูณแล้วปัดเศษทิ้ง (int) ทันทีทุกขั้น
> ลำดับหลัก: ดาเมจฐาน(7) + คงที่สกิล(8) + คงที่บัพ(9) − ป้องกันเป้า(10) + ตีแรก(11) → ×คริ(13) → ×ธาตุ(15) → ×ตัวคูณสกิล(18) → ×ตีแรก(19) → ×เสถียร(21) → +คงที่ออโต้(22) → ×Proration(23) → ×ประเภท(24) → ×ดาเมจสุดท้าย(25) → … → เพดาน/ขั้นต่ำ(35–37)
> "ฮิต N" = template ดาเมจแต่ละก้อน (ทอยคริแยกกัน) แยกตามเมธอดและตัวแปรฮิตในโค้ด (`type`, `isFirst`, `attackCount` …) ชื่อฮิต/ส่วนมาจากชื่อในโค้ด (Inferred) ตัวเลขคำนวณจากโค้ด (Code) โดยตั้งเจม/บัพเสริม = 0
> ค่าหลายก้อนในขั้นเดียวกันแบบ "บวกเข้าช่อง" จะบวกกันก่อนคูณ ส่วน "ตั้งค่าทับ" แทนที่ค่าเดิม ค่าที่ขึ้นกับสเตตัสแสดงเป็นตัวอย่างที่ 100 / 255 (และ Lv สกิลอื่น 1 / 10) ใช้สูตรที่แนบไว้คำนวณค่าอื่นเอง
<!-- calc:preface-end -->

### พาวเวอร์ชู้ต (PowerShoot) · uid 65

<img src="../../icons/sk_065.png" width="40" alt="icon">

- ทรี: สกิลยิง (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: ธนู, โบว์กัน, ลูกธนู · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `PowerShootAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีเป้าหมายด้วยพลังรุนแรง
> เวลาชาร์จจะลดลงเมื่อเลเวลเพิ่มสูงขึ้น
> มีโอกาสทำให้เป้าหมาย[ล้มคว่ำ]
> และอัตราคริติคอลจะเพิ่มขึ้นถ้าเป้าหมายติดสภาวะ[เชื่องช้า]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `tumblePercent` [อาวุธรอง ธนู และ `(mainWeaponType & 0xfffffffe) ≠ 12` หรือ อาวุธหลัก ธนู และ `(mainWeaponType & 0xfffffffe) = 12`]: **60 + 3×Lv** → 63, 66, 69, 72, 75, 78, 81, 84, 87, 90 (Lv1…10) %
- โอกาสติดสถานะ `tumblePercent` [อาวุธรองอื่น (ไม่ใช่ ธนู/โบว์กัน) และ `(mainWeaponType & 0xfffffffe) ≠ 12` หรือ อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ `(mainWeaponType & 0xfffffffe) = 12`]: **20 + 3×Lv** → 23, 26, 29, 32, 35, 38, 41, 44, 47, 50 (Lv1…10) %
- โอกาสติดสถานะ `tumblePercent` [อาวุธรอง โบว์กัน และ `(mainWeaponType & 0xfffffffe) ≠ 12` หรือ อาวุธหลัก โบว์กัน และ `(mainWeaponType & 0xfffffffe) = 12`]: **-20 + 3×Lv** → -17, -14, -11, -8, -5, -2, 1, 4, 7, 10 (Lv1…10) %
- สถานะที่ทำให้ติด: ล้มคว่ำ (Tumble)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv12: *อัตราติดล้มคว่ำ+40%
- Lv13: *เวลาชาร์จน้อยลง *อัตราติดล้มคว่ำ-40%

<!-- calc:begin uid=65 -->
#### การคำนวณแบบตัวเลข — PowerShoot (uid 65)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `ช่อง [4] ของอาร์เรย์ต่อฮิต`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 11)` และ `PlayerAttackBase.checkAbnormalPercent(this, 2, tumblePercent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0)` หรือ `!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 11)` และ `PlayerAttackBase.checkAbnormalPercent(this, 2, tumblePercent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0)`]: **(125 + 5×Lv)%** → 130%, 135%, 140%, 145%, 150%, 155%, 160%, 165%, 170%, 175% (Lv1…10)

**ใช้ร่วมทุกฮิตของ ดาเมจหลัก**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **50 + 8×Lv** → 58, 66, 74, 82, 90, 98, 106, 114, 122, 130 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 11)` หรือ `!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 11)` และ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0)` หรือ `!PlayerAttackBase.checkAbnormalPercent(this, 2, tumblePercent, playerAction)` และ `AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 11)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0)` · กิ่งที่ 1 ของ `skillRate` หรือ `AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 11)` และ `PlayerAttackBase.checkAbnormalPercent(this, 2, tumblePercent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0)` หรือ `AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 11)` และ `PlayerAttackBase.checkAbnormalPercent(this, 2, tumblePercent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `!PlayerAttackBase.checkAbnormalPercent(this, 2, tumblePercent, playerAction)` หรือ `!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 11)` และ `PlayerAttackBase.checkAbnormalPercent(this, 2, tumblePercent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0)`]: **(125 + 5×Lv)%** → 130%, 135%, 140%, 145%, 150%, 155%, 160%, 165%, 170%, 175% (Lv1…10)
<!-- calc:end -->

### บูลส์อาย (OneWheel) · uid 66

<img src="../../icons/sk_066.png" width="40" alt="icon">

- ทรี: สกิลยิง (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: ธนู, โบว์กัน, ลูกธนู · ต้องเรียนก่อน: พาวเวอร์ชู้ต · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `OneWheelAction` · สถานะการแกะ: แกะครบจากโค้ด

> ยิงซ้ำจุดเดิม
> นัดแรกจะแรงกว่านัดที่สอง
> และนัดที่สองจะแรงกว่านัดที่สาม

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 6 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

**โน้ตในเกม (ข้อความจากเกม):**
- Lv12: *พลัง+75
- Lv13: *เพิ่มอาวุธเจาะเข้า

<!-- calc:begin uid=66 -->
#### การคำนวณแบบตัวเลข — OneWheel (uid 66)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`0 lo difBreakPercent.Length` และ `1 hs difBreakPercent.Length` หรือ `0 lo difBreakPercent.Length` และ `1 lo difBreakPercent.Length` และ `2 lo difBreakPercent.Length` หรือ `0 lo difBreakPercent.Length` และ `1 lo difBreakPercent.Length` และ `2 hs difBreakPercent.Length`]: **30 + 4×Lv** → 34, 38, 42, 46, 50, 54, 58, 62, 66, 70 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรอง ธนู และ `(mainWeaponType & 0xfffffffe) ≠ 12` และ `difBreakPercent.Length > 2` และ `difBreakPercent.Length ≠ 0` และ … หรือ อาวุธรอง ธนู และ `(mainWeaponType & 0xfffffffe) ≠ 12` และ `difBreakPercent.Length > 2` และ `difBreakPercent.Length ≠ 0` และ … หรือ อาวุธรอง ธนู และ `(mainWeaponType & 0xfffffffe) ≠ 12` และ `difBreakPercent.Length > 2` และ `difBreakPercent.Length ≠ 0` และ … หรือ อาวุธหลัก ธนู และ `(mainWeaponType & 0xfffffffe) = 12` และ `difBreakPercent.Length > 2` และ `difBreakPercent.Length ≠ 0` และ … หรือ …(เงื่อนไขเต็มดูใน details)]: **(50 + 5×Lv)%** → 55%, 60%, 65%, 70%, 75%, 80%, 85%, 90%, 95%, 100% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`(mainWeaponType & 0xfffffffe) ≠ 12` และ `difBreakPercent.Length = 0` และ `0 lo difBreakPercent.Length` และ `1 hs difBreakPercent.Length` หรือ `(mainWeaponType & 0xfffffffe) ≠ 12` และ `difBreakPercent.Length = 0` และ `0 lo difBreakPercent.Length` และ `1 lo difBreakPercent.Length` และ … หรือ `(mainWeaponType & 0xfffffffe) ≠ 12` และ `difBreakPercent.Length = 0` และ `0 lo difBreakPercent.Length` และ `1 lo difBreakPercent.Length` และ … หรือ `(mainWeaponType & 0xfffffffe) = 12` และ `difBreakPercent.Length = 0` และ `0 lo difBreakPercent.Length` และ `1 hs difBreakPercent.Length` หรือ …(เงื่อนไขเต็มดูใน details)]: **(25 + 5×Lv)%** → 30%, 35%, 40%, 45%, 50%, 55%, 60%, 65%, 70%, 75% (Lv1…10)

**ใช้ร่วมทุกฮิตของ ฮิตรีแอ็กชัน (`HitReactionAssign`)**
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical)` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobBuffer.GuardUpBuff.get_GuardUpval` = ค่า Guard Upval ของ GuardUpBuff; `TryGetBuff.buff` = TryGetBuff.buff; `MobActionManagerBase.get_BuffManager` = ค่า Buff Manager ของ MobActionManagerBase (ดูแท็บ Variables)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) = 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: **25** → 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 (Lv1…10)
<!-- calc:end -->

### มีบาช็อต (MeebaShot) · uid 67

<img src="../../icons/sk_067.png" width="40" alt="icon">

- ทรี: สกิลยิง (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: ธนู, โบว์กัน, ลูกธนู · ต้องเรียนก่อน: พาวเวอร์ชู้ต · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `MeebaShotAction` · สถานะการแกะ: แกะครบจากโค้ด

> ยิงด้วยของเหลวเหนียวหนึบ
> โจมตีด้วยธาตุน้ำ เป็นธาตุคู่กับธนู
> มีโอกาสทำให้เป้าหมายติดสภาวะ[เชื่องช้า]
> ถ้าทำให้ติดเชื่องช้าได้สำเร็จ พลังจะเพิ่มขึ้นเป็นอย่างมาก

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `slowPercent` [อาวุธรอง ธนู และ `(mainWeaponType & 0xfffffffe) ≠ 12` และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก ธนู และ `(mainWeaponType & 0xfffffffe) = 12` และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธรอง ธนู และ `(mainWeaponType & 0xfffffffe) ≠ 12` และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **80 + 2×Lv** → 82, 84, 86, 88, 90, 92, 94, 96, 98, 100 (Lv1…10) %
- โอกาสติดสถานะ `slowPercent` [อาวุธรองอื่น (ไม่ใช่ ธนู/โบว์กัน) และ `(mainWeaponType & 0xfffffffe) ≠ 12` และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ `(mainWeaponType & 0xfffffffe) = 12` และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธรองอื่น (ไม่ใช่ ธนู/โบว์กัน) และ `(mainWeaponType & 0xfffffffe) ≠ 12` และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **50 + 2×Lv** → 52, 54, 56, 58, 60, 62, 64, 66, 68, 70 (Lv1…10) %
- โอกาสติดสถานะ `slowPercent` [อาวุธรอง โบว์กัน และ `(mainWeaponType & 0xfffffffe) ≠ 12` และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก โบว์กัน และ `(mainWeaponType & 0xfffffffe) = 12` และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธรอง โบว์กัน และ `(mainWeaponType & 0xfffffffe) ≠ 12` และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **20 + 2×Lv** → 22, 24, 26, 28, 30, 32, 34, 36, 38, 40 (Lv1…10) %
- สถานะที่ทำให้ติด: ช้า (Slow)
- ตัวอ่านสกิลนี้ `HuntingOneNormalAttackAction.calcPlayerToMobDamage` — HuntingOneNormalAttackAction: สูตรดาเมจผู้เล่น→มอนสเตอร์ (ใส่ค่าลง template) (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv12: *อัตราติดเชื่องช้า+30%
- Lv13: *พลัง+50 *อัตราติดเชื่องช้า-30%

<!-- calc:begin uid=67 -->
#### การคำนวณแบบตัวเลข — MeebaShot (uid 67)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) · ส่วน โบนัส (`bonus…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **50 + 5×Lv** → 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 11)` และ `PlayerAttackBase.checkAbnormalPercent(this, 11, slowPercent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0)`]: `bonusSkillRate / 100` — โดยที่ `bonusSkillRate` = `baseDEX + 50` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรอง ธนู และ `(mainWeaponType & 0xfffffffe) ≠ 12` และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธรองอื่น (ไม่ใช่ ธนู/โบว์กัน) และ `(mainWeaponType & 0xfffffffe) ≠ 12` และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก ธนู และ `(mainWeaponType & 0xfffffffe) = 12` และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19`]: **(100 + 5×Lv)%** → 105%, 110%, 115%, 120%, 125%, 130%, 135%, 140%, 145%, 150% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรอง โบว์กัน และ `(mainWeaponType & 0xfffffffe) ≠ 12` และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก โบว์กัน และ `(mainWeaponType & 0xfffffffe) = 12` และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธรอง โบว์กัน และ `(mainWeaponType & 0xfffffffe) ≠ 12` และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **(150 + 5×Lv)%** → 155%, 160%, 165%, 170%, 175%, 180%, 185%, 190%, 195%, 200% (Lv1…10)
<!-- calc:end -->

### ชู้ตมาสเตอรี่ (ShootMastary) · uid 68

<img src="../../icons/sk_068.png" width="40" alt="icon">

- ทรี: สกิลยิง (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: ธนู, โบว์กัน · ธง: StarGem
- คลาสในโค้ด: `ShootMastary` · สถานะการแกะ: แกะครบจากโค้ด

> ใช้ธนูหรือโบว์กันได้ชำนาญขึ้น
> โจมตีได้แรงขึ้นเมื่อใช้ธนูหรือโบว์กัน

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ATK อาวุธ % (`EqAtkRate`): 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 (Lv1…10)
- พาสซีฟ ATK % (`AtkRate`): 1, 1, 1, 1, 1, 1, 2, 2, 2, 2 (Lv1…10)

### สเนคแอคแทค (HideAttack) · uid 69

<img src="../../icons/sk_069.png" width="40" alt="icon">

- ทรี: สกิลยิง (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ชู้ตมาสเตอรี่ · ธง: StarGem
- คลาสในโค้ด: `HideAttackAction` · สถานะการแกะ: แกะครบจากโค้ด

> ซ่อนตัวเพื่อลดจิตอาฆาต
> ไม่เกิดเฮทจตามจำนวนครั้งที่กำหนด
> หลังใช้สกิล

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- MP ที่ใช้ [`(EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type & 0xfffffffe) = 12`]: `mp - 200` — โดยที่ `mp` = `mp - 200` [`(EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type & 0xfffffffe) = 12`]
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `HideAttackBuf` ระยะเวลา 1, 3, 4, 6, 7, 9, 10, 12, 13, 15 (Lv1…10) วินาที [`(isGemCart & 1) ≠ 0`]
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = Lv ตามที่ `HideAttackBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `QuickLoaderAction.ActionHit` — QuickLoaderAction.ActionHit: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new HideAttackBuf, 0` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBufferManager.TryGetBuf<QuickLoaderBuf>(PlayerSta… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv12: *MP ที่ใช้-200
- Lv13: *MP ที่ใช้-200

<!-- calc:begin uid=69 -->
#### การคำนวณแบบตัวเลข — HideAttack (uid 69)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `OnInitialize`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
<!-- calc:end -->

### แอร์โรว์เรน (ArrowRain) · uid 70

<img src="../../icons/sk_070.png" width="40" alt="icon">

- ทรี: สกิลยิง (ขั้น 2) · เลเวลสูงสุด: 30 · อาวุธ: ธนู, โบว์กัน, ลูกธนู · ต้องเรียนก่อน: บูลส์อาย · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `ArrowRainAction` · สถานะการแกะ: แกะครบจากโค้ด

> ยิงธนูขึ้นไปบนฟ้าจำนวนมาก
> ห่าธนูจะตกลงมาสร้างความเสียหายให้ศัตรู

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

**โน้ตในเกม (ข้อความจากเกม):**
- Lv12: *เพิ่มจำนวนครั้งการโจมตี *เพิ่มความเร็วการโจมตี *ระยะโจมตี (รัศมี) +2m
- Lv13: *พลัง+70

<!-- calc:begin uid=70 -->
#### การคำนวณแบบตัวเลข — ArrowRain (uid 70)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): 50, 60, 60, 70, 70, 80, 80, 90, 90, 100 (Lv1…10)
  - สูตร: `fixAddDamage` — โดยที่ `fixAddDamage` = `10 × int(0.5 × Lv) + 50`
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรอง ธนู และ `(mainWeaponType & 0xfffffffe) ≠ 12` และ `Lv ≥ 2` หรือ อาวุธรองอื่น (ไม่ใช่ ธนู/โบว์กัน) และ `(mainWeaponType & 0xfffffffe) ≠ 12` และ `Lv ≥ 2` หรือ อาวุธหลัก ธนู และ `(mainWeaponType & 0xfffffffe) = 12` และ `Lv ≥ 2`]: 105%, 110%, 110%, 115%, 115%, 120%, 120%, 125%, 125%, 130% (Lv1…10)
  - สูตร: `(5 × int(0.5 × Lv) + 105) / 100`
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรอง โบว์กัน และ `(mainWeaponType & 0xfffffffe) ≠ 12` และ `Lv ≥ 2` หรือ อาวุธหลัก โบว์กัน และ `(mainWeaponType & 0xfffffffe) = 12` และ `Lv ≥ 2`]: 175%, 180%, 180%, 185%, 185%, 190%, 190%, 195%, 195%, 200% (Lv1…10)
  - สูตร: `(5 × int(0.5 × Lv) + 175) / 100`
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรอง ธนู และ `(mainWeaponType & 0xfffffffe) ≠ 12` และ `Lv < 2` หรือ อาวุธรองอื่น (ไม่ใช่ ธนู/โบว์กัน) และ `(mainWeaponType & 0xfffffffe) ≠ 12` และ `Lv < 2` หรือ อาวุธหลัก ธนู และ `(mainWeaponType & 0xfffffffe) = 12` และ `Lv < 2`]: **100%** → 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรอง โบว์กัน และ `(mainWeaponType & 0xfffffffe) ≠ 12` และ `Lv < 2` หรือ อาวุธหลัก โบว์กัน และ `(mainWeaponType & 0xfffffffe) = 12` และ `Lv < 2`]: **170%** → 170%, 170%, 170%, 170%, 170%, 170%, 170%, 170%, 170%, 170% (Lv1…10)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `target.ExpDefSkill / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefSkill` = proration ช่อง Skill ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_CharacterActionManagerBase` = ค่า Character Action Manager Base ของ MobActionManagerBase (ดูแท็บ Variables)

**จำนวนฮิต / ตัวนับ**
- `damageCount` (ตั้งใน `OnInitialize`) [อาวุธรอง ธนู และ `(mainWeaponType & 0xfffffffe) ≠ 12` และ `Lv ≥ 2` หรือ อาวุธรอง ธนู และ `(mainWeaponType & 0xfffffffe) ≠ 12` และ `Lv < 2` หรือ อาวุธหลัก ธนู และ `(mainWeaponType & 0xfffffffe) = 12` และ `Lv ≥ 2`]: 2, 2, 4, 4, 4, 6, 6, 6, 8, 8 (Lv1…10)
- `LoopParam` (ตั้งใน `OnInitialize`): 1, 1, 2, 2, 2, 3, 3, 3, 4, 4 (Lv1…10)
- `damageCount` (ตั้งใน `OnInitialize`) [อาวุธรอง โบว์กัน และ `(mainWeaponType & 0xfffffffe) ≠ 12` และ `Lv ≥ 2` หรือ อาวุธรอง โบว์กัน และ `(mainWeaponType & 0xfffffffe) ≠ 12` และ `Lv < 2` หรือ อาวุธหลัก โบว์กัน และ `(mainWeaponType & 0xfffffffe) = 12` และ `Lv ≥ 2`]: 1, 1, 2, 2, 2, 3, 3, 3, 4, 4 (Lv1…10)
<!-- calc:end -->

### พาราไลซิสช็อต (ParalysisShot) · uid 71

<img src="../../icons/sk_071.png" width="40" alt="icon">

- ทรี: สกิลยิง (ขั้น 2) · เลเวลสูงสุด: 30 · อาวุธ: ธนู, โบว์กัน, ลูกธนู · ต้องเรียนก่อน: มีบาช็อต · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `ParalysisShotAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีด้วยธนูอาบยาพิษอัมพาต
> โจมตีด้วยธาตุลม เป็นธาตุคู่กับธนู
> มีโอกาสทำให้เป้าหมายติด[อัมพาต]
> ถ้าทำให้ติดอัมพาตได้สำเร็จ พลังจะเพิ่มขึ้นเป็นอย่างมาก
> และเพิ่มอัตราความเสถียรให้ตัวเองชั่วขณะเมื่อสำเร็จ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `paralysisPercent` [อาวุธหลัก โบว์กัน และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก โบว์กัน และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **50 + 2×Lv** → 52, 54, 56, 58, 60, 62, 64, 66, 68, 70 (Lv1…10) %
- โอกาสติดสถานะ `paralysisPercent` [อาวุธหลัก โบว์กัน และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก โบว์กัน และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **30 + 2×Lv** → 32, 34, 36, 38, 40, 42, 44, 46, 48, 50 (Lv1…10) %
- โอกาสติดสถานะ `paralysisPercent` [อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **70 + 2×Lv** → 72, 74, 76, 78, 80, 82, 84, 86, 88, 90 (Lv1…10) %
- โอกาสติดสถานะ `paralysisPercent` [อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **50 + 2×Lv** → 52, 54, 56, 58, 60, 62, 64, 66, 68, 70 (Lv1…10) %
- โอกาสติดสถานะ `paralysisPercent` [อาวุธหลัก ธนู และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก ธนู และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **90 + 2×Lv** → 92, 94, 96, 98, 100, 102, 104, 106, 108, 110 (Lv1…10) %
- โอกาสติดสถานะ `paralysisPercent` [อาวุธหลัก ธนู และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก ธนู และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **70 + 2×Lv** → 72, 74, 76, 78, 80, 82, 84, 86, 88, 90 (Lv1…10) %
- สถานะที่ทำให้ติด: อัมพาต (Paralysis)
- บัพ `ParalysisShotBuf` ระยะเวลา `time` วินาที: ความเสถียร (`Stable`) = Lv → 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
- ตัวอ่านสกิลนี้ `HuntingOneNormalAttackAction.calcPlayerToMobDamage` — HuntingOneNormalAttackAction: สูตรดาเมจผู้เล่น→มอนสเตอร์ (ใส่ค่าลง template) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.ReceiveAttack` — MobaPlayerActionManager.ReceiveAttack: [call] `ParalysisShotAction$$CalcBufferTime` = `MobaPlayerActionManager.get_PlayerStatus()` เมื่อ GetServerHitTypeV2.reactionType(mobResponseData.HitType) ne 1 AND GetServerHitTypeV2.hitType(mobResponseData.HitType) n… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv12: *พลัง+100 *อัตราติดอัมพาต+20%
- Lv13: *พลัง+150 *อัตราติดอัมพาต-20%
- Lv19: *อัตราติดอัมพาต+20%

<!-- calc:begin uid=71 -->
#### การคำนวณแบบตัวเลข — ParalysisShot (uid 71)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) · ส่วน โบนัส (`bonus…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **100 + 20×Lv** → 120, 140, 160, 180, 200, 220, 240, 260, 280, 300 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 6)` และ `PlayerAttackBase.checkAbnormalPercent(this, 6, paralysisPercent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0)`]: `bonusSkillRate / 100` — โดยที่ `bonusSkillRate` = `baseDEX + 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก โบว์กัน และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก โบว์กัน และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก โบว์กัน และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **(260 + 5×Lv)%** → 265%, 270%, 275%, 280%, 285%, 290%, 295%, 300%, 305%, 310% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **(110 + 5×Lv)%** → 115%, 120%, 125%, 130%, 135%, 140%, 145%, 150%, 155%, 160% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ธนู และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก ธนู และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก ธนู และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **(210 + 5×Lv)%** → 215%, 220%, 225%, 230%, 235%, 240%, 245%, 250%, 255%, 260% (Lv1…10)
<!-- calc:end -->

### ลองเรนจ์ (LongRangeMastary) · uid 72

<img src="../../icons/sk_072.png" width="40" alt="icon">

- ทรี: สกิลยิง (ขั้น 2) · เลเวลสูงสุด: 30 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ชู้ตมาสเตอรี่
- คลาสในโค้ด: `LongRangeMastary` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีจากระยะไกลได้อย่างชำนาญ
> พลังโจมตีจะเพิ่มขึ้นเมื่อโจมตีจากระยะห่างเกิน 8m ขึ้นไป

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ดาเมจสุดท้าย % (`LastDmgRate`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)

### สไนป์ (Sniping) · uid 73

<img src="../../icons/sk_073.png" width="40" alt="icon">

- ทรี: สกิลยิง (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: ธนู, โบว์กัน, ลูกธนู · ต้องเรียนก่อน: บูลส์อาย · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `SnipingAction` · สถานะการแกะ: แกะครบจากโค้ด

> เล็งเป้าหมายที่จุดอ่อน
> เวลาชาร์จจะลดลงเมื่อเลเวลเพิ่มสูงขึ้น
> มีโอกาสทำให้เป้าหมายอยู่ในสภาวะ[ลดการป้องกัน]
> ถ้าศัตรูอยู่ในสภาวะ[มืดบอด]จะโจมตีโดน 100%

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `breakingPercent` [อาวุธรอง ธนู และ `(mainWeaponType & 0xfffffffe) ≠ 12` หรือ อาวุธหลัก ธนู และ `(mainWeaponType & 0xfffffffe) = 12`]: **80 + 2×Lv** → 82, 84, 86, 88, 90, 92, 94, 96, 98, 100 (Lv1…10) %
- โอกาสติดสถานะ `breakingPercent` [อาวุธรอง ลูกธนู และ `(mainWeaponType & 0xfffffffe) ≠ 12` หรือ อาวุธรองอื่น (ไม่ใช่ ลูกธนู/ธนู/โบว์กัน) และ `(mainWeaponType & 0xfffffffe) ≠ 12` หรือ อาวุธหลัก ลูกธนู และ `(mainWeaponType & 0xfffffffe) = 12`]: **50 + 2×Lv** → 52, 54, 56, 58, 60, 62, 64, 66, 68, 70 (Lv1…10) %
- โอกาสติดสถานะ `breakingPercent` [อาวุธรอง โบว์กัน และ `(mainWeaponType & 0xfffffffe) ≠ 12` หรือ อาวุธหลัก โบว์กัน และ `(mainWeaponType & 0xfffffffe) = 12`]: **-10 + 2×Lv** → -8, -6, -4, -2, 0, 2, 4, 6, 8, 10 (Lv1…10) %
- สถานะที่ทำให้ติด: เกราะแตก (Breaking)
- บัพ `SnipingBuf`: อัตราคริ + (`CrtUp`) = -10 + Lv → -9, -8, -7, -6, -5, -4, -3, -2, -1, 0 (Lv1…10)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv12: *พลัง+200 *อัตราติดลดการป้องกัน+30% *ลดปริมาณการลดอัตราคริติคอล
- Lv13: *พลัง+300 *ความเสถียร+20% *ใช้เวลาในการชาร์จน้อยลง *อัตราติดลดการป้องกัน-60%

<!-- calc:begin uid=73 -->
#### การคำนวณแบบตัวเลข — Sniping (uid 73)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **300 + 10×Lv** → 310, 320, 330, 340, 350, 360, 370, 380, 390, 400 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรอง ธนู และ `(mainWeaponType & 0xfffffffe) ≠ 12` หรือ อาวุธหลัก ธนู และ `(mainWeaponType & 0xfffffffe) = 12`]: **(900 + 10×Lv)%** → 910%, 920%, 930%, 940%, 950%, 960%, 970%, 980%, 990%, 1000% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรอง ลูกธนู และ `(mainWeaponType & 0xfffffffe) ≠ 12` หรือ อาวุธรองอื่น (ไม่ใช่ ลูกธนู/ธนู/โบว์กัน) และ `(mainWeaponType & 0xfffffffe) ≠ 12` หรือ อาวุธหลัก ลูกธนู และ `(mainWeaponType & 0xfffffffe) = 12`]: **(700 + 10×Lv)%** → 710%, 720%, 730%, 740%, 750%, 760%, 770%, 780%, 790%, 800% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรอง โบว์กัน และ `(mainWeaponType & 0xfffffffe) ≠ 12` หรือ อาวุธหลัก โบว์กัน และ `(mainWeaponType & 0xfffffffe) = 12`]: **(1000 + 10×Lv)%** → 1010%, 1020%, 1030%, 1040%, 1050%, 1060%, 1070%, 1080%, 1090%, 1100% (Lv1…10)
<!-- calc:end -->

### สโมคดัส (SmokeDust) · uid 74

<img src="../../icons/sk_074.png" width="40" alt="icon">

- ทรี: สกิลยิง (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: ธนู, โบว์กัน, ลูกธนู · ต้องเรียนก่อน: พาราไลซิสช็อต · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `SmokeDustAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีด้วยหมอกควัน
> โจมตีด้วยธาตุมืด เป็นธาตุคู่กับธนู
> มีโอกาสทำให้เป้าหมายติด[มืดบอด]
> ถ้าทำให้ติดมืดบอดได้สำเร็จ พลังจะเพิ่มขึ้นเป็นอย่างมาก
> เพิ่มอัตราความแม่นให้ตัวเองชั่วขณะเมื่อใช้สำเร็จ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `blindnessPercent` [อาวุธหลัก โบว์กัน และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก โบว์กัน และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **50 + 2×Lv** → 52, 54, 56, 58, 60, 62, 64, 66, 68, 70 (Lv1…10) %
- โอกาสติดสถานะ `blindnessPercent` [อาวุธหลัก โบว์กัน และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก โบว์กัน และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **30 + 2×Lv** → 32, 34, 36, 38, 40, 42, 44, 46, 48, 50 (Lv1…10) %
- โอกาสติดสถานะ `blindnessPercent` [อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **70 + 2×Lv** → 72, 74, 76, 78, 80, 82, 84, 86, 88, 90 (Lv1…10) %
- โอกาสติดสถานะ `blindnessPercent` [อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **50 + 2×Lv** → 52, 54, 56, 58, 60, 62, 64, 66, 68, 70 (Lv1…10) %
- โอกาสติดสถานะ `blindnessPercent` [อาวุธหลัก ธนู และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก ธนู และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **90 + 2×Lv** → 92, 94, 96, 98, 100, 102, 104, 106, 108, 110 (Lv1…10) %
- โอกาสติดสถานะ `blindnessPercent` [อาวุธหลัก ธนู และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก ธนู และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **70 + 2×Lv** → 72, 74, 76, 78, 80, 82, 84, 86, 88, 90 (Lv1…10) %
- สถานะที่ทำให้ติด: ตาบอด (Blindness)
- บัพ `SmokeDustBuf` ระยะเวลา `time` วินาที: ความแม่น + (`HitUp`) = 5, 12, 19, 28, 37, 48, 59, 72, 85, 100 (Lv1…10)
- ตัวอ่านสกิลนี้ `HuntingOneNormalAttackAction.calcPlayerToMobDamage` — HuntingOneNormalAttackAction: สูตรดาเมจผู้เล่น→มอนสเตอร์ (ใส่ค่าลง template) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.ReceiveAttack` — MobaPlayerActionManager.ReceiveAttack: [call] `SmokeDustAction$$CalcBufferTime` = `MobaPlayerActionManager.get_PlayerStatus()` เมื่อ GetServerHitTypeV2.reactionType(mobResponseData.HitType) ne 1 AND GetServerHitTypeV2.hitType(mobResponseData.HitType) n…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new SmokeDustBuf, 0` เมื่อ GetServerHitTypeV2.reactionType(mobResponseData.HitType) ne 1 AND GetServerHitTypeV2.hitType(mobResponseData.HitType) n… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv12: *พลัง+200 *อัตราติดมืดบอด+20%
- Lv13: *พลัง+250 *อัตราติดมืดบอด-20%
- Lv19: *อัตราติดมืดบอด+20%

<!-- calc:begin uid=74 -->
#### การคำนวณแบบตัวเลข — SmokeDust (uid 74)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) · ส่วน โบนัส (`bonus…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **200 + 30×Lv** → 230, 260, 290, 320, 350, 380, 410, 440, 470, 500 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 7)` และ `PlayerAttackBase.checkAbnormalPercent(this, 7, blindnessPercent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0)`]: `bonusSkillRate / 100` — โดยที่ `bonusSkillRate` = `baseDEX + 200` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก โบว์กัน และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก โบว์กัน และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก โบว์กัน และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **(370 + 5×Lv)%** → 375%, 380%, 385%, 390%, 395%, 400%, 405%, 410%, 415%, 420% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **(120 + 5×Lv)%** → 125%, 130%, 135%, 140%, 145%, 150%, 155%, 160%, 165%, 170% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ธนู และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก ธนู และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก ธนู และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **(320 + 5×Lv)%** → 325%, 330%, 335%, 340%, 345%, 350%, 355%, 360%, 365%, 370% (Lv1…10)
<!-- calc:end -->

### ควิกดรอ (QuickDraw) · uid 75

<img src="../../icons/sk_075.png" width="40" alt="icon">

- ทรี: สกิลยิง (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ลองเรนจ์
- คลาสในโค้ด: `QuickDraw` · สถานะการแกะ: แกะครบจากโค้ด

> เตรียมการอย่างรวดเร็วสำหรับการเคลื่อนไหวถัดไป
> มีโอกาสฟื้นฟู MP เล็กน้อย
> เมื่อโจมตีด้วยสกิลนี้สำเร็จ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ โอกาสทำงาน % (`Trigger`): 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 (Lv1…10)

### เดสทอลก์ช็อต (DeathTorqueShot) · uid 79

<img src="../../icons/sk_079.png" width="40" alt="icon">

- ทรี: สกิลยิง (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: ธนู, โบว์กัน · ธง: NoMarketSearch, MercenaryCanUseSkill
- คลาสในโค้ด: `DeathTorqueShotAction` · สถานะการแกะ: แกะครบจากโค้ด

> เทคนิคการยิงที่เจาะเกราะที่แข็งแกร่ง
> เป็นการโจมตีพิเศษที่อัตราคริติคอลสูงแต่อัตราความแม่นต่ำ
> ถ้าเล็งตรงเป้าส่วนที่ทำลายได้จะปรากฏนานขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `DeathTorqueShotBuf`: ความแม่น % (`HitRate`) = -100, -100, -99, -97, -95, -93, -91, -88, -84, -80 (Lv1…10) · อัตราคริ + (`CrtUp`) = 25, 27, 29, 33, 37, 43, 49, 57, 65, 75 (Lv1…10)
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่

<!-- calc:begin uid=79 -->
#### การคำนวณแบบตัวเลข — DeathTorqueShot (uid 79)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **200** → 200, 200, 200, 200, 200, 200, 200, 200, 200, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ธนู · DEX รวม=100, STR รวม=100 หรือ อาวุธหลัก โบว์กัน · DEX รวม=100]: **(600 + 10×Lv)%** → 610%, 620%, 630%, 640%, 650%, 660%, 670%, 680%, 690%, 700% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ธนู · DEX รวม=100, STR รวม=255 หรือ อาวุธหลัก ธนู · DEX รวม=255, STR รวม=100]: **(677 + 10×Lv)%** → 687%, 697%, 707%, 717%, 727%, 737%, 747%, 757%, 767%, 777% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ธนู · DEX รวม=255, STR รวม=255 หรือ อาวุธหลัก โบว์กัน · DEX รวม=255]: **(755 + 10×Lv)%** → 765%, 775%, 785%, 795%, 805%, 815%, 825%, 835%, 845%, 855% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน)]: **(500 + 10×Lv)%** → 510%, 520%, 530%, 540%, 550%, 560%, 570%, 580%, 590%, 600% (Lv1…10)
<!-- calc:end -->

### ครอสสเฟียร์ (CrossFire) · uid 76

<img src="../../icons/sk_076.png" width="40" alt="icon">

- ทรี: สกิลยิง (ขั้น 4) · เลเวลสูงสุด: 150 · อาวุธ: ธนู, โบว์กัน · ต้องเรียนก่อน: แอร์โรว์เรน · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `CrossFireAction` · สถานะการแกะ: แกะครบจากโค้ด

> ชาร์จสกิล5 เลเวล
> โจมตีและสร้างความเสียหายให้เป้าหมายเป็นเส้นตรง
> พลังจะเพิ่มขึ้นตามปริมาณที่สะสมไว้และเพิ่มการโจมตี
> จะเพิ่มการโจมตีอีกเมื่อตรงตามเงื่อนไข

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- MP ที่ใช้: 400
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `CrossFireBuf`: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `chargeLevel` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`
- ตัวอ่านสกิลนี้ `CrossFireAction.OnInitialize` — CrossFireAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `mp` = `((SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Cr…`; [set] `<SkillIndividualFlag>k__BackingField` = `SkillBufferDataBase.GetParam(50)` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.CrossFire, out) & 1) ne 0 AND TryGetBu…; [set] `chargeLevel` = `SkillBufferDataBase.GetParam(50)` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.CrossFire, out) & 1) ne 0 AND TryGetBu… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.GetSkillTargetType` — MobaPlayerActionManager.GetSkillTargetType: คืนค่า `MasterSkillDataManager.GetSkillMaster(Singleton<MasterSkillDataManager>.get_Instance(), SkillId.CloningTechnique).TargetType` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.GetSkillTargetType` — PlayerActionManager.GetSkillTargetType: คืนค่า `MasterSkillDataManager.GetSkillMaster(Singleton<MasterSkillDataManager>.get_Instance(), SkillId.CloningTechnique).TargetType` (11 กรณี) (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv12: *พลัง+50 *พลังเพิ่มตามค่า DEX ระยะโจมตี (แนวนอน)+1m
- Lv13: *พลังของกระสุนเพิ่มเติม +100 *พลังเจาะทะลุของกระสุนเพิ่มขึ้นตามค่า DEX

<!-- calc:begin uid=76 -->
#### การคำนวณแบบตัวเลข — CrossFire (uid 76)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `type = 0` · ส่วน หลัก (`main…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **300 + 10×Lv** → 310, 320, 330, 340, 350, 360, 370, 380, 390, 400 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ธนู]: ขึ้นกับ `chargeLevel` — สูตร `(50 × Lv + baseDEX // 5 + 450) × chargeLevel / 100` — โดยที่ `chargeLevel` = `SkillBufferDataBase.GetParam(50)` [อาวุธหลัก โบว์กัน และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 76) ≠ 0` หรือ อาวุธหลัก ธนู และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 76) ≠ 0` หรือ อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 76) ≠ 0`] หรือ `SkillIndividualFlag` หรือ `chargeLevel + 1` [`!CountBufferBase.get_Peak()` และ `IsInstanceOf(actarAction, MercenaryActionManager) ≠ 1` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 85) ≠ 0` และ `chargeLevel < maxChargeLevel`] ; `SkillIndividualFlag` = `SkillBufferDataBase.GetParam(50)` [อาวุธหลัก โบว์กัน และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 76) ≠ 0` หรือ อาวุธหลัก ธนู และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 76) ≠ 0` หรือ อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 76) ≠ 0`] หรือ `chargeLevel + 1` [`!CountBufferBase.get_Peak()` และ `IsInstanceOf(actarAction, MercenaryActionManager) ≠ 1` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 85) ≠ 0` และ `chargeLevel < maxChargeLevel`] หรือ `chargeLevel` [`IsInstanceOf(actarAction, MercenaryActionManager) ≠ 1`]
  - (ส่วนที่เหลือขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้ ใช้สูตรด้านบน)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก โบว์กัน หรือ อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน)]: ขึ้นกับ `chargeLevel` — สูตร `(50 × Lv + 400) × chargeLevel / 100` — โดยที่ `chargeLevel` = `SkillBufferDataBase.GetParam(50)` [อาวุธหลัก โบว์กัน และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 76) ≠ 0` หรือ อาวุธหลัก ธนู และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 76) ≠ 0` หรือ อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 76) ≠ 0`] หรือ `SkillIndividualFlag` หรือ `chargeLevel + 1` [`!CountBufferBase.get_Peak()` และ `IsInstanceOf(actarAction, MercenaryActionManager) ≠ 1` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 85) ≠ 0` และ `chargeLevel < maxChargeLevel`] ; `SkillIndividualFlag` = `SkillBufferDataBase.GetParam(50)` [อาวุธหลัก โบว์กัน และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 76) ≠ 0` หรือ อาวุธหลัก ธนู และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 76) ≠ 0` หรือ อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 76) ≠ 0`] หรือ `chargeLevel + 1` [`!CountBufferBase.get_Peak()` และ `IsInstanceOf(actarAction, MercenaryActionManager) ≠ 1` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 85) ≠ 0` และ `chargeLevel < maxChargeLevel`] หรือ `chargeLevel` [`IsInstanceOf(actarAction, MercenaryActionManager) ≠ 1`]

  | chargeLevel | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | 450% | 500% | 550% | 600% | 650% | 700% | 750% | 800% | 850% | 900% |
  | 2 | 900% | 1000% | 1100% | 1200% | 1300% | 1400% | 1500% | 1600% | 1700% | 1800% |
  | 3 | – | – | – | 1800% | 1950% | 2100% | 2250% | 2400% | 2550% | 2700% |
  | 4 | – | – | – | – | – | – | 3000% | 3200% | 3400% | 3600% |
  | 5 | – | – | – | – | – | – | – | – | – | 4500% |

  ระดับสูงสุดต่อเลเวลสกิล: Lv1=2, Lv2=2, Lv3=2, Lv4=3, Lv5=3, Lv6=3, Lv7=4, Lv8=4, Lv9=4, Lv10=5 (`–` = เลเวลนั้นชาร์จไม่ถึง)

**ฮิต 2: `calcPlayerToMobDamage` (ดาเมจหลัก) — `type = 1` · ส่วน รอง (`sub…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **300 + 10×Lv** → 310, 320, 330, 340, 350, 360, 370, 380, 390, 400 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ธนู หรือ อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน)]: **200%** → 200%, 200%, 200%, 200%, 200%, 200%, 200%, 200%, 200%, 200% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก โบว์กัน]: **300%** → 300%, 300%, 300%, 300%, 300%, 300%, 300%, 300%, 300%, 300% (Lv1…10)

**กิ่งที่ค่าเป็น 0 ทุกขั้น** (กิ่ง default ในโค้ด ไม่ทำดาเมจ): `calcPlayerToMobDamage` (ดาเมจหลัก) — `type ≠ 0`, `type ≠ 1`, `type ≠ 2`

**ใช้ร่วมทุกฮิตของ ดาเมจหลัก**
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `target.ExpDefSkill / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefSkill` = proration ช่อง Skill ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_CharacterActionManagerBase` = ค่า Character Action Manager Base ของ MobActionManagerBase (ดูแท็บ Variables)
<!-- calc:end -->

### อาร์มเบรค (ArmBreak) · uid 77

<img src="../../icons/sk_077.png" width="40" alt="icon">

- ทรี: สกิลยิง (ขั้น 4) · เลเวลสูงสุด: 150 · อาวุธ: ธนู, โบว์กัน, ลูกธนู · ต้องเรียนก่อน: สโมคดัส · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `ArmBreakAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีแขนของเป้าหมายเพื่อลดพลังโจมตี
> โจมตีด้วยไร้ธาตุ เป็นธาตุคู่กับธนู
> มีโอกาสทำให้เป้าหมายติดสภาวะ[เฉื่อยชา]
> ถ้าทำให้ติดเฉื่อยชาได้สำเร็จ พลังจะเพิ่มขึ้นเป็นอย่างมาก

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `abnormalPercent` [อาวุธหลัก โบว์กัน และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก โบว์กัน และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **50 + 2×Lv** → 52, 54, 56, 58, 60, 62, 64, 66, 68, 70 (Lv1…10) %
- โอกาสติดสถานะ `abnormalPercent` [อาวุธหลัก โบว์กัน และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก โบว์กัน และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **30 + 2×Lv** → 32, 34, 36, 38, 40, 42, 44, 46, 48, 50 (Lv1…10) %
- โอกาสติดสถานะ `abnormalPercent` [อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **70 + 2×Lv** → 72, 74, 76, 78, 80, 82, 84, 86, 88, 90 (Lv1…10) %
- โอกาสติดสถานะ `abnormalPercent` [อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **50 + 2×Lv** → 52, 54, 56, 58, 60, 62, 64, 66, 68, 70 (Lv1…10) %
- โอกาสติดสถานะ `abnormalPercent` [อาวุธหลัก ธนู และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก ธนู และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **90 + 2×Lv** → 92, 94, 96, 98, 100, 102, 104, 106, 108, 110 (Lv1…10) %
- โอกาสติดสถานะ `abnormalPercent` [อาวุธหลัก ธนู และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก ธนู และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **70 + 2×Lv** → 72, 74, 76, 78, 80, 82, 84, 86, 88, 90 (Lv1…10) %
- สถานะที่ทำให้ติด: อ่อนแอ (Weak)
- ตัวอ่านสกิลนี้ `HuntingOneNormalAttackAction.calcPlayerToMobDamage` — HuntingOneNormalAttackAction: สูตรดาเมจผู้เล่น→มอนสเตอร์ (ใส่ค่าลง template) (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv12: *พลัง +300 *อัตราติดเฉื่อยชา +20%
- Lv13: *พลัง +350 *อัตราติดเฉื่อยชา -20%
- Lv19: *อัตราติดเฉื่อยชา +20%

<!-- calc:begin uid=77 -->
#### การคำนวณแบบตัวเลข — ArmBreak (uid 77)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) · ส่วน โบนัส (`bonus…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **300 + 40×Lv** → 340, 380, 420, 460, 500, 540, 580, 620, 660, 700 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 15)` และ `PlayerAttackBase.checkAbnormalPercent(this, 15, abnormalPercent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0)`]: `bonusSkillRate / 100` — โดยที่ `bonusSkillRate` = `baseDEX + 300` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก โบว์กัน และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก โบว์กัน และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก โบว์กัน และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **(480 + 5×Lv)%** → 485%, 490%, 495%, 500%, 505%, 510%, 515%, 520%, 525%, 530% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลักอื่น (ไม่ใช่ ธนู/โบว์กัน) และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **(130 + 5×Lv)%** → 135%, 140%, 145%, 150%, 155%, 160%, 165%, 170%, 175%, 180% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ธนู และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก ธนู และ อาวุธรองอื่น (ไม่ใช่ ลูกธนู) และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 19` หรือ อาวุธหลัก ธนู และ อาวุธรอง ลูกธนู และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 19`]: **(430 + 5×Lv)%** → 435%, 440%, 445%, 450%, 455%, 460%, 465%, 470%, 475%, 480% (Lv1…10)
<!-- calc:end -->

### เดคอยชูตเตอร์ (DecoyShooter) · uid 78

<img src="../../icons/sk_078.png" width="40" alt="icon">

- ทรี: สกิลยิง (ขั้น 4) · เลเวลสูงสุด: 150 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ควิกดรอ
- คลาสในโค้ด: `DecoyShooterAction` · สถานะการแกะ: แกะครบจากโค้ด

> สร้างร่างแยกและโจมตี
> ร่างแยกจะโจมตีศัตรูที่เป็นเป้าหมายในระยะโจมตี
> การโจมตีของร่างแยกจะเป็นการโจมตีปกติ
> แต่จะไม่มีการปันส่วน

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: ไม่มีประเภท (None)
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- ตัวอ่านสกิลนี้ `MobaPlayerBattleManager.StartDetectionDecoyShooter` — MobaPlayerBattleManager.StartDetectionDecoyShooter (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.StartDetectionDecoyShooter` — PlayerBattleManager.StartDetectionDecoyShooter (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=78 -->
#### การคำนวณแบบตัวเลข — DecoyShooter (uid 78)
Proration: ช่อง `none` โหมด `never (ExpType None: no proration slot)`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `isFirst = 0`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `skillRate / 100` — โดยที่ `skillRate` = `gemCart(402, [4]) + int(GemCartBufferManager.GetNormalAttackRate(PlayerStatusBase.get_GemCartBuffManager())) + 8 × Lv + 20` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefNormal / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `localExpDefNormal` = proration ปัจจุบันของมอนในช่องตีปกติ (%, เริ่ม 100, ถูกบีบอยู่ระหว่าง ; `MobActionManagerBase.get_MobStatus` = ค่า Mob Status ของ MobActionManagerBase (ดูแท็บ Variables)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `OnInitialize`): `DecoyShooterAction.CalcDuration(IPlayerStatusCalculator.GetNextAtkTime(PlayerStatusBase.get_SecondaryStatus()), Lv) ÷ 2`
<!-- calc:end -->

### คู่หูนักล่า (HuntingOne) · uid 87

<img src="../../icons/sk_087.png" width="40" alt="icon">

- ทรี: สกิลยิง (ขั้น 4) · เลเวลสูงสุด: 150 · อาวุธ: ธนู, โบว์กัน · ต้องเรียนก่อน: สเนคแอคแทค
- คลาสในโค้ด: `HuntingOneAction` · สถานะการแกะ: แกะครบจากโค้ด

> เรียกคู่หูนักล่ามาร่วมต่อสู้
> คู่หูจะโจมตีทุกๆ สองสามวินาที และเมื่อใช้สกิลยิง
> ตามความเคยชินตามปกติโดนเป้าหมายจะทำให้สแต็คเพิ่มขึ้น
> ช่วยเพิ่มความแข็งแกร่งให้กับการโจมตีครั้งต่อไปของคู่หู

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- MP ที่ใช้ [มีบัพ AvoidUp]: 0
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `HuntingOneBuf`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `GameManager.ReceiveSummons` — GameManager.ReceiveSummons (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `HuntingOneAction.OnInitialize` — HuntingOneAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `mp` = `0` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.HuntingOne) & 1) ne 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `HuntingOneActionManager.BattleReservation` — HuntingOneActionManager.BattleReservation (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `HuntingOneActionManager.SupportResevation` — HuntingOneActionManager.SupportResevation (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv12: [ได้รับผลแบบเดียวกันเมื่อใช้กับโบว์กัน] เมื่อพลังชีวิตหมดและยังมีสมาชิกปาร์ตี้เหลืออยู่ คู่หูจะช่วยปฐมพยาบาลก่อนออกจากการต่อสู้

### รีโทรเกรดชอท (JumpbackShot) · uid 80

<img src="../../icons/sk_080.png" width="40" alt="icon">

- ทรี: สกิลยิง (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: ธนู · ต้องเรียนก่อน: ครอสสเฟียร์
- คลาสในโค้ด: `JumpbackShotAction` · สถานะการแกะ: แกะครบจากโค้ด

> สกิลการยิงศัตรูขณะล่าถอย
> โจมตีเป็นเส้นตรงและจะหมายหัวเป้าหมาย
> ที่มี HP มากที่สุด
> เปิดใช้แบบไม่ต้องถอยโดยการกดปุ่มเคลื่อนที่ไปข้างหน้า

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `JumpbackShotProtectionBuf`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- บัพ `JumpBackShotBuf`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `JumpbackShotAction.ReceiveAttackResult` — JumpbackShotAction.ReceiveAttackResult: [call] `MobBuffManager$$RemoveBuff` = `MobActionManagerBase.get_BuffManager(MobManager.GetMobActionManager(TargetableListManager…` เมื่อ SkillManager.GetSkillLv(PlayerDataManager.get_SkillManager(PlayerDataManager.GetPlayerDataManager()), SkillId.JumpbackS…; [call] `MobBuffManager$$CreateBuff` = `?idx` เมื่อ SkillManager.GetSkillLv(PlayerDataManager.get_SkillManager(PlayerDataManager.GetPlayerDataManager()), SkillId.JumpbackS…; [call] `MobBuffManager$$AddBuff` = `MobActionManagerBase.get_BuffManager(MobManager.GetMobActionManager(TargetableListManager…` เมื่อ SkillManager.GetSkillLv(PlayerDataManager.get_SkillManager(PlayerDataManager.GetPlayerDataManager()), SkillId.JumpbackS… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerBattleManager.PursuitJumpbackShotAttack` — MobaPlayerBattleManager.PursuitJumpbackShotAttack: [call] `JumpBackShotBuf$$Next` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.JumpbackShot), targetAct…` เมื่อ (SkillActionBase.op_Equality(SkillFactory.CreateSkill(SkillId.JumpbackShotPursuit), 0) & 1) eq 0 AND (SkillBufferManage…; [call] `SkillActionBase$$SetMainTarget` = `SkillFactory.CreateSkill(SkillId.JumpbackShotPursuit), targetActionManager` เมื่อ (SkillActionBase.op_Equality(SkillFactory.CreateSkill(SkillId.JumpbackShotPursuit), 0) & 1) eq 0 AND (SkillBufferManage…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new JumpBackShotBuf, 0` เมื่อ (SkillActionBase.op_Equality(SkillFactory.CreateSkill(SkillId.JumpbackShotPursuit), 0) & 1) eq 0 AND (SkillBufferManage… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.PursuitJumpbackShotAttack` — PlayerBattleManager.PursuitJumpbackShotAttack: [call] `JumpBackShotBuf$$Next` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.JumpbackShot), targetAct…` เมื่อ (SkillActionBase.op_Equality(SkillFactory.CreateSkill(SkillId.JumpbackShotPursuit), 0) & 1) eq 0 AND (SkillBufferManage…; [call] `SkillActionBase$$SetMainTarget` = `SkillFactory.CreateSkill(SkillId.JumpbackShotPursuit), targetActionManager` เมื่อ (SkillActionBase.op_Equality(SkillFactory.CreateSkill(SkillId.JumpbackShotPursuit), 0) & 1) eq 0 AND (SkillBufferManage…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new JumpBackShotBuf, 0` เมื่อ (SkillActionBase.op_Equality(SkillFactory.CreateSkill(SkillId.JumpbackShotPursuit), 0) & 1) eq 0 AND (SkillBufferManage… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv12: [ผลของการหมายหัว] ลดอัตราหลบหลีกของเป้าหมายที่ถูกหมายหัว *สมาชิกในปาร์ตี้จะมองเห็นการหมายหัวด้วย  สร้างความเสียหายเพิ่มเติมเมื่อโจมตีโดนเป้าหมาย ที่ถูกหมายหัวด้วยสกิลยิงหรือสกิลฮันเตอร์ และพลังจะเพิ่มขึ้นอย่างต่อเนื่องจนถึงจำนวนครั้วที่กำหนด

<!-- calc:begin uid=80 -->
#### การคำนวณแบบตัวเลข — JumpbackShot (uid 80)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **300** → 300, 300, 300, 300, 300, 300, 300, 300, 300, 300 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `skillRate / 100` — โดยที่ `skillRate` = `50 × Lv + baseDEX + 500` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
<!-- calc:end -->

### พาราโบลาแคนนอน (ParabolaCannon) · uid 81

<img src="../../icons/sk_081.png" width="40" alt="icon">

- ทรี: สกิลยิง (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: ธนู, โบว์กัน, ลูกธนู · ต้องเรียนก่อน: อาร์มเบรค
- คลาสในโค้ด: `ParabolaCannonAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีโดยยิงกระสุนเป็นแนวโค้งพาราโบลา
> ยิ่งเป้าหมายอยู่ไกลกระสุนก็จะยิ่งโดนเร็วขึ้น
> มีโอกาสที่จะทำให้ศัตรูติด[นิ่งเงียบ]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: ใบ้ (Silent)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv12: [ได้รับผลแบบเดียวกันเมื่อใช้กับโบว์กัน] *หากกดปุ่มค้างไว้ตอนใช้สกิลจะเป็นการกลิ้งตัว *เมื่อยิงโดนหรือตกกระทบจะกลายเป็นกับดักที่ทำงานในอีก 1 วินาที *กับดักมีโอกาสทำให้ติด[นิ่งเงียบ]เพิ่มขึ้นอย่างมาก

<!-- calc:begin uid=81 -->
#### การคำนวณแบบตัวเลข — ParabolaCannon (uid 81)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `state ≠ 0` · ส่วน trap (`trap…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **400** → 400, 400, 400, 400, 400, 400, 400, 400, 400, 400 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `trapSkillRate / 100` — โดยที่ `trapSkillRate` = `25 × Lv + baseDEX + 1000` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**ฮิต 2: `calcPlayerToMobDamage` (ดาเมจหลัก) — `state = 0`**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **40×Lv** → 40, 80, 120, 160, 200, 240, 280, 320, 360, 400 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [DEX รวม=100]: **(850 + 25×Lv)%** → 875%, 900%, 925%, 950%, 975%, 1000%, 1025%, 1050%, 1075%, 1100% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [DEX รวม=255]: **(1005 + 25×Lv)%** → 1030%, 1055%, 1080%, 1105%, 1130%, 1155%, 1180%, 1205%, 1230%, 1255% (Lv1…10)
<!-- calc:end -->

### ทวินสตอร์ม (TwinStorm) · uid 82

<img src="../../icons/sk_082.png" width="40" alt="icon">

- ทรี: สกิลยิง (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: โบว์กัน · ต้องเรียนก่อน: ครอสสเฟียร์
- คลาสในโค้ด: `TwinStormAction` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่มพลังการโจมตีปกติอย่างมหาศาลและเพิ่มความเร็วในการเคลื่อนที่
> 
> ทุกครั้งที่การโจมตีปกติโดนเป้าหมาย
> สแต็คโอเวอร์ฮีทจะเพิ่มขึ้น
> เมื่อกดใช้สกิลนี้อีกครั้งจะเป็นการยกเลิกสถานะของสกิล

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, เปลี่ยนรูปแบบการโจมตี (อนุมานจาก hook ของบัพ), เปลี่ยนการทำงานของตีปกติ, เพิ่มดาเมจตีปกติ
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `TwinStormBuf`: ตัวคูณตีปกติ % (`NormalAttackRate`) = `normalAttackRate` · ความเร็วเคลื่อนที่ (`MoveSpeed`) = `moveSpeed` · ดาเมจคงที่ตีปกติ (`NormalAttackConstantDamage`) = `normalAttackConstant` · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `updateNextAttackCount` (ตัวนับที่เปลี่ยนตามเหตุการณ์); Next(): `updateNextAttackCount` = `0`; Next(): `updateNextAttackCount` = `(updateNextAttackCount + 1)` · ความเสถียร (`Stable`) = `effectiveStable` · ความเร็วโจมตี + (`Aspd`) = `aspd` · ดาเมจสุดท้ายที่ทำ % (`LastDmgUpRate`) = `effectiveLastDamageRate` · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `updateNextAttackCount` (ตัวนับที่เปลี่ยนตามเหตุการณ์); Next(): `updateNextAttackCount` = `0`; Next(): `updateNextAttackCount` = `(updateNextAttackCount + 1)`
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 99 ตามที่ `TwinStormBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.get_MoveSpeed` — ค่า Move Speed ของ MobaPlayerActionManager: คืนค่า `_t1117` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `NormalAttackAction.Damaged` — NormalAttackAction: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `NormalAttackAction.OnInitialize` — NormalAttackAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `<SkillIndividualFlag>k__BackingField` = `(_t1207 | 16)` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.TwinStorm, out) & 1) ne 0 AND TryGetBu… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.get_MoveSpeed` — ค่า Move Speed ของ PlayerActionManager: คืนค่า `_t1348` (3 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `TwinStormAction.IsFailure` — เงื่อนไข is failure (TwinStormAction): คืนค่า `1` (2 กรณี) (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv13: บัฟ[โอเวอร์ฮีทสแต็ค]  เมื่อโอเวอร์ฮีทสแต็คเพิ่มขึ้นพลังโจมตีปกติ พลังสกิลยิงและสกิลนายพรานจะเพิ่มขึ้นด้วย ถ้าโอเวอร์ฮีทสแต็คสูงเกินไปความเสถียรจะลดลง
- Lv15: ถ้า MATK สูงกว่า ATK จะทำการโจมตีปกติด้วย MATK
- Lv18: จะใช้พลังโจมตีระยะใกล้หรือระยะไกลที่สูงกว่าเสมอ

### ซามูไรอาร์เชอรี (SamuraiArchery) · uid 83

<img src="../../icons/sk_083.png" width="40" alt="icon">

- ทรี: สกิลยิง (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: SubKatana · ต้องเรียนก่อน: ชู้ตมาสเตอรี่
- คลาสในโค้ด: `SamuraiArchery` · สถานะการแกะ: แกะครบจากโค้ด

> ATK และความเสถียรจะเพิ่มขึ้นเล็กน้อย
> เมื่อมีการติดตั้งธนูและคาตานะพร้อมกัน
> หากทำการโจมตีปกติด้วยคาตานะ
> ความแม่นของสกิลถัดไปที่ใช้จะเพิ่มขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- ตัวอ่านสกิลนี้ `ElementReach.CheckActiveSamuraiArcherySubElement` — ตรวจ active samurai archery sub element (ElementReach): คืนค่า `0` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ElementReach.SetSubElement` — ElementReach.SetSubElement: [call] `BonusManager$$CreateBonus` = `PlayerStatusBase.get_BonusManager(), new System.Collections.Generic.List<BonusParameter>,…` เมื่อ EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 12 AND EquipItemData.get_SubWeaponItemType(Pl…; [call] `BonusManager$$SetEquipBonus` = `PlayerStatusBase.get_BonusManager(), EquipType.SubWeapon, BonusManager.CreateBonus(Player…` เมื่อ EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 12 AND EquipItemData.get_SubWeaponItemType(Pl…; [call] `EquipBuffManager$$SetBonus` = `PlayerStatusBase.get_EquipBuffManager(), 2, BonusManager.CreateBonus(PlayerStatusBase.get…` เมื่อ EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 12 AND EquipItemData.get_SubWeaponItemType(Pl… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GameManager.PlayerSkillUpdate` — GameManager.PlayerSkillUpdate (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `NormalAttackAction.Damaged` — NormalAttackAction: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new SamuraiArcheryBuf, 0` เมื่อ (MobActionManagerBase.get_IsDead(mobActionManager) & 1) eq 0 AND (SkillIndividualFlag & 8) ne 0 AND (_t1205 & 1) ne 0 A… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerStatusBase.SetEquip` — PlayerStatusBase.SetEquip (นิยามเต็มในแท็บ Variables)

### แวนควิชเชอร์ (Conquester) · uid 84

<img src="../../icons/sk_084.png" width="40" alt="icon">

- ทรี: สกิลยิง (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: ธนู, โบว์กัน · ต้องเรียนก่อน: สไนป์
- คลาสในโค้ด: `ConquesterAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีอย่างรุนแรงในวงแคบ
> พลังจะถูกกระจายออกไปหากมีหลายเป้าหมายในระยะโจมตี
> 
> ยิ่งเข้าใกล้เป้าหมายมากเท่าไหร่ก็จะยิ่งเพิกเฉยต่อ Guard และ Avoid

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

**โน้ตในเกม (ข้อความจากเกม):**
- Lv12: ถ้าตัวเองติดสภาวะไหม้ไฟอยู่จะถูกถอนออกไปเมื่อใช้สกิล โจมตีโดนแน่นอนไม่มีการกระจายของพลัง
- Lv13: ถ้าตัวเองติดสภาวะไหม้ไฟอยู่จะถูกถอนออกไปเมื่อใช้สกิล โจมตีโดนแน่นอนไม่มีการกระจายของพลัง  *หากบัฟโอเวอร์ฮีทสแต็คของทวินสตอร์มมีตั้งแต่ 5 ขึ้นไป สแต็คจะถูกใช้ไปเพื่อเสริมความแข็งแกร่งให้กับแวนควิชเชอร์
- Lv15: *สูญเสียพลังที่เพิ่มขึ้นจากค่า DEX *พลังเพิ่มขึ้นตามค่า INT
- Lv18: *ลบขอบเขตการโจมตีออกกลายเป็นการโจมตีเป้าหมายเดี่ยว

<!-- calc:begin uid=84 -->
#### การคำนวณแบบตัวเลข — Conquester (uid 84)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **1200** → 1200, 1200, 1200, 1200, 1200, 1200, 1200, 1200, 1200, 1200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรอง อุปกรณ์เวท]: `(100 × Lv + baseINT + 500) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseINT` = แต้ม INT ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseINT (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรอง มีด หรือ อาวุธรองอื่น (ไม่ใช่ อุปกรณ์เวท/มีด)]: `(100 × Lv + baseDEX + 500) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`AbnormalStateManager.Contains(PlayerActionManagerBase.get_AbnormalStatusManager(), 8)` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 82) ≠ 0` และ `TwinStormBuf.GetParam(20) ≥ 5` หรือ `!AbnormalStateManager.Contains(PlayerActionManagerBase.get_AbnormalStatusManager(), 8)` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 82) ≠ 0` และ `TwinStormBuf.GetParam(20) ≥ 5`]: `skillRate / 100` — โดยที่ `skillRate` = `100 × Lv + baseINT + 500` [อาวุธรอง อุปกรณ์เวท] หรือ `100 × Lv + baseDEX + 500` [อาวุธรอง มีด หรือ อาวุธรองอื่น (ไม่ใช่ อุปกรณ์เวท/มีด)] หรือ `2 × skillRate` [`AbnormalStateManager.Contains(PlayerActionManagerBase.get_AbnormalStatusManager(), 8)` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 82) ≠ 0` และ `TwinStormBuf.GetParam(20) ≥ 5` หรือ `!AbnormalStateManager.Contains(PlayerActionManagerBase.get_AbnormalStatusManager(), 8)` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 82) ≠ 0` และ `TwinStormBuf.GetParam(20) ≥ 5`] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
<!-- calc:end -->

### ควิกโหลดเดอร์ (QuickLoader) · uid 85

<img src="../../icons/sk_085.png" width="40" alt="icon">

- ทรี: สกิลยิง (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: ธนู, โบว์กัน · ต้องเรียนก่อน: ครอสสเฟียร์
- คลาสในโค้ด: `QuickLoaderAction` · สถานะการแกะ: แกะครบจากโค้ด

> เมื่อเปิดใช้งานครอสสเฟียร์
> หากชาร์จไม่เต็มสแต็คจะถูกใช้เพื่อเพิ่ม
> การชาร์จหนึ่งระดับและเปิดใช้งาน
> 
> สกิลนี้จะไม่ถูกบันทึกทับ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `HideAttackBuf` ระยะเวลา 1, 3, 4, 6, 7, 9, 10, 12, 13, 15 (Lv1…10) วินาที [`(isGemCart & 1) ≠ 0`]
- บัพ `QuickLoaderBuf` ระยะเวลา 120 − 6×Lv → 114, 108, 102, 96, 90, 84, 78, 72, 66, 60 (Lv1…10) วินาที: ความเร็วท่าทาง + (`MotionSpeed`) = 5×Lv → 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10) · ความเร็วท่าทาง + (`MotionSpeed`) = `CountBufferBase.GetParam(this, id)`
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = Lv ตามที่ `HideAttackBuf` ส่งให้ตัวสร้างของ `บัพฐาน`; สแตกสูงสุด (`Max`) = ((isBowgun & 1) eq 0 ? 3 : 2) ตามที่ `QuickLoaderBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `PlayerAttackBase.RemoveAfterSkillBuf` — PlayerAttackBase.RemoveAfterSkillBuf: [set] `_motionSpeed` = `((SkillActionBase.get_MotionSpeed(this) - SkillBufferDataBase.GetParam(0)) gt 50 ? (Skill…` เมื่อ (PlayerAttackBase.ContainsNotApplicableSkill(PlayerAttackBase.get_ActionID()) & 1) eq 0 AND (SkillBufferManager.TryGetB…; [set] `appliedQuicklyType` = `(((_t1499 & 1) eq 0 ? ?undef : (appliedQuicklyType | 2)) | 16)` เมื่อ (PlayerAttackBase.ContainsNotApplicableSkill(PlayerAttackBase.get_ActionID()) & 1) eq 0 AND (SkillBufferManager.TryGetB… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv12: *เมื่อเปิดใช้สกิล สเนคแอคแทคที่เรียนจะถูกเปิดใช้พร้อมกัน *เลเวลการเปิดใช้ขึ้นอยู่กับเลเวลของควิกโหลด
- Lv13: *เมื่อเปิดใช้สกิลสเนคแอคแทคที่เรียนจะถูกเปิดใช้พร้อมกัน *เลเวลการเปิดใช้ขึ้นอยู่กับเลเวลของควิกโหลด  *จำนวนสแต็คที่ได้รับ -1

### เอเลเมนท์สตาร์ทเตอร์ (ElementReach) · uid 86

<img src="../../icons/sk_086.png" width="40" alt="icon">

- ทรี: สกิลยิง (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: ธนู, โบว์กัน · ต้องเรียนก่อน: เดคอยชูตเตอร์
- คลาสในโค้ด: `ElementReach` · สถานะการแกะ: แกะครบจากโค้ด

> ธาตุของธนูหรือโบว์กันจะถูก
> เปิดใช้งานพร้อมลูกธนู
> *ไม่สามารถใช้กับสกิลที่เป็นธาตุคู่ได้
> ได้รับบาเรียฟื้นฟูเล็กน้อยทุกครั้งที่สร้างความเสียหาย
> ให้กับเป้าหมายที่มีธาตุที่เป็นจุดอ่อน

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, พาสซีฟ
- บัพ `ElementReachBuf`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `ElementReach.CheckActiveSamuraiArcherySubElement` — ตรวจ active samurai archery sub element (ElementReach): คืนค่า `0` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ElementReach.EnemyDamage` — ElementReach.EnemyDamage: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new ElementReachBuf, 0` เมื่อ (SkillActionBase.op_Equality(action, 0) & 1) eq 0 AND SkillActionBase.get_ActionID() ne 0 AND SkillActionBase.get_Actio… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ElementReach.SetSubElement` — ElementReach.SetSubElement: [call] `BonusManager$$CreateBonus` = `PlayerStatusBase.get_BonusManager(), new System.Collections.Generic.List<BonusParameter>,…` เมื่อ EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 12 AND EquipItemData.get_SubWeaponItemType(Pl…; [call] `BonusManager$$SetEquipBonus` = `PlayerStatusBase.get_BonusManager(), EquipType.SubWeapon, BonusManager.CreateBonus(Player…` เมื่อ EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 12 AND EquipItemData.get_SubWeaponItemType(Pl…; [call] `EquipBuffManager$$SetBonus` = `PlayerStatusBase.get_EquipBuffManager(), 2, BonusManager.CreateBonus(PlayerStatusBase.get…` เมื่อ EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 12 AND EquipItemData.get_SubWeaponItemType(Pl… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ElementReach.TryGetWeaponElement` — ElementReach.TryGetWeaponElement: คืนค่า `1` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GameManager.PlayerSkillUpdate` — GameManager.PlayerSkillUpdate (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerStatusBase.SetEquip` — PlayerStatusBase.SetEquip (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv8: หากเรียนรู้ซามูไรอาร์เชอรี Lv10 แล้ว ธาตุที่ติดอยู่กับคาตานะของอาวุธเสริม จะได้รับผลของธาตุนั้นด้วย

### เจาะทะลุ (Penetrator) · uid 88

<img src="../../icons/sk_088.png" width="40" alt="icon">

- ทรี: สกิลยิง (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: ธนู, โบว์กัน · ต้องเรียนก่อน: สไนป์
- คลาสในโค้ด: `PenetratorAction` · สถานะการแกะ: แกะครบจากโค้ด

> พาวเวอร์ช็อตทะลวงเกราะศัตรู
> โจมตีเป็นเส้นตรงตามเป้าหมายที่เล็งไว้ด้วยชาร์จสกิล (5 เลเวล)
> สามารถ Avoid และปรับเปลี่ยนเป้าหมายได้ขณะชาร์จ
> ทุก 1HIT (ยกเว้น Graze) จะเพิ่มพลังโจมตีและฟื้นฟู MP เล็กน้อย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- MP ที่ใช้ [มีบัพ AvoidStack]: 0
- ดาเมจ: สร้าง template ดาเมจ 6 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `PenetratorBuf`: บัพนับสแตก (สืบจาก `CountBufferBase`): ตัวนับ `Count` เริ่ม 0 เพิ่มทีละ 1 ด้วย `Next()` และสูงสุด 5; โค้ดอื่นอ่านจำนวนสแตกผ่านพารามิเตอร์ `Count` (ดูค่าที่ใช้จริงในสูตรของสกิลที่อ้างถึง)
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 5 ตามที่ `PenetratorBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `PenetratorAction.AvoidMove` — PenetratorAction.AvoidMove: [set] `oldChargeNum` = `[TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Penetrator)+0x20]` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Penetrator, out) & 1) ne 0 AND TryGetB… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PenetratorAction.OnInitialize` — PenetratorAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `mp` = `0` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Penetrator) & 1) ne 0 (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv13: เมื่อเริ่มหรือกลับมาชาร์จตัวเองจะติดคงกระพัน 1.5 วินาที *คงกระพันจะหายไปเมื่อใช้สกิล

<!-- calc:begin uid=88 -->
#### การคำนวณแบบตัวเลข — Penetrator (uid 88)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `(((0.25 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction))) - ((1 - (PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51) / 100)) * target.Def)) - (0.25 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction)))) hi status.Lv` และ `1 ≤ maxAttackCount` และ `2 > maxAttackCount` และ … หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `(((0.25 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction))) - ((1 - (PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51) / 100)) * target.Def)) - (0.25 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction)))) hi status.Lv` และ `1 ≤ maxAttackCount` และ `2 > maxAttackCount` และ … หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `(((0.5 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction))) - ((1 - (PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51) / 100)) * target.Def)) - (0.5 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction)))) hi status.Lv` และ `1 > maxAttackCount` และ `2 ≤ maxAttackCount` และ …]: `int(Lvรวม)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Lv` = เลเวลตัวละคร (ดูแท็บ Variables)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `(((0.75 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction))) - ((1 - (PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51) / 100)) * target.Def)) - (0.75 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction)))) ls status.Lv` และ `1 > maxAttackCount` และ `2 > maxAttackCount` และ … หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `(((0.75 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction))) - ((1 - (PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51) / 100)) * target.Def)) - (0.75 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction)))) ls status.Lv` และ `1 > maxAttackCount` และ `2 > maxAttackCount` และ … หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `(((0.25 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction))) - ((1 - (PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51) / 100)) * target.Def)) - (0.25 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction)))) hi status.Lv` และ `(((0.75 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction))) - ((1 - (PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51) / 100)) * target.Def)) - (0.75 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction)))) ls status.Lv` และ `1 ≤ maxAttackCount` และ …]: `int(0.75 × DEFของเป้า)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `IMobStatusCalculator.CalcDef` = DEF มอนหลังคำนวณ; `MobActionManagerBase.get_MobBattleStatus` = ค่า Mob Battle Status ของ MobActionManagerBase (ดูแท็บ Variables)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `(((0.5 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction))) - ((1 - (PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51) / 100)) * target.Def)) - (0.5 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction)))) ls status.Lv` และ `1 > maxAttackCount` และ `2 ≤ maxAttackCount` และ … หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `(((0.5 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction))) - ((1 - (PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51) / 100)) * target.Def)) - (0.5 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction)))) ls status.Lv` และ `1 > maxAttackCount` และ `2 ≤ maxAttackCount` และ … หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `(((0.25 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction))) - ((1 - (PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51) / 100)) * target.Def)) - (0.25 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction)))) hi status.Lv` และ `(((0.5 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction))) - ((1 - (PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51) / 100)) * target.Def)) - (0.5 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction)))) ls status.Lv` และ `1 ≤ maxAttackCount` และ …]: `int(0.5 × DEFของเป้า)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `IMobStatusCalculator.CalcDef` = DEF มอนหลังคำนวณ; `MobActionManagerBase.get_MobBattleStatus` = ค่า Mob Battle Status ของ MobActionManagerBase (ดูแท็บ Variables)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `(((0.25 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction))) - ((1 - (PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51) / 100)) * target.Def)) - (0.25 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction)))) ls status.Lv` และ `1 ≤ maxAttackCount` และ `2 > maxAttackCount` และ … หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `(((0.25 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction))) - ((1 - (PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51) / 100)) * target.Def)) - (0.25 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction)))) ls status.Lv` และ `1 ≤ maxAttackCount` และ `2 > maxAttackCount` และ … หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 4)` และ `(((0.25 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction))) - ((1 - (PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51) / 100)) * target.Def)) - (0.25 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction)))) ls status.Lv` และ `(((0.5 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction))) - ((1 - (PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51) / 100)) * target.Def)) - (0.5 * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction)))) hi status.Lv` และ `1 ≤ maxAttackCount` และ …]: `int(0.25 × DEFของเป้า)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `IMobStatusCalculator.CalcDef` = DEF มอนหลังคำนวณ; `MobActionManagerBase.get_MobBattleStatus` = ค่า Mob Battle Status ของ MobActionManagerBase (ดูแท็บ Variables)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `1 ≤ maxAttackCount` และ `2 ≤ maxAttackCount` และ `3 ≤ maxAttackCount` และ … หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `1 ≤ maxAttackCount` และ `2 ≤ maxAttackCount` และ `3 > maxAttackCount` และ … หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `1 ≤ maxAttackCount` และ `2 > maxAttackCount` และ `3 ≤ maxAttackCount` และ …]: **600** → 600, 600, 600, 600, 600, 600, 600, 600, 600, 600 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `1 ≤ maxAttackCount` และ `2 ≤ maxAttackCount` และ `3 ≤ maxAttackCount` และ … หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `1 ≤ maxAttackCount` และ `2 ≤ maxAttackCount` และ `3 > maxAttackCount` และ … หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `1 ≤ maxAttackCount` และ `2 > maxAttackCount` และ `3 ≤ maxAttackCount` และ …]: `skillRate / 100` — โดยที่ `skillRate` = `25 × Lv + max(baseSTR, baseDEX) ÷ 2 + 1000` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `1 ≤ maxAttackCount` และ `2 ≤ maxAttackCount` และ `3 ≤ maxAttackCount` และ … หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `1 ≤ maxAttackCount` และ `2 ≤ maxAttackCount` และ `3 > maxAttackCount` และ … หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `1 ≤ maxAttackCount` และ `2 > maxAttackCount` และ `3 ≤ maxAttackCount` และ …]: `target.ExpDefSkill / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefSkill` = proration ช่อง Skill ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)

**ใช้ร่วมทุกฮิตของ ฮิตรีแอ็กชัน (`HitReactionAssign`)**
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical)` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobBuffer.GuardUpBuff.get_GuardUpval` = ค่า Guard Upval ของ GuardUpBuff; `TryGetBuff.buff` = TryGetBuff.buff; `MobActionManagerBase.get_BuffManager` = ค่า Buff Manager ของ MobActionManagerBase (ดูแท็บ Variables)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) = 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: **25** → 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 (Lv1…10)

**จำนวนฮิต / ตัวนับ**
- `maxAttackCount` (ตั้งใน `ActionPreparation`): 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 (Lv1…10)
- `maxAttackCount` (ตั้งใน `StopCharge`) [`!CountBufferBase.get_Peak()` และ `(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 88).Count + 1) ≠ 0` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 85) ≠ 0` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 88) ≠ 0` และ … หรือ `!CountBufferBase.get_Peak()` และ `(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 88).Count + 1) = 0` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 85) ≠ 0` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 88) ≠ 0` และ …]: `(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 88).Count + 1)`
- `maxAttackCount` (ตั้งใน `StopCharge`) [`TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 85) = 0` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 88) ≠ 0` และ ไม่ `isCombo` หรือ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 88) ≠ 0` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 88).Count ≠ 0` และ ไม่ `isCombo` หรือ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 88) ≠ 0` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 88).Count = 0` และ ไม่ `isCombo`]: `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 88).Count`
<!-- calc:end -->

### ไวด์สเปรด (WideSpread) · uid 89

<img src="../../icons/sk_089.png" width="40" alt="icon">

- ทรี: สกิลยิง (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: ธนู, โบว์กัน · ต้องเรียนก่อน: อาร์มเบรค
- คลาสในโค้ด: `WideSpreadAction` · สถานะการแกะ: แกะครบจากโค้ด

> ใช้ธนู 5 ดอกโจมตีด้วยทักษะความชำนาญ
> มีโอกาสทำให้เป้าหมายติดภาวะผิดปกติตาม(ธาตุอาวุธ)
> เมื่อโจมตีเป้าหมายเดิมซ้ำๆ ประสิทธิภาพจะเพิ่มขึ้นเล็กน้อย
> 
> และสามารถปรับเปลี่ยนรูปแบบการยิงได้ตามปุ่มที่กด

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ, วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `abnormalPercent` [อาวุธหลัก ธนู และ `(PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus()) - 1) ≤ 5` และ `GemCartBufferManager.GetTalentElementType(PlayerStatusBase.get_GemCartBuffManager()) > 6` หรือ อาวุธหลัก ธนู และ `(PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus()) - 1) > 5` และ `GemCartBufferManager.GetTalentElementType(PlayerStatusBase.get_GemCartBuffManager()) > 6`]: **2×Lv** → 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 (Lv1…10) %
- โอกาสติดสถานะ `abnormalPercent` [อาวุธหลักอื่น (ไม่ใช่ ธนู) และ `(PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus()) - 1) ≤ 5` และ `GemCartBufferManager.GetTalentElementType(PlayerStatusBase.get_GemCartBuffManager()) > 6` หรือ อาวุธหลักอื่น (ไม่ใช่ ธนู) และ `(PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus()) - 1) > 5` และ `GemCartBufferManager.GetTalentElementType(PlayerStatusBase.get_GemCartBuffManager()) > 6`]: **Lv** → 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10) %
- สถานะที่ทำให้ติด: `subAbnormalType`, `mainAbnormalType`
- บัพ `WideSpreadBuf`: ความแม่น % (`HitRate`) = `([((((Lv << 2) + lv) << 1))+0x24] - 1) × (8 × Lv + 2 × lv)`

**โน้ตในเกม (ข้อความจากเกม):**
- Lv12: *อัตราติดภาวะผิดปกติ 2 เท่า *รีโทรเกรดชอทโจมตีต่อเนื่องได้สูงสุด 4 ครั้ง
- Lv13: *เมื่อเปิดใช้งานโดยการกดปุ่ม (ซ้าย/ขวา) พลังจะเพิ่มเป็นสองเท่า

<!-- calc:begin uid=89 -->
#### การคำนวณแบบตัวเลข — WideSpread (uid 89)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **200** → 200, 200, 200, 200, 200, 200, 200, 200, 200, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate` หรือ อาวุธหลัก โบว์กัน และ `((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y)) gt 1e-05`]: **(200 + 10×Lv)%** → 210%, 220%, 230%, 240%, 250%, 260%, 270%, 280%, 290%, 300% (Lv1…10)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpList[mobAction].Exp / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `target.ExpDefSkill / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefSkill` = proration ช่อง Skill ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
<!-- calc:end -->

