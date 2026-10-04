# แอ็กชันภายใน (`(internal actions)`) — คำอธิบายทีละสกิล (ภาษาไทย)

สร้างอัตโนมัติด้วย `scripts/render_explained_th.py` จาก `skill_reference.json` (ข้อมูลโค้ด client ชุดล่าสุด) ไม่มีข้อความเขียนมือ แก้ไฟล์นี้ตรง ๆ จะถูกเขียนทับ ตัวเลขทั้งหมดคำนวณจากโค้ด (Code) ความหมายของชื่อ field/บทบาทแปลจากชื่อในโค้ด (Inferred) ยังไม่ได้เทียบกับตัวเลขในเกม ข้อมูลดิบทุกเส้นทางอยู่ใน `../details/_internal_actions_.md`

---

<!-- calc:preface -->
> **วิธีอ่านหัวข้อ "การคำนวณแบบตัวเลข"** (สร้างอัตโนมัติด้วย `scripts/render_calc_th.py` จาก `skill_reference.json` แก้มือจะถูกเขียนทับ)
> ดาเมจต่อฮิตเดินตามขั้น `SkillCalcTemplate/CalcStep` 0→40 ตามลำดับ (Code: `SkillCalcTemplate.GetDamage`) ขั้น `+` บวกเข้าดาเมจ ขั้น `×` คูณแล้วปัดเศษทิ้ง (int) ทันทีทุกขั้น
> ลำดับหลัก: ดาเมจฐาน(7) + คงที่สกิล(8) + คงที่บัพ(9) − ป้องกันเป้า(10) + ตีแรก(11) → ×คริ(13) → ×ธาตุ(15) → ×ตัวคูณสกิล(18) → ×ตีแรก(19) → ×เสถียร(21) → +คงที่ออโต้(22) → ×Proration(23) → ×ประเภท(24) → ×ดาเมจสุดท้าย(25) → … → เพดาน/ขั้นต่ำ(35–37)
> "ฮิต N" = template ดาเมจแต่ละก้อน (ทอยคริแยกกัน) แยกตามเมธอดและตัวแปรฮิตในโค้ด (`type`, `isFirst`, `attackCount` …) ชื่อฮิต/ส่วนมาจากชื่อในโค้ด (Inferred) ตัวเลขคำนวณจากโค้ด (Code) โดยตั้งเจม/บัพเสริม = 0
> ค่าหลายก้อนในขั้นเดียวกันแบบ "บวกเข้าช่อง" จะบวกกันก่อนคูณ ส่วน "ตั้งค่าทับ" แทนที่ค่าเดิม ค่าที่ขึ้นกับสเตตัสแสดงเป็นตัวอย่างที่ 100 / 255 (และ Lv สกิลอื่น 1 / 10) ใช้สูตรที่แนบไว้คำนวณค่าอื่นเอง
<!-- calc:preface-end -->

### NormalAttackAction · uid 0

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `NormalAttackAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, เปลี่ยนการทำงานของตีปกติ, เพิ่มดาเมจตีปกติ
- ดาเมจ: สร้าง template ดาเมจ 3 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องตีปกติ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `SamuraiArcheryBuf`: ความแม่น % (`HitRate`) = `Count × Lv`
- บัพ `UnannouncedDestinationBuf` ระยะเวลา `shortcut & 1 ≠ 0 ? 10 - lv : 12 - lv` วินาที [`((shortcut & 1) ne 0 ? ((12 - lv) + -2) : (12 - lv)) > 0` หรือ `((shortcut & 1) ne 0 ? ((12 - lv) + -2) : (12 - lv)) ≤ 0`]
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 10 ตามที่ `SamuraiArcheryBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- บัพ `ShukuchiBuf`: ตัวคูณตีปกติ % (`NormalAttackRate`) = 400 · ตัวคูณตีปกติ % (`NormalAttackRate`) = 5×Lv → 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10) · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = 0, 2, 4, 8, 12, 18, 24, 32, 40, 50 (Lv1…10)
- บัพ `SwordMoveBuf`: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `damageInvalid` (ตัวนับที่เปลี่ยนตามเหตุการณ์)

