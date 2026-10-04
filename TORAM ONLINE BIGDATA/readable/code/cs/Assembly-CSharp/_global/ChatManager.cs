// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ChatManager : Singleton<ChatManager> // TypeDefIndex: 1761
{
	// Fields
	public const string GMChatColor = "[EE82EE]";
	private static readonly float UnreceivedMessageGetWaitTime; // 0x0
	private static readonly float ReacquisitionIntervalTime; // 0x4
	private static readonly int UnreceivedMessageRetryMaxNum; // 0x8
	private Dictionary<int, List<ChatManager.ChatData>> chatList; // 0x20
	private List<ChatManager.ChatLog> chatLogList; // 0x28
	private float fontScale; // 0x30
	private PlayerDataManager playerData; // 0x38
	private DateTime[] latestMsgTime; // 0x40
	[CompilerGenerated]
	private IChatWindow <ChatWindow>k__BackingField; // 0x48
	protected SystemTextManager systemTextManager; // 0x50
	[CompilerGenerated]
	private int <TellTargetId>k__BackingField; // 0x58
	[CompilerGenerated]
	private string <TellTargetName>k__BackingField; // 0x60
	[CompilerGenerated]
	private ChatChannelType <ChatType>k__BackingField; // 0x68
	[CompilerGenerated]
	private Dictionary<int, string> <TellChatHistory>k__BackingField; // 0x70
	[CompilerGenerated]
	private DateTime <BanWordUpdateDate>k__BackingField; // 0x78
	[CompilerGenerated]
	private Dictionary<byte, string> <BanWords>k__BackingField; // 0x80
	[CompilerGenerated]
	private Dictionary<byte, List<int>> <BanWordFields>k__BackingField; // 0x88
	private bool firstGetBanWordFlag; // 0x90
	private List<ChatData> chatMessageBuffList; // 0x98
	private List<ChatData> chatMessageGuildBuffList; // 0xA0
	private bool[] canChatUpdate; // 0xA8
	private float addWaitTime; // 0xB0
	private int[] receiveErrorCount; // 0xB8
	private float[] lastUnreceivedMessageAcquisitionTime; // 0xC0
	private int chatCount; // 0xC8
	private DateTime lastSendChatTime; // 0xD0
	private DateTime limitSendChatTime; // 0xD8
	private bool isAddMessageLock; // 0xE0
	private const int maxAddLockCount = 3;
	private const int MaxMacroLength = 30;
	protected Dictionary<int, TellHistoryData> tellHistoryDataList; // 0xE8
	protected static string tellHistorySaveKey; // 0x10
	private string tellHistoryLineCountKey; // 0xF0
	private readonly int[] tellHistoryLineCountList; // 0xF8
	private int tellHistoryLineCountData; // 0x100
	private string tellHistoryDeleteOptionKey; // 0x108
	private readonly int[] tellHistoryDeleteList; // 0x110
	private int tellHistoryDeleteData; // 0x118

	// Properties
	public List<ChatManager.ChatLog> ChatLogList { get; }
	public float FontScale { get; set; }
	public PlayerDataManager playerDataManager { get; }
	private DateTime LatestPartyMsgTime { get; }
	private DateTime LatestGuildMsgTime { get; }
	private int ChatLogMax { get; }
	public float DefaultFont { get; }
	public virtual IChatWindow ChatWindow { get; set; }
	public int TellTargetId { get; set; }
	public string TellTargetName { get; set; }
	public ChatChannelType ChatType { get; set; }
	public Dictionary<int, string> TellChatHistory { get; set; }
	public DateTime BanWordUpdateDate { get; set; }
	public Dictionary<byte, string> BanWords { get; set; }
	public Dictionary<byte, List<int>> BanWordFields { get; set; }
	public Dictionary<int, TellHistoryData> TellHistoryDataList { get; }
	public TellHistoryData TellHistoryNewData { get; }
	public int TellHistoryMaxCount { get; }
	public int TellHistoryLineCount { get; }
	public int TellHistoryLineCountData { get; }
	public int TellHistoryDeleteData { get; }
	public float TellHistoryDeleteTime { get; }

	// Methods

	// RVA: 0x20C1478 Offset: 0x20BD478 VA: 0x20C1478
	public List<ChatManager.ChatLog> get_ChatLogList() { }

	// RVA: 0x20C1480 Offset: 0x20BD480 VA: 0x20C1480
	public float get_FontScale() { }

	// RVA: 0x20C1488 Offset: 0x20BD488 VA: 0x20C1488
	public void set_FontScale(float value) { }

	// RVA: 0x20C149C Offset: 0x20BD49C VA: 0x20C149C
	public PlayerDataManager get_playerDataManager() { }

	// RVA: 0x20C1520 Offset: 0x20BD520 VA: 0x20C1520
	private DateTime get_LatestPartyMsgTime() { }

	// RVA: 0x20C1548 Offset: 0x20BD548 VA: 0x20C1548
	private DateTime get_LatestGuildMsgTime() { }

	// RVA: 0x20C1574 Offset: 0x20BD574 VA: 0x20C1574
	private int get_ChatLogMax() { }

	// RVA: 0x20C157C Offset: 0x20BD57C VA: 0x20C157C
	public float get_DefaultFont() { }

	[CompilerGenerated]
	// RVA: 0x20C1588 Offset: 0x20BD588 VA: 0x20C1588 Slot: 4
	public virtual IChatWindow get_ChatWindow() { }

	[CompilerGenerated]
	// RVA: 0x20C1590 Offset: 0x20BD590 VA: 0x20C1590 Slot: 5
	public virtual void set_ChatWindow(IChatWindow value) { }

	[CompilerGenerated]
	// RVA: 0x20C1598 Offset: 0x20BD598 VA: 0x20C1598
	public int get_TellTargetId() { }

	[CompilerGenerated]
	// RVA: 0x20C15A0 Offset: 0x20BD5A0 VA: 0x20C15A0
	private void set_TellTargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x20C15A8 Offset: 0x20BD5A8 VA: 0x20C15A8
	public string get_TellTargetName() { }

	[CompilerGenerated]
	// RVA: 0x20C15B0 Offset: 0x20BD5B0 VA: 0x20C15B0
	private void set_TellTargetName(string value) { }

	[CompilerGenerated]
	// RVA: 0x20C15B8 Offset: 0x20BD5B8 VA: 0x20C15B8
	public ChatChannelType get_ChatType() { }

	[CompilerGenerated]
	// RVA: 0x20C15C0 Offset: 0x20BD5C0 VA: 0x20C15C0
	protected void set_ChatType(ChatChannelType value) { }

	[CompilerGenerated]
	// RVA: 0x20C15C8 Offset: 0x20BD5C8 VA: 0x20C15C8
	public Dictionary<int, string> get_TellChatHistory() { }

	[CompilerGenerated]
	// RVA: 0x20C15D0 Offset: 0x20BD5D0 VA: 0x20C15D0
	private void set_TellChatHistory(Dictionary<int, string> value) { }

	[CompilerGenerated]
	// RVA: 0x20C15D8 Offset: 0x20BD5D8 VA: 0x20C15D8
	public DateTime get_BanWordUpdateDate() { }

	[CompilerGenerated]
	// RVA: 0x20C15E0 Offset: 0x20BD5E0 VA: 0x20C15E0
	private void set_BanWordUpdateDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x20C15E8 Offset: 0x20BD5E8 VA: 0x20C15E8
	public Dictionary<byte, string> get_BanWords() { }

	[CompilerGenerated]
	// RVA: 0x20C15F0 Offset: 0x20BD5F0 VA: 0x20C15F0
	private void set_BanWords(Dictionary<byte, string> value) { }

	[CompilerGenerated]
	// RVA: 0x20C15F8 Offset: 0x20BD5F8 VA: 0x20C15F8
	public Dictionary<byte, List<int>> get_BanWordFields() { }

	[CompilerGenerated]
	// RVA: 0x20C1600 Offset: 0x20BD600 VA: 0x20C1600
	private void set_BanWordFields(Dictionary<byte, List<int>> value) { }

	// RVA: 0x20C1608 Offset: 0x20BD608 VA: 0x20C1608
	public Dictionary<int, TellHistoryData> get_TellHistoryDataList() { }

	// RVA: 0x20C1610 Offset: 0x20BD610 VA: 0x20C1610
	public TellHistoryData get_TellHistoryNewData() { }

	// RVA: 0x20C177C Offset: 0x20BD77C VA: 0x20C177C
	public int get_TellHistoryMaxCount() { }

	// RVA: 0x20C1784 Offset: 0x20BD784 VA: 0x20C1784
	public int get_TellHistoryLineCount() { }

	// RVA: 0x20C17CC Offset: 0x20BD7CC VA: 0x20C17CC
	public int get_TellHistoryLineCountData() { }

	// RVA: 0x20C17D4 Offset: 0x20BD7D4 VA: 0x20C17D4
	public int get_TellHistoryDeleteData() { }

	// RVA: 0x20C17DC Offset: 0x20BD7DC VA: 0x20C17DC
	public float get_TellHistoryDeleteTime() { }

	// RVA: 0x20C1824 Offset: 0x20BD824 VA: 0x20C1824 Slot: 6
	protected virtual void Awake() { }

	// RVA: 0x20C1D8C Offset: 0x20BDD8C VA: 0x20C1D8C
	private void Start() { }

	// RVA: 0x20C1EA4 Offset: 0x20BDEA4 VA: 0x20C1EA4
	private void Update() { }

	// RVA: 0x20C1EBC Offset: 0x20BDEBC VA: 0x20C1EBC
	private void BuffMessageCheck() { }

	// RVA: 0x20C1FF8 Offset: 0x20BDFF8 VA: 0x20C1FF8
	private void ShowChatMessage() { }

	// RVA: 0x20C27AC Offset: 0x20BE7AC VA: 0x20C27AC
	private bool ExistsWaitingChatMessage() { }

	// RVA: 0x20C2B48 Offset: 0x20BEB48 VA: 0x20C2B48
	public bool SendChat(ChatChannelType chatType, string text, int targetId, bool isMacro = False) { }

	// RVA: 0x20C2CE8 Offset: 0x20BECE8 VA: 0x20C2CE8
	public bool SendSystemMessage(ChatChannelType chatType, short id) { }

	// RVA: 0x20C2FCC Offset: 0x20BEFCC VA: 0x20C2FCC
	public void AddMessage(ChatEvent chat) { }

	// RVA: 0x20C3390 Offset: 0x20BF390 VA: 0x20C3390
	public void AddMessage(string message, ChatManager.ChatMessageType type) { }

	// RVA: 0x20C3568 Offset: 0x20BF568 VA: 0x20C3568
	public void AddSystemMessage(ChatManager.SystemChatType type) { }

	// RVA: 0x20C362C Offset: 0x20BF62C VA: 0x20C362C
	public void AddSystemMessage(ChatManager.SystemChatType type, string[] text) { }

	// RVA: 0x20C3708 Offset: 0x20BF708 VA: 0x20C3708
	public void AddNPCMessage(string name, string message) { }

	// RVA: 0x20C3860 Offset: 0x20BF860 VA: 0x20C3860
	public void AddMessageEvent(ChatData receive, DateTime prevTimeStamp) { }

	// RVA: 0x20C3C24 Offset: 0x20BFC24 VA: 0x20C3C24
	public void AddUnreceivedMessage(ChatData[] chatData, int type, DateTime loginTime) { }

	// RVA: 0x20C425C Offset: 0x20C025C VA: 0x20C425C
	public void AddFiexdText(SystemChatEvent chatEvent) { }

	// RVA: 0x20C2510 Offset: 0x20BE510 VA: 0x20C2510
	private void AddBuffMessage() { }

	// RVA: 0x20C3AD8 Offset: 0x20BFAD8 VA: 0x20C3AD8
	private void AddChatList(ChatData receive, int listType, int latesMsgType) { }

	// RVA: 0x20C454C Offset: 0x20C054C VA: 0x20C454C
	private void ChatEventMessageReplace(ChatManager.ChatData data) { }

	// RVA: 0x20C3AC8 Offset: 0x20BFAC8 VA: 0x20C3AC8
	private int GetUnreceivedMessageType(byte type) { }

	// RVA: 0x20C4690 Offset: 0x20C0690 VA: 0x20C4690
	public void LatestPartyMsgTimeInitialize(int id) { }

	// RVA: 0x20C46DC Offset: 0x20C06DC VA: 0x20C46DC
	public void LatestMsgTimeInitialize(int type) { }

	// RVA: 0x20C4764 Offset: 0x20C0764 VA: 0x20C4764
	public void AllLatestMsgTimeInitialize() { }

	// RVA: 0x20C4804 Offset: 0x20C0804 VA: 0x20C4804
	public void ChatUpdateFlagEnabled(int type) { }

	// RVA: 0x20C4838 Offset: 0x20C0838 VA: 0x20C4838
	public void ChatUpdateFlagReset() { }

	// RVA: 0x20C2200 Offset: 0x20BE200 VA: 0x20C2200
	public void UnreceivedPartyMessage() { }

	// RVA: 0x20C2358 Offset: 0x20BE358 VA: 0x20C2358
	public void UnreceivedGuildMessage() { }

	// RVA: 0x20C4888 Offset: 0x20C0888 VA: 0x20C4888
	public void UnreceivedGuildMessage(DateTime response) { }

	// RVA: 0x20C4938 Offset: 0x20C0938 VA: 0x20C4938
	public void UnreceivedPartyMessageFailure(short returnCode) { }

	// RVA: 0x20C49F4 Offset: 0x20C09F4 VA: 0x20C49F4
	public void UnreceivedGuildMessageFailure(short returnCode) { }

	// RVA: 0x20C4AB8 Offset: 0x20C0AB8 VA: 0x20C4AB8
	public void AddMobaKillLog(MobaKillEvent kill) { }

	// RVA: 0x20C4E48 Offset: 0x20C0E48 VA: 0x20C4E48
	public void AddMobaDuelAbilityMessage(MobaDuelAbilityType type, object[] param) { }

	// RVA: 0x20C50D0 Offset: 0x20C10D0 VA: 0x20C50D0
	public void AddChatLog(int uuid, HistoryLog.ChatType type, string name, string message, byte regionCode) { }

	// RVA: 0x20C50D8 Offset: 0x20C10D8 VA: 0x20C50D8
	public void AddChatLog(int uuid, HistoryLog.ChatType type, string name, string message, byte regionCode, DateTime timeStamp) { }

	// RVA: 0x20C57A4 Offset: 0x20C17A4 VA: 0x20C57A4
	private bool CheckSystemLogFilter(HistoryLog.ChatType type, OptionChat op) { }

	// RVA: 0x20C582C Offset: 0x20C182C VA: 0x20C582C
	private int ChatTypeToChannelChat(HistoryLog.ChatType type) { }

	// RVA: 0x20C584C Offset: 0x20C184C VA: 0x20C584C
	public HistoryLog.ChatType ChatChannelToChatType(ChatChannelType type) { }

	// RVA: 0x20C586C Offset: 0x20C186C VA: 0x20C586C
	public bool CheckPlayerChatFilter(int type, OptionChat op) { }

	// RVA: 0x20C4674 Offset: 0x20C0674 VA: 0x20C4674
	private LocalizeManager.NGThread GetNgThraedType(ChatChannelType type) { }

	// RVA: 0x20C59F0 Offset: 0x20C19F0 VA: 0x20C59F0
	public string CheckLogFilter(HistoryLog.ChatType type, string name, string message) { }

	// RVA: 0x20C5B94 Offset: 0x20C1B94 VA: 0x20C5B94
	private string AddLogMessage(ChatEvent chatEvent, DateTime timeStamp) { }

	// RVA: 0x20C5FA4 Offset: 0x20C1FA4 VA: 0x20C5FA4
	public string AddLogMessage(int uuid, string message, string name, byte regionCode, ChatChannelType type) { }

	// RVA: 0x20C5C50 Offset: 0x20C1C50 VA: 0x20C5C50
	public string AddLogMessage(int uuid, int targetId, string message, string name, byte regionCode, ChatChannelType type, DateTime timeStamp) { }

	// RVA: 0x20C5FD4 Offset: 0x20C1FD4 VA: 0x20C5FD4 Slot: 7
	protected virtual void AddTellChatHistory(int uuid, int targetId, string message, string name, byte regionCode, ChatChannelType type, DateTime timeStamp) { }

	// RVA: 0x20C65C8 Offset: 0x20C25C8 VA: 0x20C65C8
	private string AddGMLogMessage(ChatEvent chat) { }

	// RVA: 0x20C6744 Offset: 0x20C2744 VA: 0x20C6744
	private string AddNPCLogMessage(string npcName, string message) { }

	// RVA: 0x20C6968 Offset: 0x20C2968 VA: 0x20C6968
	private string AddBattleLogMessage(string message, OptionChat.BattleLogFlag flag, HistoryLog.ChatType type) { }

	// RVA: 0x20C6A78 Offset: 0x20C2A78 VA: 0x20C6A78
	private string AddSystemLogMessage(int uuid, string message, HistoryLog.ChatType type) { }

	// RVA: 0x20C6B58 Offset: 0x20C2B58 VA: 0x20C6B58
	public void EnterFieldGetBanWord(DateTime dateTime) { }

	// RVA: 0x20C6C5C Offset: 0x20C2C5C VA: 0x20C6C5C
	public void UpdateBanWord(DateTime dateTime, BanWordData[] words) { }

	// RVA: 0x20C6E64 Offset: 0x20C2E64 VA: 0x20C6E64
	public void CheckBanWordDate(DateTime datetime) { }

	// RVA: 0x20C6F14 Offset: 0x20C2F14 VA: 0x20C6F14 Slot: 8
	protected virtual void UpdateChatMessage(ChatManager.ChatData data) { }

	// RVA: 0x20C31FC Offset: 0x20BF1FC VA: 0x20C31FC
	protected bool IsGMMessage(byte type) { }

	// RVA: 0x20C29A0 Offset: 0x20BE9A0 VA: 0x20C29A0
	private void CheckNGWordReset(ChatManager.ChatData data) { }

	// RVA: 0x20C7140 Offset: 0x20C3140 VA: 0x20C7140 Slot: 9
	public virtual string GetChatUserName(string name) { }

	// RVA: 0x20C75D8 Offset: 0x20C35D8 VA: 0x20C75D8
	public void SetTellTargetData(int id, string name) { }

	// RVA: 0x20C56CC Offset: 0x20C16CC VA: 0x20C56CC
	protected bool CheckAddMessageLock(ChatManager.ChatLog log) { }

	// RVA: 0x20C1A6C Offset: 0x20BDA6C VA: 0x20C1A6C
	private void GetLocalTellHistoryList() { }

	// RVA: 0x20C75E8 Offset: 0x20C35E8 VA: 0x20C75E8 Slot: 10
	protected virtual void LoadTellHistoryData(int id, string userName, string text, byte regionCode, DateTime dateTime) { }

	// RVA: 0x20C63E8 Offset: 0x20C23E8 VA: 0x20C63E8
	protected void SetLocalTellHistoryList() { }

	// RVA: 0x20C1A0C Offset: 0x20BDA0C VA: 0x20C1A0C
	private void GetTellHistoryLineCount() { }

	// RVA: 0x20C7728 Offset: 0x20C3728 VA: 0x20C7728
	public void SetTellHistoryLineCount(int data) { }

	// RVA: 0x20C774C Offset: 0x20C374C VA: 0x20C774C
	public void RemoveTellHistory(int id) { }

	// RVA: 0x20C77E4 Offset: 0x20C37E4 VA: 0x20C77E4
	public void ResponseTellIdHistory(int id) { }

	// RVA: 0x20C7868 Offset: 0x20C3868 VA: 0x20C7868 Slot: 11
	public virtual void UpdateTellHistoryLineCount(int add) { }

	// RVA: 0x20C79FC Offset: 0x20C39FC VA: 0x20C79FC
	public void ClearTellHistory() { }

	// RVA: 0x20C7A78 Offset: 0x20C3A78 VA: 0x20C7A78
	public void SetTellHistoryDeleteTime(int data) { }

	// RVA: 0x20C1A3C Offset: 0x20BDA3C VA: 0x20C1A3C
	private void GetTellHistoryDeleteTime() { }

	// RVA: 0x20C7A9C Offset: 0x20C3A9C VA: 0x20C7A9C
	public bool TryMacroProcess(string inputText, byte channelType, int targetId, Action sendAction) { }

	// RVA: 0x20C3210 Offset: 0x20BF210 VA: 0x20C3210
	public void AddMacroMessage(ChatMacroResultData data, string userName) { }

	// RVA: 0x20C7D10 Offset: 0x20C3D10 VA: 0x20C7D10 Slot: 12
	public virtual void SetChatType(ChatChannelType type) { }

	// RVA: 0x20C7D14 Offset: 0x20C3D14 VA: 0x20C7D14 Slot: 13
	public virtual bool GetDispUpdate() { }

	// RVA: 0x20C7D1C Offset: 0x20C3D1C VA: 0x20C7D1C Slot: 14
	public virtual List<TellHistoryData> GetTellChatData(int archeTypeId) { }

	// RVA: 0x20C7D24 Offset: 0x20C3D24 VA: 0x20C7D24
	public void .ctor() { }

	// RVA: 0x20C8104 Offset: 0x20C4104 VA: 0x20C8104
	private static void .cctor() { }
}
