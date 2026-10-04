# テイマースキル (`TamerSkill`)

7 entries. See ../README.md for how to read these blocks.

### จับสัตว์ (Taming) · uid 449

<img src="../../icons/sk_449.png" width="40" alt="icon"> 
**Tree:** テイマースキル (`TamerSkill`, tier 1) · **Type:** Special · **Max Lv:** 30 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem · **Client class:** `TamingAction`

> ลองจับมอนสเตอร์ที่อ่อนแอกว่าตัวเองดูสิ
> ถ้าสกิลเลเวลเพิ่มขึ้นจะมีโอกาสจับเป้าหมายที่มีเลเวลสูงขึ้นได้
> การจำกัดเวลาจะเพิ่มขึ้นและอัตราการสูญเสียกรงเมื่อล้มเหลวจะลดลง
> ใช้[กรงดักสัตว์] 1 ชิ้น

**Role:** utility / system action

This action never changes monster proration: ExpType None: no proration slot.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 449

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(8)`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `CaptureTarget$$.ctor (GetSkillLv)`
- `CaptureTargetFactory$$CheckCaptureType (GetSkillLv)`

---

### เทคนิคจับสัตว์ I (CaptureTechnicI) · uid 450

<img src="../../icons/sk_450.png" width="40" alt="icon"> 
**Tree:** テイマースキル (`TamerSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 30 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** จับสัตว์ · **Flags:** StarGem · **Client class:** `CaptureTechnicI` (passive mastery)

> เลเวลสูงสุดของเป้าหมายที่จับได้
> และการจำกัดเวลาจะเพิ่มขึ้น

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| LimitLvDown | 1 | 1 | 2 | 2 | 3 | 3 | 4 | 4 | 5 | 5 |
| LimitTimeUp | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


---

### จับอย่างเชี่ยวชาญ (GoodTame) · uid 451

<img src="../../icons/sk_451.png" width="40" alt="icon"> 
**Tree:** テイマースキル (`TamerSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 30 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** จับสัตว์ · **Flags:** StarGem · **Client class:** `GoodTame` (passive mastery)

> เมื่อจับสำเร็จมีโอกาสทำให้
> ขีดจำกัดของเลเวลในการเจริญเติบโตเพิ่มขึ้น

**Role:** passive mastery

---

### เพ็ทฮีล (PetHeal) · uid 452

<img src="../../icons/sk_452.png" width="40" alt="icon"> 
**Tree:** テイマースキル (`TamerSkill`, tier 1) · **Type:** Buffer · **Max Lv:** 30 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** จับสัตว์ · **Flags:** StarGem · **Client class:** `PetHealAction`

> ฟื้นฟู HP ของสัตว์เลี้ยงที่ตัวเองเรียกมา
> ไม่สามารถใช้กับสัตว์เลี้ยงของคนอื่นได้

<details><summary>In-game level notes</summary>

- Lv12: *เพิ่มปริมาณการฟื้นฟู *เวลาชาร์จน้อยลง14$0$*เพิ่มปริมาณการฟื้นฟู *เวลาชาร์จน้อยลงเล็กน้อย

</details>

**Role:** heal / recovery

This action never changes monster proration: ExpType None: no proration slot.

**Mechanics recovered from code**

- **HP recovered** (`hpRecovery`): `(Lv * 100)` → Lv1..10 [100, 200, 300, 400, 500, 600, 700, 800, 900, 1000]; `(int((hpHealRate * status.MaxHp)) + hpRecovery)` _(when UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<PetMemberActionManager>(target), 0))_
- **Cast time modifier** (`CastTime`): `((7 - frintp((Lv / 3))) / 1.5)` _(when (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND WeaponType eq 14)_; `((7 - frintp((Lv / 3))) * 0.5)` _(when (mainWeapon==Bow & 1) ne 0 OR (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND WeaponType eq 12 AND WeaponType ne 14)_; `(7 - frintp((Lv / 3)))` _(when (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND WeaponType ne 12 AND WeaponType ne 14)_

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 452

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (5 paths)

- set `ActionRange` = `-1` = -1
- set `hpRecovery` = `(Lv * 100)` → Lv1..10: [100, 200, 300, 400, 500, 600, 700, 800, 900, 1000]
- set `CastTime` = `((7 - frintp((Lv / 3))) / 1.5)` — when (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND WeaponType eq 14
- set `hpHealRate` = `((int((Lv * 2.5)) + 15) / 100)` → Lv1..10: [0.17, 0.2, 0.22, 0.25, 0.27, 0.3, 0.32, 0.35, 0.37, 0.4] — when (mainWeapon==Bow & 1) ne 0 OR (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND WeaponType eq 14
- set `CastTime` = `((7 - frintp((Lv / 3))) * 0.5)` — when (mainWeapon==Bow & 1) ne 0 OR (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND WeaponType eq 12 AND WeaponType ne 14
- set `CastTime` = `(7 - frintp((Lv / 3)))` — when (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND WeaponType ne 12 AND WeaponType ne 14
- set `hpHealRate` = `(int((Lv * 2.5)) / 100)` → Lv1..10: [0.02, 0.05, 0.07, 0.1, 0.12, 0.15, 0.17, 0.2, 0.22, 0.25] — when (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND WeaponType ne 12 AND WeaponType ne 14

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionStart`** (2 paths)

- set `hpRecovery` = `(int((hpHealRate * status.MaxHp)) + hpRecovery)` — when UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<PetMemberActionManager>(target), 0)

