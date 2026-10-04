# サバイバルスキル (`SurvivalSkill`) — skill details

9 entries.

### แกล้งตาย (ActDead) · uid 193

<img src="../../icons/sk_193.png" width="40" alt="icon"> 
**Tree:** サバイバルスキル (`SurvivalSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 1 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem · **Client class:** `ActDead` (passive mastery)

> ลดเวลาที่รอเพื่อคืนชีพ

**How it works**

- Mastery skill of the サバイバルスキル tree (tier 1, max Lv 1); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.

_Raw recovered data (every method item): [trees/SurvivalSkill.md](../trees/SurvivalSkill.md) — uid 193_

---

### เพิ่ม Exp (ExpUp) · uid 194

<img src="../../icons/sk_194.png" width="40" alt="icon"> 
**Tree:** サバイバルスキル (`SurvivalSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 1 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem · **Client class:** `ExpUp` (passive mastery)

> เพิ่ม EXP ที่ได้รับ 1% ต่อเลเวล

**How it works**

- Mastery skill of the サバイバルスキル tree (tier 1, max Lv 1); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Value (generic value) 1 at Lv1 to 10 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


Bonus meanings (inferred from the names):

- `Value`: generic value

_Raw recovered data (every method item): [trees/SurvivalSkill.md](../trees/SurvivalSkill.md) — uid 194_

---

### เพิ่มอัตราดรอป (DropUp) · uid 195

<img src="../../icons/sk_195.png" width="40" alt="icon"> 
**Tree:** サバイバルスキル (`SurvivalSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 1 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem · **Client class:** `DropUp` (passive mastery)

> เพิ่มอัตราดรอป 1% ต่อเลเวล

**How it works**

- Mastery skill of the サバイバルスキル tree (tier 1, max Lv 1); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Value (generic value) 1 at Lv1 to 10 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


Bonus meanings (inferred from the names):

- `Value`: generic value

_Raw recovered data (every method item): [trees/SurvivalSkill.md](../trees/SurvivalSkill.md) — uid 195_

---

### พักอย่างปลอดภัย (SafetyRest) · uid 196

<img src="../../icons/sk_196.png" width="40" alt="icon"> 
**Tree:** サバイバルスキル (`SurvivalSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 1 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem · **Client class:** `SafetyRest` (passive mastery)

> เพิ่มการฟื้นฟู HP อัตโนมัติเมื่อไม่ได้ต่อสู้

**How it works**

- Mastery skill of the サバイバルスキル tree (tier 1, max Lv 1); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Percent (generic percent) 10 at Lv1 to 100 at Lv10, Value (generic value) 10 at Lv1 to 100 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Percent | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |
| Value | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |


Bonus meanings (inferred from the names):

- `Percent`: generic percent
- `Value`: generic value

_Raw recovered data (every method item): [trees/SurvivalSkill.md](../trees/SurvivalSkill.md) — uid 196_

---

### พักสั้นๆ (SmallBreather) · uid 197

<img src="../../icons/sk_197.png" width="40" alt="icon"> 
**Tree:** サバイバルスキル (`SurvivalSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 1 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem · **Client class:** `SmallBreather` (passive mastery)

> เพิ่มการฟื้นฟู MP อัตโนมัติเมื่อไม่ได้ต่อสู้

**How it works**

- Mastery skill of the サバイバルスキル tree (tier 1, max Lv 1); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Percent (generic percent) 5 at Lv1 to 50 at Lv10, Value (generic value) 1 at Lv1 to 10 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Percent | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |
| Value | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


Bonus meanings (inferred from the names):

- `Percent`: generic percent
- `Value`: generic value

_Raw recovered data (every method item): [trees/SurvivalSkill.md](../trees/SurvivalSkill.md) — uid 197_

---

### เร่ง HP (HpBoost) · uid 198

<img src="../../icons/sk_198.png" width="40" alt="icon"> 
**Tree:** サバイバルスキル (`SurvivalSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 20 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** พักอย่างปลอดภัย · **Client class:** `HpBoost` (passive mastery)

> เพิ่ม HP สูงสุดขึ้นเล็กน้อย

**How it works**

- Mastery skill of the サバイバルスキル tree (tier 2, max Lv 20); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): MaxHp (max HP) 100 at Lv1 to 1000 at Lv10, MaxHpRate (max HP %) 2 at Lv1 to 20 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MaxHp | 100 | 200 | 300 | 400 | 500 | 600 | 700 | 800 | 900 | 1000 |
| MaxHpRate | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |


Bonus meanings (inferred from the names):

- `MaxHp`: max HP
- `MaxHpRate`: max HP %

_Raw recovered data (every method item): [trees/SurvivalSkill.md](../trees/SurvivalSkill.md) — uid 198_

---

### เร่ง HP ต่อเนื่อง (LeewayBattle) · uid 199

<img src="../../icons/sk_199.png" width="40" alt="icon"> 
**Tree:** サバイバルスキル (`SurvivalSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 20 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** พักอย่างปลอดภัย · **Client class:** `LeewayBattle` (passive mastery)

> เพิ่มการฟื้นฟู HP อัตโนมัติขึ้น
> เพียงเล็กน้อยขณะต่อสู้

**How it works**

- Mastery skill of the サバイバルスキル tree (tier 2, max Lv 20); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Value (generic value) 1 at Lv1 to 10 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


Bonus meanings (inferred from the names):

- `Value`: generic value

_Raw recovered data (every method item): [trees/SurvivalSkill.md](../trees/SurvivalSkill.md) — uid 199_

---

### เร่ง MP (MpBoost) · uid 200

<img src="../../icons/sk_200.png" width="40" alt="icon"> 
**Tree:** サバイバルスキル (`SurvivalSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 20 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** พักสั้นๆ · **Client class:** `MpBoost` (passive mastery)

> เพิ่ม MP สูงสุดขึ้นเล็กน้อย

**How it works**

- Mastery skill of the サバイバルスキル tree (tier 2, max Lv 20); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): MaxMp (max MP) 30 at Lv1 to 300 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MaxMp | 30 | 60 | 90 | 120 | 150 | 180 | 210 | 240 | 270 | 300 |


Bonus meanings (inferred from the names):

- `MaxMp`: max MP

_Raw recovered data (every method item): [trees/SurvivalSkill.md](../trees/SurvivalSkill.md) — uid 200_

---

### เร่ง MP ต่อเนื่อง (CoolBattlePlan) · uid 201

<img src="../../icons/sk_201.png" width="40" alt="icon"> 
**Tree:** サバイバルスキル (`SurvivalSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 20 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** พักสั้นๆ · **Client class:** `CoolBattlePlan` (passive mastery)

> เพิ่มการฟื้นฟู MP อัตโนมัติขึ้น
> เล็กน้อยระหว่างต่อสู้

**How it works**

- Mastery skill of the サバイバルスキル tree (tier 2, max Lv 20); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Value (generic value) 5 at Lv1 to 50 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |


Bonus meanings (inferred from the names):

- `Value`: generic value

_Raw recovered data (every method item): [trees/SurvivalSkill.md](../trees/SurvivalSkill.md) — uid 201_

---
