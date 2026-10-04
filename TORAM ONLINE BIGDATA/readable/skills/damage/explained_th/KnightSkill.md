# สกิลอัศวิน (`KnightSkill`) — คำอธิบายทีละสกิล (ภาษาไทย)

สร้างอัตโนมัติด้วย `scripts/render_explained_th.py` จาก `skill_reference.json` (ข้อมูลโค้ด client ชุดล่าสุด) ไม่มีข้อความเขียนมือ แก้ไฟล์นี้ตรง ๆ จะถูกเขียนทับ ตัวเลขทั้งหมดคำนวณจากโค้ด (Code) ความหมายของชื่อ field/บทบาทแปลจากชื่อในโค้ด (Inferred) ยังไม่ได้เทียบกับตัวเลขในเกม ข้อมูลดิบทุกเส้นทางอยู่ใน `../details/KnightSkill.md`

---

<!-- calc:preface -->
> **วิธีอ่านหัวข้อ "การคำนวณแบบตัวเลข"** (สร้างอัตโนมัติด้วย `scripts/render_calc_th.py` จาก `skill_reference.json` แก้มือจะถูกเขียนทับ)
> ดาเมจต่อฮิตเดินตามขั้น `SkillCalcTemplate/CalcStep` 0→40 ตามลำดับ (Code: `SkillCalcTemplate.GetDamage`) ขั้น `+` บวกเข้าดาเมจ ขั้น `×` คูณแล้วปัดเศษทิ้ง (int) ทันทีทุกขั้น
> ลำดับหลัก: ดาเมจฐาน(7) + คงที่สกิล(8) + คงที่บัพ(9) − ป้องกันเป้า(10) + ตีแรก(11) → ×คริ(13) → ×ธาตุ(15) → ×ตัวคูณสกิล(18) → ×ตีแรก(19) → ×เสถียร(21) → +คงที่ออโต้(22) → ×Proration(23) → ×ประเภท(24) → ×ดาเมจสุดท้าย(25) → … → เพดาน/ขั้นต่ำ(35–37)
> "ฮิต N" = template ดาเมจแต่ละก้อน (ทอยคริแยกกัน) แยกตามเมธอดและตัวแปรฮิตในโค้ด (`type`, `isFirst`, `attackCount` …) ชื่อฮิต/ส่วนมาจากชื่อในโค้ด (Inferred) ตัวเลขคำนวณจากโค้ด (Code) โดยตั้งเจม/บัพเสริม = 0
> ค่าหลายก้อนในขั้นเดียวกันแบบ "บวกเข้าช่อง" จะบวกกันก่อนคูณ ส่วน "ตั้งค่าทับ" แทนที่ค่าเดิม ค่าที่ขึ้นกับสเตตัสแสดงเป็นตัวอย่างที่ 100 / 255 (และ Lv สกิลอื่น 1 / 10) ใช้สูตรที่แนบไว้คำนวณค่าอื่นเอง
<!-- calc:preface-end -->

### แอสเซาต์แอคแทค (AssaultAttack) · uid 513

<img src="../../icons/sk_513.png" width="40" alt="icon">

- ทรี: สกิลอัศวิน (ขั้น 1) · เลเวลสูงสุด: 15 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `AssaultAttackAction` · สถานะการแกะ: แกะครบจากโค้ด

> จู่โจมอย่างรวดเร็วและดันศัตรูออกไป
> มีโอกาสทำให้เป้าหมาย[เชื่องช้า]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: ช้า (Slow), กระเด็น (KnockBack)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv17: *พลัง+25 *พลังสกิล+50 *อัตราติดผลักกระเด็น+50%

<!-- calc:begin uid=513 -->
#### การคำนวณแบบตัวเลข — AssaultAttack (uid 513)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [อาวุธรอง โล่]: **50 + 5×Lv** → 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [อาวุธรองอื่น (ไม่ใช่ โล่)]: **5×Lv** → 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรอง โล่ หรือ `Lv = 10`]: **(50 + 10×Lv)%** → 60%, 70%, 80%, 90%, 100%, 110%, 120%, 130%, 140%, 150% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรองอื่น (ไม่ใช่ โล่)]: **(25 + 10×Lv)%** → 35%, 45%, 55%, 65%, 75%, 85%, 95%, 105%, 115%, 125% (Lv1…10)
<!-- calc:end -->

### โพรโวค (Provoke) · uid 514

<img src="../../icons/sk_514.png" width="40" alt="icon">

- ทรี: สกิลอัศวิน (ขั้น 1) · เลเวลสูงสุด: 15 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: StarGem, MercenaryCanUseSkill
- คลาสในโค้ด: `ProvokeAction` · สถานะการแกะ: แกะครบจากโค้ด

> ยั่วยุศัตรูให้เข้ามาโจมตีผู้ใช้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: แอ็กชันระบบ/อรรถประโยชน์
- MP ที่ใช้ [`Lv > 5` และ `Lv > 9`]: 200
- MP ที่ใช้ [`Lv > 5` และ `Lv ≤ 9`]: 300
- MP ที่ใช้ [`Lv ≤ 5`]: 400
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration

### ไนท์สแตนซ์ (KnightStance) · uid 521

<img src="../../icons/sk_521.png" width="40" alt="icon">

- ทรี: สกิลอัศวิน (ขั้น 1) · เลเวลสูงสุด: 15 · อาวุธ: ดาบมือเดียว · ธง: StarGem
- คลาสในโค้ด: `KnightStanceAction` · สถานะการแกะ: แกะครบจากโค้ด

