// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UILogOutMenuManager : UIBaseMenuPanel // TypeDefIndex: 8161
{
	// Fields
	private UIPopWindow popWindow; // 0x80
	private FunctionLimitManager functionLimitManager; // 0x88
	[SerializeField]
	private GameObject houseLeaveIcon; // 0x90
	[SerializeField]
	private GameObject houseWindow; // 0x98
	[SerializeField]
	private TweenScale houseWindowMainTween; // 0xA0
	[SerializeField]
	private TweenScale houseWindowSubTween; // 0xA8
	[SerializeField]
	private GameObject houseInitWindowObject; // 0xB0
	[SerializeField]
	private GameObject houseEditWindowObject; // 0xB8
	[SerializeField]
	private GameObject otherHouseLeaveWindowObject; // 0xC0
	[SerializeField]
	private GameObject houseLeaveWindowObject; // 0xC8
	[SerializeField]
	private GameObject houseOpenCheck; // 0xD0
	private UIToggle houseOpenCheckToggle; // 0xD8
	[SerializeField]
	private GameObject houseEditCheck; // 0xE0
	private UIToggle houseEditCheckToggle; // 0xE8
	[SerializeField]
	private GameObject houseInvisibleCheck; // 0xF0
	private UIToggle houseInvisibleCheckToggle; // 0xF8
	[SerializeField]
	private GameObject houseInvisible; // 0x100
	private UILabel houseInvisibleLabel; // 0x108
	[SerializeField]
	private UILabel housePopWindowTitle; // 0x110
	[SerializeField]
	private UIImageButton houseSaveImageButton; // 0x118
	private bool houseEditPop; // 0x120
	private bool houseStateCheck; // 0x121
	private GameObject loadModel; // 0x128
	private bool isOpenWindow; // 0x130
	private const int ScoreAttackFieldId = 106000;
	[CompilerGenerated]
	private int <GlobalServerId>k__BackingField; // 0x134

	// Properties
	public int GlobalServerId { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1CDA4EC Offset: 0x1CD64EC VA: 0x1CDA4EC
	public int get_GlobalServerId() { }

	[CompilerGenerated]
	// RVA: 0x1CDA4F4 Offset: 0x1CD64F4 VA: 0x1CDA4F4
	private void set_GlobalServerId(int value) { }

	// RVA: 0x1CDA4FC Offset: 0x1CD64FC VA: 0x1CDA4FC
	private void Awake() { }

	// RVA: 0x1CDB410 Offset: 0x1CD7410 VA: 0x1CDB410 Slot: 7
	protected override void Start() { }

	// RVA: 0x1CDB820 Offset: 0x1CD7820 VA: 0x1CDB820
	private void Update() { }

	// RVA: 0x1CDB9D0 Offset: 0x1CD79D0 VA: 0x1CDB9D0
	private void ReStart() { }

	// RVA: 0x1CDBA88 Offset: 0x1CD7A88 VA: 0x1CDBA88 Slot: 10
	protected override GameObject SetButton(string text, float y, int id, UIBaseMenuPanel.SystemLockType lockFlag) { }

	// RVA: 0x1CDBC14 Offset: 0x1CD7C14 VA: 0x1CDBC14 Slot: 13
	protected override PopUpMessageWindow AdviceMessageData() { }

	// RVA: 0x1CDBEE4 Offset: 0x1CD7EE4 VA: 0x1CDBEE4 Slot: 14
	protected override void AdviceMessageButton() { }

	// RVA: 0x1CDBF08 Offset: 0x1CD7F08 VA: 0x1CDBF08 Slot: 11
	protected override void OnClickButton(int id) { }

	// RVA: 0x1CDC4C8 Offset: 0x1CD84C8 VA: 0x1CDC4C8
	private void checkLogout() { }

	[IteratorStateMachine(typeof(UILogOutMenuManager.<logout>d__40))]
	// RVA: 0x1CDD520 Offset: 0x1CD9520 VA: 0x1CDD520
	private IEnumerator logout() { }

	// RVA: 0x1CDB5E4 Offset: 0x1CD75E4 VA: 0x1CDB5E4
	private void PopHouseWindow() { }

	// RVA: 0x1CDD5B4 Offset: 0x1CD95B4 VA: 0x1CDD5B4
	private void PopUpEnterWindow() { }

	// RVA: 0x1CDD928 Offset: 0x1CD9928 VA: 0x1CDD928
	private void ClosePopHouseWindow() { }

	// RVA: 0x1CDDA0C Offset: 0x1CD9A0C VA: 0x1CDDA0C
	public void OnHouseGuildMember() { }

	// RVA: 0x1CDDAE4 Offset: 0x1CD9AE4 VA: 0x1CDDAE4
	public void OnHouseFriendMember() { }

	// RVA: 0x1CDDAEC Offset: 0x1CD9AEC VA: 0x1CDDAEC
	public void OnHouseOtherMember() { }

	// RVA: 0x1CDDA14 Offset: 0x1CD9A14 VA: 0x1CDDA14
	private void ChangeLoadHouseMemberPanel(UIActiveState state) { }

	// RVA: 0x1CDDAF4 Offset: 0x1CD9AF4 VA: 0x1CDDAF4
	public void OnEnterMyHouse() { }

	// RVA: 0x1CDDC54 Offset: 0x1CD9C54 VA: 0x1CDDC54
	public void OnSaveMyHouse() { }

	// RVA: 0x1CDDDC8 Offset: 0x1CD9DC8 VA: 0x1CDDDC8
	public void OnInitEnterMyHouse() { }

	// RVA: 0x1CDDE6C Offset: 0x1CD9E6C VA: 0x1CDDE6C
	private void OnLeaveMyHouse() { }

	// RVA: 0x1CDDFC0 Offset: 0x1CD9FC0 VA: 0x1CDDFC0
	private void OnOpenLeaveMyHouse() { }

	// RVA: 0x1CDC344 Offset: 0x1CD8344 VA: 0x1CDC344
	private void leaveHouse() { }

	// RVA: 0x1CDE114 Offset: 0x1CDA114 VA: 0x1CDE114
	public void OnChangeInvisible() { }

	// RVA: 0x1CDE1A8 Offset: 0x1CDA1A8 VA: 0x1CDE1A8
	public void OnMyHouseEnterPop() { }

	// RVA: 0x1CDC3C4 Offset: 0x1CD83C4 VA: 0x1CDC3C4
	private void enterGuildHome() { }

	// RVA: 0x1CDC478 Offset: 0x1CD8478 VA: 0x1CDC478
	private void leaveGuildHome() { }

	// RVA: 0x1CDC6A0 Offset: 0x1CD86A0 VA: 0x1CDC6A0
	private void checkEscape() { }

	// RVA: 0x1CDE3B4 Offset: 0x1CDA3B4 VA: 0x1CDE3B4
	private void escape() { }

	// RVA: 0x1CDCD4C Offset: 0x1CD8D4C VA: 0x1CDCD4C
	private void CheckRetire() { }

	// RVA: 0x1CDE528 Offset: 0x1CDA528 VA: 0x1CDE528
	private void retire() { }

	// RVA: 0x1CDC858 Offset: 0x1CD8858 VA: 0x1CDC858
	private void enterGlobalServer(int globalServerId, string globalServerPointErr, string globalServerErrPopText) { }

	// RVA: 0x1CDCB3C Offset: 0x1CD8B3C VA: 0x1CDCB3C
	private void enterGlobalServerErrPop(string text) { }

	// RVA: 0x1CDD038 Offset: 0x1CD9038 VA: 0x1CDD038
	private void enterScoreAttack(out bool success) { }

	// RVA: 0x1CDD2D8 Offset: 0x1CD92D8 VA: 0x1CDD2D8
	private void leaveScoreAttack() { }

	// RVA: 0x1CDD380 Offset: 0x1CD9380 VA: 0x1CDD380
	private void retireScoreAttack() { }

	[IteratorStateMachine(typeof(UILogOutMenuManager.<connectWait>d__69))]
	// RVA: 0x1CDCCB0 Offset: 0x1CD8CB0 VA: 0x1CDCCB0
	private IEnumerator connectWait(Func<bool> check, Action callback) { }

	// RVA: 0x1CDE468 Offset: 0x1CDA468 VA: 0x1CDE468
	private void closePopWindow() { }

	// RVA: 0x1CDE63C Offset: 0x1CDA63C VA: 0x1CDE63C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1CDE704 Offset: 0x1CDA704 VA: 0x1CDE704
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1CDE708 Offset: 0x1CDA708 VA: 0x1CDE708
	private void <OnClickButton>b__38_1() { }

	[CompilerGenerated]
	// RVA: 0x1CDE818 Offset: 0x1CDA818 VA: 0x1CDE818
	private void <checkLogout>b__39_0() { }

	[CompilerGenerated]
	// RVA: 0x1CDE880 Offset: 0x1CDA880 VA: 0x1CDE880
	private void <enterScoreAttack>b__64_0() { }

	[CompilerGenerated]
	// RVA: 0x1CDEA20 Offset: 0x1CDAA20 VA: 0x1CDEA20
	private void <retireScoreAttack>b__66_0() { }

	[CompilerGenerated]
	// RVA: 0x1CDEB78 Offset: 0x1CDAB78 VA: 0x1CDEB78
	private void <retireScoreAttack>b__66_1() { }

	[CompilerGenerated]
	// RVA: 0x1CDEC20 Offset: 0x1CDAC20 VA: 0x1CDEC20
	private void <retireScoreAttack>b__66_2() { }
}
