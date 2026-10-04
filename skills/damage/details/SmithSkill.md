# スミススキル (`SmithSkill`) — skill details

23 entries.

### แปรรูปวัตถุดิบ (MaterialCraft) · uid 353

<img src="../../icons/sk_353.png" width="40" alt="icon"> 
**Tree:** スミススキル (`SmithSkill`, tier 1) · **Type:** Extra · **Max Lv:** 25 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem

> แปรรูปวัตถุดิบด้วยตัวเอง
> อัตราความสำเร็จจะเพิ่มขึ้นตามเลเวล
> เป็นสกิลพื้นฐานร่วมกันระหว่างสกิลเล่นแร่แปรธาตุและสกิลช่างตีเหล็ก 

**How it works**

- Extra skill of the スミススキル tree (tier 1, max Lv 25); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Client status: **consumer-only** — crafting skill read by client code (rate/limit/unlock, see page).
- Other client code reads this skill (2 lookups; see the last section).

**Where else this skill takes effect**

- Code that reads this skill's level / buff by constant id: `SmithProcessingDialog$$UpdateTotal (GetSkillLv)`, `UILibraryList$$getNextReleaseSkillCount (GetSkillLv)`

_Raw recovered data (every method item): [trees/SmithSkill.md](../trees/SmithSkill.md) — uid 353_

---

### ทั่งตีเหล็กส่วนตัว (BeginnerAnvil) · uid 354