> คำสาบานของอัศวิน
> เพิ่ม VIT และเฮทของตัวเองเป็นเวลา 6 นาที
> ระหว่างเอฟเฟกต์มีผลอยู่ถ้ามีเฮทที่ตรงกัน
> อัตราความเสียหายที่ได้รับจากมอนสเตอร์จะลดลงเล็กน้อย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `KnightStanceBuf` ระยะเวลา 360 วินาที: ตัวคูณดาเมจที่ได้รับ (`RateDamageResist`) = `((int((Lv * 0.5))) << (EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator) eq 17 ? 1 : 0))` · ความเกลียดชัง % (`HateRate`) = 3×Lv → 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 (Lv1…10) · ความเกลียดชัง % (`HateRate`) = 2×Lv → 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 (Lv1…10) · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `stack` (ตัวนับที่เปลี่ยนตามเหตุการณ์)
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 100 ตามที่ `KnightStanceBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `KnightHeal.Damaged` — KnightHeal: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `KnightStanceAction.ActionHit` — KnightStanceAction.ActionHit: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.KnightStance` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_Skil…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.KnightStance` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND IPlayerStatusCalculator.get_MaxHp(PlayerStatusBase.get_… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobAttackBase.CalcLastDamage` — คำนวณ last damage (MobAttackBase): คืนค่า `((SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.ArkSaber, out) & 1) eq 0 ? ((_t983 & 1) eq 0 ? ((_t982 & 1) eq 0 ? _t997 : _t…` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobAttackBase.SetAbnormalEffect` — MobAttackBase.SetAbnormalEffect (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.ReceiveDamaged` — MobaPlayerActionManager.ReceiveDamaged (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerSecondaryStatus.get_Vit` — ค่า Vit ของ MobaPlayerSecondaryStatus: คืนค่า `_t767` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PhotonListener.OnActionMobAttack` — PhotonListener.OnActionMobAttack (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.DamagedKnightHeal` — PlayerActionManager.DamagedKnightHeal (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.GetDisplayBonusCalcHate` — PlayerSecondaryStatus.GetDisplayBonusCalcHate: คืนค่า `int(frintp((fcvt(((_t1651 + 1) * 100)) + -0.5)))` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.get_Vit` — ค่า Vit ของ PlayerSecondaryStatus: คืนค่า `_t769` (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv17: *เฮทเพิ่มขึ้นUP *เพิ่มพลังการลดอัตราความเสียหาย *ระหว่างใช้[วอร์คราย]จะเพิ่มความต้านทานหวาดกลัว

### แพรี่ (Parry) · uid 515

<img src="../../icons/sk_515.png" width="40" alt="icon">

- ทรี: สกิลอัศวิน (ขั้น 2) · เลเวลสูงสุด: 35 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: แอสเซาต์แอคแทค
- คลาสในโค้ด: `Parry` · สถานะการแกะ: แกะครบจากโค้ด

> ปัดป้องการโจมตีด้วยอาวุธ
> มีโอกาสลดความเสียหายทางกายภาพ
> สกิลนี้จะไม่เกิดพร้อมปฏิกิริยา  Guard

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ โอกาสทำงาน % (`Trigger`): 5, 10, 15, 20, 25, 10, 15, 20, 25, 30 (Lv1…10)
- พาสซีฟ ลดดาเมจที่ได้รับ % (`CutDmgRate`): 10, 10, 10, 10, 10, 20, 20, 20, 20, 20 (Lv1…10)

### เรจซอร์ด (RageSword) · uid 516

<img src="../../icons/sk_516.png" width="40" alt="icon">

- ทรี: สกิลอัศวิน (ขั้น 2) · เลเวลสูงสุด: 35 · อาวุธ: ดาบมือเดียว, ดาบสองมือ · ต้องเรียนก่อน: โพรโวค · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `RageSwordAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีโดยปลดปล่อยจิตสังหารที่มี
> เป็นการโจมตีพิเศษที่ทำให้เกิดเฮทจำนวนมาก
> ถ้าตกเป็นเป้าอัตราคริติคอลจะเพิ่มขึ้น
> MP ที่ใช้ในสกิลถัดไปจะลดลงกึ่งหนึ่ง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `RageSwordBuf`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `PlayerAttackBase.CalcCostMp` — MP ที่ใช้ของสกิล: [call] `InflexibilityBuf$$CheckMpHalving` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Inflexibility), this` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill…; [call] `MultipleHuntBuf$$CheckMode` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt), SkillMode…` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill…; [set] `<CostMpType>k__BackingField` = `(CostMpType | 1)` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.RemoveAfterSkillBuf` — PlayerAttackBase.RemoveAfterSkillBuf: [call] `SkillBufferManager$$RemoveBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.RageSword` เมื่อ (PlayerAttackBase.ContainsNotApplicableSkill(PlayerAttackBase.get_ActionID()) & 1) eq 0 AND (SkillBufferManager.Contain… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv17: *พลัง+30 *พลังจะเพิ่มมากกว่าค่า VIT ของตัวเอง *พลังสกิล+100

<!-- calc:begin uid=516 -->
#### การคำนวณแบบตัวเลข — RageSword (uid 516)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `ช่อง [4] ของอาร์เรย์ต่อฮิต`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรอง โล่ · VIT รวม=100 หรือ `Lv = 10` · VIT รวม=100]: **(230 + 10×Lv)%** → 240%, 250%, 260%, 270%, 280%, 290%, 300%, 310%, 320%, 330% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรอง โล่ · VIT รวม=255 หรือ `Lv = 10` · VIT รวม=255]: **(307 + 10×Lv)%** → 317%, 327%, 337%, 347%, 357%, 367%, 377%, 387%, 397%, 407% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรองอื่น (ไม่ใช่ โล่)]: **(150 + 10×Lv)%** → 160%, 170%, 180%, 190%, 200%, 210%, 220%, 230%, 240%, 250% (Lv1…10)

**ใช้ร่วมทุกฮิตของ ดาเมจหลัก**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [อาวุธรอง โล่]: **150 + 5×Lv** → 155, 160, 165, 170, 175, 180, 185, 190, 195, 200 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [อาวุธรองอื่น (ไม่ใช่ โล่)]: **50 + 5×Lv** → 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 (Lv1…10)
<!-- calc:end -->

### โซนิคทรัสต์ (SonicThrust) · uid 522

<img src="../../icons/sk_522.png" width="40" alt="icon">

- ทรี: สกิลอัศวิน (ขั้น 2) · เลเวลสูงสุด: 35 · อาวุธ: ดาบมือเดียว · ต้องเรียนก่อน: เรจซอร์ด
- คลาสในโค้ด: `SonicThrustAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีด้วยรัศมีแห่งดาบทำให้ศัตรูสูญเสียความสมดุล
> เป้าหมายมีโอกาส[ล้มคว่ำ]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: ล้มคว่ำ (Tumble)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv17: *พลังเพิ่มขึ้นตามค่า DEX *ถ้าผลของล้มคว่ำถูกป้องกันเนื่องจากเวลาต้านทาน จะฟื้นพู MP ขึ้นมาเล็กน้อย

<!-- calc:begin uid=522 -->
#### การคำนวณแบบตัวเลข — SonicThrust (uid 522)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **200** → 200, 200, 200, 200, 200, 200, 200, 200, 200, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรอง โล่ · DEX รวม=100]: **(250 + 15×Lv)%** → 265%, 280%, 295%, 310%, 325%, 340%, 355%, 370%, 385%, 400% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรอง โล่ · DEX รวม=255]: **(405 + 15×Lv)%** → 420%, 435%, 450%, 465%, 480%, 495%, 510%, 525%, 540%, 555% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรองอื่น (ไม่ใช่ โล่)]: **(150 + 15×Lv)%** → 165%, 180%, 195%, 210%, 225%, 240%, 255%, 270%, 285%, 300% (Lv1…10)
<!-- calc:end -->

### N$Pดีเฟนส์$F$เพอร์เฟกต์ดีเฟนส์ (P_Deffence) · uid 517

<img src="../../icons/sk_517.png" width="40" alt="icon">

- ทรี: สกิลอัศวิน (ขั้น 3) · เลเวลสูงสุด: 125 · อาวุธ: โล่ · ต้องเรียนก่อน: แพรี่
- คลาสในโค้ด: `P_DeffenceAction` · สถานะการแกะ: แกะครบจากโค้ด

> ปกป้องสมบูรณ์แบบ
> ลดค่าความเสียหายให้เหลือ 0 ด้วยโล่
> ฟื้นฟู HP เล็กน้อย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `P_DeffenceActionBuf` ระยะเวลา 1 วินาที
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `MobAttackBase.InvalidDamage` — MobAttackBase.InvalidDamage: [call] `WheelBiteBuf$$CheckDamageInvalid` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.WheelBite)` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.P_Deffence) & 1) eq 0 AND (SkillB… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobAttackPlayerSelfDestruct.calcMobToPlayerDamage` — คำนวณ mob to player damage (MobAttackPlayerSelfDestruct) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.Damaged` — MobaPlayerActionManager: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.ReceiveDamaged` — MobaPlayerActionManager.ReceiveDamaged (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `P_DeffenceAction.ActionSkillEvent` — P_DeffenceAction.ActionSkillEvent (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.Damaged` — PlayerActionManager: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Levenir` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND _t1320 ne 0 AND (SkillBufferManager.C…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new LevenirBuf, 0` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND _t1320 ne 0 AND (SkillBufferManager.C…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new LevenirBuf, 0` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND _t1320 ne 0 AND (SkillBufferManager.C… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.RemoveAfterSkillBuf` — PlayerAttackBase.RemoveAfterSkillBuf: [call] `SkillBufferManager$$RemoveBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.P_Deffence` เมื่อ (PlayerAttackBase.ContainsNotApplicableSkill(PlayerAttackBase.get_ActionID()) & 1) eq 0 AND PlayerAttackBase.get_Action… (นิยามเต็มในแท็บ Variables)

### ไบด์สไตร์ค (BindStrike) · uid 518

<img src="../../icons/sk_518.png" width="40" alt="icon">

- ทรี: สกิลอัศวิน (ขั้น 3) · เลเวลสูงสุด: 125 · อาวุธ: ดาบมือเดียว, ดาบสองมือ · ต้องเรียนก่อน: เรจซอร์ด · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `BindStrikeAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีศัตรูด้วยคลื่นพลังทำลายล้าง
> มีโอกาสทำให้เป้าหมาย[หยุดนิ่ง]
> การโจมตีพิเศษที่จะทำให้เกิดเฮทจำนวนมาก

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: สตัน (Stun), หยุดนิ่ง (Stop)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv17: *พลัง+150 *พลังจะเพิ่มมากกว่าค่า VIT ของตัวเอง *พลังสกิล+150

<!-- calc:begin uid=518 -->
#### การคำนวณแบบตัวเลข — BindStrike (uid 518)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [อาวุธหลัก ดาบสองมือ และ อาวุธรอง โล่ หรือ อาวุธหลักอื่น (ไม่ใช่ ดาบสองมือ) และ อาวุธรอง โล่]: **200 + 10×Lv** → 210, 220, 230, 240, 250, 260, 270, 280, 290, 300 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [อาวุธหลัก ดาบสองมือ และ อาวุธรองอื่น (ไม่ใช่ โล่) หรือ อาวุธหลักอื่น (ไม่ใช่ ดาบสองมือ) และ อาวุธรองอื่น (ไม่ใช่ โล่)]: **50 + 10×Lv** → 60, 70, 80, 90, 100, 110, 120, 130, 140, 150 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบสองมือ และ อาวุธรอง โล่ และ `isEquipShield` หรือ อาวุธหลักอื่น (ไม่ใช่ ดาบสองมือ) และ อาวุธรอง โล่ และ `isEquipShield` · VIT รวม=100 หรือ `Lv = 10` และ `isEquipShield` · VIT รวม=100]: **(800 + 5×Lv)%** → 805%, 810%, 815%, 820%, 825%, 830%, 835%, 840%, 845%, 850% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบสองมือ และ อาวุธรอง โล่ และ `isEquipShield` หรือ อาวุธหลักอื่น (ไม่ใช่ ดาบสองมือ) และ อาวุธรอง โล่ และ `isEquipShield` · VIT รวม=255 หรือ `Lv = 10` และ `isEquipShield` · VIT รวม=255]: **(1110 + 5×Lv)%** → 1115%, 1120%, 1125%, 1130%, 1135%, 1140%, 1145%, 1150%, 1155%, 1160% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบสองมือ และ อาวุธรองอื่น (ไม่ใช่ โล่) และ `isEquipShield` หรือ อาวุธหลักอื่น (ไม่ใช่ ดาบสองมือ) และ อาวุธรองอื่น (ไม่ใช่ โล่) และ `isEquipShield` · VIT รวม=100]: **(550 + 5×Lv)%** → 555%, 560%, 565%, 570%, 575%, 580%, 585%, 590%, 595%, 600% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบสองมือ และ อาวุธรองอื่น (ไม่ใช่ โล่) และ `isEquipShield` หรือ อาวุธหลักอื่น (ไม่ใช่ ดาบสองมือ) และ อาวุธรองอื่น (ไม่ใช่ โล่) และ `isEquipShield` · VIT รวม=255]: **(705 + 5×Lv)%** → 710%, 715%, 720%, 725%, 730%, 735%, 740%, 745%, 750%, 755% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบสองมือ และ อาวุธรอง โล่ และ ไม่ `isEquipShield` หรือ อาวุธหลัก ดาบสองมือ และ อาวุธรอง โล่ และ `isEquipShield` หรือ อาวุธหลักอื่น (ไม่ใช่ ดาบสองมือ) และ อาวุธรอง โล่ และ ไม่ `isEquipShield` หรือ อาวุธหลักอื่น (ไม่ใช่ ดาบสองมือ) และ อาวุธรอง โล่ และ `isEquipShield` · VIT รวม=100 หรือ `Lv = 10` และ ไม่ `isEquipShield` หรือ `Lv = 10` และ `isEquipShield` · VIT รวม=100]: **(700 + 5×Lv)%** → 705%, 710%, 715%, 720%, 725%, 730%, 735%, 740%, 745%, 750% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบสองมือ และ อาวุธรอง โล่ และ ไม่ `isEquipShield` หรือ อาวุธหลัก ดาบสองมือ และ อาวุธรอง โล่ และ `isEquipShield` หรือ อาวุธหลักอื่น (ไม่ใช่ ดาบสองมือ) และ อาวุธรอง โล่ และ ไม่ `isEquipShield` หรือ อาวุธหลักอื่น (ไม่ใช่ ดาบสองมือ) และ อาวุธรอง โล่ และ `isEquipShield` · VIT รวม=255 หรือ `Lv = 10` และ ไม่ `isEquipShield` หรือ `Lv = 10` และ `isEquipShield` · VIT รวม=255]: **(855 + 5×Lv)%** → 860%, 865%, 870%, 875%, 880%, 885%, 890%, 895%, 900%, 905% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบสองมือ และ อาวุธรองอื่น (ไม่ใช่ โล่) และ ไม่ `isEquipShield` หรือ อาวุธหลัก ดาบสองมือ และ อาวุธรองอื่น (ไม่ใช่ โล่) และ `isEquipShield` หรือ อาวุธหลักอื่น (ไม่ใช่ ดาบสองมือ) และ อาวุธรองอื่น (ไม่ใช่ โล่) และ ไม่ `isEquipShield` หรือ อาวุธหลักอื่น (ไม่ใช่ ดาบสองมือ) และ อาวุธรองอื่น (ไม่ใช่ โล่) และ `isEquipShield`]: **(450 + 5×Lv)%** → 455%, 460%, 465%, 470%, 475%, 480%, 485%, 490%, 495%, 500% (Lv1…10)
<!-- calc:end -->

### เรเวอเนีย (Levenir) · uid 523

<img src="../../icons/sk_523.png" width="40" alt="icon">

- ทรี: สกิลอัศวิน (ขั้น 3) · เลเวลสูงสุด: 125 · อาวุธ: ดาบมือเดียว · ต้องเรียนก่อน: โซนิคทรัสต์
- คลาสในโค้ด: `LevenirAction` · สถานะการแกะ: แกะครบจากโค้ด

> การโจมตีศัตรูทรงพลังที่ขวางทางอย่างรุนแรง
> หากตรงตามเงื่อนไขจำนวน HIT จะเพิ่มขึ้น(สูงสุด 3HIT)
> แต่ถ้าติดสภาวะผิดปกติใดๆ ผลของการ
> เพิ่มจำนวน HIT จะไม่ทำงาน
> การโจมตีนี้จะไม่ทำให้เกิดการแบ่งสัดส่วน

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 6 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · ไม่เปลี่ยนค่า proration
- บัพ `LevenirBuf`: บัพนับสแตก (สืบจาก `CountBufferBase`): ตัวนับ `Count` เริ่ม 0 เพิ่มทีละ 1 ด้วย `Next()` และสูงสุด Lv; โค้ดอื่นอ่านจำนวนสแตกผ่านพารามิเตอร์ `Count` (ดูค่าที่ใช้จริงในสูตรของสกิลที่อ้างถึง)
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = Lv ตามที่ `LevenirBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `LevenirAction.AbnormalStack` — LevenirAction.AbnormalStack: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Levenir` เมื่อ (type - 1) ls 2 AND (UnityEngine.Object.op_Equality(actor, 0) & 1) eq 0 AND (UnityEngine.Object.op_Equality(UnityEngine…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new LevenirBuf, 0` เมื่อ (type - 1) ls 2 AND (UnityEngine.Object.op_Equality(actor, 0) & 1) eq 0 AND (UnityEngine.Object.op_Equality(UnityEngine…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new LevenirBuf, 0` เมื่อ (type - 1) ls 2 AND (UnityEngine.Object.op_Equality(actor, 0) & 1) eq 0 AND (UnityEngine.Object.op_Equality(UnityEngine… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `LevenirAction.ActionPreparation` — LevenirAction: ขั้นเตรียมก่อนปล่อยสกิล: [set] `maxAttackCount` = `((SkillBufferDataBase.GetParam(20) lt 2 ? SkillBufferDataBase.GetParam(20) : 2) + maxAtta…` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Levenir` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `LevenirAction.Damaged` — LevenirAction: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Levenir` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.Levenir, 1) ge 1 AND (SkillBufferManager.TryGetBuf…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new LevenirBuf, 0` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.Levenir, 1) ge 1 AND (SkillBufferManager.TryGetBuf…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new LevenirBuf, 0` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.Levenir, 1) ge 1 AND (SkillBufferManager.TryGetBuf… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.Damaged` — PlayerActionManager: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Levenir` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND _t1320 ne 0 AND (SkillBufferManager.C…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new LevenirBuf, 0` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND _t1320 ne 0 AND (SkillBufferManager.C…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new LevenirBuf, 0` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND _t1320 ne 0 AND (SkillBufferManager.C… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv17: *การันตีคริติตอล  *จำนวน HIT จะเพิ่มขึ้น 1 เมื่อ Pดีเฟนส์สำเร็จ *จำนวน HIT จะเพิ่มขึ้น 1 เมื่อทำให้ผงะ *จำนวน HIT จะเพิ่มขึ้น 3 เมื่อทำให้ล้มคว่ำ *จำนวน HIT จะเพิ่มขึ้น 5 เมื่อทำให้หมดสติ *สามารถสะสมผลที่เพิ่มได้จนถึงสกิลเลเวล

<!-- calc:begin uid=523 -->
#### การคำนวณแบบตัวเลข — Levenir (uid 523)
Proration: ช่อง `Skill` โหมด `never (IsExpDefFluctuate=false)`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`1 ≥ maxAttackCount` และ `maxAttackCount ≥ 1` หรือ `1 < maxAttackCount` และ `2 ≥ maxAttackCount` และ `maxAttackCount ≥ 1` หรือ `1 < maxAttackCount` และ `2 < maxAttackCount` และ `3 ≥ maxAttackCount` และ `maxAttackCount ≥ 1`]: **40×Lv** → 40, 80, 120, 160, 200, 240, 280, 320, 360, 400 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`1 ≥ maxAttackCount` และ `maxAttackCount ≥ 1` หรือ `1 < maxAttackCount` และ `2 ≥ maxAttackCount` และ `maxAttackCount ≥ 1` หรือ `1 < maxAttackCount` และ `2 < maxAttackCount` และ `3 ≥ maxAttackCount` และ `maxAttackCount ≥ 1`]: `skillRate / 100` — โดยที่ `skillRate` = `10 × Lv + 2 × baseDEX + 500` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**จำนวนฮิต / ตัวนับ**
- `maxAttackCount` (ตั้งใน `ActionPreparation`) [`IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) ≠ 1` และ `System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) = 0` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ≠ 0` หรือ `IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) = 1` และ `SkillBufferDataBase.GetParam(20) ≤ 0` และ `System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) = 0` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ≠ 0` หรือ `IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) = 1` และ `SkillBufferDataBase.GetParam(20) > 0` และ `System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) = 0` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ≠ 0`]: `min(SkillBufferDataBase.GetParam(20), 2) + maxAttackCount` — โดยที่ `maxAttackCount` = `min(SkillBufferDataBase.GetParam(20), 2) + maxAttackCount` [`IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) ≠ 1` และ `System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) = 0` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ≠ 0` หรือ `IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) = 1` และ `SkillBufferDataBase.GetParam(20) ≤ 0` และ `System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) = 0` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ≠ 0` หรือ `IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) = 1` และ `SkillBufferDataBase.GetParam(20) > 0` และ `System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) = 0` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ≠ 0`]
- `LoopParam` (ตั้งใน `ActionPreparation`) [`IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) = 1` และ `SkillBufferDataBase.GetParam(20) ≤ 0` และ `System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) = 0` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ≠ 0` หรือ `IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) = 1` และ `SkillBufferDataBase.GetParam(20) > 0` และ `System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) = 0` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ≠ 0`]: `min(SkillBufferDataBase.GetParam(20), 2) + maxAttackCount` — โดยที่ `maxAttackCount` = `min(SkillBufferDataBase.GetParam(20), 2) + maxAttackCount` [`IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) ≠ 1` และ `System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) = 0` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ≠ 0` หรือ `IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) = 1` และ `SkillBufferDataBase.GetParam(20) ≤ 0` และ `System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) = 0` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ≠ 0` หรือ `IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) = 1` และ `SkillBufferDataBase.GetParam(20) > 0` และ `System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) = 0` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ≠ 0`]
- `LoopParam` (ตั้งใน `ActionPreparation`) [`System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) = 0` หรือ `System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) ≠ 0`]: `maxAttackCount` — โดยที่ `maxAttackCount` = `min(SkillBufferDataBase.GetParam(20), 2) + maxAttackCount` [`IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) ≠ 1` และ `System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) = 0` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ≠ 0` หรือ `IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) = 1` และ `SkillBufferDataBase.GetParam(20) ≤ 0` และ `System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) = 0` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ≠ 0` หรือ `IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) = 1` และ `SkillBufferDataBase.GetParam(20) > 0` และ `System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) = 0` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ≠ 0`]
<!-- calc:end -->

