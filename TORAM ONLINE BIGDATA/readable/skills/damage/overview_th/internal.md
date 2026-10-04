# (internal) (53 สกิล)

สรุปโดยรวมต่อสกิล: ตัวคูณดาเมจมาจากไหน / แยกอาวุธ / สถานะระหว่างท่า / บัพ / เชื่อมสกิลอื่น. วิธีอ่าน: [ENGINE.md](ENGINE.md)

###  (NormalAttackAction) · uid 0
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องตีปกติ (first_hit_per_target if class check passes)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: บัพ/มาสเตอรี่/สกิลอื่น
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `ค่า NormalAttackConstantDamage รวมจากบัพทุกตัว` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `NormalAttackAction.calcRampageConstantDamage(this_tpl(), playerAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `ArkSaber.CalcConstantDamage(playerAction, mobAction) ÷ 2` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `UnannouncedDestination.CalcNormalAttackConstantDamage(PlayerActionManagerBase.get_PlayerStatus())` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ checkUnannouncedDestination ≠ 0 (+เงื่อนไขอื่น)
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `IchijhinnokazeBuf.GetNormalAttackConstantDamage(PlayerActionManagerBase.get_PlayerStatus())` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ checkIchijhinnokaze ≠ 0 และ checkUnannouncedDestination ≠ 0 (+เงื่อนไขอื่น)
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `IchijhinnokazeBuf.GetNormalAttackConstantDamage(PlayerActionManagerBase.get_PlayerStatus())` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ checkIchijhinnokaze ≠ 0 และ checkUnannouncedDestination = 0 (+เงื่อนไขอื่น)
  - ดาเมจคงที่ตีแรก (`FirstAttack`, AddConstant) `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ isUnsheatheMode ≠ 0 (+เงื่อนไขอื่น)
  - ดาเมจคงที่ตีแรก (`FirstAttack`, AddConstant) = **0** คงที่ทุก Lv — เมื่อ isUnsheatheMode = 0 (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `100 × _t1245 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณตีแรก (`FirstAttackRate`, AddRate) `PlayerAttackBase.calcFastAttackDamageRate(playerAction) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ isUnsheatheMode ≠ 0 (+เงื่อนไขอื่น)
  - ตัวคูณตีแรก (`FirstAttackRate`, AddRate) = **100%** คงที่ทุก Lv — เมื่อ isUnsheatheMode = 0 (+เงื่อนไขอื่น)
  - ตัวคูณตีแรก (`FirstAttackRate`, AddRate) `100 × _t1228 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - Proration (`ExpRate`, AddRate) `proration ช่องตีปกติของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, AddRate) `100 × _t1246 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - HitCheck (`HitCheck`, SetCheck) `NormalAttackAction.get_ActionID()` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ดาเมจฐาน (`BaseDamage`, AddConstant) `_t1227` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - หักป้องกันเป้า (`Def`, AddConstant) `-NormalAttackAction.CalcDef(this, playerAction, MobActionManagerBase.get_MobBattleStatus(mobAction))` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ isUnsheatheMode ≠ 0 (+เงื่อนไขอื่น)
  - CriticalCheck (`CriticalCheck`, SetCheck) `-NormalAttackAction.CalcDef(this, playerAction, MobActionManagerBase.get_MobBattleStatus(mobAction))` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ isUnsheatheMode ≠ 0 (+เงื่อนไขอื่น)
  - ตัวคูณคริเพิ่ม (`CriticalRate`, AddRate) `status.CriticalDmg %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ isUnsheatheMode ≠ 0 (+เงื่อนไขอื่น)
  - โบนัสธาตุ (`ElementBonusRate`, AddRate) `PlayerAttackBase.CalcElementBonus(this, PlayerActionManagerBase.get_PlayerStatus(), NormalAttackAction.get_AttackType(), target.Element)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ isUnsheatheMode ≠ 0 (+เงื่อนไขอื่น)
  - ต้านธาตุ (`NormalElementDamageResistRate`, AddRate) `PlayerAttackBase.CalcNormalElementWeaponDamageResistRate(PlayerActionManagerBase.get_PlayerStatus(), mobAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ isUnsheatheMode ≠ 0 (+เงื่อนไขอื่น)
  - power wave ตีปกติ (`NormalAttackPowerWave`, AddRate) = **0** คงที่ทุก Lv — เมื่อ isUnsheatheMode ≠ 0 และ powerWaveEnable ≠ 0 (+เงื่อนไขอื่น)
  - หักป้องกันเป้า (`Def`, AddConstant) `-NormalAttackAction.CalcDef(this, playerAction, MobActionManagerBase.get_MobBattleStatus(mobAction))` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ isUnsheatheMode = 0 (+เงื่อนไขอื่น)
  - CriticalCheck (`CriticalCheck`, SetCheck) `-NormalAttackAction.CalcDef(this, playerAction, MobActionManagerBase.get_MobBattleStatus(mobAction))` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ isUnsheatheMode = 0 (+เงื่อนไขอื่น)
  - ตัวคูณคริเพิ่ม (`CriticalRate`, AddRate) `status.CriticalDmg %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ isUnsheatheMode = 0 (+เงื่อนไขอื่น)
  - โบนัสธาตุ (`ElementBonusRate`, AddRate) `PlayerAttackBase.CalcElementBonus(this, PlayerActionManagerBase.get_PlayerStatus(), NormalAttackAction.get_AttackType(), target.Element)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ isUnsheatheMode = 0 (+เงื่อนไขอื่น)
  - ต้านธาตุ (`NormalElementDamageResistRate`, AddRate) `PlayerAttackBase.CalcNormalElementWeaponDamageResistRate(PlayerActionManagerBase.get_PlayerStatus(), mobAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ isUnsheatheMode = 0 (+เงื่อนไขอื่น)
  - power wave ตีปกติ (`NormalAttackPowerWave`, AddRate) = **0** คงที่ทุก Lv — เมื่อ isUnsheatheMode = 0 และ powerWaveEnable ≠ 0 (+เงื่อนไขอื่น)
  - ตัวคูณคริเพิ่ม (`CriticalRate`, AddRate) = **100%** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)
  - โบนัสธาตุ (`ElementBonusRate`, AddRate) `PlayerAttackBase.CalcElementBonus(this, PlayerActionManagerBase.get_PlayerStatus(), NormalAttackAction.get_AttackType(), target.Element)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ต้านธาตุ (`NormalElementDamageResistRate`, AddRate) `PlayerAttackBase.CalcNormalElementWeaponDamageResistRate(PlayerActionManagerBase.get_PlayerStatus(), mobAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - power wave ตีปกติ (`NormalAttackPowerWave`, AddRate) = **0** คงที่ทุก Lv — เมื่อ powerWaveEnable ≠ 0 (+เงื่อนไขอื่น)
  - ความเสถียร (`StableRate`, AddRate) `100 × PlayerAttackBase.CalcStable(3, status.Stable, _t1226, PlayerActionManagerBase.get_PlayerStatus()) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ต้านตามระยะ (`DistanceResistRate`, AddRate) `PlayerAttackBase.CalcDistanceResistRate(playerAction, mobAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณเจม (`GemDamageRate`, AddRate) `PlayerAttackBase.CalcGemLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus())` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - เพิ่มดาเมจเป้าติดสถานะ (`AbnormalDamageIncreaseRate`, AddRate) `CheckAbnormalDamageIncrease.out2(this, mobAction, PlayerAttackBase.CalcGemLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus()))` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - GuardCheck (`GuardCheck`, SetCheck) `_t1247 × _t1250 / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - GuardPower (`GuardPower`, SetCalcValue) `_t1247` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณล่าสมบัติ (`NormalAttackTreasureHuntLastDamageRate`, AddRate) `BonusManager.GetTreasureHuntLastDmgRateBonus(PlayerStatusBase.get_BonusManager())` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - DamageLimit (`DamageLimit`, SetConstant) `max(int(target.MaxHp / 100), 1)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - MinDamage (`MinDamage`, AddConstant) `CheckDamageLimit.min(this, mobAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - MaxDamage (`MaxDamage`, AddConstant) `CheckDamageLimit.max(this, mobAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสุดท้ายตามอาวุธ (`SpecificWeaponLastDamage`, AddRate) `PlayerAttackBase.GetSpecificWeaponLastDamageRate(playerAction, mobAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: ลับคมลูกศร (Skill), สะเทือนโลกา (Skill), การิวเท็นเซ (Skill), ไนฟ์คอมแบท (Skill), ดูอัลชีลด์ (Skill), รัมเพจ (Skill), คมดาบมายา (Skill), ซามูไรอาร์เชอรี (Skill), นินจาสปิริต (Skill), ชูคุจิ (Skill), สไลด์ดิ้ง (Skill), สตอร์มรีปเปอร์ / ออร์บิทรีปเปอร์ (Skill), แนบพิงภูเขา (Skill), ทวินสตอร์ม (Skill), นุคิอุจิเซ็นโนเซ็น (Skill)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 4) บัพที่ได้จากสกิลนี้
- ความแม่น % (`HitRate`) `Count × Lv` → Lv1 1 · Lv5 5 · Lv10 10
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv
- ตัวคูณตีปกติ % (`NormalAttackRate`) = **400** คงที่ทุก Lv — เมื่อ unannouncedDestination ≠ 0
- ตัวคูณตีปกติ % (`NormalAttackRate`) `5 × Lv` → Lv1 5 · Lv5 25 · Lv10 50 — เมื่อ unannouncedDestination = 0
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) `Lv × Lv ÷ 2` → Lv1 0 · Lv5 12 · Lv10 50
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `damageInvalid`

