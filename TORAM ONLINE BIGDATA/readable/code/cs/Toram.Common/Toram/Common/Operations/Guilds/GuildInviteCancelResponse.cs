// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildInviteCancelResponse : PacketBase // TypeDefIndex: 12389
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <GuildName>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 219)]
	public int GuildId { get; set; }
	[PacketParameter(Code = 220)]
	public string GuildName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36003EC Offset: 0x35FC3EC VA: 0x36003EC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36003F4 Offset: 0x35FC3F4 VA: 0x36003F4
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x36003FC Offset: 0x35FC3FC VA: 0x36003FC
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3600404 Offset: 0x35FC404 VA: 0x3600404
	public string get_GuildName() { }

	[CompilerGenerated]
	// RVA: 0x360040C Offset: 0x35FC40C VA: 0x360040C
	public void set_GuildName(string value) { }

	// RVA: 0x3600414 Offset: 0x35FC414 VA: 0x3600414 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360041C Offset: 0x35FC41C VA: 0x360041C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3600594 Offset: 0x35FC594 VA: 0x3600594 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
