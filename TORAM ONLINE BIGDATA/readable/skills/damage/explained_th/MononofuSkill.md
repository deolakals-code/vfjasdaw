# สกิลโมโนโนฟุ (`MononofuSkill`) — คำอธิบายทีละสกิล (ภาษาไทย)

สร้างอัตโนมัติด้วย `scripts/render_explained_th.py` จาก `skill_reference.json` (ข้อมูลโค้ด client ชุดล่าสุด) ไม่มีข้อความเขียนมือ แก้ไฟล์นี้ตรง ๆ จะถูกเขียนทับ ตัวเลขทั้งหมดคำนวณจากโค้ด (Code) ความหมายของชื่อ field/บทบาทแปลจากชื่อในโค้ด (Inferred) ยังไม่ได้เทียบกับตัวเลขในเกม ข้อมูลดิบทุกเส้นทางอยู่ใน `../details/MononofuSkill.md`

---

<!-- calc:preface -->
> **วิธีอ่านหัวข้อ "การคำนวณแบบตัวเลข"** (สร้างอัตโนมัติด้วย `scripts/render_calc_th.py` จาก `skill_reference.json` แก้มือจะถูกเขียนทับ)
> ดาเมจต่อฮิตเดินตามขั้น `SkillCalcTemplate/CalcStep` 0→40 ตามลำดับ (Code: `SkillCalcTemplate.GetDamage`) ขั้น `+` บวกเข้าดาเมจ ขั้น `×` คูณแล้วปัดเศษทิ้ง (int) ทันทีทุกขั้น
> ลำดับหลัก: ดาเมจฐาน(7) + คงที่สกิล(8) + คงที่บัพ(9) − ป้องกันเป้า(10) + ตีแรก(11) → ×คริ(13) → ×ธาตุ(15) → ×ตัวคูณสกิล(18) → ×ตีแรก(19) → ×เสถียร(21) → +คงที่ออโต้(22) → ×Proration(23) → ×ประเภท(24) → ×ดาเมจสุดท้าย(25) → … → เพดาน/ขั้นต่ำ(35–37)
> "ฮิต N" = template ดาเมจแต่ละก้อน (ทอยคริแยกกัน) แยกตามเมธอดและตัวแปรฮิตในโค้ด (`type`, `isFirst`, `attackCount` …) ชื่อฮิต/ส่วนมาจากชื่อในโค้ด (Inferred) ตัวเลขคำนวณจากโค้ด (Code) โดยตั้งเจม/บัพเสริม = 0
> ค่าหลายก้อนในขั้นเดียวกันแบบ "บวกเข้าช่อง" จะบวกกันก่อนคูณ ส่วน "ตั้งค่าทับ" แทนที่ค่าเดิม ค่าที่ขึ้นกับสเตตัสแสดงเป็นตัวอย่างที่ 100 / 255 (และ Lv สกิลอื่น 1 / 10) ใช้สูตรที่แนบไว้คำนวณค่าอื่นเอง
<!-- calc:preface-end -->

### เฟลช (FlashDrawnSword) · uid 609

<img src="../../icons/sk_609.png" width="40" alt="icon">

- ทรี: สกิลโมโนโนฟุ (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: คาตานะ · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `FlashDrawnSwordAction` · สถานะการแกะ: แกะครบจากโค้ด

> ฟันศัตรูด้วยความเร็วจนตามองตามไม่ทัน
> มีโอกาสติดอัตราคริติคอลสูงในฮิตที่ 2

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 6 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

<!-- calc:begin uid=609 -->
#### การคำนวณแบบตัวเลข — FlashDrawnSword (uid 609)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `ช่อง [0] ของอาร์เรย์ต่อฮิต`**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`0 lo fixAddDamage.Length` และ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 ge skillRate.Length` หรือ `0 lo fixAddDamage.Length` และ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 hs skillRate.Length` และ … หรือ `0 lo fixAddDamage.Length` และ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 hs fixAddDamage.Length` และ …]: **0** → 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`0 hs fixAddDamage.Length` และ `0 lo skillRate.Length` และ `0 lt skillRate.Length` หรือ `0 lo fixAddDamage.Length` และ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 ge skillRate.Length` หรือ `0 lo fixAddDamage.Length` และ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 hs skillRate.Length` และ …]: **50%** → 50%, 50%, 50%, 50%, 50%, 50%, 50%, 50%, 50%, 50% (Lv1…10)

**ฮิต 2: `calcPlayerToMobDamage` (ดาเมจหลัก) — `ช่อง [1] ของอาร์เรย์ต่อฮิต`**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`0 lo fixAddDamage.Length` และ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 lo fixAddDamage.Length` และ … หรือ `0 lo fixAddDamage.Length` และ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 lo fixAddDamage.Length` และ … หรือ `0 lo fixAddDamage.Length` และ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 lo fixAddDamage.Length` และ …]: **50 + 5×Lv** → 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ธนู และ `fixAddDamage.Length > 1` และ `fixAddDamage.Length ≠ 0` และ `skillRate.Length > 1` และ … หรือ อาวุธหลัก ธนู และ `fixAddDamage.Length > 1` และ `fixAddDamage.Length ≠ 0` และ `skillRate.Length > 1` และ … หรือ อาวุธหลัก ธนู และ `fixAddDamage.Length > 1` และ `fixAddDamage.Length ≠ 0` และ `skillRate.Length > 1` และ … หรือ อาวุธหลัก ธนู และ `fixAddDamage.Length ≤ 1` และ `fixAddDamage.Length ≠ 0` และ `skillRate.Length > 1` และ … หรือ …(เงื่อนไขเต็มดูใน details)]: **(100 + 5×Lv)%** → 105%, 110%, 115%, 120%, 125%, 130%, 135%, 140%, 145%, 150% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ธนู และ `fixAddDamage.Length ≠ 0` และ `skillRate.Length > 1` และ `skillRate.Length ≤ 1` และ … หรือ อาวุธหลัก ธนู และ `fixAddDamage.Length ≠ 0` และ `skillRate.Length > 1` และ `skillRate.Length ≤ 1` และ … หรือ อาวุธหลัก ธนู และ `fixAddDamage.Length ≠ 0` และ `skillRate.Length > 1` และ `skillRate.Length ≤ 1` และ … หรือ อาวุธหลักอื่น (ไม่ใช่ ธนู) และ `fixAddDamage.Length ≠ 0` และ `skillRate.Length > 1` และ `skillRate.Length ≤ 1` และ … หรือ …(เงื่อนไขเต็มดูใน details)]: **(10000 + 500×Lv)%** → 10500%, 11000%, 11500%, 12000%, 12500%, 13000%, 13500%, 14000%, 14500%, 15000% (Lv1…10)

**ฮิต 3: `calcPlayerToMobDamage` (ดาเมจหลัก) — `ช่อง [2] ของอาร์เรย์ต่อฮิต`**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`0 lo fixAddDamage.Length` และ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 lo fixAddDamage.Length` และ …]: `fixAddDamage[2]` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`0 lo fixAddDamage.Length` และ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 lo fixAddDamage.Length` และ … หรือ `0 lo fixAddDamage.Length` และ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 lo fixAddDamage.Length` และ …]: `skillRate[2]` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**ใช้ร่วมทุกฮิตของ ดาเมจหลัก**
- ดาเมจคงที่ตีแรก (`FirstAttack`, +) [`0 lo fixAddDamage.Length` และ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 ge skillRate.Length` หรือ `0 lo fixAddDamage.Length` และ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 hs skillRate.Length` และ … หรือ `0 lo fixAddDamage.Length` และ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 hs fixAddDamage.Length` และ …]: `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamage` = ดาเมจคงที่ของ Fast Attack (ดูแท็บ Variables)
- ตัวคูณตีแรก (`FirstAttackRate`, ×, บวกเข้าช่อง) [`0 lo fixAddDamage.Length` และ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 ge skillRate.Length` หรือ `0 lo fixAddDamage.Length` และ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 hs skillRate.Length` และ … หรือ `0 lo fixAddDamage.Length` และ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 hs fixAddDamage.Length` และ …]: `PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamageRate` = ตัวคูณของ Fast Attack (ดูแท็บ Variables)
<!-- calc:end -->

### ปอมเมลสไตร์ค (StrikeBackOfSword) · uid 610

<img src="../../icons/sk_610.png" width="40" alt="icon">

- ทรี: สกิลโมโนโนฟุ (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: คาตานะ · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `StrikeBackOfSwordAction` · สถานะการแกะ: แกะครบจากโค้ด

> อัดด้วยด้ามเต็มแรง
> มีโอกาสทำให้เป้าหมายติด[อัมพาต]
> ถ้าติดอัมพาตอยู่แล้วจะมีโอกาส[หมดสติ]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `abnormalPercent`: **50 + 5×Lv** → 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 (Lv1…10) %
- โอกาสติดสถานะ `stunPercent`: **5×Lv** → 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10) %
- สถานะที่ทำให้ติด: สตัน (Stun), อัมพาต (Paralysis)

<!-- calc:begin uid=610 -->
#### การคำนวณแบบตัวเลข — StrikeBackOfSword (uid 610)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **100 + 10×Lv** → 110, 120, 130, 140, 150, 160, 170, 180, 190, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(100 + 5×Lv)%** → 105%, 110%, 115%, 120%, 125%, 130%, 135%, 140%, 145%, 150% (Lv1…10)
<!-- calc:end -->

### พัลส์เบลด / สวิฟต์พัลส์เบลด (WaveBlade) · uid 611

<img src="../../icons/sk_611.png" width="40" alt="icon">

