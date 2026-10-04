// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildSecedeEvent : PacketBase // TypeDefIndex: 12924
{
	// Fields
	private int version; // 0x20
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <MemberNum>k__BackingField; // 0x38

	// Properties
	[PacketParameter(Code = 219)]
	public int GuildId { get; set; }
	[PacketParameter(Code = 74)]
	public int ArchetypeId { get; set; }
	[PacketParameter(Code = 66)]
	public string UserName { get; set; }
	public int MemberNum { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36797F0 Offset: 0x36757F0 VA: 0x36797F0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36797F8 Offset: 0x36757F8 VA: 0x36797F8
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x3679800 Offset: 0x3675800 VA: 0x3679800
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3679808 Offset: 0x3675808 VA: 0x3679808
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3679810 Offset: 0x3675810 VA: 0x3679810
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3679818 Offset: 0x3675818 VA: 0x3679818
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x3679820 Offset: 0x3675820 VA: 0x3679820
	public void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3679828 Offset: 0x3675828 VA: 0x3679828
	public int get_MemberNum() { }

	[CompilerGenerated]
	// RVA: 0x3679830 Offset: 0x3675830 VA: 0x3679830
	public void set_MemberNum(int value) { }

	// RVA: 0x3679838 Offset: 0x3675838 VA: 0x3679838 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3679840 Offset: 0x3675840 VA: 0x3679840 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3679AD0 Offset: 0x3675AD0 VA: 0x3679AD0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
