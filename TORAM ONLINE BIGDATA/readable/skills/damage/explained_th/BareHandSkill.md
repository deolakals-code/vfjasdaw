# สกิลมือเปล่า (`BareHandSkill`) — คำอธิบายทีละสกิล (ภาษาไทย)

สร้างอัตโนมัติด้วย `scripts/render_explained_th.py` จาก `skill_reference.json` (ข้อมูลโค้ด client ชุดล่าสุด) ไม่มีข้อความเขียนมือ แก้ไฟล์นี้ตรง ๆ จะถูกเขียนทับ ตัวเลขทั้งหมดคำนวณจากโค้ด (Code) ความหมายของชื่อ field/บทบาทแปลจากชื่อในโค้ด (Inferred) ยังไม่ได้เทียบกับตัวเลขในเกม ข้อมูลดิบทุกเส้นทางอยู่ใน `../details/BareHandSkill.md`

---

<!-- calc:preface -->
> **วิธีอ่านหัวข้อ "การคำนวณแบบตัวเลข"** (สร้างอัตโนมัติด้วย `scripts/render_calc_th.py` จาก `skill_reference.json` แก้มือจะถูกเขียนทับ)
> ดาเมจต่อฮิตเดินตามขั้น `SkillCalcTemplate/CalcStep` 0→40 ตามลำดับ (Code: `SkillCalcTemplate.GetDamage`) ขั้น `+` บวกเข้าดาเมจ ขั้น `×` คูณแล้วปัดเศษทิ้ง (int) ทันทีทุกขั้น
> ลำดับหลัก: ดาเมจฐาน(7) + คงที่สกิล(8) + คงที่บัพ(9) − ป้องกันเป้า(10) + ตีแรก(11) → ×คริ(13) → ×ธาตุ(15) → ×ตัวคูณสกิล(18) → ×ตีแรก(19) → ×เสถียร(21) → +คงที่ออโต้(22) → ×Proration(23) → ×ประเภท(24) → ×ดาเมจสุดท้าย(25) → … → เพดาน/ขั้นต่ำ(35–37)
> "ฮิต N" = template ดาเมจแต่ละก้อน (ทอยคริแยกกัน) แยกตามเมธอดและตัวแปรฮิตในโค้ด (`type`, `isFirst`, `attackCount` …) ชื่อฮิต/ส่วนมาจากชื่อในโค้ด (Inferred) ตัวเลขคำนวณจากโค้ด (Code) โดยตั้งเจม/บัพเสริม = 0
> ค่าหลายก้อนในขั้นเดียวกันแบบ "บวกเข้าช่อง" จะบวกกันก่อนคูณ ส่วน "ตั้งค่าทับ" แทนที่ค่าเดิม ค่าที่ขึ้นกับสเตตัสแสดงเป็นตัวอย่างที่ 100 / 255 (และ Lv สกิลอื่น 1 / 10) ใช้สูตรที่แนบไว้คำนวณค่าอื่นเอง
<!-- calc:preface-end -->

### ความชำนาญการสู้มือเปล่า (BarehandMastery) · uid 1089

<img src="../../icons/sk_1089.png" width="40" alt="icon">

