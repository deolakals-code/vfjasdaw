// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class UIRecruitmentCristaSlotItem : UIBasePanel, IUISignBoard // TypeDefIndex: 9027
{
	// Fields
	private UIRecruitmentCristaSlotItem.PanelState panelState; // 0x2C
	[SerializeField]
	private GameObject windowPanel; // 0x30
	[SerializeField]
	private GameObject titleObj; // 0x38
	[SerializeField]
	private UILabel mainLabel; // 0x40
	[SerializeField]
	private GameObject equipObj; // 0x48
	[SerializeField]
	private UILabel buttonText; // 0x50
	private PlayerDataManager playerDataManager; // 0x58
	private int needItemId; // 0x60
	private ItemData equipItem; // 0x68
	private ItemTextManager itemTextManager; // 0x70
	private ItemManager itemManager; // 0x78
	private int haveItem; // 0x80
	private GameObject shortcutManager; // 0x88
	private bool openShortCut; // 0x90
	private SignboardPropertyData boardData; // 0x98
	private Coroutine activeCoroutine; // 0xA0
	private bool isInit; // 0xA8
	private bool isLogin; // 0xA9
	private bool isPutAwayStart; // 0xAA
	private Coroutine waitCoroutine; // 0xB0
	private SignboardType signBoardType; // 0xB8

	// Properties
	public bool IsOpenShortCutPanel { get; }

	// Methods

	// RVA: 0x1E9616C Offset: 0x1E9216C VA: 0x1E9616C Slot: 7
	public bool get_IsOpenShortCutPanel() { }

	// RVA: 0x1E96174 Offset: 0x1E92174 VA: 0x1E96174
	private void Awake() { }

	// RVA: 0x1E9617C Offset: 0x1E9217C VA: 0x1E9617C
	private void Start() { }

	// RVA: 0x1E96258 Offset: 0x1E92258 VA: 0x1E96258
	private void OnDestroy() { }

	// RVA: 0x1E962B8 Offset: 0x1E922B8 VA: 0x1E962B8
	private void Update() { }

	// RVA: 0x1E96560 Offset: 0x1E92560 VA: 0x1E96560
	public void Initialize(SignboardType boardType, int needItemId, ItemData equipItem, int gold, int slotNo, int cristaUuid) { }

	// RVA: 0x1E96644 Offset: 0x1E92644 VA: 0x1E96644
	public void InitLogin() { }

	// RVA: 0x1E96E3C Offset: 0x1E92E3C VA: 0x1E96E3C
	private void OpenStopWindow() { }

	// RVA: 0x1E968E4 Offset: 0x1E928E4 VA: 0x1E968E4
	private void OpenFailureWindow() { }

	// RVA: 0x1E971DC Offset: 0x1E931DC VA: 0x1E971DC
	public void OpenSuccessWindow(PutAwaySignboardResponse response) { }

	[IteratorStateMachine(typeof(UIRecruitmentCristaSlotItem.<UIinit>d__33))]
	// RVA: 0x1E96588 Offset: 0x1E92588 VA: 0x1E96588
	private IEnumerator UIinit(SignboardType boardType, int needItemId, ItemData equipItem, int gold, int slotNo, int cristaUuid) { }

	// RVA: 0x1E97A3C Offset: 0x1E93A3C VA: 0x1E97A3C
	private void CloseWindow() { }

	[IteratorStateMachine(typeof(UIRecruitmentCristaSlotItem.<WindowActiveFalse>d__35))]
	// RVA: 0x1E97B2C Offset: 0x1E93B2C VA: 0x1E97B2C
	private IEnumerator WindowActiveFalse() { }

	// RVA: 0x1E97138 Offset: 0x1E93138 VA: 0x1E97138
	private void SetTitle(string text, string spriteName) { }

	// RVA: 0x1E97BC0 Offset: 0x1E93BC0 VA: 0x1E97BC0
	private void onButtonMessage() { }

	// RVA: 0x1E9647C Offset: 0x1E9247C VA: 0x1E9647C
	private void CloseShortcutPanel() { }

	[IteratorStateMachine(typeof(UIRecruitmentCristaSlotItem.<PutUpSignBoard>d__39))]
	// RVA: 0x1E97CAC Offset: 0x1E93CAC VA: 0x1E97CAC
	private IEnumerator PutUpSignBoard(SignboardType boardType, ItemData equipItem, int gold, int slotNo, int needItemId, int cristaUuid) { }

	[IteratorStateMachine(typeof(UIRecruitmentCristaSlotItem.<PutAwaySignBoard>d__40))]
	// RVA: 0x1E964F4 Offset: 0x1E924F4 VA: 0x1E964F4
	private IEnumerator PutAwaySignBoard() { }

	// RVA: 0x1E96D14 Offset: 0x1E92D14 VA: 0x1E96D14
	private void SetLeftButtonType(UITopButtonBase.ActionSystemType type) { }

	// RVA: 0x1E96DA8 Offset: 0x1E92DA8 VA: 0x1E96DA8
	private void SetRightButtonType(UITopButtonBase.ActionSystemType type) { }

	// RVA: 0x1E97DB4 Offset: 0x1E93DB4 VA: 0x1E97DB4 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1E97E98 Offset: 0x1E93E98 VA: 0x1E97E98 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1E97FAC Offset: 0x1E93FAC VA: 0x1E97FAC Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x1E98034 Offset: 0x1E94034 VA: 0x1E98034
	public void .ctor() { }
}