<!-- calc:begin uid=0 -->
#### การคำนวณแบบตัวเลข — NormalAttackAction (uid 0)
Proration: ช่อง `Normal` โหมด `first_hit_per_target if class check passes`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) · ส่วน calcRampage (`calcRampage…`)**
- ดาเมจฐาน (`BaseDamage`, +) [กิ่งที่ 1 ของ `SkillIndividualFlag`]: `NormalAttackAction.CalcBaseDamage(this, playerAction, mobAction, !MobActionManagerBase.get_SystemInvincible(mobAction) ? 0 : ((System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValuePlayerStatusBase.get_SkillBufferManager().skillBufList, 639, stkp(-184), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) ? ((PlayerAttackBase.checkCriticalPercent(this, PlayerSecondaryStatus.CalcCritical(PlayerStatusBase.get_SecondaryStatus(), PlayerSecondaryStatus.GetCrtRate(PlayerStatusBase.get_SecondaryStatus()), PlayerSecondaryStatus.GetCrtConstant(PlayerStatusBase.get_SecondaryStatus(), ((SkillIndividualFlag & 2) eq 0 ? 1 : 0))), mobAction) ? 2 : 1) : 2)))` — โดยที่ `SkillIndividualFlag` = `SkillIndividualFlag | 1` หรือ `(((!PlayerAttackBase.IsBlank(this)) || (PlayerAttackBase.IsBlank(this) && !UnityEngine.Object.op_Inequality(actarAction, 0)) || (!PlayerAttackBase.IsBlank(this) && !UnityEngine.Object.op_Inequality(actarAction, 0) && UnannouncedDestination.CheckMinimumBehavior(PlayerActionManagerBase.get_PlayerStatus(), (new NormalAttackAction.<>c__DisplayClass72_1 + 16))) ? ?undef : ((!SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 626, (new NormalAttackAction.<>c__DisplayClass72_1 + 24))) || (!SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 626, (new NormalAttackAction.<>c__DisplayClass72_1 + 24)) && UnannouncedDestinationBuf.CheckActive(new NormalAttackAction.<>c__DisplayClass72_1.unannouncedDestinationBuf)) || (!SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 626, (new NormalAttackAction.<>c__DisplayClass72_1 + 24)) && UnannouncedDestinationBuf.CheckActive(new NormalAttackAction.<>c__DisplayClass72_1.unannouncedDestinationBuf) && (hasBuff(619)) ? ?undef : (SkillIndividualFlag | 64))) | 8) | 0x4000)` [อาวุธหลัก ธนู และ อาวุธรอง คาตานะ และ ไม่ `checkIchijhinnokaze` และ ไม่ `isUnsheatheMode`] หรือ `((!PlayerAttackBase.IsBlank(this)) || (PlayerAttackBase.IsBlank(this) && !UnityEngine.Object.op_Inequality(actarAction, 0)) || (!PlayerAttackBase.IsBlank(this) && !UnityEngine.Object.op_Inequality(actarAction, 0) && UnannouncedDestination.CheckMinimumBehavior(PlayerActionManagerBase.get_PlayerStatus(), (new NormalAttackAction.<>c__DisplayClass72_1 + 16))) ? ?undef : ((!SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 626, (new NormalAttackAction.<>c__DisplayClass72_1 + 24))) || (!SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 626, (new NormalAttackAction.<>c__DisplayClass72_1 + 24)) && UnannouncedDestinationBuf.CheckActive(new NormalAttackAction.<>c__DisplayClass72_1.unannouncedDestinationBuf)) || (!SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 626, (new NormalAttackAction.<>c__DisplayClass72_1 + 24)) && UnannouncedDestinationBuf.CheckActive(new NormalAttackAction.<>c__DisplayClass72_1.unannouncedDestinationBuf) && (hasBuff(619)) ? ?undef : (SkillIndividualFlag | 64))) | 8)` หรือ `(!NormalAttackAction.CheckOneChance(this, playerAction) ? ?undef : SkillIndividualFlag | 2048) | 4096` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `NormalAttackAction.CalcBaseDamage` = ดาเมจฐานของการโจมตีปกติ; `MobActionManagerBase.get_SystemInvincible` = ค่า System Invincible ของ MobActionManagerBase; `PlayerAttackBase.checkCriticalPercent` = ทอยคริติคอล (Critical − CriticalResist ของมอน จาก 100); `PlayerSecondaryStatus.CalcCritical` = คำนวณ critical (PlayerSecondaryStatus); `PlayerStatusBase.get_SecondaryStatus` = ค่า Secondary Status ของ PlayerStatusBase (ดูแท็บ Variables)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `buffParam(NormalAttackConstantDamage)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `NormalAttackAction.calcRampageConstantDamage(this_tpl(), playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `NormalAttackAction.calcRampageConstantDamage` = คำนวณ rampage constant damage (NormalAttackAction) (ดูแท็บ Variables)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `ArkSaber.CalcConstantDamage(playerAction, mobAction) ÷ 2` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `UnannouncedDestination.CalcNormalAttackConstantDamage(PlayerActionManagerBase.get_PlayerStatus())` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `UnannouncedDestination.CalcNormalAttackConstantDamage` = คำนวณ normal attack constant damage (UnannouncedDestination); `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `IchijhinnokazeBuf.GetNormalAttackConstantDamage(PlayerActionManagerBase.get_PlayerStatus())` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `IchijhinnokazeBuf.GetNormalAttackConstantDamage` = IchijhinnokazeBuf.GetNormalAttackConstantDamage; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
- หักป้องกันเป้า (`Def`, +): `-NormalAttackAction.CalcDef(this, playerAction, เป้า)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `NormalAttackAction.CalcDef` = คำนวณ def (NormalAttackAction); `MobActionManagerBase.get_MobBattleStatus` = ค่า Mob Battle Status ของ MobActionManagerBase (ดูแท็บ Variables)
- ดาเมจคงที่ตีแรก (`FirstAttack`, +): `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamage` = ดาเมจคงที่ของ Fast Attack (ดูแท็บ Variables)
- ดาเมจคงที่ตีแรก (`FirstAttack`, +): **0** → 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 (Lv1…10)
- ตัวคูณคริติคอลเพิ่ม (`CriticalRate`, ×, บวกเข้าช่อง): `CriticalDmgรวม / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.CriticalDmg` = ดาเมจคริติคอลกายภาพ % (ใช้เป็น CriticalDmg/100) (ดูแท็บ Variables)
- ตัวคูณคริติคอลเพิ่ม (`CriticalRate`, ×, บวกเข้าช่อง): **100%** → 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100% (Lv1…10)
- โบนัสธาตุ (`ElementBonusRate`, ×, บวกเข้าช่อง): `PlayerAttackBase.CalcElementBonus(this, PlayerActionManagerBase.get_PlayerStatus(), NormalAttackAction.get_AttackType(), target.Element)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.Element` = ธาตุของมอน; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `NormalAttackAction.get_AttackType` = ค่า Attack Type ของ NormalAttackAction (ดูแท็บ Variables)
- ต้านธาตุ (`NormalElementDamageResistRate`, ×, บวกเข้าช่อง): `PlayerAttackBase.CalcNormalElementWeaponDamageResistRate(PlayerActionManagerBase.get_PlayerStatus(), mobAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.CalcNormalElementWeaponDamageResistRate` = ตัวคูณต้านธาตุของอาวุธ; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
- power wave ตีปกติ (`NormalAttackPowerWave`, ×, บวกเข้าช่อง): **0** → 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `(checkIchijhinnokaze eq 0 ? !PlayerAttackBase.CheckSkillIndividualFlag(this, 1024) ? (!NormalAttackAction.calcRampageSkillRate(this, playerAction, 0) + (buffParam(NormalAttackRate) / 100)) + (GemCartBufferManager.GetNormalAttackRate(PlayerStatusBase.get_GemCartBuffManager()) * 0.01)) : ((PlayerAttackBase.CheckSkillIndividualFlag(this, 1024) && (System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValuePlayerStatusBase.get_SkillManager().SkillMasteryList, 297, stkp(-232), meta(0x3974490, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.TryGetValue())) ? (((System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValuePlayerStatusBase.get_SkillManager().SkillMasteryList, 296, stkp(-232), meta(0x3974490, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.TryGetValue())) ? (!NormalAttackAction.calcRampageSkillRate(this, playerAction, 0) + (buffParam(NormalAttackRate) / 100)) + (GemCartBufferManager.GetNormalAttackRate(PlayerStatusBase.get_GemCartBuffManager()) * 0.01)) : (((NormalAttackAction.calcRampageSkillRate(this, playerAction, 0) + (buffParam(NormalAttackRate) / 100)) + (GemCartBufferManager.GetNormalAttackRate(PlayerStatusBase.get_GemCartBuffManager()) * 0.01)) + (SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) / 100))) + (SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) / 100)) : ((System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue(PlayerStatusBase.get_SkillManager().SkillMasteryList, 296, stkp(-232), meta(0x3974490, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.TryGetValue())) ? (!NormalAttackAction.calcRampageSkillRate(this, playerAction, 0) + (buffParam(NormalAttackRate) / 100)) + (GemCartBufferManager.GetNormalAttackRate(PlayerStatusBase.get_GemCartBuffManager()) * 0.01)) : (((NormalAttackAction.calcRampageSkillRate(this, playerAction, 0) + (buffParam(NormalAttackRate) / 100)) + (GemCartBufferManager.GetNormalAttackRate(PlayerStatusBase.get_GemCartBuffManager()) * 0.01)) + (SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) / 100))))) : (((PlayerAttackBase.CheckSkillIndividualFlag(this, 1024) ? (!NormalAttackAction.calcRampageSkillRate(this, playerAction, 0) + (buffParam(NormalAttackRate) / 100)) + (GemCartBufferManager.GetNormalAttackRate(PlayerStatusBase.get_GemCartBuffManager()) * 0.01)) : ((PlayerAttackBase.CheckSkillIndividualFlag(this, 1024) && (System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValuePlayerStatusBase.get_SkillManager().SkillMasteryList, 297, stkp(-232), meta(0x3974490, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.TryGetValue())) ? (((System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue(PlayerStatusBase.get_SkillManager().SkillMasteryList, 296, stkp(-232), meta(0x3974490, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.TryGetValue())) ? (!NormalAttackAction.calcRampageSkillRate(this, playerAction, 0) + (buffParam(NormalAttackRate) / 100)) + (GemCartBufferManager.GetNormalAttackRate(PlayerStatusBase.get_GemCartBuffManager()) * 0.01)) : (((NormalAttackAction.calcRampageSkillRate(this, playerAction, 0) + (buffParam(NormalAttackRate) / 100)) + (GemCartBufferManager.GetNormalAttackRate(PlayerStatusBase.get_GemCartBuffManager()) * 0.01)) + (SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) / 100))) + (SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) / 100)) : ((System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue(PlayerStatusBase.get_SkillManager().SkillMasteryList, 296, stkp(-232), meta(0x3974490, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.TryGetValue())) ? ((NormalAttackAction.calcRampageSkillRate(this, playerAction, 0) + (buffParam(NormalAttackRate) / 100)) + (GemCartBufferManager.GetNormalAttackRate(PlayerStatusBase.get_GemCartBuffManager()) * 0.01)) : (((NormalAttackAction.calcRampageSkillRate(this, playerAction, 0) + (buffParam(NormalAttackRate) / 100)) + (GemCartBufferManager.GetNormalAttackRate(PlayerStatusBase.get_GemCartBuffManager()) * 0.01)) + (SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) / 100))))) + ((IchijhinnokazeBuf.GetNormalAttackSkillRate(PlayerActionManagerBase.get_PlayerStatus()) + IchijhinnokazeAratame.GetNormalAttackSkillRateBonus(PlayerActionManagerBase.get_PlayerStatus())) / 100)))` — โดยที่ `checkIchijhinnokaze` = `1` [`!PlayerAttackBase.CheckSkillIndividualFlag(this, 0x2000)` และ `!PlayerAttackBase.CheckSkillIndividualFlag(this, 0x4000)` และ `!PlayerAttackBase.CheckSkillIndividualFlag(this, 1024)` และ `!PlayerAttackBase.CheckSkillIndividualFlag(this, 16)` และ … หรือ `!PlayerAttackBase.CheckSkillIndividualFlag(this, 0x2000)` และ `!PlayerAttackBase.CheckSkillIndividualFlag(this, 0x4000)` และ `!PlayerAttackBase.CheckSkillIndividualFlag(this, 1024)` และ `!PlayerAttackBase.CheckSkillIndividualFlag(this, 128)` และ … หรือ `!PlayerAttackBase.CheckSkillIndividualFlag(this, 0x2000)` และ `!PlayerAttackBase.CheckSkillIndividualFlag(this, 0x4000)` และ `!PlayerAttackBase.CheckSkillIndividualFlag(this, 1024)` และ `!PlayerAttackBase.CheckSkillIndividualFlag(this, 128)` และ …] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.CheckSkillIndividualFlag` = ตรวจ skill individual flag (PlayerAttackBase); `NormalAttackAction.calcRampageSkillRate` = คำนวณ rampage skill rate (NormalAttackAction); `GemCartBufferManager.GetNormalAttackRate` = GemCartBufferManager.GetNormalAttackRate; `PlayerStatusBase.get_GemCartBuffManager` = ค่า Gem Cart Buff Manager ของ PlayerStatusBase; `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `PlayerStatusBase.get_SkillManager` = ค่า Skill Manager ของ PlayerStatusBase …(+4) (ดูแท็บ Variables)
- ตัวคูณตีแรก (`FirstAttackRate`, ×, บวกเข้าช่อง): `PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamageRate` = ตัวคูณของ Fast Attack (ดูแท็บ Variables)
- ตัวคูณตีแรก (`FirstAttackRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `SkillIndividualFlag`]: `(isUnsheatheMode ne 0 && !MobActionManagerBase.get_SystemInvincible(mobAction) ? 0 : ((System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValuePlayerStatusBase.get_SkillBufferManager().skillBufList, 639, stkp(-184), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) ? ((PlayerAttackBase.checkCriticalPercent(this, PlayerSecondaryStatus.CalcCritical(PlayerStatusBase.get_SecondaryStatus(), PlayerSecondaryStatus.GetCrtRate(PlayerStatusBase.get_SecondaryStatus()), PlayerSecondaryStatus.GetCrtConstant(PlayerStatusBase.get_SecondaryStatus(), ((SkillIndividualFlag & 2) eq 0 ? 1 : 0))), mobAction) ? 2 : 1) : 2)) ne 2 ? (PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100) : 1)` — โดยที่ `SkillIndividualFlag` = `SkillIndividualFlag | 1` หรือ `(((!PlayerAttackBase.IsBlank(this)) || (PlayerAttackBase.IsBlank(this) && !UnityEngine.Object.op_Inequality(actarAction, 0)) || (!PlayerAttackBase.IsBlank(this) && !UnityEngine.Object.op_Inequality(actarAction, 0) && UnannouncedDestination.CheckMinimumBehavior(PlayerActionManagerBase.get_PlayerStatus(), (new NormalAttackAction.<>c__DisplayClass72_1 + 16))) ? ?undef : ((!SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 626, (new NormalAttackAction.<>c__DisplayClass72_1 + 24))) || (!SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 626, (new NormalAttackAction.<>c__DisplayClass72_1 + 24)) && UnannouncedDestinationBuf.CheckActive(new NormalAttackAction.<>c__DisplayClass72_1.unannouncedDestinationBuf)) || (!SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 626, (new NormalAttackAction.<>c__DisplayClass72_1 + 24)) && UnannouncedDestinationBuf.CheckActive(new NormalAttackAction.<>c__DisplayClass72_1.unannouncedDestinationBuf) && (hasBuff(619)) ? ?undef : (SkillIndividualFlag | 64))) | 8) | 0x4000)` [อาวุธหลัก ธนู และ อาวุธรอง คาตานะ และ ไม่ `checkIchijhinnokaze` และ ไม่ `isUnsheatheMode`] หรือ `((!PlayerAttackBase.IsBlank(this)) || (PlayerAttackBase.IsBlank(this) && !UnityEngine.Object.op_Inequality(actarAction, 0)) || (!PlayerAttackBase.IsBlank(this) && !UnityEngine.Object.op_Inequality(actarAction, 0) && UnannouncedDestination.CheckMinimumBehavior(PlayerActionManagerBase.get_PlayerStatus(), (new NormalAttackAction.<>c__DisplayClass72_1 + 16))) ? ?undef : ((!SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 626, (new NormalAttackAction.<>c__DisplayClass72_1 + 24))) || (!SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 626, (new NormalAttackAction.<>c__DisplayClass72_1 + 24)) && UnannouncedDestinationBuf.CheckActive(new NormalAttackAction.<>c__DisplayClass72_1.unannouncedDestinationBuf)) || (!SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 626, (new NormalAttackAction.<>c__DisplayClass72_1 + 24)) && UnannouncedDestinationBuf.CheckActive(new NormalAttackAction.<>c__DisplayClass72_1.unannouncedDestinationBuf) && (hasBuff(619)) ? ?undef : (SkillIndividualFlag | 64))) | 8)` หรือ `(!NormalAttackAction.CheckOneChance(this, playerAction) ? ?undef : SkillIndividualFlag | 2048) | 4096` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_SystemInvincible` = ค่า System Invincible ของ MobActionManagerBase; `PlayerAttackBase.checkCriticalPercent` = ทอยคริติคอล (Critical − CriticalResist ของมอน จาก 100); `PlayerSecondaryStatus.CalcCritical` = คำนวณ critical (PlayerSecondaryStatus); `PlayerStatusBase.get_SecondaryStatus` = ค่า Secondary Status ของ PlayerStatusBase; `PlayerAttackBase.calcFastAttackDamageRate` = ตัวคูณของ Fast Attack (ดูแท็บ Variables)
- ตัวคูณตีแรก (`FirstAttackRate`, ×, บวกเข้าช่อง): **100%** → 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100% (Lv1…10)
- ความเสถียร (`StableRate`, ×, บวกเข้าช่อง): `PlayerAttackBase.CalcStable(3, Stableรวม, (!AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)) || ((AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) && PlayerAttackBase.CheckSkillIndividualFlag(this, 2)) ? 0 : 1), PlayerActionManagerBase.get_PlayerStatus())` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Stable` = ความเสถียร (Stability) %; `AbnormalStateManager.Contains` = ตัวละคร/มอนกำลังติดสถานะผิดปกตินี้อยู่หรือไม่; `PlayerStatusBase.get_AbnormalStatusManager` = ค่า Abnormal Status Manager ของ PlayerStatusBase; `PlayerAttackBase.CheckSkillIndividualFlag` = ตรวจ skill individual flag (PlayerAttackBase); `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `AbnormalType.Flash` = ตาพร่า (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, บวกเข้าช่อง): `target.ExpDefNormal / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefNormal` = proration ช่อง Normal ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, ×, บวกเข้าช่อง): `(!IsInstanceOf(mobAction, GuildRaidBossMobActionManager) ne 1) || (IsInstanceOf(mobAction, GuildRaidBossMobActionManager) eq 1 && (EnemyMobActionManagerBase.TryGetProperties<MobPropertyLifeReduceDamage>(mobAction, 90, stkp(-240))) ? PlayerAttackBase.CalcBufferLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus()) : (PlayerAttackBase.CalcBufferLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus()) - MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90))))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `MobPropertyLifeReduceDamage.CalcReduceLastDamageRate` = คำนวณ reduce last damage rate (MobPropertyLifeReduceDamage) (ดูแท็บ Variables)
- ต้านตามระยะ (`DistanceResistRate`, ×, บวกเข้าช่อง): `PlayerAttackBase.CalcDistanceResistRate(playerAction, mobAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.CalcDistanceResistRate` = ตัวคูณต้านระยะของมอน (ดูแท็บ Variables)
- ตัวคูณเจม (`GemDamageRate`, ×, บวกเข้าช่อง): `PlayerAttackBase.CalcGemLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus())` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.CalcGemLastDamageRate` = ตัวคูณดาเมจสุดท้ายจากเจมคาร์ท; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
- เพิ่มดาเมจเป้าติดสถานะ (`AbnormalDamageIncreaseRate`, ×, บวกเข้าช่อง): `CheckAbnormalDamageIncrease.out2(this, mobAction, PlayerAttackBase.CalcGemLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus()))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `CheckAbnormalDamageIncrease.out2` = CheckAbnormalDamageIncrease.out2; `PlayerAttackBase.CalcGemLastDamageRate` = ตัวคูณดาเมจสุดท้ายจากเจมคาร์ท; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
- พลังการ์ด (`GuardPower`, ตั้งค่า): `!MobBuffManager.TryGetBuff(A, 4, stkp(-248)) ? 25 : System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(A, 4)))` · `A = MobActionManagerBase.get_BuffManager(mobAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobBuffManager.TryGetBuff` = MobBuffManager.TryGetBuff; `MobActionManagerBase.get_BuffManager` = ค่า Buff Manager ของ MobActionManagerBase; `MobBuffer.GuardUpBuff.get_GuardUpval` = ค่า Guard Upval ของ GuardUpBuff; `TryGetBuff.buff` = TryGetBuff.buff (ดูแท็บ Variables)
- ตัวคูณล่าสมบัติ (`NormalAttackTreasureHuntLastDamageRate`, ×, บวกเข้าช่อง): `BonusManager.GetTreasureHuntLastDmgRateBonus(PlayerStatusBase.get_BonusManager())` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `BonusManager.GetTreasureHuntLastDmgRateBonus` = BonusManager.GetTreasureHuntLastDmgRateBonus; `PlayerStatusBase.get_BonusManager` = ค่า Bonus Manager ของ PlayerStatusBase (ดูแท็บ Variables)
- เพดานดาเมจ (`DamageLimit`, +, ตั้งค่าทับ): `max(int(target.MaxHp / 100), 1)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.MaxHp` = HP สูงสุดมอนสเตอร์; `target.MaxHp` = HP สูงสุดมอนสเตอร์ (ดูแท็บ Variables)
- ดาเมจต่ำสุด (`MinDamage`, +): `CheckDamageLimit.min(this, mobAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `CheckDamageLimit.min` = CheckDamageLimit.min (ดูแท็บ Variables)
- ดาเมจสูงสุด (`MaxDamage`, +): `CheckDamageLimit.max(this, mobAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `CheckDamageLimit.max` = CheckDamageLimit.max (ดูแท็บ Variables)
- ตัวคูณสุดท้ายตามอาวุธ (`SpecificWeaponLastDamage`, ×, บวกเข้าช่อง): `PlayerAttackBase.GetSpecificWeaponLastDamageRate(playerAction, mobAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.GetSpecificWeaponLastDamageRate` = PlayerAttackBase.GetSpecificWeaponLastDamageRate (ดูแท็บ Variables)

**ฮิต 2: `calcRampageFinish` (ท่าปิดของ Rampage) · ส่วน calcRampage (`calcRampage…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `NormalAttackAction.calcRampageConstantDamage(NormalAttackAction.calcRampageSkillRate(this, playerAction, 1), playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `NormalAttackAction.calcRampageConstantDamage` = คำนวณ rampage constant damage (NormalAttackAction); `NormalAttackAction.calcRampageSkillRate` = คำนวณ rampage skill rate (NormalAttackAction) (ดูแท็บ Variables)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `NormalAttackAction.calcRampageConstantDamage(NormalAttackAction.calcRampageSkillRate(this, playerAction, 2), playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `NormalAttackAction.calcRampageConstantDamage` = คำนวณ rampage constant damage (NormalAttackAction); `NormalAttackAction.calcRampageSkillRate` = คำนวณ rampage skill rate (NormalAttackAction) (ดูแท็บ Variables)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `NormalAttackAction.calcRampageConstantDamage(NormalAttackAction.calcRampageSkillRate(this, playerAction, 3), playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `NormalAttackAction.calcRampageConstantDamage` = คำนวณ rampage constant damage (NormalAttackAction); `NormalAttackAction.calcRampageSkillRate` = คำนวณ rampage skill rate (NormalAttackAction) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `NormalAttackAction.calcRampageSkillRate(this, playerAction, 1)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `NormalAttackAction.calcRampageSkillRate` = คำนวณ rampage skill rate (NormalAttackAction) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `NormalAttackAction.calcRampageSkillRate(this, playerAction, 2)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `NormalAttackAction.calcRampageSkillRate` = คำนวณ rampage skill rate (NormalAttackAction) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `NormalAttackAction.calcRampageSkillRate(this, playerAction, 3)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `NormalAttackAction.calcRampageSkillRate` = คำนวณ rampage skill rate (NormalAttackAction) (ดูแท็บ Variables)

**จำนวนฮิต / ตัวนับ**
- `damageCount` (ตั้งใน `UnsheatheWeaponAction`) [`!PlayerAttackBase.CheckSkillIndividualFlag(this, 1024)` และ `!PlayerAttackBase.CheckSkillIndividualFlag(this, 16)` และ `(SkillIndividualFlag & 0x2003) = 0` และ `WeaponType ≤ 16` และ … หรือ `!PlayerAttackBase.CheckSkillIndividualFlag(this, 1024)` และ `!PlayerAttackBase.CheckSkillIndividualFlag(this, 16)` และ `(SkillIndividualFlag & 0x2003) = 0` และ `WeaponType > 16` และ …]: 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 (Lv1…10)
- `damageCount` (ตั้งใน `OnInitialize`): 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 (Lv1…10)
- `LoopParam` (ตั้งใน `OnInitialize`): `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).dbData.Range`
- `damageCount` (ตั้งใน `ActionPreparation`): 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 (Lv1…10)
- `damageCount` (ตั้งใน `InitializeOthers`): 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 (Lv1…10)
- `damageCount` (ตั้งใน `ActionStartOthers`) [อาวุธหลัก ธนู และ อาวุธรอง คาตานะ และ `!PlayerAttackBase.CheckSkillIndividualFlag(this, 0x8000)` และ `isUnsheatheMode`]: 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 (Lv1…10)
- `damageCount` (ตั้งใน `ActionStartOthers`) [อาวุธหลัก ธนู และ อาวุธรอง คาตานะ และ `!PlayerAttackBase.CheckSkillIndividualFlag(this, 0x8000)` และ ไม่ `isUnsheatheMode`]: 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 (Lv1…10)
- `damageCount` (ตั้งใน `SetPowerWaveTake`) [`weaponType > 16`]: 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 (Lv1…10)

**ค่าบัพที่ขึ้นกับจำนวน stack**

- บัพ `SamuraiArcheryBuf` — `HitRate` ตามจำนวน `Count`: `Count × Lv`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
  | 2 | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |
  | 3 | 3 | 6 | 9 | 12 | 15 | 18 | 21 | 24 | 27 | 30 |
  | 4 | 4 | 8 | 12 | 16 | 20 | 24 | 28 | 32 | 36 | 40 |
  | 5 | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |
<!-- calc:end -->

### PhiloEclailAttackAction · uid 7

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `PhiloEclailAttackAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

<!-- calc:begin uid=7 -->
#### การคำนวณแบบตัวเลข — PhiloEclailAttackAction (uid 7)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจฐาน (`BaseDamage`, +, ตั้งค่าทับ): `PlayerAttackBase.calcBaseDamage(playerAction, mobAction, PhiloEclailAttackAction.get_AttackType(), 32768 × isDualSword, PlayerAttackBase.checkCriticalPercent(this, PlayerSecondaryStatus.CalcCritical(A, PlayerSecondaryStatus.GetCrtRate(A) + WrapAroundBuf.GetParam(43) / -100, PlayerSecondaryStatus.GetCrtConstant(A, 1) - ClearAndSereneBuf.GetParam(19)), mobAction) & 1)` · `A = PlayerStatusBase.get_SecondaryStatus()` — โดยที่ `isDualSword` = `1` [`PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type = 10` และ `PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 2).Type = 10`] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcBaseDamage` = ดาเมจฐาน = (ATK/MATK + ผลต่างเลเวลผู้เล่น-มอน [+ ATK อาวุธรอง×ความเสถี; `PhiloEclailAttackAction.get_AttackType` = ค่า Attack Type ของ PhiloEclailAttackAction; `PlayerAttackBase.checkCriticalPercent` = ทอยคริติคอล (Critical − CriticalResist ของมอน จาก 100); `PlayerSecondaryStatus.CalcCritical` = คำนวณ critical (PlayerSecondaryStatus); `PlayerStatusBase.get_SecondaryStatus` = ค่า Secondary Status ของ PlayerStatusBase; `WrapAroundBuf.GetParam` = WrapAroundBuf: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า) …(+1) (ดูแท็บ Variables)
- ดาเมจฐาน (`BaseDamage`, +, ตั้งค่าทับ): `PlayerAttackBase.calcBaseDamage(playerAction, mobAction, PhiloEclailAttackAction.get_AttackType(), 32768 × isDualSword, PlayerAttackBase.checkCriticalPercent(this, PlayerSecondaryStatus.CalcCritical(A, PlayerSecondaryStatus.GetCrtRate(A) + WrapAroundBuf.GetParam(43) / -100, PlayerSecondaryStatus.GetCrtConstant(A, 1)), mobAction) & 1)` · `A = PlayerStatusBase.get_SecondaryStatus()` — โดยที่ `isDualSword` = `1` [`PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type = 10` และ `PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 2).Type = 10`] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcBaseDamage` = ดาเมจฐาน = (ATK/MATK + ผลต่างเลเวลผู้เล่น-มอน [+ ATK อาวุธรอง×ความเสถี; `PhiloEclailAttackAction.get_AttackType` = ค่า Attack Type ของ PhiloEclailAttackAction; `PlayerAttackBase.checkCriticalPercent` = ทอยคริติคอล (Critical − CriticalResist ของมอน จาก 100); `PlayerSecondaryStatus.CalcCritical` = คำนวณ critical (PlayerSecondaryStatus); `PlayerStatusBase.get_SecondaryStatus` = ค่า Secondary Status ของ PlayerStatusBase; `WrapAroundBuf.GetParam` = WrapAroundBuf: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า) (ดูแท็บ Variables)
- ดาเมจฐาน (`BaseDamage`, +, ตั้งค่าทับ): `PlayerAttackBase.calcBaseDamage(playerAction, mobAction, PhiloEclailAttackAction.get_AttackType(), 32768 × isDualSword, PlayerAttackBase.checkCriticalPercent(this, PlayerSecondaryStatus.CalcCritical(A, PlayerSecondaryStatus.GetCrtRate(A), PlayerSecondaryStatus.GetCrtConstant(A, 1) - ClearAndSereneBuf.GetParam(19)), mobAction) & 1)` · `A = PlayerStatusBase.get_SecondaryStatus()` — โดยที่ `isDualSword` = `1` [`PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type = 10` และ `PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 2).Type = 10`] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcBaseDamage` = ดาเมจฐาน = (ATK/MATK + ผลต่างเลเวลผู้เล่น-มอน [+ ATK อาวุธรอง×ความเสถี; `PhiloEclailAttackAction.get_AttackType` = ค่า Attack Type ของ PhiloEclailAttackAction; `PlayerAttackBase.checkCriticalPercent` = ทอยคริติคอล (Critical − CriticalResist ของมอน จาก 100); `PlayerSecondaryStatus.CalcCritical` = คำนวณ critical (PlayerSecondaryStatus); `PlayerStatusBase.get_SecondaryStatus` = ค่า Secondary Status ของ PlayerStatusBase; `ClearAndSereneBuf.GetParam` = ClearAndSereneBuf: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า) (ดูแท็บ Variables)
- ดาเมจฐาน (`BaseDamage`, +, ตั้งค่าทับ): `PlayerAttackBase.calcBaseDamage(playerAction, mobAction, PhiloEclailAttackAction.get_AttackType(), 32768 × isDualSword, PlayerAttackBase.checkCriticalPercent(this, PlayerSecondaryStatus.CalcCritical(A, PlayerSecondaryStatus.GetCrtRate(A), PlayerSecondaryStatus.GetCrtConstant(A, 1)), mobAction) & 1)` · `A = PlayerStatusBase.get_SecondaryStatus()` — โดยที่ `isDualSword` = `1` [`PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type = 10` และ `PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 2).Type = 10`] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcBaseDamage` = ดาเมจฐาน = (ATK/MATK + ผลต่างเลเวลผู้เล่น-มอน [+ ATK อาวุธรอง×ความเสถี; `PhiloEclailAttackAction.get_AttackType` = ค่า Attack Type ของ PhiloEclailAttackAction; `PlayerAttackBase.checkCriticalPercent` = ทอยคริติคอล (Critical − CriticalResist ของมอน จาก 100); `PlayerSecondaryStatus.CalcCritical` = คำนวณ critical (PlayerSecondaryStatus); `PlayerStatusBase.get_SecondaryStatus` = ค่า Secondary Status ของ PlayerStatusBase (ดูแท็บ Variables)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **100 + 10×Lv** → 110, 120, 130, 140, 150, 160, 170, 180, 190, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `skillRate` — โดยที่ `skillRate` = `((PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 1).Type eq 10 ? (((Lv * 15) + 50) + 50) : ((Lv * 15) + 50)) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
<!-- calc:end -->

### AvoidAction · uid 8

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `AvoidAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: แอ็กชันระบบ/อรรถประโยชน์
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration

### FirstAidAction · uid 9

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `FirstAidAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- MP ที่ใช้: `FirstAidBuf.GetParam(14)`
- MP ที่ใช้: 100
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `FirstAidBuf`: MP ของปฐมพยาบาล (`FirstAidCost`) = 100 + 100×Lv → 200, 300, 400, 500, 600, 700, 800, 900, 1000, 1100 (Lv1…10)

### DamageReflectionAction · uid 10

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `DamageReflectionAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: แอ็กชันระบบ/อรรถประโยชน์
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · ไม่เปลี่ยนค่า proration

### PhysicalPursuitAction · uid 11

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `PhysicalPursuitAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · ไม่เปลี่ยนค่า proration

<!-- calc:begin uid=11 -->
#### การคำนวณแบบตัวเลข — PhysicalPursuitAction (uid 11)
Proration: ช่อง `Skill` โหมด `never (IsExpSkill excludes ActionID)`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`PlayerAttackBase.checkMobReaction(this, target.GuardProbability) = 2` และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 50) ≠ 0`]: `(SkillBufferDataBase.GetParam(85) + EquipBuffManager.GetParam(PlayerStatusBase.get_EquipBuffManager(), 153)) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `SkillBufferDataBase.GetParam` = ค่าพารามิเตอร์ของบัพตาม SkillBufferId; `EquipBuffManager.GetParam` = EquipBuffManager: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า); `PlayerStatusBase.get_EquipBuffManager` = ค่า Equip Buff Manager ของ PlayerStatusBase; `BonusType.bPhysicalPursuit` = โบนัส «เพิ่มการโจมตีด้วยอาวุธ ค่า%» (id 153 ตรงกับข้อความไอเทม) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`PlayerAttackBase.checkMobReaction(this, target.GuardProbability) = 2`]: `EquipBuffManager.GetParam(PlayerStatusBase.get_EquipBuffManager(), 153) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `EquipBuffManager.GetParam` = EquipBuffManager: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า); `PlayerStatusBase.get_EquipBuffManager` = ค่า Equip Buff Manager ของ PlayerStatusBase; `BonusType.bPhysicalPursuit` = โบนัส «เพิ่มการโจมตีด้วยอาวุธ ค่า%» (id 153 ตรงกับข้อความไอเทม) (ดูแท็บ Variables)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`PlayerAttackBase.checkMobReaction(this, target.GuardProbability) = 2` และ `TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ≠ 0`]: `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobBuffer.GuardUpBuff.get_GuardUpval` = ค่า Guard Upval ของ GuardUpBuff; `TryGetBuff.buff` = TryGetBuff.buff; `MobActionManagerBase.get_BuffManager` = ค่า Buff Manager ของ MobActionManagerBase (ดูแท็บ Variables)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`PlayerAttackBase.checkMobReaction(this, target.GuardProbability) = 2`]: **25** → 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 (Lv1…10)
<!-- calc:end -->

### MagicPursuitAction · uid 12

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `MagicPursuitAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · ไม่เปลี่ยนค่า proration

<!-- calc:begin uid=12 -->
#### การคำนวณแบบตัวเลข — MagicPursuitAction (uid 12)
Proration: ช่อง `Magic` โหมด `never (IsExpSkill excludes ActionID)`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `(((EquipBuffManager.GetParam(PlayerStatusBase.get_EquipBuffManager(), 154) + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1032], 50)) + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[982], 86)) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `EquipBuffManager.GetParam` = EquipBuffManager: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า); `PlayerStatusBase.get_EquipBuffManager` = ค่า Equip Buff Manager ของ PlayerStatusBase; `SkillBufferDataBase.GetParam` = ค่าพารามิเตอร์ของบัพตาม SkillBufferId; `PlayerStatusBase.get_SkillBufferManager` = ค่า Skill Buffer Manager ของ PlayerStatusBase; `BonusType.bMagicPursuit` = โบนัส «เพิ่มการโจมตีด้วยเวทมนตร์ ค่า%» (id 154 ตรงกับข้อความไอเทม); `SkillBufferId.Value` = ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) …(+1) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `((EquipBuffManager.GetParam(PlayerStatusBase.get_EquipBuffManager(), 154) + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1032], 50)) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `EquipBuffManager.GetParam` = EquipBuffManager: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า); `PlayerStatusBase.get_EquipBuffManager` = ค่า Equip Buff Manager ของ PlayerStatusBase; `SkillBufferDataBase.GetParam` = ค่าพารามิเตอร์ของบัพตาม SkillBufferId; `PlayerStatusBase.get_SkillBufferManager` = ค่า Skill Buffer Manager ของ PlayerStatusBase; `BonusType.bMagicPursuit` = โบนัส «เพิ่มการโจมตีด้วยเวทมนตร์ ค่า%» (id 154 ตรงกับข้อความไอเทม); `SkillBufferId.Value` = ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `((EquipBuffManager.GetParam(PlayerStatusBase.get_EquipBuffManager(), 154) + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[982], 86)) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `EquipBuffManager.GetParam` = EquipBuffManager: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า); `PlayerStatusBase.get_EquipBuffManager` = ค่า Equip Buff Manager ของ PlayerStatusBase; `SkillBufferDataBase.GetParam` = ค่าพารามิเตอร์ของบัพตาม SkillBufferId; `PlayerStatusBase.get_SkillBufferManager` = ค่า Skill Buffer Manager ของ PlayerStatusBase; `BonusType.bMagicPursuit` = โบนัส «เพิ่มการโจมตีด้วยเวทมนตร์ ค่า%» (id 154 ตรงกับข้อความไอเทม); `SkillBufferId.MagiclPursuitSkillRate` = ตัวคูณโจมตีไล่ตามเวท (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `EquipBuffManager.GetParam(PlayerStatusBase.get_EquipBuffManager(), 154) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `EquipBuffManager.GetParam` = EquipBuffManager: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า); `PlayerStatusBase.get_EquipBuffManager` = ค่า Equip Buff Manager ของ PlayerStatusBase; `BonusType.bMagicPursuit` = โบนัส «เพิ่มการโจมตีด้วยเวทมนตร์ ค่า%» (id 154 ตรงกับข้อความไอเทม) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `(((EquipBuffManager.GetParam(PlayerStatusBase.get_EquipBuffManager(), 154) + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1025], 50)) + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[982], 86)) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `EquipBuffManager.GetParam` = EquipBuffManager: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า); `PlayerStatusBase.get_EquipBuffManager` = ค่า Equip Buff Manager ของ PlayerStatusBase; `SkillBufferDataBase.GetParam` = ค่าพารามิเตอร์ของบัพตาม SkillBufferId; `PlayerStatusBase.get_SkillBufferManager` = ค่า Skill Buffer Manager ของ PlayerStatusBase; `BonusType.bMagicPursuit` = โบนัส «เพิ่มการโจมตีด้วยเวทมนตร์ ค่า%» (id 154 ตรงกับข้อความไอเทม); `SkillBufferId.Value` = ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) …(+1) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `((EquipBuffManager.GetParam(PlayerStatusBase.get_EquipBuffManager(), 154) + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1025], 50)) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `EquipBuffManager.GetParam` = EquipBuffManager: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า); `PlayerStatusBase.get_EquipBuffManager` = ค่า Equip Buff Manager ของ PlayerStatusBase; `SkillBufferDataBase.GetParam` = ค่าพารามิเตอร์ของบัพตาม SkillBufferId; `PlayerStatusBase.get_SkillBufferManager` = ค่า Skill Buffer Manager ของ PlayerStatusBase; `BonusType.bMagicPursuit` = โบนัส «เพิ่มการโจมตีด้วยเวทมนตร์ ค่า%» (id 154 ตรงกับข้อความไอเทม); `SkillBufferId.Value` = ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (ดูแท็บ Variables)

