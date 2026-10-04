# สกิลมินสเตรล (10 สกิล)

สรุปโดยรวมต่อสกิล: ตัวคูณดาเมจมาจากไหน / แยกอาวุธ / สถานะระหว่างท่า / บัพ / เชื่อมสกิลอื่น. วิธีอ่าน: [ENGINE.md](ENGINE.md)

### บทเพลงแห่งการเยียวยา (HealingSong) · uid 769
- ทรี: สกิลมินสเตรล · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = inherit · IsHitRigidity = inherit — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- HpRecoveryRate (`HpRecoveryRate`) = `guitaristSavingTime`
- MpRecoveryRate (`MpRecoveryRate`) = `ValidSongBuffLvUp`
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `UseArcheTypeId`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `GameManager.PlayerSkillUpdate` (GetSkillLv) — Player Skill Update — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MainPlayer.ConnectUpdate` (GetSkillLv) — Connect Update — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerSecondaryStatus.get_HpRecovery` (TryGetBuf) — Hp Recovery of MobaPlayerSecondaryStatus — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerSecondaryStatus.get_MpRecovery` (TryGetBuf) — Mp Recovery of MobaPlayerSecondaryStatus — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PetStatus.get_HpRecovery` (ContainsBuffer) — Hp Recovery of PetStatus — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PetStatus.get_MpRecovery` (ContainsBuffer) — Mp Recovery of PetStatus — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.CalcHpRecovery` (TryGetBuf) — calculate hp recovery — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.CalcMpRecovery` (TryGetBuf) — calculate mp recovery — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerSecondaryStatus.GetExpBonus` (TryGetBuf) — Get Exp Bonus — Code
- ถูกอ่านโดย SetlistAction (uid 799) ผ่าน `SetlistAction.GetSkillId` (GetSkillLv) — Get Skill Id — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `ShortcutManager.ShortcutChatPanelOpen` (GetSkillLv) — Shortcut Chat Panel Open — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `ShortcutManager.ShortcutChatTargetOpen` (GetSkillLv) — Shortcut Chat Target Open — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `ShortcutManager.ShortcutPanelOpen` (GetSkillLv) — Shortcut Panel Open — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIComboWindow.Initialize` (GetSkillLv) — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIExSkillManager.ExSkillList` (GetSkillLv) — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UISkillTreeManager.SkillTreeList` (GetSkillLv) — Code


---

### บทเพลงแห่งภูตพราย (FairySong) · uid 770
- ทรี: สกิลมินสเตรล · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = inherit · IsHitRigidity = inherit — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - FleeRate (`FleeRate`) = `IsValidBuff` — เมื่อ IsSelfAction = 0
  - FleeRate (`FleeRate`) = `int(0.25 × isBattleActive × IsValidBuff)` — เมื่อ IsSelfAction ≠ 0
  - Flee (`Flee`) = `int(0.25 × isBattleActive × UseArcheTypeId)` — เมื่อ IsSelfAction ≠ 0
  - Flee (`Flee`) = `UseArcheTypeId` — เมื่อ IsSelfAction = 0
- ข้อความในเกม (คำอธิบาย): เพิ่มอัตราความแม่นและอัตราหลบหลีก — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ความแม่น % (`HitRate`) = `ValidSongBuffLvUp` — เมื่อ IsSelfAction = 0
- ความแม่น % (`HitRate`) = `int(0.25 × isBattleActive × ValidSongBuffLvUp)` — เมื่อ IsSelfAction ≠ 0
- ความแม่น + (`HitUp`) = `guitaristSavingTime` — เมื่อ IsSelfAction = 0
- ความแม่น + (`HitUp`) = `int(0.25 × isBattleActive × guitaristSavingTime)` — เมื่อ IsSelfAction ≠ 0

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PetStatus.get_Hit` (ContainsBuffer) — Hit of PetStatus — Code


---

