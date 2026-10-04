# アルケミースキル (`AlchemySkill`)

19 entries. See ../README.md for how to read these blocks.

### 385 · uid 385

<img src="../../icons/sk_385.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 1) · **Type:** Extra · **Max Lv:** 25 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana

**Role:** no client action class (system / production / unreleased)

---

### ขวดยามือใหม่ (BeginnersPhial) · uid 386

<img src="../../icons/sk_386.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 1) · **Type:** Mastery · **Max Lv:** 25 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ผสมไอเท็ม · **Flags:** NoMarketSearch

> เพิ่มขีดจำกัดระดับความเชี่ยวชาญของการผสม
> ถึงแม้ไม่มีสกิลนี้ก็สามารถเพิ่มระดับความเชี่ยวชาญได้ถึง LV50

**Role:** passive mastery · no client action class (system / production / unreleased)

---

### ผสมไอเท็ม (CreateMedicine) · uid 390

<img src="../../icons/sk_390.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 1) · **Type:** Extra · **Max Lv:** 25 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** NoMarketSearch

> [ผสมไอเท็ม]ด้วยตัวเอง
> ถึงแม้จะมีอัตราความสำเร็จต่ำกว่าการผสมที่ร้านผสมของ
> แต่ก็ประหยัดเพราะไม่ต้องใช้สปินา

**Role:** no client action class (system / production / unreleased)

---

### ขวดยาช่างฝีมือ (CraftsmanPhial) · uid 387

<img src="../../icons/sk_387.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 2) · **Type:** Mastery · **Max Lv:** 50 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ขวดยามือใหม่ · **Flags:** NoMarketSearch

> เพิ่มขีดจำกัดระดับความเชี่ยวชาญของการผสม
> เพิ่มได้ 5 ต่อ 1 สกิลเลเวล

**Role:** passive mastery · no client action class (system / production / unreleased)

---

### ผสมระดับกลาง (IntermediateMedicine) · uid 391

<img src="../../icons/sk_391.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 2) · **Type:** Mastery · **Max Lv:** 50 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ผสมไอเท็ม · **Flags:** NoMarketSearch

> เพิ่มอัตราความสำเร็จให้สกิล "ผสมไอเท็ม" เล็กน้อย

**Role:** passive mastery · no client action class (system / production / unreleased)

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `SyntheticMedicine$$getMaterialRate (GetSkillLv)`

---

### ผสมอุปกรณ์ (SynthesizeEquip) · uid 394

<img src="../../icons/sk_394.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 2) · **Type:** Extra · **Max Lv:** 50 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ผสมไอเท็ม · **Flags:** NoMarketSearch

> [ผสมอุปกรณ์]ด้วยตัวเอง
> ถึงแม้จะมีอัตราความสำเร็จต่ำกว่าการผสมที่ร้านผสมของ
> แต่ก็ประหยัดเพราะไม่ต้องใช้สปินา

**Role:** no client action class (system / production / unreleased)

<details><summary>Effect applied in `SyntheticEquip$$getRate` (1 guarded path)</summary>

- when `(ShopId & 0x80000000) ne 0`
  - returns `(int((((((((max(SkillLv(394), 0) * 10) + 50) + (max(SkillLv(395), 0) * 15)) + (max(SkillLv(396), 0) * 20)) + (max(SkillLv(402), 0) * 20)) + (IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()) + IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()))) / max(((SyntheticEquip.getLockCount(this, ?mi, ?x2, ?x3) * 0.5) * SyntheticEquip.getLockCount(this, ?mi, ?x2, ?x3)), 1))) lt 100 ? int((((((((max(SkillLv(394), 0) * 10) + 50) + (max(SkillLv(395), 0) * 15)) + (max(SkillLv(396), 0) * 20)) + (max(SkillLv(402), 0) * 20)) + (IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()) + IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()))) / max(((SyntheticEquip.getLockCount(this, ?m`
  - calls `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_UnTargetDist`, `interface IPlayerStatusCalculator.get_Tec`, `SyntheticEquip$$getLockCount`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `SyntheticEquip$$getRate (GetSkillLv)`