**ใช้ร่วมทุกฮิตของ ฮิตรีแอ็กชัน (`HitReactionAssign`)**
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical)` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobBuffer.GuardUpBuff.get_GuardUpval` = ค่า Guard Upval ของ GuardUpBuff; `TryGetBuff.buff` = TryGetBuff.buff; `MobActionManagerBase.get_BuffManager` = ค่า Buff Manager ของ MobActionManagerBase (ดูแท็บ Variables)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) = 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: **25** → 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 (Lv1…10)
<!-- calc:end -->

### PetBlankMpHeel · uid 13

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `PetBlankMpHeel`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: แอ็กชันระบบ/อรรถประโยชน์
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration

### SkillChargeAction · uid 14

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `SkillChargeAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- MP ที่ใช้ [`baseSkillId = 112` และ `baseSkillId > 111` และ `baseSkillId ≠ 1155` และ `baseSkillId ≠ 718`]: 0
- MP ที่ใช้ [`baseSkillId = 718` และ `baseSkillId > 111` และ `baseSkillId ≠ 1155` หรือ `baseSkillId = 76` และ `baseSkillId ≤ 111` และ `baseSkillId ≠ 0`]: 400
- MP ที่ใช้ [`baseSkillId = 1155` และ `baseSkillId > 111`]: 500
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `MagicCannonBuf`: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `chargeValue` (ตัวนับที่เปลี่ยนตามเหตุการณ์); Next(): `chargeTimer` = `1`; Next(): `chargeValue` = `(((chargeValue lt 0x2710 ? 100 : 50) + chargeValue) lt 0x4e20 ? ((chargeValue lt 0x2710 ? 100 : 50) + chargeValue) : 0x4e20)`; Next(): `Count` = `(Max lt ((((chargeValue lt 0x2710 ? 100 : 50) + chargeValue) lt 0x4e20 ? ((chargeValue lt 0x2710 ? 100 : 50) + chargeValue) : 0x4e20) // 100) ? Max : ((((chargeValue lt 0x2710 ? 100 : 50) + chargeValue) lt 0x4e20 ? ((chargeValue lt 0x2710 ? 100 : 50) + chargeValue) : 0x4e20) // 100))` · ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); Next(): `chargeTimer` = `1`; Next(): `chargeValue` = `(((chargeValue lt 0x2710 ? 100 : 50) + chargeValue) lt 0x4e20 ? ((chargeValue lt 0x2710 ? 100 : 50) + chargeValue) : 0x4e20)`; Next(): `Count` = `(Max lt ((((chargeValue lt 0x2710 ? 100 : 50) + chargeValue) lt 0x4e20 ? ((chargeValue lt 0x2710 ? 100 : 50) + chargeValue) : 0x4e20) // 100) ? Max : ((((chargeValue lt 0x2710 ? 100 : 50) + chargeValue) lt 0x4e20 ? ((chargeValue lt 0x2710 ? 100 : 50) + chargeValue) : 0x4e20) // 100))`
- บัพ `SlashReaperBuf`: บัพนับสแตก (สืบจาก `CountBufferBase`): ตัวนับ `Count` เริ่ม 0 เพิ่มทีละ 1 ด้วย `Next()` และสูงสุด Lv; โค้ดอื่นอ่านจำนวนสแตกผ่านพารามิเตอร์ `Count` (ดูค่าที่ใช้จริงในสูตรของสกิลที่อ้างถึง)
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 200 ตามที่ `MagicCannonBuf` ส่งให้ตัวสร้างของ `บัพฐาน`; สแตกสูงสุด (`Max`) = Lv ตามที่ `SlashReaperBuf` ส่งให้ตัวสร้างของ `บัพฐาน`

### CronosDrivePursuitAction · uid 15

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `CronosDrivePursuitAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: ไม่มีประเภท (None)
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration

<!-- calc:begin uid=15 -->
#### การคำนวณแบบตัวเลข — CronosDrivePursuitAction (uid 15)
Proration: ช่อง `none` โหมด `never (ExpType None: no proration slot)`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `isGuard ≠ 0`**
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `IsMagicAttack = 0` และ `target.AvoidProbability ≤ 99` และ `target.GuardProbability > 99` หรือ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `IsMagicAttack = 0` และ `target.AvoidProbability ≤ 99` และ `target.GuardProbability ≤ 99`]: `target.ExpDefSkill / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefSkill` = proration ช่อง Skill ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `IsMagicAttack ≠ 0` และ `target.AvoidProbability ≤ 99` และ `target.GuardProbability > 99` หรือ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `IsMagicAttack ≠ 0` และ `target.AvoidProbability ≤ 99` และ `target.GuardProbability ≤ 99`]: `target.ExpDefMagic / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefMagic` = proration ช่อง Magic ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `IsMagicAttack = 0` และ `TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ≠ 0` และ `target.AvoidProbability ≤ 99` และ … หรือ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `IsMagicAttack ≠ 0` และ `TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ≠ 0` และ `target.AvoidProbability ≤ 99` และ … หรือ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `IsMagicAttack = 0` และ `TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ≠ 0` และ `target.AvoidProbability ≤ 99` และ …]: `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobBuffer.GuardUpBuff.get_GuardUpval` = ค่า Guard Upval ของ GuardUpBuff; `TryGetBuff.buff` = TryGetBuff.buff; `MobActionManagerBase.get_BuffManager` = ค่า Buff Manager ของ MobActionManagerBase (ดูแท็บ Variables)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `IsMagicAttack = 0` และ `target.AvoidProbability ≤ 99` และ `target.GuardProbability > 99` หรือ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `IsMagicAttack ≠ 0` และ `target.AvoidProbability ≤ 99` และ `target.GuardProbability > 99` หรือ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `IsMagicAttack = 0` และ `target.AvoidProbability ≤ 99` และ `target.GuardProbability ≤ 99`]: **25** → 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 (Lv1…10)

**ใช้ร่วมทุกฮิตของ ดาเมจหลัก**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +, ตั้งค่าทับ) [`!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `IsMagicAttack = 0` และ `target.AvoidProbability ≤ 99` และ `target.GuardProbability > 99` หรือ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `IsMagicAttack ≠ 0` และ `target.AvoidProbability ≤ 99` และ `target.GuardProbability > 99`]: **250 + 25×Lv** → 275, 300, 325, 350, 375, 400, 425, 450, 475, 500 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, ตั้งค่าทับ) [`IsInstanceOf(actarAction, PlayerActionManagerBase) ≠ 1` และ มีเจมคาร์ท 409 และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `IsMagicAttack = 0` และ … หรือ `IsInstanceOf(actarAction, PlayerActionManagerBase) ≠ 1` และ มีเจมคาร์ท 409 และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `IsMagicAttack ≠ 0` และ … หรือ ไม่มีเจมคาร์ท 409 และ `IsMagicAttack ≠ 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `target.AvoidProbability ≤ 99` และ … · INT รวม=100 หรือ `IsInstanceOf(actarAction, PlayerActionManagerBase) = 1` และ มีเจมคาร์ท 409 และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `IsMagicAttack = 0` และ … หรือ `IsInstanceOf(actarAction, PlayerActionManagerBase) = 1` และ มีเจมคาร์ท 409 และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `IsMagicAttack ≠ 0` และ … หรือ ไม่มีเจมคาร์ท 409 และ `IsMagicAttack = 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `target.AvoidProbability ≤ 99` และ … · STR รวม=100]: **(60 + Lv)%** → 61%, 62%, 63%, 64%, 65%, 66%, 67%, 68%, 69%, 70% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, ตั้งค่าทับ) [`IsInstanceOf(actarAction, PlayerActionManagerBase) ≠ 1` และ มีเจมคาร์ท 409 และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `IsMagicAttack = 0` และ … หรือ `IsInstanceOf(actarAction, PlayerActionManagerBase) ≠ 1` และ มีเจมคาร์ท 409 และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `IsMagicAttack ≠ 0` และ … หรือ ไม่มีเจมคาร์ท 409 และ `IsMagicAttack ≠ 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `target.AvoidProbability ≤ 99` และ … · INT รวม=255 หรือ `IsInstanceOf(actarAction, PlayerActionManagerBase) = 1` และ มีเจมคาร์ท 409 และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `IsMagicAttack = 0` และ … หรือ `IsInstanceOf(actarAction, PlayerActionManagerBase) = 1` และ มีเจมคาร์ท 409 และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `IsMagicAttack ≠ 0` และ … หรือ ไม่มีเจมคาร์ท 409 และ `IsMagicAttack = 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `target.AvoidProbability ≤ 99` และ … · STR รวม=255]: **(91 + Lv)%** → 92%, 93%, 94%, 95%, 96%, 97%, 98%, 99%, 100%, 101% (Lv1…10)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `ActionStart`) [`Lv ≠ 10`]: 5, 5, 6, 6, 7, 7, 8, 8, 9, 9 (Lv1…10)
- `LoopParam` (ตั้งใน `ActionStart`) [`Lv = 10`]: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
<!-- calc:end -->

### BeautiesOfNatureHealAction · uid 16

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `BeautiesOfNatureHealAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: แอ็กชันระบบ/อรรถประโยชน์
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration

### ComboRelfectionAction · uid 17

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `ComboRelfectionAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 3 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: ธรรมดา (SkillNormal)
- Proration: ช่องตีปกติ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

<!-- calc:begin uid=17 -->
#### การคำนวณแบบตัวเลข — ComboRelfectionAction (uid 17)
Proration: ช่อง `Normal` โหมด `first_hit_per_target if class check passes`

