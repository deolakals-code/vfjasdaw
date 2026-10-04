# アルケミースキル (`AlchemySkill`) — skill details

19 entries.

### 385 · uid 385

<img src="../../icons/sk_385.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 1) · **Type:** Extra · **Max Lv:** 25 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana

**How it works**

- Extra skill of the アルケミースキル tree (tier 1, max Lv 25); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Client status: **no-client-code** — crafting/merchant: effect is server-side (text only).

_Raw recovered data (every method item): [trees/AlchemySkill.md](../trees/AlchemySkill.md) — uid 385_

---

### ขวดยามือใหม่ (BeginnersPhial) · uid 386

<img src="../../icons/sk_386.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 1) · **Type:** Mastery · **Max Lv:** 25 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ผสมไอเท็ม · **Flags:** NoMarketSearch

> เพิ่มขีดจำกัดระดับความเชี่ยวชาญของการผสม
> ถึงแม้ไม่มีสกิลนี้ก็สามารถเพิ่มระดับความเชี่ยวชาญได้ถึง LV50

**How it works**

- Mastery skill of the アルケミースキル tree (tier 1, max Lv 25); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **no-client-code** — crafting/merchant: effect is server-side (text only).

_Raw recovered data (every method item): [trees/AlchemySkill.md](../trees/AlchemySkill.md) — uid 386_

---

### ผสมไอเท็ม (CreateMedicine) · uid 390

<img src="../../icons/sk_390.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 1) · **Type:** Extra · **Max Lv:** 25 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** NoMarketSearch

> [ผสมไอเท็ม]ด้วยตัวเอง
> ถึงแม้จะมีอัตราความสำเร็จต่ำกว่าการผสมที่ร้านผสมของ
> แต่ก็ประหยัดเพราะไม่ต้องใช้สปินา

**How it works**

- Extra skill of the アルケミースキル tree (tier 1, max Lv 25); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Client status: **no-client-code** — crafting/merchant: effect is server-side (text only).

_Raw recovered data (every method item): [trees/AlchemySkill.md](../trees/AlchemySkill.md) — uid 390_

---

### ขวดยาช่างฝีมือ (CraftsmanPhial) · uid 387

<img src="../../icons/sk_387.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 2) · **Type:** Mastery · **Max Lv:** 50 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ขวดยามือใหม่ · **Flags:** NoMarketSearch

> เพิ่มขีดจำกัดระดับความเชี่ยวชาญของการผสม
> เพิ่มได้ 5 ต่อ 1 สกิลเลเวล

**How it works**

- Mastery skill of the アルケミースキル tree (tier 2, max Lv 50); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **no-client-code** — crafting/merchant: effect is server-side (text only).

_Raw recovered data (every method item): [trees/AlchemySkill.md](../trees/AlchemySkill.md) — uid 387_

---

### ผสมระดับกลาง (IntermediateMedicine) · uid 391

<img src="../../icons/sk_391.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 2) · **Type:** Mastery · **Max Lv:** 50 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ผสมไอเท็ม · **Flags:** NoMarketSearch

> เพิ่มอัตราความสำเร็จให้สกิล "ผสมไอเท็ม" เล็กน้อย

**How it works**

- Mastery skill of the アルケミースキル tree (tier 2, max Lv 50); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **consumer-only** — crafting skill read by client code (rate/limit/unlock, see page).
- Other client code reads this skill (1 lookup; see the last section).

**Where else this skill takes effect**

- Code that reads this skill's level / buff by constant id: `SyntheticMedicine$$getMaterialRate (GetSkillLv)`

_Raw recovered data (every method item): [trees/AlchemySkill.md](../trees/AlchemySkill.md) — uid 391_

---

### ผสมอุปกรณ์ (SynthesizeEquip) · uid 394

<img src="../../icons/sk_394.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 2) · **Type:** Extra · **Max Lv:** 50 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ผสมไอเท็ม · **Flags:** NoMarketSearch

> [ผสมอุปกรณ์]ด้วยตัวเอง
> ถึงแม้จะมีอัตราความสำเร็จต่ำกว่าการผสมที่ร้านผสมของ
> แต่ก็ประหยัดเพราะไม่ต้องใช้สปินา

**How it works**

- Extra skill of the アルケミースキル tree (tier 2, max Lv 50); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Client status: **consumer-only** — crafting skill read by client code (rate/limit/unlock, see page).
- Its effect is applied by client code: `SyntheticEquip$$getRate` (formulas in the last section).
- Other client code reads this skill (2 lookups; see the last section).

