// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGLItemScrollPanelButton : UIItemScrollPanelButton // TypeDefIndex: 8918
{
	// Fields
	[SerializeField]
	private GameObject baseButton; // 0x138
	[SerializeField]
	private UIGLWidgetsConvert glWidgetsConvert; // 0x140
	[SerializeField]
	private GameObject paramLabel3Base; // 0x148
	private bool isActive; // 0x150
	private UIGLMesh[] uiGLMesh; // 0x158
	private int depth; // 0x160

	// Properties
	protected override GameObject BaseButton { get; }

	// Methods

	// RVA: 0x1E5508C Offset: 0x1E5108C VA: 0x1E5508C Slot: 38
	protected override GameObject get_BaseButton() { }

	// RVA: 0x1E55094 Offset: 0x1E51094 VA: 0x1E55094
	private void UpdateBaseButton() { }

	// RVA: 0x1E554A0 Offset: 0x1E514A0 VA: 0x1E554A0
	private void WriteMesh() { }

	// RVA: 0x1E552CC Offset: 0x1E512CC VA: 0x1E552CC
	private void UseParam3Label() { }

	// RVA: 0x1E555C8 Offset: 0x1E515C8 VA: 0x1E555C8 Slot: 57
	public override bool SetActive(bool isActive) { }

	// RVA: 0x1E555FC Offset: 0x1E515FC VA: 0x1E555FC Slot: 39
	public override void Init(IUIItemScrollPanelButton copy, UIItemScrollPanelManager panelManager, UIItemScrollListManager listManager, GameObject parentObj) { }

	// RVA: 0x1E55704 Offset: 0x1E51704 VA: 0x1E55704 Slot: 40
	public override void Initialize(ItemData itemData, UIItemScrollPanelManager panelManager, UIItemScrollListManager listManager, GameObject parentObj) { }

	// RVA: 0x1E55758 Offset: 0x1E51758 VA: 0x1E55758 Slot: 41
	public override void InitializeAddSlot(UIItemScrollPanelManager panelManager) { }

	// RVA: 0x1E5578C Offset: 0x1E5178C VA: 0x1E5578C Slot: 42
	public override void Clear() { }

	// RVA: 0x1E557B0 Offset: 0x1E517B0 VA: 0x1E557B0 Slot: 43
	public override void Select() { }

	// RVA: 0x1E557D4 Offset: 0x1E517D4 VA: 0x1E557D4 Slot: 44
	public override void DeSelect() { }

	// RVA: 0x1E557F8 Offset: 0x1E517F8 VA: 0x1E557F8 Slot: 45
	public override void SetEnable(bool enabled) { }

	// RVA: 0x1E5582C Offset: 0x1E5182C VA: 0x1E5582C Slot: 46
	public override void SetLock(bool lockFlag) { }

	// RVA: 0x1E55860 Offset: 0x1E51860 VA: 0x1E55860 Slot: 47
	public override void SetNew(bool flag) { }

	// RVA: 0x1E55894 Offset: 0x1E51894 VA: 0x1E55894 Slot: 48
	public override void SetFavorite(bool flag) { }

	// RVA: 0x1E558C8 Offset: 0x1E518C8 VA: 0x1E558C8 Slot: 49
	public override void EquipCheck(bool flag) { }

	// RVA: 0x1E558FC Offset: 0x1E518FC VA: 0x1E558FC Slot: 50
	public override void QuestCheck(bool flag) { }

	// RVA: 0x1E55930 Offset: 0x1E51930 VA: 0x1E55930 Slot: 51
	public override void NewItemCheck(bool flag) { }

	// RVA: 0x1E55964 Offset: 0x1E51964 VA: 0x1E55964 Slot: 52
	public override void FavorItemCheck(bool flag, bool isNewItem) { }

	// RVA: 0x1E559A0 Offset: 0x1E519A0 VA: 0x1E559A0 Slot: 53
	public override void ItemUpdateCheck(ItemData itemData) { }

	// RVA: 0x1E559D4 Offset: 0x1E519D4 VA: 0x1E559D4 Slot: 54
	public override void SetSelectIcon(string spriteName, bool enabled) { }

	// RVA: 0x1E55A10 Offset: 0x1E51A10 VA: 0x1E55A10 Slot: 55
	public override void ChangeDetachIcon() { }

	// RVA: 0x1E55A3C Offset: 0x1E51A3C VA: 0x1E55A3C Slot: 56
	public override void ChangeAvatarCategoryIcon() { }

	// RVA: 0x1E55A68 Offset: 0x1E51A68 VA: 0x1E55A68
	public void .ctor() { }
}