**ฮิต 1: `calcPlayerToMobDamage` (สูตรโจมตีปกติ (`NormalAttackAction`)) · ส่วน calcRampage (`calcRampage…`)**
- ดาเมจฐาน (`BaseDamage`, +): `NormalAttackAction.CalcBaseDamage(this, playerAction, mobAction, !MobActionManagerBase.get_SystemInvincible(mobAction) ? 0 : ((System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValuePlayerStatusBase.get_SkillBufferManager().skillBufList, 639, stkp(-184), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) ? ((PlayerAttackBase.checkCriticalPercent(this, PlayerSecondaryStatus.CalcCritical(PlayerStatusBase.get_SecondaryStatus(), PlayerSecondaryStatus.GetCrtRate(PlayerStatusBase.get_SecondaryStatus()), PlayerSecondaryStatus.GetCrtConstant(PlayerStatusBase.get_SecondaryStatus(), ((SkillIndividualFlag & 2) eq 0 ? 1 : 0))), mobAction) ? 2 : 1) : 2)))` — โดยที่ `SkillIndividualFlag` = `(!NormalAttackAction.CheckOneChance(this, playerAction) ? ?undef : SkillIndividualFlag | 2048) | 4096` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `NormalAttackAction.CalcBaseDamage` = ดาเมจฐานของการโจมตีปกติ; `MobActionManagerBase.get_SystemInvincible` = ค่า System Invincible ของ MobActionManagerBase; `PlayerAttackBase.checkCriticalPercent` = ทอยคริติคอล (Critical − CriticalResist ของมอน จาก 100); `PlayerSecondaryStatus.CalcCritical` = คำนวณ critical (PlayerSecondaryStatus); `PlayerStatusBase.get_SecondaryStatus` = ค่า Secondary Status ของ PlayerStatusBase (ดูแท็บ Variables)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `buffParam(NormalAttackConstantDamage)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `NormalAttackAction.calcRampageConstantDamage(this_tpl(), playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `NormalAttackAction.calcRampageConstantDamage` = คำนวณ rampage constant damage (NormalAttackAction) (ดูแท็บ Variables)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `ArkSaber.CalcConstantDamage(playerAction, mobAction) ÷ 2` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `UnannouncedDestination.CalcNormalAttackConstantDamage(PlayerActionManagerBase.get_PlayerStatus())` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `UnannouncedDestination.CalcNormalAttackConstantDamage` = คำนวณ normal attack constant damage (UnannouncedDestination); `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `IchijhinnokazeBuf.GetNormalAttackConstantDamage(PlayerActionManagerBase.get_PlayerStatus())` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `IchijhinnokazeBuf.GetNormalAttackConstantDamage` = IchijhinnokazeBuf.GetNormalAttackConstantDamage; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
- หักป้องกันเป้า (`Def`, +): `-NormalAttackAction.CalcDef(this, playerAction, เป้า)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `NormalAttackAction.CalcDef` = คำนวณ def (NormalAttackAction); `MobActionManagerBase.get_MobBattleStatus` = ค่า Mob Battle Status ของ MobActionManagerBase (ดูแท็บ Variables)
- ดาเมจคงที่ตีแรก (`FirstAttack`, +): `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamage` = ดาเมจคงที่ของ Fast Attack (ดูแท็บ Variables)
- ดาเมจคงที่ตีแรก (`FirstAttack`, +): **0** → 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 (Lv1…10)
- ตัวคูณคริติคอลเพิ่ม (`CriticalRate`, ×, บวกเข้าช่อง): `CriticalDmgรวม / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.CriticalDmg` = ดาเมจคริติคอลกายภาพ % (ใช้เป็น CriticalDmg/100) (ดูแท็บ Variables)
- ตัวคูณคริติคอลเพิ่ม (`CriticalRate`, ×, บวกเข้าช่อง): **100%** → 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100% (Lv1…10)
- โบนัสธาตุ (`ElementBonusRate`, ×, บวกเข้าช่อง): `PlayerAttackBase.CalcElementBonus(this, PlayerActionManagerBase.get_PlayerStatus(), NormalAttackAction.get_AttackType(), target.Element)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.Element` = ธาตุของมอน; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `NormalAttackAction.get_AttackType` = ค่า Attack Type ของ NormalAttackAction (ดูแท็บ Variables)
- ต้านธาตุ (`NormalElementDamageResistRate`, ×, บวกเข้าช่อง): `PlayerAttackBase.CalcNormalElementWeaponDamageResistRate(PlayerActionManagerBase.get_PlayerStatus(), mobAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.CalcNormalElementWeaponDamageResistRate` = ตัวคูณต้านธาตุของอาวุธ; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
- power wave ตีปกติ (`NormalAttackPowerWave`, ×, บวกเข้าช่อง): `powerWaveRate` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `(checkIchijhinnokaze eq 0 ? !PlayerAttackBase.CheckSkillIndividualFlag(this, 1024) ? (!NormalAttackAction.calcRampageSkillRate(this, playerAction, 0) + (buffParam(NormalAttackRate) / 100)) + (GemCartBufferManager.GetNormalAttackRate(PlayerStatusBase.get_GemCartBuffManager()) * 0.01)) : ((PlayerAttackBase.CheckSkillIndividualFlag(this, 1024) && (System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValuePlayerStatusBase.get_SkillManager().SkillMasteryList, 297, stkp(-232), meta(0x3974490, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.TryGetValue())) ? (((System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValuePlayerStatusBase.get_SkillManager().SkillMasteryList, 296, stkp(-232), meta(0x3974490, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.TryGetValue())) ? (!NormalAttackAction.calcRampageSkillRate(this, playerAction, 0) + (buffParam(NormalAttackRate) / 100)) + (GemCartBufferManager.GetNormalAttackRate(PlayerStatusBase.get_GemCartBuffManager()) * 0.01)) : (((NormalAttackAction.calcRampageSkillRate(this, playerAction, 0) + (buffParam(NormalAttackRate) / 100)) + (GemCartBufferManager.GetNormalAttackRate(PlayerStatusBase.get_GemCartBuffManager()) * 0.01)) + (SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) / 100))) + (SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) / 100)) : ((System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue(PlayerStatusBase.get_SkillManager().SkillMasteryList, 296, stkp(-232), meta(0x3974490, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.TryGetValue())) ? (!NormalAttackAction.calcRampageSkillRate(this, playerAction, 0) + (buffParam(NormalAttackRate) / 100)) + (GemCartBufferManager.GetNormalAttackRate(PlayerStatusBase.get_GemCartBuffManager()) * 0.01)) : (((NormalAttackAction.calcRampageSkillRate(this, playerAction, 0) + (buffParam(NormalAttackRate) / 100)) + (GemCartBufferManager.GetNormalAttackRate(PlayerStatusBase.get_GemCartBuffManager()) * 0.01)) + (SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) / 100))))) : (((PlayerAttackBase.CheckSkillIndividualFlag(this, 1024) ? (!NormalAttackAction.calcRampageSkillRate(this, playerAction, 0) + (buffParam(NormalAttackRate) / 100)) + (GemCartBufferManager.GetNormalAttackRate(PlayerStatusBase.get_GemCartBuffManager()) * 0.01)) : ((PlayerAttackBase.CheckSkillIndividualFlag(this, 1024) && (System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValuePlayerStatusBase.get_SkillManager().SkillMasteryList, 297, stkp(-232), meta(0x3974490, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.TryGetValue())) ? (((System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue(PlayerStatusBase.get_SkillManager().SkillMasteryList, 296, stkp(-232), meta(0x3974490, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.TryGetValue())) ? (!NormalAttackAction.calcRampageSkillRate(this, playerAction, 0) + (buffParam(NormalAttackRate) / 100)) + (GemCartBufferManager.GetNormalAttackRate(PlayerStatusBase.get_GemCartBuffManager()) * 0.01)) : (((NormalAttackAction.calcRampageSkillRate(this, playerAction, 0) + (buffParam(NormalAttackRate) / 100)) + (GemCartBufferManager.GetNormalAttackRate(PlayerStatusBase.get_GemCartBuffManager()) * 0.01)) + (SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) / 100))) + (SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) / 100)) : ((System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue(PlayerStatusBase.get_SkillManager().SkillMasteryList, 296, stkp(-232), meta(0x3974490, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.TryGetValue())) ? ((NormalAttackAction.calcRampageSkillRate(this, playerAction, 0) + (buffParam(NormalAttackRate) / 100)) + (GemCartBufferManager.GetNormalAttackRate(PlayerStatusBase.get_GemCartBuffManager()) * 0.01)) : (((NormalAttackAction.calcRampageSkillRate(this, playerAction, 0) + (buffParam(NormalAttackRate) / 100)) + (GemCartBufferManager.GetNormalAttackRate(PlayerStatusBase.get_GemCartBuffManager()) * 0.01)) + (SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) / 100))))) + ((IchijhinnokazeBuf.GetNormalAttackSkillRate(PlayerActionManagerBase.get_PlayerStatus()) + IchijhinnokazeAratame.GetNormalAttackSkillRateBonus(PlayerActionManagerBase.get_PlayerStatus())) / 100)))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.CheckSkillIndividualFlag` = ตรวจ skill individual flag (PlayerAttackBase); `NormalAttackAction.calcRampageSkillRate` = คำนวณ rampage skill rate (NormalAttackAction); `GemCartBufferManager.GetNormalAttackRate` = GemCartBufferManager.GetNormalAttackRate; `PlayerStatusBase.get_GemCartBuffManager` = ค่า Gem Cart Buff Manager ของ PlayerStatusBase; `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `PlayerStatusBase.get_SkillManager` = ค่า Skill Manager ของ PlayerStatusBase …(+4) (ดูแท็บ Variables)
- ตัวคูณตีแรก (`FirstAttackRate`, ×, บวกเข้าช่อง): `PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamageRate` = ตัวคูณของ Fast Attack (ดูแท็บ Variables)
- ตัวคูณตีแรก (`FirstAttackRate`, ×, บวกเข้าช่อง): `(isUnsheatheMode ne 0 && !MobActionManagerBase.get_SystemInvincible(mobAction) ? 0 : ((System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValuePlayerStatusBase.get_SkillBufferManager().skillBufList, 639, stkp(-184), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) ? ((PlayerAttackBase.checkCriticalPercent(this, PlayerSecondaryStatus.CalcCritical(PlayerStatusBase.get_SecondaryStatus(), PlayerSecondaryStatus.GetCrtRate(PlayerStatusBase.get_SecondaryStatus()), PlayerSecondaryStatus.GetCrtConstant(PlayerStatusBase.get_SecondaryStatus(), ((SkillIndividualFlag & 2) eq 0 ? 1 : 0))), mobAction) ? 2 : 1) : 2)) ne 2 ? (PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100) : 1)` — โดยที่ `SkillIndividualFlag` = `(!NormalAttackAction.CheckOneChance(this, playerAction) ? ?undef : SkillIndividualFlag | 2048) | 4096` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_SystemInvincible` = ค่า System Invincible ของ MobActionManagerBase; `PlayerAttackBase.checkCriticalPercent` = ทอยคริติคอล (Critical − CriticalResist ของมอน จาก 100); `PlayerSecondaryStatus.CalcCritical` = คำนวณ critical (PlayerSecondaryStatus); `PlayerStatusBase.get_SecondaryStatus` = ค่า Secondary Status ของ PlayerStatusBase; `PlayerAttackBase.calcFastAttackDamageRate` = ตัวคูณของ Fast Attack (ดูแท็บ Variables)
- ตัวคูณตีแรก (`FirstAttackRate`, ×, บวกเข้าช่อง): **100%** → 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100% (Lv1…10)
- ความเสถียร (`StableRate`, ×, บวกเข้าช่อง): `PlayerAttackBase.CalcStable(3, Stableรวม, (!AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)) || ((AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) && PlayerAttackBase.CheckSkillIndividualFlag(this, 2)) ? 0 : 1), PlayerActionManagerBase.get_PlayerStatus())` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Stable` = ความเสถียร (Stability) %; `AbnormalStateManager.Contains` = ตัวละคร/มอนกำลังติดสถานะผิดปกตินี้อยู่หรือไม่; `PlayerStatusBase.get_AbnormalStatusManager` = ค่า Abnormal Status Manager ของ PlayerStatusBase; `PlayerAttackBase.CheckSkillIndividualFlag` = ตรวจ skill individual flag (PlayerAttackBase); `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `AbnormalType.Flash` = ตาพร่า (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, บวกเข้าช่อง): `target.ExpDefNormal / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefNormal` = proration ช่อง Normal ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, ×, บวกเข้าช่อง): `(!IsInstanceOf(mobAction, GuildRaidBossMobActionManager) ne 1) || (IsInstanceOf(mobAction, GuildRaidBossMobActionManager) eq 1 && (EnemyMobActionManagerBase.TryGetProperties<MobPropertyLifeReduceDamage>(mobAction, 90, stkp(-240))) ? PlayerAttackBase.CalcBufferLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus()) : (PlayerAttackBase.CalcBufferLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus()) - MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90))))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `MobPropertyLifeReduceDamage.CalcReduceLastDamageRate` = คำนวณ reduce last damage rate (MobPropertyLifeReduceDamage) (ดูแท็บ Variables)
- ต้านตามระยะ (`DistanceResistRate`, ×, บวกเข้าช่อง): `PlayerAttackBase.CalcDistanceResistRate(playerAction, mobAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.CalcDistanceResistRate` = ตัวคูณต้านระยะของมอน (ดูแท็บ Variables)
- ตัวคูณเจม (`GemDamageRate`, ×, บวกเข้าช่อง): `PlayerAttackBase.CalcGemLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus())` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.CalcGemLastDamageRate` = ตัวคูณดาเมจสุดท้ายจากเจมคาร์ท; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
- เพิ่มดาเมจเป้าติดสถานะ (`AbnormalDamageIncreaseRate`, ×, บวกเข้าช่อง): `CheckAbnormalDamageIncrease.out2(this, mobAction, PlayerAttackBase.CalcGemLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus()))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `CheckAbnormalDamageIncrease.out2` = CheckAbnormalDamageIncrease.out2; `PlayerAttackBase.CalcGemLastDamageRate` = ตัวคูณดาเมจสุดท้ายจากเจมคาร์ท; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
- พลังการ์ด (`GuardPower`, ตั้งค่า): `!MobBuffManager.TryGetBuff(A, 4, stkp(-248)) ? 25 : System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(A, 4)))` · `A = MobActionManagerBase.get_BuffManager(mobAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobBuffManager.TryGetBuff` = MobBuffManager.TryGetBuff; `MobActionManagerBase.get_BuffManager` = ค่า Buff Manager ของ MobActionManagerBase; `MobBuffer.GuardUpBuff.get_GuardUpval` = ค่า Guard Upval ของ GuardUpBuff; `TryGetBuff.buff` = TryGetBuff.buff (ดูแท็บ Variables)
- ตัวคูณล่าสมบัติ (`NormalAttackTreasureHuntLastDamageRate`, ×, บวกเข้าช่อง): `BonusManager.GetTreasureHuntLastDmgRateBonus(PlayerStatusBase.get_BonusManager())` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `BonusManager.GetTreasureHuntLastDmgRateBonus` = BonusManager.GetTreasureHuntLastDmgRateBonus; `PlayerStatusBase.get_BonusManager` = ค่า Bonus Manager ของ PlayerStatusBase (ดูแท็บ Variables)
- เพดานดาเมจ (`DamageLimit`, +, ตั้งค่าทับ): `max(int(target.MaxHp / 100), 1)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.MaxHp` = HP สูงสุดมอนสเตอร์; `target.MaxHp` = HP สูงสุดมอนสเตอร์ (ดูแท็บ Variables)
- ดาเมจต่ำสุด (`MinDamage`, +): `CheckDamageLimit.min(this, mobAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `CheckDamageLimit.min` = CheckDamageLimit.min (ดูแท็บ Variables)
- ดาเมจสูงสุด (`MaxDamage`, +): `CheckDamageLimit.max(this, mobAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `CheckDamageLimit.max` = CheckDamageLimit.max (ดูแท็บ Variables)
- ตัวคูณสุดท้ายตามอาวุธ (`SpecificWeaponLastDamage`, ×, บวกเข้าช่อง): `PlayerAttackBase.GetSpecificWeaponLastDamageRate(playerAction, mobAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.GetSpecificWeaponLastDamageRate` = PlayerAttackBase.GetSpecificWeaponLastDamageRate (ดูแท็บ Variables)

**ฮิต 2: `calcRampageFinish` · ส่วน calcRampage (`calcRampage…`)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `NormalAttackAction.calcRampageConstantDamage(NormalAttackAction.calcRampageSkillRate(this, playerAction, 1), playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `NormalAttackAction.calcRampageConstantDamage` = คำนวณ rampage constant damage (NormalAttackAction); `NormalAttackAction.calcRampageSkillRate` = คำนวณ rampage skill rate (NormalAttackAction) (ดูแท็บ Variables)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `NormalAttackAction.calcRampageConstantDamage(NormalAttackAction.calcRampageSkillRate(this, playerAction, 2), playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `NormalAttackAction.calcRampageConstantDamage` = คำนวณ rampage constant damage (NormalAttackAction); `NormalAttackAction.calcRampageSkillRate` = คำนวณ rampage skill rate (NormalAttackAction) (ดูแท็บ Variables)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `NormalAttackAction.calcRampageConstantDamage(NormalAttackAction.calcRampageSkillRate(this, playerAction, 3), playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `NormalAttackAction.calcRampageConstantDamage` = คำนวณ rampage constant damage (NormalAttackAction); `NormalAttackAction.calcRampageSkillRate` = คำนวณ rampage skill rate (NormalAttackAction) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `NormalAttackAction.calcRampageSkillRate(this, playerAction, 1)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `NormalAttackAction.calcRampageSkillRate` = คำนวณ rampage skill rate (NormalAttackAction) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `NormalAttackAction.calcRampageSkillRate(this, playerAction, 2)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `NormalAttackAction.calcRampageSkillRate` = คำนวณ rampage skill rate (NormalAttackAction) (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `NormalAttackAction.calcRampageSkillRate(this, playerAction, 3)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `NormalAttackAction.calcRampageSkillRate` = คำนวณ rampage skill rate (NormalAttackAction) (ดูแท็บ Variables)

**จำนวนฮิต / ตัวนับ**
- `damageCount` (ตั้งใน `OnInitialize`): 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 (Lv1…10)
<!-- calc:end -->

### MagicEgelAttackAction · uid 18

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `MagicEgelAttackAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · ไม่เปลี่ยนค่า proration
- สถานะที่ทำให้ติด: กระเด็น (KnockBack)

<!-- calc:begin uid=18 -->
#### การคำนวณแบบตัวเลข — MagicEgelAttackAction (uid 18)
Proration: ช่อง `Magic` โหมด `never (IsExpDefFluctuate=false)`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **300** → 300, 300, 300, 300, 300, 300, 300, 300, 300, 300 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก อุปกรณ์เวท หรือ อาวุธหลัก ไม้เท้า · INT รวม=100]: **150%** → 150%, 150%, 150%, 150%, 150%, 150%, 150%, 150%, 150%, 150% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก อุปกรณ์เวท หรือ อาวุธหลัก ไม้เท้า · INT รวม=255]: **305%** → 305%, 305%, 305%, 305%, 305%, 305%, 305%, 305%, 305%, 305% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ อุปกรณ์เวท/ไม้เท้า)]: **50%** → 50%, 50%, 50%, 50%, 50%, 50%, 50%, 50%, 50%, 50% (Lv1…10)
<!-- calc:end -->

### ImperialRayPursuitAction · uid 19

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `ImperialRayPursuitAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · ไม่เปลี่ยนค่า proration
- สถานะที่ทำให้ติด: ล่มสลาย (Collapse)

<!-- calc:begin uid=19 -->
#### การคำนวณแบบตัวเลข — ImperialRayPursuitAction (uid 19)
Proration: ช่อง `Magic` โหมด `never (IsExpDefFluctuate=false)`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **300 + 10×Lv** → 310, 320, 330, 340, 350, 360, 370, 380, 390, 400 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate`]: `(150 × Lv + SkillMasteryBase.GetMasteryParam(MasteryId.Value) + 500) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `SkillMasteryBase.GetMasteryParam` = โบนัสพาสซีฟของมาสเตอรีตามเลเวลสกิล; `MasteryId.Value` = ค่าทั่วไป (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `skillRate`]: **(500 + 150×Lv)%** → 650%, 800%, 950%, 1100%, 1250%, 1400%, 1550%, 1700%, 1850%, 2000% (Lv1…10)
<!-- calc:end -->

### ShadowWalkAttackAction · uid 20

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `ShadowWalkAttackAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

<!-- calc:begin uid=20 -->
#### การคำนวณแบบตัวเลข — ShadowWalkAttackAction (uid 20)
Proration: ช่อง `Skill` โหมด `first_hit_per_target if class check passes`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `isCounter ≠ 0`**
- ตัวคูณสกิล (`SkillRate`, ×, ตั้งค่าทับ) [`((((Lv * 10) + 100) * 0.01) * (weaponItem.Function lt 300 ? weaponItem.Function : 300)) < 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `target.AvoidProbability ≤ 99` และ `target.GuardProbability ≤ 99` หรือ `((((Lv * 10) + 100) * 0.01) * (weaponItem.Function lt 300 ? weaponItem.Function : 300)) < 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `target.AvoidProbability ≤ 99` และ `target.GuardProbability > 99` หรือ `((((Lv * 10) + 100) * 0.01) * (weaponItem.Function lt 300 ? weaponItem.Function : 300)) < 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `target.AvoidProbability > 99` และ `target.GuardProbability ≤ 99`]: `int(frintp((0.1 × Lv + 1) × min(weaponItem.Function, 300) - 0.5)) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, ตั้งค่าทับ) [`((((Lv * 10) + 100) * 0.01) * (weaponItem.Function lt 300 ? weaponItem.Function : 300)) ≥ 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `target.AvoidProbability ≤ 99` และ `target.GuardProbability ≤ 99` หรือ `((((Lv * 10) + 100) * 0.01) * (weaponItem.Function lt 300 ? weaponItem.Function : 300)) ≥ 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `target.AvoidProbability ≤ 99` และ `target.GuardProbability > 99` หรือ `((((Lv * 10) + 100) * 0.01) * (weaponItem.Function lt 300 ? weaponItem.Function : 300)) ≥ 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `target.AvoidProbability > 99` และ `target.GuardProbability ≤ 99`]: `int(floor((0.1 × Lv + 1) × min(weaponItem.Function, 300) + 0.5)) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, ตั้งค่าทับ) [`PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1000].IsManual = 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `target.AvoidProbability ≤ 99` และ `target.GuardProbability ≤ 99` หรือ `PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1000].IsManual = 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `target.AvoidProbability ≤ 99` และ `target.GuardProbability > 99` หรือ `PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1000].IsManual = 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `target.AvoidProbability > 99` และ `target.GuardProbability ≤ 99` หรือ `PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1000].IsManual ≠ 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` และ `target.AvoidProbability ≤ 99` และ `target.GuardProbability ≤ 99` หรือ …(เงื่อนไขเต็มดูใน details)]: **(1000 + 200×Lv)%** → 1200%, 1400%, 1600%, 1800%, 2000%, 2200%, 2400%, 2600%, 2800%, 3000% (Lv1…10)

**ฮิต 2: `calcPlayerToMobDamage` (ดาเมจหลัก) — `isCounter = 0` · ส่วน EX (`ex…`)**
- ตัวคูณสกิล (`SkillRate`, ×, ตั้งค่าทับ) [`PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1000].IsManual = 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` หรือ `PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1000].IsManual ≠ 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)`]: ขึ้นกับ `ฮิตที่ (attackCount)` — สูตร `(200 × Lv + 1000) / 100`

  | ฮิตที่ (attackCount) | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | 1200% | 1400% | 1600% | 1800% | 2000% | 2200% | 2400% | 2600% | 2800% | 3000% |
  | 2 | 1200% | 1400% | 1600% | 1800% | 2000% | 2200% | 2400% | 2600% | 2800% | 3000% |
  | 3 | 1200% | 1400% | 1600% | 1800% | 2000% | 2200% | 2400% | 2600% | 2800% | 3000% |
  | 4 | 1200% | 1400% | 1600% | 1800% | 2000% | 2200% | 2400% | 2600% | 2800% | 3000% |
  | 5 | 1200% | 1400% | 1600% | 1800% | 2000% | 2200% | 2400% | 2600% | 2800% | 3000% |

- ตัวคูณสกิล (`SkillRate`, ×, ตั้งค่าทับ) [`PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1000].IsManual = 0` และ `((((Lv * 10) + 100) * 0.01) * (weaponItem.Function lt 300 ? weaponItem.Function : 300)) < 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` หรือ `PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1000].IsManual ≠ 0` และ `((((Lv * 10) + 100) * 0.01) * (weaponItem.Function lt 300 ? weaponItem.Function : 300)) < 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)`]: ขึ้นกับ `ฮิตที่ (attackCount)` — สูตร `((attackCount - 1) × (int(frintp((0.1 × Lv + 1) × min(weaponItem.Function, 300) - 0.5)) ÷ 4) + 200 × Lv + 1000) / 100`
  - (ส่วนที่เหลือขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้ ใช้สูตรด้านบน)
- ตัวคูณสกิล (`SkillRate`, ×, ตั้งค่าทับ) [`PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1000].IsManual = 0` และ `((((Lv * 10) + 100) * 0.01) * (weaponItem.Function lt 300 ? weaponItem.Function : 300)) ≥ 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` หรือ `PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1000].IsManual ≠ 0` และ `((((Lv * 10) + 100) * 0.01) * (weaponItem.Function lt 300 ? weaponItem.Function : 300)) ≥ 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)`]: ขึ้นกับ `ฮิตที่ (attackCount)` — สูตร `((attackCount - 1) × (int(floor((0.1 × Lv + 1) × min(weaponItem.Function, 300) + 0.5)) ÷ 4) + 200 × Lv + 1000) / 100`
  - (ส่วนที่เหลือขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้ ใช้สูตรด้านบน)
- ตัวคูณสกิล (`SkillRate`, ×, ตั้งค่าทับ) [`((((Lv * 10) + 100) * 0.01) * (weaponItem.Function lt 300 ? weaponItem.Function : 300)) < 0` และ `PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1000].IsManual = 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` หรือ `((((Lv * 10) + 100) * 0.01) * (weaponItem.Function lt 300 ? weaponItem.Function : 300)) < 0` และ `PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1000].IsManual ≠ 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)`]: ขึ้นกับ `ฮิตที่ (attackCount)` — สูตร `int(frintp((0.1 × Lv + 1) × min(weaponItem.Function, 300) - 0.5)) / 100`
  - (ส่วนที่เหลือขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้ ใช้สูตรด้านบน)
- ตัวคูณสกิล (`SkillRate`, ×, ตั้งค่าทับ) [`((((Lv * 10) + 100) * 0.01) * (weaponItem.Function lt 300 ? weaponItem.Function : 300)) < 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)`]: ขึ้นกับ `ฮิตที่ (attackCount)` — สูตร `((attackCount - 1) × (A ÷ 4) + A) / 100` · `A = int(frintp((0.1 × Lv + 1) × min(weaponItem.Function, 300) - 0.5))`
  - (ส่วนที่เหลือขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้ ใช้สูตรด้านบน)
- ตัวคูณสกิล (`SkillRate`, ×, ตั้งค่าทับ) [`((((Lv * 10) + 100) * 0.01) * (weaponItem.Function lt 300 ? weaponItem.Function : 300)) < 0` และ `((((Lv * 10) + 100) * 0.01) * (weaponItem.Function lt 300 ? weaponItem.Function : 300)) ≥ 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)`]: ขึ้นกับ `ฮิตที่ (attackCount)` — สูตร `((attackCount - 1) × (int(floor(A + 0.5)) ÷ 4) + int(frintp(A - 0.5))) / 100` · `A = (0.1 × Lv + 1) × min(weaponItem.Function, 300)`
  - (ส่วนที่เหลือขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้ ใช้สูตรด้านบน)
- ตัวคูณสกิล (`SkillRate`, ×, ตั้งค่าทับ) [`((((Lv * 10) + 100) * 0.01) * (weaponItem.Function lt 300 ? weaponItem.Function : 300)) ≥ 0` และ `PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1000].IsManual = 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)` หรือ `((((Lv * 10) + 100) * 0.01) * (weaponItem.Function lt 300 ? weaponItem.Function : 300)) ≥ 0` และ `PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1000].IsManual ≠ 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)`]: ขึ้นกับ `ฮิตที่ (attackCount)` — สูตร `int(floor((0.1 × Lv + 1) × min(weaponItem.Function, 300) + 0.5)) / 100`
  - (ส่วนที่เหลือขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้ ใช้สูตรด้านบน)
- ตัวคูณสกิล (`SkillRate`, ×, ตั้งค่าทับ) [`((((Lv * 10) + 100) * 0.01) * (weaponItem.Function lt 300 ? weaponItem.Function : 300)) ≥ 0` และ `((((Lv * 10) + 100) * 0.01) * (weaponItem.Function lt 300 ? weaponItem.Function : 300)) < 0` และ `!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)`]: ขึ้นกับ `ฮิตที่ (attackCount)` — สูตร `((attackCount - 1) × (int(frintp(A - 0.5)) ÷ 4) + int(floor(A + 0.5))) / 100` · `A = (0.1 × Lv + 1) × min(weaponItem.Function, 300)`
  - (ส่วนที่เหลือขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้ ใช้สูตรด้านบน)

**ใช้ร่วมทุกฮิตของ ดาเมจหลัก**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +, ตั้งค่าทับ) [`!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)`]: **100** → 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 (Lv1…10)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`!MobActionManagerBase.get_IsDeadOrLocalDead(mobAction)`]: `target.ExpDefSkill / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefSkill` = proration ช่อง Skill ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
<!-- calc:end -->

### MagicFinawPursuitAction · uid 21

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `MagicFinawPursuitAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

<!-- calc:begin uid=21 -->
#### การคำนวณแบบตัวเลข — MagicFinawPursuitAction (uid 21)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`damageCount lo fixAddDamage.Length` และ `damageCount lo skillRate.Length`]: `fixAddDamage[damageCount]` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`damageCount lo fixAddDamage.Length` และ `damageCount lo skillRate.Length` หรือ `damageCount hs fixAddDamage.Length` และ `damageCount lo skillRate.Length`]: `skillRate[damageCount]` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`damageCount hs skillRate.Length` หรือ `damageCount lo fixAddDamage.Length` และ `damageCount lo skillRate.Length` หรือ `damageCount hs fixAddDamage.Length` และ `damageCount lo skillRate.Length`]: `target.ExpDefMagic / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefMagic` = proration ช่อง Magic ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`damageCount hs skillRate.Length` หรือ `damageCount lo fixAddDamage.Length` และ `damageCount lo skillRate.Length` หรือ `damageCount hs fixAddDamage.Length` และ `damageCount lo skillRate.Length`]: `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_CharacterActionManagerBase` = ค่า Character Action Manager Base ของ MobActionManagerBase (ดูแท็บ Variables)

**จำนวนฮิต / ตัวนับ**
- `damageCount` (ตั้งใน `NextRangeHit`): `damageCount + 1`
<!-- calc:end -->

### HolyLightPursuitAction · uid 22

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `HolyLightPursuitAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ฟื้นฟู
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

<!-- calc:begin uid=22 -->
#### การคำนวณแบบตัวเลข — HolyLightPursuitAction (uid 22)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **200** → 200, 200, 200, 200, 200, 200, 200, 200, 200, 200 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate`]: **(100 + 15×Lv)%** → 115%, 130%, 145%, 160%, 175%, 190%, 205%, 220%, 235%, 250% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `skillRate` · INT รวม=100]: **(400 + 15×Lv)%** → 415%, 430%, 445%, 460%, 475%, 490%, 505%, 520%, 535%, 550% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 2 ของ `skillRate` · INT รวม=255]: **(710 + 15×Lv)%** → 725%, 740%, 755%, 770%, 785%, 800%, 815%, 830%, 845%, 860% (Lv1…10)
<!-- calc:end -->

### BonusNormalDamageAction · uid 25

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `BonusNormalDamageAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: ธรรมดา (SkillNormal)
- Proration: ช่องตีปกติ · ไม่เปลี่ยนค่า proration

<!-- calc:begin uid=25 -->
#### การคำนวณแบบตัวเลข — BonusNormalDamageAction (uid 25)
Proration: ช่อง `Normal` โหมด `never (IsExpSkill excludes ActionID)`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`PlayerAttackBase.checkMobReaction(this, target.GuardProbability) = 2`]: `skillRate / 100` — โดยที่ `skillRate` = `param` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`PlayerAttackBase.checkMobReaction(this, target.GuardProbability) = 2` และ `TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ≠ 0`]: `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobBuffer.GuardUpBuff.get_GuardUpval` = ค่า Guard Upval ของ GuardUpBuff; `TryGetBuff.buff` = TryGetBuff.buff; `MobActionManagerBase.get_BuffManager` = ค่า Buff Manager ของ MobActionManagerBase (ดูแท็บ Variables)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`PlayerAttackBase.checkMobReaction(this, target.GuardProbability) = 2`]: **25** → 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 (Lv1…10)
<!-- calc:end -->

### BonusPhysicalDamageAction · uid 26

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `BonusPhysicalDamageAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · ไม่เปลี่ยนค่า proration

<!-- calc:begin uid=26 -->
#### การคำนวณแบบตัวเลข — BonusPhysicalDamageAction (uid 26)
Proration: ช่อง `Skill` โหมด `never (IsExpSkill excludes ActionID)`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`PlayerAttackBase.checkMobReaction(this, target.GuardProbability) = 2`]: `skillRate / 100` — โดยที่ `skillRate` = `param` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`PlayerAttackBase.checkMobReaction(this, target.GuardProbability) = 2` และ `TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ≠ 0`]: `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobBuffer.GuardUpBuff.get_GuardUpval` = ค่า Guard Upval ของ GuardUpBuff; `TryGetBuff.buff` = TryGetBuff.buff; `MobActionManagerBase.get_BuffManager` = ค่า Buff Manager ของ MobActionManagerBase (ดูแท็บ Variables)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`PlayerAttackBase.checkMobReaction(this, target.GuardProbability) = 2`]: **25** → 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 (Lv1…10)
<!-- calc:end -->

