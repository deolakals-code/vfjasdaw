// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBCollaborationEnterManager : UIBasePanelConnection // TypeDefIndex: 5621
{
	// Fields
	[SerializeField]
	private GameObject mainPanel; // 0x30
	private UIIruna2Anchor mainAnchor; // 0x38
	[SerializeField]
	private GameObject partyNamePanel; // 0x40
	private UIIruna2Anchor partyNameAnchor; // 0x48
	[SerializeField]
	private GameObject mainTextPanel; // 0x50
	[SerializeField]
	private UIImageButton enterButton; // 0x58
	[SerializeField]
	private UILabel enterLabel; // 0x60
	[SerializeField]
	private GameObject[] partyMemberObj; // 0x68
	protected UIPartyMember[] partyMemberData; // 0x70
	protected TweenPosition[] partyMemberEffect; // 0x78
	[SerializeField]
	private GameObject topObj; // 0x80
	[SerializeField]
	private GameObject bottomObj; // 0x88
	[SerializeField]
	private GameObject errLabel; // 0x90
	[SerializeField]
	private GameObject matchingPanel; // 0x98
	[SerializeField]
	private UILabel matchingTimerLabel; // 0xA0
	[SerializeField]
	private UILabel resetLabel; // 0xA8
	[SerializeField]
	private GameObject weeklyChallengePanel; // 0xB0
	[SerializeField]
	private UIScrollWindow weeklyChallengeScrollWindow; // 0xB8
	[SerializeField]
	private GameObject weeklyChallengeTextElement; // 0xC0
	[SerializeField]
	private GameObject weeklyChallengeElement; // 0xC8
	[SerializeField]
	private UIImageButton[] mainPanelButtons; // 0xD0
	[SerializeField]
	private GameObject matchingCheckObj; // 0xD8
	[SerializeField]
	private UIToggle matchingToggle; // 0xE0
	[SerializeField]
	private UILabel matchingLabel; // 0xE8
	[CompilerGenerated]
	private bool <IsCancel>k__BackingField; // 0xF0
	[CompilerGenerated]
	private bool <IsClose>k__BackingField; // 0xF1
	private UIBCollaborationEnterBasePanel enterBasePanel; // 0xF8
	private PlayerDataManager playerDataManager; // 0x100
	private BCollaborationRoomData roomData; // 0x108
	private GameObject shortcutManager; // 0x110
	private bool openShortcut; // 0x118
	private bool isInit; // 0x119
	private float connectTimer; // 0x11C
	private bool isPartner; // 0x120
	private UIPopBaseWindow popWindow; // 0x128
	private UIPopWindow errPopWindow; // 0x130
	private UIBCollaborationEnterManager.PanelState panelState; // 0x138
	private UIBCollaborationRankingManager rankingManager; // 0x140
	private BCollaborationEventData eventData; // 0x148
	private bool isMatching; // 0x150
	private bool isUserCheckMatching; // 0x151
	private bool isBeforeUserCheckMatching; // 0x152

	// Properties
	public bool IsCancel { get; set; }
	public bool IsClose { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x17A6E50 Offset: 0x17A2E50 VA: 0x17A6E50
	public bool get_IsCancel() { }

	[CompilerGenerated]
	// RVA: 0x17A6E58 Offset: 0x17A2E58 VA: 0x17A6E58
	private void set_IsCancel(bool value) { }

	[CompilerGenerated]
	// RVA: 0x17A6E64 Offset: 0x17A2E64 VA: 0x17A6E64
	public bool get_IsClose() { }

	[CompilerGenerated]
	// RVA: 0x17A6E6C Offset: 0x17A2E6C VA: 0x17A6E6C
	private void set_IsClose(bool value) { }

	// RVA: 0x17A6E78 Offset: 0x17A2E78 VA: 0x17A6E78
	private void Awake() { }

	// RVA: 0x17A6E84 Offset: 0x17A2E84 VA: 0x17A6E84
	private void Start() { }

	// RVA: 0x17A70F4 Offset: 0x17A30F4 VA: 0x17A70F4
	private void Update() { }

	// RVA: 0x17A86A8 Offset: 0x17A46A8 VA: 0x17A86A8
	private void OnDestroy() { }

	// RVA: 0x17A8700 Offset: 0x17A4700 VA: 0x17A8700
	public void Initialize(int fieldId, byte roomId, Vector3 pos, float rot, EmergencyPositionData emergencyPosition) { }

	// RVA: 0x17A8F98 Offset: 0x17A4F98 VA: 0x17A8F98
	public void ForceCancel() { }

	// RVA: 0x17A8FC8 Offset: 0x17A4FC8 VA: 0x17A8FC8
	public void OnBattleReady() { }

	// RVA: 0x17A91DC Offset: 0x17A51DC VA: 0x17A91DC
	public void OnRanking() { }

	// RVA: 0x17A91E4 Offset: 0x17A51E4 VA: 0x17A91E4
	public void OnWeeklyChallenge() { }

	// RVA: 0x17A91EC Offset: 0x17A51EC VA: 0x17A91EC
	public void OnChangeMatchingFlag() { }

	// RVA: 0x17A8B64 Offset: 0x17A4B64 VA: 0x17A8B64
	private void UIInit() { }

	// RVA: 0x17A77A0 Offset: 0x17A37A0 VA: 0x17A77A0
	private void ChangePanelState(UIBCollaborationEnterManager.PanelState panelState) { }

	// RVA: 0x17A85E8 Offset: 0x17A45E8 VA: 0x17A85E8
	private void BattleReadyCancel() { }

	// RVA: 0x17A7684 Offset: 0x17A3684 VA: 0x17A7684
	private void CloseShortcutPanel() { }

	[IteratorStateMachine(typeof(UIBCollaborationEnterManager.<PopErrWindow>d__63))]
	// RVA: 0x17A9D28 Offset: 0x17A5D28 VA: 0x17A9D28
	private IEnumerator PopErrWindow(string title, string text) { }

	// RVA: 0x17A9250 Offset: 0x17A5250 VA: 0x17A9250
	private void UpdateMatchingLabel() { }

	// RVA: 0x17A775C Offset: 0x17A375C VA: 0x17A775C
	private void SendRoomLobbySettingChange() { }

	// RVA: 0x17A6FCC Offset: 0x17A2FCC VA: 0x17A6FCC
	private void SetLeftButtonType(UITopButtonBase.ActionSystemType type) { }

	// RVA: 0x17A7060 Offset: 0x17A3060 VA: 0x17A7060
	private void SetRightButtonType(UITopButtonBase.ActionSystemType type) { }

	// RVA: 0x17A9DEC Offset: 0x17A5DEC VA: 0x17A9DEC Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x17AA018 Offset: 0x17A6018 VA: 0x17AA018 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x17AA088 Offset: 0x17A6088 VA: 0x17AA088 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x17AA178 Offset: 0x17A6178 VA: 0x17AA178
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x17AA28C Offset: 0x17A628C VA: 0x17AA28C
	private void <Initialize>b__53_2() { }

	[CompilerGenerated]
	// RVA: 0x17AA290 Offset: 0x17A6290 VA: 0x17AA290
	private void <ChangePanelState>b__60_0() { }
}
