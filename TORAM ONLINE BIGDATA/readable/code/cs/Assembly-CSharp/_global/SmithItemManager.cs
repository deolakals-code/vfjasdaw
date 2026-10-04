// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SmithItemManager : SmithUIMaterialBase, UIItemScrollPanelManager // TypeDefIndex: 8501
{
	// Fields
	private readonly string selectedIconName; // 0x68
	private readonly string[] categoryIconName; // 0x70
	[SerializeField]
	private SmithProcessingDialog Dialog; // 0x78
	[SerializeField]
	private Transform processButtonTransform; // 0x80
	[SerializeField]
	private UISprite selectButtonSprite; // 0x88
	[SerializeField]
	private UILabel selectButtonLabel; // 0x90
	[SerializeField]
	private UISprite categoryIcon; // 0x98
	[SerializeField]
	private UILabel categoryLabel; // 0xA0
	private GameObject itemListObject; // 0xA8
	private UIItemScrollListManager itemListManager; // 0xB0
	private PlayerDataManager playerDataManager; // 0xB8
	private List<ItemData> selectedItem; // 0xC0
	private List<IUIItemScrollPanelButton> selectedItemButton; // 0xC8
	private int nowBag; // 0xD0
	private SortCategory selectedCategory; // 0xD4
	[CompilerGenerated]
	private bool <isMultiSelect>k__BackingField; // 0xD8
	public byte ShopType; // 0xD9
	private bool isGuildStaff; // 0xDA
	private List<ItemData> newItemDataList; // 0xE0

	// Properties
	public bool isMultiSelect { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D89280 Offset: 0x1D85280 VA: 0x1D89280
	public bool get_isMultiSelect() { }

	[CompilerGenerated]
	// RVA: 0x1D89288 Offset: 0x1D85288 VA: 0x1D89288
	private void set_isMultiSelect(bool value) { }

	// RVA: 0x1D89294 Offset: 0x1D85294 VA: 0x1D89294
	private void Start() { }

	// RVA: 0x1D899DC Offset: 0x1D859DC VA: 0x1D899DC
	public void ReloadItemList(bool isScrollUpdate = False) { }

	// RVA: 0x1D89A0C Offset: 0x1D85A0C VA: 0x1D89A0C
	public void ReloadItemList(int materialType, int materialLv, bool isScrollUpdate = False) { }

	// RVA: 0x1D8A5F4 Offset: 0x1D865F4 VA: 0x1D8A5F4
	private void ReloadItemList(SortCategory category, int materialType, int materialLv, bool isUpdate = False) { }

	// RVA: 0x1D8B438 Offset: 0x1D87438 VA: 0x1D8B438
	public void ActiveGuildStaff() { }

	// RVA: 0x1D8B444 Offset: 0x1D87444 VA: 0x1D8B444
	private void OnDrop(GameObject fromObject) { }

	// RVA: 0x1D8B448 Offset: 0x1D87448 VA: 0x1D8B448
	private void onProcessing() { }

	// RVA: 0x1D8B78C Offset: 0x1D8778C VA: 0x1D8B78C
	private void closeDialog() { }

	// RVA: 0x1D8B7C4 Offset: 0x1D877C4 VA: 0x1D8B7C4
	private void onChangeSelect() { }

	// RVA: 0x1D8B8AC Offset: 0x1D878AC VA: 0x1D8B8AC
	public int[] GetItemUuids() { }

	// RVA: 0x1D8B9FC Offset: 0x1D879FC VA: 0x1D8B9FC
	public Dictionary<int, short> GetItemDictionarty() { }

	// RVA: 0x1D8BBD4 Offset: 0x1D87BD4 VA: 0x1D8BBD4
	public ItemSelectData[] GetItemSelectData() { }

	// RVA: 0x1D8BE78 Offset: 0x1D87E78 VA: 0x1D8BE78
	public ItemData[] GetItemDatas() { }

	// RVA: 0x1D8BEC8 Offset: 0x1D87EC8 VA: 0x1D8BEC8
	private void onChangeCategory() { }

	// RVA: 0x1D8983C Offset: 0x1D8583C VA: 0x1D8983C
	private void UpdateCategoryIconLabel() { }

	// RVA: 0x1D8BF14 Offset: 0x1D87F14 VA: 0x1D8BF14
	public void ActiveItemScrollCamera() { }

	// RVA: 0x1D8BF34 Offset: 0x1D87F34 VA: 0x1D8BF34 Slot: 6
	public void OnPress(UIItemScrollPanelButton select) { }

	// RVA: 0x1D8BF38 Offset: 0x1D87F38 VA: 0x1D8BF38 Slot: 7
	public void OnRelease(UIItemScrollPanelButton select) { }

	// RVA: 0x1D8CAB4 Offset: 0x1D88AB4 VA: 0x1D8CAB4 Slot: 8
	public void OnDrag(UIItemScrollPanelButton select) { }

	// RVA: 0x1D8BF60 Offset: 0x1D87F60 VA: 0x1D8BF60
	private void SelectItemButton(UIItemScrollPanelButton select) { }

	// RVA: 0x1D8CB10 Offset: 0x1D88B10 VA: 0x1D8CB10 Slot: 9
	public void OnDragRelease(UIItemScrollPanelButton select) { }

	// RVA: 0x1D8CB80 Offset: 0x1D88B80 VA: 0x1D8CB80 Slot: 10
	public void OnPanelChangeClick() { }

	// RVA: 0x1D8CBA4 Offset: 0x1D88BA4 VA: 0x1D8CBA4 Slot: 11
	public void OnRightButtonClick() { }

	// RVA: 0x1D8CD68 Offset: 0x1D88D68 VA: 0x1D8CD68 Slot: 12
	public void OnLeftButtonClick() { }

	// RVA: 0x1D8CBF8 Offset: 0x1D88BF8 VA: 0x1D8CBF8
	private void changePageReload() { }

	// RVA: 0x1D8CDB4 Offset: 0x1D88DB4 VA: 0x1D8CDB4 Slot: 13
	public void OnFilterButton() { }

	// RVA: 0x1D8CDB8 Offset: 0x1D88DB8 VA: 0x1D8CDB8 Slot: 14
	public bool CheckIconDrag() { }

	// RVA: 0x1D8CDD4 Offset: 0x1D88DD4 VA: 0x1D8CDD4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1D8D078 Offset: 0x1D89078 VA: 0x1D8D078
	private bool <Start>b__22_0(ItemData x) { }
}
