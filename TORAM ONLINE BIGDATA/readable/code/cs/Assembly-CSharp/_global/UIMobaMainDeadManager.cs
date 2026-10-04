// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMobaMainDeadManager : UIBasePanel // TypeDefIndex: 6089
{
	// Fields
	[SerializeField]
	private UIIruna2Anchor respawnWaitWindowAnchor; // 0x30
	[SerializeField]
	private UILabel respawnWaitWindowLabel; // 0x38
	[SerializeField]
	private UIIruna2Anchor respawnWindowAnchor; // 0x40
	[SerializeField]
	private UILabel respawnWindowLabel; // 0x48
	[SerializeField]
	private UIIruna2Anchor endPhaseWindowAnchor; // 0x50
	private GameObject shortcutManager; // 0x58
	private bool openShortcut; // 0x60
	private bool cancelCheck; // 0x61
	private short nearTrapId; // 0x62
	private GameObject player; // 0x68
	private byte fadeState; // 0x70
	private MobaRoomData mobaRoomData; // 0x78
	private bool isRespawnWait; // 0x80
	private string respawnWindowLocalize; // 0x88
	private string respawnCountDownWindowLocalize; // 0x90
	private UIMobaGhostWarpButton warpButton; // 0x98

	// Methods

	// RVA: 0x188255C Offset: 0x187E55C VA: 0x188255C
	private void Awake() { }

	[IteratorStateMachine(typeof(UIMobaMainDeadManager.<Start>d__17))]
	// RVA: 0x1882564 Offset: 0x187E564 VA: 0x1882564
	private IEnumerator Start() { }

	// RVA: 0x18825F8 Offset: 0x187E5F8 VA: 0x18825F8
	private void OnDestroy() { }

	// RVA: 0x1882778 Offset: 0x187E778 VA: 0x1882778
	private void Update() { }

	[IteratorStateMachine(typeof(UIMobaMainDeadManager.<PopUpAdviceMessage>d__20))]
	// RVA: 0x1882E44 Offset: 0x187EE44 VA: 0x1882E44
	private IEnumerator PopUpAdviceMessage() { }

	// RVA: 0x1882D20 Offset: 0x187ED20 VA: 0x1882D20
	private void UpdateRespawnWiatPanel() { }

	// RVA: 0x1882ED8 Offset: 0x187EED8 VA: 0x1882ED8
	public void OnClick_PlayerGhostToRevival() { }

	// RVA: 0x1883000 Offset: 0x187F000 VA: 0x1883000
	public void OnClick_LobbyLeaveButton() { }

	// RVA: 0x1883088 Offset: 0x187F088 VA: 0x1883088 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x188323C Offset: 0x187F23C VA: 0x188323C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18832F0 Offset: 0x187F2F0 VA: 0x18832F0 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x188339C Offset: 0x187F39C VA: 0x188339C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x188341C Offset: 0x187F41C VA: 0x188341C
	private void <Start>b__17_0() { }
}