- ทรี: สกิลโมโนโนฟุ (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: คาตานะ · ต้องเรียนก่อน: เฟลช · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `WaveBladeAction` · สถานะการแกะ: แกะครบจากโค้ด

> ฟันศัตรูที่อยู่ห่างออกไปด้วยใบมีดสูญญากาศ
> ยิ่งอยู่ห่างเป้าหมายเท่าไหร่พลังทำลายก็ยิ่งลดต่ำลง
> สามารถเคลื่อนไหวตอนเก็บดาบเข้าฝักได้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, เปลี่ยนการทำงานของตีปกติ
- ดาเมจ: สร้าง template ดาเมจ 6 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `SwordMoveBuf`: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `damageInvalid` (ตัวนับที่เปลี่ยนตามเหตุการณ์)

<!-- calc:begin uid=611 -->
#### การคำนวณแบบตัวเลข — WaveBlade (uid 611)
Proration: ช่อง `Skill` โหมด `first_hit_per_target if class check passes`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `ช่อง [0] ของอาร์เรย์ต่อฮิต`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 ge skillRate.Length` หรือ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 hs skillRate.Length` และ `1 lt skillRate.Length` หรือ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 lo skillRate.Length` และ `1 lt skillRate.Length` และ …]: `(skillRate[0] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**ฮิต 2: `calcPlayerToMobDamage` (ดาเมจหลัก) — `ช่อง [1] ของอาร์เรย์ต่อฮิต`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 lo skillRate.Length` และ `1 lt skillRate.Length` และ … หรือ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 lo skillRate.Length` และ `1 lt skillRate.Length` และ … หรือ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 lo skillRate.Length` และ `1 lt skillRate.Length` และ …]: `(skillRate[1] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**ฮิต 3: `calcPlayerToMobDamage` (ดาเมจหลัก) — `ช่อง [2] ของอาร์เรย์ต่อฮิต`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 lo skillRate.Length` และ `1 lt skillRate.Length` และ …]: `(skillRate[2] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**ใช้ร่วมทุกฮิตของ ดาเมจหลัก**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 ge skillRate.Length` หรือ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 hs skillRate.Length` และ `1 lt skillRate.Length` หรือ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 lo skillRate.Length` และ `1 lt skillRate.Length` และ …]: **30 + Lv** → 31, 32, 33, 34, 35, 36, 37, 38, 39, 40 (Lv1…10)
- หักป้องกันเป้า (`Def`, +, ตั้งค่าทับ) [`0 hs skillRate.Length` และ `0 lt skillRate.Length` หรือ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 ge skillRate.Length` หรือ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 hs skillRate.Length` และ `1 lt skillRate.Length`]: `-PlayerAttackBase.CalcPowerResistDamage(PlayerActionManagerBase.get_PlayerStatus(), int(((((max((int(MathUtil.DistanceToDisplayMeter(max((fsqrt((((UnityEngine.Transform.get_position(MobActionManagerBase.get_transform(mobAction)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(playerAction)).z) * (UnityEngine.Transform.get_position(MobActionManagerBase.get_transform(mobAction)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(playerAction)).z)) + ((UnityEngine.Transform.get_position(MobActionManagerBase.get_transform(mobAction)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(playerAction)).x) * (UnityEngine.Transform.get_position(MobActionManagerBase.get_transform(mobAction)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(playerAction)).x)))) - MobActionManagerBase.get_Size(mobAction)), 0))) - int(MathUtil.DistanceToDisplayMeter(weaponRange))), 0) * decayRate) / 100) + 1) * DEFของเป้า)), 0)` — โดยที่ `weaponRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))` ; `decayRate` = `11 - Lv` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.CalcPowerResistDamage` = DEF กายภาพของมอน × (1 − min(1, ทะลุเกราะ)); `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `MathUtil.DistanceToDisplayMeter` = MathUtil.DistanceToDisplayMeter; `MobActionManagerBase.get_transform` = ค่า transform ของ MobActionManagerBase; `MobActionManagerBase.get_Size` = ค่า Size ของ MobActionManagerBase; `IMobStatusCalculator.CalcDef` = DEF มอนหลังคำนวณ …(+1) (ดูแท็บ Variables)
- ดาเมจคงที่ตีแรก (`FirstAttack`, +) [`0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 ge skillRate.Length` หรือ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 hs skillRate.Length` และ `1 lt skillRate.Length` หรือ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 lo skillRate.Length` และ `1 lt skillRate.Length` และ …]: `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamage` = ดาเมจคงที่ของ Fast Attack (ดูแท็บ Variables)
- ตัวคูณตีแรก (`FirstAttackRate`, ×, บวกเข้าช่อง) [`0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 ge skillRate.Length` หรือ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 hs skillRate.Length` และ `1 lt skillRate.Length` หรือ `0 lo skillRate.Length` และ `0 lt skillRate.Length` และ `1 lo skillRate.Length` และ `1 lt skillRate.Length` และ …]: `PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamageRate` = ตัวคูณของ Fast Attack (ดูแท็บ Variables)
<!-- calc:end -->

### บุชิโด (Bushido) · uid 612

<img src="../../icons/sk_612.png" width="40" alt="icon">

- ทรี: สกิลโมโนโนฟุ (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: StarGem
- คลาสในโค้ด: `Bushido` · สถานะการแกะ: แกะครบจากโค้ด

> เรียนรู้หัวใจแห่งการเป็นนักรบ
> HP, MP และความแม่นเพิ่มขึ้นเล็กน้อย
> ATK จะเพิ่มขึ้นเมื่อติดตั้งคาตานะ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ HP สูงสุด (`MaxHp`): 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10)
- พาสซีฟ MP สูงสุด (`MaxMp`): 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10)
- พาสซีฟ ความแม่น (`Hit`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
- พาสซีฟ ATK % (`AtkRate`): `int((Lv + 2) × vec(0x9999999a, 0x3fc99999)) + 1`
- พาสซีฟ ATK อาวุธ % (`EqAtkRate`): 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 (Lv1…10)

### ทูแฮนด์ (WeaponInBothHands) · uid 613

<img src="../../icons/sk_613.png" width="40" alt="icon">

- ทรี: สกิลโมโนโนฟุ (ขั้น 1) · เลเวลสูงสุด: 10 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: บุชิโด · ธง: StarGem
- คลาสในโค้ด: `WeaponInBothHands` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่มพลังโจมตีถ้าใช้อาวุธสองมือ
> ค่าสถานะต่างๆ จะเพิ่มขึ้นถ้าช่องอาวุธเสริมว่างเปล่า
> ค่าความเสียหายคริติคอลจะเพิ่มขึ้นเป็นอย่างมากด้วยคาตานะ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ความเสถียร (`Stable`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
- พาสซีฟ อัตราคริ (`Crt`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
- พาสซีฟ ความแม่น % (`HitRate`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
- พาสซีฟ ATK % (`AtkRate`): 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10)
- พาสซีฟ ATK อาวุธ % (`EqAtkRate`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv8: *อัตราคริติคอลเพิ่มขึ้น 2 เท่า ความเสถียรเพิ่มขึ้น 2 เท่า

### ทริปเปิ้ลทรัสต์ (ThreeStageThrust) · uid 614

<img src="../../icons/sk_614.png" width="40" alt="icon">

- ทรี: สกิลโมโนโนฟุ (ขั้น 2) · เลเวลสูงสุด: 30 · อาวุธ: คาตานะ · ต้องเรียนก่อน: [N]พัลส์เบลด[N2]สวิฟต์พัลส์เบลด[N] · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `ThreeStageThrustAction` · สถานะการแกะ: แกะครบจากโค้ด

> พุ่งเข้าแทงศัตรูด้วยการก้าวเท้าอย่างรวดเร็ว
> เคลื่อนไหวไปข้างหลังแล้วโจมตี
> พลังโจมตีของสกิลถัดไปจะเพิ่มขึ้นเล็กน้อย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `ThreeStageThrustBuf`: ดาเมจคงที่สกิล (`SkillConstantDamage`) = `playerLv // (11 - lv)`
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 1 ตามที่ `ThreeStageThrustBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.ReceiveAttack` — MobaPlayerActionManager.ReceiveAttack (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=614 -->
#### การคำนวณแบบตัวเลข — ThreeStageThrust (uid 614)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ตีแรก (`FirstAttack`, +): `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamage` = ดาเมจคงที่ของ Fast Attack (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [AGI รวม=100]: **(170 + 20×Lv)%** → 190%, 210%, 230%, 250%, 270%, 290%, 310%, 330%, 350%, 370% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [AGI รวม=255]: **(201 + 20×Lv)%** → 221%, 241%, 261%, 281%, 301%, 321%, 341%, 361%, 381%, 401% (Lv1…10)
- ตัวคูณตีแรก (`FirstAttackRate`, ×, บวกเข้าช่อง): `PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamageRate` = ตัวคูณของ Fast Attack (ดูแท็บ Variables)
<!-- calc:end -->

### มากาดาจิ (CutOffTheDisaster) · uid 615

<img src="../../icons/sk_615.png" width="40" alt="icon">

- ทรี: สกิลโมโนโนฟุ (ขั้น 2) · เลเวลสูงสุด: 30 · อาวุธ: คาตานะ · ต้องเรียนก่อน: ปอมเมลสไตร์ค · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `CutOffTheDisasterAction` · สถานะการแกะ: แกะครบจากโค้ด

> ปัดการโจมตีของศัตรูและลดความเสียหายได้เพียง 1 ครั้ง
> สภาวะผิดปกติไม่มีผล, ฟื้นฟู MP ขึ้นเล็กน้อย
> จะเหลืออย่างน้อย 1 HP เสมอเมื่อโดนโจมตีถึงตาย
> บางกรณีอาจไม่ปัดการโจมตี และต้องรับความเสียหายเต็มจำนวน
> ถ้าใช้คอมโบปริมาณการฟื้นฟู MP จะลดน้อยลง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ, เปลี่ยนรูปแบบการโจมตี (อนุมานจาก hook ของบัพ), เปลี่ยนการทำงานของตีปกติ
- ดาเมจ: สร้าง template ดาเมจ 2 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: None (None)
- บัพ `HeavenlyStarBuf` ระยะเวลา 10 วินาที
- บัพ `CutOffTheDisasterBuf`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 4 ตามที่ `HeavenlyStarBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `CutOffTheDisasterAction.ActionSkillEvent` — CutOffTheDisasterAction.ActionSkillEvent (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MercenaryActionManager.Damaged` — MercenaryActionManager: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.CutOffTheDisaster` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(Pl…; [call] `SkillDamageData$$SetAbnormalType` = `damageData, AbnormalType.None, 0` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(Pl… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.Damaged` — PlayerActionManager: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.CutOffTheDisaster` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(Pl…; [call] `SkillDamageData$$SetAbnormalType` = `damageData, AbnormalType.None, 0` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(Pl… (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=615 -->
#### การคำนวณแบบตัวเลข — CutOffTheDisaster (uid 615)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) · ส่วน HeavenlyStar (`heavenlyStar…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **100 + 10×Lv** → 110, 120, 130, 140, 150, 160, 170, 180, 190, 200 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **300** → 300, 300, 300, 300, 300, 300, 300, 300, 300, 300 (Lv1…10)
- ดาเมจคงที่จากบัพ (`BufferConstantDamage`, +, ตั้งค่าทับ): **0** → 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 (Lv1…10)
- ดาเมจคงที่ตีแรก (`FirstAttack`, +): `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamage` = ดาเมจคงที่ของ Fast Attack (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `heavenlyStarSkillRate / 100` — โดยที่ `heavenlyStarSkillRate` = `int(0.5 × CountBufferBase.GetParam(20) × (25 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 620, 1) + 150)) + 1300` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(200 + 30×Lv)%** → 230%, 260%, 290%, 320%, 350%, 380%, 410%, 440%, 470%, 500% (Lv1…10)
- ตัวคูณตีแรก (`FirstAttackRate`, ×, บวกเข้าช่อง): `PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamageRate` = ตัวคูณของ Fast Attack (ดูแท็บ Variables)
<!-- calc:end -->

### เมเคียวชิซุย (ClearAndSerene) · uid 616

<img src="../../icons/sk_616.png" width="40" alt="icon">

- ทรี: สกิลโมโนโนฟุ (ขั้น 2) · เลเวลสูงสุด: 30 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ทูแฮนด์
- คลาสในโค้ด: `ClearAndSereneAction` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่มสมาธิให้แน่วแน่
> เพิ่มอัตราคริติคอลปริมาณมากในระยะเวลาสั้นๆ
> ค่าความเสียหายคริติคอลล, DEF, MDEF จะลดลง
> ถ้าใช้สกิลอื่นผลจะหมดลงทันที

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- ตัวอ่านสกิลนี้ `MobaPlayerSecondaryStatus.get_CriticalDmg` — ค่า Critical Dmg ของ MobaPlayerSecondaryStatus: คืนค่า `_t609` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.CalcCriticalDmg` — คำนวณ critical dmg (PlayerSecondaryStatus): คืนค่า `(int((_t1571 * (((PlayerSecondaryStatus.get_Str(this) * 0.2) + max(((PlayerSecondaryStatus.get_Agi(this) - PlayerSecondaryStatus.get_Str(this)) * 0.1), 0)) + 1…` (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv8: *ระยะเวลาแสดงผล 2 เท่า *การเพิ่มของอัตราคริติคอล+25 *ค่าความเสียหายคริติคอลไม่ลดลง

### ลมมงคล (Mizukaze) · uid 628

<img src="../../icons/sk_628.png" width="40" alt="icon">

- ทรี: สกิลโมโนโนฟุ (ขั้น 2) · เลเวลสูงสุด: 30 · อาวุธ: คาตานะ · ต้องเรียนก่อน: เมเคียวชิซุย
- คลาสในโค้ด: `Mizukaze` · สถานะการแกะ: แกะครบจากโค้ด

> มีโอกาสทำงานเมื่อการโจมตีของตัวเอง MISS
> หรือเมื่อหลบหลีก Avoid สำเร็จพลังโจมตีระยะใกล้/
> โจมตีคริติคอล/แม่นยำจะเพิ่มขึ้นเล็กน้อย
> เป็นเวลา 30 วินาทีและสามารถสะสมได้สูงสุด 3 สแต็ค
> ผลของสกิลเพิ่มขึ้นตามระดับ Lv การเรียนรู้ของสกิลโมโนโนฟุ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, พาสซีฟ
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 3 ตามที่ `MizukazeBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- บัพ `MizukazeBuf` ระยะเวลา 30 วินาที: ดาเมจระยะใกล้ % (`ShortRangeRate`) = `(Count * shortRangeDamageRate)` (ตัวนับที่เปลี่ยนตามเหตุการณ์); Next(): `LeftTime` = `30` · ดาเมจคริ (`CrtDmg`) = `(Count * criticalDamage)` (ตัวนับที่เปลี่ยนตามเหตุการณ์); Next(): `LeftTime` = `30` · ความแม่น + (`HitUp`) = `(Count * hit)` (ตัวนับที่เปลี่ยนตามเหตุการณ์); Next(): `LeftTime` = `30`
- พาสซีฟ ค่าเปอร์เซ็นต์ (`Percent`): 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10)
- ตัวอ่านสกิลนี้ `Mizukaze.UpdateBuf` — Mizukaze.UpdateBuf: [call] `MizukazeBuf$$UpdateSkillTreeLevel` = `new MizukazeBuf, SkillManager.GetSkillTreeLv(PlayerStatusBase.get_SkillManager(), SkillTr…` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.Mizukaze, 1) ge 1 AND (SkillBufferManager.TryGetBu…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new MizukazeBuf, 0` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.Mizukaze, 1) ge 1 AND (SkillBufferManager.TryGetBu… (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=628 -->
#### การคำนวณแบบตัวเลข — Mizukaze (uid 628)

**ค่าบัพที่ขึ้นกับจำนวน stack**

- บัพ `MizukazeBuf` — `ShortRangeRate` ตามจำนวน `Count`: `Count × shortRangeDamageRate`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |

- บัพ `MizukazeBuf` — `CrtDmg` ตามจำนวน `Count`: `Count × criticalDamage`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |

- บัพ `MizukazeBuf` — `HitUp` ตามจำนวน `Count`: `Count × hit`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |
<!-- calc:end -->

### ฮัซโซฮัปปะ (Okaranman) · uid 617

<img src="../../icons/sk_617.png" width="40" alt="icon">

- ทรี: สกิลโมโนโนฟุ (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: คาตานะ · ต้องเรียนก่อน: ทริปเปิ้ลทรัสต์ · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `HassohappaAction` · สถานะการแกะ: แกะครบจากโค้ด

> ฟันศัตรูในพื้นที่ที่กำหนดพร้อมกัน
> สร้างความเสียหายแก่ศัตรูโดยรอบได้อย่างแม่นยำ
> สามารถเคลื่อนไหวตอนเก็บดาบเข้าฝักได้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, วางวัตถุ/กับดัก/อัญเชิญ, เปลี่ยนการทำงานของตีปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `SwordMoveBuf`: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `damageInvalid` (ตัวนับที่เปลี่ยนตามเหตุการณ์)

<!-- calc:begin uid=617 -->
#### การคำนวณแบบตัวเลข — Okaranman (uid 617)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `change = 0`, `isFirstAttck ≠ 0`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): 220%, 230%, 240%, 250%, 260%, 270%, 280%, 290%, 300%, 600% (Lv1…10)
  - สูตร: `(Lv = 10 ? skillRate + 300 : skillRate) / 100` — โดยที่ `skillRate` = `(10 × Lv < 90 ? 10 × Lv : 90) + 210`

**ฮิต 2: `calcPlayerToMobDamage` (ดาเมจหลัก) — `change ≠ 0`, `isFirstAttck ≠ 0`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): 320%, 330%, 340%, 350%, 360%, 370%, 380%, 390%, 400%, 700% (Lv1…10)
  - สูตร: `((Lv = 10 ? skillRate + 300 : skillRate) + 100) / 100` — โดยที่ `skillRate` = `(10 × Lv < 90 ? 10 × Lv : 90) + 210`

**ฮิต 3: `calcPlayerToMobDamage` (ดาเมจหลัก) — `change = 0`, `isFirstAttck = 0`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): 220%, 230%, 240%, 250%, 260%, 270%, 280%, 290%, 300%, 300% (Lv1…10)
  - สูตร: `skillRate / 100` — โดยที่ `skillRate` = `(10 × Lv < 90 ? 10 × Lv : 90) + 210`

**ฮิต 4: `calcPlayerToMobDamage` (ดาเมจหลัก) — `change ≠ 0`, `isFirstAttck = 0`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): 320%, 330%, 340%, 350%, 360%, 370%, 380%, 390%, 400%, 400% (Lv1…10)
  - สูตร: `(skillRate + 100) / 100` — โดยที่ `skillRate` = `(10 × Lv < 90 ? 10 × Lv : 90) + 210`

**ใช้ร่วมทุกฮิตของ ดาเมจหลัก**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **130 + 2×Lv** → 132, 134, 136, 138, 140, 142, 144, 146, 148, 150 (Lv1…10)
- ดาเมจคงที่ตีแรก (`FirstAttack`, +): `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamage` = ดาเมจคงที่ของ Fast Attack (ดูแท็บ Variables)
- ตัวคูณตีแรก (`FirstAttackRate`, ×, บวกเข้าช่อง): `PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamageRate` = ตัวคูณของ Fast Attack (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `target.ExpDefSkill / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefSkill` = proration ช่อง Skill ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_CharacterActionManagerBase` = ค่า Character Action Manager Base ของ MobActionManagerBase (ดูแท็บ Variables)

**จำนวนฮิต / ตัวนับ**
- `damageCount` (ตั้งใน `OnInitialize`): 1, 1, 1, 2, 2, 2, 3, 3, 3, 3 (Lv1…10)
<!-- calc:end -->

### ซังเทเซตเท็ตสึ (Zanteisettetsu) · uid 618

<img src="../../icons/sk_618.png" width="40" alt="icon">

- ทรี: สกิลโมโนโนฟุ (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: คาตานะ · ต้องเรียนก่อน: มากาดาจิ · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `ZanteisettetsuAction` · สถานะการแกะ: แกะครบจากโค้ด

> ฟาดฟันศัตรูด้วยความโกรธอย่างต่อเนื่อง
> ความเสียหายไม่มีผลหนึ่งครั้งและโจมตีกลับ
> การโจมตีกลับมีโอกาสติด[ลดการป้องกัน] 

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ, เปลี่ยนรูปแบบการโจมตี (อนุมานจาก hook ของบัพ), เปลี่ยนการทำงานของตีปกติ
- ดาเมจ: สร้าง template ดาเมจ 3 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `abnormalPercent`: **50 + 5×Lv** → 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 (Lv1…10) %
- สถานะที่ทำให้ติด: เกราะแตก (Breaking), None (None)
- บัพ `HeavenlyStarBuf` ระยะเวลา 10 วินาที
- บัพ `ZanteisettetsuBuf`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 4 ตามที่ `HeavenlyStarBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `MercenaryActionManager.Damaged` — MercenaryActionManager: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Zanteisettetsu` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(Pl…; [call] `SkillDamageData$$SetAbnormalType` = `damageData, AbnormalType.None, 0` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(Pl…; [call] `AbnormalStateManager$$RemoveAbnormalState` = `PlayerStatusBase.get_AbnormalStatusManager(), AbnormalType.KnockBack` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(Pl… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.ReceiveDamaged` — MobaPlayerActionManager.ReceiveDamaged: [call] `SkillBufferManager$$RemoveSelfBuffer` = `MobaPlayerStatus.get_SkillBufferManager(), SkillId.Zanteisettetsu` เมื่อ (skillId & 0xffff) ne 514 AND GetServerHitTypeV2.hitType(responseData.HitType) ne 0 AND (SkillBufferManager.ContainsBuf… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.Damaged` — PlayerActionManager: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Zanteisettetsu` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(Pl…; [call] `SkillDamageData$$SetAbnormalType` = `damageData, AbnormalType.None, 0` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(Pl… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ZanteisettetsuAction.ActionSkillEvent` — ZanteisettetsuAction.ActionSkillEvent: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Zanteisettetsu` เมื่อ ActionRange ne -1 AND (UnityEngine.Object.op_Equality(actarAction, 0) & 1) eq 0 AND ((param eq 100 ? 1 : 0) & (IsOtherP…; [set] `isLocalizeHeavenlyStar` = `1` เมื่อ ActionRange ne -1 AND (UnityEngine.Object.op_Equality(actarAction, 0) & 1) eq 0 AND ((param eq 100 ? 1 : 0) & (IsOtherP…; [call] `IchijhinnokazeAction$$ResetSpecialAcion` = `PlayerActionManagerBase.get_PlayerStatus()` เมื่อ ActionRange ne -1 AND (UnityEngine.Object.op_Equality(actarAction, 0) & 1) eq 0 AND ((param eq 100 ? 1 : 0) & (IsOtherP… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ZanteisettetsuAction.CheckDamageInvalid` — ตรวจ damage invalid (ZanteisettetsuAction): [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Zanteisettetsu` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Zanteisettetsu) & 1) ne 0; [call] `SkillDamageData$$SetAbnormalType` = `damageData, AbnormalType.None, 0` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Zanteisettetsu) & 1) ne 0 AND (Sk… (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=618 -->
#### การคำนวณแบบตัวเลข — Zanteisettetsu (uid 618)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) · ส่วน ไล่ตาม (`pursuit…`), HeavenlyStar (`heavenlyStar…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **10×Lv** → 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **30×Lv** → 30, 60, 90, 120, 150, 180, 210, 240, 270, 300 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **300** → 300, 300, 300, 300, 300, 300, 300, 300, 300, 300 (Lv1…10)
- ดาเมจคงที่จากบัพ (`BufferConstantDamage`, +, ตั้งค่าทับ): **0** → 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 (Lv1…10)
- ดาเมจคงที่ตีแรก (`FirstAttack`, +): `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamage` = ดาเมจคงที่ของ Fast Attack (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `heavenlyStarSkillRate / 100` — โดยที่ `heavenlyStarSkillRate` = `int(0.5 × CountBufferBase.GetParam(20) × (25 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 620, 1) + 150)) + 1300` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(100 + 20×Lv)%** → 120%, 140%, 160%, 180%, 200%, 220%, 240%, 260%, 280%, 300% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(500 + 100×Lv)%** → 600%, 700%, 800%, 900%, 1000%, 1100%, 1200%, 1300%, 1400%, 1500% (Lv1…10)
- ตัวคูณตีแรก (`FirstAttackRate`, ×, บวกเข้าช่อง): `PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamageRate` = ตัวคูณของ Fast Attack (ดูแท็บ Variables)
<!-- calc:end -->

### ชูคุจิ (Shukuchi) · uid 619

<img src="../../icons/sk_619.png" width="40" alt="icon">

- ทรี: สกิลโมโนโนฟุ (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: บุชิโด
- คลาสในโค้ด: `ShukuchiAction` · สถานะการแกะ: แกะครบจากโค้ด

> เทคนิคที่ทำให้เคลื่อนไหวได้อย่างรวดเร็ว
> สามารถเคลื่อนไหวได้อย่างรวดเร็วในระยะการโจมตีปกติ
> เพิ่มความสามารถการโจมตีปกติในครั้งถัดไปเล็กน้อย
> จะไม่เพิ่มขึ้นถ้าติด[เชื่องช้า/หยุดนิ่ง]อยู่

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, พาสซีฟ, เปลี่ยนการทำงานของตีปกติ, เพิ่มดาเมจตีปกติ
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `ShukuchiBuf`: ตัวคูณตีปกติ % (`NormalAttackRate`) = 400 · ตัวคูณตีปกติ % (`NormalAttackRate`) = 5×Lv → 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10) · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = 0, 2, 4, 8, 12, 18, 24, 32, 40, 50 (Lv1…10)
- ตัวอ่านสกิลนี้ `CloningTechniqueAction.ActionStart` — CloningTechniqueAction: ตอนเริ่มทำงานของสกิล: [set] `shukuchi` = `1` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND SkillMana…; [set] `<SkillIndividualFlag>k__BackingField` = `1` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND SkillMana… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `IchijhinnokazeAratame.InvokeShukuchi` — IchijhinnokazeAratame.InvokeShukuchi: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new ShukuchiBuf, 0` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Shukuchi) & 1) eq 0 AND (Abnormal… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `IchijhinnokazeAttackAction.ActionPreparation` — IchijhinnokazeAttackAction: ขั้นเตรียมก่อนปล่อยสกิล: [set] `shukuchiLevel` = `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.Shukuchi, 1)` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `IchijhinnokazeBuf.Updata` — IchijhinnokazeBuf: อัปเดตทุกเฟรม/ทุกจังหวะของบัพ (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerBattleManager.<ShukuchiMoveWait>d__93.MoveNext` — <ShukuchiMoveWait>d__93.MoveNext: คืนค่า `0` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerBattleManager.AbnormalFear` — MobaPlayerBattleManager.AbnormalFear: [call] `SkillFactory$$CreateSkill` = `619, 10, actionManager` เมื่อ (SkillActionBase.op_Equality(action, 0) & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBuff…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Shukuchi` เมื่อ (SkillActionBase.op_Equality(action, 0) & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBuff… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerBattleManager.OnBattleEnd` — MobaPlayerBattleManager.OnBattleEnd: [call] `SkillFactory$$CreateSkill` = `619, 10, actionManager` เมื่อ IsUnsheathe eq 0 AND (UnityEngine.Object.op_Inequality(actionManager, 0) & 1) ne 0 AND (SkillBufferManager.ContainsBuff…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Shukuchi` เมื่อ IsUnsheathe eq 0 AND (UnityEngine.Object.op_Inequality(actionManager, 0) & 1) ne 0 AND (SkillBufferManager.ContainsBuff… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `NormalAttackAction.ActionPreparation` — NormalAttackAction: ขั้นเตรียมก่อนปล่อยสกิล: [set] `checkUnannouncedDestination` = `1` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (Unannoun…; [set] `<SkillIndividualFlag>k__BackingField` = `(SkillIndividualFlag | 64)` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (Unannoun… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `NormalAttackAction.calcPlayerToMobDamage` — NormalAttackAction: สูตรดาเมจผู้เล่น→มอนสเตอร์ (ใส่ค่าลง template): [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Shukuchi` เมื่อ PlayerAttackBase.CalcHitReaction(this, NormalAttackAction.get_AttackType(), playerAction, mobAction) ne 1 AND (_t1222 &… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.<ShukuchiMoveWait>d__54.MoveNext` — <ShukuchiMoveWait>d__54.MoveNext: คืนค่า `0` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.AbnormalFear` — PlayerBattleManager.AbnormalFear: [call] `SkillFactory$$CreateSkill` = `619, 10, actionManager` เมื่อ (SkillActionBase.op_Equality(action, 0) & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBuff…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Shukuchi` เมื่อ (SkillActionBase.op_Equality(action, 0) & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBuff… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.OnBattleEnd` — PlayerBattleManager.OnBattleEnd: [call] `SkillFactory$$CreateSkill` = `619, 10, actionManager` เมื่อ IsUnsheathe eq 0 AND (UnityEngine.Object.op_Inequality(actionManager, 0) & 1) ne 0 AND (SkillBufferManager.ContainsBuff…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Shukuchi` เมื่อ IsUnsheathe eq 0 AND (UnityEngine.Object.op_Inequality(actionManager, 0) & 1) ne 0 AND (SkillBufferManager.ContainsBuff… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.get_AtkMpRecovery` — ค่า Atk Mp Recovery ของ PlayerSecondaryStatus: คืนค่า `0` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ShukuchiAction.CanActivated` — เงื่อนไข can activated (ShukuchiAction): [call] `ShukuchiAction$$CheckInBlackHole` = `UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(battle))` เมื่อ battle.IsDelay eq 0 AND (AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), AbnormalType.Stop)… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv8: *สามารถใช้ได้กับสกิลคาตานะ

<!-- calc:begin uid=619 -->
#### การคำนวณแบบตัวเลข — Shukuchi (uid 619)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `ActionStart`): `int(NextActionRrange + CharacterActionManagerBase.get_Size())`
<!-- calc:end -->

### คมดาบมายา (RepelBlade) · uid 623

<img src="../../icons/sk_623.png" width="40" alt="icon">

- ทรี: สกิลโมโนโนฟุ (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: MainKatana · ธง: NoMarketSearch, MercenaryCanUseSkill
- คลาสในโค้ด: `RepelBladeAction` · สถานะการแกะ: แกะครบจากโค้ด

> เทคนิคการใช้ฝักดาบป้องกัน
> ถ้าได้รับความเสียหายตอนใช้ฝักดาบตั้งท่าอยู่
> จะโจมตีกลับ 1 ครั้งจะลดMP ที่ใช้
> และเพิ่มอัตราความแม่นให้สกิลถัดไป

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ, เปลี่ยนการทำงานของตีปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: None (None)
- บัพ `RepelBladeBuf`: ความแม่น % (`HitRate`) = `(2 × Lv + 5) × eqAtk // 100` · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = 10×Lv → 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10)
- บัพ `SwordMoveBuf`: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `damageInvalid` (ตัวนับที่เปลี่ยนตามเหตุการณ์)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.CalcCostMp` — MP ที่ใช้ของสกิล: [call] `InflexibilityBuf$$CheckMpHalving` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Inflexibility), this` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill…; [call] `MultipleHuntBuf$$CheckMode` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt), SkillMode…` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill…; [set] `<CostMpType>k__BackingField` = `(CostMpType | 1)` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill… (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=623 -->
#### การคำนวณแบบตัวเลข — RepelBlade (uid 623)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **100 + 10×Lv** → 110, 120, 130, 140, 150, 160, 170, 180, 190, 200 (Lv1…10)
- ดาเมจคงที่ตีแรก (`FirstAttack`, +): `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamage` = ดาเมจคงที่ของ Fast Attack (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(200 + 20×Lv)%** → 220%, 240%, 260%, 280%, 300%, 320%, 340%, 360%, 380%, 400% (Lv1…10)
- ตัวคูณตีแรก (`FirstAttackRate`, ×, บวกเข้าช่อง): `PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamageRate` = ตัวคูณของ Fast Attack (ดูแท็บ Variables)
<!-- calc:end -->

### ลมกระโชก / ลมสงบนิ่ง[N3]ลมเหนือ[N4]ลมตะวันออก[N5]ลมตะวันตก[N6]ลมใต้[N7]สี่ฤดูกาล (Ichijhinnokaze) · uid 629

<img src="../../icons/sk_629.png" width="40" alt="icon">

- ทรี: สกิลโมโนโนฟุ (ขั้น 3) · เลเวลสูงสุด: 70 · อาวุธ: คาตานะ · ต้องเรียนก่อน: ลมมงคล
- คลาสในโค้ด: `IchijhinnokazeAction` · สถานะการแกะ: แกะครบจากโค้ด

> เข้าสู่ท่าตั้งรับการชักดาบสองมือ ลบผลของพลังโจมตี
> จากฟันครั้งแรกและแปลงเป็น ATK กับ ATK อาวุธแทน
> เมื่อสกิลนี้ทำงานอยู่หากใช้ลมกระโชกซ้ำ
> จะเกิดผลที่แตกต่างกันไปตามคีย์ที่กด
> ผลจะสิ้นสุดลงเมื่อเก็บดาบเข้าฝักแล้วเคลื่อนไหว

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, เปลี่ยนการทำงานของตีปกติ
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `IchijhinnokazeBuf`: ATK อาวุธฐาน + (`BaseEqAtk`) = `baseEqAtk` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `(NowAttackMode + 1)` · ATK + (`AtkUp`) = `atk` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `(NowAttackMode + 1)` · ค่าเปอร์เซ็นต์ทั่วไป (`Percent`) = 10×Lv → 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10) · ค่าทั่วไปตัวที่ 2 (`Value2`) = `activeSkill` · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `NowAttackMode` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `(NowAttackMode + 1)` · ATK % (`AtkUpRate`) = `atkRate` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `(NowAttackMode + 1)` · ตัวนับ/stack (`Count`) = `NowAttackMode + 1` · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `NowAttackMode` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `(NowAttackMode + 1)`
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 3 ตามที่ `IchijhinnokazeBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `EquipItemData.WeaponTypeCalculatorBase.CalcEqAtk` — คำนวณ eq atk (WeaponTypeCalculatorBase): คืนค่า `(((_t282 // 100) + (_t277 + ItemData.get_Refine(WeaponTypeCalculatorBase.item))) + int(_t285))` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `HayateAction.IsFailure` — เงื่อนไข is failure (HayateAction): คืนค่า `PlayerAttackBase.IsFailure(this, status, missType)` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `IchijhinnokazeAction.IsFailure` — เงื่อนไข is failure (IchijhinnokazeAction): คืนค่า `1` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `IchijhinnokazeAttackAction.CheckSetunakenran` — ตรวจ setunakenran (IchijhinnokazeAttackAction): [call] `IchijhinnokazeBuf$$CheckActiveSetsunakenran` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Ichijhinnokaze)` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.UnannouncedDestination, 1) ge 1 AND EquipItemData.…; [call] `UnannouncedDestinationBuf$$CheckActive` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.UnannouncedDestination)` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.UnannouncedDestination, 1) ge 1 AND EquipItemData.… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `IchijhinnokazeBuf.CheckNormalAttackIchijhinnokaze` — ตรวจ normal attack ichijhinnokaze (IchijhinnokazeBuf): [call] `SkillUtil$$CheckSkillEquipLimit` = `PlayerStatusBase.get_EquipItemData(), MasterSkillDataManager.GetSkillMaster(Singleton<Mas…` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.Ichijhinnokaze, 1) ge 1 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.GetSkillTargetType` — PlayerActionManager.GetSkillTargetType: คืนค่า `MasterSkillDataManager.GetSkillMaster(Singleton<MasterSkillDataManager>.get_Instance(), SkillId.CloningTechnique).TargetType` (11 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `TenjhoTengeMusouSwordAction.CheckActive` — ตรวจ active (TenjhoTengeMusouSwordAction): คืนค่า `1` (2 กรณี) (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv8: สกิลที่มีการเปลี่ยนแปลงซึ่งสามารถใช้ได้ด้วยการกดปุ่ม [ลมสงบนิ่ง(ตั้งรับ)][ลมเหนือ][ลมตะวันออก][ลมตะวันตก] [ลมใต้] สามารถใช้โดยยังรักษาสถานะของ[เมเคียวชิซุย]เอาไว้ได้  ถึงจะกดคีย์หลังจากที่ตั้งรับ[ลมสงบนิ่ง]แล้ว ยังสามารถใช้สกิลการเปลี่ยนแปลงที่เกี่ยวข้องได้ (จะใช้ MP เมื่อเปิดใช้[ลมสงบนิ่ง]เท่านั้น)

### เท็นริวรันเซ (HeavenlyStar) · uid 620

<img src="../../icons/sk_620.png" width="40" alt="icon">

- ทรี: สกิลโมโนโนฟุ (ขั้น 4) · เลเวลสูงสุด: 150 · อาวุธ: คาตานะ · ต้องเรียนก่อน: ฮัซโซฮัปปะ · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `HeavenlyStarAction` · สถานะการแกะ: แกะครบจากโค้ด

> ฟันอย่างต่อเนื่องราวคลื่นที่โหมกระหน่ำ
> เพิ่มพลังชั่วขณะทุกครั้งที่ใช้งาน(ใช้ได้สูงสุด 4 ครั้ง)
> เมื่อสำเร็จตามเงื่อนไขของมากาดาจิ/ซังเทเซ็ตเท็ตสึจะใช้การโจมตีพิเศษได้
> และระยะเวลาการเพิ่มพลังจะเพิ่มขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, เปลี่ยนรูปแบบการโจมตี (อนุมานจาก hook ของบัพ), เปลี่ยนการทำงานของตีปกติ
- MP ที่ใช้ [อาวุธหลัก ธนู และ มีบัพ 620 HeavenlyStar หรือ อาวุธหลักอื่น (ไม่ใช่ ธนู) และ มีบัพ 620 HeavenlyStar]: 100
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `HeavenlyStarBuf` ระยะเวลา 10 วินาที
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 4 ตามที่ `HeavenlyStarBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `CutOffTheDisasterAction.<>c__DisplayClass31_1.<ActionSkillEvent>b__1` — <>c__DisplayClass31_1.<ActionSkillEvent>b__1: [call] `HeavenlyStarBuf$$Reset` = `PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[SkillId.HeavenlyStar]` เมื่อ (_t191 & 1) ne 0; [call] `HeavenlyStarBuf$$Reset` = `new HeavenlyStarBuf` เมื่อ (_t191 & 1) eq 0 AND (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.HeavenlyStar, 1) & 255) ne 0; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new HeavenlyStarBuf, 0` เมื่อ (_t191 & 1) eq 0 AND (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.HeavenlyStar, 1) & 255) ne 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `CutOffTheDisasterAction.OnInitialize` — CutOffTheDisasterAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `heavenlyStarSkillRate` = `(int(((CountBufferBase.GetParam(20) * ((SkillManager.GetSkillLv(PlayerStatusBase.get_Skil…` เมื่อ (_t192 & 1) ne 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `HeavenlyStarAction.OnInitialize` — HeavenlyStarAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `mp` = `100` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.HeavenlyStar) & 1) ne 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `IllusionarySceneAction.<>c__DisplayClass30_0.<ActionPreparation>b__0` — <>c__DisplayClass30_0.<ActionPreparation>b__0: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.HeavenlyStar, SkillManager.GetSkillLv(…` เมื่อ (SkillBufferManager.TryGetBuf<HeavenlyStarBuf>(PlayerStatusBase.get_SkillBufferManager(), 620, out) & 1) eq 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `IllusionarySceneAction.OnInitialize` — IllusionarySceneAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `finishSkillRate` = `(SkillBufferDataBase.GetParam(20) lt 1 ? 100 : (((SkillManager.GetSkillLv(PlayerStatusBas…` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.HeavenlyStar, out) & 1) ne 0 AND TryGe…; [set] `finishConstantDamage` = `200` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.HeavenlyStar, out) & 1) ne 0 AND TryGe…; [set] `finishConstantDamage` = `200` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.HeavenlyStar, out) & 1) eq 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerBattleManager.OnSkillActionEnd` — MobaPlayerBattleManager.OnSkillActionEnd: [set] `attackDelay` = `0` เมื่อ (SkillActionBase.get_IsChatLog() & 1) eq 0 AND (SkillActionBase.get_IsSupport() & 1) eq 0 AND (SkillBufferManager.Conta…; [set] `<IsDelay>k__BackingField` = `0` เมื่อ (SkillActionBase.get_IsChatLog() & 1) eq 0 AND (SkillActionBase.get_IsSupport() & 1) eq 0 AND (SkillBufferManager.Conta… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.CalcCostMp` — MP ที่ใช้ของสกิล: [set] `<CostMpType>k__BackingField` = `0` เมื่อ PlayerAttackBase.get_ActionID() eq 620 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager()…; [set] `<CostMpType>k__BackingField` = `0` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill…; [set] `<CostMpType>k__BackingField` = `0` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.CheckZeroActionDelay` — ตรวจ zero action delay (PlayerBattleManager): คืนค่า `1` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ZanteisettetsuAction.<>c__DisplayClass32_0.<ActionSkillEvent>b__1` — <>c__DisplayClass32_0.<ActionSkillEvent>b__1: [call] `HeavenlyStarBuf$$Reset` = `new HeavenlyStarBuf` เมื่อ (SkillBufferManager.TryGetBuf<HeavenlyStarBuf>(PlayerStatusBase.get_SkillBufferManager(), 620, out) & 1) eq 0 AND (Skil…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new HeavenlyStarBuf, 0` เมื่อ (SkillBufferManager.TryGetBuf<HeavenlyStarBuf>(PlayerStatusBase.get_SkillBufferManager(), 620, out) & 1) eq 0 AND (Skil… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ZanteisettetsuAction.OnInitialize` — ZanteisettetsuAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `heavenlyStarSkillRate` = `(int(((CountBufferBase.GetParam(20) * ((SkillManager.GetSkillLv(PlayerStatusBase.get_Skil…` เมื่อ (_t192 & 1) ne 0 (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=620 -->
#### การคำนวณแบบตัวเลข — HeavenlyStar (uid 620)
Proration: ช่อง `Skill` โหมด `first_hit_per_target if class check passes`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **10×Lv** → 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10)
- ดาเมจคงที่ตีแรก (`FirstAttack`, +): `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamage` = ดาเมจคงที่ของ Fast Attack (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`InflexibilityBuf.CheckHeavenlyStarPowerUp(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627))` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627) ≠ 0` · กิ่งที่ 1 ของ `skillRate`]: `(25 × Lv + (25 × Lv + 150) × A + 100 × A + 250) / 100` · `A = System.Math.Min(CountBufferBase.GetParam(20), 3)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `CountBufferBase.GetParam` = CountBufferBase: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`InflexibilityBuf.CheckHeavenlyStarPowerUp(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627))` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627) ≠ 0`]: `(skillRate + skillRate × A + 100 × A + 100) / 100` · `A = System.Math.Min(CountBufferBase.GetParam(20), 3)` — โดยที่ `skillRate` = `25 × Lv + 150` หรือ `skillRate + skillRate × A + 100 × A + 100` (`A = System.Math.Min(CountBufferBase.GetParam(20), 3)`) [`InflexibilityBuf.CheckHeavenlyStarPowerUp(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627))` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627) ≠ 0`] หรือ `skillRate + skillRate × System.Math.Min(CountBufferBase.GetParam(20), 3)` หรือ `skillRate + 100 × stackLevel + 100` [`InflexibilityBuf.CheckHeavenlyStarPowerUp(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627))` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627) ≠ 0`] ; `stackLevel` = `System.Math.Min(CountBufferBase.GetParam(20), 3)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `CountBufferBase.GetParam` = CountBufferBase: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate`]: `(25 × Lv + (25 × Lv + 150) × System.Math.Min(CountBufferBase.GetParam(20), 3) + 150) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `CountBufferBase.GetParam` = CountBufferBase: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`InflexibilityBuf.CheckHeavenlyStarPowerUp(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627))` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627) ≠ 0`]: `(skillRate + skillRate × System.Math.Min(CountBufferBase.GetParam(20), 3)) / 100` — โดยที่ `skillRate` = `25 × Lv + 150` หรือ `skillRate + skillRate × A + 100 × A + 100` (`A = System.Math.Min(CountBufferBase.GetParam(20), 3)`) [`InflexibilityBuf.CheckHeavenlyStarPowerUp(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627))` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627) ≠ 0`] หรือ `skillRate + skillRate × System.Math.Min(CountBufferBase.GetParam(20), 3)` หรือ `skillRate + 100 × stackLevel + 100` [`InflexibilityBuf.CheckHeavenlyStarPowerUp(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627))` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627) ≠ 0`] ; `stackLevel` = `System.Math.Min(CountBufferBase.GetParam(20), 3)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `CountBufferBase.GetParam` = CountBufferBase: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate` หรือ `InflexibilityBuf.CheckHeavenlyStarPowerUp(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627))` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627) ≠ 0`]: **(150 + 25×Lv)%** → 175%, 200%, 225%, 250%, 275%, 300%, 325%, 350%, 375%, 400% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`InflexibilityBuf.CheckHeavenlyStarPowerUp(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627))` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627) ≠ 0` · กิ่งที่ 1 ของ `skillRate`]: ขึ้นกับ `stackLevel` — สูตร `(25 × Lv + 100 × stackLevel + 250) / 100` — โดยที่ `stackLevel` = `System.Math.Min(CountBufferBase.GetParam(20), 3)`

  | stackLevel | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | 375% | 400% | 425% | 450% | 475% | 500% | 525% | 550% | 575% | 600% |
  | 2 | 475% | 500% | 525% | 550% | 575% | 600% | 625% | 650% | 675% | 700% |
  | 3 | 575% | 600% | 625% | 650% | 675% | 700% | 725% | 750% | 775% | 800% |
  | 4 | 675% | 700% | 725% | 750% | 775% | 800% | 825% | 850% | 875% | 900% |
  | 5 | 775% | 800% | 825% | 850% | 875% | 900% | 925% | 950% | 975% | 1000% |

- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`InflexibilityBuf.CheckHeavenlyStarPowerUp(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627))` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627) ≠ 0`]: ขึ้นกับ `stackLevel` — สูตร `(skillRate + 100 × stackLevel + 100) / 100` — โดยที่ `skillRate` = `25 × Lv + 150` หรือ `skillRate + skillRate × A + 100 × A + 100` (`A = System.Math.Min(CountBufferBase.GetParam(20), 3)`) [`InflexibilityBuf.CheckHeavenlyStarPowerUp(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627))` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627) ≠ 0`] หรือ `skillRate + skillRate × System.Math.Min(CountBufferBase.GetParam(20), 3)` หรือ `skillRate + 100 × stackLevel + 100` [`InflexibilityBuf.CheckHeavenlyStarPowerUp(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627))` และ `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627) ≠ 0`] ; `stackLevel` = `System.Math.Min(CountBufferBase.GetParam(20), 3)`

  | stackLevel | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | 375% | 400% | 425% | 450% | 475% | 500% | 525% | 550% | 575% | 600% |
  | 2 | 475% | 500% | 525% | 550% | 575% | 600% | 625% | 650% | 675% | 700% |
  | 3 | 575% | 600% | 625% | 650% | 675% | 700% | 725% | 750% | 775% | 800% |
  | 4 | 675% | 700% | 725% | 750% | 775% | 800% | 825% | 850% | 875% | 900% |
  | 5 | 775% | 800% | 825% | 850% | 875% | 900% | 925% | 950% | 975% | 1000% |

- ตัวคูณตีแรก (`FirstAttackRate`, ×, บวกเข้าช่อง): `PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamageRate` = ตัวคูณของ Fast Attack (ดูแท็บ Variables)
<!-- calc:end -->

### การิวเท็นเซ (FinishingTouch) · uid 621

<img src="../../icons/sk_621.png" width="40" alt="icon">

- ทรี: สกิลโมโนโนฟุ (ขั้น 4) · เลเวลสูงสุด: 150 · อาวุธ: คาตานะ · ต้องเรียนก่อน: ฮัซโซฮัปปะ · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `FinishingTouchAction` · สถานะการแกะ: แกะครบจากโค้ด

> พิฆาตในดาบเดียว
> พลังจะเพิ่มขึ้นทุกครั้งที่ใช้โมโนโนฟุสกิล (ใช้ได้สูงสุด 10 ครั้ง)
> พลังจะเพิ่มขึ้นเมื่อเป้าหมายถูกทำลายชิ้นส่วน
> เป็นสกิลที่มีอัตราคริติคอลต่ำเป็นอย่างมาก

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `FinishingTouchBuf`: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `lastDamageRate` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `lastDamageRate` = `(Count << 1)`; NextSkip(): `lastDamageRate` = `(Count << 1)` · ตัวคูณตีแรก (`FirstAttackRate`) = `firstAttackRate` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `lastDamageRate` = `(Count << 1)`; NextSkip(): `lastDamageRate` = `(Count << 1)` · MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = `atkMpRecovery` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `lastDamageRate` = `(Count << 1)`; NextSkip(): `lastDamageRate` = `(Count << 1)` · ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `lastDamageRate` = `(Count << 1)`; NextSkip(): `lastDamageRate` = `(Count << 1)` · ตัวคูณดาเมจที่ได้รับจากมอน (หมวดบัพ) (`MobLastDamageRateBuf`) = `damageCut` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `lastDamageRate` = `(Count << 1)`; NextSkip(): `lastDamageRate` = `(Count << 1)` · ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `lastDamageRate` = `(Count << 1)`; NextSkip(): `lastDamageRate` = `(Count << 1)`
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `FinishingTouchAction.AddSwordSoul` — FinishingTouchAction.AddSwordSoul: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new FinishingTouchBuf, 0` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.FinishingTouch, 1) ge 1 AND (SkillBufferManager.Tr… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `IchijhinnokazeAttackAction.<>c__DisplayClass117_0.<AddMotionEndFinishingTouchBuf>b__0` — <>c__DisplayClass117_0.<AddMotionEndFinishingTouchBuf>b__0: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.FinishingTouch, SkillManager.GetSkillL…` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.FinishingTouch, 1) ge 1 AND (_t772 & 1) eq 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `NormalAttackAction.<>c__DisplayClass81_0.<calcPlayerToMobDamage>b__0` — <>c__DisplayClass81_0.<calcPlayerToMobDamage>b__0: [call] `SkillBufferManager$$AddSelfBuffer` = `<>c__DisplayClass81_0.skillBuffer, SkillId.FinishingTouch, SkillManager.GetSkillLv(Player…` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.FinishingTouch, 1) ge 1 AND (_t1176 & 1) eq 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.<>c__DisplayClass113_0.<ActionStart>b__1` — <>c__DisplayClass113_0.<ActionStart>b__1: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.FinishingTouch, SkillManager.GetSkillL…` เมื่อ PlayerAttackBase.get_TreeType() eq 19 AND CharacterActionManagerBase.get_UnTargetDist() ne 0 AND CharacterActionManager… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.CalcBufferLastDamageRate` — ตัวคูณดาเมจสุดท้ายจากบัพ/โบนัส: คืนค่า `_t1363` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `RepelBladeAction.<>c__DisplayClass30_0.<ActionStart>b__1` — <>c__DisplayClass30_0.<ActionStart>b__1: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.FinishingTouch, SkillManager.GetSkillL…` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.FinishingTouch, 1) ge 1 AND (SkillBufferManager.Tr… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ShadowlessSlashAction.ActionSkillEvent` — ShadowlessSlashAction.ActionSkillEvent: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.FinishingTouch, SkillManager.GetSkillL…` เมื่อ param ne 102 AND param ne 101 AND param eq 100 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND Skil… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `TenjhoTengeMusouSwordAction.ActionStart` — TenjhoTengeMusouSwordAction: ตอนเริ่มทำงานของสกิล (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `TenjhoTengeMusouSwordAction.CheckActive` — ตรวจ active (TenjhoTengeMusouSwordAction): คืนค่า `1` (2 กรณี) (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv8: พลังของโมโนโนฟุสกิลจะเพิ่มขึ้น เมื่อบัฟของการิวเท็นเซเพิ่มขึ้น  เมื่อเปิดใช้งานสกิล บัฟที่สะสมไว้ของการิวเท็นเซทั้งหมดจะถูกใช้ และคุณจะเข้าสู่สถานะลดค่าความเสียหาย ในระหว่างสถานะนี้การเพิ่มพลังของโมโนโนฟุจะยังคงอยู่ที่ระดับสูงสุด  รีเซ็ตเมื่อสกิล[ลมกระโชก]ถูกยกเลิก

<!-- calc:begin uid=621 -->
#### การคำนวณแบบตัวเลข — FinishingTouch (uid 621)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10)`]: **1000** → 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10)` · กิ่งที่ 1 ของ `fixAddDamage` หรือ `AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10)` และ `!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10)`]: **100** → 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate` หรือ `PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[621].Count ≥ 1`]: **(20×Lv)%** → 20%, 40%, 60%, 80%, 100%, 120%, 140%, 160%, 180%, 200% (Lv1…10)
<!-- calc:end -->