**Where else this skill takes effect**

- Effect applied in `SyntheticEquip$$getRate` (1 guarded path):
  - when `(ShopId & 0x80000000) ne 0`
    - returns `(int((((((((max(SkillLv(394), 0) * 10) + 50) + (max(SkillLv(395), 0) * 15)) + (max(SkillLv(396), 0) * 20)) + (max(SkillLv(402), 0) * 20)) + (IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()) + IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()))) / max(((SyntheticEquip.getLockCount(this, ?mi, ?x2, ?x3) * 0.5) * SyntheticEquip.getLockCount(this, ?mi, ?x2, ?x3)), 1))) lt 100 ? int((((((((max(SkillLv(394), 0) * 10) + 50) + (max(SkillLv(395), 0) * 15)) + (max(SkillLv(396), 0) * 20)) + (max(SkillLv(402), 0) * 20)) + (IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()) + IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()))) / max(((SyntheticEquip.getLockCount(this, ?m`
    - calls `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_UnTargetDist`, `interface IPlayerStatusCalculator.get_Tec`, `SyntheticEquip$$getLockCount`
- Code that reads this skill's level / buff by constant id: `SyntheticEquip$$getRate (GetSkillLv)`, `UIStockColorCreatePanel$$GetPrintSuccessRate (GetSkillLv)`

_Raw recovered data (every method item): [trees/AlchemySkill.md](../trees/AlchemySkill.md) — uid 394_

---

### การสังเคราะห์สี (ColorSynthesis) · uid 403

<img src="../../icons/sk_403.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 2) · **Type:** Extra · **Max Lv:** 50 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ผสมไอเท็ม · **Flags:** NoMarketSearch

> สามารถใช้อัญมณีและสปินาที่ได้รับจากวงกตนิรันดร์
> เพื่อสร้างอุปกรณ์ที่มีสีย้อมได้
> 
> อัตราความสำเร็จจะเพิ่มขึ้นตามเลเวลสกิล
> และจำนวนสปินาที่ต้องใช้สำหรับอุปกรณ์เสริมจะลดลง

**How it works**

- Extra skill of the アルケミースキル tree (tier 2, max Lv 50); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Client status: **consumer-only** — crafting skill read by client code (rate/limit/unlock, see page).
- Other client code reads this skill (1 lookup; see the last section).

**Where else this skill takes effect**

- Code that reads this skill's level / buff by constant id: `UIColorSynthesisMainManager$$GetColorSkillLevels (GetSkillLv)`

_Raw recovered data (every method item): [trees/AlchemySkill.md](../trees/AlchemySkill.md) — uid 403_

---

### ขวดยาช่างผสมของ (AlchemyPhial) · uid 388

<img src="../../icons/sk_388.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 3) · **Type:** Mastery · **Max Lv:** 100 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ขวดยาช่างฝีมือ · **Flags:** NoMarketSearch

> เพิ่มขีดจำกัดระดับความเชี่ยวชาญของการผสม
> เพิ่มได้ 5 ต่อ 1 สกิลเลเวล

**How it works**

- Mastery skill of the アルケミースキル tree (tier 3, max Lv 100); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **no-client-code** — crafting/merchant: effect is server-side (text only).

_Raw recovered data (every method item): [trees/AlchemySkill.md](../trees/AlchemySkill.md) — uid 388_

---

### ผสมระดับสูง (AdvancedMedicine) · uid 392

<img src="../../icons/sk_392.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 3) · **Type:** Mastery · **Max Lv:** 100 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ผสมระดับกลาง · **Flags:** NoMarketSearch

> เพิ่มอัตราความสำเร็จให้สกิล "ผสมไอเท็ม"

**How it works**

- Mastery skill of the アルケミースキル tree (tier 3, max Lv 100); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **consumer-only** — crafting skill read by client code (rate/limit/unlock, see page).
- Other client code reads this skill (1 lookup; see the last section).

**Where else this skill takes effect**

- Code that reads this skill's level / buff by constant id: `SyntheticMedicine$$getMaterialRate (GetSkillLv)`

_Raw recovered data (every method item): [trees/AlchemySkill.md](../trees/AlchemySkill.md) — uid 392_

---

### เทคนิคการผสม I (SynthesisTechnologyImprovement1) · uid 395

<img src="../../icons/sk_395.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 3) · **Type:** Mastery · **Max Lv:** 100 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ผสมอุปกรณ์ · **Flags:** NoMarketSearch