- `UIStockColorCreatePanel$$GetPrintSuccessRate (GetSkillLv)`

---

### การสังเคราะห์สี (ColorSynthesis) · uid 403

<img src="../../icons/sk_403.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 2) · **Type:** Extra · **Max Lv:** 50 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ผสมไอเท็ม · **Flags:** NoMarketSearch

> สามารถใช้อัญมณีและสปินาที่ได้รับจากวงกตนิรันดร์
> เพื่อสร้างอุปกรณ์ที่มีสีย้อมได้
> 
> อัตราความสำเร็จจะเพิ่มขึ้นตามเลเวลสกิล
> และจำนวนสปินาที่ต้องใช้สำหรับอุปกรณ์เสริมจะลดลง

**Role:** no client action class (system / production / unreleased)

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `UIColorSynthesisMainManager$$GetColorSkillLevels (GetSkillLv)`

---

### ขวดยาช่างผสมของ (AlchemyPhial) · uid 388

<img src="../../icons/sk_388.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 3) · **Type:** Mastery · **Max Lv:** 100 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ขวดยาช่างฝีมือ · **Flags:** NoMarketSearch

> เพิ่มขีดจำกัดระดับความเชี่ยวชาญของการผสม
> เพิ่มได้ 5 ต่อ 1 สกิลเลเวล

**Role:** passive mastery · no client action class (system / production / unreleased)

---

### ผสมระดับสูง (AdvancedMedicine) · uid 392

<img src="../../icons/sk_392.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 3) · **Type:** Mastery · **Max Lv:** 100 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ผสมระดับกลาง · **Flags:** NoMarketSearch

> เพิ่มอัตราความสำเร็จให้สกิล "ผสมไอเท็ม"

**Role:** passive mastery · no client action class (system / production / unreleased)

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `SyntheticMedicine$$getMaterialRate (GetSkillLv)`

---

### เทคนิคการผสม I (SynthesisTechnologyImprovement1) · uid 395

<img src="../../icons/sk_395.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 3) · **Type:** Mastery · **Max Lv:** 100 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ผสมอุปกรณ์ · **Flags:** NoMarketSearch

> เพิ่มอัตราความสำเร็จให้สกิล “ผสมอุปกรณ์”
> และสามารถใช้ EX สกิลใหม่ ”บันทึกสีย้อม” ได้

**Role:** passive mastery · no client action class (system / production / unreleased)

<details><summary>Effect applied in `SyntheticEquip$$getRate` (1 guarded path)</summary>

- when `(ShopId & 0x80000000) ne 0`
  - returns `(int((((((((max(SkillLv(394), 0) * 10) + 50) + (max(SkillLv(395), 0) * 15)) + (max(SkillLv(396), 0) * 20)) + (max(SkillLv(402), 0) * 20)) + (IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()) + IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()))) / max(((SyntheticEquip.getLockCount(this, ?mi, ?x2, ?x3) * 0.5) * SyntheticEquip.getLockCount(this, ?mi, ?x2, ?x3)), 1))) lt 100 ? int((((((((max(SkillLv(394), 0) * 10) + 50) + (max(SkillLv(395), 0) * 15)) + (max(SkillLv(396), 0) * 20)) + (max(SkillLv(402), 0) * 20)) + (IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()) + IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()))) / max(((SyntheticEquip.getLockCount(this, ?m`
  - calls `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_UnTargetDist`, `interface IPlayerStatusCalculator.get_Tec`, `SyntheticEquip$$getLockCount`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `SyntheticEquip$$getRate (GetSkillLv)`
- `UIColorSynthesisResultPanel$$UpdateStockColorToggle (GetSkillLv)`
- `UIStockColorCreatePanel$$GetPrintSuccessRate (GetSkillLv)`

---

### คู่มือการผสมสี (ColorSynthesisGuide1) · uid 404

