// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFishingPanelManager : UIBasePanelConnection, IHistoryLogPanel // TypeDefIndex: 7060
{
	// Fields
	[SerializeField]
	private UIFishingPanelAnchorController anchorController; // 0x30
	[SerializeField]
	private UIFishingPanelChummingController chummingController; // 0x38
	[SerializeField]
	private UIFishingGameController miniGameController; // 0x40
	[SerializeField]
	private UILabel coolerBoxButtonLabel; // 0x48
	[SerializeField]
	private UILabel chummingButtonLabel; // 0x50
	[SerializeField]
	private GameObject hitLabelObject; // 0x58
	[SerializeField]
	private GameObject rightMenu; // 0x60
	private CameraManager cameraManager; // 0x68
	private PlayerDataManager playerDataManager; // 0x70
	private GameObject coolerBoxMenuObject; // 0x78
	private UIFishingCoolerBoxMenuController coolerBoxMenuController; // 0x80
	private bool inputLock; // 0x88
	private UIShortcutListManager shortcutListManager; // 0x90
	private bool isOpenShortcut; // 0x98
	private HistoryLog historyLogPanel; // 0xA0
	private UIFishingPanelManager.MainUIStatus mainUIStatus; // 0xA8
	private bool isServerFishing; // 0xAC

	// Properties
	public bool InputLock { get; }
	public SystemTextManager SystemTextManager { get; }

	// Methods

	// RVA: 0x1A83E80 Offset: 0x1A7FE80 VA: 0x1A83E80
	public bool get_InputLock() { }

	// RVA: 0x1A83E88 Offset: 0x1A7FE88 VA: 0x1A83E88
	public SystemTextManager get_SystemTextManager() { }

	// RVA: 0x1A83E90 Offset: 0x1A7FE90 VA: 0x1A83E90
	private void Start() { }

	// RVA: 0x1A846A4 Offset: 0x1A806A4 VA: 0x1A846A4
	private void Update() { }

	// RVA: 0x1A84CB4 Offset: 0x1A80CB4 VA: 0x1A84CB4
	private void OnDestroy() { }

	// RVA: 0x1A840DC Offset: 0x1A800DC VA: 0x1A840DC
	private void Initialize() { }

	// RVA: 0x1A84FBC Offset: 0x1A80FBC VA: 0x1A84FBC
	private void StartFishingResponse(bool isSuccess) { }

	// RVA: 0x1A84484 Offset: 0x1A80484 VA: 0x1A84484
	private void ChangeFishingPanelState(UIFishingPanelManager.MainUIStatus status) { }

	// RVA: 0x1A85388 Offset: 0x1A81388 VA: 0x1A85388
	private void ConfigureMainUIManager(UIFishingPanelManager.MainUIStatus status) { }

	// RVA: 0x1A8593C Offset: 0x1A8193C VA: 0x1A8593C
	private void UpdateCoolerBoxButtonLabel() { }

	// RVA: 0x1A85718 Offset: 0x1A81718 VA: 0x1A85718
	private void UpdateChummingButtonLabel() { }

	// RVA: 0x1A85A34 Offset: 0x1A81A34 VA: 0x1A85A34
	private void TopReturnButton() { }

	// RVA: 0x1A85C74 Offset: 0x1A81C74 VA: 0x1A85C74
	private void TopChatButton() { }

	// RVA: 0x1A849F8 Offset: 0x1A809F8 VA: 0x1A849F8
	private void HitLabelPositionUpdate() { }

	// RVA: 0x1A85D14 Offset: 0x1A81D14 VA: 0x1A85D14
	private void LeftTopButton() { }

	// RVA: 0x1A85E70 Offset: 0x1A81E70 VA: 0x1A85E70
	private void RightTopButton() { }

	// RVA: 0x1A85F3C Offset: 0x1A81F3C VA: 0x1A85F3C
	public void ChangeInputLockFlag(bool isActive) { }

	// RVA: 0x1A83964 Offset: 0x1A7F964 VA: 0x1A83964
	public void ChangeFishingPanelToMainUI() { }

	// RVA: 0x1A85F48 Offset: 0x1A81F48 VA: 0x1A85F48
	public void ChangeFishingPanelToMiniGame() { }

	// RVA: 0x1A85F50 Offset: 0x1A81F50 VA: 0x1A85F50
	public void OnClickViewModeButton() { }

	// RVA: 0x1A86004 Offset: 0x1A82004 VA: 0x1A86004
	public void OnClickScreenShotButton() { }

	// RVA: 0x1A860BC Offset: 0x1A820BC VA: 0x1A860BC
	public void OnClickCoolerBoxButton() { }

	// RVA: 0x1A86148 Offset: 0x1A82148 VA: 0x1A86148
	public void OnClickFeedButton() { }

	// RVA: 0x1A852DC Offset: 0x1A812DC VA: 0x1A852DC
	public void ChangeActiveHitLabel(bool isActive) { }

	// RVA: 0x1A8623C Offset: 0x1A8223C VA: 0x1A8623C
	public void OnClickHitLabel() { }

	// RVA: 0x1A86370 Offset: 0x1A82370 VA: 0x1A86370 Slot: 8
	public void OnChatInput() { }

	// RVA: 0x1A86384 Offset: 0x1A82384 VA: 0x1A86384 Slot: 9
	public void OnChatSend() { }

	// RVA: 0x1A86398 Offset: 0x1A82398 VA: 0x1A86398 Slot: 10
	public void AddChatText(HistoryLog.ChatType type, string name, string message) { }

	// RVA: 0x1A863AC Offset: 0x1A823AC VA: 0x1A863AC Slot: 11
	public void onOpenChatTypeSelect() { }

	// RVA: 0x1A849DC Offset: 0x1A809DC VA: 0x1A849DC Slot: 12
	public void onCloseChatTypeSelect() { }

	// RVA: 0x1A8644C Offset: 0x1A8244C VA: 0x1A8644C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1A86450 Offset: 0x1A82450 VA: 0x1A86450 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1A86454 Offset: 0x1A82454 VA: 0x1A86454 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x1A865C0 Offset: 0x1A825C0 VA: 0x1A865C0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1A865D4 Offset: 0x1A825D4 VA: 0x1A865D4
	private void <ConfigureMainUIManager>b__28_0() { }
}
