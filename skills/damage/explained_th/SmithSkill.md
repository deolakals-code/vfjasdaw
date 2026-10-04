# สกิลช่างตีเหล็ก (`SmithSkill`) — คำอธิบายทีละสกิล (ภาษาไทย)

สร้างอัตโนมัติด้วย `scripts/render_explained_th.py` จาก `skill_reference.json` (ข้อมูลโค้ด client ชุดล่าสุด) ไม่มีข้อความเขียนมือ แก้ไฟล์นี้ตรง ๆ จะถูกเขียนทับ ตัวเลขทั้งหมดคำนวณจากโค้ด (Code) ความหมายของชื่อ field/บทบาทแปลจากชื่อในโค้ด (Inferred) ยังไม่ได้เทียบกับตัวเลขในเกม ข้อมูลดิบทุกเส้นทางอยู่ใน `../details/SmithSkill.md`

---

### แปรรูปวัตถุดิบ (MaterialCraft) · uid 353

<img src="../../icons/sk_353.png" width="40" alt="icon">

- ทรี: สกิลช่างตีเหล็ก (ขั้น 1) · เลเวลสูงสุด: 25 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: StarGem
- ไม่มีคลาสของตัวเอง ผลอยู่ในโค้ดที่อ่านสกิลนี้ (`crafting skill read by client code (rate/limit/unlock, see page)`)

> แปรรูปวัตถุดิบด้วยตัวเอง
> อัตราความสำเร็จจะเพิ่มขึ้นตามเลเวล
> เป็นสกิลพื้นฐานร่วมกันระหว่างสกิลเล่นแร่แปรธาตุและสกิลช่างตีเหล็ก 

**ทำงานยังไง (จากโค้ด):**
- บทบาท: ไม่มีคลาสแอ็กชันฝั่ง client
- ตัวอ่านสกิลนี้ `SmithProcessingDialog.UpdateTotal` — SmithProcessingDialog.UpdateTotal (นิยามเต็มในแท็บ Variables)

### ทั่งตีเหล็กส่วนตัว (BeginnerAnvil) · uid 354

<img src="../../icons/sk_354.png" width="40" alt="icon">

- ทรี: สกิลช่างตีเหล็ก (ขั้น 1) · เลเวลสูงสุด: 25 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ถลุงอุปกรณ์ · ธง: NoMarketSearch
- ไม่มีคลาสของตัวเอง ผลอยู่ในโค้ดที่อ่านสกิลนี้ (`crafting skill read by client code (rate/limit/unlock, see page)`)

> เพิ่มขีดจำกัดระดับความเชี่ยวชาญของการตีเหล็ก
> ถึงแม้ไม่มีสกิลนี้ก็สามารถเพิ่มระดับความเชี่ยวชาญได้ถึง LV50
> 
> เมื่อถึง LV10 ขีดจำกัดสูงสุดจะเพิ่มขึ้นเท่ากับ LVCAP

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ, ไม่มีคลาสแอ็กชันฝั่ง client
- ตัวอ่านสกิลนี้ `ProficiencyManager.getBlackSmithLimitIncreaseBySkill` — ProficiencyManager.getBlackSmithLimitIncreaseBySkill: คืนค่า `_t1672` (2 กรณี) (นิยามเต็มในแท็บ Variables)

### ถลุงอุปกรณ์ (RefiningEquipment) · uid 358

<img src="../../icons/sk_358.png" width="40" alt="icon">

- ทรี: สกิลช่างตีเหล็ก (ขั้น 1) · เลเวลสูงสุด: 25 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: NoMarketSearch
- ไม่มีโค้ดฝั่ง client (`crafting/merchant: effect is server-side (text only)`)

> ถลุงอุปกรณ์ด้วยตัวเอง
> ถึงแม้จะมีอัตราความสำเร็จต่ำกว่าการถลุงที่ร้านตีเหล็ก
> แต่ก็ประหยัดเพราะไม่ต้องใช้สปินา