#### 5) เชื่อมกับสกิลอื่น
- สกิลนี้ใส่บัพของสกิล การิวเท็นเซ (uid 621) — Code


---

###  (PhiloEclailAttackAction) · uid 7
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `10 × Lv + 100` → Lv1 110 · Lv5 150 · Lv10 200
  - ตัวคูณสกิล (`SkillRate`, AddRate) `PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), EquipType.Weapon).Type eq 10 ? (((Lv * 15) + 50) + 50) : ((Lv * 15) + 50) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ดาเมจฐาน (`BaseDamage`, SetConstant) [ดาบมือเดียว] `PlayerAttackBase.calcBaseDamage(playerAction, mobAction, PhiloEclailAttackAction.get_AttackType(), 32768, PlayerAttackBase.checkCriticalPercent(this, PlayerSecondarySt…(ย่อ)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ดาเมจฐาน (`BaseDamage`, SetConstant) [อื่นๆ] `PlayerAttackBase.calcBaseDamage(playerAction, mobAction, PhiloEclailAttackAction.get_AttackType(), 32768 × isDualSword, PlayerAttackBase.checkCriticalPercent(this, Pla…(ย่อ)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ดาเมจฐาน (`BaseDamage`, SetConstant) [ดาบมือเดียว] `PlayerAttackBase.calcBaseDamage(playerAction, mobAction, PhiloEclailAttackAction.get_AttackType(), 32768, PlayerAttackBase.checkCriticalPercent(this, PlayerSecondarySt…(ย่อ)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ดาเมจฐาน (`BaseDamage`, SetConstant) [อื่นๆ] `PlayerAttackBase.calcBaseDamage(playerAction, mobAction, PhiloEclailAttackAction.get_AttackType(), 32768 × isDualSword, PlayerAttackBase.checkCriticalPercent(this, Pla…(ย่อ)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ดาเมจฐาน (`BaseDamage`, SetConstant) [ดาบมือเดียว] `PlayerAttackBase.calcBaseDamage(playerAction, mobAction, PhiloEclailAttackAction.get_AttackType(), 32768, PlayerAttackBase.checkCriticalPercent(this, PlayerSecondarySt…(ย่อ)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ดาเมจฐาน (`BaseDamage`, SetConstant) [อื่นๆ] `PlayerAttackBase.calcBaseDamage(playerAction, mobAction, PhiloEclailAttackAction.get_AttackType(), 32768 × isDualSword, PlayerAttackBase.checkCriticalPercent(this, Pla…(ย่อ)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ดาเมจฐาน (`BaseDamage`, SetConstant) [ดาบมือเดียว] `PlayerAttackBase.calcBaseDamage(playerAction, mobAction, PhiloEclailAttackAction.get_AttackType(), 32768, PlayerAttackBase.checkCriticalPercent(this, PlayerSecondarySt…(ย่อ)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ดาเมจฐาน (`BaseDamage`, SetConstant) [อื่นๆ] `PlayerAttackBase.calcBaseDamage(playerAction, mobAction, PhiloEclailAttackAction.get_AttackType(), 32768 × isDualSword, PlayerAttackBase.checkCriticalPercent(this, Pla…(ย่อ)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (AvoidAction) · uid 8
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (FirstAidAction) · uid 9
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 4) บัพที่ได้จากสกิลนี้
- FirstAidCost (`FirstAidCost`) `100 × Lv + 100` → Lv1 200 · Lv5 600 · Lv10 1100

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (DamageReflectionAction) · uid 10
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (PhysicalPursuitAction) · uid 11
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (never (IsExpSkill excludes ActionID))

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- **ดาเมจหลัก**
  - ตัวคูณสกิล (`SkillRate`, AddRate) `SkillBufferDataBase.GetParam(85) + โบนัสอุปกรณ์ bPhysicalPursuit %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ MobaMode ≠ 0 (+เงื่อนไขอื่น) หรือ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `โบนัสอุปกรณ์ bPhysicalPursuit %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ MobaMode ≠ 0 (+เงื่อนไขอื่น) หรือ (+เงื่อนไขอื่น)
  - GuardPower (`GuardPower`, SetCalcValue) `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ MobaMode ≠ 0 (+เงื่อนไขอื่น) หรือ (+เงื่อนไขอื่น)
  - GuardPower (`GuardPower`, SetCalcValue) = **25** คงที่ทุก Lv — เมื่อ MobaMode ≠ 0 (+เงื่อนไขอื่น) หรือ (+เงื่อนไขอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล ออร่าเบลด (uid 50): `PhysicalPursuitAction.calcPlayerToMobDamage` (TryGetBuf) — PhysicalPursuitAction: player→mob damage template — Code


---

###  (MagicPursuitAction) · uid 12
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (never (IsExpSkill excludes ActionID))

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- **ดาเมจหลัก**
  - ตัวคูณสกิล (`SkillRate`, AddRate) `(โบนัสอุปกรณ์ bMagicPursuit + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().s…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `โบนัสอุปกรณ์ bMagicPursuit + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().se…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `โบนัสอุปกรณ์ bMagicPursuit + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().se…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `โบนัสอุปกรณ์ bMagicPursuit %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `(โบนัสอุปกรณ์ bMagicPursuit + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().s…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `โบนัสอุปกรณ์ bMagicPursuit + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().se…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (PetBlankMpHeel) · uid 13
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (SkillChargeAction) · uid 14
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: ครอสสเฟียร์ (Skill), กลอเรียเทคชอต (Skill)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `chargeValue`
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- สกิลนี้ใส่บัพของสกิล กลอเรียเทคชอต (uid 1155) — Code
- สกิลนี้ใส่บัพของสกิล ครอสสเฟียร์ (uid 76) — Code
- ได้รับการเสริมจากสกิล เวทมนตร์:เมจิกแคนนอน (uid 112): `SkillChargeAction.ReceiveSupport` (TryGetBuf) — Receive Support — Code


---

###  (CronosDrivePursuitAction) · uid 15
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: ไม่มีประเภท (None) · Proration: none (never (ExpType None: no proration slot))

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ INTรวม/STRรวม
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, SetConstant) `25 × Lv + 250` → Lv1 275 · Lv5 375 · Lv10 500 — เมื่อ (IsMagicAttack = 0 และ target.AvoidProbability ≤ 99 และ target.GuardProbability > 99 (+เงื่อนไขอื่น)) หรือ (target.AvoidProbability ≤ 99 และ target.GuardProbability > 99 (+เงื่อนไขอื่น))
  - ตัวคูณสกิล (`SkillRate`, SetRate) [`Lv + INTรวม ÷ 5 + 40 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น) หรือ IsMagicAttack ≠ 0 (+เงื่อนไขอื่น)] หรือ [`Lv + STRรวม ÷ 5 + 40 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น) หรือ IsMagicAttack = 0 (+เงื่อนไขอื่น)] — เมื่อ (IsMagicAttack = 0 และ target.AvoidProbability ≤ 99 และ target.GuardProbability > 99 (+เงื่อนไขอื่น)) หรือ (target.AvoidProbability ≤ 99 และ target.GuardProbability > 99 (+เงื่อนไขอื่น))
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (IsMagicAttack = 0 และ target.AvoidProbability ≤ 99 และ target.GuardProbability > 99 (+เงื่อนไขอื่น)) หรือ (IsMagicAttack = 0 และ target.AvoidProbability ≤ 99 (+เงื่อนไขอื่น))
  - Proration (`ExpRate`, SetRate) `proration ช่องเวทของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (IsMagicAttack ≠ 0 และ target.AvoidProbability ≤ 99 และ target.GuardProbability > 99 (+เงื่อนไขอื่น)) หรือ (IsMagicAttack ≠ 0 และ target.AvoidProbability ≤ 99 (+เงื่อนไขอื่น))
  - GuardPower (`GuardPower`, SetCalcValue) `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (IsMagicAttack = 0 และ target.AvoidProbability ≤ 99 และ target.GuardProbability ≤ 99 (+เงื่อนไขอื่น)) หรือ (target.AvoidProbability ≤ 99 และ target.GuardProbability > 99 (+เงื่อนไขอื่น))
  - GuardPower (`GuardPower`, SetCalcValue) = **25** คงที่ทุก Lv — เมื่อ (IsMagicAttack = 0 และ target.AvoidProbability ≤ 99 และ target.GuardProbability ≤ 99 (+เงื่อนไขอื่น)) หรือ (target.AvoidProbability ≤ 99 และ target.GuardProbability > 99 (+เงื่อนไขอื่น))
- **ดาเมจหลัก** — isGuard ≠ 0
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ IsMagicAttack = 0 และ target.AvoidProbability ≤ 99 และ target.GuardProbability ≤ 99 (+เงื่อนไขอื่น)
  - Proration (`ExpRate`, SetRate) `proration ช่องเวทของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ IsMagicAttack ≠ 0 และ target.AvoidProbability ≤ 99 และ target.GuardProbability ≤ 99 (+เงื่อนไขอื่น)
  - GuardPower (`GuardPower`, SetCalcValue) `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ IsMagicAttack = 0 และ target.AvoidProbability ≤ 99 และ target.GuardProbability ≤ 99 (+เงื่อนไขอื่น)
  - GuardPower (`GuardPower`, SetCalcValue) = **25** คงที่ทุก Lv — เมื่อ IsMagicAttack = 0 และ target.AvoidProbability ≤ 99 และ target.GuardProbability ≤ 99 (+เงื่อนไขอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (BeautiesOfNatureHealAction) · uid 16
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (ComboRelfectionAction) · uid 17
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (MagicEgelAttackAction) · uid 18
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (never (IsExpDefFluctuate=false))

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: สถานะ INTรวม, อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **300** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) [อุปกรณ์เวท | ไม้เท้า] `INTรวม + 50 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [อื่นๆ] = **50%** คงที่ทุก Lv
- สถานะผิดปกติที่ติดเป้า:
  - กระเด็น โอกาส = **100** คงที่ทุก Lv

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (ImperialRayPursuitAction) · uid 19
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (never (IsExpDefFluctuate=false))

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), บัพ/มาสเตอรี่/สกิลอื่น
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `10 × Lv + 300` → Lv1 310 · Lv5 350 · Lv10 400
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`150 × Lv + ค่า Value ของมาสเตอรี่ + 500 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)] หรือ [`150 × Lv + 500 %` → Lv1 650% · Lv5 1250% · Lv10 2000%]
- สถานะผิดปกติที่ติดเป้า:
  - ล่มสลาย โอกาส = **100** คงที่ทุก Lv

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (ShadowWalkAttackAction) · uid 20
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target if class check passes)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, SetConstant) = **100** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น) หรือ target.AvoidProbability ≤ 99 (+เงื่อนไขอื่น)
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น) หรือ target.AvoidProbability ≤ 99 (+เงื่อนไขอื่น)
- **ดาเมจหลัก** — isCounter ≠ 0
  - ตัวคูณสกิล (`SkillRate`, SetRate) [`200 × Lv + 1000 %` → Lv1 1200% · Lv5 2000% · Lv10 3000% — เมื่อ (MobaMode ≠ 0 และ isCounter ≠ 0 (+เงื่อนไขอื่น)) หรือ isCounter ≠ 0 (+เงื่อนไขอื่น)] หรือ [`int(frintp((0.1 × Lv + 1) × min(weaponItem.Function, 300) - 0.5)) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ isCounter = 0 (+เงื่อนไขอื่น)] หรือ [`int(floor((0.1 × Lv + 1) × min(weaponItem.Function, 300) + 0.5)) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ isCounter = 0 (+เงื่อนไขอื่น)] — เมื่อ (target.AvoidProbability > 99 และ target.GuardProbability ≤ 99 (+เงื่อนไขอื่น)) หรือ target.AvoidProbability ≤ 99 (+เงื่อนไขอื่น)
- **ดาเมจหลัก** — isCounter = 0
  - ตัวคูณสกิล (`SkillRate`, SetRate) [`200 × Lv + 1000 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (MobaMode ≠ 0 และ isCounter ≠ 0 (+เงื่อนไขอื่น)) หรือ isCounter ≠ 0 (+เงื่อนไขอื่น)] หรือ [`int(frintp((0.1 × Lv + 1) × min(weaponItem.Function, 300) - 0.5)) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (MobaMode ≠ 0 และ isCounter ≠ 0 (+เงื่อนไขอื่น)) หรือ isCounter ≠ 0 (+เงื่อนไขอื่น); isCounter = 0 (+เงื่อนไขอื่น)] หรือ [`int(floor((0.1 × Lv + 1) × min(weaponItem.Function, 300) + 0.5)) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (MobaMode ≠ 0 และ isCounter ≠ 0 (+เงื่อนไขอื่น)) หรือ isCounter ≠ 0 (+เงื่อนไขอื่น); isCounter = 0 (+เงื่อนไขอื่น)] หรือ [`(attackCount - 1) × (int(frintp((0.1 × Lv + 1) × min(weaponItem.Function, 300) - 0.5)) ÷ 4) + 200 × Lv + 1000 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ isCounter = 0 (+เงื่อนไขอื่น); (MobaMode ≠ 0 และ isCounter ≠ 0 (+เงื่อนไขอื่น)) หรือ isCounter ≠ 0 (+เงื่อนไขอื่น)] หรือ [`(attackCount - 1) × ((int(frintp((0.1 × Lv + 1) × min(weaponItem.Function, 300) - 0.5))) ÷ 4) + (int(frintp((0.1 × Lv + 1) × min(weaponItem.Function, 300) - 0.5))) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ isCounter = 0 (+เงื่อนไขอื่น)] หรือ [`(attackCount - 1) × (int(frintp(((0.1 × Lv + 1) × min(weaponItem.Function, 300)) - 0.5)) ÷ 4) + int(floor(((0.1 × Lv + 1) × min(weaponItem.Function, 300)) + 0.5)) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ isCounter = 0 (+เงื่อนไขอื่น)] — เมื่อ (+เงื่อนไขอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (MagicFinawPursuitAction) · uid 21
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- **ดาเมจหลัก**
  - Proration (`ExpRate`, SetRate) `proration ช่องเวทของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(proration ที่เก็บไว้ตอนร่าย[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ดาเมจหลัก** — damageCount < skillRate.Length
  - ตัวคูณสกิล (`SkillRate`, AddRate) `(skillRate[damageCount]) * 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `damageCount`: `damageCount + 1`
- **ดาเมจหลัก** — damageCount < fixAddDamage.Length และ damageCount < skillRate.Length
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `fixAddDamage[damageCount]` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `damageCount`: `damageCount + 1`

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (HolyLightPursuitAction) · uid 22
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ INTรวม
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **200** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`15 × Lv + 100 %` → Lv1 115% · Lv5 175% · Lv10 250%] หรือ [`15 × Lv + 2 × INTรวม + 200 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)]

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (BonusNormalDamageAction) · uid 25
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: ธรรมดา (SkillNormal) · Proration: ช่องตีปกติ (never (IsExpSkill excludes ActionID))

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- **ดาเมจหลัก**
  - ตัวคูณสกิล (`SkillRate`, AddRate) `param %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ MobaMode ≠ 0 (+เงื่อนไขอื่น) หรือ (+เงื่อนไขอื่น)
  - GuardPower (`GuardPower`, SetCalcValue) `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - GuardPower (`GuardPower`, SetCalcValue) = **25** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (BonusPhysicalDamageAction) · uid 26
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (never (IsExpSkill excludes ActionID))

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- **ดาเมจหลัก**
  - ตัวคูณสกิล (`SkillRate`, AddRate) `param %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ MobaMode ≠ 0 (+เงื่อนไขอื่น) หรือ (+เงื่อนไขอื่น)
  - GuardPower (`GuardPower`, SetCalcValue) `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - GuardPower (`GuardPower`, SetCalcValue) = **25** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (BonusMagicDamageAction) · uid 27
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (never (IsExpSkill excludes ActionID))

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- **ดาเมจหลัก**
  - ตัวคูณสกิล (`SkillRate`, AddRate) `param %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ MobaMode ≠ 0 (+เงื่อนไขอื่น) หรือ (+เงื่อนไขอื่น)
  - GuardPower (`GuardPower`, SetCalcValue) `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - GuardPower (`GuardPower`, SetCalcValue) = **25** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (BonusNaturalDamageAction) · uid 28
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: ธรรมดา (SkillNormal) · Proration: ช่องตีปกติ (never (IsExpSkill excludes ActionID))

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- **ดาเมจหลัก**
  - ตัวคูณสกิล (`SkillRate`, AddRate) `param %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ MobaMode ≠ 0 (+เงื่อนไขอื่น) หรือ (+เงื่อนไขอื่น)
  - Proration (`ExpRate`, SetRate) = **1** คงที่ทุก Lv — เมื่อ MobaMode ≠ 0 (+เงื่อนไขอื่น) หรือ (+เงื่อนไขอื่น)
  - GuardPower (`GuardPower`, SetCalcValue) `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - GuardPower (`GuardPower`, SetCalcValue) = **25** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (MoonSlashPursuitAction) · uid 63
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (never (IsExpDefFluctuate=false))

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ INT(ที่ลงเอง)/STRรวม
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `INT(ที่ลงเอง)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `0.1 × STRรวม × Lv %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (JumpbackShotPursuitAction) · uid 95
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (never (IsExpDefFluctuate=false))

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ DEXรวม
- **ดาเมจหลัก**
  - ตัวคูณสกิล (`SkillRate`, AddRate) `min(0.01 × Lv × DEXรวม × count + 100, 500) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `count`: `count`

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (AshuraAuraAttackAction) · uid 157
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (never (IsExpDefFluctuate=false))

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ AGI(ที่ลงเอง), อาวุธหลัก/รองที่ถือ, บัพ/มาสเตอรี่/สกิลอื่น
- **ดาเมจหลัก**
  - ดาเมจคงที่จากบัพ (`BufferConstantDamage`, SetConstant) = **0** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) [สนับมือ] `((AGI(ที่ลงเอง) ÷ (12 - Lv) + 100) < 0 ? AGI(ที่ลงเอง) ÷ (12 - Lv) + 101 : (AGI(ที่ลงเอง) ÷ (12 - Lv) + 100)) ÷ 2 + 45 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [อื่นๆ] `((AGI(ที่ลงเอง) ÷ (12 - Lv) + 100) < 0 ? AGI(ที่ลงเอง) ÷ (12 - Lv) + 101 : (AGI(ที่ลงเอง) ÷ (12 - Lv) + 100)) ÷ 2 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, SetRate) = **100%** คงที่ทุก Lv

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล อาชูร่าออร่า (uid 145): `AshuraAuraAttackAction.OnInitialize` (TryGetBuf) — AshuraAuraAttackAction: initial values — Code


