# バトルスキル (`BattleSkill`) — skill details

15 entries.

### เพิ่มพลังโจมตี (AtkUp) · uid 481

<img src="../../icons/sk_481.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 20 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem · **Client class:** `AtkUp` (passive mastery)

> เพิ่ม ATK ขึ้นเล็กน้อย
> จำนวนที่เพิ่มจะขึ้นอยู่กับเลเวลของผู้เล่น

**How it works**

- Mastery skill of the バトルスキル tree (tier 1, max Lv 20); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): AtkRate (ATK %) 2 at Lv1 to 25 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| AtkRate | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |


Bonus meanings (inferred from the names):

- `AtkRate`: ATK %

_Raw recovered data (every method item): [trees/BattleSkill.md](../trees/BattleSkill.md) — uid 481_

---

### เพิ่มพลังเวท (MatkUp) · uid 482

<img src="../../icons/sk_482.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 20 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem · **Client class:** `MatkUp` (passive mastery)

> เพิ่ม MATK ขึ้นเล็กน้อย
> จำนวนที่เพิ่มจะขึ้นอยู่กับเลเวลของผู้เล่น

**How it works**

- Mastery skill of the バトルスキル tree (tier 1, max Lv 20); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): MatkRate (MATK %) 2 at Lv1 to 25 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MatkRate | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |


Bonus meanings (inferred from the names):

- `MatkRate`: MATK %

_Raw recovered data (every method item): [trees/BattleSkill.md](../trees/BattleSkill.md) — uid 482_

---

### เพิ่มพลังป้องกัน (DefUp) · uid 483

<img src="../../icons/sk_483.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 20 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem · **Client class:** `DefUp` (passive mastery)

> เพิ่ม DEF/MDEF ขึ้นเล็กน้อย
> จำนวนที่เพิ่มจะขึ้นอยู่กับเลเวลของผู้เล่น

**How it works**

- Mastery skill of the バトルスキル tree (tier 1, max Lv 20); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): DefRate (DEF %) 2 at Lv1 to 25 at Lv10, MdefRate (MDEF %) 2 at Lv1 to 25 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| DefRate | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |
| MdefRate | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |


Bonus meanings (inferred from the names):

- `DefRate`: DEF %
- `MdefRate`: MDEF %

_Raw recovered data (every method item): [trees/BattleSkill.md](../trees/BattleSkill.md) — uid 483_

---

### เต็มแรง (HeavyBlow) · uid 484

<img src="../../icons/sk_484.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 20 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เพิ่มพลังโจมตี · **Flags:** StarGem · **Client class:** `HeavyBlow` (passive mastery)

> เมื่อโจมตีทางกายภาพทำให้มีโอกาสเพียงน้อยนิด
> ที่จะทำให้อัตราความเสียหายครั้งสุดท้ายเพิ่มขึ้น

**How it works**

- Mastery skill of the バトルスキル tree (tier 1, max Lv 20); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Trigger (trigger chance (%)) 1 at Lv1 to 10 at Lv10, LastDmgRate (final damage dealt %) 11 at Lv1 to 20 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Trigger | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| LastDmgRate | 11 | 12 | 13 | 14 | 15 | 16 | 17 | 18 | 19 | 20 |


Bonus meanings (inferred from the names):

- `Trigger`: trigger chance (%)
- `LastDmgRate`: final damage dealt %

_Raw recovered data (every method item): [trees/BattleSkill.md](../trees/BattleSkill.md) — uid 484_

---

### สมาธิ (Concentration) · uid 485

<img src="../../icons/sk_485.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 20 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เพิ่มพลังเวท · **Flags:** StarGem · **Client class:** `Concentration` (passive mastery)

> เมื่อโจมตีด้วยเวทมนตร์ทำให้มีโอกาสเพียงน้อยนิด
> ที่จะทำให้อัตราความเสียหายครั้งสุดท้ายเพิ่มขึ้น

**How it works**

- Mastery skill of the バトルスキル tree (tier 1, max Lv 20); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Trigger (trigger chance (%)) 1 at Lv1 to 10 at Lv10, LastDmgRate (final damage dealt %) 11 at Lv1 to 20 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Trigger | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| LastDmgRate | 11 | 12 | 13 | 14 | 15 | 16 | 17 | 18 | 19 | 20 |


