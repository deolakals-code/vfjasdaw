// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UITreasureHuntEnterManager : UIBasePanel // TypeDefIndex: 6355
{
	// Fields
	[SerializeField]
	private GameObject[] mainViewPanels; // 0x30
	[SerializeField]
	private UIIruna2Anchor mainViewAnchor; // 0x38
	[SerializeField]
	private GameObject partyNamePanel; // 0x40
	private UIIruna2Anchor partyNameAnchor; // 0x48
	[SerializeField]
	private GameObject[] frameObj; // 0x50
	[SerializeField]
	private UILabel recommLevelLabel; // 0x58
	[SerializeField]
	private UIImageButton enterButton; // 0x60
	[SerializeField]
	private UILabel enterLabel; // 0x68
	[SerializeField]
	private GameObject[] partyMemberObj; // 0x70
	protected UIPartyMember[] partyMemberData; // 0x78
	protected TweenPosition[] partyMemberEffect; // 0x80
	[SerializeField]
	private GameObject topObj; // 0x88
	[SerializeField]
	private GameObject centerTopObj; // 0x90
	[SerializeField]
	private GameObject bottomObj; // 0x98
	[SerializeField]
	private GameObject creditObj; // 0xA0
	[SerializeField]
	private GameObject errLabel; // 0xA8
	[SerializeField]
	private GameObject errBagFullLabel; // 0xB0
	[SerializeField]
	private UILabel fieldNameLabel; // 0xB8
	[SerializeField]
	private UILabel creditLabel; // 0xC0
	[SerializeField]
	private UILabel creditMessageLabel; // 0xC8
	[SerializeField]
	private GameObject creditHelpButtonObj; // 0xD0
	[SerializeField]
	private GameObject gemSprite; // 0xD8
	[SerializeField]
	private UIImageButton recoveryButton; // 0xE0
	[SerializeField]
	private UILabel recoveryButtonLabel; // 0xE8
	[SerializeField]
	private UIImageButton mainDropButton; // 0xF0
	[SerializeField]
	private UIScrollWindow dropScrollWindow; // 0xF8
	[SerializeField]
	private GameObject dropElementObj; // 0x100
	[SerializeField]
	private UIIcon dropItemIcon; // 0x108
	[SerializeField]
	private UILabel dropItemLabel; // 0x110
	[SerializeField]
	private UIImageButton mainBoostButton; // 0x118
	[SerializeField]
	private UIScrollWindow boostScrollWindow; // 0x120
	[SerializeField]
	private GameObject boostElementObj; // 0x128
	[SerializeField]
	private GameObject buttonObject; // 0x130
	[SerializeField]
	private UILabel boostWindowMessageLabel; // 0x138
	[SerializeField]
	private GameObject boostButtonIcon; // 0x140
	[CompilerGenerated]
	private bool <IsCancel>k__BackingField; // 0x148
	[CompilerGenerated]
	private bool <IsClose>k__BackingField; // 0x149
	[CompilerGenerated]
	private bool <IsOrbShop>k__BackingField; // 0x14A
	private static readonly float dropListElementHeight; // 0x0
	private static readonly Vector3[] CreditObjectPosition; // 0x8
	private static readonly Vector3[] CreditLabelPosition; // 0x10
	private static readonly Vector3[] CreditMessageLabelPosition; // 0x18
	private static readonly int TrialPointMax; // 0x20
	private static readonly int BoostUseMax; // 0x24
	private UITreasureHuntEnterManager.PanelState panelState; // 0x14C
	private bool isEnterErr; // 0x150
	private UIPopBaseWindow popWindow; // 0x158
	private UIPopWindow helpPopWindow; // 0x160
	private UITreasureHuntEnterBasePanel treasureHuntEnterBasePanel; // 0x168
	private bool isInit; // 0x170
	private float connectTimer; // 0x174
	private PlayerDataManager playerDataManager; // 0x178
	private TreasureHuntRoomData treasureHuntRoomData; // 0x180
	private int fieldId; // 0x188
	private byte roomId; // 0x18C
	private int recommLevel; // 0x190
	private byte trialPoint; // 0x194
	private byte useTrialPoint; // 0x195
	private TreasureHuntRewardData itemData; // 0x198
	private GameObject shortcutManager; // 0x1A0
	private bool openShortcut; // 0x1A8
	private float loadingTimer; // 0x1AC
	private GameObject loadingObject; // 0x1B0
	private ItemTextManager itemTextManager; // 0x1B8
	private int recoveryType; // 0x1C0
	private List<byte> selectionBonusList; // 0x1C8
	private List<UITreasureHuntBoostButton> boostBuuttonList; // 0x1D0
	private GameObject[] pointObjectList; // 0x1D8
	private bool isBoostButtonEnabled; // 0x1E0
	private int orbItemNum; // 0x1E4
	private bool orbUseFlag; // 0x1E8
	private RegistletManager registletManager; // 0x1F0
	private RegistletTextManager registletTextManager; // 0x1F8

	// Properties
	public bool IsCancel { get; set; }
	public bool IsClose { get; set; }
	public bool IsOrbShop { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x18ED048 Offset: 0x18E9048 VA: 0x18ED048
	public bool get_IsCancel() { }

	[CompilerGenerated]
	// RVA: 0x18ED050 Offset: 0x18E9050 VA: 0x18ED050
	private void set_IsCancel(bool value) { }

	[CompilerGenerated]
	// RVA: 0x18ED05C Offset: 0x18E905C VA: 0x18ED05C
	public bool get_IsClose() { }

	[CompilerGenerated]
	// RVA: 0x18ED064 Offset: 0x18E9064 VA: 0x18ED064
	private void set_IsClose(bool value) { }

	[CompilerGenerated]
	// RVA: 0x18ED070 Offset: 0x18E9070 VA: 0x18ED070
	public bool get_IsOrbShop() { }

	[CompilerGenerated]
	// RVA: 0x18ED078 Offset: 0x18E9078 VA: 0x18ED078
	private void set_IsOrbShop(bool value) { }

	// RVA: 0x18ED084 Offset: 0x18E9084 VA: 0x18ED084
	private void Awake() { }

	// RVA: 0x18ED228 Offset: 0x18E9228 VA: 0x18ED228
	private void Start() { }

	// RVA: 0x18ED3DC Offset: 0x18E93DC VA: 0x18ED3DC
	private void OnDestroy() { }

	// RVA: 0x18ED434 Offset: 0x18E9434 VA: 0x18ED434
	public void Initialize(int fieldId, byte roomId, int level, Vector3 pos, float rot, EmergencyPositionData emergency) { }

	[IteratorStateMachine(typeof(UITreasureHuntEnterManager.<WaitRoomData>d__87))]
	// RVA: 0x18ED858 Offset: 0x18E9858 VA: 0x18ED858
	private IEnumerator WaitRoomData() { }

	// RVA: 0x18ED8CC Offset: 0x18E98CC VA: 0x18ED8CC
	private void UIinit() { }

	// RVA: 0x18EEC38 Offset: 0x18EAC38 VA: 0x18EEC38
	private void Update() { }

	// RVA: 0x18EF4DC Offset: 0x18EB4DC VA: 0x18EF4DC
	public byte[] GetSelectionBoostList() { }

	// RVA: 0x18EE2F4 Offset: 0x18EA2F4 VA: 0x18EE2F4
	public void TrialPointUpdate() { }

	// RVA: 0x18EF554 Offset: 0x18EB554 VA: 0x18EF554
	private void BattleReady() { }

	// RVA: 0x18EF3B0 Offset: 0x18EB3B0 VA: 0x18EF3B0
	private void BattleReadyCancel() { }

	// RVA: 0x18ED2B4 Offset: 0x18E92B4 VA: 0x18ED2B4
	private void SetLeftButtonType(UITopButtonBase.ActionSystemType type) { }

	// RVA: 0x18ED348 Offset: 0x18E9348 VA: 0x18ED348
	private void SetRightButtonType(UITopButtonBase.ActionSystemType type) { }

	// RVA: 0x18EF79C Offset: 0x18EB79C VA: 0x18EF79C
	private void OnDrop() { }

	// RVA: 0x18EF7A4 Offset: 0x18EB7A4 VA: 0x18EF7A4
	private void OnBoost() { }

	// RVA: 0x18EF7AC Offset: 0x18EB7AC VA: 0x18EF7AC
	private void OnPointRecovery() { }

	[IteratorStateMachine(typeof(UITreasureHuntEnterManager.<OpenPointRecoveryWindow>d__99))]
	// RVA: 0x18EF874 Offset: 0x18EB874 VA: 0x18EF874
	private IEnumerator OpenPointRecoveryWindow() { }

	[IteratorStateMachine(typeof(UITreasureHuntEnterManager.<CheckOrbItemNum>d__100))]
	// RVA: 0x18EF8E8 Offset: 0x18EB8E8 VA: 0x18EF8E8
	private IEnumerator CheckOrbItemNum() { }

	// RVA: 0x18EF95C Offset: 0x18EB95C VA: 0x18EF95C
	private void OnRecoveryPopWindowButton() { }

	[IteratorStateMachine(typeof(UITreasureHuntEnterManager.<RecoveryTrialPoint>d__102))]
	// RVA: 0x18EFA6C Offset: 0x18EBA6C VA: 0x18EFA6C
	private IEnumerator RecoveryTrialPoint() { }

	// RVA: 0x18EFAE0 Offset: 0x18EBAE0 VA: 0x18EFAE0
	private void OnBoostSelectButton(int index) { }

	// RVA: 0x18EFEC0 Offset: 0x18EBEC0 VA: 0x18EFEC0
	private void OnSetBoostMessage(int index) { }

	// RVA: 0x18EFF60 Offset: 0x18EBF60 VA: 0x18EFF60
	private void OnCreditHelpButton() { }

	// RVA: 0x18EE1AC Offset: 0x18EA1AC VA: 0x18EE1AC
	private void ChangePanel(UITreasureHuntEnterManager.PanelState panelState) { }

	// RVA: 0x18F075C Offset: 0x18EC75C VA: 0x18F075C
	private void SetDropItemList() { }

	// RVA: 0x18F08A4 Offset: 0x18EC8A4 VA: 0x18F08A4
	private float DropCategoryBox(float y, TreasureHuntTreasureRankType rank, RewardData[] rewardItem) { }

	// RVA: 0x18F09C8 Offset: 0x18EC9C8 VA: 0x18F09C8
	private float AddDropCategoryButton(float y, int rank, int itemNum) { }

	// RVA: 0x18F0C20 Offset: 0x18ECC20 VA: 0x18F0C20
	private GameObject CreateDropElement(Vector3 pos, RewardData data) { }

	// RVA: 0x18F0D84 Offset: 0x18ECD84 VA: 0x18F0D84
	private GameObject CreateDropCategoryElement(Vector3 pos, string text, string name) { }

	// RVA: 0x18F0EF4 Offset: 0x18ECEF4 VA: 0x18F0EF4
	private string GetDropItemName(RewardType type, int rewardValue) { }

	// RVA: 0x18F0D40 Offset: 0x18ECD40 VA: 0x18F0D40
	private Color GetBoxColor(int rank) { }

	// RVA: 0x18EE7D4 Offset: 0x18EA7D4 VA: 0x18EE7D4
	private void AddBoostButton() { }

	// RVA: 0x18F11B8 Offset: 0x18ED1B8 VA: 0x18F11B8
	private void ClosePopWindow(bool isHelp) { }

	// RVA: 0x18F017C Offset: 0x18EC17C VA: 0x18F017C
	private void CreditObjectsUpdate() { }

	// RVA: 0x18EE66C Offset: 0x18EA66C VA: 0x18EE66C
	private void SetTrialPointLabel() { }

	[IteratorStateMachine(typeof(UITreasureHuntEnterManager.<ConnectWait>d__118))]
	// RVA: 0x18F12D8 Offset: 0x18ED2D8 VA: 0x18F12D8
	private IEnumerator ConnectWait(OrbManager.ConnectFlag connectFlag) { }

	// RVA: 0x18EF2D8 Offset: 0x18EB2D8 VA: 0x18EF2D8
	private void CloseShortcutPanel() { }

	// RVA: 0x18F135C Offset: 0x18ED35C VA: 0x18F135C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x18F14F8 Offset: 0x18ED4F8 VA: 0x18F14F8 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18F15F0 Offset: 0x18ED5F0 VA: 0x18F15F0 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x18F16D4 Offset: 0x18ED6D4 VA: 0x18F16D4
	public void .ctor() { }

	// RVA: 0x18F186C Offset: 0x18ED86C VA: 0x18F186C
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x18F19E4 Offset: 0x18ED9E4 VA: 0x18F19E4
	private void <OnCreditHelpButton>b__105_0() { }
}
