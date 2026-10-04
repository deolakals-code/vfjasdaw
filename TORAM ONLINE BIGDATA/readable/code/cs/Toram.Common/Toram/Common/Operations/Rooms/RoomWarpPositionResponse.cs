// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms
public class RoomWarpPositionResponse : OperationResponseBase // TypeDefIndex: 11736
{
	// Fields
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 54)]
	public short[] Position { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x373EE30 Offset: 0x373AE30 VA: 0x373EE30
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x373EE38 Offset: 0x373AE38 VA: 0x373EE38
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x373EE40 Offset: 0x373AE40 VA: 0x373EE40
	public void set_Position(short[] value) { }

	// RVA: 0x373EE48 Offset: 0x373AE48 VA: 0x373EE48 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x373EE50 Offset: 0x373AE50 VA: 0x373EE50 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x373EE58 Offset: 0x373AE58 VA: 0x373EE58 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x373EF84 Offset: 0x373AF84 VA: 0x373EF84 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
