# สกิลนักฆ่า (`AssassinSkill`) — คำอธิบายทีละสกิล (ภาษาไทย)

สร้างอัตโนมัติด้วย `scripts/render_explained_th.py` จาก `skill_reference.json` (ข้อมูลโค้ด client ชุดล่าสุด) ไม่มีข้อความเขียนมือ แก้ไฟล์นี้ตรง ๆ จะถูกเขียนทับ ตัวเลขทั้งหมดคำนวณจากโค้ด (Code) ความหมายของชื่อ field/บทบาทแปลจากชื่อในโค้ด (Inferred) ยังไม่ได้เทียบกับตัวเลขในเกม ข้อมูลดิบทุกเส้นทางอยู่ใน `../details/AssassinSkill.md`

---

<!-- calc:preface -->
> **วิธีอ่านหัวข้อ "การคำนวณแบบตัวเลข"** (สร้างอัตโนมัติด้วย `scripts/render_calc_th.py` จาก `skill_reference.json` แก้มือจะถูกเขียนทับ)
> ดาเมจต่อฮิตเดินตามขั้น `SkillCalcTemplate/CalcStep` 0→40 ตามลำดับ (Code: `SkillCalcTemplate.GetDamage`) ขั้น `+` บวกเข้าดาเมจ ขั้น `×` คูณแล้วปัดเศษทิ้ง (int) ทันทีทุกขั้น
> ลำดับหลัก: ดาเมจฐาน(7) + คงที่สกิล(8) + คงที่บัพ(9) − ป้องกันเป้า(10) + ตีแรก(11) → ×คริ(13) → ×ธาตุ(15) → ×ตัวคูณสกิล(18) → ×ตีแรก(19) → ×เสถียร(21) → +คงที่ออโต้(22) → ×Proration(23) → ×ประเภท(24) → ×ดาเมจสุดท้าย(25) → … → เพดาน/ขั้นต่ำ(35–37)
> "ฮิต N" = template ดาเมจแต่ละก้อน (ทอยคริแยกกัน) แยกตามเมธอดและตัวแปรฮิตในโค้ด (`type`, `isFirst`, `attackCount` …) ชื่อฮิต/ส่วนมาจากชื่อในโค้ด (Inferred) ตัวเลขคำนวณจากโค้ด (Code) โดยตั้งเจม/บัพเสริม = 0
> ค่าหลายก้อนในขั้นเดียวกันแบบ "บวกเข้าช่อง" จะบวกกันก่อนคูณ ส่วน "ตั้งค่าทับ" แทนที่ค่าเดิม ค่าที่ขึ้นกับสเตตัสแสดงเป็นตัวอย่างที่ 100 / 255 (และ Lv สกิลอื่น 1 / 10) ใช้สูตรที่แนบไว้คำนวณค่าอื่นเอง
<!-- calc:preface-end -->

### แอสแซสซินสแทบ / ฟรอนท์สแทบ / ไซด์สแทบ / แบ็คสแทบ (AssassinStub) · uid 993

<img src="../../icons/sk_993.png" width="40" alt="icon">

- ทรี: สกิลนักฆ่า (ขั้น 1) · เลเวลสูงสุด: 15 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: NoMarketSearch, MercenaryCanUseSkill
- คลาสในโค้ด: `AssassinStubAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีเป้าหมายหนึ่งครั้งอย่างหมายเอาชีวิต
> ประสิทธิภาพจะเปลี่ยนไปตามทิศทางการโจมตี
> จะแสดงพลังความสามารถได้มากที่สุดจากการเล็งทางด้านหลังของศัตรู

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `AssassinStubBuf`: ความแม่น % (`HitRate`) = `hitUp`
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `AssassinStubAction.OnEnd` — AssassinStubAction.OnEnd: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.AssassinStub` เมื่อ (UnityEngine.Object.op_Inequality(playerAction, 0) & 1) ne 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.ge… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv18: [จะได้รับผลแบบเดียวกันเมื่อใช้คัมภีร์นินจูตสึ] *พลัง+50 สำหรับฟรอนท์สแทบ  * พลัง+100 สำหรับไซด์สแทบ *พลัง+300 สำหรับแบ็คสแต็บ