### ไคริกิรันชิน (WeirdnessOfGod) · uid 622

<img src="../../icons/sk_622.png" width="40" alt="icon">

- ทรี: สกิลโมโนโนฟุ (ขั้น 4) · เลเวลสูงสุด: 150 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: เมเคียวชิซุย
- คลาสในโค้ด: `WeirdnessOfGodAction` · สถานะการแกะ: แกะครบจากโค้ด

> ปลดปล่อยพลังปิศาจที่แฝงอยู่ภายใน
> เพิ่ม ATK/ฟื้นฟู MP โจมตี/การโจมตีปกติ
> อัพเกรดการทะลวงการป้องกัน/อัตราคริติคอลของการิวเท็นเซ
> ตัวเองจะติด[ไหม้ไฟ]เมื่อใช้งาน

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, เพิ่มดาเมจตีปกติ
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `WeirdnessOfGodBuf` ระยะเวลา 5, 6, 6, 7, 7, 8, 8, 9, 9, 10 (Lv1…10) วินาที: ATK + (`AtkUp`) = `atk` · ตัวคูณตีปกติ % (`NormalAttackRate`) = `normalAttackRate + 50` · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `registBreak` · MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = 6, 7, 8, 9, 10, 16, 17, 18, 19, 25 (Lv1…10)
- ตัวอ่านสกิลนี้ `IchijhinnokazeAttackAction.ActionPreparation` — IchijhinnokazeAttackAction: ขั้นเตรียมก่อนปล่อยสกิล: [set] `weirdnessOfGodLevel` = `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.WeirdnessOfGod, 1)` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0; [set] `<CastTime>k__BackingField` = `1` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (IchijhinnokazeAttackAction.GetInputDirect(this, SkillManager.GetSkillLv(… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `TenjhoTengeMusouSwordAction.ActionPreparation` — TenjhoTengeMusouSwordAction: ขั้นเตรียมก่อนปล่อยสกิล: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new WeirdnessOfGodBuf, Id` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND SkillMana…; [set] `resistBreaker` = `((TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.WeirdnessOfGod).Level …` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBuf…; [set] `critical` = `_t1914` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBuf… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv8: *พลังการโจมตีปกติ +50 *3x ระยะเวลาแสดงผล

### ลมกรด (Hayate) · uid 630

<img src="../../icons/sk_630.png" width="40" alt="icon">

- ทรี: สกิลโมโนโนฟุ (ขั้น 4) · เลเวลสูงสุด: 150 · อาวุธ: คาตานะ · ต้องเรียนก่อน: [N]ลมกระโชก[N2]ลมสงบนิ่ง[N3]ลมเหนือ[N4]ลมตะวันออก[N5]ลมตะวันตก[N6]ลมใต้[N7]สี่ฤดูกาล[N]
- คลาสในโค้ด: `HayateAction` · สถานะการแกะ: แกะครบจากโค้ด

> หลบหนีจากวิกฤตได้ราวสายลมพัด(เฉพาะในสถานะลมกระโชกเท่านั้น)
> ระหว่างการกระโดดจะอยู่ในสถานะคงกระพัน
> เมื่อเวลาผ่านไปหรือกดคีย์จะโจมตีแบบพุ่งลง
> พลังโจมตีเพิ่มขึ้นตามระยะเวลาที่คงกระพันแต่หากไม่มีเป้าหมายอยู่ที่จุดตกถึงพื้นจะ MISS

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

<!-- calc:begin uid=630 -->
#### การคำนวณแบบตัวเลข — Hayate (uid 630)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **400** → 400, 400, 400, 400, 400, 400, 400, 400, 400, 400 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`jumpElapsedTime ≥ 1`]: `300 × min(int(jumpElapsedTime), 4) / 100` — โดยที่ `jumpElapsedTime` = `UnityEngine.Time.get_realtimeSinceStartup() - jumpStartTime` [`IsOtherPlayer = 0` และ `jumpStartTime pl 0`] ; `jumpStartTime` = `UnityEngine.Time.get_realtimeSinceStartup()` [`IsOtherPlayer ≠ 0` และ `param = 100` และ `param ≠ 101` หรือ `IsOtherPlayer = 0` และ `param = 100` และ `param ≠ 101`] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(60×Lv)%** → 60%, 120%, 180%, 240%, 300%, 360%, 420%, 480%, 540%, 600% (Lv1…10)
<!-- calc:end -->

### คาสุมิเซ็ตสึเก็คคะ / เท็นริวรันเซ:ซันยุ (IllusionaryScene) · uid 624

<img src="../../icons/sk_624.png" width="40" alt="icon">

- ทรี: สกิลโมโนโนฟุ (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: คาตานะ · ต้องเรียนก่อน: เท็นริวรันเซ
- คลาสในโค้ด: `IllusionarySceneAction` · สถานะการแกะ: แกะครบจากโค้ด

> ฟาดฟันโจมตีเป้าหมายอย่างต่อเนื่อง
> ลดความเสียหายที่ได้รับลงอย่างมากขณะใช้งาน
> จะเกิดการโจมตีพิเศษถ้ามีผลของเท็นริวรันเซอยู่
> ระยะเวลาต่อเนื่องของพลังที่เพิ่มจะขึ้นอยู่กับจำนวนครั้งที่ใช้งาน

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 2 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: None (None)
- บัพ `IllusionarySceneBuf`: ตัวคูณดาเมจที่ได้รับจากมอน (หมวดบัพ) (`MobLastDamageRateBuf`) = 9×Lv → 9, 18, 27, 36, 45, 54, 63, 72, 81, 90 (Lv1…10)
- บัพ `OkaranmanBuf`: บัพนับสแตก (สืบจาก `CountBufferBase`): ตัวนับ `Count` เริ่ม 0 เพิ่มทีละ 1 ด้วย `Next()` และสูงสุด 1; โค้ดอื่นอ่านจำนวนสแตกผ่านพารามิเตอร์ `Count` (ดูค่าที่ใช้จริงในสูตรของสกิลที่อ้างถึง)
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 1 ตามที่ `OkaranmanBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `FacticeArmeAction.ActionSkillEvent` — FacticeArmeAction.ActionSkillEvent (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `IllusionarySceneAction.<>c__DisplayClass30_0.<ActionPreparation>b__0` — <>c__DisplayClass30_0.<ActionPreparation>b__0: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.IllusionaryScene` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.IllusionaryScene, out) & 1) ne 0 AND T…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new OkaranmanBuf, 0` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.IllusionaryScene, out) & 1) ne 0 AND T…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.IllusionaryScene` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.IllusionaryScene, out) & 1) eq 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `IllusionarySceneAction.ActionSkillEvent` — IllusionarySceneAction.ActionSkillEvent (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `IllusionarySceneAction.Damaged` — IllusionarySceneAction: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `SkillDamageData$$SetAbnormalType` = `damageData, AbnormalType.None, 0` เมื่อ (UnityEngine.Object.op_Equality(playerAction, 0) & 1) eq 0 AND (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_Skill… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobAttackBase.CalcLastDamage` — คำนวณ last damage (MobAttackBase): [set] `illusionarySceneDamageCut` = `1` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.IllusionaryScene, out) & 1) ne 0 AND (… (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=624 -->
#### การคำนวณแบบตัวเลข — IllusionaryScene (uid 624)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) · ส่วน rangeki (`rangeki…`), ท่าปิด (`finish…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `rangekiConstantDamage` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **200** → 200, 200, 200, 200, 200, 200, 200, 200, 200, 200 (Lv1…10)
- ดาเมจคงที่ตีแรก (`FirstAttack`, +): `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamage` = ดาเมจคงที่ของ Fast Attack (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก คาตานะ และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 620) ≠ 0` หรือ อาวุธหลักอื่น (ไม่ใช่ คาตานะ) และ อาวุธรอง คาตานะ และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 620) ≠ 0`]: `((A < 1 ? 100 : (25 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 620, 1) + 150) × A) + 2 × DEXรวม // (5 - A)) / 100` · `A = SkillBufferDataBase.GetParam(20)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Dex` = DEX สุดท้าย; `SkillBufferDataBase.GetParam` = ค่าพารามิเตอร์ของบัพตาม SkillBufferId; `SkillManager.GetSkillLv` = เลเวลของสกิลที่ผู้เล่นเรียน; `PlayerStatusBase.get_SkillManager` = ค่า Skill Manager ของ PlayerStatusBase; `SkillId.HeavenlyStar` = เท็นริวรันเซ (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ คาตานะ) และ อาวุธรองอื่น (ไม่ใช่ คาตานะ) และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 620) ≠ 0`]: `(A < 1 ? 100 : (25 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 620, 1) + 150) × A) / 100` · `A = SkillBufferDataBase.GetParam(20)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `SkillBufferDataBase.GetParam` = ค่าพารามิเตอร์ของบัพตาม SkillBufferId; `SkillManager.GetSkillLv` = เลเวลของสกิลที่ผู้เล่นเรียน; `PlayerStatusBase.get_SkillManager` = ค่า Skill Manager ของ PlayerStatusBase; `SkillId.HeavenlyStar` = เท็นริวรันเซ (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก คาตานะ หรือ อาวุธหลักอื่น (ไม่ใช่ คาตานะ) และ อาวุธรอง คาตานะ]: `finishSkillRate / 100` — โดยที่ `finishSkillRate` = `(A < 1 ? 100 : (25 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 620, 1) + 150) × A) + 2 × DEXรวม // (5 - A)` (`A = SkillBufferDataBase.GetParam(20)`) [อาวุธหลัก คาตานะ และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 620) ≠ 0` หรือ อาวุธหลักอื่น (ไม่ใช่ คาตานะ) และ อาวุธรอง คาตานะ และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 620) ≠ 0`] หรือ `A < 1 ? 100 : (25 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 620, 1) + 150) × A` (`A = SkillBufferDataBase.GetParam(20)`) [อาวุธหลักอื่น (ไม่ใช่ คาตานะ) และ อาวุธรองอื่น (ไม่ใช่ คาตานะ) และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 620) ≠ 0`] หรือ `finishSkillRate + 2 × DEXรวม // 5` [อาวุธหลัก คาตานะ หรือ อาวุธหลักอื่น (ไม่ใช่ คาตานะ) และ อาวุธรอง คาตานะ] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(750 + 75×Lv)%** → 825%, 900%, 975%, 1050%, 1125%, 1200%, 1275%, 1350%, 1425%, 1500% (Lv1…10)
- ตัวคูณตีแรก (`FirstAttackRate`, ×, บวกเข้าช่อง): `PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamageRate` = ตัวคูณของ Fast Attack (ดูแท็บ Variables)
<!-- calc:end -->