<img src="../../icons/sk_354.png" width="40" alt="icon"> 
**Tree:** スミススキル (`SmithSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 25 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ถลุงอุปกรณ์ · **Flags:** NoMarketSearch

> เพิ่มขีดจำกัดระดับความเชี่ยวชาญของการตีเหล็ก
> ถึงแม้ไม่มีสกิลนี้ก็สามารถเพิ่มระดับความเชี่ยวชาญได้ถึง LV50
> 
> เมื่อถึง LV10 ขีดจำกัดสูงสุดจะเพิ่มขึ้นเท่ากับ LVCAP

**How it works**

- Mastery skill of the スミススキル tree (tier 1, max Lv 25); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **consumer-only** — crafting skill read by client code (rate/limit/unlock, see page).
- Its effect is applied by client code: `ProficiencyManager$$getBlackSmithLimitIncreaseBySkill` (formulas in the last section).
- Other client code reads this skill (1 lookup; see the last section).

**Where else this skill takes effect**

- Effect applied in `ProficiencyManager$$getBlackSmithLimitIncreaseBySkill` (2 guarded paths):
  - when `SkillLv(354) gt 0`
    - returns `(GetValue.out2() * ((SkillLv(354) + (SkillLv(354) << 2)) + 50))`
    - calls `Singleton<object>$$get_Instance`, `FunctionLimitManager$$GetValue`
  - when `SkillLv(354) le 0`
    - returns `DefaultBlackSmithLimit`
- Code that reads this skill's level / buff by constant id: `ProficiencyManager$$getBlackSmithLimitIncreaseBySkill (GetSkillLv)`

_Raw recovered data (every method item): [trees/SmithSkill.md](../trees/SmithSkill.md) — uid 354_

---

### ถลุงอุปกรณ์ (RefiningEquipment) · uid 358

<img src="../../icons/sk_358.png" width="40" alt="icon"> 
**Tree:** スミススキル (`SmithSkill`, tier 1) · **Type:** Extra · **Max Lv:** 25 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** NoMarketSearch

> ถลุงอุปกรณ์ด้วยตัวเอง
> ถึงแม้จะมีอัตราความสำเร็จต่ำกว่าการถลุงที่ร้านตีเหล็ก
> แต่ก็ประหยัดเพราะไม่ต้องใช้สปินา

**How it works**

- Extra skill of the スミススキル tree (tier 1, max Lv 25); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Client status: **no-client-code** — crafting/merchant: effect is server-side (text only).

_Raw recovered data (every method item): [trees/SmithSkill.md](../trees/SmithSkill.md) — uid 358_

---

### สร้างอุปกรณ์ (EquipmentProduction) · uid 362

<img src="../../icons/sk_362.png" width="40" alt="icon"> 
**Tree:** スミススキル (`SmithSkill`, tier 1) · **Type:** Extra · **Max Lv:** 50 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ถลุงอุปกรณ์ · **Flags:** NoMarketSearch

> สร้างอุปกรณ์ด้วยตัวเอง
> การเพิ่มค่าความสามารถของอุปกรณ์ที่สร้างเสร็จ
> จำเป็นต้องใช้สกิล[อัพเกรดอุปกรณ์]

**How it works**

- Extra skill of the スミススキル tree (tier 1, max Lv 50); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Client status: **no-client-code** — crafting/merchant: effect is server-side (text only).

_Raw recovered data (every method item): [trees/SmithSkill.md](../trees/SmithSkill.md) — uid 362_

---

### อัพเกรดอุปกรณ์ (EnhanceEquipment) · uid 365

<img src="../../icons/sk_365.png" width="40" alt="icon"> 
**Tree:** スミススキル (`SmithSkill`, tier 1) · **Type:** Extra · **Max Lv:** 50 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** สร้างอุปกรณ์ · **Flags:** NoMarketSearch

> ใช้ศักยภาพเพื่อเพิ่มประสิทธิภาพของอุปกรณ์
> ที่สร้างสำเร็จด้วยสกิล[สร้างอุปกรณ์]

**How it works**

- Extra skill of the スミススキル tree (tier 1, max Lv 50); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Client status: **consumer-only** — crafting skill read by client code (rate/limit/unlock, see page).
- Its effect is applied by client code: `SmithGrant$$getSuccessSkillRate`, `SmithGrantInfoWindow$$getEnhanceMax` (formulas in the last section).
- Other client code reads this skill (3 lookups; see the last section).

**Where else this skill takes effect**

- Effect applied in `SmithGrant$$getSuccessSkillRate` (1 guarded path):
  - always
    - returns `(((SkillLv(366) gt 0 ? (SkillLv(366) + 10) : 0) + max(SkillLv(365), 0)) + (SkillLv(367) gt 0 ? (SkillLv(367) + 20) : 0))`
    - calls `PlayerDataManager$$get_SkillManager`
- Effect applied in `SmithGrantInfoWindow$$getEnhanceMax` (2 guarded paths):
  - always
    - returns `System.Math.Max(1, System.Math.Min(System.Math.Min(int(((((((max(SkillLv(365), 0) + (max(SkillLv(365), 0) << 1)) + 10) + (max(SkillLv(366), 0) + (max(SkillLv(366), 0) << 1))) + (max(SkillLv(367), 0) + (max(SkillLv(367), 0) << 1))) / 100) * ?stack)), (?blr // 10), 0, ?x3), ?stack, 0, ?x3), 0, ?x3)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `0x165d8dc`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_UnTargetDist`, `System.Math$$Min`, `System.Math$$Min`, `System.Math$$Max`
  - always
    - returns `System.Math.Max(1, System.Math.Min(System.Math.Min(int(((((((max(SkillLv(365), 0) + (max(SkillLv(365), 0) << 1)) + 10) + (max(SkillLv(366), 0) + (max(SkillLv(366), 0) << 1))) + (max(SkillLv(367), 0) + (max(SkillLv(367), 0) << 1))) / 100) * ?stack)), (?blr // 10), 0, ?x3), ?stack, 0, ?x3), 0, ?x3)`
    - calls `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_UnTargetDist`, `System.Math$$Min`, `System.Math$$Min`, `System.Math$$Max`
- Code that reads this skill's level / buff by constant id: `SmithGrant$$getSuccessSkillRate (GetSkillLv)`, `SmithGrant$$getUsableSlotCount (GetSkillLv)`, `SmithGrantInfoWindow$$getEnhanceMax (GetSkillLv)`

_Raw recovered data (every method item): [trees/SmithSkill.md](../trees/SmithSkill.md) — uid 365_

---

### ทั่งช่างฝีมือ (CraftsmanAnvil) · uid 355

<img src="../../icons/sk_355.png" width="40" alt="icon"> 
**Tree:** スミススキル (`SmithSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 50 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ทั่งตีเหล็กส่วนตัว · **Flags:** NoMarketSearch

> ลดวัตถุดิบที่จำเป็นสำหรับอัพเกรดอุปกรณ์

**How it works**

- Mastery skill of the スミススキル tree (tier 2, max Lv 50); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **no-client-code** — crafting/merchant: effect is server-side (text only).

_Raw recovered data (every method item): [trees/SmithSkill.md](../trees/SmithSkill.md) — uid 355_

---

### ถลุงระดับกลาง (IntermediateRefining) · uid 359

<img src="../../icons/sk_359.png" width="40" alt="icon"> 
**Tree:** スミススキル (`SmithSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 50 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ถลุงอุปกรณ์ · **Flags:** NoMarketSearch

> เพิ่มอัตราความสำเร็จให้สกิล[ถลุงอุปกรณ์]เล็กน้อย

**How it works**

- Mastery skill of the スミススキル tree (tier 2, max Lv 50); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **no-client-code** — crafting/merchant: effect is server-side (text only).

_Raw recovered data (every method item): [trees/SmithSkill.md](../trees/SmithSkill.md) — uid 359_

---

### สร้างอย่างระวัง · uid 363

<img src="../../icons/sk_363.png" width="40" alt="icon"> 
**Tree:** スミススキル (`SmithSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 100 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** สร้างอุปกรณ์ · **Flags:** NoMarketSearch

> เพิ่มศักยภาพอุปกรณ์ที่สร้างสำเร็จ
> ด้วยสกิล[สร้างอุปกรณ์]

**How it works**

- Mastery skill of the スミススキル tree (tier 2, max Lv 100); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **no-client-code** — crafting/merchant: effect is server-side (text only).

_Raw recovered data (every method item): [trees/SmithSkill.md](../trees/SmithSkill.md) — uid 363_

---

### ทั่งช่างตีเหล็ก (BlacksmithAnvil) · uid 356

<img src="../../icons/sk_356.png" width="40" alt="icon"> 
**Tree:** スミススキル (`SmithSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 100 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ทั่งช่างฝีมือ · **Flags:** NoMarketSearch

> ลดวัตถุดิบที่จำเป็นสำหรับอัพเกรดอุปกรณ์

**How it works**

- Mastery skill of the スミススキル tree (tier 3, max Lv 100); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **no-client-code** — crafting/merchant: effect is server-side (text only).

_Raw recovered data (every method item): [trees/SmithSkill.md](../trees/SmithSkill.md) — uid 356_

---

### ถลุงระดับสูง (AdvancedRefining) · uid 360

<img src="../../icons/sk_360.png" width="40" alt="icon"> 
**Tree:** スミススキル (`SmithSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 100 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ถลุงระดับกลาง · **Flags:** NoMarketSearch

> เพิ่มอัตราความสำเร็จให้สกิล[ถลุงอุปกรณ์]

**How it works**

- Mastery skill of the スミススキル tree (tier 3, max Lv 100); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **no-client-code** — crafting/merchant: effect is server-side (text only).

_Raw recovered data (every method item): [trees/SmithSkill.md](../trees/SmithSkill.md) — uid 360_

---

### อัพเกรดอย่างเที่ยงตรง (ExactEnhance) · uid 366

<img src="../../icons/sk_366.png" width="40" alt="icon"> 
**Tree:** スミススキル (`SmithSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 100 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** อัพเกรดอุปกรณ์ · **Flags:** NoMarketSearch

> เพิ่มอัตราความสำเร็จ[สกิลอัพเกรด]ขึ้นเล็กน้อย
> ช่องความสามารถที่ใช้ได้จะเพิ่มขึ้น

**How it works**

- Mastery skill of the スミススキル tree (tier 3, max Lv 100); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **consumer-only** — crafting skill read by client code (rate/limit/unlock, see page).
- Its effect is applied by client code: `SmithGrant$$getSuccessSkillRate`, `SmithGrant$$getUsableSlotCount`, `SmithGrantInfoWindow$$getEnhanceMax` (formulas in the last section).
- Other client code reads this skill (3 lookups; see the last section).

**Where else this skill takes effect**

- Effect applied in `SmithGrant$$getSuccessSkillRate` (1 guarded path):
  - always
    - returns `(((SkillLv(366) gt 0 ? (SkillLv(366) + 10) : 0) + max(SkillLv(365), 0)) + (SkillLv(367) gt 0 ? (SkillLv(367) + 20) : 0))`
    - calls `PlayerDataManager$$get_SkillManager`
- Effect applied in `SmithGrant$$getUsableSlotCount` (1 guarded path):
  - always
    - returns `(int(((SkillLv(367) + 4) * 0.2)) + (int(frintm(((SkillLv(366) + 2) * 0.3))) + 3))`
    - calls `PlayerDataManager$$get_SkillManager`
- Effect applied in `SmithGrantInfoWindow$$getEnhanceMax` (2 guarded paths):
  - always
    - returns `System.Math.Max(1, System.Math.Min(System.Math.Min(int(((((((max(SkillLv(365), 0) + (max(SkillLv(365), 0) << 1)) + 10) + (max(SkillLv(366), 0) + (max(SkillLv(366), 0) << 1))) + (max(SkillLv(367), 0) + (max(SkillLv(367), 0) << 1))) / 100) * ?stack)), (?blr // 10), 0, ?x3), ?stack, 0, ?x3), 0, ?x3)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `0x165d8dc`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_UnTargetDist`, `System.Math$$Min`, `System.Math$$Min`, `System.Math$$Max`
  - always
    - returns `System.Math.Max(1, System.Math.Min(System.Math.Min(int(((((((max(SkillLv(365), 0) + (max(SkillLv(365), 0) << 1)) + 10) + (max(SkillLv(366), 0) + (max(SkillLv(366), 0) << 1))) + (max(SkillLv(367), 0) + (max(SkillLv(367), 0) << 1))) / 100) * ?stack)), (?blr // 10), 0, ?x3), ?stack, 0, ?x3), 0, ?x3)`
    - calls `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_UnTargetDist`, `System.Math$$Min`, `System.Math$$Min`, `System.Math$$Max`
- Code that reads this skill's level / buff by constant id: `SmithGrant$$getSuccessSkillRate (GetSkillLv)`, `SmithGrant$$getUsableSlotCount (GetSkillLv)`, `SmithGrantInfoWindow$$getEnhanceMax (GetSkillLv)`

_Raw recovered data (every method item): [trees/SmithSkill.md](../trees/SmithSkill.md) — uid 366_

---

### ทั่งมาสเตอร์ (MasterAnvil) · uid 357

<img src="../../icons/sk_357.png" width="40" alt="icon"> 
**Tree:** スミススキル (`SmithSkill`, tier 4) · **Type:** Mastery · **Max Lv:** 200 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ทั่งช่างตีเหล็ก · **Flags:** NoMarketSearch

> ลดวัตถุดิบที่จำเป็นสำหรับอัพเกรดอุปกรณ์

**How it works**

- Mastery skill of the スミススキル tree (tier 4, max Lv 200); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **no-client-code** — crafting/merchant: effect is server-side (text only).

_Raw recovered data (every method item): [trees/SmithSkill.md](../trees/SmithSkill.md) — uid 357_

---

### ถลุงระดับมืออาชีพ (MastersRefining) · uid 361

<img src="../../icons/sk_361.png" width="40" alt="icon"> 
**Tree:** スミススキル (`SmithSkill`, tier 4) · **Type:** Mastery · **Max Lv:** 200 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ถลุงระดับสูง · **Flags:** NoMarketSearch

> เพิ่มอัตราความสำเร็จให้สกิล[ถลุงอุปกรณ์]พอสมควร

**How it works**

- Mastery skill of the スミススキル tree (tier 4, max Lv 200); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **no-client-code** — crafting/merchant: effect is server-side (text only).

_Raw recovered data (every method item): [trees/SmithSkill.md](../trees/SmithSkill.md) — uid 361_

---

### สร้างแบบมืออาชีพ · uid 364

<img src="../../icons/sk_364.png" width="40" alt="icon"> 
**Tree:** スミススキル (`SmithSkill`, tier 4) · **Type:** Mastery · **Max Lv:** 200 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** สร้างอย่างระวัง · **Flags:** NoMarketSearch

> เพิ่มศักยภาพอุปกรณ์ที่สร้างสำเร็จ
> ด้วยสกิล[สร้างอุปกรณ์]ให้มากขึ้น

**How it works**

- Mastery skill of the スミススキル tree (tier 4, max Lv 200); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **no-client-code** — crafting/merchant: effect is server-side (text only).

_Raw recovered data (every method item): [trees/SmithSkill.md](../trees/SmithSkill.md) — uid 364_

---

### อัพเกรดแบบมืออาชีพ (MastersEnhance) · uid 367

<img src="../../icons/sk_367.png" width="40" alt="icon"> 
**Tree:** スミススキル (`SmithSkill`, tier 4) · **Type:** Mastery · **Max Lv:** 200 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** อัพเกรดอย่างเที่ยงตรง · **Flags:** NoMarketSearch

> เพิ่มอัตราความสำเร็จของ[สกิลอัพเกรด]
> และช่องความสามารถที่ใช้ได้จะเพิ่มขึ้น

**How it works**

- Mastery skill of the スミススキル tree (tier 4, max Lv 200); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **consumer-only** — crafting skill read by client code (rate/limit/unlock, see page).
- Its effect is applied by client code: `SmithGrant$$getSuccessSkillRate`, `SmithGrant$$getUsableSlotCount`, `SmithGrantInfoWindow$$getEnhanceMax` (formulas in the last section).
- Other client code reads this skill (3 lookups; see the last section).

**Where else this skill takes effect**

- Effect applied in `SmithGrant$$getSuccessSkillRate` (1 guarded path):
  - always
    - returns `(((SkillLv(366) gt 0 ? (SkillLv(366) + 10) : 0) + max(SkillLv(365), 0)) + (SkillLv(367) gt 0 ? (SkillLv(367) + 20) : 0))`
    - calls `PlayerDataManager$$get_SkillManager`
- Effect applied in `SmithGrant$$getUsableSlotCount` (1 guarded path):
  - always
    - returns `(int(((SkillLv(367) + 4) * 0.2)) + (int(frintm(((SkillLv(366) + 2) * 0.3))) + 3))`
    - calls `PlayerDataManager$$get_SkillManager`
- Effect applied in `SmithGrantInfoWindow$$getEnhanceMax` (2 guarded paths):
  - always
    - returns `System.Math.Max(1, System.Math.Min(System.Math.Min(int(((((((max(SkillLv(365), 0) + (max(SkillLv(365), 0) << 1)) + 10) + (max(SkillLv(366), 0) + (max(SkillLv(366), 0) << 1))) + (max(SkillLv(367), 0) + (max(SkillLv(367), 0) << 1))) / 100) * ?stack)), (?blr // 10), 0, ?x3), ?stack, 0, ?x3), 0, ?x3)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `0x165d8dc`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_UnTargetDist`, `System.Math$$Min`, `System.Math$$Min`, `System.Math$$Max`
  - always
    - returns `System.Math.Max(1, System.Math.Min(System.Math.Min(int(((((((max(SkillLv(365), 0) + (max(SkillLv(365), 0) << 1)) + 10) + (max(SkillLv(366), 0) + (max(SkillLv(366), 0) << 1))) + (max(SkillLv(367), 0) + (max(SkillLv(367), 0) << 1))) / 100) * ?stack)), (?blr // 10), 0, ?x3), ?stack, 0, ?x3), 0, ?x3)`
    - calls `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_UnTargetDist`, `System.Math$$Min`, `System.Math$$Min`, `System.Math$$Max`
- Code that reads this skill's level / buff by constant id: `SmithGrant$$getSuccessSkillRate (GetSkillLv)`, `SmithGrant$$getUsableSlotCount (GetSkillLv)`, `SmithGrantInfoWindow$$getEnhanceMax (GetSkillLv)`

_Raw recovered data (every method item): [trees/SmithSkill.md](../trees/SmithSkill.md) — uid 367_

---

### ทั่งมาสเตอร์II (MasterAnvil2) · uid 368

<img src="../../icons/sk_368.png" width="40" alt="icon"> 
**Tree:** スミススキル (`SmithSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ทั่งมาสเตอร์ · **Flags:** NoMarketSearch

> ลดวัตถุดิบที่จำเป็นสำหรับอัพเกรดอุปกรณ์

**How it works**

- Mastery skill of the スミススキル tree (tier 5, max Lv 250); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **no-client-code** — crafting/merchant: effect is server-side (text only).

_Raw recovered data (every method item): [trees/SmithSkill.md](../trees/SmithSkill.md) — uid 368_

---

### อัพเกรดแบบมืออาชีพII (MastersEnhance2) · uid 369

<img src="../../icons/sk_369.png" width="40" alt="icon"> 
**Tree:** スミススキル (`SmithSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** อัพเกรดแบบมืออาชีพ · **Flags:** NoMarketSearch

> มีโอกาสที่สกิล[อัพเกรดอุปกรณ์]จะไม่เปลี่ยนแปลง
> แม้ว่าช่องความสามารถแรกจะล้มเหลว

**How it works**

- Mastery skill of the スミススキル tree (tier 5, max Lv 250); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **no-client-code** — crafting/merchant: effect is server-side (text only).

_Raw recovered data (every method item): [trees/SmithSkill.md](../trees/SmithSkill.md) — uid 369_

---

### ความเข้าใจโลหะ (MetalUnderstand) · uid 370

<img src="../../icons/sk_370.png" width="40" alt="icon"> 
**Tree:** スミススキル (`SmithSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** NoMarketSearch

> ลดพ้อยท์วัตถุดิบโลหะที่ใช้โดยสกิล[อัพเกรดอุปกรณ์]

**How it works**

- Mastery skill of the スミススキル tree (tier 5, max Lv 250); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **no-client-code** — crafting/merchant: effect is server-side (text only).

_Raw recovered data (every method item): [trees/SmithSkill.md](../trees/SmithSkill.md) — uid 370_

---

### ความเข้าใจผ้า (ClothUnderstand) · uid 371

<img src="../../icons/sk_371.png" width="40" alt="icon"> 
**Tree:** スミススキル (`SmithSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** NoMarketSearch

> ลดพ้อยท์วัตถุดิบผ้าที่ใช้โดยสกิล[อัพเกรดอุปกรณ์]

**How it works**

- Mastery skill of the スミススキル tree (tier 5, max Lv 250); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **no-client-code** — crafting/merchant: effect is server-side (text only).

_Raw recovered data (every method item): [trees/SmithSkill.md](../trees/SmithSkill.md) — uid 371_

---

### ความเข้าอสูร (BeastUnderstand) · uid 372

<img src="../../icons/sk_372.png" width="40" alt="icon"> 
**Tree:** スミススキル (`SmithSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** NoMarketSearch

> ลดพ้อยท์วัตถุดิบอสูรที่ใช้โดยสกิล[อัพเกรดอุปกรณ์]

**How it works**

- Mastery skill of the スミススキル tree (tier 5, max Lv 250); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **no-client-code** — crafting/merchant: effect is server-side (text only).

_Raw recovered data (every method item): [trees/SmithSkill.md](../trees/SmithSkill.md) — uid 372_

---

### ความเข้าไม้ (WoodUnderstand) · uid 373

<img src="../../icons/sk_373.png" width="40" alt="icon"> 
**Tree:** スミススキル (`SmithSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** NoMarketSearch

> ลดพ้อยท์วัตถุดิบไม้ที่ใช้โดยสกิล[อัพเกรดอุปกรณ์]

**How it works**

- Mastery skill of the スミススキル tree (tier 5, max Lv 250); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **no-client-code** — crafting/merchant: effect is server-side (text only).

_Raw recovered data (every method item): [trees/SmithSkill.md](../trees/SmithSkill.md) — uid 373_

---

### ความเข้ายา (DrugUnderstand) · uid 374

<img src="../../icons/sk_374.png" width="40" alt="icon"> 
**Tree:** スミススキル (`SmithSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** NoMarketSearch

> ลดพ้อยท์วัตถุดิบยาที่ใช้โดยสกิล[อัพเกรดอุปกรณ์]

**How it works**

- Mastery skill of the スミススキル tree (tier 5, max Lv 250); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **no-client-code** — crafting/merchant: effect is server-side (text only).

_Raw recovered data (every method item): [trees/SmithSkill.md](../trees/SmithSkill.md) — uid 374_

---

### ความเข้ามานา (MagicUnderstand) · uid 375

<img src="../../icons/sk_375.png" width="40" alt="icon"> 
**Tree:** スミススキル (`SmithSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** NoMarketSearch

> ลดพ้อยท์วัตถุดิบมานาที่ใช้โดยสกิล[อัพเกรดอุปกรณ์]

**How it works**

- Mastery skill of the スミススキル tree (tier 5, max Lv 250); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **consumer-only** — crafting skill read by client code (rate/limit/unlock, see page).
- Other client code reads this skill (1 lookup; see the last section).

**Where else this skill takes effect**

- Code that reads this skill's level / buff by constant id: `SmithGrantInfoWindow$$CalcUnderstandSkill (GetSkillLv)`

_Raw recovered data (every method item): [trees/SmithSkill.md](../trees/SmithSkill.md) — uid 375_

---
