# ニンジャスキル (`NinjaSkill`) — skill details

4 entries.

### นินจาสปิริต (ShinobiWay) · uid 1217

<img src="../../icons/sk_1217.png" width="40" alt="icon"> 
**Tree:** ニンジャスキル (`NinjaSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 1 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** นินจูตสึ · **Flags:** NoMarketSearch · **Client class:** `ShinobiWay` (passive mastery)

> เรียนรู้กฎเกณฑ์ของชิโนบิ
> ช่วยเพิ่มหลบหลีกและลดเฮทลงอย่างละเล็กน้อย
> ถ้าสกิลนี้ถึง Lv10 จะใช้ "ทูแฮนด์" ได้
> เม้ว่าจะติดตั้งม้วนคัมภีร์นินจูตสึอยู่ด้วย

**How it works**

- Mastery skill of the ニンジャスキル tree (tier 1, max Lv 1); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Hit (accuracy) 1 at Lv1 to 10 at Lv10, Percent (generic percent) -1 at Lv1 to -10 at Lv10, Flee (dodge) 1 at Lv1 to 10 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Hit | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| Percent | -1 | -2 | -3 | -4 | -5 | -6 | -7 | -8 | -9 | -10 |
| Flee | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


Bonus meanings (inferred from the names):

- `Hit`: accuracy
- `Percent`: generic percent
- `Flee`: dodge

_Raw recovered data (every method item): [trees/NinjaSkill.md](../trees/NinjaSkill.md) — uid 1217_

---

### นินจูตสึ (Ninjutsu) · uid 1218

<img src="../../icons/sk_1218.png" width="40" alt="icon"> 
**Tree:** ニンジャスキル (`NinjaSkill`, tier 1) · **Type:** Special · **Max Lv:** 1 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** NoMarketSearch · **Client class:** `NinjutsuAction`

> วิชาแปลกใหม่จากต่างแดน
> เมื่อใช้งานจะเรียกใช้นินจูตสึแบบแรนดอม
> ถ้าเปิดใช้ม้วนคัมภีร์นินจูตสึ เลเวลจะเท่ากับเลเวลของสกิลนี้
> EX สกิล "สร้างม้วนคัมภีร์นินจูตสึ" จะสามารถใช้งานได้

**How it works**

- Special skill of the ニンジャスキル tree (tier 1, max Lv 1); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a utility / system action (movement, state change) rather than a damage or buff skill.
- Other client code reads this skill (4 lookups; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `((Lv * -0.2) + 2.5)` = 2.3
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1218
- No proration slot: ExpType None: no proration slot.

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `((Lv * -0.2) + 2.5)` = 2.3

**In-game level notes**

- Lv255: [ขว้างคุไน] ขว้างคุไนที่ซ่อนอยู่เพื่อโจมตี จะโจมตีจนกว่ามีการเคลื่อนไหว และจะไม่โดนเมื่ออยู่นอกระยะ เมื่อมีความแม่นจะเกิดความเคยชินทำให้ฟื้นฟู MP ได้เล็กน้อย
- Lv255: [คาถาไฟ] สร้างความเสียหายเวทมนตร์ให้เป้าหมายด้วย MATK มีโอกาสติด[ไหม้ไฟ] ถ้าตรเงื่อนไข พลังจะเปลี่ยนเป็นการโจมตีในวงกว้างด้วยพลังที่เพิ่มขึ้นและ การโจมตีเพิ่มไม่ได้รับอิทธิพลจากคอมโบจากคอมโบจะถูกเปิดใช้งาน
- Lv255: [คาถาน้ำ] สร้างแอ่งน้ำรอบเท้าของตัวเอง ที่ด้านบนแอ่งน้ำสามารถลดความเสียหาย จากพิษและไหม้ไฟ รวมถึงลดผลเสีย ของเชื่องช้า, หยุดนิ่ง, แช่แข็ง ถ้าตรงตามเงื่อนไขจะเปลี่ยนเป็นสกิลความเสียหายทางกายภาพด้วย MATK
- Lv255: [คาถาดิน] เปลี่ยนหินรอบบริเวณเป็นดังโล่ ลดความเสียหายระยะไกล ได้จำนวนหนึ่ง ถ้าจำนวนการป้องกันยังเหลืออยู่ เมื่อระยะเวลา แสดงผลสิ้นสุดลง จะสร้างความเสียหายเวทมนตร์ด้วย MATK
- Lv255: [คาถาลม] โบยบินไปในท้องฟ้าตามสายลม เมื่อถึงที่หมายจะสร้างความเสียหายเวทมนตร์ ด้วย MATK รอบบริเวณ ถ้าเปลี่ยนเป็นคาตานะ จะสร้างความเสียหายด้วย ATK หรือ MATK ที่มีค่าสูงกว่าเมื่อเปิดใช้งานจะได้รับอัตราคริติคอลที่ขึ้นกับ DEX และ ASPD เพิ่มขึ้นเป็นเวลา 20 วินาทีเมื่อเปลี่ยนแปลงพลังดาบบัตโตจะเพิ่มขึ้น
- Lv255: [ชูริเคนปีศาจวายุ] ขว้างชูริเคนขนาดใหญ่ ชูริเคนจะพุ่งตรงไปสร้างความเสียหายในวงแคบ จะกลับมาเมื่อถึงระยะที่กำหนด และสิ้นสุดลงเมื่อชนกำแพง
- Lv255: [คาถาแยกร่าง] เพิ่มจำนวนการโจมตีด้วยร่างแยก ถ้าใช้ร่างแยก จะสามารถเคลื่อนย้ายไปยังตำแหน่งของร่างแยกได้ในพริบตาและฟื้นฟู MP ระหว่างที่ใช้แยกร่าง HP สูงสุดจะลดลง และถ้าอยู่ห่างกันเกินไป จะไม่สามารถควบคุมได้ เมื่อเรียนรู้ชูคุจิแล้ว มีโอกาสที่ร่างแยกจะเร่งความเร็วได้ 1 ครั้ง ถ้าใช้เดคอยชูตเตอร์จะสามารถแทนที่ร่างแยกได้
- Lv255: [คาถาสายฟ้า] เคลื่อนที่ไปยังเป้าหมายอย่างรวดเร็วราวสายฟ้าและ สร้างความเสียหายทางกายภาพด้วย ATK หรือ MATK ที่มีค่าสูงกว่า เมื่อใช้กับคาตานะจะกลายเป็นคริติคอลที่แน่นอน

**Where else this skill takes effect**

- Code that reads this skill's level / buff by constant id: `UIComboWindow$$SetAvailableSkillList (GetSkillLv)`, `UIExSkillManager$$ExSkillList (GetSkillLv)`, `UIShortcutCustomSkill$$SetSkillDataList (GetSkillLv)`, `UISkillTreeManager$$SkillTreeList (GetSkillLv)`

_Raw recovered data (every method item): [trees/NinjaSkill.md](../trees/NinjaSkill.md) — uid 1218_

---

### ศาสตร์แห่งนินจูตสึ I (NinjutsuTraining1) · uid 1227

<img src="../../icons/sk_1227.png" width="40" alt="icon"> 
**Tree:** ニンジャスキル (`NinjaSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 100 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** นินจูตสึ · **Flags:** NoMarketSearch

> อัพเกรดสกิลที่เปิดใช้งานด้วยนินจูตสึ

**How it works**

- Mastery skill of the ニンジャスキル tree (tier 2, max Lv 100); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **consumer-only** — no action class; effect applied in consumer code (see page).
- Its effect is applied by client code: `NinjaSkillBase$$GetNinjutsuTraining` (formulas in the last section).
- Other client code reads this skill (1 lookup; see the last section).

**Where else this skill takes effect**

- Effect applied in `NinjaSkillBase$$GetNinjutsuTraining` (1 guarded path):
  - always
    - returns `(max(SkillLv(1228), 0) + max(SkillLv(1227), 0))`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`
- Code that reads this skill's level / buff by constant id: `NinjaSkillBase$$GetNinjutsuTraining (GetSkillLv)`

_Raw recovered data (every method item): [trees/NinjaSkill.md](../trees/NinjaSkill.md) — uid 1227_

---

### ศาสตร์แห่งนินจูตสึ II (NinjutsuTraining2) · uid 1228

<img src="../../icons/sk_1228.png" width="40" alt="icon"> 
**Tree:** ニンジャスキル (`NinjaSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 200 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ศาสตร์แห่งนินจูตสึ I · **Flags:** NoMarketSearch

> อัพเกรดสกิลที่เปิดใช้งานด้วยนินจูตสึ
> ไม่สำคัญว่าจะเรียนศาสตร์แห่งนินจูตสึ I หรือ II ก่อน
> เพราะค่าการอัพเกรดที่เพิ่มนั้นเท่ากัน

**How it works**

- Mastery skill of the ニンジャスキル tree (tier 3, max Lv 200); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **consumer-only** — no action class; effect applied in consumer code (see page).
- Its effect is applied by client code: `NinjaSkillBase$$GetNinjutsuTraining` (formulas in the last section).
- Other client code reads this skill (1 lookup; see the last section).

**Where else this skill takes effect**

- Effect applied in `NinjaSkillBase$$GetNinjutsuTraining` (1 guarded path):
  - always
    - returns `(max(SkillLv(1228), 0) + max(SkillLv(1227), 0))`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`
- Code that reads this skill's level / buff by constant id: `NinjaSkillBase$$GetNinjutsuTraining (GetSkillLv)`

_Raw recovered data (every method item): [trees/NinjaSkill.md](../trees/NinjaSkill.md) — uid 1228_

---
