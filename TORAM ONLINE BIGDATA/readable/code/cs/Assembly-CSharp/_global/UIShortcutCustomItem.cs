// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIShortcutCustomItem : UIShortcutCustomBase // TypeDefIndex: 7528
{
	// Fields
	private PlayerDataManager playerDataManager; // 0x28
	private ItemTextManager itemTextManager; // 0x30
	private List<int> itemList; // 0x38

	// Properties
	public override bool IsTopMenu { get; }

	// Methods

	// RVA: 0x1B83EC8 Offset: 0x1B7FEC8 VA: 0x1B83EC8
	public void .ctor(IUIShortcutCustomManager manager) { }

	// RVA: 0x1B86870 Offset: 0x1B82870 VA: 0x1B86870 Slot: 4
	public override bool get_IsTopMenu() { }

	// RVA: 0x1B86878 Offset: 0x1B82878 VA: 0x1B86878 Slot: 6
	public override void CreateList() { }

	// RVA: 0x1B86B68 Offset: 0x1B82B68 VA: 0x1B86B68 Slot: 7
	public override string OnSelect(int itemId) { }

	// RVA: 0x1B86BF0 Offset: 0x1B82BF0 VA: 0x1B86BF0 Slot: 8
	public override void OnClick(int id) { }
}
