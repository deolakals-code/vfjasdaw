// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GameManager : Singleton<GameManager> // TypeDefIndex: 4140
{
	// Fields
	[CompilerGenerated]
	private bool <IsReview>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsMasterServerConnected>k__BackingField; // 0x21
	[CompilerGenerated]
	private bool <IsFieldEntered>k__BackingField; // 0x22
	[CompilerGenerated]
	private bool <IsPlayerControlLock>k__BackingField; // 0x23
	[CompilerGenerated]
	private bool <IsFirstGameServer>k__BackingField; // 0x24
	[CompilerGenerated]
	private BattleMemberManager <BattleMemberManager>k__BackingField; // 0x28
	private Game engine; // 0x30
	private string serverAddress; // 0x38
	private string masterApplicationName; // 0x40
	private string gameApplicationName; // 0x48
	private string globalApplicationName; // 0x50
	private bool useTcp; // 0x58
	private bool isEngineConnection; // 0x59
	private bool isLoadFieldEnd; // 0x5A
	private IEnumerator battleEndCheckCoroutine; // 0x60
	private readonly List<ISceneChangeManager> sceneChangeManagerList; // 0x68
	private PlayerDataManager playerManager; // 0x70
	private CameraManager cameraManager; // 0x78
	private int maintenanceTime; // 0x80
	private float maintenanceCountStartTime; // 0x84
	private Settings gameSettings; // 0x88
	private MercenaryOperationManager mercenaryOperation; // 0x90
	private PetOperationManager petOperation; // 0x98
	private bool isEnableOfWebView; // 0xA0
	private const float webViewUpdateSeconds = 60;
	private float webViewUpdateTimer; // 0xA4
	[SerializeField]
	private ChangeEnterWorldManager changeEnterWorldManager; // 0xA8
	[CompilerGenerated]
	private bool <IsSelectEnterWorld>k__BackingField; // 0xB0
	[CompilerGenerated]
	private MultiWorkerThread <Thread>k__BackingField; // 0xB8
	private bool isAfterCreateAvatar; // 0xC0
	private readonly int clockCountDefault; // 0xC4
	private readonly int clockCheckMillisecondTime; // 0xC8
	private readonly float clockCheckMerginRate; // 0xCC
	private int clockServerTime; // 0xD0
	private int clockCount; // 0xD4
	private int clockOverCount; // 0xD8
	private int tragetFrame; // 0xDC
	private IncrementManager playerDamageIdManager; // 0xE0
	private IncrementManager mobDamageIdManager; // 0xE8

	// Properties
	public int AccountLevel { get; }
	public bool IsReview { get; set; }
	public bool IsConnect { get; }
	public bool IsReConnect { get; }
	public bool IsMasterServerConnected { get; set; }
	public bool IsFieldEntered { get; set; }
	public bool IsPlayerControlLock { get; set; }
	public DateTime TimeData { get; }
	public bool IsFirstGameServer { get; set; }
	public BattleMemberManager BattleMemberManager { get; set; }
	public int ScenarioOperationPoolNum { get; }
	public MercenaryOperationManager MercenaryOperation { get; }
	public PetOperationManager PetOpetarion { get; }
	public bool IsSelectEnterWorld { get; set; }
	public MultiWorkerThread Thread { get; set; }

	// Methods

	// RVA: 0x2434D80 Offset: 0x2430D80 VA: 0x2434D80
	public int get_AccountLevel() { }

	[CompilerGenerated]
	// RVA: 0x2434E30 Offset: 0x2430E30 VA: 0x2434E30
	public bool get_IsReview() { }

	[CompilerGenerated]
	// RVA: 0x2434E38 Offset: 0x2430E38 VA: 0x2434E38
	private void set_IsReview(bool value) { }

	// RVA: 0x2434E44 Offset: 0x2430E44 VA: 0x2434E44
	public bool get_IsConnect() { }

	// RVA: 0x2434ED4 Offset: 0x2430ED4 VA: 0x2434ED4
	public bool get_IsReConnect() { }

	[CompilerGenerated]
	// RVA: 0x2434F20 Offset: 0x2430F20 VA: 0x2434F20
	private void set_IsMasterServerConnected(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2434F2C Offset: 0x2430F2C VA: 0x2434F2C
	public bool get_IsMasterServerConnected() { }

	[CompilerGenerated]
	// RVA: 0x2434F34 Offset: 0x2430F34 VA: 0x2434F34
	public bool get_IsFieldEntered() { }

	[CompilerGenerated]
	// RVA: 0x2434F3C Offset: 0x2430F3C VA: 0x2434F3C
	private void set_IsFieldEntered(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2434F48 Offset: 0x2430F48 VA: 0x2434F48
	public bool get_IsPlayerControlLock() { }

	[CompilerGenerated]
	// RVA: 0x2434F50 Offset: 0x2430F50 VA: 0x2434F50
	private void set_IsPlayerControlLock(bool value) { }

	// RVA: 0x2434F5C Offset: 0x2430F5C VA: 0x2434F5C
	public DateTime get_TimeData() { }

	[CompilerGenerated]
	// RVA: 0x2434FC4 Offset: 0x2430FC4 VA: 0x2434FC4
	public bool get_IsFirstGameServer() { }

	[CompilerGenerated]
	// RVA: 0x2434FCC Offset: 0x2430FCC VA: 0x2434FCC
	private void set_IsFirstGameServer(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2434FD8 Offset: 0x2430FD8 VA: 0x2434FD8
	public BattleMemberManager get_BattleMemberManager() { }

	[CompilerGenerated]
	// RVA: 0x2434FE0 Offset: 0x2430FE0 VA: 0x2434FE0
	private void set_BattleMemberManager(BattleMemberManager value) { }

	// RVA: 0x2434FE8 Offset: 0x2430FE8 VA: 0x2434FE8
	public int get_ScenarioOperationPoolNum() { }

	// RVA: 0x243500C Offset: 0x243100C VA: 0x243500C
	public MercenaryOperationManager get_MercenaryOperation() { }

	// RVA: 0x2435090 Offset: 0x2431090 VA: 0x2435090
	public PetOperationManager get_PetOpetarion() { }

	[CompilerGenerated]
	// RVA: 0x2435114 Offset: 0x2431114 VA: 0x2435114
	public bool get_IsSelectEnterWorld() { }

	[CompilerGenerated]
	// RVA: 0x243511C Offset: 0x243111C VA: 0x243511C
	private void set_IsSelectEnterWorld(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2435128 Offset: 0x2431128 VA: 0x2435128
	public MultiWorkerThread get_Thread() { }

	[CompilerGenerated]
	// RVA: 0x2435130 Offset: 0x2431130 VA: 0x2435130
	private void set_Thread(MultiWorkerThread value) { }

	// RVA: 0x2435138 Offset: 0x2431138 VA: 0x2435138
	private void Awake() { }

	// RVA: 0x2435328 Offset: 0x2431328 VA: 0x2435328
	private void Start() { }

	// RVA: 0x2435460 Offset: 0x2431460 VA: 0x2435460
	private void Update() { }

	// RVA: 0x2435700 Offset: 0x2431700 VA: 0x2435700
	public void OnMasterConnect(int frame) { }

	// RVA: 0x243548C Offset: 0x243148C VA: 0x243548C
	private void checkClockUp() { }

	// RVA: 0x24358F4 Offset: 0x24318F4 VA: 0x24358F4
	private void OnApplicationQuit() { }

	// RVA: 0x2435990 Offset: 0x2431990 VA: 0x2435990
	public void AddSceneChangeManager(ISceneChangeManager changeManager) { }

	[IteratorStateMachine(typeof(GameManager.<StartConnectionWait>d__82))]
	// RVA: 0x2435A74 Offset: 0x2431A74 VA: 0x2435A74
	public IEnumerator StartConnectionWait(string assobimoId, string asobimoToken, int selectWorldId, Action<bool> callback) { }

	// RVA: 0x2435B0C Offset: 0x2431B0C VA: 0x2435B0C
	public void StartConnection(string assobimoId, string asobimoToken, int selectWorld, bool isList) { }

	// RVA: 0x24362A0 Offset: 0x24322A0 VA: 0x24362A0
	public IPAddress GetIpAddress(string serverIp) { }

	// RVA: 0x2436370 Offset: 0x2432370 VA: 0x2436370
	public void OnMasterSelectWorld(LoginResponse worldSelect) { }

	// RVA: 0x2436448 Offset: 0x2432448 VA: 0x2436448
	public void Reboot() { }

	[IteratorStateMachine(typeof(GameManager.<reboot>d__87))]
	// RVA: 0x2436468 Offset: 0x2432468 VA: 0x2436468
	private IEnumerator reboot() { }

	// RVA: 0x24364DC Offset: 0x24324DC VA: 0x24364DC
	public void ReceiveGameRejoin(IAccountUserData accountUserData, IAccountGameData accountGameData, IGuildGameData guildGameData, IHouseData houseData, Dictionary<byte, object> newProperties, IItemBagData itemBagData, IStatusData statusData, IGuildBufferData guildBufferData, IParamData paramData, IHouseBufferData houseBufferData, AvatarOptionDataBase[] OptionList, GameReJoinResponse rejoin) { }

	// RVA: 0x2436F5C Offset: 0x2432F5C VA: 0x2436F5C
	public void ReceiveEnterAvatar(IAccountUserData accountUserData, IAccountGameData accountGameData, IGuildGameData guildGameData, IHouseData houseData, Dictionary<byte, object> newProperties, IItemBagData itemBagData, IStatusData statusData, IGuildBufferData guildBufferData, IParamData paramData, IHouseBufferData houseBufferData, FishingData fishingData, AreaPopData AreaPop, PetEnterData petEnterData, AvatarOptionDataBase[] OptionList) { }

	// RVA: 0x2436820 Offset: 0x2432820 VA: 0x2436820
	private void gameJoinData(PlayerDataManager playerDataManager, IAccountUserData accountUserData, IAccountGameData accountGameData, IGuildGameData guildGameData, IHouseData houseData, Dictionary<byte, object> newProperties, IItemBagData itemBagData, IStatusData statusData, IGuildBufferData guildBufferData, IParamData paramData, IHouseBufferData houseBufferData, AvatarOptionDataBase[] optionList) { }

	// RVA: 0x2437878 Offset: 0x2433878 VA: 0x2437878
	public void GameLogin() { }

	// RVA: 0x2437884 Offset: 0x2433884 VA: 0x2437884
	public void GameLogout() { }

	// RVA: 0x2437998 Offset: 0x2433998 VA: 0x2437998
	public void SetMaintenanceTime(int serverTime, bool isMaintenance) { }

	[IteratorStateMachine(typeof(GameManager.<startMaintenanceCount>d__94))]
	// RVA: 0x2437C38 Offset: 0x2433C38 VA: 0x2437C38
	private IEnumerator startMaintenanceCount(bool isMaintenance) { }

	// RVA: 0x243642C Offset: 0x243242C VA: 0x243642C
	public void Disconnect() { }

	// RVA: 0x2437CC0 Offset: 0x2433CC0 VA: 0x2437CC0
	public void OnDisconnect() { }

	// RVA: 0x2437CC4 Offset: 0x2433CC4 VA: 0x2437CC4
	public void OnTimeoutDisconnect() { }

	// RVA: 0x2437CC8 Offset: 0x2433CC8 VA: 0x2437CC8
	public void OnOperationFailure() { }

	// RVA: 0x2437CD0 Offset: 0x2433CD0 VA: 0x2437CD0
	public void OnDisconnectedMasterServer() { }

	// RVA: 0x2437CD8 Offset: 0x2433CD8 VA: 0x2437CD8
	public void OnReconnectedMasterServer() { }

	// RVA: 0x2437CE4 Offset: 0x2433CE4 VA: 0x2437CE4
	public void OnConnectGameServer() { }

	[IteratorStateMachine(typeof(GameManager.<OnConnectWaitingGameServer>d__102))]
	// RVA: 0x2437D1C Offset: 0x2433D1C VA: 0x2437D1C
	private IEnumerator OnConnectWaitingGameServer() { }

	// RVA: 0x2437D90 Offset: 0x2433D90 VA: 0x2437D90
	public void OnConnectedGameServer() { }

	// RVA: 0x2437D98 Offset: 0x2433D98 VA: 0x2437D98
	public void SetIsReview(bool isReview) { }

	// RVA: 0x2437DA4 Offset: 0x2433DA4 VA: 0x2437DA4
	public void LoadAvatarCheck() { }

	// RVA: 0x2437DE0 Offset: 0x2433DE0 VA: 0x2437DE0
	public bool OperationConnection(IReconnectionData sendOperation) { }

	// RVA: 0x2437E38 Offset: 0x2433E38 VA: 0x2437E38
	public bool OperationConnection(IReconnectionSubData sendOperation) { }

	// RVA: 0x2437E90 Offset: 0x2433E90 VA: 0x2437E90
	public void LoginField() { }

	// RVA: 0x2437E9C Offset: 0x2433E9C VA: 0x2437E9C
	public void FirstLoadField(int fieldId, FieldRoomType roomType, byte roomId, Vector3 playerPos, HideSeekData[] hideSeekList) { }

	[IteratorStateMachine(typeof(GameManager.<ShowAnnounce>d__110))]
	// RVA: 0x2438118 Offset: 0x2434118 VA: 0x2438118
	public IEnumerator ShowAnnounce() { }

	[IteratorStateMachine(typeof(GameManager.<ShowAnnounceForce>d__111))]
	// RVA: 0x243818C Offset: 0x243418C VA: 0x243818C
	public IEnumerator ShowAnnounceForce() { }

	[IteratorStateMachine(typeof(GameManager.<ShowMaintenanceAnnounce>d__112))]
	// RVA: 0x2438200 Offset: 0x2434200 VA: 0x2438200
	public IEnumerator ShowMaintenanceAnnounce() { }

	// RVA: 0x2438274 Offset: 0x2434274 VA: 0x2438274
	public void ShowMaintenanceAnnounce(string text, Action callback) { }

	// RVA: 0x2438338 Offset: 0x2434338 VA: 0x2438338
	public void OnMaintenanceQuitInGame(bool isMaintenance) { }

	// RVA: 0x243850C Offset: 0x243450C VA: 0x243850C
	public void OnPrivateMaintenance(string debugMessage) { }

	[IteratorStateMachine(typeof(GameManager.<showMaintenanceAnnounceInGame>d__116))]
	// RVA: 0x2438A74 Offset: 0x2434A74 VA: 0x2438A74
	private IEnumerator showMaintenanceAnnounceInGame() { }

	[IteratorStateMachine(typeof(GameManager.<showMaintenanceAnnounce>d__117))]
	// RVA: 0x2438AE8 Offset: 0x2434AE8 VA: 0x2438AE8
	private IEnumerator showMaintenanceAnnounce() { }

	[IteratorStateMachine(typeof(GameManager.<showMaintenanceAnnounce>d__118))]
	// RVA: 0x2438294 Offset: 0x2434294 VA: 0x2438294
	private IEnumerator showMaintenanceAnnounce(string text, Action callback) { }

	[IteratorStateMachine(typeof(GameManager.<showAnnounce>d__119))]
	// RVA: 0x2438B5C Offset: 0x2434B5C VA: 0x2438B5C
	private IEnumerator showAnnounce() { }

	[IteratorStateMachine(typeof(GameManager.<showAlwaysAnnounce>d__120))]
	// RVA: 0x2438BD0 Offset: 0x2434BD0 VA: 0x2438BD0
	private IEnumerator showAlwaysAnnounce() { }

	[IteratorStateMachine(typeof(GameManager.<loginAnnounce>d__121))]
	// RVA: 0x2438C44 Offset: 0x2434C44 VA: 0x2438C44
	private IEnumerator loginAnnounce() { }

	// RVA: 0x2438CB8 Offset: 0x2434CB8 VA: 0x2438CB8
	public void LoadAnnounceWebView() { }

	// RVA: 0x2438EB4 Offset: 0x2434EB4 VA: 0x2438EB4
	public void EnableWebView(bool isEnable) { }

	// RVA: 0x2439000 Offset: 0x2435000 VA: 0x2439000
	public void LoadField(int fieldId, FieldRoomType roomType, byte roomId, int[] popMobList, HideSeekData[] hideSeekList) { }

	[IteratorStateMachine(typeof(GameManager.<loadFieldData>d__125))]
	// RVA: 0x24391F8 Offset: 0x24351F8 VA: 0x24391F8
	private IEnumerator loadFieldData(bool enter, int[] popMobList) { }

	// RVA: 0x2439294 Offset: 0x2435294 VA: 0x2439294
	public void ResetField() { }

	// RVA: 0x2439454 Offset: 0x2435454 VA: 0x2439454
	public void LeaveField() { }

	// RVA: 0x243945C Offset: 0x243545C VA: 0x243945C
	public void LeaveField(bool loginField) { }

	[IteratorStateMachine(typeof(GameManager.<startLeaveField>d__129))]
	// RVA: 0x243993C Offset: 0x243593C VA: 0x243993C
	private IEnumerator startLeaveField() { }

	// RVA: 0x24399B0 Offset: 0x24359B0 VA: 0x24399B0
	public void EnterParameterCreate() { }

	// RVA: 0x2439B38 Offset: 0x2435B38 VA: 0x2439B38
	public void EnterField(Game game) { }

	[IteratorStateMachine(typeof(GameManager.<playerMergeCheck>d__132))]
	// RVA: 0x2439EB8 Offset: 0x2435EB8 VA: 0x2439EB8
	private IEnumerator playerMergeCheck() { }

	// RVA: 0x2439F2C Offset: 0x2435F2C VA: 0x2439F2C
	public void ChangeField(int fieldId, byte roomType, byte roomId, float[] basePos, float angle, float cameraRot, EmergencyPositionData emergency) { }

	// RVA: 0x243A354 Offset: 0x2436354 VA: 0x243A354
	public void LeaveRoom() { }

	[IteratorStateMachine(typeof(GameManager.<EnterAreaLevelRoomForcibly>d__135))]
	// RVA: 0x243A450 Offset: 0x2436450 VA: 0x243A450
	public IEnumerator EnterAreaLevelRoomForcibly(int fieldId, byte roomType, byte roomId, Vector3 position, float angle, float cameraRot, short areaLevel, EmergencyPositionData emergency, Action<int> callback) { }

	// RVA: 0x243A550 Offset: 0x2436550 VA: 0x243A550
	public void FieldWarpPoint(byte pointId, byte roomType, byte roomId, float[] position, EmergencyPositionData emergency) { }

	// RVA: 0x243A668 Offset: 0x2436668 VA: 0x243A668
	public void FieldSpinaWarp(int fieldId, int gold) { }

	// RVA: 0x243A7C0 Offset: 0x24367C0 VA: 0x243A7C0
	public void ItemWarp() { }

	// RVA: 0x243A870 Offset: 0x2436870 VA: 0x243A870
	public void ItemBoxOpen(int uuid, short usedNum, short stackNum) { }

	// RVA: 0x243A9D0 Offset: 0x24369D0 VA: 0x243A9D0
	public void ChangeFieldSavePoint() { }

	// RVA: 0x243A9F0 Offset: 0x24369F0 VA: 0x243A9F0
	public void EmergencyChangeField() { }

	// RVA: 0x243AAF0 Offset: 0x2436AF0 VA: 0x243AAF0
	public void GuildRaidLobbyEnter() { }

	// RVA: 0x243AAF4 Offset: 0x2436AF4 VA: 0x243AAF4
	public void GuildHomeLeave() { }

	// RVA: 0x243ABB8 Offset: 0x2436BB8 VA: 0x243ABB8
	public void FieldWarpList(short warpListId, int nextFieldId, short nextLocationId, byte roomType, byte roomId, float[] position) { }

	// RVA: 0x243AD5C Offset: 0x2436D5C VA: 0x243AD5C
	public void UpdateItem(ItemDatav2[] itemList) { }

	// RVA: 0x243AD68 Offset: 0x2436D68 VA: 0x243AD68
	public void UpdateItem(bool isNewItem, ItemDatav2[] itemList) { }

	// RVA: 0x243AE5C Offset: 0x2436E5C VA: 0x243AE5C
	public void UpdateItem(InventoryPackData inventory, short[] inventoryCapacity) { }

	// RVA: 0x243AF18 Offset: 0x2436F18 VA: 0x243AF18
	public void UpdateItemConnection(ItemManager.ItemConnectFlag flag, ItemDatav2[] itemList) { }

	// RVA: 0x243AF5C Offset: 0x2436F5C VA: 0x243AF5C
	public void UpdateItemConnection(ItemManager.ItemConnectFlag flag, InventoryPackData inventory, short[] inventoryCapacity) { }

	// RVA: 0x243AFA4 Offset: 0x2436FA4 VA: 0x243AFA4
	public void UpdateItemLocation(ItemManager.ItemConnectFlag flag, Dictionary<int, short> itemLocationList) { }

	// RVA: 0x243B004 Offset: 0x2437004 VA: 0x243B004
	public void ItemOperationFailed(int uuid) { }

	// RVA: 0x243B034 Offset: 0x2437034 VA: 0x243B034
	public void ItemOperationFailed() { }

	// RVA: 0x243B060 Offset: 0x2437060 VA: 0x243B060
	public void SkillBookUseFailed(int uuid) { }

	// RVA: 0x243B238 Offset: 0x2437238 VA: 0x243B238
	public void UpdateGold(int gold) { }

	// RVA: 0x243B278 Offset: 0x2437278 VA: 0x243B278
	public void UpdateBlackSmith(int blackSmith) { }

	// RVA: 0x243B2B8 Offset: 0x24372B8 VA: 0x243B2B8
	public void UpdateCoinItemUse(OrbItemUseResponse coinUse) { }

	// RVA: 0x243B318 Offset: 0x2437318 VA: 0x243B318
	public void UpdateWarrantyItem(WarrantyItemDatav2[] itemList) { }

	// RVA: 0x243B324 Offset: 0x2437324 VA: 0x243B324
	public void UpdateWarrantyItem(ItemManager.ItemConnectFlag flag, WarrantyItemDatav2[] itemList) { }

	// RVA: 0x243B45C Offset: 0x243745C VA: 0x243B45C
	public void DiscardWarrantyItem(ItemManager.ItemConnectFlag flag, _WarrantyDiscardResponse responseObject, short returnCode) { }

	// RVA: 0x243B544 Offset: 0x2437544 VA: 0x243B544
	public void UpdateItemBagCapacity(short[] bagCapacity) { }

	// RVA: 0x243B574 Offset: 0x2437574 VA: 0x243B574
	public void ItemBagSlotRelease(ItemBagSlotReleaseResponse responseObject) { }

	// RVA: 0x243B654 Offset: 0x2437654 VA: 0x243B654
	public void ItemUserFlagChange(ItemDataTypev2 type, int uuid, byte userFlag) { }

	// RVA: 0x243B660 Offset: 0x2437660 VA: 0x243B660
	public void ReceiveItemRandomPropertyEffectStart(ItemRandomPropertyStartEffectEvent start) { }

	// RVA: 0x243B7BC Offset: 0x24377BC VA: 0x243B7BC
	public void ReceiveItemRandomPropertyEffectEnd(ItemRandomPropertyEndEffectEvent end) { }

	// RVA: 0x243B7F4 Offset: 0x24377F4 VA: 0x243B7F4
	public void CheckScenarioList() { }

	// RVA: 0x243B7F8 Offset: 0x24377F8 VA: 0x243B7F8
	public bool StartMissionOrQuest(bool mission, int id, bool restart) { }

	// RVA: 0x243B8C0 Offset: 0x24378C0 VA: 0x243B8C0
	public bool EndMissionOrQuest(bool mission, int id) { }

	// RVA: 0x243B950 Offset: 0x2437950 VA: 0x243B950
	public void SetkeyitemMissionOrQuest(bool mission, int questId, byte keyNo, byte current, byte max) { }

	// RVA: 0x243BAE0 Offset: 0x2437AE0 VA: 0x243BAE0
	public void SetViewFlagMissionOrQuest(bool mission, int questId, byte checkFlag, short keyViewFlag, short itemViewFlag, short mobViewFlag, byte infoNo) { }

	// RVA: 0x243BC0C Offset: 0x2437C0C VA: 0x243BC0C
	public void ReceiveMissionStart(MissionStartResponse mission) { }

	// RVA: 0x243BC40 Offset: 0x2437C40 VA: 0x243BC40
	public void ReceiveMissionEnd(MissionEndResponse mission) { }

	// RVA: 0x243BC70 Offset: 0x2437C70 VA: 0x243BC70
	public void ReceiveQuestStart(QuestStartResponse quest) { }

	// RVA: 0x243BCA0 Offset: 0x2437CA0 VA: 0x243BCA0
	public void ReceiveQuestEnd(QuestEndResponse quest) { }

	// RVA: 0x243BCD0 Offset: 0x2437CD0 VA: 0x243BCD0
	public void SendMissionGetData(int id) { }

	// RVA: 0x243BCF4 Offset: 0x2437CF4 VA: 0x243BCF4
	public void ReceiveMissionData(MissionGetDataResponse mission) { }

	// RVA: 0x243BD24 Offset: 0x2437D24 VA: 0x243BD24
	public void SendQuestGetData(int id) { }

	// RVA: 0x243BD48 Offset: 0x2437D48 VA: 0x243BD48
	public void ReceiveQuestData(QuestGetDataResponse quest) { }

	// RVA: 0x243BD78 Offset: 0x2437D78 VA: 0x243BD78
	public bool AbandonQuest(int questId) { }

	// RVA: 0x243BD80 Offset: 0x2437D80 VA: 0x243BD80
	public bool AbandonQuest(int questId, bool restart) { }

	// RVA: 0x243BDEC Offset: 0x2437DEC VA: 0x243BDEC
	public void ReceiveQuestAbandon(QuestAbandonmentResponse response) { }

	// RVA: 0x243BE20 Offset: 0x2437E20 VA: 0x243BE20
	public void ReceiveMissionAbandon(int missionId) { }

	// RVA: 0x243BE50 Offset: 0x2437E50 VA: 0x243BE50
	public bool AbandonMission(int missionId) { }

	// RVA: 0x243BF24 Offset: 0x2437F24 VA: 0x243BF24
	public void ReceiveMissionAbandon(MissionAbandonmentResponse response) { }

	// RVA: 0x243BFA4 Offset: 0x2437FA4 VA: 0x243BFA4
	public bool RewardQuest(int questId, byte rewardId, byte count, bool isStopMaxExp) { }

	// RVA: 0x243C02C Offset: 0x243802C VA: 0x243C02C
	public bool RewardQuest(int questId, byte rewardId) { }

	// RVA: 0x243C0A4 Offset: 0x24380A4 VA: 0x243C0A4
	public void ReceiveQuestReward(QuestCheckRewardResponse response) { }

	// RVA: 0x243C0EC Offset: 0x24380EC VA: 0x243C0EC
	public void ReceiveQuestContinuousReward(QuestCheckContinuousRewardResponse response) { }

	// RVA: 0x243C134 Offset: 0x2438134 VA: 0x243C134
	public bool RewardMission(int missionId, byte rewardId) { }

	// RVA: 0x243C1AC Offset: 0x24381AC VA: 0x243C1AC
	public void ReceiveMissionReward(MissionCheckRewardResponse response) { }

	// RVA: 0x243C1F4 Offset: 0x24381F4 VA: 0x243C1F4
	public void ReceiveMissionFailed(OperationResponse responseObject) { }

	// RVA: 0x243C224 Offset: 0x2438224 VA: 0x243C224
	public void ReceiveQuestFailed(OperationResponse responseObject) { }

	// RVA: 0x243C254 Offset: 0x2438254 VA: 0x243C254
	public void MissionReOrder(int scenarioProgress) { }

	// RVA: 0x243C284 Offset: 0x2438284 VA: 0x243C284
	public void SendChat(ChatChannelType chatType, string text, int targetId) { }

	// RVA: 0x243C344 Offset: 0x2438344 VA: 0x243C344
	public void BanWordUpdate(DateTime datetime) { }

	// RVA: 0x243C350 Offset: 0x2438350 VA: 0x243C350
	public void ReceiveBanWordUpdate(BanWordUpdateResponse response) { }

	// RVA: 0x243C3B4 Offset: 0x24383B4 VA: 0x243C3B4
	public void SendBanWord(int index, string word) { }

	// RVA: 0x243C3C0 Offset: 0x24383C0 VA: 0x243C3C0
	public void ReceiveEventBanWordUpdate(BanWordUpdateEvent updateEvent) { }

	// RVA: 0x243C424 Offset: 0x2438424 VA: 0x243C424
	public void UnreceivedPartyMessage(DateTime latestTime) { }

	// RVA: 0x243C430 Offset: 0x2438430 VA: 0x243C430
	public void UnreceivedGuildMessage(DateTime latestTime) { }

	// RVA: 0x243C43C Offset: 0x243843C VA: 0x243C43C
	public void AvatarRename(string name) { }

	// RVA: 0x243C4E8 Offset: 0x24384E8 VA: 0x243C4E8
	public void CreateAvatarStart() { }

	// RVA: 0x243C5AC Offset: 0x24385AC VA: 0x243C5AC
	public void CreateCheckName(string name) { }

	// RVA: 0x243C658 Offset: 0x2438658 VA: 0x243C658
	public void NewAvatarRegister(string name, NewStyleData style, byte weaponNo) { }

	// RVA: 0x243C72C Offset: 0x243872C VA: 0x243C72C
	public void ReceiveDeterminePersonality(PersonalityType personalityType) { }

	// RVA: 0x243C7A8 Offset: 0x24387A8 VA: 0x243C7A8
	public void ReceiveCompensationStatusReset(CompensationStatusResetResponse responseObject) { }

	// RVA: 0x243C878 Offset: 0x2438878 VA: 0x243C878
	public void ReceiveCompensationPersonalityReset(CompensationPersonalityResetResponse responseObject) { }

	// RVA: 0x243C948 Offset: 0x2438948 VA: 0x243C948
	public void CustomerSelectToCreate() { }

	// RVA: 0x243C9D8 Offset: 0x24389D8 VA: 0x243C9D8
	public void CustomerSelectToAccountLogin() { }

	// RVA: 0x243CAB4 Offset: 0x2438AB4 VA: 0x243CAB4
	public void GMGameEventDateUpdate() { }

	// RVA: 0x243CAB8 Offset: 0x2438AB8 VA: 0x243CAB8
	public void GMGameEventInit() { }

	// RVA: 0x243CABC Offset: 0x2438ABC VA: 0x243CABC
	public void GmInvisible(bool invisible) { }

	// RVA: 0x243CAC0 Offset: 0x2438AC0 VA: 0x243CAC0
	public void GMSetGuildPoint(int point) { }

	// RVA: 0x243CAC4 Offset: 0x2438AC4 VA: 0x243CAC4
	public void GmGuildHeldRaid(int raidId) { }

	// RVA: 0x243CAC8 Offset: 0x2438AC8 VA: 0x243CAC8
	public void GMGenericFlagClear() { }

	// RVA: 0x243CACC Offset: 0x2438ACC VA: 0x243CACC
	public void GMGetOrbShard(int orbShard) { }

	// RVA: 0x243CAD0 Offset: 0x2438AD0 VA: 0x243CAD0
	public void GMGuildLv(short guildLv) { }

	// RVA: 0x243CAD4 Offset: 0x2438AD4 VA: 0x243CAD4
	public void SetComboPoint() { }

	// RVA: 0x243CAD8 Offset: 0x2438AD8 VA: 0x243CAD8
	public void TestGMOperations(byte operationsCode, Dictionary<byte, object> param) { }

	// RVA: 0x243CADC Offset: 0x2438ADC VA: 0x243CADC
	public void GMDefenceRoomRandom() { }

	// RVA: 0x243CAE0 Offset: 0x2438AE0 VA: 0x243CAE0
	public void GMGetItem(int itemId, short itemNum) { }

	// RVA: 0x243CAE4 Offset: 0x2438AE4 VA: 0x243CAE4
	public void GMGetAvaterEquip(int itemId) { }

	// RVA: 0x243CAE8 Offset: 0x2438AE8 VA: 0x243CAE8
	public void GetOrbItem(int itemId, byte itemNum) { }

	// RVA: 0x243CAEC Offset: 0x2438AEC VA: 0x243CAEC
	public void GMGetCristaEquip(ItemDatav2 photnItemData) { }

	// RVA: 0x243CAF0 Offset: 0x2438AF0 VA: 0x243CAF0
	public void GMGetGold(int gold) { }

	// RVA: 0x243CAF4 Offset: 0x2438AF4 VA: 0x243CAF4
	public void GMGetSkill(int type, int lv) { }

	// RVA: 0x243CAF8 Offset: 0x2438AF8 VA: 0x243CAF8
	public void GMWarp(int fieldId, int warpId) { }

	// RVA: 0x243CAFC Offset: 0x2438AFC VA: 0x243CAFC
	public void GmChangeAccountProgress(int progress) { }

	// RVA: 0x243CB00 Offset: 0x2438B00 VA: 0x243CB00
	public void GMLv(int lv) { }

	// RVA: 0x243CB04 Offset: 0x2438B04 VA: 0x243CB04
	public void GMMission(int progress) { }

	// RVA: 0x243CB08 Offset: 0x2438B08 VA: 0x243CB08
	public void GMLoginRollback(int goBackDay) { }

	// RVA: 0x243CB0C Offset: 0x2438B0C VA: 0x243CB0C
	public void GmMissionGiveUp() { }

	// RVA: 0x243CB10 Offset: 0x2438B10 VA: 0x243CB10
	public void GmGreed(short rate) { }

	// RVA: 0x243CB14 Offset: 0x2438B14 VA: 0x243CB14
	public void GMSetDungeonFloor(byte target, short floor) { }

	// RVA: 0x243CB18 Offset: 0x2438B18 VA: 0x243CB18
	public void GMGetUserLocation(int id) { }

	// RVA: 0x243CB1C Offset: 0x2438B1C VA: 0x243CB1C
	public void GMCallUser(int targetId) { }

	// RVA: 0x243CB20 Offset: 0x2438B20 VA: 0x243CB20
	public void GMWarpPosition(int fieldId, byte channel, short[] position) { }

	// RVA: 0x243CB24 Offset: 0x2438B24 VA: 0x243CB24
	public void GMDiscardItem(Dictionary<int, short> discardItem) { }

	// RVA: 0x243CB28 Offset: 0x2438B28 VA: 0x243CB28
	public void GMAddSkillPoint(int point) { }

	// RVA: 0x243CB2C Offset: 0x2438B2C VA: 0x243CB2C
	public void GMUpdateComboPoint(int point) { }

	// RVA: 0x243CB30 Offset: 0x2438B30 VA: 0x243CB30
	public void GMUpdateComboExp(int exp) { }

	// RVA: 0x243CB34 Offset: 0x2438B34 VA: 0x243CB34
	public void GMKickout(int targetId) { }

	// RVA: 0x243CB38 Offset: 0x2438B38 VA: 0x243CB38
	public void GMGetTicket(int num) { }

	// RVA: 0x243CB3C Offset: 0x2438B3C VA: 0x243CB3C
	public void GetTicketPiece(int num) { }

	// RVA: 0x243CB40 Offset: 0x2438B40 VA: 0x243CB40
	public void GMChangeMailState(byte type, byte state) { }

	// RVA: 0x243CB44 Offset: 0x2438B44 VA: 0x243CB44
	public void GMDefenceEnd(DefenceGameEndType type) { }

	// RVA: 0x243CB48 Offset: 0x2438B48 VA: 0x243CB48
	public void GMDefenceRankingUpdate() { }

	// RVA: 0x243CB4C Offset: 0x2438B4C VA: 0x243CB4C
	public void GMDefenceRewardReset() { }

	// RVA: 0x243CB50 Offset: 0x2438B50 VA: 0x243CB50
	public void GMAreaBonusUpdate(short addGauge) { }

	// RVA: 0x243CB54 Offset: 0x2438B54 VA: 0x243CB54
	public void GMHouseClear() { }

	// RVA: 0x243CB58 Offset: 0x2438B58 VA: 0x243CB58
	public void GMGetStarGemShard(int shard) { }

	// RVA: 0x243CB5C Offset: 0x2438B5C VA: 0x243CB5C
	public void GMGetStarGem(short skillId, byte skillLv) { }

	// RVA: 0x243CB60 Offset: 0x2438B60 VA: 0x243CB60
	public void GMMiniGameEnter(int fieldId, int memberMax) { }

	// RVA: 0x243CB64 Offset: 0x2438B64 VA: 0x243CB64
	public void GMMiniGameLeave() { }

	// RVA: 0x243CB68 Offset: 0x2438B68 VA: 0x243CB68
	public void GMMiniGameLobbyEnter(int fieldId, int matchingNum) { }

	// RVA: 0x243CB6C Offset: 0x2438B6C VA: 0x243CB6C
	public void GmTreasureHistoryInitialize() { }

	// RVA: 0x243CB70 Offset: 0x2438B70 VA: 0x243CB70
	public void GmTreasureKeyRecover(byte keyNum) { }

	// RVA: 0x243CB74 Offset: 0x2438B74 VA: 0x243CB74
	public void GmAddItemBagSlot(int addSlot, byte dataType) { }

	// RVA: 0x243CB78 Offset: 0x2438B78 VA: 0x243CB78
	public void GmAddParameterSlot(int addSlot) { }

	// RVA: 0x243CB7C Offset: 0x2438B7C VA: 0x243CB7C
	public void GMSummerSetStamina(int stamina) { }

	// RVA: 0x243CB80 Offset: 0x2438B80 VA: 0x243CB80
	public void GMSummerSetPoint(int _point) { }

	// RVA: 0x243CB84 Offset: 0x2438B84 VA: 0x243CB84
	public void GMSummerPrizeReset() { }

	// RVA: 0x243CB88 Offset: 0x2438B88 VA: 0x243CB88
	public void GMSummerSetSeaItem(int _item_id, int _request_num) { }

	// RVA: 0x243CB8C Offset: 0x2438B8C VA: 0x243CB8C
	public void GmOxygenRecovery() { }

	// RVA: 0x243CB90 Offset: 0x2438B90 VA: 0x243CB90
	public void GmCultivationTimeRewind(short index, int hour) { }

	// RVA: 0x243CB94 Offset: 0x2438B94 VA: 0x243CB94
	public void GmBossPopReserve() { }

	// RVA: 0x243CB98 Offset: 0x2438B98 VA: 0x243CB98
	public void GmBossDeadReserve() { }

	// RVA: 0x243CB9C Offset: 0x2438B9C VA: 0x243CB9C
	public void GmCuisineRecipeInitialize() { }

	// RVA: 0x243CBA0 Offset: 0x2438BA0 VA: 0x243CBA0
	public void GmCuisineRecipeSettingLv(int id, byte lv) { }

	// RVA: 0x243CBA4 Offset: 0x2438BA4 VA: 0x243CBA4
	public void GmGetFoodPoint(int point) { }

	// RVA: 0x243CBA8 Offset: 0x2438BA8 VA: 0x243CBA8
	public void GmCuisineSettingInitialize() { }

	// RVA: 0x243CBAC Offset: 0x2438BAC VA: 0x243CBAC
	public void GmInitMaterialPoint() { }

	// RVA: 0x243CBB0 Offset: 0x2438BB0 VA: 0x243CBB0
	public void GmMaxMaterialPoint() { }

	// RVA: 0x243CBB4 Offset: 0x2438BB4 VA: 0x243CBB4
	public void GmInitGuildPointCollectTime(GuildCheckContributionResponse response) { }

	// RVA: 0x243CBB8 Offset: 0x2438BB8 VA: 0x243CBB8
	public void GmInitGuildPresentTime() { }

	// RVA: 0x243CBBC Offset: 0x2438BBC VA: 0x243CBBC
	public void GmBankReset(BankType type, int day) { }

	// RVA: 0x243CBC0 Offset: 0x2438BC0 VA: 0x243CBC0
	public void GmResetTrophy() { }

	// RVA: 0x243CBC4 Offset: 0x2438BC4 VA: 0x243CBC4
	public void GmExchangeInitAlreadyList(short shopId) { }

	// RVA: 0x243CBC8 Offset: 0x2438BC8 VA: 0x243CBC8
	public void GmSetExchangePoint(short shopId, int point) { }

	// RVA: 0x243CBCC Offset: 0x2438BCC VA: 0x243CBCC
	public void GmSetExchangeUsedTotalPoint(short shopId, int usePoint) { }

	// RVA: 0x243CBD0 Offset: 0x2438BD0 VA: 0x243CBD0
	public void GmSoundScoreReset() { }

	// RVA: 0x243CBD4 Offset: 0x2438BD4 VA: 0x243CBD4
	public void GmRezeroBattleHeldReserve() { }

	// RVA: 0x243CBD8 Offset: 0x2438BD8 VA: 0x243CBD8
	public void GmTreasureHuntTrialPointMax() { }

	// RVA: 0x243CBDC Offset: 0x2438BDC VA: 0x243CBDC
	public void GmSetBlackSmithProficiency(int lv) { }

	// RVA: 0x243CBE0 Offset: 0x2438BE0 VA: 0x243CBE0
	public void GmSetAlchemyProficiency(int lv) { }

	// RVA: 0x243CBE4 Offset: 0x2438BE4 VA: 0x243CBE4
	public void GmGetHouseBlackKnightGold(int gold) { }

	// RVA: 0x243CBE8 Offset: 0x2438BE8 VA: 0x243CBE8
	public void GmGetHouseBlackKnightCristaAll() { }

	// RVA: 0x243CBEC Offset: 0x2438BEC VA: 0x243CBEC
	public void GmChangeNewWaveSeed() { }

	// RVA: 0x243CBF0 Offset: 0x2438BF0 VA: 0x243CBF0
	public void GmGetNewWaveSeed() { }

	// RVA: 0x243CBF4 Offset: 0x2438BF4 VA: 0x243CBF4
	public void GmGetGemCart(short id) { }

	// RVA: 0x243CBF8 Offset: 0x2438BF8 VA: 0x243CBF8
	public void GmGetGemPowder(int num) { }

	// RVA: 0x243CBFC Offset: 0x2438BFC VA: 0x243CBFC
	public void GmSetHighRaidPoint(byte highRaidNo, int point) { }

	// RVA: 0x243CC00 Offset: 0x2438C00 VA: 0x243CC00
	public void GmSetHighRaidCallengePoint(byte count, byte point) { }

	// RVA: 0x243CC04 Offset: 0x2438C04 VA: 0x243CC04
	public void LiveKeywordCheck() { }

	// RVA: 0x243CC08 Offset: 0x2438C08 VA: 0x243CC08
	public void GmItemConvertReset(Game game) { }

	// RVA: 0x243CC0C Offset: 0x2438C0C VA: 0x243CC0C
	public void GmHighRaidTrophyReset(byte highRaidNo) { }

	// RVA: 0x243CC10 Offset: 0x2438C10 VA: 0x243CC10
	public void GmMobaUpdateLevel(short level) { }

	// RVA: 0x243CC14 Offset: 0x2438C14 VA: 0x243CC14
	public void GmMobaGetGold(int gold) { }

	// RVA: 0x243CC18 Offset: 0x2438C18 VA: 0x243CC18
	public void GmMobaGameChange(byte mobaGameType) { }

	// RVA: 0x243CC1C Offset: 0x2438C1C VA: 0x243CC1C
	public void GmMobaGameEnd() { }

	// RVA: 0x243CC20 Offset: 0x2438C20 VA: 0x243CC20
	public void GmInitializePaletteStorage() { }

	// RVA: 0x243CC24 Offset: 0x2438C24 VA: 0x243CC24
	public void GmMaxPaletteStorage() { }

	// RVA: 0x243CC28 Offset: 0x2438C28 VA: 0x243CC28
	public void GmFamiliaInitialize() { }

	// RVA: 0x243CC2C Offset: 0x2438C2C VA: 0x243CC2C
	public void GmHuntingOneInitialize() { }

	// RVA: 0x243CC30 Offset: 0x2438C30 VA: 0x243CC30
	public void FriendRequest(byte targetType, int targetId, string message, string targetName) { }

	// RVA: 0x243CDC8 Offset: 0x2438DC8 VA: 0x243CDC8
	public void FriendRequestCancel(byte targetType, int targetId) { }

	// RVA: 0x243CF2C Offset: 0x2438F2C VA: 0x243CF2C
	public void FriendAcceptance(byte targetType, int targetId) { }

	// RVA: 0x243D090 Offset: 0x2439090 VA: 0x243D090
	public void FriendRejection(byte targetType, int targetId) { }

	// RVA: 0x243D1F4 Offset: 0x24391F4 VA: 0x243D1F4
	public void FriendRemove(byte targetType, int targetId) { }

	// RVA: 0x243D358 Offset: 0x2439358 VA: 0x243D358
	public void FriendPartyInvitation(int targetId, string message) { }

	// RVA: 0x243D440 Offset: 0x2439440 VA: 0x243D440
	public void FriendGetList() { }

	// RVA: 0x243D588 Offset: 0x2439588 VA: 0x243D588
	public void FriendInitialize(FriendUpdateResponse friendListEvent) { }

	// RVA: 0x243D60C Offset: 0x243960C VA: 0x243D60C
	public void OnFriendRemove(int removeId, string removeName) { }

	// RVA: 0x243D698 Offset: 0x2439698 VA: 0x243D698
	public void OnFriendRequest(FriendRequestEvent request) { }

	// RVA: 0x243D6CC Offset: 0x24396CC VA: 0x243D6CC
	public void OnFriendRequestResponse(FriendRequestResponse response) { }

	// RVA: 0x243D754 Offset: 0x2439754 VA: 0x243D754
	public void OnFriendAcceptance(FriendData stateData) { }

	// RVA: 0x243D7D8 Offset: 0x24397D8 VA: 0x243D7D8
	public void OnFriendRejection(int rejectId, string rejectName) { }

	// RVA: 0x243D818 Offset: 0x2439818 VA: 0x243D818
	public void OnFriendRejectionResponse(int rejectId, string rejectName) { }

	// RVA: 0x243D8A4 Offset: 0x24398A4 VA: 0x243D8A4
	public void OnFriendRequestCancel(int cancelId, string cancelName) { }

	// RVA: 0x243D8E4 Offset: 0x24398E4 VA: 0x243D8E4
	public void OnFriendRequestCancelResponse(int cancelId, string cancelName) { }

	// RVA: 0x243D970 Offset: 0x2439970 VA: 0x243D970
	public void OnFriendStateChange(int archetypeId, byte state, short level, int worldId) { }

	// RVA: 0x243D9C8 Offset: 0x24399C8 VA: 0x243D9C8
	public void FriendChagneOnlineNotice(byte type) { }

	// RVA: 0x243DB04 Offset: 0x2439B04 VA: 0x243DB04
	public void OnFriendChangeOnlineNoticeResponse() { }

	// RVA: 0x243DB78 Offset: 0x2439B78 VA: 0x243DB78
	public void PartyInvitation(int archetypeId, string message) { }

	// RVA: 0x243DC60 Offset: 0x2439C60 VA: 0x243DC60
	public void PartyInvitationResponse(PartyInvitationResponse response) { }

	// RVA: 0x243DD10 Offset: 0x2439D10 VA: 0x243DD10
	public void PartyDissolution(PartyDissolutionEvent dissolution) { }

	// RVA: 0x243E274 Offset: 0x243A274 VA: 0x243E274
	public void PartySecede() { }

	// RVA: 0x243E314 Offset: 0x243A314 VA: 0x243E314
	public void PartySecedeResponse(short returnCode) { }

	// RVA: 0x243E874 Offset: 0x243A874 VA: 0x243E874
	public void PartyAcceptance(int senderId, byte senderType, int partyId) { }

	// RVA: 0x243E93C Offset: 0x243A93C VA: 0x243E93C
	public void PartyAcceptanceResponse(PartyAcceptanceResponse response) { }

	// RVA: 0x243E9C0 Offset: 0x243A9C0 VA: 0x243E9C0
	public void PartyRejection(int senderId, int partyId) { }

	// RVA: 0x243EA80 Offset: 0x243AA80 VA: 0x243EA80
	public void PartyRejectionResponse(PartyInviteCancelResponse response) { }

	// RVA: 0x243EB04 Offset: 0x243AB04 VA: 0x243EB04
	public void PartyInvitationCancel(int targetId, string targetName) { }

	// RVA: 0x243EBC4 Offset: 0x243ABC4 VA: 0x243EBC4
	public void PartyInvitationCancelResponse(PartySenderInvitedCancelResponse response) { }

	// RVA: 0x243EC48 Offset: 0x243AC48 VA: 0x243EC48
	public void PartyDissolution() { }

	// RVA: 0x243ED8C Offset: 0x243AD8C VA: 0x243ED8C
	public void PartyKickout(byte targetType, int targetId) { }

	// RVA: 0x243EE4C Offset: 0x243AE4C VA: 0x243EE4C
	public void PartyPetKickOut(int kickPetId) { }

	// RVA: 0x243EEF8 Offset: 0x243AEF8 VA: 0x243EEF8
	public void PartyKickoutEvent(PartyKickoutEvent kickout) { }

	// RVA: 0x243F444 Offset: 0x243B444 VA: 0x243F444
	public void PartyChangeLeader(int targetId) { }

	// RVA: 0x243F4F0 Offset: 0x243B4F0 VA: 0x243F4F0
	public void NpcAvatarJoin(int npcId, Vector3 position, float rot, int flag) { }

	// RVA: 0x243F53C Offset: 0x243B53C VA: 0x243F53C
	public void ReturnCodeBanParty() { }

	// RVA: 0x243F698 Offset: 0x243B698 VA: 0x243F698
	public void PartyLotteryRecruitStart(short removeFlag) { }

	// RVA: 0x243F7D8 Offset: 0x243B7D8 VA: 0x243F7D8
	public void PartyLotteryInfo(UIBasePanel panel) { }

	// RVA: 0x243F8D8 Offset: 0x243B8D8 VA: 0x243F8D8
	public void PartyLotteryListClear(UIBasePanel panel) { }

	// RVA: 0x243F9D8 Offset: 0x243B9D8 VA: 0x243F9D8
	public void PartyLotteryRecruitCancel() { }

	// RVA: 0x243FAD0 Offset: 0x243BAD0 VA: 0x243FAD0
	public void PartyLotteryStart(string message) { }

	// RVA: 0x243FC28 Offset: 0x243BC28 VA: 0x243FC28
	public void PartyLotteryRecruitReSend() { }

	// RVA: 0x243FD20 Offset: 0x243BD20 VA: 0x243FD20
	public void PartyLotteryJoin(int partyId, int organizerId) { }

	// RVA: 0x243FE70 Offset: 0x243BE70 VA: 0x243FE70
	public void PartyLinkInvitation(int targetId) { }

	// RVA: 0x243FF48 Offset: 0x243BF48 VA: 0x243FF48
	public void ReceivePartyLinkInvitation(PartyLinkInvitationResponse response) { }

	// RVA: 0x243FFA0 Offset: 0x243BFA0 VA: 0x243FFA0
	public void PartyLinkInviteCancel(PartyLinkInviteData invite) { }

	// RVA: 0x2440078 Offset: 0x243C078 VA: 0x2440078
	public void ReceivePartyLinkInviteCancel(PartyLinkInviteCancelResponse response) { }

	// RVA: 0x24400D0 Offset: 0x243C0D0 VA: 0x24400D0
	public void PartyLinkSenderInvitedCancel() { }

	// RVA: 0x2440194 Offset: 0x243C194 VA: 0x2440194
	public void ReceivePartyLinkSenderInvitedCancelResponse() { }

	// RVA: 0x24401E4 Offset: 0x243C1E4 VA: 0x24401E4
	public void PartyLinkConsent(PartyLinkInviteData invite) { }

	// RVA: 0x24402BC Offset: 0x243C2BC VA: 0x24402BC
	public void ReceivePartyLinkConsent(PartyLinkConsentResponse response) { }

	// RVA: 0x2440314 Offset: 0x243C314 VA: 0x2440314
	public void PartyLinkRelease() { }

	// RVA: 0x24403D8 Offset: 0x243C3D8 VA: 0x24403D8
	public void ReceivePartyLinkRelease() { }

	// RVA: 0x2440428 Offset: 0x243C428 VA: 0x2440428
	public void RemoveOtherPlayer(byte archetypeType, int archetypeId) { }

	// RVA: 0x24405A8 Offset: 0x243C5A8 VA: 0x24405A8
	public void UpdateMaterialPoint(MaterialData materialData) { }

	// RVA: 0x243B624 Offset: 0x2437624 VA: 0x243B624
	public void UpdateMaterialPoint(MaterialData[] materialData) { }

	// RVA: 0x24405D8 Offset: 0x243C5D8 VA: 0x24405D8
	public void GetAccountLevel() { }

	// RVA: 0x2440678 Offset: 0x243C678 VA: 0x2440678
	public void LibraryLearnSkillTree(int shopId, byte skillTreeType, byte skillTreeLv, int cost, Vector3 position) { }

	// RVA: 0x24407C4 Offset: 0x243C7C4 VA: 0x24407C4
	public void OnLibraryLearnSkillTree(SkillLibraryResponse response) { }

	// RVA: 0x24407F8 Offset: 0x243C7F8 VA: 0x24407F8
	public void SetPlayerControlLock(bool flag) { }

	// RVA: 0x2440804 Offset: 0x243C804 VA: 0x2440804
	public void UpdatePlayerStatus(PlayerStatusData playerStatusData) { }

	// RVA: 0x2440914 Offset: 0x243C914 VA: 0x2440914
	public void UpdatePlayerStatusFromDamage(byte damageId, PlayerStatusData playerStatusData) { }

	// RVA: 0x2440990 Offset: 0x243C990 VA: 0x2440990
	public void UpdatePlayerDamagedFailed(byte damageId) { }

	// RVA: 0x2440A2C Offset: 0x243CA2C VA: 0x2440A2C
	public void ReceiveActionEndFunc(PlayerStatusData playerStatusData, int skillParamFlg) { }

	// RVA: 0x2440A90 Offset: 0x243CA90 VA: 0x2440A90
	public void ReceivesSupportDelay(short skillId, byte targetType, int targetId, SupportResultData supportData) { }

	// RVA: 0x2441248 Offset: 0x243D248 VA: 0x2441248
	public void PlayerGameStatusUpdate(int hp, int exHp, int mp, int exMp) { }

	// RVA: 0x24412A0 Offset: 0x243D2A0 VA: 0x24412A0
	public void MagicGaugeUpdate(short magicGauge, TimeSpan magicTimeSapn) { }

	// RVA: 0x24412F0 Offset: 0x243D2F0 VA: 0x24412F0
	public void PlayerDamagedUpdateFailed(byte id) { }

	// RVA: 0x244138C Offset: 0x243D38C VA: 0x244138C
	public void PlayerDamagedUpdate(byte id, int hp, int exHp, int mp, int exMp) { }

	// RVA: 0x2441410 Offset: 0x243D410 VA: 0x2441410
	public void ClearFirstAidBuffer() { }

	// RVA: 0x2441438 Offset: 0x243D438 VA: 0x2441438
	public void PlayerRespawn(int hp, int mp, bool orbRespawn) { }

	// RVA: 0x2441458 Offset: 0x243D458 VA: 0x2441458
	public void PlayerRespawnTime(float respawnTime, float yellsTime) { }

	// RVA: 0x2441474 Offset: 0x243D474 VA: 0x2441474
	public void PlayerPrimaryStatusUpdate(GameStatusData gameStatusData, PrimaryStatusData primaryStatusData) { }

	// RVA: 0x24414D4 Offset: 0x243D4D4 VA: 0x24414D4
	public void PlayerSkillUpdate(GameStatusData gameStatusData, PrimaryStatusData primaryStatusData, Dictionary<short, byte> skillList) { }

	// RVA: 0x24416D4 Offset: 0x243D6D4 VA: 0x24416D4
	public void RemovePlayerAbnormalState(byte[] list, byte[] ids) { }

	// RVA: 0x2441724 Offset: 0x243D724 VA: 0x2441724
	public void ReceivePlayerAttackStart(ArchetypeType archetypeType, int archetypeId, AttackStartResponseData response) { }

	// RVA: 0x2441FE8 Offset: 0x243DFE8 VA: 0x2441FE8
	public void ReceivePlayerAttackEnd(SkillId skillId, int localId) { }

	// RVA: 0x24420F8 Offset: 0x243E0F8 VA: 0x24420F8
	public void ReceivePlayerSupportStart(ArchetypeType archetypeType, int archetypeId, SupportStartResponseData response) { }

	// RVA: 0x24428E0 Offset: 0x243E8E0 VA: 0x24428E0
	public void ReceiveSkillMotionEnd(GameReturnCode returnCode, byte archetypeType, int archetypeId, SkillMotionEndResponseData response) { }

	// RVA: 0x24429E4 Offset: 0x243E9E4 VA: 0x24429E4
	public void ReceivePlayerSkillCancel(SkillId skillId, int localId) { }

	// RVA: 0x2442AF4 Offset: 0x243EAF4 VA: 0x2442AF4
	public void ReceiveSkillEvent(SkillEventResponseData responseData) { }

	// RVA: 0x2442B18 Offset: 0x243EB18 VA: 0x2442B18
	public void ReceiveNpcSkillEvent(byte archetypeType, int archetypeId, SkillEventResponseData responseData) { }

	// RVA: 0x2441C60 Offset: 0x243DC60 VA: 0x2441C60
	private void CheckChangeBarehandQigong(int skillFlag, PlayerActionManagerBase playerAction) { }

	// RVA: 0x2442CC4 Offset: 0x243ECC4 VA: 0x2442CC4
	public void InitializeStamp(LoginStampEvent stampEvent) { }

	// RVA: 0x2442D24 Offset: 0x243ED24 VA: 0x2442D24
	public void StampCardCheckReward(byte stampIndex) { }

	// RVA: 0x2442DFC Offset: 0x243EDFC VA: 0x2442DFC
	public void ReceiveStampReward(LoginStampRewardResponse response) { }

	// RVA: 0x2442E98 Offset: 0x243EE98 VA: 0x2442E98
	public void ReceiveLoginAvatarVariable(LoginAvatarVariableEvent login) { }

	// RVA: 0x2442EF4 Offset: 0x243EEF4 VA: 0x2442EF4
	public void AvatarComebackUpdate(Action<AvatarVariableUpdateResponse> callback) { }

	// RVA: 0x2442F98 Offset: 0x243EF98 VA: 0x2442F98
	public void ReceiveAvatarComeback(AvatarVariableUpdateResponse response) { }

	// RVA: 0x2443094 Offset: 0x243F094 VA: 0x2443094
	public void SkillCompensInquiry() { }

	// RVA: 0x2443154 Offset: 0x243F154 VA: 0x2443154
	public void EventDamage(int damage, byte damagaId, byte state, byte flag) { }

	// RVA: 0x244316C Offset: 0x243F16C VA: 0x244316C
	public void EventAbnormal(byte abnormalState, float stateTime, float resistTime, int value, byte localId, bool forceAdd) { }

	// RVA: 0x244317C Offset: 0x243F17C VA: 0x244317C
	public void EventMonsterDamage(SkillActionBase action, SkillDamageData damageData, byte damageId) { }

	// RVA: 0x2443384 Offset: 0x243F384 VA: 0x2443384
	public void MoodMessage(string moodMessage, bool isLog) { }

	// RVA: 0x244344C Offset: 0x243F44C VA: 0x244344C
	public void Emotion(GameObject actor, byte emotion, bool sitDown) { }

	// RVA: 0x24436A4 Offset: 0x243F6A4 VA: 0x24436A4
	public void Emotion(GameObject actor, byte emotionType, byte emotion) { }

	// RVA: 0x2443820 Offset: 0x243F820 VA: 0x2443820
	public void Emotion(GameObject actor, byte emotionType, byte emotion, Vector3 pos, float rotation) { }

	// RVA: 0x2443A30 Offset: 0x243FA30 VA: 0x2443A30
	public void EmotionCancel(GameObject actor) { }

	// RVA: 0x2443B8C Offset: 0x243FB8C VA: 0x2443B8C
	public void NPCEmotion(ArchetypeUid archetypeUid, EmotionPlayer.SendType sendType, byte id) { }

	// RVA: 0x2443B98 Offset: 0x243FB98 VA: 0x2443B98
	public void FieldEventAction(GameObject actor, byte eventActionId, bool sendPos) { }

	// RVA: 0x2443D50 Offset: 0x243FD50 VA: 0x2443D50
	public void RemoveReconnectionEmotionCancel() { }

	// RVA: 0x2443DE0 Offset: 0x243FDE0 VA: 0x2443DE0
	public byte GetNextPlayerDamageId() { }

	// RVA: 0x2443E00 Offset: 0x243FE00 VA: 0x2443E00
	public byte GetNextMobDamageId() { }

	// RVA: 0x2443E20 Offset: 0x243FE20 VA: 0x2443E20
	public void ReceiveMobKilled(MobData mobData, ResultData resultData, bool isResend, bool isParty) { }

	// RVA: 0x244466C Offset: 0x244066C VA: 0x244466C
	public void ReceiveMobKilled(BattleResultData battleResult, MobData[] mobIds, MonsterResultData[] mobResult, bool isResend) { }

	// RVA: 0x2444F28 Offset: 0x2440F28 VA: 0x2444F28
	public void ReceiveMobaMobKilled(MobData[] mobIds, MobaMonsterResultData mobResult, bool isResend) { }

	// RVA: 0x2445028 Offset: 0x2441028 VA: 0x2445028
	public void MobCreate(MobActionManagerBase mob) { }

	// RVA: 0x24450E8 Offset: 0x24410E8 VA: 0x24450E8
	public void AttackStartToMob(MobActionManagerBase mob, SkillActionBase action) { }

	// RVA: 0x2445C04 Offset: 0x2441C04 VA: 0x2445C04
	public void AttackDamage(MobActionManagerBase mob, SkillActionBase action, SkillDamageData damageData, byte id) { }

	// RVA: 0x24463C4 Offset: 0x24423C4 VA: 0x24463C4
	public void AttackDamage(SkillActionBase action, byte id) { }

	// RVA: 0x2447168 Offset: 0x2443168 VA: 0x2447168
	public void ComboEnd() { }

	// RVA: 0x24471C8 Offset: 0x24431C8 VA: 0x24471C8
	public void AttackPart(EnemyMobActionManagerBase boss, byte id, int damage) { }

	// RVA: 0x2447220 Offset: 0x2443220 VA: 0x2447220
	public void SkillEvent(GameObject actor, int skillId, byte localId, short skillEventId, Dictionary<TakeParameterType, int> param) { }

	// RVA: 0x24475C4 Offset: 0x24435C4 VA: 0x24475C4
	public void GuardAndAvoid(byte type, int param, int[] clientParam) { }

	// RVA: 0x24475D0 Offset: 0x24435D0 VA: 0x24475D0
	public void ReceiveGuardAndAvoid(GameReturnCode returnCode, GuardAndAvoidResponseData response) { }

	// RVA: 0x24476A8 Offset: 0x24436A8 VA: 0x24476A8
	public void ActionCancel(SkillActionBase action) { }

	// RVA: 0x24476EC Offset: 0x24436EC VA: 0x24476EC
	public void ActionSkillMotionEnd(Transform actorTransform, SkillActionBase action) { }

	// RVA: 0x24477E0 Offset: 0x24437E0 VA: 0x24477E0
	public void ActionEnd(SkillActionBase action) { }

	// RVA: 0x2447850 Offset: 0x2443850 VA: 0x2447850
	public void BattleEndCheck(float time) { }

	// RVA: 0x24478A4 Offset: 0x24438A4 VA: 0x24478A4
	public void StopBattleEndCheck() { }

	[IteratorStateMachine(typeof(GameManager.<waitBattleEndCheck>d__427))]
	// RVA: 0x24478E8 Offset: 0x24438E8 VA: 0x24478E8
	private IEnumerator waitBattleEndCheck(float time) { }

	// RVA: 0x244796C Offset: 0x244396C VA: 0x244796C
	public void ActionRemoveSkillBuffer(List<SkillId> removeSkillIdList) { }

	// RVA: 0x2447BAC Offset: 0x2443BAC VA: 0x2447BAC
	public void MobAttackStartToActor(EnemyMobActionManagerBase mobActionManager, SkillActionBase action, MobPatternBase mobPattern, GameObject target) { }

	// RVA: 0x2448044 Offset: 0x2444044 VA: 0x2448044
	public void MobAttackDamage(MobActionManagerBase mob, SkillActionBase action, byte id) { }

	[Obsolete("Debug")]
	// RVA: 0x2448D7C Offset: 0x2444D7C VA: 0x2448D7C
	public void DebugMobAttackDamage(MobActionManagerBase mob, AbnormalType type) { }

	// RVA: 0x2448D80 Offset: 0x2444D80 VA: 0x2448D80
	public void MobAttackDamage(MobActionManagerBase mob, SkillActionBase action, SkillDamageData damageData, byte id) { }

	// RVA: 0x2449094 Offset: 0x2445094 VA: 0x2449094
	public void MobEventAttack(MobSendData mobData, byte eventAttackType, int damage, AbnormalData abnormal, Dictionary<short, int> appendData, byte flag) { }

	// RVA: 0x2449358 Offset: 0x2445358 VA: 0x2449358
	public void NpcMobEventAttack(ArchetypeUid archetypeUid, MobSendData mobData, byte eventAttackType, int damage, AbnormalData abnormal, Dictionary<short, int> appendData, byte flag) { }

	// RVA: 0x244962C Offset: 0x244562C VA: 0x244962C
	public void MobSupport(MobActionManagerBase mob, SkillActionBase action, int supportValue, AbnormalType abnormalState, float abnormalStateTime, float abnormalStateResist, byte id) { }

	// RVA: 0x24497EC Offset: 0x24457EC VA: 0x24497EC
	public void MobRelease(MobActionManagerBase mob) { }

	// RVA: 0x24498A4 Offset: 0x24458A4 VA: 0x24498A4
	public void MobCheck(MobActionManagerBase mob) { }

	// RVA: 0x244995C Offset: 0x244595C VA: 0x244995C
	public void RoomEntreeStagingClear() { }

	// RVA: 0x2449A08 Offset: 0x2445A08 VA: 0x2449A08
	public void AreaBonusResult(short bounusGauge, short bounusMaxGauge, Dictionary<int, int> subdueMobs, bool resultThrough, byte state) { }

	// RVA: 0x2449AF4 Offset: 0x2445AF4 VA: 0x2449AF4
	public void StartSupportSkill(GameObject target, SkillActionBase action) { }

	// RVA: 0x2449F24 Offset: 0x2445F24 VA: 0x2449F24
	public void ActionSupportSkill(GameObject target, SkillActionBase action) { }

	// RVA: 0x244AB84 Offset: 0x2446B84 VA: 0x244AB84
	public void ActionCircleSupportSkill(List<GameObject> targetList, short skillId, byte localId, bool withPlayer) { }

	// RVA: 0x244B0DC Offset: 0x24470DC VA: 0x244B0DC
	public void ActionCircleSupportEnd(short skillId, byte localId) { }

	// RVA: 0x244B0E8 Offset: 0x24470E8 VA: 0x244B0E8
	public void ActionSuppportDelay(short skillId, List<TargetPlayerData> targetList, Dictionary<short, int> appendData, bool withPlayer) { }

	// RVA: 0x244B598 Offset: 0x2447598 VA: 0x244B598
	public void ReceiveActionSupportDelay(SupportDelayResponseData response) { }

	// RVA: 0x24427C4 Offset: 0x243E7C4 VA: 0x24427C4
	public void Summons(short skillId, byte localId, short[] sendPos, float rot) { }

	// RVA: 0x244B8F4 Offset: 0x24478F4 VA: 0x244B8F4
	public void ReceiveSummons(SkillSummonsResponseData response) { }

	// RVA: 0x244280C Offset: 0x243E80C VA: 0x244280C
	public void SummonsRemove(short skillId, byte localId, ArchetypeType servantType, bool forceRemove) { }

	// RVA: 0x244BF64 Offset: 0x2447F64 VA: 0x244BF64
	public void ReceiveSummonsRemove(SkillSummonsRemoveResponseData response) { }

	// RVA: 0x244C348 Offset: 0x2448348 VA: 0x244C348
	public bool GetFamilia(Action<GetFamiliaResponse> callback) { }

	// RVA: 0x244C420 Offset: 0x2448420 VA: 0x244C420
	public void ChangeFamilia(UIBasePanel panel, byte no, int color, int flag) { }

	// RVA: 0x244C58C Offset: 0x244858C VA: 0x244C58C
	public void UnlockFamilia(UIBasePanel panel, byte no, int useOrb, int orbNum) { }

	// RVA: 0x244C6F8 Offset: 0x24486F8 VA: 0x244C6F8
	public bool ParameterGetList() { }

	// RVA: 0x244C7C8 Offset: 0x24487C8 VA: 0x244C7C8
	public void ReceiveParameterGetList(ParameterGetListResponse parameterList) { }

	// RVA: 0x244C87C Offset: 0x244887C VA: 0x244C87C
	public void ParameterListReset() { }

	// RVA: 0x244C93C Offset: 0x244893C VA: 0x244C93C
	public void ReceiveParameterOrderReset(ParameterOrderResetResponse parameterList) { }

	// RVA: 0x244C9F4 Offset: 0x24489F4 VA: 0x244C9F4
	public bool ParameterGetStatus(byte paramId) { }

	// RVA: 0x244CADC Offset: 0x2448ADC VA: 0x244CADC
	public void ReceiveParameterGetStatus(ParameterGetStatusResponse response) { }

	// RVA: 0x244CB60 Offset: 0x2448B60 VA: 0x244CB60
	public bool ParameterNameChange(byte paramId, string name) { }

	// RVA: 0x244CCC8 Offset: 0x2448CC8 VA: 0x244CCC8
	public void ReceiveParameterNameChange(byte parameterId, string parameterName) { }

	// RVA: 0x244CD5C Offset: 0x2448D5C VA: 0x244CD5C
	public bool ParameterDelete(byte paramId) { }

	// RVA: 0x244CE44 Offset: 0x2448E44 VA: 0x244CE44
	public void ReceiveParameterDelete(ParameterDeleteResponse response) { }

	// RVA: 0x244CF4C Offset: 0x2448F4C VA: 0x244CF4C
	public bool ParameterCreate(byte paramId) { }

	// RVA: 0x244D034 Offset: 0x2449034 VA: 0x244D034
	public void NewParameterRegister(NewStyleData style, byte weaponNo, bool isNewMission) { }

	// RVA: 0x244D0FC Offset: 0x24490FC VA: 0x244D0FC
	public void ParameterCreateCancel() { }

	// RVA: 0x244D108 Offset: 0x2449108 VA: 0x244D108
	public bool ParameterChange(byte paramId) { }

	// RVA: 0x244D1F8 Offset: 0x24491F8 VA: 0x244D1F8
	public void UpdateParameterSlotMax(byte parameterSlotMax) { }

	// RVA: 0x244D250 Offset: 0x2449250 VA: 0x244D250
	public void ParameterOrderChange(byte[] orderList) { }

	// RVA: 0x244D33C Offset: 0x244933C VA: 0x244D33C
	public void ReceiveParameterSortChange(ParameterOrderChangeResponse response) { }

	// RVA: 0x244D398 Offset: 0x2449398 VA: 0x244D398
	public bool RenameChange() { }

	// RVA: 0x244D448 Offset: 0x2449448 VA: 0x244D448
	public bool TrophyCheckReward(int trophyId) { }

	// RVA: 0x244D610 Offset: 0x2449610 VA: 0x244D610
	public void ReceiveTrophyCheckReward(OperationCode code, int trophyId, RewardResponseDatav2 reward) { }

	// RVA: 0x2437328 Offset: 0x2433328 VA: 0x2437328
	public void SetRewardData(RewardResponseDatav2 reward) { }

	// RVA: 0x244D6BC Offset: 0x24496BC VA: 0x244D6BC
	public void SkillLevelUp(short skillId, byte skillTreeType, byte skillLevel, short skillPoint) { }

	// RVA: 0x244D7AC Offset: 0x24497AC VA: 0x244D7AC
	public void ReceiveSkillLevelUp(SkillLevelUpResponse response) { }

	// RVA: 0x244D94C Offset: 0x244994C VA: 0x244D94C
	public void CompensationSkillTreeReset(UIBasePanel panel, short skillId, byte compensNum) { }

	// RVA: 0x244DAA8 Offset: 0x2449AA8 VA: 0x244DAA8
	public void DeleteSkillTree(short skillTreeId) { }

	// RVA: 0x244DBE4 Offset: 0x2449BE4 VA: 0x244DBE4
	public void GameRecord() { }

	// RVA: 0x244DC10 Offset: 0x2449C10 VA: 0x244DC10
	public void ReceiveGameRecord(GameRecordEvent record) { }

	// RVA: 0x244DC70 Offset: 0x2449C70 VA: 0x244DC70
	public void SaveRespawnPosition(int fieldId, short[] position) { }

	// RVA: 0x244DCA0 Offset: 0x2449CA0 VA: 0x244DCA0
	public void RespawnChangeField() { }

	// RVA: 0x244DD58 Offset: 0x2449D58 VA: 0x244DD58
	public void YellsRespawn() { }

	// RVA: 0x244DDF8 Offset: 0x2449DF8 VA: 0x244DDF8
	public void CheckRespawnTime() { }

	// RVA: 0x244DE04 Offset: 0x2449E04 VA: 0x244DE04
	public void NormalRespawn() { }

	// RVA: 0x244DEC8 Offset: 0x2449EC8 VA: 0x244DEC8
	public void SystemRespawn() { }

	// RVA: 0x244DF78 Offset: 0x2449F78 VA: 0x244DF78
	public void ChannelGetList() { }

	// RVA: 0x244E03C Offset: 0x244A03C VA: 0x244E03C
	public void ChannelGetWorld() { }

	// RVA: 0x244E100 Offset: 0x244A100 VA: 0x244E100
	public void ChannelChange(int fieldId, int channel, int worldId) { }

	// RVA: 0x244E11C Offset: 0x244A11C VA: 0x244E11C
	public void ChannelGetGlobal() { }

	// RVA: 0x244E214 Offset: 0x244A214 VA: 0x244E214
	public void GlobalChannelGetList(UIBasePanel manager) { }

	// RVA: 0x244E314 Offset: 0x244A314 VA: 0x244E314
	public void GlobalChannelGetWorld(UIBasePanel manager) { }

	// RVA: 0x244E414 Offset: 0x244A414 VA: 0x244E414
	public void GlobalChange(int worldId, int id, short point) { }

	// RVA: 0x244E578 Offset: 0x244A578 VA: 0x244E578
	public void GlobalChannelChange(int worldId, byte channelId) { }

	// RVA: 0x244E6D4 Offset: 0x244A6D4 VA: 0x244E6D4
	public void ReturnServer() { }

	// RVA: 0x244E7CC Offset: 0x244A7CC VA: 0x244E7CC
	public void AttachCrista(int itemUid, byte slotId, int cristaId) { }

	// RVA: 0x244E8C4 Offset: 0x244A8C4 VA: 0x244E8C4
	public void DestroyCrista(int itemUid, byte slotId) { }

	// RVA: 0x244E9A8 Offset: 0x244A9A8 VA: 0x244E9A8
	public void DetachCrista(int itemUid, byte slotId, int useItemId) { }

	// RVA: 0x244E9FC Offset: 0x244A9FC VA: 0x244E9FC
	public void AttachReinforceCrista(int itemUid, byte slotId, int cristaId) { }

	// RVA: 0x244EB04 Offset: 0x244AB04 VA: 0x244EB04
	public void ReceiveAttachReinforceCrista(ItemDatav2[] itemList) { }

	// RVA: 0x244EB34 Offset: 0x244AB34 VA: 0x244EB34
	public void AttachOrbReinforceCrista(int itemUid, byte slotId, int cristaId) { }

	// RVA: 0x244EC44 Offset: 0x244AC44 VA: 0x244EC44
	public void AttachOrbServiceReinforceCrista(int itemUid, byte slotId, int cristaId) { }

	// RVA: 0x244ED88 Offset: 0x244AD88 VA: 0x244ED88
	public void UpdateCristaSlot(int hp, int exHp, short mp, short exMp, ItemDatav2[] itemList) { }

	// RVA: 0x244ED94 Offset: 0x244AD94 VA: 0x244ED94
	public void UpdateCristaSlot(int hp, int exHp, short mp, short exMp, bool isNewItem, ItemDatav2[] itemList) { }

	// RVA: 0x244EED0 Offset: 0x244AED0 VA: 0x244EED0
	public bool GetStorageList() { }

	// RVA: 0x244EFA8 Offset: 0x244AFA8 VA: 0x244EFA8
	public void ReceiveStorageList(StorageDatav2[] storageList, byte storageLimit, byte[] orderList) { }

	// RVA: 0x244F048 Offset: 0x244B048 VA: 0x244F048
	public bool StorageEdit(byte storageNo, string storageName, string storageInfo) { }

	// RVA: 0x244F158 Offset: 0x244B158 VA: 0x244F158
	public void ReceiveStorageEdit(byte storageNo, string storageName, string storageInfo) { }

	// RVA: 0x244F1F8 Offset: 0x244B1F8 VA: 0x244F1F8
	public void UpdateStorageItem(int storageNo, StorageManager.ConnectFlag connectFlag, StorageItemDatav3[] storageItemData) { }

	// RVA: 0x244F268 Offset: 0x244B268 VA: 0x244F268
	public bool StorageGetItem(byte storageNo) { }

	// RVA: 0x244F350 Offset: 0x244B350 VA: 0x244F350
	public bool StorageTake(byte storageNo, byte bagId, StorageItemDatav3 storageItem, byte type, short num) { }

	// RVA: 0x244F480 Offset: 0x244B480 VA: 0x244F480
	public bool StoragePut(byte storageNo, ItemSelectData data, byte useType) { }

	// RVA: 0x244F5AC Offset: 0x244B5AC VA: 0x244F5AC
	public void ReceiveStoragePut(ItemDatav2 itemData) { }

	// RVA: 0x244F6AC Offset: 0x244B6AC VA: 0x244F6AC
	public bool StorageDiscard(byte storageNo, StorageItemDatav3 storageItem) { }

	// RVA: 0x244F7AC Offset: 0x244B7AC VA: 0x244F7AC
	public bool StorageSort(byte storageNo, byte storagePageNo) { }

	// RVA: 0x244F8A4 Offset: 0x244B8A4 VA: 0x244F8A4
	public bool StorageLock(byte storageNo, StorageItemDatav3 storageItem, byte itemUserFlag) { }

	// RVA: 0x244F9B4 Offset: 0x244B9B4 VA: 0x244F9B4
	public void StorageOrderChange(byte[] orderList) { }

	// RVA: 0x244FA60 Offset: 0x244BA60 VA: 0x244FA60
	public void ReceiveStorageOrderChange(byte[] orderList) { }

	// RVA: 0x244FAB8 Offset: 0x244BAB8 VA: 0x244FAB8
	public void RecoveryStorageGetInfo(UIBasePanel panel) { }

	// RVA: 0x244FABC Offset: 0x244BABC VA: 0x244FABC
	public void RecoveryStorageGetItems(UIBasePanel panel, byte no) { }

	// RVA: 0x244FAC0 Offset: 0x244BAC0 VA: 0x244FAC0
	public void RecoveryStorageGetItem(UIBasePanel panel, byte no, byte bagId, StorageItemDatav3 storageItem) { }

	// RVA: 0x2436D28 Offset: 0x2432D28 VA: 0x2436D28
	public void AutoUpdate(AppVerData appData) { }

	[IteratorStateMachine(typeof(GameManager.<AutoUpdateCoroutine>d__522))]
	// RVA: 0x244FB48 Offset: 0x244BB48 VA: 0x244FB48
	public IEnumerator AutoUpdateCoroutine(int appver) { }

	[IteratorStateMachine(typeof(GameManager.<autoUpdate>d__523))]
	// RVA: 0x244FAC4 Offset: 0x244BAC4 VA: 0x244FAC4
	private IEnumerator autoUpdate(int appver) { }

	// RVA: 0x244FBCC Offset: 0x244BBCC VA: 0x244FBCC
	public void GuildCheckName(string guildName) { }

	// RVA: 0x244FCA4 Offset: 0x244BCA4 VA: 0x244FCA4
	public void GuildCreate(string guildName) { }

	// RVA: 0x244FCB0 Offset: 0x244BCB0 VA: 0x244FCB0
	public void GuildCreateResponse(GuildCreateResponse response) { }

	// RVA: 0x244FD04 Offset: 0x244BD04 VA: 0x244FD04
	public void GuildInvitation(int targetId, string message, string targetName) { }

	// RVA: 0x244FD10 Offset: 0x244BD10 VA: 0x244FD10
	public void OnGuildInvitation() { }

	// RVA: 0x244FD38 Offset: 0x244BD38 VA: 0x244FD38
	public void GuildInvitationReject(int guildId) { }

	// RVA: 0x244FE10 Offset: 0x244BE10 VA: 0x244FE10
	public void GuildInvitationRejectResponse(int guildId) { }

	// RVA: 0x244FE40 Offset: 0x244BE40 VA: 0x244FE40
	public void GuildInvitationCancel(int targetId) { }

	// RVA: 0x244FEEC Offset: 0x244BEEC VA: 0x244FEEC
	public void GuildInvitationCancelResponse(GuildInviteSenderCancelResponse response) { }

	// RVA: 0x244FF68 Offset: 0x244BF68 VA: 0x244FF68
	public void OnGuildInvitationCancel(GuildInviteSenderCancelEvent events) { }

	// RVA: 0x244FF98 Offset: 0x244BF98 VA: 0x244FF98
	public void GuildAcceptance(int guildId) { }

	// RVA: 0x2450070 Offset: 0x244C070 VA: 0x2450070
	public void OnGuildAcceptance(GuildAcceptanceResponse data) { }

	// RVA: 0x24501B4 Offset: 0x244C1B4 VA: 0x24501B4
	public void GuildSecede() { }

	// RVA: 0x24501C0 Offset: 0x244C1C0 VA: 0x24501C0
	public void GuildSecedeResponse(GuildSecedeResponse response) { }

	// RVA: 0x2450210 Offset: 0x244C210 VA: 0x2450210
	public void OnGuildSecede(GuildSecedeEvent secede) { }

	// RVA: 0x2450240 Offset: 0x244C240 VA: 0x2450240
	public void GuildExile(int targetId) { }

	// RVA: 0x24502EC Offset: 0x244C2EC VA: 0x24502EC
	public void GuildExileResponse() { }

	// RVA: 0x2450340 Offset: 0x244C340 VA: 0x2450340
	public void OnGuildExile(GuildExileEvent exile) { }

	// RVA: 0x2450380 Offset: 0x244C380 VA: 0x2450380
	public void GuildDissolution() { }

	// RVA: 0x2450474 Offset: 0x244C474 VA: 0x2450474
	public void GuildDissolutionResponse(GuildDissolutionResponse response) { }

	// RVA: 0x24504C4 Offset: 0x244C4C4 VA: 0x24504C4
	public void GuildGetData() { }

	// RVA: 0x24505B0 Offset: 0x244C5B0 VA: 0x24505B0
	public void GuildGetMember() { }

	// RVA: 0x24506C8 Offset: 0x244C6C8 VA: 0x24506C8
	public void GuildGetBoard() { }

	// RVA: 0x245078C Offset: 0x244C78C VA: 0x245078C
	public void GuildWriteBoard(byte type, string message) { }

	// RVA: 0x2450870 Offset: 0x244C870 VA: 0x2450870
	public void GuildCheck() { }

	// RVA: 0x2450968 Offset: 0x244C968 VA: 0x2450968
	public void OnEventGuildCheck(GuildCheckEvent checkEvent) { }

	// RVA: 0x24509EC Offset: 0x244C9EC VA: 0x24509EC
	public void OnGuildRequest(GuildInvitationEvent events) { }

	// RVA: 0x2450A20 Offset: 0x244CA20 VA: 0x2450A20
	public void OnGuildJoin(GuildJoinEvent join) { }

	// RVA: 0x2450A50 Offset: 0x244CA50 VA: 0x2450A50
	public void OnGuildJoin(GuildBBSJoinEvent join) { }

	// RVA: 0x2450A80 Offset: 0x244CA80 VA: 0x2450A80
	public void OnGuildBBSAllowRequest(GuildBBSAllowRequestEvent allowEvent) { }

	// RVA: 0x2450BC4 Offset: 0x244CBC4 VA: 0x2450BC4
	public void OnGuildBBSJoinRequest(GuildBBSJoinRequestEvent joinRequestEvent) { }

	// RVA: 0x2450BF4 Offset: 0x244CBF4 VA: 0x2450BF4
	public void GuildChangeAuthority(int targetId, byte authority) { }

	// RVA: 0x2450C00 Offset: 0x244CC00 VA: 0x2450C00
	public void GuildChangeAuthorityResponse(GuildPostChangeResponse response) { }

	// RVA: 0x2450C3C Offset: 0x244CC3C VA: 0x2450C3C
	public void OnGuildChangeAuthority(GuildPostChangeEvent response) { }

	// RVA: 0x2450C78 Offset: 0x244CC78 VA: 0x2450C78
	public void UpdateCheckProperties() { }

	// RVA: 0x2450CA0 Offset: 0x244CCA0 VA: 0x2450CA0
	public void GuildChangeName(string guildName) { }

	// RVA: 0x2450D78 Offset: 0x244CD78 VA: 0x2450D78
	public void OnGuildChangeName(GuildNameChangeEvent eventChangeName) { }

	// RVA: 0x2450DA8 Offset: 0x244CDA8 VA: 0x2450DA8
	public void OnGuildLevelUp(GuildLevelUpEvent levelUp) { }

	// RVA: 0x2450EF4 Offset: 0x244CEF4 VA: 0x2450EF4
	public void GuildCheckNameFailure(GameReturnCode returnCode) { }

	// RVA: 0x2450F24 Offset: 0x244CF24 VA: 0x2450F24
	public void GuildSettingTenant(int tenant, bool flag) { }

	// RVA: 0x2451078 Offset: 0x244D078 VA: 0x2451078
	public void GuildUpdateTenant() { }

	// RVA: 0x2451170 Offset: 0x244D170 VA: 0x2451170
	public void GuildOpenRenovation(byte renovationId) { }

	// RVA: 0x24512B0 Offset: 0x244D2B0 VA: 0x24512B0
	public void GuildChangeRenovation(byte renovationId) { }

	// RVA: 0x24513F0 Offset: 0x244D3F0 VA: 0x24513F0
	public void GuildContributeGold(UIBasePanel panel, int point) { }

	// RVA: 0x2451540 Offset: 0x244D540 VA: 0x2451540
	public void GuildMedalUpdate() { }

	// RVA: 0x2451638 Offset: 0x244D638 VA: 0x2451638
	public void GuildLevelUpFacility(int id, short nowLevel, byte element) { }

	// RVA: 0x2451798 Offset: 0x244D798 VA: 0x2451798
	public void GuildSetFacilityFlag(bool isActive) { }

	// RVA: 0x24518D8 Offset: 0x244D8D8 VA: 0x24518D8
	public void GetGuildStaffData() { }

	// RVA: 0x24519EC Offset: 0x244D9EC VA: 0x24519EC
	public void GuildStaffRunningErrand() { }

	// RVA: 0x2451B00 Offset: 0x244DB00 VA: 0x2451B00
	public void GuildStaffRecoveryPlayer() { }

	// RVA: 0x2451C14 Offset: 0x244DC14 VA: 0x2451C14
	public void StartChangeStaffData(GuildStaffChangeType type) { }

	// RVA: 0x2451D6C Offset: 0x244DD6C VA: 0x2451D6C
	public void CancelChangeStaffData(GuildStaffChangeType type) { }

	// RVA: 0x2451EAC Offset: 0x244DEAC VA: 0x2451EAC
	public void EndChangeStaffName(string name) { }

	// RVA: 0x2452004 Offset: 0x244E004 VA: 0x2452004
	public void EndChangeStaffEquip(Dictionary<byte, int> equipData) { }

	// RVA: 0x245215C Offset: 0x244E15C VA: 0x245215C
	public void EndChangeStaffStyle(NewStyleData styleData) { }

	// RVA: 0x24522B4 Offset: 0x244E2B4 VA: 0x24522B4
	public void GuildStaffChangeFlag(GuildStaffFlag type, bool flag) { }

	// RVA: 0x2452404 Offset: 0x244E404 VA: 0x2452404
	public void GuildStaffChangeSupport(byte type) { }

	// RVA: 0x2452544 Offset: 0x244E544 VA: 0x2452544
	public void GuildHeldRaid(int raidId, bool isPractice) { }

	// RVA: 0x2452698 Offset: 0x244E698 VA: 0x2452698
	public void GuildGetHeldRaidData() { }

	// RVA: 0x2452790 Offset: 0x244E790 VA: 0x2452790
	public void GuildResetRaid() { }

	// RVA: 0x2452888 Offset: 0x244E888 VA: 0x2452888
	public void GuildEndHeldRaid() { }

	// RVA: 0x2452980 Offset: 0x244E980 VA: 0x2452980
	public void GuildQuestGetQuest(UIBasePanel panel) { }

	// RVA: 0x2452A80 Offset: 0x244EA80 VA: 0x2452A80
	public void GuildQuestResetQuest(UIBasePanel panel, byte no) { }

	// RVA: 0x2452BD0 Offset: 0x244EBD0 VA: 0x2452BD0
	public void GuildQuestDiscardQuest(UIBasePanel panel, byte no, byte type) { }

	// RVA: 0x2452D2C Offset: 0x244ED2C VA: 0x2452D2C
	public void GuildQuestReportQuest(UIBasePanel panel, byte no, byte clear) { }

	// RVA: 0x2452E8C Offset: 0x244EE8C VA: 0x2452E8C
	public void GuildQuestItemReportQuest(UIBasePanel panel, byte no, int value, byte clear) { }

	// RVA: 0x2452FFC Offset: 0x244EFFC VA: 0x2452FFC
	public void OnTransferMasterPost(int id) { }

	// RVA: 0x24530F4 Offset: 0x244F0F4 VA: 0x24530F4
	public void TransferMasterPostResponse(GuildTransferMasterPostResponse response) { }

	// RVA: 0x2453134 Offset: 0x244F134 VA: 0x2453134
	public void EventTranstferMasterPost(GuildTransferMasterEvent transEvent) { }

	// RVA: 0x2453174 Offset: 0x244F174 VA: 0x2453174
	public void OnCandidacyMasterPost(int id) { }

	// RVA: 0x245326C Offset: 0x244F26C VA: 0x245326C
	public void CandidacyMasterPostResponse(GuildCandidacyMasterPostResponse response) { }

	// RVA: 0x24532AC Offset: 0x244F2AC VA: 0x24532AC
	public void EventCandidacyMasterPost(GuildCandidacyMasterEvent transEvent) { }

	// RVA: 0x24532EC Offset: 0x244F2EC VA: 0x24532EC
	public void ChangeGuildMasterOperationFailure() { }

	// RVA: 0x2453314 Offset: 0x244F314 VA: 0x2453314
	public void UpdateGuildVariableData(GuildVariableData[] list) { }

	// RVA: 0x2453344 Offset: 0x244F344 VA: 0x2453344
	public void GuildChangeOnlineNotice(byte type) { }

	// RVA: 0x24533F0 Offset: 0x244F3F0 VA: 0x24533F0
	public void GuildChangeOnlineNoticeResponse() { }

	// RVA: 0x2453468 Offset: 0x244F468 VA: 0x2453468
	public void OnGuildGetBooster() { }

	// RVA: 0x2453528 Offset: 0x244F528 VA: 0x2453528
	public void GuildGetBoosterResponse(GuildGetBoosterResponse response) { }

	// RVA: 0x245355C Offset: 0x244F55C VA: 0x245355C
	public void OnGuildCheckContribution() { }

	// RVA: 0x2453648 Offset: 0x244F648 VA: 0x2453648
	public void GuildCheckContributionResponse(GuildCheckContributionResponse response) { }

	// RVA: 0x245364C Offset: 0x244F64C VA: 0x245364C
	public void OnGuildCollectContribution() { }

	// RVA: 0x2453738 Offset: 0x244F738 VA: 0x2453738
	public void GuildCollectContributionResponse(GuildCollectContributionResponse response) { }

	// RVA: 0x245373C Offset: 0x244F73C VA: 0x245373C
	public void OnGuildRunBooster(GuildBoosterType type) { }

	// RVA: 0x2453834 Offset: 0x244F834 VA: 0x2453834
	public void GuildRunBoosterResponse(GuildRunBoosterResponse response) { }

	// RVA: 0x2453838 Offset: 0x244F838 VA: 0x2453838
	public void EventGuildRunBoosterResponse(GuildRunBoosterEvent boosterEvent) { }

	// RVA: 0x245397C Offset: 0x244F97C VA: 0x245397C
	public void OnGuildPresent(GuildPresentType type) { }

	// RVA: 0x2453A74 Offset: 0x244FA74 VA: 0x2453A74
	public void GuildPresentResponse(GuildPresentResponse response) { }

	// RVA: 0x2453A78 Offset: 0x244FA78 VA: 0x2453A78
	public void EventGuildPresentResponse(GuildPresentEvent presentEvent) { }

	// RVA: 0x2453AA8 Offset: 0x244FAA8 VA: 0x2453AA8
	public void CheckBossSymbol(int fieldId, byte roomId, bool forcibly) { }

	// RVA: 0x2453B7C Offset: 0x244FB7C VA: 0x2453B7C
	public void ReceiveCheckBossSymbol(CheckBossSymbolResponse response) { }

	// RVA: 0x2453D3C Offset: 0x244FD3C VA: 0x2453D3C
	public void CheckBossRaidSymbol(int fieldId, byte roomId, bool isMatching) { }

	// RVA: 0x2453E18 Offset: 0x244FE18 VA: 0x2453E18
	public void ReceiveCheckBossRaidSymbol(CheckRaidBossSymbolResponse response) { }

	// RVA: 0x2453FD4 Offset: 0x244FFD4 VA: 0x2453FD4
	public void CheckTreasureHuntRoom(int fieldId, byte roomId) { }

	// RVA: 0x2454094 Offset: 0x2450094 VA: 0x2454094
	public void ReceiveCheckTreasureHuntRoom(CheckTreasureHuntRoomResponse response) { }

	// RVA: 0x24541C8 Offset: 0x24501C8 VA: 0x24541C8
	public void CheckDungeonRoom() { }

	// RVA: 0x245432C Offset: 0x245032C VA: 0x245432C
	public void ReceiveCheckDungeonRoom(CheckDungeonRoomResponse response) { }

	// RVA: 0x2454448 Offset: 0x2450448 VA: 0x2454448
	public void CheckDefenceRoom(int fieldId, byte flag, short level) { }

	// RVA: 0x24545EC Offset: 0x24505EC VA: 0x24545EC
	public void ReceiveCheckDefenceRoom(CheckDefenceRoomResponse response) { }

	// RVA: 0x2454718 Offset: 0x2450718 VA: 0x2454718
	public void CheckGuildRaidRoom(UIBasePanel basePanel) { }

	// RVA: 0x2454818 Offset: 0x2450818 VA: 0x2454818
	public void ReceiveCheckGuildRaidRoom(CheckGuildRaidRoomResponse response) { }

	// RVA: 0x2454BB4 Offset: 0x2450BB4 VA: 0x2454BB4
	public void GetRaidBossData() { }

	// RVA: 0x2454CAC Offset: 0x2450CAC VA: 0x2454CAC
	public void RoomJoinCancel() { }

	// RVA: 0x2454D4C Offset: 0x2450D4C VA: 0x2454D4C
	public void RoomJoinReadyCancel() { }

	// RVA: 0x2454DEC Offset: 0x2450DEC VA: 0x2454DEC
	public void RoomJoinReady() { }

	// RVA: 0x2454DF8 Offset: 0x2450DF8 VA: 0x2454DF8
	public void RoomJoinReady(int[] itemList, int[] orbItemList) { }

	// RVA: 0x2454EB8 Offset: 0x2450EB8 VA: 0x2454EB8
	public void ReceiveRoomJoinReady(bool isBattle) { }

	// RVA: 0x2454F38 Offset: 0x2450F38 VA: 0x2454F38
	public void RoomBattleJoin() { }

	// RVA: 0x2455040 Offset: 0x2451040 VA: 0x2455040
	public void RoomBattleStart() { }

	// RVA: 0x245504C Offset: 0x245104C VA: 0x245504C
	public void RoomBattleStart(int[] itemList, int[] orbItemList) { }

	// RVA: 0x2455174 Offset: 0x2451174 VA: 0x2455174
	public void RoomState() { }

	// RVA: 0x24551A0 Offset: 0x24511A0 VA: 0x24551A0
	public void RoomStartEntry(RoomGroupSetting groupSetting) { }

	// RVA: 0x24551AC Offset: 0x24511AC VA: 0x24551AC
	public void RoomStartEntry(RoomGroupSetting groupSetting, int[] itemList, int[] orbItemList) { }

	// RVA: 0x2455338 Offset: 0x2451338 VA: 0x2455338
	public void RoomStart() { }

	// RVA: 0x2455430 Offset: 0x2451430 VA: 0x2455430
	public void RoomLobbyLeave() { }

	// RVA: 0x2455528 Offset: 0x2451528 VA: 0x2455528
	public void RoomLobbyJoinCancel() { }

	// RVA: 0x2455620 Offset: 0x2451620 VA: 0x2455620
	public void RoomLobbyJoin() { }

	// RVA: 0x2455718 Offset: 0x2451718 VA: 0x2455718
	public void RoomLobbyJoin(int[] supportItems, int[] supportOrbItems) { }

	// RVA: 0x245588C Offset: 0x245188C VA: 0x245588C
	public void RoomLobbyJoin(byte[] itemList) { }

	// RVA: 0x24559F0 Offset: 0x24519F0 VA: 0x24559F0
	public void RoomLobbyJoin_Plus(byte[] itemList, int[] supportItems, int[] supportOrbItems) { }

	// RVA: 0x2455B88 Offset: 0x2451B88 VA: 0x2455B88
	public void ReceiveRoomLobbyJoin(bool isBattle) { }

	// RVA: 0x2455C0C Offset: 0x2451C0C VA: 0x2455C0C
	public void RoomLobbyBattleJoin() { }

	// RVA: 0x2455DA0 Offset: 0x2451DA0 VA: 0x2455DA0
	public void RaidRoomBattleStart() { }

	// RVA: 0x2455EA8 Offset: 0x2451EA8 VA: 0x2455EA8
	public void GuildRaidRoomLobbyBattleStart() { }

	// RVA: 0x2456048 Offset: 0x2452048 VA: 0x2456048
	public void GuildRaidRoomLobbyJoin() { }

	// RVA: 0x2456174 Offset: 0x2452174 VA: 0x2456174
	public void GuildRaidRoomLobbyJoinCancel() { }

	// RVA: 0x245626C Offset: 0x245226C VA: 0x245626C
	public void TreasureHuntRoomLobbyBattleStart(byte[] bonusList) { }

	// RVA: 0x2456388 Offset: 0x2452388 VA: 0x2456388
	public void TreasureHuntRoomLobbyBattleStart_Plus(byte[] bonusList, int[] supportItems, int[] supportOrbItems) { }

	// RVA: 0x24564C4 Offset: 0x24524C4 VA: 0x24564C4
	public void GuildRaidRoomLobbyState(UIBasePanel basePanel) { }

	// RVA: 0x2456578 Offset: 0x2452578 VA: 0x2456578
	public void RaidRoomState() { }

	// RVA: 0x2456584 Offset: 0x2452584 VA: 0x2456584
	public void HighRaidRoomBattleStart(int[] supportItems, int[] supportOrbItems) { }

	// RVA: 0x24566AC Offset: 0x24526AC VA: 0x24566AC
	public bool RoomGroupSettingChange(bool isReinforce, short areaLevel) { }

	// RVA: 0x24567B0 Offset: 0x24527B0 VA: 0x24567B0
	public bool RoomLobbySettingChange(bool isMatching, bool isSecondParty, short areaLevel) { }

	// RVA: 0x2456898 Offset: 0x2452898 VA: 0x2456898
	public bool RoomLobbySettingChange(bool isMatching, short areaLevel) { }

	// RVA: 0x2456974 Offset: 0x2452974 VA: 0x2456974
	public bool WeeklyRoomGroupSettingChange(short areaLevel) { }

	// RVA: 0x2456A64 Offset: 0x2452A64 VA: 0x2456A64
	public bool NewWaveRoomLobbySettingChange(short areaLevel) { }

	// RVA: 0x2456B2C Offset: 0x2452B2C VA: 0x2456B2C
	public bool HighRaidRoomLobbySettincChange(short areaLevel) { }

	// RVA: 0x2456BF4 Offset: 0x2452BF4 VA: 0x2456BF4
	public bool NCollaborationRoomLobbySettincChange(bool isMatching, bool isSecondParty, short areaLevel) { }

	// RVA: 0x2456CDC Offset: 0x2452CDC VA: 0x2456CDC
	public bool NaCollaborationRoomLobbySettingChange(short areaLevel) { }

	// RVA: 0x2453CA4 Offset: 0x244FCA4 VA: 0x2453CA4
	public void UpdateRoomState(RoomSetting roomSetting, RoomGroupSetting groupSetting, List<IRoomMember> members) { }

	// RVA: 0x2453F58 Offset: 0x244FF58 VA: 0x2453F58
	public void UpdateRoomState(RoomLobbySetting setting, List<IRoomMember> members) { }

	// RVA: 0x2456DB4 Offset: 0x2452DB4 VA: 0x2456DB4
	public void AddUsedGemUser(RoomSupportUseData[] roomSupportUseItemDataList, bool entreeStagingFlag, int[] targetMobList) { }

	// RVA: 0x2457AE4 Offset: 0x2453AE4 VA: 0x2457AE4
	public void EventRoomBattleStart(int[] supportList, int[] targetMobList) { }

	// RVA: 0x2458088 Offset: 0x2454088 VA: 0x2458088
	public void RoomSecondPartyRegistry(int[] npcId) { }

	// RVA: 0x2458094 Offset: 0x2454094 VA: 0x2458094
	public void RoomSecondPartyJoin(NpcJoinPositionData[] positionData) { }

	// RVA: 0x24580A0 Offset: 0x24540A0 VA: 0x24580A0
	public void RoomWarpPosition() { }

	// RVA: 0x245819C Offset: 0x245419C VA: 0x245819C
	public void RoomWarpPosition(Vector3 position) { }

	// RVA: 0x2458310 Offset: 0x2454310 VA: 0x2458310
	public void OnAutoMemberJoin(NpcArchetype npcArchetype, NpcAvatarJoinResponse npcSetting) { }

	// RVA: 0x24583A4 Offset: 0x24543A4 VA: 0x24583A4
	public void OnRoomNpcJoinEvent(NpcArchetype npcArchetype, RoomNpcJoinEvent npcSetting) { }

	// RVA: 0x2458438 Offset: 0x2454438 VA: 0x2458438
	public void OnAutoMemberRejoin(NpcArchetype npcArchetype, NpcAvatarRejoinResponse npcSetting) { }

	// RVA: 0x24584CC Offset: 0x24544CC VA: 0x24584CC
	public void OnPartnerAvatarJoin(PartnerArchetype response) { }

	// RVA: 0x245855C Offset: 0x245455C VA: 0x245855C
	public void OnPetAvatarJoin(PetArchetype response) { }

	// RVA: 0x24585EC Offset: 0x24545EC VA: 0x24585EC
	public void OnMercenaryAvatarJoin(MercenaryArchetype response) { }

	// RVA: 0x245867C Offset: 0x245467C VA: 0x245867C
	public void OnFamiliaAvatarJoin(FamiliaArchetype response) { }

	// RVA: 0x245870C Offset: 0x245470C VA: 0x245870C
	public void OnHuntingOneAvatarJoin(HuntingOneArchetype response) { }

	// RVA: 0x245879C Offset: 0x245479C VA: 0x245879C
	public void OnSummonDemonicAvatarJoin(SummonDemonicArchetype response) { }

	// RVA: 0x245882C Offset: 0x245482C VA: 0x245882C
	public void OnCallGolemAvatarJoin(CallGolemArchetype response) { }

	// RVA: 0x24588BC Offset: 0x24548BC VA: 0x24588BC
	public void AutomemberRejoin(RoomArchetypeManagedEvent response) { }

	// RVA: 0x24588EC Offset: 0x24548EC VA: 0x24588EC
	public void AutoMemberMove(ArchetypeUid archetypeUid, Transform transform) { }

	// RVA: 0x24589B4 Offset: 0x24549B4 VA: 0x24589B4
	public void AutoMemberMove(ArchetypeUid archetypeUid, Transform transform, short speed) { }

	// RVA: 0x2458A8C Offset: 0x2454A8C VA: 0x2458A8C
	public void NpcAttackDamage(ArchetypeUid archetypeUid, MobActionManagerBase mob, SkillActionBase action, SkillDamageData damageData, byte dmgId) { }

	// RVA: 0x2458E6C Offset: 0x2454E6C VA: 0x2458E6C
	public void NpcAttackDamage(ArchetypeUid archetypeUid, SkillActionBase action, byte dmgId) { }

	// RVA: 0x2459464 Offset: 0x2455464 VA: 0x2459464
	public void NpcAttackStartToMob(ArchetypeUid archetypeUid, Transform npcTrans, MobActionManagerBase mob, SkillActionBase action) { }

	// RVA: 0x24598C8 Offset: 0x24558C8 VA: 0x24598C8
	public void NpcStartSupportSkill(ArchetypeUid archetypeUid, Transform npcTrans, GameObject target, SkillActionBase action) { }

	// RVA: 0x2459AA8 Offset: 0x2455AA8 VA: 0x2459AA8
	public void NpcActionSupportSkill(ArchetypeUid archetypeUid, GameObject target, SkillActionBase action, bool self) { }

	// RVA: 0x2459E74 Offset: 0x2455E74 VA: 0x2459E74
	public void NpcActionEnd(ArchetypeUid archetypeUid, SkillActionBase action) { }

	// RVA: 0x2459EF8 Offset: 0x2455EF8 VA: 0x2459EF8
	public void NpcActionCancel(ArchetypeUid archetypeUid, SkillActionBase action) { }

	// RVA: 0x2459F44 Offset: 0x2455F44 VA: 0x2459F44
	public void NpcActionSkillMotionEnd(ArchetypeUid archetypeUid, SkillActionBase action) { }

	// RVA: 0x2459F90 Offset: 0x2455F90 VA: 0x2459F90
	public void NpcBattleEndCheck(ArchetypeUid archetypeUid) { }

	// RVA: 0x2459F9C Offset: 0x2455F9C VA: 0x2459F9C
	public void MobAttackStartToNpc(ArchetypeUid archetypeUid, MobActionManagerBase mob, SkillActionBase action, MobPatternBase mobPattern) { }

	// RVA: 0x245A1EC Offset: 0x24561EC VA: 0x245A1EC
	public void NpcMobAttackDamage(ArchetypeUid archetypeUid, MobActionManagerBase mob, SkillActionBase action, byte id) { }

	// RVA: 0x245A868 Offset: 0x2456868 VA: 0x245A868
	public void NpcMobAttackDamage(ArchetypeUid archetypeUid, MobActionManagerBase mob, SkillActionBase action, SkillDamageData damageData, byte id) { }

	// RVA: 0x245AB28 Offset: 0x2456B28 VA: 0x245AB28
	public void NpcForcedKill(ArchetypeUid archetypeUid) { }

	// RVA: 0x245AC34 Offset: 0x2456C34 VA: 0x245AC34
	public void NpcMobSupport(ArchetypeUid archetypeUid, MobActionManagerBase mob, SkillActionBase action, int supportValue, AbnormalType abnormalState, float abnormalStateTime, float abnormalStateResist, byte id) { }

	// RVA: 0x2442B64 Offset: 0x243EB64 VA: 0x2442B64
	public void UpdateNpcStatus(ArchetypeUid archetypeId, PlayerStatusData status) { }

	// RVA: 0x245ADFC Offset: 0x2456DFC VA: 0x245ADFC
	public void NpcRespawn(ArchetypeUid archetypeUid) { }

	// RVA: 0x245AED4 Offset: 0x2456ED4 VA: 0x245AED4
	public void OnNpcRespawn(NpcRespawnResponse response) { }

	// RVA: 0x245AF34 Offset: 0x2456F34 VA: 0x245AF34
	public void UpdateNpcRespawnTime(ArchetypeUid archetypeId, short respawnTime) { }

	// RVA: 0x245AFB8 Offset: 0x2456FB8 VA: 0x245AFB8
	public void NpcActionCircleSupportSkill(ArchetypeUid archetypeUid, List<GameObject> memberList, short p, byte p_2, bool p_3) { }

	// RVA: 0x245B3D8 Offset: 0x24573D8 VA: 0x245B3D8
	public void UpdatePetStatus(GameStatusData petStatus) { }

	// RVA: 0x245B588 Offset: 0x2457588 VA: 0x245B588
	public void SkillComboSet() { }

	// RVA: 0x245B680 Offset: 0x2457680 VA: 0x245B680
	public void SetComboPoint(int cp) { }

	// RVA: 0x245B6B0 Offset: 0x24576B0 VA: 0x245B6B0
	public bool DungeonGroupSettingChange(int areaLevel) { }

	// RVA: 0x245B7C0 Offset: 0x24577C0 VA: 0x245B7C0
	public void ReceiveDungeonGroupSettingChange(DungeonGroupSettingChangeResponse response) { }

	// RVA: 0x245B8A8 Offset: 0x24578A8 VA: 0x245B8A8
	public void ManaMagicCharge(byte charge) { }

	// RVA: 0x245B8CC Offset: 0x24578CC VA: 0x245B8CC
	public void ReceiveManaMagicCharge(ManaMagicChargeResponse response) { }

	// RVA: 0x245B94C Offset: 0x245794C VA: 0x245B94C
	public void OnEnterDungeonField(EnterDungeonField enterDungeonField) { }

	// RVA: 0x245BAB4 Offset: 0x2457AB4 VA: 0x245BAB4
	public short DungeonFieldDownstairs() { }

	[IteratorStateMachine(typeof(GameManager.<OnDungeonFieldDownstairs>d__711))]
	// RVA: 0x245BBB8 Offset: 0x2457BB8 VA: 0x245BBB8
	public IEnumerator OnDungeonFieldDownstairs(int randamSeed, int areaLevel, byte areaDay, DungeonFloorEventType floorEventType, byte[] roomMapChip, Dictionary<byte, byte> trapList, byte[] itemBoxList, MobResponseData[] mobList, bool firstLogIn) { }

	// RVA: 0x245BCC4 Offset: 0x2457CC4 VA: 0x245BCC4
	public void ReceiveDungeonBeat(short areaLevel) { }

	// RVA: 0x245BEC4 Offset: 0x2457EC4 VA: 0x245BEC4
	public void CheckDungeonFloorDepth(short floorDepth) { }

	// RVA: 0x245BE1C Offset: 0x2457E1C VA: 0x245BE1C
	public void RemoveDungeonEmergencyPoint() { }

	// RVA: 0x245BF78 Offset: 0x2457F78 VA: 0x245BF78
	public void DungeonMobHate(int id) { }

	// RVA: 0x245BF9C Offset: 0x2457F9C VA: 0x245BF9C
	public void OpenItemBox(int itemBoxId) { }

	// RVA: 0x245C058 Offset: 0x2458058 VA: 0x245C058
	public void ReceiveOpenItemBox(int itemBoxId, IItemDatav2[] itemList, WarrantyItemDatav2[] warrantyItem, bool party) { }

	// RVA: 0x245C300 Offset: 0x2458300 VA: 0x245C300
	public void DungeonTrapActive(int id) { }

	// RVA: 0x245C7BC Offset: 0x24587BC VA: 0x245C7BC
	public void ReceiveDungeonTrapActive(byte senderType, int senderId, byte trapId) { }

	// RVA: 0x245C8A4 Offset: 0x24588A4 VA: 0x245C8A4
	public void DungeonTrapDamage(int damage, byte damageId, byte trapId) { }

	// RVA: 0x245C934 Offset: 0x2458934 VA: 0x245C934
	public bool DungeonTrapAttack(byte trapId) { }

	// RVA: 0x245CA50 Offset: 0x2458A50 VA: 0x245CA50
	public void ReceiveDungeonTrapAttack(DungeonTrapData trapData, bool self) { }

	// RVA: 0x245CB04 Offset: 0x2458B04 VA: 0x245CB04
	public void OnEnterDefenceField() { }

	// RVA: 0x245CBE4 Offset: 0x2458BE4 VA: 0x245CBE4
	public void RoomRespawn() { }

	// RVA: 0x245CCDC Offset: 0x2458CDC VA: 0x245CCDC
	public void RoomRetire() { }

	// RVA: 0x245CDA0 Offset: 0x2458DA0 VA: 0x245CDA0
	public void DefenceGetRankingScore() { }

	// RVA: 0x245CE8C Offset: 0x2458E8C VA: 0x245CE8C
	public void ReceiveDefenceGetRankingScroe(DefenceCurrentScoreResponse response) { }

	// RVA: 0x245CF64 Offset: 0x2458F64 VA: 0x245CF64
	public void DefenceGetRanking(int rankType) { }

	// RVA: 0x245D05C Offset: 0x245905C VA: 0x245D05C
	public void ReceiveDefenceGetRanking(DefenceScoreRankingResponse response) { }

	// RVA: 0x245D110 Offset: 0x2459110 VA: 0x245D110
	public void UpdateTrialPoint(int trialPoint) { }

	// RVA: 0x245D1C0 Offset: 0x24591C0 VA: 0x245D1C0
	public void DefenceRankingResult() { }

	// RVA: 0x245D2AC Offset: 0x24592AC VA: 0x245D2AC
	public void ReceiveDefenceRankingResult(DefenceScoreResultRankingResponse response) { }

	// RVA: 0x245D36C Offset: 0x245936C VA: 0x245D36C
	public void DefenceRankingReward() { }

	// RVA: 0x245D458 Offset: 0x2459458 VA: 0x245D458
	public void ReceiveDefenceRankingReward(DefenceScoreResultRewardResponse response) { }

	// RVA: 0x245D514 Offset: 0x2459514 VA: 0x245D514
	public void GetEvent(GameEventType gameEventType, Dictionary<byte, object> data) { }

	// RVA: 0x245D5D4 Offset: 0x24595D4 VA: 0x245D5D4
	public void SetEvent(GameEventType gameEventType, Dictionary<byte, object> data) { }

	// RVA: 0x245D694 Offset: 0x2459694 VA: 0x245D694
	public void SettingEventVal(byte gameEventType, int version) { }

	// RVA: 0x245D754 Offset: 0x2459754 VA: 0x245D754
	public void GetEventVal(byte gameEventType, int version, byte valIndex) { }

	// RVA: 0x245D820 Offset: 0x2459820 VA: 0x245D820
	public void SetEventVal(byte gameEventType, int version, byte valIndex, byte val) { }

	// RVA: 0x245D900 Offset: 0x2459900 VA: 0x245D900
	public void GameEventResult(byte gameEvent) { }

	// RVA: 0x245DA40 Offset: 0x2459A40 VA: 0x245DA40
	public void GameEventChangeField(byte gameEvent, Vector3 position, float rot, float cameraRot, Dictionary<byte, object> param) { }

	// RVA: 0x245DC04 Offset: 0x2459C04 VA: 0x245DC04
	public void SummerCreateDiving(SummerRecruitType recruitType, Vector3 position, float rot, float cameraRot, int[] useItemId) { }

	// RVA: 0x245DDC8 Offset: 0x2459DC8 VA: 0x245DDC8
	public void SummerFreeDiving(Vector3 position, float rot, float cameraRot) { }

	// RVA: 0x245DF5C Offset: 0x2459F5C VA: 0x245DF5C
	public void SummerEnterDiving(int lobbiyId, Vector3 position, float rot, float cameraRot, int[] useItemId) { }

	// RVA: 0x245E120 Offset: 0x245A120 VA: 0x245E120
	public void SummerGetPoint() { }

	// RVA: 0x245E218 Offset: 0x245A218 VA: 0x245E218
	public void EventLogin(byte gameEvent) { }

	// RVA: 0x245E358 Offset: 0x245A358 VA: 0x245E358
	public void GetRoomGmEventMobData() { }

	// RVA: 0x245E44C Offset: 0x245A44C VA: 0x245E44C
	public void ExchangeGetMyData(short id) { }

	// RVA: 0x245E58C Offset: 0x245A58C VA: 0x245E58C
	public void ExchangeRun(short id, short excNo, byte wxchType, int nowNum, byte wxchMethod, int getCount) { }

	// RVA: 0x245E70C Offset: 0x245A70C VA: 0x245E70C
	public void HouseEnter(int userId, byte editType) { }

	// RVA: 0x245E71C Offset: 0x245A71C VA: 0x245E71C
	public void HouseOhterEnter(int userId, byte enterType) { }

	// RVA: 0x245E730 Offset: 0x245A730 VA: 0x245E730
	public void HouseLeave() { }

	// RVA: 0x245E794 Offset: 0x245A794 VA: 0x245E794
	public void HouseInitialLandPurchase(int landPrice) { }

	// RVA: 0x245E840 Offset: 0x245A840 VA: 0x245E840
	public void HouseStartEditMode() { }

	// RVA: 0x245E8E0 Offset: 0x245A8E0 VA: 0x245E8E0
	public void HouseEndEditMode(bool openPrivateFlag) { }

	// RVA: 0x245E990 Offset: 0x245A990 VA: 0x245E990
	public void HouseLandPurchase(byte buyArea, int gold, byte w, byte h, int orb, bool direct) { }

	// RVA: 0x245EA94 Offset: 0x245AA94 VA: 0x245EA94
	public void HouseConstruction(byte floorHeight, List<int> itemList) { }

	// RVA: 0x245EB80 Offset: 0x245AB80 VA: 0x245EB80
	public void PartitionEdit(int startPosition, HousePartitionEditData[] updateList, int[] removeList) { }

	// RVA: 0x245EC4C Offset: 0x245AC4C VA: 0x245EC4C
	public void AddCoordinate(int uid, int objId, int parentUid, int position, byte rotation) { }

	// RVA: 0x245ED3C Offset: 0x245AD3C VA: 0x245ED3C
	public void MoveCoordinate(int uid, int objId, int parentUid, int position, byte rotation) { }

	// RVA: 0x245EE2C Offset: 0x245AE2C VA: 0x245EE2C
	public void RemoveCoordinate(int[] uidList) { }

	// RVA: 0x245EF84 Offset: 0x245AF84 VA: 0x245EF84
	public void HouseOtherList(byte type) { }

	// RVA: 0x245F030 Offset: 0x245B030 VA: 0x245F030
	public void HouseEntryCheck() { }

	// RVA: 0x245F0D0 Offset: 0x245B0D0 VA: 0x245F0D0
	public void HouseSaveEntry(byte saveEdit) { }

	// RVA: 0x245F17C Offset: 0x245B17C VA: 0x245F17C
	public void HouseCreateObjItem(int objId, int num, bool direct, int orbNum, int useOrb) { }

	// RVA: 0x245F26C Offset: 0x245B26C VA: 0x245F26C
	public void HouseUpdateObjItem(int objId, byte flag, int[] binary) { }

	// RVA: 0x245F278 Offset: 0x245B278 VA: 0x245F278
	public void HouseBelonginsList() { }

	// RVA: 0x245F318 Offset: 0x245B318 VA: 0x245F318
	public void HousePetOwnershipUpdate() { }

	// RVA: 0x245F3B8 Offset: 0x245B3B8 VA: 0x245F3B8
	public void HousePetOwnershipGet(List<PetSendData> pets) { }

	// RVA: 0x245F464 Offset: 0x245B464 VA: 0x245F464
	public void HousePetMove(List<PetSendData> petData) { }

	// RVA: 0x245F474 Offset: 0x245B474 VA: 0x245F474
	public void HouseChangeBGMItem(int bgmItemId) { }

	// RVA: 0x245F5B4 Offset: 0x245B5B4 VA: 0x245F5B4
	public void HouseListAnchor(int targetAid) { }

	// RVA: 0x245F6F4 Offset: 0x245B6F4 VA: 0x245F6F4
	public void HouseLotteryRecruitStart(short removeFlag) { }

	// RVA: 0x245F834 Offset: 0x245B834 VA: 0x245F834
	public void HouseLotteryInfo(UIBasePanel panel) { }

	// RVA: 0x245F934 Offset: 0x245B934 VA: 0x245F934
	public void HouseLotteryListClear(UIBasePanel panel) { }

	// RVA: 0x245FA34 Offset: 0x245BA34 VA: 0x245FA34
	public void HouseLotteryRecruitCancel() { }

	// RVA: 0x245FB2C Offset: 0x245BB2C VA: 0x245FB2C
	public void HouseLotteryStart(UIBasePanel panel, string message) { }

	// RVA: 0x245FC8C Offset: 0x245BC8C VA: 0x245FC8C
	public void HouseLotteryRecruitReSend() { }

	// RVA: 0x245FD84 Offset: 0x245BD84 VA: 0x245FD84
	public void HouseLotteryJoin(int organizerId) { }

	// RVA: 0x245FEC4 Offset: 0x245BEC4 VA: 0x245FEC4
	public void CultivationGardenEnter() { }

	// RVA: 0x245FFBC Offset: 0x245BFBC VA: 0x245FFBC
	public void CultivationGardenLeave() { }

	// RVA: 0x24600B4 Offset: 0x245C0B4 VA: 0x24600B4
	public void CultivationPlant(short index, int produceId, short point, byte bonus) { }

	// RVA: 0x2460194 Offset: 0x245C194 VA: 0x2460194
	public void CultivationHarvest(short index, int produceId) { }

	// RVA: 0x2460254 Offset: 0x245C254 VA: 0x2460254
	public void CultivationRemove(short index, int produceId) { }

	// RVA: 0x2460314 Offset: 0x245C314 VA: 0x2460314
	public void CultivationWatering(short index, int produceId) { }

	// RVA: 0x24603D4 Offset: 0x245C3D4 VA: 0x24603D4
	public void CultivationWatering() { }

	// RVA: 0x2460484 Offset: 0x245C484 VA: 0x2460484
	public void CultivationGetList() { }

	// RVA: 0x246057C Offset: 0x245C57C VA: 0x246057C
	public void CuisineCooking(int id, byte lv) { }

	// RVA: 0x24606D0 Offset: 0x245C6D0 VA: 0x24606D0
	public void CuisineSubCooking(int id, byte lv) { }

	// RVA: 0x2460824 Offset: 0x245C824 VA: 0x2460824
	public void CuisineChangeType(byte type) { }

	// RVA: 0x2460964 Offset: 0x245C964 VA: 0x2460964
	public void CuisineDineOut(int otherAid, int id, byte lv, byte type) { }

	// RVA: 0x2460AD4 Offset: 0x245CAD4 VA: 0x2460AD4
	public void CuisineCleanUp() { }

	// RVA: 0x2460BCC Offset: 0x245CBCC VA: 0x2460BCC
	public void CuisineGetRecipe() { }

	// RVA: 0x2460CC4 Offset: 0x245CCC4 VA: 0x2460CC4
	public void CuisineGetEatingList() { }

	// RVA: 0x2460DBC Offset: 0x245CDBC VA: 0x2460DBC
	public void GetFoodPoint() { }

	// RVA: 0x2460EB4 Offset: 0x245CEB4 VA: 0x2460EB4
	public void UpdateBan(OffenderData offender) { }

	// RVA: 0x2460EE4 Offset: 0x245CEE4 VA: 0x2460EE4
	public void StartBan(int offenderId) { }

	// RVA: 0x2460FBC Offset: 0x245CFBC VA: 0x2460FBC
	public void RecreateStart() { }

	// RVA: 0x2461078 Offset: 0x245D078 VA: 0x2461078
	public void RecreateEnd() { }

	// RVA: 0x2461084 Offset: 0x245D084 VA: 0x2461084
	public void RecreateSetStyleData(NewStyleData newStyle, Dictionary<int, int> savedList, int useOrb) { }

	// RVA: 0x24611B8 Offset: 0x245D1B8 VA: 0x24611B8
	public void FunctionLimitUpdate(GameSystemUpdateEvent limited) { }

	// RVA: 0x24613CC Offset: 0x245D3CC VA: 0x24613CC
	private void OnApplicationPause(bool pause) { }

	// RVA: 0x2461488 Offset: 0x245D488 VA: 0x2461488
	private void resetConnectResume() { }

	[IteratorStateMachine(typeof(GameManager.<LoginOverCoroutine>d__804))]
	// RVA: 0x24614A4 Offset: 0x245D4A4 VA: 0x24614A4
	public IEnumerator LoginOverCoroutine(UILabel stateLabel) { }

	// RVA: 0x2461534 Offset: 0x245D534 VA: 0x2461534
	private void loginOverCoroutineCallback(string message) { }

	// RVA: 0x24616A4 Offset: 0x245D6A4 VA: 0x24616A4
	public void AvatarGenericFlagList() { }

	// RVA: 0x2461744 Offset: 0x245D744 VA: 0x2461744
	public void UpdateGenericFlag(GenericFlagId id, string data) { }

	// RVA: 0x2461830 Offset: 0x245D830 VA: 0x2461830
	public void UpdateOnceFlag(byte version, GenericFlagData[] genericFlagData) { }

	// RVA: 0x24618C8 Offset: 0x245D8C8 VA: 0x24618C8
	public void OptionSettingChange(OptionSettingCode code, bool flag, int updateFlag) { }

	// RVA: 0x2461994 Offset: 0x245D994 VA: 0x2461994
	public void DailyDartsGameEnter() { }

	// RVA: 0x2461A34 Offset: 0x245DA34 VA: 0x2461A34
	public void DailyDartsGameThrowDarts(int hitId, byte throwNum) { }

	// RVA: 0x2461AF4 Offset: 0x245DAF4 VA: 0x2461AF4
	public void DailyDartsGameRewardItem(int rewardId) { }

	// RVA: 0x2461BA0 Offset: 0x245DBA0 VA: 0x2461BA0
	public void MarketSetUp(int shopId, int autoLockFlag) { }

	// RVA: 0x2461CAC Offset: 0x245DCAC VA: 0x2461CAC
	public void MarketGetProductList(MarketType type, int itemId, ItemType itemType, MarketOrderType orderType, byte page) { }

	// RVA: 0x2461DE4 Offset: 0x245DDE4 VA: 0x2461DE4
	public void MarketGetSaleList() { }

	// RVA: 0x2461ED0 Offset: 0x245DED0 VA: 0x2461ED0
	public void MarketRegsiter(int slotId, MarketType type, ItemSelectData data, int price, int fee) { }

	// RVA: 0x2462008 Offset: 0x245E008 VA: 0x2462008
	public void MarketRegsiterStarGem(int slotId, MarketType type, long uuid, int price, int fee) { }

	// RVA: 0x2462140 Offset: 0x245E140 VA: 0x2462140
	public void MarketRegsiterCancel(int slotId, long marketId) { }

	// RVA: 0x246224C Offset: 0x245E24C VA: 0x246224C
	public void MarketCollect(int slotId, long marketId) { }

	// RVA: 0x2462358 Offset: 0x245E358 VA: 0x2462358
	public void MarketPurchase(MarketType marketType, long marketId, int itemId, byte tariffRate, ItemType itemType, MarketOrderType orderType, int autoLockFlag) { }

	// RVA: 0x24624B8 Offset: 0x245E4B8 VA: 0x24624B8
	public void MarketProductListEquipOption(MarketType type, int itemId, ItemType itemType, MarketOrderType orderType, MarketProductList.EnumOptionsSlot slot, byte color, MarketProductList.EnumOptionsParts parts, int modelId, short capId, short rProperty, byte page) { }

	// RVA: 0x2462658 Offset: 0x245E658 VA: 0x2462658
	public void MarketProductListPetOption(MarketType marketType, int id, ItemType itemType, MarketOrderType orderType, int petId, byte page) { }

	// RVA: 0x2462844 Offset: 0x245E844 VA: 0x2462844
	public void MailCheck() { }

	// RVA: 0x2462908 Offset: 0x245E908 VA: 0x2462908
	public void ReceiveMailCheck(MailCheckResponse checkResponse) { }

	// RVA: 0x2462940 Offset: 0x245E940 VA: 0x2462940
	public void MailReceiveDelivery(long id) { }

	// RVA: 0x2462A18 Offset: 0x245EA18 VA: 0x2462A18
	public void ReceiveMailDelivery(MailReceiveDeliveryResponse response) { }

	// RVA: 0x2462AA0 Offset: 0x245EAA0 VA: 0x2462AA0
	public void MailChangeState(Dictionary<long, byte> updateMailStates) { }

	// RVA: 0x2462B78 Offset: 0x245EB78 VA: 0x2462B78
	public void ReceiveMailChangeState(MailChangeStateResponse changeResponse) { }

	// RVA: 0x2462BAC Offset: 0x245EBAC VA: 0x2462BAC
	public void SendMail(int toAvatarUuid, byte mailType, string title, string message, ItemSelectData data, byte sendType) { }

	// RVA: 0x2462CD0 Offset: 0x245ECD0 VA: 0x2462CD0
	public void ReceiveSendMail(MailSendResponse response) { }

	// RVA: 0x2462D24 Offset: 0x245ED24 VA: 0x2462D24
	public void MailHistoryCheck() { }

	// RVA: 0x2462DE8 Offset: 0x245EDE8 VA: 0x2462DE8
	public void ReceiveMailHistoryCheck(MailHistoryCheckResponse response) { }

	// RVA: 0x2462E2C Offset: 0x245EE2C VA: 0x2462E2C
	public void MailGetMessage() { }

	// RVA: 0x2462EF0 Offset: 0x245EEF0 VA: 0x2462EF0
	public void ReceiveMailGetMessage(MailGetMessageResponse response) { }

	// RVA: 0x2462F24 Offset: 0x245EF24 VA: 0x2462F24
	public void MailGetBox(MailCountType mailType, long mailUniqueId, int page, Dictionary<long, byte> mailUpdateStates) { }

	// RVA: 0x2463028 Offset: 0x245F028 VA: 0x2463028
	public void ReceiveMailGetBox(MailGetBoxResponse response) { }

	// RVA: 0x2463058 Offset: 0x245F058 VA: 0x2463058
	public void MailGetBody(long mailUniqueId) { }

	// RVA: 0x2463130 Offset: 0x245F130 VA: 0x2463130
	public void ReceiveMailGetBody(MailGetBodyResponse response) { }

	// RVA: 0x2463160 Offset: 0x245F160 VA: 0x2463160
	public void MailReply(int toAvatarUuid, byte mailType, string title, string message, long replyMailId, string toAvatarName) { }

	// RVA: 0x2463284 Offset: 0x245F284 VA: 0x2463284
	public void MailDeleteExpired(long[] deleteMailIds) { }

	// RVA: 0x246335C Offset: 0x245F35C VA: 0x246335C
	public void ReceiveMailDeleteExpired(MailDeleteExpiredResponse response) { }

	// RVA: 0x2463390 Offset: 0x245F390 VA: 0x2463390
	public void EventSignboard(SignboardEvent events) { }

	// RVA: 0x24633E8 Offset: 0x245F3E8 VA: 0x24633E8
	public void PutUpSignboardOfSlotExpansion(ItemSelectData data, int cost, int requiredItemId) { }

	// RVA: 0x24634E0 Offset: 0x245F4E0 VA: 0x24634E0
	public void PutUpSignboardOfCristaExtraction(ItemSelectData data, int cost, int slotNo) { }

	// RVA: 0x24635D8 Offset: 0x245F5D8 VA: 0x24635D8
	public void PutUpSignboardOfReinforceCristaAttach(ItemSelectData data, int gold, int slotNo, ItemSelectData cristaData) { }

	// RVA: 0x24636DC Offset: 0x245F6DC VA: 0x24636DC
	public void PutUpSignvoardOfBazaar() { }

	// RVA: 0x24637A0 Offset: 0x245F7A0 VA: 0x24637A0
	public void SignboardPutupResponse(PutUpSignboardResponse response) { }

	// RVA: 0x24638F0 Offset: 0x245F8F0 VA: 0x24638F0
	public void PutAwaySignboard() { }

	// RVA: 0x24639B4 Offset: 0x245F9B4 VA: 0x24639B4
	public void PutAwaySignboardResponse(PutAwaySignboardResponse response) { }

	// RVA: 0x2463A20 Offset: 0x245FA20 VA: 0x2463A20
	public void CheckSignboard() { }

	// RVA: 0x2463AE4 Offset: 0x245FAE4 VA: 0x2463AE4
	public void SignboardCheckResponse(CheckSignboardResponse response) { }

	// RVA: 0x2463B3C Offset: 0x245FB3C VA: 0x2463B3C
	public void ExecuteSignboardOfSlotExpansion(int targetId, int itemId, DateTime date) { }

	// RVA: 0x2463C34 Offset: 0x245FC34 VA: 0x2463C34
	public void ExecuteSignboardOfCristaExtraction(int targetId, int itemId, DateTime date) { }

	// RVA: 0x2463D2C Offset: 0x245FD2C VA: 0x2463D2C
	public void ExeCutesignboardOfReinforceCristaAttach(int targetId, int itemId, DateTime date) { }

	// RVA: 0x2463E24 Offset: 0x245FE24 VA: 0x2463E24
	public void ExeCutesignboardOfBazaar(int targetId, byte slotIndex, int num, bool isNotEnoughCancel, int autoLockFlag, DateTime date) { }

	// RVA: 0x2463F4C Offset: 0x245FF4C VA: 0x2463F4C
	public void ExecuteSignboardContentResponse(ContentExecuteSignboardResponse response) { }

	// RVA: 0x246380C Offset: 0x245F80C VA: 0x246380C
	public void SetExpenseData(ExpenseResponseData expense) { }

	// RVA: 0x2463F80 Offset: 0x245FF80 VA: 0x2463F80
	public void BankSetup(UIBasePanel manager) { }

	// RVA: 0x2464080 Offset: 0x2460080 VA: 0x2464080
	public void BankDepositGold(UIBasePanel manager, int goldNum, long bankPoint) { }

	// RVA: 0x24641DC Offset: 0x24601DC VA: 0x24641DC
	public void BankWithdrawGold(UIBasePanel manager, int goldNum, int clientFee, long bankPoint) { }

	// RVA: 0x2464348 Offset: 0x2460348 VA: 0x2464348
	public void BankDepositMaterial(UIBasePanel manager, byte materialId, byte materialLv, int materialNum, long bankPoint) { }

	// RVA: 0x24644C4 Offset: 0x24604C4 VA: 0x24644C4
	public void BankWithdrawMaterial(UIBasePanel manager, byte materialId, byte materialLv, int materialNum, int clientFee, long bankPoint) { }

	// RVA: 0x2464648 Offset: 0x2460648 VA: 0x2464648
	public void ExpPotionPurchase(UIBasePanel manager, int haveOrb) { }

	// RVA: 0x2464798 Offset: 0x2460798 VA: 0x2464798
	public void ExpPotionDeposit(UIBasePanel manager) { }

	// RVA: 0x2464898 Offset: 0x2460898 VA: 0x2464898
	public void ExpPotionUse(UIBasePanel manager, byte potionNo) { }

	// RVA: 0x24649E8 Offset: 0x24609E8 VA: 0x24649E8
	public void BankMarkWithdrawGold(UIBasePanel manager, int goldNum, long bankPoint) { }

	// RVA: 0x2464B44 Offset: 0x2460B44 VA: 0x2464B44
	public void BankMarketDepositMaterial(UIBasePanel manager, byte materialId, byte materialLv, int materialPoint, long bankPoint) { }

	// RVA: 0x2464CC0 Offset: 0x2460CC0 VA: 0x2464CC0
	public void MarketDepositExpPotion(UIBasePanel manager, byte potionNo) { }

	// RVA: 0x2464E10 Offset: 0x2460E10 VA: 0x2464E10
	public void ReceiveEnchantScrollResponse(OrbEnchantScroll response) { }

	// RVA: 0x2464FC8 Offset: 0x2460FC8 VA: 0x2464FC8
	public void ReceiveReEnchantMent(OrbReEnchantmentResponse response) { }

	// RVA: 0x2435708 Offset: 0x2431708 VA: 0x2435708
	public void OnHackXigncodeCallback(string source = "A") { }

	// RVA: 0x2465180 Offset: 0x2461180 VA: 0x2465180
	public void OnAdbEnabledDetected() { }

	// RVA: 0x24653B4 Offset: 0x24613B4 VA: 0x24653B4
	public void OnVPNDetected() { }

	// RVA: 0x246552C Offset: 0x246152C VA: 0x246552C
	public void OnMinimumWindowsOS() { }

	// RVA: 0x2465760 Offset: 0x2461760 VA: 0x2465760
	public void OnNotUseLauncherCallback() { }

	// RVA: 0x2465764 Offset: 0x2461764 VA: 0x2465764
	public void OnNotSingleLauncherCallback() { }

	// RVA: 0x2465768 Offset: 0x2461768 VA: 0x2465768
	public void SendTouch(TouchData[] touchData) { }

	// RVA: 0x2465774 Offset: 0x2461774 VA: 0x2465774
	public void WaveMobTargetAttack(short targetId, int mobUniqueId, int damage, bool isCombo) { }

	// RVA: 0x2465784 Offset: 0x2461784 VA: 0x2465784
	public void CheckWaveRoom(int fieldId, byte roomId, short level) { }

	// RVA: 0x2465928 Offset: 0x2461928 VA: 0x2465928
	public void ReceiveCheckWaveRoom(CheckWaveRoomResponse response) { }

	// RVA: 0x2465A00 Offset: 0x2461A00 VA: 0x2465A00
	public bool WaveRoomGroupSettingChange(short level) { }

	// RVA: 0x2465AF0 Offset: 0x2461AF0 VA: 0x2465AF0
	public void CheckWaveRaidRoom(int fieldId, byte roomId) { }

	// RVA: 0x2465C7C Offset: 0x2461C7C VA: 0x2465C7C
	public void ReceiveCheckWaveRaidRoom(CheckWaveRaidRoomResponse response) { }

	// RVA: 0x2465D4C Offset: 0x2461D4C VA: 0x2465D4C
	public void WaveRaidMobTargetAttack(short targetId, int mobUniqueId, int damage, bool isCombo) { }

	// RVA: 0x2465D5C Offset: 0x2461D5C VA: 0x2465D5C
	public void AddHateMonster(int uniqueId) { }

	// RVA: 0x2465D68 Offset: 0x2461D68 VA: 0x2465D68
	public void SendDeadlyPoisonCheck(IMobIdData mobIdData) { }

	// RVA: 0x2465F14 Offset: 0x2461F14 VA: 0x2465F14
	public void SendCatarabomosCheck(IMobIdData mobIdData) { }

	// RVA: 0x24660C0 Offset: 0x24620C0 VA: 0x24660C0
	public void SnowballFightThrow(byte power, short angle, short height, short motionSpeed, byte ballNum) { }

	// RVA: 0x24660CC Offset: 0x24620CC VA: 0x24660CC
	public void SnowballFightReload(short reloadTime, Vector3 pos, byte ballNum) { }

	// RVA: 0x2466108 Offset: 0x2462108 VA: 0x2466108
	public void SnowballFightCreate(short[] pos, byte ballNum) { }

	// RVA: 0x2466114 Offset: 0x2462114 VA: 0x2466114
	public void SnowballFightDodge(short angle, short[] pos, byte ballNum) { }

	// RVA: 0x2466120 Offset: 0x2462120 VA: 0x2466120
	public void SnowballFightAttack(int ballNo, int otherArchetypeId, byte ballFlag) { }

	// RVA: 0x246612C Offset: 0x246212C VA: 0x246612C
	public void SnowballFightMeteorAttack(int ballNo, int[] otherArchetypeIds) { }

	// RVA: 0x2466138 Offset: 0x2462138 VA: 0x2466138
	public void SnowballFightDamage(int ballNo, int otherArchetypeId, byte flag, short[] pos) { }

	// RVA: 0x2466160 Offset: 0x2462160 VA: 0x2466160
	public void SnowballFightDead(int otherArchetypeId) { }

	// RVA: 0x246616C Offset: 0x246216C VA: 0x246616C
	public void SnowballFightResurrection() { }

	// RVA: 0x2466178 Offset: 0x2462178 VA: 0x2466178
	public void SnowballFightGetItem(int itemUid) { }

	// RVA: 0x2466184 Offset: 0x2462184 VA: 0x2466184
	public void SnowballFightUseItem(int itemUid) { }

	// RVA: 0x2466190 Offset: 0x2462190 VA: 0x2466190
	public void MiniGameLobbyJoin() { }

	// RVA: 0x2466230 Offset: 0x2462230 VA: 0x2466230
	public void MiniGameLobbyReady() { }

	// RVA: 0x24662D0 Offset: 0x24622D0 VA: 0x24662D0
	public void MiniGameLobbyReadyCancel() { }

	// RVA: 0x2466370 Offset: 0x2462370 VA: 0x2466370
	public void MiniGameEnter() { }

	// RVA: 0x246637C Offset: 0x246237C VA: 0x246637C
	public void MiniGameJoin() { }

	// RVA: 0x246641C Offset: 0x246241C VA: 0x246641C
	public void MiniGameLeave() { }

	// RVA: 0x24664BC Offset: 0x24624BC VA: 0x24664BC
	public void MiniGameLobbyReEnter() { }

	// RVA: 0x24664C8 Offset: 0x24624C8 VA: 0x24664C8
	public void SummerThrow(byte weaponId, int harpoonNo, Vector3 pos, short rot) { }

	// RVA: 0x2466514 Offset: 0x2462514 VA: 0x2466514
	public void SummerAttack(byte weaponId, int harpoonNo, MobSendData targetFish) { }

	// RVA: 0x2466520 Offset: 0x2462520 VA: 0x2466520
	public void SummerFishMove(List<MobSendData> mobData, bool isReliable) { }

	// RVA: 0x2466530 Offset: 0x2462530 VA: 0x2466530
	public void SummerFishAttackDamage(MobSendData mobData) { }

	// RVA: 0x24665B4 Offset: 0x24625B4 VA: 0x24665B4
	public void CreateDivingClientMob(int mobId, byte localId, Vector3 position, float rotation) { }

	// RVA: 0x246668C Offset: 0x246268C VA: 0x246668C
	public void SummerStartGame() { }

	// RVA: 0x2466698 Offset: 0x2462698 VA: 0x2466698
	public void SummerRuleChange(SummerRecruitType settingType) { }

	// RVA: 0x24666A4 Offset: 0x24626A4 VA: 0x24666A4
	public void SummerPlayerRevive(int id, Vector3 pos) { }

	// RVA: 0x24666D8 Offset: 0x24626D8 VA: 0x24666D8
	public void SummerGiveUp() { }

	// RVA: 0x24666E4 Offset: 0x24626E4 VA: 0x24666E4
	public void ReceiveGMGuildPoint(int guildId, int point) { }

	// RVA: 0x2466884 Offset: 0x2462884 VA: 0x2466884
	public void TreasureOpen(byte boxId) { }

	// RVA: 0x2466968 Offset: 0x2462968 VA: 0x2466968
	public void TreasureKeyInfo() { }

	// RVA: 0x2466A4C Offset: 0x2462A4C VA: 0x2466A4C
	public void ReceiveTreasureKeyInfo(TreasureKeyInfoResponse response) { }

	// RVA: 0x2466AD0 Offset: 0x2462AD0 VA: 0x2466AD0
	public void ReceiveTreasureSettingData(TreasureSettingData[] response) { }

	// RVA: 0x2466B4C Offset: 0x2462B4C VA: 0x2466B4C
	public void ReceiveTreasureOpen(TreasureOpenResponse response) { }

	// RVA: 0x2466C88 Offset: 0x2462C88 VA: 0x2466C88
	public void TreasureKeyRecovery(int keyNum) { }

	// RVA: 0x2466CB8 Offset: 0x2462CB8 VA: 0x2466CB8
	public void ReceiveGmTreasureRecoverKey(int keyNum) { }

	// RVA: 0x2466CEC Offset: 0x2462CEC VA: 0x2466CEC
	public void HideSeekCheck(int manageId) { }

	// RVA: 0x2466D98 Offset: 0x2462D98 VA: 0x2466D98
	public void ReceiveHideSeekCheckResponse(HideSeekCheckResponse response) { }

	// RVA: 0x2466EB4 Offset: 0x2462EB4 VA: 0x2466EB4
	public void RhythmGameEnter(int objId, bool isEveryone) { }

	// RVA: 0x2466F78 Offset: 0x2462F78 VA: 0x2466F78
	public void RhythmGameJoin() { }

	// RVA: 0x2467018 Offset: 0x2463018 VA: 0x2467018
	public void RhythmGameSetting(byte gameState, int musicId, byte difficulty) { }

	// RVA: 0x2467024 Offset: 0x2463024 VA: 0x2467024
	public void RhythmGameReady(byte gameState, int musicId, byte difficulty) { }

	// RVA: 0x2467030 Offset: 0x2463030 VA: 0x2467030
	public void RhythmGameReadyCancel() { }

	// RVA: 0x246703C Offset: 0x246303C VA: 0x246703C
	public void RhythmGameStart() { }

	// RVA: 0x24670DC Offset: 0x24630DC VA: 0x24670DC
	public void RhythmGameFinish(short critical, short hit, short graze, short miss) { }

	// RVA: 0x24671BC Offset: 0x24631BC VA: 0x24671BC
	public void RhythmGameResult() { }

	// RVA: 0x246725C Offset: 0x246325C VA: 0x246725C
	public void RhythmGameLeave() { }

	// RVA: 0x24672FC Offset: 0x24632FC VA: 0x24672FC
	public void RhythmGameGiveUp() { }

	// RVA: 0x2467308 Offset: 0x2463308 VA: 0x2467308
	public void RhythmGameAttack(short critical, short hit, short graze, short miss) { }

	// RVA: 0x2467314 Offset: 0x2463314 VA: 0x2467314
	public void BlackKnightEnter(int objId) { }

	// RVA: 0x2467454 Offset: 0x2463454 VA: 0x2467454
	public void BlackKnightLeave() { }

	// RVA: 0x246754C Offset: 0x246354C VA: 0x246754C
	public void BlackKnightJoin() { }

	// RVA: 0x2467644 Offset: 0x2463644 VA: 0x2467644
	public void BlackKnightSelectSaveData(byte saveId) { }

	// RVA: 0x2467784 Offset: 0x2463784 VA: 0x2467784
	public void BlackKnightStartGame(byte stage) { }

	// RVA: 0x24678C4 Offset: 0x24638C4 VA: 0x24678C4
	public void BlackKnightSelectStage() { }

	// RVA: 0x24679BC Offset: 0x24639BC VA: 0x24679BC
	public void BlackKnightEndGame(byte endType, int score, int gold, DateTime time) { }

	// RVA: 0x2467B2C Offset: 0x2463B2C VA: 0x2467B2C
	public void BlackKnightLootBox() { }

	// RVA: 0x2467C24 Offset: 0x2463C24 VA: 0x2467C24
	public void BlackKnightDeleteSaveData() { }

	// RVA: 0x2467D1C Offset: 0x2463D1C VA: 0x2467D1C
	public void BlackKnightChangeEquip(byte[] equip) { }

	// RVA: 0x2467E74 Offset: 0x2463E74 VA: 0x2467E74
	public void BlackKnightChangeAvatar(byte type) { }

	// RVA: 0x2467FB4 Offset: 0x2463FB4 VA: 0x2467FB4
	public void BlackKnightUpdateRanking(byte type, byte stageId) { }

	// RVA: 0x2468108 Offset: 0x2464108 VA: 0x2468108
	public void CardGameEnter(int objId) { }

	// RVA: 0x2468248 Offset: 0x2464248 VA: 0x2468248
	public void CardGameJoin() { }

	// RVA: 0x2468340 Offset: 0x2464340 VA: 0x2468340
	public void CardGameReady(CardGameSettingData data) { }

	// RVA: 0x2468394 Offset: 0x2464394 VA: 0x2468394
	public void CardGameReadyCancel() { }

	// RVA: 0x24683A0 Offset: 0x24643A0 VA: 0x24683A0
	public void CardGameSettingUpdate(CardGameSettingData data) { }

	// RVA: 0x24683F4 Offset: 0x24643F4 VA: 0x24683F4
	public void CardGameLeave() { }

	// RVA: 0x24684EC Offset: 0x24644EC VA: 0x24684EC
	public void CardGameResult() { }

	// RVA: 0x24685E4 Offset: 0x24645E4 VA: 0x24685E4
	public void CardGameGiveUp() { }

	// RVA: 0x24686DC Offset: 0x24646DC VA: 0x24686DC
	public void CardGameTurnEnd(byte turnCount, List<byte> bossA, List<byte> bossB, List<byte> bossC, List<byte> bossD, List<byte> bossEx, List<byte> sell, List<byte> buy) { }

	// RVA: 0x2468900 Offset: 0x2464900 VA: 0x2468900
	public void CardGameLastChance(byte type) { }

	// RVA: 0x2468A40 Offset: 0x2464A40 VA: 0x2468A40
	public void CardGameReacquire() { }

	// RVA: 0x2468A4C Offset: 0x2464A4C VA: 0x2468A4C
	public void CardGameReconnectResult() { }

	// RVA: 0x2468B44 Offset: 0x2464B44 VA: 0x2468B44
	public void CardGameTableCheck() { }

	// RVA: 0x2468B50 Offset: 0x2464B50 VA: 0x2468B50
	public void SetTreasureHuntBonus(RoomSupportUseData[] supportData) { }

	// RVA: 0x2468BD4 Offset: 0x2464BD4 VA: 0x2468BD4
	public void OpenTreasureHuntBox(TreasureHuntTreasureData data) { }

	// RVA: 0x2468CB8 Offset: 0x2464CB8 VA: 0x2468CB8
	public void ReceiveOpenTreasureHuntBox(byte localId) { }

	// RVA: 0x2468D40 Offset: 0x2464D40 VA: 0x2468D40
	public void UpdateTreasureHuntTrialPoint(byte trialPoint) { }

	// RVA: 0x2468DE0 Offset: 0x2464DE0 VA: 0x2468DE0
	public void CheckNewWaveRoom(int fieldId, byte roomId, bool isForcibly, bool isMatching) { }

	// RVA: 0x2468F78 Offset: 0x2464F78 VA: 0x2468F78
	public void ReceiveCheckNewWaveRoom(CheckNewWaveRoomResponse response) { }

	// RVA: 0x246904C Offset: 0x246504C VA: 0x246904C
	public void NewWaveMobTargetAttack(int mobUniqueId, int damage, bool isCombo) { }

	// RVA: 0x246906C Offset: 0x246506C VA: 0x246906C
	public void CreateNinjutsuScroll(ItemSelectData[] itemDatas) { }

	// RVA: 0x2469118 Offset: 0x2465118 VA: 0x2469118
	public void ReceiveCreateNinjutsuScroll(ItemDatav2[] useItemList, ItemDatav2 createItem, short[] randomSkillList) { }

	// RVA: 0x246933C Offset: 0x246533C VA: 0x246933C
	public void CheckHighRaidRoom(byte highRaidNo) { }

	// RVA: 0x2469414 Offset: 0x2465414 VA: 0x2469414
	public void ReceiveHighRaidRoom(CheckHighRaidRoomResponse response) { }

	// RVA: 0x24694E8 Offset: 0x24654E8 VA: 0x24694E8
	public void GetChallengePoint() { }

	// RVA: 0x2469588 Offset: 0x2465588 VA: 0x2469588
	public void ReceiveGetChallengePoint(GetChallengePointResponse response) { }

	// RVA: 0x246963C Offset: 0x246563C VA: 0x246963C
	public void AddChallengePoint(byte index, Dictionary<int, byte> clientItems) { }

	// RVA: 0x24696FC Offset: 0x24656FC VA: 0x24696FC
	public void ReceiveAddChallengePoint(AddChallengePointResponse response) { }

	// RVA: 0x24697B8 Offset: 0x24657B8 VA: 0x24697B8
	public void GetHighRaidPoint(byte highRaidNo) { }

	// RVA: 0x2469864 Offset: 0x2465864 VA: 0x2469864
	public void ReceiveGetHighRaidPoint(GetHighRaidPointResponse response) { }

	// RVA: 0x2469868 Offset: 0x2465868 VA: 0x2469868
	public void RunHighRaidExchange(byte highRaidNo, int rewardCost, int nowPoint, byte rewardNo, int getCount) { }

	// RVA: 0x2469948 Offset: 0x2465948 VA: 0x2469948
	public void ReceiveRunHighRaidExchange(RunHighRaidExchangeResponse response) { }

	// RVA: 0x2469960 Offset: 0x2465960 VA: 0x2469960
	public void GetHighRaidBattleHeld() { }

	// RVA: 0x2469A00 Offset: 0x2465A00 VA: 0x2469A00
	public void GetHighRaidExchangeHeld() { }

	// RVA: 0x2469AA0 Offset: 0x2465AA0 VA: 0x2469AA0
	public void ReceiveGetHighRaidHeld(GetHighRaidListResponse response) { }

	// RVA: 0x2469C04 Offset: 0x2465C04 VA: 0x2469C04
	public void SendClientOptions(ClientOptionsData options) { }

	// RVA: 0x2469C14 Offset: 0x2465C14 VA: 0x2469C14
	public void RegistletProcessingGemCart(long[] uuid) { }

	// RVA: 0x2469CC0 Offset: 0x2465CC0 VA: 0x2469CC0
	public void RegistletEnhanceGemCart(long enhanceUuid, long[] materialUuid) { }

	// RVA: 0x2469D80 Offset: 0x2465D80 VA: 0x2469D80
	public void RegistletExtensionSlot() { }

	// RVA: 0x2469E20 Offset: 0x2465E20 VA: 0x2469E20
	public void RegistletChangeGemCartEquip(Dictionary<byte, long> updateEquips) { }

	// RVA: 0x2469ECC Offset: 0x2465ECC VA: 0x2469ECC
	public void RegistletChangeGemCartFlag(long uuid, byte flag) { }

	// RVA: 0x2469F8C Offset: 0x2465F8C VA: 0x2469F8C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x246A138 Offset: 0x2466138 VA: 0x246A138
	private void <playerMergeCheck>b__132_1() { }

	[CompilerGenerated]
	// RVA: 0x246A1D0 Offset: 0x24661D0 VA: 0x246A1D0
	private void <playerMergeCheck>b__132_2() { }

	[CompilerGenerated]
	// RVA: 0x246A614 Offset: 0x2466614 VA: 0x246A614
	private void <LeaveRoom>b__134_0() { }

	[CompilerGenerated]
	// RVA: 0x246A620 Offset: 0x2466620 VA: 0x246A620
	private void <EmergencyChangeField>b__141_0() { }

	[CompilerGenerated]
	// RVA: 0x246A64C Offset: 0x246664C VA: 0x246A64C
	private void <FriendGetList>b__310_0() { }

	[CompilerGenerated]
	// RVA: 0x246A658 Offset: 0x2466658 VA: 0x246A658
	private void <PartyLotteryInfo>b__342_0() { }

	[CompilerGenerated]
	// RVA: 0x246A664 Offset: 0x2466664 VA: 0x246A664
	private void <PartyLotteryListClear>b__343_0() { }

	[CompilerGenerated]
	// RVA: 0x246A670 Offset: 0x2466670 VA: 0x246A670
	private void <PartyLotteryRecruitCancel>b__344_0() { }

	[CompilerGenerated]
	// RVA: 0x246A67C Offset: 0x246667C VA: 0x246A67C
	private void <PartyLotteryRecruitReSend>b__346_0() { }

	[CompilerGenerated]
	// RVA: 0x246A688 Offset: 0x2466688 VA: 0x246A688
	private void <ChannelGetGlobal>b__489_0() { }

	[CompilerGenerated]
	// RVA: 0x246A694 Offset: 0x2466694 VA: 0x246A694
	private void <GlobalChannelGetList>b__490_0() { }

	[CompilerGenerated]
	// RVA: 0x246A6A0 Offset: 0x24666A0 VA: 0x246A6A0
	private void <GlobalChannelGetWorld>b__491_0() { }

	[CompilerGenerated]
	// RVA: 0x246A6AC Offset: 0x24666AC VA: 0x246A6AC
	private void <ReturnServer>b__494_0() { }

	[CompilerGenerated]
	// RVA: 0x246A6BC Offset: 0x24666BC VA: 0x246A6BC
	private void <GuildDissolution>b__542_0() { }

	[CompilerGenerated]
	// RVA: 0x246A6C8 Offset: 0x24666C8 VA: 0x246A6C8
	private void <GuildGetMember>b__545_0() { }

	[CompilerGenerated]
	// RVA: 0x246A6D4 Offset: 0x24666D4 VA: 0x246A6D4
	private void <GuildCheck>b__548_0() { }

	[CompilerGenerated]
	// RVA: 0x246A6E0 Offset: 0x24666E0 VA: 0x246A6E0
	private void <GuildUpdateTenant>b__564_0() { }

	[CompilerGenerated]
	// RVA: 0x246A6EC Offset: 0x24666EC VA: 0x246A6EC
	private void <GuildMedalUpdate>b__568_0() { }

	[CompilerGenerated]
	// RVA: 0x246A6F8 Offset: 0x24666F8 VA: 0x246A6F8
	private void <GetGuildStaffData>b__571_0() { }

	[CompilerGenerated]
	// RVA: 0x246A704 Offset: 0x2466704 VA: 0x246A704
	private void <GuildStaffRunningErrand>b__572_0() { }

	[CompilerGenerated]
	// RVA: 0x246A710 Offset: 0x2466710 VA: 0x246A710
	private void <GuildStaffRecoveryPlayer>b__573_0() { }

	[CompilerGenerated]
	// RVA: 0x246A71C Offset: 0x246671C VA: 0x246A71C
	private void <GuildGetHeldRaidData>b__582_0() { }

	[CompilerGenerated]
	// RVA: 0x246A728 Offset: 0x2466728 VA: 0x246A728
	private void <GuildResetRaid>b__583_0() { }

	[CompilerGenerated]
	// RVA: 0x246A734 Offset: 0x2466734 VA: 0x246A734
	private void <GuildEndHeldRaid>b__584_0() { }

	[CompilerGenerated]
	// RVA: 0x246A740 Offset: 0x2466740 VA: 0x246A740
	private void <GuildQuestGetQuest>b__585_0() { }

	[CompilerGenerated]
	// RVA: 0x246A74C Offset: 0x246674C VA: 0x246A74C
	private void <CheckGuildRaidRoom>b__622_0() { }

	[CompilerGenerated]
	// RVA: 0x246A758 Offset: 0x2466758 VA: 0x246A758
	private void <GetRaidBossData>b__624_0() { }

	[CompilerGenerated]
	// RVA: 0x246A764 Offset: 0x2466764 VA: 0x246A764
	private void <RoomStart>b__636_0() { }

	[CompilerGenerated]
	// RVA: 0x246A770 Offset: 0x2466770 VA: 0x246A770
	private void <RoomLobbyLeave>b__637_0() { }

	[CompilerGenerated]
	// RVA: 0x246A77C Offset: 0x246677C VA: 0x246A77C
	private void <RoomLobbyJoinCancel>b__638_0() { }

	[CompilerGenerated]
	// RVA: 0x246A788 Offset: 0x2466788 VA: 0x246A788
	private void <RoomLobbyJoin>b__639_0() { }

	[CompilerGenerated]
	// RVA: 0x246A794 Offset: 0x2466794 VA: 0x246A794
	private void <GuildRaidRoomLobbyJoin>b__647_0() { }

	[CompilerGenerated]
	// RVA: 0x246A7A0 Offset: 0x24667A0 VA: 0x246A7A0
	private void <GuildRaidRoomLobbyJoinCancel>b__648_0() { }

	[CompilerGenerated]
	// RVA: 0x246A7AC Offset: 0x24667AC VA: 0x246A7AC
	private void <RoomWarpPosition>b__668_0() { }

	[CompilerGenerated]
	// RVA: 0x246A7BC Offset: 0x24667BC VA: 0x246A7BC
	private void <RoomRespawn>b__724_0() { }

	[CompilerGenerated]
	// RVA: 0x246A7C8 Offset: 0x24667C8 VA: 0x246A7C8
	private void <SummerGetPoint>b__745_0() { }

	[CompilerGenerated]
	// RVA: 0x246A7D4 Offset: 0x24667D4 VA: 0x246A7D4
	private void <GetRoomGmEventMobData>b__747_0() { }

	[CompilerGenerated]
	// RVA: 0x246A7E0 Offset: 0x24667E0 VA: 0x246A7E0
	private void <HouseLotteryInfo>b__774_0() { }

	[CompilerGenerated]
	// RVA: 0x246A7EC Offset: 0x24667EC VA: 0x246A7EC
	private void <HouseLotteryListClear>b__775_0() { }

	[CompilerGenerated]
	// RVA: 0x246A7F8 Offset: 0x24667F8 VA: 0x246A7F8
	private void <HouseLotteryRecruitCancel>b__776_0() { }

	[CompilerGenerated]
	// RVA: 0x246A804 Offset: 0x2466804 VA: 0x246A804
	private void <HouseLotteryRecruitReSend>b__778_0() { }

	[CompilerGenerated]
	// RVA: 0x246A810 Offset: 0x2466810 VA: 0x246A810
	private void <CultivationGardenEnter>b__780_0() { }

	[CompilerGenerated]
	// RVA: 0x246A81C Offset: 0x246681C VA: 0x246A81C
	private void <CultivationGardenLeave>b__781_0() { }

	[CompilerGenerated]
	// RVA: 0x246A828 Offset: 0x2466828 VA: 0x246A828
	private void <CultivationGetList>b__787_0() { }

	[CompilerGenerated]
	// RVA: 0x246A834 Offset: 0x2466834 VA: 0x246A834
	private void <CuisineCleanUp>b__792_0() { }

	[CompilerGenerated]
	// RVA: 0x246A840 Offset: 0x2466840 VA: 0x246A840
	private void <CuisineGetRecipe>b__793_0() { }

	[CompilerGenerated]
	// RVA: 0x246A84C Offset: 0x246684C VA: 0x246A84C
	private void <CuisineGetEatingList>b__794_0() { }

	[CompilerGenerated]
	// RVA: 0x246A858 Offset: 0x2466858 VA: 0x246A858
	private void <GetFoodPoint>b__795_0() { }

	[CompilerGenerated]
	// RVA: 0x246A864 Offset: 0x2466864 VA: 0x246A864
	private void <BankSetup>b__858_0() { }

	[CompilerGenerated]
	// RVA: 0x246A870 Offset: 0x2466870 VA: 0x246A870
	private void <ExpPotionDeposit>b__864_0() { }

	[CompilerGenerated]
	// RVA: 0x246A87C Offset: 0x246687C VA: 0x246A87C
	private void <BlackKnightLeave>b__937_0() { }

	[CompilerGenerated]
	// RVA: 0x246A888 Offset: 0x2466888 VA: 0x246A888
	private void <BlackKnightJoin>b__938_0() { }

	[CompilerGenerated]
	// RVA: 0x246A894 Offset: 0x2466894 VA: 0x246A894
	private void <BlackKnightSelectStage>b__941_0() { }

	[CompilerGenerated]
	// RVA: 0x246A8A0 Offset: 0x24668A0 VA: 0x246A8A0
	private void <BlackKnightLootBox>b__943_0() { }

	[CompilerGenerated]
	// RVA: 0x246A8AC Offset: 0x24668AC VA: 0x246A8AC
	private void <BlackKnightDeleteSaveData>b__944_0() { }

	[CompilerGenerated]
	// RVA: 0x246A8B8 Offset: 0x24668B8 VA: 0x246A8B8
	private void <CardGameJoin>b__949_0() { }

	[CompilerGenerated]
	// RVA: 0x246A8C4 Offset: 0x24668C4 VA: 0x246A8C4
	private void <CardGameLeave>b__953_0() { }

	[CompilerGenerated]
	// RVA: 0x246A8D0 Offset: 0x24668D0 VA: 0x246A8D0
	private void <CardGameResult>b__954_0() { }

	[CompilerGenerated]
	// RVA: 0x246A8DC Offset: 0x24668DC VA: 0x246A8DC
	private void <CardGameGiveUp>b__955_0() { }

	[CompilerGenerated]
	// RVA: 0x246A8E8 Offset: 0x24668E8 VA: 0x246A8E8
	private void <CardGameReconnectResult>b__959_0() { }
}
