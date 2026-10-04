// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Fishing
public class Chumming : OperationRequestBase // TypeDefIndex: 11653
{
	// Fields
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ChummingCount>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 0)]
	public int FieldId { get; set; }
	[PacketParameter(Code = 10)]
	public byte ChummingCount { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372BD18 Offset: 0x3727D18 VA: 0x372BD18
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x372BD20 Offset: 0x3727D20 VA: 0x372BD20
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x372BD28 Offset: 0x3727D28 VA: 0x372BD28
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x372BD30 Offset: 0x3727D30 VA: 0x372BD30
	public byte get_ChummingCount() { }

	[CompilerGenerated]
	// RVA: 0x372BD38 Offset: 0x3727D38 VA: 0x372BD38
	public void set_ChummingCount(byte value) { }

	// RVA: 0x372BD40 Offset: 0x3727D40 VA: 0x372BD40 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372BD48 Offset: 0x3727D48 VA: 0x372BD48 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372BD50 Offset: 0x3727D50 VA: 0x372BD50 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x372BE2C Offset: 0x3727E2C VA: 0x372BE2C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
