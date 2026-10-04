// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIWaveRaidEnterManager : UIBasePanel // TypeDefIndex: 6448
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
	private UIWaveRaidEnterBasePanel waveEnterBasePanel; // 0xB8
	private bool isInit; // 0xC0
	private float connectTimer; // 0xC4
	private PlayerDataManager playerDataManager; // 0xC8
	private WaveRaidRoomData waveRaidRoomData; // 0xD0
	private int fieldId; // 0xD8
	private byte roomId; // 0xDC
	private short difficulty; // 0xDE
	private short beforeDifficulty; // 0xE0
	private GameObject shortcutManager; // 0xE8
	private bool openShortcut; // 0xF0
	private float loadingTimer; // 0xF4
	private GameObject loadingObject; // 0xF8
	private bool isReconnected; // 0x100
	private WaveRaidRoomData beforeRoomData; // 0x108

	// Properties
	public bool IsCancel { get; set; }
	public bool IsClose { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x193598C Offset: 0x193198C VA: 0x193598C
	public bool get_IsCancel() { }

	[CompilerGenerated]
	// RVA: 0x1935994 Offset: 0x1931994 VA: 0x1935994
	private void set_IsCancel(bool value) { }

	[CompilerGenerated]
	// RVA: 0x19359A0 Offset: 0x19319A0 VA: 0x19359A0
	public bool get_IsClose() { }

	[CompilerGenerated]
	// RVA: 0x19359A8 Offset: 0x19319A8 VA: 0x19359A8
	private void set_IsClose(bool value) { }

	// RVA: 0x19359B4 Offset: 0x19319B4 VA: 0x19359B4
	private void Awake() { }

	// RVA: 0x19359C0 Offset: 0x19319C0 VA: 0x19359C0
	private void Start() { }

	// RVA: 0x1935C44 Offset: 0x1931C44 VA: 0x1935C44
	private void OnDestroy() { }

	// RVA: 0x1935C9C Offset: 0x1931C9C VA: 0x1935C9C
	public void Initialize(int fieldId, byte roomId, Vector3 pos, float rot, EmergencyPositionData emergencyPosition, short difficulty, string mainText, bool isCheckPartner) { }

	[IteratorStateMachine(typeof(UIWaveRaidEnterManager.<WaitRoomData>d__44))]
	// RVA: 0x1936038 Offset: 0x1932038 VA: 0x1936038
	private IEnumerator WaitRoomData() { }

	// RVA: 0x19360A4 Offset: 0x19320A4 VA: 0x19360A4
	private void UIinit() { }

	// RVA: 0x1936E14 Offset: 0x1932E14 VA: 0x1936E14
	private void Update() { }

	// RVA: 0x1937634 Offset: 0x1933634 VA: 0x1937634
	private void BattleReady() { }

	// RVA: 0x1937574 Offset: 0x1933574 VA: 0x1937574
	private void BattleReadyCancel() { }

	// RVA: 0x1935B1C Offset: 0x1931B1C VA: 0x1935B1C
	private void SetLeftButtonType(UITopButtonBase.ActionSystemType type) { }

	// RVA: 0x1935BB0 Offset: 0x1931BB0 VA: 0x1935BB0
	private void SetRightButtonType(UITopButtonBase.ActionSystemType type) { }

	// RVA: 0x1937864 Offset: 0x1933864 VA: 0x1937864
	public void ForceClose() { }

	// RVA: 0x1937894 Offset: 0x1933894 VA: 0x1937894
	public void CopeGroupNotFound() { }

	// RVA: 0x193749C Offset: 0x193349C VA: 0x193749C
	private void CloseShortcutPanel() { }

	// RVA: 0x1937B48 Offset: 0x1933B48 VA: 0x1937B48 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1937CB8 Offset: 0x1933CB8 VA: 0x1937CB8 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1937D10 Offset: 0x1933D10 VA: 0x1937D10 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x1937E04 Offset: 0x1933E04 VA: 0x1937E04
	public void .ctor() { }
}
