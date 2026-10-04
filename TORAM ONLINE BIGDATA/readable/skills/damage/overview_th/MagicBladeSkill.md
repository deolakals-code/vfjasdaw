# สกิลเมจิกเบลด (15 สกิล)

สรุปโดยรวมต่อสกิล: ตัวคูณดาเมจมาจากไหน / แยกอาวุธ / สถานะระหว่างท่า / บัพ / เชื่อมสกิลอื่น. วิธีอ่าน: [ENGINE.md](ENGINE.md)

### เมจิกวอริเออร์มาสเตอรี่ (KnowledgeOfMagicWarriorMastary) · uid 865
- ทรี: สกิลเมจิกเบลด · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: SubMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ความเร็วร่าย % (`CspdRate`) = `System.Math.Max(Lv - 5, 0, 0, ?x3) + Lv` — Code
- พาสซีฟ/มาสเตอรี่: ความเร็วร่าย + (`Cspd`) → Lv1 10 · Lv5 50 · Lv10 100 — Code
- พาสซีฟ/มาสเตอรี่: MATK (`Matk`) = `System.Math.Max(Lv - 5, 0, 0, ?x3) + 2 × Lv` — Code
- พาสซีฟ/มาสเตอรี่: ATK % (`AtkRate`) → Lv1 1 · Lv5 5 · Lv10 10 — Code

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `UIExSkillManager.ExSkillList` (GetSkillLv) — Code


---