### บทเพลงแห่งชีวิต (SongOfLife) · uid 771
- ทรี: สกิลมินสเตรล · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = inherit · IsHitRigidity = inherit — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (คำอธิบาย): สะสมผลการลดความเสียหายแบบเป็นเปอร์เซ็นต์ — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = `guitaristSavingTime`

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### บทเพลงแห่งมายา (PhantomSong) · uid 772
- ทรี: สกิลมินสเตรล · เลเวลสูงสุด: 60 · อาวุธที่ใช้ได้: ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = inherit · IsHitRigidity = inherit — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `ValidSongBuffLvUp`

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### แอดลิบ (ImprovisationSong) · uid 773
- ทรี: สกิลมินสเตรล · เลเวลสูงสุด: 60 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: บีทบลาสต์ (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - (`MobLastDamageRate*` เข้าสูตรดาเมจที่มอนทำใส่ผู้เล่นใน `MobAttackBase.CalcLastDamage` — ค่านี้คือส่วนลดดาเมจที่ได้รับ; หน่วยและการรวมกับบัพอื่นยังไม่ยืนยัน — Inferred)
  - MobLastDamageRateUnique (`MobLastDamageRateUnique`) = `+0x1e`
- ข้อความในเกม (คำอธิบาย): จะลดความเสียหายขณะใช้แอดลิบ — Text
- ข้อความในเกม (คำอธิบาย): (Lv10 จะเปลี่ยนจากการลดความเสียหายเป็นคงกระพัน) — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: `MobAttackBase.CalcLastDamage` — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล บีทบลาสต์ (uid 776): `ImprovisationSongAction.ActionSkillEventIfMoveIndex` (GetSkillLv) — Action Skill Event If Move Index — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobAttackBase.CalcLastDamage` (TryGetBuf) — calculate last damage — Code


---

### บทเพลงแห่งความเร่าร้อน (EnthusiasticSong) · uid 774
- ทรี: สกิลมินสเตรล · เลเวลสูงสุด: 120 · อาวุธที่ใช้ได้: ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = inherit · IsHitRigidity = inherit — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `int(0.25 × isBattleActive × guitaristSavingTime)` — เมื่อ IsSelfAction ≠ 0
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `guitaristSavingTime` — เมื่อ IsSelfAction = 0

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.CalcElementBonus` (TryGetBuf) — Element advantage multiplier — Code


---

### บทเพลงแห่งภูมิปัญญา (KnowledgeSong) · uid 775
- ทรี: สกิลมินสเตรล · เลเวลสูงสุด: 120 · อาวุธที่ใช้ได้: ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = inherit · IsHitRigidity = inherit — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - (`MobLastDamageRate*` เข้าสูตรดาเมจที่มอนทำใส่ผู้เล่นใน `MobAttackBase.CalcLastDamage` — ค่านี้คือส่วนลดดาเมจที่ได้รับ; หน่วยและการรวมกับบัพอื่นยังไม่ยืนยัน — Inferred)
  - ตัวคูณดาเมจที่ได้รับจากมอน (หมวดซัพพอร์ต) (`MobLastDamageRateSupport`) = `guitaristSavingTime`
- ข้อความในเกม (คำอธิบาย): ลดความเสียหายทุกประเภทและระยะผลักกระเด็น — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `int(0.25 × isBattleActive × ValidSongBuffLvUp)` — เมื่อ IsSelfAction ≠ 0
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `ValidSongBuffLvUp` — เมื่อ IsSelfAction = 0

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `AutoMemberActionManager.CalcAbnormalKnockBackDistance` (TryGetBuf) — calculate abnormal knock back distance — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.CalcAbnormalKnockBackDistance` (TryGetBuf) — calculate abnormal knock back distance — Code


---

### บีทบลาสต์ (BeatBlast) · uid 776
- ทรี: สกิลมินสเตรล · เลเวลสูงสุด: 60 · อาวุธที่ใช้ได้: ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, คาตานะ
- ประเภทดาเมจ: เวท (ใช้ MATK) · Proration: ช่องเวท (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก** — attackCount ≥ 1
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **0** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `15 × Lv + 100 %` → Lv1 115% · Lv5 175% · Lv10 250%

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย แอดลิบ (uid 773) ผ่าน `ImprovisationSongAction.ActionSkillEventIfMoveIndex` (GetSkillLv) — Action Skill Event If Move Index — Code


---

### ซาวนด์เวล (SoundVeil) · uid 777
- ทรี: สกิลมินสเตรล · เลเวลสูงสุด: 120 · อาวุธที่ใช้ได้: ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ข้อความในเกม (คำอธิบาย): และลดความเสียหายทั้งหมดตามจำนวนบัฟเพลง — Text
- ข้อความในเกม (คำอธิบาย): แต่ไม่สามารถลดความเสียหายจากเป้าหมาย — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### แบทเทิลโน้ต (BattleNotes) · uid 778
- ทรี: สกิลมินสเตรล · เลเวลสูงสุด: 120 · อาวุธที่ใช้ได้: ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ค่าเปอร์เซ็นต์ (`Percent`) → Lv1 10 · Lv5 50 · Lv10 100 — Code

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.StartBattleNotesAttack` (GetSkillLv) — Start Battle Notes Attack — Code


---