<!-- calc:begin uid=993 -->
#### การคำนวณแบบตัวเลข — AssassinStub (uid 993)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `direction = 1`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `int((A = 0 ? 1 : A) × ((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + (isEquipBonus = 0 ? B : B + 100))) / 100` · `A = 0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 2` · `B = SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate)` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `BackstepBuf.GetParam` = BackstepBuf: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า); `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.LastDmgRate` = ดาเมจสุดท้าย % (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 1005 AssassinationSecrets ≥ 1`]: `int((A = 0 ? 1 : A) × ((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + gemCart(1004, [4]) + AssassinationSecrets.GetAssassinStubSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1), PlayerActionManagerBase.get_PlayerStatus()) + (isEquipBonus = 0 ? B : B + 100))) / 100` · `A = 0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 2` · `B = SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate)` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `BackstepBuf.GetParam` = BackstepBuf: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า); `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `AssassinationSecrets.GetAssassinStubSkillRate` = AssassinationSecrets.GetAssassinStubSkillRate; `SkillManager.GetSkillLv` = เลเวลของสกิลที่ผู้เล่นเรียน; `PlayerStatusBase.get_SkillManager` = ค่า Skill Manager ของ PlayerStatusBase; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase …(+2) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 1005 AssassinationSecrets < 1`]: `int((A = 0 ? 1 : A) × ((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + gemCart(1004, [4]) + (isEquipBonus = 0 ? B : B + 100))) / 100` · `A = 0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 2` · `B = SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate)` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `BackstepBuf.GetParam` = BackstepBuf: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า); `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.LastDmgRate` = ดาเมจสุดท้าย % (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `int((A = 0 ? 1 : A) × (Lv + (isEquipBonus = 0 ? 0 : 50) + (isEquipBonus = 0 ? B : B + 100) + 100)) / 100` · `A = 0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 2` · `B = SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate)` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `BackstepBuf.GetParam` = BackstepBuf: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า); `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.LastDmgRate` = ดาเมจสุดท้าย % (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `int((B = 0 ? 1 : B) × ((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + (isEquipBonus = 0 ? A : A + 100))) / 100` · `A = SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate)` · `B = 0.01 × BackstepBuf.GetParam(50) + 1` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `BackstepBuf.GetParam` = BackstepBuf: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า); `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.LastDmgRate` = ดาเมจสุดท้าย % (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 1005 AssassinationSecrets ≥ 1`]: `int((B = 0 ? 1 : B) × ((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + gemCart(1004, [4]) + AssassinationSecrets.GetAssassinStubSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1), PlayerActionManagerBase.get_PlayerStatus()) + (isEquipBonus = 0 ? A : A + 100))) / 100` · `A = SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate)` · `B = 0.01 × BackstepBuf.GetParam(50) + 1` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `BackstepBuf.GetParam` = BackstepBuf: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า); `AssassinationSecrets.GetAssassinStubSkillRate` = AssassinationSecrets.GetAssassinStubSkillRate; `SkillManager.GetSkillLv` = เลเวลของสกิลที่ผู้เล่นเรียน; `PlayerStatusBase.get_SkillManager` = ค่า Skill Manager ของ PlayerStatusBase; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล …(+2) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 1005 AssassinationSecrets < 1`]: `int((B = 0 ? 1 : B) × ((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + gemCart(1004, [4]) + (isEquipBonus = 0 ? A : A + 100))) / 100` · `A = SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate)` · `B = 0.01 × BackstepBuf.GetParam(50) + 1` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `BackstepBuf.GetParam` = BackstepBuf: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า); `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.LastDmgRate` = ดาเมจสุดท้าย % (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `int((B = 0 ? 1 : B) × (Lv + (isEquipBonus = 0 ? 0 : 50) + (isEquipBonus = 0 ? A : A + 100) + 100)) / 100` · `A = SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate)` · `B = 0.01 × BackstepBuf.GetParam(50) + 1` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `BackstepBuf.GetParam` = BackstepBuf: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า); `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.LastDmgRate` = ดาเมจสุดท้าย % (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `int((A = 0 ? 1 : A) × ((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + (isEquipBonus = 0 ? B : B + 100))) / 100` · `A = 0.01 × SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 1` · `B = SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate)` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.LastDmgRate` = ดาเมจสุดท้าย % (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 1005 AssassinationSecrets ≥ 1`]: `int((A = 0 ? 1 : A) × ((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + gemCart(1004, [4]) + AssassinationSecrets.GetAssassinStubSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1), PlayerActionManagerBase.get_PlayerStatus()) + (isEquipBonus = 0 ? B : B + 100))) / 100` · `A = 0.01 × SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 1` · `B = SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate)` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `AssassinationSecrets.GetAssassinStubSkillRate` = AssassinationSecrets.GetAssassinStubSkillRate; `SkillManager.GetSkillLv` = เลเวลของสกิลที่ผู้เล่นเรียน; `PlayerStatusBase.get_SkillManager` = ค่า Skill Manager ของ PlayerStatusBase; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `MasteryId.LastDmgRate` = ดาเมจสุดท้าย % …(+1) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 1005 AssassinationSecrets < 1`]: `int((A = 0 ? 1 : A) × ((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + gemCart(1004, [4]) + (isEquipBonus = 0 ? B : B + 100))) / 100` · `A = 0.01 × SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 1` · `B = SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate)` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.LastDmgRate` = ดาเมจสุดท้าย % (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `int((A = 0 ? 1 : A) × (Lv + (isEquipBonus = 0 ? 0 : 50) + (isEquipBonus = 0 ? B : B + 100) + 100)) / 100` · `A = 0.01 × SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 1` · `B = SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate)` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.LastDmgRate` = ดาเมจสุดท้าย % (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `int((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + (isEquipBonus = 0 ? A : A + 100)) / 100` · `A = SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate)` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.LastDmgRate` = ดาเมจสุดท้าย % (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 1005 AssassinationSecrets ≥ 1`]: `int((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + gemCart(1004, [4]) + AssassinationSecrets.GetAssassinStubSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1), PlayerActionManagerBase.get_PlayerStatus()) + (isEquipBonus = 0 ? A : A + 100)) / 100` · `A = SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate)` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `AssassinationSecrets.GetAssassinStubSkillRate` = AssassinationSecrets.GetAssassinStubSkillRate; `SkillManager.GetSkillLv` = เลเวลของสกิลที่ผู้เล่นเรียน; `PlayerStatusBase.get_SkillManager` = ค่า Skill Manager ของ PlayerStatusBase; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `SkillId.AssassinationSecrets` = เคล็ดลับลอบสังหาร …(+1) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 1005 AssassinationSecrets < 1`]: `int((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + gemCart(1004, [4]) + (isEquipBonus = 0 ? A : A + 100)) / 100` · `A = SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate)` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.LastDmgRate` = ดาเมจสุดท้าย % (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `int(Lv + (isEquipBonus = 0 ? 0 : 50) + (isEquipBonus = 0 ? A : A + 100) + 100) / 100` · `A = SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate)` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.LastDmgRate` = ดาเมจสุดท้าย % (ดูแท็บ Variables)

