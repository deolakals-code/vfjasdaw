// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ChatWindow : UIIruna2TextList, IChatWindow // TypeDefIndex: 1763
{
	// Fields
	[SerializeField]
	private GameObject inputObject; // 0x68
	[SerializeField]
	private UIWidget background; // 0x70
	[SerializeField]
	private BoxCollider backCollision; // 0x78
	[SerializeField]
	private UIIruna2AnchorSimple historyAssist; // 0x80
	[CompilerGenerated]
	private UILabel <TextLabel>k__BackingField; // 0x88
	private bool hideFlag; // 0x90
	private bool pressed; // 0x91
	private int touchId; // 0x94
	private float waitTimer; // 0x98
	private float waitTime; // 0x9C
	private float defaultHeight; // 0xA0
	private UIInput uiInput; // 0xA8
	private UILabel inputLabel; // 0xB0
	private PlayerDataManager playerDataManager; // 0xB8
	[CompilerGenerated]
	private int <TellTargetId>k__BackingField; // 0xC0
	[CompilerGenerated]
	private string <TellTargetName>k__BackingField; // 0xC8
	private UIClockChatType clockType; // 0xD0
	private SystemTextManager systemTextManager; // 0xD8
	private Queue<string> playerSayQueue; // 0xE0
	private UIIruna2Anchor parentAnchor; // 0xE8
	private int currentChatId; // 0xF0
	private EnemyTextManager enemyTextManager; // 0xF8
	[CompilerGenerated]
	private bool <canOpenHistoryLog>k__BackingField; // 0x100

	// Properties
	public UILabel TextLabel { get; set; }
	public int TellTargetId { get; set; }
	public string TellTargetName { get; set; }
	public virtual bool isOpenChatWindow { get; }
	public List<ChatManager.ChatLog> ChatLogList { get; }
	public bool canOpenHistoryLog { get; set; }
	private float DefaultLogWidth { get; }
	private int DefaultChatRow { get; }
	private int PetPanelChatRow { get; }
	public bool IsPressed { get; }
	private bool IsMobaMatching { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x20C8A68 Offset: 0x20C4A68 VA: 0x20C8A68 Slot: 7
	public UILabel get_TextLabel() { }

	[CompilerGenerated]
	// RVA: 0x20C8A70 Offset: 0x20C4A70 VA: 0x20C8A70
	private void set_TextLabel(UILabel value) { }

	[CompilerGenerated]
	// RVA: 0x20C8A78 Offset: 0x20C4A78 VA: 0x20C8A78
	public int get_TellTargetId() { }

	[CompilerGenerated]
	// RVA: 0x20C8A80 Offset: 0x20C4A80 VA: 0x20C8A80
	public void set_TellTargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x20C8A88 Offset: 0x20C4A88 VA: 0x20C8A88
	public string get_TellTargetName() { }

	[CompilerGenerated]
	// RVA: 0x20C8A90 Offset: 0x20C4A90 VA: 0x20C8A90
	public void set_TellTargetName(string value) { }

	// RVA: 0x20C8A98 Offset: 0x20C4A98 VA: 0x20C8A98 Slot: 9
	public virtual bool get_isOpenChatWindow() { }

	// RVA: 0x20C8AB4 Offset: 0x20C4AB4 VA: 0x20C8AB4
	public List<ChatManager.ChatLog> get_ChatLogList() { }

	[CompilerGenerated]
	// RVA: 0x20C8B04 Offset: 0x20C4B04 VA: 0x20C8B04
	public bool get_canOpenHistoryLog() { }

	[CompilerGenerated]
	// RVA: 0x20C8B0C Offset: 0x20C4B0C VA: 0x20C8B0C
	public void set_canOpenHistoryLog(bool value) { }

	// RVA: 0x20C8B18 Offset: 0x20C4B18 VA: 0x20C8B18
	private float get_DefaultLogWidth() { }

	// RVA: 0x20C8B24 Offset: 0x20C4B24 VA: 0x20C8B24
	private int get_DefaultChatRow() { }

	// RVA: 0x20C8B2C Offset: 0x20C4B2C VA: 0x20C8B2C
	private int get_PetPanelChatRow() { }

	// RVA: 0x20C8B34 Offset: 0x20C4B34 VA: 0x20C8B34
	public bool get_IsPressed() { }

	// RVA: 0x20C8B3C Offset: 0x20C4B3C VA: 0x20C8B3C
	private bool get_IsMobaMatching() { }

	// RVA: 0x20C8BCC Offset: 0x20C4BCC VA: 0x20C8BCC Slot: 10
	protected virtual void Awake() { }

	// RVA: 0x20C8DE8 Offset: 0x20C4DE8 VA: 0x20C8DE8 Slot: 11
	protected virtual void Start() { }

	// RVA: 0x20C8F80 Offset: 0x20C4F80 VA: 0x20C8F80
	public void LoadSettingFromOption() { }

	// RVA: 0x20C9030 Offset: 0x20C5030 VA: 0x20C9030 Slot: 12
	public virtual void Initialize(UIClockChatType clock) { }

	// RVA: 0x20C9038 Offset: 0x20C5038 VA: 0x20C9038 Slot: 13
	protected virtual void Update() { }

	// RVA: 0x20C9DA4 Offset: 0x20C5DA4 VA: 0x20C9DA4 Slot: 4
	protected override void Add(string text, bool updateVisible) { }

	// RVA: 0x20C9CE8 Offset: 0x20C5CE8 VA: 0x20C9CE8
	public void SetHeight(float height) { }

	// RVA: 0x20C9DB4 Offset: 0x20C5DB4 VA: 0x20C9DB4
	public void AddMessage(ChatEvent chat) { }

	// RVA: 0x20C9E08 Offset: 0x20C5E08 VA: 0x20C9E08
	public void AddMessage(int uuid, string message, string name, byte regionCode, ChatChannelType type) { }

	// RVA: 0x20C83FC Offset: 0x20C43FC VA: 0x20C83FC
	public void AddSystemMessage(string message) { }

	// RVA: 0x20C9EE4 Offset: 0x20C5EE4 VA: 0x20C9EE4
	public void AddSystemMessage(ChatManager.SystemChatType type) { }

	// RVA: 0x20C9F38 Offset: 0x20C5F38 VA: 0x20C9F38
	public void AddSystemMessage(ChatManager.SystemChatType type, string[] text) { }

	// RVA: 0x20C9F9C Offset: 0x20C5F9C VA: 0x20C9F9C
	public void AddNPCMessage(string npcName, string message) { }

	// RVA: 0x20CA000 Offset: 0x20C6000 VA: 0x20CA000
	public void AddGMMessage(ChatEvent chat) { }

	// RVA: 0x20CA054 Offset: 0x20C6054 VA: 0x20CA054
	public void AddDamageMessage(string message) { }

	// RVA: 0x20CA0AC Offset: 0x20C60AC VA: 0x20CA0AC
	public void AddAttackMessage(string message) { }

	// RVA: 0x20CA104 Offset: 0x20C6104 VA: 0x20CA104
	public void AddComboMessage(string message) { }

	// RVA: 0x20CA15C Offset: 0x20C615C VA: 0x20CA15C
	public void AddHealMessage(string message) { }

	// RVA: 0x20CA1B4 Offset: 0x20C61B4 VA: 0x20CA1B4
	public void AddErrorMessage(string message) { }

	// RVA: 0x20CA20C Offset: 0x20C620C VA: 0x20CA20C
	public void AddAbnormalEnemyMessage(AbnormalType type, int mobId, int mobUniqueId) { }

	// RVA: 0x20CA630 Offset: 0x20C6630 VA: 0x20CA630
	public void AddAbnormalPlayerMessage(AbnormalType type) { }

	// RVA: 0x20CA7B4 Offset: 0x20C67B4 VA: 0x20CA7B4
	public void EnterFieldGetBanWord(DateTime dateTime) { }

	// RVA: 0x20CA808 Offset: 0x20C6808 VA: 0x20CA808
	public void UpdateBanWord(DateTime dateTime, BanWordData[] words) { }

	// RVA: 0x20CA86C Offset: 0x20C686C VA: 0x20CA86C
	public void CheckBanWordDate(DateTime dateTime) { }

	// RVA: 0x20CA8C0 Offset: 0x20C68C0 VA: 0x20CA8C0
	public string GetChatUserName(string name) { }

	// RVA: 0x20CA91C Offset: 0x20C691C VA: 0x20CA91C Slot: 14
	public virtual void SetLogLines(int lines) { }

	// RVA: 0x20CA9EC Offset: 0x20C69EC VA: 0x20CA9EC Slot: 15
	public virtual void SetFontScale(float scale) { }

	// RVA: 0x20CACD0 Offset: 0x20C6CD0 VA: 0x20CACD0 Slot: 16
	public virtual void SetChatCollisiion(bool isEnabled) { }

	// RVA: 0x20CACF0 Offset: 0x20C6CF0 VA: 0x20CACF0 Slot: 5
	protected override void UpdateVisibleText() { }

	// RVA: 0x20CB434 Offset: 0x20C7434 VA: 0x20CB434
	private void OnPress(bool isPressed) { }

	// RVA: 0x20CB4F0 Offset: 0x20C74F0 VA: 0x20CB4F0
	private void OnDrag(Vector2 delta) { }

	// RVA: 0x20CB5F4 Offset: 0x20C75F4 VA: 0x20CB5F4
	public void OnInput() { }

	// RVA: 0x20CB8CC Offset: 0x20C78CC VA: 0x20CB8CC
	public void OnSubmit() { }

	// RVA: 0x20CB854 Offset: 0x20C7854 VA: 0x20CB854
	private void ResetInputValue() { }

	// RVA: 0x20CC298 Offset: 0x20C8298 VA: 0x20CC298
	public void StartCurrentChat() { }

	// RVA: 0x20CC29C Offset: 0x20C829C VA: 0x20CC29C Slot: 17
	public virtual void StartTellChat(int archetypeId, string userName) { }

	// RVA: 0x20CC37C Offset: 0x20C837C VA: 0x20CC37C
	public void WaitingStartTellChat(int archetypeId, string userName) { }

	[IteratorStateMachine(typeof(ChatWindow.<DelayStartTellChat>d__86))]
	// RVA: 0x20CC39C Offset: 0x20C839C VA: 0x20CC39C
	private IEnumerator DelayStartTellChat(int archetypeId, string userName) { }

	// RVA: 0x20CC454 Offset: 0x20C8454 VA: 0x20CC454 Slot: 18
	public virtual void CancelChat() { }

	// RVA: 0x20CC488 Offset: 0x20C8488 VA: 0x20CC488
	public void SystemSendChat(ChatChannelType chatType, string text) { }

	// RVA: 0x20CC554 Offset: 0x20C8554 VA: 0x20CC554 Slot: 19
	public virtual void ResetChatLogForce() { }

	// RVA: 0x20C9C50 Offset: 0x20C5C50 VA: 0x20C9C50
	private void OutChatLogForce() { }

	// RVA: 0x20CC5C0 Offset: 0x20C85C0 VA: 0x20CC5C0
	private void OnApplicationPause(bool isPause) { }

	// RVA: 0x20CC600 Offset: 0x20C8600 VA: 0x20CC600
	public void SetDefaultChatSize() { }

	// RVA: 0x20CC748 Offset: 0x20C8748 VA: 0x20CC748
	public void DoneChat() { }

	// RVA: 0x20CC764 Offset: 0x20C8764 VA: 0x20CC764 Slot: 8
	public void ChatUpdate(string addMessage) { }

	// RVA: 0x20CC7F8 Offset: 0x20C87F8 VA: 0x20CC7F8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x20CC89C Offset: 0x20C889C VA: 0x20CC89C
	private void <OnSubmit>b__81_0() { }
}
