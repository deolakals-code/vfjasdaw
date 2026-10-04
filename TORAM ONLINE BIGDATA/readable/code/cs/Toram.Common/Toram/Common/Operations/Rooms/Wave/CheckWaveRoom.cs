// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Wave
public class CheckWaveRoom : OperationRequestBase // TypeDefIndex: 11796
{
	// Fields
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <RoomId>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <Level>k__BackingField; // 0x26

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	[UnityHash(Code = 60)]
	public int FieldId { get; set; }
	[UnityHash(Code = 106)]
	public byte RoomId { get; set; }
	[UnityHash(Code = 29)]
	public short Level { get; set; }

	// Methods

	// RVA: 0x374D408 Offset: 0x3749408 VA: 0x374D408 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374D410 Offset: 0x3749410 VA: 0x374D410 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x374D418 Offset: 0x3749418 VA: 0x374D418
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x374D420 Offset: 0x3749420 VA: 0x374D420
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x374D428 Offset: 0x3749428 VA: 0x374D428
	public byte get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x374D430 Offset: 0x3749430 VA: 0x374D430
	public void set_RoomId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x374D438 Offset: 0x3749438 VA: 0x374D438
	public short get_Level() { }

	[CompilerGenerated]
	// RVA: 0x374D440 Offset: 0x3749440 VA: 0x374D440
	public void set_Level(short value) { }

	// RVA: 0x374D448 Offset: 0x3749448 VA: 0x374D448
	public void .ctor() { }

	// RVA: 0x374D450 Offset: 0x3749450 VA: 0x374D450 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x374D570 Offset: 0x3749570 VA: 0x374D570 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
