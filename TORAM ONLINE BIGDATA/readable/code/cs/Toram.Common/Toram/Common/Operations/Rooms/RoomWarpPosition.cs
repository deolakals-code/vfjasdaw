// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms
public class RoomWarpPosition : OperationRequestBase // TypeDefIndex: 11735
{
	// Fields
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 54, IsOptional = True)]
	public short[] Position { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x373EC20 Offset: 0x373AC20 VA: 0x373EC20
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x373EC28 Offset: 0x373AC28 VA: 0x373EC28
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x373EC30 Offset: 0x373AC30 VA: 0x373EC30
	public void set_Position(short[] value) { }

	// RVA: 0x373EC38 Offset: 0x373AC38 VA: 0x373EC38 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x373EC40 Offset: 0x373AC40 VA: 0x373EC40 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x373EC48 Offset: 0x373AC48 VA: 0x373EC48 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x373EDBC Offset: 0x373ADBC VA: 0x373EDBC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