### BonusMagicDamageAction · uid 27

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `BonusMagicDamageAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · ไม่เปลี่ยนค่า proration

<!-- calc:begin uid=27 -->
#### การคำนวณแบบตัวเลข — BonusMagicDamageAction (uid 27)
Proration: ช่อง `Magic` โหมด `never (IsExpSkill excludes ActionID)`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`PlayerAttackBase.checkMobReaction(this, target.GuardProbability) = 2`]: `skillRate / 100` — โดยที่ `skillRate` = `param` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`PlayerAttackBase.checkMobReaction(this, target.GuardProbability) = 2` และ `TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ≠ 0`]: `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobBuffer.GuardUpBuff.get_GuardUpval` = ค่า Guard Upval ของ GuardUpBuff; `TryGetBuff.buff` = TryGetBuff.buff; `MobActionManagerBase.get_BuffManager` = ค่า Buff Manager ของ MobActionManagerBase (ดูแท็บ Variables)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`PlayerAttackBase.checkMobReaction(this, target.GuardProbability) = 2`]: **25** → 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 (Lv1…10)
<!-- calc:end -->

### BonusNaturalDamageAction · uid 28

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `BonusNaturalDamageAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: ธรรมดา (SkillNormal)
- Proration: ช่องตีปกติ · ไม่เปลี่ยนค่า proration

<!-- calc:begin uid=28 -->
#### การคำนวณแบบตัวเลข — BonusNaturalDamageAction (uid 28)
Proration: ช่อง `Normal` โหมด `never (IsExpSkill excludes ActionID)`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`PlayerAttackBase.checkMobReaction(this, target.GuardProbability) = 2`]: `skillRate / 100` — โดยที่ `skillRate` = `param` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`PlayerAttackBase.checkMobReaction(this, target.GuardProbability) = 2`]: **1** → 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 (Lv1…10)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`PlayerAttackBase.checkMobReaction(this, target.GuardProbability) = 2` และ `TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ≠ 0`]: `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobBuffer.GuardUpBuff.get_GuardUpval` = ค่า Guard Upval ของ GuardUpBuff; `TryGetBuff.buff` = TryGetBuff.buff; `MobActionManagerBase.get_BuffManager` = ค่า Buff Manager ของ MobActionManagerBase (ดูแท็บ Variables)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`PlayerAttackBase.checkMobReaction(this, target.GuardProbability) = 2`]: **25** → 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 (Lv1…10)
<!-- calc:end -->

### MoonSlashPursuitAction · uid 63

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `MoonSlashPursuitAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · ไม่เปลี่ยนค่า proration
- โอกาสติดสถานะ `criticalPercent`: `10 × Lv + baseCRT` %

<!-- calc:begin uid=63 -->
#### การคำนวณแบบตัวเลข — MoonSlashPursuitAction (uid 63)
Proration: ช่อง `Skill` โหมด `never (IsExpDefFluctuate=false)`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `fixAddDamage` — โดยที่ `fixAddDamage` = `baseINT` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [STR รวม=100]: **(10×Lv)%** → 10%, 20%, 30%, 40%, 50%, 60%, 70%, 80%, 90%, 100% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [STR รวม=255]: **(25.5×Lv)%** → 25.5%, 51%, 76.5%, 102%, 127.5%, 153%, 178.5%, 204%, 229.5%, 255% (Lv1…10)
<!-- calc:end -->

### JumpbackShotPursuitAction · uid 95

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `JumpbackShotPursuitAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · ไม่เปลี่ยนค่า proration
- บัพ `JumpBackShotBuf`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่

<!-- calc:begin uid=95 -->
#### การคำนวณแบบตัวเลข — JumpbackShotPursuitAction (uid 95)
Proration: ช่อง `Skill` โหมด `never (IsExpDefFluctuate=false)`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) · ส่วน โบนัส (`bonus…`)**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): ขึ้นกับ `count` — สูตร `min(baseSkillRate + bonusSkillRate × count, 500) / 100` — โดยที่ `baseSkillRate` = `100` ; `bonusSkillRate` = `0.01 × Lv × DEXรวม`

  *DEX รวม=100*

  | count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | 101% | 102% | 103% | 104% | 105% | 106% | 107% | 108% | 109% | 110% |
  | 2 | 102% | 104% | 106% | 108% | 110% | 112% | 114% | 116% | 118% | 120% |
  | 3 | – | – | – | 112% | 115% | 118% | 121% | 124% | 127% | 130% |
  | 4 | – | – | – | – | – | – | 128% | 132% | 136% | 140% |
  | 5 | – | – | – | – | – | – | – | – | – | 150% |

  *DEX รวม=255*

  | count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | 102.55% | 105.1% | 107.65% | 110.2% | 112.75% | 115.3% | 117.85% | 120.4% | 122.95% | 125.5% |
  | 2 | 105.1% | 110.2% | 115.3% | 120.4% | 125.5% | 130.6% | 135.7% | 140.8% | 145.9% | 151% |
  | 3 | – | – | – | 130.6% | 138.25% | 145.9% | 153.55% | 161.2% | 168.85% | 176.5% |
  | 4 | – | – | – | – | – | – | 171.4% | 181.6% | 191.8% | 202% |
  | 5 | – | – | – | – | – | – | – | – | – | 227.5% |

  ระดับสูงสุดต่อเลเวลสกิล: Lv1=2, Lv2=2, Lv3=2, Lv4=3, Lv5=3, Lv6=3, Lv7=4, Lv8=4, Lv9=4, Lv10=5 (`–` = เลเวลนั้นชาร์จไม่ถึง)

<!-- calc:end -->

### AshuraAuraAttackAction · uid 157

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `AshuraAuraAttackAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · ไม่เปลี่ยนค่า proration

<!-- calc:begin uid=157 -->
#### การคำนวณแบบตัวเลข — AshuraAuraAttackAction (uid 157)
Proration: ช่อง `Skill` โหมด `never (IsExpDefFluctuate=false)`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่จากบัพ (`BufferConstantDamage`, +, ตั้งค่าทับ): **0** → 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) = 16`]: `((A < 0 ? baseAGI // (12 - Lv) + 101 : A) ÷ 2 + 45) / 100` · `A = baseAGI // (12 - Lv) + 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseAGI` = แต้ม AGI ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseAGI; `baseAGI` = แต้ม AGI ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseAGI; `baseAGI` = แต้ม AGI ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseAGI (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) ≠ 16`]: `((A < 0 ? baseAGI // (12 - Lv) + 101 : A) ÷ 2) / 100` · `A = baseAGI // (12 - Lv) + 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseAGI` = แต้ม AGI ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseAGI; `baseAGI` = แต้ม AGI ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseAGI; `baseAGI` = แต้ม AGI ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseAGI (ดูแท็บ Variables)
- ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, ×, ตั้งค่าทับ): **100%** → 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100% (Lv1…10)
<!-- calc:end -->

### MindimageSenjuSupportAction · uid 158

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `MindimageSenjuSupportAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง, บัพปาร์ตี้/ผู้อื่น
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `ChakraBuf` ระยะเวลา 20 + Lv → 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 (Lv1…10) วินาที [`(isKnuckle & 1) ≠ 0`] / 10 + Lv → 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 (Lv1…10) วินาที [`(isKnuckle & 1) = 0`]: MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = 1, 2, 3, 4, 5, 7, 9, 11, 13, 15 (Lv1…10) · ลดดาเมจฐาน (`BaseDamageCut`) = `baseDamageCut` · ตัวคูณดาเมจที่ได้รับจากมอน (หมวดซัพพอร์ต) (`MobLastDamageRateSupport`) = 30 + 2×Lv → 32, 34, 36, 38, 40, 42, 44, 46, 48, 50 (Lv1…10)
- บัพ `ClearAndSereneBuf` ระยะเวลา 10 + 2×Lv → 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 (Lv1…10) วินาที: ดาเมจคริ % (`CrtDamageUpRate`) = `-criticalDamageRate` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · MDEF + (`Mdef`) = -1100 + 100×Lv → -1000, -900, -800, -700, -600, -500, -400, -300, -200, -100 (Lv1…10) · DEF + (`Def`) = -1100 + 100×Lv → -1000, -900, -800, -700, -600, -500, -400, -300, -200, -100 (Lv1…10) · อัตราคริ + (`CrtUp`) = `critical` (ตัวนับที่เปลี่ยนตามเหตุการณ์)
- บัพ `DestroyerBuf`: ATK อาวุธฐาน % (`BaseEqAtkUpRate`) = 5×Lv → 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 (Lv1…10) · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = 2, 5, 7, 10, 12, 15, 17, 20, 22, 25 (Lv1…10) · ความเสถียร (`Stable`) = `(isMainKnuckleEquip eq 0 ? 0 : 0xfffffff6)` (ตัวนับที่เปลี่ยนตามเหตุการณ์)
- บัพ `HideAttackBuf` ระยะเวลา 1, 3, 4, 6, 7, 9, 10, 12, 13, 15 (Lv1…10) วินาที [`(isGemCart & 1) ≠ 0`]
- บัพ `MindimageSenjuBuf` ระยะเวลา `isMainKnuckle & 1 ≠ 0 ? 10 - lv : 20 - lv` วินาที [`((isMainKnuckle & 1) ne 0 ? ((20 - lv) + -10) : (20 - lv)) > 0` หรือ `((isMainKnuckle & 1) ne 0 ? ((20 - lv) + -10) : (20 - lv)) ≤ 0`]
- บัพ `QuickAuraBuf` ระยะเวลา `time` วินาที: ความเร็วโจมตี + (`Aspd`) = `50 × (isLevel1 ≠ 1 ? lv : 1)` · ความเร็วโจมตี % (`AspdRate`) = `[(0x165d9d4(meta(0x3972658, int[]_TypeInfo), 10) + ((((isLevel1 ne 1 ? lv : 1)) - 1) << 2))+0x20]`
- บัพ `WarCryBuf` ระยะเวลา `val & 255 = 10 ? Lv + 65 : Lv + 15` วินาที: ATK % (`AtkUpRate`) = `(val = 11 ? 5 : 0) + Lv`
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = Lv ตามที่ `HideAttackBuf` ส่งให้ตัวสร้างของ `บัพฐาน`; สแตกสูงสุด (`Max`) = max ตามที่ `NextAttackBufferBase` ส่งให้ตัวสร้างของ `บัพฐาน`
- บัพ `NextAttackBufferBase`: บัพนับสแตก (สืบจาก `CountBufferBase`): ตัวนับ `Count` เริ่ม 0 เพิ่มทีละ 1 ด้วย `Next()` และสูงสุด max; โค้ดอื่นอ่านจำนวนสแตกผ่านพารามิเตอร์ `Count` (ดูค่าที่ใช้จริงในสูตรของสกิลที่อ้างถึง)
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่

### MindimageSenjuAttackAction · uid 159

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `MindimageSenjuAttackAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ, เปลี่ยนรูปแบบการโจมตี (อนุมานจาก hook ของบัพ)
- ดาเมจ: สร้าง template ดาเมจ 5 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: ได้ประเภทจากสกิลแม่; Exorcism = เวท, Nemesis = กายภาพ — เงื่อนไข: copy: OnInitialize: = parent action (this+0x128) AttackType (vtable slot 6); Magic: InitializeExorcism, not other player; Physics: InitializeNemesis, not other player
- Proration: ช่องที่เลือกตอนร่าย (กายภาพ/เวท) · สกิลเช็กเองว่าจะเปลี่ยนค่าหรือไม่
- สถานะที่ทำให้ติด: `abnormalType`
- บัพ `MindimageSenjuBuf` ระยะเวลา `isMainKnuckle & 1 ≠ 0 ? 10 - lv : 20 - lv` วินาที [`((isMainKnuckle & 1) ne 0 ? ((20 - lv) + -10) : (20 - lv)) > 0` หรือ `((isMainKnuckle & 1) ne 0 ? ((20 - lv) + -10) : (20 - lv)) ≤ 0`]
- บัพ `NemesisBuf` ระยะเวลา 20×Lv → 20, 40, 60, 80, 100, 120, 140, 160, 180, 200 (Lv1…10) วินาที [`EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type = 17`] / 10×Lv → 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 (Lv1…10) วินาที [`EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ≠ 17`]: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`
- บัพ `CountBufferBase`: ตัวนับ/stack (`Count`) = `Count` (ตัวนับที่เปลี่ยนตามเหตุการณ์); ค่าตั้งต้น `0`; Next(): `Count` = `System.Math.Min((Count + 1), Max)`; NextSkip(): `Count` = `System.Math.Min((Count + count), Max)`; Prev(): `Count` = `System.Math.Max((Count - 1), 0)`; PrevSkip(): `Count` = `System.Math.Max((Count - count), 0)`; สแตกสูงสุด (`Max`) = 20 ตามที่ `NemesisBuf` ส่งให้ตัวสร้างของ `บัพฐาน`
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่

<!-- calc:begin uid=159 -->
#### การคำนวณแบบตัวเลข — MindimageSenjuAttackAction (uid 159)
Proration: ช่อง `dynamic` โหมด `custom_check + class check`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `ช่อง [0] ของอาร์เรย์ต่อฮิต`**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`CharacterActionManagerBase.get_IsLocalDead() ≤ 843` และ `CharacterActionManagerBase.get_IsLocalDead() ≠ 140` และ `CharacterActionManagerBase.get_IsLocalDead() ≠ 842` และ `IsInheritance ≠ 0` และ … หรือ `CharacterActionManagerBase.get_IsLocalDead() ≤ 843` และ `CharacterActionManagerBase.get_IsLocalDead() ≠ 140` และ `CharacterActionManagerBase.get_IsLocalDead() ≠ 842` และ `IsInheritance ≠ 0` และ … หรือ `CharacterActionManagerBase.get_IsLocalDead() > 843` และ `CharacterActionManagerBase.get_IsLocalDead() ≠ 1160` และ `CharacterActionManagerBase.get_IsLocalDead() ≠ 844` และ `IsInheritance ≠ 0` และ …]: `fixAddDamage[0]` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`CharacterActionManagerBase.get_IsLocalDead() ≤ 843` และ `CharacterActionManagerBase.get_IsLocalDead() ≠ 140` และ `CharacterActionManagerBase.get_IsLocalDead() ≠ 842` และ `IsInheritance ≠ 0` และ … หรือ `CharacterActionManagerBase.get_IsLocalDead() > 843` และ `CharacterActionManagerBase.get_IsLocalDead() ≠ 1160` และ `CharacterActionManagerBase.get_IsLocalDead() ≠ 844` และ `IsInheritance ≠ 0` และ …]: `(skillRate[0] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**ฮิต 2: `CalcDamageChariot` (ส่วน Chariot) — `ช่อง [0] ของอาร์เรย์ต่อฮิต`**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`fixAddDamage.Length ≠ 0` และ `skillRate.Length ≠ 0`]: `fixAddDamage[0]` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`fixAddDamage.Length ≠ 0` และ `skillRate.Length ≠ 0` หรือ `fixAddDamage.Length = 0` และ `skillRate.Length ≠ 0`]: `(skillRate[0] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**ฮิต 3: `CalcDamageExorcism` (ส่วน Exorcism) — `ช่อง [0] ของอาร์เรย์ต่อฮิต`**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`fixAddDamage.Length ≠ 0` และ `skillRate.Length ≠ 0` และ `target.Element = 6` หรือ `fixAddDamage.Length ≠ 0` และ `isNemesisBuf` และ `skillRate.Length ≠ 0` และ `target.Element ≠ 6` หรือ `fixAddDamage.Length ≠ 0` และ ไม่ `isNemesisBuf` และ `skillRate.Length ≠ 0` และ `target.Element ≠ 6`]: `(target.Element eq 6 ? (fixAddDamage[0] + 100) : fixAddDamage[0])` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.Element` = ธาตุของมอน (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`fixAddDamage.Length ≠ 0` และ `skillRate.Length ≠ 0` และ `target.Element = 6` หรือ `fixAddDamage.Length ≠ 0` และ `isNemesisBuf` และ `skillRate.Length ≠ 0` และ `target.Element ≠ 6` หรือ `fixAddDamage.Length ≠ 0` และ ไม่ `isNemesisBuf` และ `skillRate.Length ≠ 0` และ `target.Element ≠ 6`]: `((target.Element eq 6 ? (skillRate[0] + 400) : skillRate[0]) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.Element` = ธาตุของมอน (ดูแท็บ Variables)

**ฮิต 4: `CalcDamageNemesis` (ส่วน Nemesis) — `ช่อง [0] ของอาร์เรย์ต่อฮิต`**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`fixAddDamage.Length ≠ 0` และ `skillRate.Length ≠ 0`]: `fixAddDamage[0]` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`fixAddDamage.Length ≠ 0` และ `skillRate.Length ≠ 0` หรือ `fixAddDamage.Length = 0` และ `skillRate.Length ≠ 0`]: `(skillRate[0] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**ฮิต 5: `CalcDamageNemesis` (ส่วน Nemesis) — `ช่อง [1] ของอาร์เรย์ต่อฮิต`**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`!PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction)` และ `fixAddDamage.Length > 1` และ `skillRate.Length > 1` หรือ `criticalAttackCount lt SkillActionBase.get_AttackCount(this)` และ `fixAddDamage.Length > 1` และ `skillRate.Length > 1`]: `fixAddDamage[1]` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`!PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction)` และ `fixAddDamage.Length > 1` และ `skillRate.Length > 1` หรือ `!PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction)` และ `fixAddDamage.Length ≤ 1` และ `skillRate.Length > 1`]: `(skillRate[1] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**ฮิต 6: `CalcDamageGeoImpact` (ส่วน GeoImpact) — `ช่อง [0] ของอาร์เรย์ต่อฮิต`**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`fixAddDamage.Length ≠ 0` และ มีบัพ 1159 Destroyer และ `skillRate.Length ≠ 0` หรือ ไม่มีบัพ 1159 Destroyer และ `fixAddDamage.Length ≠ 0` และ `skillRate.Length ≠ 0`]: `fixAddDamage[0]` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`fixAddDamage.Length ≠ 0` และ มีบัพ 1159 Destroyer และ `skillRate.Length ≠ 0` หรือ `fixAddDamage.Length = 0` และ มีบัพ 1159 Destroyer และ `skillRate.Length ≠ 0` หรือ ไม่มีบัพ 1159 Destroyer และ `fixAddDamage.Length ≠ 0` และ `skillRate.Length ≠ 0`]: `(skillRate[0] * 0.01)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**จำนวนฮิต / ตัวนับ**
- `maxAttackCount` (ตั้งใน `InitializeEarthBind`): 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 (Lv1…10)
- `maxAttackCount` (ตั้งใน `InitializeFlashArts`) [`IsInstanceOf(playerAction, PlayerActionManager) ≠ 1`]: `int(0.5 × AvoidActionManager.get_AvoidCount([playerAction.battleManager+0xa8])) + 1`
- `maxAttackCount` (ตั้งใน `InitializeFlashArts`) [`IsInstanceOf(playerAction, PlayerActionManager) = 1`]: `int(0.5 × AvoidActionManager.get_AvoidCount([playerAction.battleManager+0xa0])) + 1`
- `maxAttackCount` (ตั้งใน `InitializeExorcism`) [`IsOtherPlayer = 0`]: 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 (Lv1…10)
- `LoopParam` (ตั้งใน `InitializeExorcism`) [`IsOtherPlayer = 0`]: `int(10 × MathUtil.DisplayMeterToDistance(3))`
- `maxAttackCount` (ตั้งใน `InitializeNemesis`) [`IsOtherPlayer = 0`]: `[baseSkill+0x28]`
- `LoopParam` (ตั้งใน `InitializeNemesis`) [`IsOtherPlayer = 0` และ `PlayerAttackBase.ExistWeaponType(playerAction, 17)` หรือ `!PlayerAttackBase.ExistWeaponType(playerAction, 17)` และ `IsOtherPlayer = 0` และ `PlayerAttackBase.ExistWeaponType(playerAction, 15)` หรือ `!PlayerAttackBase.ExistWeaponType(playerAction, 15)` และ `!PlayerAttackBase.ExistWeaponType(playerAction, 17)` และ `IsOtherPlayer = 0`]: `[baseSkill+0x104] & 1`
- `LoopParam` (ตั้งใน `InitializeOthers`): `motionSpeed`
<!-- calc:end -->

### CrazyDaggerPursuitAction · uid 319

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `CrazyDaggerPursuitAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: ธรรมดา (SkillNormal)
- Proration: ช่องตีปกติ · ไม่เปลี่ยนค่า proration

