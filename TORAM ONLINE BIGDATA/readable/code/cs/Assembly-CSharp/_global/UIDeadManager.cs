// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIDeadManager : UIBasePanel // TypeDefIndex: 6496
{
	// Fields
	[SerializeField]
	private GameObject nowRevivalButton; // 0x30
	private UIIruna2Anchor nowRevivalButtonAnchor; // 0x38
	[SerializeField]
	private UILabel nowRevivalMessage; // 0x40
	[SerializeField]
	private GameObject revivalButton; // 0x48
	private UIIruna2Anchor revivalButtonAnchor; // 0x50
	private UIImageButton revivalImageButton; // 0x58
	[SerializeField]
	private UILabel revivalButtonMessage; // 0x60
	[SerializeField]
	private UILabel respawnCountUpMessage; // 0x68
	private string respawnLocalize; // 0x70
	private float respawnTimer; // 0x78
	private float yellsRespawnTimer; // 0x7C
	private TweenAlpha respawnCountUpMessageTweenAlpha; // 0x80
	private TweenPosition respawnCountUpMessageTweenPosition; // 0x88
	[SerializeField]
	private GameObject townButton; // 0x90
	private UIIruna2Anchor townButtonAnchor; // 0x98
	[SerializeField]
	private GameObject respawnButton; // 0xA0
	private UIIruna2Anchor respawnButtonAnchor; // 0xA8
	[SerializeField]
	private GameObject messageWindow; // 0xB0
	private UIIruna2Anchor messageWindowAnchor; // 0xB8
	[SerializeField]
	private UILabel respawnPointLabel; // 0xC0
	[SerializeField]
	private GameObject allDeadTelop; // 0xC8
	[SerializeField]
	private UILabel[] allDeadTelopMessage; // 0xD0
	private PlayerGameStatus gameStatus; // 0xD8
	private PlayerDataManager playerDataManager; // 0xE0
	private bool popUpWindowActive; // 0xE8
	private GameObject shortcutManager; // 0xF0
	private bool openShortcut; // 0xF8
	private bool systemLockCheck; // 0xF9
	private bool coinFade; // 0xFA
	private Action coinAction; // 0x100
	private bool initFade; // 0x108
	private bool fadeOutCheck; // 0x109
	private CharacterMove charaMove; // 0x110
	private bool isEmergencyRespawn; // 0x118
	private bool isRespawnLock; // 0x119

	// Methods

	// RVA: 0x195A3F0 Offset: 0x19563F0 VA: 0x195A3F0
	private void Awake() { }

	// RVA: 0x195A3F8 Offset: 0x19563F8 VA: 0x195A3F8
	private void Start() { }

	[IteratorStateMachine(typeof(UIDeadManager.<WaitEnterFieldEnd>d__37))]
	// RVA: 0x195ADE0 Offset: 0x1956DE0 VA: 0x195ADE0
	private IEnumerator WaitEnterFieldEnd() { }

	[IteratorStateMachine(typeof(UIDeadManager.<WaitEventSceneEnd>d__38))]
	// RVA: 0x195AE4C Offset: 0x1956E4C VA: 0x195AE4C
	private IEnumerator WaitEventSceneEnd() { }

	[IteratorStateMachine(typeof(UIDeadManager.<UpdateOrbData>d__39))]
	// RVA: 0x195AD74 Offset: 0x1956D74 VA: 0x195AD74
	private IEnumerator UpdateOrbData() { }

	// RVA: 0x195AF30 Offset: 0x1956F30 VA: 0x195AF30
	private void SetNowRevivalButton(string text, bool fadeIn, Action coin) { }

	// RVA: 0x195B04C Offset: 0x195704C VA: 0x195B04C
	private void OnDestroy() { }

	// RVA: 0x195B1B0 Offset: 0x19571B0 VA: 0x195B1B0
	private void FadeIn() { }

	// RVA: 0x195B5C8 Offset: 0x19575C8 VA: 0x195B5C8
	public void FadeOut() { }

	// RVA: 0x195B7BC Offset: 0x19577BC VA: 0x195B7BC
	private void Update() { }

	// RVA: 0x195BB48 Offset: 0x1957B48 VA: 0x195BB48
	private void CheckRespawnTimer() { }

	// RVA: 0x195C35C Offset: 0x195835C VA: 0x195C35C
	private void OnTownBackButtonClick() { }

	// RVA: 0x195C8F8 Offset: 0x19588F8 VA: 0x195C8F8
	private bool RespawnChangeField() { }

	// RVA: 0x195C978 Offset: 0x1958978 VA: 0x195C978
	private bool ScoreAttackRetire() { }

	// RVA: 0x195CAC0 Offset: 0x1958AC0 VA: 0x195CAC0
	private void OnItemRespawnButtonClick() { }

	// RVA: 0x195CADC Offset: 0x1958ADC VA: 0x195CADC
	private void PopCoinItemWindow() { }

	// RVA: 0x195CD6C Offset: 0x1958D6C VA: 0x195CD6C
	private bool CoinItemRespawn() { }

	// RVA: 0x195CE44 Offset: 0x1958E44 VA: 0x195CE44
	private void PopCoinWindow() { }

	[IteratorStateMachine(typeof(UIDeadManager.<UpdateOrbItemCost>d__53))]
	// RVA: 0x195CEF4 Offset: 0x1958EF4 VA: 0x195CEF4
	private IEnumerator UpdateOrbItemCost() { }

	// RVA: 0x195CF88 Offset: 0x1958F88 VA: 0x195CF88
	private bool OrbRespawn() { }

	// RVA: 0x195D084 Offset: 0x1959084 VA: 0x195D084
	private bool CoinErrCheck() { }

	// RVA: 0x195D114 Offset: 0x1959114 VA: 0x195D114
	private void OnRespawnButtonClick() { }

	// RVA: 0x195D1F8 Offset: 0x19591F8 VA: 0x195D1F8
	private void OnYellsRespawnClick() { }

	// RVA: 0x195B95C Offset: 0x195795C VA: 0x195B95C
	private void YellsRespawnUpdate() { }

	// RVA: 0x195D264 Offset: 0x1959264 VA: 0x195D264 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x195D32C Offset: 0x195932C VA: 0x195D32C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x195D3D8 Offset: 0x19593D8 VA: 0x195D3D8 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	[IteratorStateMachine(typeof(UIDeadManager.<PopWindowThread>d__62))]
	// RVA: 0x195C804 Offset: 0x1958804 VA: 0x195C804
	private IEnumerator PopWindowThread(string title, string button, bool enabledFlag, PopUpMessageWindow.MessageData messageData, Func<bool> callBackAction, Func<bool> connectCheck) { }

	[IteratorStateMachine(typeof(UIDeadManager.<NormalRespawn>d__63))]
	// RVA: 0x195D1A0 Offset: 0x19591A0 VA: 0x195D1A0
	private IEnumerator NormalRespawn() { }

	// RVA: 0x195D6F8 Offset: 0x19596F8 VA: 0x195D6F8
	public void .ctor() { }
}
