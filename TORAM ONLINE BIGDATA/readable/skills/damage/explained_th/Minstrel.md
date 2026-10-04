# สกิลมินสเตรล (`Minstrel`) — คำอธิบายทีละสกิล (ภาษาไทย)

สร้างอัตโนมัติด้วย `scripts/render_explained_th.py` จาก `skill_reference.json` (ข้อมูลโค้ด client ชุดล่าสุด) ไม่มีข้อความเขียนมือ แก้ไฟล์นี้ตรง ๆ จะถูกเขียนทับ ตัวเลขทั้งหมดคำนวณจากโค้ด (Code) ความหมายของชื่อ field/บทบาทแปลจากชื่อในโค้ด (Inferred) ยังไม่ได้เทียบกับตัวเลขในเกม ข้อมูลดิบทุกเส้นทางอยู่ใน `../details/Minstrel.md`

---

<!-- calc:preface -->
> **วิธีอ่านหัวข้อ "การคำนวณแบบตัวเลข"** (สร้างอัตโนมัติด้วย `scripts/render_calc_th.py` จาก `skill_reference.json` แก้มือจะถูกเขียนทับ)
> ดาเมจต่อฮิตเดินตามขั้น `SkillCalcTemplate/CalcStep` 0→40 ตามลำดับ (Code: `SkillCalcTemplate.GetDamage`) ขั้น `+` บวกเข้าดาเมจ ขั้น `×` คูณแล้วปัดเศษทิ้ง (int) ทันทีทุกขั้น
> ลำดับหลัก: ดาเมจฐาน(7) + คงที่สกิล(8) + คงที่บัพ(9) − ป้องกันเป้า(10) + ตีแรก(11) → ×คริ(13) → ×ธาตุ(15) → ×ตัวคูณสกิล(18) → ×ตีแรก(19) → ×เสถียร(21) → +คงที่ออโต้(22) → ×Proration(23) → ×ประเภท(24) → ×ดาเมจสุดท้าย(25) → … → เพดาน/ขั้นต่ำ(35–37)
> "ฮิต N" = template ดาเมจแต่ละก้อน (ทอยคริแยกกัน) แยกตามเมธอดและตัวแปรฮิตในโค้ด (`type`, `isFirst`, `attackCount` …) ชื่อฮิต/ส่วนมาจากชื่อในโค้ด (Inferred) ตัวเลขคำนวณจากโค้ด (Code) โดยตั้งเจม/บัพเสริม = 0
> ค่าหลายก้อนในขั้นเดียวกันแบบ "บวกเข้าช่อง" จะบวกกันก่อนคูณ ส่วน "ตั้งค่าทับ" แทนที่ค่าเดิม ค่าที่ขึ้นกับสเตตัสแสดงเป็นตัวอย่างที่ 100 / 255 (และ Lv สกิลอื่น 1 / 10) ใช้สูตรที่แนบไว้คำนวณค่าอื่นเอง
<!-- calc:preface-end -->

### บทเพลงแห่งการเยียวยา (HealingSong) · uid 769

<img src="../../icons/sk_769.png" width="40" alt="icon">

