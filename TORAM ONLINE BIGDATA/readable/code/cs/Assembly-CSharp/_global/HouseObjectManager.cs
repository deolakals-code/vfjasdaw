// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HouseObjectManager // TypeDefIndex: 1979
{
	// Fields
	private Dictionary<int, int> itemData; // 0x10
	private Dictionary<int, FurnitureCoordinateData> furnitureCoordinateData; // 0x18
	private Dictionary<int, FurnitureArrangeData> furnitureArrangeData; // 0x20
	private Dictionary<int, GameObject> furnitureCoordinateModelData; // 0x28
	private Dictionary<int, EventArea> furnitureCoordinateEditArea; // 0x30
	private Dictionary<int, int[]> furnitureCoordinateSetArea; // 0x38
	private Dictionary<int, int[]> parentFurnitureCoordinateArea; // 0x40
	private Dictionary<int, int> childParentFurnitureCoordinateId; // 0x48
	public List<int> cookingItemList; // 0x50
	private float areaDist; // 0x58
	private float updateTime; // 0x5C
	private List<int> mainCookingItemList; // 0x60
	private List<int> subCookingItemList; // 0x68
	private bool isDebugCheckCookItem; // 0x70

	// Properties
	public static int MaxData { get; }
	public bool IsMaxItem { get; }
	public int SetItemNum { get; }
	public bool IsLoadObjectItemData { get; }
	public FurnitureCoordinateData[] FurnitureCoordinateData { get; }
	public FurnitureCoordinateData[] CookingFurnitureCoordinateData { get; }
	public bool IsCookingItem { get; }

	// Methods

	// RVA: 0x211A578 Offset: 0x2116578 VA: 0x211A578
	public static int get_MaxData() { }

	// RVA: 0x211A628 Offset: 0x2116628 VA: 0x211A628
	public bool get_IsMaxItem() { }

	// RVA: 0x211A68C Offset: 0x211668C VA: 0x211A68C
	public int get_SetItemNum() { }

	// RVA: 0x211A6DC Offset: 0x21166DC VA: 0x211A6DC
	public bool get_IsLoadObjectItemData() { }

	// RVA: 0x211A738 Offset: 0x2116738 VA: 0x211A738
	public FurnitureCoordinateData[] get_FurnitureCoordinateData() { }

	// RVA: 0x211A7A4 Offset: 0x21167A4 VA: 0x211A7A4
	public FurnitureCoordinateData[] get_CookingFurnitureCoordinateData() { }

	// RVA: 0x211A870 Offset: 0x2116870 VA: 0x211A870
	public bool get_IsCookingItem() { }

	// RVA: 0x211A8C0 Offset: 0x21168C0 VA: 0x211A8C0
	public void Update(bool isRoom, Vector3 viewPos) { }

	// RVA: 0x211B314 Offset: 0x2117314 VA: 0x211B314
	public bool CheckSetFurnitureItem(HouseObjType type) { }

	// RVA: 0x211B514 Offset: 0x2117514 VA: 0x211B514
	public byte[] GetFurnitureItemColor(int objId) { }

	// RVA: 0x211B624 Offset: 0x2117624 VA: 0x211B624
	public void SetFurnitureItemColor(int objId, GameObject model) { }

	// RVA: 0x211B7F0 Offset: 0x21177F0 VA: 0x211B7F0
	public bool CheckCoordinateModel(FurnitureCoordinateData coordinateData, float heightY) { }

	// RVA: 0x211B8EC Offset: 0x21178EC VA: 0x211B8EC
	public void SetFurnitureItemModel(FurnitureCoordinateData coordinateData, GameObject model, float heightY) { }

	// RVA: 0x211CB00 Offset: 0x2118B00 VA: 0x211CB00
	private bool SettingLinkAnimationObject(int uid, GameObject model) { }

	// RVA: 0x211CFA0 Offset: 0x2118FA0 VA: 0x211CFA0
	public void RemoveFurnitureItemModel(int uid) { }

	// RVA: 0x211CBFC Offset: 0x2118BFC VA: 0x211CBFC
	public bool ResetFurnitureItemModel(int uid) { }

	// RVA: 0x211D1FC Offset: 0x21191FC VA: 0x211D1FC
	public int CheckCoordinateChip(int uid, int itemId, int[] chipId) { }

	// RVA: 0x211D684 Offset: 0x2119684 VA: 0x211D684
	public bool CheckWallChip(int uid) { }

	// RVA: 0x211C958 Offset: 0x2118958 VA: 0x211C958
	public float GetFurnitureItemModelY(int uid) { }

	// RVA: 0x211DB98 Offset: 0x2119B98 VA: 0x211DB98
	public bool CheckCoordinateChipAll(int[] chipId) { }

	// RVA: 0x211CCBC Offset: 0x2118CBC VA: 0x211CCBC
	private void SetFurnitureItemEditEvent(FurnitureCoordinateData coordinateData, GameObject model) { }

	// RVA: 0x211D0C8 Offset: 0x21190C8 VA: 0x211D0C8
	private void RemoveFurnitureItemEditEvent(int uid) { }

	// RVA: 0x211DE64 Offset: 0x2119E64 VA: 0x211DE64
	public void EnabledFurnitureItemEditEvent(bool flag) { }

	// RVA: 0x211E030 Offset: 0x211A030 VA: 0x211E030
	public List<int> GetOnPartitionCoordinate(int[] partitionList) { }

	// RVA: 0x211E6C8 Offset: 0x211A6C8 VA: 0x211E6C8
	public List<int> GetOnRoomWallCoordinate(int[] partitionList) { }

	// RVA: 0x211EAFC Offset: 0x211AAFC VA: 0x211EAFC
	public bool ParentPosition(int parentUid, int position, byte rotation, Vector4 chipSize, out int parentPosition, out byte parentRotation) { }

	// RVA: 0x211E558 Offset: 0x211A558 VA: 0x211E558
	public void GetChildrenList(int uid, List<int> list) { }

	// RVA: 0x211F320 Offset: 0x211B320 VA: 0x211F320
	private void ParentAreaClear(int childUid) { }

	// RVA: 0x211F42C Offset: 0x211B42C VA: 0x211F42C
	public int[] FurnitureItemAllClear() { }

	// RVA: 0x211F4D4 Offset: 0x211B4D4 VA: 0x211F4D4
	public GameObject ChangeTargetFamily(HouseManager houseManager) { }

	// RVA: 0x211F8A4 Offset: 0x211B8A4 VA: 0x211F8A4
	public bool LoadArrangement(byte[] buf) { }

	// RVA: 0x211FFEC Offset: 0x211BFEC VA: 0x211FFEC
	public bool LoadItemData(byte[] buf) { }

	// RVA: 0x2120454 Offset: 0x211C454 VA: 0x2120454
	public void UpdateRewardBgmItem(int[] rewardIdData) { }

	// RVA: 0x2120564 Offset: 0x211C564 VA: 0x2120564
	public void ReceiveParameterFailed(byte operationCode, short returnCode) { }

	// RVA: 0x2120568 Offset: 0x211C568 VA: 0x2120568
	public void ReceiveHouseCoordinate(HouseCoordinateResponse response, out FurnitureCoordinateData data) { }

	// RVA: 0x212069C Offset: 0x211C69C VA: 0x212069C
	public void ReceiveHouseCoordinateRemoves(int[] removeList) { }

	// RVA: 0x212075C Offset: 0x211C75C VA: 0x212075C
	public bool StartEdit() { }

	// RVA: 0x21209F4 Offset: 0x211C9F4 VA: 0x21209F4
	public void ReceiveUpdateObjItem(HouseUpdateObjItemResponse response) { }

	// RVA: 0x2120F34 Offset: 0x211CF34 VA: 0x2120F34
	public int GetObjCount(int objId) { }

	// RVA: 0x2120FAC Offset: 0x211CFAC VA: 0x2120FAC
	public void UpdateObjData(int objId, int count) { }

	// RVA: 0x2121014 Offset: 0x211D014 VA: 0x2121014
	public int GetFieldObjCount(int objId) { }

	// RVA: 0x2121134 Offset: 0x211D134 VA: 0x2121134
	public GameObject CloneSetObject(int uid) { }

	// RVA: 0x2121224 Offset: 0x211D224 VA: 0x2121224
	public FurnitureCoordinateData GetFurnitureCoordinateData(int uid) { }

	// RVA: 0x212129C Offset: 0x211D29C VA: 0x212129C
	public void OnEnter() { }

	// RVA: 0x212159C Offset: 0x211D59C VA: 0x212159C
	public void OnLeave() { }

	// RVA: 0x2121A18 Offset: 0x211DA18 VA: 0x2121A18
	public void DebugClearCookingItemList() { }

	// RVA: 0x2121A7C Offset: 0x211DA7C VA: 0x2121A7C
	public void DebugChangeFlagCheckCookItem(bool flag) { }

	// RVA: 0x2121A88 Offset: 0x211DA88 VA: 0x2121A88
	public void DebugCheckCookingItemList() { }

	// RVA: 0x2121B20 Offset: 0x211DB20 VA: 0x2121B20
	public void DebugCheckFlagCookItem() { }

	// RVA: 0x2121B34 Offset: 0x211DB34 VA: 0x2121B34
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2121E38 Offset: 0x211DE38 VA: 0x2121E38
	private bool <get_CookingFurnitureCoordinateData>b__20_0(FurnitureCoordinateData data) { }
}