---

###  (MindimageSenjuSupportAction) · uid 158
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: เทพลมกรด (Skill), แม็กซ์ไมเซอร์ (Skill), แอบสแตรกต์อาร์ม (Skill)

#### 3) ระหว่างใช้สกิล
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - (`MobLastDamageRate*` เข้าสูตรดาเมจที่มอนทำใส่ผู้เล่นใน `MobAttackBase.CalcLastDamage` — ค่านี้คือส่วนลดดาเมจที่ได้รับ; หน่วยและการรวมกับบัพอื่นยังไม่ยืนยัน — Inferred)
  - ลดดาเมจฐาน (`BaseDamageCut`) = `baseDamageCut`
  - ตัวคูณดาเมจที่ได้รับจากมอน (หมวดซัพพอร์ต) (`MobLastDamageRateSupport`) = `baseDamageCutRate`
  - MDEF + (`Mdef`) = `-def`
  - DEF + (`Def`) = `-def`

#### 4) บัพที่ได้จากสกิลนี้
- MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = `attckMpRecovery`
- CrtDamageUpRate (`CrtDamageUpRate`) = `-criticalDamageRate`
- อัตราคริ + (`CrtUp`) = `critical`
- BaseEqAtkUpRate (`BaseEqAtkUpRate`) `5 × Lv` → Lv1 5 · Lv5 25 · Lv10 50 — เมื่อ isMainKnuckleEquip ≠ 0
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) `int(2.5 × Lv)` → Lv1 2 · Lv5 12 · Lv10 25 — เมื่อ isMainKnuckleEquip ≠ 0
- ความเสถียร (`Stable`) = `isMainKnuckleEquip = 0 ? 0 : 0xfffffff6`
- ความเร็วโจมตี + (`Aspd`) `50 × Lv` → Lv1 50 · Lv5 250 · Lv10 500
- ความเร็วโจมตี % (`AspdRate`) = `[(0x165d9d4(meta(0x3972658, int[]_TypeInfo), 10) + ((Lv - 1) << 2))+0x20]`
- ATK % (`AtkUpRate`) = `(equip = 11 ? 5 : 0) + Lv`
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- สกิลนี้ใส่บัพของสกิล วิธีการหายใจ (uid 1154) — Code
- สกิลนี้ใส่บัพของสกิล เทพลมกรด (uid 974) — Code
- สกิลนี้ใส่บัพของสกิล โฮลี่ไบเบิ้ล (uid 843) — Code
- สกิลนี้ใส่บัพของสกิล การ์เดียน (uid 265) — Code
- สกิลนี้ใส่บัพของสกิล ชาร์จ MP (uid 101) — Code
- ได้รับการเสริมจากสกิล แม็กซ์ไมเซอร์ (uid 110): `MindimageSenjuSupportAction.ActionSkillEvent` (GetSkillLv) — Action Skill Event — Code
- ได้รับการเสริมจากสกิล โฮลี่ไบเบิ้ล (uid 843): `MindimageSenjuSupportAction.ActionHit` (TryGetBuf) — Action Hit — Code