- ทรี: สกิลมือเปล่า (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: มือเปล่า, SubWeaponExclusion · ธง: NoMarketSearch
- คลาสในโค้ด: `BarehandMastery` · สถานะการแกะ: แกะครบจากโค้ด

> สามารถใช้ได้เมื่อทั้งเมนและซับเป็นมือเปล่าเท่านั้น
> แก่นแท้ของมือเปล่า
> จะได้รับ ATK อาวุธตามเลเวลของตัวเอง
> และเพิ่มขีดจำกัดให้ชี่กง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, พาสซีฟ
- บัพ `TakeQigongBuf` ระยะเวลา 600 วินาที: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `Max` · ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์)
- พาสซีฟ ATK อาวุธ % (`EqAtkRate`): 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10)
- ตัวอ่านสกิลนี้ `Revival.CheckRevival` — ตรวจ revival (Revival): คืนค่า `(TakeQigongBuf.GetUseQigongNum(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.BarehandMastery)) gt 0 ? 1 : 0)` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `Revival.OnActionMobDamage` — Revival.OnActionMobDamage: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.BarehandMastery, PlayerStatusBase.get_…` เมื่อ (CharacterActionManagerBase.get_IsDead() & 1) eq 0 AND Toram.Common.Actions.ActionAppendData.Get(appendData, 1093) ge 1…; [call] `CollectQigongBuf$$UpdateQigongNum` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.CollectQigong), Toram.Co…` เมื่อ (CharacterActionManagerBase.get_IsDead() & 1) eq 0 AND Toram.Common.Actions.ActionAppendData.Get(appendData, 1093) ge 1…; [call] `CollectQigongBuf$$UpdateQigongNum` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.CollectQigong), Toram.Co…` เมื่อ (CharacterActionManagerBase.get_IsDead() & 1) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId… (นิยามเต็มในแท็บ Variables)

### ชาร์จพลังชี่กง (CollectQigong) · uid 1090

<img src="../../icons/sk_1090.png" width="40" alt="icon">

- ทรี: สกิลมือเปล่า (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: มือเปล่า, SubWeaponExclusion · ธง: NoMarketSearch
- คลาสในโค้ด: `CollectQigongAction` · สถานะการแกะ: แกะครบจากโค้ด

> สามารถใช้ได้เมื่อทั้งเมนและซับเป็นมือเปล่าเท่านั้น
> ใช้ MP ทั้งหมดเพื่อสะสมชี่กง
> เพิ่ม ATK ตามการสะสมชี่กงเป็นเวลา 180 วินาที
> ความเสถียรจะเพิ่มขึ้นโดยไม่เกี่ยวข้องกับจำนวนชี่กง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- MP ที่ใช้: `max(min(PlayerAttackBase.CalcCostMp(this, playerAction), 2000), 100)`
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `CollectQigongBuf` ระยะเวลา 180 วินาที: ATK + (`AtkUp`) = `((((Count * Lv) * Lv) * Lv) // 100)` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `takeNum` · ความเสถียร (`Stable`) = 5×Lv → 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10) · ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `takeNum`
- ตัวอ่านสกิลนี้ `PlayerSecondaryStatus.get_AtkMpRecovery` — ค่า Atk Mp Recovery ของ PlayerSecondaryStatus: คืนค่า `0` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `Revival.OnActionMobDamage` — Revival.OnActionMobDamage: [call] `CollectQigongBuf$$UpdateQigongNum` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.CollectQigong), Toram.Co…` เมื่อ (CharacterActionManagerBase.get_IsDead() & 1) eq 0 AND Toram.Common.Actions.ActionAppendData.Get(appendData, 1093) ge 1…; [call] `CollectQigongBuf$$UpdateQigongNum` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.CollectQigong), Toram.Co…` เมื่อ (CharacterActionManagerBase.get_IsDead() & 1) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId…; [call] `CollectQigongBuf$$UpdateQigongNum` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.CollectQigong), Toram.Co…` เมื่อ (CharacterActionManagerBase.get_IsDead() & 1) eq 0 AND Toram.Common.Actions.ActionAppendData.Get(appendData, 1093) ge 1… (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=1090 -->
#### การคำนวณแบบตัวเลข — CollectQigong (uid 1090)

**ค่าบัพที่ขึ้นกับจำนวน stack**

- บัพ `CollectQigongBuf` — `AtkUp` ตามจำนวน `Count`: `Count × Lv × Lv × Lv // 100`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | 0 | 0 | 0 | 0 | 1 | 2 | 3 | 5 | 7 | 10 |
  | 2 | 0 | 0 | 0 | 1 | 2 | 4 | 6 | 10 | 14 | 20 |
  | 3 | 0 | 0 | 0 | 1 | 3 | 6 | 10 | 15 | 21 | 30 |
  | 4 | 0 | 0 | 1 | 2 | 5 | 8 | 13 | 20 | 29 | 40 |
  | 5 | 0 | 0 | 1 | 3 | 6 | 10 | 17 | 25 | 36 | 50 |
  | 6 | 0 | 0 | 1 | 3 | 7 | 12 | 20 | 30 | 43 | 60 |
  | 7 | 0 | 0 | 1 | 4 | 8 | 15 | 24 | 35 | 51 | 70 |
  | 8 | 0 | 0 | 2 | 5 | 10 | 17 | 27 | 40 | 58 | 80 |
  | 9 | 0 | 0 | 2 | 5 | 11 | 19 | 30 | 46 | 65 | 90 |
  | 10 | 0 | 0 | 2 | 6 | 12 | 21 | 34 | 51 | 72 | 100 |
<!-- calc:end -->

### ซีซ่าแสลชเชอร์ (FuriousEfforts) · uid 1091

<img src="../../icons/sk_1091.png" width="40" alt="icon">