**ทำงานยังไง (จากโค้ด):**
- บทบาท: ไม่มีคลาสแอ็กชันฝั่ง client

### สร้างอุปกรณ์ (EquipmentProduction) · uid 362

<img src="../../icons/sk_362.png" width="40" alt="icon">

- ทรี: สกิลช่างตีเหล็ก (ขั้น 1) · เลเวลสูงสุด: 50 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ถลุงอุปกรณ์ · ธง: NoMarketSearch
- ไม่มีโค้ดฝั่ง client (`crafting/merchant: effect is server-side (text only)`)

> สร้างอุปกรณ์ด้วยตัวเอง
> การเพิ่มค่าความสามารถของอุปกรณ์ที่สร้างเสร็จ
> จำเป็นต้องใช้สกิล[อัพเกรดอุปกรณ์]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: ไม่มีคลาสแอ็กชันฝั่ง client

### อัพเกรดอุปกรณ์ (EnhanceEquipment) · uid 365

<img src="../../icons/sk_365.png" width="40" alt="icon">

- ทรี: สกิลช่างตีเหล็ก (ขั้น 1) · เลเวลสูงสุด: 50 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: สร้างอุปกรณ์ · ธง: NoMarketSearch
- ไม่มีคลาสของตัวเอง ผลอยู่ในโค้ดที่อ่านสกิลนี้ (`crafting skill read by client code (rate/limit/unlock, see page)`)

> ใช้ศักยภาพเพื่อเพิ่มประสิทธิภาพของอุปกรณ์
> ที่สร้างสำเร็จด้วยสกิล[สร้างอุปกรณ์]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: ไม่มีคลาสแอ็กชันฝั่ง client
- ตัวอ่านสกิลนี้ `SmithGrant.getSuccessSkillRate` — SmithGrant.getSuccessSkillRate: คืนค่า `((_t1861 + max(SkillManager.GetSkillLv(PlayerDataManager.get_SkillManager(playerDataManager), SkillId.EnhanceEquipment, 1), 0)) + _t1862)` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SmithGrant.getUsableSlotCount` — SmithGrant.getUsableSlotCount: คืนค่า `_t1863` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SmithGrantInfoWindow.getEnhanceMax` — SmithGrantInfoWindow.getEnhanceMax: คืนค่า `System.Math.Max(1, _t1867)` (2 กรณี) (นิยามเต็มในแท็บ Variables)

### ทั่งช่างฝีมือ (CraftsmanAnvil) · uid 355

<img src="../../icons/sk_355.png" width="40" alt="icon">

- ทรี: สกิลช่างตีเหล็ก (ขั้น 2) · เลเวลสูงสุด: 50 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ทั่งตีเหล็กส่วนตัว · ธง: NoMarketSearch
- ไม่มีโค้ดฝั่ง client (`crafting/merchant: effect is server-side (text only)`)

> ลดวัตถุดิบที่จำเป็นสำหรับอัพเกรดอุปกรณ์

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ, ไม่มีคลาสแอ็กชันฝั่ง client

### ถลุงระดับกลาง (IntermediateRefining) · uid 359

<img src="../../icons/sk_359.png" width="40" alt="icon">

- ทรี: สกิลช่างตีเหล็ก (ขั้น 2) · เลเวลสูงสุด: 50 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ถลุงอุปกรณ์ · ธง: NoMarketSearch
- ไม่มีโค้ดฝั่ง client (`crafting/merchant: effect is server-side (text only)`)

> เพิ่มอัตราความสำเร็จให้สกิล[ถลุงอุปกรณ์]เล็กน้อย

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ, ไม่มีคลาสแอ็กชันฝั่ง client

### สร้างอย่างระวัง · uid 363

<img src="../../icons/sk_363.png" width="40" alt="icon">

- ทรี: สกิลช่างตีเหล็ก (ขั้น 2) · เลเวลสูงสุด: 100 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: สร้างอุปกรณ์ · ธง: NoMarketSearch
- ไม่มีโค้ดฝั่ง client (`crafting/merchant: effect is server-side (text only)`)

