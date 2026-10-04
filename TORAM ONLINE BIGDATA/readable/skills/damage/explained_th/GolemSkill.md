# สกิลโกเล็ม (`GolemSkill`) — คำอธิบายทีละสกิล (ภาษาไทย)

สร้างอัตโนมัติด้วย `scripts/render_explained_th.py` จาก `skill_reference.json` (ข้อมูลโค้ด client ชุดล่าสุด) ไม่มีข้อความเขียนมือ แก้ไฟล์นี้ตรง ๆ จะถูกเขียนทับ ตัวเลขทั้งหมดคำนวณจากโค้ด (Code) ความหมายของชื่อ field/บทบาทแปลจากชื่อในโค้ด (Inferred) ยังไม่ได้เทียบกับตัวเลขในเกม ข้อมูลดิบทุกเส้นทางอยู่ใน `../details/GolemSkill.md`

---

<!-- calc:preface -->
> **วิธีอ่านหัวข้อ "การคำนวณแบบตัวเลข"** (สร้างอัตโนมัติด้วย `scripts/render_calc_th.py` จาก `skill_reference.json` แก้มือจะถูกเขียนทับ)
> ดาเมจต่อฮิตเดินตามขั้น `SkillCalcTemplate/CalcStep` 0→40 ตามลำดับ (Code: `SkillCalcTemplate.GetDamage`) ขั้น `+` บวกเข้าดาเมจ ขั้น `×` คูณแล้วปัดเศษทิ้ง (int) ทันทีทุกขั้น
> ลำดับหลัก: ดาเมจฐาน(7) + คงที่สกิล(8) + คงที่บัพ(9) − ป้องกันเป้า(10) + ตีแรก(11) → ×คริ(13) → ×ธาตุ(15) → ×ตัวคูณสกิล(18) → ×ตีแรก(19) → ×เสถียร(21) → +คงที่ออโต้(22) → ×Proration(23) → ×ประเภท(24) → ×ดาเมจสุดท้าย(25) → … → เพดาน/ขั้นต่ำ(35–37)
> "ฮิต N" = template ดาเมจแต่ละก้อน (ทอยคริแยกกัน) แยกตามเมธอดและตัวแปรฮิตในโค้ด (`type`, `isFirst`, `attackCount` …) ชื่อฮิต/ส่วนมาจากชื่อในโค้ด (Inferred) ตัวเลขคำนวณจากโค้ด (Code) โดยตั้งเจม/บัพเสริม = 0
> ค่าหลายก้อนในขั้นเดียวกันแบบ "บวกเข้าช่อง" จะบวกกันก่อนคูณ ส่วน "ตั้งค่าทับ" แทนที่ค่าเดิม ค่าที่ขึ้นกับสเตตัสแสดงเป็นตัวอย่างที่ 100 / 255 (และ Lv สกิลอื่น 1 / 10) ใช้สูตรที่แนบไว้คำนวณค่าอื่นเอง
<!-- calc:preface-end -->

### อัญเชิญโกเล็ม (CallGolem) · uid 577

<img src="../../icons/sk_577.png" width="40" alt="icon">