**ใช้ร่วมทุกฮิตของ ดาเมจหลัก**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **30×Lv** → 30, 60, 90, 120, 150, 180, 210, 240, 270, 300 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `int((A = 0 ? 1 : A) × ((isEquipBonus = 0 ? 105 : 205) + 3 × Lv)) / 100` · `A = 0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 2` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `BackstepBuf.GetParam` = BackstepBuf: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า); `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.LastDmgRate` = ดาเมจสุดท้าย % (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 1005 AssassinationSecrets ≥ 1`]: `int((A = 0 ? 1 : A) × ((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + gemCart(1004, [4]) + AssassinationSecrets.GetAssassinStubSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1), PlayerActionManagerBase.get_PlayerStatus()))) / 100` · `A = 0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 2` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `BackstepBuf.GetParam` = BackstepBuf: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า); `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `AssassinationSecrets.GetAssassinStubSkillRate` = AssassinationSecrets.GetAssassinStubSkillRate; `SkillManager.GetSkillLv` = เลเวลของสกิลที่ผู้เล่นเรียน; `PlayerStatusBase.get_SkillManager` = ค่า Skill Manager ของ PlayerStatusBase; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase …(+2) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 1005 AssassinationSecrets < 1`]: `int((A = 0 ? 1 : A) × ((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + gemCart(1004, [4]))) / 100` · `A = 0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 2` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `BackstepBuf.GetParam` = BackstepBuf: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า); `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.LastDmgRate` = ดาเมจสุดท้าย % (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `int((A = 0 ? 1 : A) × (Lv + (isEquipBonus = 0 ? 0 : 50) + 100)) / 100` · `A = 0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 2` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `BackstepBuf.GetParam` = BackstepBuf: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า); `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.LastDmgRate` = ดาเมจสุดท้าย % (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `int((A = 0 ? 1 : A) × ((isEquipBonus = 0 ? 105 : 205) + 3 × Lv)) / 100` · `A = 0.01 × BackstepBuf.GetParam(50) + 1` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `BackstepBuf.GetParam` = BackstepBuf: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 1005 AssassinationSecrets ≥ 1`]: `int((A = 0 ? 1 : A) × ((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + gemCart(1004, [4]) + AssassinationSecrets.GetAssassinStubSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1), PlayerActionManagerBase.get_PlayerStatus()))) / 100` · `A = 0.01 × BackstepBuf.GetParam(50) + 1` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `BackstepBuf.GetParam` = BackstepBuf: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า); `AssassinationSecrets.GetAssassinStubSkillRate` = AssassinationSecrets.GetAssassinStubSkillRate; `SkillManager.GetSkillLv` = เลเวลของสกิลที่ผู้เล่นเรียน; `PlayerStatusBase.get_SkillManager` = ค่า Skill Manager ของ PlayerStatusBase; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `SkillId.AssassinationSecrets` = เคล็ดลับลอบสังหาร (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 1005 AssassinationSecrets < 1`]: `int((A = 0 ? 1 : A) × ((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + gemCart(1004, [4]))) / 100` · `A = 0.01 × BackstepBuf.GetParam(50) + 1` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `BackstepBuf.GetParam` = BackstepBuf: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `int((A = 0 ? 1 : A) × (Lv + (isEquipBonus = 0 ? 0 : 50) + 100)) / 100` · `A = 0.01 × BackstepBuf.GetParam(50) + 1` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `BackstepBuf.GetParam` = BackstepBuf: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `int((A = 0 ? 1 : A) × ((isEquipBonus = 0 ? 105 : 205) + 3 × Lv)) / 100` · `A = 0.01 × SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 1` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.LastDmgRate` = ดาเมจสุดท้าย % (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 1005 AssassinationSecrets ≥ 1`]: `int((A = 0 ? 1 : A) × ((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + gemCart(1004, [4]) + AssassinationSecrets.GetAssassinStubSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1), PlayerActionManagerBase.get_PlayerStatus()))) / 100` · `A = 0.01 × SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 1` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `AssassinationSecrets.GetAssassinStubSkillRate` = AssassinationSecrets.GetAssassinStubSkillRate; `SkillManager.GetSkillLv` = เลเวลของสกิลที่ผู้เล่นเรียน; `PlayerStatusBase.get_SkillManager` = ค่า Skill Manager ของ PlayerStatusBase; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `MasteryId.LastDmgRate` = ดาเมจสุดท้าย % …(+1) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 1005 AssassinationSecrets < 1`]: `int((A = 0 ? 1 : A) × ((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + gemCart(1004, [4]))) / 100` · `A = 0.01 × SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 1` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.LastDmgRate` = ดาเมจสุดท้าย % (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `int((A = 0 ? 1 : A) × (Lv + (isEquipBonus = 0 ? 0 : 50) + 100)) / 100` · `A = 0.01 × SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 1` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.LastDmgRate` = ดาเมจสุดท้าย % (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 1005 AssassinationSecrets ≥ 1`]: `int((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + gemCart(1004, [4]) + AssassinationSecrets.GetAssassinStubSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1), PlayerActionManagerBase.get_PlayerStatus())) / 100` — โดยที่ `isEquipBonus` = `1` [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `AssassinationSecrets.GetAssassinStubSkillRate` = AssassinationSecrets.GetAssassinStubSkillRate; `SkillManager.GetSkillLv` = เลเวลของสกิลที่ผู้เล่นเรียน; `PlayerStatusBase.get_SkillManager` = ค่า Skill Manager ของ PlayerStatusBase; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `SkillId.AssassinationSecrets` = เคล็ดลับลอบสังหาร (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(205 + 3×Lv)%** → 208%, 211%, 214%, 217%, 220%, 223%, 226%, 229%, 232%, 235% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(150 + Lv)%** → 151%, 152%, 153%, 154%, 155%, 156%, 157%, 158%, 159%, 160% (Lv1…10)
<!-- calc:end -->

### อีเวชัน (Evolution) · uid 994

<img src="../../icons/sk_994.png" width="40" alt="icon">

- ทรี: สกิลนักฆ่า (ขั้น 1) · เลเวลสูงสุด: 15 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: NoMarketSearch, MercenaryCanUseSkill
- คลาสในโค้ด: `EvolutionAction` · สถานะการแกะ: แกะครบจากโค้ด

> สกิลเพิ่มความสามารถในการหลบหลีก
> เพิ่มอัตราการหลบหลีกชั่วขณะ
> เมื่อใช้จะปลดสถานะผิดปกติ "เชื่องช้า"

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, บัพปาร์ตี้/ผู้อื่น
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `EvolutionBuf` ระยะเวลา 40 + 2×Lv → 42, 44, 46, 48, 50, 52, 54, 56, 58, 60 (Lv1…10) วินาที [`itemType = 23` หรือ `itemType = 18` และ `itemType ≠ 23`] / 20 + Lv → 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 (Lv1…10) วินาที [`itemType ≠ 18` และ `itemType ≠ 23`]: หลบ + (`Flee`) = 10 + Lv → 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 (Lv1…10) · หลบ % (`FleeRate`) = Lv → 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่

**โน้ตในเกม (ข้อความจากเกม):**
- Lv18: [จะได้รับผลแบบเดียวกันเมื่อใช้คัมภีร์นินจูตสึ] *2x ระยะเวลาแสดงผล *หลบหลีก +10

### เวนอมอินเจค (VenomInject) · uid 1001

<img src="../../icons/sk_1001.png" width="40" alt="icon">

- ทรี: สกิลนักฆ่า (ขั้น 1) · เลเวลสูงสุด: 15 · อาวุธ: มีด, NinjutsuScroll, MainHand · ธง: NoMarketSearch
- คลาสในโค้ด: `VenomInjectAction` · สถานะการแกะ: แกะครบจากโค้ด

> ทักษะลอบสังหารเคลือบพิษที่อาวุธ
> ใช้ HP ของตัวเองเพื่อเพิ่มโอกาสติดพิษร้าย
> ระหว่างการโจมตีปกติ อัตราการติด
> จะเปลี่ยนไปตามประสิทธิภาพของ
> ดาบสั้น/ม้วนคัมภีร์นินจูตสึ, คริติคอลและ Graze

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, เปลี่ยนการทำงานของตีปกติ
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `VenomInjectBuf`: ค่าเปอร์เซ็นต์ทั่วไป (`Percent`) = 10×Lv → 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10) · ค่าเปอร์เซ็นต์ทั่วไป (`Percent`) = `CountBufferBase.GetParam(this, id)`
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = (Lv << 1) ตามที่ `VenomInjectBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `NormalAttackAction.PossibilityAbnormalState` — NormalAttackAction.PossibilityAbnormalState: คืนค่า `0x165d9d4(meta(0x39744c8, AbnormalType[]_TypeInfo), 1)` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `VenomInjectAction.CalcPercent` — คำนวณ percent (VenomInjectAction): คืนค่า `_t1930` (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: *อัตราติดพิษเพิ่มขึ้นตามสกิลเลเวล
- Lv9: *อัตราติดพิษเพิ่มขึ้นตามสกิลเลเวล
- Lv254: **อัตราติดพิษเพิ่มขึ้นตามสกิลเลเวล

### แบ็คสเต็ป (Backstep) · uid 995

<img src="../../icons/sk_995.png" width="40" alt="icon">

- ทรี: สกิลนักฆ่า (ขั้น 2) · เลเวลสูงสุด: 35 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: [N]แอสแซสซินสแทบ[F]ฟรอนท์สแทบ[S]ไซด์สแทบ[B]แบ็คสแทบ[N] · ธง: NoMarketSearch, MercenaryCanUseSkill
- คลาสในโค้ด: `BackstepAction` · สถานะการแกะ: แกะครบจากโค้ด

> สกิลหลบหลีกอย่างว่องไว
> เมื่อเคลื่อนย้ายในระยะทางที่กำหนดได้สำเร็จ
> เพิ่มพลังโจมตีของแอสแซสซินสแทบที่จะใช้ถัดไป
> MP จะเพิ่มขึ้นเล็กน้อย
> เมื่อใช้ให้เข้ากับสัญญาณเตือนโจมตีของมอนสเตอร์

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `BackstepBuf`: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = 5×Lv → 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10)
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่

**โน้ตในเกม (ข้อความจากเกม):**
- Lv18: [จะได้รับผลแบบเดียวกันเมื่อใช้คัมภีร์นินจูตสึ] *ปริมาณฟื้นฟู MP เป็น 2 เท่า

<!-- calc:begin uid=995 -->
#### การคำนวณแบบตัวเลข — Backstep (uid 995)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `ActionStart`): `int((UnityEngine.Quaternion.Internal_MakePositive(0).y * 100))`
<!-- calc:end -->

### เซียรัม (Sierram) · uid 996

<img src="../../icons/sk_996.png" width="40" alt="icon">

- ทรี: สกิลนักฆ่า (ขั้น 2) · เลเวลสูงสุด: 35 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: อีเวชัน · ธง: NoMarketSearch, MercenaryCanUseSkill
- คลาสในโค้ด: `SierramAction` · สถานะการแกะ: แกะครบจากโค้ด

> สกิลระงับความเจ็บปวด
> จะลดความเสียหายที่มีอย่างต่อเนื่องของพิษและไหม้ไฟชั่วระยะเวลาหนึ่ง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, บัพปาร์ตี้/ผู้อื่น
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `SierramBuf` ระยะเวลา 30 + 3×Lv → 33, 36, 39, 42, 45, 48, 51, 54, 57, 60 (Lv1…10) วินาที [อาวุธรอง ม้วนนินจุตสึ หรือ อาวุธรอง มีด] / 10 + Lv → 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 (Lv1…10) วินาที [อาวุธรองอื่น (ไม่ใช่ ม้วนนินจุตสึ/มีด)]: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = 27, 30, 32, 35, 37, 40, 42, 45, 47, 50 (Lv1…10) · ค่าทั่วไปตัวที่ 2 (`Value2`) = 10 + 2×Lv → 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 (Lv1…10)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv18: [จะได้รับผลแบบเดียวกันเมื่อใช้คัมภีร์นินจูตสึ] *ระยะเวลาแสดงผล x3

### พิษกัดกร่อน (CorrosivePoison) · uid 1002

<img src="../../icons/sk_1002.png" width="40" alt="icon">

- ทรี: สกิลนักฆ่า (ขั้น 2) · เลเวลสูงสุด: 35 · อาวุธ: มีด, NinjutsuScroll, MainHand · ต้องเรียนก่อน: เวนอมอินเจค · ธง: NoMarketSearch
- คลาสในโค้ด: `CorrosivePoison` · สถานะการแกะ: แกะครบจากโค้ด

> เวนอมอินเจคทำให้เพิ่มพิษร้ายซ้อนกันได้
> ถ้าเพิ่มพิษร้ายโดยการซ้อน(สูงสุด+2)
> การโจมตีของผู้เล่นอาจทำให้
> เกิดความเสียหายจากพิษร้ายได้ด้วย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- ตัวอ่านสกิลนี้ `CorrosivePoison.CalcCorrosivePoison` — คำนวณ corrosive poison (CorrosivePoison): [call] `VenomInjectAction$$CalcPercent` = `PlayerActionManagerBase.get_PlayerStatus(), (damageData.HitType eq 2 ? 1 : 0), damageData…` เมื่อ (AbnormalStateManager.TryGetAbnormalStateData(EnemyMobActionManagerBase.get_AbnormalStateManager(mobAction), AbnormalTy…; [call] `VenomInjectAction$$CalcPercent` = `PlayerActionManagerBase.get_PlayerStatus(), (damageData.HitType eq 2 ? 1 : 0), damageData…` เมื่อ (AbnormalStateManager.TryGetAbnormalStateData(EnemyMobActionManagerBase.get_AbnormalStateManager(mobAction), AbnormalTy… (นิยามเต็มในแท็บ Variables)

### ฟูเนวินเด (FuneVinte) · uid 997

<img src="../../icons/sk_997.png" width="40" alt="icon">

- ทรี: สกิลนักฆ่า (ขั้น 3) · เลเวลสูงสุด: 125 · อาวุธ: มีด, NinjutsuScroll · ต้องเรียนก่อน: แบ็คสเต็ป · ธง: NoMarketSearch, MercenaryCanUseSkill
- คลาสในโค้ด: `FuneVinteAction` · สถานะการแกะ: แกะครบจากโค้ด

> แก่นแท้สกิลของกลุ่มนักฆ่าที่สืบทอดต่อกันมา
> ใช้ MP ทั้งหมดเพื่อโจมตีเป้าหมาย
> เพิ่มปริมาณการฟื้นฟู MP สูงขึ้นจนกว่าจะใช้สกิลถัดไป
> ถ้าไม่ถูกเล็งเป้าเฮทของตัวเองจะลดน้อยลงเป็นอย่างมาก

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- MP ที่ใช้: `PlayerAttackBase.CalcCostMp(this, actarAction)`
- MP ที่ใช้: 0
- MP ที่ใช้ [`(SkillComboState.get_CurrentComboType(_currentSkillCombo) & 255) = 4`]: 0
- MP ที่ใช้ [`(SkillComboState.get_CurrentComboType(_currentSkillCombo) & 255) ≠ 4`]: `PlayerAttackBase.CalcCostMp(this, playerAction)`
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `FuneVinteBuf`: MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = 10, 10, 10, 10, 10, 20, 20, 20, 20, 20 (Lv1…10)
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `PlayerAttackBase.RemoveAfterSkillBuf` — PlayerAttackBase.RemoveAfterSkillBuf: [call] `SkillBufferManager$$RemoveBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.FuneVinte` เมื่อ (PlayerAttackBase.ContainsNotApplicableSkill(PlayerAttackBase.get_ActionID()) & 1) eq 0 AND (SkillBufferManager.Contain… (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=997 -->
#### การคำนวณแบบตัวเลข — FuneVinte (uid 997)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **500 + 50×Lv** → 550, 600, 650, 700, 750, 800, 850, 900, 950, 1000 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 1004 DeathReception < 1` และ `Lv สกิล 1005 AssassinationSecrets ≥ 1` หรือ `Lv สกิล 1004 DeathReception ≥ 1` และ `Lv สกิล 1005 AssassinationSecrets ≥ 1`]: `(10 × Lv + PlayerAttackBase.get_Mp() // 100 × (int(AssassinationSecrets.GetFuneVinteMpSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1), PlayerActionManagerBase.get_PlayerStatus())) + 4 × Lv + 60)) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.get_Mp` = ค่า Mp ของ PlayerAttackBase; `AssassinationSecrets.GetFuneVinteMpSkillRate` = AssassinationSecrets.GetFuneVinteMpSkillRate; `SkillManager.GetSkillLv` = เลเวลของสกิลที่ผู้เล่นเรียน; `PlayerStatusBase.get_SkillManager` = ค่า Skill Manager ของ PlayerStatusBase; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `SkillId.AssassinationSecrets` = เคล็ดลับลอบสังหาร (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `(10 × Lv + PlayerAttackBase.get_Mp() // 100 × (4 × Lv + 60)) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.get_Mp` = ค่า Mp ของ PlayerAttackBase (ดูแท็บ Variables)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `ActionStart`): `int(100 × MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)))`
<!-- calc:end -->

### ละทิ้ง (Abandonment) · uid 998

<img src="../../icons/sk_998.png" width="40" alt="icon">

- ทรี: สกิลนักฆ่า (ขั้น 3) · เลเวลสูงสุด: 125 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: เซียรัม · ธง: NoMarketSearch
- คลาสในโค้ด: `Abandonment` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่มความสามารถในการหลบหลีกของตัวเองจนเกินขีดจำกัด
> ลดความแม่นที่มีของมอนสเตอร์ลงต่ำสุด
> ทำให้หลบหลีกได้ดีกว่าเดิม
> เพิ่มพลังของแอสแซสซินสแทบ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ดาเมจสุดท้าย % (`LastDmgRate`): 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10)
- พาสซีฟ ความแม่น (`Hit`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)

### เวนอมสแนทช (VenomSnatch) · uid 1003

<img src="../../icons/sk_1003.png" width="40" alt="icon">

- ทรี: สกิลนักฆ่า (ขั้น 3) · เลเวลสูงสุด: 125 · อาวุธ: มีด, NinjutsuScroll, MainHand · ต้องเรียนก่อน: พิษกัดกร่อน · ธง: NoMarketSearch
- คลาสในโค้ด: `VenomSnatchAction` · สถานะการแกะ: แกะครบจากโค้ด

> ช่วงชิงพิษกัดกร่อนเป้าหมาย
> ฟื้นฟู HP และสถานะพิษของตัวเอง
> 
> ถ้าเป็นพิษร้ายที่อัพเกรดจะฟื้นฟู MP ด้วย
> ถ้าไม่มีพิษที่สามารถกำจัดออกจาก
> ตัวเองได้จะได้รับผลการป้องกัน

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `VenomSnatchBuf`: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `poisonLevel` · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `CountBufferBase.GetParam(this, id)`
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = poisonLevel ตามที่ `VenomSnatchBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `DeathReceptionAction.IsFailure` — เงื่อนไข is failure (DeathReceptionAction): คืนค่า `PlayerAttackBase.IsFailure(this, status, missType)` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `VenomSnatchAction.BattleResult` — VenomSnatchAction.BattleResult: [call] `VenomSnatchAction$$CalcHpHealValue` = `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.VenomSnatch, 1), Pla…` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.VenomSnatch, 1) ge 1; [call] `VenomSnatchAction$$CalcMpHealValue` = `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.VenomSnatch, 1), Pla…` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.VenomSnatch, 1) ge 1; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new VenomSnatchBuf, 0` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.VenomSnatch, 1) ge 1 AND SkillManager.GetSkillLv(P… (นิยามเต็มในแท็บ Variables)

### ซิคาเรียส (Seekerius) · uid 999

<img src="../../icons/sk_999.png" width="40" alt="icon">

- ทรี: สกิลนักฆ่า (ขั้น 4) · เลเวลสูงสุด: 205 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: แบ็คสเต็ป · ธง: NoMarketSearch
- คลาสในโค้ด: `Seekerius` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่มพลังของแบ็คสแทบแบบถาวร
> นอกจากนี้ถ้าใช้แบ็คสแทบสำเร็จ
> เมื่อได้รับความเสียหายจากATKและอาวุธเจาะเข้าที่อัพเกรดขึ้นเล็กน้อย
> จะทำให้บรรเทาลงและการอัพเกรดจะสิ้นสุด

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, พาสซีฟ
- บัพ `SeekeriusBuf` ระยะเวลา 30 วินาที: ATK + (`AtkUp`) = 10×Lv → 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10) · เจาะกายภาพ (`PowerResistBreaker`) = 15 + Lv → 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 (Lv1…10) · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `int(100 × rate)` · ตัวคูณดาเมจที่ได้รับจากมอน (หมวดบัพ) (`MobLastDamageRateBuf`) = `int((Lv + 10) × rate)`
- พาสซีฟ ดาเมจสุดท้าย % (`LastDmgRate`): 15, 30, 45, 60, 75, 90, 105, 120, 135, 150 (Lv1…10)

### ชาโดว์วอล์ค (ShadowWalk) · uid 1000

<img src="../../icons/sk_1000.png" width="40" alt="icon">

- ทรี: สกิลนักฆ่า (ขั้น 4) · เลเวลสูงสุด: 205 · อาวุธ: มีด, NinjutsuScroll · ต้องเรียนก่อน: ละทิ้ง · ธง: NoMarketSearch
- คลาสในโค้ด: `ShadowWalkAction` · สถานะการแกะ: แกะครบจากโค้ด

> ถ้าตัวเองไม่ได้ถูกเล็งเป็นเป้าหมายในระยะเวลาสั้นๆ
> ผลการโจมตีเพิ่มจะเปลี่ยนตาม Avoid (ระยะยิงขึ้นอยู่กับอาวุธ)
> การโจมตีเพิ่มจะถูกอัพเกรดด้วยการกระทำที่เจาะจงแต่ถ้าได้รับ
> ความเสียหายขณะถูกเล็งการอัพเกรดจะถูกรีเซ็ตและไม่สามารถใช้งานได้อีก

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `ShadowWalkBuf`: บัพนับสแตก (สืบจาก `CountBufferBase`): ตัวนับ `Count` เริ่ม 0 เพิ่มทีละ 1 ด้วย `Next()` และสูงสุด (Lv + 10); โค้ดอื่นอ่านจำนวนสแตกผ่านพารามิเตอร์ `Count` (ดูค่าที่ใช้จริงในสูตรของสกิลที่อ้างถึง)
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = (Lv + 10) ตามที่ `ShadowWalkBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.ReceiveDamaged` — MobaPlayerActionManager.ReceiveDamaged (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv18: [จะได้รับผลแบบเดียวกันเมื่อใช้คัมภีร์นินจูตสึ] จะอัพเกรดเพิ่มการโจมตีเมื่อใช้ Avoid, แอสแซสซินสแทบ แบ็คสเต็ป (เฉพาะที่สำเร็จ)  ถ้าค่าอัพเกรดตั้งแต่ 10 ขึ้นไป เมื่อได้รับความเสียหายระหว่าง Avoid จะใช้ค่าอัพเกรดเพื่ออัพเกรดเพิ่มการโจมตีให้มากขึ้นอีก

### เดธรีเซฟชัน (DeathReception) · uid 1004

<img src="../../icons/sk_1004.png" width="40" alt="icon">

- ทรี: สกิลนักฆ่า (ขั้น 4) · เลเวลสูงสุด: 205 · อาวุธ: มีด, NinjutsuScroll, MainHand · ต้องเรียนก่อน: เวนอมสแนทช · ธง: NoMarketSearch
- คลาสในโค้ด: `DeathReceptionAction` · สถานะการแกะ: แกะครบจากโค้ด

> ใช้พิษที่ช่วงชิงมาด้วยเวนอมสแนทชจะสร้าง
> ความเสียหายและดีบัฟพิษร้ายแก่เป้าหมาย
> นอกจากนี้จะสร้างความเสียหายเพิ่มเติม
> ก่อให้เกิดพิษต่อพื้นที่โดยรอบขึ้นอยู่กับพิษที่ใช้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: พิษ (Poison)
- ตัวอ่านสกิลนี้ `FuneVinteAction.ActionPreparation` — FuneVinteAction: ขั้นเตรียมก่อนปล่อยสกิล: [set] `targetDeadlyPoison` = `(MobBuffManager.Contains(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.GameObject…` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND SkillMana… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `VenomSnatchAction.BattleResult` — VenomSnatchAction.BattleResult: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new VenomSnatchBuf, 0` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.VenomSnatch, 1) ge 1 AND SkillManager.GetSkillLv(P… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv10: *พลังเพิ่มตามค่า DEX ของตัวเอง *อาวุธเจาะเข้า+25%
- Lv254: *พลังเพิ่มตามเลเวลของตัวเอง *อาวุธเจาะเข้า+25%

<!-- calc:begin uid=1004 -->
#### การคำนวณแบบตัวเลข — DeathReception (uid 1004)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) · ส่วน single (`single…`), ระยะ (`range…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **30×Lv** → 30, 60, 90, 120, 150, 180, 210, 240, 270, 300 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`poisonLevel = 1` หรือ `poisonLevel = 2` และ `poisonLevel ≠ 1` หรือ `poisonLevel ≠ 1` และ `poisonLevel ≠ 2`]: **0** → 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบมือเดียว และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 18` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 23`]: `((((((Lv * 25) + 250) + DEXรวม) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500))) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Dex` = DEX สุดท้าย; `EquipItemData.get_SubWeapon` = ค่า Sub Weapon ของ EquipItemData; `PlayerStatusBase.get_EquipItemData` = ค่า Equip Item Data ของ PlayerStatusBase (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบมือเดียว และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 23`]: `((((((Lv * 25) + 250) + DEXรวม) + (int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function * 0.8)) lt 500 ? int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function * 0.8)) : 500))) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Dex` = DEX สุดท้าย; `EquipItemData.get_SubWeapon` = ค่า Sub Weapon ของ EquipItemData; `PlayerStatusBase.get_EquipItemData` = ค่า Equip Item Data ของ PlayerStatusBase (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ ทวน/มือเปล่า/ดาบมือเดียว) และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 18` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 23`]: `(((((Lv * 25) + 250) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500))) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `EquipItemData.get_SubWeapon` = ค่า Sub Weapon ของ EquipItemData; `PlayerStatusBase.get_EquipItemData` = ค่า Equip Item Data ของ PlayerStatusBase (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบมือเดียว และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 18` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 23` และ `poisonLevel = 1` หรือ อาวุธหลัก ดาบมือเดียว และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 18` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 23` และ `poisonLevel = 2` และ … หรือ อาวุธหลัก ดาบมือเดียว และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 18` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 23` และ `poisonLevel ≠ 1` และ …]: `(((((((Lv * 25) + 250) + DEXรวม) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500)) * 0.5)) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Dex` = DEX สุดท้าย; `EquipItemData.get_SubWeapon` = ค่า Sub Weapon ของ EquipItemData; `PlayerStatusBase.get_EquipItemData` = ค่า Equip Item Data ของ PlayerStatusBase (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบมือเดียว และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 23` และ `poisonLevel = 1` หรือ อาวุธหลัก ดาบมือเดียว และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 23` และ `poisonLevel = 2` และ `poisonLevel ≠ 1` หรือ อาวุธหลัก ดาบมือเดียว และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 23` และ `poisonLevel ≠ 1` และ `poisonLevel ≠ 2`]: `(((((((Lv * 25) + 250) + DEXรวม) + (int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function * 0.8)) lt 500 ? int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function * 0.8)) : 500)) * 0.5)) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Dex` = DEX สุดท้าย; `EquipItemData.get_SubWeapon` = ค่า Sub Weapon ของ EquipItemData; `PlayerStatusBase.get_EquipItemData` = ค่า Equip Item Data ของ PlayerStatusBase (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ ทวน/มือเปล่า/ดาบมือเดียว) และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 18` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 23` และ `poisonLevel = 1` หรือ อาวุธหลักอื่น (ไม่ใช่ ทวน/มือเปล่า/ดาบมือเดียว) และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 18` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 23` และ `poisonLevel = 2` และ … หรือ อาวุธหลักอื่น (ไม่ใช่ ทวน/มือเปล่า/ดาบมือเดียว) และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 18` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 23` และ `poisonLevel ≠ 1` และ …]: `((((((Lv * 25) + 250) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500)) * 0.5)) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `EquipItemData.get_SubWeapon` = ค่า Sub Weapon ของ EquipItemData; `PlayerStatusBase.get_EquipItemData` = ค่า Equip Item Data ของ PlayerStatusBase (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบมือเดียว และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 18` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 23` · DEX รวม=100]: **(350 + 25×Lv)%** → 375%, 400%, 425%, 450%, 475%, 500%, 525%, 550%, 575%, 600% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบมือเดียว และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 18` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 23` · DEX รวม=255]: **(505 + 25×Lv)%** → 530%, 555%, 580%, 605%, 630%, 655%, 680%, 705%, 730%, 755% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบมือเดียว และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 18` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 23` และ `poisonLevel = 1` หรือ อาวุธหลัก ดาบมือเดียว และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 18` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 23` และ `poisonLevel = 2` และ … หรือ อาวุธหลัก ดาบมือเดียว และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 18` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 23` และ `poisonLevel ≠ 1` และ … · DEX รวม=100]: **(175 + 12.5×Lv)%** → 187.5%, 200%, 212.5%, 225%, 237.5%, 250%, 262.5%, 275%, 287.5%, 300% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก ดาบมือเดียว และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 18` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 23` และ `poisonLevel = 1` หรือ อาวุธหลัก ดาบมือเดียว และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 18` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 23` และ `poisonLevel = 2` และ … หรือ อาวุธหลัก ดาบมือเดียว และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 18` และ `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 23` และ `poisonLevel ≠ 1` และ … · DEX รวม=255]: **(252.5 + 12.5×Lv)%** → 265%, 277.5%, 290%, 302.5%, 315%, 327.5%, 340%, 352.5%, 365%, 377.5% (Lv1…10)

**ใช้ร่วมทุกฮิตของ ฮิตรีแอ็กชัน (`HitReactionAssign`)**
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical)` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobBuffer.GuardUpBuff.get_GuardUpval` = ค่า Guard Upval ของ GuardUpBuff; `TryGetBuff.buff` = TryGetBuff.buff; `MobActionManagerBase.get_BuffManager` = ค่า Buff Manager ของ MobActionManagerBase (ดูแท็บ Variables)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) = 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: **25** → 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 (Lv1…10)
<!-- calc:end -->

### เคล็ดลับลอบสังหาร (AssassinationSecrets) · uid 1005

<img src="../../icons/sk_1005.png" width="40" alt="icon">

- ทรี: สกิลนักฆ่า (ขั้น 5) · เลเวลสูงสุด: 285 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ฟูเนวินเด · ธง: NoMarketSearch
- คลาสในโค้ด: `AssassinationSecrets` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่มความเข้าใจในทักษะการลอบสังหาร
> เพิ่มพลังของสกิล[แอสแซสซินสแทบ]และสกิล[ฟิวเนวินเต้]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- ตัวอ่านสกิลนี้ `AssassinStubAction.ActionPreparation` — AssassinStubAction: ขั้นเตรียมก่อนปล่อยสกิล: [set] `skillRate` = `_t22` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.AssassinationSecrets, 1) ge 1 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `FuneVinteAction.ActionPreparation` — FuneVinteAction: ขั้นเตรียมก่อนปล่อยสกิล (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv18: [จะได้รับผลแบบเดียวกันเมื่อใช้คัมภีร์นินจูตสึ] *พลังของแอสแซสซินสแทบจะเพิ่มขึ้นอีก

### แอสเซาท์เชส (AssaultChase) · uid 1006

<img src="../../icons/sk_1006.png" width="40" alt="icon">

- ทรี: สกิลนักฆ่า (ขั้น 5) · เลเวลสูงสุด: 285 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ชาโดว์วอล์ค · ธง: NoMarketSearch
- คลาสในโค้ด: `AssaultChaseAction` · สถานะการแกะ: แกะครบจากโค้ด

> เมื่อได้รับผลของบัฟใหม่จะฟื้นฟูAvoid 50%
> ลดปริมาณการใช้Avoidที่มุ่งไปยัง(หรือรอบๆ)เป้าหมาย
> ที่โจมตีเป็นเวลา 180 วินาที
> เมื่อจำนวนAvoidที่เหลืออยู่เป็น 0 ผลของบัฟจะสิ้นสุดลงเช่นกัน

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `AssaultChaseBuf` ระยะเวลา 180 วินาที [`EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 18` หรือ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) = 23` และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 18` หรือ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 18` และ `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ≠ 23`]: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = 2500 + 250×Lv → 2750, 3000, 3250, 3500, 3750, 4000, 4250, 4500, 4750, 5000 (Lv1…10) · ดาเมจระยะใกล้ % (`ShortRangeRate`) = `shortRangeRate` (ตัวนับที่เปลี่ยนตามเหตุการณ์)
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `AssaultChaseAction.CheckAssaultChase` — ตรวจ assault chase (AssaultChaseAction): คืนค่า `0` (2 กรณี) (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv255: เมื่อหลบหลีกด้วย Avoid ได้สำเร็จในขณะที่ บัฟทำงานอยู่จะเพิ่มผลทำให้พลังโจมตีระยะใกล้เพิ่มขึ้น  เพิ่มผล Avoid ในท่าเปิดใช้งานของ แอสเซาท์เชสเฉพาะสกิลเลเวล 10 เท่านั้น
- Lv18: [จะได้รับผลแบบเดียวกันเมื่อใช้คัมภีร์นินจูตสึ] *ลดการใช้ของ Avoid ลงอีก *เพิ่มจำนวนพลังโจมตีระยะใกล้เมื่อ Avoid สำเร็จ (ขีดจำกัดสูงสุดยังคงไม่เปลี่ยนแปลง)

### นักปรุงยาพิษ (PoisonMixer) · uid 1007

<img src="../../icons/sk_1007.png" width="40" alt="icon">

- ทรี: สกิลนักฆ่า (ขั้น 5) · เลเวลสูงสุด: 285 · อาวุธ: มีด, NinjutsuScroll, MainHand · ต้องเรียนก่อน: เดธรีเซฟชัน · ธง: NoMarketSearch
- คลาสในโค้ด: `PoisonMixer` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่มระยะเวลาภาวะผิดปกติของ[พิษ]
> และพลังของสกิล[เดธรีเซฟชัน]
> มีโอกาสทำให้ติดพิษจากความเสียหายที่เกิดจากพิษร้าย
> เพิ่ม(การพึ่งพาเวนอมอินเจค) 

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- ตัวอ่านสกิลนี้ `DeathReceptionAction.ActionPreparation` — DeathReceptionAction: ขั้นเตรียมก่อนปล่อยสกิล: [set] `singleSkillRate` = `(singleSkillRate + PoisonMixer.GetDeathReceptionSingleAttackSkillRate(SkillManager.GetSki…` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND SkillMana…; [set] `rangeSkillRate` = `(rangeSkillRate + PoisonMixer.GetDeathReceptionRangeAttackSkillRate(SkillManager.GetSkill…` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND SkillMana… (นิยามเต็มในแท็บ Variables)

