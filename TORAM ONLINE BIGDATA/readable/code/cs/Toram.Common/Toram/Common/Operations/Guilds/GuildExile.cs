// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildExile : PacketBase // TypeDefIndex: 12404
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 96)]
	public int TargetId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3602134 Offset: 0x35FE134 VA: 0x3602134
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x360213C Offset: 0x35FE13C VA: 0x360213C
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x3602144 Offset: 0x35FE144 VA: 0x3602144
	public void set_TargetId(int value) { }

	// RVA: 0x360214C Offset: 0x35FE14C VA: 0x360214C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3602154 Offset: 0x35FE154 VA: 0x3602154 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3602274 Offset: 0x35FE274 VA: 0x3602274 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
