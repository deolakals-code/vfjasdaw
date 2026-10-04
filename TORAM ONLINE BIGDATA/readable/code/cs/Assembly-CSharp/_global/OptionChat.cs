// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class OptionChat // TypeDefIndex: 5361
{
	// Fields
	[CompilerGenerated]
	private Color <SayChatColor>k__BackingField; // 0x10
	[CompilerGenerated]
	private Color <ShoutChatColor>k__BackingField; // 0x20
	[CompilerGenerated]
	private Color <PartyChatColor>k__BackingField; // 0x30
	[CompilerGenerated]
	private Color <GuildChatColor>k__BackingField; // 0x40
	[CompilerGenerated]
	private Color <TellChatColor>k__BackingField; // 0x50
	[CompilerGenerated]
	private Color <WorldChatColor>k__BackingField; // 0x60
	[CompilerGenerated]
	private Color <BattleLogColor>k__BackingField; // 0x70
	[CompilerGenerated]
	private Color <SystemLogColor>k__BackingField; // 0x80
	[CompilerGenerated]
	private Color <WarningLogColor>k__BackingField; // 0x90
	[CompilerGenerated]
	private Color <GMMessageColor>k__BackingField; // 0xA0
	[CompilerGenerated]
	private bool <ShowSayChat>k__BackingField; // 0xB0
	[CompilerGenerated]
	private bool <ShowShoutChat>k__BackingField; // 0xB1
	[CompilerGenerated]
	private bool <ShowPartyChat>k__BackingField; // 0xB2
	[CompilerGenerated]
	private bool <ShowGuildChat>k__BackingField; // 0xB3
	[CompilerGenerated]
	private bool <ShowTellChat>k__BackingField; // 0xB4
	[CompilerGenerated]
	private bool <ShowWorldChat>k__BackingField; // 0xB5
	[CompilerGenerated]
	private OptionChat.BattleLogFlag <ShowBattleLog>k__BackingField; // 0xB8
	[CompilerGenerated]
	private bool <ShowEventLog>k__BackingField; // 0xBC
	[CompilerGenerated]
	private bool <ChatNameSpace>k__BackingField; // 0xBD
	[CompilerGenerated]
	private byte <ChatWindowSelectRowSpace>k__BackingField; // 0xBE
	[CompilerGenerated]
	private bool <ChatWindowTap>k__BackingField; // 0xBF
	[CompilerGenerated]
	private byte <ChatWindowSelectFontSize>k__BackingField; // 0xC0
	[CompilerGenerated]
	private byte <ChatWindowSelectNewFontSize>k__BackingField; // 0xC1
	protected float[] ChatFontSizeList; // 0xC8
	[CompilerGenerated]
	private byte <SelectChatWindowPosition>k__BackingField; // 0xD0
	[CompilerGenerated]
	private bool <DispEmotionBar>k__BackingField; // 0xD1
	public List<OptionChat.PCChatFilterData> filterDataList; // 0xD8
	public const int DefaultSelectRowSpace = 4;
	public const int DefaultSelectFontSize = 6;
	public const int DefaultPosition = 6;
	public static readonly Color32 DefaultSayChatColor; // 0x0
	public static readonly Color32 DefaultShoutChatColor; // 0x4
	public static readonly Color32 DefaultPartyChatColor; // 0x8
	public static readonly Color32 DefaultGuildChatColor; // 0xC
	public static readonly Color32 DefaultTellChatColor; // 0x10
	public static readonly Color32 DefaultWorldChatColor; // 0x14
	public static readonly Color32 DefaultSystemLogColor; // 0x18
	public static readonly Color32 DefaultWarningLogColor; // 0x1C
	public static readonly Color32 DefaultGMMessageColor; // 0x20
	public static readonly Color32 DefaultBattleLogColor; // 0x24

	// Properties
	[SerializeField]
	public Color SayChatColor { get; set; }
	[SerializeField]
	public Color ShoutChatColor { get; set; }
	[SerializeField]
	public Color PartyChatColor { get; set; }
	[SerializeField]
	public Color GuildChatColor { get; set; }
	[SerializeField]
	public Color TellChatColor { get; set; }
	[SerializeField]
	public Color WorldChatColor { get; set; }
	[SerializeField]
	public Color BattleLogColor { get; set; }
	[SerializeField]
	public Color SystemLogColor { get; set; }
	[SerializeField]
	public Color WarningLogColor { get; set; }
	[SerializeField]
	public Color GMMessageColor { get; set; }
	[SerializeField]
	public bool ShowSayChat { get; set; }
	[SerializeField]
	public bool ShowShoutChat { get; set; }
	[SerializeField]
	public bool ShowPartyChat { get; set; }
	[SerializeField]
	public bool ShowGuildChat { get; set; }
	[SerializeField]
	public bool ShowTellChat { get; set; }
	[SerializeField]
	public bool ShowWorldChat { get; set; }
	[SerializeField]
	public OptionChat.BattleLogFlag ShowBattleLog { get; set; }
	[SerializeField]
	public bool ShowEventLog { get; set; }
	[SerializeField]
	public bool ChatNameSpace { get; set; }
	public byte ChatWindowSelectRowSpace { get; set; }
	[SerializeField]
	public byte ChatWindowRow { get; }
	[SerializeField]
	public bool ChatWindowTap { get; set; }
	[SerializeField]
	public byte ChatWindowSelectFontSize { get; set; }
	[SerializeField]
	public byte ChatWindowSelectNewFontSize { get; set; }
	public float ChatWindowFontSize { get; }
	public float DefaultFontSize { get; }
	public int ChatWindowPosition { get; }
	[SerializeField]
	public byte SelectChatWindowPosition { get; set; }
	public bool FullScreenChat { get; set; }
	[SerializeField]
	public bool DispEmotionBar { get; set; }
	public byte ShowChatBitFlag { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x264A208 Offset: 0x2646208 VA: 0x264A208
	private void set_SayChatColor(Color value) { }

	[CompilerGenerated]
	// RVA: 0x264A214 Offset: 0x2646214 VA: 0x264A214
	public Color get_SayChatColor() { }

	[CompilerGenerated]
	// RVA: 0x264A220 Offset: 0x2646220 VA: 0x264A220
	private void set_ShoutChatColor(Color value) { }

	[CompilerGenerated]
	// RVA: 0x264A22C Offset: 0x264622C VA: 0x264A22C
	public Color get_ShoutChatColor() { }

	[CompilerGenerated]
	// RVA: 0x264A238 Offset: 0x2646238 VA: 0x264A238
	private void set_PartyChatColor(Color value) { }

	[CompilerGenerated]
	// RVA: 0x264A244 Offset: 0x2646244 VA: 0x264A244
	public Color get_PartyChatColor() { }

	[CompilerGenerated]
	// RVA: 0x264A250 Offset: 0x2646250 VA: 0x264A250
	private void set_GuildChatColor(Color value) { }

	[CompilerGenerated]
	// RVA: 0x264A25C Offset: 0x264625C VA: 0x264A25C
	public Color get_GuildChatColor() { }

	[CompilerGenerated]
	// RVA: 0x264A268 Offset: 0x2646268 VA: 0x264A268
	private void set_TellChatColor(Color value) { }

	[CompilerGenerated]
	// RVA: 0x264A274 Offset: 0x2646274 VA: 0x264A274
	public Color get_TellChatColor() { }

	[CompilerGenerated]
	// RVA: 0x264A280 Offset: 0x2646280 VA: 0x264A280
	private void set_WorldChatColor(Color value) { }

	[CompilerGenerated]
	// RVA: 0x264A28C Offset: 0x264628C VA: 0x264A28C
	public Color get_WorldChatColor() { }

	[CompilerGenerated]
	// RVA: 0x264A298 Offset: 0x2646298 VA: 0x264A298
	private void set_BattleLogColor(Color value) { }

	[CompilerGenerated]
	// RVA: 0x264A2A4 Offset: 0x26462A4 VA: 0x264A2A4
	public Color get_BattleLogColor() { }

	[CompilerGenerated]
	// RVA: 0x264A2B0 Offset: 0x26462B0 VA: 0x264A2B0
	private void set_SystemLogColor(Color value) { }

	[CompilerGenerated]
	// RVA: 0x264A2BC Offset: 0x26462BC VA: 0x264A2BC
	public Color get_SystemLogColor() { }

	[CompilerGenerated]
	// RVA: 0x264A2C8 Offset: 0x26462C8 VA: 0x264A2C8
	private void set_WarningLogColor(Color value) { }

	[CompilerGenerated]
	// RVA: 0x264A2D4 Offset: 0x26462D4 VA: 0x264A2D4
	public Color get_WarningLogColor() { }

	[CompilerGenerated]
	// RVA: 0x264A2E0 Offset: 0x26462E0 VA: 0x264A2E0
	private void set_GMMessageColor(Color value) { }

	[CompilerGenerated]
	// RVA: 0x264A2EC Offset: 0x26462EC VA: 0x264A2EC
	public Color get_GMMessageColor() { }

	[CompilerGenerated]
	// RVA: 0x264A2F8 Offset: 0x26462F8 VA: 0x264A2F8
	private void set_ShowSayChat(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264A304 Offset: 0x2646304 VA: 0x264A304
	public bool get_ShowSayChat() { }

	[CompilerGenerated]
	// RVA: 0x264A30C Offset: 0x264630C VA: 0x264A30C
	private void set_ShowShoutChat(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264A318 Offset: 0x2646318 VA: 0x264A318
	public bool get_ShowShoutChat() { }

	[CompilerGenerated]
	// RVA: 0x264A320 Offset: 0x2646320 VA: 0x264A320
	private void set_ShowPartyChat(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264A32C Offset: 0x264632C VA: 0x264A32C
	public bool get_ShowPartyChat() { }

	[CompilerGenerated]
	// RVA: 0x264A334 Offset: 0x2646334 VA: 0x264A334
	private void set_ShowGuildChat(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264A340 Offset: 0x2646340 VA: 0x264A340
	public bool get_ShowGuildChat() { }

	[CompilerGenerated]
	// RVA: 0x264A348 Offset: 0x2646348 VA: 0x264A348
	private void set_ShowTellChat(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264A354 Offset: 0x2646354 VA: 0x264A354
	public bool get_ShowTellChat() { }

	[CompilerGenerated]
	// RVA: 0x264A35C Offset: 0x264635C VA: 0x264A35C
	private void set_ShowWorldChat(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264A368 Offset: 0x2646368 VA: 0x264A368
	public bool get_ShowWorldChat() { }

	[CompilerGenerated]
	// RVA: 0x264A370 Offset: 0x2646370 VA: 0x264A370
	private void set_ShowBattleLog(OptionChat.BattleLogFlag value) { }

	[CompilerGenerated]
	// RVA: 0x264A378 Offset: 0x2646378 VA: 0x264A378
	public OptionChat.BattleLogFlag get_ShowBattleLog() { }

	[CompilerGenerated]
	// RVA: 0x264A380 Offset: 0x2646380 VA: 0x264A380
	private void set_ShowEventLog(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264A38C Offset: 0x264638C VA: 0x264A38C
	public bool get_ShowEventLog() { }

	[CompilerGenerated]
	// RVA: 0x264A394 Offset: 0x2646394 VA: 0x264A394
	private void set_ChatNameSpace(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264A3A0 Offset: 0x26463A0 VA: 0x264A3A0
	public bool get_ChatNameSpace() { }

	[CompilerGenerated]
	// RVA: 0x264A3A8 Offset: 0x26463A8 VA: 0x264A3A8
	private void set_ChatWindowSelectRowSpace(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264A3B0 Offset: 0x26463B0 VA: 0x264A3B0
	public byte get_ChatWindowSelectRowSpace() { }

	// RVA: 0x264A3B8 Offset: 0x26463B8 VA: 0x264A3B8
	public byte get_ChatWindowRow() { }

	[CompilerGenerated]
	// RVA: 0x264A3C4 Offset: 0x26463C4 VA: 0x264A3C4
	private void set_ChatWindowTap(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264A3D0 Offset: 0x26463D0 VA: 0x264A3D0
	public bool get_ChatWindowTap() { }

	[CompilerGenerated]
	// RVA: 0x264A3D8 Offset: 0x26463D8 VA: 0x264A3D8
	private void set_ChatWindowSelectFontSize(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264A3E0 Offset: 0x26463E0 VA: 0x264A3E0
	public byte get_ChatWindowSelectFontSize() { }

	[CompilerGenerated]
	// RVA: 0x264A3E8 Offset: 0x26463E8 VA: 0x264A3E8
	private void set_ChatWindowSelectNewFontSize(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264A3F0 Offset: 0x26463F0 VA: 0x264A3F0
	public byte get_ChatWindowSelectNewFontSize() { }

	// RVA: 0x264A3F8 Offset: 0x26463F8 VA: 0x264A3F8
	public float get_ChatWindowFontSize() { }

	// RVA: 0x264A42C Offset: 0x264642C VA: 0x264A42C
	public float get_DefaultFontSize() { }

	// RVA: 0x264A458 Offset: 0x2646458 VA: 0x264A458
	public int get_ChatWindowPosition() { }

	[CompilerGenerated]
	// RVA: 0x264A464 Offset: 0x2646464 VA: 0x264A464
	private void set_SelectChatWindowPosition(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264A46C Offset: 0x264646C VA: 0x264A46C
	public byte get_SelectChatWindowPosition() { }

	// RVA: 0x264A474 Offset: 0x2646474 VA: 0x264A474
	public void set_FullScreenChat(bool value) { }

	// RVA: 0x264A508 Offset: 0x2646508 VA: 0x264A508
	public bool get_FullScreenChat() { }

	[CompilerGenerated]
	// RVA: 0x264A598 Offset: 0x2646598 VA: 0x264A598
	private void set_DispEmotionBar(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264A5A4 Offset: 0x26465A4 VA: 0x264A5A4
	public bool get_DispEmotionBar() { }

	// RVA: 0x264A5AC Offset: 0x26465AC VA: 0x264A5AC
	public byte get_ShowChatBitFlag() { }

	// RVA: 0x264A604 Offset: 0x2646604 VA: 0x264A604
	public void .ctor() { }

	// RVA: 0x264A984 Offset: 0x2646984 VA: 0x264A984
	public void Initialize() { }

	// RVA: 0x264AB04 Offset: 0x2646B04 VA: 0x264AB04
	private int SaveFlag(int setting, bool flag, int bit) { }

	// RVA: 0x264AB14 Offset: 0x2646B14 VA: 0x264AB14 Slot: 4
	public virtual void ChatOptionSave() { }

	// RVA: 0x264AF10 Offset: 0x2646F10 VA: 0x264AF10
	private void ColorToInt(string save, Color32 colorData) { }

	// RVA: 0x264AF38 Offset: 0x2646F38 VA: 0x264AF38 Slot: 5
	public virtual void ChatOptionLoad() { }

	// RVA: 0x264B2A8 Offset: 0x26472A8 VA: 0x264B2A8
	private Color IntToColor(string load, Color baseColor) { }

	// RVA: 0x264B344 Offset: 0x2647344 VA: 0x264B344 Slot: 6
	public virtual bool SetFlag(OptionChat.ChatOptionType type, bool setFlag) { }

	// RVA: 0x264B768 Offset: 0x2647768 VA: 0x264B768
	public bool SetParam(OptionChat.ChatOptionType type, int setParam) { }

	// RVA: 0x264B858 Offset: 0x2647858 VA: 0x264B858
	public bool SetColor(OptionChat.ChatOptionType type, Color setColor) { }

	// RVA: 0x264B900 Offset: 0x2647900 VA: 0x264B900
	public bool CheckChatFilter(ChatChannelType type) { }

	// RVA: 0x264B964 Offset: 0x2647964 VA: 0x264B964
	public Color GetChatTypeColor(ChatChannelType type) { }

	// RVA: 0x264BA0C Offset: 0x2647A0C VA: 0x264BA0C
	private static void .cctor() { }
}
