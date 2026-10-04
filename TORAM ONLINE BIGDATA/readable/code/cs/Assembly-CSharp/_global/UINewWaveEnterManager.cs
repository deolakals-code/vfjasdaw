// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UINewWaveEnterManager : UIBasePanel // TypeDefIndex: 6156
{
	// Fields
	[SerializeField]
	private UIIruna2Anchor mainAnchor; // 0x30
	[SerializeField]
	private UIIruna2Anchor partyNameAnchor; // 0x38
	[SerializeField]
	private GameObject[] partyMemberObj; // 0x40
	[SerializeField]
	private UILabel titleLabel; // 0x48
	[SerializeField]
	private UILabel difficultNumLabel; // 0x50
	[SerializeField]
	private GameObject[] difficultSelectButtons; // 0x58
	[SerializeField]
	private UILabel pointBoostLabel; // 0x60
	[SerializeField]
	private UISprite pointBoostIcon; // 0x68
	[SerializeField]
	private UISprite pointBoostButton; // 0x70
	[SerializeField]
	private UILabel pointBoostSubLabel; // 0x78
	[SerializeField]
	private UIImageButton enterButton; // 0x80
	[SerializeField]
	private UILabel enterButtonLabel; // 0x88
	[SerializeField]
	private GameObject attentionWindowObj; // 0x90
	[SerializeField]
	private UILabel attentionWindowLabel; // 0x98
	[SerializeField]
	private GameObject errLabel; // 0xA0
	[CompilerGenerated]
	private bool <IsCancel>k__BackingField; // 0xA8
	[CompilerGenerated]
	private bool <IsClose>k__BackingField; // 0xA9
	private UINewWaveEnterBasePanel newWaveEnterBasePanel; // 0xB0
	private PlayerDataManager playerDataManager; // 0xB8
	private NewWaveRoomData roomData; // 0xC0
	private GameObject shortcutManager; // 0xC8
	private bool openShortcut; // 0xD0
	private bool isInit; // 0xD1
	private float connectTimer; // 0xD4
	private short selectDifficultyNum; // 0xD8
	private List<int> difficultList; // 0xE0
	private float loadingTimer; // 0xE8
	private GameObject loadingObject; // 0xF0
	private int selectedDifficulty; // 0xF8
	private int beforeDifficulty; // 0xFC
	private int averageLevel; // 0x100
	private const int attentionLevel = 30;
	private bool isOpenAttentionWindow; // 0x104
	private readonly string[] pointBoostIconNames; // 0x108
	private byte havePointBoost; // 0x110

	// Properties
	public bool IsCancel { get; set; }
	public bool IsClose { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x18A4AC4 Offset: 0x18A0AC4 VA: 0x18A4AC4
	public bool get_IsCancel() { }

	[CompilerGenerated]
	// RVA: 0x18A4ACC Offset: 0x18A0ACC VA: 0x18A4ACC
	private void set_IsCancel(bool value) { }

	[CompilerGenerated]
	// RVA: 0x18A4AD8 Offset: 0x18A0AD8 VA: 0x18A4AD8
	public bool get_IsClose() { }

	[CompilerGenerated]
	// RVA: 0x18A4AE0 Offset: 0x18A0AE0 VA: 0x18A4AE0
	private void set_IsClose(bool value) { }

	// RVA: 0x18A4AEC Offset: 0x18A0AEC VA: 0x18A4AEC
	private void Awake() { }

	// RVA: 0x18A4AF8 Offset: 0x18A0AF8 VA: 0x18A4AF8
	private void Start() { }

	// RVA: 0x18A4D7C Offset: 0x18A0D7C VA: 0x18A4D7C
	private void Update() { }

	// RVA: 0x18A5510 Offset: 0x18A1510 VA: 0x18A5510
	private void OnDestroy() { }

	// RVA: 0x18A5568 Offset: 0x18A1568 VA: 0x18A5568
	public void Initialize(int fieldId, byte roomId, Vector3 pos, float rot, EmergencyPositionData emergencyPosition, List<int> difficulty) { }

	[IteratorStateMachine(typeof(UINewWaveEnterManager.<WaitRoomData>d__46))]
	// RVA: 0x18A5860 Offset: 0x18A1860 VA: 0x18A5860
	private IEnumerator WaitRoomData() { }

	// RVA: 0x18A58F4 Offset: 0x18A18F4 VA: 0x18A58F4
	private void UIinit() { }

	// RVA: 0x18A62BC Offset: 0x18A22BC VA: 0x18A62BC
	private void UpdateDifficulty() { }

	// RVA: 0x18A5394 Offset: 0x18A1394 VA: 0x18A5394
	private void UpdateDifficultyText(int diff) { }

	// RVA: 0x18A63C8 Offset: 0x18A23C8 VA: 0x18A63C8
	private void UpdatePointBoost() { }

	// RVA: 0x18A6588 Offset: 0x18A2588 VA: 0x18A6588
	private byte[] GetPointBoostList() { }

	// RVA: 0x18A6624 Offset: 0x18A2624 VA: 0x18A6624
	public void OnChangeDifficulty(int param) { }

	// RVA: 0x18A66DC Offset: 0x18A26DC VA: 0x18A66DC
	public void OnPointBoost() { }

	// RVA: 0x18A67C8 Offset: 0x18A27C8 VA: 0x18A67C8
	public void BattleReady() { }

	// RVA: 0x18A5450 Offset: 0x18A1450 VA: 0x18A5450
	private void BattleReadyCancel() { }

	// RVA: 0x18A6BBC Offset: 0x18A2BBC VA: 0x18A6BBC
	public void AttentionWindowButton() { }

	// RVA: 0x18A52BC Offset: 0x18A12BC VA: 0x18A52BC
	private void CloseShortcutPanel() { }

	// RVA: 0x18A6A48 Offset: 0x18A2A48 VA: 0x18A6A48
	private void ChangeActiveAttentionWindow(bool isActive) { }

	// RVA: 0x18A5C6C Offset: 0x18A1C6C VA: 0x18A5C6C
	private void UpdatePartyAverageLevel() { }

	// RVA: 0x18A4C54 Offset: 0x18A0C54 VA: 0x18A4C54
	private void SetLeftButtonType(UITopButtonBase.ActionSystemType type) { }

	// RVA: 0x18A4CE8 Offset: 0x18A0CE8 VA: 0x18A4CE8
	private void SetRightButtonType(UITopButtonBase.ActionSystemType type) { }

	// RVA: 0x18A6C3C Offset: 0x18A2C3C VA: 0x18A6C3C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x18A6D50 Offset: 0x18A2D50 VA: 0x18A6D50 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18A6DD4 Offset: 0x18A2DD4 VA: 0x18A6DD4 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x18A6EC8 Offset: 0x18A2EC8 VA: 0x18A6EC8
	public void .ctor() { }
}
