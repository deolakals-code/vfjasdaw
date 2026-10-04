// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildPostChange : PacketBase // TypeDefIndex: 12398
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <PostFlag>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 96)]
	public int TargetId { get; set; }
	[PacketParameter(Code = 43)]
	public byte PostFlag { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3601794 Offset: 0x35FD794 VA: 0x3601794
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x360179C Offset: 0x35FD79C VA: 0x360179C
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x36017A4 Offset: 0x35FD7A4 VA: 0x36017A4
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36017AC Offset: 0x35FD7AC VA: 0x36017AC
	public byte get_PostFlag() { }

	[CompilerGenerated]
	// RVA: 0x36017B4 Offset: 0x35FD7B4 VA: 0x36017B4
	public void set_PostFlag(byte value) { }

	// RVA: 0x36017BC Offset: 0x35FD7BC VA: 0x36017BC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36017C4 Offset: 0x35FD7C4 VA: 0x36017C4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x360193C Offset: 0x35FD93C VA: 0x360193C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
