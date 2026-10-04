// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MasterItemDataManager : Singleton<MasterItemDataManager> // TypeDefIndex: 2038
{
	// Fields
	private Dictionary<int, ItemDBData> masterItemDataList; // 0x20
	private Dictionary<ItemDBData.ItemType, Dictionary<int, ItemDBData.ItemFlag>> modelItemFlag; // 0x28
	private Dictionary<CreateSupportItemType, List<int>> createSupportItem; // 0x30
	private List<int> avatarExChatItem; // 0x38

	// Methods

	// RVA: 0x213A788 Offset: 0x2136788 VA: 0x213A788
	public bool ReadItemData(byte[] data) { }

	// RVA: 0x213ADB4 Offset: 0x2136DB4 VA: 0x213ADB4
	public bool ReadItemProperty(byte[] data) { }

	// RVA: 0x213B248 Offset: 0x2137248 VA: 0x213B248
	public bool ReadCreateSupportItem(byte[] data) { }

	// RVA: 0x213B88C Offset: 0x213788C VA: 0x213B88C
	public ItemDBData GetMasterItemData(int id) { }

	// RVA: 0x213B920 Offset: 0x2137920 VA: 0x213B920
	public List<int> GetItemIdTypeList(ItemDBData.ItemType[] type) { }

	// RVA: 0x213BB6C Offset: 0x2137B6C VA: 0x213BB6C
	public List<int> GetCreateSupportItemList(CreateSupportItemType type) { }

	// RVA: 0x213BBDC Offset: 0x2137BDC VA: 0x213BBDC
	public bool CheckChatExAvatarItem(ItemData avatarOption) { }

	// RVA: 0x213BC48 Offset: 0x2137C48 VA: 0x213BC48
	public List<ItemDBData> GetMasterItemDataList(int modelId) { }

	// RVA: 0x213BD68 Offset: 0x2137D68 VA: 0x213BD68
	public List<int> GetAllMasterItemIdList(List<int> list) { }

	// RVA: 0x213BF34 Offset: 0x2137F34 VA: 0x213BF34
	public void .ctor() { }
}