### ชาโดว์เลสสแลช (ShadowlessSlash) · uid 625

<img src="../../icons/sk_625.png" width="40" alt="icon">

- ทรี: สกิลโมโนโนฟุ (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: คาตานะ · ต้องเรียนก่อน: การิวเท็นเซ
- คลาสในโค้ด: `ShadowlessSlashAction` · สถานะการแกะ: แกะครบจากโค้ด

> ฟันด้วยความเร็วสูงจนแม้แต่ศัตรูก็มองไม่ออกว่า
> คาตานะออกจากฝักตั้งแต่เมื่อไหร่
> โจมตีเป้าหมายด้วยความแม่นยำสูง
> และเพิ่มประสิทธิภาพด้วยบัฟทั้ง 2 ของมังกรผงาดฟ้า
> สามารถเคลื่อนไหวตอนเก็บดาบเข้าฝักได้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, วางวัตถุ/กับดัก/อัญเชิญ, เปลี่ยนการทำงานของตีปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `ShadowlessSlashBuf` ระยะเวลา 1 วินาที: ความแม่น % (`HitRate`) = 3, 12, 27, 48, 75, 108, 147, 192, 243, 300 (Lv1…10)
- บัพ `SwordMoveBuf`: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `damageInvalid` (ตัวนับที่เปลี่ยนตามเหตุการณ์)
- ตัวอ่านสกิลนี้ `TenjhoTengeMusouSwordAction.CheckActive` — ตรวจ active (TenjhoTengeMusouSwordAction): คืนค่า `1` (2 กรณี) (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=625 -->
#### การคำนวณแบบตัวเลข — ShadowlessSlash (uid 625)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **300** → 300, 300, 300, 300, 300, 300, 300, 300, 300, 300 (Lv1…10)
- ดาเมจคงที่ตีแรก (`FirstAttack`, +): `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamage` = ดาเมจคงที่ของ Fast Attack (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `skillRate / 100` — โดยที่ `skillRate` = `50 × Lv + (baseAGI + baseDEX) ÷ 2 + 400` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณตีแรก (`FirstAttackRate`, ×, บวกเข้าช่อง): `PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamageRate` = ตัวคูณของ Fast Attack (ดูแท็บ Variables)
<!-- calc:end -->

### นุคิอุจิเซ็นโนเซ็น (UnannouncedDestination) · uid 626

<img src="../../icons/sk_626.png" width="40" alt="icon">

- ทรี: สกิลโมโนโนฟุ (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: MainKatana · ต้องเรียนก่อน: ชูคุจิ
- คลาสในโค้ด: `UnannouncedDestination` · สถานะการแกะ: แกะครบจากโค้ด

> เทคนิคการกวัดแกว่งดาบด้วยฝีมือระดับเทพ
> เมื่อไม่ได้โจมตีในระยะเวลาหนึ่ง
> การโจมตีปกติของชูคุจิจะรุนแรงขึ้นเป็นอย่างมาก
> ยิ่งผู้ใช้มี HP เหลือน้อยเท่าไหร่พลังก็จะยิ่งเพิ่มมากขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- ตัวอ่านสกิลนี้ `IchijhinnokazeAttackAction.CheckSetunakenran` — ตรวจ setunakenran (IchijhinnokazeAttackAction): [call] `IchijhinnokazeBuf$$CheckActiveSetsunakenran` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Ichijhinnokaze)` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.UnannouncedDestination, 1) ge 1 AND EquipItemData.…; [call] `UnannouncedDestinationBuf$$CheckActive` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.UnannouncedDestination)` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.UnannouncedDestination, 1) ge 1 AND EquipItemData.… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `NormalAttackAction.ActionPreparation` — NormalAttackAction: ขั้นเตรียมก่อนปล่อยสกิล: [call] `UnannouncedDestinationBuf$$CheckActive` = `new NormalAttackAction.<>c__DisplayClass72_1.unannouncedDestinationBuf` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (Unannoun…; [set] `checkUnannouncedDestination` = `1` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (Unannoun…; [set] `<SkillIndividualFlag>k__BackingField` = `(SkillIndividualFlag | 64)` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (Unannoun… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ShukuchiAction.OnInitialize` — ShukuchiAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [call] `UnannouncedDestinationBuf$$CheckActive` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.UnannouncedDestination)` เมื่อ (UnannouncedDestination.CheckMinimumBehavior(PlayerActionManagerBase.get_PlayerStatus()) & 1) ne 0 AND (SkillBufferMana… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `UnannouncedDestination.CheckMinimumBehavior` — ตรวจ minimum behavior (UnannouncedDestination): คืนค่า `(UnannouncedDestination.CheckMinimumBehavior(status, out) & 1)` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `WaveBladeAction.ActionPreparation` — WaveBladeAction: ขั้นเตรียมก่อนปล่อยสกิล: [set] `unannouncedWaveblade` = `1` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBuf…; [set] `<CurrentTake>k__BackingField` = `new SkillLinkedTake` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBuf…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.UnannouncedDestination` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBuf… (นิยามเต็มในแท็บ Variables)

### ดอนท์เลส (Inflexibility) · uid 627

<img src="../../icons/sk_627.png" width="40" alt="icon">

- ทรี: สกิลโมโนโนฟุ (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: MainKatana · ต้องเรียนก่อน: ไคริกิรันชิน
- คลาสในโค้ด: `Inflexibility` · สถานะการแกะ: แกะครบจากโค้ด

> มีปณิธานอันแน่วแน่ที่จะเผชิญหน้ากับศัตรู
> ดอนท์เลสจะสะสมโดยอัตโนมัติเมื่อต่อสู้กับศัตรูที่แข็งแกร่ง
> จะได้รับผลของบัฟต่างๆ ทุกการนับ 10
> เมื่อศัตรูที่แข็งแกร่งถูกกำจัดการนับจะถูกใช้และจะหมดลงเมื่อเวลาผ่านไป

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, พาสซีฟ
- บัพ `InflexibilityBuf` ระยะเวลา `?sbfx - lv + 12` วินาที: ความแม่น + (`HitUp`) = `hit` · ตัวคูณตีแรก (`FirstAttackRate`) = `firstAttackRate` · ATK อาวุธฐาน + (`BaseEqAtk`) = `baseEqAtk` · ATK อาวุธ + (`EqAtk`) = `eqAtk` · ความเร็วท่าทาง + (`MotionSpeed`) = `motionSpeed`
- ตัวอ่านสกิลนี้ `EquipItemData.WeaponTypeCalculatorBase.CalcEqAtk` — คำนวณ eq atk (WeaponTypeCalculatorBase): [call] `InflexibilityBuf$$CheckRefineBonus` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Inflexibility)` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Inflexibility, out) & 1) ne 0 AND Play… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `HeavenlyStarBuf.IllusionarySceneReset` — HeavenlyStarBuf.IllusionarySceneReset: [set] `<Count>k__BackingField` = `max((((illusionarySceneParry & 1) + count) + ([TryGetBuf.buf(PlayerStatusBase.get_SkillBu…` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Inflexibility, out) & 1) ne 0 AND TryG…; [set] `<LeftTime>k__BackingField` = `(EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData…` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Inflexibility, out) & 1) ne 0 AND TryG…; [set] `<Count>k__BackingField` = `max((((illusionarySceneParry & 1) + count) + 0xfffffffd), 0)` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Inflexibility, out) & 1) eq 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `Inflexibility.CheckAdd` — ตรวจ add (Inflexibility): คืนค่า `(?mvn & 1)` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerSecondaryStatus.GetMotionSpeed` — MobaPlayerSecondaryStatus.GetMotionSpeed: คืนค่า `(100 - _t518)` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.CalcCostMp` — MP ที่ใช้ของสกิล: [call] `InflexibilityBuf$$CheckMpHalving` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Inflexibility), this` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Inflexibility, out) & 1) ne 0 AND TryG…; [call] `InflexibilityBuf$$CheckMpHalving` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Inflexibility), this` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill…; [call] `InflexibilityBuf$$CheckMpHalving` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Inflexibility), this` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.GetCalcMotionSpeed` — PlayerSecondaryStatus.GetCalcMotionSpeed: คืนค่า `_t1597` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SwordMove.AddBuf` — SwordMove.AddBuf: [call] `InflexibilityBuf$$CheckSwordMoveBuffer` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Inflexibility)` เมื่อ EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) eq 8 A…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new SwordMoveBuf, skill.Id` เมื่อ EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) eq 8 A…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new SwordMoveBuf, skill.Id` เมื่อ EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) eq 8 A… (นิยามเต็มในแท็บ Variables)