### ฟาเรส (Fearless) · uid 519

<img src="../../icons/sk_519.png" width="40" alt="icon">

- ทรี: สกิลอัศวิน (ขั้น 4) · เลเวลสูงสุด: 205 · อาวุธ: โล่ · ต้องเรียนก่อน: N$Pดีเฟนส์$F$เพอร์เฟกต์ดีเฟนส์ · ธง: StarGem
- คลาสในโค้ด: `FearlessAction` · สถานะการแกะ: แกะครบจากโค้ด

> ผลจะเพิ่มขึ้นเมื่ออยู่ในสภาพหยุดนิ่ง(5 ระดับ)
> เพิ่มความเร็วการโจมตี, อาวุธเจาะเข้า, การโจมตีปกติ,
> อัตราส่วนการลดความเสียหาย
> 
> ความเร็วการโจมตีและอาวุธเจาะเข้าจะได้รับอิทธิพลจากค่า VIT ของตัวเอง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, เพิ่มดาเมจตีปกติ
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `FearlessBuf` ระยะเวลา 240 วินาที: เจาะกายภาพ (`PowerResistBreaker`) = `(Count * baseResist)` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0` · ตัวคูณตีปกติ % (`NormalAttackRate`) = `(Count * baseNormalAtkUpRate)` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0` · ความเร็วโจมตี + (`Aspd`) = `(Count * baseAspdUp)` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0` · ตัวคูณดาเมจที่ได้รับจากมอน (หมวดบัพ) (`MobLastDamageRateBuf`) = `int((baseRateDmgDownRate * Count))` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `ArialSlayAction.ActionStart` — ArialSlayAction: ตอนเริ่มทำงานของสกิล: [set] `isMoveAssist` = `0` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManage…; [set] `charaMove` = `UnityEngine.Component.GetComponent<CharacterMove>(actarAction)` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManage…; [set] `enableMove` = `1` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManage… (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=519 -->
#### การคำนวณแบบตัวเลข — Fearless (uid 519)

**ค่าบัพที่ขึ้นกับจำนวน stack**

- บัพ `FearlessBuf` — `PowerResistBreaker` ตามจำนวน `Count`: `Count × baseResist`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |

- บัพ `FearlessBuf` — `NormalAttackRate` ตามจำนวน `Count`: `Count × baseNormalAtkUpRate`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |

- บัพ `FearlessBuf` — `Aspd` ตามจำนวน `Count`: `Count × baseAspdUp`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |

- บัพ `FearlessBuf` — `MobLastDamageRateBuf` ตามจำนวน `Count`: `int(baseRateDmgDownRate × Count)`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |
<!-- calc:end -->

### ไนท์วีล (KnightWill) · uid 520

<img src="../../icons/sk_520.png" width="40" alt="icon">

- ทรี: สกิลอัศวิน (ขั้น 4) · เลเวลสูงสุด: 205 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ไบด์สไตร์ค · ธง: StarGem
- คลาสในโค้ด: `KnightWill` · สถานะการแกะ: แกะครบจากโค้ด

> จะมีผลเมื่อความรู้สึกเป็นศัตรูของเป้าหมายมุ่งมาที่ตัวเอง
> เฮทของตัวเองจะเพิ่มได้ง่ายยิ่งขึ้น
> เสริมประสิทธิภาพของสกิลอัศวิน Lv10 จนถึงทรีเลเวล 3
> (ไม่รวมสกิลในขั้นที่ 3 และขั้นที่ 4)

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- ตัวอ่านสกิลนี้ `CallGolemNormalAttackAction.ActionPreparation` — CallGolemNormalAttackAction: ขั้นเตรียมก่อนปล่อยสกิล: [set] `<SkillParam>k__BackingField` = `(SkillParam | 512)` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (UnityEngine.Object.op_Inequality(PlayerStatusBase.get_… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `HuntingOneNormalAttackAction.ActionPreparation` — HuntingOneNormalAttackAction: ขั้นเตรียมก่อนปล่อยสกิล: [set] `<SkillParam>k__BackingField` = `(SkillParam | 512)` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (UnityEngine.Object.op_Inequality(PlayerStatusBase.get_… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.ActionPreparation` — PlayerAttackBase: ขั้นเตรียมก่อนปล่อยสกิล: [set] `<SkillParam>k__BackingField` = `(_t1355 | 512)` เมื่อ (UnityEngine.Object.op_Inequality(PlayerStatusBase.get_SkillManager(), 0) & 1) ne 0 AND SkillManager.GetSkillLv(PlayerS… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `WarCryAction.ActionPreparation` — WarCryAction: ขั้นเตรียมก่อนปล่อยสกิล: [set] `<SkillParam>k__BackingField` = `(_t1933 | 512)` เมื่อ (UnityEngine.Object.op_Inequality(PlayerStatusBase.get_SkillManager(), 0) & 1) ne 0 AND SkillManager.GetSkillLv(PlayerS… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv17: *เพิ่มค่าเฮท *เพิ่มพลังของแอสเซาต์แอคแทคLv10 เพิ่มปริมาณเฮทของโพรโวคLv10 *เพิ่มอัตราการเกิดแพรี่Lv10 *เพิ่มปริมาณเฮทและพลังของเรจซอร์ดLv10 *เพิ่มพลังของไบด์สไตร์คLv10 *เพิ่มขีดจำกัดการฟื้นฟูของPดีเฟ้นส์Lv10

### ไนท์ฮีล (KnightHeal) · uid 524

<img src="../../icons/sk_524.png" width="40" alt="icon">

- ทรี: สกิลอัศวิน (ขั้น 4) · เลเวลสูงสุด: 205 · อาวุธ: ดาบมือเดียว · ต้องเรียนก่อน: ไนท์สแตนซ์
- คลาสในโค้ด: `KnightHeal` · สถานะการแกะ: แกะครบจากโค้ด

> ความเสียหายที่ได้รับระหว่างใช้ไนท์สแตนซ์
> จะมีบางส่วนที่ถูกสะสมไว้เพื่อใช้ฟื้นฟู HP
> และเมื่อใช้ไนท์สแตนซ์อีกครั้ง
> ค่าที่สะสมไว้ทั้งหมดจะถูกใช้เพื่อฟื้นฟู HP

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ค่าเปอร์เซ็นต์ (`Percent`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
- ตัวอ่านสกิลนี้ `KnightStanceAction.ActionHit` — KnightStanceAction.ActionHit (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv17: *สะสมความเสียหายให้มากขึ้น จากเป้าหมายที่มีเฮทตรงกัน

### อาฟเตอร์ชีลด์ (AfterShield) · uid 525

<img src="../../icons/sk_525.png" width="40" alt="icon">

- ทรี: สกิลอัศวิน (ขั้น 5) · เลเวลสูงสุด: 285 · อาวุธ: ดาบมือเดียว · ต้องเรียนก่อน: ฟาเรส
- คลาสในโค้ด: `AfterShield` · สถานะการแกะ: แกะครบจากโค้ด

> หลังจากเปิดใช้งานPดีเฟ้นส์
> จะลดความเสียหายลงได้ช่วงเวลาหนึ่ง
> 
> และถ้าเรียนรู้จะเพิ่มต้านทานไร้ธาตุเล็กน้อยแบบถาวร

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, พาสซีฟ
- บัพ `AfterShieldBuf`: ตัวคูณดาเมจที่ได้รับจากมอน (หมวดบัพ) (`MobLastDamageRateBuf`) = `(int(LeftTime) + (int(LeftTime) << 2))` (ตัวนับที่เปลี่ยนตามเหตุการณ์)
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- พาสซีฟ ต้านธาตุปกติ (`NormalResist`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
- ตัวอ่านสกิลนี้ `MobAttackBase.CalcLastDamage` — คำนวณ last damage (MobAttackBase): คืนค่า `((SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.ArkSaber, out) & 1) eq 0 ? ((_t983 & 1) eq 0 ? ((_t982 & 1) eq 0 ? _t997 : _t…` (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: ถ้าได้รับความเสียหายร้ายแรงเกินHPสูงสุด ระหว่างอาฟเตอร์ชีลด์มีผลอยู่ความเสียหายนั้นจะไม่มีผล แต่หลังจากใช้งานไป 1 ครั้งจะไม่สามารถ ใช้งานอาฟเตอร์ชีลด์ได้อีกในระยะเวลาหนึ่ง

### บลิงค์ซอร์ด (BlinkSword) · uid 526

<img src="../../icons/sk_526.png" width="40" alt="icon">

- ทรี: สกิลอัศวิน (ขั้น 5) · เลเวลสูงสุด: 285 · อาวุธ: ดาบมือเดียว · ต้องเรียนก่อน: ไนท์วีล
- คลาสในโค้ด: `BlinkSwordAction` · สถานะการแกะ: แกะครบจากโค้ด

> ขว้างดาบและเข้าใกล้เป้าหมายทันที
> มีโอกาส[ผงะ]สามารถลดเปอร์เซ็นต์ความเสียหาย
> ได้เป็นเวลา 3 วินาทีหลังจากสำเร็จ
> แม้ว่าจะเคลื่อนไหวผลของฟาเรสจะไม่หายไป

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: ผงะ (Flinch)
- บัพ `BlinkSwordBuf` ระยะเวลา 3 วินาที: ตัวคูณดาเมจที่ได้รับ (`RateDamageResist`) = 3×Lv → 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 (Lv1…10)
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `MobAttackBase.CalcLastDamage` — คำนวณ last damage (MobAttackBase): คืนค่า `((SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.ArkSaber, out) & 1) eq 0 ? ((_t983 & 1) eq 0 ? ((_t982 & 1) eq 0 ? _t997 : _t…` (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: ถ้าทำให้ติดผงะได้สำเร็จ บลิงค์ซอร์ดจะเล็งตรงเป้าแน่นอน หากเกิดMISSการเปิดใช้งานจะล้มเหลว

<!-- calc:begin uid=526 -->
#### การคำนวณแบบตัวเลข — BlinkSword (uid 526)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **200** → 200, 200, 200, 200, 200, 200, 200, 200, 200, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1)` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1)` และ `PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction)` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1)` และ `PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ … · กิ่งที่ 1 ของ `skillRate`]: `(75 × Lv + baseVIT + 500) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseVIT` = แต้ม VIT ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseVIT (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1)` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1)` และ `PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction)` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1)` และ `PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ …]: `(skillRate + baseVIT) / 100` — โดยที่ `skillRate` = `75 × Lv + 500` หรือ `skillRate + baseVIT` [`AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1)` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1)` และ `PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction)` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1)` และ `PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ …] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseVIT` = แต้ม VIT ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseVIT (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` หรือ `!PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction)` และ `AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` หรือ `!AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1)` และ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3)` · กิ่งที่ 1 ของ `skillRate` หรือ `AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1)` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ … หรือ `AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1)` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1)` และ `PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction)` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1)` และ `PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ … หรือ …(เงื่อนไขเต็มดูใน details)]: **(500 + 75×Lv)%** → 575%, 650%, 725%, 800%, 875%, 950%, 1025%, 1100%, 1175%, 1250% (Lv1…10)

**ใช้ร่วมทุกฮิตของ ฮิตรีแอ็กชัน (`HitReactionAssign`)**
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical)` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobBuffer.GuardUpBuff.get_GuardUpval` = ค่า Guard Upval ของ GuardUpBuff; `TryGetBuff.buff` = TryGetBuff.buff; `MobActionManagerBase.get_BuffManager` = ค่า Buff Manager ของ MobActionManagerBase (ดูแท็บ Variables)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) = 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: **25** → 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 (Lv1…10)
<!-- calc:end -->

### ไนท์เพลดจ์ (KnightPledge) · uid 527

<img src="../../icons/sk_527.png" width="40" alt="icon">

- ทรี: สกิลอัศวิน (ขั้น 5) · เลเวลสูงสุด: 285 · อาวุธ: ดาบมือเดียว · ต้องเรียนก่อน: ไนท์ฮีล
- คลาสในโค้ด: `KnightPledgeAction` · สถานะการแกะ: แกะครบจากโค้ด

> แทงดาบแห่งคำสาบานเพื่อสร้างพื้นที่ป้องกัน
> เพิ่มพลังโจมตีภายในพื้นที่และเพิ่มต้านทานความเสียหาย
> อย่างรุนแรง(ลดลงตามจำนวนครั้ง)ให้กับผู้อื่น
> จะหายไปเมื่อโดนโจมตีแบบผลักกระเด็น
> ผลลัพธ์จะกระจายมากขึ้นตามเป้าหมายที่ปกป้อง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, วางวัตถุ/กับดัก/อัญเชิญ
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `KnightPledgeBuf`: ลดระยะกระเด็น % (`KnockbackDistReduceRate`) = `knockbackDistReduceRate` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ค่าทั่วไปตัวที่ 2 (`Value2`) = `effectiveNum` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `selfBufData.totalReduceValue` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ตัวคูณดาเมจที่ได้รับจากมอน (หมวดเฉพาะ) (`MobLastDamageRateUnique`) = `(totalReduceValue // effectiveNum)` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ตัวคูณดาเมจสุดท้าย (ทศนิยม) (`LastDamageRateDecimal`) = `((lastDamageRate * 100) // effectiveNum)` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `selfBufData.totalReduceValue` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์)
- ตัวอ่านสกิลนี้ `MobAttackBase.CalcLastDamage` — คำนวณ last damage (MobAttackBase): คืนค่า `((SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.ArkSaber, out) & 1) eq 0 ? ((_t983 & 1) eq 0 ? ((_t982 & 1) eq 0 ? _t997 : _t…` (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: หากลดความเสียหายจากการโจมตีแบบผลักกระเด็นในพื้นที่ จะสามารถลดระยะนั้นลงได้เป็นอย่างมาก แต่ดาบที่แทงลงไปจะถูกดีดออกทำให้ผลของสกิลสิ้นสุดลง  นอกจากนี้หากมีหลายเป้าหมายในพื้นที่ พลังโจมตีจะเพิ่มขึ้น ความเสียหายจะลดลง ผลลดลงเนื่องจากการกระจายของผลการลดผลักกระเด็น
- Lv17: *ความต้านทานผลักกระเด็นเพิ่มขึ้นอีก พลังโจมตีเพิ่มขึ้นอีกขึ้นอยู่กับค่าถลุงโล่

