// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHighRaidEnterManager : UIBasePanel // TypeDefIndex: 5794
{
	// Fields
	[SerializeField]
	private UIIruna2Anchor mainPanelAnchor; // 0x30
	[SerializeField]
	private UIIruna2Anchor partyPanelAnchor; // 0x38
	[SerializeField]
	private GameObject[] panelObj; // 0x40
	[SerializeField]
	private UILabel recommLevelLabel; // 0x48
	[SerializeField]
	private UILabel bossNameLabel; // 0x50
	[SerializeField]
	private GameObject[] difficultSelectButtons; // 0x58
	[SerializeField]
	private UILabel difflicultNumLabel; // 0x60
	[SerializeField]
	private UIImageButton infoButton; // 0x68
	[SerializeField]
	private UIImageButton readyButton; // 0x70
	[SerializeField]
	private UILabel readyButtonLabel; // 0x78
	[SerializeField]
	private GameObject[] partyMemberObj; // 0x80
	[SerializeField]
	private UILabel bossStatusLabel; // 0x88
	[SerializeField]
	private GameObject centerPanelObj; // 0x90
	[SerializeField]
	private GameObject errLabel; // 0x98
	[SerializeField]
	private GameObject employButton; // 0xA0
	[SerializeField]
	private UIScrollWindow statusScrollWindow; // 0xA8
	[SerializeField]
	private GameObject statusScrollElement; // 0xB0
	[SerializeField]
	private GameObject statusPropElement; // 0xB8
	[SerializeField]
	private UISprite[] dropSettingIcon; // 0xC0
	[SerializeField]
	private UIIcon dropItemIcon; // 0xC8
	[SerializeField]
	private UILabel dropItemLabel; // 0xD0
	[SerializeField]
	private GameObject statusExDropElement; // 0xD8
	[SerializeField]
	private GameObject statusExPlusElement; // 0xE0
	[SerializeField]
	private GameObject lineElement; // 0xE8
	[SerializeField]
	private UISprite gemPanelIcon; // 0xF0
	[SerializeField]
	private UILabel itemPopUpLabel; // 0xF8
	[SerializeField]
	private UIItemProperty gemPropertyLabel; // 0x100
	[SerializeField]
	private GameObject itemButton; // 0x108
	[SerializeField]
	private UIImageButton[] menuButtons; // 0x110
	[CompilerGenerated]
	private bool <IsCancel>k__BackingField; // 0x118
	[CompilerGenerated]
	private bool <IsClose>k__BackingField; // 0x119
	[CompilerGenerated]
	private object <DifficultyState>k__BackingField; // 0x120
	[CompilerGenerated]
	private bool <IsEmployMercenary>k__BackingField; // 0x128
	private UIHighRaidEnterManager.PanelState panelState; // 0x12C
	private GameObject shortcutManager; // 0x130
	private bool openShortcut; // 0x138
	private PlayerDataManager playerDataManager; // 0x140
	private UIHighRaidEnterBasePanel enterBasePanel; // 0x148
	private bool isInit; // 0x150
	private HighRaidRoomData roomData; // 0x158
	private float loadingTimer; // 0x160
	private GameObject loadingObject; // 0x168
	private float connectTimer; // 0x170
	private short difficulty; // 0x174
	private short beforeDifficulty; // 0x176
	private short baseDifficulty; // 0x178
	private ItemTextManager itemTextManager; // 0x180
	private EnemyTextManager enemyTextManager; // 0x188
	private const int difficultyNum = 5;
	private int minDifficulty; // 0x190
	private int maxDifficulty; // 0x194
	private const int basePoint = 100;
	private const int basePartsPoint = 30;
	private bool isPartner; // 0x198
	private byte highRaidNo; // 0x199
	private const int CanEmployScenarioNum = 5;
	private Dictionary<int, UIHighRaidEnterManager.GemData> gemList; // 0x1A0
	private UIHighRaidEnterManager.GemData nowSelectGemData; // 0x1A8
	private List<int> selectedGemList; // 0x1B0
	private List<int> selectedOrbGemList; // 0x1B8
	private UICamera gemScrollCamera; // 0x1C0
	private GemUsePopWindow gemPopUpWindow; // 0x1C8
	private UIScrollWindow itemListWindow; // 0x1D0
	private UIIruna2Anchor itemListWindowAnchor; // 0x1D8

	// Properties
	public bool IsCancel { get; set; }
	public bool IsClose { get; set; }
	public object DifficultyState { get; set; }
	public bool IsEmployMercenary { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x17EEE84 Offset: 0x17EAE84 VA: 0x17EEE84
	public bool get_IsCancel() { }

	[CompilerGenerated]
	// RVA: 0x17EEE8C Offset: 0x17EAE8C VA: 0x17EEE8C
	private void set_IsCancel(bool value) { }

	[CompilerGenerated]
	// RVA: 0x17EEE98 Offset: 0x17EAE98 VA: 0x17EEE98
	public bool get_IsClose() { }

	[CompilerGenerated]
	// RVA: 0x17EEEA0 Offset: 0x17EAEA0 VA: 0x17EEEA0
	private void set_IsClose(bool value) { }

	[CompilerGenerated]
	// RVA: 0x17EEEAC Offset: 0x17EAEAC VA: 0x17EEEAC
	public object get_DifficultyState() { }

	[CompilerGenerated]
	// RVA: 0x17EEEB4 Offset: 0x17EAEB4 VA: 0x17EEEB4
	private void set_DifficultyState(object value) { }

	[CompilerGenerated]
	// RVA: 0x17EEEC4 Offset: 0x17EAEC4 VA: 0x17EEEC4
	public bool get_IsEmployMercenary() { }

	[CompilerGenerated]
	// RVA: 0x17EEECC Offset: 0x17EAECC VA: 0x17EEECC
	private void set_IsEmployMercenary(bool value) { }

	// RVA: 0x17EEED8 Offset: 0x17EAED8 VA: 0x17EEED8
	private void Awake() { }

	// RVA: 0x17EF0FC Offset: 0x17EB0FC VA: 0x17EF0FC
	private void Start() { }

	// RVA: 0x17EF380 Offset: 0x17EB380 VA: 0x17EF380
	private void Update() { }

	// RVA: 0x17EFC80 Offset: 0x17EBC80 VA: 0x17EFC80
	private void OnDestroy() { }

	// RVA: 0x17EFCD8 Offset: 0x17EBCD8 VA: 0x17EFCD8
	public void Initialize(byte highRaidNo, EmergencyPositionData emergency) { }

	// RVA: 0x17F0CDC Offset: 0x17ECCDC VA: 0x17F0CDC
	public void OnDifficultyDown() { }

	// RVA: 0x17F0CFC Offset: 0x17ECCFC VA: 0x17F0CFC
	public void OnDifficultyUp() { }

	// RVA: 0x17F0D1C Offset: 0x17ECD1C VA: 0x17F0D1C
	public void OnDifficultySDown() { }

	// RVA: 0x17F0D3C Offset: 0x17ECD3C VA: 0x17F0D3C
	public void OnDifficultySUp() { }

	// RVA: 0x17F0D5C Offset: 0x17ECD5C VA: 0x17F0D5C
	public void OnOpenBossData() { }

	// RVA: 0x17F0ED4 Offset: 0x17ECED4 VA: 0x17F0ED4
	public void OnBattleReady() { }

	// RVA: 0x17F1178 Offset: 0x17ED178 VA: 0x17F1178
	public void OnEmploy() { }

	// RVA: 0x17F11B0 Offset: 0x17ED1B0 VA: 0x17F11B0
	public void OnItemList() { }

	[IteratorStateMachine(typeof(UIHighRaidEnterManager.<WaitRoomData>d__91))]
	// RVA: 0x17EFE90 Offset: 0x17EBE90 VA: 0x17EFE90
	private IEnumerator WaitRoomData() { }

	// RVA: 0x17EFF04 Offset: 0x17EBF04 VA: 0x17EFF04
	private void UIInit() { }

	// RVA: 0x17F0D64 Offset: 0x17ECD64 VA: 0x17F0D64
	private void ChangePanel(UIHighRaidEnterManager.PanelState panelState) { }

	// RVA: 0x17EF924 Offset: 0x17EB924 VA: 0x17EF924
	private void UpdateDifficultyLabel() { }

	// RVA: 0x17EF84C Offset: 0x17EB84C VA: 0x17EF84C
	private void CloseShortcutPanel() { }

	// RVA: 0x17EFADC Offset: 0x17EBADC VA: 0x17EFADC
	private void BattleReadyCancel() { }

	// RVA: 0x17EFBA8 Offset: 0x17EBBA8 VA: 0x17EFBA8
	private void ReturnPreviousState() { }

	// RVA: 0x17F1110 Offset: 0x17ED110 VA: 0x17F1110
	private void ChangeActiveMenuButton(bool isActive) { }

	// RVA: 0x17F11B8 Offset: 0x17ED1B8 VA: 0x17F11B8
	private void ChangeActiveEmployButton() { }

	[IteratorStateMachine(typeof(UIHighRaidEnterManager.<ChangeEmployButtonPos>d__100))]
	// RVA: 0x17F2454 Offset: 0x17EE454 VA: 0x17F2454
	private IEnumerator ChangeEmployButtonPos() { }

	// RVA: 0x17F12A4 Offset: 0x17ED2A4 VA: 0x17F12A4
	private void OpenBossDataWindow() { }

	// RVA: 0x17F24C8 Offset: 0x17EE4C8 VA: 0x17F24C8
	private GameObject CreateStatusElement(bool isDebug, Vector3 pos, int itemId, byte itemDropType, int propValTotal, int colorTotal, bool isRedText) { }

	// RVA: 0x17F2864 Offset: 0x17EE864 VA: 0x17F2864
	private string GetDropItemName(ItemDBData db, int itemId, bool isDebug, bool isRedText, int valTotal, int colorTotal) { }

	// RVA: 0x17EF258 Offset: 0x17EB258 VA: 0x17EF258
	private void SetLeftButtonType(UITopButtonBase.ActionSystemType type) { }

	// RVA: 0x17EF2EC Offset: 0x17EB2EC VA: 0x17EF2EC
	private void SetRightButtonType(UITopButtonBase.ActionSystemType type) { }

	// RVA: 0x17F1EB4 Offset: 0x17EDEB4 VA: 0x17F1EB4
	private void OpenItemList() { }

	// RVA: 0x17F2B74 Offset: 0x17EEB74 VA: 0x17F2B74
	public void CheckUseItem(int itemId) { }

	// RVA: 0x17F2E58 Offset: 0x17EEE58 VA: 0x17F2E58
	private void OpenGemCheckWindow(int itemId) { }

	// RVA: 0x17F303C Offset: 0x17EF03C VA: 0x17F303C
	private void AddOrbGemList(int itemId) { }

	// RVA: 0x17F3148 Offset: 0x17EF148 VA: 0x17F3148 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x17F3354 Offset: 0x17EF354 VA: 0x17F3354 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x17F33AC Offset: 0x17EF3AC VA: 0x17F33AC Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x17F349C Offset: 0x17EF49C VA: 0x17F349C
	public void .ctor() { }
}
