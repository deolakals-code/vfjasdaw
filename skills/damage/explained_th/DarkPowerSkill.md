# สกิลพลังมืด (`DarkPowerSkill`) — คำอธิบายทีละสกิล (ภาษาไทย)

สร้างอัตโนมัติด้วย `scripts/render_explained_th.py` จาก `skill_reference.json` (ข้อมูลโค้ด client ชุดล่าสุด) ไม่มีข้อความเขียนมือ แก้ไฟล์นี้ตรง ๆ จะถูกเขียนทับ ตัวเลขทั้งหมดคำนวณจากโค้ด (Code) ความหมายของชื่อ field/บทบาทแปลจากชื่อในโค้ด (Inferred) ยังไม่ได้เทียบกับตัวเลขในเกม ข้อมูลดิบทุกเส้นทางอยู่ใน `../details/DarkPowerSkill.md`

---

<!-- calc:preface -->
> **วิธีอ่านหัวข้อ "การคำนวณแบบตัวเลข"** (สร้างอัตโนมัติด้วย `scripts/render_calc_th.py` จาก `skill_reference.json` แก้มือจะถูกเขียนทับ)
> ดาเมจต่อฮิตเดินตามขั้น `SkillCalcTemplate/CalcStep` 0→40 ตามลำดับ (Code: `SkillCalcTemplate.GetDamage`) ขั้น `+` บวกเข้าดาเมจ ขั้น `×` คูณแล้วปัดเศษทิ้ง (int) ทันทีทุกขั้น
> ลำดับหลัก: ดาเมจฐาน(7) + คงที่สกิล(8) + คงที่บัพ(9) − ป้องกันเป้า(10) + ตีแรก(11) → ×คริ(13) → ×ธาตุ(15) → ×ตัวคูณสกิล(18) → ×ตีแรก(19) → ×เสถียร(21) → +คงที่ออโต้(22) → ×Proration(23) → ×ประเภท(24) → ×ดาเมจสุดท้าย(25) → … → เพดาน/ขั้นต่ำ(35–37)
> "ฮิต N" = template ดาเมจแต่ละก้อน (ทอยคริแยกกัน) แยกตามเมธอดและตัวแปรฮิตในโค้ด (`type`, `isFirst`, `attackCount` …) ชื่อฮิต/ส่วนมาจากชื่อในโค้ด (Inferred) ตัวเลขคำนวณจากโค้ด (Code) โดยตั้งเจม/บัพเสริม = 0
> ค่าหลายก้อนในขั้นเดียวกันแบบ "บวกเข้าช่อง" จะบวกกันก่อนคูณ ส่วน "ตั้งค่าทับ" แทนที่ค่าเดิม ค่าที่ขึ้นกับสเตตัสแสดงเป็นตัวอย่างที่ 100 / 255 (และ Lv สกิลอื่น 1 / 10) ใช้สูตรที่แนบไว้คำนวณค่าอื่นเอง
<!-- calc:preface-end -->

### บลัดดี้ไบท์ (BloodBite) · uid 1057

<img src="../../icons/sk_1057.png" width="40" alt="icon">

