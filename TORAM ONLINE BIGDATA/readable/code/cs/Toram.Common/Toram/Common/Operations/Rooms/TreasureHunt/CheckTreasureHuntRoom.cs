// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.TreasureHunt
public class CheckTreasureHuntRoom : OperationRequestBase // TypeDefIndex: 11785
{
	// Fields
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <RoomId>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 60)]
	public int FieldId { get; set; }
	[PacketParameter(Code = 106)]
	public byte RoomId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x374AA4C Offset: 0x3746A4C VA: 0x374AA4C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x374AA54 Offset: 0x3746A54 VA: 0x374AA54
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x374AA5C Offset: 0x3746A5C VA: 0x374AA5C
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x374AA64 Offset: 0x3746A64 VA: 0x374AA64
	public byte get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x374AA6C Offset: 0x3746A6C VA: 0x374AA6C
	public void set_RoomId(byte value) { }

	// RVA: 0x374AA74 Offset: 0x3746A74 VA: 0x374AA74 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374AA7C Offset: 0x3746A7C VA: 0x374AA7C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x374AA84 Offset: 0x3746A84 VA: 0x374AA84 Slot: 3
	public override string ToString() { }

	// RVA: 0x374AB40 Offset: 0x3746B40 VA: 0x374AB40 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x374ACB8 Offset: 0x3746CB8 VA: 0x374ACB8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
