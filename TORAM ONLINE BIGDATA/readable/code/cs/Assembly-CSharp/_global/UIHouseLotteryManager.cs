// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseLotteryManager : UIBasePanel // TypeDefIndex: 7268
{
	// Fields
	[SerializeField]
	private GameObject lotteryPanel; // 0x30
	[SerializeField]
	private UILabel messageLabel; // 0x38
	[SerializeField]
	private GameObject sendButton; // 0x40
	[SerializeField]
	private GameObject windowPanel; // 0x48
	[SerializeField]
	private GameObject settingPanel; // 0x50
	[SerializeField]
	private UIToggle[] toggleButton; // 0x58
	[SerializeField]
	private UILabel clearUserNumButtonLabel; // 0x60
	[SerializeField]
	private UIImageButton startButton; // 0x68
	[SerializeField]
	private GameObject clearPanel; // 0x70
	[SerializeField]
	private UILabel clearUserLabel; // 0x78
	[SerializeField]
	private GameObject clearWaitPanel; // 0x80
	[SerializeField]
	private UISprite clearBarSprite; // 0x88
	[SerializeField]
	private GameObject resultWindowPanel; // 0x90
	[SerializeField]
	private UILabel resultUserLabel; // 0x98
	private GameObject shortcutManager; // 0xA0
	private bool openShortcut; // 0xA8
	private string localizeText; // 0xB0
	private float timer; // 0xB8
	private int partyNum; // 0xBC
	private bool popUpWindowActive; // 0xC0
	private bool isClose; // 0xC1
	private float popButtonTimer; // 0xC4
	private UIHouseLotteryManager.PanelState panelState; // 0xC8
	private int userNum; // 0xCC
	private float clearTimer; // 0xD0
	private string resultUserName; // 0xD8

	// Methods

	// RVA: 0x1AF6A2C Offset: 0x1AF2A2C VA: 0x1AF6A2C
	private void Awake() { }

	[IteratorStateMachine(typeof(UIHouseLotteryManager.<Start>d__28))]
	// RVA: 0x1AF6B10 Offset: 0x1AF2B10 VA: 0x1AF6B10
	private IEnumerator Start() { }

	// RVA: 0x1AF6BA4 Offset: 0x1AF2BA4 VA: 0x1AF6BA4
	private void ActiveSettingPanel() { }

	// RVA: 0x1AF6D04 Offset: 0x1AF2D04 VA: 0x1AF6D04
	private void ActiveClearPanel() { }

	// RVA: 0x1AF6E14 Offset: 0x1AF2E14 VA: 0x1AF6E14
	private void ActiveClearWaitPanel() { }

	// RVA: 0x1AF6E84 Offset: 0x1AF2E84 VA: 0x1AF6E84
	public void OnReceiveUserNum(int num) { }

	// RVA: 0x1AF6E8C Offset: 0x1AF2E8C VA: 0x1AF6E8C
	private void OnDestroy() { }

	// RVA: 0x1AF6F1C Offset: 0x1AF2F1C VA: 0x1AF6F1C
	private void Update() { }

	// RVA: 0x1AF73A0 Offset: 0x1AF33A0 VA: 0x1AF73A0
	private void CloseShortcutPanel() { }

	// RVA: 0x1AF74D4 Offset: 0x1AF34D4 VA: 0x1AF74D4
	public void OnClickLotterStart() { }

	// RVA: 0x1AF77D0 Offset: 0x1AF37D0 VA: 0x1AF77D0
	public void OnClickChatPop() { }

	// RVA: 0x1AF7880 Offset: 0x1AF3880 VA: 0x1AF7880
	public void OnClickEnter() { }

	// RVA: 0x1AF79B4 Offset: 0x1AF39B4 VA: 0x1AF79B4
	public void OnClickAllSelected(int param) { }

	// RVA: 0x1AF7A40 Offset: 0x1AF3A40 VA: 0x1AF7A40
	public void OnUpdateSelected() { }

	// RVA: 0x1AF7AB0 Offset: 0x1AF3AB0 VA: 0x1AF7AB0
	public void ReceiveResultUserName(string userName) { }

	[IteratorStateMachine(typeof(UIHouseLotteryManager.<connectWait>d__42))]
	// RVA: 0x1AF7310 Offset: 0x1AF3310 VA: 0x1AF7310
	private IEnumerator connectWait(byte subCode, Action<int> callback) { }

	[IteratorStateMachine(typeof(UIHouseLotteryManager.<PopUpWrapWindow>d__43))]
	// RVA: 0x1AF7438 Offset: 0x1AF3438 VA: 0x1AF7438
	private IEnumerator PopUpWrapWindow(UIPopBaseWindow window, Action<int> callback) { }

	// RVA: 0x1AF7B08 Offset: 0x1AF3B08 VA: 0x1AF7B08
	private void PartyLotteryRecruitCancel() { }

	// RVA: 0x1AF7C30 Offset: 0x1AF3C30 VA: 0x1AF7C30 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x1AF7CB8 Offset: 0x1AF3CB8 VA: 0x1AF7CB8 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1AF7DC0 Offset: 0x1AF3DC0 VA: 0x1AF7DC0 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1AF7ED0 Offset: 0x1AF3ED0 VA: 0x1AF7ED0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1AF7F40 Offset: 0x1AF3F40 VA: 0x1AF7F40
	private void <Update>b__34_0(int x) { }

	[CompilerGenerated]
	// RVA: 0x1AF7F44 Offset: 0x1AF3F44 VA: 0x1AF7F44
	private void <Update>b__34_1(int f) { }

	[CompilerGenerated]
	// RVA: 0x1AF7F48 Offset: 0x1AF3F48 VA: 0x1AF7F48
	private void <OnClickEnter>b__38_0(int f) { }
}