- ทรี: สกิลพลังมืด (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: NoMarketSearch
- คลาสในโค้ด: `BloodBiteAction` · สถานะการแกะ: แกะครบจากโค้ด

> ศาสตร์มืดที่ดูดเลือดของศัตรูมาหล่อเลี้ยง
> สร้างความเสียหายให้กับเป้าหมาย
> และดูดซับค่าความเสียหายบางส่วนมาเป็น HP ของตัวเอง
> ปริมาณการฟื้นฟูจะขึ้นอยู่กับเลเวลของตัวเอง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ฟื้นฟู
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

<!-- calc:begin uid=1057 -->
#### การคำนวณแบบตัวเลข — BloodBite (uid 1057)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **100** → 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(100 + 10×Lv)%** → 110%, 120%, 130%, 140%, 150%, 160%, 170%, 180%, 190%, 200% (Lv1…10)
<!-- calc:end -->

### แซครีไฟซ์ (Sacrifice) · uid 1058

<img src="../../icons/sk_1058.png" width="40" alt="icon">

- ทรี: สกิลพลังมืด (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: NoMarketSearch
- คลาสในโค้ด: `SacrificeAction` · สถานะการแกะ: แกะครบจากโค้ด

> สาปศัตรูด้วยการเสียสละพลังชีวิตตัวเอง
> ใช้ 10% ของค่า HP สูงสุดเพื่อสร้างความเสียหายพิเศษ
> จะหมดสติในกรณีที่ HP มีไม่เพียงพอ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · ไม่เปลี่ยนค่า proration
- บัพ `SoulHuntBuf`: บัพนับสแตก (สืบจาก `CountBufferBase`): ตัวนับ `Count` เริ่ม 0 เพิ่มทีละ 1 ด้วย `Next()` และสูงสุด 10; โค้ดอื่นอ่านจำนวนสแตกผ่านพารามิเตอร์ `Count` (ดูค่าที่ใช้จริงในสูตรของสกิลที่อ้างถึง)
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 10 ตามที่ `SoulHuntBuf` ส่งให้ตัวสร้างของ `บัพฐาน`

<!-- calc:begin uid=1058 -->
#### การคำนวณแบบตัวเลข — Sacrifice (uid 1058)
Proration: ช่อง `Skill` โหมด `never (IsExpSkill excludes ActionID)`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจฐาน (`BaseDamage`, +): `int(0x15c29 × consumptionHpRate × MaxHpรวม)` — โดยที่ `consumptionHpRate` = `10` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.MaxHp` = HP สูงสุด (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): 600%, 700%, 800%, 900%, 1000%, 1000%, 1000%, 1000%, 1000%, 1000% (Lv1…10)
  - สูตร: `skillRate / 100` — โดยที่ `skillRate` = `(100 × Lv < 500 ? 100 × Lv : 500) + 500`
- ความเสถียร (`StableRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `stable`]: `PlayerAttackBase.CalcStable(SacrificeAction.get_AttackType(), ((EternalNightmareBuf.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1064], 1) + ((Lv eq 10 ? 45 : 35) + ((Lv hi 5 ? Lv : 5) + ((Lv hi 5 ? Lv : 5) << 2))))), (SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 4) & 1), PlayerActionManagerBase.get_PlayerStatus())` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `SacrificeAction.get_AttackType` = ค่า Attack Type ของ SacrificeAction; `EternalNightmareBuf.GetParam` = EternalNightmareBuf: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า); `PlayerStatusBase.get_SkillBufferManager` = ค่า Skill Buffer Manager ของ PlayerStatusBase; `SkillCalcTemplate.CheckStepResult` = ตรวจ step result (SkillCalcTemplate); `PlayerAttackBase.HitReactionAssign` = PlayerAttackBase.HitReactionAssign; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase …(+1) (ดูแท็บ Variables)
- ความเสถียร (`StableRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `stable`]: `PlayerAttackBase.CalcStable(SacrificeAction.get_AttackType(), (Lv = 10 ? 45 : 35) + 5 × (Lv > 5 ? Lv : 5), SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new, SkillCalcTemplate, playerAction, mobAction), 4) & 1, PlayerActionManagerBase.get_PlayerStatus())` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `SacrificeAction.get_AttackType` = ค่า Attack Type ของ SacrificeAction; `SkillCalcTemplate.CheckStepResult` = ตรวจ step result (SkillCalcTemplate); `PlayerAttackBase.HitReactionAssign` = PlayerAttackBase.HitReactionAssign; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, บวกเข้าช่อง): `(100 - max(target.CutAttack)) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.CutAttack` = ลดพลังโจมตีกายภาพของผู้เล่นต่อมอน (ใช้ใน calcBaseDamage: (100-CutAttac (ดูแท็บ Variables)
- ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, ×, ตั้งค่าทับ) [`IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `TryGetProperties<object>.out2(mobAction, 90, PlayerActionManagerBase.get_PlayerStatus()) ≠ 0`]: `1 - MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90, PlayerActionManagerBase.get_PlayerStatus()))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobPropertyLifeReduceDamage.CalcReduceLastDamageRate` = คำนวณ reduce last damage rate (MobPropertyLifeReduceDamage); `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
- เพดานดาเมจ (`DamageLimit`, +, ตั้งค่าทับ): `CheckPlayerDamageUpLimit.limitDamage(this, playerAction, mobAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `CheckPlayerDamageUpLimit.limitDamage` = CheckPlayerDamageUpLimit.limitDamage (ดูแท็บ Variables)
- ดาเมจต่ำสุด (`MinDamage`, +) [`CheckDamageLimit.max(this, mobAction) ≠ -1` และ `CheckDamageLimit.min(this, mobAction) ≠ -1` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` หรือ `CheckDamageLimit.max(this, mobAction) = -1` และ `CheckDamageLimit.min(this, mobAction) ≠ -1` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` หรือ `CheckDamageLimit.max(this, mobAction) ≠ -1` และ `CheckDamageLimit.min(this, mobAction) ≠ -1` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) ≠ 1`]: `CheckDamageLimit.min(this, mobAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `CheckDamageLimit.min` = CheckDamageLimit.min (ดูแท็บ Variables)
- ดาเมจสูงสุด (`MaxDamage`, +) [`CheckDamageLimit.max(this, mobAction) ≠ -1` และ `CheckDamageLimit.min(this, mobAction) ≠ -1` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` หรือ `CheckDamageLimit.max(this, mobAction) ≠ -1` และ `CheckDamageLimit.min(this, mobAction) = -1` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` หรือ `CheckDamageLimit.max(this, mobAction) ≠ -1` และ `CheckDamageLimit.min(this, mobAction) ≠ -1` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) ≠ 1`]: `CheckDamageLimit.max(this, mobAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `CheckDamageLimit.max` = CheckDamageLimit.max (ดูแท็บ Variables)

**ใช้ร่วมทุกฮิตของ ฮิตรีแอ็กชัน (`HitReactionAssign`)**
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical)` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobBuffer.GuardUpBuff.get_GuardUpval` = ค่า Guard Upval ของ GuardUpBuff; `TryGetBuff.buff` = TryGetBuff.buff; `MobActionManagerBase.get_BuffManager` = ค่า Buff Manager ของ MobActionManagerBase (ดูแท็บ Variables)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) = 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: **25** → 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 (Lv1…10)
<!-- calc:end -->

### เนตรมารข่มขวัญ (IntimidatingEvilEye) · uid 1065

<img src="../../icons/sk_1065.png" width="40" alt="icon">

- ทรี: สกิลพลังมืด (ขั้น 1) · เลเวลสูงสุด: 1 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: NoMarketSearch
- คลาสในโค้ด: `IntimidatingEvilEyeAction` · สถานะการแกะ: แกะครบจากโค้ด

> จ้องมองด้วยสายตาอันเฉียบคมเพื่อข่มขวัญศัตรูให้หวาดกลัว
> ยิ่งเลเวลของเป้าหมายต่ำกว่ายิ่งมีโอกาสมากขึ้นที่จะทำให้ติดผงะ
> ถ้าข่มขวัญไม่สำเร็จจะติดเชื่องช้าแทน
> ไม่สามารถคาดหวังความเสียหายจากการโจมตีนี้ได้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- โอกาสติดสถานะ `slowPercent`: 100 %
- โอกาสติดสถานะ `flinchPercent`: `max(max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1064, 1), 0) + Lvรวม - target.Level, 0) × Lv` %
- สถานะที่ทำให้ติด: ผงะ (Flinch), ช้า (Slow)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv255: *นำเลเวลการเรียนรู้ของสกิลอีเทอนอลไนท์แมร์ มาบวกเพิ่มในอัตราติดผงะ

<!-- calc:begin uid=1065 -->
#### การคำนวณแบบตัวเลข — IntimidatingEvilEye (uid 1065)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **20×Lv** → 20, 40, 60, 80, 100, 120, 140, 160, 180, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(Lv)%** → 1%, 2%, 3%, 4%, 5%, 6%, 7%, 8%, 9%, 10% (Lv1…10)
<!-- calc:end -->

### ดาร์คสตริงเกอร์ (DarkStinger) · uid 1059

<img src="../../icons/sk_1059.png" width="40" alt="icon">

- ทรี: สกิลพลังมืด (ขั้น 2) · เลเวลสูงสุด: 60 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: บลัดดี้ไบท์ · ธง: NoMarketSearch
- คลาสในโค้ด: `DarkStingerAction` · สถานะการแกะ: แกะครบจากโค้ด

> ระเบิดพลังศาสตร์มืดที่อยู่ในแขนขวา
> ใช้ 10% ของ HP ปัจจุบันเพื่อสร้างความเสียหาย
> ค่า HP สูงสุดของตัวเองจะลดต่ำลง
> เป็นเวลา 10 วินาที (ไม่เกิน 5 ครั้ง)
> ถ้าใช้บลัดดี้ไบท์ระหว่างแสดงผล
> ผลเสียจะถูกลบออกไปและเพิ่มการฟื้นฟู HP

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `SoulHuntBuf`: บัพนับสแตก (สืบจาก `CountBufferBase`): ตัวนับ `Count` เริ่ม 0 เพิ่มทีละ 1 ด้วย `Next()` และสูงสุด 10; โค้ดอื่นอ่านจำนวนสแตกผ่านพารามิเตอร์ `Count` (ดูค่าที่ใช้จริงในสูตรของสกิลที่อ้างถึง)
- บัพ `DarkStingerBuf` ระยะเวลา 30 วินาที: HP สูงสุด % (`MaxHpUpRate`) = `-(maxHp * stack)` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `stack` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `stack` (ตัวนับที่เปลี่ยนตามเหตุการณ์)
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 10 ตามที่ `SoulHuntBuf` ส่งให้ตัวสร้างของ `บัพฐาน`

<!-- calc:begin uid=1059 -->
#### การคำนวณแบบตัวเลข — DarkStinger (uid 1059)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `fixAddDamage` — โดยที่ `fixAddDamage` = `(int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) lt 1000 ? int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) : 1000)` [`int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) < 1` และ `int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) < 1001` หรือ `Lv สกิล 1063 SoulHunt_Deathscythe ≥ 1` และ `int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) ≥ 1001` หรือ `Lv สกิล 1063 SoulHunt_Deathscythe < 1` และ `int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) ≥ 1001`] ; `consumptionHpRate` = `10` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate`]: `(30 × Lv + baseVIT + baseSTR + 100) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseVIT` = แต้ม VIT ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseVIT; `baseSTR` = แต้ม STR ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseSTR (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`Lv สกิล 1063 SoulHunt_Deathscythe ≥ 1` และ `int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) ≥ 1001` หรือ `Lv สกิล 1063 SoulHunt_Deathscythe < 1` และ `int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) ≥ 1001`]: `skillRate / 100` — โดยที่ `skillRate` = `30 × Lv + baseVIT + baseSTR + 100` หรือ `(skillRate + ((int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) - 1000) // (30 - EternalNightmareBuf.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1064], 2))))` [`Lv สกิล 1063 SoulHunt_Deathscythe ≥ 1` และ `int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) ≥ 1001` หรือ `Lv สกิล 1063 SoulHunt_Deathscythe < 1` และ `int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) ≥ 1001`] หรือ `(skillRate + ((int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) - 1000) // 30))` [`Lv สกิล 1063 SoulHunt_Deathscythe ≥ 1` และ `int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) ≥ 1001` หรือ `Lv สกิล 1063 SoulHunt_Deathscythe < 1` และ `int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) ≥ 1001`] ; `consumptionHpRate` = `10` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**ค่าบัพที่ขึ้นกับจำนวน stack**

- บัพ `DarkStingerBuf` — `MaxHpUpRate` ตามจำนวน `stack`: `-(maxHp × stack)`

  | stack | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |
<!-- calc:end -->

### เดมอนคลอว์ (DemonCrowe) · uid 1060

<img src="../../icons/sk_1060.png" width="40" alt="icon">

- ทรี: สกิลพลังมืด (ขั้น 2) · เลเวลสูงสุด: 60 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: แซครีไฟซ์ · ธง: NoMarketSearch
- คลาสในโค้ด: `DemonCroweAction` · สถานะการแกะ: แกะครบจากโค้ด

> ปีศาจร้ายที่อยู่ภายในอาละวาดดเพราะกระหายลือด
> เข้าโจมตีศัตรูที่เป็นเป้าหมาย
> โจมตีได้สูงสุดถึง 10 ตัวแต่ความเสียหายจะลดลงไป
> พลังจะเพิ่มมากขึ้นตาม HP ที่ลดลงเมื่อใช้งาน
> และจะไม่เกิดเฮท

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: Tiredness (Tiredness)

<!-- calc:begin uid=1060 -->
#### การคำนวณแบบตัวเลข — DemonCrowe (uid 1060)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **40×Lv** → 40, 80, 120, 160, 200, 240, 280, 320, 360, 400 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate` หรือ มีเจมคาร์ท 1016]: **(100 + 10×Lv)%** → 110%, 120%, 130%, 140%, 150%, 160%, 170%, 180%, 190%, 200% (Lv1…10)
<!-- calc:end -->

### เนตรมารเสน่หา (EnchantingEvilEye) · uid 1066

<img src="../../icons/sk_1066.png" width="40" alt="icon">

- ทรี: สกิลพลังมืด (ขั้น 2) · เลเวลสูงสุด: 60 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: เนตรมารข่มขวัญ · ธง: NoMarketSearch
- คลาสในโค้ด: `EnchantingEvilEyeAction` · สถานะการแกะ: แกะครบจากโค้ด

> ตรึงเป้าหมายไว้ด้วยอำนาจแห่งความชั่วร้าย
> มีโอกาสทำให้เป้าหมายติดหลงใหล
> หากเป้าหมายติดหลงใหลอยู่แล้วจะเพิ่มความเสียหาย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: มนตร์เสน่ห์ (Charm)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv255: *ขยายระยะเวลาผลของหลงใหลตามเลเวลการเรียนรู้ของสกิลอีเทอนอลไนท์แมร์ *ระยะเวลาความต้านทานไม่เปลี่ยนแปลง

<!-- calc:begin uid=1066 -->
#### การคำนวณแบบตัวเลข — EnchantingEvilEye (uid 1066)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30)`]: `min(target.Level × Lv, 10000)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.Level` = เลเวลมอนสเตอร์; `target.Level` = เลเวลมอนสเตอร์ (ดูแท็บ Variables)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30)` หรือ `!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30)`]: **0** → 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30)`]: **(100×Lv)%** → 100%, 200%, 300%, 400%, 500%, 600%, 700%, 800%, 900%, 1000% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30)`]: **(Lv)%** → 1%, 2%, 3%, 4%, 5%, 6%, 7%, 8%, 9%, 10% (Lv1…10)
<!-- calc:end -->

### เรดเทีย (RedTear) · uid 1061

<img src="../../icons/sk_1061.png" width="40" alt="icon">

- ทรี: สกิลพลังมืด (ขั้น 3) · เลเวลสูงสุด: 120 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ดาร์คสตริงเกอร์ · ธง: NoMarketSearch
- คลาสในโค้ด: `RedTearAction` · สถานะการแกะ: แกะครบจากโค้ด

> ความเกลียดชังจะถูกแปรเปลี่ยนเป็นน้ำตาแห่งสายเลือดและโจมตีศัตรู
> ถ้าถูกเล็งเป้าโดยศัตรูจะตกอยู่ในสภาวะเลือดออก
> ถ้าไม่ค่าเฮทจะลดง และจะยกเว้นการใช้ HP
> ของพลังแห่งความมืดระหว่างใช้สกิล

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, วางวัตถุ/กับดัก/อัญเชิญ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `RedTearBuf` ระยะเวลา 2, 2, 2, 3, 3, 4, 4, 5, 5, 6 (Lv1…10) วินาที
- ตัวอ่านสกิลนี้ `SacrificeAction.CheckPayHp` — SacrificeAction: ตรวจว่า HP พอจ่ายต้นทุนของสกิลนี้ไหม (true = ร่ายได้): คืนค่า `1` (2 กรณี) (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=1061 -->
#### การคำนวณแบบตัวเลข — RedTear (uid 1061)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(180 + 2×Lv)%** → 182%, 184%, 186%, 188%, 190%, 192%, 194%, 196%, 198%, 200% (Lv1…10)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `target.ExpDefMagic / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefMagic` = proration ช่อง Magic ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_CharacterActionManagerBase` = ค่า Character Action Manager Base ของ MobActionManagerBase (ดูแท็บ Variables)

**จำนวนฮิต / ตัวนับ**
- `damageCount` (ตั้งใน `OnInitialize`): `int(((EternalNightmareBuf.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1064], 4) * (int((Lv * 0.5)) gt 1 ? int((Lv * 0.5)) : 1)) * 0.01))`
- `LoopParam` (ตั้งใน `OnInitialize`): `int(((EternalNightmareBuf.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1064], 4) * (int((Lv * 0.5)) gt 1 ? int((Lv * 0.5)) : 1)) * 0.01))`
- `damageCount` (ตั้งใน `OnInitialize`): 1, 1, 1, 2, 2, 3, 3, 4, 4, 5 (Lv1…10)
- `LoopParam` (ตั้งใน `OnInitialize`): 1, 1, 1, 2, 2, 3, 3, 4, 4, 5 (Lv1…10)
- `damageCount` (ตั้งใน `InitializeOthers`): `motionSpeed`
<!-- calc:end -->

### รีเกรทเลส (Regret) · uid 1062

<img src="../../icons/sk_1062.png" width="40" alt="icon">

- ทรี: สกิลพลังมืด (ขั้น 3) · เลเวลสูงสุด: 120 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: เดมอนคลอว์ · ธง: NoMarketSearch
- คลาสในโค้ด: `RegretAction` · สถานะการแกะ: แกะครบจากโค้ด

> ถึงตายก็ไม่เสียดายชีวิต
> ฟื้นฟู HP ทั้งหมด เพิ่มสเตตัส และลด HP สูงสุดชั่วขณะ (ใช้ซ้อนกันได้)
> จะตายเมื่อผลสิ้นสุดลง
> *ไม่สามารถใช้ปฐมพยาบาล, พยายามเข้านะ!! และหยาดแห่งชีวิตได้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `RegretBuf` ระยะเวลา 30 วินาที: MP สูงสุด + (`MaxMpUp`) = `((stack lt 10 ? stack : 10) * maxMp)` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · HP สูงสุด % (`MaxHpUpRate`) = `-(maxHp * stack)` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · MATK + (`MatkUp`) = `((stack lt 10 ? stack : 10) * matk)` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ATK + (`AtkUp`) = `((stack lt 10 ? stack : 10) * atk)` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `stack` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = `((stack lt 10 ? stack : 10) * atkMpHeal)` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ลดดาเมจเวทที่ได้รับ (`MagicDmgCut`) = `((stack lt 10 ? stack : 10) * magic)` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ลดดาเมจกายภาพที่ได้รับ (`PowerDmgCut`) = `((stack lt 10 ? stack : 10) * physics)` (ตัวนับที่เปลี่ยนตามเหตุการณ์)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.Damaged` — MobaPlayerActionManager: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [set] `<IsApparentDeath>k__BackingField` = `0` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND GemCartBufferBase.GetValue(GemCartBuf…; [set] `apparentDeathId` = `0` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND GemCartBufferBase.GetValue(GemCartBuf…; [call] `PlayerGameStatus$$SetLocalHp` = `PlayerStatusBase.get_GameStatus(), int((IPlayerStatusCalculator.get_MaxHp(PlayerStatusBas…` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND GemCartBufferBase.GetValue(GemCartBuf… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.ReceiveDamaged` — MobaPlayerActionManager.ReceiveDamaged: [call] `PlayerGameStatus$$SetLocalHp` = `PlayerStatusBase.get_GameStatus(), int((IPlayerStatusCalculator.get_MaxHp(PlayerStatusBas…` เมื่อ (skillId & 0xffff) ne 514 AND GetServerHitTypeV2.hitType(responseData.HitType) ne 0 AND (CharacterActionManagerBase.get… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.Damaged` — PlayerActionManager: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน: [set] `<IsApparentDeath>k__BackingField` = `0` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND (SkillBufferManager.TryGetBuf(PlayerS…; [set] `apparentDeathId` = `0` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND (SkillBufferManager.TryGetBuf(PlayerS…; [call] `PlayerGameStatus$$SetLocalHp` = `PlayerStatusBase.get_GameStatus(), int((IPlayerStatusCalculator.get_MaxHp(PlayerStatusBas…` เมื่อ damageData.HitType ne 0 AND (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND (SkillBufferManager.TryGetBuf(PlayerS… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.EventDamaged` — PlayerActionManager.EventDamaged: [set] `<IsApparentDeath>k__BackingField` = `0` เมื่อ (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND (PlayerActionManager.get_IsLocalDead() & 1) ne 0 AND (_t1337 & 1)…; [set] `apparentDeathId` = `0` เมื่อ (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND (PlayerActionManager.get_IsLocalDead() & 1) ne 0 AND (_t1337 & 1)…; [call] `PlayerGameStatus$$SetLocalHp` = `PlayerStatusBase.get_GameStatus(), int((IPlayerStatusCalculator.get_MaxHp(PlayerStatusBas…` เมื่อ (PlayerStatusBase.get_IsInvincibility() & 1) eq 0 AND (PlayerActionManager.get_IsLocalDead() & 1) ne 0 AND (_t1337 & 1)… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.abnormalActionLockCheck` — PlayerActionManager.abnormalActionLockCheck (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SuppressionBonusGameManager.<>c__DisplayClass18_0.<Start>b__0` — <>c__DisplayClass18_0.<Start>b__0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SuppressionBonusGameManager.<MenuLoadWait>d__21.MoveNext` — <MenuLoadWait>d__21.MoveNext: คืนค่า `0` (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=1062 -->
#### การคำนวณแบบตัวเลข — Regret (uid 1062)

**ค่าบัพที่ขึ้นกับจำนวน stack**

- บัพ `RegretBuf` — `MaxMpUp` ตามจำนวน `stack`: `min(stack, 10) × maxMp`

  | stack | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |

- บัพ `RegretBuf` — `MaxHpUpRate` ตามจำนวน `stack`: `-(maxHp × stack)`

  | stack | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |

- บัพ `RegretBuf` — `MatkUp` ตามจำนวน `stack`: `min(stack, 10) × matk`

  | stack | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |

- บัพ `RegretBuf` — `AtkUp` ตามจำนวน `stack`: `min(stack, 10) × atk`

  | stack | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |

- บัพ `RegretBuf` — `AttackMprecoveryUp` ตามจำนวน `stack`: `min(stack, 10) × atkMpHeal`

  | stack | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |

- บัพ `RegretBuf` — `MagicDmgCut` ตามจำนวน `stack`: `min(stack, 10) × magic`

  | stack | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |

- บัพ `RegretBuf` — `PowerDmgCut` ตามจำนวน `stack`: `min(stack, 10) × physics`

  | stack | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |
<!-- calc:end -->

### เนตรมารเพลิงทมิฬ (BlackFlameEvilEye) · uid 1067

<img src="../../icons/sk_1067.png" width="40" alt="icon">

- ทรี: สกิลพลังมืด (ขั้น 3) · เลเวลสูงสุด: 120 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: เนตรมารเสน่หา · ธง: NoMarketSearch
- คลาสในโค้ด: `BlackFlameEvilEyeAction` · สถานะการแกะ: แกะครบจากโค้ด

> แผดเผาเป้าหมายที่จ้องมองด้วยเพลิงทมิฬ
> สร้างความเสียหายด้วยเวทมนตร์
> โดยอิงจากค่า ATK MATK ที่สูงกว่า
> หากเป้าหมายกำลังตั้งเป้าโจมตีมาที่ตัวคุณจะการันตีคริติคอล
> หากใช้เพลิงทมิฬมากเกินไปอาจส่งผลกระทบต่อร่างกายของผู้ใช้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `BlackFlameEvilEyeBuf`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่

**โน้ตในเกม (ข้อความจากเกม):**
- Lv255: *เพิ่มความรุนแรงของสกิลตามระดับเลเวลของอีเทอนอลไนท์แมร์

<!-- calc:begin uid=1067 -->
#### การคำนวณแบบตัวเลข — BlackFlameEvilEye (uid 1067)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **100** → 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate` หรือ `(PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp) le (int((status.MaxHp * 0.3)) gt 1000 ? int((status.MaxHp * 0.3)) : 1000)` และ `CharacterActionManagerBase.get_UnTargetDist() lt new BlackFlameEvilEyeBuf.Count` และ `Lv สกิล 1064 EternalNightmare ≥ 1` หรือ `(PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp) gt (int((status.MaxHp * 0.3)) gt 1000 ? int((status.MaxHp * 0.3)) : 1000)` และ `CharacterActionManagerBase.get_UnTargetDist() lt new BlackFlameEvilEyeBuf.Count` และ `Lv สกิล 1064 EternalNightmare ≥ 1`]: **(1000 + 100×Lv)%** → 1100%, 1200%, 1300%, 1400%, 1500%, 1600%, 1700%, 1800%, 1900%, 2000% (Lv1…10)
<!-- calc:end -->

### โซลฮันเตอร์ / เดธรีปเปอร์ (SoulHunt_Deathscythe) · uid 1063

<img src="../../icons/sk_1063.png" width="40" alt="icon">

- ทรี: สกิลพลังมืด (ขั้น 4) · เลเวลสูงสุด: 180 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: เรดเทีย · ธง: NoMarketSearch
- คลาสในโค้ด: `SoulHuntAction` · สถานะการแกะ: แกะครบจากโค้ด

> การเผชิญหน้าอย่างมุ่งมั่นจะทำให้เราได้พบสิ่งที่ดีที่สุด
> ผลลัพธ์จะมากขึ้นด้วยการใช้ HP(สูงสุด 10 เลเวล)
> จะทำให้เป้าหมายมีโอกาสติด[หวาดกลัว]
> และถ้าได้ผลลัพธ์มากขึ้นจะเพิ่มการฟื้นฟู MP
> และจะกวัดแกว่งวิญญาณที่ถูกล่ามาแทนเคียวเพื่อโจมตีสิ่งโดยรอบ

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: หวาดกลัว (Fear)
- บัพ `SoulHuntBuf`: บัพนับสแตก (สืบจาก `CountBufferBase`): ตัวนับ `Count` เริ่ม 0 เพิ่มทีละ 1 ด้วย `Next()` และสูงสุด 10; โค้ดอื่นอ่านจำนวนสแตกผ่านพารามิเตอร์ `Count` (ดูค่าที่ใช้จริงในสูตรของสกิลที่อ้างถึง)
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 10 ตามที่ `SoulHuntBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- ตัวอ่านสกิลนี้ `DarkStingerAction.ActionStart` — DarkStingerAction: ตอนเริ่มทำงานของสกิล: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new SoulHuntBuf, 0` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND SkillMana… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `GameManager.ReceiveActionSupportDelay` — GameManager.ReceiveActionSupportDelay (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `HealingShotAction.CheckPayHp` — HealingShotAction: ตรวจว่า HP พอจ่ายต้นทุนของสกิลนี้ไหม (true = ร่ายได้): [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new SoulHuntBuf, 0` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND consumptionHp lt (PlayerStatusBase.get_GameStatus().ser… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ReceiveSupportResult.OnActionPlayerSupport` — ReceiveSupportResult.OnActionPlayerSupport: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerDataManager.get_SkillBufferManager(PlayerDataManager.GetPlayerDataManager()), new S…` เมื่อ skillId gt 709 AND skillId le 1025 AND skillId le 869 AND skillId gt 773 AND (skillId & 0xffff) ne 803 AND (skillId & 0…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerDataManager.get_SkillBufferManager(PlayerDataManager.GetPlayerDataManager()), new S…` เมื่อ skillId gt 709 AND skillId le 1025 AND skillId gt 869 AND skillId le 968 AND (skillId & 0xffff) eq 965 AND supportData.…; [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerDataManager.get_SkillBufferManager(PlayerDataManager.GetPlayerDataManager()), new S…` เมื่อ skillId le 709 AND skillId gt 142 AND skillId le 527 AND skillId le 231 AND (skillId & 0xffff) eq 158 AND Decryption.sk… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ReceiveSupportResult.OnEventPlayerSupport` — ReceiveSupportResult.OnEventPlayerSupport (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SacrificeAction.CheckPayHp` — SacrificeAction: ตรวจว่า HP พอจ่ายต้นทุนของสกิลนี้ไหม (true = ร่ายได้): [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new SoulHuntBuf, 0` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND consumptionHp lt (PlayerStatusBase.get_GameStatus().ser… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SkillComboState.CheckBloody` — ตรวจ bloody (SkillComboState): [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new SoulHuntBuf, 0` เมื่อ fixidValues.BloodyCost ge 1 AND (PlayerStatusBase.get_GameStatus().serverHp + PlayerStatusBase.get_GameStatus().serverE… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SkillComboState.CheckTenacityCost` — ตรวจ tenacity cost (SkillComboState): [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new SoulHuntBuf, 0` เมื่อ (SkillComboState.EnoughTenacityCost(this, playerStatus) & 1) ne 0 AND fixidValues.TenacityCost ge 1 AND SkillManager.Ge… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SoulHuntAction.PayHp` — SoulHuntAction: จุดที่สกิลจ่าย/ลงทะเบียนต้นทุน HP (ในโค้ดเรียกว่า PayHp; อ่านนิยามจริงด้านล่าง): [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new SoulHuntBuf, 0` เมื่อ SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.SoulHunt_Deathscythe, 1) ge 1 AND (SkillBufferMana… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SpriteShieldAction.CheckPayHp` — SpriteShieldAction: ตรวจว่า HP พอจ่ายต้นทุนของสกิลนี้ไหม (true = ร่ายได้): [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new SoulHuntBuf, 0` เมื่อ (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND consumptionHp lt (PlayerStatusBase.get_GameStatus().ser… (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv8: *พลังเพิ่มตามค่า DEX ของตัวเอง *โอกาสที่จะติดหวาดกลัวลดลงมาก
- Lv10: *พลังเพิ่มขึ้นตามค่า STR ของตัวเอง
- Lv11: [จะได้รับผลแบบเดียวกันเมื่อใช้หอกวายุ] *ระยะโจมตี(รัศมี)+2 *โอกาสที่จะติดหวาดกลัวลดลงมาก
- Lv12: [จะได้รับผลแบบเดียวกันเมื่อใช้โบว์กัน] *พลังจะลดลงอย่างมาก แต่จะใช้ตรงใจกลางของเป้าหมาย *โอกาสที่จะติดหวาดกลัวลดลงเล็กน้อย
- Lv14: [จะได้รับผลแบบเดียวกันเมื่อใช้อุปกรณ์เวท] *โอกาสที่จะติดหวาดกลัวลดลง *เพิ่มปริมาณการฟื้นฟู MP
- Lv16: *พลังเพิ่มตามค่า AGI ของตัวเอง

<!-- calc:begin uid=1063 -->
#### การคำนวณแบบตัวเลข — SoulHunt_Deathscythe (uid 1063)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `attackCount ≠ 1`, `attackCount ≠ 2` · ส่วน ครั้งที่ 2 (`second…`)**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **500%** → 500%, 500%, 500%, 500%, 500%, 500%, 500%, 500%, 500%, 500% (Lv1…10)

**ฮิต 2: `calcPlayerToMobDamage` (ดาเมจหลัก) — `attackCount = 2` · ส่วน ครั้งแรก (`first…`)**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(500 + 50×Lv)%** → 550%, 600%, 650%, 700%, 750%, 800%, 850%, 900%, 950%, 1000% (Lv1…10)

**ใช้ร่วมทุกฮิตของ ดาเมจหลัก**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **100 + 30×Lv** → 130, 160, 190, 220, 250, 280, 310, 340, 370, 400 (Lv1…10)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefMagic / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `localExpDefMagic` = proration ปัจจุบันของมอนในช่องเวท (%); `MobActionManagerBase.get_MobStatus` = ค่า Mob Status ของ MobActionManagerBase (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpList[MobActionManagerBase.get_MobStatus(mobAction).UniqueId] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_MobStatus` = ค่า Mob Status ของ MobActionManagerBase (ดูแท็บ Variables)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `OnInitialize`) [`(mainWeaponType - 8) > 8`]: `int(10 × MathUtil.DisplayMeterToDistance(4))`
<!-- calc:end -->

### อีเทอนอลไนท์แมร์ (EternalNightmare) · uid 1064

<img src="../../icons/sk_1064.png" width="40" alt="icon">

- ทรี: สกิลพลังมืด (ขั้น 4) · เลเวลสูงสุด: 180 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: รีเกรทเลส · ธง: NoMarketSearch
- คลาสในโค้ด: `EternalNightmareAction` · สถานะการแกะ: แกะครบจากโค้ด

> เราอยู่ในห้วงฝันหรือว่าฝันร้าย?
> ใช้ HP อย่างต่อเนื่องเพื่อลดพลังป้องกันของมอนสเตอร์
> และอัพเกรดดาร์คพาวเวอร์สกิลได้ถึงเลเวล 3
> เพิ่มความต้านทานธาตุมืดในระหว่างการใช้งาน แต่ความต้านทานธาตุแสงลงจะลดลง

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, วางวัตถุ/กับดัก/อัญเชิญ
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `EternalNightmareBuf` ระยะเวลา `IsSelfAction = 0 ? 3 : 300` วินาที: HP สูงสุด % (`MaxHpUpRate`) = 2×Lv → 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 (Lv1…10) · ลด DEF เป้า (`TargetDefDown`) = `min(val × Lv ÷ 2, 400)` · ลด MDEF เป้า (`TargetMdefDown`) = `min(val × Lv ÷ 2, 400)` · ดาเมจธาตุแสงที่ได้รับ % (`ReceiveLightElementDmgRate`) = -5 · ดาเมจธาตุมืดที่ได้รับ % (`ReceiveDarkElementDmgRate`) = Lv → 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
- ตัวอ่านสกิลนี้ `BlackFlameEvilEyeAction.ActionPreparation` — BlackFlameEvilEyeAction: ขั้นเตรียมก่อนปล่อยสกิล: [set] `skillRate` = `(skillRate + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.Eterna…` เมื่อ (PlayerAttackBase.IsBlank(this) & 1) eq 0 AND (UnityEngine.Object.op_Inequality(actarAction, 0) & 1) ne 0 AND SkillMana… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EnchantingEvilEyeAction.calcPlayerToMobDamage` — EnchantingEvilEyeAction: สูตรดาเมจผู้เล่น→มอนสเตอร์ (ใส่ค่าลง template) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `IntimidatingEvilEyeAction.ActionPreparation` — IntimidatingEvilEyeAction: ขั้นเตรียมก่อนปล่อยสกิล (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `ReceiveSupportResult.OnActionPlayerSupport` — ReceiveSupportResult.OnActionPlayerSupport (นิยามเต็มในแท็บ Variables)

**โน้ตในเกม (ข้อความจากเกม):**
- Lv255: *ปริมาณการป้องกันที่ลดลงขึ้นอยู่กับเลเวลรวมของดาร์คพาวเวอร์ *เพิ่มลิมิตการฟื้นฟูของบลัดดี้ไบท์ *เพิ่มอัตราความเสถียรของแซคคริไฟส์ *เพิ่มพลังของดาร์คสตริงเกอร์ตามสัดส่วนการใช้ HP *ลดเกณฑ์ HP ในการเพิ่มพลังของเดมอนคลอว์ *เพิ่มจำนวนการโจมตีของเรดเทีย *เพิ่มโอกาสในการหลีกเลี่ยงความเสียใจด้วยรีเกรทเลส

<!-- calc:begin uid=1064 -->
#### การคำนวณแบบตัวเลข — EternalNightmare (uid 1064)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `OnInitialize`): 300, 300, 300, 300, 300, 300, 300, 300, 300, 300 (Lv1…10)
<!-- calc:end -->

### เนตรมารโกลาหล (ChaosEvilEye) · uid 1068

<img src="../../icons/sk_1068.png" width="40" alt="icon">

- ทรี: สกิลพลังมืด (ขั้น 4) · เลเวลสูงสุด: 180 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: เนตรมารเพลิงทมิฬ · ธง: NoMarketSearch
- คลาสในโค้ด: `ChaosEvilEyeAction` · สถานะการแกะ: แกะครบจากโค้ด

> ใช้กระแสแห่งความโกลาหลมอบความทรมานให้แก่ศัตรู
> สร้างความเสียหายด้วยเวทมนตร์ตามจุดอ่อนของเป้าหมาย
> มอบภาวะผิดปกติ(โดยการสุ่มมาหนึ่งจากสิบประเภท)
> หากมอบสำเร็จความเสียหายจะเพิ่มขึ้นเป็นอย่างมาก
> ถ้าเป้าหมายกำลังเล็งโจมตีคุณอยู่จะเจาะ Guard ได้

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท; ช่อง proration ตั้งใน ctor (expType=2) = ช่องเวท — เงื่อนไข: Magic: always
- Proration: ช่องที่เลือกตอนร่าย (กายภาพ/เวท) · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: `abnormalType`

<!-- calc:begin uid=1068 -->
#### การคำนวณแบบตัวเลข — ChaosEvilEye (uid 1068)
Proration: ช่อง `dynamic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **50×Lv** → 50, 100, 150, 200, 250, 300, 350, 400, 450, 500 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(500 + 100×Lv)%** → 600%, 700%, 800%, 900%, 1000%, 1100%, 1200%, 1300%, 1400%, 1500% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 3)` และ `PlayerAttackBase.checkAbnormalPercent(this, abnormalType, 100, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `target.ExpDefMagic gt target.ExpDefNormal` และ … หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 3)` และ `PlayerAttackBase.checkAbnormalPercent(this, abnormalType, 100, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `target.ExpDefMagic gt target.ExpDefNormal` และ … หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 3)` และ `PlayerAttackBase.checkAbnormalPercent(this, abnormalType, 100, playerAction)` และ `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `target.ExpDefMagic gt target.ExpDefSkill` และ …]: **(750 + 150×Lv)%** → 900%, 1050%, 1200%, 1350%, 1500%, 1650%, 1800%, 1950%, 2100%, 2250% (Lv1…10)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `isEffectiveAbnormal` และ `target.ExpDefMagic gt target.ExpDefNormal` และ `target.ExpDefMagic lt target.ExpDefNormal` และ … หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ ไม่ `isEffectiveAbnormal` และ `target.ExpDefMagic gt target.ExpDefNormal` และ `target.ExpDefMagic lt target.ExpDefNormal` และ … หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `isEffectiveAbnormal` และ `target.ExpDefMagic gt target.ExpDefNormal` และ `target.ExpDefMagic lt target.ExpDefNormal` และ …]: `target.ExpDefSkill / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefSkill` = proration ช่อง Skill ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `isEffectiveAbnormal` และ `target.ExpDefMagic gt target.ExpDefNormal` และ `target.ExpDefMagic lt target.ExpDefNormal` และ … หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ ไม่ `isEffectiveAbnormal` และ `target.ExpDefMagic gt target.ExpDefNormal` และ `target.ExpDefMagic lt target.ExpDefNormal` และ … หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `isEffectiveAbnormal` และ `target.ExpDefMagic gt target.ExpDefNormal` และ `target.ExpDefMagic lt target.ExpDefNormal` และ …]: `target.ExpDefNormal / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefNormal` = proration ช่อง Normal ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `isEffectiveAbnormal` และ `target.ExpDefMagic ge target.ExpDefNormal` และ `target.ExpDefMagic ge target.ExpDefSkill` และ … หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ ไม่ `isEffectiveAbnormal` และ `target.ExpDefMagic ge target.ExpDefNormal` และ `target.ExpDefMagic ge target.ExpDefSkill` และ … หรือ `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0)` และ `isEffectiveAbnormal` และ `target.ExpDefMagic ge target.ExpDefNormal` และ `target.ExpDefMagic ge target.ExpDefSkill` และ …]: `target.ExpDefMagic / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefMagic` = proration ช่อง Magic ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
<!-- calc:end -->

