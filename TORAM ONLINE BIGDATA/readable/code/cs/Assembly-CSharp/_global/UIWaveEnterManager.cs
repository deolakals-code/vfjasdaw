// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIWaveEnterManager : UIBasePanel // TypeDefIndex: 6426
{
	// Fields
	[SerializeField]
	private GameObject mainPanel; // 0x30
	private UIIruna2Anchor mainAnchor; // 0x38
	[SerializeField]
	private GameObject partyNamePanel; // 0x40
	private UIIruna2Anchor partyNameAnchor; // 0x48
	[SerializeField]
	private UILabel recommLevelLabel; // 0x50
	[SerializeField]
	private UILabel mainTextLabel; // 0x58
	[SerializeField]
	private UIImageButton enterButton; // 0x60
	[SerializeField]
	private UILabel enterLabel; // 0x68
	[SerializeField]
	private GameObject[] partyMemberObj; // 0x70
	protected UIPartyMember[] partyMemberData; // 0x78
	protected TweenPosition[] partyMemberEffect; // 0x80
	[SerializeField]
	private GameObject topObj; // 0x88
	[SerializeField]
	private GameObject bottomObj; // 0x90
	[SerializeField]
	private GameObject errLabel; // 0x98
	[CompilerGenerated]
	private bool <IsCancel>k__BackingField; // 0xA0
	[CompilerGenerated]
	private bool <IsClose>k__BackingField; // 0xA1
	private bool isPartner; // 0xA2
	private UIPopBaseWindow popWindow; // 0xA8
	private UIPopWindow errPopWindow; // 0xB0
	private UIWaveEnterBasePanel waveEnterBasePanel; // 0xB8
	private bool isInit; // 0xC0
	private float connectTimer; // 0xC4
	private PlayerDataManager playerDataManager; // 0xC8
	private WaveRoomData waveRoomData; // 0xD0
	private int fieldId; // 0xD8
	private byte roomId; // 0xDC
	private short difficulty; // 0xDE
	private short beforeDifficulty; // 0xE0
	private GameObject shortcutManager; // 0xE8
	private bool openShortcut; // 0xF0
	private float loadingTimer; // 0xF4
	private GameObject loadingObject; // 0xF8
	private bool isReconnected; // 0x100
	private WaveRoomData beforeRoomData; // 0x108

	// Properties
	public bool IsCancel { get; set; }
	public bool IsClose { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x192D540 Offset: 0x1929540 VA: 0x192D540
	public bool get_IsCancel() { }

	[CompilerGenerated]
	// RVA: 0x192D548 Offset: 0x1929548 VA: 0x192D548
	private void set_IsCancel(bool value) { }

	[CompilerGenerated]
	// RVA: 0x192D554 Offset: 0x1929554 VA: 0x192D554
	public bool get_IsClose() { }

	[CompilerGenerated]
	// RVA: 0x192D55C Offset: 0x192955C VA: 0x192D55C
	private void set_IsClose(bool value) { }

	// RVA: 0x192D568 Offset: 0x1929568 VA: 0x192D568
	private void Awake() { }

	// RVA: 0x192D574 Offset: 0x1929574 VA: 0x192D574
	private void Start() { }

	// RVA: 0x192D7F8 Offset: 0x19297F8 VA: 0x192D7F8
	private void OnDestroy() { }

	// RVA: 0x192D850 Offset: 0x1929850 VA: 0x192D850
	public void Initialize(int fieldId, byte roomId, Vector3 pos, float rot, EmergencyPositionData emergencyPosition, short difficulty, string mainText, bool isCheckPartner) { }

	[IteratorStateMachine(typeof(UIWaveEnterManager.<WaitRoomData>d__44))]
	// RVA: 0x192DBF0 Offset: 0x1929BF0 VA: 0x192DBF0
	private IEnumerator WaitRoomData() { }

	// RVA: 0x192DC5C Offset: 0x1929C5C VA: 0x192DC5C
	private void UIinit() { }

	// RVA: 0x192E81C Offset: 0x192A81C VA: 0x192E81C
	private void Update() { }

	// RVA: 0x192F044 Offset: 0x192B044 VA: 0x192F044
	private void BattleReady() { }

	// RVA: 0x192EF84 Offset: 0x192AF84 VA: 0x192EF84
	private void BattleReadyCancel() { }

	// RVA: 0x192D6D0 Offset: 0x19296D0 VA: 0x192D6D0
	private void SetLeftButtonType(UITopButtonBase.ActionSystemType type) { }

	// RVA: 0x192D764 Offset: 0x1929764 VA: 0x192D764
	private void SetRightButtonType(UITopButtonBase.ActionSystemType type) { }

	// RVA: 0x192F280 Offset: 0x192B280 VA: 0x192F280
	public void ForceClose() { }

	// RVA: 0x192F2B0 Offset: 0x192B2B0 VA: 0x192F2B0
	public void CopeGroupNotFound() { }

	// RVA: 0x192EEAC Offset: 0x192AEAC VA: 0x192EEAC
	private void CloseShortcutPanel() { }

	// RVA: 0x192F56C Offset: 0x192B56C VA: 0x192F56C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x192F6DC Offset: 0x192B6DC VA: 0x192F6DC Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x192F734 Offset: 0x192B734 VA: 0x192F734 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x192F828 Offset: 0x192B828 VA: 0x192F828
	public void .ctor() { }
}
