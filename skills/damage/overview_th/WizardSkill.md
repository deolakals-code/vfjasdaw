# สกิลจอมเวทย์ (15 สกิล)

สรุปโดยรวมต่อสกิล: ตัวคูณดาเมจมาจากไหน / แยกอาวุธ / สถานะระหว่างท่า / บัพ / เชื่อมสกิลอื่น. วิธีอ่าน: [ENGINE.md](ENGINE.md)

### แฟมิเรีย (Familia) · uid 1025
- ทรี: สกิลจอมเวทย์ · เลเวลสูงสุด: 15 · อาวุธที่ใช้ได้: ไม้เท้า, อุปกรณ์เวท, SubMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `magicPursuitAttackRate`
- MATK + (`MatkUp`) = `matkUpRate × status.Lv ÷ 100`
- MP สูงสุด + (`MaxMpUp`) = `maxMp`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย บลิซซาร์ด (uid 1028) ผ่าน `BlizzardAction.IsFailure` (ContainsBuffer) — predicate is failure — Code
- ถูกอ่านโดย คริสตัลเลเซอร์ (uid 1034) ผ่าน `CrystalLaserAction.IsFailure` (ContainsBuffer) — predicate is failure — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `GameManager.ReceiveSummons` (GetSkillLv) — Receive Summons — Code
- ถูกอ่านโดย ไฮแฟมิเรีย (uid 1032) ผ่าน `HighFamiliaAction.IsFailure` (GetSkillLv) — predicate is failure — Code
- ถูกอ่านโดย ไลท์นิ่ง (uid 1027) ผ่าน `LightningAction.IsFailure` (ContainsBuffer) — predicate is failure — Code
- ถูกอ่านโดย มานาคริสตัล (uid 1026) ผ่าน `ManaCrystalAction.IsFailure` (ContainsBuffer) — predicate is failure — Code
- ถูกอ่านโดย เมเทโอสตอร์มสไตร์ค (uid 1029) ผ่าน `MeteorStrikeAction.IsFailure` (ContainsBuffer) — predicate is failure — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.PursuitAttack` (ContainsBuffer) — Pursuit Attack — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `SkillBufferManager.AlignLearningSkillBuffer` (GetSkillLv) — Align Learning Skill Buffer — Code
- ถูกอ่านโดย สโตนสกิล (uid 1030) ผ่าน `StoneSkinAction.IsFailure` (ContainsBuffer) — predicate is failure — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIExSkillManager.ExSkillList` (GetSkillLv) — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UISkillTreeManager.SkillTreeList` (GetSkillLv) — Code


---

### มานาคริสตัล (ManaCrystal) · uid 1026
- ทรี: สกิลจอมเวทย์ · เลเวลสูงสุด: 15 · อาวุธที่ใช้ได้: ไม้เท้า, อุปกรณ์เวท, SubMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = `System.Collections.Generic.Dictionary<int, object>.get_Count(invokers, meta(0x39aa0b8, Method$System.Collections.Generic.Dictionary<int, ManaCrystalBuf.Invoker>.get_Co…(ย่อ)`

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล แฟมิเรีย (uid 1025): `ManaCrystalAction.IsFailure` (ContainsBuffer) — predicate is failure — Code
- ได้รับการเสริมจากสกิล ไฮแฟมิเรีย (uid 1032): `ManaCrystalAction.IsFailure` (ContainsBuffer) — predicate is failure — Code
- ถูกอ่านโดย คริสตัลเลเซอร์ (uid 1034) ผ่าน `CrystalLaserAction.ActionSkillEvent` (GetSkillLv) — Action Skill Event — Code
- ถูกอ่านโดย คริสตัลเลเซอร์ (uid 1034) ผ่าน `CrystalLaserAction.ActionSkillEvent` (TryGetBuf) — Action Skill Event — Code
- ถูกอ่านโดย คริสตัลเลเซอร์ (uid 1034) ผ่าน `CrystalLaserAction.ActionStart` (TryGetBuf) — CrystalLaserAction: skill start — Code
- ถูกอ่านโดย คริสตัลเลเซอร์ (uid 1034) ผ่าน `CrystalLaserAction.OnEnd` (TryGetBuf) — On End — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.StartCatsDropItem` (GetSkillLv) — Start Cats Drop Item — Code


---

### ไลท์นิ่ง (Lightning) · uid 1027
- ทรี: สกิลจอมเวทย์ · เลเวลสูงสุด: 35 · อาวุธที่ใช้ได้: ไม้เท้า, อุปกรณ์เวท, SubMagictool
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target if class check passes)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **80** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `30 × Lv + HighFamiliaAction.GetLightningPowerUpValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.HighFamilia, 1)) + 400 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- สถานะผิดปกติที่ติดเป้า:
  - อัมพาต โอกาส `3 × Lv` → Lv1 3 · Lv5 15 · Lv10 30
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: ไฮแฟมิเรีย (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล แฟมิเรีย (uid 1025): `LightningAction.IsFailure` (ContainsBuffer) — predicate is failure — Code
- ได้รับการเสริมจากสกิล ไฮแฟมิเรีย (uid 1032): `LightningAction.IsFailure` (ContainsBuffer) — predicate is failure — Code
- ได้รับการเสริมจากสกิล ไฮแฟมิเรีย (uid 1032): `LightningAction.calcPlayerToMobDamage` (GetSkillLv) — LightningAction: player→mob damage template — Code


---

### บลิซซาร์ด (Blizzard) · uid 1028
- ทรี: สกิลจอมเวทย์ · เลเวลสูงสุด: 35 · อาวุธที่ใช้ได้: ไม้เท้า, อุปกรณ์เวท, SubMagictool
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target if class check passes)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **100** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `HighFamiliaAction.GetBlizzardPowerUpValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.HighFamilia, 1)) + 5 × Lv + 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `proration ช่องเวทของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(proration ที่เก็บไว้ตอนร่าย[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- สถานะผิดปกติที่ติดเป้า:
  - แช่แข็ง โอกาส `Lv` → Lv1 1 · Lv5 5 · Lv10 10
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: ไฮแฟมิเรีย (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล แฟมิเรีย (uid 1025): `BlizzardAction.IsFailure` (ContainsBuffer) — predicate is failure — Code
- ได้รับการเสริมจากสกิล ไฮแฟมิเรีย (uid 1032): `BlizzardAction.IsFailure` (ContainsBuffer) — predicate is failure — Code
- ได้รับการเสริมจากสกิล ไฮแฟมิเรีย (uid 1032): `BlizzardAction.OnInitialize` (GetSkillLv) — BlizzardAction: initial values — Code


---

### เมเทโอสตอร์มสไตร์ค (MeteorStrike) · uid 1029
- ทรี: สกิลจอมเวทย์ · เลเวลสูงสุด: 125 · อาวุธที่ใช้ได้: ไม้เท้า, อุปกรณ์เวท, SubMagictool
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target if class check passes)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **300** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `HighFamiliaAction.GetMeteorStrikePowerUpValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.HighFamilia, 1)) + 100 × Lv + 500 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `proration ช่องเวทของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(proration ที่เก็บไว้ตอนร่าย[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- สถานะผิดปกติที่ติดเป้า:
  - ไฟไหม้ โอกาส `5 × Lv + 50` → Lv1 55 · Lv5 75 · Lv10 100
  - มึนงง โอกาส `5 × Lv` → Lv1 5 · Lv5 25 · Lv10 50
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: ไฮแฟมิเรีย (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล แฟมิเรีย (uid 1025): `MeteorStrikeAction.IsFailure` (ContainsBuffer) — predicate is failure — Code
- ได้รับการเสริมจากสกิล ไฮแฟมิเรีย (uid 1032): `MeteorStrikeAction.IsFailure` (ContainsBuffer) — predicate is failure — Code
- ได้รับการเสริมจากสกิล ไฮแฟมิเรีย (uid 1032): `MeteorStrikeAction.OnInitialize` (GetSkillLv) — MeteorStrikeAction: initial values — Code


---

### สโตนสกิล (StoneSkin) · uid 1030
- ทรี: สกิลจอมเวทย์ · เลเวลสูงสุด: 125 · อาวุธที่ใช้ได้: ไม้เท้า, อุปกรณ์เวท, SubMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (คำอธิบาย): จะติดบาเรียลดความเสียหายได้ในระดับหนึ่งแต่ — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `barrier`

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล แฟมิเรีย (uid 1025): `StoneSkinAction.IsFailure` (ContainsBuffer) — predicate is failure — Code
- ได้รับการเสริมจากสกิล ไฮแฟมิเรีย (uid 1032): `StoneSkinAction.IsFailure` (ContainsBuffer) — predicate is failure — Code


---

### อิมพีเรียลเรย์ / อิมพีเรียลบลาสท์ / อิมพีเรียลไฟร์ / อิมพีเรียลฟรีซ / อิมพีเรียลโกลม / อิมพีเรียลเปตรา / อิมพีเรียลโฮลี่ / อิมพีเรียลชาโดว์ (ImperialRay) · uid 1031
- ทรี: สกิลจอมเวทย์ · เลเวลสูงสุด: 205 · อาวุธที่ใช้ได้: ไม้เท้า, อุปกรณ์เวท, SubMagictool
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (never (IsExpDefFluctuate=false))

**ชื่อ/รูปแบบของสกิล (จากข้อความในเกม):** [N] อิมพีเรียลเรย์ · [PN] อิมพีเรียลบลาสท์ · [PF] อิมพีเรียลไฟร์ · [PA] อิมพีเรียลฟรีซ · [PW] อิมพีเรียลโกลม · [PE] อิมพีเรียลเปตรา · [PL] อิมพีเรียลโฮลี่ · [PD] อิมพีเรียลชาโดว์

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), บัพ/มาสเตอรี่/สกิลอื่น
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `20 × Lv + 200` → Lv1 220 · Lv5 300 · Lv10 400
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`50 × Lv + ค่า SkillRate ของมาสเตอรี่ + 500 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] หรือ [`50 × Lv + 500 %` → Lv1 550% · Lv5 750% · Lv10 1000%]

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerBattleManager.PursuitImperialRayAttack` (GetSkillLv) — Pursuit Imperial Ray Attack — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.PursuitImperialRayAttack` (GetSkillLv) — Pursuit Imperial Ray Attack — Code


