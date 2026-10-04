// Assembly: Assembly-CSharp.dll
// Namespace: 
public class QuestManager : MonoBehaviour // TypeDefIndex: 2227
{
	// Fields
	private const int maxQuestCount = 10;
	private PlayerDataManager playerData; // 0x20
	protected Dictionary<int, ScenarioData<QuestCommon>> questList; // 0x28
	private Dictionary<int, ScenarioData<QuestCommon>> removeQuestList; // 0x30
	protected ScenarioData<MissionCommon> missionData; // 0x38
	private MissionCommon removeMission; // 0x40
	private Dictionary<int, MasterScenarioData> masterQuestList; // 0x48
	private Dictionary<int, MasterScenarioData> masterMissionList; // 0x50
	private List<QuestManager.MobClearData> mobClearDataList; // 0x58
	private List<QuestManager.ItemClearData> itemClearDataList; // 0x60
	private List<QuestManager.RewardData> rewardList; // 0x68
	private bool restartAbandonQuest; // 0x70
	private bool restartStartQuest; // 0x71
	private SystemTextManager systemTextManager; // 0x78
	private readonly int[] appsFlyerMissionIdList; // 0x80
	[CompilerGenerated]
	private bool <WarrantyItem>k__BackingField; // 0x88
	[CompilerGenerated]
	private int <ScenarioProgress>k__BackingField; // 0x8C
	[CompilerGenerated]
	private int <AccountProgress>k__BackingField; // 0x90
	[CompilerGenerated]
	private QuestManager.RewardStateType <RewardState>k__BackingField; // 0x94
	private List<MasterMissionSkipData> masterMissionSkipDataList; // 0x98
	private bool isMissionSkipMasterLoaded; // 0xA0
	[CompilerGenerated]
	private List<int> <MissionChapterNumList>k__BackingField; // 0xA8

