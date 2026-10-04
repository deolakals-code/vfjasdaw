// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildPostChangeResponse : PacketBase // TypeDefIndex: 12399
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

	// RVA: 0x3601A4C Offset: 0x35FDA4C VA: 0x3601A4C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3601A54 Offset: 0x35FDA54 VA: 0x3601A54
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x3601A5C Offset: 0x35FDA5C VA: 0x3601A5C
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3601A64 Offset: 0x35FDA64 VA: 0x3601A64
	public byte get_PostFlag() { }

	[CompilerGenerated]
	// RVA: 0x3601A6C Offset: 0x35FDA6C VA: 0x3601A6C
	public void set_PostFlag(byte value) { }

	// RVA: 0x3601A74 Offset: 0x35FDA74 VA: 0x3601A74 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3601A7C Offset: 0x35FDA7C VA: 0x3601A7C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3601BF4 Offset: 0x35FDBF4 VA: 0x3601BF4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
