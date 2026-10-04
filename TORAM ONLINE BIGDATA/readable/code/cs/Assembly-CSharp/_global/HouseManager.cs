// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HouseManager : Singleton<HouseManager>, ISceneChangeManager // TypeDefIndex: 3963
{
	// Fields
	private static readonly string EnterSaveName; // 0x0
	public static readonly Color[] ColorPallet; // 0x8
	private const int defaultBGMItemId = 4100017;
	private GameManager gameManager; // 0x20
	private bool initRecipeFlag; // 0x28
	private bool initHouseFlag; // 0x29
	private bool craeteHouseFlag; // 0x2A
	private HouseRecipeManager recipeManager; // 0x30
	private HousePartitionManager partitionManager; // 0x38
	private HouseComponentManager componentManager; // 0x40
	private HouseObjectManager objectManager; // 0x48
	private HousePetManager petManager; // 0x50
	private HouseFarmManager farmManager; // 0x58
	private HouseCuisineManager cuisineManager; // 0x60
	private List<HouseEntryData> otherHouseEntryList; // 0x68
	private PlayerDataManager player; // 0x70
	[CompilerGenerated]
	private byte <EditState>k__BackingField; // 0x78
	private byte serverEditState; // 0x79
	private byte updateEditState; // 0x7A
	[CompilerGenerated]
	private bool <IsConnection>k__BackingField; // 0x7B
	private DateTime updateTime; // 0x80
	private int houseEnterTryCount; // 0x88
	private HouseSlotData[] houseSlotList; // 0x90
	private byte nowSelectSlotNo; // 0x98
	private const int craneGameObjId = 600180;
	private const int mahjongObjId = 200059;
	[CompilerGenerated]
	private int <ErrCode>k__BackingField; // 0x9C
	[CompilerGenerated]
	private string <HouseName>k__BackingField; // 0xA0
	private bool emergencyHouseLeave; // 0xA8
	private bool emergencyForceHouseLeave; // 0xA9
	[CompilerGenerated]
	private int <HouseBGMItemId>k__BackingField; // 0xAC
	[CompilerGenerated]
	private DateTime <BgmUpdateTime>k__BackingField; // 0xB0
	[CompilerGenerated]
	private MyRoomEventSendData <MyRoomEventData>k__BackingField; // 0xB8

	// Properties
	public byte EditState { get; set; }
	public bool IsConnection { get; set; }
	public bool IsMyroom { get; }
	public bool IsEdit { get; }
	public bool IsServerEdit { get; }
	public bool IsPrivate { get; }
	public bool IsCreateHouse { get; }
	public bool CreateHouseFlag { get; }
	public bool IsHouseBuyed { get; }
	public bool IsHouseFarm { get; }
	public HouseEntryData[] OtherHouseEntryList { get; }
	public HouseRecipeManager RecipeManager { get; }
	public HousePartitionManager PartitionManager { get; }
	public HouseComponentManager ComponentManager { get; }
	public HouseObjectManager ObjectManager { get; }
	public HousePetManager PetManager { get; }
	public HouseFarmManager FarmManager { get; }
	public HouseCuisineManager CuisineManager { get; }
	private PlayerDataManager playerData { get; }
	public int ErrCode { get; set; }
	public string HouseName { get; set; }
	public bool IsMaxItem { get; }
	public int HouseBGMItemId { get; set; }
	public DateTime BgmUpdateTime { get; set; }
	public MyRoomEventSendData MyRoomEventData { get; set; }
	public HouseSlotData[] HouseSlotList { get; }
	public byte NowSelectSlot { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x241FA40 Offset: 0x241BA40 VA: 0x241FA40
	public byte get_EditState() { }

	[CompilerGenerated]
	// RVA: 0x241FA48 Offset: 0x241BA48 VA: 0x241FA48
	private void set_EditState(byte value) { }

	[CompilerGenerated]
	// RVA: 0x241FA50 Offset: 0x241BA50 VA: 0x241FA50
	public bool get_IsConnection() { }

	[CompilerGenerated]
	// RVA: 0x241FA58 Offset: 0x241BA58 VA: 0x241FA58
	private void set_IsConnection(bool value) { }

	// RVA: 0x241FA64 Offset: 0x241BA64 VA: 0x241FA64
	public void CraneGameEnterMethod() { }

	// RVA: 0x241FAF4 Offset: 0x241BAF4 VA: 0x241FAF4
	public void MahjongGameEnter() { }

	// RVA: 0x241FB84 Offset: 0x241BB84 VA: 0x241FB84
	public bool get_IsMyroom() { }

	// RVA: 0x2413F5C Offset: 0x240FF5C VA: 0x2413F5C
	public bool get_IsEdit() { }

	// RVA: 0x241FCA4 Offset: 0x241BCA4 VA: 0x241FCA4
	public bool get_IsServerEdit() { }

	// RVA: 0x241FCB0 Offset: 0x241BCB0 VA: 0x241FCB0
	public bool get_IsPrivate() { }

	// RVA: 0x241FCBC Offset: 0x241BCBC VA: 0x241FCBC
	public bool get_IsCreateHouse() { }

	// RVA: 0x241FCCC Offset: 0x241BCCC VA: 0x241FCCC
	public bool get_CreateHouseFlag() { }

	// RVA: 0x241FCD4 Offset: 0x241BCD4 VA: 0x241FCD4
	public bool get_IsHouseBuyed() { }

	// RVA: 0x241FCE4 Offset: 0x241BCE4 VA: 0x241FCE4
	public bool get_IsHouseFarm() { }

	// RVA: 0x241FD64 Offset: 0x241BD64 VA: 0x241FD64
	public HouseEntryData[] get_OtherHouseEntryList() { }

	// RVA: 0x241FDB4 Offset: 0x241BDB4 VA: 0x241FDB4
	public HouseRecipeManager get_RecipeManager() { }

	// RVA: 0x241FDBC Offset: 0x241BDBC VA: 0x241FDBC
	public HousePartitionManager get_PartitionManager() { }

	// RVA: 0x241FDC4 Offset: 0x241BDC4 VA: 0x241FDC4
	public HouseComponentManager get_ComponentManager() { }

	// RVA: 0x241FDCC Offset: 0x241BDCC VA: 0x241FDCC
	public HouseObjectManager get_ObjectManager() { }

	// RVA: 0x241FDD4 Offset: 0x241BDD4 VA: 0x241FDD4
	public HousePetManager get_PetManager() { }

	// RVA: 0x241FDDC Offset: 0x241BDDC VA: 0x241FDDC
	public HouseFarmManager get_FarmManager() { }

	// RVA: 0x241FDE4 Offset: 0x241BDE4 VA: 0x241FDE4
	public HouseCuisineManager get_CuisineManager() { }

	// RVA: 0x241FC20 Offset: 0x241BC20 VA: 0x241FC20
	private PlayerDataManager get_playerData() { }

	[CompilerGenerated]
	// RVA: 0x241FDEC Offset: 0x241BDEC VA: 0x241FDEC
	private void set_ErrCode(int value) { }

	[CompilerGenerated]
	// RVA: 0x241FDF4 Offset: 0x241BDF4 VA: 0x241FDF4
	public int get_ErrCode() { }

	[CompilerGenerated]
	// RVA: 0x241FDFC Offset: 0x241BDFC VA: 0x241FDFC
	private void set_HouseName(string value) { }

	[CompilerGenerated]
	// RVA: 0x241FE04 Offset: 0x241BE04 VA: 0x241FE04
	public string get_HouseName() { }

	// RVA: 0x241FE0C Offset: 0x241BE0C VA: 0x241FE0C
	public bool get_IsMaxItem() { }

	[CompilerGenerated]
	// RVA: 0x241FE28 Offset: 0x241BE28 VA: 0x241FE28
	private void set_HouseBGMItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x241FE30 Offset: 0x241BE30 VA: 0x241FE30
	public int get_HouseBGMItemId() { }

	[CompilerGenerated]
	// RVA: 0x241FE38 Offset: 0x241BE38 VA: 0x241FE38
	private void set_BgmUpdateTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x241FE40 Offset: 0x241BE40 VA: 0x241FE40
	public DateTime get_BgmUpdateTime() { }

	[CompilerGenerated]
	// RVA: 0x241FE48 Offset: 0x241BE48 VA: 0x241FE48
	public void set_MyRoomEventData(MyRoomEventSendData value) { }

	[CompilerGenerated]
	// RVA: 0x241FE50 Offset: 0x241BE50 VA: 0x241FE50
	public MyRoomEventSendData get_MyRoomEventData() { }

	// RVA: 0x241FE58 Offset: 0x241BE58 VA: 0x241FE58
	public HouseSlotData[] get_HouseSlotList() { }

	// RVA: 0x241FE60 Offset: 0x241BE60 VA: 0x241FE60
	public byte get_NowSelectSlot() { }

	// RVA: 0x241FE68 Offset: 0x241BE68 VA: 0x241FE68
	private void Awake() { }

	// RVA: 0x241FF6C Offset: 0x241BF6C VA: 0x241FF6C
	private void Start() { }

	// RVA: 0x241FF8C Offset: 0x241BF8C VA: 0x241FF8C
	private void Update() { }

	[IteratorStateMachine(typeof(HouseManager.<CreateHouse>d__107))]
	// RVA: 0x24200A8 Offset: 0x241C0A8 VA: 0x24200A8
	public IEnumerator CreateHouse(bool isSetHouseObject = True) { }

	[IteratorStateMachine(typeof(HouseManager.<CreateFarm>d__108))]
	// RVA: 0x2420130 Offset: 0x241C130 VA: 0x2420130
	public IEnumerator CreateFarm() { }

	// RVA: 0x24201A4 Offset: 0x241C1A4 VA: 0x24201A4
	public void UpdateHouseBGMItemId(int id) { }

	[IteratorStateMachine(typeof(HouseManager.<PlayHouseBGM>d__110))]
	// RVA: 0x2420340 Offset: 0x241C340 VA: 0x2420340
	private IEnumerator PlayHouseBGM(int id) { }

	// RVA: 0x24203C4 Offset: 0x241C3C4 VA: 0x24203C4
	public bool CheckSetFurnitureItem(HouseObjType type) { }

	// RVA: 0x24203E0 Offset: 0x241C3E0 VA: 0x24203E0
	public byte[] GetFurnitureItemColor(int objId) { }

	// RVA: 0x24203FC Offset: 0x241C3FC VA: 0x24203FC
	public void SetFurnitureItemColor(int objId, GameObject model) { }

	// RVA: 0x2420418 Offset: 0x241C418 VA: 0x2420418
	public void SetFurnitureItem(FurnitureCoordinateData coordinateData) { }

	[IteratorStateMachine(typeof(HouseManager.<SetWaitFurnitureItem>d__115))]
	// RVA: 0x242055C Offset: 0x241C55C VA: 0x242055C
	private IEnumerator SetWaitFurnitureItem(FurnitureCoordinateData coordinateData) { }

	[IteratorStateMachine(typeof(HouseManager.<SetFurnitureItem>d__116))]
	// RVA: 0x24204BC Offset: 0x241C4BC VA: 0x24204BC
	private IEnumerator SetFurnitureItem(FurnitureCoordinateData coordinateData, float heightY) { }

	// RVA: 0x24205EC Offset: 0x241C5EC VA: 0x24205EC
	public void RemoveFurnitureItemModel(int uid) { }

	// RVA: 0x2420608 Offset: 0x241C608 VA: 0x2420608
	public bool ResetFurnitureItemModel(int uid) { }

	// RVA: 0x2420624 Offset: 0x241C624 VA: 0x2420624
	public int CheckCoordinateChip(int uid, int itemId, int[] chipId) { }

	// RVA: 0x24206D8 Offset: 0x241C6D8 VA: 0x24206D8
	public float GetFurnitureItemModelY(int uid) { }

	// RVA: 0x24206F4 Offset: 0x241C6F4 VA: 0x24206F4
	public bool CheckCoordinateChipAll(int[] chipId) { }

	// RVA: 0x2420710 Offset: 0x241C710 VA: 0x2420710
	public void EnabledFurnitureItemEditEvent(bool flag) { }

	// RVA: 0x2420730 Offset: 0x241C730 VA: 0x2420730
	public List<int> GetOnPartitionCoordinate(int[] partitionList) { }

	// RVA: 0x242074C Offset: 0x241C74C VA: 0x242074C
	public List<int> GetOnRoomWallCoordinate(int[] partitionList) { }

	// RVA: 0x2420768 Offset: 0x241C768 VA: 0x2420768
	public GameObject ChangeTargetFamily() { }

	// RVA: 0x2420788 Offset: 0x241C788 VA: 0x2420788
	public bool CultivationPlant(short index, int produceId, short point, byte bonus) { }

	// RVA: 0x2420838 Offset: 0x241C838 VA: 0x2420838
	public void ReceiveCultivationPlant(short index, int produceId) { }

	[IteratorStateMachine(typeof(HouseManager.<AddProduceDataModel>d__128))]
	// RVA: 0x2420954 Offset: 0x241C954 VA: 0x2420954
	private IEnumerator AddProduceDataModel(ProduceDataBase data, int modelId, Action<bool> callback) { }

	// RVA: 0x2420A08 Offset: 0x241CA08 VA: 0x2420A08
	public void ReceiveParameterFailed(byte operationCode, byte subOperationCode, short returnCode) { }

	// RVA: 0x2420D4C Offset: 0x241CD4C VA: 0x2420D4C
	public bool HouseConstruction(byte floorHeight, List<int> item) { }

	// RVA: 0x2420DE4 Offset: 0x241CDE4 VA: 0x2420DE4
	public void ReceiveHouseConstruction(HouseConstructionResponse response) { }

	// RVA: 0x2420E30 Offset: 0x241CE30 VA: 0x2420E30
	public bool PartitionEdit(int startPositionId, Dictionary<HousePartsType, List<int>> updateList) { }

	// RVA: 0x2420E80 Offset: 0x241CE80 VA: 0x2420E80
	public void ReceivePartitionEdit(HousePartitionEditResponse response) { }

	// RVA: 0x2420EE4 Offset: 0x241CEE4 VA: 0x2420EE4
	public bool AddCoordinate(int uid, int objId, int parentUid, int position, byte rotation, Vector4 chipSize) { }

	// RVA: 0x2420FF8 Offset: 0x241CFF8 VA: 0x2420FF8
	public bool MoveCoordinate(int uid, int objId, int parentUid, int position, byte rotation, Vector4 chipSize) { }

	// RVA: 0x24210C0 Offset: 0x241D0C0 VA: 0x24210C0
	public bool RemoveCoordinate(int uid) { }

	// RVA: 0x2421214 Offset: 0x241D214 VA: 0x2421214
	public bool RemoveAllCoordinate() { }

	// RVA: 0x2421270 Offset: 0x241D270 VA: 0x2421270
	public void ReceiveHouseCoordinate(HouseCoordinateResponse response) { }

	// RVA: 0x24212D4 Offset: 0x241D2D4 VA: 0x24212D4
	public void ReceiveHouseCoordinate(HouseCoordinateRemovesResponse response) { }

	// RVA: 0x2421304 Offset: 0x241D304 VA: 0x2421304
	public bool HouseOtherList(byte type) { }

	// RVA: 0x24213E0 Offset: 0x241D3E0 VA: 0x24213E0
	public void ReceiveHouseOtherList(HouseOtherListResponse response) { }

	// RVA: 0x2421448 Offset: 0x241D448 VA: 0x2421448
	public void GMEnterOtherPlayerHouse(int houseId) { }

	// RVA: 0x2421474 Offset: 0x241D474 VA: 0x2421474
	public bool EntryCheck() { }

	// RVA: 0x24214BC Offset: 0x241D4BC VA: 0x24214BC
	public void ReceiveEntryCheck(byte mode) { }

	// RVA: 0x24214CC Offset: 0x241D4CC VA: 0x24214CC
	public bool HouseSaveEntry(byte saveEdit) { }

	// RVA: 0x2421528 Offset: 0x241D528 VA: 0x2421528
	public bool StartEdit() { }

	// RVA: 0x2421688 Offset: 0x241D688 VA: 0x2421688
	public bool EndEdit() { }

	// RVA: 0x24217CC Offset: 0x241D7CC VA: 0x24217CC
	public void PrivateOpenCheckHouseLeave() { }

	// RVA: 0x2421808 Offset: 0x241D808 VA: 0x2421808
	public void CheckHouseLeave() { }

	// RVA: 0x2421848 Offset: 0x241D848 VA: 0x2421848
	public void ReceiveEndEditHouseLeave(byte mode) { }

	// RVA: 0x2420D3C Offset: 0x241CD3C VA: 0x2420D3C
	public void ReceiveHouseMode(byte edit) { }

	// RVA: 0x2421874 Offset: 0x241D874 VA: 0x2421874
	public byte HouseInitialLandPurchase(int gold) { }

	// RVA: 0x2421924 Offset: 0x241D924 VA: 0x2421924
	public void ReceiveHouseInitialLandPurchase(HouseInitialLandPurchaseResponse response) { }

	// RVA: 0x2421934 Offset: 0x241D934 VA: 0x2421934
	public bool HouseLandPurchase(byte buyArea, int gold, int orb, bool direct) { }

	// RVA: 0x24219E0 Offset: 0x241D9E0 VA: 0x24219E0
	public void ReceiveHouseLandPurchase(HouseLandPurchaseResponse response) { }

	// RVA: 0x2421A50 Offset: 0x241DA50 VA: 0x2421A50
	public bool CreateHouseFurnitureItem(int objId, bool direct, int orbNum, int useOrbNum) { }

	// RVA: 0x2421AD8 Offset: 0x241DAD8 VA: 0x2421AD8
	public void ReceiveCreateHouseFurnitureItem(HouseCreateObjItemResponse response) { }

	// RVA: 0x2421B0C Offset: 0x241DB0C VA: 0x2421B0C
	public bool GetBelonginsList(bool reload) { }

	// RVA: 0x2421B70 Offset: 0x241DB70 VA: 0x2421B70
	public void ReceiveGetBelonginsList(HouseBelonginsListResponse response) { }

	// RVA: 0x2421BB8 Offset: 0x241DBB8 VA: 0x2421BB8
	public void ReceiveUpdate(OperationResponse response) { }

	// RVA: 0x2421D28 Offset: 0x241DD28 VA: 0x2421D28
	public bool UpdateObjItemColor(int objId, byte[] color) { }

	// RVA: 0x2421E18 Offset: 0x241DE18 VA: 0x2421E18
	public void ReceiveUpdateObjItem(HouseUpdateObjItemResponse response) { }

	// RVA: 0x2421E34 Offset: 0x241DE34 VA: 0x2421E34
	public void ReceiveEventPetOwnership(PetOwnershipEvent ownershipEvent) { }

	// RVA: 0x2421EC8 Offset: 0x241DEC8 VA: 0x2421EC8
	public void ReceiveHousePetOwnershipUpdate(HousePetOwnershipUpdateResponse response) { }

	// RVA: 0x2421F5C Offset: 0x241DF5C VA: 0x2421F5C
	public void ReceiveStrayPetUpdate(PetModelData petModelData) { }

	// RVA: 0x2421FA0 Offset: 0x241DFA0 VA: 0x2421FA0
	public bool RoomAllClear() { }

	// RVA: 0x2421FEC Offset: 0x241DFEC VA: 0x2421FEC
	public void ResetErrCode() { }

	[IteratorStateMachine(typeof(HouseManager.<LoadEnterHouseData>d__168))]
	// RVA: 0x2421FF8 Offset: 0x241DFF8 VA: 0x2421FF8
	public IEnumerator LoadEnterHouseData(HouseReadOnlyData readData, CultivationSendData[] cultivationSendData, bool loadHouse, bool loadFarm) { }

	// RVA: 0x24220BC Offset: 0x241E0BC VA: 0x24220BC
	private void LoadHouseData(HouseReadOnlyData readData) { }

	// RVA: 0x2422454 Offset: 0x241E454 VA: 0x2422454
	private void LoadFramData(CultivationSendData[] cultivationSendData) { }

	// RVA: 0x2422470 Offset: 0x241E470 VA: 0x2422470
	public bool PetRaceLeaveMethod(bool errStop = False) { }

	// RVA: 0x2422754 Offset: 0x241E754 VA: 0x2422754
	public bool PetRaceGiveUpMethod(bool errStop = False) { }

	// RVA: 0x2422A38 Offset: 0x241EA38 VA: 0x2422A38
	public static byte LoadHeader(MemoryStream ms, Dictionary<byte, long> header) { }

	// RVA: 0x2422AF4 Offset: 0x241EAF4 VA: 0x2422AF4
	public static int GetHouseBgmId() { }

	// RVA: 0x24202F0 Offset: 0x241C2F0 VA: 0x24202F0
	public int GetBgmId() { }

	// RVA: 0x2422B98 Offset: 0x241EB98 VA: 0x2422B98
	public void GetSaveSlotData() { }

	// RVA: 0x2422C20 Offset: 0x241EC20 VA: 0x2422C20
	public void UpdateSaveSlotData(byte slotNo, string memo) { }

	// RVA: 0x2422CC0 Offset: 0x241ECC0 VA: 0x2422CC0
	public void ChangeSaveSlot(byte slotNo) { }

	// RVA: 0x2422D58 Offset: 0x241ED58 VA: 0x2422D58
	public void DebugCheckCookingItem(List<int> mainCookingItems, List<int> subCookingItems) { }

	// RVA: 0x2422D5C Offset: 0x241ED5C VA: 0x2422D5C Slot: 4
	public void OnEnter() { }

	[IteratorStateMachine(typeof(HouseManager.<ChangeMyRoomEventPanel>d__181))]
	// RVA: 0x24230D4 Offset: 0x241F0D4 VA: 0x24230D4
	public IEnumerator ChangeMyRoomEventPanel() { }

	// RVA: 0x242312C Offset: 0x241F12C VA: 0x242312C Slot: 5
	public void OnLeave() { }

	// RVA: 0x24232C4 Offset: 0x241F2C4 VA: 0x24232C4
	public void .ctor() { }

	// RVA: 0x2423570 Offset: 0x241F570 VA: 0x2423570
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x24237F4 Offset: 0x241F7F4 VA: 0x24237F4
	private void <ReceiveCultivationPlant>b__127_0(bool x) { }
}
