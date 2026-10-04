// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPartyLotteryManager : UIBasePanel // TypeDefIndex: 7697
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
	private GameObject shortcutManager; // 0x90
	private bool openShortcut; // 0x98
	private string localizeText; // 0xA0
	private float timer; // 0xA8
	private int partyNum; // 0xAC
	private bool popUpWindowActive; // 0xB0
	private bool isClose; // 0xB1
	private float popButtonTimer; // 0xB4
	private UIPartyLotteryManager.PanelState panelState; // 0xB8
	private int userNum; // 0xBC
	private float clearTimer; // 0xC0

	// Methods

	// RVA: 0x1BE5F30 Offset: 0x1BE1F30 VA: 0x1BE5F30
	private void Awake() { }

	[IteratorStateMachine(typeof(UIPartyLotteryManager.<Start>d__25))]
	// RVA: 0x1BE6014 Offset: 0x1BE2014 VA: 0x1BE6014
	private IEnumerator Start() { }

	// RVA: 0x1BE60A8 Offset: 0x1BE20A8 VA: 0x1BE60A8
	private void ActiveSettingPanel() { }

	// RVA: 0x1BE6208 Offset: 0x1BE2208 VA: 0x1BE6208
	private void ActiveClearPanel() { }

	// RVA: 0x1BE6318 Offset: 0x1BE2318 VA: 0x1BE6318
	private void ActiveClearWaitPanel() { }

	// RVA: 0x1BE6388 Offset: 0x1BE2388 VA: 0x1BE6388
	public void OnReceiveUserNum(int num) { }

	// RVA: 0x1BE6390 Offset: 0x1BE2390 VA: 0x1BE6390
	private void OnDestroy() { }

	// RVA: 0x1BE6420 Offset: 0x1BE2420 VA: 0x1BE6420
	private void Update() { }

	// RVA: 0x1BE68A4 Offset: 0x1BE28A4 VA: 0x1BE68A4
	private void CloseShortcutPanel() { }

	// RVA: 0x1BE69D8 Offset: 0x1BE29D8 VA: 0x1BE69D8
	public void OnClickLotterStart() { }

	// RVA: 0x1BE6CD4 Offset: 0x1BE2CD4 VA: 0x1BE6CD4
	public void OnClickChatPop() { }

	// RVA: 0x1BE6D84 Offset: 0x1BE2D84 VA: 0x1BE6D84
	public void OnClickEnter() { }

	// RVA: 0x1BE6F14 Offset: 0x1BE2F14 VA: 0x1BE6F14
	public void OnClickAllSelected(int param) { }

	// RVA: 0x1BE6FA0 Offset: 0x1BE2FA0 VA: 0x1BE6FA0
	public void OnUpdateSelected() { }

	[IteratorStateMachine(typeof(UIPartyLotteryManager.<connectWait>d__38))]
	// RVA: 0x1BE6814 Offset: 0x1BE2814 VA: 0x1BE6814
	private IEnumerator connectWait(byte subCode, Action<int> callback) { }

	[IteratorStateMachine(typeof(UIPartyLotteryManager.<PopUpWrapWindow>d__39))]
	// RVA: 0x1BE693C Offset: 0x1BE293C VA: 0x1BE693C
	private IEnumerator PopUpWrapWindow(UIPopBaseWindow window, Action<int> callback) { }

	// RVA: 0x1BE7060 Offset: 0x1BE3060 VA: 0x1BE7060
	private void PartyLotteryRecruitCancel() { }

	// RVA: 0x1BE7188 Offset: 0x1BE3188 VA: 0x1BE7188 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x1BE7210 Offset: 0x1BE3210 VA: 0x1BE7210 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1BE7318 Offset: 0x1BE3318 VA: 0x1BE7318 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1BE7428 Offset: 0x1BE3428 VA: 0x1BE7428
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1BE7488 Offset: 0x1BE3488 VA: 0x1BE7488
	private void <Update>b__31_0(int x) { }

	[CompilerGenerated]
	// RVA: 0x1BE748C Offset: 0x1BE348C VA: 0x1BE748C
	private void <Update>b__31_1(int f) { }
}