---

###  (MindimageSenjuAttackAction) · uid 159
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: ได้ประเภทจากสกิลแม่; Exorcism = เวท, Nemesis = กายภาพ · Proration: expType = parent action ExpType (vtable slot 7), unchanged by Exorcism/Nemesis (custom_check + class check)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [ช่องที่ 1 ของอาร์เรย์ต่อฮิต] `fixAddDamage[0]` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (IsInheritance ≠ 0 และ abnormalType ≠ 0 และ fixAddDamage.Length ≠ 0 และ skillRate.Length ≠ 0 (+เงื่อนไขอื่น)) หรือ (IsInheritance ≠ 0 และ fixAddDamage.Length ≠ 0 และ skillRate.Length ≠ 0 (+เงื่อนไข…
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ช่องที่ 1 ของอาร์เรย์ต่อฮิต] `skillRate[0] %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ IsInheritance ≠ 0 และ fixAddDamage.Length = 0 และ skillRate.Length ≠ 0 (+เงื่อนไขอื่น)
- **CalcDamageChariot**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [ช่องที่ 1 ของอาร์เรย์ต่อฮิต] `fixAddDamage[0]` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (fixAddDamage.Length ≠ 0 และ skillRate.Length ≠ 0) หรือ (fixAddDamage.Length ≠ 0 และ skillRate.Length ≠ 0 (+เงื่อนไขอื่น))
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ช่องที่ 1 ของอาร์เรย์ต่อฮิต] `skillRate[0] %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (fixAddDamage.Length ≠ 0 และ skillRate.Length ≠ 0 (+เงื่อนไขอื่น)) หรือ skillRate.Length ≠ 0
- **CalcDamageExorcism**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `(target.Element eq 6 ? (fixAddDamage[0] + 100) : fixAddDamage[0])` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ fixAddDamage.Length ≠ 0 และ skillRate.Length ≠ 0
    - ตัวปรับ `target`: `target`
  - ตัวคูณสกิล (`SkillRate`, AddRate) `target.Element eq 6 ? (skillRate[0] + 400) : skillRate[0] %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ fixAddDamage.Length ≠ 0 และ skillRate.Length ≠ 0
    - ตัวปรับ `target`: `target`
- **CalcDamageNemesis** — isFirst ≠ 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [ช่องที่ 1 ของอาร์เรย์ต่อฮิต] `fixAddDamage[0]` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ fixAddDamage.Length ≠ 0 และ skillRate.Length ≠ 0
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ช่องที่ 1 ของอาร์เรย์ต่อฮิต] `skillRate[0] %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ skillRate.Length ≠ 0
- **CalcDamageNemesis** — isFirst = 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [ช่องที่ 2 ของอาร์เรย์ต่อฮิต] `fixAddDamage[1]` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ fixAddDamage.Length > 1 และ skillRate.Length > 1 (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ช่องที่ 2 ของอาร์เรย์ต่อฮิต] `skillRate[1] %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (fixAddDamage.Length > 1 และ skillRate.Length > 1 (+เงื่อนไขอื่น)) หรือ skillRate.Length > 1 (+เงื่อนไขอื่น)
- **CalcDamageNemesis** — criticalAttackCount = -1 และ criticalAttackCount ≥ 1 และ isFirst = 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [ช่องที่ 2 ของอาร์เรย์ต่อฮิต] `fixAddDamage[1]` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ fixAddDamage.Length > 1 และ skillRate.Length > 1 (+เงื่อนไขอื่น)
- **CalcDamageGeoImpact**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [ช่องที่ 1 ของอาร์เรย์ต่อฮิต] `fixAddDamage[0]` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ fixAddDamage.Length ≠ 0 และ skillRate.Length ≠ 0
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ช่องที่ 1 ของอาร์เรย์ต่อฮิต] `(skillRate[0] * 0.01) * 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (fixAddDamage.Length ≠ 0 และ skillRate.Length ≠ 0 (+เงื่อนไขอื่น)) หรือ skillRate.Length ≠ 0 (+เงื่อนไขอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: แอบสแตรกต์อาร์ม (Skill)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- สกิลนี้ใส่บัพของสกิล ก็อดแฮนด์ (uid 1158) — Code
- ได้รับการเสริมจากสกิล เนเมซิส (uid 844): `MindimageSenjuAttackAction.ActionStart` (ContainsBuffer) — MindimageSenjuAttackAction: skill start — Code
- ได้รับการเสริมจากสกิล ก็อดแฮนด์ (uid 1158): `MindimageSenjuAttackAction.ActionHit` (TryGetBuf) — Action Hit — Code
- ได้รับการเสริมจากสกิล ผู้ทำลายล้าง (uid 1159): `MindimageSenjuAttackAction.CalcDamageGeoImpact` (ContainsBuffer) — calculate damage geo impact — Code


---

###  (CrazyDaggerPursuitAction) · uid 319
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: ธรรมดา (SkillNormal) · Proration: ช่องตีปกติ (never (IsExpDefFluctuate=false))

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: สถานะ DEX(ที่ลงเอง), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มีด + มือรองที่ไม่ใช่ มีด] [`50 × SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301), SkillBufferId.Count) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [= **50%** คงที่ทุก Lv]
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มีด + มือรอง มีด] [`System.Math.Min(((GetSubWeaponType.item(actarAction).Function ÷ ((mul64(DEX(ที่ลงเอง), 0xae147ae1) >> 37) + 15)) + 50), 100) * SkillBufferDataBase.GetParam(TryGetBuf.b…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`System.Math.Min(((GetSubWeaponType.item(actarAction).Function ÷ ((mul64(DEX(ที่ลงเอง), 0xae147ae1) >> 37) + 15)) + 50), 100) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)]
  - ตัวคูณสกิล (`SkillRate`, AddRate) [อื่นๆ + มือรองที่ไม่ใช่ มีด] [`100 × SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301), SkillBufferId.Count) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [= **100%** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)] หรือ [`50 × SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301), SkillBufferId.Count) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [= **50%** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)]
  - ตัวคูณสกิล (`SkillRate`, AddRate) [อื่นๆ + มือรอง มีด] [`(System.Math.Min(((GetSubWeaponType.item(actarAction).Function ÷ ((mul64(DEX(ที่ลงเอง), 0xae147ae1) >> 37) + 15)) + 50), 100) + 50) * SkillBufferDataBase.GetParam(TryG…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`System.Math.Min(((GetSubWeaponType.item(actarAction).Function ÷ ((mul64(DEX(ที่ลงเอง), 0xae147ae1) >> 37) + 15)) + 50), 100) + 50 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`System.Math.Min(((GetSubWeaponType.item(actarAction).Function ÷ ((mul64(DEX(ที่ลงเอง), 0xae147ae1) >> 37) + 15)) + 50), 100) * SkillBufferDataBase.GetParam(TryGetBuf.b…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`System.Math.Min(((GetSubWeaponType.item(actarAction).Function ÷ ((mul64(DEX(ที่ลงเอง), 0xae147ae1) >> 37) + 15)) + 50), 100) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล เครซี่แดกเกอร์ (uid 301): `CrazyDaggerPursuitAction.OnInitialize` (TryGetBuf) — CrazyDaggerPursuitAction: initial values — Code


---

###  (IchijhinnokazeAttackAction) · uid 637
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: กายภาพ; ท่า Kariwatashi/Hibari/Ibuki/Arahae เป็นธรรมดา · Proration: dynamic (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ท่า Nagi**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [= **300** คงที่ทุก Lv — เมื่อ skillRates.Length ≠ 0] หรือ [= **300** คงที่ทุก Lv — เมื่อ skillRates.Length > 1] หรือ [= **300** คงที่ทุก Lv — เมื่อ skillRates.Length > 2] หรือ [= **300** คงที่ทุก Lv — เมื่อ skillRates.Length > 3] หรือ [= **300** คงที่ทุก Lv — เมื่อ skillRates.Length > 4] — เมื่อ skillRates.Length ≠ 0
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ช่องที่ 1 ของอาร์เรย์ต่อฮิต] `50 × Lv + IchijhinnokazeAratame.GetNagiBonus(PlayerActionManagerBase.get_PlayerStatus()) + 500 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ skillRates.Length ≠ 0
- **ท่า Kariwatashi**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [= **300** คงที่ทุก Lv — เมื่อ skillRates.Length ≠ 0] หรือ [= **300** คงที่ทุก Lv — เมื่อ skillRates.Length > 1] หรือ [= **300** คงที่ทุก Lv — เมื่อ skillRates.Length > 2] หรือ [= **300** คงที่ทุก Lv — เมื่อ skillRates.Length > 3] หรือ [= **300** คงที่ทุก Lv — เมื่อ skillRates.Length > 4] — เมื่อ skillRates.Length > 1
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ช่องที่ 2 ของอาร์เรย์ต่อฮิต] [`IchijhinnokazeBuf.GetKariwatashiBonus((PlayerActionManagerBase.get_PlayerStatus())) + 20 × Lv + IchijhinnokazeAratame.GetKariwatashiBonus((PlayerActionManagerBase.get_…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ skillRates.Length > 1] หรือ [`IchijhinnokazeBuf.GetKariwatashiBonus(PlayerActionManagerBase.get_PlayerStatus()) + 20 × Lv + 400 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ skillRates.Length > 1 และ skillRates.Length ≤ 1] — เมื่อ skillRates.Length > 1
    - ตัวปรับ `skillRates[1]`: `(skillRates[1] + 1200)` เมื่อ skillRates.Length > 1
- **ท่า Hibari**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [= **300** คงที่ทุก Lv — เมื่อ skillRates.Length ≠ 0] หรือ [= **300** คงที่ทุก Lv — เมื่อ skillRates.Length > 1] หรือ [= **300** คงที่ทุก Lv — เมื่อ skillRates.Length > 2] หรือ [= **300** คงที่ทุก Lv — เมื่อ skillRates.Length > 3] หรือ [= **300** คงที่ทุก Lv — เมื่อ skillRates.Length > 4] — เมื่อ skillRates.Length > 2
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ช่องที่ 3 ของอาร์เรย์ต่อฮิต] [`IchijhinnokazeBuf.GetHibariBonus((PlayerActionManagerBase.get_PlayerStatus())) + 30 × Lv + IchijhinnokazeAratame.GetHibariBonus((PlayerActionManagerBase.get_PlayerStat…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ skillRates.Length > 2] หรือ [`IchijhinnokazeBuf.GetHibariBonus(PlayerActionManagerBase.get_PlayerStatus()) + 30 × Lv + 600 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ skillRates.Length > 2 และ skillRates.Length ≤ 2] — เมื่อ skillRates.Length > 2
    - ตัวปรับ `skillRates[2]`: `(skillRates[2] + 1550)` เมื่อ skillRates.Length > 1 และ skillRates.Length > 3 และ skillRates.Length ≠ 4
- **ท่า Ibuki**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [= **300** คงที่ทุก Lv — เมื่อ skillRates.Length ≠ 0] หรือ [= **300** คงที่ทุก Lv — เมื่อ skillRates.Length > 1] หรือ [= **300** คงที่ทุก Lv — เมื่อ skillRates.Length > 2] หรือ [= **300** คงที่ทุก Lv — เมื่อ skillRates.Length > 3] หรือ [= **300** คงที่ทุก Lv — เมื่อ skillRates.Length > 4] — เมื่อ skillRates.Length > 3
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ช่องที่ 4 ของอาร์เรย์ต่อฮิต] [`IchijhinnokazeBuf.GetIbukiBonus((PlayerActionManagerBase.get_PlayerStatus())) + 60 × Lv + IchijhinnokazeAratame.GetIbukiBonus((PlayerActionManagerBase.get_PlayerStatus…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ skillRates.Length > 3] หรือ [`IchijhinnokazeBuf.GetIbukiBonus(PlayerActionManagerBase.get_PlayerStatus()) + 60 × Lv + 300 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ skillRates.Length > 3 และ skillRates.Length ≤ 3] — เมื่อ skillRates.Length > 3
    - ตัวปรับ `skillRates[3]`: `(skillRates[3] + 1450)` เมื่อ skillRates.Length > 1 และ skillRates.Length > 3
