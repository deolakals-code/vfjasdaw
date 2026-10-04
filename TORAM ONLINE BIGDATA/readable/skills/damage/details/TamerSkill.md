# テイマースキル (`TamerSkill`) — skill details

7 entries.

### จับสัตว์ (Taming) · uid 449

<img src="../../icons/sk_449.png" width="40" alt="icon"> 
**Tree:** テイマースキル (`TamerSkill`, tier 1) · **Type:** Special · **Max Lv:** 30 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem · **Client class:** `TamingAction`

> ลองจับมอนสเตอร์ที่อ่อนแอกว่าตัวเองดูสิ
> ถ้าสกิลเลเวลเพิ่มขึ้นจะมีโอกาสจับเป้าหมายที่มีเลเวลสูงขึ้นได้
> การจำกัดเวลาจะเพิ่มขึ้นและอัตราการสูญเสียกรงเมื่อล้มเหลวจะลดลง
> ใช้[กรงดักสัตว์] 1 ชิ้น

**How it works**

- Special skill of the テイマースキル tree (tier 1, max Lv 30); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a utility / system action (movement, state change) rather than a damage or buff skill.
- Other client code reads this skill (2 lookups; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(8)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 449
- No proration slot: ExpType None: no proration slot.

**Where else this skill takes effect**

- Code that reads this skill's level / buff by constant id: `CaptureTarget$$.ctor (GetSkillLv)`, `CaptureTargetFactory$$CheckCaptureType (GetSkillLv)`

_Raw recovered data (every method item): [trees/TamerSkill.md](../trees/TamerSkill.md) — uid 449_

---

### เทคนิคจับสัตว์ I (CaptureTechnicI) · uid 450

<img src="../../icons/sk_450.png" width="40" alt="icon"> 
**Tree:** テイマースキル (`TamerSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 30 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** จับสัตว์ · **Flags:** StarGem · **Client class:** `CaptureTechnicI` (passive mastery)

> เลเวลสูงสุดของเป้าหมายที่จับได้
> และการจำกัดเวลาจะเพิ่มขึ้น

**How it works**

- Mastery skill of the テイマースキル tree (tier 1, max Lv 30); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): LimitLvDown (level-cap reduction) 1 at Lv1 to 5 at Lv10, LimitTimeUp (time limit extension) 1 at Lv1 to 10 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| LimitLvDown | 1 | 1 | 2 | 2 | 3 | 3 | 4 | 4 | 5 | 5 |
| LimitTimeUp | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


Bonus meanings (inferred from the names):

- `LimitLvDown`: level-cap reduction
- `LimitTimeUp`: time limit extension

_Raw recovered data (every method item): [trees/TamerSkill.md](../trees/TamerSkill.md) — uid 450_

---

### จับอย่างเชี่ยวชาญ (GoodTame) · uid 451

<img src="../../icons/sk_451.png" width="40" alt="icon"> 
**Tree:** テイマースキル (`TamerSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 30 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** จับสัตว์ · **Flags:** StarGem · **Client class:** `GoodTame` (passive mastery)

> เมื่อจับสำเร็จมีโอกาสทำให้
> ขีดจำกัดของเลเวลในการเจริญเติบโตเพิ่มขึ้น

**How it works**

- Mastery skill of the テイマースキル tree (tier 1, max Lv 30); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.

_Raw recovered data (every method item): [trees/TamerSkill.md](../trees/TamerSkill.md) — uid 451_

---

### เพ็ทฮีล (PetHeal) · uid 452

<img src="../../icons/sk_452.png" width="40" alt="icon"> 
**Tree:** テイマースキル (`TamerSkill`, tier 1) · **Type:** Buffer · **Max Lv:** 30 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** จับสัตว์ · **Flags:** StarGem · **Client class:** `PetHealAction`

> ฟื้นฟู HP ของสัตว์เลี้ยงที่ตัวเองเรียกมา
> ไม่สามารถใช้กับสัตว์เลี้ยงของคนอื่นได้

**How it works**

- Buffer skill of the テイマースキル tree (tier 1, max Lv 30); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It restores HP or MP.

**Cost, timing and range**

- **Cast time** (`CastTime`): `((7 - frintp((Lv / 3))) / 1.5)`
  - when `(mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND WeaponType eq 14`
- **Cast time** (`CastTime`): `((7 - frintp((Lv / 3))) * 0.5)`
  - when `(mainWeapon==Bow & 1) ne 0 OR (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND WeaponType eq 12 AND WeaponType ne 14`
- **Cast time** (`CastTime`): `(7 - frintp((Lv / 3)))`
  - when `(mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND WeaponType ne 12 AND WeaponType ne 14`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 7 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionStart` — when the cast starts: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 452
- No proration slot: ExpType None: no proration slot.

**Other recovered parameters**

- **HP recovered** (`hpRecovery`): `(Lv * 100)` → Lv1..10 [100, 200, 300, 400, 500, 600, 700, 800, 900, 1000]; `(int((hpHealRate * status.MaxHp)) + hpRecovery)` _(when UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<PetMemberActionManager>(target), 0))_
- **Cast time modifier** (`CastTime`): `((7 - frintp((Lv / 3))) / 1.5)` _(when (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND WeaponType eq 14)_; `((7 - frintp((Lv / 3))) * 0.5)` _(when (mainWeapon==Bow & 1) ne 0 OR (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND WeaponType eq 12 AND WeaponType ne 14)_; `(7 - frintp((Lv / 3)))` _(when (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND WeaponType ne 12 AND WeaponType ne 14)_

**In-game level notes**

- Lv12: *เพิ่มปริมาณการฟื้นฟู *เวลาชาร์จน้อยลง14$0$*เพิ่มปริมาณการฟื้นฟู *เวลาชาร์จน้อยลงเล็กน้อย

_Raw recovered data (every method item): [trees/TamerSkill.md](../trees/TamerSkill.md) — uid 452_

---

### เทคนิคจับสัตว์ II (CaptureTechnicII) · uid 453

<img src="../../icons/sk_453.png" width="40" alt="icon"> 
**Tree:** テイマースキル (`TamerSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 90 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เทคนิคจับสัตว์ I · **Client class:** `CaptureTechnicII` (passive mastery)

> เลเวลสูงสุดของเป้าหมายที่จับได้
> และการจำกัดเวลาจะเพิ่มมากขึ้นอีก

**How it works**

- Mastery skill of the テイマースキル tree (tier 2, max Lv 90); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.

_Raw recovered data (every method item): [trees/TamerSkill.md](../trees/TamerSkill.md) — uid 453_

---

### จับอย่างละม่อม (CarefulCapture) · uid 454

<img src="../../icons/sk_454.png" width="40" alt="icon"> 
**Tree:** テイマースキル (`TamerSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 90 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** จับอย่างเชี่ยวชาญ · **Client class:** `CarefulCapture` (passive mastery)

> เมื่อจับสำเร็จมีโอกาสที่จะจับได้แบบ
> มีศักยภาพสูงขึ้นเล็กน้อย

**How it works**

- Mastery skill of the テイマースキル tree (tier 2, max Lv 90); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.

_Raw recovered data (every method item): [trees/TamerSkill.md](../trees/TamerSkill.md) — uid 454_

---

### เพ็ท MP ชาร์จ (PetCharge) · uid 455

<img src="../../icons/sk_455.png" width="40" alt="icon"> 
**Tree:** テイマースキル (`TamerSkill`, tier 2) · **Type:** Buffer · **Max Lv:** 90 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เพ็ทฮีล · **Client class:** `PetChargeAction`

> ฟื้นฟู MP ของสัตว์เลี้ยงที่ตัวเองเรียกมา
> ไม่สามารถใช้กับสัตว์เลี้ยงของคนอื่นได้

**How it works**

- Buffer skill of the テイマースキル tree (tier 2, max Lv 90); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a utility / system action (movement, state change) rather than a damage or buff skill.

**Cost, timing and range**

- **Cast time** (`CastTime`): `((10 - frintp((Lv / 3))) / 1.5)`
  - when `(mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND WeaponType eq 14`
- **Cast time** (`CastTime`): `((10 - frintp((Lv / 3))) * 0.5)`
  - when `(mainWeapon==Bow & 1) ne 0 OR (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND WeaponType eq 12 AND WeaponType ne 14`
- **Cast time** (`CastTime`): `(10 - frintp((Lv / 3)))`
  - when `(mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND WeaponType ne 12 AND WeaponType ne 14`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 5 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 455
- No proration slot: ExpType None: no proration slot.

**Other recovered parameters**

- **MP recovered** (`mpRecovery`): `(Lv * 100)` → Lv1..10 [100, 200, 300, 400, 500, 600, 700, 800, 900, 1000]
- **Cast time modifier** (`CastTime`): `((10 - frintp((Lv / 3))) / 1.5)` _(when (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND WeaponType eq 14)_; `((10 - frintp((Lv / 3))) * 0.5)` _(when (mainWeapon==Bow & 1) ne 0 OR (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND WeaponType eq 12 AND WeaponType ne 14)_; `(10 - frintp((Lv / 3)))` _(when (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND WeaponType ne 12 AND WeaponType ne 14)_

**In-game level notes**

- Lv12: *เวลาชาร์จน้อยลง
- Lv14: *เวลาชาร์จน้อยลงเล็กน้อย

_Raw recovered data (every method item): [trees/TamerSkill.md](../trees/TamerSkill.md) — uid 455_

---
