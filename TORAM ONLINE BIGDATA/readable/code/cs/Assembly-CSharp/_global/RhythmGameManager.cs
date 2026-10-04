// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RhythmGameManager : Singleton<RhythmGameManager>, ISceneChangeManager // TypeDefIndex: 4483
{
	// Fields
	public static readonly int ButtonCount; // 0x0
	public static int BossMaxHp; // 0x4
	[CompilerGenerated]
	private int <IntervalParam>k__BackingField; // 0x20
	public const int DefaultIntervalParam = 5;
	[CompilerGenerated]
	private int <BackColorParam>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <MoveCameraFlag>k__BackingField; // 0x28
	private RhythmGameManager.ScritpId nowScriptId; // 0x2C
	private SystemTextManager systemTextManager; // 0x30
	private PlayerDataManager playerDataManager; // 0x38
	private List<RhythmGameManager.RhythmGameModelData> memberModelList; // 0x40
	private RhythmGameManager.RhythmGameModelData enemyModelData; // 0x48
	private SkinnedMeshRenderer[] enemySkinMesh; // 0x50
	private const float enemyHitEffMinPos = 2;
	private const float enemyHitEffMaxPos = 6;
	private GameManager gameManager; // 0x58
	private const int playerModelId = 2101;
	private RhythmMemberData[] memberData; // 0x60
	private RhythmRecordData[] recordData; // 0x68
	private RhythmSettingData setting; // 0x70
	private RhythmMemberData myMemberData; // 0x78
	private int bossHp; // 0x80
	private UIRhythmGameEnterManager uiEnterManager; // 0x88
	private UIRhythmGameManager uiManager; // 0x90
	private Dictionary<string, IntegratedNotesData> notesList; // 0x98
	private RhythmMasterData masterData; // 0xA0
	private bool isPopWindow; // 0xA8
	private const float disconnectTime = 30;
	private CameraManager cameraManager; // 0xB0
	private readonly Color baseModelColor; // 0xB8
	private int houseBgmId; // 0xC8
	private GameObject hitEffectObj; // 0xD0
	private AnimationBase hitEffectAnimation; // 0xD8
	private Vector3 hitEffectBasePos; // 0xE0
	private GameObject lastAttackEffectObj; // 0xF0
	private AnimationBase lastAttackEffectAnime; // 0xF8
	private RhythmGameResultEvent lastResultData; // 0x100
	private const int houseItemId = 600045;
	private WaitForSeconds waitForSeconds; // 0x108
	private List<GameObject> mainPanelList; // 0x110
	private WaitForEndOfFrame waitForEndOfFrame; // 0x118
	private bool isLoadNotes; // 0x120
	private const int NpcModelId = 2000000;
	private const string SettingIntervalKey = "RhythmGameSettingInterval";
	private const string SettingBackColorKey = "RhythmGameSettingBackColor";
	private const string SettingMoveCameraKey = "RhythmGameSettingMoveCamera";

	// Properties
	public bool IsOwner { get; }
	public int BossHP { get; }
	public RhythmMemberData[] MemberData { get; }
	public RhythmRecordData[] RecordData { get; }
	public RhythmSettingData SettingData { get; }
	public RhythmMasterData MasterData { get; }
	public List<RhythmMusicData> MusicDataList { get; }
	public bool IsLoadNotes { get; }
	public List<string> NotesKeysList { get; }
	public int IntervalParam { get; set; }
	public float NotesInterval { get; }
	public int BackColorParam { get; set; }
	public float BackColorAlpha { get; }
	public bool MoveCameraFlag { get; set; }

	// Methods

	// RVA: 0x24F8ABC Offset: 0x24F4ABC VA: 0x24F8ABC
	public bool get_IsOwner() { }

	// RVA: 0x24F8B34 Offset: 0x24F4B34 VA: 0x24F8B34
	public int get_BossHP() { }

	// RVA: 0x24F8B3C Offset: 0x24F4B3C VA: 0x24F8B3C
	public RhythmMemberData[] get_MemberData() { }

	// RVA: 0x24F8B44 Offset: 0x24F4B44 VA: 0x24F8B44
	public RhythmRecordData[] get_RecordData() { }

	// RVA: 0x24F8B4C Offset: 0x24F4B4C VA: 0x24F8B4C
	public RhythmSettingData get_SettingData() { }

	// RVA: 0x24F8B54 Offset: 0x24F4B54 VA: 0x24F8B54
	public RhythmMasterData get_MasterData() { }

	// RVA: 0x24F8B5C Offset: 0x24F4B5C VA: 0x24F8B5C
	public List<RhythmMusicData> get_MusicDataList() { }

	// RVA: 0x24F8B74 Offset: 0x24F4B74 VA: 0x24F8B74
	public bool get_IsLoadNotes() { }

	// RVA: 0x24F8B7C Offset: 0x24F4B7C VA: 0x24F8B7C
	public List<string> get_NotesKeysList() { }

	[CompilerGenerated]
	// RVA: 0x24F8BE8 Offset: 0x24F4BE8 VA: 0x24F8BE8
	public int get_IntervalParam() { }

	[CompilerGenerated]
	// RVA: 0x24F8BF0 Offset: 0x24F4BF0 VA: 0x24F8BF0
	private void set_IntervalParam(int value) { }

	// RVA: 0x24F8BF8 Offset: 0x24F4BF8 VA: 0x24F8BF8
	public float get_NotesInterval() { }

	[CompilerGenerated]
	// RVA: 0x24F8C18 Offset: 0x24F4C18 VA: 0x24F8C18
	public int get_BackColorParam() { }

	[CompilerGenerated]
	// RVA: 0x24F8C20 Offset: 0x24F4C20 VA: 0x24F8C20
	private void set_BackColorParam(int value) { }

	// RVA: 0x24F8C28 Offset: 0x24F4C28 VA: 0x24F8C28
	public float get_BackColorAlpha() { }

	[CompilerGenerated]
	// RVA: 0x24F8C30 Offset: 0x24F4C30 VA: 0x24F8C30
	public bool get_MoveCameraFlag() { }

	[CompilerGenerated]
	// RVA: 0x24F8C38 Offset: 0x24F4C38 VA: 0x24F8C38
	private void set_MoveCameraFlag(bool value) { }

	// RVA: 0x24F8C44 Offset: 0x24F4C44 VA: 0x24F8C44
	private void Awake() { }

	// RVA: 0x24F8F38 Offset: 0x24F4F38 VA: 0x24F8F38
	private void Start() { }

	// RVA: 0x24F8F58 Offset: 0x24F4F58 VA: 0x24F8F58
	private void Update() { }

	// RVA: 0x24F9394 Offset: 0x24F5394 VA: 0x24F9394
	private void OnApplicationPause(bool pauseStatus) { }

	// RVA: 0x24F95B8 Offset: 0x24F55B8 VA: 0x24F95B8
	public bool GetNotesData(string name, out IntegratedNotesData data) { }

	// RVA: 0x24F96A4 Offset: 0x24F56A4 VA: 0x24F96A4
	public RhythmMemberData GetMemberData(int memberId) { }

	// RVA: 0x24F9790 Offset: 0x24F5790 VA: 0x24F9790
	public RhythmMusicData GetMusicDataSortId(int sortId) { }

	// RVA: 0x24F9884 Offset: 0x24F5884 VA: 0x24F9884
	public RhythmMusicData GetMusicDataMusicId(int musicId) { }

	// RVA: 0x24F9978 Offset: 0x24F5978 VA: 0x24F9978
	public RhythmMusicData GetMusicDataIndex(int index) { }

	// RVA: 0x24F9A04 Offset: 0x24F5A04 VA: 0x24F9A04
	public int GetIndex(int musicId) { }

	// RVA: 0x24F9AF8 Offset: 0x24F5AF8 VA: 0x24F9AF8
	public RhythmRecordData GetRecordData(int musicId) { }

	[IteratorStateMachine(typeof(RhythmGameManager.<LoadBGM>d__89))]
	// RVA: 0x24F9BE4 Offset: 0x24F5BE4 VA: 0x24F9BE4
	public IEnumerator LoadBGM() { }

	// RVA: 0x24F9C58 Offset: 0x24F5C58 VA: 0x24F9C58
	public void LoadRhythmNotesData() { }

	// RVA: 0x24F9CEC Offset: 0x24F5CEC VA: 0x24F9CEC
	public void LoadMusicMasterData() { }

	// RVA: 0x24F9D7C Offset: 0x24F5D7C VA: 0x24F9D7C
	public void LoadMasterData(byte[] binary) { }

	// RVA: 0x24FA098 Offset: 0x24F6098 VA: 0x24FA098
	public void UpdatePotumPosition(int id, Vector3 pos, float rot, float scale) { }

	// RVA: 0x24FA2F4 Offset: 0x24F62F4 VA: 0x24FA2F4
	public void UpdateBossPosition(int id, Vector3 pos, float rot, float scale) { }

	// RVA: 0x24FA410 Offset: 0x24F6410 VA: 0x24FA410
	public void UpdateCameraPosition(Vector3 pos, Vector3 rot) { }

	// RVA: 0x24FA550 Offset: 0x24F6550 VA: 0x24FA550
	public void StartPlayCameraMove() { }

	// RVA: 0x24FA5E4 Offset: 0x24F65E4 VA: 0x24FA5E4
	public void ForcePlayMotionToNatural(MobAnimationType type) { }

	// RVA: 0x24FA754 Offset: 0x24F6754 VA: 0x24FA754
	public void PlayMotion(MobAnimationType type, WrapMode mode) { }

	// RVA: 0x24FA8C0 Offset: 0x24F68C0 VA: 0x24FA8C0
	public void PlayMotionToNaturalButtonId(int id, MobAnimationType type) { }

	// RVA: 0x24FA998 Offset: 0x24F6998 VA: 0x24FA998
	public void PlayMotionToNatural(int id, MobAnimationType type) { }

	// RVA: 0x24FAA38 Offset: 0x24F6A38 VA: 0x24FAA38
	public void PlayEnemyMotionToNatural(float waitTime, MobAnimationType type) { }

	// RVA: 0x24FABBC Offset: 0x24F6BBC VA: 0x24FABBC
	public void PlayEnemyMotion(MobAnimationType type, WrapMode mode) { }

	// RVA: 0x24FABD0 Offset: 0x24F6BD0 VA: 0x24FABD0
	public void Enter(bool isEveryone) { }

	// RVA: 0x24FABF8 Offset: 0x24F6BF8 VA: 0x24FABF8
	public void Join() { }

	// RVA: 0x24FAC14 Offset: 0x24F6C14 VA: 0x24FAC14
	public void Setting(RhythmGameState gameState, int musicId, byte difficulty) { }

	// RVA: 0x24FAC8C Offset: 0x24F6C8C VA: 0x24FAC8C
	public void EnterReady(RhythmGameState gameState, int musicId, byte difficulty) { }

	// RVA: 0x24FACA8 Offset: 0x24F6CA8 VA: 0x24FACA8
	public void StartReady() { }

	// RVA: 0x24FACC4 Offset: 0x24F6CC4 VA: 0x24FACC4
	public void Finish(short critical, short hit, short graze, short miss) { }

	// RVA: 0x24FACE0 Offset: 0x24F6CE0 VA: 0x24FACE0
	public void ResultEnd() { }

	// RVA: 0x24FACFC Offset: 0x24F6CFC VA: 0x24FACFC
	public void GiveUp() { }

	// RVA: 0x24FAD18 Offset: 0x24F6D18 VA: 0x24FAD18
	public void Leave() { }

	// RVA: 0x24FAD34 Offset: 0x24F6D34 VA: 0x24FAD34
	public void Attack(short combo, short critical, short hit, short graze, short miss) { }

	// RVA: 0x24FAD7C Offset: 0x24F6D7C VA: 0x24FAD7C
	public void ReceiveJoinResponse(RhythmJoinResponse response) { }

	// RVA: 0x24FAFFC Offset: 0x24F6FFC VA: 0x24FAFFC
	public void ReceiveLeave() { }

	// RVA: 0x24FB030 Offset: 0x24F7030 VA: 0x24FB030
	public void ReceiveGiveUp() { }

	// RVA: 0x24FB034 Offset: 0x24F7034 VA: 0x24FB034
	public void ReceiveEventRhythmGameState(RhythmGameStateEvent state) { }

	// RVA: 0x24FB314 Offset: 0x24F7314 VA: 0x24FB314
	public void ReceiveEventRhythmGameStartPrepare(RhythmGameStartPrepareEvent prepare) { }

	// RVA: 0x24FB3E4 Offset: 0x24F73E4 VA: 0x24FB3E4
	public void ReceiveEventRhythmGameStart(RhythmGameStartEvent start) { }

	// RVA: 0x24FB580 Offset: 0x24F7580 VA: 0x24FB580
	public void ReceiveEventRhythmGameScoreState(RhythmGameScoreStateEvent state) { }

	// RVA: 0x24FB6C8 Offset: 0x24F76C8 VA: 0x24FB6C8
	public void ReceiveEventRhythmGameResult(RhythmGameResultEvent result) { }

	// RVA: 0x24FBAC8 Offset: 0x24F7AC8 VA: 0x24FBAC8
	public void ReceiveEventRhythmGameEnd(RhythmGameEndEvent end) { }

	// RVA: 0x24FBBE8 Offset: 0x24F7BE8 VA: 0x24FBBE8
	public void ReceiveEventRhythmGameGiveUp(RhythmGameGiveupEvent giveup) { }

	// RVA: 0x24FBD64 Offset: 0x24F7D64 VA: 0x24FBD64
	public void ReceiveEventRhythmGameKickout(RhythmGameKickoutEvent kickout) { }

	// RVA: 0x24FBDF4 Offset: 0x24F7DF4 VA: 0x24FBDF4
	public void CheckOperationFailure(byte operationCode, byte subCode, short returnCode) { }

	// RVA: 0x24FBE28 Offset: 0x24F7E28 VA: 0x24FBE28
	public void OpenErrorWindow() { }

	// RVA: 0x24FBE2C Offset: 0x24F7E2C VA: 0x24FBE2C
	public void SetIntervalParam(int param) { }

	// RVA: 0x24FBE34 Offset: 0x24F7E34 VA: 0x24FBE34
	public void SetBackColorParam(int param) { }

	// RVA: 0x24FBE3C Offset: 0x24F7E3C VA: 0x24FBE3C
	public void SetMoveCameraFlag(bool isMove) { }

	// RVA: 0x24FBE48 Offset: 0x24F7E48 VA: 0x24FBE48
	public void SaveOption() { }

	// RVA: 0x24F8E50 Offset: 0x24F4E50 VA: 0x24F8E50
	private void InitOption() { }

	// RVA: 0x24FAF94 Offset: 0x24F6F94 VA: 0x24FAF94
	private void SetScriptId(RhythmGameManager.ScritpId id) { }

	// RVA: 0x24FBE9C Offset: 0x24F7E9C VA: 0x24FBE9C
	private int GetHouseBgmId() { }

	[IteratorStateMachine(typeof(RhythmGameManager.<LoadMobResource>d__133))]
	// RVA: 0x24FBFA8 Offset: 0x24F7FA8 VA: 0x24FBFA8
	private IEnumerator LoadMobResource(int modelId, int modelScale, int buttonId, int[] color) { }

	[IteratorStateMachine(typeof(RhythmGameManager.<LoadMobResource>d__134))]
	// RVA: 0x24FC054 Offset: 0x24F8054 VA: 0x24FC054
	private IEnumerator LoadMobResource(int modelId, int modelScale, int buttonId, Color[] color) { }

	[IteratorStateMachine(typeof(RhythmGameManager.<UpdateModelList>d__135))]
	// RVA: 0x24FAF20 Offset: 0x24F6F20 VA: 0x24FAF20
	private IEnumerator UpdateModelList() { }

	// RVA: 0x24FC104 Offset: 0x24F8104 VA: 0x24FC104
	private void UpdateModelColor(GameObject obj, Color color) { }

	// RVA: 0x24FC2E8 Offset: 0x24F82E8 VA: 0x24FC2E8
	private void DestroyEnemyModel() { }

	// RVA: 0x24FC39C Offset: 0x24F839C VA: 0x24FC39C
	private void DestroyAllModel() { }

	// RVA: 0x24FC574 Offset: 0x24F8574 VA: 0x24FC574
	private void PlaySuccessMotion() { }

	// RVA: 0x24FC6D8 Offset: 0x24F86D8 VA: 0x24FC6D8
	private void PlayDeadMotion() { }

	[IteratorStateMachine(typeof(RhythmGameManager.<LoadHitEffect>d__141))]
	// RVA: 0x24FC83C Offset: 0x24F883C VA: 0x24FC83C
	private IEnumerator LoadHitEffect() { }

	// RVA: 0x24FC8B0 Offset: 0x24F88B0 VA: 0x24FC8B0
	private void InitHitEffectModel() { }

	[IteratorStateMachine(typeof(RhythmGameManager.<LoadLastAttackEffect>d__143))]
	// RVA: 0x24FCA80 Offset: 0x24F8A80 VA: 0x24FCA80
	private IEnumerator LoadLastAttackEffect(int id) { }

	// RVA: 0x24FCB04 Offset: 0x24F8B04 VA: 0x24FCB04
	private void InitLastAttackEffectModel(int id) { }

	// RVA: 0x24FCCD4 Offset: 0x24F8CD4 VA: 0x24FCCD4
	private bool CheckNpcModelId(int modelId) { }

	[IteratorStateMachine(typeof(RhythmGameManager.<LoadNotesData>d__146))]
	// RVA: 0x24F9C78 Offset: 0x24F5C78 VA: 0x24F9C78
	private IEnumerator LoadNotesData() { }

	[IteratorStateMachine(typeof(RhythmGameManager.<ChangeMainPanel>d__147))]
	// RVA: 0x24FB370 Offset: 0x24F7370 VA: 0x24FB370
	private IEnumerator ChangeMainPanel() { }

	[IteratorStateMachine(typeof(RhythmGameManager.<ChangeResultPanel>d__148))]
	// RVA: 0x24FBA38 Offset: 0x24F7A38 VA: 0x24FBA38
	private IEnumerator ChangeResultPanel(RhythmGameResultEvent result) { }

	[IteratorStateMachine(typeof(RhythmGameManager.<ResultMotion>d__149))]
	// RVA: 0x24FCCE8 Offset: 0x24F8CE8 VA: 0x24FCCE8
	private IEnumerator ResultMotion(bool isSuccess, int id, int musicId) { }

	[IteratorStateMachine(typeof(RhythmGameManager.<ReturnSelectMusicPanel>d__150))]
	// RVA: 0x24FBB74 Offset: 0x24F7B74 VA: 0x24FBB74
	private IEnumerator ReturnSelectMusicPanel() { }

	[IteratorStateMachine(typeof(RhythmGameManager.<ChangeMainGameNonPanel>d__151))]
	// RVA: 0x24F90B0 Offset: 0x24F50B0 VA: 0x24F90B0
	private IEnumerator ChangeMainGameNonPanel() { }

	[IteratorStateMachine(typeof(RhythmGameManager.<WaitPlayEnemyMotionToNatural>d__152))]
	// RVA: 0x24FAAA4 Offset: 0x24F6AA4 VA: 0x24FAAA4
	private IEnumerator WaitPlayEnemyMotionToNatural(float waitTime, MobAnimationType type) { }

	[IteratorStateMachine(typeof(RhythmGameManager.<WaitPlayHitEffect>d__153))]
	// RVA: 0x24FAB38 Offset: 0x24F6B38 VA: 0x24FAB38
	private IEnumerator WaitPlayHitEffect(float waitTime) { }

	// RVA: 0x24FAE5C Offset: 0x24F6E5C VA: 0x24FAE5C
	private void UpdateMyMemberData() { }

	// RVA: 0x24FB744 Offset: 0x24F7744 VA: 0x24FB744
	private void UpdateRecordData(RhythmRecordData data) { }

	// RVA: 0x24F9480 Offset: 0x24F5480 VA: 0x24F9480
	private void ErrorWindow() { }

	// RVA: 0x24F925C Offset: 0x24F525C VA: 0x24F925C
	private void DisconnectWindow() { }

	// RVA: 0x24F9124 Offset: 0x24F5124 VA: 0x24F9124
	private void LeaveWindow() { }

	// RVA: 0x24FCD78 Offset: 0x24F8D78 VA: 0x24FCD78
	private void LeaveButton() { }

	[IteratorStateMachine(typeof(RhythmGameManager.<LeaveWait>d__160))]
	// RVA: 0x24FCD9C Offset: 0x24F8D9C VA: 0x24FCD9C
	private IEnumerator LeaveWait() { }

	// RVA: 0x24FCE10 Offset: 0x24F8E10 VA: 0x24FCE10 Slot: 4
	public void OnEnter() { }

	// RVA: 0x24FD5A0 Offset: 0x24F95A0 VA: 0x24FD5A0 Slot: 5
	public void OnLeave() { }

	// RVA: 0x24FD910 Offset: 0x24F9910 VA: 0x24FD910
	public void .ctor() { }

	// RVA: 0x24FDAE0 Offset: 0x24F9AE0 VA: 0x24FDAE0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x24FDB30 Offset: 0x24F9B30 VA: 0x24FDB30
	private bool <UpdateMyMemberData>b__154_0(RhythmMemberData x) { }
}