- ทรี: สกิลมินสเตรล (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, คาตานะ · ธง: NoMarketSearch
- คลาสในโค้ด: `HealingSongAction` · สถานะการแกะ: แกะครบจากโค้ด

> การพักผ่อนของนักเดินทาง
> เพิ่มค่าประสบการณ์ที่ได้รับและเพิ่มพลังการฟื้นฟู
> อย่างเป็นธรรมชาติตอนไม่ได้ต่อสู้
> ฟื้นฟู HP และ MP เพิ่มเติมเมื่อจบการต่อสู้
> โดยขึ้นอยู่กับเวลาที่ใช้ในการต่อสู้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, สร้างพื้นที่ (วง/เพลง)
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `HealingSongBuf`: HP ฟื้นธรรมชาติ % (`HpRecoveryRate`) = `guitaristSavingTime` · MP ฟื้นธรรมชาติ % (`MpRecoveryRate`) = `ValidSongBuffLvUp` · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `UseArcheTypeId`
- บัพ `SongBufferBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `GameManager.PlayerSkillUpdate` — GameManager.PlayerSkillUpdate (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MainPlayer.ConnectUpdate` — MainPlayer.ConnectUpdate: คืนค่า `0` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerSecondaryStatus.get_HpRecovery` — ค่า Hp Recovery ของ MobaPlayerSecondaryStatus: คืนค่า `_t711` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerSecondaryStatus.get_MpRecovery` — ค่า Mp Recovery ของ MobaPlayerSecondaryStatus: คืนค่า `_t752` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PetStatus.get_HpRecovery` — ค่า Hp Recovery ของ PetStatus: คืนค่า `_t709` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PetStatus.get_MpRecovery` — ค่า Mp Recovery ของ PetStatus: คืนค่า `_t750` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.CalcHpRecovery` — คำนวณ hp recovery (PlayerSecondaryStatus): คืนค่า `((_t1576 & 1) ne 0 ? 0 : (int((_t1577 * _t712)) + _t1578))` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.CalcMpRecovery` — คำนวณ mp recovery (PlayerSecondaryStatus): คืนค่า `(int((_t1585 * _t753)) + _t1586)` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.GetExpBonus` — PlayerSecondaryStatus.GetExpBonus: คืนค่า `(BonusManager.GetGuildFacilityExpBonus(PlayerStatusBase.get_BonusManager(), BonusType.bExpRate) + _t1656)` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SetlistAction.GetSkillId` — SetlistAction.GetSkillId: คืนค่า `0xffffffff` (3 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ShortcutManager.ShortcutChatPanelOpen` — ShortcutManager.ShortcutChatPanelOpen (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ShortcutManager.ShortcutChatTargetOpen` — ShortcutManager.ShortcutChatTargetOpen (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ShortcutManager.ShortcutPanelOpen` — ShortcutManager.ShortcutPanelOpen (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv255: [บัฟเพลง] เมื่อใช้สกิลเพลงต่อเนื่องถึงระยะเวลาหนึ่ง สกิลเพลงนั้นจะเปลี่ยนเป็นบัฟเพลง(ผลถาวร)  ยิ่งจำนวนเพลงที่เปลี่ยนเป็นบัฟเพลงเพิ่มขึ้นเท่าใด MP ที่ใช้ในการร่ายสกิลเพลง และเวลาที่ต้องใช้ในการ เปลี่ยนเพลงถัดไปให้เป็นบัฟเพลงก็จะเพิ่มขึ้นเท่านั้น

### บทเพลงแห่งภูตพราย (FairySong) · uid 770

<img src="../../icons/sk_770.png" width="40" alt="icon">

- ทรี: สกิลมินสเตรล (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, คาตานะ · ต้องเรียนก่อน: บทเพลงแห่งการเยียวยา · ธง: NoMarketSearch
- คลาสในโค้ด: `FairySongAction` · สถานะการแกะ: แกะครบจากโค้ด

> การชี้นำแห่งภูตพราย
> เพิ่มอัตราความแม่นและอัตราหลบหลีก
> เมื่อโจมตีเป้าหมายแล้วเกิด Avoid หรือ Guard
> จะฟื้นฟู MP เล็กน้อย(ขึ้นอยู่กับค่าฟื้นฟู MP การโจมตี)
> ไม่สามารถใช้ร่วมกับสกิลเพลงอื่นได้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, สร้างพื้นที่ (วง/เพลง)
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `FairySongBuf`: หลบ % (`FleeRate`) = `IsValidBuff` · หลบ % (`FleeRate`) = `int(0.25 × isBattleActive × IsValidBuff)` · ความแม่น % (`HitRate`) = `ValidSongBuffLvUp` · ความแม่น % (`HitRate`) = `int(0.25 × isBattleActive × ValidSongBuffLvUp)` · ความแม่น + (`HitUp`) = `guitaristSavingTime` · ความแม่น + (`HitUp`) = `int(0.25 × isBattleActive × guitaristSavingTime)` · หลบ + (`Flee`) = `int(0.25 × isBattleActive × UseArcheTypeId)` · หลบ + (`Flee`) = `UseArcheTypeId`
- บัพ `SongBufferBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `PetStatus.get_Hit` — ค่า Hit ของ PetStatus: คืนค่า `(int(_t682) + _t683)` (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv255: [บัฟเพลง] เมื่อใช้สกิลเพลงต่อเนื่องถึงระยะเวลาหนึ่ง สกิลเพลงนั้นจะเปลี่ยนเป็นบัฟเพลง(ผลถาวร)  ยิ่งจำนวนเพลงที่เปลี่ยนเป็นบัฟเพลงเพิ่มขึ้นเท่าใด MP ที่ใช้ในการร่ายสกิลเพลงและเวลาที่ต้องใช้ในการ เปลี่ยนเพลงถัดไปให้เป็นบัฟเพลงก็จะเพิ่มขึ้นเท่านั้น
- Lv255: ผลบางส่วนของบทเพลงแห่งภูตพรายที่ผู้ใช้ได้รับจะลดลง ผลกระทบนี้จะลดลงเมื่อสมาชิกในปาร์ตี้ (ไม่รวม NPC) เพิ่มขึ้น

### บทเพลงแห่งชีวิต (SongOfLife) · uid 771

<img src="../../icons/sk_771.png" width="40" alt="icon">

- ทรี: สกิลมินสเตรล (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, คาตานะ · ต้องเรียนก่อน: บทเพลงแห่งการเยียวยา · ธง: NoMarketSearch
- คลาสในโค้ด: `SongOfLifeAction` · สถานะการแกะ: แกะครบจากโค้ด

> จังหวะชีวิต
> ลดเวลาการคืนชีพทุกช่วงเวลาที่กำหนด
> สะสมผลการลดความเสียหายแบบเป็นเปอร์เซ็นต์
> เมื่อ HP เหลือ 0 ค่าสะสมจะเปลี่ยนเป็นบาเรียฟื้นฟู
> ไม่สามารถใช้ร่วมกับสกิลเพลงอื่นได้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, สร้างพื้นที่ (วง/เพลง)
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `SongOfLifeBuf`: ตัวนับ/stack (`Count`) = `guitaristSavingTime`
- บัพ `SongBufferBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่

**โน้ตในเกม (ข้อความจากเกม):**
- Lv255: [บัฟเพลง] เมื่อใช้สกิลเพลงต่อเนื่องถึงระยะเวลาหนึ่ง สกิลเพลงนั้นจะเปลี่ยนเป็นบัฟเพลง(ผลถาวร)  ยิ่งจำนวนเพลงที่เปลี่ยนเป็นบัฟเพลงเพิ่มขึ้นเท่าใด MP ที่ใช้ในการร่ายสกิลเพลง และเวลาที่ต้องใช้ในการ เปลี่ยนเพลงถัดไปให้เป็นบัฟเพลงก็จะเพิ่มขึ้นเท่านั้น

### บทเพลงแห่งมายา (PhantomSong) · uid 772

<img src="../../icons/sk_772.png" width="40" alt="icon">

- ทรี: สกิลมินสเตรล (ขั้น 2) · เลเวลสูงสุด: 60 · อาวุธ: ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, คาตานะ · ต้องเรียนก่อน: บทเพลงแห่งชีวิต · ธง: NoMarketSearch
- คลาสในโค้ด: `PhantomSongAction` · สถานะการแกะ: แกะครบจากโค้ด

> มายาแห่งห้วงฝัน
> จะสะสมผลของเพลงไว้ชั่วขณะ
> ตอนที่สกิลคลายลงจะใช้ผลของเพลงเพื่อฟื้นฟู MP
> จะไม่ทำงานระหว่างทำคอมโบ
> ไม่สามารถใช้ร่วมกับสกิลเพลงอื่นได้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, สร้างพื้นที่ (วง/เพลง)
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `PhantomSongBuf`: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `ValidSongBuffLvUp`
- บัพ `SongBufferBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่

**โน้ตในเกม (ข้อความจากเกม):**
- Lv255: [บัฟเพลง] เมื่อใช้สกิลเพลงต่อเนื่องถึงระยะเวลาหนึ่ง สกิลเพลงนั้นจะเปลี่ยนเป็นบัฟเพลง(ผลถาวร)  ยิ่งจำนวนเพลงที่เปลี่ยนเป็นบัฟเพลงเพิ่มขึ้นเท่าใด MP ที่ใช้ในการร่ายสกิลเพลง และเวลาที่ต้องใช้ในการ เปลี่ยนเพลงถัดไปให้เป็นบัฟเพลงก็จะเพิ่มขึ้นเท่านั้น

### แอดลิบ (ImprovisationSong) · uid 773

<img src="../../icons/sk_773.png" width="40" alt="icon">

- ทรี: สกิลมินสเตรล (ขั้น 2) · เลเวลสูงสุด: 60 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: NoMarketSearch
- คลาสในโค้ด: `ImprovisationSongAction` · สถานะการแกะ: แกะครบจากโค้ด

> ใช้สกิลเพลงที่ใช้ไปล่าสุดอีกครั้ง
> ในระหว่างที่สกิลเพลงกำลังทำงานอยู่
> จะลดความเสียหายขณะใช้แอดลิบ
> (Lv10 จะเปลี่ยนจากการลดความเสียหายเป็นคงกระพัน)

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `BeatBlastBuf`: บัพนับสแตก (สืบจาก `CountBufferBase`): ตัวนับ `Count` เริ่ม 0 เพิ่มทีละ 1 ด้วย `Next()` และสูงสุด 20; โค้ดอื่นอ่านจำนวนสแตกผ่านพารามิเตอร์ `Count` (ดูค่าที่ใช้จริงในสูตรของสกิลที่อ้างถึง)
- บัพ `ImprovisationSongBuf` ระยะเวลา 1 วินาที: ตัวคูณดาเมจที่ได้รับจากมอน (หมวดเฉพาะ) (`MobLastDamageRateUnique`) = 30
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 20 ตามที่ `BeatBlastBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- บัพ `SongBufferBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `MobAttackBase.CalcLastDamage` — คำนวณ last damage (MobAttackBase): คืนค่า `((SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.ArkSaber, out) & 1) eq 0 ? ((_t983 & 1) eq 0 ? ((_t982 & 1) eq 0 ? _t997 : _t…` (นิยามเต็มในแท็บ Variables)

### บีทบลาสต์ (BeatBlast) · uid 776

<img src="../../icons/sk_776.png" width="40" alt="icon">

- ทรี: สกิลมินสเตรล (ขั้น 2) · เลเวลสูงสุด: 60 · อาวุธ: ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, คาตานะ · ต้องเรียนก่อน: บทเพลงแห่งชีวิต · ธง: NoMarketSearch
- คลาสในโค้ด: `BeatBlastAction` · สถานะการแกะ: แกะครบจากโค้ด

> โจมตีด้วยแรงดันเสียงที่ใช้ได้ขณะใช้สกิลเพลงเท่านั้น
> จะสะสมสแต็คตามค่า MP ที่สมาชิกปาร์ตี้
> ได้รับผลจากเพลงใช้ไป (สูงสุด 20)
> ใช้(สูงสุด 6) สแต็คเพื่อสร้าง
> ความเสียหายเวทมนตร์ต่อศัตรูรอบข้าง (ที่กำลังต่อสู้อยู่)

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- ตัวอ่านสกิลนี้ `ImprovisationSongAction.ActionSkillEventIfMoveIndex` — ImprovisationSongAction.ActionSkillEventIfMoveIndex: [call] `SkillUtil$$CheckSkillEquipLimit` = `PlayerStatusBase.get_EquipItemData(), MasterSkillDataManager.GetSkillMaster(Singleton<Mas…` เมื่อ +0x129 eq 0 AND IsOtherPlayer eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBufferMana…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new BeatBlastBuf, 0` เมื่อ +0x129 eq 0 AND IsOtherPlayer eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBufferMana… (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=776 -->
#### การคำนวณแบบตัวเลข — BeatBlast (uid 776)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `attackCount ge 1`**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **0** → 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(100 + 15×Lv)%** → 115%, 130%, 145%, 160%, 175%, 190%, 205%, 220%, 235%, 250% (Lv1…10)
<!-- calc:end -->

### บทเพลงแห่งความเร่าร้อน (EnthusiasticSong) · uid 774

<img src="../../icons/sk_774.png" width="40" alt="icon">

- ทรี: สกิลมินสเตรล (ขั้น 3) · เลเวลสูงสุด: 120 · อาวุธ: ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, คาตานะ · ต้องเรียนก่อน: บทเพลงแห่งภูตพราย · ธง: NoMarketSearch
- คลาสในโค้ด: `EnthusiasticSongAction` · สถานะการแกะ: แกะครบจากโค้ด

> จิตที่ตั้งมั่นอย่างแน่วแน่
> เพิ่มความเสียหายต่อจุดอ่อนและความเสียหายต่อไร้ธาตุ
> และเพิ่มเฮทเมื่อตกเป็นเป้าหมาย
> ไม่สามารถใช้ร่วมกับสกิลเพลงอื่นได้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, สร้างพื้นที่ (วง/เพลง)
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `EnthusiasticSongBuf`: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `int(0.25 × isBattleActive × guitaristSavingTime)` · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `guitaristSavingTime`
- บัพ `SongBufferBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `PlayerAttackBase.CalcElementBonus` — โบนัสธาตุ (ได้เปรียบ/เสียเปรียบธาตุ): คืนค่า `((_t1417 + 100) * 0.01)` (3 กรณี) (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv255: [บัฟเพลง] เมื่อใช้สกิลเพลงต่อเนื่องถึงระยะเวลาหนึ่ง สกิลเพลงนั้นจะเปลี่ยนเป็นบัฟเพลง(ผลถาวร)  ยิ่งจำนวนเพลงที่เปลี่ยนเป็นบัฟเพลงเพิ่มขึ้นเท่าใด MP ที่ใช้ในการร่ายสกิลเพลงและเวลาที่ต้องใช้ในการ เปลี่ยนเพลงถัดไปให้เป็นบัฟเพลงก็จะเพิ่มขึ้นเท่านั้น
- Lv255: ผลของบทเพลงแห่งความเร่าร้อนที่ผู้ใช้ได้รับจะลดลง ผลกระทบนี้จะลดลงเมื่อสมาชิกในปาร์ตี้ (ไม่รวม NPC) เพิ่มขึ้น

### บทเพลงแห่งภูมิปัญญา (KnowledgeSong) · uid 775

<img src="../../icons/sk_775.png" width="40" alt="icon">

- ทรี: สกิลมินสเตรล (ขั้น 3) · เลเวลสูงสุด: 120 · อาวุธ: ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, คาตานะ · ต้องเรียนก่อน: บทเพลงแห่งภูตพราย · ธง: NoMarketSearch
- คลาสในโค้ด: `KnowledgeSongAction` · สถานะการแกะ: แกะครบจากโค้ด

> การรู้แจ้งแห่งภูมิปัญญาอันมหาศาล
> ลดความเสียหายทุกประเภทและระยะผลักกระเด็น
> ไม่สามารถใช้ร่วมกับสกิลเพลงอื่นได้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, สร้างพื้นที่ (วง/เพลง)
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `KnowledgeSongBuf`: ตัวคูณดาเมจที่ได้รับจากมอน (หมวดซัพพอร์ต) (`MobLastDamageRateSupport`) = `guitaristSavingTime` · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `int(0.25 × isBattleActive × ValidSongBuffLvUp)` · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `ValidSongBuffLvUp`
- บัพ `SongBufferBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `AutoMemberActionManager.CalcAbnormalKnockBackDistance` — คำนวณ abnormal knock back distance (AutoMemberActionManager) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.CalcAbnormalKnockBackDistance` — คำนวณ abnormal knock back distance (PlayerActionManager) (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv255: [บัฟเพลง] เมื่อใช้สกิลเพลงต่อเนื่องถึงระยะเวลาหนึ่ง สกิลเพลงนั้นจะเปลี่ยนเป็นบัฟเพลง(ผลถาวร)  ยิ่งจำนวนเพลงที่เปลี่ยนเป็นบัฟเพลงเพิ่มขึ้นเท่าใด MP ที่ใช้ในการร่ายสกิลเพลงและเวลาที่ต้องใช้ในการ เปลี่ยนเพลงถัดไปให้เป็นบัฟเพลงก็จะเพิ่มขึ้นเท่านั้น
- Lv255: ผลของบทเพลงแห่งภูมิปัญญาที่ผู้ใช้ได้รับจะลดลง ผลกระทบนี้จะลดลงเมื่อสมาชิกในปาร์ตี้ (ไม่รวม NPC) เพิ่มขึ้น

### ซาวนด์เวล (SoundVeil) · uid 777

<img src="../../icons/sk_777.png" width="40" alt="icon">

- ทรี: สกิลมินสเตรล (ขั้น 3) · เลเวลสูงสุด: 120 · อาวุธ: ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, คาตานะ · ต้องเรียนก่อน: บีทบลาสต์ · ธง: NoMarketSearch
- คลาสในโค้ด: `SoundVeil` · สถานะการแกะ: แกะครบจากโค้ด

> ขณะใช้สกิลเพลงค่าเฮทที่เกิดจากตัวผู้ใช้จะกลายเป็น 1
> และลดความเสียหายทั้งหมดตามจำนวนบัฟเพลง
> แต่ไม่สามารถลดความเสียหายจากเป้าหมาย
> ที่พุ่งเป้ามาที่ผู้ใช้โดยตรงได้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ

### แบทเทิลโน้ต (BattleNotes) · uid 778

<img src="../../icons/sk_778.png" width="40" alt="icon">

- ทรี: สกิลมินสเตรล (ขั้น 3) · เลเวลสูงสุด: 120 · อาวุธ: ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, คาตานะ · ต้องเรียนก่อน: บีทบลาสต์ · ธง: NoMarketSearch
- คลาสในโค้ด: `BattleNotes` · สถานะการแกะ: แกะครบจากโค้ด

> ขณะใช้สกิลเพลงหากมีเป้าหมาย
> อยู่ในระยะโจมตีของอาวุธที่ติดตั้งและผู้ใช้หยุดนิ่ง
> จะปล่อยคลื่นเสียงโจมตีเพื่อทำการโจมตีปกติ
> (ระยะเวลาการใช้ขึ้นอยู่กับค่า ASPD และสกิลเลเวล)

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ค่าเปอร์เซ็นต์ (`Percent`): 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.StartBattleNotesAttack` — PlayerBattleManager.StartBattleNotesAttack: [call] `SkillFactory$$CreateSkill` = `SkillId.BattleNotesAttack` เมื่อ (SkillActionManager.IsPlaySkillData(skillActManager, SkillId.BattleNotesAttack) & 1) eq 0 AND (UnityEngine.Object.op_Eq… (นิยามเต็มในแท็บ Variables)