> เพิ่มศักยภาพอุปกรณ์ที่สร้างสำเร็จ
> ด้วยสกิล[สร้างอุปกรณ์]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ, ไม่มีคลาสแอ็กชันฝั่ง client

### ทั่งช่างตีเหล็ก (BlacksmithAnvil) · uid 356

<img src="../../icons/sk_356.png" width="40" alt="icon">

- ทรี: สกิลช่างตีเหล็ก (ขั้น 3) · เลเวลสูงสุด: 100 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ทั่งช่างฝีมือ · ธง: NoMarketSearch
- ไม่มีโค้ดฝั่ง client (`crafting/merchant: effect is server-side (text only)`)

> ลดวัตถุดิบที่จำเป็นสำหรับอัพเกรดอุปกรณ์

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ, ไม่มีคลาสแอ็กชันฝั่ง client

### ถลุงระดับสูง (AdvancedRefining) · uid 360

<img src="../../icons/sk_360.png" width="40" alt="icon">

- ทรี: สกิลช่างตีเหล็ก (ขั้น 3) · เลเวลสูงสุด: 100 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ถลุงระดับกลาง · ธง: NoMarketSearch
- ไม่มีโค้ดฝั่ง client (`crafting/merchant: effect is server-side (text only)`)

> เพิ่มอัตราความสำเร็จให้สกิล[ถลุงอุปกรณ์]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ, ไม่มีคลาสแอ็กชันฝั่ง client

### อัพเกรดอย่างเที่ยงตรง (ExactEnhance) · uid 366

<img src="../../icons/sk_366.png" width="40" alt="icon">

- ทรี: สกิลช่างตีเหล็ก (ขั้น 3) · เลเวลสูงสุด: 100 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: อัพเกรดอุปกรณ์ · ธง: NoMarketSearch
- ไม่มีคลาสของตัวเอง ผลอยู่ในโค้ดที่อ่านสกิลนี้ (`crafting skill read by client code (rate/limit/unlock, see page)`)

> เพิ่มอัตราความสำเร็จ[สกิลอัพเกรด]ขึ้นเล็กน้อย
> ช่องความสามารถที่ใช้ได้จะเพิ่มขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ, ไม่มีคลาสแอ็กชันฝั่ง client
- ตัวอ่านสกิลนี้ `SmithGrant.getSuccessSkillRate` — SmithGrant.getSuccessSkillRate: คืนค่า `((_t1861 + max(SkillManager.GetSkillLv(PlayerDataManager.get_SkillManager(playerDataManager), SkillId.EnhanceEquipment, 1), 0)) + _t1862)` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SmithGrant.getUsableSlotCount` — SmithGrant.getUsableSlotCount: คืนค่า `_t1863` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SmithGrantInfoWindow.getEnhanceMax` — SmithGrantInfoWindow.getEnhanceMax: คืนค่า `System.Math.Max(1, _t1867)` (2 กรณี) (นิยามเต็มในแท็บ Variables)

### ทั่งมาสเตอร์ (MasterAnvil) · uid 357

<img src="../../icons/sk_357.png" width="40" alt="icon">

- ทรี: สกิลช่างตีเหล็ก (ขั้น 4) · เลเวลสูงสุด: 200 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ทั่งช่างตีเหล็ก · ธง: NoMarketSearch
- ไม่มีโค้ดฝั่ง client (`crafting/merchant: effect is server-side (text only)`)

> ลดวัตถุดิบที่จำเป็นสำหรับอัพเกรดอุปกรณ์

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ, ไม่มีคลาสแอ็กชันฝั่ง client

### ถลุงระดับมืออาชีพ (MastersRefining) · uid 361

<img src="../../icons/sk_361.png" width="40" alt="icon">

- ทรี: สกิลช่างตีเหล็ก (ขั้น 4) · เลเวลสูงสุด: 200 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ถลุงระดับสูง · ธง: NoMarketSearch
- ไม่มีโค้ดฝั่ง client (`crafting/merchant: effect is server-side (text only)`)