> เพิ่มอัตราความสำเร็จให้สกิล “ผสมอุปกรณ์”
> และสามารถใช้ EX สกิลใหม่ ”บันทึกสีย้อม” ได้

**How it works**

- Mastery skill of the アルケミースキル tree (tier 3, max Lv 100); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **consumer-only** — crafting skill read by client code (rate/limit/unlock, see page).
- Its effect is applied by client code: `SyntheticEquip$$getRate` (formulas in the last section).
- Other client code reads this skill (3 lookups; see the last section).

**Where else this skill takes effect**

- Effect applied in `SyntheticEquip$$getRate` (1 guarded path):
  - when `(ShopId & 0x80000000) ne 0`
    - returns `(int((((((((max(SkillLv(394), 0) * 10) + 50) + (max(SkillLv(395), 0) * 15)) + (max(SkillLv(396), 0) * 20)) + (max(SkillLv(402), 0) * 20)) + (IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()) + IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()))) / max(((SyntheticEquip.getLockCount(this, ?mi, ?x2, ?x3) * 0.5) * SyntheticEquip.getLockCount(this, ?mi, ?x2, ?x3)), 1))) lt 100 ? int((((((((max(SkillLv(394), 0) * 10) + 50) + (max(SkillLv(395), 0) * 15)) + (max(SkillLv(396), 0) * 20)) + (max(SkillLv(402), 0) * 20)) + (IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()) + IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()))) / max(((SyntheticEquip.getLockCount(this, ?m`
    - calls `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_UnTargetDist`, `interface IPlayerStatusCalculator.get_Tec`, `SyntheticEquip$$getLockCount`
- Code that reads this skill's level / buff by constant id: `SyntheticEquip$$getRate (GetSkillLv)`, `UIColorSynthesisResultPanel$$UpdateStockColorToggle (GetSkillLv)`, `UIStockColorCreatePanel$$GetPrintSuccessRate (GetSkillLv)`

_Raw recovered data (every method item): [trees/AlchemySkill.md](../trees/AlchemySkill.md) — uid 395_

---

### คู่มือการผสมสี (ColorSynthesisGuide1) · uid 404

<img src="../../icons/sk_404.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 3) · **Type:** Mastery · **Max Lv:** 100 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** การสังเคราะห์สี · **Flags:** NoMarketSearch

> EX สกิล “การสังเคราะห์สี” จะสามารถสร้างชุดเกราะได้
> 
> อัตราความสำเร็จจะเพิ่มขึ้นตามเลเวลสกิล
> และจำนวนสปินาที่ต้องใช้สำหรับชุดเกราะจะลดลง

**How it works**

- Mastery skill of the アルケミースキル tree (tier 3, max Lv 100); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **consumer-only** — crafting skill read by client code (rate/limit/unlock, see page).
- Other client code reads this skill (2 lookups; see the last section).

**Where else this skill takes effect**

- Code that reads this skill's level / buff by constant id: `UIColorSynthesisMainManager$$GetColorSkillLevels (GetSkillLv)`, `UIColorSynthesisSelectEquipPanel$$IsTargetUnlocked (GetSkillLv)`

_Raw recovered data (every method item): [trees/AlchemySkill.md](../trees/AlchemySkill.md) — uid 404_

---

### ขวดยามาสเตอร์ (MasterPhial) · uid 389

<img src="../../icons/sk_389.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 4) · **Type:** Mastery · **Max Lv:** 200 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ขวดยาช่างผสมของ · **Flags:** NoMarketSearch

> เพิ่มขีดจำกัดระดับความเชี่ยวชาญของการผสม
> เพิ่มได้ 5 ต่อ 1 สกิลเลเวล

**How it works**

- Mastery skill of the アルケミースキル tree (tier 4, max Lv 200); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **no-client-code** — crafting/merchant: effect is server-side (text only).

_Raw recovered data (every method item): [trees/AlchemySkill.md](../trees/AlchemySkill.md) — uid 389_

---

### ผสมระดับมืออาชีพ (MastersMedicine) · uid 393

<img src="../../icons/sk_393.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 4) · **Type:** Mastery · **Max Lv:** 200 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ผสมระดับสูง · **Flags:** NoMarketSearch

> เพิ่มอัตราความสำเร็จให้สกิล "ผสมไอเท็ม" พอสมควร

**How it works**

