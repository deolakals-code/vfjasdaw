// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildStaffEquipPanel : UIEquipBasePanel // TypeDefIndex: 6675
{
	// Fields
	[SerializeField]
	private GameObject scrollWindowObject; // 0x28
	private UIScrollWindow scrollWindow; // 0x30
	[SerializeField]
	private GameObject scrollCategoryObject; // 0x38
	private UIScrollWindow scrollCategoryWindow; // 0x40
	private UIIruna2Anchor scrollCategoryWindowAnchor; // 0x48
	[SerializeField]
	private GameObject scrollCategoryButtonObject; // 0x50
	[SerializeField]
	private GameObject noAvatarObj; // 0x58
	[SerializeField]
	private UILabel noAvatarLabel; // 0x60
	[SerializeField]
	private UICamera categoryCamera; // 0x68
	private UIGuildStaffEquipManager manager; // 0x70
	private PlayerDataManager playerDataManager; // 0x78
	private OrbEquipItemManager orbEquipItemManager; // 0x80
	private ItemDBData.EquipType selectedEquipType; // 0x88
	private UICharacterModelBaseManager modelManager; // 0x90
	private SystemTextManager systemTextManager; // 0x98
	private ItemTextManager itemTextManager; // 0xA0
	private Dictionary<int, List<ItemData>> avatarItemList; // 0xA8
	private bool selectedAvatarCategory; // 0xB0
	private int selectedAvatarCategoryType; // 0xB4
	private ItemDBData.ItemType selectAvaterItemType; // 0xB8
	private int selectedItemUid; // 0xBC
	private ItemData selectedItemData; // 0xC0
	private ItemData holdItemData; // 0xC8
	private List<ItemData> newAvatarEquipList; // 0xD0
	private List<ItemData> newPrintItemList; // 0xD8
	private const int newAvatarCategory = -10;
	private bool isMan; // 0xE0

	// Methods

	// RVA: 0x19B2550 Offset: 0x19AE550 VA: 0x19B2550 Slot: 5
	public override void Initialize(PlayerDataManager playerDataManager, IUIEquipMainManager manager) { }

	// RVA: 0x19B2FE8 Offset: 0x19AEFE8 VA: 0x19B2FE8 Slot: 6
	public override void Open() { }

	// RVA: 0x19B2FF0 Offset: 0x19AEFF0 VA: 0x19B2FF0 Slot: 7
	public override void Close() { }

	// RVA: 0x19B30FC Offset: 0x19AF0FC VA: 0x19B30FC Slot: 8
	public override void SelectedEquipType(ItemDBData.EquipType equipType) { }

	// RVA: 0x19B4F24 Offset: 0x19B0F24 VA: 0x19B4F24 Slot: 9
	public override bool Cancel() { }

	// RVA: 0x19B4F80 Offset: 0x19B0F80 VA: 0x19B4F80 Slot: 10
	public override bool Enter() { }

	// RVA: 0x19B5090 Offset: 0x19B1090 VA: 0x19B5090 Slot: 12
	public override string GetSelectedItemText(ItemData itemData) { }

	// RVA: 0x19B51CC Offset: 0x19B11CC VA: 0x19B51CC Slot: 11
	public override void SelectedItem(ItemData itemData) { }

	// RVA: 0x19B51D4 Offset: 0x19B11D4 VA: 0x19B51D4
	private void SelectedItem(ItemData itemData, bool selected) { }

	// RVA: 0x19B5820 Offset: 0x19B1820 VA: 0x19B5820 Slot: 4
	public override bool InputLock() { }

	// RVA: 0x19B3008 Offset: 0x19AF008 VA: 0x19B3008
	private bool Clear() { }

	// RVA: 0x19B55E0 Offset: 0x19B15E0 VA: 0x19B55E0
	private void EquipChangeStatusData(string text, int changeEquipStatusPoint, int type, bool isActive) { }

	// RVA: 0x19B2B08 Offset: 0x19AEB08 VA: 0x19B2B08
	private void UpdateModel() { }

	// RVA: 0x19B508C Offset: 0x19B108C VA: 0x19B508C
	private void SetEquipItemModel(ItemDBData.EquipType equipType, ItemData equipItem) { }

	// RVA: 0x19B55FC Offset: 0x19B15FC VA: 0x19B55FC
	private void FocusSetEquipItemModel(ItemDBData.EquipType equipType, ItemData equipItem) { }

	// RVA: 0x19B5050 Offset: 0x19B1050 VA: 0x19B5050
	private ItemDBData.EquipType CheakEquipType(ItemDBData.EquipType equipType) { }

	// RVA: 0x19B3D5C Offset: 0x19AFD5C VA: 0x19B3D5C
	private void AvatarEquipSelect(bool categoryPopCheck) { }

	// RVA: 0x19B5828 Offset: 0x19B1828 VA: 0x19B5828
	public void PushAvatarEquipCategory(int category) { }

	// RVA: 0x19B5ADC Offset: 0x19B1ADC VA: 0x19B5ADC
	public void PushAvatarEquipCategoryEx(int category, int pageId) { }

	// RVA: 0x19B5C10 Offset: 0x19B1C10 VA: 0x19B5C10
	private void ClosedUpdate() { }

	// RVA: 0x19B2C48 Offset: 0x19AEC48 VA: 0x19B2C48
	private List<ItemData> GetNewAvatarEquipList() { }

	// RVA: 0x19B5844 Offset: 0x19B1844 VA: 0x19B5844
	private void UpdateNewAvatarEquipList() { }

	// RVA: 0x19B5C80 Offset: 0x19B1C80 VA: 0x19B5C80
	public void .ctor() { }
}
