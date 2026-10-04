// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBossRaidSymbolManager : UIBasePanel // TypeDefIndex: 5648
{
	// Fields
	private PlayerDataManager playerData; // 0x30
	private Dictionary<int, UIBossRaidSymbolManager.GemData> gemList; // 0x38
	private UIBossRaidSymbolManager.GemData nowSelectGemData; // 0x40
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
	private UIBossRaidSymbolBasePanel bossSymbolPanel; // 0x118
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
	private int difficultyState; // 0x1D0
	private int difficultyStateNum; // 0x1D4
	private int beforeDifficultyState; // 0x1D8
	private bool diffIconSizeFlg; // 0x1DC
	private bool canDifficultyChangeFlag; // 0x1DD
	private byte closeDifficultyFlag; // 0x1DE
	private List<int> difficultyList; // 0x1E0
	private bool cancel; // 0x1E8
	private bool close; // 0x1E9
	private UIBossRaidSymbolManager.PanelState panelState; // 0x1EC
	private ItemTextManager itemTextManager; // 0x1F0
	private float connectTimer; // 0x1F8
	private int battleLevel; // 0x1FC
	private bool initCheck; // 0x200
	private bool popWindow; // 0x201
	private GameObject shortcutManager; // 0x208
	private bool openShortcut; // 0x210
	private BossRaidRoomData bossRoomData; // 0x218
	[CompilerGenerated]
	private bool <IsEmployMercenary>k__BackingField; // 0x220
	private const int CanEmployScenarioNum = 5;
	private bool isReconnected; // 0x221
	private BossRaidRoomData beforeRoomData; // 0x228
	private int[] bossHpList; // 0x230

	// Properties
	private PlayerDataManager playerDataManager { get; }
	public bool ReinforceToggle { get; }
	public bool IsCancel { get; }
	public bool IsClose { get; }
	public bool IsEmployMercenary { get; set; }

	// Methods

	// RVA: 0x17B151C Offset: 0x17AD51C VA: 0x17B151C
	private PlayerDataManager get_playerDataManager() { }

	// RVA: 0x17B15A0 Offset: 0x17AD5A0 VA: 0x17B15A0
	public bool get_ReinforceToggle() { }

	// RVA: 0x17B15BC Offset: 0x17AD5BC VA: 0x17B15BC
	public bool get_IsCancel() { }

	// RVA: 0x17B15C4 Offset: 0x17AD5C4 VA: 0x17B15C4
	public bool get_IsClose() { }

	[CompilerGenerated]
	// RVA: 0x17B15CC Offset: 0x17AD5CC VA: 0x17B15CC
	public bool get_IsEmployMercenary() { }

	[CompilerGenerated]
	// RVA: 0x17B15D4 Offset: 0x17AD5D4 VA: 0x17B15D4
	private void set_IsEmployMercenary(bool value) { }

	// RVA: 0x17B15E0 Offset: 0x17AD5E0 VA: 0x17B15E0
	private void Awake() { }

	// RVA: 0x17B1764 Offset: 0x17AD764 VA: 0x17B1764
	private void Start() { }

	// RVA: 0x17B1F98 Offset: 0x17ADF98 VA: 0x17B1F98
	private void OnDestroy() { }

	// RVA: 0x17B2074 Offset: 0x17AE074 VA: 0x17B2074
	public void Initialize(int fieldId, byte roomId, Vector3 pos, float rot, EmergencyPositionData emergencyPosition, int level, int difficulty, bool canDiffFlag, string bossText, byte closeDifficulty, bool isMatching, int[] bossHpList) { }

	[IteratorStateMachine(typeof(UIBossRaidSymbolManager.<InitializeThread>d__96))]
	// RVA: 0x17B2154 Offset: 0x17AE154 VA: 0x17B2154
	public IEnumerator InitializeThread(int fieldId, byte roomId, Vector3 pos, float rot, EmergencyPositionData emergencyPosition, int level, int difficulty, bool canDiffFlag, string bossText, byte closeDifficulty, bool isMatching) { }

	[IteratorStateMachine(typeof(UIBossRaidSymbolManager.<PopErrWindow>d__97))]
	// RVA: 0x17B22A0 Offset: 0x17AE2A0 VA: 0x17B22A0
	private IEnumerator PopErrWindow() { }

	// RVA: 0x17B2314 Offset: 0x17AE314 VA: 0x17B2314
	private void Update() { }

	// RVA: 0x17B2754 Offset: 0x17AE754 VA: 0x17B2754
	private void CloseShortcutPanel() { }

	// RVA: 0x17B3CD8 Offset: 0x17AFCD8 VA: 0x17B3CD8
	private void CheckPartyToggle() { }

	// RVA: 0x17B3D10 Offset: 0x17AFD10 VA: 0x17B3D10
	private void CheckReinforceToggle() { }

	// RVA: 0x17B34A8 Offset: 0x17AF4A8 VA: 0x17B34A8
	private void OpenBossData() { }

	// RVA: 0x17B3DE4 Offset: 0x17AFDE4 VA: 0x17B3DE4
	private bool CheckBossData() { }

	// RVA: 0x17B3E90 Offset: 0x17AFE90 VA: 0x17B3E90
	private void OpenBossDataWindow() { }

	// RVA: 0x17B4D30 Offset: 0x17B0D30 VA: 0x17B4D30
	private GameObject CreateStatusElement(bool isDebug, Vector3 pos, int itemId, byte itemDropType, int propValTotal, int colorTotal, bool isRedText) { }

	// RVA: 0x17B50CC Offset: 0x17B10CC VA: 0x17B50CC
	private string GetDropItemName(ItemDBData db, int itemId, bool isDebug, bool isRedText, int valTotal, int colorTotal) { }

	// RVA: 0x17B3748 Offset: 0x17AF748 VA: 0x17B3748
	private void OpenItemList() { }

	// RVA: 0x17B53E4 Offset: 0x17B13E4 VA: 0x17B53E4
	public void CheckUseItem(int itemId) { }

	// RVA: 0x17B56B0 Offset: 0x17B16B0 VA: 0x17B56B0
	private void OpenGemCheckWindow(int itemId) { }

	// RVA: 0x17B589C Offset: 0x17B189C VA: 0x17B589C
	private void AddOrbGemList(int itemId) { }

	// RVA: 0x17B287C Offset: 0x17AE87C VA: 0x17B287C
	private void SendRoomLobbySettingChange() { }

	// RVA: 0x17B1CFC Offset: 0x17ADCFC VA: 0x17B1CFC
	private void OpenMainPanel() { }

	// RVA: 0x17B5AF4 Offset: 0x17B1AF4 VA: 0x17B5AF4
	private void BattleReady() { }

	// RVA: 0x17B5C38 Offset: 0x17B1C38 VA: 0x17B5C38
	private void BattleReadyCancel() { }

	// RVA: 0x17B3154 Offset: 0x17AF154 VA: 0x17B3154
	private void BossBattleLevelText() { }

	// RVA: 0x17B5D00 Offset: 0x17B1D00 VA: 0x17B5D00
	private void SetSelectDifficulty(out bool isCantNormal) { }

	// RVA: 0x17B2930 Offset: 0x17AE930 VA: 0x17B2930
	private void DifficultySet() { }

	// RVA: 0x17B3588 Offset: 0x17AF588 VA: 0x17B3588
	private void DifficultyIconScaleChange() { }

	// RVA: 0x17B33AC Offset: 0x17AF3AC VA: 0x17B33AC
	private bool PartyDifficulty() { }

	// RVA: 0x17B6020 Offset: 0x17B2020 VA: 0x17B6020
	private void DifficultyUp() { }

	// RVA: 0x17B6120 Offset: 0x17B2120 VA: 0x17B6120
	private void DifficultyDown() { }

	// RVA: 0x17B59A8 Offset: 0x17B19A8 VA: 0x17B59A8
	private bool CheckCanEnter() { }

	// RVA: 0x17B6204 Offset: 0x17B2204 VA: 0x17B6204
	public void ChangeMatchingFlag() { }

	// RVA: 0x17B62B0 Offset: 0x17B22B0 VA: 0x17B62B0
	private void ChangeActiveEmployButton() { }

	[IteratorStateMachine(typeof(UIBossRaidSymbolManager.<ChangeEmployButtonPos>d__125))]
	// RVA: 0x17B63A0 Offset: 0x17B23A0 VA: 0x17B63A0
	private IEnumerator ChangeEmployButtonPos() { }

	// RVA: 0x17B6434 Offset: 0x17B2434 VA: 0x17B6434
	private void OnEmploy() { }

	// RVA: 0x17B646C Offset: 0x17B246C VA: 0x17B646C
	public void ForceClose() { }

	// RVA: 0x17B649C Offset: 0x17B249C VA: 0x17B649C
	public void CopeGroupNotFound() { }

	[IteratorStateMachine(typeof(UIBossRaidSymbolManager.<ReCheckBossSymbol>d__129))]
	// RVA: 0x17B65B8 Offset: 0x17B25B8 VA: 0x17B65B8
	private IEnumerator ReCheckBossSymbol() { }

	[IteratorStateMachine(typeof(UIBossRaidSymbolManager.<ConnectWait>d__130))]
	// RVA: 0x17B3D48 Offset: 0x17AFD48 VA: 0x17B3D48
	private IEnumerator ConnectWait(Func<bool> checkConnect, Action callBack) { }

	// RVA: 0x17B6654 Offset: 0x17B2654 VA: 0x17B6654 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x17B6868 Offset: 0x17B2868 VA: 0x17B6868 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x17B695C Offset: 0x17B295C VA: 0x17B695C Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x17B6A9C Offset: 0x17B2A9C VA: 0x17B6A9C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x17B6CB0 Offset: 0x17B2CB0 VA: 0x17B6CB0
	private bool <InitializeThread>b__96_0() { }

	[CompilerGenerated]
	// RVA: 0x17B6CD4 Offset: 0x17B2CD4 VA: 0x17B6CD4
	private bool <ReCheckBossSymbol>b__129_0() { }
}
