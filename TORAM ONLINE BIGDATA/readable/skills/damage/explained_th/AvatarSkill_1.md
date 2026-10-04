# สกิลอีเวนต์/คอลแลบ (`AvatarSkill_1`) — คำอธิบายทีละสกิล (ภาษาไทย)

สร้างอัตโนมัติด้วย `scripts/render_explained_th.py` จาก `skill_reference.json` (ข้อมูลโค้ด client ชุดล่าสุด) ไม่มีข้อความเขียนมือ แก้ไฟล์นี้ตรง ๆ จะถูกเขียนทับ ตัวเลขทั้งหมดคำนวณจากโค้ด (Code) ความหมายของชื่อ field/บทบาทแปลจากชื่อในโค้ด (Inferred) ยังไม่ได้เทียบกับตัวเลขในเกม ข้อมูลดิบทุกเส้นทางอยู่ใน `../details/AvatarSkill_1.md`

---

<!-- calc:preface -->
> **วิธีอ่านหัวข้อ "การคำนวณแบบตัวเลข"** (สร้างอัตโนมัติด้วย `scripts/render_calc_th.py` จาก `skill_reference.json` แก้มือจะถูกเขียนทับ)
> ดาเมจต่อฮิตเดินตามขั้น `SkillCalcTemplate/CalcStep` 0→40 ตามลำดับ (Code: `SkillCalcTemplate.GetDamage`) ขั้น `+` บวกเข้าดาเมจ ขั้น `×` คูณแล้วปัดเศษทิ้ง (int) ทันทีทุกขั้น
> ลำดับหลัก: ดาเมจฐาน(7) + คงที่สกิล(8) + คงที่บัพ(9) − ป้องกันเป้า(10) + ตีแรก(11) → ×คริ(13) → ×ธาตุ(15) → ×ตัวคูณสกิล(18) → ×ตีแรก(19) → ×เสถียร(21) → +คงที่ออโต้(22) → ×Proration(23) → ×ประเภท(24) → ×ดาเมจสุดท้าย(25) → … → เพดาน/ขั้นต่ำ(35–37)
> "ฮิต N" = template ดาเมจแต่ละก้อน (ทอยคริแยกกัน) แยกตามเมธอดและตัวแปรฮิตในโค้ด (`type`, `isFirst`, `attackCount` …) ชื่อฮิต/ส่วนมาจากชื่อในโค้ด (Inferred) ตัวเลขคำนวณจากโค้ด (Code) โดยตั้งเจม/บัพเสริม = 0
> ค่าหลายก้อนในขั้นเดียวกันแบบ "บวกเข้าช่อง" จะบวกกันก่อนคูณ ส่วน "ตั้งค่าทับ" แทนที่ค่าเดิม ค่าที่ขึ้นกับสเตตัสแสดงเป็นตัวอย่างที่ 100 / 255 (และ Lv สกิลอื่น 1 / 10) ใช้สูตรที่แนบไว้คำนวณค่าอื่นเอง
<!-- calc:preface-end -->

### เอ็กซ์โพชั่น (Explosion) · uid 1281

