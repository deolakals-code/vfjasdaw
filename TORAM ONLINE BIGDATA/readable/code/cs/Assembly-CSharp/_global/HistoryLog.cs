// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HistoryLog : UIBasePanelControl, IUIMenuShortcutClose, IHistoryLogPanel // TypeDefIndex: 7182
{
	// Fields
	[SerializeField]
	private UIIruna2TextList textList; // 0x58
	[SerializeField]
	private UIScrollWindow filterScroll; // 0x60
	[SerializeField]
	private GameObject filterButton; // 0x68
	[SerializeField]
	private float buttonHeight; // 0x70
	[SerializeField]
	private UIIruna2AnchorSimple filterAnchor; // 0x78
	[SerializeField]
	private GameObject filterScrollObject; // 0x80
	[SerializeField]
	private UIIruna2Anchor textListAnchor; // 0x88
	private float defaultLogWidth; // 0x90
	private Dictionary<HistoryLog.ChatType, Pair<UILabel, UIImageButton>> addedButtonLabel; // 0x98
	private Dictionary<HistoryLog.ChatType, bool> filter; // 0xA0
	private bool isShortcutOpen; // 0xA8
	private float lastOpenShortcut; // 0xAC
	private UIMainManager.UIElicitFlag uiElicitFlag; // 0xB0
	private UIBasePanelControl externalTopButtonControl; // 0xB8

	// Properties
	public bool IsShortcutClose { get; }

	// Methods

	// RVA: 0x1AB604C Offset: 0x1AB204C VA: 0x1AB604C
	public static bool CheckHistoryState(UIActiveState activeState) { }

	// RVA: 0x1AB6070 Offset: 0x1AB2070 VA: 0x1AB6070 Slot: 14
	public bool get_IsShortcutClose() { }

	// RVA: 0x1AB60EC Offset: 0x1AB20EC VA: 0x1AB60EC
	private void Awake() { }

	// RVA: 0x1AB626C Offset: 0x1AB226C VA: 0x1AB626C
	private void Start() { }

	// RVA: 0x1AB6BD0 Offset: 0x1AB2BD0 VA: 0x1AB6BD0
	public void InitializeChatText() { }

	// RVA: 0x1AB71A4 Offset: 0x1AB31A4 VA: 0x1AB71A4 Slot: 17
	public void AddChatText(HistoryLog.ChatType type, string name, string message) { }

	// RVA: 0x1AB65F0 Offset: 0x1AB25F0 VA: 0x1AB65F0
	private void initializeFilterScroll() { }

	// RVA: 0x1AB73D8 Offset: 0x1AB33D8 VA: 0x1AB73D8
	private GameObject createFilterButton(GameObject original, string buttonText, int index, int sendParam) { }

	// RVA: 0x1AB7830 Offset: 0x1AB3830 VA: 0x1AB7830
	private void onClick(int param) { }

	// RVA: 0x1AB7598 Offset: 0x1AB3598 VA: 0x1AB7598
	private void updateButtonState(HistoryLog.ChatType key, bool playSound) { }

	// RVA: 0x1AB7A70 Offset: 0x1AB3A70 VA: 0x1AB7A70
	private void onChat() { }

	// RVA: 0x1AB7AC8 Offset: 0x1AB3AC8 VA: 0x1AB7AC8
	private void onClose() { }

	// RVA: 0x1AB7B80 Offset: 0x1AB3B80 VA: 0x1AB7B80 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1AB7B84 Offset: 0x1AB3B84 VA: 0x1AB7B84 Slot: 19
	public void onCloseChatTypeSelect() { }

	// RVA: 0x1AB7DA8 Offset: 0x1AB3DA8 VA: 0x1AB7DA8
	public void OnCloseWaitingChatTypeSelect() { }

	// RVA: 0x1AB7F60 Offset: 0x1AB3F60 VA: 0x1AB7F60 Slot: 18
	public void onOpenChatTypeSelect() { }

	// RVA: 0x1AB802C Offset: 0x1AB402C VA: 0x1AB802C
	public void OnOpenWaitingChatTypeSelect(SmithUIMaterialBase smithBase) { }

	// RVA: 0x1AB7CB0 Offset: 0x1AB3CB0 VA: 0x1AB7CB0
	private void destroyShortcutPanel() { }

	// RVA: 0x1AB8140 Offset: 0x1AB4140 VA: 0x1AB8140
	private void toActiveScroll() { }

	// RVA: 0x1AB8160 Offset: 0x1AB4160 VA: 0x1AB8160
	private void OnDestroy() { }

	// RVA: 0x1AB8164 Offset: 0x1AB4164 VA: 0x1AB8164 Slot: 15
	public void OnChatInput() { }

	// RVA: 0x1AB8250 Offset: 0x1AB4250 VA: 0x1AB8250 Slot: 16
	public void OnChatSend() { }

	[IteratorStateMachine(typeof(HistoryLog.<OnClickArea>d__38))]
	// RVA: 0x1AB82C0 Offset: 0x1AB42C0 VA: 0x1AB82C0
	public IEnumerator OnClickArea(UIClickableEventArea param) { }

	// RVA: 0x1AB8370 Offset: 0x1AB4370 VA: 0x1AB8370
	public void .ctor() { }
}
