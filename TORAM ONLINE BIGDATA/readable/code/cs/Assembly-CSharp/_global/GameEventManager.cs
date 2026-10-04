// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GameEventManager : Singleton<GameEventManager>, ISceneChangeManager // TypeDefIndex: 1843
{
	// Fields
	private Action<int> callBackSetVal; // 0x20
	private Action<int> callBackGetVal; // 0x28
	private Action<int> callBackSettingVal; // 0x30
	private GameEventDataBase gameEventDataBase; // 0x38
	private List<byte> ongoingEventList; // 0x40
	private Dictionary<byte, GameEventManager.GameEventValData> gameEventValList; // 0x48
	private Dictionary<short, IGameEventExchangeData> exchangeDataList; // 0x50
	private int checkSettingVersion; // 0x58
	private byte checkSettingType; // 0x5C
	private int checkGetVersion; // 0x60
	private byte checkGetType; // 0x64
	private byte checkGetIndex; // 0x65
	private GmEventData[] roomGmMobEventData; // 0x68
	private DateTime updateRoomGmMobEventData; // 0x70
	[CompilerGenerated]
	private HighRaidEventData <HighRaidData>k__BackingField; // 0x78
	[CompilerGenerated]
	private WaveRewardData <WaveRewardData>k__BackingField; // 0x80
	[CompilerGenerated]
	private ScoreAttackEventData <ScoreAttackData>k__BackingField; // 0x88
	[CompilerGenerated]
	private WarpListManager <WarpListManager>k__BackingField; // 0x90
	private TermEventData[] termEventDataList; // 0x98

	// Properties
	public GameEventDataBase GameEventData { get; }
	public HighRaidEventData HighRaidData { get; set; }
	public WaveRewardData WaveRewardData { get; set; }
	public ScoreAttackEventData ScoreAttackData { get; set; }
	public WarpListManager WarpListManager { get; set; }

	// Methods

	// RVA: 0x20EC0F4 Offset: 0x20E80F4 VA: 0x20EC0F4
	public GameEventDataBase get_GameEventData() { }

	[CompilerGenerated]
	// RVA: 0x20EC0FC Offset: 0x20E80FC VA: 0x20EC0FC
	public HighRaidEventData get_HighRaidData() { }

	[CompilerGenerated]
	// RVA: 0x20EC104 Offset: 0x20E8104 VA: 0x20EC104
	private void set_HighRaidData(HighRaidEventData value) { }

	[CompilerGenerated]
	// RVA: 0x20EC10C Offset: 0x20E810C VA: 0x20EC10C
	public WaveRewardData get_WaveRewardData() { }

	[CompilerGenerated]
	// RVA: 0x20EC114 Offset: 0x20E8114 VA: 0x20EC114
	private void set_WaveRewardData(WaveRewardData value) { }

	[CompilerGenerated]
	// RVA: 0x20EC11C Offset: 0x20E811C VA: 0x20EC11C
	public ScoreAttackEventData get_ScoreAttackData() { }

	[CompilerGenerated]
	// RVA: 0x20EC124 Offset: 0x20E8124 VA: 0x20EC124
	private void set_ScoreAttackData(ScoreAttackEventData value) { }

	[CompilerGenerated]
	// RVA: 0x20EC12C Offset: 0x20E812C VA: 0x20EC12C
	public WarpListManager get_WarpListManager() { }

	[CompilerGenerated]
	// RVA: 0x20EC134 Offset: 0x20E8134 VA: 0x20EC134
	private void set_WarpListManager(WarpListManager value) { }

	// RVA: 0x20EC13C Offset: 0x20E813C VA: 0x20EC13C
	private void Start() { }

	// RVA: 0x20EC194 Offset: 0x20E8194 VA: 0x20EC194
	public void SetOngoingGameEventType(byte[] ongoingGameEventType) { }

	// RVA: 0x20EC204 Offset: 0x20E8204 VA: 0x20EC204
	public bool CheckOngoingGameEventType(byte ongoingGameEventType) { }

	// RVA: 0x20EC25C Offset: 0x20E825C VA: 0x20EC25C
	public void EnterGameEcentScene(EnterGameEventField eventData) { }

	// RVA: 0x20EC5FC Offset: 0x20E85FC VA: 0x20EC5FC
	public void OnOperationFailure(byte operationCode, short returnCode) { }

	// RVA: 0x20EC8A8 Offset: 0x20E88A8 VA: 0x20EC8A8
	private bool GameEventHasEndedCheck(short returnCode) { }

	// RVA: 0x20ECAE8 Offset: 0x20E8AE8 VA: 0x20ECAE8
	public void GetEvent(byte gameEventType, Action<int> callBack, byte[] param) { }

	// RVA: 0x20ECB84 Offset: 0x20E8B84 VA: 0x20ECB84
	public void ReceiveGetEvent(GetEventResponse response, short returnCode) { }

	// RVA: 0x20ECC00 Offset: 0x20E8C00 VA: 0x20ECC00
	public void SetEvent(byte gameEventType, Action<int> callBack, byte[] param) { }

	// RVA: 0x20ECC9C Offset: 0x20E8C9C VA: 0x20ECC9C
	public void ReceiveSetEvent(SetEventResponse response, short returnCode) { }

	// RVA: 0x20ECD18 Offset: 0x20E8D18 VA: 0x20ECD18
	public void SettingVal(byte gameEventType, int version, Action<int> callBack) { }

	// RVA: 0x20ECE08 Offset: 0x20E8E08 VA: 0x20ECE08
	public void ReceiveSettingVal(GameEventGetScenarioResponse response, short returnCode) { }

	// RVA: 0x20ED0D0 Offset: 0x20E90D0 VA: 0x20ED0D0
	public void GetVal(byte gameEventType, int version, byte valIndex, Action<int> callBack) { }

	// RVA: 0x20ED2E0 Offset: 0x20E92E0 VA: 0x20ED2E0
	public void ReceiveGetVal(GameEventGetFlagResponse response, short returnCode) { }

	// RVA: 0x20ED424 Offset: 0x20E9424 VA: 0x20ED424
	public void SetVal(byte gameEventType, int version, byte valIndex, byte val, Action<int> callBack) { }

	// RVA: 0x20ED4C4 Offset: 0x20E94C4 VA: 0x20ED4C4
	public void ReceiveSetVal(GameEventSetFlagResponse response, short returnCode) { }

	// RVA: 0x20ED600 Offset: 0x20E9600 VA: 0x20ED600
	public IGameEventExchangeData GetExchangeData(short shopId) { }

	// RVA: 0x20ED82C Offset: 0x20E982C VA: 0x20ED82C
	public bool CheckExchangeData(short shopId) { }

	// RVA: 0x20ED8A8 Offset: 0x20E98A8 VA: 0x20ED8A8
	public bool ReceiveExchangeData(short shopId, out GameEventExchangeData retData) { }

	// RVA: 0x20ED9DC Offset: 0x20E99DC VA: 0x20ED9DC
	public void TryConnectionRoomGMMobEventData() { }

	// RVA: 0x20EDB30 Offset: 0x20E9B30 VA: 0x20EDB30
	public List<GmEventData> GetRoomGMMobEventData() { }

	// RVA: 0x20EDBDC Offset: 0x20E9BDC VA: 0x20EDBDC
	public void ReceiveRoomGMMobEventData(GmEventData[] data) { }

	// RVA: 0x20EDAC0 Offset: 0x20E9AC0 VA: 0x20EDAC0
	private void RoomGMMobEvevtClear() { }

	[IteratorStateMachine(typeof(GameEventManager.<LoadHighRaidBossMaster>d__56))]
	// RVA: 0x20EDC54 Offset: 0x20E9C54 VA: 0x20EDC54
	public IEnumerator LoadHighRaidBossMaster() { }

	[IteratorStateMachine(typeof(GameEventManager.<LoadHighRaidMaterialMaster>d__57))]
	// RVA: 0x20EDCE8 Offset: 0x20E9CE8 VA: 0x20EDCE8
	public IEnumerator LoadHighRaidMaterialMaster() { }

	[IteratorStateMachine(typeof(GameEventManager.<LoadHighRaidTrophyMaster>d__58))]
	// RVA: 0x20EDD7C Offset: 0x20E9D7C VA: 0x20EDD7C
	public IEnumerator LoadHighRaidTrophyMaster() { }

	// RVA: 0x20EDE10 Offset: 0x20E9E10 VA: 0x20EDE10
	public int GetFishingProcessRatePoint(int foodPoint) { }

	// RVA: 0x20EDF2C Offset: 0x20E9F2C VA: 0x20EDF2C
	public int GetExpBonusRate(int lv, bool isParty) { }

	// RVA: 0x20EE034 Offset: 0x20EA034 VA: 0x20EE034
	public int GetDropRate() { }

	// RVA: 0x20EE0F8 Offset: 0x20EA0F8 VA: 0x20EE0F8
	public void GetActiveTermEvent() { }

	// RVA: 0x20EE188 Offset: 0x20EA188 VA: 0x20EE188 Slot: 4
	public void OnEnter() { }

	// RVA: 0x20EE1A0 Offset: 0x20EA1A0 VA: 0x20EE1A0 Slot: 5
	public void OnLeave() { }

	// RVA: 0x20EE3F8 Offset: 0x20EA3F8 VA: 0x20EE3F8
	public void .ctor() { }
}