> เพิ่มอัตราความสำเร็จให้สกิล[ถลุงอุปกรณ์]พอสมควร

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ, ไม่มีคลาสแอ็กชันฝั่ง client

### สร้างแบบมืออาชีพ · uid 364

<img src="../../icons/sk_364.png" width="40" alt="icon">

- ทรี: สกิลช่างตีเหล็ก (ขั้น 4) · เลเวลสูงสุด: 200 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: สร้างอย่างระวัง · ธง: NoMarketSearch
- ไม่มีโค้ดฝั่ง client (`crafting/merchant: effect is server-side (text only)`)

> เพิ่มศักยภาพอุปกรณ์ที่สร้างสำเร็จ
> ด้วยสกิล[สร้างอุปกรณ์]ให้มากขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ, ไม่มีคลาสแอ็กชันฝั่ง client

### อัพเกรดแบบมืออาชีพ (MastersEnhance) · uid 367

<img src="../../icons/sk_367.png" width="40" alt="icon">

- ทรี: สกิลช่างตีเหล็ก (ขั้น 4) · เลเวลสูงสุด: 200 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: อัพเกรดอย่างเที่ยงตรง · ธง: NoMarketSearch
- ไม่มีคลาสของตัวเอง ผลอยู่ในโค้ดที่อ่านสกิลนี้ (`crafting skill read by client code (rate/limit/unlock, see page)`)

