// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb
public class OrbRecycling : OperationRequestBase // TypeDefIndex: 11814
{
	// Fields
	[CompilerGenerated]
	private int <ItemId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ItemUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <RecycleType>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 91)]
	public int ItemId { get; set; }
	[PacketParameter(Code = 137)]
	public int ItemUuid { get; set; }
	public byte RecycleType { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3750468 Offset: 0x374C468 VA: 0x3750468
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3750470 Offset: 0x374C470 VA: 0x3750470
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x3750478 Offset: 0x374C478 VA: 0x3750478
	public void set_ItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3750480 Offset: 0x374C480 VA: 0x3750480
	public int get_ItemUuid() { }

	[CompilerGenerated]
	// RVA: 0x3750488 Offset: 0x374C488 VA: 0x3750488
	public void set_ItemUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3750490 Offset: 0x374C490 VA: 0x3750490
	public byte get_RecycleType() { }

	[CompilerGenerated]
	// RVA: 0x3750498 Offset: 0x374C498 VA: 0x3750498
	public void set_RecycleType(byte value) { }

	// RVA: 0x37504A0 Offset: 0x374C4A0 VA: 0x37504A0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37504A8 Offset: 0x374C4A8 VA: 0x37504A8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37504B0 Offset: 0x374C4B0 VA: 0x37504B0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37506A0 Offset: 0x374C6A0 VA: 0x37506A0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