### ลมกระโชกแรง (IchijhinnokazeAratame) · uid 631

<img src="../../icons/sk_631.png" width="40" alt="icon">

- ทรี: สกิลโมโนโนฟุ (ขั้น 5) · เลเวลสูงสุด: 240 · อาวุธ: คาตานะ · ต้องเรียนก่อน: ลมกรด
- คลาสในโค้ด: `IchijhinnokazeAratame` · สถานะการแกะ: แกะครบจากโค้ด

> พัฒนาฝีมือวิชาดาบสองมือผ่านการฝึกฝนเป็นประจำ
> 
> พลังโจมตีของสกิลลมกระโชกในการโจมตีปกติ (ทั้ง 3 ระดับ)
> และพลังโจมตีของสกิลที่เปลี่ยนแปลงทั้งหมดจะเพิ่มขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, พาสซีฟ, เปลี่ยนการทำงานของตีปกติ, เพิ่มดาเมจตีปกติ
- บัพ `ShukuchiBuf`: ตัวคูณตีปกติ % (`NormalAttackRate`) = 400 · ตัวคูณตีปกติ % (`NormalAttackRate`) = 5×Lv → 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10) · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = 0, 2, 4, 8, 12, 18, 24, 32, 40, 50 (Lv1…10)
- ตัวอ่านสกิลนี้ `IchijhinnokazeAratame.InvokeShukuchi` — IchijhinnokazeAratame.InvokeShukuchi: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new ShukuchiBuf, 0` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Shukuchi) & 1) eq 0 AND (Abnormal… (นิยามเต็มในแท็บ Variables)