> เพิ่มอัตราความสำเร็จของ[สกิลอัพเกรด]
> และช่องความสามารถที่ใช้ได้จะเพิ่มขึ้น

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ, ไม่มีคลาสแอ็กชันฝั่ง client
- ตัวอ่านสกิลนี้ `SmithGrant.getSuccessSkillRate` — SmithGrant.getSuccessSkillRate: คืนค่า `((_t1861 + max(SkillManager.GetSkillLv(PlayerDataManager.get_SkillManager(playerDataManager), SkillId.EnhanceEquipment, 1), 0)) + _t1862)` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SmithGrant.getUsableSlotCount` — SmithGrant.getUsableSlotCount: คืนค่า `_t1863` (นิยามเต็มในแท็บ Variables)
- ตัวอ่านสกิลนี้ `SmithGrantInfoWindow.getEnhanceMax` — SmithGrantInfoWindow.getEnhanceMax: คืนค่า `System.Math.Max(1, _t1867)` (2 กรณี) (นิยามเต็มในแท็บ Variables)

### ทั่งมาสเตอร์II (MasterAnvil2) · uid 368

<img src="../../icons/sk_368.png" width="40" alt="icon">

- ทรี: สกิลช่างตีเหล็ก (ขั้น 5) · เลเวลสูงสุด: 250 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: ทั่งมาสเตอร์ · ธง: NoMarketSearch
- ไม่มีโค้ดฝั่ง client (`crafting/merchant: effect is server-side (text only)`)

> ลดวัตถุดิบที่จำเป็นสำหรับอัพเกรดอุปกรณ์

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ, ไม่มีคลาสแอ็กชันฝั่ง client

### อัพเกรดแบบมืออาชีพII (MastersEnhance2) · uid 369

<img src="../../icons/sk_369.png" width="40" alt="icon">

- ทรี: สกิลช่างตีเหล็ก (ขั้น 5) · เลเวลสูงสุด: 250 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ต้องเรียนก่อน: อัพเกรดแบบมืออาชีพ · ธง: NoMarketSearch
- ไม่มีโค้ดฝั่ง client (`crafting/merchant: effect is server-side (text only)`)

> มีโอกาสที่สกิล[อัพเกรดอุปกรณ์]จะไม่เปลี่ยนแปลง
> แม้ว่าช่องความสามารถแรกจะล้มเหลว

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ, ไม่มีคลาสแอ็กชันฝั่ง client

### ความเข้าใจโลหะ (MetalUnderstand) · uid 370

<img src="../../icons/sk_370.png" width="40" alt="icon">

- ทรี: สกิลช่างตีเหล็ก (ขั้น 5) · เลเวลสูงสุด: 250 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: NoMarketSearch
- ไม่มีโค้ดฝั่ง client (`crafting/merchant: effect is server-side (text only)`)

> ลดพ้อยท์วัตถุดิบโลหะที่ใช้โดยสกิล[อัพเกรดอุปกรณ์]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ, ไม่มีคลาสแอ็กชันฝั่ง client

### ความเข้าใจผ้า (ClothUnderstand) · uid 371

<img src="../../icons/sk_371.png" width="40" alt="icon">

- ทรี: สกิลช่างตีเหล็ก (ขั้น 5) · เลเวลสูงสุด: 250 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: NoMarketSearch
- ไม่มีโค้ดฝั่ง client (`crafting/merchant: effect is server-side (text only)`)

> ลดพ้อยท์วัตถุดิบผ้าที่ใช้โดยสกิล[อัพเกรดอุปกรณ์]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ, ไม่มีคลาสแอ็กชันฝั่ง client

### ความเข้าอสูร (BeastUnderstand) · uid 372

<img src="../../icons/sk_372.png" width="40" alt="icon">

- ทรี: สกิลช่างตีเหล็ก (ขั้น 5) · เลเวลสูงสุด: 250 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: NoMarketSearch
- ไม่มีโค้ดฝั่ง client (`crafting/merchant: effect is server-side (text only)`)

> ลดพ้อยท์วัตถุดิบอสูรที่ใช้โดยสกิล[อัพเกรดอุปกรณ์]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ, ไม่มีคลาสแอ็กชันฝั่ง client

### ความเข้าไม้ (WoodUnderstand) · uid 373

<img src="../../icons/sk_373.png" width="40" alt="icon">

- ทรี: สกิลช่างตีเหล็ก (ขั้น 5) · เลเวลสูงสุด: 250 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: NoMarketSearch
- ไม่มีโค้ดฝั่ง client (`crafting/merchant: effect is server-side (text only)`)

> ลดพ้อยท์วัตถุดิบไม้ที่ใช้โดยสกิล[อัพเกรดอุปกรณ์]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ, ไม่มีคลาสแอ็กชันฝั่ง client

### ความเข้ายา (DrugUnderstand) · uid 374

<img src="../../icons/sk_374.png" width="40" alt="icon">

- ทรี: สกิลช่างตีเหล็ก (ขั้น 5) · เลเวลสูงสุด: 250 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: NoMarketSearch
- ไม่มีโค้ดฝั่ง client (`crafting/merchant: effect is server-side (text only)`)

> ลดพ้อยท์วัตถุดิบยาที่ใช้โดยสกิล[อัพเกรดอุปกรณ์]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ, ไม่มีคลาสแอ็กชันฝั่ง client

### ความเข้ามานา (MagicUnderstand) · uid 375

<img src="../../icons/sk_375.png" width="40" alt="icon">

- ทรี: สกิลช่างตีเหล็ก (ขั้น 5) · เลเวลสูงสุด: 250 · อาวุธ: มือเปล่า, ดาบมือเดียว, ดาบสองมือ, ธนู, โบว์กัน, ไม้เท้า, อุปกรณ์เวท, สนับมือ, ทวน, คาตานะ · ธง: NoMarketSearch
- ไม่มีคลาสของตัวเอง ผลอยู่ในโค้ดที่อ่านสกิลนี้ (`crafting skill read by client code (rate/limit/unlock, see page)`)

> ลดพ้อยท์วัตถุดิบมานาที่ใช้โดยสกิล[อัพเกรดอุปกรณ์]

**ทำงานยังไง (จากโค้ด):**
- บทบาท: พาสซีฟ, ไม่มีคลาสแอ็กชันฝั่ง client
- ตัวอ่านสกิลนี้ `SmithGrantInfoWindow.CalcUnderstandSkill` — คำนวณ understand skill (SmithGrantInfoWindow): คืนค่า `usePoint` (นิยามเต็มในแท็บ Variables)

