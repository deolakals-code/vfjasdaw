// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildInviteCancelAll : PacketBase // TypeDefIndex: 12356
{
	// Fields
	[CompilerGenerated]
	private int <ExceptGuildId>k__BackingField; // 0x20

	// Properties
	public int ExceptGuildId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35F9DC8 Offset: 0x35F5DC8 VA: 0x35F9DC8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35F9DD0 Offset: 0x35F5DD0 VA: 0x35F9DD0
	public int get_ExceptGuildId() { }

	[CompilerGenerated]
	// RVA: 0x35F9DD8 Offset: 0x35F5DD8 VA: 0x35F9DD8
	public void set_ExceptGuildId(int value) { }

	// RVA: 0x35F9DE0 Offset: 0x35F5DE0 VA: 0x35F9DE0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F9DE8 Offset: 0x35F5DE8 VA: 0x35F9DE8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35F9EBC Offset: 0x35F5EBC VA: 0x35F9EBC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