---

### ไฮแฟมิเรีย (HighFamilia) · uid 1032
- ทรี: สกิลจอมเวทย์ · เลเวลสูงสุด: 205 · อาวุธที่ใช้ได้: ไม้เท้า, อุปกรณ์เวท, SubMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `magicPursuitAttackRate`
- MATK + (`MatkUp`) = `matkUpRate × status.Lv ÷ 100`
- MP สูงสุด + (`MaxMpUp`) = `maxMp`

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล แฟมิเรีย (uid 1025): `HighFamiliaAction.IsFailure` (GetSkillLv) — predicate is failure — Code
- ถูกอ่านโดย บลิซซาร์ด (uid 1028) ผ่าน `BlizzardAction.IsFailure` (ContainsBuffer) — predicate is failure — Code
- ถูกอ่านโดย บลิซซาร์ด (uid 1028) ผ่าน `BlizzardAction.OnInitialize` (GetSkillLv) — BlizzardAction: initial values — Code
- ถูกอ่านโดย คริสตัลเลเซอร์ (uid 1034) ผ่าน `CrystalLaserAction.IsFailure` (ContainsBuffer) — predicate is failure — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `FamiliaActionManager.UpdateHighFamilia` (GetSkillLv) — Update High Familia — Code
- ถูกอ่านโดย ไลท์นิ่ง (uid 1027) ผ่าน `LightningAction.IsFailure` (ContainsBuffer) — predicate is failure — Code
- ถูกอ่านโดย ไลท์นิ่ง (uid 1027) ผ่าน `LightningAction.calcPlayerToMobDamage` (GetSkillLv) — LightningAction: player→mob damage template — Code
- ถูกอ่านโดย มานาคริสตัล (uid 1026) ผ่าน `ManaCrystalAction.IsFailure` (ContainsBuffer) — predicate is failure — Code
- ถูกอ่านโดย เมเทโอสตอร์มสไตร์ค (uid 1029) ผ่าน `MeteorStrikeAction.IsFailure` (ContainsBuffer) — predicate is failure — Code
- ถูกอ่านโดย เมเทโอสตอร์มสไตร์ค (uid 1029) ผ่าน `MeteorStrikeAction.OnInitialize` (GetSkillLv) — MeteorStrikeAction: initial values — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.PursuitAttack` (ContainsBuffer) — Pursuit Attack — Code
- ถูกอ่านโดย สโตนสกิล (uid 1030) ผ่าน `StoneSkinAction.IsFailure` (ContainsBuffer) — predicate is failure — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIFamiliarSelectManager.UpdateRushSwitchButton` (GetSkillLv) — Code