- ทรี: สกิลโกเล็ม (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: โบว์กัน, ไม้เท้า, MainMagictool · ธง: NoMarketSearch
- คลาสในโค้ด: `CallGolemAction` · สถานะการแกะ: แกะครบจากโค้ด

> อัญเชิญโกเล็มมาร่วมต่อสู้
> 
> สูญเสียฟื้นฟู MP การโจมตีของคุณ
> แต่ได้ฟื้นฟู MP จากการโจมตีปกติมาแทน
> เลือกประเภทของโกเล็มและปรับแต่งหลอดพลังด้วย EX สกิล

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, วางวัตถุ/กับดัก/อัญเชิญ
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `CallGolemBuf` ระยะเวลา `8 × (A & 255) + 2 × A + ([TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577)+0x10] = 1 ? B : 0.5 × B) + 10` วินาที [`TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577) ≠ 0`] / `8 × (A & 255) + 2 × A + 10` วินาที [`TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577) ≠ 0`] / 10 วินาที [`TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577) = 0`]: ตัวคูณดาเมจที่ได้รับจากมอน (หมวดบัพ) (`MobLastDamageRateBuf`) = `ExSkillCallGolem.GetPoint(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577), lv, 1) + 10` · ความเร็วโจมตี % (`AspdRate`) = `16 × (A & 255) - A + 0xffffffe7` · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `[TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577)+0x10]`
- ตัวอ่านสกิลนี้ `CallGolemAction.EnchantEnd` — CallGolemAction.EnchantEnd (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `CallGolemActionManager.BattleReservation` — CallGolemActionManager.BattleReservation (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `CallGolemActionManager.CalcMoveSpeed` — คำนวณ move speed (CallGolemActionManager) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `CallGolemBuf.GetDamageResistRate` — CallGolemBuf.GetDamageResistRate: คืนค่า `0` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `CallGolemNormalAttackAction.OnInitialize` — CallGolemNormalAttackAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `golemType` = `SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), Ski…` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.CallGolem, out) & 1) ne 0 AND TryGetBu…; [set] `isBoost` = `1` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.CallGolem, out) & 1) ne 0 AND TryGetBu…; [set] `addHit` = `(SkillMasteryBase.GetMasteryParam(MasteryId.Hit) + addHit)` เมื่อ (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.CallGolem, out) & 1) ne 0 AND TryGetBu… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GameManager.PlayerSkillUpdate` — GameManager.PlayerSkillUpdate (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GameManager.ReceiveSummons` — GameManager.ReceiveSummons (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MainPlayer.PlayerDead` — MainPlayer.PlayerDead: [call] `SkillBufferManager$$RemoveBuffer` = `SkillBufferManager, SkillId.CallGolem` เมื่อ (AutoMemberManager.TryGetAutoMember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 16, Toram.Common.Archet… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerSecondaryStatus.get_AtkMpRecovery` — ค่า Atk Mp Recovery ของ MobaPlayerSecondaryStatus: คืนค่า `0` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.get_AtkMpRecovery` — ค่า Atk Mp Recovery ของ PlayerSecondaryStatus: คืนค่า `0` (2 กรณี) (นิยามเต็มในแท็บ Variables)

### ระเบิดเวทมนตร์ (MagicGrenade) · uid 584

<img src="../../icons/sk_584.png" width="40" alt="icon">

- ทรี: สกิลโกเล็ม (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: โบว์กัน, โล่, MainHand · ธง: NoMarketSearch
- คลาสในโค้ด: `MagicGrenadeAction` · สถานะการแกะ: แกะครบจากโค้ด

> ทำให้พลังเวทของหลอดพลังเกินขีดจำกัดแล้วใช้เป็นระเบิด
> 
> โจมตีเป็นวงกว้างแต่จะไม่ถึง
> หากเป้าหมายอยู่ไกลเกินไป
> พลังโจมตีจะเพิ่มขึ้นอีกตามค่า INT หรือ TEC

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · ไม่เปลี่ยนค่า proration
- ตัวอ่านสกิลนี้ `FlashGrenadeAction.OnInitialize` — FlashGrenadeAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `<LoopParam>k__BackingField` = `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.MagicGrenade, 1)` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `FreezeGrenadeAction.OnInitialize` — FreezeGrenadeAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `<LoopParam>k__BackingField` = `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.MagicGrenade, 1)` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GolemGrenadeSkillBase.GetMagicGrenadeParameter` — GolemGrenadeSkillBase.GetMagicGrenadeParameter: [call] `GolemGrenadeSkillBase$$CalcSkillRate` = `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.MagicGrenade, 1), Sk…` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.MagicGrenade, 1) gt 0 (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=584 -->
#### การคำนวณแบบตัวเลข — MagicGrenade (uid 584)
Proration: ช่อง `Magic` โหมด `never (IsExpDefFluctuate=false)`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `constantDamage` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `skillRate / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `OnInitialize`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
<!-- calc:end -->

### แลนเซอร์พลัส (LancerTypeImproved) · uid 578

<img src="../../icons/sk_578.png" width="40" alt="icon">

- ทรี: สกิลโกเล็ม (ขั้น 2) · เลเวลสูงสุด: 200 · อาวุธ: โบว์กัน, ไม้เท้า, MainMagictool · ต้องเรียนก่อน: อัญเชิญโกเล็ม · ธง: NoMarketSearch
- คลาสในโค้ด: `LancerTypeImproved` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่มประสิทธิภาพของโกเล็มประเภทแลนเซอร์
> 
> พลังเจาะเข้าและอัตราคริติคอลของโกเล็มจะเพิ่มขึ้น
> สำหรับประเภทชีลด์และบัสเตอร์ก็จะเพิ่มขึ้นเพียงเล็กน้อย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ เจาะกายภาพ (`PowerResistBreaker`): 12, 19, 26, 33, 40, 47, 54, 61, 68, 75 (Lv1…10)
- พาสซีฟ อัตราคริ (`Crt`): 7, 15, 22, 30, 37, 45, 52, 60, 67, 75 (Lv1…10)

### ชีลด์พลัส (ShieldTypeImproved) · uid 579

<img src="../../icons/sk_579.png" width="40" alt="icon">

- ทรี: สกิลโกเล็ม (ขั้น 2) · เลเวลสูงสุด: 200 · อาวุธ: โบว์กัน, ไม้เท้า, MainMagictool · ต้องเรียนก่อน: อัญเชิญโกเล็ม · ธง: NoMarketSearch
- คลาสในโค้ด: `ShieldTypeImproved` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่มประสิทธิภาพของโกเล็มประเภทชีลด์
> 
> ระยะเวลาคงอยู่และระยะการลดความเสียหายของโกเล็มจะเพิ่มขึ้น
> สำหรับประเภทแลนเซอร์และบัสเตอร์ก็จะเพิ่มขึ้นเพียงเล็กน้อย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ เพิ่มเวลาจำกัด (`LimitTimeUp`): 8, 16, 24, 32, 40, 48, 56, 64, 72, 80 (Lv1…10)
- พาสซีฟ ค่าทั่วไป (`Value`): 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 (Lv1…10)

### บัสเตอร์พลัส (BusterTypeImproved) · uid 580

<img src="../../icons/sk_580.png" width="40" alt="icon">

- ทรี: สกิลโกเล็ม (ขั้น 2) · เลเวลสูงสุด: 200 · อาวุธ: โบว์กัน, ไม้เท้า, MainMagictool · ต้องเรียนก่อน: อัญเชิญโกเล็ม · ธง: NoMarketSearch
- คลาสในโค้ด: `BusterTypeImproved` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่มประสิทธิภาพของโกเล็มประเภทบัสเตอร์
> 
> พลังเจาะเข้าและอัตราคริติคอลของโกเล็มจะเพิ่มขึ้น
> สำหรับประเภทแลนเซอร์และชีลด์จะเพิ่มขึ้นเพียงเล็กน้อย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ เจาะกายภาพ (`PowerResistBreaker`): 12, 19, 26, 33, 40, 47, 54, 61, 68, 75 (Lv1…10)
- พาสซีฟ อัตราคริ (`Crt`): 7, 15, 22, 30, 37, 45, 52, 60, 67, 75 (Lv1…10)

### ระเบิดเยือกแข็ง (FreezeGrenade) · uid 585

<img src="../../icons/sk_585.png" width="40" alt="icon">

- ทรี: สกิลโกเล็ม (ขั้น 2) · เลเวลสูงสุด: 200 · อาวุธ: โบว์กัน, โล่, MainHand · ต้องเรียนก่อน: ระเบิดเวทมนตร์ · ธง: NoMarketSearch
- คลาสในโค้ด: `FreezeGrenadeAction` · สถานะการแกะ: แกะครบจากโค้ด

> เติมพลังเวทเยือกแข็งลงในหลอดพลัง
> 
> พลังโจมตีขึ้นอยู่กับระเบิดเวทมนตร์ที่เรียนรู้มา
> มีโอกาสติด "แช่แข็ง" แต่
> หากโดนระเบิดตัวเองก็มีโอกาสเล็กน้อยที่จะถูกแช่แข็งไปด้วย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · ไม่เปลี่ยนค่า proration
- สถานะที่ทำให้ติด: แช่แข็ง (Freeze)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv17: เมื่อติดตั้งโล่จะต้านทานแช่แข็งได้ด้วยการต้านภาวะผิดปกติของคุณเอง
- Lv254: [ผลลัพธ์ต่อไปนี้ใช้ได้เมื่อติดตั้งเป็นอุปกรณ์หลักเท่านั้น] ขณะสกิลชี่กงฟื้นฟูทำงานจะต้านทานแช่แข็ง ได้ด้วยการต้านภาวะผิดปกติของคุณเอง

<!-- calc:begin uid=585 -->
#### การคำนวณแบบตัวเลข — FreezeGrenade (uid 585)
Proration: ช่อง `Magic` โหมด `never (IsExpDefFluctuate=false)`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `constantDamage` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `skillRate / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `OnInitialize`): `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 584, 1)`
<!-- calc:end -->

