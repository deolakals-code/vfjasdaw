// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIScoreAttackEnterManager : UIBasePanelConnection // TypeDefIndex: 6245
{
	// Fields
	[SerializeField]
	private UIIruna2Anchor mainPanelAnchor; // 0x30
	[SerializeField]
	private UIIruna2Anchor partyPanelAnchor; // 0x38
	[SerializeField]
	private GameObject[] panelObj; // 0x40
	[SerializeField]
	private UILabel bossNameLabel; // 0x48
	[SerializeField]
	private UILabel categoryLabel; // 0x50
	[SerializeField]
	private UIImageButton infoButton; // 0x58
	[SerializeField]
	private UIImageButton rankingButton; // 0x60
	[SerializeField]
	private UIImageButton readyButton; // 0x68
	[SerializeField]
	private UILabel readyButtonLabel; // 0x70
	[SerializeField]
	private GameObject[] partyMemberObj; // 0x78
	[SerializeField]
	private UILabel bossStatusLabel; // 0x80
	[SerializeField]
	[Header("DropStatus")]
	private UIScrollWindow statusScrollWindow; // 0x88
	[SerializeField]
	private GameObject statusScrollElement; // 0x90
	[SerializeField]
	private GameObject statusPropElement; // 0x98
	[SerializeField]
	private UISprite[] dropSettingIcon; // 0xA0
	[SerializeField]
	private UIIcon dropItemIcon; // 0xA8
	[SerializeField]
	private UILabel dropItemLabel; // 0xB0
	[SerializeField]
	private GameObject statusExDropElement; // 0xB8
	[SerializeField]
	private GameObject statusExPlusElement; // 0xC0
	[SerializeField]
	private GameObject lineElement; // 0xC8
	[SerializeField]
	private GameObject popUpWindow; // 0xD0
	[SerializeField]
	private UILabel popUpWindowTitleLabel; // 0xD8
	[SerializeField]
	private UILabel popUpWindowMessageLabel; // 0xE0
	private UIScoreAttackEnterManager.PanelState panelState; // 0xE8
	private GameObject shortcutManager; // 0xF0
	private bool openShortcut; // 0xF8
	private UIScoreAttackEnterBasePanel enterBasePanel; // 0x100
	private bool isInit; // 0x108
	private ScoreAttackRoomData roomData; // 0x110
	private float connectTimer; // 0x118
	private EnemyTextManager enemyTextManager; // 0x120
	private bool isSolo; // 0x128
	private ScoreAttackBossData bossData; // 0x130
	private UIScoreAttackRankingManager rankingManager; // 0x138
	private Action popWindowCallBack; // 0x140
	[CompilerGenerated]
	private bool <IsCancel>k__BackingField; // 0x148
	[CompilerGenerated]
	private bool <IsClose>k__BackingField; // 0x149

	// Properties
	public bool IsCancel { get; set; }
	public bool IsClose { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x18C9290 Offset: 0x18C5290 VA: 0x18C9290
	public bool get_IsCancel() { }

	[CompilerGenerated]
	// RVA: 0x18C9298 Offset: 0x18C5298 VA: 0x18C9298
	private void set_IsCancel(bool value) { }

	[CompilerGenerated]
	// RVA: 0x18C92A4 Offset: 0x18C52A4 VA: 0x18C92A4
	public bool get_IsClose() { }

	[CompilerGenerated]
	// RVA: 0x18C92AC Offset: 0x18C52AC VA: 0x18C92AC
	private void set_IsClose(bool value) { }

	// RVA: 0x18C92B8 Offset: 0x18C52B8 VA: 0x18C92B8
	private void Awake() { }

	// RVA: 0x18C9440 Offset: 0x18C5440 VA: 0x18C9440
	private void Start() { }

	// RVA: 0x18C96B4 Offset: 0x18C56B4 VA: 0x18C96B4
	private void Update() { }

	// RVA: 0x18C9E2C Offset: 0x18C5E2C VA: 0x18C9E2C
	private void OnDestroy() { }

	// RVA: 0x18C9E84 Offset: 0x18C5E84 VA: 0x18C9E84
	public void Initialize(ScoreAttackRoomData roomData, ScoreAttackBossData bossData, EmergencyPositionData emergency, bool isIgnoreRotation = False) { }

	// RVA: 0x18CA14C Offset: 0x18C614C VA: 0x18CA14C
	public void OnClickRanking() { }

	// RVA: 0x18CA720 Offset: 0x18C6720 VA: 0x18CA720
	public void OnOpenBossData() { }

	// RVA: 0x18CA728 Offset: 0x18C6728 VA: 0x18CA728
	public void OnBattleReady() { }

	// RVA: 0x18CA890 Offset: 0x18C6890 VA: 0x18CA890
	public void OnClickPopUpWindowButton() { }

	// RVA: 0x18CA918 Offset: 0x18C6918 VA: 0x18CA918
	private void UIInit() { }

	// RVA: 0x18CA440 Offset: 0x18C6440 VA: 0x18CA440
	private void ChangePanel(UIScoreAttackEnterManager.PanelState state) { }

	// RVA: 0x18C9C20 Offset: 0x18C5C20 VA: 0x18C9C20
	private void CloseShortcutPanel() { }

	// RVA: 0x18C9CF8 Offset: 0x18C5CF8 VA: 0x18C9CF8
	private void BattleReadyCancel() { }

	// RVA: 0x18C9DB8 Offset: 0x18C5DB8 VA: 0x18C9DB8
	private void ReturnPreviousState() { }

	// RVA: 0x18C958C Offset: 0x18C558C VA: 0x18C958C
	private void SetLeftButtonType(UITopButtonBase.ActionSystemType type) { }

	// RVA: 0x18C9620 Offset: 0x18C5620 VA: 0x18C9620
	private void SetRightButtonType(UITopButtonBase.ActionSystemType type) { }

	// RVA: 0x18CAC48 Offset: 0x18C6C48 VA: 0x18CAC48
	private void OpenBossDataWindow() { }

	// RVA: 0x18CB238 Offset: 0x18C7238 VA: 0x18CB238
	private void PopUpWindow(string title, string message, Action callBack) { }

	// RVA: 0x18CB2A4 Offset: 0x18C72A4 VA: 0x18CB2A4 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x18CB4E0 Offset: 0x18C74E0 VA: 0x18CB4E0 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18CB614 Offset: 0x18C7614 VA: 0x18CB614 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x18CB708 Offset: 0x18C7708 VA: 0x18CB708
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x18CB7C8 Offset: 0x18C77C8 VA: 0x18CB7C8
	private void <OnClickRanking>b__49_0() { }
}
