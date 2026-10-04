// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild.GuildBBS
public class GuildBBSJoinEvent : EventSubBase // TypeDefIndex: 12933
{
	// Fields
	private int version; // 0x20
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <JoinUserId>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <JoinUserName>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <MemberNum>k__BackingField; // 0x38

	// Properties
	public int GuildId { get; set; }
	public int JoinUserId { get; set; }
	public string JoinUserName { get; set; }
	public int MemberNum { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x367BA1C Offset: 0x3677A1C VA: 0x367BA1C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x367BA24 Offset: 0x3677A24 VA: 0x367BA24
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x367BA2C Offset: 0x3677A2C VA: 0x367BA2C
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x367BA34 Offset: 0x3677A34 VA: 0x367BA34
	public int get_JoinUserId() { }

	[CompilerGenerated]
	// RVA: 0x367BA3C Offset: 0x3677A3C VA: 0x367BA3C
	public void set_JoinUserId(int value) { }

	[CompilerGenerated]
	// RVA: 0x367BA44 Offset: 0x3677A44 VA: 0x367BA44
	public string get_JoinUserName() { }

	[CompilerGenerated]
	// RVA: 0x367BA4C Offset: 0x3677A4C VA: 0x367BA4C
	public void set_JoinUserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x367BA54 Offset: 0x3677A54 VA: 0x367BA54
	public int get_MemberNum() { }

	[CompilerGenerated]
	// RVA: 0x367BA5C Offset: 0x3677A5C VA: 0x367BA5C
	public void set_MemberNum(int value) { }

	// RVA: 0x367BA64 Offset: 0x3677A64 VA: 0x367BA64 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x367BA6C Offset: 0x3677A6C VA: 0x367BA6C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x367BA74 Offset: 0x3677A74 VA: 0x367BA74 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x367BDB0 Offset: 0x3677DB0 VA: 0x367BDB0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
