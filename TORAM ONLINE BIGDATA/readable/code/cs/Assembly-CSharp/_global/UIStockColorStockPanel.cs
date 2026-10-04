// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIStockColorStockPanel : MonoBehaviour, UIItemScrollPanelManager, IUIStockColor // TypeDefIndex: 6776
{
	// Fields
	[SerializeField]
	private UISprite selectChangeIcon; // 0x20
	[SerializeField]
	private UILabel stockColorButtonLabel; // 0x28
	[SerializeField]
	private UIIruna2Anchor stockColorButtonAnchor; // 0x30
	[SerializeField]
	private GameObject stockColorSaveButtonObj; // 0x38
	[SerializeField]
	private GameObject stockCheckElement; // 0x40
	[SerializeField]
	private GameObject stockResultElement; // 0x48
	[SerializeField]
	private GameObject stockLineElement; // 0x50
	[SerializeField]
	private GameObject windowObj; // 0x58
	[SerializeField]
	private UILabel windowTitleLabel; // 0x60
	[SerializeField]
	private GameObject[] windowButtons; // 0x68
	[SerializeField]
	private UIScrollWindow windowScrollWindow; // 0x70
	[SerializeField]
	private GameObject nonObj; // 0x78
	[SerializeField]
	private GameObject attentionObj; // 0x80
	private UIItemScrollListManager itemListManager; // 0x88
	private GameObject itemListObject; // 0x90
	private List<ItemData> printItemList; // 0x98
	private List<ItemData> selectedItemList; // 0xA0
	private List<IUIItemScrollPanelButton> selectedItemButtonList; // 0xA8
	private const string stockIconName = "sys_22";
	private bool isMultSelect; // 0xB0
	private UIStockColorMainManager manager; // 0xB8
	private PlayerDataManager playerDataManager; // 0xC0
	private SystemTextManager systemTextManager; // 0xC8
	private ItemTextManager itemTextManager; // 0xD0
	private UIPopBaseWindow popWindow; // 0xD8
	private bool cancelCheck; // 0xE0
	private Dictionary<ItemType, PaletteData> prevPaletteDataList; // 0xE8
	private List<ItemData> newItemDataList; // 0xF0

	// Methods

	// RVA: 0x19F7264 Offset: 0x19F3264 VA: 0x19F7264 Slot: 13
	public void Initialize(UIStockColorMainManager manager, PlayerDataManager playerDataManager, SystemTextManager systemTextManager, ItemTextManager itemTextManager) { }

	// RVA: 0x19F7428 Offset: 0x19F3428 VA: 0x19F7428 Slot: 14
	public void Open() { }

	// RVA: 0x19F7CE4 Offset: 0x19F3CE4 VA: 0x19F7CE4 Slot: 15
	public bool Close() { }

	// RVA: 0x19F5778 Offset: 0x19F1778 VA: 0x19F5778
	public void OpenResult(PaletteData[] updatePalettes) { }

	// RVA: 0x19F8DC4 Offset: 0x19F4DC4 VA: 0x19F8DC4
	public void OnChangeSelect() { }

	// RVA: 0x19F9460 Offset: 0x19F5460 VA: 0x19F9460
	public void OnStockColor() { }

	// RVA: 0x19FA4A0 Offset: 0x19F64A0 VA: 0x19FA4A0
	public void OnSave() { }

	// RVA: 0x19FA788 Offset: 0x19F6788 VA: 0x19FA788
	public void OnSaveOk() { }

	// RVA: 0x19F7540 Offset: 0x19F3540 VA: 0x19F7540
	private void ChangeActiveItemPanel(bool isActive) { }

	// RVA: 0x19F8F80 Offset: 0x19F4F80 VA: 0x19F8F80
	private void UpdateItemList() { }

	// RVA: 0x19F8EAC Offset: 0x19F4EAC VA: 0x19F8EAC
	private void UpdateChangeSelectObj() { }

	[IteratorStateMachine(typeof(UIStockColorStockPanel.<OpenLoadWaitPopWindow>d__41))]
	// RVA: 0x19FA6AC Offset: 0x19F66AC VA: 0x19FA6AC
	private IEnumerator OpenLoadWaitPopWindow(float time, string title, string text, Action completedAction, Action canecelAction) { }

	// RVA: 0x19F7DAC Offset: 0x19F3DAC VA: 0x19F7DAC
	private Dictionary<ItemType, List<UIStockColorStockPanel.ResultData>> CreateResultData(PaletteData[] updatePalettes) { }

	// RVA: 0x19FA868 Offset: 0x19F6868 VA: 0x19FA868 Slot: 4
	public void OnPress(UIItemScrollPanelButton select) { }

	// RVA: 0x19FA86C Offset: 0x19F686C VA: 0x19FA86C Slot: 5
	public void OnRelease(UIItemScrollPanelButton select) { }

	// RVA: 0x19FB078 Offset: 0x19F7078 VA: 0x19FB078 Slot: 6
	public void OnDrag(UIItemScrollPanelButton select) { }

	// RVA: 0x19FA894 Offset: 0x19F6894 VA: 0x19FA894
	private void SelectItemButton(UIItemScrollPanelButton select) { }

	// RVA: 0x19FB0BC Offset: 0x19F70BC VA: 0x19FB0BC Slot: 7
	public void OnDragRelease(UIItemScrollPanelButton select) { }

	// RVA: 0x19FB138 Offset: 0x19F7138 VA: 0x19FB138 Slot: 8
	public void OnPanelChangeClick() { }

	// RVA: 0x19FB15C Offset: 0x19F715C VA: 0x19FB15C Slot: 9
	public void OnRightButtonClick() { }

	// RVA: 0x19FB160 Offset: 0x19F7160 VA: 0x19FB160 Slot: 10
	public void OnLeftButtonClick() { }

	// RVA: 0x19FB164 Offset: 0x19F7164 VA: 0x19FB164 Slot: 11
	public void OnFilterButton() { }

	// RVA: 0x19FB168 Offset: 0x19F7168 VA: 0x19FB168 Slot: 12
	public bool CheckIconDrag() { }

	// RVA: 0x19FB184 Offset: 0x19F7184 VA: 0x19FB184
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x19FB32C Offset: 0x19F732C VA: 0x19FB32C
	private void <OnSave>b__36_0() { }

	[CompilerGenerated]
	// RVA: 0x19FB464 Offset: 0x19F7464 VA: 0x19FB464
	private void <OnSave>b__36_1() { }

	[CompilerGenerated]
	// RVA: 0x19FB484 Offset: 0x19F7484 VA: 0x19FB484
	private bool <ChangeActiveItemPanel>b__38_1(ItemData item) { }

	[CompilerGenerated]
	// RVA: 0x19FB61C Offset: 0x19F761C VA: 0x19FB61C
	private void <ChangeActiveItemPanel>b__38_2() { }

	[CompilerGenerated]
	// RVA: 0x19FB698 Offset: 0x19F7698 VA: 0x19FB698
	private void <ChangeActiveItemPanel>b__38_3() { }
}