<img src="../../icons/sk_404.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 3) · **Type:** Mastery · **Max Lv:** 100 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** การสังเคราะห์สี · **Flags:** NoMarketSearch

> EX สกิล “การสังเคราะห์สี” จะสามารถสร้างชุดเกราะได้
> 
> อัตราความสำเร็จจะเพิ่มขึ้นตามเลเวลสกิล
> และจำนวนสปินาที่ต้องใช้สำหรับชุดเกราะจะลดลง

**Role:** passive mastery · no client action class (system / production / unreleased)

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `UIColorSynthesisMainManager$$GetColorSkillLevels (GetSkillLv)`
- `UIColorSynthesisSelectEquipPanel$$IsTargetUnlocked (GetSkillLv)`

---

### ขวดยามาสเตอร์ (MasterPhial) · uid 389

<img src="../../icons/sk_389.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 4) · **Type:** Mastery · **Max Lv:** 200 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ขวดยาช่างผสมของ · **Flags:** NoMarketSearch

> เพิ่มขีดจำกัดระดับความเชี่ยวชาญของการผสม
> เพิ่มได้ 5 ต่อ 1 สกิลเลเวล

**Role:** passive mastery · no client action class (system / production / unreleased)

---

### ผสมระดับมืออาชีพ (MastersMedicine) · uid 393

<img src="../../icons/sk_393.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 4) · **Type:** Mastery · **Max Lv:** 200 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ผสมระดับสูง · **Flags:** NoMarketSearch

> เพิ่มอัตราความสำเร็จให้สกิล "ผสมไอเท็ม" พอสมควร

**Role:** passive mastery · no client action class (system / production / unreleased)

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `SyntheticMedicine$$getMaterialRate (GetSkillLv)`

---

### เทคนิคการผสม II (SynthesisTechnologyImprovement2) · uid 396

<img src="../../icons/sk_396.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 4) · **Type:** Mastery · **Max Lv:** 200 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เทคนิคการผสม I · **Flags:** NoMarketSearch

> เพิ่มอัตราความสำเร็จให้สกิล[ผสมอุปกรณ์]

**Role:** passive mastery · no client action class (system / production / unreleased)

<details><summary>Effect applied in `SyntheticEquip$$getRate` (1 guarded path)</summary>

- when `(ShopId & 0x80000000) ne 0`
  - returns `(int((((((((max(SkillLv(394), 0) * 10) + 50) + (max(SkillLv(395), 0) * 15)) + (max(SkillLv(396), 0) * 20)) + (max(SkillLv(402), 0) * 20)) + (IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()) + IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()))) / max(((SyntheticEquip.getLockCount(this, ?mi, ?x2, ?x3) * 0.5) * SyntheticEquip.getLockCount(this, ?mi, ?x2, ?x3)), 1))) lt 100 ? int((((((((max(SkillLv(394), 0) * 10) + 50) + (max(SkillLv(395), 0) * 15)) + (max(SkillLv(396), 0) * 20)) + (max(SkillLv(402), 0) * 20)) + (IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()) + IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()))) / max(((SyntheticEquip.getLockCount(this, ?m`
  - calls `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_UnTargetDist`, `interface IPlayerStatusCalculator.get_Tec`, `SyntheticEquip$$getLockCount`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `SyntheticEquip$$getRate (GetSkillLv)`
- `UIStockColorCreatePanel$$GetPrintSuccessRate (GetSkillLv)`

---

### คู่มือการผสมสีII (ColorSynthesisGuide2) · uid 405

<img src="../../icons/sk_405.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 4) · **Type:** Mastery · **Max Lv:** 200 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** คู่มือการผสมสี · **Flags:** NoMarketSearch

> EX สกิล “การสังเคราะห์สี” จะสามารถสร้างอาวุธได้
> 
> อัตราความสำเร็จจะเพิ่มขึ้นตามเลเวลสกิล
> และจำนวนสปินาที่ต้องใช้สำหรับชุดเกราะจะลดลง

**Role:** passive mastery · no client action class (system / production / unreleased)

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `UIColorSynthesisMainManager$$GetColorSkillLevels (GetSkillLv)`