- Mastery skill of the アルケミースキル tree (tier 4, max Lv 200); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **consumer-only** — crafting skill read by client code (rate/limit/unlock, see page).
- Other client code reads this skill (1 lookup; see the last section).

**Where else this skill takes effect**

- Code that reads this skill's level / buff by constant id: `SyntheticMedicine$$getMaterialRate (GetSkillLv)`

_Raw recovered data (every method item): [trees/AlchemySkill.md](../trees/AlchemySkill.md) — uid 393_

---

### เทคนิคการผสม II (SynthesisTechnologyImprovement2) · uid 396

<img src="../../icons/sk_396.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 4) · **Type:** Mastery · **Max Lv:** 200 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เทคนิคการผสม I · **Flags:** NoMarketSearch

> เพิ่มอัตราความสำเร็จให้สกิล[ผสมอุปกรณ์]

**How it works**

- Mastery skill of the アルケミースキル tree (tier 4, max Lv 200); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **consumer-only** — crafting skill read by client code (rate/limit/unlock, see page).
- Its effect is applied by client code: `SyntheticEquip$$getRate` (formulas in the last section).
- Other client code reads this skill (2 lookups; see the last section).

**Where else this skill takes effect**

- Effect applied in `SyntheticEquip$$getRate` (1 guarded path):
  - when `(ShopId & 0x80000000) ne 0`
    - returns `(int((((((((max(SkillLv(394), 0) * 10) + 50) + (max(SkillLv(395), 0) * 15)) + (max(SkillLv(396), 0) * 20)) + (max(SkillLv(402), 0) * 20)) + (IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()) + IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()))) / max(((SyntheticEquip.getLockCount(this, ?mi, ?x2, ?x3) * 0.5) * SyntheticEquip.getLockCount(this, ?mi, ?x2, ?x3)), 1))) lt 100 ? int((((((((max(SkillLv(394), 0) * 10) + 50) + (max(SkillLv(395), 0) * 15)) + (max(SkillLv(396), 0) * 20)) + (max(SkillLv(402), 0) * 20)) + (IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()) + IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()))) / max(((SyntheticEquip.getLockCount(this, ?m`
    - calls `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_UnTargetDist`, `interface IPlayerStatusCalculator.get_Tec`, `SyntheticEquip$$getLockCount`
- Code that reads this skill's level / buff by constant id: `SyntheticEquip$$getRate (GetSkillLv)`, `UIStockColorCreatePanel$$GetPrintSuccessRate (GetSkillLv)`

_Raw recovered data (every method item): [trees/AlchemySkill.md](../trees/AlchemySkill.md) — uid 396_

---

### คู่มือการผสมสีII (ColorSynthesisGuide2) · uid 405

<img src="../../icons/sk_405.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 4) · **Type:** Mastery · **Max Lv:** 200 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** คู่มือการผสมสี · **Flags:** NoMarketSearch

> EX สกิล “การสังเคราะห์สี” จะสามารถสร้างอาวุธได้
> 
> อัตราความสำเร็จจะเพิ่มขึ้นตามเลเวลสกิล
> และจำนวนสปินาที่ต้องใช้สำหรับชุดเกราะจะลดลง

**How it works**

- Mastery skill of the アルケミースキル tree (tier 4, max Lv 200); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **consumer-only** — crafting skill read by client code (rate/limit/unlock, see page).
- Other client code reads this skill (1 lookup; see the last section).

**Where else this skill takes effect**

- Code that reads this skill's level / buff by constant id: `UIColorSynthesisMainManager$$GetColorSkillLevels (GetSkillLv)`

_Raw recovered data (every method item): [trees/AlchemySkill.md](../trees/AlchemySkill.md) — uid 405_

---

### ขวดยามาสเตอร์II (MasterPhial2) · uid 400

<img src="../../icons/sk_400.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 5) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ขวดยามาสเตอร์ · **Flags:** NoMarketSearch

> เพิ่มขีดจำกัดระดับความเชี่ยวชาญของการผสม
> เพิ่มได้ 5 ต่อ 1 สกิลเลเวล
> 
> เมื่อเพิ่มทักษะขวดยา (ทั้งหมด) เป็น LV10
> ความเชี่ยวชาญจะเพิ่มขึ้นจนถึง LVCAP ปัจจุบัน

**How it works**

- Mastery skill of the アルケミースキル tree (tier 5, max Lv 250); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **no-client-code** — crafting/merchant: effect is server-side (text only).