	// Properties
	public bool WarrantyItem { get; set; }
	public List<QuestCommon> QuestList { get; }
	public int QuestCount { get; }
	public bool IsQuestMax { get; }
	public MissionCommon MissionData { get; }
	public int CurrentMissionId { get; }
	public int ScenarioProgress { get; set; }
	public int AccountProgress { get; set; }
	public bool HasClearTarget { get; }
	public List<QuestManager.MobClearData> MobClearDataList { get; }
	public List<QuestManager.ItemClearData> ItemClearDataList { get; }
	public QuestManager.RewardStateType RewardState { get; set; }
	public List<QuestManager.RewardData> RewardList { get; }
	public List<int> MissionChapterNumList { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x216B2CC Offset: 0x21672CC VA: 0x216B2CC
	public bool get_WarrantyItem() { }

	[CompilerGenerated]
	// RVA: 0x216B2D4 Offset: 0x21672D4 VA: 0x216B2D4
	private void set_WarrantyItem(bool value) { }

	// RVA: 0x216B2E0 Offset: 0x21672E0 VA: 0x216B2E0
	public List<QuestCommon> get_QuestList() { }

	// RVA: 0x216B400 Offset: 0x2167400 VA: 0x216B400
	public int get_QuestCount() { }

	// RVA: 0x216B450 Offset: 0x2167450 VA: 0x216B450
	public bool get_IsQuestMax() { }

	// RVA: 0x216B4AC Offset: 0x21674AC VA: 0x216B4AC
	public MissionCommon get_MissionData() { }

	// RVA: 0x216B57C Offset: 0x216757C VA: 0x216B57C
	public int get_CurrentMissionId() { }

	[CompilerGenerated]
	// RVA: 0x216B5C4 Offset: 0x21675C4 VA: 0x216B5C4
	public int get_ScenarioProgress() { }

	[CompilerGenerated]
	// RVA: 0x216B5CC Offset: 0x21675CC VA: 0x216B5CC
	private void set_ScenarioProgress(int value) { }

	[CompilerGenerated]
	// RVA: 0x216B5D4 Offset: 0x21675D4 VA: 0x216B5D4
	public int get_AccountProgress() { }

	[CompilerGenerated]
	// RVA: 0x216B5DC Offset: 0x21675DC VA: 0x216B5DC
	private void set_AccountProgress(int value) { }

	// RVA: 0x216B5E4 Offset: 0x21675E4 VA: 0x216B5E4
	public bool get_HasClearTarget() { }

	// RVA: 0x216B65C Offset: 0x216765C VA: 0x216B65C
	public List<QuestManager.MobClearData> get_MobClearDataList() { }

	// RVA: 0x216B664 Offset: 0x2167664 VA: 0x216B664
	public List<QuestManager.ItemClearData> get_ItemClearDataList() { }

	[CompilerGenerated]
	// RVA: 0x216B66C Offset: 0x216766C VA: 0x216B66C
	public QuestManager.RewardStateType get_RewardState() { }

	[CompilerGenerated]
	// RVA: 0x216B674 Offset: 0x2167674 VA: 0x216B674
	private void set_RewardState(QuestManager.RewardStateType value) { }

	// RVA: 0x216B67C Offset: 0x216767C VA: 0x216B67C
	public List<QuestManager.RewardData> get_RewardList() { }

	// RVA: 0x216B79C Offset: 0x216779C VA: 0x216B79C
	private void Awake() { }

	// RVA: 0x216B7CC Offset: 0x21677CC VA: 0x216B7CC
	public bool ReadMasterData(TextAsset questData, TextAsset missionData) { }

	// RVA: 0x216C118 Offset: 0x2168118 VA: 0x216C118
	private void checkLocalizeData() { }

	// RVA: 0x216C834 Offset: 0x2168834 VA: 0x216C834
	private void GetScenarioIdList(Dictionary<int, List<int>> dic, TextManagerBase textManager, int[] keys) { }

	// RVA: 0x216CA6C Offset: 0x2168A6C VA: 0x216CA6C
	public void LoadLocalizeData() { }

	[IteratorStateMachine(typeof(QuestManager.<LoadScenarioData>d__61))]
	// RVA: 0x216CDE0 Offset: 0x2168DE0 VA: 0x216CDE0
	public IEnumerator LoadScenarioData(MissionTextManager textManager, int ScenarioProgress, UnityAction callback) { }

	[IteratorStateMachine(typeof(QuestManager.<loadMissionLocalizeData>d__62))]
	// RVA: 0x216CEB4 Offset: 0x2168EB4 VA: 0x216CEB4
	private IEnumerator loadMissionLocalizeData(int id) { }

	// RVA: 0x216CF58 Offset: 0x2168F58 VA: 0x216CF58
	public int ScenarioReceiveLevel(bool mission, int id) { }

	[IteratorStateMachine(typeof(QuestManager.<LoadReOrderMissionList>d__64))]
	// RVA: 0x216D02C Offset: 0x216902C VA: 0x216D02C
	public IEnumerator LoadReOrderMissionList(int endId) { }

	// RVA: 0x216D0D0 Offset: 0x21690D0 VA: 0x216D0D0 Slot: 4
	public virtual void Initialize(ScenarioList scenarioData) { }

	// RVA: 0x216D5B0 Offset: 0x21695B0 VA: 0x216D5B0
	private IScenarioData getScenarioData(bool mission, int questId) { }

	// RVA: 0x216D67C Offset: 0x216967C VA: 0x216D67C
	public void StartRewardConnection() { }

	// RVA: 0x216D6F4 Offset: 0x21696F4 VA: 0x216D6F4 Slot: 5
	public virtual void ReceiveMissionStart(MissionStartResponse startData) { }

	// RVA: 0x216DA30 Offset: 0x2169A30 VA: 0x216DA30
	public void ReceiveMissionEnd(MissionEndResponse endData) { }

	// RVA: 0x216DF74 Offset: 0x2169F74 VA: 0x216DF74
	public void ReceiveQuestStart(QuestStartResponse startData) { }

	// RVA: 0x216E1B0 Offset: 0x216A1B0 VA: 0x216E1B0
	public void ReceiveQuestEnd(QuestEndResponse endData) { }

	// RVA: 0x216E260 Offset: 0x216A260 VA: 0x216E260
	public void ReceiveMissionData(MissionGetDataResponse mission) { }

	// RVA: 0x216E574 Offset: 0x216A574 VA: 0x216E574
	public void ReceiveQuestData(QuestGetDataResponse quest) { }

	// RVA: 0x216E940 Offset: 0x216A940 VA: 0x216E940 Slot: 6
	public virtual void ReceiveQuestAbandon(QuestAbandonmentResponse abandonData) { }

	// RVA: 0x216EA34 Offset: 0x216AA34 VA: 0x216EA34 Slot: 7
	public virtual void ReceiveMissionAbandon(MissionAbandonmentResponse abandonData) { }

	// RVA: 0x216EAC8 Offset: 0x216AAC8 VA: 0x216EAC8
	public void ReceiveMissionAbandon(int MissionId) { }

	// RVA: 0x216EB4C Offset: 0x216AB4C VA: 0x216EB4C
	public void ReceiveQuestReward(QuestCheckRewardResponse reward) { }

	// RVA: 0x216ED64 Offset: 0x216AD64 VA: 0x216ED64
	public void ReceiveQuestReward(QuestCheckContinuousRewardResponse reward) { }

	// RVA: 0x216F0C8 Offset: 0x216B0C8 VA: 0x216F0C8
	public void ReceiveMissionReward(MissionCheckRewardResponse reward) { }

	// RVA: 0x216F294 Offset: 0x216B294 VA: 0x216F294
	public void ReceiveQuestFailed(OperationResponse responseObject) { }

	// RVA: 0x216F558 Offset: 0x216B558 VA: 0x216F558
	public void ReceiveMissionFailed(OperationResponse responseObject) { }

	// RVA: 0x216F76C Offset: 0x216B76C VA: 0x216F76C
	public void StartQuest(int questId, bool restart) { }

	// RVA: 0x216F864 Offset: 0x216B864 VA: 0x216F864
	public void EndQuest(int questId) { }

	// RVA: 0x216F94C Offset: 0x216B94C VA: 0x216F94C
	public bool AbandonQuest(int questId, bool restart) { }

	// RVA: 0x216FA48 Offset: 0x216BA48 VA: 0x216FA48
	public bool StartMission(int missionId) { }

	// RVA: 0x216FAD4 Offset: 0x216BAD4 VA: 0x216FAD4
	public bool EndMission(int missionId) { }

	// RVA: 0x216FC30 Offset: 0x216BC30 VA: 0x216FC30
	public bool AbandonMission(int missionId) { }

	// RVA: 0x216FD7C Offset: 0x216BD7C VA: 0x216FD7C
	public QuestManager.QuestOrderCondition GetQuestOrderCondition(int questId, byte flag) { }

	// RVA: 0x216FFD4 Offset: 0x216BFD4 VA: 0x216FFD4
	public bool CheckOrdered(bool mission, int id) { }

	// RVA: 0x216FFF0 Offset: 0x216BFF0 VA: 0x216FFF0
	public bool CheckRewardOrdered(bool mission, int id) { }

	// RVA: 0x217008C Offset: 0x216C08C VA: 0x217008C
	public int GetItemRestCount(bool mission, int questId, int no) { }

	// RVA: 0x2170184 Offset: 0x216C184 VA: 0x2170184
	public int GetMobSubdueRestCount(bool mission, int questId, int no) { }

	// RVA: 0x2170260 Offset: 0x216C260 VA: 0x2170260 Slot: 8
	public virtual void ItemClearCheck() { }

	// RVA: 0x21708E8 Offset: 0x216C8E8 VA: 0x21708E8 Slot: 9
	public virtual void MobSubdueCountUp(int fieldId, int mobUuid) { }

	// RVA: 0x2170B3C Offset: 0x216CB3C VA: 0x2170B3C
	public bool RewardCheck(bool mission, int questId) { }

	// RVA: 0x2170C28 Offset: 0x216CC28 VA: 0x2170C28
	public bool RewardCheck(bool mission, int questId, short keyNoFlag, short itemNoFlag, short mobNoFlag) { }

	// RVA: 0x2170D38 Offset: 0x216CD38 VA: 0x2170D38
	public int GetRewardRepeatNum(bool mission, int questId) { }

	// RVA: 0x2170E24 Offset: 0x216CE24 VA: 0x2170E24 Slot: 10
	public virtual bool EndCheck(bool mission, int questId) { }

	// RVA: 0x2170EB8 Offset: 0x216CEB8 VA: 0x2170EB8
	public IScenarioKey SetKeyitem(bool mission, int questId, byte keyNo, byte current, byte max) { }

	// RVA: 0x2170FAC Offset: 0x216CFAC VA: 0x2170FAC
	public int GetKeyitem(bool mission, int questId, byte keyNo, byte type) { }

	// RVA: 0x2171098 Offset: 0x216D098 VA: 0x2171098
	public int[] GetCheckItemId() { }

	// RVA: 0x21712FC Offset: 0x216D2FC VA: 0x21712FC
	public void SetWarrantyItem(bool flag) { }

	// RVA: 0x2171308 Offset: 0x216D308 VA: 0x2171308
	public void SetViewFlag(bool mission, int questId, byte checkFlag, short keyViewFlag, short itemViewFlag, short mobViewFlag, byte infoNo) { }

	// RVA: 0x216D770 Offset: 0x2169770 VA: 0x216D770
	private void AddSystemChat(bool mission, int id, ChatManager.SystemChatType type) { }

	[IteratorStateMachine(typeof(QuestManager.<LoadTextWait>d__105))]
	// RVA: 0x2171418 Offset: 0x216D418 VA: 0x2171418
	private IEnumerator LoadTextWait(bool mission, int id, ChatManager.SystemChatType type) { }

	// RVA: 0x21714D8 Offset: 0x216D4D8 VA: 0x21714D8 Slot: 11
	public virtual void SetDetailManager(GameObject obj) { }

	// RVA: 0x21714DC Offset: 0x216D4DC VA: 0x21714DC Slot: 12
	public virtual void DeleteDetailManager(GameObject obj) { }

	// RVA: 0x21714E0 Offset: 0x216D4E0 VA: 0x21714E0 Slot: 13
	public virtual void UpdateAllDetail() { }

	[CompilerGenerated]
	// RVA: 0x21714E4 Offset: 0x216D4E4 VA: 0x21714E4
	public List<int> get_MissionChapterNumList() { }

	[CompilerGenerated]
	// RVA: 0x21714EC Offset: 0x216D4EC VA: 0x21714EC
	private void set_MissionChapterNumList(List<int> value) { }

	[IteratorStateMachine(typeof(QuestManager.<LoadMasterMissionSkipData>d__115))]
	// RVA: 0x21714F4 Offset: 0x216D4F4 VA: 0x21714F4
	public IEnumerator LoadMasterMissionSkipData() { }

	[IteratorStateMachine(typeof(QuestManager.<LoadMissionLocalize>d__116))]
	// RVA: 0x2171588 Offset: 0x216D588 VA: 0x2171588
	public IEnumerator LoadMissionLocalize(MasterMissionSkipData[] datas) { }

	// RVA: 0x2171638 Offset: 0x216D638 VA: 0x2171638
	public bool TryGetMasterQuestData(int missionId, out MasterMissionSkipData data) { }

	// RVA: 0x2171738 Offset: 0x216D738 VA: 0x2171738
	public bool TryGetChapterMasterQuestDataList(int chapter, out List<MasterMissionSkipData> dataList) { }

	// RVA: 0x2171878 Offset: 0x216D878 VA: 0x2171878
	public int GetSkipNeedGold(int skipMissionId) { }

	// RVA: 0x2171A40 Offset: 0x216DA40 VA: 0x2171A40
	public bool CheckCanSkipMission(int missionId) { }

	// RVA: 0x2171A84 Offset: 0x216DA84 VA: 0x2171A84
	public List<int> GetProgressChapterNumList(int missionId) { }

	// RVA: 0x2171BC0 Offset: 0x216DBC0 VA: 0x2171BC0
	public int GetClearMaxChapterNum() { }

	// RVA: 0x2171C30 Offset: 0x216DC30 VA: 0x2171C30
	public void MissionSkipProcess(int avatarUuid, int missionId) { }

	// RVA: 0x2171D24 Offset: 0x216DD24 VA: 0x2171D24
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2172080 Offset: 0x216E080 VA: 0x2172080
	private bool <checkLocalizeData>b__58_0(int x) { }

	[CompilerGenerated]
	// RVA: 0x21720E4 Offset: 0x216E0E4 VA: 0x21720E4
	private bool <checkLocalizeData>b__58_1(int x) { }
}