- **ท่า Arahae**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [= **300** คงที่ทุก Lv — เมื่อ skillRates.Length ≠ 0] หรือ [= **300** คงที่ทุก Lv — เมื่อ skillRates.Length > 1] หรือ [= **300** คงที่ทุก Lv — เมื่อ skillRates.Length > 2] หรือ [= **300** คงที่ทุก Lv — เมื่อ skillRates.Length > 3] หรือ [= **300** คงที่ทุก Lv — เมื่อ skillRates.Length > 4] — เมื่อ skillRates.Length > 4
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ช่องที่ 5 ของอาร์เรย์ต่อฮิต] [`IchijhinnokazeBuf.GetArahaeBonus((PlayerActionManagerBase.get_PlayerStatus())) + 20 × Lv + IchijhinnokazeAratame.GetArahaeBonus((PlayerActionManagerBase.get_PlayerStat…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ skillRates.Length > 4] หรือ [`IchijhinnokazeBuf.GetArahaeBonus(PlayerActionManagerBase.get_PlayerStatus()) + 20 × Lv + 500 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ skillRates.Length > 4 และ skillRates.Length ≤ 4] — เมื่อ skillRates.Length > 4
    - ตัวปรับ `skillRates[4]`: `(skillRates[4] + 1350)` เมื่อ skillRates.Length > 1 และ skillRates.Length > 3 และ skillRates.Length ≠ 4
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: การิวเท็นเซ (Skill), ชูคุจิ (Skill), ไคริกิรันชิน (Skill)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- สกิลนี้ใส่บัพของสกิล การิวเท็นเซ (uid 621) — Code
- ได้รับการเสริมจากสกิล ชูคุจิ (uid 619): `IchijhinnokazeAttackAction.ActionPreparation` (GetSkillLv) — IchijhinnokazeAttackAction: preparation — Code
- ได้รับการเสริมจากสกิล ไคริกิรันชิน (uid 622): `IchijhinnokazeAttackAction.ActionPreparation` (GetSkillLv) — IchijhinnokazeAttackAction: preparation — Code
- ได้รับการเสริมจากสกิล นุคิอุจิเซ็นโนเซ็น (uid 626): `IchijhinnokazeAttackAction.CheckSetunakenran` (GetSkillLv) — check setunakenran — Code
- ได้รับการเสริมจากสกิล นุคิอุจิเซ็นโนเซ็น (uid 626): `IchijhinnokazeAttackAction.CheckSetunakenran` (TryGetBuf) — check setunakenran — Code
- ได้รับการเสริมจากสกิล ลมกระโชก / ลมสงบนิ่ง / ลมเหนือ / ลมตะวันออก / ลมตะวันตก / ลมใต้ / สี่ฤดูกาล (uid 629): `IchijhinnokazeAttackAction.CheckSetunakenran` (TryGetBuf) — check setunakenran — Code


