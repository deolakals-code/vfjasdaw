// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class GeneralStoreItemListManager : MonoBehaviour, UIItemScrollPanelManager // TypeDefIndex: 8338
{
	// Fields
	private readonly string selectedIconName; // 0x20
	[SerializeField]
	private GeneralStoreDialog Dialog; // 0x28
	[SerializeField]
	private Transform sellButtonTransform; // 0x30
	[SerializeField]
	private UISprite selectButtonSprite; // 0x38
	[SerializeField]
	private UILabel selectButtonLabel; // 0x40
	[SerializeField]
	private UIIruna2Anchor sellButtonAnchor; // 0x48
	[SerializeField]
	private UIIruna2Anchor selectIconAnchor; // 0x50
	private GameObject itemListObject; // 0x58
	private UIItemScrollListManager itemListManager; // 0x60
	private List<ItemData> selectedItem; // 0x68
	private List<IUIItemScrollPanelButton> selectedItemButton; // 0x70
	private int nowBag; // 0x78
	private int ShopId; // 0x7C
	[CompilerGenerated]
	private UIBasePanelControl <topButtonControl>k__BackingField; // 0x80
	private TextManagerBase itemTextManager; // 0x88
	private SystemTextManager systemTextManager; // 0x90
	private PlayerDataManager playerDataManager; // 0x98
	private List<ItemData> newItemDataList; // 0xA0
	[CompilerGenerated]
	private bool <isMultiSelect>k__BackingField; // 0xA8

	// Properties
	public UIBasePanelControl topButtonControl { get; set; }
	public bool isMultiSelect { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D24D00 Offset: 0x1D20D00 VA: 0x1D24D00
	public UIBasePanelControl get_topButtonControl() { }

	[CompilerGenerated]
	// RVA: 0x1D24D08 Offset: 0x1D20D08 VA: 0x1D24D08
	public void set_topButtonControl(UIBasePanelControl value) { }

	[CompilerGenerated]
	// RVA: 0x1D24D10 Offset: 0x1D20D10 VA: 0x1D24D10
	private void set_isMultiSelect(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1D24D1C Offset: 0x1D20D1C VA: 0x1D24D1C
	public bool get_isMultiSelect() { }

	// RVA: 0x1D24D24 Offset: 0x1D20D24 VA: 0x1D24D24
	private void Awake() { }

	// RVA: 0x1D24EBC Offset: 0x1D20EBC VA: 0x1D24EBC
	private void Start() { }

	// RVA: 0x1D25274 Offset: 0x1D21274 VA: 0x1D25274
	private void Update() { }

	// RVA: 0x1D25388 Offset: 0x1D21388 VA: 0x1D25388
	public void OnSellButton() { }

	// RVA: 0x1D25724 Offset: 0x1D21724 VA: 0x1D25724
	private void SellEndItem() { }

	// RVA: 0x1D25760 Offset: 0x1D21760 VA: 0x1D25760
	private void CloseDialog() { }

	// RVA: 0x1D257A8 Offset: 0x1D217A8 VA: 0x1D257A8
	private void OnSellItem() { }

	[IteratorStateMachine(typeof(GeneralStoreItemListManager.<WaitResponse>d__33))]
	// RVA: 0x1D25B9C Offset: 0x1D21B9C VA: 0x1D25B9C
	private IEnumerator WaitResponse(int shopId, short[] position, ItemSelectData[] selectItem) { }

	// RVA: 0x1D25268 Offset: 0x1D21268 VA: 0x1D25268
	public void reloadItemList(bool isScrollUpdate = False) { }

	// RVA: 0x1D25C70 Offset: 0x1D21C70 VA: 0x1D25C70
	public void reloadItemList(bool selectClear, bool isScrollUpdate = False) { }

	// RVA: 0x1D1F940 Offset: 0x1D1B940 VA: 0x1D1F940
	public void Close() { }

	// RVA: 0x1D267F8 Offset: 0x1D227F8 VA: 0x1D267F8
	private void OnDestroy() { }

	// RVA: 0x1D26890 Offset: 0x1D22890 VA: 0x1D26890
	public void SetShopId(int shopId) { }

	// RVA: 0x1D26898 Offset: 0x1D22898 VA: 0x1D26898
	private void onChangeSelect() { }

	// RVA: 0x1D26984 Offset: 0x1D22984 VA: 0x1D26984
	private void OnClick() { }

	// RVA: 0x1D26988 Offset: 0x1D22988 VA: 0x1D26988
	private void OnDrop() { }

	// RVA: 0x1D2698C Offset: 0x1D2298C VA: 0x1D2698C Slot: 4
	public void OnPress(UIItemScrollPanelButton select) { }

	// RVA: 0x1D26990 Offset: 0x1D22990 VA: 0x1D26990 Slot: 5
	public void OnRelease(UIItemScrollPanelButton select) { }

	// RVA: 0x1D27170 Offset: 0x1D23170 VA: 0x1D27170 Slot: 6
	public void OnDrag(UIItemScrollPanelButton select) { }

	// RVA: 0x1D269B8 Offset: 0x1D229B8 VA: 0x1D269B8
	private void SelectItemButton(UIItemScrollPanelButton select) { }

	// RVA: 0x1D271BC Offset: 0x1D231BC VA: 0x1D271BC Slot: 7
	public void OnDragRelease(UIItemScrollPanelButton select) { }

	// RVA: 0x1D2722C Offset: 0x1D2322C VA: 0x1D2722C Slot: 8
	public void OnPanelChangeClick() { }

	// RVA: 0x1D27250 Offset: 0x1D23250 VA: 0x1D27250 Slot: 9
	public void OnRightButtonClick() { }

	// RVA: 0x1D273BC Offset: 0x1D233BC VA: 0x1D273BC Slot: 10
	public void OnLeftButtonClick() { }

	// RVA: 0x1D272A4 Offset: 0x1D232A4 VA: 0x1D272A4
	private void changePageReload() { }

	// RVA: 0x1D27408 Offset: 0x1D23408 VA: 0x1D27408 Slot: 11
	public void OnFilterButton() { }

	// RVA: 0x1D27414 Offset: 0x1D23414 VA: 0x1D27414 Slot: 12
	public bool CheckIconDrag() { }

	// RVA: 0x1D27430 Offset: 0x1D23430 VA: 0x1D27430
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1D2755C Offset: 0x1D2355C VA: 0x1D2755C
	private bool <Start>b__27_0(ItemData x) { }

	[CompilerGenerated]
	// RVA: 0x1D27594 Offset: 0x1D23594 VA: 0x1D27594
	private void <Start>b__27_1() { }

	[CompilerGenerated]
	// RVA: 0x1D27680 Offset: 0x1D23680 VA: 0x1D27680
	private void <Start>b__27_2() { }
}