<!-- calc:begin uid=319 -->
#### การคำนวณแบบตัวเลข — CrazyDaggerPursuitAction (uid 319)
Proration: ช่อง `Normal` โหมด `never (IsExpDefFluctuate=false)`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรอง มีด และ อาวุธหลักเป็น มือเปล่า/ดาบมือเดียว/สนับมือ และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301) ≠ 0`]: `((((System.Math.Min(((GetSubWeaponType.item(actarAction).Function // ((mul64(baseDEX, 0xae147ae1) >> 37) + 15)) + 50), 100) + 50) * SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301), 20))) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `GetSubWeaponType.item` = GetSubWeaponType.item; `SkillBufferDataBase.GetParam` = ค่าพารามิเตอร์ของบัพตาม SkillBufferId; `TryGetBuf.buf` = TryGetBuf.buf; `PlayerStatusBase.get_SkillBufferManager` = ค่า Skill Buffer Manager ของ PlayerStatusBase; `SkillBufferId.Count` = ตัวนับ/stack (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรอง มีด และ อาวุธหลักเป็น มือเปล่า/ดาบมือเดียว/สนับมือ]: `(((System.Math.Min(((GetSubWeaponType.item(actarAction).Function // ((mul64(baseDEX, 0xae147ae1) >> 37) + 15)) + 50), 100) + 50)) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `GetSubWeaponType.item` = GetSubWeaponType.item (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรอง มีด และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301) ≠ 0`]: `(((System.Math.Min(((GetSubWeaponType.item(actarAction).Function // ((mul64(baseDEX, 0xae147ae1) >> 37) + 15)) + 50), 100) * SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301), 20))) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `GetSubWeaponType.item` = GetSubWeaponType.item; `SkillBufferDataBase.GetParam` = ค่าพารามิเตอร์ของบัพตาม SkillBufferId; `TryGetBuf.buf` = TryGetBuf.buf; `PlayerStatusBase.get_SkillBufferManager` = ค่า Skill Buffer Manager ของ PlayerStatusBase; `SkillBufferId.Count` = ตัวนับ/stack (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธรอง มีด]: `((System.Math.Min(((GetSubWeaponType.item(actarAction).Function // ((mul64(baseDEX, 0xae147ae1) >> 37) + 15)) + 50), 100)) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseDEX` = แต้ม DEX ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseDEX; `GetSubWeaponType.item` = GetSubWeaponType.item (ดูแท็บ Variables)

**จำนวนฮิต / ตัวนับ**
- `damageCount` (ตั้งใน `OnInitialize`) [อาวุธรอง มีด และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301) ≠ 0` หรือ อาวุธรองอื่น (ไม่ใช่ มีด) และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301) ≠ 0`]: `SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301), 20)`
- `damageCount` (ตั้งใน `InitializeOthers`): `SkillIndividualFlag` — โดยที่ `SkillIndividualFlag` = `SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301), 20)` [อาวุธรอง มีด และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301) ≠ 0` หรือ อาวุธรองอื่น (ไม่ใช่ มีด) และ `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301) ≠ 0`]
<!-- calc:end -->

### IchijhinnokazeAttackAction · uid 637

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `IchijhinnokazeAttackAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 5 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ; ท่า Kariwatashi/Hibari/Ibuki/Arahae เป็นธรรมดา — เงื่อนไข: Physics: default (ctor); InitializeNagi; Normal: InitializeKariwatashi / Hibari / Ibuki / Arahae, SkillEventArahae
- Proration: ช่องที่เลือกตอนร่าย (กายภาพ/เวท) · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

<!-- calc:begin uid=637 -->
#### การคำนวณแบบตัวเลข — IchijhinnokazeAttackAction (uid 637)
Proration: ช่อง `dynamic` โหมด `first_hit_per_target`

**ฮิต 1: `CalcNagiDamage` (ส่วน Nagi) — `ช่อง [0] ของอาร์เรย์ต่อฮิต`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`forceMiss ≠ 0` และ `skillRates.Length ≠ 0` หรือ `forceMiss = 0` และ `skillRates.Length ≠ 0`]: `(skillRates[0] / 100)` — โดยที่ `skillRates[0]` = `50 × Lv + IchijhinnokazeAratame.GetNagiBonus(PlayerActionManagerBase.get_PlayerStatus()) + 500` [`skillRates.Length ≠ 0`] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**ฮิต 2: `CalcKariwatashiDamage` (ส่วน Kariwatashi) — `ช่อง [1] ของอาร์เรย์ต่อฮิต`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`skillRates.Length > 1` และ `forceMiss ≠ 0` หรือ `skillRates.Length > 1` และ `forceMiss = 0`]: `(IchijhinnokazeBuf.GetKariwatashiBonus(A) + 20 × Lv + IchijhinnokazeAratame.GetKariwatashiBonus(A) + 400) / 100` · `A = PlayerActionManagerBase.get_PlayerStatus()` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `IchijhinnokazeBuf.GetKariwatashiBonus` = IchijhinnokazeBuf.GetKariwatashiBonus; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `IchijhinnokazeAratame.GetKariwatashiBonus` = IchijhinnokazeAratame.GetKariwatashiBonus (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`skillRates.Length > 1` และ `skillRates.Length ≤ 1` และ `forceMiss ≠ 0` หรือ `skillRates.Length > 1` และ `skillRates.Length ≤ 1` และ `forceMiss = 0`]: `(IchijhinnokazeBuf.GetKariwatashiBonus(PlayerActionManagerBase.get_PlayerStatus()) + 20 × Lv + 400) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `IchijhinnokazeBuf.GetKariwatashiBonus` = IchijhinnokazeBuf.GetKariwatashiBonus; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`skillRates.Length > 1` และ `skillRates.Length ≤ 3` และ `forceMiss ≠ 0` หรือ `skillRates.Length > 1` และ `skillRates.Length ≤ 3` และ `forceMiss = 0` หรือ `skillRates.Length > 1` และ `skillRates.Length > 3` และ `skillRates.Length ≠ 4` และ `forceMiss ≠ 0` หรือ `skillRates.Length > 1` และ `skillRates.Length > 3` และ `skillRates.Length ≠ 4` และ `forceMiss = 0` หรือ …(เงื่อนไขเต็มดูใน details)]: `(skillRates[1] / 100)` — โดยที่ `skillRates[1]` = `IchijhinnokazeBuf.GetKariwatashiBonus(A) + 20 × Lv + IchijhinnokazeAratame.GetKariwatashiBonus(A) + 400` (`A = PlayerActionManagerBase.get_PlayerStatus()`) [`skillRates.Length > 1`] หรือ `IchijhinnokazeBuf.GetKariwatashiBonus(PlayerActionManagerBase.get_PlayerStatus()) + 20 × Lv + 400` [`skillRates.Length > 1` และ `skillRates.Length ≤ 1`] หรือ `(skillRates[1] + 1200)` [`skillRates.Length > 1` และ `skillRates.Length ≤ 3` หรือ `skillRates.Length > 1` และ `skillRates.Length > 3` และ `skillRates.Length ≠ 4` หรือ `skillRates.Length = 4` และ `skillRates.Length > 1` และ `skillRates.Length > 3`] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**ฮิต 3: `CalcHibariDamage` (ส่วน Hibari) — `ช่อง [2] ของอาร์เรย์ต่อฮิต`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`skillRates.Length > 2` และ `forceMiss ≠ 0` หรือ `skillRates.Length > 2` และ `forceMiss = 0`]: `(IchijhinnokazeBuf.GetHibariBonus(A) + 30 × Lv + IchijhinnokazeAratame.GetHibariBonus(A) + 600) / 100` · `A = PlayerActionManagerBase.get_PlayerStatus()` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `IchijhinnokazeBuf.GetHibariBonus` = IchijhinnokazeBuf.GetHibariBonus; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `IchijhinnokazeAratame.GetHibariBonus` = IchijhinnokazeAratame.GetHibariBonus (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`skillRates.Length > 2` และ `skillRates.Length ≤ 2` และ `forceMiss ≠ 0` หรือ `skillRates.Length > 2` และ `skillRates.Length ≤ 2` และ `forceMiss = 0`]: `(IchijhinnokazeBuf.GetHibariBonus(PlayerActionManagerBase.get_PlayerStatus()) + 30 × Lv + 600) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `IchijhinnokazeBuf.GetHibariBonus` = IchijhinnokazeBuf.GetHibariBonus; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`skillRates.Length > 1` และ `skillRates.Length > 3` และ `skillRates.Length ≠ 4` และ `forceMiss ≠ 0` และ … หรือ `skillRates.Length > 1` และ `skillRates.Length > 3` และ `skillRates.Length ≠ 4` และ `forceMiss = 0` และ …]: `(skillRates[2] / 100)` — โดยที่ `skillRates[2]` = `IchijhinnokazeBuf.GetHibariBonus(A) + 30 × Lv + IchijhinnokazeAratame.GetHibariBonus(A) + 600` (`A = PlayerActionManagerBase.get_PlayerStatus()`) [`skillRates.Length > 2`] หรือ `IchijhinnokazeBuf.GetHibariBonus(PlayerActionManagerBase.get_PlayerStatus()) + 30 × Lv + 600` [`skillRates.Length > 2` และ `skillRates.Length ≤ 2`] หรือ `(skillRates[2] + 1550)` [`skillRates.Length > 1` และ `skillRates.Length > 3` และ `skillRates.Length ≠ 4`] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**ฮิต 4: `CalcIbukiDamage` (ส่วน Ibuki) — `ช่อง [3] ของอาร์เรย์ต่อฮิต`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`skillRates.Length > 3` และ `forceMiss ≠ 0` หรือ `skillRates.Length > 3` และ `forceMiss = 0`]: `(IchijhinnokazeBuf.GetIbukiBonus(A) + 60 × Lv + IchijhinnokazeAratame.GetIbukiBonus(A) + 300) / 100` · `A = PlayerActionManagerBase.get_PlayerStatus()` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `IchijhinnokazeBuf.GetIbukiBonus` = IchijhinnokazeBuf.GetIbukiBonus; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `IchijhinnokazeAratame.GetIbukiBonus` = IchijhinnokazeAratame.GetIbukiBonus (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`skillRates.Length > 3` และ `skillRates.Length ≤ 3` และ `forceMiss ≠ 0` หรือ `skillRates.Length > 3` และ `skillRates.Length ≤ 3` และ `forceMiss = 0`]: `(IchijhinnokazeBuf.GetIbukiBonus(PlayerActionManagerBase.get_PlayerStatus()) + 60 × Lv + 300) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `IchijhinnokazeBuf.GetIbukiBonus` = IchijhinnokazeBuf.GetIbukiBonus; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`skillRates.Length > 1` และ `skillRates.Length > 3` และ `skillRates.Length ≠ 4` และ `forceMiss ≠ 0` หรือ `skillRates.Length > 1` และ `skillRates.Length > 3` และ `skillRates.Length ≠ 4` และ `forceMiss = 0` หรือ `skillRates.Length = 4` และ `skillRates.Length > 1` และ `skillRates.Length > 3` และ `forceMiss ≠ 0` หรือ `skillRates.Length = 4` และ `skillRates.Length > 1` และ `skillRates.Length > 3` และ `forceMiss = 0`]: `(skillRates[3] / 100)` — โดยที่ `skillRates[3]` = `IchijhinnokazeBuf.GetIbukiBonus(A) + 60 × Lv + IchijhinnokazeAratame.GetIbukiBonus(A) + 300` (`A = PlayerActionManagerBase.get_PlayerStatus()`) [`skillRates.Length > 3`] หรือ `IchijhinnokazeBuf.GetIbukiBonus(PlayerActionManagerBase.get_PlayerStatus()) + 60 × Lv + 300` [`skillRates.Length > 3` และ `skillRates.Length ≤ 3`] หรือ `(skillRates[3] + 1450)` [`skillRates.Length > 1` และ `skillRates.Length > 3` และ `skillRates.Length ≠ 4` หรือ `skillRates.Length = 4` และ `skillRates.Length > 1` และ `skillRates.Length > 3`] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**ฮิต 5: `CalcArahaeDamage` (ส่วน Arahae) — `ช่อง [4] ของอาร์เรย์ต่อฮิต`**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`skillRates.Length > 4` และ `forceMiss ≠ 0` หรือ `skillRates.Length > 4` และ `forceMiss = 0`]: `(IchijhinnokazeBuf.GetArahaeBonus(A) + 20 × Lv + IchijhinnokazeAratame.GetArahaeBonus(A) + 500) / 100` · `A = PlayerActionManagerBase.get_PlayerStatus()` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `IchijhinnokazeBuf.GetArahaeBonus` = IchijhinnokazeBuf.GetArahaeBonus; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `IchijhinnokazeAratame.GetArahaeBonus` = IchijhinnokazeAratame.GetArahaeBonus (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`skillRates.Length > 4` และ `skillRates.Length ≤ 4` และ `forceMiss ≠ 0` หรือ `skillRates.Length > 4` และ `skillRates.Length ≤ 4` และ `forceMiss = 0`]: `(IchijhinnokazeBuf.GetArahaeBonus(PlayerActionManagerBase.get_PlayerStatus()) + 20 × Lv + 500) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `IchijhinnokazeBuf.GetArahaeBonus` = IchijhinnokazeBuf.GetArahaeBonus; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`skillRates.Length > 1` และ `skillRates.Length > 3` และ `skillRates.Length ≠ 4` และ `forceMiss ≠ 0` และ … หรือ `skillRates.Length > 1` และ `skillRates.Length > 3` และ `skillRates.Length ≠ 4` และ `forceMiss = 0` และ …]: `(skillRates[4] / 100)` — โดยที่ `skillRates[4]` = `IchijhinnokazeBuf.GetArahaeBonus(A) + 20 × Lv + IchijhinnokazeAratame.GetArahaeBonus(A) + 500` (`A = PlayerActionManagerBase.get_PlayerStatus()`) [`skillRates.Length > 4`] หรือ `IchijhinnokazeBuf.GetArahaeBonus(PlayerActionManagerBase.get_PlayerStatus()) + 20 × Lv + 500` [`skillRates.Length > 4` และ `skillRates.Length ≤ 4`] หรือ `(skillRates[4] + 1350)` [`skillRates.Length > 1` และ `skillRates.Length > 3` และ `skillRates.Length ≠ 4`] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**ใช้ร่วมทุกฮิตของ CalcNagiDamage**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`forceMiss ≠ 0` และ `skillRates.Length ≠ 0` หรือ `forceMiss = 0` และ `skillRates.Length ≠ 0`]: **300** → 300, 300, 300, 300, 300, 300, 300, 300, 300, 300 (Lv1…10)

**ใช้ร่วมทุกฮิตของ CalcKariwatashiDamage**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`forceMiss ≠ 0` และ `skillRates.Length > 1` หรือ `forceMiss = 0` และ `skillRates.Length > 1`]: **300** → 300, 300, 300, 300, 300, 300, 300, 300, 300, 300 (Lv1…10)

**ใช้ร่วมทุกฮิตของ CalcHibariDamage**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`forceMiss ≠ 0` และ `skillRates.Length > 2` หรือ `forceMiss = 0` และ `skillRates.Length > 2`]: **300** → 300, 300, 300, 300, 300, 300, 300, 300, 300, 300 (Lv1…10)

**ใช้ร่วมทุกฮิตของ CalcIbukiDamage**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`forceMiss ≠ 0` และ `skillRates.Length > 3` หรือ `forceMiss = 0` และ `skillRates.Length > 3`]: **300** → 300, 300, 300, 300, 300, 300, 300, 300, 300, 300 (Lv1…10)

**ใช้ร่วมทุกฮิตของ CalcArahaeDamage**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`forceMiss ≠ 0` และ `skillRates.Length > 4` หรือ `forceMiss = 0` และ `skillRates.Length > 4`]: **300** → 300, 300, 300, 300, 300, 300, 300, 300, 300, 300 (Lv1…10)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `ActionPreparation`): `int(MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)))`
<!-- calc:end -->

### TenjhoTengeMusouSwordAction · uid 638

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `TenjhoTengeMusouSwordAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, เพิ่มดาเมจตีปกติ
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `WeirdnessOfGodBuf` ระยะเวลา 5, 6, 6, 7, 7, 8, 8, 9, 9, 10 (Lv1…10) วินาที: ATK + (`AtkUp`) = `atk` · ตัวคูณตีปกติ % (`NormalAttackRate`) = `normalAttackRate + 50` · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `registBreak` · MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = 6, 7, 8, 9, 10, 16, 17, 18, 19, 25 (Lv1…10)

<!-- calc:begin uid=638 -->
#### การคำนวณแบบตัวเลข — TenjhoTengeMusouSwordAction (uid 638)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `constantDamage × (AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10) ? 2 : 1)` — โดยที่ `constantDamage` = `500` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `AbnormalStateManager.Contains` = ตัวละคร/มอนกำลังติดสถานะผิดปกตินี้อยู่หรือไม่; `MobActionManagerBase.get_AbnormalStateManager` = ค่า Abnormal State Manager ของ MobActionManagerBase; `AbnormalType.Breaking` = เกราะแตก (ดูแท็บ Variables)
- ดาเมจคงที่ตีแรก (`FirstAttack`, +): `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamage` = ดาเมจคงที่ของ Fast Attack (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Function ≤ 499`]: `(((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Function + 3000)) / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `EquipItemData.get_Weapon` = ค่า Weapon ของ EquipItemData; `PlayerStatusBase.get_EquipItemData` = ค่า Equip Item Data ของ PlayerStatusBase (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Function > 499`]: **3500%** → 3500%, 3500%, 3500%, 3500%, 3500%, 3500%, 3500%, 3500%, 3500%, 3500% (Lv1…10)
- ตัวคูณตีแรก (`FirstAttackRate`, ×, บวกเข้าช่อง): `PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamageRate` = ตัวคูณของ Fast Attack (ดูแท็บ Variables)
<!-- calc:end -->

