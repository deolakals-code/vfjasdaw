// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UINCollaborationEnterManager : UIBasePanelConnection // TypeDefIndex: 6148
{
	// Fields
	private PlayerDataManager playerData; // 0x30
	private Dictionary<int, UINCollaborationEnterManager.GemData> gemList; // 0x38
	private UINCollaborationEnterManager.GemData nowSelectGemData; // 0x40
	private List<int> selectedGemList; // 0x48
	private List<int> selectedOrbGemList; // 0x50
	[SerializeField]
	private GameObject gemIcon; // 0x58
	[SerializeField]
	private UISprite gemPanelIcon; // 0x60
	private UICamera gemScrollCamera; // 0x68
	private GemUsePopWindow gemPopUpWindow; // 0x70
	[SerializeField]
	private GameObject[] partyMemberObject; // 0x78
	[SerializeField]
	private GameObject mainPanelObject; // 0x80
	[SerializeField]
	private UIImageButton[] imageButton; // 0x88
	[SerializeField]
	private UILabel gemSelectButtonLabel; // 0x90
	[SerializeField]
	private UIImageButton enterButton; // 0x98
	[SerializeField]
	private UILabel enterButtonLabel; // 0xA0
	[SerializeField]
	private GameObject partyButton; // 0xA8
	private UIToggle partyToggle; // 0xB0
	[SerializeField]
	private GameObject reinforceButton; // 0xB8
	private UIToggle reinforceToggle; // 0xC0
	[SerializeField]
	private GameObject bossStatusPanel; // 0xC8
	[SerializeField]
	private UIIruna2Anchor mainPanelAnchor; // 0xD0
	[SerializeField]
	private UILabel bossStatusLabel; // 0xD8
	private UIScrollWindow itemListWindow; // 0xE0
	private UIIruna2Anchor itemListWindowAnchor; // 0xE8
	[SerializeField]
	private GameObject itemButton; // 0xF0
	[SerializeField]
	private UILabel itemPopUpLabel; // 0xF8
	[SerializeField]
	private GameObject gemPropertyObject; // 0x100
	private UIItemProperty gemPropertyLabel; // 0x108
	private bool inputLock; // 0x110
	private bool isMatching; // 0x111
	private bool isUserCheckMatching; // 0x112
	private bool isBeforeUserCheckMatching; // 0x113
	private UINCollaborationEnterBasePanel bossSymbolPanel; // 0x118
	[SerializeField]
	private UILabel bossBattleLevel; // 0x120
	[SerializeField]
	private GameObject rightDifficultyButton; // 0x128
	[SerializeField]
	private GameObject leftDifficultyButton; // 0x130
	[SerializeField]
	private UILabel difficultyLabel; // 0x138
	[SerializeField]
	private UILabel difficultyEngLabel; // 0x140
	[SerializeField]
	private UISprite[] diffIconBaseSprite; // 0x148
	[SerializeField]
	private UISprite[] diffIconSprite; // 0x150
	[SerializeField]
	private GameObject difficultyObj; // 0x158
	[SerializeField]
	private GameObject fixDifficultyObj; // 0x160
	[SerializeField]
	private GameObject matchingCheckObj; // 0x168
	[SerializeField]
	private UIToggle matchingToggle; // 0x170
	[SerializeField]
	private UILabel matchingLabel; // 0x178
	[SerializeField]
	private UIScrollWindow statusScrollWindow; // 0x180
	[SerializeField]
	private GameObject statusScrollElement; // 0x188
	[SerializeField]
	private GameObject statusPropElement; // 0x190
	[SerializeField]
	private UISprite[] dropSettingIcon; // 0x198
	[SerializeField]
	private UIIcon dropItemIcon; // 0x1A0
	[SerializeField]
	private UILabel dropItemLabel; // 0x1A8
	[SerializeField]
	private GameObject statusExDropElement; // 0x1B0
	[SerializeField]
	private GameObject statusExPlusElement; // 0x1B8
	[SerializeField]
	private GameObject lineElement; // 0x1C0
	[SerializeField]
	private GameObject employButton; // 0x1C8
	[SerializeField]
	private UIToggle pointBoostToggle; // 0x1D0
	[SerializeField]
	private UILabel pointBoostLabel; // 0x1D8
	[SerializeField]
	private GameObject pointBoostWindow; // 0x1E0
	private BoxCollider pointBoostCol; // 0x1E8
	private int difficultyState; // 0x1F0
	private int difficultyStateNum; // 0x1F4
	private int beforeDifficultyState; // 0x1F8
	private bool diffIconSizeFlg; // 0x1FC
	private bool canDifficultyChangeFlag; // 0x1FD
	private byte closeDifficultyFlag; // 0x1FE
	private List<int> difficultyList; // 0x200
	private bool cancel; // 0x208
	private bool close; // 0x209
	private UINCollaborationEnterManager.PanelState panelState; // 0x20C
	private ItemTextManager itemTextManager; // 0x210
	private float connectTimer; // 0x218
	private int battleLevel; // 0x21C
	private bool initCheck; // 0x220
	private bool popWindow; // 0x221
	private GameObject shortcutManager; // 0x228
	private bool openShortcut; // 0x230
	private NCollaborationRoomData bossRoomData; // 0x238
	[CompilerGenerated]
	private bool <IsEmployMercenary>k__BackingField; // 0x240
	private const int CanEmployScenarioNum = 5;
	private bool isReconnected; // 0x241
	private NCollaborationRoomData beforeRoomData; // 0x248
	private int[] bossHpList; // 0x250

	// Properties
	private PlayerDataManager playerDataManager { get; }
	public bool ReinforceToggle { get; }
	public bool IsCancel { get; }
	public bool IsClose { get; }
	public bool IsEmployMercenary { get; set; }

	// Methods

	// RVA: 0x189AADC Offset: 0x1896ADC VA: 0x189AADC
	private PlayerDataManager get_playerDataManager() { }

	// RVA: 0x189AB60 Offset: 0x1896B60 VA: 0x189AB60
	public bool get_ReinforceToggle() { }

	// RVA: 0x189AB7C Offset: 0x1896B7C VA: 0x189AB7C
	public bool get_IsCancel() { }

	// RVA: 0x189AB84 Offset: 0x1896B84 VA: 0x189AB84
	public bool get_IsClose() { }

	[CompilerGenerated]
	// RVA: 0x189AB8C Offset: 0x1896B8C VA: 0x189AB8C
	public bool get_IsEmployMercenary() { }

	[CompilerGenerated]
	// RVA: 0x189AB94 Offset: 0x1896B94 VA: 0x189AB94
	private void set_IsEmployMercenary(bool value) { }

	// RVA: 0x189ABA0 Offset: 0x1896BA0 VA: 0x189ABA0
	private void Awake() { }

	// RVA: 0x189AD24 Offset: 0x1896D24 VA: 0x189AD24
	private void Start() { }

	// RVA: 0x189B644 Offset: 0x1897644 VA: 0x189B644
	private void OnDestroy() { }

	// RVA: 0x189B720 Offset: 0x1897720 VA: 0x189B720
	public void Initialize(int fieldId, byte roomId, Vector3 pos, float rot, EmergencyPositionData emergencyPosition, int level, int difficulty, bool isMatching, int[] bossHpList) { }

	[IteratorStateMachine(typeof(UINCollaborationEnterManager.<InitializeThread>d__100))]
	// RVA: 0x189B7CC Offset: 0x18977CC VA: 0x189B7CC
	public IEnumerator InitializeThread(int fieldId, byte roomId, Vector3 pos, float rot, EmergencyPositionData emergencyPosition, int level, int difficulty, bool isMatching) { }

	[IteratorStateMachine(typeof(UINCollaborationEnterManager.<PopErrWindow>d__101))]
	// RVA: 0x189B8DC Offset: 0x18978DC VA: 0x189B8DC
	private IEnumerator PopErrWindow() { }

	// RVA: 0x189B970 Offset: 0x1897970 VA: 0x189B970
	private void Update() { }

	// RVA: 0x189BDB8 Offset: 0x1897DB8 VA: 0x189BDB8
	private void CloseShortcutPanel() { }

	// RVA: 0x189D260 Offset: 0x1899260 VA: 0x189D260
	private void CheckPartyToggle() { }

	// RVA: 0x189D298 Offset: 0x1899298 VA: 0x189D298
	private void CheckReinforceToggle() { }

	// RVA: 0x189CB0C Offset: 0x1898B0C VA: 0x189CB0C
	public void OpenBossData() { }

	// RVA: 0x189D36C Offset: 0x189936C VA: 0x189D36C
	private bool CheckBossData() { }

	// RVA: 0x189D418 Offset: 0x1899418 VA: 0x189D418
	private void OpenBossDataWindow() { }

	// RVA: 0x189E2B8 Offset: 0x189A2B8 VA: 0x189E2B8
	private GameObject CreateStatusElement(bool isDebug, Vector3 pos, int itemId, byte itemDropType, int propValTotal, int colorTotal, bool isRedText) { }

	// RVA: 0x189E654 Offset: 0x189A654 VA: 0x189E654
	private string GetDropItemName(ItemDBData db, int itemId, bool isDebug, bool isRedText, int valTotal, int colorTotal) { }

	// RVA: 0x189CDAC Offset: 0x1898DAC VA: 0x189CDAC
	private void OpenItemList() { }

	// RVA: 0x189E96C Offset: 0x189A96C VA: 0x189E96C
	public void CheckUseItem(int itemId) { }

	// RVA: 0x189EC38 Offset: 0x189AC38 VA: 0x189EC38
	private void OpenGemCheckWindow(int itemId) { }

	// RVA: 0x189EE24 Offset: 0x189AE24 VA: 0x189EE24
	private void AddOrbGemList(int itemId) { }

	// RVA: 0x189BEE0 Offset: 0x1897EE0 VA: 0x189BEE0
	private void SendRoomLobbySettingChange() { }

	// RVA: 0x189B2BC Offset: 0x18972BC VA: 0x189B2BC
	private void OpenMainPanel() { }

	// RVA: 0x189F07C Offset: 0x189B07C VA: 0x189F07C
	public void BattleReady() { }

	// RVA: 0x189F22C Offset: 0x189B22C VA: 0x189F22C
	private void BattleReadyCancel() { }

	// RVA: 0x189C7B8 Offset: 0x18987B8 VA: 0x189C7B8
	private void BossBattleLevelText() { }

	// RVA: 0x189F35C Offset: 0x189B35C VA: 0x189F35C
	private byte[] GetPointBoostList() { }

	// RVA: 0x189F3DC Offset: 0x189B3DC VA: 0x189F3DC
	private void SetSelectDifficulty(out bool isCantNormal) { }

	// RVA: 0x189BF94 Offset: 0x1897F94 VA: 0x189BF94
	private void DifficultySet() { }

	// RVA: 0x189CBEC Offset: 0x1898BEC VA: 0x189CBEC
	private void DifficultyIconScaleChange() { }

	// RVA: 0x189CA10 Offset: 0x1898A10 VA: 0x189CA10
	private bool PartyDifficulty() { }

	// RVA: 0x189F6FC Offset: 0x189B6FC VA: 0x189F6FC
	public void DifficultyUp() { }

	// RVA: 0x189F808 Offset: 0x189B808 VA: 0x189F808
	public void DifficultyDown() { }

	// RVA: 0x189EF30 Offset: 0x189AF30 VA: 0x189EF30
	private bool CheckCanEnter() { }

	// RVA: 0x189F8F8 Offset: 0x189B8F8 VA: 0x189F8F8
	public void ChangeMatchingFlag() { }

	// RVA: 0x189F9A4 Offset: 0x189B9A4 VA: 0x189F9A4
	public void OnPointBoost() { }

	// RVA: 0x189FA1C Offset: 0x189BA1C VA: 0x189FA1C
	public void OnPointBoostWindowButton() { }

	// RVA: 0x189FA54 Offset: 0x189BA54 VA: 0x189FA54
	private void ChangeActiveEmployButton() { }

	[IteratorStateMachine(typeof(UINCollaborationEnterManager.<ChangeEmployButtonPos>d__132))]
	// RVA: 0x189FB44 Offset: 0x189BB44 VA: 0x189FB44
	private IEnumerator ChangeEmployButtonPos() { }

	// RVA: 0x189FBD8 Offset: 0x189BBD8 VA: 0x189FBD8
	private void OnEmploy() { }

	// RVA: 0x189FC10 Offset: 0x189BC10 VA: 0x189FC10
	public void ForceClose() { }

	// RVA: 0x189FC40 Offset: 0x189BC40 VA: 0x189FC40
	public void CopeGroupNotFound() { }

	[IteratorStateMachine(typeof(UINCollaborationEnterManager.<ReCheckBossSymbol>d__136))]
	// RVA: 0x189FD5C Offset: 0x189BD5C VA: 0x189FD5C
	private IEnumerator ReCheckBossSymbol() { }

	[IteratorStateMachine(typeof(UINCollaborationEnterManager.<ConnectWait>d__137))]
	// RVA: 0x189D2D0 Offset: 0x18992D0 VA: 0x189D2D0
	private IEnumerator ConnectWait(Func<bool> checkConnect, Action callBack) { }

	// RVA: 0x189FE18 Offset: 0x189BE18 VA: 0x189FE18 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x18A0074 Offset: 0x189C074 VA: 0x18A0074 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18A0168 Offset: 0x189C168 VA: 0x18A0168 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x18A02A8 Offset: 0x189C2A8 VA: 0x18A02A8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x18A04BC Offset: 0x189C4BC VA: 0x18A04BC
	private bool <InitializeThread>b__100_0() { }

	[CompilerGenerated]
	// RVA: 0x18A04E0 Offset: 0x189C4E0 VA: 0x18A04E0
	private bool <ReCheckBossSymbol>b__136_0() { }
}
