# สกิลพลังมืด (12 สกิล)

สรุปโดยรวมต่อสกิล: ตัวคูณดาเมจมาจากไหน / แยกอาวุธ / สถานะระหว่างท่า / บัพ / เชื่อมสกิลอื่น. วิธีอ่าน: [ENGINE.md](ENGINE.md)

### บลัดดี้ไบท์ (BloodBite) · uid 1057
- ทรี: สกิลพลังมืด · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **100** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `10 × Lv + โบนัสคริสตัล#1015[4] + 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### แซครีไฟซ์ (Sacrifice) · uid 1058
- ทรี: สกิลพลังมืด · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (never (IsExpSkill excludes ActionID))

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ตัวคูณสกิล (`SkillRate`, AddRate) `(100 × Lv < 500 ? 100 × Lv : 500) + 500 %` → Lv1 600% · Lv5 1000% · Lv10 1000%
  - Proration (`ExpRate`, AddRate) `(100 - max(target.CutAttack)) / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, SetRate) `100 - 100 × MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90, PlayerActionManagerBase.get_PlayerStatus())) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ดาเมจฐาน (`BaseDamage`, AddConstant) `int(0xd999a × status.MaxHp)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ความเสถียร (`StableRate`, AddRate) [`(PlayerAttackBase.CalcStable(SacrificeAction.get_AttackType(), ((EternalNightmareBuf.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1064], BonusTy…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] หรือ [`100 × PlayerAttackBase.CalcStable(SacrificeAction.get_AttackType(), (Lv = 10 ? 45 : 35) + 5 × (Lv > 5 ? Lv : 5), SkillCalcTemplate.CheckStepResult(PlayerAttackBase.Hit…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)]
  - DamageLimit (`DamageLimit`, SetConstant) `CheckPlayerDamageUpLimit.limitDamage(this, playerAction, mobAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - MinDamage (`MinDamage`, AddConstant) `CheckDamageLimit.min(this, mobAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - MaxDamage (`MaxDamage`, AddConstant) `CheckDamageLimit.max(this, mobAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: เบอร์เซิร์ก (Skill), โซลฮันเตอร์ / เดธรีปเปอร์ (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล เบอร์เซิร์ก (uid 46): `SacrificeAction.ActionStart` (GetSkillLv) — SacrificeAction: skill start — Code
- ได้รับการเสริมจากสกิล เบอร์เซิร์ก (uid 46): `SacrificeAction.StrengthPayHp` (ContainsBuffer) — Strength Pay Hp — Code
- ได้รับการเสริมจากสกิล เรดเทีย (uid 1061): `SacrificeAction.CheckPayHp` (ContainsBuffer) — SacrificeAction: can the HP cost be paid — Code
- ได้รับการเสริมจากสกิล โซลฮันเตอร์ / เดธรีปเปอร์ (uid 1063): `SacrificeAction.CheckPayHp` (GetSkillLv) — SacrificeAction: can the HP cost be paid — Code


---

### ดาร์คสตริงเกอร์ (DarkStinger) · uid 1059
- ทรี: สกิลพลังมืด · เลเวลสูงสุด: 60 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ STR(ที่ลงเอง)/VIT(ที่ลงเอง)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `((int((((10) * PlayerStatusBase.get_GameStatus().serverHp) / 100)) lt 1000 ? int((((10) * PlayerStatusBase.get_GameStatus().serverHp) / 100)) : 1000))` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `30 × Lv + VIT(ที่ลงเอง) + STR(ที่ลงเอง) + 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `skillRate`: `(skillRate + ((int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) - 1000) ÷ (30 - EternalNightmareBuf.GetParam(PlayerStatusBase.get_SkillBuf…(ย่อ)` เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `(skillRate + ((int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) - 1000) ÷ 30))` เมื่อ (+เงื่อนไขอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: โซลฮันเตอร์ / เดธรีปเปอร์ (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - HP สูงสุด % (`MaxHpUpRate`) = `-(maxHp × stack)`

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `stack`
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล โซลฮันเตอร์ / เดธรีปเปอร์ (uid 1063): `DarkStingerAction.ActionStart` (GetSkillLv) — DarkStingerAction: skill start — Code


---

### เดมอนคลอว์ (DemonCrowe) · uid 1060
- ทรี: สกิลพลังมืด · เลเวลสูงสุด: 60 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `40 × Lv` → Lv1 40 · Lv5 200 · Lv10 400
  - ตัวคูณสกิล (`SkillRate`, AddRate) `10 × Lv + 100 %` → Lv1 110% · Lv5 150% · Lv10 200%
    - ตัวปรับ `skillRate`: `(max((skillRate + -100), 0) * ((((((100 - (int(PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus())) - EternalNightmareBuf.GetParam(PlayerStatusBa…(ย่อ)` เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `max(skillRate - 100, 0) × 10 × min(100 - int(PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus())), 90) ÷ 10 / 12` เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `(skillRate * ((((((100 - (int(PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus())) - EternalNightmareBuf.GetParam(PlayerStatusBase.get_SkillBuffe…(ย่อ)` เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `skillRate × 10 × min(100 - int(PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus())), 90) ÷ 10 / 12` เมื่อ (+เงื่อนไขอื่น)
- สถานะผิดปกติที่ติดเป้า:
  - Tiredness โอกาส [`(((((((100 - (int(PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus())) - EternalNightmareBuf.GetParam(PlayerStatusBase.get_SkillBufferManager().s…(ย่อ)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`10 × min(100 - int(PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus())), 90) ÷ 10 ÷ (11 - Lv)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (คำอธิบาย): โจมตีได้สูงสุดถึง 10 ตัวแต่ความเสียหายจะลดลงไป — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### เรดเทีย (RedTear) · uid 1061
- ทรี: สกิลพลังมืด · เลเวลสูงสุด: 120 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ตัวคูณสกิล (`SkillRate`, AddRate) `2 × Lv + 180 %` → Lv1 182% · Lv5 190% · Lv10 200%
  - Proration (`ExpRate`, SetRate) `proration ช่องเวทของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(proration ที่เก็บไว้ตอนร่าย[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย แซครีไฟซ์ (uid 1058) ผ่าน `SacrificeAction.CheckPayHp` (ContainsBuffer) — SacrificeAction: can the HP cost be paid — Code


---

### รีเกรทเลส (Regret) · uid 1062
- ทรี: สกิลพลังมืด · เลเวลสูงสุด: 120 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - HP สูงสุด % (`MaxHpUpRate`) = `-(maxHp × stack)`
  - ลดดาเมจเวทที่ได้รับ (`MagicDmgCut`) = `min(stack, 10) × magic`
  - ลดดาเมจกายภาพที่ได้รับ (`PowerDmgCut`) = `min(stack, 10) × physics`

#### 4) บัพที่ได้จากสกิลนี้
- MP สูงสุด + (`MaxMpUp`) = `min(stack, 10) × maxMp`
- MATK + (`MatkUp`) = `min(stack, 10) × matk`
- ATK + (`AtkUp`) = `min(stack, 10) × atk`
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `stack`
- MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = `min(stack, 10) × atkMpHeal`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.Damaged` (ContainsBuffer) — MobaPlayerActionManager: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.ReceiveDamaged` (ContainsBuffer) — Receive Damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.Damaged` (ContainsBuffer) — PlayerActionManager: on damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.EventDamaged` (ContainsBuffer) — Event Damaged — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.abnormalActionLockCheck` (ContainsBuffer) — abnormal Action Lock Check — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `SuppressionBonusGameManager.<MenuLoadWait>d__21.MoveNext` (ContainsBuffer) — Move Next — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIRezeroFieldPopWindowManager.Start` (ContainsBuffer) — Code


---

### โซลฮันเตอร์ / เดธรีปเปอร์ (SoulHunt_Deathscythe) · uid 1063
- ทรี: สกิลพลังมืด · เลเวลสูงสุด: 180 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องเวท (first_hit_per_target)

**ชื่อ/รูปแบบของสกิล (จากข้อความในเกม):** [N] โซลฮันเตอร์ · [N2] เดธรีปเปอร์

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ VIT(ที่ลงเอง)
- **ดาเมจหลัก** — attackCount ≠ 1 และ attackCount ≠ 2
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `30 × Lv + 100` → Lv1 130 · Lv5 250 · Lv10 400
  - ตัวคูณสกิล (`SkillRate`, AddRate) = **500%** คงที่ทุก Lv
    - ตัวปรับ `secondSkillRate`: `(secondSkillRate + (((VIT(ที่ลงเอง) ÷ 10) + 100) * PlayerStatusBase.get_SkillBufferManager().skillBufList[1063].Count))` เมื่อ (+เงื่อนไขอื่น)
  - Proration (`ExpRate`, SetRate) `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefMagic / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(targetExpList[MobActionManagerBase.get_MobStatus(mobAction).UniqueId] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ดาเมจหลัก** — attackCount = 2
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `30 × Lv + 100` → Lv1 130 · Lv5 250 · Lv10 400
  - ตัวคูณสกิล (`SkillRate`, AddRate) `50 × Lv + 500 %` → Lv1 550% · Lv5 750% · Lv10 1000%
  - Proration (`ExpRate`, SetRate) `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefMagic / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(targetExpList[MobActionManagerBase.get_MobStatus(mobAction).UniqueId] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- สถานะผิดปกติที่ติดเป้า:
  - หวาดกลัว โอกาส `Lv × Lv` → Lv1 1 · Lv5 25 · Lv10 100

#### 3) ระหว่างใช้สกิล
- คงกระพัน (สถานะ Invincibility) ตั้งแต่เริ่มท่า จนถอดตอนจบท่า — เพดาน 1 วินาที — Code · `ActionSkillEvent: AbnormalStateManager$$AddInvincibilityTemporarilyInAction`
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ดาร์คสตริงเกอร์ (uid 1059) ผ่าน `DarkStingerAction.ActionStart` (GetSkillLv) — DarkStingerAction: skill start — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `GameManager.ReceiveActionSupportDelay` (GetSkillLv) — Receive Action Support Delay — Code
- ถูกอ่านโดย ฮีลลิ่งช็อต (uid 677) ผ่าน `HealingShotAction.CheckPayHp` (GetSkillLv) — HealingShotAction: can the HP cost be paid — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `ReceiveSupportResult.OnActionPlayerSupport` (GetSkillLv) — On Action Player Support — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `ReceiveSupportResult.OnEventPlayerSupport` (GetSkillLv) — On Event Player Support — Code
- ถูกอ่านโดย แซครีไฟซ์ (uid 1058) ผ่าน `SacrificeAction.CheckPayHp` (GetSkillLv) — SacrificeAction: can the HP cost be paid — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `SkillComboState.CheckBloody` (GetSkillLv) — check bloody — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `SkillComboState.CheckTenacityCost` (GetSkillLv) — check tenacity cost — Code
- ถูกอ่านโดย สไปรท์ชีลด์ (uid 713) ผ่าน `SpriteShieldAction.CheckPayHp` (GetSkillLv) — SpriteShieldAction: can the HP cost be paid — Code


---

### อีเทอนอลไนท์แมร์ (EternalNightmare) · uid 1064
- ทรี: สกิลพลังมืด · เลเวลสูงสุด: 180 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - HP สูงสุด % (`MaxHpUpRate`) `2 × Lv` → Lv1 2 · Lv5 10 · Lv10 20 — เมื่อ IsSelfAction ≠ 0
  - ReceiveLightElementDmgRate (`ReceiveLightElementDmgRate`) = **4294967291** คงที่ทุก Lv — เมื่อ IsSelfAction ≠ 0
  - ReceiveDarkElementDmgRate (`ReceiveDarkElementDmgRate`) `Lv` → Lv1 1 · Lv5 5 · Lv10 10 — เมื่อ IsSelfAction ≠ 0
- ข้อความในเกม (คำอธิบาย): เพิ่มความต้านทานธาตุมืดในระหว่างการใช้งาน แต่ความต้านทานธาตุแสงลงจะลดลง — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ลด DEF เป้า (`TargetDefDown`) = `min(allDarkPowerSkillLevel × Lv ÷ 2, 400)`
- ลด MDEF เป้า (`TargetMdefDown`) = `min(allDarkPowerSkillLevel × Lv ÷ 2, 400)`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย เนตรมารเพลิงทมิฬ (uid 1067) ผ่าน `BlackFlameEvilEyeAction.ActionPreparation` (GetSkillLv) — BlackFlameEvilEyeAction: preparation — Code
- ถูกอ่านโดย เนตรมารเสน่หา (uid 1066) ผ่าน `EnchantingEvilEyeAction.calcPlayerToMobDamage` (GetSkillLv) — EnchantingEvilEyeAction: player→mob damage template — Code
- ถูกอ่านโดย เนตรมารข่มขวัญ (uid 1065) ผ่าน `IntimidatingEvilEyeAction.ActionPreparation` (GetSkillLv) — IntimidatingEvilEyeAction: preparation — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `ReceiveSupportResult.OnActionPlayerSupport` (GetSkillLv) — On Action Player Support — Code


---

### เนตรมารข่มขวัญ (IntimidatingEvilEye) · uid 1065
- ทรี: สกิลพลังมืด · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `20 × Lv` → Lv1 20 · Lv5 100 · Lv10 200
  - ตัวคูณสกิล (`SkillRate`, AddRate) `Lv %` → Lv1 1% · Lv5 5% · Lv10 10%
- สถานะผิดปกติที่ติดเป้า:
  - ผงะ โอกาส `max(max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.EternalNightmare, 1), 0) + status.Lv - target.Level, 0) × Lv` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ช้า โอกาส = **100** คงที่ทุก Lv
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: อีเทอนอลไนท์แมร์ (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล อีเทอนอลไนท์แมร์ (uid 1064): `IntimidatingEvilEyeAction.ActionPreparation` (GetSkillLv) — IntimidatingEvilEyeAction: preparation — Code


---

### เนตรมารเสน่หา (EnchantingEvilEye) · uid 1066
- ทรี: สกิลพลังมืด · เลเวลสูงสุด: 60 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `min(target.Level × Lv, 10000)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **0** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **0** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `100 × Lv %` → Lv1 100% · Lv5 500% · Lv10 1000% — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `Lv %` → Lv1 1% · Lv5 5% · Lv10 10% — เมื่อ (+เงื่อนไขอื่น)
- สถานะผิดปกติที่ติดเป้า:
  - มนตร์เสน่ห์ โอกาส `Lv × Lv` → Lv1 1 · Lv5 25 · Lv10 100

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (Lv255): ระยะเวลาความต้านทานไม่เปลี่ยนแปลง — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล อีเทอนอลไนท์แมร์ (uid 1064): `EnchantingEvilEyeAction.calcPlayerToMobDamage` (GetSkillLv) — EnchantingEvilEyeAction: player→mob damage template — Code


---

### เนตรมารเพลิงทมิฬ (BlackFlameEvilEye) · uid 1067
- ทรี: สกิลพลังมืด · เลเวลสูงสุด: 120 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **100** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `100 × Lv + 1000 %` → Lv1 1100% · Lv5 1500% · Lv10 2000%
    - ตัวปรับ `skillRate`: `2 × skillRate + 100 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.EternalNightmare, 1)` เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `skillRate + 50 × SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.EternalNightmare, 1)` เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `skillRate`: `2 × skillRate` เมื่อ (+เงื่อนไขอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: อีเทอนอลไนท์แมร์ (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล อีเทอนอลไนท์แมร์ (uid 1064): `BlackFlameEvilEyeAction.ActionPreparation` (GetSkillLv) — BlackFlameEvilEyeAction: preparation — Code


---

### เนตรมารโกลาหล (ChaosEvilEye) · uid 1068
- ทรี: สกิลพลังมืด · เลเวลสูงสุด: 180 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: เวท; ช่อง proration ตั้งใน ctor (expType=2) = ช่องเวท · Proration: Magic (ctor sets expType=2) (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `50 × Lv` → Lv1 50 · Lv5 250 · Lv10 500
  - ตัวคูณสกิล (`SkillRate`, AddRate) `100 × Lv + 500 %` → Lv1 600% · Lv5 1000% · Lv10 1500%
  - ตัวคูณสกิล (`SkillRate`, AddRate) `150 × Lv + 750 %` → Lv1 900% · Lv5 1500% · Lv10 2250% — เมื่อ (target.ExpDefMagic > target.ExpDefSkill และ target.ExpDefMagic ≤ target.ExpDefNormal และ target.ExpDefMagic < target.ExpDefNormal และ target.ExpDefNormal < target.ExpDefSkill (+เงื่อนไขอื่น)) หรือ…
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (isEffectiveAbnormal ≠ 0 และ target.ExpDefMagic > target.ExpDefNormal และ target.ExpDefMagic < target.ExpDefNormal และ target.ExpDefNormal ≤ target.ExpDefSkill และ target.ExpDefNormal < target.ExpD…
  - Proration (`ExpRate`, SetRate) `proration ช่องตีปกติของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (isEffectiveAbnormal ≠ 0 และ target.ExpDefMagic > target.ExpDefNormal และ target.ExpDefMagic < target.ExpDefNormal และ target.ExpDefNormal ≥ target.ExpDefSkill และ target.ExpDefNormal ≤ target.ExpD…
  - Proration (`ExpRate`, SetRate) `proration ช่องเวทของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (isEffectiveAbnormal ≠ 0 และ target.ExpDefMagic ≥ target.ExpDefNormal และ target.ExpDefMagic ≥ target.ExpDefSkill และ target.ExpDefMagic > target.ExpDefNormal และ target.ExpDefNormal ≤ target.ExpDe…

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---
