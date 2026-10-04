// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildAcceptance : PacketBase // TypeDefIndex: 12396
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20

	// Properties
	public int GuildId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3601580 Offset: 0x35FD580 VA: 0x3601580
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3601588 Offset: 0x35FD588 VA: 0x3601588
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x3601590 Offset: 0x35FD590 VA: 0x3601590
	public void set_GuildId(int value) { }

	// RVA: 0x3601598 Offset: 0x35FD598 VA: 0x3601598 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36015A0 Offset: 0x35FD5A0 VA: 0x36015A0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36016C0 Offset: 0x35FD6C0 VA: 0x36016C0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