### บาเรียสกรีน (BarrierScreen) · uid 587

<img src="../../icons/sk_587.png" width="40" alt="icon">

- ทรี: สกิลโกเล็ม (ขั้น 2) · เลเวลสูงสุด: 200 · อาวุธ: โบว์กัน, โล่ · ต้องเรียนก่อน: ระเบิดเวทมนตร์ · ธง: NoMarketSearch
- คลาสในโค้ด: `BarrierScreenAction` · สถานะการแกะ: แกะครบจากโค้ด

> ติดตั้งโดรนกางเมจิกบาเรีย
> ช่วยลดความรุนแรงของการโจมตีแนวตรง, กระสุน
> ของมีคมประเภทซัดที่ผ่านบาเรียได้หนึ่งครั้ง
> *มีการโจมตีบางประเภทที่ไม่สามารถลดความเสียหายได้
> ระหว่างติดตั้งการฟื้นฟู MP การโจมตีจะลดลง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, วางวัตถุ/กับดัก/อัญเชิญ
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `BarrierScreenBuf`: MP ฟื้นต่อการโจมตี % (`AttackMprecoveryUpRate`) = `int(2.5 × (modifyLevel & 255)) - 50` · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `int(time)` (ตัวนับที่เปลี่ยนตามเหตุการณ์)
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่

