// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildInvitationResponse : PacketBase // TypeDefIndex: 12388
{
	// Fields
	[CompilerGenerated]
	private GuildMemberData <MemberData>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 199)]
	public GuildMemberData MemberData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3600160 Offset: 0x35FC160 VA: 0x3600160
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3600168 Offset: 0x35FC168 VA: 0x3600168
	public GuildMemberData get_MemberData() { }

	[CompilerGenerated]
	// RVA: 0x3600170 Offset: 0x35FC170 VA: 0x3600170
	public void set_MemberData(GuildMemberData value) { }

	// RVA: 0x3600178 Offset: 0x35FC178 VA: 0x3600178
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x360025C Offset: 0x35FC25C VA: 0x360025C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36002CC Offset: 0x35FC2CC VA: 0x36002CC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36002D4 Offset: 0x35FC2D4 VA: 0x36002D4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x360036C Offset: 0x35FC36C VA: 0x360036C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