Bonus meanings (inferred from the names):

- `Trigger`: trigger chance (%)
- `LastDmgRate`: final damage dealt %

_Raw recovered data (every method item): [trees/BattleSkill.md](../trees/BattleSkill.md) — uid 485_

---

### เพิ่มการหลบหลีก (FleeUp) · uid 486

<img src="../../icons/sk_486.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 20 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เพิ่มพลังป้องกัน · **Flags:** StarGem · **Client class:** `FleeUp` (passive mastery)

> เพิ่มอัตราหลบหลีกเล็กน้อย

**How it works**

- Mastery skill of the バトルスキル tree (tier 1, max Lv 20); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Flee (dodge) 1 at Lv1 to 10 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flee | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


Bonus meanings (inferred from the names):

- `Flee`: dodge

_Raw recovered data (every method item): [trees/BattleSkill.md](../trees/BattleSkill.md) — uid 486_

---

### เพิ่มคริติคอล (CrtUp) · uid 487

<img src="../../icons/sk_487.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 60 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เต็มแรง · **Client class:** `CrtUp` (passive mastery)

> เพิ่มอัตราคริติคอลและค่าความเสียหายเล็กน้อย

**How it works**

- Mastery skill of the バトルスキル tree (tier 2, max Lv 60); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Crt (critical rate) 0 at Lv1 to 5 at Lv10, CrtDmg (critical damage) 0 at Lv1 to 5 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Crt | 0 | 1 | 1 | 2 | 2 | 3 | 3 | 4 | 4 | 5 |
| CrtDmg | 0 | 1 | 1 | 2 | 2 | 3 | 3 | 4 | 4 | 5 |


Bonus meanings (inferred from the names):

- `Crt`: critical rate
- `CrtDmg`: critical damage

_Raw recovered data (every method item): [trees/BattleSkill.md](../trees/BattleSkill.md) — uid 487_

---

### ต่อต้านเต็มกำลัง (DesperateResistance) · uid 488

<img src="../../icons/sk_488.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 60 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** สมาธิ · **Client class:** `DesperateResistance` (passive mastery)

> ลดค่าความเสียหายลงเล็กน้อยเมื่อตกอยู่ในสภาพ
> ที่เคลื่อนไหวไม่ได้อย่างล้มคว่ำหรือหมดสติ

**How it works**

- Mastery skill of the バトルスキル tree (tier 2, max Lv 60); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): CutDmgRate (damage taken reduction %) 1 at Lv1 to 10 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| CutDmgRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


Bonus meanings (inferred from the names):

- `CutDmgRate`: damage taken reduction %

_Raw recovered data (every method item): [trees/BattleSkill.md](../trees/BattleSkill.md) — uid 488_

---

### เพิ่มความแม่นยำ (HitUp) · uid 489

<img src="../../icons/sk_489.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 60 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เพิ่มการหลบหลีก · **Client class:** `HitUp` (passive mastery)

> เพิ่มอัตราความแม่นเล็กน้อย

**How it works**

- Mastery skill of the バトルスキル tree (tier 2, max Lv 60); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Hit (accuracy) 1 at Lv1 to 10 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Hit | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


Bonus meanings (inferred from the names):

- `Hit`: accuracy

_Raw recovered data (every method item): [trees/BattleSkill.md](../trees/BattleSkill.md) — uid 489_

---

### พลังขู่ขวัญ (ThreateningPower) · uid 490

<img src="../../icons/sk_490.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 120 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เพิ่มคริติคอล · **Client class:** `ThreateningPower` (passive mastery)

> เพิ่ม ATK เล็กน้อย
> จำนวนที่เพิ่มจะขึ้นอยู่กับเลเวลของผู้เล่น

**How it works**

- Mastery skill of the バトルスキル tree (tier 3, max Lv 120); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): AtkRate (ATK %) 2 at Lv1 to 25 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| AtkRate | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |


Bonus meanings (inferred from the names):

- `AtkRate`: ATK %

_Raw recovered data (every method item): [trees/BattleSkill.md](../trees/BattleSkill.md) — uid 490_

---

### เพิ่มพลังเวทขั้นสูง (FurtherMagic) · uid 491