---

### คาสต์มาสเตอรี่ (CastMastery) · uid 1033
- ทรี: สกิลจอมเวทย์ · เลเวลสูงสุด: 15 · อาวุธที่ใช้ได้: ไม้เท้า, MainMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ATK % (`AtkRate`) = **0** คงที่ทุก Lv — Code
- พาสซีฟ/มาสเตอรี่: ความเร็วร่าย + (`Cspd`) = `this.allWizardSkillLevel × Lv` — Code
- พาสซีฟ/มาสเตอรี่: ความเร็วร่าย % (`CspdRate`) = `this.learnWizardSkillNum × (Lv ÷ 2) + Lv` — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### คริสตัลเลเซอร์ (CrystalLaser) · uid 1034
- ทรี: สกิลจอมเวทย์ · เลเวลสูงสุด: 35 · อาวุธที่ใช้ได้: ไม้เท้า, MainMagictool
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, SetConstant) = **200** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, SetRate) `30 × Lv + 700 %` → Lv1 730% · Lv5 850% · Lv10 1000%

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล แฟมิเรีย (uid 1025): `CrystalLaserAction.IsFailure` (ContainsBuffer) — predicate is failure — Code
- ได้รับการเสริมจากสกิล มานาคริสตัล (uid 1026): `CrystalLaserAction.ActionSkillEvent` (GetSkillLv) — Action Skill Event — Code
- ได้รับการเสริมจากสกิล มานาคริสตัล (uid 1026): `CrystalLaserAction.ActionSkillEvent` (TryGetBuf) — Action Skill Event — Code
- ได้รับการเสริมจากสกิล มานาคริสตัล (uid 1026): `CrystalLaserAction.ActionStart` (TryGetBuf) — CrystalLaserAction: skill start — Code
- ได้รับการเสริมจากสกิล มานาคริสตัล (uid 1026): `CrystalLaserAction.OnEnd` (TryGetBuf) — On End — Code
- ได้รับการเสริมจากสกิล ไฮแฟมิเรีย (uid 1032): `CrystalLaserAction.IsFailure` (ContainsBuffer) — predicate is failure — Code