---

###  (TenjhoTengeMusouSwordAction) · uid 638
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `500 × (AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), AbnormalType.Breaking) ? 2 : 1)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ดาเมจคงที่ตีแรก (`FirstAttack`, AddConstant) `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Function + 3000 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [= **3500%** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)]
  - ตัวคูณตีแรก (`FirstAttackRate`, AddRate) `PlayerAttackBase.calcFastAttackDamageRate(playerAction) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: ไคริกิรันชิน (Skill)

#### 3) ระหว่างใช้สกิล
- คงกระพันตามช่วงของแอนิเมชันท่า (motion) จนกว่าท่าจบ — Code · `ActionSkillEvent: AbnormalStateManager$$AddMotionInvincibility`

#### 4) บัพที่ได้จากสกิลนี้
- ATK + (`AtkUp`) = `atk`
- ตัวคูณตีปกติ % (`NormalAttackRate`) = `normalAttackRate`
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `registBreak`
- MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = `atkMpHeal`

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล การิวเท็นเซ (uid 621): `TenjhoTengeMusouSwordAction.ActionStart` (TryGetBuf) — TenjhoTengeMusouSwordAction: skill start — Code
- ได้รับการเสริมจากสกิล การิวเท็นเซ (uid 621): `TenjhoTengeMusouSwordAction.CheckActive` (GetSkillLv) — check active — Code
- ได้รับการเสริมจากสกิล การิวเท็นเซ (uid 621): `TenjhoTengeMusouSwordAction.CheckActive` (TryGetBuf) — check active — Code
- ได้รับการเสริมจากสกิล ไคริกิรันชิน (uid 622): `TenjhoTengeMusouSwordAction.ActionPreparation` (GetSkillLv) — TenjhoTengeMusouSwordAction: preparation — Code
- ได้รับการเสริมจากสกิล ไคริกิรันชิน (uid 622): `TenjhoTengeMusouSwordAction.ActionPreparation` (TryGetBuf) — TenjhoTengeMusouSwordAction: preparation — Code
- ได้รับการเสริมจากสกิล ชาโดว์เลสสแลช (uid 625): `TenjhoTengeMusouSwordAction.CheckActive` (GetSkillLv) — check active — Code
- ได้รับการเสริมจากสกิล ลมกระโชก / ลมสงบนิ่ง / ลมเหนือ / ลมตะวันออก / ลมตะวันตก / ลมใต้ / สี่ฤดูกาล (uid 629): `TenjhoTengeMusouSwordAction.CheckActive` (ContainsBuffer) — check active — Code


---

###  (LunaDitherStarBladeRainAction) · uid 671
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องเวท (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **0** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `5 × Lv + 250 %` → Lv1 255% · Lv5 275% · Lv10 300%
  - Proration (`ExpRate`, SetRate) `proration ช่องเวทของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(targetExpList[mobAction] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ลูนาดิธเธอร์สตาร์ (uid 655) ผ่าน `LunaDitherStarAction.ReceivedAbnormal` (ContainsBuffer) — Received Abnormal — Code


---

###  (RangeHateAttackAction) · uid 703
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (LifeExplosionAction) · uid 732
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **400** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `100 × Lv + 1000 %` → Lv1 1100% · Lv5 1500% · Lv10 2000%

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (AutoDeviceAttackAction) · uid 733
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (AstralLanceAttackAction) · uid 734
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (never (IsExpDefFluctuate=false))

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **500** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `50 × Lv + 250 %` → Lv1 300% · Lv5 500% · Lv10 750%

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล แอสเทิลแลนซ์ (uid 710): `AstralLanceAttackAction.ActionStart` (TryGetBuf) — AstralLanceAttackAction: skill start — Code
- ได้รับการเสริมจากสกิล แอสเทิลแลนซ์ (uid 710): `AstralLanceAttackAction.OnEnd` (TryGetBuf) — On End — Code


---

###  (CounterForceAttackAction) · uid 735
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (never (IsExpDefFluctuate=false))

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ INTรวม
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **75** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `INTรวม / 10 + 30 × Lv %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล เคาน์เตอร์ฟอร์ส (uid 707): `CounterForceAttackAction.OnEnd` (TryGetBuf) — On End — Code


---

###  (BattleNotesAttackAction) · uid 797
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: ธรรมดา (SkillNormal) · Proration: ช่องตีปกติ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, SetConstant) `buffParam(NormalAttackConstantDamage)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, SetRate) `100 × buffParam(NormalAttackRate) / 100 + 100 × GemCartBufferManager.GetNormalAttackRate(PlayerStatusBase.get_GemCartBuffManager()) / 100 + 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - Proration (`ExpRate`, SetRate) `proration ช่องตีปกติของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, SetRate) `100 × PlayerAttackBase.CalcBufferLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus()) - 100 × MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetPr…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, SetRate) `100 × PlayerAttackBase.CalcBufferLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus()) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ดาเมจฐาน (`BaseDamage`, SetConstant) `PlayerAttackBase.calcBaseDamage(playerAction, mobAction, BattleNotesAttackAction.get_AttackType(), (MasterSkillDataManager.GetSkillMaster(Singleton<MasterSkillDataMana…(ย่อ)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - หักป้องกันเป้า (`Def`, SetConstant) `-PlayerAttackBase.CalcRegistDamage(this, BattleNotesAttackAction.get_AttackType(), PlayerActionManagerBase.get_PlayerStatus(), MobActionManagerBase.get_MobBattleStatus…(ย่อ)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณคริเพิ่ม (`CriticalRate`, SetRate) `status.CriticalDmg %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - โบนัสธาตุ (`ElementBonusRate`, SetRate) `PlayerAttackBase.CalcElementBonus(this, PlayerActionManagerBase.get_PlayerStatus(), BattleNotesAttackAction.get_AttackType(), target.Element)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ต้านธาตุ (`NormalElementDamageResistRate`, SetRate) `PlayerAttackBase.CalcNormalElementWeaponDamageResistRate(PlayerActionManagerBase.get_PlayerStatus(), mobAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ความเสถียร (`StableRate`, SetRate) `100 × PlayerAttackBase.CalcStable(3, status.Stable, CalcHit.correctHit(this, (PlayerActionManagerBase.get_PlayerStatus()), mobAction), (PlayerActionManagerBase.get_Pla…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ต้านตามระยะ (`DistanceResistRate`, SetRate) `PlayerAttackBase.CalcDistanceResistRate(playerAction, mobAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณเจม (`GemDamageRate`, SetRate) `PlayerAttackBase.CalcGemLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus())` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - เพิ่มดาเมจเป้าติดสถานะ (`AbnormalDamageIncreaseRate`, SetRate) `CheckAbnormalDamageIncrease.out2(this, mobAction, PlayerAttackBase.CalcGemLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus()))` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - GuardPower (`GuardPower`, SetCalcValue) `max(25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)), 0)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณล่าสมบัติ (`NormalAttackTreasureHuntLastDamageRate`, SetRate) `BonusManager.GetTreasureHuntLastDmgRateBonus(PlayerStatusBase.get_BonusManager())` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - DamageLimit (`DamageLimit`, SetConstant) `CheckPlayerDamageUpLimit.limitDamage(this, playerAction, mobAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - MinDamage (`MinDamage`, SetConstant) `CheckDamageLimit.min(this, mobAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - MaxDamage (`MaxDamage`, SetConstant) `CheckDamageLimit.max(this, mobAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสุดท้ายพิเศษ (`SpecialLastDamageRate`, SetRate) `PlayerAttackBase.GetSpecificWeaponLastDamageRate(playerAction, mobAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - GuardPower (`GuardPower`, SetCalcValue) = **25** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณคริเพิ่ม (`CriticalRate`, SetRate) = **100%** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: แบทเทิลโน้ต (Skill)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (SetlistAction) · uid 799
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล บทเพลงแห่งการเยียวยา (uid 769): `SetlistAction.GetSkillId` (GetSkillLv) — Get Skill Id — Code


---

###  (HolyGracePursuitAttackAction) · uid 863
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องตีปกติ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ DEXรวม/INT(ที่ลงเอง), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [ไม้เท้า] `DEXรวม + (300 × Lv > 1500 ? 300 × Lv : 1500) - 1200` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [อื่นๆ] `(300 × Lv > 1500 ? 300 × Lv : 1500) - 1200` → Lv1 300 · Lv5 300 · Lv10 1800
  - ตัวคูณสกิล (`SkillRate`, AddRate) [ไม้เท้า] `50 × Lv + INT(ที่ลงเอง) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [อื่นๆ] `50 × Lv %` → Lv1 50% · Lv5 250% · Lv10 500%
  - Proration (`ExpRate`, SetRate) `proration ช่องตีปกติของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (BlitzPikePursuitAction) · uid 988
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: ธรรมดา (SkillNormal) · Proration: ช่องตีปกติ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: สถานะ INTรวม
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `INTรวม` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `INTรวม ÷ 2 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- สกิลนี้ใส่บัพของสกิล 987 (uid 987) — Code


---

###  (GodSpearHandling3Action) · uid 989
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: เทพลมกรด (Skill)

#### 3) ระหว่างใช้สกิล
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - หลบ + (`AvoidUp`) = `avoid`
  - ลดดาเมจเวทที่ได้รับ (`MagicDmgCut`) = `cverlayCount × (HandlingerOfGodspeedBuf.GetGodSpearHandlingParam(this, id) - magicResist)`
  - ลดดาเมจกายภาพที่ได้รับ (`PowerDmgCut`) = `cverlayCount × (HandlingerOfGodspeedBuf.GetGodSpearHandlingParam(this, id) - physicsResist)`

#### 4) บัพที่ได้จากสกิลนี้
- MP สูงสุด + (`MaxMpUp`) = `-maxMp`
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `cverlayCount`
- ความเร็วโจมตี + (`Aspd`) = `aspd`
- MotionSpeedRate (`MotionSpeedRate`) = `actionSpeed`

#### 5) เชื่อมกับสกิลอื่น
- สกิลนี้ใส่บัพของสกิล เทพลมกรด (uid 974) — Code
- ได้รับการเสริมจากสกิล เทพลมกรด (uid 974): `GodSpearHandling3Action.ActionHit` (GetSkillLv) — Action Hit — Code
- ได้รับการเสริมจากสกิล เทพลมกรด (uid 974): `GodSpearHandling3Action.IsFailure` (GetSkillLv) — predicate is failure — Code
- ได้รับการเสริมจากสกิล เทพลมกรด (uid 974): `GodSpearHandling3Action.IsFailure` (TryGetBuf) — predicate is failure — Code
- ได้รับการเสริมจากสกิล ออลไมทีวีลด์ (uid 978): `GodSpearHandling3Action.IsFailure` (GetSkillLv) — predicate is failure — Code


---

###  (GodSpearHandling2Action) · uid 990
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: เทพลมกรด (Skill)

#### 3) ระหว่างใช้สกิล
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - หลบ + (`AvoidUp`) = `avoid`
  - ลดดาเมจเวทที่ได้รับ (`MagicDmgCut`) = `cverlayCount × (HandlingerOfGodspeedBuf.GetGodSpearHandlingParam(this, id) - magicResist)`
  - ลดดาเมจกายภาพที่ได้รับ (`PowerDmgCut`) = `cverlayCount × (HandlingerOfGodspeedBuf.GetGodSpearHandlingParam(this, id) - physicsResist)`

#### 4) บัพที่ได้จากสกิลนี้
- MP สูงสุด + (`MaxMpUp`) = `-maxMp`
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `cverlayCount`
- ความเร็วโจมตี + (`Aspd`) = `aspd`
- MotionSpeedRate (`MotionSpeedRate`) = `actionSpeed`

#### 5) เชื่อมกับสกิลอื่น
- สกิลนี้ใส่บัพของสกิล เทพลมกรด (uid 974) — Code
- ได้รับการเสริมจากสกิล เทพลมกรด (uid 974): `GodSpearHandling2Action.ActionHit` (GetSkillLv) — Action Hit — Code
- ได้รับการเสริมจากสกิล เทพลมกรด (uid 974): `GodSpearHandling2Action.IsFailure` (GetSkillLv) — predicate is failure — Code
- ได้รับการเสริมจากสกิล เทพลมกรด (uid 974): `GodSpearHandling2Action.IsFailure` (TryGetBuf) — predicate is failure — Code
- ได้รับการเสริมจากสกิล ออลไมทีวีลด์ (uid 978): `GodSpearHandling2Action.IsFailure` (GetSkillLv) — predicate is failure — Code


---

###  (GodSpearHandling1Action) · uid 991
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: เทพลมกรด (Skill)

#### 3) ระหว่างใช้สกิล
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - หลบ + (`AvoidUp`) = `avoid`
  - ลดดาเมจเวทที่ได้รับ (`MagicDmgCut`) = `cverlayCount × (HandlingerOfGodspeedBuf.GetGodSpearHandlingParam(this, id) - magicResist)`
  - ลดดาเมจกายภาพที่ได้รับ (`PowerDmgCut`) = `cverlayCount × (HandlingerOfGodspeedBuf.GetGodSpearHandlingParam(this, id) - physicsResist)`

#### 4) บัพที่ได้จากสกิลนี้
- MP สูงสุด + (`MaxMpUp`) = `-maxMp`
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `cverlayCount`
- ความเร็วโจมตี + (`Aspd`) = `aspd`
- MotionSpeedRate (`MotionSpeedRate`) = `actionSpeed`

#### 5) เชื่อมกับสกิลอื่น
- สกิลนี้ใส่บัพของสกิล เทพลมกรด (uid 974) — Code
- ได้รับการเสริมจากสกิล เทพลมกรด (uid 974): `GodSpearHandling1Action.ActionHit` (GetSkillLv) — Action Hit — Code
- ได้รับการเสริมจากสกิล เทพลมกรด (uid 974): `GodSpearHandling1Action.IsFailure` (GetSkillLv) — predicate is failure — Code
- ได้รับการเสริมจากสกิล เทพลมกรด (uid 974): `GodSpearHandling1Action.IsFailure` (TryGetBuf) — predicate is failure — Code
- ได้รับการเสริมจากสกิล ออลไมทีวีลด์ (uid 978): `GodSpearHandling1Action.IsFailure` (GetSkillLv) — predicate is failure — Code


---

###  (KunaiThrowingAction) · uid 1219
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: ธรรมดา (SkillNormal) · Proration: ช่องตีปกติ (every_hit + class check)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ตัวคูณสกิล (`SkillRate`, AddRate) [คาตานะ] `2 × NinjaSkillBase.GetNinjutsuTraining(this, PlayerActionManagerBase.get_PlayerStatus()) + 60 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [อื่นๆ] `NinjaSkillBase.GetNinjutsuTraining(this, PlayerActionManagerBase.get_PlayerStatus()) + 30 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(targetExpLit[MobActionManagerBase.get_MobStatus(mobAction).UniqueId] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (FumaShurikenAction) · uid 1220
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `20 × Lv + 100` → Lv1 120 · Lv5 200 · Lv10 300
  - ตัวคูณสกิล (`SkillRate`, AddRate) `(3 × Lv + NinjaSkillBase.GetNinko(this, PlayerActionManagerBase.get_PlayerStatus()) ÷ 10 + 20) × ((GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBu…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `attackUpCount`: `max(attackUpCount - 1, 0)` เมื่อ hit ≠ 0 และ param = 102 และ param ≠ 103

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (FireStyleAction) · uid 1221
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- **ดาเมจหลัก** — change ≠ 0 และ isFirstAttack = 0
  - ตัวคูณสกิล (`SkillRate`, AddRate) `?mla + NinjaSkillBase.GetNinko(this, (PlayerActionManagerBase.get_PlayerStatus())) + 30 × NinjaSkillBase.GetNinjutsuTraining(this, (PlayerActionManagerBase.get_PlayerS…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
- **ดาเมจหลัก** — change = 0
  - ตัวคูณสกิล (`SkillRate`, AddRate) `?mla + NinjaSkillBase.GetNinko(this, (PlayerActionManagerBase.get_PlayerStatus())) + 30 × NinjaSkillBase.GetNinjutsuTraining(this, (PlayerActionManagerBase.get_PlayerS…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `proration ช่องสกิลของเป้า / 100` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **400** คงที่ทุก Lv
- **ดาเมจหลัก** — change ≠ 0 และ isFirstAttack ≠ 0
  - ตัวคูณสกิล (`SkillRate`, AddRate) `rangeSkillRate %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `rangeSkillRate`: `rangeSkillRate + NinjaSkillBase.GetNinko(this, (PlayerActionManagerBase.get_PlayerStatus())) + 30 × NinjaSkillBase.GetNinjutsuTraining(this, (PlayerActionManagerBase.g…(ย่อ)` เมื่อ (+เงื่อนไขอื่น)
- สถานะผิดปกติที่ติดเป้า:
  - ไฟไหม้ โอกาส `((((Lv << 1) + 30)) << 1), playerAction` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ไฟไหม้ โอกาส `2 × Lv + 30` → Lv1 32 · Lv5 40 · Lv10 50

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (ThunderStyleAction) · uid 1222
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `20 × Lv + 200` → Lv1 220 · Lv5 300 · Lv10 400
  - ดาเมจคงที่ตีแรก (`FirstAttack`, AddConstant) `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `10 × Lv + NinjaSkillBase.GetNinko(this, (PlayerActionManagerBase.get_PlayerStatus())) + 30 × NinjaSkillBase.GetNinjutsuTraining(this, (PlayerActionManagerBase.get_Play…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณตีแรก (`FirstAttackRate`, AddRate) `PlayerAttackBase.calcFastAttackDamageRate(playerAction) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `damageInvalid`

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (WaterStyleAction) · uid 1223
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - (`MobLastDamageRate*` เข้าสูตรดาเมจที่มอนทำใส่ผู้เล่นใน `MobAttackBase.CalcLastDamage` — ค่านี้คือส่วนลดดาเมจที่ได้รับ; หน่วยและการรวมกับบัพอื่นยังไม่ยืนยัน — Inferred)
  - ตัวคูณดาเมจที่ได้รับจากมอน (หมวดซัพพอร์ต) (`MobLastDamageRateSupport`) = `damageCut`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `InstallationBlackHolePattern.CheckSuctionHit` (ContainsBuffer) — check suction hit — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `InstallationMoveBlackHolePattern.CheckSuctionHit` (ContainsBuffer) — check suction hit — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.get_MoveSpeed` (ContainsBuffer) — Move Speed of MobaPlayerActionManager — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PetMemberActionManager.get_MoveSpeed` (ContainsBuffer) — Move Speed of PetMemberActionManager — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.get_MoveSpeed` (ContainsBuffer) — Move Speed of PlayerActionManager — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.ActionStart` (ContainsBuffer) — PlayerAttackBase: skill start — Code


---

###  (EarthStyleAction) · uid 1224
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - (`MobLastDamageRate*` เข้าสูตรดาเมจที่มอนทำใส่ผู้เล่นใน `MobAttackBase.CalcLastDamage` — ค่านี้คือส่วนลดดาเมจที่ได้รับ; หน่วยและการรวมกับบัพอื่นยังไม่ยืนยัน — Inferred)
  - ตัวคูณดาเมจที่ได้รับจากมอน (หมวดบัพ) (`MobLastDamageRateBuf`) = `min(int((Max - Count) × (Max - Count) / 2.5 + 10), 50)`

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.ReceiveDamaged` (TryGetBuf) — Receive Damaged — Code


---

###  (WindStyleAction) · uid 1225
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `10 × Lv + 200` → Lv1 210 · Lv5 250 · Lv10 300
  - ตัวคูณสกิล (`SkillRate`, AddRate) `10 × Lv + NinjaSkillBase.GetNinko(this, (PlayerActionManagerBase.get_PlayerStatus())) + 20 × NinjaSkillBase.GetNinjutsuTraining(this, (PlayerActionManagerBase.get_Play…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- **ดาเมจหลัก** — change ≠ 0
  - ดาเมจคงที่ตีแรก (`FirstAttack`, AddConstant) `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ isGemCart ≠ 0
  - ตัวคูณตีแรก (`FirstAttackRate`, AddRate) `PlayerAttackBase.calcFastAttackDamageRate(playerAction) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ isGemCart ≠ 0
- สถานะผิดปกติที่ติดเป้า:
  - ล้มคว่ำ โอกาส = **100** คงที่ทุก Lv

#### 3) ระหว่างใช้สกิล
- คงกระพัน (สถานะ Invincibility) ตั้งแต่เริ่มท่า จนถอดตอนจบท่า — เพดาน 3 วินาที — Code · `ActionSkillEvent: AbnormalStateManager$$AddInvincibilityTemporarilyInAction`

#### 4) บัพที่ได้จากสกิลนี้
- อัตราคริ + (`CrtUp`) `Lv` → Lv1 1 · Lv5 5 · Lv10 10
- ตัวคูณตีแรก (`FirstAttackRate`) `Lv` → Lv1 1 · Lv5 5 · Lv10 10 — เมื่อ change ≠ 0

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `EquipItemData.WeaponTypeCalculatorBase.CalcAspd` (ContainsBuffer) — calculate aspd — Code


---

###  (CloningTechniqueAction) · uid 1226
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: ธรรมดา (SkillNormal) · Proration: ช่องตีปกติ (never (IsExpDefFluctuate=false))

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- **ดาเมจหลัก**
  - ตัวคูณสกิล (`SkillRate`, SetRate) = **100%** คงที่ทุก Lv
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: ชูคุจิ (Skill)

#### 3) ระหว่างใช้สกิล
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - HP สูงสุด % (`MaxHpUpRate`) = `-maxHpRate`

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล ชูคุจิ (uid 619): `CloningTechniqueAction.ActionStart` (GetSkillLv) — CloningTechniqueAction: skill start — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.GetSkillTargetType` (ContainsBuffer) — Get Skill Target Type — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerBattleManager.ConvertNinjutsuSkill` (ContainsBuffer) — Convert Ninjutsu Skill — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.GetSkillTargetType` (ContainsBuffer) — Get Skill Target Type — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.ConvertNinjutsuSkill` (ContainsBuffer) — Convert Ninjutsu Skill — Code


---

###  (RapidAquaVortexAction) · uid 1245
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **500** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `10 × Lv + 10 × NinjaSkillBase.GetNinjutsuTraining(this, (PlayerActionManagerBase.get_PlayerStatus())) + NinjaSkillBase.GetNinko(this, (PlayerActionManagerBase.get_Play…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefSkill / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - Proration (`ExpRate`, SetRate) `(targetExpList[MobActionManagerBase.get_MobStatus(mobAction).UniqueId] / 100)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (EarthStyleAttackAction) · uid 1246
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `fixAddDamage` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `skillRate %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
    - ตัวปรับ `skillRate`: `(((skillRate + ((NinjaSkillBase.GetNinjutsuTraining(this, PlayerActionManagerBase.get_PlayerStatus()) + (NinjaSkillBase.GetNinjutsuTraining(this, PlayerActionManagerBa…(ย่อ)`
    - ตัวปรับ `skillRate`: `skillRate + 20 × NinjaSkillBase.GetNinjutsuTraining(this, (PlayerActionManagerBase.get_PlayerStatus())) + NinjaSkillBase.GetNinko(this, (PlayerActionManagerBase.get_Pl…(ย่อ)`

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

###  (UtsusemiAction) · uid 1247
- ทรี: (internal) · เลเวลสูงสุด: None · อาวุธที่ใช้ได้: ไม่จำกัด/ไม่ระบุ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- คงกระพันตามเวลา PlayerActionManagerBase.get_AbnormalStatusManager() วินาที (ถอดเมื่อจบท่า/ครบเวลา) — Code · `ActionStart: AbnormalStateManager$$AddTimeInvincibility`

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---
