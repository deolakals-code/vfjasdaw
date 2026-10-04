// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Defence
public class CheckDefenceRoom : PacketBase // TypeDefIndex: 11761
{
	// Fields
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <Level>k__BackingField; // 0x26

	// Properties
	[PacketParameter(Code = 60)]
	public int FieldId { get; set; }
	[PacketParameter(Code = 43)]
	public byte Flag { get; set; }
	[PacketParameter(Code = 29, IsOptional = True)]
	public short Level { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3744188 Offset: 0x3740188 VA: 0x3744188
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3744190 Offset: 0x3740190 VA: 0x3744190
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x3744198 Offset: 0x3740198 VA: 0x3744198
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x37441A0 Offset: 0x37401A0 VA: 0x37441A0
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x37441A8 Offset: 0x37401A8 VA: 0x37441A8
	public void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37441B0 Offset: 0x37401B0 VA: 0x37441B0
	public short get_Level() { }

	[CompilerGenerated]
	// RVA: 0x37441B8 Offset: 0x37401B8 VA: 0x37441B8
	public void set_Level(short value) { }

	// RVA: 0x37441C0 Offset: 0x37401C0 VA: 0x37441C0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37441C8 Offset: 0x37401C8 VA: 0x37441C8 Slot: 3
	public override string ToString() { }

	// RVA: 0x37442BC Offset: 0x37402BC VA: 0x37442BC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37444B8 Offset: 0x37404B8 VA: 0x37444B8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
