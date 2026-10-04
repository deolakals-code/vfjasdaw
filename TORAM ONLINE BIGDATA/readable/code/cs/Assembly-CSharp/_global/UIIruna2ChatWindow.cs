// Assembly: Assembly-CSharp.dll
// Namespace: 
[Obsolete("ChatWindowに移行済み")]
public class UIIruna2ChatWindow : UIIruna2TextList // TypeDefIndex: 103
{
	// Fields
	private readonly float defaultLogWidth; // 0x68
	private readonly float defaultFont; // 0x6C
	private readonly int defaultChatRow; // 0x70
	private readonly int petPanelChatRow; // 0x74
	private bool hideFlag; // 0x78
	private bool pressed; // 0x79
	private int touchId; // 0x7C
	private float waitTimer; // 0x80
	private float waitTime; // 0x84
	private float defaultHeight; // 0x88
	[SerializeField]
	private GameObject inputObject; // 0x90
	private UIInput uiInput; // 0x98
	private UILabel inputLabel; // 0xA0
	[SerializeField]
	private UIWidget background; // 0xA8
	[SerializeField]
	private BoxCollider backCollision; // 0xB0
	[SerializeField]
	private UIIruna2AnchorSimple historyAssist; // 0xB8
	private PlayerDataManager playerDataManager; // 0xC0
	[CompilerGenerated]
	private int <TellTargetId>k__BackingField; // 0xC8
	[CompilerGenerated]
	private string <TellTargetName>k__BackingField; // 0xD0
	private UIClockChatType clockType; // 0xD8
	[CompilerGenerated]
	private List<UIIruna2ChatWindow.ChatLog> <ChatLogList>k__BackingField; // 0xE0
	[CompilerGenerated]
	private Dictionary<int, string> <TellChatHistory>k__BackingField; // 0xE8
	private readonly int chatLogMax; // 0xF0
	private SystemTextManager systemTextManager; // 0xF8
	private float fontScale; // 0x100
	private Queue<string> playerSayQueue; // 0x108
	private UIIruna2Anchor parentAnchor; // 0x110
	[CompilerGenerated]
	private DateTime <BanWordUpdateDate>k__BackingField; // 0x118
	private bool firstGetBanWordFlag; // 0x120

