# สกิลนักฆ่า (15 สกิล)

สรุปโดยรวมต่อสกิล: ตัวคูณดาเมจมาจากไหน / แยกอาวุธ / สถานะระหว่างท่า / บัพ / เชื่อมสกิลอื่น. วิธีอ่าน: [ENGINE.md](ENGINE.md)

### แอสแซสซินสแทบ / ฟรอนท์สแทบ / ไซด์สแทบ / แบ็คสแทบ (AssassinStub) · uid 993
- ทรี: สกิลนักฆ่า · เลเวลสูงสุด: 15 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

**ชื่อ/รูปแบบของสกิล (จากข้อความในเกม):** [N] แอสแซสซินสแทบ · [F] ฟรอนท์สแทบ · [S] ไซด์สแทบ · [B] แบ็คสแทบ

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), อาวุธหลัก/รองที่ถือ, บัพ/มาสเตอรี่/สกิลอื่น
- **ดาเมจหลัก** — direction = 1
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)`
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (skillRate + (isEquipBonus = 0 ? (SkillMasteryBase.GetMasteryParam(Master…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (skillRate …(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(skillRate + (isEquipBonus = 0 ? (ค่า LastDmgRate ของมาสเตอรี่) : (ค่า LastDmgRate ของมาสเตอรี่) + 100))` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(skillRate)`
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มือเปล่า + มือรอง ม้วนนินจุตสึ/มีด | ดาบมือเดียว + มือรอง ม้วนนินจุตสึ/มีด | ดาบสองมือ + มือรอง ม้วนนินจุตสึ/มีด | ธนู + มือรอง ม้วนนินจุตสึ/มีด | โบว์กัน + มือรอง ม้วนนินจุตสึ/มีด | ไม้เท้า + มือรอง ม้วนนินจุตสึ/มีด | อุปกรณ์เวท + มือรอง ม้วนนินจุตสึ/มีด | สนับมือ + มือรอง ม้วนนินจุตสึ/มีด | ทวน + มือรอง ม้วนนินจุตสึ/มีด | คาตานะ + มือรอง ม้วนนินจุตสึ/มีด] [`int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (3 × Lv + ค่า LastDmgRate ของมาสเตอรี่ + 305)) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (3 × Lv + โบนัสคริสตัล#1004[4] + AssassinationSecrets.GetAssassinStubSkil…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (3 × Lv + โบนัสคริสตัล#1004[4] + SkillMasteryBase.GetMasteryParam(Mastery…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (Lv + ค่า LastDmgRate ของมาสเตอรี่ + 250)) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (Lv + โบนัสคริสตัล#1004[4] + AssassinationSecrets.GetAssassinStubSkillRat…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (Lv + โบนัสคริสตัล#1004[4] + SkillMasteryBase.GetMasteryParam(MasteryId.L…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)`
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (skillRate + (isEquipBonus = 0 ? (SkillMasteryBase.GetMasteryParam(Master…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (skillRate …(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(skillRate + (isEquipBonus = 0 ? (ค่า LastDmgRate ของมาสเตอรี่) : (ค่า LastDmgRate ของมาสเตอรี่) + 100))` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(skillRate)`
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มือเปล่า + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ดาบมือเดียว + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ดาบสองมือ + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ธนู + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | โบว์กัน + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ไม้เท้า + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | อุปกรณ์เวท + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | สนับมือ + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ทวน + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | คาตานะ + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ] [`int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × ((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + (isEquipBonus = 0 ? (SkillMast…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × ((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + โบนัสคริสตัล#1004[4] + Assassi…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × ((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + โบนัสคริสตัล#1004[4] + (isEqui…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (Lv + (isEquipBonus = 0 ? 0 : 50) + (isEquipBonus = 0 ? (SkillMasteryBase…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (Lv + (isEquipBonus = 0 ? 0 : 50) + โบนัสคริสตัล#1004[4] + AssassinationS…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (Lv + (isEquipBonus = 0 ? 0 : 50) + โบนัสคริสตัล#1004[4] + (isEquipBonus …(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)`
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (skillRate + (isEquipBonus = 0 ? (SkillMasteryBase.GetMasteryParam(Master…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (skillRate …(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(skillRate + (isEquipBonus = 0 ? (ค่า LastDmgRate ของมาสเตอรี่) : (ค่า LastDmgRate ของมาสเตอรี่) + 100))` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(skillRate)`
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มือเปล่า + มือรอง ม้วนนินจุตสึ/มีด | ดาบมือเดียว + มือรอง ม้วนนินจุตสึ/มีด | ดาบสองมือ + มือรอง ม้วนนินจุตสึ/มีด | ธนู + มือรอง ม้วนนินจุตสึ/มีด | โบว์กัน + มือรอง ม้วนนินจุตสึ/มีด | ไม้เท้า + มือรอง ม้วนนินจุตสึ/มีด | อุปกรณ์เวท + มือรอง ม้วนนินจุตสึ/มีด | สนับมือ + มือรอง ม้วนนินจุตสึ/มีด | ทวน + มือรอง ม้วนนินจุตสึ/มีด | คาตานะ + มือรอง ม้วนนินจุตสึ/มีด] [`int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (3 × Lv + S…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (3 × Lv + โ…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (3 × Lv + โ…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (Lv + Skill…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (Lv + โบนัส…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (Lv + โบนัส…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)`
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (skillRate + (isEquipBonus = 0 ? (SkillMasteryBase.GetMasteryParam(Master…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (skillRate …(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(skillRate + (isEquipBonus = 0 ? (ค่า LastDmgRate ของมาสเตอรี่) : (ค่า LastDmgRate ของมาสเตอรี่) + 100))` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(skillRate)`
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มือเปล่า + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ดาบมือเดียว + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ดาบสองมือ + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ธนู + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | โบว์กัน + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ไม้เท้า + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | อุปกรณ์เวท + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | สนับมือ + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ทวน + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | คาตานะ + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ] [`int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × ((isEquipBo…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × ((isEquipBo…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × ((isEquipBo…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (Lv + (isEq…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (Lv + (isEq…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (Lv + (isEq…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)`
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (skillRate + (isEquipBonus = 0 ? (SkillMasteryBase.GetMasteryParam(Master…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (skillRate …(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(skillRate + (isEquipBonus = 0 ? (ค่า LastDmgRate ของมาสเตอรี่) : (ค่า LastDmgRate ของมาสเตอรี่) + 100))` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(skillRate)`
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มือเปล่า + มือรอง ม้วนนินจุตสึ/มีด | ดาบมือเดียว + มือรอง ม้วนนินจุตสึ/มีด | ดาบสองมือ + มือรอง ม้วนนินจุตสึ/มีด | ธนู + มือรอง ม้วนนินจุตสึ/มีด | โบว์กัน + มือรอง ม้วนนินจุตสึ/มีด | ไม้เท้า + มือรอง ม้วนนินจุตสึ/มีด | อุปกรณ์เวท + มือรอง ม้วนนินจุตสึ/มีด | สนับมือ + มือรอง ม้วนนินจุตสึ/มีด | ทวน + มือรอง ม้วนนินจุตสึ/มีด | คาตานะ + มือรอง ม้วนนินจุตสึ/มีด] [`int(3 × Lv + ค่า LastDmgRate ของมาสเตอรี่ + 305) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(3 × Lv + โบนัสคริสตัล#1004[4] + AssassinationSecrets.GetAssassinStubSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.AssassinationSec…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(3 × Lv + โบนัสคริสตัล#1004[4] + ค่า LastDmgRate ของมาสเตอรี่ + 305) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(Lv + ค่า LastDmgRate ของมาสเตอรี่ + 250) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(Lv + โบนัสคริสตัล#1004[4] + AssassinationSecrets.GetAssassinStubSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.AssassinationSecrets…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(Lv + โบนัสคริสตัล#1004[4] + ค่า LastDmgRate ของมาสเตอรี่ + 250) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)`
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (skillRate + (isEquipBonus = 0 ? (SkillMasteryBase.GetMasteryParam(Master…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (skillRate …(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(skillRate + (isEquipBonus = 0 ? (ค่า LastDmgRate ของมาสเตอรี่) : (ค่า LastDmgRate ของมาสเตอรี่) + 100))` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(skillRate)`
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มือเปล่า + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ดาบมือเดียว + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ดาบสองมือ + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ธนู + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | โบว์กัน + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ไม้เท้า + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | อุปกรณ์เวท + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | สนับมือ + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ทวน + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | คาตานะ + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ] [`int((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + (isEquipBonus = 0 ? (ค่า LastDmgRate ของมาสเตอรี่) : (SkillMasteryBase.GetMasteryParam(Mastery…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + โบนัสคริสตัล#1004[4] + AssassinationSecrets.GetAssassinStubSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillMa…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + โบนัสคริสตัล#1004[4] + (isEquipBonus = 0 ? (ค่า LastDmgRate ของมาสเตอรี่) : (SkillMasteryBase.…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(Lv + (isEquipBonus = 0 ? 0 : 50) + (isEquipBonus = 0 ? (ค่า LastDmgRate ของมาสเตอรี่) : (SkillMasteryBase.GetMasteryParam(MasteryId.Last…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(Lv + (isEquipBonus = 0 ? 0 : 50) + โบนัสคริสตัล#1004[4] + AssassinationSecrets.GetAssassinStubSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager()…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(Lv + (isEquipBonus = 0 ? 0 : 50) + โบนัสคริสตัล#1004[4] + (isEquipBonus = 0 ? (ค่า LastDmgRate ของมาสเตอรี่) : (SkillMasteryBase.GetMast…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)`
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (skillRate + (isEquipBonus = 0 ? (SkillMasteryBase.GetMasteryParam(Master…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (skillRate …(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(skillRate + (isEquipBonus = 0 ? (ค่า LastDmgRate ของมาสเตอรี่) : (ค่า LastDmgRate ของมาสเตอรี่) + 100))` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(skillRate)`
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `30 × Lv` → Lv1 30 · Lv5 150 · Lv10 300
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)`
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (skillRate + (isEquipBonus = 0 ? (SkillMasteryBase.GetMasteryParam(Master…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (skillRate …(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(skillRate + (isEquipBonus = 0 ? (ค่า LastDmgRate ของมาสเตอรี่) : (ค่า LastDmgRate ของมาสเตอรี่) + 100))` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(skillRate)`
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มือเปล่า + มือรอง ม้วนนินจุตสึ/มีด | ดาบมือเดียว + มือรอง ม้วนนินจุตสึ/มีด | ดาบสองมือ + มือรอง ม้วนนินจุตสึ/มีด | ธนู + มือรอง ม้วนนินจุตสึ/มีด | โบว์กัน + มือรอง ม้วนนินจุตสึ/มีด | ไม้เท้า + มือรอง ม้วนนินจุตสึ/มีด | อุปกรณ์เวท + มือรอง ม้วนนินจุตสึ/มีด | สนับมือ + มือรอง ม้วนนินจุตสึ/มีด | ทวน + มือรอง ม้วนนินจุตสึ/มีด | คาตานะ + มือรอง ม้วนนินจุตสึ/มีด] [`int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (3 × Lv + 205)) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (3 × Lv + โบนัสคริสตัล#1004[4] + AssassinationSecrets.GetAssassinStubSkil…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (3 × Lv + โบนัสคริสตัล#1004[4] + 205)) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (Lv + 150)) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (Lv + โบนัสคริสตัล#1004[4] + AssassinationSecrets.GetAssassinStubSkillRat…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (Lv + โบนัสคริสตัล#1004[4] + 150)) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)`
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (skillRate + (isEquipBonus = 0 ? (SkillMasteryBase.GetMasteryParam(Master…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (skillRate …(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(skillRate + (isEquipBonus = 0 ? (ค่า LastDmgRate ของมาสเตอรี่) : (ค่า LastDmgRate ของมาสเตอรี่) + 100))` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(skillRate)`
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มือเปล่า + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ดาบมือเดียว + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ดาบสองมือ + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ธนู + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | โบว์กัน + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ไม้เท้า + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | อุปกรณ์เวท + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | สนับมือ + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ทวน + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | คาตานะ + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ] [`int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × ((isEquipBonus = 0 ? 105 : 205) + 3 × Lv)) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × ((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + โบนัสคริสตัล#1004[4] + Assassi…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × ((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + โบนัสคริสตัล#1004[4])) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (Lv + (isEquipBonus = 0 ? 0 : 50) + 100)) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (Lv + (isEquipBonus = 0 ? 0 : 50) + โบนัสคริสตัล#1004[4] + AssassinationS…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (Lv + (isEquipBonus = 0 ? 0 : 50) + โบนัสคริสตัล#1004[4] + 100)) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)`
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (skillRate + (isEquipBonus = 0 ? (SkillMasteryBase.GetMasteryParam(Master…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (skillRate …(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(skillRate + (isEquipBonus = 0 ? (ค่า LastDmgRate ของมาสเตอรี่) : (ค่า LastDmgRate ของมาสเตอรี่) + 100))` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(skillRate)`
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มือเปล่า + มือรอง ม้วนนินจุตสึ/มีด | ดาบมือเดียว + มือรอง ม้วนนินจุตสึ/มีด | ดาบสองมือ + มือรอง ม้วนนินจุตสึ/มีด | ธนู + มือรอง ม้วนนินจุตสึ/มีด | โบว์กัน + มือรอง ม้วนนินจุตสึ/มีด | ไม้เท้า + มือรอง ม้วนนินจุตสึ/มีด | อุปกรณ์เวท + มือรอง ม้วนนินจุตสึ/มีด | สนับมือ + มือรอง ม้วนนินจุตสึ/มีด | ทวน + มือรอง ม้วนนินจุตสึ/มีด | คาตานะ + มือรอง ม้วนนินจุตสึ/มีด] [`int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (3 × Lv + 2…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (3 × Lv + โ…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (3 × Lv + โ…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (Lv + 150)) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (Lv + โบนัส…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (Lv + โบนัส…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)`
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (skillRate + (isEquipBonus = 0 ? (SkillMasteryBase.GetMasteryParam(Master…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (skillRate …(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(skillRate + (isEquipBonus = 0 ? (ค่า LastDmgRate ของมาสเตอรี่) : (ค่า LastDmgRate ของมาสเตอรี่) + 100))` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(skillRate)`
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มือเปล่า + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ดาบมือเดียว + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ดาบสองมือ + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ธนู + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | โบว์กัน + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ไม้เท้า + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | อุปกรณ์เวท + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | สนับมือ + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ทวน + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | คาตานะ + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ] [`int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × ((isEquipBo…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × ((isEquipBo…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × ((isEquipBo…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (Lv + (isEq…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (Lv + (isEq…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (Lv + (isEq…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)`
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (skillRate + (isEquipBonus = 0 ? (SkillMasteryBase.GetMasteryParam(Master…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (skillRate …(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(skillRate + (isEquipBonus = 0 ? (ค่า LastDmgRate ของมาสเตอรี่) : (ค่า LastDmgRate ของมาสเตอรี่) + 100))` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(skillRate)`
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มือเปล่า + มือรอง ม้วนนินจุตสึ/มีด | ดาบมือเดียว + มือรอง ม้วนนินจุตสึ/มีด | ดาบสองมือ + มือรอง ม้วนนินจุตสึ/มีด | ธนู + มือรอง ม้วนนินจุตสึ/มีด | โบว์กัน + มือรอง ม้วนนินจุตสึ/มีด | ไม้เท้า + มือรอง ม้วนนินจุตสึ/มีด | อุปกรณ์เวท + มือรอง ม้วนนินจุตสึ/มีด | สนับมือ + มือรอง ม้วนนินจุตสึ/มีด | ทวน + มือรอง ม้วนนินจุตสึ/มีด | คาตานะ + มือรอง ม้วนนินจุตสึ/มีด] [`int(3 × Lv + 205) %` → Lv1 208% · Lv5 220% · Lv10 235% — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(3 × Lv + โบนัสคริสตัล#1004[4] + AssassinationSecrets.GetAssassinStubSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.AssassinationSec…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(3 × Lv + โบนัสคริสตัล#1004[4] + 205) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(Lv + 150) %` → Lv1 151% · Lv5 155% · Lv10 160% — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(Lv + โบนัสคริสตัล#1004[4] + AssassinationSecrets.GetAssassinStubSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.AssassinationSecrets…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(Lv + โบนัสคริสตัล#1004[4] + 150) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)`
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (skillRate + (isEquipBonus = 0 ? (SkillMasteryBase.GetMasteryParam(Master…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (skillRate …(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(skillRate + (isEquipBonus = 0 ? (ค่า LastDmgRate ของมาสเตอรี่) : (ค่า LastDmgRate ของมาสเตอรี่) + 100))` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(skillRate)`
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มือเปล่า + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ดาบมือเดียว + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ดาบสองมือ + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ธนู + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | โบว์กัน + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ไม้เท้า + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | อุปกรณ์เวท + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | สนับมือ + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | ทวน + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ | คาตานะ + มือรอง มือเปล่า/ไม่ถือ/อื่นๆ] [`int((isEquipBonus = 0 ? 105 : 205) + 3 × Lv) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + โบนัสคริสตัล#1004[4] + AssassinationSecrets.GetAssassinStubSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillMa…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int((isEquipBonus = 0 ? 105 : 205) + 3 × Lv + โบนัสคริสตัล#1004[4]) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(Lv + (isEquipBonus = 0 ? 0 : 50) + 100) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(Lv + (isEquipBonus = 0 ? 0 : 50) + โบนัสคริสตัล#1004[4] + AssassinationSecrets.GetAssassinStubSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager()…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`int(Lv + (isEquipBonus = 0 ? 0 : 50) + โบนัสคริสตัล#1004[4] + 100) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 2) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 0.01 × SkillMa…(ย่อ)`
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × (skillRate + (isEquipBonus = 0 ? (SkillMasteryBase.GetMasteryParam(Master…(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × BackstepBuf.GetParam(50) + 1) = 0 ? 1 : (0.01 × BackstepBuf.GetParam(50) + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × (skillRate …(ย่อ)` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(((0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1) = 0 ? 1 : (0.01 × ค่า LastDmgRate ของมาสเตอรี่ + 1)) × skillRate)`
    - ตัวปรับ `skillRate`: `int(skillRate + (isEquipBonus = 0 ? (ค่า LastDmgRate ของมาสเตอรี่) : (ค่า LastDmgRate ของมาสเตอรี่) + 100))` เมื่อ direction = 1
    - ตัวปรับ `skillRate`: `int(skillRate)`
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: เคล็ดลับลอบสังหาร (Skill)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ความแม่น % (`HitRate`) = `hitUp`

#### 5) เชื่อมกับสกิลอื่น
- สกิลนี้ใส่บัพของสกิล ซิคาเรียส (uid 999) — Code
- ได้รับการเสริมจากสกิล เคล็ดลับลอบสังหาร (uid 1005): `AssassinStubAction.ActionPreparation` (GetSkillLv) — AssassinStubAction: preparation — Code


---

### อีเวชัน (Evolution) · uid 994
- ทรี: สกิลนักฆ่า · เลเวลสูงสุด: 15 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - Flee (`Flee`) = `flee`
  - FleeRate (`FleeRate`) = `fleeRate`
- ข้อความในเกม (คำอธิบาย): สกิลเพิ่มความสามารถในการหลบหลีก — Text
- ข้อความในเกม (คำอธิบาย): เพิ่มอัตราการหลบหลีกชั่วขณะ — Text
- ข้อความในเกม (Lv18): หลบหลีก +10 — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### แบ็คสเต็ป (Backstep) · uid 995
- ทรี: สกิลนักฆ่า · เลเวลสูงสุด: 35 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (คำอธิบาย): สกิลหลบหลีกอย่างว่องไว — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `attackRate`

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### เซียรัม (Sierram) · uid 996
- ทรี: สกิลนักฆ่า · เลเวลสูงสุด: 35 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (คำอธิบาย): จะลดความเสียหายที่มีอย่างต่อเนื่องของพิษและไหม้ไฟชั่วระยะเวลาหนึ่ง — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `reducePoisonDamage`
- ค่าทั่วไปตัวที่ 2 (`Value2`) = `reduceIgnitionDamage`

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ฟูเนวินเด (FuneVinte) · uid 997
- ทรี: สกิลนักฆ่า · เลเวลสูงสุด: 125 · อาวุธที่ใช้ได้: มีด, NinjutsuScroll
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv)
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `50 × Lv + 500` → Lv1 550 · Lv5 750 · Lv10 1000
  - ตัวคูณสกิล (`SkillRate`, AddRate) [`10 × Lv + PlayerAttackBase.get_Mp() ÷ 100 × (int(AssassinationSecrets.GetFuneVinteMpSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.Assa…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)] หรือ [`10 × Lv + PlayerAttackBase.get_Mp() ÷ 100 × (4 × Lv + 60) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)]
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: เคล็ดลับลอบสังหาร (Skill), เดธรีเซฟชัน (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- MP ฟื้นต่อการโจมตี (`AttackMprecoveryUp`) = `atkMpRecovery`

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล เดธรีเซฟชัน (uid 1004): `FuneVinteAction.ActionPreparation` (GetSkillLv) — FuneVinteAction: preparation — Code
- ได้รับการเสริมจากสกิล เคล็ดลับลอบสังหาร (uid 1005): `FuneVinteAction.ActionPreparation` (GetSkillLv) — FuneVinteAction: preparation — Code
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `PlayerAttackBase.RemoveAfterSkillBuf` (ContainsBuffer) — Remove After Skill Buf — Code


---

### ละทิ้ง (Abandonment) · uid 998
- ทรี: สกิลนักฆ่า · เลเวลสูงสุด: 125 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- พาสซีฟ/มาสเตอรี่: ดาเมจสุดท้าย % (`LastDmgRate`) → Lv1 5 · Lv5 25 · Lv10 50 — Code
- พาสซีฟ/มาสเตอรี่: ความแม่น (`Hit`) → Lv1 1 · Lv5 5 · Lv10 10 — Code
- ข้อความในเกม (คำอธิบาย): เพิ่มความสามารถในการหลบหลีกของตัวเองจนเกินขีดจำกัด — Text
- ข้อความในเกม (คำอธิบาย): ทำให้หลบหลีกได้ดีกว่าเดิม — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ซิคาเรียส (Seekerius) · uid 999
- ทรี: สกิลนักฆ่า · เลเวลสูงสุด: 205 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- บัพป้องกันระหว่างบัพทำงาน — Code:
  - (`MobLastDamageRate*` เข้าสูตรดาเมจที่มอนทำใส่ผู้เล่นใน `MobAttackBase.CalcLastDamage` — ค่านี้คือส่วนลดดาเมจที่ได้รับ; หน่วยและการรวมกับบัพอื่นยังไม่ยืนยัน — Inferred)
  - ตัวคูณดาเมจที่ได้รับจากมอน (หมวดบัพ) (`MobLastDamageRateBuf`) = `damageCut`
- พาสซีฟ/มาสเตอรี่: ดาเมจสุดท้าย % (`LastDmgRate`) → Lv1 15 · Lv5 75 · Lv10 150 — Code

#### 4) บัพที่ได้จากสกิลนี้
- ATK + (`AtkUp`) = `atkUp`
- เจาะกายภาพ (`PowerResistBreaker`) = `powerResistBreaker`
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `int(100 × stubRate)`

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### ชาโดว์วอล์ค (ShadowWalk) · uid 1000
- ทรี: สกิลนักฆ่า · เลเวลสูงสุด: 205 · อาวุธที่ใช้ได้: มีด, NinjutsuScroll

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `MobaPlayerActionManager.ReceiveDamaged` (TryGetBuf) — Receive Damaged — Code


---

### เวนอมอินเจค (VenomInject) · uid 1001
- ทรี: สกิลนักฆ่า · เลเวลสูงสุด: 15 · อาวุธที่ใช้ได้: มีด, NinjutsuScroll, MainHand

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ค่าเปอร์เซ็นต์ทั่วไป (`Percent`) = `percent`
- ค่าเปอร์เซ็นต์ทั่วไป (`Percent`) = `CountBufferBase.GetParam(this, id)` — เมื่อ BuffEffectActive = 0
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย ระบบ/เอนจิน ผ่าน `NormalAttackAction.PossibilityAbnormalState` (ContainsBuffer) — Possibility Abnormal State — Code


---

### พิษกัดกร่อน (CorrosivePoison) · uid 1002
- ทรี: สกิลนักฆ่า · เลเวลสูงสุด: 35 · อาวุธที่ใช้ได้: มีด, NinjutsuScroll, MainHand

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### เวนอมสแนทช (VenomSnatch) · uid 1003
- ทรี: สกิลนักฆ่า · เลเวลสูงสุด: 125 · อาวุธที่ใช้ได้: มีด, NinjutsuScroll, MainHand

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: เดธรีเซฟชัน (Skill)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `poisonLevel`
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `CountBufferBase.GetParam(this, id)` — เมื่อ BuffEffectActive = 0
- ตัวนับ/stack (`Count`) = **1** คงที่ทุก Lv

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล เดธรีเซฟชัน (uid 1004): `VenomSnatchAction.BattleResult` (GetSkillLv) — Battle Result — Code
- ถูกอ่านโดย เดธรีเซฟชัน (uid 1004) ผ่าน `DeathReceptionAction.IsFailure` (ContainsBuffer) — predicate is failure — Code


---

### เดธรีเซฟชัน (DeathReception) · uid 1004
- ทรี: สกิลนักฆ่า · เลเวลสูงสุด: 205 · อาวุธที่ใช้ได้: มีด, NinjutsuScroll, MainHand
- ประเภทดาเมจ: กายภาพ (ใช้ ATK) · Proration: ช่องสกิลกายภาพ (first_hit_per_target)

#### 1) ตัวคูณดาเมจมาจากไหน
- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code
- ตัวคูณสกิลขึ้นกับ: เลเวลสกิล (Lv), อาวุธหลัก/รองที่ถือ
- **ดาเมจหลัก**
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `30 × Lv` → Lv1 30 · Lv5 150 · Lv10 300 — เมื่อ (+เงื่อนไขอื่น)
  - ดาเมจคงที่ของสกิล (`SkillConstantDamage`, AddConstant) `rangeConstantDamage` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มีด + มือรอง ม้วนนินจุตสึ] `((Lv * 25) + 250) + (int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function * 0.8)) lt 500 ? int((EquipItemData.get_SubWeapon(PlayerStatusBase…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `singleSkillRate`: `singleSkillRate + PoisonMixer.GetDeathReceptionSingleAttackSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.PoisonMixer, 1), PlayerAction…(ย่อ)` เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มีด + มือรองที่ไม่ใช่ ม้วนนินจุตสึ/มีด] `25 × Lv + 250 %` → Lv1 275% · Lv5 375% · Lv10 500% — เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `singleSkillRate`: `singleSkillRate + PoisonMixer.GetDeathReceptionSingleAttackSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.PoisonMixer, 1), PlayerAction…(ย่อ)` เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มีด + มือรอง มีด] `((Lv * 25) + 250) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `singleSkillRate`: `singleSkillRate + PoisonMixer.GetDeathReceptionSingleAttackSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.PoisonMixer, 1), PlayerAction…(ย่อ)` เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มีด + มือรอง ม้วนนินจุตสึ] `(((Lv * 25) + 250) + (int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function * 0.8)) lt 500 ? int((EquipItemData.get_SubWeapon(PlayerStatusBas…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `rangeSkillRate`: `rangeSkillRate + PoisonMixer.GetDeathReceptionRangeAttackSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.PoisonMixer, 1), PlayerActionMa…(ย่อ)` เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มีด + มือรองที่ไม่ใช่ ม้วนนินจุตสึ/มีด] `12.5 × Lv + 125 %` → Lv1 137.5% · Lv5 187.5% · Lv10 250% — เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `rangeSkillRate`: `rangeSkillRate + PoisonMixer.GetDeathReceptionRangeAttackSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.PoisonMixer, 1), PlayerActionMa…(ย่อ)` เมื่อ (+เงื่อนไขอื่น)
  - ตัวคูณสกิล (`SkillRate`, AddRate) [มีด + มือรอง มีด] `(((Lv * 25) + 250) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemDat…(ย่อ) %` (ขึ้นกับค่าสถานะ/สถานการณ์จริง) — เมื่อ (+เงื่อนไขอื่น)
    - ตัวปรับ `rangeSkillRate`: `rangeSkillRate + PoisonMixer.GetDeathReceptionRangeAttackSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), SkillId.PoisonMixer, 1), PlayerActionMa…(ย่อ)` เมื่อ (+เงื่อนไขอื่น)
- สถานะผิดปกติที่ติดเป้า:
  - พิษ โอกาส = **100** คงที่ทุก Lv
  - พิษ โอกาส `VenomInjectAction.CalcPercent(PlayerActionManagerBase.get_PlayerStatus(), SkillCalcTemplate.CheckStepResult((PlayerAttackBase.HitReactionAssign(this, new, SkillCalcTem…(ย่อ)` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)
- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: นักปรุงยาพิษ (Skill)

#### 2) แยกตามอาวุธ
ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ใช่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)

#### 5) เชื่อมกับสกิลอื่น
- ได้รับการเสริมจากสกิล เวนอมสแนทช (uid 1003): `DeathReceptionAction.IsFailure` (ContainsBuffer) — predicate is failure — Code
- ได้รับการเสริมจากสกิล นักปรุงยาพิษ (uid 1007): `DeathReceptionAction.ActionPreparation` (GetSkillLv) — DeathReceptionAction: preparation — Code
- ถูกอ่านโดย ฟูเนวินเด (uid 997) ผ่าน `FuneVinteAction.ActionPreparation` (GetSkillLv) — FuneVinteAction: preparation — Code
- ถูกอ่านโดย เวนอมสแนทช (uid 1003) ผ่าน `VenomSnatchAction.BattleResult` (GetSkillLv) — Battle Result — Code


---

### เคล็ดลับลอบสังหาร (AssassinationSecrets) · uid 1005
- ทรี: สกิลนักฆ่า · เลเวลสูงสุด: 285 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย แอสแซสซินสแทบ / ฟรอนท์สแทบ / ไซด์สแทบ / แบ็คสแทบ (uid 993) ผ่าน `AssassinStubAction.ActionPreparation` (GetSkillLv) — AssassinStubAction: preparation — Code
- ถูกอ่านโดย ฟูเนวินเด (uid 997) ผ่าน `FuneVinteAction.ActionPreparation` (GetSkillLv) — FuneVinteAction: preparation — Code


---

### แอสเซาท์เชส (AssaultChase) · uid 1006
- ทรี: สกิลนักฆ่า · เลเวลสูงสุด: 285 · อาวุธที่ใช้ได้: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ธงของท่า: IsInterruptable = ไม่ · IsHitRigidity = ไม่ — Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)
- ข้อความในเกม (Lv255): เมื่อหลบหลีกด้วย Avoid ได้สำเร็จในขณะที่ — Text
- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README) — Inferred

#### 4) บัพที่ได้จากสกิลนี้
- ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน) (`Value`) = `avoidConsumptionReductionValue`
- ดาเมจระยะใกล้ % (`ShortRangeRate`) = `shortRangeRate`

#### 5) เชื่อมกับสกิลอื่น
- ไม่พบ


---

### นักปรุงยาพิษ (PoisonMixer) · uid 1007
- ทรี: สกิลนักฆ่า · เลเวลสูงสุด: 285 · อาวุธที่ใช้ได้: มีด, NinjutsuScroll, MainHand

#### 1) ตัวคูณดาเมจมาจากไหน
- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)

#### 3) ระหว่างใช้สกิล
- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้

#### 5) เชื่อมกับสกิลอื่น
- ถูกอ่านโดย เดธรีเซฟชัน (uid 1004) ผ่าน `DeathReceptionAction.ActionPreparation` (GetSkillLv) — DeathReceptionAction: preparation — Code


---
