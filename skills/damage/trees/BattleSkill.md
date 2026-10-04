# バトルスキル (`BattleSkill`)

15 entries. See ../README.md for how to read these blocks.

### เพิ่มพลังโจมตี (AtkUp) · uid 481

<img src="../../icons/sk_481.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 20 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem · **Client class:** `AtkUp` (passive mastery)

> เพิ่ม ATK ขึ้นเล็กน้อย
> จำนวนที่เพิ่มจะขึ้นอยู่กับเลเวลของผู้เล่น

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| AtkRate | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |


---

### เพิ่มพลังเวท (MatkUp) · uid 482

<img src="../../icons/sk_482.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 20 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem · **Client class:** `MatkUp` (passive mastery)

> เพิ่ม MATK ขึ้นเล็กน้อย
> จำนวนที่เพิ่มจะขึ้นอยู่กับเลเวลของผู้เล่น

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MatkRate | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |


---

### เพิ่มพลังป้องกัน (DefUp) · uid 483

<img src="../../icons/sk_483.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 20 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem · **Client class:** `DefUp` (passive mastery)

> เพิ่ม DEF/MDEF ขึ้นเล็กน้อย
> จำนวนที่เพิ่มจะขึ้นอยู่กับเลเวลของผู้เล่น

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| DefRate | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |
| MdefRate | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |


---

### เต็มแรง (HeavyBlow) · uid 484

<img src="../../icons/sk_484.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 20 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เพิ่มพลังโจมตี · **Flags:** StarGem · **Client class:** `HeavyBlow` (passive mastery)

> เมื่อโจมตีทางกายภาพทำให้มีโอกาสเพียงน้อยนิด
> ที่จะทำให้อัตราความเสียหายครั้งสุดท้ายเพิ่มขึ้น

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Trigger | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| LastDmgRate | 11 | 12 | 13 | 14 | 15 | 16 | 17 | 18 | 19 | 20 |


---

### สมาธิ (Concentration) · uid 485

<img src="../../icons/sk_485.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 20 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เพิ่มพลังเวท · **Flags:** StarGem · **Client class:** `Concentration` (passive mastery)

> เมื่อโจมตีด้วยเวทมนตร์ทำให้มีโอกาสเพียงน้อยนิด
> ที่จะทำให้อัตราความเสียหายครั้งสุดท้ายเพิ่มขึ้น

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Trigger | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| LastDmgRate | 11 | 12 | 13 | 14 | 15 | 16 | 17 | 18 | 19 | 20 |


---

### เพิ่มการหลบหลีก (FleeUp) · uid 486

<img src="../../icons/sk_486.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 20 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เพิ่มพลังป้องกัน · **Flags:** StarGem · **Client class:** `FleeUp` (passive mastery)

> เพิ่มอัตราหลบหลีกเล็กน้อย

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flee | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


---

### เพิ่มคริติคอล (CrtUp) · uid 487

<img src="../../icons/sk_487.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 60 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เต็มแรง · **Client class:** `CrtUp` (passive mastery)

> เพิ่มอัตราคริติคอลและค่าความเสียหายเล็กน้อย

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Crt | 0 | 1 | 1 | 2 | 2 | 3 | 3 | 4 | 4 | 5 |
| CrtDmg | 0 | 1 | 1 | 2 | 2 | 3 | 3 | 4 | 4 | 5 |


---

### ต่อต้านเต็มกำลัง (DesperateResistance) · uid 488

<img src="../../icons/sk_488.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 60 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** สมาธิ · **Client class:** `DesperateResistance` (passive mastery)

> ลดค่าความเสียหายลงเล็กน้อยเมื่อตกอยู่ในสภาพ
> ที่เคลื่อนไหวไม่ได้อย่างล้มคว่ำหรือหมดสติ

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| CutDmgRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


---

### เพิ่มความแม่นยำ (HitUp) · uid 489

<img src="../../icons/sk_489.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 60 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เพิ่มการหลบหลีก · **Client class:** `HitUp` (passive mastery)

> เพิ่มอัตราความแม่นเล็กน้อย

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Hit | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


---

### พลังขู่ขวัญ (ThreateningPower) · uid 490

<img src="../../icons/sk_490.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 120 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เพิ่มคริติคอล · **Client class:** `ThreateningPower` (passive mastery)

> เพิ่ม ATK เล็กน้อย
> จำนวนที่เพิ่มจะขึ้นอยู่กับเลเวลของผู้เล่น

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| AtkRate | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |


---

### เพิ่มพลังเวทขั้นสูง (FurtherMagic) · uid 491

<img src="../../icons/sk_491.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 120 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ต่อต้านเต็มกำลัง · **Client class:** `FurtherMagic` (passive mastery)

> เพิ่ม MATK เล็กน้อย
> จำนวนที่เพิ่มจะขึ้นอยู่กับเลเวลของผู้เล่น

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MatkRate | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |


---

### ดีเฟ้นส์มาสเตอรี่ (KnowledgeOfDefense) · uid 492

<img src="../../icons/sk_492.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 120 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เพิ่มความแม่นยำ · **Client class:** `KnowledgeOfDefense` (passive mastery)

> เพิ่ม DEF/MDEF เล็กน้อย
> จำนวนที่เพิ่มจะขึ้นอยู่กับเลเวลของผู้เล่น

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| DefRate | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |
| MdefRate | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |


---

### แก่นแท้แห่งการโจมตี (ThePursuitOfPursuit) · uid 493

<img src="../../icons/sk_493.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 4) · **Type:** Mastery · **Max Lv:** 180 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** พลังขู่ขวัญ · **Client class:** `ThePursuitOfPursuit` (passive mastery)

> เพิ่มอัตราการเกิดการโจมตีทางกายภาพและเวทเพิ่ม
> จำเป็นต้องมีอุปกรณ์ที่มีความสามารถข้างต้นติดอยู่

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Percent | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |


---

### สเปลเบิสต์ (SpellBurst) · uid 494

<img src="../../icons/sk_494.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 4) · **Type:** Mastery · **Max Lv:** 180 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เพิ่มพลังเวทขั้นสูง · **Client class:** `SpellBurst` (passive mastery)

> ความสามารถทางคริติคอลจะมีอิทธิพล
> ต่อการโจมตีเวทมนตร์เล็กน้อยด้วย

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Percent | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |


---

### ซุปเปอร์กริป (SuperGrip) · uid 495

<img src="../../icons/sk_495.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 4) · **Type:** Mastery · **Max Lv:** 180 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ดีเฟ้นส์มาสเตอรี่ · **Client class:** `SuperGrip` (passive mastery)

> ทำให้ระยะของผลักกระเด็นที่เกิดตอน
> โจมตีเต็มกำลังมีระยะสั้นลง

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Percent | 7 | 15 | 22 | 30 | 37 | 45 | 52 | 60 | 67 | 75 |


---
