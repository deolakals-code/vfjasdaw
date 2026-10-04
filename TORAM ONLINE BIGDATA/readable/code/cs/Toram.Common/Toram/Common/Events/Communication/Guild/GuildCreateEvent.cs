// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildCreateEvent : PacketBase // TypeDefIndex: 12913
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <GuildName>k__BackingField; // 0x28
	[CompilerGenerated]
	private GuildUserData <User>k__BackingField; // 0x30
	[CompilerGenerated]
	private DateTime <GuildLatestMsgTime>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <GuildLoginMessage>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte <MemberVersion>k__BackingField; // 0x48
	[CompilerGenerated]
	private int[] <MemberIdList>k__BackingField; // 0x50

	// Properties
	public int GuildId { get; set; }
	public string GuildName { get; set; }
	public GuildUserData User { get; set; }
	public DateTime GuildLatestMsgTime { get; set; }
	public string GuildLoginMessage { get; set; }
	public byte MemberVersion { get; set; }
	public int[] MemberIdList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3676984 Offset: 0x3672984 VA: 0x3676984
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x367698C Offset: 0x367298C VA: 0x367698C Slot: 7
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x3676994 Offset: 0x3672994 VA: 0x3676994 Slot: 8
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x367699C Offset: 0x367299C VA: 0x367699C Slot: 9
	public string get_GuildName() { }

	[CompilerGenerated]
	// RVA: 0x36769A4 Offset: 0x36729A4 VA: 0x36769A4 Slot: 10
	public void set_GuildName(string value) { }

	[CompilerGenerated]
	// RVA: 0x36769AC Offset: 0x36729AC VA: 0x36769AC Slot: 11
	public GuildUserData get_User() { }

	[CompilerGenerated]
	// RVA: 0x36769B4 Offset: 0x36729B4 VA: 0x36769B4 Slot: 12
	public void set_User(GuildUserData value) { }

	[CompilerGenerated]
	// RVA: 0x36769BC Offset: 0x36729BC VA: 0x36769BC Slot: 13
	public DateTime get_GuildLatestMsgTime() { }

	[CompilerGenerated]
	// RVA: 0x36769C4 Offset: 0x36729C4 VA: 0x36769C4 Slot: 14
	public void set_GuildLatestMsgTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x36769CC Offset: 0x36729CC VA: 0x36769CC Slot: 15
	public string get_GuildLoginMessage() { }

	[CompilerGenerated]
	// RVA: 0x36769D4 Offset: 0x36729D4 VA: 0x36769D4 Slot: 16
	public void set_GuildLoginMessage(string value) { }

	[CompilerGenerated]
	// RVA: 0x36769DC Offset: 0x36729DC VA: 0x36769DC Slot: 17
	public byte get_MemberVersion() { }

	[CompilerGenerated]
	// RVA: 0x36769E4 Offset: 0x36729E4 VA: 0x36769E4 Slot: 18
	public void set_MemberVersion(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36769EC Offset: 0x36729EC VA: 0x36769EC Slot: 19
	public int[] get_MemberIdList() { }

	[CompilerGenerated]
	// RVA: 0x36769F4 Offset: 0x36729F4 VA: 0x36769F4 Slot: 20
	public void set_MemberIdList(int[] value) { }

	// RVA: 0x36769FC Offset: 0x36729FC VA: 0x36769FC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3676A04 Offset: 0x3672A04 VA: 0x3676A04 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3676E28 Offset: 0x3672E28 VA: 0x3676E28 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
