// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIActDeadManager : UIBasePanel // TypeDefIndex: 6474
{
	// Fields
	[SerializeField]
	private GameObject revivalButton; // 0x30
	private UIIruna2Anchor revivalButtonAnchor; // 0x38
	private UIImageButton revivalImageButton; // 0x40
	[SerializeField]
	private UILabel revivalButtonMessage; // 0x48
	[SerializeField]
	private GameObject townButton; // 0x50
	private UIIruna2Anchor townButtonAnchor; // 0x58
	[SerializeField]
	private GameObject messageWindow; // 0x60
	private UIIruna2Anchor messageWindowAnchor; // 0x68
	[SerializeField]
	private GameObject allDeadTelop; // 0x70
	[SerializeField]
	private UILabel[] allDeadTelopMessage; // 0x78
	[SerializeField]
	private UILabel respawnPointLabel; // 0x80
	private string respawnLocalize; // 0x88
	private float respawnTimer; // 0x90
	private PlayerGameStatus gameStatus; // 0x98
	private PlayerDataManager playerDataManager; // 0xA0
	private bool popUpWindowActive; // 0xA8
	private GameObject shortcutManager; // 0xB0
	private bool openShortcut; // 0xB8
	private bool systemLockCheck; // 0xB9
	private bool initFade; // 0xBA
	private bool fadeOutCheck; // 0xBB
	private bool isEmergencyRespawn; // 0xBC
	private bool isRespawnLock; // 0xBD

	// Methods

	// RVA: 0x1947B10 Offset: 0x1943B10 VA: 0x1947B10
	public void FadeOut() { }

	// RVA: 0x1947C7C Offset: 0x1943C7C VA: 0x1947C7C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1947D28 Offset: 0x1943D28 VA: 0x1947D28 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x1947FB4 Offset: 0x1943FB4 VA: 0x1947FB4 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x194807C Offset: 0x194407C VA: 0x194807C
	private void Awake() { }

	// RVA: 0x1948084 Offset: 0x1944084 VA: 0x1948084
	private void Start() { }

	[IteratorStateMachine(typeof(UIActDeadManager.<WaitEnterFieldEnd>d__29))]
	// RVA: 0x1948750 Offset: 0x1944750 VA: 0x1948750
	private IEnumerator WaitEnterFieldEnd() { }

	[IteratorStateMachine(typeof(UIActDeadManager.<WaitEventSceneEnd>d__30))]
	// RVA: 0x19487BC Offset: 0x19447BC VA: 0x19487BC
	private IEnumerator WaitEventSceneEnd() { }

	// RVA: 0x1948878 Offset: 0x1944878 VA: 0x1948878
	private void OnDestroy() { }

	// RVA: 0x19489D4 Offset: 0x19449D4 VA: 0x19489D4
	private void FadeIn() { }

	// RVA: 0x1948CAC Offset: 0x1944CAC VA: 0x1948CAC
	private void Update() { }

	// RVA: 0x1948E44 Offset: 0x1944E44 VA: 0x1948E44
	private void CheckRespawnTimer() { }

	// RVA: 0x1949238 Offset: 0x1945238 VA: 0x1949238
	private void OnTownBackButtonClick() { }

	// RVA: 0x1949694 Offset: 0x1945694 VA: 0x1949694
	private bool RespawnChangeField() { }

	// RVA: 0x19496F8 Offset: 0x19456F8 VA: 0x19496F8
	private void OnRespawnButtonClick() { }

	[IteratorStateMachine(typeof(UIActDeadManager.<PopWindowThread>d__38))]
	// RVA: 0x19495B4 Offset: 0x19455B4 VA: 0x19495B4
	private IEnumerator PopWindowThread(string title, string button, bool enabledFlag, PopUpMessageWindow.MessageData messageData, Func<bool> callBackAction) { }

	[IteratorStateMachine(typeof(UIActDeadManager.<NormalRespawn>d__39))]
	// RVA: 0x194977C Offset: 0x194577C VA: 0x194977C
	private IEnumerator NormalRespawn() { }

	// RVA: 0x1949824 Offset: 0x1945824 VA: 0x1949824
	public void .ctor() { }
}