### LunaDitherStarBladeRainAction · uid 671

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `LunaDitherStarBladeRainAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `LunaDitherStarBladeRainBuf`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- บัพ `LunaDitherStarBuf` ระยะเวลา `6 × hitCount` วินาที
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `LunaDitherStarAction.ReceivedAbnormal` — LunaDitherStarAction.ReceivedAbnormal: [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.LunaDitherStarBladeRain` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.LunaDitherStarBladeRain) & 1) ne … (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `LunaDitherStarBladeRainAction.<>c__DisplayClass45_0.<ActionStart>b__0` — <>c__DisplayClass45_0.<ActionStart>b__0: [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new LunaDitherStarBuf, [<>c__DisplayClass45_0.…` เมื่อ (cancel & 1) eq 0 AND (SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), SkillId.LunaDitherStarBl…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.LunaDitherStarBladeRain` (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=671 -->
#### การคำนวณแบบตัวเลข — LunaDitherStarBladeRainAction (uid 671)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **0** → 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(250 + 5×Lv)%** → 255%, 260%, 265%, 270%, 275%, 280%, 285%, 290%, 295%, 300% (Lv1…10)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `target.ExpDefMagic / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefMagic` = proration ช่อง Magic ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpList[mobAction] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
<!-- calc:end -->

### RangeHateAttackAction · uid 703

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `RangeHateAttackAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: แอ็กชันระบบ/อรรถประโยชน์
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration

### LifeExplosionAction · uid 732

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `LifeExplosionAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ฟื้นฟู
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

<!-- calc:begin uid=732 -->
#### การคำนวณแบบตัวเลข — LifeExplosionAction (uid 732)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **400** → 400, 400, 400, 400, 400, 400, 400, 400, 400, 400 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(1000 + 100×Lv)%** → 1100%, 1200%, 1300%, 1400%, 1500%, 1600%, 1700%, 1800%, 1900%, 2000% (Lv1…10)
<!-- calc:end -->

### AutoDeviceAttackAction · uid 733

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `AutoDeviceAttackAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: แอ็กชันระบบ/อรรถประโยชน์
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องตีปกติ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

### AstralLanceAttackAction · uid 734

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `AstralLanceAttackAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · ไม่เปลี่ยนค่า proration

<!-- calc:begin uid=734 -->
#### การคำนวณแบบตัวเลข — AstralLanceAttackAction (uid 734)
Proration: ช่อง `Magic` โหมด `never (IsExpDefFluctuate=false)`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **500** → 500, 500, 500, 500, 500, 500, 500, 500, 500, 500 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): **(250 + 50×Lv)%** → 300%, 350%, 400%, 450%, 500%, 550%, 600%, 650%, 700%, 750% (Lv1…10)
<!-- calc:end -->

### CounterForceAttackAction · uid 735

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `CounterForceAttackAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · ไม่เปลี่ยนค่า proration

<!-- calc:begin uid=735 -->
#### การคำนวณแบบตัวเลข — CounterForceAttackAction (uid 735)
Proration: ช่อง `Magic` โหมด `never (IsExpDefFluctuate=false)`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **75** → 75, 75, 75, 75, 75, 75, 75, 75, 75, 75 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [INT รวม=100]: **(10 + 30×Lv)%** → 40%, 70%, 100%, 130%, 160%, 190%, 220%, 250%, 280%, 310% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [INT รวม=255]: **(25.5 + 30×Lv)%** → 55.5%, 85.5%, 115.5%, 145.5%, 175.5%, 205.5%, 235.5%, 265.5%, 295.5%, 325.5% (Lv1…10)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `OnInitialize`): 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 (Lv1…10)
<!-- calc:end -->

### BattleNotesAttackAction · uid 797

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `BattleNotesAttackAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: ธรรมดา (SkillNormal)
- Proration: ช่องตีปกติ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

<!-- calc:begin uid=797 -->
#### การคำนวณแบบตัวเลข — BattleNotesAttackAction (uid 797)
Proration: ช่อง `Normal` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจฐาน (`BaseDamage`, +, ตั้งค่าทับ) [`CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) ≠ 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ …]: `PlayerAttackBase.calcBaseDamage(playerAction, mobAction, BattleNotesAttackAction.get_AttackType(), baseSkillMaster.EqLimit, CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2 ? 1 : 0)` — โดยที่ `baseSkillMaster` = `MasterSkillDataManager.GetSkillMaster(Singleton<MasterSkillDataManager>.get_Instance(), 778)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcBaseDamage` = ดาเมจฐาน = (ATK/MATK + ผลต่างเลเวลผู้เล่น-มอน [+ ATK อาวุธรอง×ความเสถี; `BattleNotesAttackAction.get_AttackType` = ค่า Attack Type ของ BattleNotesAttackAction; `CalcHit.hitType` = CalcHit.hitType; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +, ตั้งค่าทับ) [`CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) ≠ 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ …]: `buffParam(NormalAttackConstantDamage)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- หักป้องกันเป้า (`Def`, +, ตั้งค่าทับ) [`CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) ≠ 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ …]: `-PlayerAttackBase.CalcRegistDamage(this, BattleNotesAttackAction.get_AttackType(), PlayerActionManagerBase.get_PlayerStatus(), เป้า)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.CalcRegistDamage` = ค่า DEF/MDEF ของมอนที่หักออก (หลังหัก pierce); `BattleNotesAttackAction.get_AttackType` = ค่า Attack Type ของ BattleNotesAttackAction; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `MobActionManagerBase.get_MobBattleStatus` = ค่า Mob Battle Status ของ MobActionManagerBase (ดูแท็บ Variables)
- ตัวคูณคริติคอลเพิ่ม (`CriticalRate`, ×, ตั้งค่าทับ) [`CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) = 2` และ …]: `CriticalDmgรวม / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.CriticalDmg` = ดาเมจคริติคอลกายภาพ % (ใช้เป็น CriticalDmg/100) (ดูแท็บ Variables)
- ตัวคูณคริติคอลเพิ่ม (`CriticalRate`, ×, ตั้งค่าทับ) [`CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) ≠ 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) ≠ 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) ≠ 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) = 2` และ …]: **100%** → 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100% (Lv1…10)
- โบนัสธาตุ (`ElementBonusRate`, ×, ตั้งค่าทับ) [`CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) ≠ 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ …]: `PlayerAttackBase.CalcElementBonus(this, PlayerActionManagerBase.get_PlayerStatus(), BattleNotesAttackAction.get_AttackType(), target.Element)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.Element` = ธาตุของมอน; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `BattleNotesAttackAction.get_AttackType` = ค่า Attack Type ของ BattleNotesAttackAction (ดูแท็บ Variables)
- ต้านธาตุ (`NormalElementDamageResistRate`, ×, ตั้งค่าทับ) [`CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) ≠ 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ …]: `PlayerAttackBase.CalcNormalElementWeaponDamageResistRate(PlayerActionManagerBase.get_PlayerStatus(), mobAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.CalcNormalElementWeaponDamageResistRate` = ตัวคูณต้านธาตุของอาวุธ; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, ตั้งค่าทับ) [`CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) ≠ 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ …]: `buffParam(NormalAttackRate) / 100 + GemCartBufferManager.GetNormalAttackRate(PlayerStatusBase.get_GemCartBuffManager()) / 100 + 1` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `GemCartBufferManager.GetNormalAttackRate` = GemCartBufferManager.GetNormalAttackRate; `PlayerStatusBase.get_GemCartBuffManager` = ค่า Gem Cart Buff Manager ของ PlayerStatusBase (ดูแท็บ Variables)
- ความเสถียร (`StableRate`, ×, ตั้งค่าทับ) [`CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) ≠ 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ …]: `PlayerAttackBase.CalcStable(3, Stableรวม, CalcHit.correctHit(this, A, mobAction), A)` · `A = PlayerActionManagerBase.get_PlayerStatus()` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `status.Stable` = ความเสถียร (Stability) %; `CalcHit.correctHit` = CalcHit.correctHit; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ) [`CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) ≠ 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ …]: `target.ExpDefNormal / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefNormal` = proration ช่อง Normal ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, ×, ตั้งค่าทับ) [`CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) = 2` และ … หรือ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `!PlayerAttackBase.CheckAbnormalDamageIncrease(this, mobAction, PlayerAttackBase.CalcGemLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus()))` และ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ …]: `PlayerAttackBase.CalcBufferLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus()) - MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase; `MobPropertyLifeReduceDamage.CalcReduceLastDamageRate` = คำนวณ reduce last damage rate (MobPropertyLifeReduceDamage) (ดูแท็บ Variables)
- ตัวคูณดาเมจสุดท้าย (`LastDamageRate`, ×, ตั้งค่าทับ) [`CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) = 2` และ … หรือ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `!PlayerAttackBase.CheckAbnormalDamageIncrease(this, mobAction, PlayerAttackBase.CalcGemLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus()))` และ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ …]: `PlayerAttackBase.CalcBufferLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus())` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
- ต้านตามระยะ (`DistanceResistRate`, ×, ตั้งค่าทับ) [`CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) = 2` และ … หรือ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `!PlayerAttackBase.CheckAbnormalDamageIncrease(this, mobAction, PlayerAttackBase.CalcGemLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus()))` และ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ …]: `PlayerAttackBase.CalcDistanceResistRate(playerAction, mobAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.CalcDistanceResistRate` = ตัวคูณต้านระยะของมอน (ดูแท็บ Variables)
- ตัวคูณสุดท้ายพิเศษ (`SpecialLastDamageRate`, ×, ตั้งค่าทับ) [`CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) = 2` และ … หรือ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `!PlayerAttackBase.CheckAbnormalDamageIncrease(this, mobAction, PlayerAttackBase.CalcGemLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus()))` และ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ …]: `PlayerAttackBase.GetSpecificWeaponLastDamageRate(playerAction, mobAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.GetSpecificWeaponLastDamageRate` = PlayerAttackBase.GetSpecificWeaponLastDamageRate (ดูแท็บ Variables)
- ตัวคูณเจม (`GemDamageRate`, ×, ตั้งค่าทับ) [`CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) = 2` และ … หรือ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `!PlayerAttackBase.CheckAbnormalDamageIncrease(this, mobAction, PlayerAttackBase.CalcGemLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus()))` และ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ …]: `PlayerAttackBase.CalcGemLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus())` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.CalcGemLastDamageRate` = ตัวคูณดาเมจสุดท้ายจากเจมคาร์ท; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
- เพิ่มดาเมจเป้าติดสถานะ (`AbnormalDamageIncreaseRate`, ×, ตั้งค่าทับ) [`CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) = 2` และ … หรือ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) ≠ 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) = 2` และ …]: `CheckAbnormalDamageIncrease.out2(this, mobAction, PlayerAttackBase.CalcGemLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus()))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `CheckAbnormalDamageIncrease.out2` = CheckAbnormalDamageIncrease.out2; `PlayerAttackBase.CalcGemLastDamageRate` = ตัวคูณดาเมจสุดท้ายจากเจมคาร์ท; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) = 2` และ … หรือ `!PlayerAttackBase.CheckAbnormalDamageIncrease(this, mobAction, PlayerAttackBase.CalcGemLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus()))` และ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ … หรือ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) ≠ 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) = 2` และ …]: `max(25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)), 0)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobBuffer.GuardUpBuff.get_GuardUpval` = ค่า Guard Upval ของ GuardUpBuff; `TryGetBuff.buff` = TryGetBuff.buff; `MobActionManagerBase.get_BuffManager` = ค่า Buff Manager ของ MobActionManagerBase (ดูแท็บ Variables)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) = 2` และ … หรือ `!PlayerAttackBase.CheckAbnormalDamageIncrease(this, mobAction, PlayerAttackBase.CalcGemLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus()))` และ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ … หรือ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) ≠ 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) = 2` และ …]: **25** → 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 (Lv1…10)
- ตัวคูณล่าสมบัติ (`NormalAttackTreasureHuntLastDamageRate`, ×, ตั้งค่าทับ) [`CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) = 2` และ … หรือ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `!PlayerAttackBase.CheckAbnormalDamageIncrease(this, mobAction, PlayerAttackBase.CalcGemLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus()))` และ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ …]: `BonusManager.GetTreasureHuntLastDmgRateBonus(PlayerStatusBase.get_BonusManager())` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `BonusManager.GetTreasureHuntLastDmgRateBonus` = BonusManager.GetTreasureHuntLastDmgRateBonus; `PlayerStatusBase.get_BonusManager` = ค่า Bonus Manager ของ PlayerStatusBase (ดูแท็บ Variables)
- เพดานดาเมจ (`DamageLimit`, +, ตั้งค่าทับ) [`CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) = 2` และ … หรือ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ `PlayerAttackBase.CalcHitReaction(this, BattleNotesAttackAction.get_AttackType(), playerAction, mobAction) ≠ 1` และ … หรือ `!PlayerAttackBase.CheckAbnormalDamageIncrease(this, mobAction, PlayerAttackBase.CalcGemLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus()))` และ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ `MobActionManagerBase.get_SystemInvincible(mobAction)` และ …]: `CheckPlayerDamageUpLimit.limitDamage(this, playerAction, mobAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `CheckPlayerDamageUpLimit.limitDamage` = CheckPlayerDamageUpLimit.limitDamage (ดูแท็บ Variables)
- ดาเมจต่ำสุด (`MinDamage`, +, ตั้งค่าทับ) [`CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `CheckDamageLimit.max(this, mobAction) ≠ -1` และ `CheckDamageLimit.min(this, mobAction) ≠ -1` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ … หรือ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `CheckDamageLimit.max(this, mobAction) = -1` และ `CheckDamageLimit.min(this, mobAction) ≠ -1` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ … หรือ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `CheckDamageLimit.max(this, mobAction) ≠ -1` และ `CheckDamageLimit.min(this, mobAction) ≠ -1` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ …]: `CheckDamageLimit.min(this, mobAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `CheckDamageLimit.min` = CheckDamageLimit.min (ดูแท็บ Variables)
- ดาเมจสูงสุด (`MaxDamage`, +, ตั้งค่าทับ) [`CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `CheckDamageLimit.max(this, mobAction) ≠ -1` และ `CheckDamageLimit.min(this, mobAction) ≠ -1` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ … หรือ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `CheckDamageLimit.max(this, mobAction) ≠ -1` และ `CheckDamageLimit.min(this, mobAction) = -1` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ … หรือ `CalcHit.hitType(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) = 2` และ `CheckDamageLimit.max(this, mobAction) ≠ -1` และ `CheckDamageLimit.min(this, mobAction) ≠ -1` และ `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) = 1` และ …]: `CheckDamageLimit.max(this, mobAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `CheckDamageLimit.max` = CheckDamageLimit.max (ดูแท็บ Variables)
<!-- calc:end -->

### SetlistAction · uid 799

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `SetlistAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: แอ็กชันระบบ/อรรถประโยชน์
- MP ที่ใช้ [`SetlistAction.GetSkillId() ≥ 1`]: `SongActionBase.CalcBaseCostMp(SkillFactory.CreateSkill(A, SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), A, 1), actarAction), PlayerActionManagerBase.get_PlayerStatus())` · `A = SetlistAction.GetSkillId()`
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration

### HolyGracePursuitAttackAction · uid 863

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `HolyGracePursuitAttackAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องตีปกติ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

<!-- calc:begin uid=863 -->
#### การคำนวณแบบตัวเลข — HolyGracePursuitAttackAction (uid 863)
Proration: ช่อง `Normal` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`(mainWeaponType & 0xfffffffe) = 14` · DEX รวม=100]: 400, 400, 400, 400, 400, 700, 1000, 1300, 1600, 1900 (Lv1…10)
  - สูตร: `DEXรวม + (300 × Lv > 1500 ? 300 × Lv : 1500) - 1200`
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`(mainWeaponType & 0xfffffffe) = 14` · DEX รวม=255]: 555, 555, 555, 555, 555, 855, 1155, 1455, 1755, 2055 (Lv1…10)
  - สูตร: `DEXรวม + (300 × Lv > 1500 ? 300 × Lv : 1500) - 1200`
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [`(mainWeaponType & 0xfffffffe) ≠ 14`]: 300, 300, 300, 300, 300, 600, 900, 1200, 1500, 1800 (Lv1…10)
  - สูตร: `(300 × Lv > 1500 ? 300 × Lv : 1500) - 1200`
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`(mainWeaponType & 0xfffffffe) = 14`]: `(50 × Lv + baseINT) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `baseINT` = แต้ม INT ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า baseINT (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`(mainWeaponType & 0xfffffffe) ≠ 14`]: **(50×Lv)%** → 50%, 100%, 150%, 200%, 250%, 300%, 350%, 400%, 450%, 500% (Lv1…10)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `target.ExpDefNormal / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefNormal` = proration ช่อง Normal ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
<!-- calc:end -->

### BlitzPikePursuitAction · uid 988

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `BlitzPikePursuitAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: ธรรมดา (SkillNormal)
- Proration: ช่องตีปกติ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

<!-- calc:begin uid=988 -->
#### การคำนวณแบบตัวเลข — BlitzPikePursuitAction (uid 988)
Proration: ช่อง `Normal` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [INT รวม=100]: **100** → 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 (Lv1…10)
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +) [INT รวม=255]: **255** → 255, 255, 255, 255, 255, 255, 255, 255, 255, 255 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [INT รวม=100]: **50%** → 50%, 50%, 50%, 50%, 50%, 50%, 50%, 50%, 50%, 50% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [INT รวม=255]: **127%** → 127%, 127%, 127%, 127%, 127%, 127%, 127%, 127%, 127%, 127% (Lv1…10)
<!-- calc:end -->

### GodSpearHandling3Action · uid 989

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `GodSpearHandling3Action`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `HandlingerOfGodspeedBuf` ระยะเวลา 10 + 2×Lv → 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 (Lv1…10) วินาที: หลบ + (`AvoidUp`) = `avoid` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · MP สูงสุด + (`MaxMpUp`) = `-maxMp` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `cverlayCount` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ความเร็วโจมตี + (`Aspd`) = `aspd` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ลดดาเมจเวทที่ได้รับ (`MagicDmgCut`) = `(cverlayCount * (HandlingerOfGodspeedBuf.GetGodSpearHandlingParam(this, id) - magicResist))` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ลดดาเมจกายภาพที่ได้รับ (`PowerDmgCut`) = `(cverlayCount * (HandlingerOfGodspeedBuf.GetGodSpearHandlingParam(this, id) - physicsResist))` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ความเร็วท่าทาง % (`MotionSpeedRate`) = `actionSpeed` (ตัวนับที่เปลี่ยนตามเหตุการณ์)

### GodSpearHandling2Action · uid 990

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `GodSpearHandling2Action`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `HandlingerOfGodspeedBuf` ระยะเวลา 10 + 2×Lv → 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 (Lv1…10) วินาที: หลบ + (`AvoidUp`) = `avoid` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · MP สูงสุด + (`MaxMpUp`) = `-maxMp` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `cverlayCount` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ความเร็วโจมตี + (`Aspd`) = `aspd` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ลดดาเมจเวทที่ได้รับ (`MagicDmgCut`) = `(cverlayCount * (HandlingerOfGodspeedBuf.GetGodSpearHandlingParam(this, id) - magicResist))` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ลดดาเมจกายภาพที่ได้รับ (`PowerDmgCut`) = `(cverlayCount * (HandlingerOfGodspeedBuf.GetGodSpearHandlingParam(this, id) - physicsResist))` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ความเร็วท่าทาง % (`MotionSpeedRate`) = `actionSpeed` (ตัวนับที่เปลี่ยนตามเหตุการณ์)

### GodSpearHandling1Action · uid 991

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `GodSpearHandling1Action`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `HandlingerOfGodspeedBuf` ระยะเวลา 10 + 2×Lv → 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 (Lv1…10) วินาที: หลบ + (`AvoidUp`) = `avoid` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · MP สูงสุด + (`MaxMpUp`) = `-maxMp` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `cverlayCount` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ความเร็วโจมตี + (`Aspd`) = `aspd` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ลดดาเมจเวทที่ได้รับ (`MagicDmgCut`) = `(cverlayCount * (HandlingerOfGodspeedBuf.GetGodSpearHandlingParam(this, id) - magicResist))` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ลดดาเมจกายภาพที่ได้รับ (`PowerDmgCut`) = `(cverlayCount * (HandlingerOfGodspeedBuf.GetGodSpearHandlingParam(this, id) - physicsResist))` (ตัวนับที่เปลี่ยนตามเหตุการณ์) · ความเร็วท่าทาง % (`MotionSpeedRate`) = `actionSpeed` (ตัวนับที่เปลี่ยนตามเหตุการณ์)

### KunaiThrowingAction · uid 1219

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `KunaiThrowingAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- MP ที่ใช้: `NinjaSkillBase.CalcNinjaSkillBaseMp(this, 300, actarAction)`
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: ธรรมดา (SkillNormal)
- Proration: ช่องตีปกติ · เปลี่ยนค่าทุกฮิต

<!-- calc:begin uid=1219 -->
#### การคำนวณแบบตัวเลข — KunaiThrowingAction (uid 1219)
Proration: ช่อง `Normal` โหมด `every_hit + class check`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก คาตานะ · Lv สกิล 1227 NinjutsuTraining1=1, Lv สกิล 1228 NinjutsuTraining2=1]: **64%** → 64%, 64%, 64%, 64%, 64%, 64%, 64%, 64%, 64%, 64% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก คาตานะ · Lv สกิล 1227 NinjutsuTraining1=1, Lv สกิล 1228 NinjutsuTraining2=10 หรือ อาวุธหลัก คาตานะ · Lv สกิล 1227 NinjutsuTraining1=10, Lv สกิล 1228 NinjutsuTraining2=1]: **82%** → 82%, 82%, 82%, 82%, 82%, 82%, 82%, 82%, 82%, 82% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลัก คาตานะ · Lv สกิล 1227 NinjutsuTraining1=10, Lv สกิล 1228 NinjutsuTraining2=10]: **100%** → 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ คาตานะ) · Lv สกิล 1227 NinjutsuTraining1=1, Lv สกิล 1228 NinjutsuTraining2=1]: **32%** → 32%, 32%, 32%, 32%, 32%, 32%, 32%, 32%, 32%, 32% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ คาตานะ) · Lv สกิล 1227 NinjutsuTraining1=1, Lv สกิล 1228 NinjutsuTraining2=10 หรือ อาวุธหลักอื่น (ไม่ใช่ คาตานะ) · Lv สกิล 1227 NinjutsuTraining1=10, Lv สกิล 1228 NinjutsuTraining2=1]: **41%** → 41%, 41%, 41%, 41%, 41%, 41%, 41%, 41%, 41%, 41% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [อาวุธหลักอื่น (ไม่ใช่ คาตานะ) · Lv สกิล 1227 NinjutsuTraining1=10, Lv สกิล 1228 NinjutsuTraining2=10]: **50%** → 50%, 50%, 50%, 50%, 50%, 50%, 50%, 50%, 50%, 50% (Lv1…10)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `target.ExpDefSkill / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefSkill` = proration ช่อง Skill ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpLit[MobActionManagerBase.get_MobStatus(mobAction).UniqueId] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_MobStatus` = ค่า Mob Status ของ MobActionManagerBase (ดูแท็บ Variables)

**ใช้ร่วมทุกฮิตของ ฮิตรีแอ็กชัน (`HitReactionAssign`)**
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical)` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: `System.Math.Max(0, 25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4)))` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobBuffer.GuardUpBuff.get_GuardUpval` = ค่า Guard Upval ของ GuardUpBuff; `TryGetBuff.buff` = TryGetBuff.buff; `MobActionManagerBase.get_BuffManager` = ค่า Buff Manager ของ MobActionManagerBase (ดูแท็บ Variables)
- พลังการ์ด (`GuardPower`, ตั้งค่า) [`!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) ≠ 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `((1 | isCritical) & 1) = 0` และ `(False & 1) = 0` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ … หรือ `!MobActionManagerBase.get_SystemInvincible(mobAction)` และ `(False & 1) = 0` และ `AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33)` และ `PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) = 2` และ …]: **25** → 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 (Lv1…10)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `ActionStart`): `int(MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)))`
- `damageCount` (ตั้งใน `NextRangeHit`): `damageCount + 1`
<!-- calc:end -->

### FumaShurikenAction · uid 1220

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `FumaShurikenAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- MP ที่ใช้: `NinjaSkillBase.CalcNinjaSkillBaseMp(this, gemCart(1030, [2]) + 500, actarAction)`
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

<!-- calc:begin uid=1220 -->
#### การคำนวณแบบตัวเลข — FumaShurikenAction (uid 1220)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **100 + 20×Lv** → 120, 140, 160, 180, 200, 220, 240, 260, 280, 300 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `attackUpCount`]: `skillRate × ((GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1030) ≠ 0 ? A + 1 : A) > 0 ? 10 : 1) / 100` · `A = mainWeapon = Katana ? NinjaSkillBase.GetNinjutsuTraining(this, PlayerActionManagerBase.get_PlayerStatus()) // 10 + (Lv = 10 ? 1 : 0) + 1 : NinjaSkillBase.GetNinjutsuTraining(this, PlayerActionManagerBase.get_PlayerStatus()) // 10 + (Lv = 10 ? 1 : 0)` — โดยที่ `skillRate` = `3 × Lv + NinjaSkillBase.GetNinko(this, PlayerActionManagerBase.get_PlayerStatus()) // 10 + 20` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `GemCartBufferManager.GetGemCartBuffer` = GemCartBufferManager.GetGemCartBuffer; `PlayerStatusBase.get_GemCartBuffManager` = ค่า Gem Cart Buff Manager ของ PlayerStatusBase; `PlayerActionManagerBase.get_PlayerStatus` = ค่า Player Status ของ PlayerActionManagerBase (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [`hit ≠ 0` และ `param = 102` และ `param ≠ 103`]: `skillRate × (attackUpCount > 0 ? 10 : 1) / 100` — โดยที่ `skillRate` = `3 × Lv + NinjaSkillBase.GetNinko(this, PlayerActionManagerBase.get_PlayerStatus()) // 10 + 20` ; `attackUpCount` = `GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1030) ≠ 0 ? A + 1 : A` (`A = mainWeapon = Katana ? NinjaSkillBase.GetNinjutsuTraining(this, PlayerActionManagerBase.get_PlayerStatus()) // 10 + (Lv = 10 ? 1 : 0) + 1 : NinjaSkillBase.GetNinjutsuTraining(this, PlayerActionManagerBase.get_PlayerStatus()) // 10 + (Lv = 10 ? 1 : 0)`) หรือ `max(attackUpCount - 1, 0)` [`hit ≠ 0` และ `param = 102` และ `param ≠ 103`] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
<!-- calc:end -->

### FireStyleAction · uid 1221

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `FireStyleAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- MP ที่ใช้: `NinjaSkillBase.CalcNinjaSkillBaseMp(this, 600, actarAction)`
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: ไฟไหม้ (Ignition)

<!-- calc:begin uid=1221 -->
#### การคำนวณแบบตัวเลข — FireStyleAction (uid 1221)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `change ≠ 0`, `isFirstAttack = 0`**
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `targetExpRegister / 100` — โดยที่ `targetExpRegister` = `target.ExpDefSkill` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**ฮิต 2: `calcPlayerToMobDamage` (ดาเมจหลัก) — `change ≠ 0`, `isFirstAttack ≠ 0` · ส่วน ระยะ (`range…`)**
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `rangeSkillRate / 100` — โดยที่ `rangeSkillRate` = `rangeSkillRate + NinjaSkillBase.GetNinko(this, A) + 30 × NinjaSkillBase.GetNinjutsuTraining(this, A)` (`A = PlayerActionManagerBase.get_PlayerStatus()`) [`AbnormalStateManager.Contains(PlayerActionManagerBase.get_AbnormalStatusManager(), 8)` หรือ `!AbnormalStateManager.Contains(PlayerActionManagerBase.get_AbnormalStatusManager(), 8)`] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)

**ใช้ร่วมทุกฮิตของ ดาเมจหลัก**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **400** → 400, 400, 400, 400, 400, 400, 400, 400, 400, 400 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง): `targetSkillRate / 100` — โดยที่ `targetSkillRate` = `?mla + NinjaSkillBase.GetNinko(this, A) + 30 × NinjaSkillBase.GetNinjutsuTraining(this, A)` (`A = PlayerActionManagerBase.get_PlayerStatus()`) [`AbnormalStateManager.Contains(PlayerActionManagerBase.get_AbnormalStatusManager(), 8)` หรือ `!AbnormalStateManager.Contains(PlayerActionManagerBase.get_AbnormalStatusManager(), 8)`] (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `target.ExpDefSkill / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `target.ExpDefSkill` = proration ช่อง Skill ของมอน (ค่าปัจจุบัน %) (ดูแท็บ Variables)
<!-- calc:end -->