---

### โอเวอร์ลิมิต (OverLimit) · uid 1035
- ทรี: สกิลจอมเวทย์ · เลเวลสูงสุด: 125 · อาวุธที่ใช้ได้: ไม้เท้า, MainMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ความเร็วร่าย + (`CspdUp`) = `ค่า Cspd ของมาสเตอรี่ - 1000`
- ความเร็วร่าย + (`CspdUp`) = **4294966296** คงที่ทุก Lv
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `ค่า Value ของมาสเตอรี่ + Lv`
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) `Lv` → Lv1 1 · Lv5 5 · Lv10 10

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ซอร์ดเซอรีไกด์ (MagicalGuidance) · uid 1036
- ทรี: สกิลจอมเวทย์ · เลเวลสูงสุด: 205 · อาวุธที่ใช้ได้: ไม้เท้า, MainMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ค่าทั่วไป (`Value`) → Lv1 1 · Lv5 5 · Lv10 10 — Code
- พาสซีฟ/มาสเตอรี่: ความเร็วร่าย + (`Cspd`) → Lv1 50 · Lv5 250 · Lv10 500 — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ของที่แมวทำหล่น (CatsDropItem) · uid 1037
- ทรี: สกิลจอมเวทย์ · เลเวลสูงสุด: 285 · อาวุธที่ใช้ได้: ไม้เท้า, MainMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ค่าเปอร์เซ็นต์ (`Percent`) → Lv1 1 · Lv5 25 · Lv10 100 — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### การวิจัยเวทมนตร์ (MagicResearch) · uid 1038
- ทรี: สกิลจอมเวทย์ · เลเวลสูงสุด: 285 · อาวุธที่ใช้ได้: ไม้เท้า, อุปกรณ์เวท, SubMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ความเร็วร่าย + (`Cspd`) → Lv1 1 · Lv5 5 · Lv10 10 — Code
- พาสซีฟ/มาสเตอรี่: ค่าทั่วไป (`Value`) → Lv1 40 · Lv5 200 · Lv10 400 — Code
- พาสซีฟ/มาสเตอรี่: ตัวคูณสกิล (`SkillRate`) → Lv1 20 · Lv5 100 · Lv10 200 — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ชิฟท์ (Shift) · uid 1039
- ทรี: สกิลจอมเวทย์ · เลเวลสูงสุด: 285 · อาวุธที่ใช้ได้: ไม้เท้า, MainMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (คำอธิบาย): ซ่อนตัวในชั้นมิติเพื่อหลบหนีวิกฤต — Text
- ข้อความในเกม (คำอธิบาย): แต่จะอยู่ในสถานะคงกระพันตลอด — Text
- ข้อความในเกม (Lv14): ระหว่างชิฟท์ถ้าหลบหลีกความเสียหายจะได้รับ — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: `MobaPlayerActionManager.BattleReserve`, `MobaPlayerActionManager.Damaged`, `MobaPlayerActionManager.OnActionButton`, `MobaPlayerActionManager.SupportReserve`, `MobaPlayerBattleManager.StartAutoDeviceAttack`, `PlayerActionManager.Damaged`, `PlayerBattleManager.StartAutoDeviceAttack` — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ความเร็วท่าทาง + (`MotionSpeed`) = `motionSpeed`
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `AvoidActionManager.CheckAvoidStart` (ContainsBuffer) — check avoid start — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `BattleManagerBase.BattleEntry` (ContainsBuffer) — Battle Entry — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `BattleManagerBase.SupportEntry` (ContainsBuffer) — Support Entry — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `GuardActionManager.CheckGuardStart` (ContainsBuffer) — check guard start — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.BattleReserve` (ContainsBuffer) — Battle Reserve — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.Damaged` (TryGetBuf) — MobaPlayerActionManager: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.OnActionButton` (ContainsBuffer) — On Action Button — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.SupportReserve` (ContainsBuffer) — Support Reserve — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerBattleManager.StartAutoDeviceAttack` (ContainsBuffer) — Start Auto Device Attack — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.BattleReserve` (ContainsBuffer) — Battle Reserve — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.Damaged` (TryGetBuf) — PlayerActionManager: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.OnActionButton` (ContainsBuffer) — On Action Button — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.SupportReserve` (ContainsBuffer) — Support Reserve — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.StartAutoDeviceAttack` (ContainsBuffer) — Start Auto Device Attack — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `ReceiveSupportResult.OnEventPlayerSupport` (TryGetBuf) — On Event Player Support — Code


---