</details>

---

### เทคนิคจับสัตว์ II (CaptureTechnicII) · uid 453

<img src="../../icons/sk_453.png" width="40" alt="icon"> 
**Tree:** テイマースキル (`TamerSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 90 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เทคนิคจับสัตว์ I · **Client class:** `CaptureTechnicII` (passive mastery)

> เลเวลสูงสุดของเป้าหมายที่จับได้
> และการจำกัดเวลาจะเพิ่มมากขึ้นอีก

**Role:** passive mastery

---

### จับอย่างละม่อม (CarefulCapture) · uid 454

<img src="../../icons/sk_454.png" width="40" alt="icon"> 
**Tree:** テイマースキル (`TamerSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 90 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** จับอย่างเชี่ยวชาญ · **Client class:** `CarefulCapture` (passive mastery)

> เมื่อจับสำเร็จมีโอกาสที่จะจับได้แบบ
> มีศักยภาพสูงขึ้นเล็กน้อย

**Role:** passive mastery

---

### เพ็ท MP ชาร์จ (PetCharge) · uid 455

<img src="../../icons/sk_455.png" width="40" alt="icon"> 
**Tree:** テイマースキル (`TamerSkill`, tier 2) · **Type:** Buffer · **Max Lv:** 90 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เพ็ทฮีล · **Client class:** `PetChargeAction`

> ฟื้นฟู MP ของสัตว์เลี้ยงที่ตัวเองเรียกมา
> ไม่สามารถใช้กับสัตว์เลี้ยงของคนอื่นได้

<details><summary>In-game level notes</summary>

- Lv12: *เวลาชาร์จน้อยลง
- Lv14: *เวลาชาร์จน้อยลงเล็กน้อย

</details>

**Role:** utility / system action

This action never changes monster proration: ExpType None: no proration slot.

**Mechanics recovered from code**

- **MP recovered** (`mpRecovery`): `(Lv * 100)` → Lv1..10 [100, 200, 300, 400, 500, 600, 700, 800, 900, 1000]
- **Cast time modifier** (`CastTime`): `((10 - frintp((Lv / 3))) / 1.5)` _(when (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND WeaponType eq 14)_; `((10 - frintp((Lv / 3))) * 0.5)` _(when (mainWeapon==Bow & 1) ne 0 OR (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND WeaponType eq 12 AND WeaponType ne 14)_; `(10 - frintp((Lv / 3)))` _(when (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND WeaponType ne 12 AND WeaponType ne 14)_

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 455

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (5 paths)

- set `ActionRange` = `-1` = -1
- set `mpRecovery` = `(Lv * 100)` → Lv1..10: [100, 200, 300, 400, 500, 600, 700, 800, 900, 1000]
- set `CastTime` = `((10 - frintp((Lv / 3))) / 1.5)` — when (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND WeaponType eq 14
- set `CastTime` = `((10 - frintp((Lv / 3))) * 0.5)` — when (mainWeapon==Bow & 1) ne 0 OR (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND WeaponType eq 12 AND WeaponType ne 14
- set `CastTime` = `(10 - frintp((Lv / 3)))` — when (mainWeapon==Bow & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND WeaponType ne 12 AND WeaponType ne 14

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

</details>

---