### ThunderStyleAction · uid 1222

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `ThunderStyleAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, เปลี่ยนการทำงานของตีปกติ
- MP ที่ใช้: `NinjaSkillBase.CalcNinjaSkillBaseMp(this, 600, actarAction)`
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- บัพ `SwordMoveBuf`: ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `damageInvalid` (ตัวนับที่เปลี่ยนตามเหตุการณ์)

<!-- calc:begin uid=1222 -->
#### การคำนวณแบบตัวเลข — ThunderStyleAction (uid 1222)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **200 + 20×Lv** → 220, 240, 260, 280, 300, 320, 340, 360, 380, 400 (Lv1…10)
- ดาเมจคงที่ตีแรก (`FirstAttack`, +): `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamage` = ดาเมจคงที่ของ Fast Attack (ดูแท็บ Variables)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [ค่าฐานอาวุธรอง (`ItemData.Function`)=100, Lv สกิล 1227 NinjutsuTraining1=1, Lv สกิล 1228 NinjutsuTraining2=1]: **(260 + 10×Lv)%** → 270%, 280%, 290%, 300%, 310%, 320%, 330%, 340%, 350%, 360% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [ค่าฐานอาวุธรอง (`ItemData.Function`)=100, Lv สกิล 1227 NinjutsuTraining1=1, Lv สกิล 1228 NinjutsuTraining2=10 หรือ ค่าฐานอาวุธรอง (`ItemData.Function`)=100, Lv สกิล 1227 NinjutsuTraining1=10, Lv สกิล 1228 NinjutsuTraining2=1]: **(530 + 10×Lv)%** → 540%, 550%, 560%, 570%, 580%, 590%, 600%, 610%, 620%, 630% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [ค่าฐานอาวุธรอง (`ItemData.Function`)=100, Lv สกิล 1227 NinjutsuTraining1=10, Lv สกิล 1228 NinjutsuTraining2=10]: **(800 + 10×Lv)%** → 810%, 820%, 830%, 840%, 850%, 860%, 870%, 880%, 890%, 900% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [ค่าฐานอาวุธรอง (`ItemData.Function`)=300, Lv สกิล 1227 NinjutsuTraining1=1, Lv สกิล 1228 NinjutsuTraining2=1]: **(460 + 10×Lv)%** → 470%, 480%, 490%, 500%, 510%, 520%, 530%, 540%, 550%, 560% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [ค่าฐานอาวุธรอง (`ItemData.Function`)=300, Lv สกิล 1227 NinjutsuTraining1=1, Lv สกิล 1228 NinjutsuTraining2=10 หรือ ค่าฐานอาวุธรอง (`ItemData.Function`)=300, Lv สกิล 1227 NinjutsuTraining1=10, Lv สกิล 1228 NinjutsuTraining2=1]: **(730 + 10×Lv)%** → 740%, 750%, 760%, 770%, 780%, 790%, 800%, 810%, 820%, 830% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [ค่าฐานอาวุธรอง (`ItemData.Function`)=300, Lv สกิล 1227 NinjutsuTraining1=10, Lv สกิล 1228 NinjutsuTraining2=10]: **(1000 + 10×Lv)%** → 1010%, 1020%, 1030%, 1040%, 1050%, 1060%, 1070%, 1080%, 1090%, 1100% (Lv1…10)
- ตัวคูณตีแรก (`FirstAttackRate`, ×, บวกเข้าช่อง): `PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamageRate` = ตัวคูณของ Fast Attack (ดูแท็บ Variables)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `ActionStart`): `int(1.5 × MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)))`
<!-- calc:end -->

### WaterStyleAction · uid 1223

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `WaterStyleAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- MP ที่ใช้: `NinjaSkillBase.CalcNinjaSkillBaseMp(this, 700, actarAction)`
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `WaterStyleBuf` ระยะเวลา 3 วินาที: ตัวคูณดาเมจที่ได้รับจากมอน (หมวดซัพพอร์ต) (`MobLastDamageRateSupport`) = 5 + Lv → 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 (Lv1…10)
- ตัวอ่านสกิลนี้ `InstallationBlackHolePattern.CheckSuctionHit` — ตรวจ suction hit (InstallationBlackHolePattern): คืนค่า `0` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `InstallationMoveBlackHolePattern.CheckSuctionHit` — ตรวจ suction hit (InstallationMoveBlackHolePattern): คืนค่า `0` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.get_MoveSpeed` — ค่า Move Speed ของ MobaPlayerActionManager: คืนค่า `_t1117` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PetMemberActionManager.get_MoveSpeed` — ค่า Move Speed ของ PetMemberActionManager: คืนค่า `0` (3 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.get_MoveSpeed` — ค่า Move Speed ของ PlayerActionManager: คืนค่า `_t1348` (3 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerAttackBase.ActionStart` — PlayerAttackBase: ตอนเริ่มทำงานของสกิล: [set] `_motionSpeed` = `int((SkillActionBase.get_MotionSpeed(this) * 1.5))` เมื่อ (AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), AbnormalType.Freeze) & 1) ne 0 AND (SkillB…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.Shukuchi` เมื่อ (SkillActionBase.get_IsServantSkill() & 1) eq 0 AND (+0x109 & 5) eq 0 AND (_t1356 & 1) ne 0 AND PlayerAttackBase.get_Ac…; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.FloatDash` เมื่อ (SkillActionBase.get_IsServantSkill() & 1) eq 0 AND (+0x109 & 5) eq 0 AND (SkillParam & 16) eq 0 AND PlayerAttackBase.g… (นิยามเต็มในแท็บ Variables)

### EarthStyleAction · uid 1224

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `EarthStyleAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: บัพตัวเอง
- MP ที่ใช้: `NinjaSkillBase.CalcNinjaSkillBaseMp(this, 600, actarAction)`
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration
- บัพ `EarthStyleBuf`: ตัวคูณดาเมจที่ได้รับจากมอน (หมวดบัพ) (`MobLastDamageRateBuf`) = `min(int((Max - Count) × (Max - Count) / 2.5 + 10), 50)` · ตัวนับ/stack (`Count`) = `Count`
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `EarthStyleAction.ActionSkillEndCheck` — EarthStyleAction.ActionSkillEndCheck: คืนค่า `0` (3 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `EarthStyleAction.Damaged` — EarthStyleAction: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.ReceiveDamaged` — MobaPlayerActionManager.ReceiveDamaged: [call] `SkillBufferManager$$RemoveSelfBuffer` = `MobaPlayerStatus.get_SkillBufferManager(), SkillId.Zanteisettetsu` เมื่อ (skillId & 0xffff) ne 514 AND GetServerHitTypeV2.hitType(responseData.HitType) ne 0 AND (SkillBufferManager.ContainsBuf…; [call] `PlayerGameStatus$$SetLocalHp` = `PlayerStatusBase.get_GameStatus(), int((IPlayerStatusCalculator.get_MaxHp(PlayerStatusBas…` เมื่อ (skillId & 0xffff) ne 514 AND GetServerHitTypeV2.hitType(responseData.HitType) ne 0 AND (CharacterActionManagerBase.get… (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=1224 -->
#### การคำนวณแบบตัวเลข — EarthStyleAction (uid 1224)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `OnInitialize`): `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`

**ค่าบัพที่ขึ้นกับจำนวน stack**

- บัพ `EarthStyleBuf` — `MobLastDamageRateBuf` ตามจำนวน `Count`: `min(int((Max - Count) × (Max - Count) / 2.5 + 10), 50)`

  | Count | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
  |---|---|---|---|---|---|---|---|---|---|---|
  | 1 | – | – | – | – | – | – | – | – | – | – |
  | 2 | – | – | – | – | – | – | – | – | – | – |
  | 3 | – | – | – | – | – | – | – | – | – | – |
  | 4 | – | – | – | – | – | – | – | – | – | – |
  | 5 | – | – | – | – | – | – | – | – | – | – |
<!-- calc:end -->

### WindStyleAction · uid 1225

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `WindStyleAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง, ทำให้ติดสถานะผิดปกติ
- MP ที่ใช้: `NinjaSkillBase.CalcNinjaSkillBaseMp(this, 500, actarAction)`
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: ล้มคว่ำ (Tumble)
- บัพ `WindStyleBuf` ระยะเวลา 20 วินาที: อัตราคริ + (`CrtUp`) = Lv → 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10) · ตัวคูณตีแรก (`FirstAttackRate`) = Lv → 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 (Lv1…10)
- ตัวอ่านสกิลนี้ `EquipItemData.WeaponTypeCalculatorBase.CalcAspd` — คำนวณ aspd (WeaponTypeCalculatorBase): คืนค่า `EquipItemData.WeaponTypeCalculatorBase.calcAspdParam(status, (_t270 + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), SkillB…` (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=1225 -->
#### การคำนวณแบบตัวเลข — WindStyleAction (uid 1225)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก) — `change ≠ 0`**
- ดาเมจคงที่ตีแรก (`FirstAttack`, +) [`isGemCart`]: `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamage` = ดาเมจคงที่ของ Fast Attack (ดูแท็บ Variables)
- ตัวคูณตีแรก (`FirstAttackRate`, ×, บวกเข้าช่อง) [`isGemCart`]: `PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `PlayerAttackBase.calcFastAttackDamageRate` = ตัวคูณของ Fast Attack (ดูแท็บ Variables)

**ใช้ร่วมทุกฮิตของ ดาเมจหลัก**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **200 + 10×Lv** → 210, 220, 230, 240, 250, 260, 270, 280, 290, 300 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [ค่าฐานอาวุธรอง (`ItemData.Function`)=100, Lv สกิล 1227 NinjutsuTraining1=1, Lv สกิล 1228 NinjutsuTraining2=1]: **(640 + 10×Lv)%** → 650%, 660%, 670%, 680%, 690%, 700%, 710%, 720%, 730%, 740% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [ค่าฐานอาวุธรอง (`ItemData.Function`)=100, Lv สกิล 1227 NinjutsuTraining1=1, Lv สกิล 1228 NinjutsuTraining2=10 หรือ ค่าฐานอาวุธรอง (`ItemData.Function`)=100, Lv สกิล 1227 NinjutsuTraining1=10, Lv สกิล 1228 NinjutsuTraining2=1]: **(820 + 10×Lv)%** → 830%, 840%, 850%, 860%, 870%, 880%, 890%, 900%, 910%, 920% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [ค่าฐานอาวุธรอง (`ItemData.Function`)=100, Lv สกิล 1227 NinjutsuTraining1=10, Lv สกิล 1228 NinjutsuTraining2=10]: **(1000 + 10×Lv)%** → 1010%, 1020%, 1030%, 1040%, 1050%, 1060%, 1070%, 1080%, 1090%, 1100% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [ค่าฐานอาวุธรอง (`ItemData.Function`)=300, Lv สกิล 1227 NinjutsuTraining1=1, Lv สกิล 1228 NinjutsuTraining2=1]: **(840 + 10×Lv)%** → 850%, 860%, 870%, 880%, 890%, 900%, 910%, 920%, 930%, 940% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [ค่าฐานอาวุธรอง (`ItemData.Function`)=300, Lv สกิล 1227 NinjutsuTraining1=1, Lv สกิล 1228 NinjutsuTraining2=10 หรือ ค่าฐานอาวุธรอง (`ItemData.Function`)=300, Lv สกิล 1227 NinjutsuTraining1=10, Lv สกิล 1228 NinjutsuTraining2=1]: **(1020 + 10×Lv)%** → 1030%, 1040%, 1050%, 1060%, 1070%, 1080%, 1090%, 1100%, 1110%, 1120% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [ค่าฐานอาวุธรอง (`ItemData.Function`)=300, Lv สกิล 1227 NinjutsuTraining1=10, Lv สกิล 1228 NinjutsuTraining2=10]: **(1200 + 10×Lv)%** → 1210%, 1220%, 1230%, 1240%, 1250%, 1260%, 1270%, 1280%, 1290%, 1300% (Lv1…10)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `ActionPreparation`) [`InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance())` และ ไม่ `change`]: `int((UnityEngine.Quaternion.Internal_MakePositive(0).y * 10))`
<!-- calc:end -->

### CloningTechniqueAction · uid 1226

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `CloningTechniqueAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), บัพตัวเอง
- MP ที่ใช้: `NinjaSkillBase.CalcNinjaSkillBaseMp(this, 600, actarAction)`
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: ธรรมดา (SkillNormal)
- Proration: ช่องตีปกติ · ไม่เปลี่ยนค่า proration
- บัพ `CloningTechniqueBuf` ระยะเวลา 60 วินาที: HP สูงสุด % (`MaxHpUpRate`) = `-(75 - 5 × Lv - ninjutsuTrainingLv)`
- บัพ `SkillBufferDataBase`: บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่
- ตัวอ่านสกิลนี้ `CloningTechniqueAction.IsFailure` — เงื่อนไข is failure (CloningTechniqueAction): [call] `SkillBufferManager$$AddSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), new CloningTechniqueBuf, Id` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.CloningTechnique) & 1) eq 0; [call] `SkillBufferManager$$RemoveSelfBuffer` = `PlayerStatusBase.get_SkillBufferManager(), SkillId.CloningTechnique` เมื่อ (SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), SkillId.CloningTechnique) & 1) eq 0 (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerActionManager.GetSkillTargetType` — MobaPlayerActionManager.GetSkillTargetType: คืนค่า `MasterSkillDataManager.GetSkillMaster(Singleton<MasterSkillDataManager>.get_Instance(), SkillId.CloningTechnique).TargetType` (2 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `MobaPlayerBattleManager.ConvertNinjutsuSkill` — MobaPlayerBattleManager.ConvertNinjutsuSkill: [call] `SkillFactory$$CreateSkill` = `1247, 1, playerAction` เมื่อ (NinjutsuAction.GetRandamNinjutsu() - 1223) hs 2 AND NinjutsuAction.GetRandamNinjutsu() eq 1226 AND (SkillBufferManager…; [call] `BattleManagerBase.TargetData$$Clear` = `nextTargetData` เมื่อ (NinjutsuAction.GetRandamNinjutsu() - 1223) hs 2 AND NinjutsuAction.GetRandamNinjutsu() eq 1226 AND (SkillBufferManager…; [call] `BattleManagerBase.TargetData$$SetTarget` = `nextTargetData, UnityEngine.Component.get_gameObject(playerAction), playerAction, Charact…` เมื่อ (NinjutsuAction.GetRandamNinjutsu() - 1223) hs 2 AND NinjutsuAction.GetRandamNinjutsu() eq 1226 AND (SkillBufferManager… (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerActionManager.GetSkillTargetType` — PlayerActionManager.GetSkillTargetType: คืนค่า `MasterSkillDataManager.GetSkillMaster(Singleton<MasterSkillDataManager>.get_Instance(), SkillId.CloningTechnique).TargetType` (11 กรณี) (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `PlayerBattleManager.ConvertNinjutsuSkill` — PlayerBattleManager.ConvertNinjutsuSkill: [call] `SkillFactory$$CreateSkill` = `1247, 1, playerAction` เมื่อ (NinjutsuAction.GetRandamNinjutsu() - 1223) hs 2 AND NinjutsuAction.GetRandamNinjutsu() eq 1226 AND (SkillBufferManager…; [call] `BattleManagerBase.TargetData$$Clear` = `nextTargetData` เมื่อ (NinjutsuAction.GetRandamNinjutsu() - 1223) hs 2 AND NinjutsuAction.GetRandamNinjutsu() eq 1226 AND (SkillBufferManager…; [call] `BattleManagerBase.TargetData$$SetTarget` = `nextTargetData, UnityEngine.Component.get_gameObject(playerAction), playerAction, Charact…` เมื่อ (NinjutsuAction.GetRandamNinjutsu() - 1223) hs 2 AND NinjutsuAction.GetRandamNinjutsu() eq 1226 AND (SkillBufferManager… (นิยามเต็มในแท็บ Variables)

<!-- calc:begin uid=1226 -->
#### การคำนวณแบบตัวเลข — CloningTechniqueAction (uid 1226)
Proration: ช่อง `Normal` โหมด `never (IsExpDefFluctuate=false)`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ตัวคูณสกิล (`SkillRate`, ×, ตั้งค่าทับ): **100%** → 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100%, 100% (Lv1…10)

**จำนวนฮิต / ตัวนับ**
- `LoopParam` (ตั้งใน `OnInitialize`): `int(100 × IPlayerStatusCalculator.GetNextAtkTime(PlayerStatusBase.get_SecondaryStatus()))`
<!-- calc:end -->

### RapidAquaVortexAction · uid 1245

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `RapidAquaVortexAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ), ทำให้ติดสถานะผิดปกติ
- MP ที่ใช้: `NinjaSkillBase.CalcNinjaSkillBaseMp(this, 300, actarAction)`
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: กายภาพ (ใช้ ATK)
- Proration: ช่องสกิลกายภาพ · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย
- สถานะที่ทำให้ติด: `(isFirstAttack ne 0 ? 12 : 1)`

<!-- calc:begin uid=1245 -->
#### การคำนวณแบบตัวเลข — RapidAquaVortexAction (uid 1245)
Proration: ช่อง `Skill` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): **500** → 500, 500, 500, 500, 500, 500, 500, 500, 500, 500 (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [ค่าฐานอาวุธรอง (`ItemData.Function`)=100, Lv สกิล 1227 NinjutsuTraining1=1, Lv สกิล 1228 NinjutsuTraining2=1]: **(170 + 10×Lv)%** → 180%, 190%, 200%, 210%, 220%, 230%, 240%, 250%, 260%, 270% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [ค่าฐานอาวุธรอง (`ItemData.Function`)=100, Lv สกิล 1227 NinjutsuTraining1=1, Lv สกิล 1228 NinjutsuTraining2=10 หรือ ค่าฐานอาวุธรอง (`ItemData.Function`)=100, Lv สกิล 1227 NinjutsuTraining1=10, Lv สกิล 1228 NinjutsuTraining2=1]: **(260 + 10×Lv)%** → 270%, 280%, 290%, 300%, 310%, 320%, 330%, 340%, 350%, 360% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [ค่าฐานอาวุธรอง (`ItemData.Function`)=100, Lv สกิล 1227 NinjutsuTraining1=10, Lv สกิล 1228 NinjutsuTraining2=10]: **(350 + 10×Lv)%** → 360%, 370%, 380%, 390%, 400%, 410%, 420%, 430%, 440%, 450% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [ค่าฐานอาวุธรอง (`ItemData.Function`)=300, Lv สกิล 1227 NinjutsuTraining1=1, Lv สกิล 1228 NinjutsuTraining2=1]: **(270 + 10×Lv)%** → 280%, 290%, 300%, 310%, 320%, 330%, 340%, 350%, 360%, 370% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [ค่าฐานอาวุธรอง (`ItemData.Function`)=300, Lv สกิล 1227 NinjutsuTraining1=1, Lv สกิล 1228 NinjutsuTraining2=10 หรือ ค่าฐานอาวุธรอง (`ItemData.Function`)=300, Lv สกิล 1227 NinjutsuTraining1=10, Lv สกิล 1228 NinjutsuTraining2=1]: **(360 + 10×Lv)%** → 370%, 380%, 390%, 400%, 410%, 420%, 430%, 440%, 450%, 460% (Lv1…10)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [ค่าฐานอาวุธรอง (`ItemData.Function`)=300, Lv สกิล 1227 NinjutsuTraining1=10, Lv สกิล 1228 NinjutsuTraining2=10]: **(450 + 10×Lv)%** → 460%, 470%, 480%, 490%, 500%, 510%, 520%, 530%, 540%, 550% (Lv1…10)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefSkill / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `localExpDefSkill` = proration ปัจจุบันของมอนในช่องสกิลกายภาพ (%); `MobActionManagerBase.get_MobStatus` = ค่า Mob Status ของ MobActionManagerBase (ดูแท็บ Variables)
- Proration (`ExpRate`, ×, ตั้งค่าทับ): `(targetExpList[MobActionManagerBase.get_MobStatus(mobAction).UniqueId] / 100)` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้) — ตัวแปร: `MobActionManagerBase.get_MobStatus` = ค่า Mob Status ของ MobActionManagerBase (ดูแท็บ Variables)
<!-- calc:end -->

### EarthStyleAttackAction · uid 1246

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `EarthStyleAttackAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: โจมตี (สร้างดาเมจ)
- ดาเมจ: สร้าง template ดาเมจ 1 ก้อน (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ "การคำนวณแบบตัวเลข" ด้านล่าง
- ประเภทดาเมจ: เวท (ใช้ MATK)
- Proration: ช่องเวท · เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย

<!-- calc:begin uid=1246 -->
#### การคำนวณแบบตัวเลข — EarthStyleAttackAction (uid 1246)
Proration: ช่อง `Magic` โหมด `first_hit_per_target`

**ฮิต 1: `calcPlayerToMobDamage` (ดาเมจหลัก)**
- ดาเมจคงที่ของสกิล (`SkillConstantDamage`, +): `fixAddDamage` (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
- ตัวคูณสกิล (`SkillRate`, ×, บวกเข้าช่อง) [กิ่งที่ 1 ของ `skillRate`]: `skillRate / 100` — โดยที่ `skillRate` = `(((skillRate + ((NinjaSkillBase.GetNinjutsuTraining(this, PlayerActionManagerBase.get_PlayerStatus()) + (NinjaSkillBase.GetNinjutsuTraining(this, PlayerActionManagerBase.get_PlayerStatus()) << 2)) << 2)) + (((skillRate + ((NinjaSkillBase.GetNinjutsuTraining(this, PlayerActionManagerBase.get_PlayerStatus()) + (NinjaSkillBase.GetNinjutsuTraining(this, PlayerActionManagerBase.get_PlayerStatus()) << 2)) << 2)) * 0.5) * (PlayerStatusBase.get_SkillBufferManager().skillBufList[1224].Max - PlayerStatusBase.get_SkillBufferManager().skillBufList[1224].Count))) + NinjaSkillBase.GetNinko(this, PlayerActionManagerBase.get_PlayerStatus()))` หรือ `skillRate + 20 × NinjaSkillBase.GetNinjutsuTraining(this, A) + NinjaSkillBase.GetNinko(this, A)` (`A = PlayerActionManagerBase.get_PlayerStatus()`) (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้)
<!-- calc:end -->

### UtsusemiAction · uid 1247

- แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)
- คลาสในโค้ด: `UtsusemiAction`

**ทำงานยังไง (จากโค้ด):**
- บทบาท: แอ็กชันระบบ/อรรถประโยชน์
- MP ที่ใช้: `NinjaSkillBase.CalcNinjaSkillBaseMp(this, 600, actarAction)`
- Proration: ไม่มีช่อง · ไม่เปลี่ยนค่า proration