<img src="../../icons/sk_491.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 120 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ต่อต้านเต็มกำลัง · **Client class:** `FurtherMagic` (passive mastery)

> เพิ่ม MATK เล็กน้อย
> จำนวนที่เพิ่มจะขึ้นอยู่กับเลเวลของผู้เล่น

**How it works**

- Mastery skill of the バトルスキル tree (tier 3, max Lv 120); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): MatkRate (MATK %) 2 at Lv1 to 25 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MatkRate | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |


Bonus meanings (inferred from the names):

- `MatkRate`: MATK %

_Raw recovered data (every method item): [trees/BattleSkill.md](../trees/BattleSkill.md) — uid 491_

---

### ดีเฟ้นส์มาสเตอรี่ (KnowledgeOfDefense) · uid 492

<img src="../../icons/sk_492.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 120 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เพิ่มความแม่นยำ · **Client class:** `KnowledgeOfDefense` (passive mastery)

> เพิ่ม DEF/MDEF เล็กน้อย
> จำนวนที่เพิ่มจะขึ้นอยู่กับเลเวลของผู้เล่น

**How it works**

- Mastery skill of the バトルスキル tree (tier 3, max Lv 120); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): DefRate (DEF %) 2 at Lv1 to 25 at Lv10, MdefRate (MDEF %) 2 at Lv1 to 25 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| DefRate | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |
| MdefRate | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |


Bonus meanings (inferred from the names):

- `DefRate`: DEF %
- `MdefRate`: MDEF %

_Raw recovered data (every method item): [trees/BattleSkill.md](../trees/BattleSkill.md) — uid 492_

---

### แก่นแท้แห่งการโจมตี (ThePursuitOfPursuit) · uid 493

<img src="../../icons/sk_493.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 4) · **Type:** Mastery · **Max Lv:** 180 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** พลังขู่ขวัญ · **Client class:** `ThePursuitOfPursuit` (passive mastery)

> เพิ่มอัตราการเกิดการโจมตีทางกายภาพและเวทเพิ่ม
> จำเป็นต้องมีอุปกรณ์ที่มีความสามารถข้างต้นติดอยู่

**How it works**

- Mastery skill of the バトルスキル tree (tier 4, max Lv 180); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Percent (generic percent) 2 at Lv1 to 25 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Percent | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |


Bonus meanings (inferred from the names):

- `Percent`: generic percent

_Raw recovered data (every method item): [trees/BattleSkill.md](../trees/BattleSkill.md) — uid 493_

---

### สเปลเบิสต์ (SpellBurst) · uid 494

<img src="../../icons/sk_494.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 4) · **Type:** Mastery · **Max Lv:** 180 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เพิ่มพลังเวทขั้นสูง · **Client class:** `SpellBurst` (passive mastery)

> ความสามารถทางคริติคอลจะมีอิทธิพล
> ต่อการโจมตีเวทมนตร์เล็กน้อยด้วย

**How it works**

- Mastery skill of the バトルスキル tree (tier 4, max Lv 180); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Percent (generic percent) 2 at Lv1 to 25 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Percent | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |


Bonus meanings (inferred from the names):

- `Percent`: generic percent

_Raw recovered data (every method item): [trees/BattleSkill.md](../trees/BattleSkill.md) — uid 494_

---

### ซุปเปอร์กริป (SuperGrip) · uid 495

<img src="../../icons/sk_495.png" width="40" alt="icon"> 
**Tree:** バトルスキル (`BattleSkill`, tier 4) · **Type:** Mastery · **Max Lv:** 180 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ดีเฟ้นส์มาสเตอรี่ · **Client class:** `SuperGrip` (passive mastery)

> ทำให้ระยะของผลักกระเด็นที่เกิดตอน
> โจมตีเต็มกำลังมีระยะสั้นลง

**How it works**

- Mastery skill of the バトルスキル tree (tier 4, max Lv 180); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Percent (generic percent) 7 at Lv1 to 75 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Percent | 7 | 15 | 22 | 30 | 37 | 45 | 52 | 60 | 67 | 75 |


Bonus meanings (inferred from the names):

- `Percent`: generic percent

_Raw recovered data (every method item): [trees/BattleSkill.md](../trees/BattleSkill.md) — uid 495_

---
