// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BuildPlayerStatus : PlayerStatus // TypeDefIndex: 1379
{
	// Fields
	private EquipItemData equipData; // 0x80

	// Properties
	public override EquipItemData EquipItemData { get; }

	// Methods

	// RVA: 0x1FE2B48 Offset: 0x1FDEB48 VA: 0x1FE2B48 Slot: 12
	public override EquipItemData get_EquipItemData() { }

	// RVA: 0x1FE2B50 Offset: 0x1FDEB50 VA: 0x1FE2B50
	public void .ctor(BonusManager bonusManager, SkillManager skillManager, SkillBufferManager skillBufManager, AbnormalStateManager abnormalManager, EquipBuffManager equipBuffManager, GemCartBufferManager gemCartBuffManager, ItemRandomPropertyManager itemRandomPropertyManager) { }

	// RVA: 0x1FE2C14 Offset: 0x1FDEC14 VA: 0x1FE2C14 Slot: 28
	public override void SetEquip(ItemDBData.EquipType type, ItemData item) { }
}
