// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaGhostWarpResponse : OperationResponseBase // TypeDefIndex: 11603
{
	// Fields
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <SecondUntilNextWarp>k__BackingField; // 0x24
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x30

	// Properties
	public short ReturnCode { get; set; }
	public int SecondUntilNextWarp { get; set; }
	public short[] Position { get; set; }
	public short Rotation { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3722E0C Offset: 0x371EE0C VA: 0x3722E0C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3722E14 Offset: 0x371EE14 VA: 0x3722E14
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x3722E1C Offset: 0x371EE1C VA: 0x3722E1C
	public void set_ReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x3722E24 Offset: 0x371EE24 VA: 0x3722E24
	public int get_SecondUntilNextWarp() { }

	[CompilerGenerated]
	// RVA: 0x3722E2C Offset: 0x371EE2C VA: 0x3722E2C
	public void set_SecondUntilNextWarp(int value) { }

	[CompilerGenerated]
	// RVA: 0x3722E34 Offset: 0x371EE34 VA: 0x3722E34
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x3722E3C Offset: 0x371EE3C VA: 0x3722E3C
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x3722E44 Offset: 0x371EE44 VA: 0x3722E44
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x3722E4C Offset: 0x371EE4C VA: 0x3722E4C
	public void set_Rotation(short value) { }

	// RVA: 0x3722E54 Offset: 0x371EE54 VA: 0x3722E54 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3722E5C Offset: 0x371EE5C VA: 0x3722E5C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3722E64 Offset: 0x371EE64 VA: 0x3722E64 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3722F90 Offset: 0x371EF90 VA: 0x3722F90 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