### เสริมพลังโจมตี (AttackPerformanceImprovement) · uid 581

<img src="../../icons/sk_581.png" width="40" alt="icon">

- ทรี: สกิลโกเล็ม (ขั้น 3) · เลเวลสูงสุด: 250 · อาวุธ: โบว์กัน, ไม้เท้า, MainMagictool · ต้องเรียนก่อน: แลนเซอร์พลัส · ธง: NoMarketSearch
- คลาสในโค้ด: `AttackPerformanceImprovement` · สถานะการแกะ: แกะครบจากโค้ด

> ปรับปรุงหลอดพลังเพื่อเพิ่มประสิทธิภาพการโจมตี
> 
> ค่าพลังที่แบ่งไปที่การโจมตีจะเพิ่มขึ้น
> และค่าความแม่นจะเพิ่มขึ้นตลอดเวลา
> โดยไม่ขึ้นอยู่กับการแบ่งพลัง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ค่าทั่วไป (`Value`): 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 (Lv1…10)
- พาสซีฟ ความแม่น (`Hit`): 2, 8, 18, 32, 50, 72, 98, 128, 162, 200 (Lv1…10)
- ตัวอ่านสกิลนี้ `CallGolemNormalAttackAction.OnInitialize` — CallGolemNormalAttackAction: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...): [set] `skillRate` = `((max((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.AttackPerform…` เมื่อ isBoost ne 0 AND _t125 ne 2 AND _t125 ne 1 AND _t125 eq 0; [set] `skillRate` = `(((max((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.AttackPerfor…` เมื่อ isBoost ne 0 AND _t125 eq 2; [set] `skillRate` = `((max((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.AttackPerform…` เมื่อ isBoost ne 0 AND _t125 ne 2 AND _t125 eq 1 (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv13: [สามารถใช้ผลแบบเดียวกันทั้งกับไม้เท้าและอุปกรณ์เวทมนตร์] หากใช้งานสกิล[อัญเชิญโกเล็ม]ซ้ำในขณะที่เรียกโกเล็มออกมาอยู่ จะติดบัฟเพิ่มพลังโจมตีให้โกเล็มได้ 1 ครั้ง

### เสริมพลังป้องกัน (ShieldPerformanceImprovement) · uid 582

<img src="../../icons/sk_582.png" width="40" alt="icon">

- ทรี: สกิลโกเล็ม (ขั้น 3) · เลเวลสูงสุด: 250 · อาวุธ: โบว์กัน, ไม้เท้า, MainMagictool · ต้องเรียนก่อน: ชีลด์พลัส · ธง: NoMarketSearch
- คลาสในโค้ด: `ShieldPerformanceImprovement` · สถานะการแกะ: แกะครบจากโค้ด

> ปรับปรุงหลอดพลังเพื่อเพิ่มประสิทธิภาพโล่
> 
> ค่าพลังที่แบ่งไปที่โล่จะเพิ่มขึ้น
> และระยะลดความเสียหายจะเพิ่มขึ้นตลอดเวลา
> โดยไม่ขึ้นอยู่กับการแบ่งพลัง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ดาเมจสุดท้ายที่ได้รับจากมอน (`MobAttackLastDamageRate`): 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 (Lv1…10)
- พาสซีฟ ค่าทั่วไป (`Value`): 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 (Lv1…10)

### เสริมความเร็ว (SpeedPerformanceImprovement) · uid 583

<img src="../../icons/sk_583.png" width="40" alt="icon">

- ทรี: สกิลโกเล็ม (ขั้น 3) · เลเวลสูงสุด: 250 · อาวุธ: โบว์กัน, ไม้เท้า, MainMagictool · ต้องเรียนก่อน: บัสเตอร์พลัส · ธง: NoMarketSearch
- คลาสในโค้ด: `SpeedPerformanceImprovement` · สถานะการแกะ: แกะครบจากโค้ด

> ปรับปรุงหลอดพลังเพื่อเพิ่มประสิทธิภาพความเร็ว
> 
> ค่าพลังที่แบ่งไปที่ความเร็ว
> จะทำให้ความเร็วการเคลื่อนที่เพิ่มขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ความเร็วโจมตี + (`Aspd`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)

### ระเบิดแสง (FlashGrenade) · uid 586

<img src="../../icons/sk_586.png" width="40" alt="icon">

- ทรี: สกิลโกเล็ม (ขั้น 3) · เลเวลสูงสุด: 250 · อาวุธ: โบว์กัน, โล่, MainHand · ต้องเรียนก่อน: ระเบิดเยือกแข็ง · ธง: NoMarketSearch
- คลาสในโค้ด: `FlashGrenadeAction` · สถานะการแกะ: แกะครบจากโค้ด

> เติมพลังเวทแสงลงในหลอดพลัง
> 
> ความเสียหายขึ้นอยู่กับระเบิดเวทมนตร์ที่เรียนรู้มา
> มีโอกาสติด "ตาพร่า แต่
> หากโดนระเบิดตัวเองก็มีโอกาสเล็กน้อยที่จะตาพร่าไปด้วย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · ไม่เปลี่ยนค่า proration
- สถานะที่ทำให้ติด: ตาพร่า (Flash)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv17: เมื่อติดตั้งโล่จะต้านทานตาพร่าได้ด้วยการต้านภาวะผิดปกติของคุณเอง
- Lv254: [ผลลัพธ์ต่อไปนี้ใช้ได้เมื่อติดตั้งเป็นอุปกรณ์หลักเท่านั้น] ขณะสกิลชี่กงฟื้นฟูทำงานจะต้านทานตาพร่า ได้ด้วยการต้านภาวะผิดปกติของคุณเอง

<!-- calc:begin uid=586 -->
#### การคำนวณแบบตัวเลข — FlashGrenade (uid 586)
Proration: ช่อง `Magic` โหมด `never (IsExpDefFluctuate=false)`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `constantDamage` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `skillRate / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `OnInitialize`): `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 584, 1)`
<!-- calc:end -->

### เสริมบาเรีย (BarrierScreenPerformanceImprovement) · uid 588

<img src="../../icons/sk_588.png" width="40" alt="icon">

- ทรี: สกิลโกเล็ม (ขั้น 3) · เลเวลสูงสุด: 250 · อาวุธ: โบว์กัน, โล่ · ต้องเรียนก่อน: บาเรียสกรีน · ธง: NoMarketSearch
- ไม่มีคลาสของตัวเอง ผลอยู่ในโค้ดที่อ่านสกิลนี้ (`no action class; effect applied in consumer code (see page)`)

> ปรับปรุงบาเรียโดรน
> 
> เพิ่มอัตราการลดทอนความรุนแรงของบาเรียให้สูงขึ้น
> และลดปริมาณการสูญเสียพลังฟื้นฟู
> MP การโจมตีที่ใช้ในการคงสภาพโดรน

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ, ไม่มีคลาสแอ็กชันฝั่ง client
- ตัวอ่านสกิลนี้ `BarrierScreenAction.ActionSkillEvent` — BarrierScreenAction.ActionSkillEvent (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `BarrierScreenAction.ActionStart` — BarrierScreenAction: ตอนเริ่มทำงานของสกิล: [set] `reduceDamageValue` = `(reduceDamageValue + max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), Ski…` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (UnityEng…; [set] `reduceDamageValue` = `(reduceDamageValue + max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), Ski…` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (UnityEng…; [set] `reduceDamageValue` = `(reduceDamageValue + max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), Ski…` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (UnityEng… (นิยามเต็มในแท็บ Variables)

