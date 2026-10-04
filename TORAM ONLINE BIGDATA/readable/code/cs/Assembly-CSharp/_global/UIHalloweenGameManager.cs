// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHalloweenGameManager : UIBasePanelConnection // TypeDefIndex: 5872
{
	// Fields
	private readonly int[] keyIconItems; // 0x30
	private readonly int[] boxIconItems; // 0x38
	private readonly int[] commandIconItems; // 0x40
	[SerializeField]
	private UIIruna2AnchorSimple[] mainAnchor; // 0x48
	[SerializeField]
	private UIIruna2AnchorSimple[] subAnchor; // 0x50
	[SerializeField]
	private UIIruna2AnchorSimple leftTopMenuAnchor; // 0x58
	[SerializeField]
	private GameObject leftTopMenuPanl; // 0x60
	[SerializeField]
	private UIIcon switchIcon; // 0x68
	[SerializeField]
	private UILabel switchIconLabel; // 0x70
	[SerializeField]
	private GameObject[] commandIcon; // 0x78
	[SerializeField]
	private UILabel[] commandIconLabel; // 0x80
	[SerializeField]
	private UISprite[] hpBar; // 0x88
	[SerializeField]
	private int hpBarW; // 0x90
	[SerializeField]
	private UILabel hpBarLabel; // 0x98
	[SerializeField]
	private TweenColor hpGaugeTweenColor; // 0xA0
	[SerializeField]
	private GameObject[] itemIcons; // 0xA8
	[SerializeField]
	private UILabel[] itemLabels; // 0xB0
	[SerializeField]
	private UILabel questLabel; // 0xB8
	[SerializeField]
	private GameObject[] keyIcons; // 0xC0
	[SerializeField]
	private GameObject windowPanel; // 0xC8
	[SerializeField]
	private UILabel timerLabel; // 0xD0
	[SerializeField]
	private UISprite timerBar; // 0xD8
	[SerializeField]
	private GameObject dropItem; // 0xE0
	[SerializeField]
	private GameObject helpWindow; // 0xE8
	[SerializeField]
	private GameObject[] helpPanel; // 0xF0
	[SerializeField]
	private GameObject[] helpArrowButton; // 0xF8
	[SerializeField]
	private GameObject[] helpTopButton; // 0x100
	[SerializeField]
	private GameObject itemWindow; // 0x108
	[SerializeField]
	private GameObject[] itemPanel; // 0x110
	[SerializeField]
	private UIMiniMapTexture[] itemMiniMapTexture; // 0x118
	[SerializeField]
	private GameObject goalWindow; // 0x120
	[SerializeField]
	private GameObject[] goalPanel; // 0x128
	[SerializeField]
	private UILabel goalMessageLabel; // 0x130
	[SerializeField]
	private GameObject resultWindow; // 0x138
	[SerializeField]
	private GameObject[] resultPanel; // 0x140
	[SerializeField]
	private UILabel[] resultScoreLabel; // 0x148
	[SerializeField]
	private UIScrollWindow dropScroll; // 0x150
	[SerializeField]
	private GameObject dropElement; // 0x158
	[SerializeField]
	private GameObject resultEffect; // 0x160
	private int helpCurrentId; // 0x168
	private bool isMenuButton; // 0x16C
	private PlayerDataManager playerDataManager; // 0x170
	protected HalloweenEventGameRoomData roomData; // 0x178
	private Halloween2024Master gameMaster; // 0x180
	private int currentAccessPoint; // 0x188
	private float chageTime; // 0x18C
	private int chageCount; // 0x190
	private float updateIconCheck; // 0x194
	private float[] hpPercent; // 0x198
	private GameObject shortcutManager; // 0x1A0
	private bool openShortcut; // 0x1A8

	// Properties
	protected virtual UIMainManager.UIElicitFlag DefaultView { get; }

	// Methods

	// RVA: 0x180F19C Offset: 0x180B19C VA: 0x180F19C Slot: 8
	protected virtual UIMainManager.UIElicitFlag get_DefaultView() { }

	// RVA: 0x180F1A4 Offset: 0x180B1A4 VA: 0x180F1A4
	private void AllActiveAnchorStartMove() { }

	// RVA: 0x180F2DC Offset: 0x180B2DC VA: 0x180F2DC
	private void AnchorReverseMove(bool isAll) { }

	// RVA: 0x180F41C Offset: 0x180B41C VA: 0x180F41C
	private void popWindow(GameObject window) { }

	// RVA: 0x180F488 Offset: 0x180B488 VA: 0x180F488
	private void closeWindow(GameObject window) { }

	[IteratorStateMachine(typeof(UIHalloweenGameManager.<Start>d__58))]
	// RVA: 0x180F55C Offset: 0x180B55C VA: 0x180F55C
	protected IEnumerator Start() { }

	// RVA: 0x180F5F0 Offset: 0x180B5F0 VA: 0x180F5F0
	private void Update() { }

	// RVA: 0x1810158 Offset: 0x180C158 VA: 0x1810158
	private void UpdateHpBar() { }

	// RVA: 0x18104BC Offset: 0x180C4BC VA: 0x18104BC
	private void UpdateIconView() { }

	// RVA: 0x180FD4C Offset: 0x180BD4C VA: 0x180FD4C
	private void GetItem() { }

	// RVA: 0x1810964 Offset: 0x180C964 VA: 0x1810964
	private void GetItemReward(int[] reward) { }

	// RVA: 0x1811230 Offset: 0x180D230 VA: 0x1811230
	private void UseActionItem(int action) { }

	// RVA: 0x180FF34 Offset: 0x180BF34 VA: 0x180FF34
	private void CloseWindowSetting() { }

	// RVA: 0x1811280 Offset: 0x180D280 VA: 0x1811280
	public void ReceiveResultData(int timer, int battleNum, int searchNum, bool isRedKey, Dictionary<byte, List<RewardData>> reward) { }

	// RVA: 0x1811D44 Offset: 0x180DD44 VA: 0x1811D44
	private void SetMiniMapKeyView(UIMiniMapTexture minimap, Vector3 pop, Texture mainTexture) { }

	// RVA: 0x1811EF0 Offset: 0x180DEF0 VA: 0x1811EF0
	public void OnClick_Action(int action) { }

	// RVA: 0x18120D8 Offset: 0x180E0D8 VA: 0x18120D8
	public void OnClick_PopupWindow(int type) { }

	// RVA: 0x181247C Offset: 0x180E47C VA: 0x181247C
	public void OnClick_PopupItemWindowClose() { }

	// RVA: 0x1812498 Offset: 0x180E498 VA: 0x1812498
	public void OnClick_SelectHelpWindow(int add) { }

	// RVA: 0x181265C Offset: 0x180E65C VA: 0x181265C
	public void OnClick_HelpStartButton() { }

	// RVA: 0x18126B0 Offset: 0x180E6B0 VA: 0x18126B0
	public void OnClick_HelpGiveupButton() { }

	// RVA: 0x1812764 Offset: 0x180E764 VA: 0x1812764
	public void OnClick_GoalButton() { }

	// RVA: 0x1812984 Offset: 0x180E984 VA: 0x1812984
	public void OnClick_ResultNext() { }

	// RVA: 0x1812A74 Offset: 0x180EA74 VA: 0x1812A74
	public void OnClick_ResultClose() { }

	// RVA: 0x1812B28 Offset: 0x180EB28 VA: 0x1812B28
	public void OnClick_SkipAction() { }

	// RVA: 0x1812BBC Offset: 0x180EBBC VA: 0x1812BBC Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1812E00 Offset: 0x180EE00 VA: 0x1812E00 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1810038 Offset: 0x180C038 VA: 0x1810038
	private void CheckShortcutPanel() { }

	// RVA: 0x1812BCC Offset: 0x180EBCC VA: 0x1812BCC
	private bool TopReturnButton() { }

	// RVA: 0x1812F50 Offset: 0x180EF50 VA: 0x1812F50 Slot: 9
	protected virtual bool OnMenuWindow(bool openLock) { }

	// RVA: 0x18130AC Offset: 0x180F0AC VA: 0x18130AC Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x18131E0 Offset: 0x180F1E0 VA: 0x18131E0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1813308 Offset: 0x180F308 VA: 0x1813308
	private void <OnClick_GoalButton>b__74_1() { }
}