- ทรี: สกิลมือเปล่า (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: มือเปล่า, SubWeaponExclusion · ต้องเรียนก่อน: ชาร์จพลังชี่กง · ธง: NoMarketSearch
- คลาสในโค้ด: `FuriousEffortsAction` · สถานะการแกะ: แกะครบจากโค้ด

> สามารถใช้ได้เมื่อทั้งเมนและซับเป็นมือเปล่าเท่านั้น
> ใช้ชี่กง 30 วินาที
> เพื่อเพิ่มการโจมตีปกติ และอัตราคริติคอล
> แต่ต้องแลกกับการสูญเสียความเร็วการโจมตีจำนวนมาก
> ถ้าใช้สกิลชี่กงอื่นผลจะสิ้นสุดลงทันที 

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, เพิ่มดาเมจตีปกติ
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `FuriousEffortsBuf` ระยะเวลา 30 วินาที: ตัวคูณตีปกติ % (`NormalAttackRate`) = `(SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) + 2 × Lv) × useNum` · ดาเมจคงที่ตีปกติ (`NormalAttackConstantDamage`) = `5 × useNum × Lv` · ความเร็วโจมตี + (`Aspd`) = -2850 · ตัวนับ/stack (`Count`) = `useNum` · อัตราคริ + (`CrtUp`) = `useNum × Lv`
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 10 ตามที่ `FuriousEffortsBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `BCollaboBossActionManager.Damaged` — BCollaboBossActionManager: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new FuriousEffortsExtremeBuf, 0` เมื่อ (EnemyMobActionManagerBase.get_IsDead() & 1) eq 0 AND IsValid ne 0 AND (EnemyMobActionManagerBase.CheckCurrentPatternDa… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EarthShatteringAction.ActionSkillEvent` — EarthShatteringAction.ActionSkillEvent (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EarthShatteringAction.ActionStart` — EarthShatteringAction: ตอนเริ่มทำงานของสกิล: [set] `<LoopParam>k__BackingField` = `(LoopParam | 2)` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get…; [set] `<LoopParam>k__BackingField` = `(((SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.F…` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EarthShatteringBuf.GetBufferEffectAppendParameter` — EarthShatteringBuf.GetBufferEffectAppendParameter: คืนค่า `new System.Collections.Generic.Dictionary<TakeParameterType, int>` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EnemyMobActionManagerBase.Damaged` — EnemyMobActionManagerBase: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new FuriousEffortsExtremeBuf, 0` เมื่อ (EnemyMobActionManagerBase.get_IsDead() & 1) eq 0 AND IsValid ne 0 AND damageData.HitType ne 0 AND (UnityEngine.Object.… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `FuriousEffortsAction.ActionSkillEvent` — FuriousEffortsAction.ActionSkillEvent (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `FuriousEffortsExtreme.Damaged` — FuriousEffortsExtreme: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new FuriousEffortsExtremeBuf, 0` เมื่อ (_t349 & 1) ne 0 AND PlayerStatusBase.get_SkillManager().SkillMasteryList[SkillId.FuriousEffortsExtreme].skillData.Leve… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GuildRaidBossMobActionManager.Damaged` — GuildRaidBossMobActionManager: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new FuriousEffortsExtremeBuf, 0` เมื่อ (EnemyMobActionManagerBase.get_IsDead() & 1) eq 0 AND IsValid ne 0 AND damageData.HitType ne 0 AND (UnityEngine.Object.… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `Revival.OnActionMobDamage` — Revival.OnActionMobDamage: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.FuriousEffortsExtreme` เมื่อ (CharacterActionManagerBase.get_IsDead() & 1) eq 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ScoreAttackBossActionManager.Damaged` — ScoreAttackBossActionManager: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new FuriousEffortsExtremeBuf, 0` เมื่อ (EnemyMobActionManagerBase.get_IsDead() & 1) eq 0 AND IsValid ne 0 AND (EnemyMobActionManagerBase.CheckCurrentPatternDa… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SelfDisclosure.UpdateCristaBonus` — SelfDisclosure.UpdateCristaBonus: [call] `SelfDisclosure$$SetCristBonus` = `playerData, ((SkillBufferManager.ContainsBuffer(PlayerDataManager.get_SkillBufferManager(…` (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=1091 -->
#### การคำนวณแบบตัวเลข — FuriousEfforts (uid 1091)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `ActionStart`): `TakeQigongBuf.GetUseQigongNum(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1089])`

**ค่าบัพที่ขึ้นกับจำนวน stack**

- บัพ `FuriousEffortsBuf` — `NormalAttackRate` ตามจำนวน `Count`: `normalAttackDamageUpRate × Count`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |

- บัพ `FuriousEffortsBuf` — `NormalAttackConstantDamage` ตามจำนวน `Count`: `5 × Count × Lv`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |
  | 2 | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |
  | 3 | 15 | 30 | 45 | 60 | 75 | 90 | 105 | 120 | 135 | 150 |
  | 4 | 20 | 40 | 60 | 80 | 100 | 120 | 140 | 160 | 180 | 200 |
  | 5 | 25 | 50 | 75 | 100 | 125 | 150 | 175 | 200 | 225 | 250 |

- บัพ `FuriousEffortsBuf` — `CrtUp` ตามจำนวน `Count`: `Count × Lv`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
  | 2 | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |
  | 3 | 3 | 6 | 9 | 12 | 15 | 18 | 21 | 24 | 27 | 30 |
  | 4 | 4 | 8 | 12 | 16 | 20 | 24 | 28 | 32 | 36 | 40 |
  | 5 | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |
<!-- calc:end -->

### วายุโหมคลื่นกระหน่ำ (StormAndUrge) · uid 1092

<img src="../../icons/sk_1092.png" width="40" alt="icon">

- ทรี: สกิลมือเปล่า (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: มือเปล่า, SubWeaponExclusion · ต้องเรียนก่อน: ชาร์จพลังชี่กง · ธง: NoMarketSearch
- คลาสในโค้ด: `StormAndUrgeAction` · สถานะการแกะ: แกะครบจากโค้ด

> สามารถใช้ได้เมื่อทั้งเมนและซับเป็นมือเปล่าเท่านั้น
> ใช้ชี่กง 30 วินาทีเพื่อเพิ่มความแม่น, ความเร็วการโจมตี
> ความเร็วในการเคลื่อนย้าย 
> ถ้าใช้สกิลชี่กงอื่นผลจะสิ้นสุดลงทันที

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `StormAndUrgeBuf` ระยะเวลา 30 วินาที: ความแม่น + (`HitUp`) = `useNum × Lv × Lv` · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = 50 · ความเร็วโจมตี + (`Aspd`) = `100 × useNum × Lv` · MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = `int(0.2 × useNum × Lv)` · ตัวนับ/stack (`Count`) = `useNum`
- ตัวอ่านสกิลนี้ `EarthShatteringAction.ActionSkillEvent` — EarthShatteringAction.ActionSkillEvent (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EarthShatteringAction.ActionStart` — EarthShatteringAction: ตอนเริ่มทำงานของสกิล: [set] `<LoopParam>k__BackingField` = `(((SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.F…` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EarthShatteringBuf.GetBufferEffectAppendParameter` — EarthShatteringBuf.GetBufferEffectAppendParameter: คืนค่า `new System.Collections.Generic.Dictionary<TakeParameterType, int>` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.get_MoveSpeed` — ค่า Move Speed ของ MobaPlayerActionManager: คืนค่า `_t1117` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.get_MoveSpeed` — ค่า Move Speed ของ PlayerActionManager: คืนค่า `_t1348` (3 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `Revival.OnActionMobDamage` — Revival.OnActionMobDamage: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.StormAndUrgeExtreme` เมื่อ (CharacterActionManagerBase.get_IsDead() & 1) eq 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SelfDisclosure.UpdateCristaBonus` — SelfDisclosure.UpdateCristaBonus (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `StormAndUrgeAction.ActionSkillEvent` — StormAndUrgeAction.ActionSkillEvent: [call] `SkillFactory$$CreateSkillBuffer` = `SkillId.StormAndUrge, Lv, 1, 0, useQigongNum` เมื่อ IsInstanceOf(actarAction, OtherPlayerActionManager) eq 1 AND useQigongNum ge 1; [call] `SkillFactory$$CreateSkillBuffer` = `SkillId.StormAndUrge, Lv, 1, 0, useQigongNum` เมื่อ IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) eq…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.StormAndUrge, Lv, 0, useQigongNum, Id` เมื่อ IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne… (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=1092 -->
#### การคำนวณแบบตัวเลข — StormAndUrge (uid 1092)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `ActionStart`): `TakeQigongBuf.GetUseQigongNum(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1089])`

**ค่าบัพที่ขึ้นกับจำนวน stack**

- บัพ `StormAndUrgeBuf` — `HitUp` ตามจำนวน `Count`: `Count × Lv × Lv`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | 1 | 4 | 9 | 16 | 25 | 36 | 49 | 64 | 81 | 100 |
  | 2 | 2 | 8 | 18 | 32 | 50 | 72 | 98 | 128 | 162 | 200 |
  | 3 | 3 | 12 | 27 | 48 | 75 | 108 | 147 | 192 | 243 | 300 |
  | 4 | 4 | 16 | 36 | 64 | 100 | 144 | 196 | 256 | 324 | 400 |
  | 5 | 5 | 20 | 45 | 80 | 125 | 180 | 245 | 320 | 405 | 500 |

- บัพ `StormAndUrgeBuf` — `Aspd` ตามจำนวน `Count`: `100 × Count × Lv`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | 100 | 200 | 300 | 400 | 500 | 600 | 700 | 800 | 900 | 1000 |
  | 2 | 200 | 400 | 600 | 800 | 1000 | 1200 | 1400 | 1600 | 1800 | 2000 |
  | 3 | 300 | 600 | 900 | 1200 | 1500 | 1800 | 2100 | 2400 | 2700 | 3000 |
  | 4 | 400 | 800 | 1200 | 1600 | 2000 | 2400 | 2800 | 3200 | 3600 | 4000 |
  | 5 | 500 | 1000 | 1500 | 2000 | 2500 | 3000 | 3500 | 4000 | 4500 | 5000 |

- บัพ `StormAndUrgeBuf` — `AttackMprecoveryUp` ตามจำนวน `Count`: `int(0.2 × Count × Lv)`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | 0 | 0 | 0 | 0 | 1 | 1 | 1 | 1 | 1 | 2 |
  | 2 | 0 | 0 | 1 | 1 | 2 | 2 | 2 | 3 | 3 | 4 |
  | 3 | 0 | 1 | 1 | 2 | 3 | 3 | 4 | 4 | 5 | 6 |
  | 4 | 0 | 1 | 2 | 3 | 4 | 4 | 5 | 6 | 7 | 8 |
  | 5 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
<!-- calc:end -->

### ชี่กงฟื้นฟู (HealQigong) · uid 1093

<img src="../../icons/sk_1093.png" width="40" alt="icon">

- ทรี: สกิลมือเปล่า (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: มือเปล่า, SubWeaponExclusion · ต้องเรียนก่อน: ชาร์จพลังชี่กง · ธง: NoMarketSearch
- คลาสในโค้ด: `HealQigongAction` · สถานะการแกะ: แกะครบจากโค้ด

> สามารถใช้ได้เมื่อทั้งเมนและซับเป็นมือเปล่าเท่านั้น
> ใช้ชี่กงเพื่อเพิ่มการฟื้นฟู HP อย่างต่อเนื่องชั่วขณะ
> เมื่อถูกโจมตีจะใช้ชี่กงเพื่อลดความเสียหายให้เบาลง
> ระหว่างติดผลพลังการโจมตีจะลดลง ความเสียหายจากพิษจะแรงขึ้น
> ถ้าใช้สกิลชี่กงอื่นผลจะสิ้นสุดลงทันที

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `HealQigongBuf`: ค่าเปอร์เซ็นต์ทั่วไป (`Percent`) = `SkillMasteryBase.GetMasteryParam(MasteryId.Percent)` · ATK % (`AtkUpRate`) = -98, -95, -93, -90, -88, -85, -83, -80, -78, -75 (Lv1…10) · ตัวนับ/stack (`Count`) = `Count` · ตัวคูณดาเมจที่ได้รับจากมอน (หมวดเฉพาะ) (`MobLastDamageRateUnique`) = `int((0.5 × Lv + 4.5) × Count)`
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 10 ตามที่ `HealQigongBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `EarthShatteringAction.ActionSkillEvent` — EarthShatteringAction.ActionSkillEvent: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new EarthShatteringBuf, Id` เมื่อ IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new EquipPhysicalBarrierBuf, Id` เมื่อ IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.BarehandMastery, PlayerStatusBase.get_…` เมื่อ IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EarthShatteringAction.ActionStart` — EarthShatteringAction: ตอนเริ่มทำงานของสกิล: [set] `<LoopParam>k__BackingField` = `(LoopParam | 8)` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get…; [set] `<LoopParam>k__BackingField` = `(LoopParam | 2)` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get…; [set] `<LoopParam>k__BackingField` = `(((SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.F…` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `FlashGrenadeAction.ActionSkillEvent` — FlashGrenadeAction.ActionSkillEvent (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `FreezeGrenadeAction.ActionSkillEvent` — FreezeGrenadeAction.ActionSkillEvent (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `HealQigongAction.ActionSkillEvent` — HealQigongAction.ActionSkillEvent (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `Revival.CheckRevival` — ตรวจ revival (Revival): คืนค่า `(TakeQigongBuf.GetUseQigongNum(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.BarehandMastery)) gt 0 ? 1 : 0)` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `Revival.OnActionMobDamage` — Revival.OnActionMobDamage (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SelfDisclosure.UpdateCristaBonus` — SelfDisclosure.UpdateCristaBonus (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=1093 -->
#### การคำนวณแบบตัวเลข — HealQigong (uid 1093)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `ActionStart`): `TakeQigongBuf.GetUseQigongNum(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1089])`

**ค่าบัพที่ขึ้นกับจำนวน stack**

- บัพ `HealQigongBuf` — `MobLastDamageRateUnique` ตามจำนวน `Count`: `int((0.5 × Lv + 4.5) × Count)`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | 5 | 5 | 6 | 6 | 7 | 7 | 8 | 8 | 9 | 9 |
  | 2 | 10 | 11 | 12 | 13 | 14 | 15 | 16 | 17 | 18 | 19 |
  | 3 | 15 | 16 | 18 | 19 | 21 | 22 | 24 | 25 | 27 | 28 |
  | 4 | 20 | 22 | 24 | 26 | 28 | 30 | 32 | 34 | 36 | 38 |
  | 5 | 25 | 27 | 30 | 32 | 35 | 37 | 40 | 42 | 45 | 47 |
<!-- calc:end -->

### ชาร์จพลังชี่กงอัลติมา (CollectQigongExtreme) · uid 1094

<img src="../../icons/sk_1094.png" width="40" alt="icon">

- ทรี: สกิลมือเปล่า (ขั้น 2) · เลเวลสูงสุด: 100 · อาวุธ: มือเปล่า, SubWeaponExclusion · ต้องเรียนก่อน: ชาร์จพลังชี่กง · ธง: NoMarketSearch
- คลาสในโค้ด: `CollectQigongExtreme` · สถานะการแกะ: แกะครบจากโค้ด

> ลดจำนวนการใช้ชี่กงเมื่อใช้สกิลอื่นนอกเหนือจากมือเปล่า
> และเพิ่มการฟื้นฟู MP การโจมตีขึ้นเล็กน้อย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ค่าเปอร์เซ็นต์ (`Percent`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
- พาสซีฟ ค่าทั่วไป (`Value`): 0, 1, 1, 2, 2, 3, 3, 4, 4, 5 (Lv1…10)

### ซีซ่าแสลชเชอร์อัลติมา (FuriousEffortsExtreme) · uid 1095

<img src="../../icons/sk_1095.png" width="40" alt="icon">

- ทรี: สกิลมือเปล่า (ขั้น 2) · เลเวลสูงสุด: 100 · อาวุธ: มือเปล่า, SubWeaponExclusion · ต้องเรียนก่อน: ซีซ่าแสลชเชอร์ · ธง: NoMarketSearch
- คลาสในโค้ด: `FuriousEffortsExtreme` · สถานะการแกะ: แกะครบจากโค้ด

> เพิ่มผลของซีซ่าแสลชเชอร์เพื่ออัพเกรดการโจมตีปกติ
> ถ้าติดคริติคอลระหว่างใช้ซีซ่าแสลชเชอร์
> ผลที่ช่วยอัพเกรดสกิลการโจมตีจะถูกสะสมไว้
> แต่ถ้าใช้างานชี่กงฟื้นฟูพลังจะหายไป

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, พาสซีฟ
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = ((((Lv << 2) + lv) lo 25 ? ((Lv << 2) + lv) : 25) + 5) ตามที่ `FuriousEffortsExtremeBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- บัพ `FuriousEffortsExtremeBuf`: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = 5, 5, 5, 5, 5, 6, 7, 8, 9, 10 (Lv1…10)
- พาสซีฟ ตัวคูณสกิล (`SkillRate`): 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 (Lv1…10)

### วายุโหมคลื่นกระหน่ำอัลติมา (StormAndUrgeExtreme) · uid 1096

<img src="../../icons/sk_1096.png" width="40" alt="icon">

- ทรี: สกิลมือเปล่า (ขั้น 2) · เลเวลสูงสุด: 100 · อาวุธ: มือเปล่า, SubWeaponExclusion · ต้องเรียนก่อน: วายุโหมคลื่นกระหน่ำ · ธง: NoMarketSearch
- คลาสในโค้ด: `StormAndUrgeExtreme` · สถานะการแกะ: แกะครบจากโค้ด

> เมื่อใช้วายุโหมคลื่นกระหน่ำจะมีโอกาสช่วยเพิ่ม
> อาวุธเจาะเข้าและโจมตีระยะประชิดเพิ่มมากขึ้น
> ผลจะสิ้นสุดลงถ้าใช้สกิลอื่นที่ไม่ใช่มือเปล่า
> แต่จะลด MP ที่ใช้ลงครึ่งหนึ่ง
> และถ้าใช้ชี่กงฟื้นฟูผลก็จะหายไปเช่นกัน

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, พาสซีฟ
- บัพ `StormAndUrgeExtremeBuf`: ค่าเปอร์เซ็นต์ทั่วไป (`Percent`) = 2×Lv → 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 (Lv1…10) · เจาะกายภาพ (`PowerResistBreaker`) = 200×Lv → 200, 400, 600, 800, 1000, 1200, 1400, 1600, 1800, 2000 (Lv1…10) · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = 200×Lv → 200, 400, 600, 800, 1000, 1200, 1400, 1600, 1800, 2000 (Lv1…10)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.CalcCostMp` — MP ที่ใช้ของสกิล: [call] `InflexibilityBuf$$CheckMpHalving` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.Inflexibility), this` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill…; [call] `MultipleHuntBuf$$CheckMode` = `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.MultipleHunt), SkillMode…` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill…; [set] `<CostMpType>k__BackingField` = `(CostMpType | 1)` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.DeadlySpear) & 1) eq 0 AND (Skill… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `StormAndUrgeAction.ActionSkillEvent` — StormAndUrgeAction.ActionSkillEvent: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.StormAndUrgeExtreme, SkillManager.GetS…` เมื่อ IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne…; [call] `AvoidActionManager$$Heal` = `[actarAction.battleManager+0xa8], SkillBufferDataBase.GetParam(_t1872, SkillBufferId.Valu…` เมื่อ IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne…; [call] `AvoidActionManager$$Heal` = `[actarAction.battleManager+0xa0], SkillBufferDataBase.GetParam(_t1872, SkillBufferId.Valu…` เมื่อ IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne… (นิยามเต็มในแท็บ Variables)

### การปะทะของจิตวิญญาณ (CollisionOfFightingSpirit) · uid 1097

<img src="../../icons/sk_1097.png" width="40" alt="icon">

- ทรี: สกิลมือเปล่า (ขั้น 2) · เลเวลสูงสุด: 100 · อาวุธ: มือเปล่า, SubWeaponExclusion · ต้องเรียนก่อน: ชี่กงฟื้นฟู · ธง: NoMarketSearch
- คลาสในโค้ด: `CollisionOfFightingSpirit` · สถานะการแกะ: แกะครบจากโค้ด

> ใช้ได้เฉพาะตอนไม่ได้ติดตั้งอาวุธหลักหรืออาวุธเสริม
> เมื่อทิศทางของเฮทระหว่างคุณและเป้าหมายตรงกัน
> ความเสียหายที่ได้รับจากเป้าหมายจะลดลง
> มีโอกาสในการป้องกันการใช้ชี่กง
> ถ้าได้รับความเสียหายระหว่างใช้ชี่กงฟื้นฟู

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ดาเมจสุดท้าย % (`LastDmgRate`): 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
- พาสซีฟ ค่าเปอร์เซ็นต์ (`Percent`): 2, 5, 7, 10, 12, 15, 17, 20, 22, 25 (Lv1…10)

### สะเทือนโลกา (EarthShattering) · uid 1098

<img src="../../icons/sk_1098.png" width="40" alt="icon">

- ทรี: สกิลมือเปล่า (ขั้น 3) · เลเวลสูงสุด: 250 · อาวุธ: มือเปล่า, SubWeaponExclusion · ธง: NoMarketSearch
- คลาสในโค้ด: `EarthShatteringAction` · สถานะการแกะ: แกะครบจากโค้ด

> สามารถใช้ได้ต่อเมื่อทั้งอาวุธหลักและเสริมเป็นมือเปล่าเท่านั้น
> สกิลนี้จะได้รับบาเรียตามจำนวนชี่กงที่สะสม
> ธาตุที่ได้เปรียบ อาวุธเจาะเข้า ความเสถียรทั้งหมดจะเพิ่มขึ้น
> ผลจะสิ้นสุดลงเมื่อใช้ชี่กงฟื้นฟู

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `EarthShatteringBuf`: ค่าเปอร์เซ็นต์ทั่วไป (`Percent`) = `Lvรวม // 10 + 2 × Lv` · เจาะกายภาพ (`PowerResistBreaker`) = 1, 2, 3, 4, 5, 7, 9, 11, 13, 15 (Lv1…10) · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `barrier` · ความเสถียร (`Stable`) = Lv → 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
- บัพ `EquipMagicBarrierBuf`: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `value`
- บัพ `EquipPhysicalBarrierBuf`: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `value`
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `EarthShatteringAction.ActionPreparation` — EarthShatteringAction: ขั้นเตรียมก่อนปล่อยสกิล: [set] `<SkillIndividualFlag>k__BackingField` = `((SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.Ea…` เมื่อ (UnityEngine.Object.op_Equality(actarAction, 0) & 1) eq 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EarthShatteringAction.ActionSkillEvent` — EarthShatteringAction.ActionSkillEvent: [call] `SkillBufferManager$$RemoveBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.EarthShattering` เมื่อ IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.bPhysicalBarrier` เมื่อ IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.bMagicBarrier` เมื่อ IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EarthShatteringAction.ActionStart` — EarthShatteringAction: ตอนเริ่มทำงานของสกิล: [set] `<LoopParam>k__BackingField` = `(_t227 | 1)` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EquipMagicBarrierBuf.CheckTakeOver` — ตรวจ take over (EquipMagicBarrierBuf): คืนค่า `(_t321 gt 0 ? 1 : 0)` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EquipMagicBarrierBuf.GetBarrierValue` — EquipMagicBarrierBuf.GetBarrierValue: คืนค่า `_t323` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EquipPhysicalBarrierBuf.CheckTakeOver` — ตรวจ take over (EquipPhysicalBarrierBuf): คืนค่า `(_t327 gt 0 ? 1 : 0)` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EquipPhysicalBarrierBuf.GetBarrierValue` — EquipPhysicalBarrierBuf.GetBarrierValue: คืนค่า `_t328` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MagicBarrier.Calc` — คำนวณ (MagicBarrier): คืนค่า `(IsValid eq 0 ? value : (((value gt 1 ? value : 1) - _t803) gt 0 ? ((value gt 1 ? value : 1) - _t803) : 1))` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `NormalAttackAction.ActionPreparation` — NormalAttackAction: ขั้นเตรียมก่อนปล่อยสกิล: [set] `damageCount` = `3` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.EarthShattering) & 1) ne 0; [set] `<SkillIndividualFlag>k__BackingField` = `(_t1188 | 0x4000)` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.EarthShattering) & 1) ne 0; [set] `<UnmanagedHitTake>k__BackingField` = `1` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.EarthShattering) & 1) ne 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PhysicalBarrier.Calc` — คำนวณ (PhysicalBarrier): คืนค่า `(IsValid eq 0 ? value : (((value gt 1 ? value : 1) - _t803) gt 0 ? ((value gt 1 ? value : 1) - _t803) : 1))` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ReceiveSupportResult.OnActionPlayerSupport` — ReceiveSupportResult.OnActionPlayerSupport: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerDataManager.get_SkillBufferManager(PlayerDataManager.GetPlayerDataManager()), Skill…` เมื่อ skillId gt 709 AND skillId gt 1025 AND skillId gt 1039 AND skillId gt 1090 AND (skillId - 1091) lo 3 AND (SkillBufferMa…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerDataManager.get_SkillBufferManager(PlayerDataManager.GetPlayerDataManager()), Skill…` เมื่อ skillId gt 709 AND skillId gt 1025 AND skillId gt 1039 AND skillId le 1090 AND (skillId & 0xffff) ne 1064 AND (skillId …; [call] `SacredTeachings$$ReceiveHpHeal` = `skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataM…` เมื่อ skillId gt 709 AND skillId gt 1025 AND skillId gt 1039 AND skillId le 1090 AND (skillId & 0xffff) ne 1064 AND (skillId … (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SkillBufferManager.Update` — SkillBufferManager.Update (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=1098 -->
#### การคำนวณแบบตัวเลข — EarthShattering (uid 1098)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `ActionStart`) [มีบัพ 1093 HealQigong]: `LoopParam | 8`
- `LoopParam` (ตั้งใน `ActionStart`) [ไม่มีบัพ 1093 HealQigong และ มีบัพ 1091 FuriousEfforts และ มีบัพ 1092 StormAndUrge และ มีบัพ 1098 EarthShattering]: `LoopParam | 2 | 4 | 1`
- `LoopParam` (ตั้งใน `ActionStart`) [ไม่มีบัพ 1093 HealQigong และ ไม่มีบัพ 1098 EarthShattering และ มีบัพ 1091 FuriousEfforts และ มีบัพ 1092 StormAndUrge]: `LoopParam | 2 | 4`
- `LoopParam` (ตั้งใน `ActionStart`) [ไม่มีบัพ 1092 StormAndUrge และ ไม่มีบัพ 1093 HealQigong และ มีบัพ 1091 FuriousEfforts และ มีบัพ 1098 EarthShattering]: `LoopParam | 2 | 1`
- `LoopParam` (ตั้งใน `ActionStart`) [ไม่มีบัพ 1092 StormAndUrge และ ไม่มีบัพ 1093 HealQigong และ ไม่มีบัพ 1098 EarthShattering และ มีบัพ 1091 FuriousEfforts]: `LoopParam | 2`
- `LoopParam` (ตั้งใน `ActionStart`) [ไม่มีบัพ 1091 FuriousEfforts และ ไม่มีบัพ 1093 HealQigong และ มีบัพ 1092 StormAndUrge และ มีบัพ 1098 EarthShattering]: `LoopParam | 4 | 1`
- `LoopParam` (ตั้งใน `ActionStart`) [ไม่มีบัพ 1091 FuriousEfforts และ ไม่มีบัพ 1093 HealQigong และ ไม่มีบัพ 1098 EarthShattering และ มีบัพ 1092 StormAndUrge]: `LoopParam | 4`
- `LoopParam` (ตั้งใน `ActionStart`) [ไม่มีบัพ 1091 FuriousEfforts และ ไม่มีบัพ 1092 StormAndUrge และ ไม่มีบัพ 1093 HealQigong และ มีบัพ 1098 EarthShattering]: `LoopParam | 1`
<!-- calc:end -->

### ฟื้นคืนชีพ (Revival) · uid 1099

<img src="../../icons/sk_1099.png" width="40" alt="icon">

- ทรี: สกิลมือเปล่า (ขั้น 3) · เลเวลสูงสุด: 250 · อาวุธ: มือเปล่า, SubWeaponExclusion · ต้องเรียนก่อน: การปะทะของจิตวิญญาณ · ธง: NoMarketSearch
- คลาสในโค้ด: `Revival` · สถานะการแกะ: แกะครบจากโค้ด

> ถ้าตายไปตอนที่ไม่ได้เปิดใช้ชี่กงฟื้นฟูมีโอกาสที่
> ชี่กงฟื้นฟูจะถูกเปิดใช้งานโดยอัตโนมัติเพื่อฟื้นฟู HP
> เมื่อเปิดใช้ไปแล้วจะไม่สามารถใช้งานได้อีกระยะหนึ่ง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, พาสซีฟ
- บัพ `RevivalBuf` ระยะเวลา 900 วินาที
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`
- พาสซีฟ ค่าทั่วไป (`Value`): 0, 0, 0, 0, 0, 1, 1, 1, 1, 1 (Lv1…10)
- พาสซีฟ ค่าเปอร์เซ็นต์ (`Percent`): 1, 4, 9, 16, 25, 36, 49, 64, 81, 100 (Lv1…10)
- ตัวอ่านสกิลนี้ `Revival.CheckRevival` — ตรวจ revival (Revival): คืนค่า `(TakeQigongBuf.GetUseQigongNum(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), SkillId.BarehandMastery)) gt 0 ? 1 : 0)` (2 กรณี) (นิยามเต็มในแท็บ Variables)

### ซ่อนเร้นตัวตน (SelfDisclosure) · uid 1100

<img src="../../icons/sk_1100.png" width="40" alt="icon">

- ทรี: สกิลมือเปล่า (ขั้น 3) · เลเวลสูงสุด: 250 · อาวุธ: มือเปล่า, SubWeaponExclusion · ต้องเรียนก่อน: ชาร์จพลังชี่กงอัลติมา · ธง: NoMarketSearch
- คลาสในโค้ด: `SelfDisclosure` · สถานะการแกะ: แกะครบจากโค้ด

> หากไม่มีสล็อตให้ถือไว้
> เมื่อติดตั้งคริสตา 3 อันและเปิดใช้
> ซีซ่าแสลชเชอร์/วายุโหมคลื่นกระหน่ำ/ชี่กงฟื้นฟู
> จะได้รับความสามารถของคริสตา 2 อันที่สอดคล้องกัน

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ
- พาสซีฟ ค่าทั่วไป (`Value`): 1200, 1400, 1600, 1800, 2000, 2200, 2400, 2600, 2800, 3000 (Lv1…10)
- พาสซีฟ ค่าเปอร์เซ็นต์ (`Percent`): 0, 1, 1, 2, 2, 3, 3, 4, 4, 5 (Lv1…10)
- พาสซีฟ หลบ (`Avoid`): 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10)
- พาสซีฟ พลังการ์ด (`GuardPower`): 500, 1000, 1500, 2000, 2500, 3000, 3500, 4000, 4500, 5000 (Lv1…10)
- พาสซีฟ อัตราการ์ด (`Guard`): 7, 9, 11, 13, 15, 17, 19, 21, 23, 25 (Lv1…10)

