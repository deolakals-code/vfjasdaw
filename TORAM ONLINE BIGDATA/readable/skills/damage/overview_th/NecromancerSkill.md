# สกิลเนโครแมนเซอร์ (12 สกิล)

สรุปโดยรวมต่อสกิล: ตัวคูณดาเมจมาจากไหน / แยกอาวุธ / สถานะระหว่างท่า / บัพ / เชื่อมสกิลอื่น. วิธีอ่าน: [ENGINE.md](ENGINE.md)

### เกรฟดิกเกอร์ (GlaiveTigger) · uid 1121
- ทรี: สกิลเนโครแมนเซอร์ · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: ซัมมอนสเกเลตัน (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - ต้านสถานะผิดปกติ (`AbnormalRegist`) = **0** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)
  - ต้านสถานะผิดปกติ (`AbnormalRegist`) = `CountBufferBase.GetParam(this, id)` — เมื่อ (+เงื่อนไขอื่น)
- ข้อความในเกม (Lv14): และความต้านทานต่อสภาวะผิดปกติ — Text
- ข้อความในเกม (Lv14): ความต้านทานต่อสภาวะผิดปกติจะเพิ่มขึ้นตามเลเวลสกิล — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: `MobaPlayerSecondaryStatus.get_AntiVirus` — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ค่าเปอร์เซ็นต์ทั่วไป (`Percent`) `int(0.1 × Lv × Count)` → Lv1 0 · Lv5 0 · Lv10 1 — เมื่อ (+เงื่อนไขอื่น)
- ค่าเปอร์เซ็นต์ทั่วไป (`Percent`) = `CountBufferBase.GetParam(this, id)` — เมื่อ (+เงื่อนไขอื่น)
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `System.Linq.Enumerable.Count<SkillActionBase>(SkillActionManager.get_PlaceSkilList(skillActionManager), GlaiveTiggerBuf.<>, c.<>, 9, __11_0)` — เมื่อ (+เงื่อนไขอื่น)
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `GlaiveTiggerBuf.SetCountValue` (GetSkillLv) — Set Count Value — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `GlaiveTiggerBuf.SetCountValue` (TryGetBuf) — Set Count Value — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerSecondaryStatus.get_AntiVirus` (TryGetBuf) — Anti Virus of MobaPlayerSecondaryStatus — Code
- ถูกอ่านโดย แฟนทอมมิสไซล์ (uid 1123) ผ่าน `PhantomMissileAction.ActionPreparation` (TryGetBuf) — PhantomMissileAction: preparation — Code
- ถูกอ่านโดย แฟนทอมมิสไซล์ (uid 1123) ผ่าน `PhantomMissileAction.IsFailure` (TryGetBuf) — predicate is failure — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.CalcAntiVirus` (TryGetBuf) — calculate anti virus — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.get_AtkMpRecovery` (TryGetBuf) — Atk Mp Recovery of PlayerSecondaryStatus — Code
- ถูกอ่านโดย ซัมมอนสเกเลตัน (uid 1127) ผ่าน `SummonSkeletonAction.ActionPreparation` (TryGetBuf) — SummonSkeletonAction: preparation — Code
- ถูกอ่านโดย ซัมมอนสเกเลตัน (uid 1127) ผ่าน `SummonSkeletonAction.IsFailure` (TryGetBuf) — predicate is failure — Code
- ถูกอ่านโดย ทูม (uid 1122) ผ่าน `TombAction.ActionPreparation` (TryGetBuf) — TombAction: preparation — Code


---

### ทูม (Tomb) · uid 1122
- ทรี: สกิลเนโครแมนเซอร์ · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `30 × Lv` → Lv1 30 · Lv5 150 · Lv10 300 — เมื่อ (+เงื่อนไขอื่น)
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **300** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `10 × Lv + 150 %` → Lv1 160% · Lv5 200% · Lv10 250% — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) = **250%** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `target`: `UnityEngine.GameObject.get_transform(target)`
  - Proration (`ExpRate`, SetRate) `(proration ที่เก็บไว้ตอนร่าย[mobAction] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- สถานะผิดปกติที่ติดเป้า:
  - ล้มคว่ำ โอกาส `System.Math.Min(20 × VIT(ที่ลงเอง) ÷ 50, 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล เกรฟดิกเกอร์ (uid 1121): `TombAction.ActionPreparation` (TryGetBuf) — TombAction: preparation — Code


---

### แฟนทอมมิสไซล์ (PhantomMissile) · uid 1123
- ทรี: สกิลเนโครแมนเซอร์ · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: ไม้เท้า
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **500** คงที่ทุก Lv — เมื่อ targetMagicExp ≠ 0 (+เงื่อนไขอื่น) หรือ targetMagicExp = 0 (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) = **100%** คงที่ทุก Lv — เมื่อ targetMagicExp ≠ 0 (+เงื่อนไขอื่น) หรือ targetMagicExp = 0 (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `10 × Lv + skillRate` เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `20 × Lv + skillRate` เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `30 × Lv + skillRate` เมื่อ targetMagicExp = 0 (+เงื่อนไขอื่น) หรือ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `10 × Lv + 100 %` → Lv1 110% · Lv5 150% · Lv10 200% — เมื่อ targetMagicExp = 0 (+เงื่อนไขอื่น) หรือ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `10 × Lv + skillRate` เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `20 × Lv + skillRate` เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `30 × Lv + skillRate` เมื่อ targetMagicExp = 0 (+เงื่อนไขอื่น) หรือ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `20 × Lv + 100 %` → Lv1 120% · Lv5 200% · Lv10 300% — เมื่อ targetMagicExp = 0 (+เงื่อนไขอื่น) หรือ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `10 × Lv + skillRate` เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `20 × Lv + skillRate` เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `30 × Lv + skillRate` เมื่อ targetMagicExp = 0 (+เงื่อนไขอื่น) หรือ (+เงื่อนไขอื่น)
  - Proration (`ExpRate`, SetRate) `proration ช่องเวทของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ targetMagicExp = 0 (+เงื่อนไขอื่น)
    - ตัวปรับ `target`: `target`
    - ตัวปรับ `target`: `target`
  - Proration (`ExpRate`, SetRate) `targetMagicExp / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ targetMagicExp ≠ 0 (+เงื่อนไขอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล เกรฟดิกเกอร์ (uid 1121): `PhantomMissileAction.ActionPreparation` (TryGetBuf) — PhantomMissileAction: preparation — Code
- ได้รับการเสริมจากสกิล เกรฟดิกเกอร์ (uid 1121): `PhantomMissileAction.IsFailure` (TryGetBuf) — predicate is failure — Code


---

### พลั่วชั้นดี (GoodQualityShovel) · uid 1124
- ทรี: สกิลเนโครแมนเซอร์ · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: ไม้เท้า

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ค่าทั่วไป (`Value`) → Lv1 6 · Lv5 30 · Lv10 60 — Code

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### สกัลเชคเกอร์ (SkullShaker) · uid 1125
- ทรี: สกิลเนโครแมนเซอร์ · เลเวลสูงสุด: 205 · อาวุธที่ใช้ได้: ไม้เท้า, ทวน
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `fixAddDamage` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `skillRate %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `skillRate`: `(WeaponType = 14 ? int(7.5 × Lv) + 25 : int(7.5 × Lv)) × MobBuffBase.GetValue() + skillRate` เมื่อ (+เงื่อนไขอื่น)
- สถานะผิดปกติที่ติดเป้า:
  - มึนงง โอกาส `System.Math.Min(STR(ที่ลงเอง) ÷ 5 + 5 × Lv, 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - สตัน โอกาส `10 × MobBuffBase.GetValue()` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### บลัดสตีล (BloodSteel) · uid 1126
- ทรี: สกิลเนโครแมนเซอร์ · เลเวลสูงสุด: 205 · อาวุธที่ใช้ได้: ไม้เท้า

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `EnemyMobActionManagerBase.SetHyperModeStatus` (TryGetBuf) — Set Hyper Mode Status — Code


---

### ซัมมอนสเกเลตัน (SummonSkeleton) · uid 1127
- ทรี: สกิลเนโครแมนเซอร์ · เลเวลสูงสุด: 205 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องตีปกติ (never (IsExpDefFluctuate=false))

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ตัวคูณสกิล (`SkillRate`, AddRate) `10 × Lv %` → Lv1 10% · Lv5 50% · Lv10 100%

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล เกรฟดิกเกอร์ (uid 1121): `SummonSkeletonAction.ActionPreparation` (TryGetBuf) — SummonSkeletonAction: preparation — Code
- ได้รับการเสริมจากสกิล เกรฟดิกเกอร์ (uid 1121): `SummonSkeletonAction.IsFailure` (TryGetBuf) — predicate is failure — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.HarvestSummonSkeleton` (GetSkillLv) — Harvest Summon Skeleton — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.StartSummonSkeletonBomb` (GetSkillLv) — Start Summon Skeleton Bomb — Code


---

### ฮาร์เวสต์ (Harvest) · uid 1128
- ทรี: สกิลเนโครแมนเซอร์ · เลเวลสูงสุด: 205 · อาวุธที่ใช้ได้: ไม้เท้า

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### เดนเจอร์เชค (DengerShake) · uid 1129
- ทรี: สกิลเนโครแมนเซอร์ · เลเวลสูงสุด: 260 · อาวุธที่ใช้ได้: ไม้เท้า, ทวน
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: สถานะ STR(ที่ลงเอง)
- **ดาเมจหลัก** — isFirst ≠ 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **100** คงที่ทุก Lv — เมื่อ skillRate.Length ≠ 0
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ช่องที่ 1 ของอาร์เรย์ต่อฮิต] `STR(ที่ลงเอง) ÷ 2 + 750 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ skillRate.Length ≠ 0
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ skillRate.Length ≠ 0
    - ตัวปรับ `target`: `target`
  - Proration (`ExpRate`, SetRate) `(proration ที่เก็บไว้ตอนร่าย[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ skillRate.Length ≠ 0
- **ดาเมจหลัก** — attackDir < skillRate.Length และ isFirst = 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **100** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `skillRate[attackDir] %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `target`: `target`
  - Proration (`ExpRate`, SetRate) `(proration ที่เก็บไว้ตอนร่าย[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ท่านี้นับเป็น Guard ของสกิล (IsSkillGuard = 1) — Code · `ActionStart: set IsSkillGuard`
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (คำอธิบาย): ข้างหน้า (พลังสูง), ซ้ายขวา (ลดความเสียหาย), ข้างหลัง (แบ็คสเต็ป) — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ความเร็วท่าทาง + (`MotionSpeed`) = **50** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.RemoveAfterSkillBuf` (TryGetBuf) — Remove After Skill Buf — Code


---

### โซลสตรีม (SoulStream) · uid 1130
- ทรี: สกิลเนโครแมนเซอร์ · เลเวลสูงสุด: 260 · อาวุธที่ใช้ได้: ไม้เท้า
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ INT(ที่ลงเอง), บัพ/มาสเตอรี่/สกิลอื่น
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `45 × Lv + 450` → Lv1 495 · Lv5 675 · Lv10 900
  - ตัวคูณสกิล (`SkillRate`, AddRate) `100 × Lv + INT(ที่ลงเอง) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `skillRate`: `((Count ของบัพ เกรฟดิกเกอร์ * 75) + skillRate)` เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `(((max((status.MaxMp - (PlayerStatusBase.get_GameStatus().localExMp + PlayerStatusBase.get_GameStatus().localMp)), 0) ÷ 100) * 75) + skillRate)` เมื่อ (+เงื่อนไขอื่น)
- สถานะผิดปกติที่ติดเป้า:
  - อ่อนแอ โอกาส [`((((Count ของบัพ เกรฟดิกเกอร์ + (Count ของบัพ เกรฟดิกเกอร์ << 2…(ย่อ)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`(((((max((status.MaxMp - (PlayerStatusBase.get_GameStatus().localExMp + PlayerStatusBase.get_GameStatus().localMp)), 0) ÷ 100) + ((max((status.MaxMp - (PlayerStatusBas…(ย่อ)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ซัมมอนเดโมนิก (SummonDemonic) · uid 1131
- ทรี: สกิลเนโครแมนเซอร์ · เลเวลสูงสุด: 260 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - HP สูงสุด % (`MaxHpUpRate`) = `maxHpRate`

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `summonMp`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `GameManager.ReceiveSummons` (GetSkillLv) — Receive Summons — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MainPlayer.PlayerDead` (ContainsBuffer) — Player Dead — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PhotonListener.OnActionPartyChangeHateActor` (ContainsBuffer) — On Action Party Change Hate Actor — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PhotonListener.OnActionPartyChangeHateMine` (ContainsBuffer) — On Action Party Change Hate Mine — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PhotonListener.OnActionRoomChangeHateActor` (ContainsBuffer) — On Action Room Change Hate Actor — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PhotonListener.OnActionRoomChangeHateMine` (ContainsBuffer) — On Action Room Change Hate Mine — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.Damaged` (ContainsBuffer) — PlayerActionManager: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `ReceiveSupportResult.OnActionPlayerSupport` (TryGetBuf) — On Action Player Support — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `ReceiveSupportResult.OnEventNpcSupport` (TryGetBuf) — On Event Npc Support — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `ReceiveSupportResult.OnEventPlayerSupport` (TryGetBuf) — On Event Player Support — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `SummonDemonicActionManager.BattleReservSpecialAttack` (GetSkillLv) — Battle Reserv Special Attack — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `SummonDemonicActionManager.BattleReserveNormalAttack` (GetSkillLv) — Battle Reserve Normal Attack — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `SummonDemonicAttackAction.ActionHit` (TryGetBuf) — Action Hit — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `SummonDemonicAttackAction.OnInitialize` (TryGetBuf) — SummonDemonicAttackAction: initial values — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `SummonDemonicSpecialAttack.ActionHit` (TryGetBuf) — Action Hit — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `SummonDemonicSpecialAttack.OnInitialize` (TryGetBuf) — SummonDemonicSpecialAttack: initial values — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIExSkillManager.ExSkillList` (GetSkillLv) — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UINecromancerExSkillManager.Initialize` (GetSkillLv) — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UISkillTreeManager.SkillTreeList` (GetSkillLv) — Code


---

### แผนตลบหลัง (MatchPump) · uid 1132
- ทรี: สกิลเนโครแมนเซอร์ · เลเวลสูงสุด: 260 · อาวุธที่ใช้ได้: ไม้เท้า

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---
