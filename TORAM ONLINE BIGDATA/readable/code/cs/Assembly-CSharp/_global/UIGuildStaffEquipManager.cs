// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildStaffEquipManager : UIBasePanelConnection, UIIItemPanelManager, IUIEquipMainManager // TypeDefIndex: 6672
{
	// Fields
	[SerializeField]
	private GameObject itemListManagerObject; // 0x30
	private UIItemListManager itemListManager; // 0x38
	[SerializeField]
	private GameObject itemListLeftAnchorObject; // 0x40
	private UIIruna2Anchor itemListLeftAnchor; // 0x48
	[SerializeField]
	private GameObject itemListRightAnchorObject; // 0x50
	private UIIruna2Anchor itemListRightAnchor; // 0x58
	[SerializeField]
	private GameObject equipPanelAnchorObject; // 0x60
	private UIIruna2Anchor equipPanelAnchor; // 0x68
	[SerializeField]
	private GameObject avatarEquipPanelAnchorObject; // 0x70
	private UIIruna2Anchor avatarEquipPanelAnchor; // 0x78
	[SerializeField]
	private GameObject[] equipSlotButtonObject; // 0x80
	private UIEquipSlotButton[] equipSlotButton; // 0x88
	[SerializeField]
	private GameObject listButtonObject; // 0x90
	[SerializeField]
	private GameObject listEnterButtonObject; // 0x98
	private UIImageButton listEnterImageButton; // 0xA0
	[SerializeField]
	private UILabel listEnterButtonLabel; // 0xA8
	[SerializeField]
	private GameObject enterButtonObject; // 0xB0
	private UIImageButton enterImageButton; // 0xB8
	[SerializeField]
	private UILabel enterButtonLabel; // 0xC0
	[SerializeField]
	private GameObject enterEquipButton; // 0xC8
	[SerializeField]
	private GameObject equipBackPanel; // 0xD0
	[SerializeField]
	private GameObject avatarBackPanel; // 0xD8
	[SerializeField]
	private GameObject itemListScrollCameraObj; // 0xE0
	private List<ItemData> selectItemDataList; // 0xE8
	private ItemTextManager itemTextManager; // 0xF0
	private PlayerDataManager playerDataManager; // 0xF8
	private UIItemPanelButton selectedButton; // 0x100
	private int pageId; // 0x108
	private int pageItemNum; // 0x10C
	[SerializeField]
	private GameObject[] basePanelObject; // 0x110
	private UIEquipBasePanel[] basePanel; // 0x118
	private int selectedPanel; // 0x120
	private bool isActiveEquipButton; // 0x124
	private ItemData[] equipedItemList; // 0x128
	private ItemData[] selectEquipedItemList; // 0x130
	private ItemDBData.EquipType selectedEquipType; // 0x138
	private int updateBitFlag; // 0x13C

	// Properties
	private bool inputLock { get; }
	public int PageId { get; }

	// Methods

	// RVA: 0x19AF660 Offset: 0x19AB660 VA: 0x19AF660
	private bool get_inputLock() { }

	// RVA: 0x19AF668 Offset: 0x19AB668 VA: 0x19AF668
	public int get_PageId() { }

	// RVA: 0x19AF670 Offset: 0x19AB670 VA: 0x19AF670
	public List<ItemData> GetItemTypeList(ItemDBData.EquipType type, ItemDBData.ItemType[] types) { }

	// RVA: 0x19AF808 Offset: 0x19AB808 VA: 0x19AF808
	public ItemData GetEquipItem(ItemDBData.EquipType type) { }

	// RVA: 0x19AF838 Offset: 0x19AB838 VA: 0x19AF838
	public void SetEquipItem(ItemDBData.EquipType type, ItemData data) { }

	// RVA: 0x19AF9AC Offset: 0x19AB9AC VA: 0x19AF9AC
	private void Start() { }

	// RVA: 0x19B0168 Offset: 0x19AC168 VA: 0x19B0168 Slot: 15
	public void OnClickEquipButton(ItemDBData.EquipType selectedEquipType) { }

	// RVA: 0x19B0200 Offset: 0x19AC200 VA: 0x19B0200
	public void SetItemList(List<ItemData> itemList, ItemDBData.EquipType equipType, string buttonText) { }

	// RVA: 0x19B0208 Offset: 0x19AC208 VA: 0x19B0208
	public void SetItemList(List<ItemData> itemList, ItemDBData.EquipType equipType, string buttonText, int pageId) { }

	// RVA: 0x19B071C Offset: 0x19AC71C VA: 0x19B071C
	public void UpdateItemList() { }

	// RVA: 0x19B02D4 Offset: 0x19AC2D4 VA: 0x19B02D4
	public void SetItemListLabel(string buttonText, bool isActive) { }

	// RVA: 0x19B0360 Offset: 0x19AC360 VA: 0x19B0360
	private void OpenItemList() { }

	// RVA: 0x19B07B8 Offset: 0x19AC7B8 VA: 0x19B07B8
	public void ItemPanelClose() { }

	// RVA: 0x19B08E4 Offset: 0x19AC8E4 VA: 0x19B08E4
	public void ResetEquipMenu() { }

	// RVA: 0x19B091C Offset: 0x19AC91C VA: 0x19B091C
	public void SetEquipItemLabel(ItemDBData.EquipType equipType, ItemData equipItem) { }

	// RVA: 0x19B0BA0 Offset: 0x19ACBA0 VA: 0x19B0BA0
	public void UpdateSelectButton() { }

	// RVA: 0x19B0C28 Offset: 0x19ACC28 VA: 0x19B0C28
	public void MoveAvatarPanel(bool isEnable) { }

	// RVA: 0x19B0D20 Offset: 0x19ACD20 VA: 0x19B0D20
	public void ResetItemProperty() { }

	// RVA: 0x19B0720 Offset: 0x19AC720 VA: 0x19B0720
	private void ChangeAvatarEnebleButton(bool isActive) { }

	// RVA: 0x19B0D44 Offset: 0x19ACD44 VA: 0x19B0D44 Slot: 8
	public void OnPress(UIItemPanelButton select) { }

	// RVA: 0x19B0EB0 Offset: 0x19ACEB0 VA: 0x19B0EB0 Slot: 9
	public void OnRelease(UIItemPanelButton select) { }

	// RVA: 0x19B0EB4 Offset: 0x19ACEB4 VA: 0x19B0EB4 Slot: 10
	public void OnDrag(UIItemPanelButton select) { }

	// RVA: 0x19B0EB8 Offset: 0x19ACEB8 VA: 0x19B0EB8 Slot: 11
	public void OnDragRelease(UIItemPanelButton select) { }

	// RVA: 0x19B0EBC Offset: 0x19ACEBC VA: 0x19B0EBC Slot: 12
	public void OnPanelChangeClick() { }

	// RVA: 0x19B0F50 Offset: 0x19ACF50 VA: 0x19B0F50 Slot: 13
	public void OnRightButtonClick() { }

	// RVA: 0x19B0FC0 Offset: 0x19ACFC0 VA: 0x19B0FC0 Slot: 14
	public void OnLeftButtonClick() { }

	// RVA: 0x19B1010 Offset: 0x19AD010 VA: 0x19B1010
	public void OnPageBackButtonClick() { }

	// RVA: 0x19B1080 Offset: 0x19AD080 VA: 0x19B1080
	public void OnClick_EquipEnter() { }

	// RVA: 0x19B1418 Offset: 0x19AD418 VA: 0x19B1418
	private void OnEquipPanelSlideIn() { }

	// RVA: 0x19B1550 Offset: 0x19AD550 VA: 0x19B1550
	private void OnAvatarPanelSlideIn() { }

	// RVA: 0x19B152C Offset: 0x19AD52C VA: 0x19B152C
	private void OnLeftPanelChange() { }

	// RVA: 0x19B17A0 Offset: 0x19AD7A0 VA: 0x19B17A0
	private void AvatarToCristaPanel() { }

	// RVA: 0x19B16E8 Offset: 0x19AD6E8 VA: 0x19B16E8
	private void LeftPanelUpdate() { }

	// RVA: 0x19B17D8 Offset: 0x19AD7D8 VA: 0x19B17D8 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x19B1A5C Offset: 0x19ADA5C VA: 0x19B1A5C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x19B1118 Offset: 0x19AD118 VA: 0x19B1118
	private void EndChangeStaffEquip() { }

	// RVA: 0x19B1D10 Offset: 0x19ADD10 VA: 0x19B1D10
	public void OpenAvatarPanel() { }

	[IteratorStateMachine(typeof(UIGuildStaffEquipManager.<ToOpenAvatarPanel>d__76))]
	// RVA: 0x19B1D30 Offset: 0x19ADD30 VA: 0x19B1D30
	private IEnumerator ToOpenAvatarPanel() { }

	// RVA: 0x19B1DC4 Offset: 0x19ADDC4 VA: 0x19B1DC4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x19B1F08 Offset: 0x19ADF08 VA: 0x19B1F08
	private void <EndChangeStaffEquip>b__74_1() { }
}
