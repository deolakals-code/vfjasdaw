// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ItemSelector : MonoBehaviour, UIItemScrollPanelManager // TypeDefIndex: 8064
{
	// Fields
	[SerializeField]
	private CountSystem countSystem; // 0x20
	[SerializeField]
	private GameObject dialog; // 0x28
	[SerializeField]
	private ItemIcon itemIcon; // 0x30
	[SerializeField]
	private GameObject selectButton; // 0x38
	[SerializeField]
	private GameObject changeBagButton; // 0x40
	[SerializeField]
	private UISprite changeIcon; // 0x48
	[SerializeField]
	private GameObject[] selectIconList; // 0x50
	[CompilerGenerated]
	private bool <IsAutoClose>k__BackingField; // 0x58
	[CompilerGenerated]
	private bool <IsClosed>k__BackingField; // 0x59
	[CompilerGenerated]
	private Transform <ReceiveDragPosition>k__BackingField; // 0x60
	private UIItemScrollListManager itemListManager; // 0x68
	private GameObject itemListObject; // 0x70
	private SystemTextManager systemTextManager; // 0x78
	private ItemTextManager itemTextManager; // 0x80
	private PlayerDataManager playerDataManager; // 0x88
	private ItemData selectedItem; // 0x90
	private UIItemScrollPanelButton selectedItemButton; // 0x98
	private int nowBag; // 0xA0
	private IUIPanelControl topControl; // 0xA8
	private Action<ItemData, int> callback; // 0xB0
	private Func<ItemData, bool> selector; // 0xB8
	private Func<ItemData, bool> showSelector; // 0xC0
	private UITopButtonBase.ActionSystemType oldLeft; // 0xC8
	private UITopButtonBase.ActionSystemType oldRight; // 0xCC
	private bool isChangeBag; // 0xD0
	private bool isSelectInBag; // 0xD1
	private UIStarGemSelector stargemSelector; // 0xD8
	private Action<StarGemData> starGemCallback; // 0xE0
	private UIIruna2Anchor selectButtonAnchor; // 0xE8
	private UIIruna2Anchor changeBagButtonAnchor; // 0xF0
	private List<ItemData> newItemDataList; // 0xF8

	// Properties
	public bool IsAutoClose { get; set; }
	public bool IsClosed { get; set; }
	public bool EnableSelectButton { get; set; }
	public bool EnableChangeBagButton { get; set; }
	public Transform ReceiveDragPosition { get; set; }
	public UIStarGemSelector StarGemSelector { get; }
	public UIItemScrollListManager ItemListManager { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1CB3CC0 Offset: 0x1CAFCC0 VA: 0x1CB3CC0
	public bool get_IsAutoClose() { }

	[CompilerGenerated]
	// RVA: 0x1CB3CC8 Offset: 0x1CAFCC8 VA: 0x1CB3CC8
	public void set_IsAutoClose(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1CB3CD4 Offset: 0x1CAFCD4 VA: 0x1CB3CD4
	public bool get_IsClosed() { }

	[CompilerGenerated]
	// RVA: 0x1CB3CDC Offset: 0x1CAFCDC VA: 0x1CB3CDC
	private void set_IsClosed(bool value) { }

	// RVA: 0x1CB3CE8 Offset: 0x1CAFCE8 VA: 0x1CB3CE8
	public bool get_EnableSelectButton() { }

	// RVA: 0x1CB3D70 Offset: 0x1CAFD70 VA: 0x1CB3D70
	public void set_EnableSelectButton(bool value) { }

	// RVA: 0x1CB3E08 Offset: 0x1CAFE08 VA: 0x1CB3E08
	public bool get_EnableChangeBagButton() { }

	// RVA: 0x1CB3E90 Offset: 0x1CAFE90 VA: 0x1CB3E90
	public void set_EnableChangeBagButton(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1CB3F28 Offset: 0x1CAFF28 VA: 0x1CB3F28
	public Transform get_ReceiveDragPosition() { }

	[CompilerGenerated]
	// RVA: 0x1CB3F30 Offset: 0x1CAFF30 VA: 0x1CB3F30
	public void set_ReceiveDragPosition(Transform value) { }

	// RVA: 0x1CB3F38 Offset: 0x1CAFF38 VA: 0x1CB3F38
	public UIStarGemSelector get_StarGemSelector() { }

	// RVA: 0x1CB3F40 Offset: 0x1CAFF40 VA: 0x1CB3F40
	public UIItemScrollListManager get_ItemListManager() { }

	// RVA: 0x1CB3F48 Offset: 0x1CAFF48 VA: 0x1CB3F48
	private void Awake() { }

	// RVA: 0x1CB402C Offset: 0x1CB002C VA: 0x1CB402C
	private void Update() { }

	// RVA: 0x1CB40CC Offset: 0x1CB00CC VA: 0x1CB40CC
	public void SetShowSelector(Func<ItemData, bool> showSelector) { }

	// RVA: 0x1CB40D4 Offset: 0x1CB00D4 VA: 0x1CB40D4
	public void Initialize(IUIPanelControl control, Func<ItemData, bool> selector) { }

	// RVA: 0x1CB44A8 Offset: 0x1CB04A8 VA: 0x1CB44A8
	public void Initialize(IUIPanelControl control, bool isChangeBag, Func<ItemData, bool> selector) { }

	// RVA: 0x1CB44B0 Offset: 0x1CB04B0 VA: 0x1CB44B0
	public void Open(Action<ItemData, int> callback) { }

	// RVA: 0x1CB54D8 Offset: 0x1CB14D8 VA: 0x1CB54D8
	public void Close() { }

	// RVA: 0x1CB5914 Offset: 0x1CB1914 VA: 0x1CB5914
	public void InitializeItemList(Func<ItemData, bool> _selector) { }

	// RVA: 0x1CB4ABC Offset: 0x1CB0ABC VA: 0x1CB4ABC
	public void InitializeItemList() { }

	// RVA: 0x1CB5930 Offset: 0x1CB1930 VA: 0x1CB5930
	public void SetStarGemCallBack(Action<StarGemData> callback) { }

	// RVA: 0x1CB59C8 Offset: 0x1CB19C8 VA: 0x1CB59C8
	public void OpenStarGemSelectPanel() { }

	// RVA: 0x1CB5B30 Offset: 0x1CB1B30 VA: 0x1CB5B30
	public void UpdatePreviewAction(Action action, Action closeAction) { }

	// RVA: 0x1CB5B4C Offset: 0x1CB1B4C VA: 0x1CB5B4C
	public void SetPreviewIconActive(bool isActive) { }

	// RVA: 0x1CB5B6C Offset: 0x1CB1B6C VA: 0x1CB5B6C
	public void ChangeInfluenceFull(bool isFlag) { }

	// RVA: 0x1CB5B8C Offset: 0x1CB1B8C VA: 0x1CB5B8C
	public void ChangeModelDeleteFlag(bool isFlag) { }

	// RVA: 0x1CB5BAC Offset: 0x1CB1BAC VA: 0x1CB5BAC
	public void ChangeSelectIcon(ItemSelector.SelectIconType type) { }

	// RVA: 0x1CB40E0 Offset: 0x1CB00E0 VA: 0x1CB40E0
	private void Initalize(IUIPanelControl control, bool isChangeBag, Func<ItemData, bool> selector) { }

	// RVA: 0x1CB5C18 Offset: 0x1CB1C18 VA: 0x1CB5C18
	private void onSelected() { }

	// RVA: 0x1CB5E40 Offset: 0x1CB1E40 VA: 0x1CB5E40
	private void onCountSetting(ItemData item) { }

	// RVA: 0x1CB5884 Offset: 0x1CB1884 VA: 0x1CB5884
	private void closeDialog() { }

	// RVA: 0x1CB6060 Offset: 0x1CB2060 VA: 0x1CB6060
	private void SelectedStarGem() { }

	// RVA: 0x1CB6184 Offset: 0x1CB2184 VA: 0x1CB6184
	private void StarGemClose() { }

	// RVA: 0x1CB49DC Offset: 0x1CB09DC VA: 0x1CB49DC
	private void ActiveButton() { }

	// RVA: 0x1CB6510 Offset: 0x1CB2510 VA: 0x1CB6510
	private void NonActiveButton() { }

	// RVA: 0x1CB65E0 Offset: 0x1CB25E0 VA: 0x1CB65E0 Slot: 4
	public void OnPress(UIItemScrollPanelButton select) { }

	// RVA: 0x1CB65E4 Offset: 0x1CB25E4 VA: 0x1CB65E4 Slot: 5
	public void OnRelease(UIItemScrollPanelButton select) { }

	// RVA: 0x1CB67E4 Offset: 0x1CB27E4 VA: 0x1CB67E4 Slot: 6
	public void OnDrag(UIItemScrollPanelButton select) { }

	// RVA: 0x1CB66C8 Offset: 0x1CB26C8 VA: 0x1CB66C8
	private void SelectItemButton(UIItemScrollPanelButton select) { }

	// RVA: 0x1CB6828 Offset: 0x1CB2828 VA: 0x1CB6828 Slot: 7
	public void OnDragRelease(UIItemScrollPanelButton select) { }

	// RVA: 0x1CB6918 Offset: 0x1CB2918 VA: 0x1CB6918 Slot: 8
	public void OnPanelChangeClick() { }

	// RVA: 0x1CB693C Offset: 0x1CB293C VA: 0x1CB693C Slot: 9
	public void OnRightButtonClick() { }

	// RVA: 0x1CB6990 Offset: 0x1CB2990 VA: 0x1CB6990 Slot: 10
	public void OnLeftButtonClick() { }

	// RVA: 0x1CB69DC Offset: 0x1CB29DC VA: 0x1CB69DC Slot: 11
	public void OnFilterButton() { }

	// RVA: 0x1CB69E0 Offset: 0x1CB29E0 VA: 0x1CB69E0 Slot: 12
	public bool CheckIconDrag() { }

	// RVA: 0x1CB69FC Offset: 0x1CB29FC VA: 0x1CB69FC
	private void OnSelectButton() { }

	// RVA: 0x1CB6AA0 Offset: 0x1CB2AA0 VA: 0x1CB6AA0
	public void OnChangeBag() { }

	// RVA: 0x1CB6C64 Offset: 0x1CB2C64 VA: 0x1CB6C64
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1CB6DE0 Offset: 0x1CB2DE0 VA: 0x1CB6DE0
	private bool <Initalize>b__67_0(ItemData x) { }
}
