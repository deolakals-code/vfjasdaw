// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UINaCollaborationEnterManager : UIBasePanelConnection // TypeDefIndex: 6133
{
	// Fields
	[Header("MainPanel")]
	[SerializeField]
	private GameObject mainPanelObject; // 0x30
	[SerializeField]
	private UIIruna2Anchor mainPanelAnchor; // 0x38
	[SerializeField]
	private GameObject bossStatusPanel; // 0x40
	[SerializeField]
	private UILabel bossStatusLabel; // 0x48
	[SerializeField]
	private UILabel bossBattleLevel; // 0x50
	[SerializeField]
	private GameObject weaponRewardButton; // 0x58
	[Header("Difficulty")]
	[SerializeField]
	private GameObject rightDifficultyButton; // 0x60
	[SerializeField]
	private GameObject leftDifficultyButton; // 0x68
	[SerializeField]
	private UILabel difficultyLabel; // 0x70
	[SerializeField]
	private UILabel difficultyEnglishLabel; // 0x78
	[SerializeField]
	private UISprite[] difficultyIconBaseSprites; // 0x80
	[SerializeField]
	private UISprite[] difficultyIconSprites; // 0x88
	[SerializeField]
	private GameObject difficultyObj; // 0x90
	[SerializeField]
	private GameObject fixDifficultyObj; // 0x98
	[SerializeField]
	private UIScrollWindow statusScrollWindow; // 0xA0
	[SerializeField]
	private GameObject statusScrollElement; // 0xA8
	[SerializeField]
	private GameObject statusPropElement; // 0xB0
	[SerializeField]
	private UISprite[] dropSettingIcon; // 0xB8
	[SerializeField]
	private UIIcon dropItemIcon; // 0xC0
	[SerializeField]
	private UILabel dropItemLabel; // 0xC8
	[SerializeField]
	private GameObject statusExDropElement; // 0xD0
	[SerializeField]
	private GameObject statusExPlusElement; // 0xD8
	[SerializeField]
	private GameObject lineElement; // 0xE0
	[SerializeField]
	[Header("Member")]
	private GameObject[] partyMemberObject; // 0xE8
	[SerializeField]
	private UIImageButton[] imageButton; // 0xF0
	[SerializeField]
	private UIIruna2Anchor partyMenuAnchor; // 0xF8
	[Header("Gem")]
	[SerializeField]
	private UILabel gemSelectButtonLabel; // 0x100
	[SerializeField]
	private GameObject gemIcon; // 0x108
	[SerializeField]
	private UISprite gemPanelIcon; // 0x110
	[SerializeField]
	private GameObject gemPropertyObject; // 0x118
	[Header("Other")]
	[SerializeField]
	private UIImageButton enterButton; // 0x120
	[SerializeField]
	private UILabel enterButtonLabel; // 0x128
	[SerializeField]
	private GameObject partyButton; // 0x130
	[SerializeField]
	private GameObject reinforceButton; // 0x138
	[SerializeField]
	private GameObject itemButton; // 0x140
	[SerializeField]
	private UILabel itemPopUpLabel; // 0x148
	[SerializeField]
	private GameObject employButton; // 0x150
	[SerializeField]
	private UIToggle pointBoostToggle; // 0x158
	[SerializeField]
	private UILabel pointBoostLabel; // 0x160
	[SerializeField]
	private GameObject pointBoostWindow; // 0x168
	[SerializeField]
	private GameObject specialRewardButton; // 0x170
	[SerializeField]
	private GameObject specialRewardReceivedIcon; // 0x178
	[Header("Infomation")]
	[SerializeField]
	private GameObject infomationWindow; // 0x180
	[SerializeField]
	private GameObject infomationWindowCloseObj; // 0x188
	[SerializeField]
	private UILabel infoTitleLabel; // 0x190
	[SerializeField]
	private UILabel infoLabel; // 0x198
	[SerializeField]
	private UILabel infoItemLabel; // 0x1A0
	[SerializeField]
	private GameObject infoRightButton; // 0x1A8
	[SerializeField]
	private GameObject infoLeftButton; // 0x1B0
	[SerializeField]
	private GameObject weaponRewardWindow; // 0x1B8
	[SerializeField]
	private GameObject weaponRewardWindowCloseObj; // 0x1C0
	[SerializeField]
	private UILabel[] weaponRewardLabels; // 0x1C8
	[SerializeField]
	private UILabel weaponRewardCountLabel; // 0x1D0
	[SerializeField]
	private GameObject weaponRewardInfoButton; // 0x1D8
	[SerializeField]
	private GameObject[] weaponRewardPanels; // 0x1E0
	[SerializeField]
	private GameObject specialRewardWindow; // 0x1E8
	[SerializeField]
	private GameObject[] specialRewardObjs; // 0x1F0
	[SerializeField]
	private UIQuestRewardList[] specialRewardLists; // 0x1F8
	[SerializeField]
	private UIImageButton specialRewardWindowButton; // 0x200
	[SerializeField]
	private UILabel specialRewardErrorLabel; // 0x208
	private PlayerDataManager playerData; // 0x210
	private ItemTextManager itemTextManager; // 0x218
	private UIToggle partyToggle; // 0x220
	private UIToggle reinforceToggle; // 0x228
	private Dictionary<int, UINaCollaborationEnterManager.GemData> gemList; // 0x230
	private UINaCollaborationEnterManager.GemData nowSelectGemData; // 0x238
	private List<int> selectedGemList; // 0x240
	private List<int> selectedOrbGemList; // 0x248
	private UICamera gemScrollCamera; // 0x250
	private GemUsePopWindow gemPopUpWindow; // 0x258
	private UIItemProperty gemPropertyLabel; // 0x260
	private UIScrollWindow itemListWindow; // 0x268
	private UIIruna2Anchor itemListAnchor; // 0x270
	private bool inputLock; // 0x278
	private bool isMatching; // 0x279
	private bool isUserCheckMatching; // 0x27A
	private bool isBeforeUserCheckMatching; // 0x27B
	private UINaCollaborationEnterBasePanel bossSymbolPanel; // 0x280
	private BoxCollider pointBoostCol; // 0x288
	private int difficultyState; // 0x290
	private int difficultyStateNum; // 0x294
	private int beforeDifficultyState; // 0x298
	private bool difficultyIconSizeFlag; // 0x29C
	private bool canDifficultyChangeFlag; // 0x29D
	private byte closeDifficultyFlag; // 0x29E
	private List<int> difficultyList; // 0x2A0
	private bool isCancel; // 0x2A8
	private bool isClose; // 0x2A9
	private UINaCollaborationEnterManager.PanelState panelState; // 0x2AC
	private float connectTimer; // 0x2B0
	private int battleLevel; // 0x2B4
	private bool initCheck; // 0x2B8
	private bool popWindow; // 0x2B9
	private GameObject shortcutManager; // 0x2C0
	private bool openShortCut; // 0x2C8
	private NaCollaborationRoomData bossRoomData; // 0x2D0
	private const int CanEmployScenarioNum = 5;
	private bool isReconnected; // 0x2D8
	private NaCollaborationRoomData beforeRoomData; // 0x2E0
	private int[] bossHpList; // 0x2E8
	private UINaCollaborationEnterManager.InfoPage pageNum; // 0x2F0
	private const int getMaxMainWeaponValue = 1000;
	private const int getMinMainWeaponValue = 500;
	private const int getMainWeaponStackValue = 100;
	private readonly Color maxMainWeaponValueColor; // 0x2F4
	private readonly Color minMainWeaponValueColor; // 0x304
	private int lastTimeLeft; // 0x314
	[CompilerGenerated]
	private bool <IsEmployMercenary>k__BackingField; // 0x318

	// Properties
	private PlayerDataManager playerDataManager { get; }
	public bool ReinforceToggle { get; }
	public bool IsCancel { get; }
	public bool IsClose { get; }
	public bool IsEmployMercenary { get; set; }

	// Methods

	// RVA: 0x188E30C Offset: 0x188A30C VA: 0x188E30C
	private PlayerDataManager get_playerDataManager() { }

	// RVA: 0x188E394 Offset: 0x188A394 VA: 0x188E394
	public bool get_ReinforceToggle() { }

	// RVA: 0x188E41C Offset: 0x188A41C VA: 0x188E41C
	public bool get_IsCancel() { }

	// RVA: 0x188E424 Offset: 0x188A424 VA: 0x188E424
	public bool get_IsClose() { }

	[CompilerGenerated]
	// RVA: 0x188E42C Offset: 0x188A42C VA: 0x188E42C
	public bool get_IsEmployMercenary() { }

	[CompilerGenerated]
	// RVA: 0x188E434 Offset: 0x188A434 VA: 0x188E434
	private void set_IsEmployMercenary(bool value) { }

	// RVA: 0x188E440 Offset: 0x188A440 VA: 0x188E440
	private void Awake() { }

	// RVA: 0x188E5E4 Offset: 0x188A5E4 VA: 0x188E5E4
	private void Start() { }

	// RVA: 0x188F658 Offset: 0x188B658 VA: 0x188F658
	private void OnDestroy() { }

	// RVA: 0x188F734 Offset: 0x188B734 VA: 0x188F734
	private void Update() { }

	// RVA: 0x1890BFC Offset: 0x188CBFC VA: 0x1890BFC
	public void Initialize(int fieldId, byte roomId, Vector3 pos, float rot, EmergencyPositionData emergencyPosition, int level, int difficulty, bool isMatching, int[] bossHpList) { }

	[IteratorStateMachine(typeof(UINaCollaborationEnterManager.<InitializeThread>d__128))]
	// RVA: 0x1890CA8 Offset: 0x188CCA8 VA: 0x1890CA8
	public IEnumerator InitializeThread(int fieldId, byte roomId, Vector3 pos, float rot, EmergencyPositionData emergencyPosition, int level, int difficulty, bool isMatching) { }

	// RVA: 0x189095C Offset: 0x188C95C VA: 0x189095C
	public void OpenBossData() { }

	// RVA: 0x1890E3C Offset: 0x188CE3C VA: 0x1890E3C
	public void CheckUseItem(int itemId) { }

	// RVA: 0x18912E0 Offset: 0x188D2E0 VA: 0x18912E0
	public void BattleReady() { }

	// RVA: 0x189169C Offset: 0x188D69C VA: 0x189169C
	public void DifficultyUp() { }

	// RVA: 0x18917A8 Offset: 0x188D7A8 VA: 0x18917A8
	public void DifficultyDown() { }

	// RVA: 0x1891898 Offset: 0x188D898 VA: 0x1891898
	public void OnPointBoost() { }

	// RVA: 0x1891910 Offset: 0x188D910 VA: 0x1891910
	public void OnPointBoostWindowButton() { }

	// RVA: 0x1891948 Offset: 0x188D948 VA: 0x1891948
	public void OpenInfomation() { }

	// RVA: 0x1891A70 Offset: 0x188DA70 VA: 0x1891A70
	public void OnClickChangeInfoPage(bool isNext) { }

	// RVA: 0x1891C58 Offset: 0x188DC58 VA: 0x1891C58
	public void OpenWeaponReward() { }

	// RVA: 0x18920D0 Offset: 0x188E0D0 VA: 0x18920D0
	public void OnOpenWeaponInfo() { }

	// RVA: 0x1892160 Offset: 0x188E160 VA: 0x1892160
	public void OnOpenSpecialReward() { }

	// RVA: 0x18925A8 Offset: 0x188E5A8 VA: 0x18925A8
	public void OnGetSpecialReward() { }

	// RVA: 0x18926D8 Offset: 0x188E6D8 VA: 0x18926D8
	public void OnOkSpecialReward() { }

	// RVA: 0x189289C Offset: 0x188E89C VA: 0x189289C
	private bool CheckBossData() { }

	// RVA: 0x1892944 Offset: 0x188E944 VA: 0x1892944
	private void OpenBossDataWindow() { }

	// RVA: 0x1893A14 Offset: 0x188FA14 VA: 0x1893A14
	private GameObject CreateStatusElement(bool isDebug, Vector3 pos, int itemId, byte itemDropType, int propValTotal, int colorTotal, bool isRedText) { }

	// RVA: 0x1893D84 Offset: 0x188FD84 VA: 0x1893D84
	private string GetDropItemName(ItemDBData db, int itemId, bool isDebug, bool isRedText, int valTotal, int colorTotal) { }

	[IteratorStateMachine(typeof(UINaCollaborationEnterManager.<PopErrWindow>d__147))]
	// RVA: 0x1894094 Offset: 0x1890094 VA: 0x1894094
	private IEnumerator PopErrWindow() { }

	// RVA: 0x1894108 Offset: 0x1890108 VA: 0x1894108
	public void OpenItemList() { }

	// RVA: 0x188FB84 Offset: 0x188BB84 VA: 0x188FB84
	private void CloseShortcutPanel() { }

	// RVA: 0x1894720 Offset: 0x1890720 VA: 0x1894720
	private void CheckPartyToggle() { }

	// RVA: 0x1894758 Offset: 0x1890758 VA: 0x1894758
	private void CheckReinforceToggle() { }

	// RVA: 0x18910F8 Offset: 0x188D0F8 VA: 0x18910F8
	private void OpenGemCheckWindow(int itemId) { }

	// RVA: 0x1894790 Offset: 0x1890790 VA: 0x1894790
	private void AddOrbGemList(int itemId) { }

	// RVA: 0x188FDF4 Offset: 0x188BDF4 VA: 0x188FDF4
	private void SendRoomLobbySettingChange() { }

	// RVA: 0x188F28C Offset: 0x188B28C VA: 0x188F28C
	private void OpenMainPanel() { }

	// RVA: 0x18914EC Offset: 0x188D4EC VA: 0x18914EC
	private void BattleReadyCancel() { }

	// RVA: 0x18905FC Offset: 0x188C5FC VA: 0x18905FC
	private void BossBattleLevelText() { }

	// RVA: 0x189161C Offset: 0x188D61C VA: 0x189161C
	private byte[] GetPointBoostList() { }

	// RVA: 0x1894944 Offset: 0x1890944 VA: 0x1894944
	private void SetSelectDifficulty(out bool isCantNormal) { }

	// RVA: 0x188FE5C Offset: 0x188BE5C VA: 0x188FE5C
	private void DifficultySet() { }

	// RVA: 0x1890A3C Offset: 0x188CA3C VA: 0x1890A3C
	private void DifficultyIconScaleChange() { }

	// RVA: 0x1890860 Offset: 0x188C860 VA: 0x1890860
	private bool PartyDifficulty() { }

	// RVA: 0x189489C Offset: 0x189089C VA: 0x189489C
	private bool CheckCanEnter() { }

	// RVA: 0x1894C64 Offset: 0x1890C64 VA: 0x1894C64
	private void ChangeActiveEmployButton() { }

	[IteratorStateMachine(typeof(UINaCollaborationEnterManager.<ChangeEmployButtonPos>d__165))]
	// RVA: 0x1894D10 Offset: 0x1890D10 VA: 0x1894D10
	private IEnumerator ChangeEmployButtonPos() { }

	// RVA: 0x1894D84 Offset: 0x1890D84 VA: 0x1894D84
	private void OnEmploy() { }

	// RVA: 0x1894DBC Offset: 0x1890DBC VA: 0x1894DBC
	private void ForceClose() { }

	// RVA: 0x1894DEC Offset: 0x1890DEC VA: 0x1894DEC
	private void CopeGroupNotFound() { }

	[IteratorStateMachine(typeof(UINaCollaborationEnterManager.<ReCheckBossSymbol>d__169))]
	// RVA: 0x1894F08 Offset: 0x1890F08 VA: 0x1894F08
	private IEnumerator ReCheckBossSymbol() { }

	[IteratorStateMachine(typeof(UINaCollaborationEnterManager.<ConnectWait>d__170))]
	// RVA: 0x1890D98 Offset: 0x188CD98 VA: 0x1890D98
	private IEnumerator ConnectWait(Func<bool> checkConnect, Action callBack) { }

	// RVA: 0x18923DC Offset: 0x188E3DC VA: 0x18923DC
	private void CloseMainPanel() { }

	// RVA: 0x189194C Offset: 0x188D94C VA: 0x189194C
	private void OpenInfomationWindow() { }

	// RVA: 0x1891B04 Offset: 0x188DB04 VA: 0x1891B04
	private void ChangeInfoPage(UINaCollaborationEnterManager.InfoPage targetPage) { }

	// RVA: 0x188FCD0 Offset: 0x188BCD0 VA: 0x188FCD0
	private void UpdateInfoTimeLeft() { }

	// RVA: 0x1891C5C Offset: 0x188DC5C VA: 0x1891C5C
	private void OpenWeaponRewardWindow() { }

	// RVA: 0x1893968 Offset: 0x188F968 VA: 0x1893968
	private void ChangeSpecialRewardActive() { }

	[IteratorStateMachine(typeof(UINaCollaborationEnterManager.<ReceiveSpecialReward>d__177))]
	// RVA: 0x1892664 Offset: 0x188E664 VA: 0x1892664
	private IEnumerator ReceiveSpecialReward() { }

	[IteratorStateMachine(typeof(UINaCollaborationEnterManager.<StartSpecialRewardEffect>d__178))]
	// RVA: 0x1894F7C Offset: 0x1890F7C VA: 0x1894F7C
	private IEnumerator StartSpecialRewardEffect() { }

	// RVA: 0x1894FF0 Offset: 0x1890FF0 VA: 0x1894FF0 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x189538C Offset: 0x189138C VA: 0x189538C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1895480 Offset: 0x1891480 VA: 0x1895480 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x189562C Offset: 0x189162C VA: 0x189562C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x18958CC Offset: 0x18918CC VA: 0x18958CC
	private bool <InitializeThread>b__128_0() { }

	[CompilerGenerated]
	// RVA: 0x18958F0 Offset: 0x18918F0 VA: 0x18958F0
	private bool <ReCheckBossSymbol>b__169_0() { }

	[CompilerGenerated]
	// RVA: 0x1895914 Offset: 0x1891914 VA: 0x1895914
	private void <ReceiveSpecialReward>b__177_1() { }
}