_Raw recovered data (every method item): [trees/AlchemySkill.md](../trees/AlchemySkill.md) — uid 400_

---

### ผสมระดับมืออาชีพII (MastersMedicine2) · uid 401

<img src="../../icons/sk_401.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 5) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ผสมระดับมืออาชีพ · **Flags:** NoMarketSearch

> เพิ่มอัตราความสำเร็จให้สกิล "ผสมไอเท็ม" ระดับพอประมาณ

**How it works**

- Mastery skill of the アルケミースキル tree (tier 5, max Lv 250); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **consumer-only** — crafting skill read by client code (rate/limit/unlock, see page).
- Its effect is applied by client code: `SyntheticMedicine$$getMaterialRate` (formulas in the last section).
- Other client code reads this skill (1 lookup; see the last section).

**Where else this skill takes effect**

- Effect applied in `SyntheticMedicine$$getMaterialRate` (1 guarded path):
  - when `(isShop & 1) eq 0`
    - returns `SkillLv(401)`
    - calls `PlayerDataManager$$get_SkillManager`
- Code that reads this skill's level / buff by constant id: `SyntheticMedicine$$getMaterialRate (GetSkillLv)`

_Raw recovered data (every method item): [trees/AlchemySkill.md](../trees/AlchemySkill.md) — uid 401_

---

### เทคนิคการผสมIII (SynthesisTechnologyImprovement3) · uid 402

<img src="../../icons/sk_402.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 5) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เทคนิคการผสม II · **Flags:** NoMarketSearch

> เพิ่มอัตราความสำเร็จให้สกิล[ผสมอุปกรณ์]

**How it works**

- Mastery skill of the アルケミースキル tree (tier 5, max Lv 250); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **consumer-only** — crafting skill read by client code (rate/limit/unlock, see page).
- Its effect is applied by client code: `SyntheticEquip$$getRate` (formulas in the last section).
- Other client code reads this skill (2 lookups; see the last section).

**Where else this skill takes effect**

- Effect applied in `SyntheticEquip$$getRate` (1 guarded path):
  - when `(ShopId & 0x80000000) ne 0`
    - returns `(int((((((((max(SkillLv(394), 0) * 10) + 50) + (max(SkillLv(395), 0) * 15)) + (max(SkillLv(396), 0) * 20)) + (max(SkillLv(402), 0) * 20)) + (IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()) + IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()))) / max(((SyntheticEquip.getLockCount(this, ?mi, ?x2, ?x3) * 0.5) * SyntheticEquip.getLockCount(this, ?mi, ?x2, ?x3)), 1))) lt 100 ? int((((((((max(SkillLv(394), 0) * 10) + 50) + (max(SkillLv(395), 0) * 15)) + (max(SkillLv(396), 0) * 20)) + (max(SkillLv(402), 0) * 20)) + (IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()) + IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()))) / max(((SyntheticEquip.getLockCount(this, ?m`
    - calls `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_UnTargetDist`, `interface IPlayerStatusCalculator.get_Tec`, `SyntheticEquip$$getLockCount`
- Code that reads this skill's level / buff by constant id: `SyntheticEquip$$getRate (GetSkillLv)`, `UIStockColorCreatePanel$$GetPrintSuccessRate (GetSkillLv)`

_Raw recovered data (every method item): [trees/AlchemySkill.md](../trees/AlchemySkill.md) — uid 402_

---

### คู่มือการผสมสีIII (ColorSynthesisGuide3) · uid 406

<img src="../../icons/sk_406.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 5) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** คู่มือการผสมสีII · **Flags:** NoMarketSearch

> เพิ่มอัตราความสำเร็จของ EX สกิล “การสังเคราะห์สี”
> เมื่อสกิลทั้ง 4 ประเภทที่เกี่ยวข้องกับการสังเคราะห์สีมีเลเวลสูงสุด
> มีโอกาสน้อยนิดที่จะได้รับรางวัลเพิ่มเติม

**How it works**

- Mastery skill of the アルケミースキル tree (tier 5, max Lv 250); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **consumer-only** — crafting skill read by client code (rate/limit/unlock, see page).
- Other client code reads this skill (1 lookup; see the last section).

**Where else this skill takes effect**

- Code that reads this skill's level / buff by constant id: `UIColorSynthesisMainManager$$GetColorSkillLevels (GetSkillLv)`

_Raw recovered data (every method item): [trees/AlchemySkill.md](../trees/AlchemySkill.md) — uid 406_

---
