// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AutoItemManager // TypeDefIndex: 1994
{
	// Fields
	private ItemManager itemManager; // 0x10
	private AutoItemUseData imoData; // 0x18

	// Properties
	public AutoItemUseData ItemData { get; }

	// Methods

	// RVA: 0x212A590 Offset: 0x2126590 VA: 0x212A590
	public AutoItemUseData get_ItemData() { }

	// RVA: 0x212A598 Offset: 0x2126598 VA: 0x212A598
	public void .ctor(ItemManager itemManager) { }

	// RVA: 0x212A638 Offset: 0x2126638 VA: 0x212A638
	public void UpdateItemData() { }

	// RVA: 0x212A718 Offset: 0x2126718 VA: 0x212A718
	public void Update(IAutoItemPlayer player, PlayerActionManager actionManatger, float itemDelayTime) { }

	// RVA: 0x212A650 Offset: 0x2126650 VA: 0x212A650
	private void loadImoData() { }

	// RVA: 0x212A6E4 Offset: 0x21266E4 VA: 0x212A6E4
	public void UpdateItemCount() { }
}