---

### ขวดยามาสเตอร์II (MasterPhial2) · uid 400

<img src="../../icons/sk_400.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 5) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ขวดยามาสเตอร์ · **Flags:** NoMarketSearch

> เพิ่มขีดจำกัดระดับความเชี่ยวชาญของการผสม
> เพิ่มได้ 5 ต่อ 1 สกิลเลเวล
> 
> เมื่อเพิ่มทักษะขวดยา (ทั้งหมด) เป็น LV10
> ความเชี่ยวชาญจะเพิ่มขึ้นจนถึง LVCAP ปัจจุบัน

**Role:** passive mastery · no client action class (system / production / unreleased)

---

### ผสมระดับมืออาชีพII (MastersMedicine2) · uid 401

<img src="../../icons/sk_401.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 5) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ผสมระดับมืออาชีพ · **Flags:** NoMarketSearch

> เพิ่มอัตราความสำเร็จให้สกิล "ผสมไอเท็ม" ระดับพอประมาณ

**Role:** passive mastery · no client action class (system / production / unreleased)

<details><summary>Effect applied in `SyntheticMedicine$$getMaterialRate` (1 guarded path)</summary>

- when `(isShop & 1) eq 0`
  - returns `SkillLv(401)`
  - calls `PlayerDataManager$$get_SkillManager`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `SyntheticMedicine$$getMaterialRate (GetSkillLv)`

---

### เทคนิคการผสมIII (SynthesisTechnologyImprovement3) · uid 402

<img src="../../icons/sk_402.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 5) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เทคนิคการผสม II · **Flags:** NoMarketSearch

> เพิ่มอัตราความสำเร็จให้สกิล[ผสมอุปกรณ์]

**Role:** passive mastery · no client action class (system / production / unreleased)

<details><summary>Effect applied in `SyntheticEquip$$getRate` (1 guarded path)</summary>

- when `(ShopId & 0x80000000) ne 0`
  - returns `(int((((((((max(SkillLv(394), 0) * 10) + 50) + (max(SkillLv(395), 0) * 15)) + (max(SkillLv(396), 0) * 20)) + (max(SkillLv(402), 0) * 20)) + (IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()) + IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()))) / max(((SyntheticEquip.getLockCount(this, ?mi, ?x2, ?x3) * 0.5) * SyntheticEquip.getLockCount(this, ?mi, ?x2, ?x3)), 1))) lt 100 ? int((((((((max(SkillLv(394), 0) * 10) + 50) + (max(SkillLv(395), 0) * 15)) + (max(SkillLv(396), 0) * 20)) + (max(SkillLv(402), 0) * 20)) + (IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()) + IPlayerStatusCalculator.get_Tec(CharacterActionManagerBase.get_UnTargetDist()))) / max(((SyntheticEquip.getLockCount(this, ?m`
  - calls `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_UnTargetDist`, `interface IPlayerStatusCalculator.get_Tec`, `SyntheticEquip$$getLockCount`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `SyntheticEquip$$getRate (GetSkillLv)`
- `UIStockColorCreatePanel$$GetPrintSuccessRate (GetSkillLv)`

---

### คู่มือการผสมสีIII (ColorSynthesisGuide3) · uid 406

<img src="../../icons/sk_406.png" width="40" alt="icon"> 
**Tree:** アルケミースキル (`AlchemySkill`, tier 5) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** คู่มือการผสมสีII · **Flags:** NoMarketSearch

> เพิ่มอัตราความสำเร็จของ EX สกิล “การสังเคราะห์สี”
> เมื่อสกิลทั้ง 4 ประเภทที่เกี่ยวข้องกับการสังเคราะห์สีมีเลเวลสูงสุด
> มีโอกาสน้อยนิดที่จะได้รับรางวัลเพิ่มเติม

**Role:** passive mastery · no client action class (system / production / unreleased)

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `UIColorSynthesisMainManager$$GetColorSkillLevels (GetSkillLv)`

---
