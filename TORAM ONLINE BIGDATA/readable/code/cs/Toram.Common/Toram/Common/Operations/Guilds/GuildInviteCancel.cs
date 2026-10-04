// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildInviteCancel : PacketBase // TypeDefIndex: 12394
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20

	// Properties
	public int GuildId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3601158 Offset: 0x35FD158 VA: 0x3601158
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3601160 Offset: 0x35FD160 VA: 0x3601160
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x3601168 Offset: 0x35FD168 VA: 0x3601168
	public void set_GuildId(int value) { }

	// RVA: 0x3601170 Offset: 0x35FD170 VA: 0x3601170 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3601178 Offset: 0x35FD178 VA: 0x3601178 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3601298 Offset: 0x35FD298 VA: 0x3601298 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
