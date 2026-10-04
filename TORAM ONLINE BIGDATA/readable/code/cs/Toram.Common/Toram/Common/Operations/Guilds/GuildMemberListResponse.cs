// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildMemberListResponse : OperationResponseBase // TypeDefIndex: 12360
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <MemberVersion>k__BackingField; // 0x24
	[CompilerGenerated]
	private GuildMemberListData[] <MemberList>k__BackingField; // 0x28

	// Properties
	public int GuildId { get; set; }
	public byte MemberVersion { get; set; }
	public GuildMemberListData[] MemberList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35FA908 Offset: 0x35F6908 VA: 0x35FA908
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35FA910 Offset: 0x35F6910 VA: 0x35FA910
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x35FA918 Offset: 0x35F6918 VA: 0x35FA918
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35FA920 Offset: 0x35F6920 VA: 0x35FA920
	public byte get_MemberVersion() { }

	[CompilerGenerated]
	// RVA: 0x35FA928 Offset: 0x35F6928 VA: 0x35FA928
	public void set_MemberVersion(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35FA930 Offset: 0x35F6930 VA: 0x35FA930
	public GuildMemberListData[] get_MemberList() { }

	[CompilerGenerated]
	// RVA: 0x35FA938 Offset: 0x35F6938 VA: 0x35FA938
	public void set_MemberList(GuildMemberListData[] value) { }

	// RVA: 0x35FA940 Offset: 0x35F6940 VA: 0x35FA940 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FA948 Offset: 0x35F6948 VA: 0x35FA948 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35FA950 Offset: 0x35F6950 VA: 0x35FA950 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35FAB2C Offset: 0x35F6B2C VA: 0x35FAB2C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