	// Properties
	public int TellTargetId { get; set; }
	public string TellTargetName { get; set; }
	public List<UIIruna2ChatWindow.ChatLog> ChatLogList { get; set; }
	public Dictionary<int, string> TellChatHistory { get; set; }
	public bool isOpenChatWindow { get; }
	public DateTime BanWordUpdateDate { get; set; }
	public bool IsPress { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1ED3F0C Offset: 0x1ECFF0C VA: 0x1ED3F0C
	public int get_TellTargetId() { }

	[CompilerGenerated]
	// RVA: 0x1ED3F14 Offset: 0x1ECFF14 VA: 0x1ED3F14
	public void set_TellTargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1ED3F1C Offset: 0x1ECFF1C VA: 0x1ED3F1C
	public string get_TellTargetName() { }

	[CompilerGenerated]
	// RVA: 0x1ED3F24 Offset: 0x1ECFF24 VA: 0x1ED3F24
	public void set_TellTargetName(string value) { }

	[CompilerGenerated]
	// RVA: 0x1ED3F2C Offset: 0x1ECFF2C VA: 0x1ED3F2C
	public List<UIIruna2ChatWindow.ChatLog> get_ChatLogList() { }

	[CompilerGenerated]
	// RVA: 0x1ED3F34 Offset: 0x1ECFF34 VA: 0x1ED3F34
	private void set_ChatLogList(List<UIIruna2ChatWindow.ChatLog> value) { }

	[CompilerGenerated]
	// RVA: 0x1ED3F3C Offset: 0x1ECFF3C VA: 0x1ED3F3C
	public Dictionary<int, string> get_TellChatHistory() { }

	[CompilerGenerated]
	// RVA: 0x1ED3F44 Offset: 0x1ECFF44 VA: 0x1ED3F44
	private void set_TellChatHistory(Dictionary<int, string> value) { }

	// RVA: 0x1ED3F4C Offset: 0x1ECFF4C VA: 0x1ED3F4C
	public bool get_isOpenChatWindow() { }

	[CompilerGenerated]
	// RVA: 0x1ED3F68 Offset: 0x1ECFF68 VA: 0x1ED3F68
	public DateTime get_BanWordUpdateDate() { }

	[CompilerGenerated]
	// RVA: 0x1ED3F70 Offset: 0x1ECFF70 VA: 0x1ED3F70
	public void set_BanWordUpdateDate(DateTime value) { }

	// RVA: 0x1ED3F78 Offset: 0x1ECFF78 VA: 0x1ED3F78
	public bool get_IsPress() { }

	// RVA: 0x1ED3F80 Offset: 0x1ECFF80 VA: 0x1ED3F80
	private void Awake() { }

	// RVA: 0x1ED41A4 Offset: 0x1ED01A4 VA: 0x1ED41A4
	private void Start() { }

	// RVA: 0x1ED41DC Offset: 0x1ED01DC VA: 0x1ED41DC
	public void LoadSettingFromOption() { }

	// RVA: 0x1ED467C Offset: 0x1ED067C VA: 0x1ED467C
	public void Initialize(UIClockChatType clock) { }

	// RVA: 0x1ED4684 Offset: 0x1ED0684 VA: 0x1ED4684
	private void Update() { }

	// RVA: 0x1ED4EC0 Offset: 0x1ED0EC0 VA: 0x1ED4EC0 Slot: 4
	protected override void Add(string text, bool updateVisible) { }

	// RVA: 0x1ED4E08 Offset: 0x1ED0E08 VA: 0x1ED4E08
	public void SetHeight(float height) { }

	// RVA: 0x1ED4F0C Offset: 0x1ED0F0C VA: 0x1ED4F0C
	public void AddMessage(ChatEvent chatEvent) { }

	// RVA: 0x1ED4274 Offset: 0x1ED0274 VA: 0x1ED4274
	public void AddSystemMessage(ChatManager.SystemChatType type) { }

	// RVA: 0x1ED54D4 Offset: 0x1ED14D4 VA: 0x1ED54D4
	public void AddSystemMessage(ChatManager.SystemChatType type, string[] text) { }

	// RVA: 0x1ED55AC Offset: 0x1ED15AC VA: 0x1ED55AC
	public void AddNPCMessage(string npcName, string message) { }

	// RVA: 0x1ED5818 Offset: 0x1ED1818 VA: 0x1ED5818
	public void AddNPCMessage(string message) { }

	// RVA: 0x1ED5404 Offset: 0x1ED1404 VA: 0x1ED5404
	public void AddSystemMessage(string message) { }

	// RVA: 0x1ED5E0C Offset: 0x1ED1E0C VA: 0x1ED5E0C
	public void AddGMMessage(ChatEvent chat) { }

	// RVA: 0x1ED5F7C Offset: 0x1ED1F7C VA: 0x1ED5F7C
	public void AddMarketMessage(int uuid, string message) { }

	// RVA: 0x1ED6050 Offset: 0x1ED2050 VA: 0x1ED6050
	public void AddErrorMessage(string message) { }

	// RVA: 0x1ED6120 Offset: 0x1ED2120 VA: 0x1ED6120
	public void AddDamageMessage(string message) { }

	// RVA: 0x1ED621C Offset: 0x1ED221C VA: 0x1ED621C
	public void AddAttackMessage(string message) { }

	// RVA: 0x1ED6318 Offset: 0x1ED2318 VA: 0x1ED6318
	public void AddComboMessage(string message) { }

	[Obsolete("チャットタイプがないので使用できない")]
	// RVA: 0x1ED6414 Offset: 0x1ED2414 VA: 0x1ED6414
	public void AddDropMessage(string message) { }

	// RVA: 0x1ED5034 Offset: 0x1ED1034 VA: 0x1ED5034
	private void addMessage(int uuid, string message, string name, ChatChannelType type) { }

	// RVA: 0x1ED64E4 Offset: 0x1ED24E4 VA: 0x1ED64E4
	private bool checkChatFilter(int type, OptionChat op) { }

	// RVA: 0x1ED6688 Offset: 0x1ED2688 VA: 0x1ED6688
	private bool checkSystemLogFilter(HistoryLog.ChatType type, OptionChat op) { }

	// RVA: 0x1ED66FC Offset: 0x1ED26FC VA: 0x1ED66FC
	private void addCheckFilter(HistoryLog.ChatType type, string name, string message) { }

	// RVA: 0x1ED5964 Offset: 0x1ED1964 VA: 0x1ED5964
	public string GetChatUserName(string name) { }

	// RVA: 0x1ED5BC4 Offset: 0x1ED1BC4 VA: 0x1ED5BC4
	private void addChatLog(int uuid, HistoryLog.ChatType type, string name, string message) { }

	// RVA: 0x1ED6668 Offset: 0x1ED2668 VA: 0x1ED6668
	private HistoryLog.ChatType chatChannelToChatType(ChatChannelType type) { }

	// RVA: 0x1ED688C Offset: 0x1ED288C VA: 0x1ED688C
	private int chatTypeToChannelChat(HistoryLog.ChatType type) { }

	// RVA: 0x1ED458C Offset: 0x1ED058C VA: 0x1ED458C
	public void SetLogLines(int lines) { }

	// RVA: 0x1ED4334 Offset: 0x1ED0334 VA: 0x1ED4334
	public void SetFontScale(float scale) { }

	// RVA: 0x1ED465C Offset: 0x1ED065C VA: 0x1ED465C
	public void SetChatCollisiion(bool isEnabled) { }

	// RVA: 0x1ED6904 Offset: 0x1ED2904 VA: 0x1ED6904 Slot: 5
	protected override void UpdateVisibleText() { }

	// RVA: 0x1ED6FF4 Offset: 0x1ED2FF4 VA: 0x1ED6FF4
	private void OnPress(bool isPressed) { }

	// RVA: 0x1ED70B0 Offset: 0x1ED30B0 VA: 0x1ED70B0
	private void OnDrag(Vector2 delta) { }

	// RVA: 0x1ED71B4 Offset: 0x1ED31B4 VA: 0x1ED71B4
	public void OnInput() { }

	// RVA: 0x1ED742C Offset: 0x1ED342C VA: 0x1ED742C
	public void OnSubmit() { }

	// RVA: 0x1ED7D00 Offset: 0x1ED3D00 VA: 0x1ED7D00
	public void StartCurrentChat() { }

	// RVA: 0x1ED7D04 Offset: 0x1ED3D04 VA: 0x1ED7D04
	public void StartTellChat(int archetypeId, string userName) { }

	// RVA: 0x1ED7DC4 Offset: 0x1ED3DC4 VA: 0x1ED7DC4
	public void CancelChat() { }

	// RVA: 0x1ED7DF8 Offset: 0x1ED3DF8 VA: 0x1ED7DF8
	public void SystemSendChat(ChatChannelType chatType, string text) { }

	// RVA: 0x1ED7EC8 Offset: 0x1ED3EC8 VA: 0x1ED7EC8
	public void ResetChatLogForce() { }

	// RVA: 0x1ED4D74 Offset: 0x1ED0D74 VA: 0x1ED4D74
	private void OutChatLogForce() { }

	// RVA: 0x1ED7F30 Offset: 0x1ED3F30 VA: 0x1ED7F30
	private void OnApplicationPause(bool isPause) { }

	// RVA: 0x1ED7F64 Offset: 0x1ED3F64 VA: 0x1ED7F64
	public void EnterFieldGetBanWord(DateTime dateTime) { }

	// RVA: 0x1ED8060 Offset: 0x1ED4060 VA: 0x1ED8060
	public void CheckBanWordDate(DateTime datetime) { }

	// RVA: 0x1ED8110 Offset: 0x1ED4110 VA: 0x1ED8110
	public void SetDefaultChatSize() { }

	// RVA: 0x1ED821C Offset: 0x1ED421C VA: 0x1ED821C
	public void .ctor() { }
}
