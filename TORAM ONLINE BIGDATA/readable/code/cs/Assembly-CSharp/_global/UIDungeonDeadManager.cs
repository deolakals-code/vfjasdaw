// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIDungeonDeadManager : UIBasePanel // TypeDefIndex: 6500
{
	// Fields
	[SerializeField]
	private GameObject deadWindow; // 0x30
	private UIIruna2Anchor deadWindowAnchor; // 0x38
	private GameObject shortcutManager; // 0x40
	private bool openShortcut; // 0x48
	private bool cancelCheck; // 0x49
	private short nearTrapId; // 0x4A
	private GameObject tapEffect; // 0x50
	private BoxCollider tapCollider; // 0x58
	private SkinnedMeshRenderer tapSkin; // 0x60
	private GameObject player; // 0x68
	private DungeonRoomData roomData; // 0x70
	private PlayerDataManager playerDataManager; // 0x78
	private bool initMiniMap; // 0x80

	// Methods

	// RVA: 0x195EDD4 Offset: 0x195ADD4 VA: 0x195EDD4
	private void Awake() { }

	// RVA: 0x195EDDC Offset: 0x195ADDC VA: 0x195EDDC
	private void Start() { }

	// RVA: 0x195F27C Offset: 0x195B27C VA: 0x195F27C
	private void InitTapEffect() { }

	// RVA: 0x195F784 Offset: 0x195B784 VA: 0x195F784
	private void OnDestroy() { }

	// RVA: 0x195F8B4 Offset: 0x195B8B4 VA: 0x195F8B4
	private void Update() { }

	// RVA: 0x195FDB4 Offset: 0x195BDB4 VA: 0x195FDB4
	public void AttackTrap() { }

	[IteratorStateMachine(typeof(UIDungeonDeadManager.<PopUpAdviceMessage>d__19))]
	// RVA: 0x195FE24 Offset: 0x195BE24 VA: 0x195FE24
	private IEnumerator PopUpAdviceMessage() { }

	// RVA: 0x195FEB8 Offset: 0x195BEB8 VA: 0x195FEB8 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x195FFF8 Offset: 0x195BFF8 VA: 0x195FFF8 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x196008C Offset: 0x195C08C VA: 0x196008C Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x1960114 Offset: 0x195C114 VA: 0x1960114
	public void .ctor() { }
}