- ทรี: สกิลอีเวนต์/คอลแลบ (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: NoMarketSearch
- คลาสในโค้ด: `ExplosionAction` · สถานะการแกะ: แกะครบจากโค้ด

> สกิลที่ลอกเลียนแบบมาจากเวทเอ็กซ์โพชั่นของเมกุมิน
> จะทำให้เป้าหมายได้รับความเสียหายจากธาตุไฟ
> ยิ่งใช้ MP มากเท่าไหร่พลังปลดปล่อยออกมาก็จะยิ่งสูงขึ้น
> เมื่อใช้งานจะทำให้ตัวผู้ใช้หมดสติ
> ไม่สามารถตั้งค่าในคอมโบได้
> ระหว่างอีเว้นท์ พลังการโจมตีและขอบเขตการใช้จะเพิ่มขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- MP ที่ใช้: `System.Math.Max(PlayerAttackBase.CalcCostMp(this, actarAction), 100)`
- MP ที่ใช้: `System.Math.Max(PlayerAttackBase.CalcCostMp(this, playerAction), 100)`
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

<!-- calc:begin uid=1281 -->
#### การคำนวณแบบตัวเลข — Explosion (uid 1281)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [กิ่งที่ 1 ของ `fixAddDamage`]: **1000** → 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [กิ่งที่ 2 ของ `fixAddDamage`]: **100** → 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate`]: `300 × System.Math.Max(PlayerAttackBase.CalcCostMp(this, actarAction), 100) // 100 / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `skillRate`]: `100 × System.Math.Max(PlayerAttackBase.CalcCostMp(this, actarAction), 100) // 100 / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
<!-- calc:end -->

### ไลท์ออฟเซเบอร์ (LightOfSaber) · uid 1282

- ทรี: สกิลอีเวนต์/คอลแลบ (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: NoMarketSearch
- คลาสในโค้ด: `LightOfSaberAction` · สถานะการแกะ: แกะครบจากโค้ด

> สกิลที่ลอกเลียนแบบมาจากเวทแห่งแสงของยุนยุน
> จะทำให้เป้าหมายได้รับความเสียหายจากธาตุแสง
> ยิ่งคนในปาร์ตี้น้อยเท่าไหร่พลังโจมตีก็จะยิ่งสูงขึ้น
> ไม่สามารถตั้งค่าในคอมโบได้
> ระหว่างอีเว้นท์ พลังการโจมตีและขอบเขตการใช้จะเพิ่มขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

<!-- calc:begin uid=1282 -->
#### การคำนวณแบบตัวเลข — LightOfSaber (uid 1282)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [กิ่งที่ 1 ของ `fixAddDamage`]: **600** → 600, 600, 600, 600, 600, 600, 600, 600, 600, 600 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [กิ่งที่ 2 ของ `fixAddDamage`]: **300** → 300, 300, 300, 300, 300, 300, 300, 300, 300, 300 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **700%** → 700%, 700%, 700%, 700%, 700%, 700%, 700%, 700%, 700%, 700% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `skillRate`]: **350%** → 350%, 350%, 350%, 350%, 350%, 350%, 350%, 350%, 350%, 350% (Lv1…10)
<!-- calc:end -->

### Morning Star (MorningStar) · uid 1283

<img src="../../icons/sk_1283.png" width="40" alt="icon">

- ทรี: สกิลอีเวนต์/คอลแลบ (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: MercenaryCanUseSkill
- คลาสในโค้ด: `MorningStarAction` · สถานะการแกะ: แกะครบจากโค้ด

> สกิลที่ทำเลียนแบบ Morning Star ของ Rem
> รูปแบบการใช้จะเปลี่ยนแปลงตามสถานะ
> ของคาแรคเตอร์เวลาใช้สกิล
> ไม่สามารถนำไปตั้งเป็นคอมโบได้
> ระหว่าง COLLABORATION พลังโจมตีจะเพิ่มขึ้นเป็นอย่างมาก!!
> Re:Zero -Starting Life in Another World-

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 6 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `MorningStarBuf`: ตัวคูณดาเมจที่ได้รับจากมอน (หมวดบัพ) (`MobLastDamageRateBuf`) = `isEvent & 1 ≠ 0 ? Lv + 20 : Lv`
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่

<!-- calc:begin uid=1283 -->
#### การคำนวณแบบตัวเลข — MorningStar (uid 1283)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`1 eq (attackDirection eq 1 ? 2 : 1)` หรือ `1 ne (attackDirection eq 1 ? 2 : 1)` และ `2 eq (attackDirection eq 1 ? 2 : 1)` หรือ `1 ne (attackDirection eq 1 ? 2 : 1)` และ `2 ne (attackDirection eq 1 ? 2 : 1)` และ `3 eq (attackDirection eq 1 ? 2 : 1)`]: **100** → 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`1 eq (attackDirection eq 1 ? 2 : 1)` หรือ `1 ne (attackDirection eq 1 ? 2 : 1)` และ `2 eq (attackDirection eq 1 ? 2 : 1)` หรือ `1 ne (attackDirection eq 1 ? 2 : 1)` และ `2 ne (attackDirection eq 1 ? 2 : 1)` และ `3 eq (attackDirection eq 1 ? 2 : 1)` · กิ่งที่ 1 ของ `skillRate`]: `(30 × Lv + Lvรวม ÷ 4 + 300) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Lv` = เลเวลตัวละคร; `status.Lv` = เลเวลตัวละคร; `status.Lv` = เลเวลตัวละคร (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`1 eq (attackDirection eq 1 ? 2 : 1)` หรือ `1 ne (attackDirection eq 1 ? 2 : 1)` และ `2 eq (attackDirection eq 1 ? 2 : 1)` หรือ `1 ne (attackDirection eq 1 ? 2 : 1)` และ `2 ne (attackDirection eq 1 ? 2 : 1)` และ `3 eq (attackDirection eq 1 ? 2 : 1)` · กิ่งที่ 2 ของ `skillRate`]: `(30 × Lv + Lvรวม ÷ 4) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Lv` = เลเวลตัวละคร; `status.Lv` = เลเวลตัวละคร; `status.Lv` = เลเวลตัวละคร (ดูแท็บ Variables)
<!-- calc:end -->

### 1284 (DivaCheering) · uid 1284

<img src="../../icons/sk_1284.png" width="40" alt="icon">

- ทรี: สกิลอีเวนต์/คอลแลบ (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: NoMarketSearch
- ไม่มีคลาสของตัวเอง ผลอยู่ในโค้ดที่อ่านสกิลนี้ (`no action class; effect applied in consumer code (see page)`)

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, ไม่มีคลาสแอ็กชันฝั่ง client
- บัพ `DivaCheeringBuf` ระยะเวลา 10 วินาที: ความเร็วร่าย + (`CspdUp`) = 750 · ดาเมจสุดท้ายที่ทำ % (`LastDmgUpRate`) = `lastDamageRate` · ความเร็วโจมตี + (`Aspd`) = 750 · MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = 15
- ตัวอ่านสกิลนี้ `NewWaveRoomData.ReceiveMinusHateEvent` — NewWaveRoomData.ReceiveMinusHateEvent: [call] `ChatWindow$$AddSystemMessage` = `[Singleton<UIMainManager>.get_Instance()+0x188], SystemTextManager.Get(RoomDataBase.get_s…` เมื่อ eventData.BufferTargetId.Length ge 1 AND 0 lo eventData.BufferTargetId.Length AND PlayerDataManager.get_PlayerArchetype…; [call] `ChatWindow$$AddSystemMessage` = `[Singleton<UIMainManager>.get_Instance()+0x188], SystemTextManager.Get(RoomDataBase.get_s…` เมื่อ eventData.BufferTargetId.Length ge 1 AND 0 lo eventData.BufferTargetId.Length AND PlayerDataManager.get_PlayerArchetype…; [call] `ChatWindow$$AddSystemMessage` = `[Singleton<UIMainManager>.get_Instance()+0x188], SystemTextManager.Get(RoomDataBase.get_s…` เมื่อ eventData.BufferTargetId.Length ge 1 AND 0 lo eventData.BufferTargetId.Length AND PlayerDataManager.get_PlayerArchetype… (นิยามเต็มในแท็บ Variables)

### ดราก้อนสเลฟ / ดราก้อนสเลฟ (DragSlave) · uid 1285

- ทรี: สกิลอีเวนต์/คอลแลบ (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: NoMarketSearch
- คลาสในโค้ด: `DragSlaveAction` · สถานะการแกะ: แกะครบจากโค้ด

> สกิลที่มีโมเดลมาจากดราก้อนสเลฟ
> สร้างความเสียหายแบบไร้ธาตุกับเป้าหมาย
> พลังจะเพิ่มขึ้นตาม MP ที่ใช้และ MP สูงสุด
> ทุกเป้าหมายที่โดนจะติด[อ่อนแอ]และ[ลดการป้องกัน]
> ใช้กับคอมโบไม่ได้
> พลังจะเพิ่มขึ้นอย่างมากระหว่างโคลาโบ!!

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- MP ที่ใช้: `PlayerAttackBase.CalcCostMp(this, actarAction)`
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `breakPercent`: `min(PlayerAttackBase.CalcCostMp(this, actarAction) // 10, 100)` %
- สถานะที่ทำให้ติด: ล่มสลาย (Collapse), เกราะแตก (Breaking)

<!-- calc:begin uid=1285 -->
#### การคำนวณแบบตัวเลข — DragSlave (uid 1285)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `first = 0`**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`target.Element = 7` หรือ `target.Element ≠ 7`]: `constantDamage` — โดยที่ `constantDamage` = `50 × PlayerAttackBase.get_Mp() // 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- โบนัสธาตุ (`ElementBonusRate`, ×, บวกเข้าช่อง) [`target.Element = 7`]: **0.25** → 0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`target.Element = 7` หรือ `target.Element ≠ 7` · กิ่งที่ 1 ของ `skillRate`]: `((((int(((((PlayerSecondaryStatus.CalcBaseMaxMp(PlayerStatusBase.get_SecondaryStatus()) / 20) * 0.5) * (PlayerAttackBase.CalcCostMp(this, actarAction) / 200)) + (((PlayerSecondaryStatus.CalcBaseMaxMp(PlayerStatusBase.get_SecondaryStatus()) / 20) * (((PlayerAttackBase.CalcCostMp(this, actarAction) / 200) / 20) + 0.5)) * 10))) + int(((((PlayerSecondaryStatus.CalcBaseMaxMp(PlayerStatusBase.get_SecondaryStatus()) / 20) * 0.5) * (PlayerAttackBase.CalcCostMp(this, actarAction) / 200)) + (((PlayerSecondaryStatus.CalcBaseMaxMp(PlayerStatusBase.get_SecondaryStatus()) / 20) * (((PlayerAttackBase.CalcCostMp(this, actarAction) / 200) / 20) + 0.5)) * 10)))) mi 4000 ? (int(((((PlayerSecondaryStatus.CalcBaseMaxMp(PlayerStatusBase.get_SecondaryStatus()) / 20) * 0.5) * (PlayerAttackBase.CalcCostMp(this, actarAction) / 200)) + (((PlayerSecondaryStatus.CalcBaseMaxMp(PlayerStatusBase.get_SecondaryStatus()) / 20) * (((PlayerAttackBase.CalcCostMp(this, actarAction) / 200) / 20) + 0.5)) * 10))) + int(((((PlayerSecondaryStatus.CalcBaseMaxMp(PlayerStatusBase.get_SecondaryStatus()) / 20) * 0.5) * (PlayerAttackBase.CalcCostMp(this, actarAction) / 200)) + (((PlayerSecondaryStatus.CalcBaseMaxMp(PlayerStatusBase.get_SecondaryStatus()) / 20) * (((PlayerAttackBase.CalcCostMp(this, actarAction) / 200) / 20) + 0.5)) * 10)))) : 4000)) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerSecondaryStatus.CalcBaseMaxMp` = คำนวณ base max mp (PlayerSecondaryStatus); `PlayerStatusBase.get_SecondaryStatus` = ค่า Secondary Status ของ PlayerStatusBase (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`target.Element = 7` หรือ `target.Element ≠ 7` · กิ่งที่ 2 ของ `skillRate`]: `(((int(((((PlayerSecondaryStatus.CalcBaseMaxMp(PlayerStatusBase.get_SecondaryStatus()) / 20) * 0.5) * (PlayerAttackBase.CalcCostMp(this, actarAction) / 200)) + (((PlayerSecondaryStatus.CalcBaseMaxMp(PlayerStatusBase.get_SecondaryStatus()) / 20) * (((PlayerAttackBase.CalcCostMp(this, actarAction) / 200) / 20) + 0.5)) * 10))) mi 2000 ? int(((((PlayerSecondaryStatus.CalcBaseMaxMp(PlayerStatusBase.get_SecondaryStatus()) / 20) * 0.5) * (PlayerAttackBase.CalcCostMp(this, actarAction) / 200)) + (((PlayerSecondaryStatus.CalcBaseMaxMp(PlayerStatusBase.get_SecondaryStatus()) / 20) * (((PlayerAttackBase.CalcCostMp(this, actarAction) / 200) / 20) + 0.5)) * 10))) : 2000)) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerSecondaryStatus.CalcBaseMaxMp` = คำนวณ base max mp (PlayerSecondaryStatus); `PlayerStatusBase.get_SecondaryStatus` = ค่า Secondary Status ของ PlayerStatusBase (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`target.Element = 7` หรือ `target.Element ≠ 7`]: `target.ExpDefMagic / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefMagic` = proration ช่อง Magic ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`target.Element = 7` หรือ `target.Element ≠ 7`]: `(targetMagicExpList[MobActionManagerBase.get_gameObject(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_gameObject` = ค่า game Object ของ MobActionManagerBase (ดูแท็บ Variables)
<!-- calc:end -->

