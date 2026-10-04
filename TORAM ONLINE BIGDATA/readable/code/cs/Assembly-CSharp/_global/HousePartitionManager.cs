// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HousePartitionManager // TypeDefIndex: 1980
{
	// Fields
	public const int PartitionMaxSize = 160;
	public const float PartitionPanelSize = 4;
	public const int ChipMaxSize = 640;
	public const float ChipPanelSize = 1;
	public const float BaseHeight = 10;
	public const int ParentChipMaxSize = 15;
	private Vector3 point; // 0x10
	private Vector3 size; // 0x1C
	private Dictionary<HousePartsType, List<int>> housePartitionList; // 0x28
	private Dictionary<HousePartsType, List<int>> housePartitionEditList; // 0x30
	private List<byte> retCheckPartsTypes; // 0x38
	private DefenceMapNode[,] mapChip; // 0x40
	[CompilerGenerated]
	private int <StartPartitionId>k__BackingField; // 0x48
	private int editStartPositionId; // 0x4C
	[CompilerGenerated]
	private bool <IsGarden>k__BackingField; // 0x50
	[CompilerGenerated]
	private bool <IsRoom>k__BackingField; // 0x51
	private bool isStrayPop; // 0x52

	// Properties
	public int StartPartitionId { get; set; }
	public bool IsGarden { get; set; }
	public bool IsRoom { get; set; }
	public static int PartitionMaxAraeData { get; }
	public Vector3 AreaSize { get; }
	public Vector3 PartitionSize { get; }
	public Vector3 Point { get; }
	public Vector3 WorldPoint { get; }
	public bool IsStrayPop { get; }
	public bool IsOutlineGarden { get; }
	public DefenceMapNode[,] MapChip { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2121EE4 Offset: 0x211DEE4 VA: 0x2121EE4
	public int get_StartPartitionId() { }

	[CompilerGenerated]
	// RVA: 0x2121EEC Offset: 0x211DEEC VA: 0x2121EEC
	private void set_StartPartitionId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2121EF4 Offset: 0x211DEF4 VA: 0x2121EF4
	public bool get_IsGarden() { }

	[CompilerGenerated]
	// RVA: 0x2121EFC Offset: 0x211DEFC VA: 0x2121EFC
	private void set_IsGarden(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2121F08 Offset: 0x211DF08 VA: 0x2121F08
	public bool get_IsRoom() { }

	[CompilerGenerated]
	// RVA: 0x2121F10 Offset: 0x211DF10 VA: 0x2121F10
	private void set_IsRoom(bool value) { }

	// RVA: 0x2121F1C Offset: 0x211DF1C VA: 0x2121F1C
	public static int get_PartitionMaxAraeData() { }

	// RVA: 0x2121F8C Offset: 0x211DF8C VA: 0x2121F8C
	public Vector3 get_AreaSize() { }

	// RVA: 0x2121FA8 Offset: 0x211DFA8 VA: 0x2121FA8
	public Vector3 get_PartitionSize() { }

	// RVA: 0x2121FB4 Offset: 0x211DFB4 VA: 0x2121FB4
	public Vector3 get_Point() { }

	// RVA: 0x2121FC0 Offset: 0x211DFC0 VA: 0x2121FC0
	public Vector3 get_WorldPoint() { }

	// RVA: 0x2121FDC Offset: 0x211DFDC VA: 0x2121FDC
	public bool get_IsStrayPop() { }

	// RVA: 0x212204C Offset: 0x211E04C VA: 0x212204C
	public bool get_IsOutlineGarden() { }

	// RVA: 0x2122054 Offset: 0x211E054 VA: 0x2122054
	public DefenceMapNode[,] get_MapChip() { }

	// RVA: 0x212205C Offset: 0x211E05C VA: 0x212205C
	public int GetExtensionLandGold(byte buyArea) { }

	// RVA: 0x2122078 Offset: 0x211E078 VA: 0x2122078
	public int GetExtensionLandArea(byte buyArea) { }

	// RVA: 0x21220C8 Offset: 0x211E0C8 VA: 0x21220C8
	public bool CheckPartsType(HousePartsType type, int id) { }

	// RVA: 0x2122170 Offset: 0x211E170 VA: 0x2122170
	public byte[] GetRoomPanelTypes(int panelId) { }

	// RVA: 0x2122C24 Offset: 0x211EC24 VA: 0x2122C24
	public byte GetRoomWallFlag(int panelId) { }

	// RVA: 0x2122D3C Offset: 0x211ED3C VA: 0x2122D3C
	public byte GetDoorFlag(int panelId) { }

	// RVA: 0x211B0B8 Offset: 0x21170B8 VA: 0x211B0B8
	public bool TryGetPartition(HousePartsType type, List<int> list) { }

	// RVA: 0x2122E08 Offset: 0x211EE08 VA: 0x2122E08
	public void UpdateStartPartitionId(int partitionId) { }

	// RVA: 0x2122E10 Offset: 0x211EE10 VA: 0x2122E10
	public Vector3 GetStartPosition() { }

	// RVA: 0x211D770 Offset: 0x2119770 VA: 0x211D770
	public bool CheckChipAreaData(bool room, int[] chipId) { }

	// RVA: 0x2122EB0 Offset: 0x211EEB0 VA: 0x2122EB0
	public Vector3[] GetPartitionPositions(int num) { }

	// RVA: 0x2123110 Offset: 0x211F110 VA: 0x2123110
	public bool TryGetGardenPartitionPosition(out Vector3 position) { }

	// RVA: 0x21237B4 Offset: 0x211F7B4 VA: 0x21237B4
	public void ReceiveParameterFailed(byte operationCode, short returnCode) { }

	// RVA: 0x21237B8 Offset: 0x211F7B8 VA: 0x21237B8
	public void AllClearData() { }

	// RVA: 0x2123AD8 Offset: 0x211FAD8 VA: 0x2123AD8
	public bool PartitionEdit(int startPositionId, Dictionary<HousePartsType, List<int>> updateList) { }

	// RVA: 0x2124760 Offset: 0x2120760 VA: 0x2124760
	public void ReceivePartitionEdit(HousePartitionEditResponse response) { }

	// RVA: 0x2125274 Offset: 0x2121274 VA: 0x2125274
	public bool HouseLandPurchase(byte buyArea, int gold, int haveGold, int orb, bool direct) { }

	// RVA: 0x2125390 Offset: 0x2121390 VA: 0x2125390
	public void ReceiveHouseLandPurchase(HouseLandPurchaseResponse response) { }

	// RVA: 0x2125434 Offset: 0x2121434 VA: 0x2125434
	public bool LoadPartition(byte[] buf, Vector3 pointData, Vector3 sizeData, int startPartitionId) { }

	// RVA: 0x211CABC Offset: 0x2118ABC VA: 0x211CABC
	public static int GetChipId(Vector3 position) { }

	// RVA: 0x211B2C4 Offset: 0x21172C4 VA: 0x211B2C4
	public static int GetPartitionId(Vector3 position) { }

	// RVA: 0x2125E1C Offset: 0x2121E1C VA: 0x2125E1C
	private static int GetId(Vector3 position, int max, float scale) { }

	// RVA: 0x211C93C Offset: 0x211893C VA: 0x211C93C
	public static Vector3 GetParentChipPosition(int chipId) { }

	// RVA: 0x211C930 Offset: 0x2118930 VA: 0x211C930
	public static Vector3 GetChipPosition(int chipId) { }

	// RVA: 0x2122E3C Offset: 0x211EE3C VA: 0x2122E3C
	public static Vector3 GetPartitionPosition(int partitionId) { }

	// RVA: 0x2125E6C Offset: 0x2121E6C VA: 0x2125E6C
	private static Vector3 GetIdPostition(int id, int max, float scale) { }

	// RVA: 0x2122E48 Offset: 0x211EE48 VA: 0x2122E48
	public static int ChipIdToPartitionId(int chipId) { }

	// RVA: 0x211E42C Offset: 0x211A42C VA: 0x211E42C
	public static int[] PartitionIdToChipId(int partitionId) { }

	// RVA: 0x2125EE0 Offset: 0x2121EE0 VA: 0x2125EE0
	public void OnEnter() { }

	// RVA: 0x2125EE4 Offset: 0x2121EE4 VA: 0x2125EE4
	public void OnLeave() { }

	// RVA: 0x2124A88 Offset: 0x2120A88 VA: 0x2124A88
	private DefenceMapNode[,] CreateMapChip(int width, int height) { }

	// RVA: 0x2125F44 Offset: 0x2121F44 VA: 0x2125F44
	public void SetCraneGamePartitionList() { }

	// RVA: 0x2126A0C Offset: 0x2122A0C VA: 0x2126A0C
	public void .ctor() { }
}