### อีเทอร์แฟลร์ (EtherFlare) · uid 866
- ทรี: สกิลเมจิกเบลด · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: SubMagictool
- ประเภทดาเมจ: เวท; กายภาพเมื่อมีบัฟ 867 · Proration: dynamic (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: สถานะ INT(ที่ลงเอง)/STR(ที่ลงเอง)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `2 × fixAddDamage` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `fixAddDamage`: `2 × fixAddDamage` เมื่อ (+เงื่อนไขอื่น)
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `fixAddDamage` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `fixAddDamage`: `2 × fixAddDamage` เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `max(INT(ที่ลงเอง), STR(ที่ลงเอง)) + 250 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- สถานะผิดปกติที่ติดเป้า:
  - ไฟไหม้ โอกาส `percent` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = `attackMpRecovery`

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล คอนเวอร์ชั่น (uid 867): `EtherFlareAction.OnInitialize` (ContainsBuffer) — EtherFlareAction: initial values — Code


---

### คอนเวอร์ชั่น (Conversion) · uid 867
- ทรี: สกิลเมจิกเบลด · เลเวลสูงสุด: 60 · อาวุธที่ใช้ได้: ดาบมือเดียว, ดาบสองมือ, โบว์กัน, สนับมือ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย เอเลเม้นต์สแลช (uid 868) ผ่าน `ElementSlashAction.OnInitialize` (ContainsBuffer) — ElementSlashAction: initial values — Code
- ถูกอ่านโดย เอนชานท์บลาส / เอนชานท์อกรา (uid 872) ผ่าน `EnchantedBurstAction.OnInitialize` (ContainsBuffer) — EnchantedBurstAction: initial values — Code
- ถูกอ่านโดย เอนชานท์ซอร์ด / เอนชานท์บลาสซอร์ด (uid 870) ผ่าน `EnchantedSwordAction.OnInitialize` (ContainsBuffer) — EnchantedSwordAction: initial values — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `EquipItemData.WeaponTypeCalculatorBase.CalcMatk` (GetSkillLv) — calculate matk — Code
- ถูกอ่านโดย อีเทอร์แฟลร์ (uid 866) ผ่าน `EtherFlareAction.OnInitialize` (ContainsBuffer) — EtherFlareAction: initial values — Code
- ถูกอ่านโดย ยูเนียนซอร์ด / รียูเนียนซอร์ด (uid 874) ผ่าน `UnionSwordAction.OnInitialize` (ContainsBuffer) — UnionSwordAction: initial values — Code


---

### เอเลเม้นต์สแลช (ElementSlash) · uid 868
- ทรี: สกิลเมจิกเบลด · เลเวลสูงสุด: 60 · อาวุธที่ใช้ได้: SubMagictool
- ประเภทดาเมจ: เวท; กายภาพเมื่อมีบัฟ 867 · Proration: dynamic (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), สถานะ INT(ที่ลงเอง)/STR(ที่ลงเอง)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `15 × Lv + 50` → Lv1 65 · Lv5 125 · Lv10 200
  - ตัวคูณสกิล (`SkillRate`, AddRate) `50 × Lv + max(STR(ที่ลงเอง), INT(ที่ลงเอง)) / 12.5 × Lv + 100 %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- สถานะผิดปกติที่ติดเป้า:
  - ล่มสลาย โอกาส `10 × Lv` → Lv1 10 · Lv5 50 · Lv10 100

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล คอนเวอร์ชั่น (uid 867): `ElementSlashAction.OnInitialize` (ContainsBuffer) — ElementSlashAction: initial values — Code


---

### เรโซแนนซ์ (Resonance) · uid 869
- ทรี: สกิลเมจิกเบลด · เลเวลสูงสุด: 120 · อาวุธที่ใช้ได้: SubMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ATK + (`AtkUp`) = `atk`
- MATK + (`MatkUp`) = `matk`
- ความแม่น + (`HitUp`) = `hit`
- ความเร็วโจมตี + (`Aspd`) = `aspd`
- ความเร็วร่าย + (`CspdUp`) = `cspd`
- อัตราคริ + (`CrtUp`) = `critical`

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### เอนชานท์ซอร์ด / เอนชานท์บลาสซอร์ด (EnchantedSword) · uid 870
- ทรี: สกิลเมจิกเบลด · เลเวลสูงสุด: 120 · อาวุธที่ใช้ได้: ดาบมือเดียว, ดาบสองมือ, โบว์กัน, สนับมือ
- ประเภทดาเมจ: กายภาพ; เวทเมื่อมีบัฟ 867 (กลับด้านกับ 866) · Proration: dynamic (first_hit_per_target)

**ชื่อ/รูปแบบของสกิล (จากข้อความในเกม):** [N] เอนชานท์ซอร์ด · [N2] เอนชานท์บลาสซอร์ด

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก** — attackCount ≥ 1
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **300** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) `60 × Lv + 400 %` → Lv1 460% · Lv5 700% · Lv10 1000% — เมื่อ (+เงื่อนไขอื่น)
- **ดาเมจ (เมธอดเสริม)**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **300** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `60 × Lv + 400 %` → Lv1 460% · Lv5 700% · Lv10 1000%
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: เอนชานท์บลาส / เอนชานท์อกรา (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- สกิลนี้ใส่บัพของสกิล เอนชานท์บลาส / เอนชานท์อกรา (uid 872) — Code
- ได้รับการเสริมจากสกิล เอเนอร์จี้คอนโทรล (uid 147): `EnchantedSwordAction.ActionPreparation` (ContainsBuffer) — EnchantedSwordAction: preparation — Code
- ได้รับการเสริมจากสกิล คอนเวอร์ชั่น (uid 867): `EnchantedSwordAction.OnInitialize` (ContainsBuffer) — EnchantedSwordAction: initial values — Code
- ได้รับการเสริมจากสกิล เอนชานท์บลาส / เอนชานท์อกรา (uid 872): `EnchantedSwordAction.ActionHit` (GetSkillLv) — Action Hit — Code
- ได้รับการเสริมจากสกิล เอนชานท์บลาส / เอนชานท์อกรา (uid 872): `EnchantedSwordAction.ReceiveAttackResult` (GetSkillLv) — Receive Attack Result — Code
- ได้รับการเสริมจากสกิล ผู้ทำลายล้าง (uid 1159): `EnchantedSwordAction.ActionPreparation` (ContainsBuffer) — EnchantedSwordAction: preparation — Code


---

### เอนชานท์สเปล (EnchantedSpell) · uid 871
- ทรี: สกิลเมจิกเบลด · เลเวลสูงสุด: 180 · อาวุธที่ใช้ได้: SubMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.CheckEnchantedSpellMpLessInvoke` (GetSkillLv) — check enchanted spell mp less invoke — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `ReceiveSupportResult.OnEventPlayerSupport` (GetSkillLv) — On Event Player Support — Code


---

### เอนชานท์บลาส / เอนชานท์อกรา (EnchantedBurst) · uid 872
- ทรี: สกิลเมจิกเบลด · เลเวลสูงสุด: 180 · อาวุธที่ใช้ได้: ดาบสองมือ, SubMagictool
- ประเภทดาเมจ: เวท; กายภาพเมื่อมีบัฟ 867 · Proration: dynamic (first_hit_per_target)

**ชื่อ/รูปแบบของสกิล (จากข้อความในเกม):** [N] เอนชานท์บลาส · [N2] เอนชานท์อกรา

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [ดาบสองมือ + มือรอง อุปกรณ์เวท] [= **100** คงที่ทุก Lv — เมื่อ (+เงื่อนไขอื่น)] หรือ [`((((int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function / 2.5)) lt 300 ? int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemDat…(ย่อ)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`((((int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function / 2.5)) lt 300 ? int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemDat…(ย่อ)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) [ดาบสองมือ + มือรองที่ไม่ใช่ อุปกรณ์เวท] = **100** คงที่ทุก Lv
  - ตัวคูณสกิล (`SkillRate`, AddRate) `50 × Lv + 1000 %` → Lv1 1050% · Lv5 1250% · Lv10 1500%
- สถานะผิดปกติที่ติดเป้า:
  - ล่มสลาย โอกาส = **100** คงที่ทุก Lv

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล เอเนอร์จี้คอนโทรล (uid 147): `EnchantedBurstAction.ActionHit` (ContainsBuffer) — Action Hit — Code
- ได้รับการเสริมจากสกิล เอเนอร์จี้คอนโทรล (uid 147): `EnchantedBurstAction.AddLocalStack` (ContainsBuffer) — Add Local Stack — Code
- ได้รับการเสริมจากสกิล คอนเวอร์ชั่น (uid 867): `EnchantedBurstAction.OnInitialize` (ContainsBuffer) — EnchantedBurstAction: initial values — Code
- ได้รับการเสริมจากสกิล ผู้ทำลายล้าง (uid 1159): `EnchantedBurstAction.ActionHit` (ContainsBuffer) — Action Hit — Code
- ได้รับการเสริมจากสกิล ผู้ทำลายล้าง (uid 1159): `EnchantedBurstAction.AddLocalStack` (ContainsBuffer) — Add Local Stack — Code
- ถูกอ่านโดย เดรนบาเรีย (uid 875) ผ่าน `DrainBarrierAction.DamageFunction` (GetSkillLv) — Damage Function — Code
- ถูกอ่านโดย เอนชานท์ซอร์ด / เอนชานท์บลาสซอร์ด (uid 870) ผ่าน `EnchantedSwordAction.ActionHit` (GetSkillLv) — Action Hit — Code
- ถูกอ่านโดย เอนชานท์ซอร์ด / เอนชานท์บลาสซอร์ด (uid 870) ผ่าน `EnchantedSwordAction.ReceiveAttackResult` (GetSkillLv) — Receive Attack Result — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PhotonListener.OnActionMobAttack` (TryGetBuf) — On Action Mob Attack — Code


---

### ดูอัลบริงเกอร์ (DualBringer) · uid 873
- ทรี: สกิลเมจิกเบลด · เลเวลสูงสุด: 260 · อาวุธที่ใช้ได้: SubMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- MagicCrtDamage (`MagicCrtDamage`) = `criticalDamage` — เมื่อ isIntBonus ≠ 0

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย เวทมนตร์: บลาส / เฮลอินเฟรูโน่ / อีเทอนอลบลิซซาร์ด / ฟอร์สเทมเพสต์ / เทิร์นกราวิตี้ / พันนิชเมนท์ / อีคลิปส์ (uid 109) ผ่าน `MagicBurstAction.ActionHit` (ContainsBuffer) — Action Hit — Code
- ถูกอ่านโดย เวทมนตร์:เมจิกแคนนอน (uid 112) ผ่าน `MagicCannonAction.ActionHit` (ContainsBuffer) — Action Hit — Code
- ถูกอ่านโดย เวทมนตร์:แครช / เมเทโอเรน / เฮล / ฟลูกูไรต์ / ร็อคฟอล / เมเทโอไลท์ / คอสมอส (uid 113) ผ่าน `MagicFallAction.ActionHit` (ContainsBuffer) — Action Hit — Code
- ถูกอ่านโดย เวทมนตร์: ไฟนอล (uid 108) ผ่าน `MagicFinawAction.ActionHit` (ContainsBuffer) — Action Hit — Code


---

### ยูเนียนซอร์ด / รียูเนียนซอร์ด (UnionSword) · uid 874
- ทรี: สกิลเมจิกเบลด · เลเวลสูงสุด: 260 · อาวุธที่ใช้ได้: ดาบสองมือ, SubMagictool
- ประเภทดาเมจ: กายภาพ; เวทเมื่อมีบัฟ 867 (กลับด้านกับ 866) · Proration: dynamic (first_hit_per_target)

**ชื่อ/รูปแบบของสกิล (จากข้อความในเกม):** [N] ยูเนียนซอร์ด · [N2] รียูเนียนซอร์ด

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **500** คงที่ทุก Lv — เมื่อ isReUnionSword ≠ 0
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) = **500** คงที่ทุก Lv — เมื่อ isReUnionSword = 0
  - ตัวคูณสกิล (`SkillRate`, AddRate) `100 × Lv + 2000 %` → Lv1 2100% · Lv5 2500% · Lv10 3000% — เมื่อ isReUnionSword ≠ 0
  - ตัวคูณสกิล (`SkillRate`, AddRate) `50 × Lv + 1000 %` → Lv1 1050% · Lv5 1250% · Lv10 1500% — เมื่อ isReUnionSword = 0

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล คอนเวอร์ชั่น (uid 867): `UnionSwordAction.OnInitialize` (ContainsBuffer) — UnionSwordAction: initial values — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobAttackBase.CalcLastDamage` (TryGetBuf) — calculate last damage — Code


---

### เดรนบาเรีย (DrainBarrier) · uid 875
- ทรี: สกิลเมจิกเบลด · เลเวลสูงสุด: 1 · อาวุธที่ใช้ได้: อุปกรณ์เวท

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: เอนชานท์บลาส / เอนชานท์อกรา (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - ลดดาเมจกายภาพที่ได้รับ (`PowerDmgCut`) = `damageCut`
  - ลดดาเมจเวทที่ได้รับ (`MagicDmgCut`) = `damageCut`
- ข้อความในเกม (คำอธิบาย): ลดความเสียหายทางกายภาพ/เวทมนตร์ — Text
- ข้อความในเกม (คำอธิบาย): เมื่อความเสียหายทางเวทลดลงจะเพิ่มปริมาณการฟื้นฟู — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `mpHeal`

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล เอนชานท์บลาส / เอนชานท์อกรา (uid 872): `DrainBarrierAction.DamageFunction` (GetSkillLv) — Damage Function — Code


---

### เทเลพอร์ต (Teleport) · uid 876
- ทรี: สกิลเมจิกเบลด · เลเวลสูงสุด: 60 · อาวุธที่ใช้ได้: อุปกรณ์เวท

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (คำอธิบาย): เทคนิคการหลบหลีกโดยเปลี่ยนตำแหน่งแบบฉับพลัน — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### เดรนรีคอล (DrainRecall) · uid 877
- ทรี: สกิลเมจิกเบลด · เลเวลสูงสุด: 120 · อาวุธที่ใช้ได้: SubMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ข้อความในเกม (คำอธิบาย): เมื่อลดความเสียหายด้วยเดรนบาเรียสำเร็จ — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `mpHeal`

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### โฟรทแดช (FloatDash) · uid 878
- ทรี: สกิลเมจิกเบลด · เลเวลสูงสุด: 180 · อาวุธที่ใช้ได้: SubMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - หลบ + (`AvoidUp`) = `avoid`
  - Flee (`Flee`) = `flee`

#### 4) บัพที่ได้จากสกิลนี้
- MoveSpeed (`MoveSpeed`) = `moveSpeed`

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.NextSkillReserve` (ContainsBuffer) — Next Skill Reserve — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.TargetMobBattleReserve` (ContainsBuffer) — Target Mob Battle Reserve — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.get_MoveSpeed` (TryGetBuf) — Move Speed of MobaPlayerActionManager — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerBattleManager.OnSkillActionEnd` (ContainsBuffer) — On Skill Action End — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.Update` (ContainsBuffer) — Update — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.get_MoveSpeed` (TryGetBuf) — Move Speed of PlayerActionManager — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerActionManager.targetMobBattleReserve` (ContainsBuffer) — target Mob Battle Reserve — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.CalcCostMp` (ContainsBuffer) — Skill MP cost — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerBattleManager.OnSkillActionEnd` (ContainsBuffer) — On Skill Action End — Code
- ถูกอ่านโดย ชูคุจิ (uid 619) ผ่าน `ShukuchiAction.CanActivated` (ContainsBuffer) — predicate can activated — Code


---

### เมจิกสกิน (MagicSkin) · uid 879
- ทรี: สกิลเมจิกเบลด · เลเวลสูงสุด: 260 · อาวุธที่ใช้ได้: SubMagictool

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ดาเมจสุดท้ายที่ได้รับจากมอน (`MobAttackLastDamageRate`) → Lv1 25 · Lv5 125 · Lv10 250 — Code
- พาสซีฟ/มาสเตอรี่: ค่าเปอร์เซ็นต์ (`Percent`) → Lv1 1 · Lv5 25 · Lv10 100 — Code
- ข้อความในเกม (คำอธิบาย): การลดความเสียหายเช่นเดียวกับค่าถลุงของโล่ — Text
- ข้อความในเกม (คำอธิบาย): ลดความเสียหายทางกายภาพ/เวทมนตร์ได้มากขึ้นเท่านั้น — Text
- ข้อความในเกม (Lv15): ผลการลดความเสียหายจาก MP ที่เหลือ — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `EquipItemData.CalcEqDef` (GetSkillLv) — calculate eq def — Code


---
