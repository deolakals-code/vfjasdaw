// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIEventMessageWindow : UIBasePanel // TypeDefIndex: 6516
{
	// Fields
	private bool windowOpen; // 0x29
	private InactiveTimer inactiveTimer; // 0x30
	[SerializeField]
	private Transform messageBottomFrame; // 0x38
	[SerializeField]
	private Transform messageSideFrame; // 0x40
	[SerializeField]
	private Transform messageBack; // 0x48
	[SerializeField]
	private UILabel messageLabel; // 0x50
	[SerializeField]
	private GameObject messageAnchorObject; // 0x58
	private UIIruna2Anchor messageAnchor; // 0x60
	private UISprites[] messageFrame; // 0x68
	[SerializeField]
	private UILabel userLabel; // 0x70
	[SerializeField]
	private GameObject informationObject; // 0x78
	private UIIruna2Anchor informationAnchor; // 0x80
	[SerializeField]
	private GameObject userAnchorObject; // 0x88
	private UIIruna2Anchor userAnchor; // 0x90
	private string activeUserName; // 0x98
	[SerializeField]
	private GameObject buttonAnchorObject; // 0xA0
	private UIIruna2Anchor buttonAnchor; // 0xA8
	private bool buttonPush; // 0xB0
	[SerializeField]
	private GameObject ScrollWindowObject; // 0xB8
	private UIScrollWindow scrollWindow; // 0xC0
	private UIIruna2Anchor scrollAnchor; // 0xC8
	[SerializeField]
	private GameObject scrollScenarioButton; // 0xD0
	[SerializeField]
	private GameObject scrollMenuButton; // 0xD8
	[SerializeField]
	private GameObject scrollMenuExButton; // 0xE0
	private int selectMenuIndex; // 0xE8
	private int selectMenuNum; // 0xEC
	private Vector3 position; // 0xF0
	public bool IsCloseWarpList; // 0xFC
	[CompilerGenerated]
	private WarpListRowData <SelectedWarpListRowData>k__BackingField; // 0x100
	private int warpListId; // 0x108
	private WarpListManager warpListManager; // 0x110
	private WarpListTextManager warpListTextManager; // 0x118
	private WarpListTextManagerData warpListTextManagerData; // 0x120
	private WarpListMasterData masterData; // 0x128

	// Properties
	private UIIruna2Anchor MessageAnchor { get; }
	private UIIruna2Anchor InformationAnchor { get; }
	private UIIruna2Anchor UserAnchor { get; }
	public string ActiveUserName { get; }
	private UIIruna2Anchor ButtonAnchor { get; }
	public WarpListRowData SelectedWarpListRowData { get; set; }

	// Methods

	// RVA: 0x1965C30 Offset: 0x1961C30 VA: 0x1965C30
	private void Awake() { }

	// RVA: 0x1965C98 Offset: 0x1961C98 VA: 0x1965C98
	private void OnDisable() { }

	// RVA: 0x1965CF0 Offset: 0x1961CF0 VA: 0x1965CF0
	private UIIruna2Anchor get_MessageAnchor() { }

	// RVA: 0x1965DA0 Offset: 0x1961DA0 VA: 0x1965DA0
	private UIIruna2Anchor get_InformationAnchor() { }

	// RVA: 0x1965E50 Offset: 0x1961E50 VA: 0x1965E50
	private UIIruna2Anchor get_UserAnchor() { }

	// RVA: 0x1965F00 Offset: 0x1961F00 VA: 0x1965F00
	public string get_ActiveUserName() { }

	// RVA: 0x1965F08 Offset: 0x1961F08 VA: 0x1965F08
	private UIIruna2Anchor get_ButtonAnchor() { }

	// RVA: 0x1965FB8 Offset: 0x1961FB8 VA: 0x1965FB8
	public void SetMesseage(string message, byte pivot) { }

	// RVA: 0x19665A0 Offset: 0x19625A0 VA: 0x19665A0
	public void SetUserName(string name) { }

	// RVA: 0x196689C Offset: 0x196289C VA: 0x196689C
	public void ButtonFade(bool flag) { }

	// RVA: 0x1966998 Offset: 0x1962998 VA: 0x1966998
	public bool ButtonPushedCheck() { }

	// RVA: 0x19669A0 Offset: 0x19629A0 VA: 0x19669A0
	private void ButtonPsuhed() { }

	// RVA: 0x19669AC Offset: 0x19629AC VA: 0x19669AC
	public void MenuInitialize(int num) { }

	// RVA: 0x1966C7C Offset: 0x1962C7C VA: 0x1966C7C
	public void AddMenuButton(string mes, int id) { }

	// RVA: 0x1966E18 Offset: 0x1962E18 VA: 0x1966E18
	public void AddMenuButton(UIEventMenuButton.MessageButtonData mes, int id) { }

	// RVA: 0x1966EBC Offset: 0x1962EBC VA: 0x1966EBC
	public void AddMenuButtonEx(string mes, int id) { }

	// RVA: 0x1966FDC Offset: 0x1962FDC VA: 0x1966FDC
	public void AddMenuButtonEx(UIEventMenuButton.MessageButtonData mes, int id) { }

	// RVA: 0x1966EEC Offset: 0x1962EEC VA: 0x1966EEC
	private UIEventMenuButton CraeteExButton(string mes) { }

	// RVA: 0x196703C Offset: 0x196303C VA: 0x196703C
	public void AddQuestMenuButton(int questId, int sendId, QuestManager.QuestOrderCondition state) { }

	// RVA: 0x1966CF4 Offset: 0x1962CF4 VA: 0x1966CF4
	private GameObject AddButton(GameObject baseButton) { }

	// RVA: 0x19675B8 Offset: 0x19635B8 VA: 0x19675B8
	public int SelectMenuIndexCheck() { }

	// RVA: 0x19675C0 Offset: 0x19635C0 VA: 0x19675C0
	private void SelectMenuPsuhed(int index) { }

	// RVA: 0x19675C8 Offset: 0x19635C8 VA: 0x19675C8
	public void SelectMenuClear() { }

	[CompilerGenerated]
	// RVA: 0x1967678 Offset: 0x1963678 VA: 0x1967678
	public WarpListRowData get_SelectedWarpListRowData() { }

	[CompilerGenerated]
	// RVA: 0x1967680 Offset: 0x1963680 VA: 0x1967680
	private void set_SelectedWarpListRowData(WarpListRowData value) { }

	// RVA: 0x1967690 Offset: 0x1963690 VA: 0x1967690
	public void InitializeWarpList(int warpListId) { }

	[IteratorStateMachine(typeof(UIEventMessageWindow.<InitWarpListUI>d__66))]
	// RVA: 0x196789C Offset: 0x196389C VA: 0x196789C
	private IEnumerator InitWarpListUI() { }

	// RVA: 0x1967930 Offset: 0x1963930 VA: 0x1967930
	private void UpdateWarpList(List<WarpListRowData> list) { }

	[IteratorStateMachine(typeof(UIEventMessageWindow.<LoadResourceProcess>d__68))]
	// RVA: 0x19681A0 Offset: 0x19641A0 VA: 0x19681A0
	private IEnumerator LoadResourceProcess() { }

	// RVA: 0x1968234 Offset: 0x1964234 VA: 0x1968234
	public void OnSelectWarpListButton(int param) { }

	// RVA: 0x19682D4 Offset: 0x19642D4 VA: 0x19682D4
	public void WindowClose() { }

	// RVA: 0x1968414 Offset: 0x1964414 VA: 0x1968414 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1968584 Offset: 0x1964584 VA: 0x1968584 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x19686F4 Offset: 0x19646F4 VA: 0x19686F4
	public void .ctor() { }
}
