# GuardSkill (`GuardSkill`)

7 entries. See ../README.md for how to read these blocks.

### เฮวี่อาร์เมอร์มาสเตอรี่ (HeavyArmorMastary) · uid 161

<img src="../../icons/sk_161.png" width="40" alt="icon"> 
**Type:** Mastery · **Max Lv:** 30 · **Weapons:** HevyArmor · **Flags:** StarGem · **Client class:** `HeavyArmorMastary` (passive mastery)

> เพิ่มการฟื้นฟู Guard ของเกราะหนักที่ปรับแต่งแล้วเมื่อสวมใส่

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Guard | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


---

### ไลท์อาร์เมอร์มาสเตอรี่ (LightArmorMastary) · uid 162

<img src="../../icons/sk_162.png" width="40" alt="icon"> 
**Type:** Mastery · **Max Lv:** 30 · **Weapons:** LightArmor · **Flags:** StarGem · **Client class:** `LightArmorMastary` (passive mastery)

> เพิ่มการฟื้นฟู  Avoid ของเกราะเบาที่ปรับแต่งแล้วเมื่อสวมใส่

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Avoid | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


---

### แอดวานซ์การ์ด (AdvanceGuard) · uid 163

<img src="../../icons/sk_163.png" width="40" alt="icon"> 
**Type:** Mastery · **Max Lv:** 120 · **Weapons:** HevyArmor · **Requires:** เฮวี่อาร์เมอร์มาสเตอรี่ · **Client class:** `AdvanceGuard` (passive mastery)

> เพิ่ม(การลดความเสียหาย)ด้วยพลัง Guard
> และเพิ่มการฟื้นฟู Guard ของเกราะหนักที่ปรับแต่งแล้ว
> เล็กน้อยเมื่อสวมใส่

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Guard | 0 | 1 | 1 | 2 | 2 | 3 | 3 | 4 | 4 | 5 |
| GuardPower | 1 | 1 | 2 | 2 | 3 | 3 | 4 | 4 | 5 | 5 |


---

### แอดวานซ์อีวาชั่น (AdvanceFlee) · uid 164

<img src="../../icons/sk_164.png" width="40" alt="icon"> 
**Type:** Mastery · **Max Lv:** 120 · **Weapons:** LightArmor · **Requires:** ไลท์อาร์เมอร์มาสเตอรี่ · **Client class:** `AdvanceFlee` (passive mastery)

> เพิ่มการฟื้นฟู  Avoid ของเกราะเบาที่ปรับแต่งแล้วเมื่อสวมใส่
> 
> จำนวนที่ลดลงต่อเลเวลเท่ากับผลของ
> ไลท์อาร์เมอร์มาสเตอรี่.

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Avoid | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


---

### ฟิซิคัลการ์ด (PhysicalGuard) · uid 165

<img src="../../icons/sk_165.png" width="40" alt="icon"> 
**Type:** Mastery · **Max Lv:** 180 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เฮวี่อาร์เมอร์มาสเตอรี่ · **Client class:** `PhysicalGuard` (passive mastery)

> เพิ่มความต้านทานความผิดปกติจาก Guard เมื่อ HP เหลือน้อย
> 
> ถ้าสกิลเลเวลเพิ่มขึ้นจะใช้งานได้กับ
> จำนวน HP ที่เหลือเพิ่มมากขึ้น

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Trigger | 14 | 18 | 22 | 26 | 30 | 34 | 38 | 42 | 46 | 50 |


---

### มิราจอีวาชั่น (MirageStep) · uid 166

<img src="../../icons/sk_166.png" width="40" alt="icon"> 
**Type:** Mastery · **Max Lv:** 180 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ไลท์อาร์เมอร์มาสเตอรี่ · **Client class:** `MirageStep` (passive mastery)

> ใช้ Avoid ได้ระหว่างกำลังชาร์จหรือร่ายเวทย์
> 
> เมื่อใช้ไปครั้งหนึ่งแล้วผลจะหายไปในเวลาไม่กี่วินาที
> ขึ้นอยู่กับสกิลเลเวล

**Role:** buff (self) · passive mastery

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Trigger | 19 | 18 | 17 | 16 | 15 | 14 | 13 | 12 | 11 | 10 |


**Buffs**

**Buff `MirageStepBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Duration: `(20 - lv)` s
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `AvoidActionManager$$AvoidMove (GetSkillLv)`
- `AvoidActionManager$$AvoidStart (GetSkillLv)`

---

### #ガードスキル · uid 192

**Type:** Unknown

**Role:** no client action class (system / production / unreleased)

---
