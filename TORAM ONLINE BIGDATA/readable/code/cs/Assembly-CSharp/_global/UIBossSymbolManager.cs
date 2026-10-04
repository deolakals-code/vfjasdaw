// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBossSymbolManager : UIBasePanel // TypeDefIndex: 6390
{
	// Fields
	private PlayerDataManager playerData; // 0x30
	private Dictionary<int, UIBossSymbolManager.GemData> gemList; // 0x38
	private UIBossSymbolManager.GemData nowSelectGemData; // 0x40
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
	private UIScrollPanel gemPropertyPlate; // 0x110
	private bool inputLock; // 0x118
	private UIBossSymbolBasePanel bossSymbolPanel; // 0x120
	[SerializeField]
	private UILabel bossBattleLevel; // 0x128
	[SerializeField]
	private GameObject rightDifficultyButton; // 0x130
	[SerializeField]
	private GameObject leftDifficultyButton; // 0x138
	[SerializeField]
	private UILabel difficultyLabel; // 0x140
	[SerializeField]
	private UILabel difficultyEngLabel; // 0x148
	[SerializeField]
	private UISprite[] diffIconBaseSprite; // 0x150
	[SerializeField]
	private UISprite[] diffIconSprite; // 0x158
	[SerializeField]
	private GameObject difficultyObj; // 0x160
	[SerializeField]
	private GameObject fixDifficultyObj; // 0x168
	[SerializeField]
	private UIScrollWindow statusScrollWindow; // 0x170
	[SerializeField]
	private GameObject statusScrollElement; // 0x178
	[SerializeField]
	private GameObject statusPropElement; // 0x180
	[SerializeField]
	private UISprite[] dropSettingIcon; // 0x188
	[SerializeField]
	private UIIcon dropItemIcon; // 0x190
	[SerializeField]
	private UILabel dropItemLabel; // 0x198
	[SerializeField]
	private GameObject statusExDropElement; // 0x1A0
	[SerializeField]
	private GameObject statusExPlusElement; // 0x1A8
	[SerializeField]
	private GameObject lineElement; // 0x1B0
	[SerializeField]
	private GameObject employButton; // 0x1B8
	private int difficultyState; // 0x1C0
	private int difficultyStateNum; // 0x1C4
	private int beforeDifficultyState; // 0x1C8
	private bool diffIconSizeFlg; // 0x1CC
	private bool canDifficultyChangeFlag; // 0x1CD
	private byte closeDifficultyFlag; // 0x1CE
	private List<int> difficultyList; // 0x1D0
	private bool cancel; // 0x1D8
	private bool close; // 0x1D9
	private UIBossSymbolManager.PanelState panelState; // 0x1DC
	private ItemTextManager itemTextManager; // 0x1E0
	private float connectTimer; // 0x1E8
	private int battleLevel; // 0x1EC
	private bool initCheck; // 0x1F0
	private bool popWindow; // 0x1F1
	private GameObject shortcutManager; // 0x1F8
	private bool openShortcut; // 0x200
	private BossRoomData bossRoomData; // 0x208
	[CompilerGenerated]
	private bool <IsEmployMercenary>k__BackingField; // 0x210
	private const int CanEmployScenarioNum = 5;
	private bool isReconnected; // 0x211
	private BossRoomData beforeRoomData; // 0x218
	private int[] bossHpList; // 0x220

	// Properties
	private PlayerDataManager playerDataManager { get; }
	public bool ReinforceToggle { get; }
	public bool IsCancel { get; }
	public bool IsClose { get; }
	public bool IsEmployMercenary { get; set; }

	// Methods

	// RVA: 0x1919EE4 Offset: 0x1915EE4 VA: 0x1919EE4
	private PlayerDataManager get_playerDataManager() { }

	// RVA: 0x1919F68 Offset: 0x1915F68 VA: 0x1919F68
	public bool get_ReinforceToggle() { }

	// RVA: 0x1919F84 Offset: 0x1915F84 VA: 0x1919F84
	public bool get_IsCancel() { }

	// RVA: 0x1919F8C Offset: 0x1915F8C VA: 0x1919F8C
	public bool get_IsClose() { }

	[CompilerGenerated]
	// RVA: 0x1919F94 Offset: 0x1915F94 VA: 0x1919F94
	public bool get_IsEmployMercenary() { }

	[CompilerGenerated]
	// RVA: 0x1919F9C Offset: 0x1915F9C VA: 0x1919F9C
	private void set_IsEmployMercenary(bool value) { }

	// RVA: 0x1919FA8 Offset: 0x1915FA8 VA: 0x1919FA8
	private void Awake() { }

	// RVA: 0x1919FB0 Offset: 0x1915FB0 VA: 0x1919FB0
	private void Start() { }

	// RVA: 0x191B100 Offset: 0x1917100 VA: 0x191B100
	private void OnDestroy() { }

	// RVA: 0x191B1DC Offset: 0x19171DC VA: 0x191B1DC
	public void Initialize(int fieldId, byte roomId, Vector3 pos, float rot, EmergencyPositionData emergencyPosition, int level, int difficulty, bool canDiffFlag, string bossText, byte closeDifficulty, int[] bossHpList, bool itemButtonHideFlag) { }

	// RVA: 0x191C940 Offset: 0x1918940 VA: 0x191C940
	private void ReceiveCheckBossSymbol() { }

	[IteratorStateMachine(typeof(UIBossSymbolManager.<PopErrWindow>d__92))]
	// RVA: 0x191CD5C Offset: 0x1918D5C VA: 0x191CD5C
	private IEnumerator PopErrWindow() { }

	// RVA: 0x191CDD0 Offset: 0x1918DD0 VA: 0x191CDD0
	private void Update() { }

	// RVA: 0x191D1F0 Offset: 0x19191F0 VA: 0x191D1F0
	private void CloseShortcutPanel() { }

	// RVA: 0x191DC80 Offset: 0x1919C80 VA: 0x191DC80
	private void CheckPartyToggle() { }

	// RVA: 0x191DCB8 Offset: 0x1919CB8 VA: 0x191DCB8
	private void CheckReinforceToggle() { }

	// RVA: 0x191D414 Offset: 0x1919414 VA: 0x191D414
	private void OpenBossData() { }

	// RVA: 0x191DCF0 Offset: 0x1919CF0 VA: 0x191DCF0
	private bool CheckBossData() { }

	// RVA: 0x191DD9C Offset: 0x1919D9C VA: 0x191DD9C
	private void OpenBossDataWindow() { }

	// RVA: 0x191EB44 Offset: 0x191AB44 VA: 0x191EB44
	private GameObject CreateStatusElement(bool isDebug, Vector3 pos, int itemId, byte itemDropType, int propValTotal, int colorTotal, bool isRedText) { }

	// RVA: 0x191EEE0 Offset: 0x191AEE0 VA: 0x191EEE0
	private string GetDropItemName(ItemDBData db, int itemId, bool isDebug, bool isRedText, int valTotal, int colorTotal) { }

	// RVA: 0x191D6B4 Offset: 0x19196B4 VA: 0x191D6B4
	private void OpenItemList() { }

	// RVA: 0x19198EC Offset: 0x19158EC VA: 0x19198EC
	public void CheckUseItem(int itemId) { }

	// RVA: 0x191F1F0 Offset: 0x191B1F0 VA: 0x191F1F0
	private void OpenGemCheckWindow(int itemId) { }

	// RVA: 0x191F3F8 Offset: 0x191B3F8 VA: 0x191F3F8
	private void AddOrbGemList(int itemId) { }

	// RVA: 0x191AE64 Offset: 0x1916E64 VA: 0x191AE64
	private void OpenMainPanel() { }

	// RVA: 0x191F66C Offset: 0x191B66C VA: 0x191F66C
	private void BattleReady() { }

	// RVA: 0x191F834 Offset: 0x191B834 VA: 0x191F834
	private void BattleReadyCancel() { }

	// RVA: 0x191B978 Offset: 0x1917978 VA: 0x191B978
	private void BossBattleLevelText() { }

	// RVA: 0x191BC68 Offset: 0x1917C68 VA: 0x191BC68
	private void SetSelectDifficulty(out bool isCantNormal) { }

	// RVA: 0x191BF88 Offset: 0x1917F88 VA: 0x191BF88
	private void DifficultySet() { }

	// RVA: 0x191D4F4 Offset: 0x19194F4 VA: 0x191D4F4
	private void DifficultyIconScaleChange() { }

	// RVA: 0x191D318 Offset: 0x1919318 VA: 0x191D318
	private bool PartyDifficulty() { }

	// RVA: 0x191F8FC Offset: 0x191B8FC VA: 0x191F8FC
	private void DifficultyUp() { }

	// RVA: 0x191FA04 Offset: 0x191BA04 VA: 0x191FA04
	private void DifficultyDown() { }

	// RVA: 0x191F520 Offset: 0x191B520 VA: 0x191F520
	private bool CheckCanEnter() { }

	// RVA: 0x191C7AC Offset: 0x19187AC VA: 0x191C7AC
	private void ChangeActiveEmployButton() { }

	[IteratorStateMachine(typeof(UIBossSymbolManager.<ChangeEmployButtonPos>d__118))]
	// RVA: 0x191FAF0 Offset: 0x191BAF0 VA: 0x191FAF0
	private IEnumerator ChangeEmployButtonPos() { }

	// RVA: 0x191FB64 Offset: 0x191BB64 VA: 0x191FB64
	private void OnEmploy() { }

	// RVA: 0x191FB9C Offset: 0x191BB9C VA: 0x191FB9C
	public void ForceClose() { }

	// RVA: 0x191C9B8 Offset: 0x19189B8 VA: 0x191C9B8
	public void CopeGroupNotFound() { }

	// RVA: 0x191FBCC Offset: 0x191BBCC VA: 0x191FBCC
	private void ReceiveReconnectCheck() { }

	[IteratorStateMachine(typeof(UIBossSymbolManager.<ConnectWait>d__123))]
	// RVA: 0x191C89C Offset: 0x191889C VA: 0x191C89C
	private IEnumerator ConnectWait(Func<bool> checkConnect, Action callBack) { }

	// RVA: 0x191FC04 Offset: 0x191BC04 VA: 0x191FC04 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x191FE30 Offset: 0x191BE30 VA: 0x191FE30 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x191FF24 Offset: 0x191BF24 VA: 0x191FF24 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x1920064 Offset: 0x191C064 VA: 0x1920064
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1920264 Offset: 0x191C264 VA: 0x1920264
	private bool <Initialize>b__90_0() { }

	[CompilerGenerated]
	// RVA: 0x1920288 Offset: 0x191C288 VA: 0x1920288
	private bool <CopeGroupNotFound>b__121_0() { }
}
