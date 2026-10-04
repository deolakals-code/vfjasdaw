// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Cuisine
public class CuisineCooking : OperationRequestBase // TypeDefIndex: 12257
{
	// Fields
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Lv>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 200)]
	public int Id { get; set; }
	[PacketParameter(Code = 101)]
	public byte Lv { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E7F5C Offset: 0x35E3F5C VA: 0x35E7F5C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35E7F64 Offset: 0x35E3F64 VA: 0x35E7F64
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x35E7F6C Offset: 0x35E3F6C VA: 0x35E7F6C
	public void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x35E7F74 Offset: 0x35E3F74 VA: 0x35E7F74
	public byte get_Lv() { }

	[CompilerGenerated]
	// RVA: 0x35E7F7C Offset: 0x35E3F7C VA: 0x35E7F7C
	public void set_Lv(byte value) { }

	// RVA: 0x35E7F84 Offset: 0x35E3F84 VA: 0x35E7F84
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E7F88 Offset: 0x35E3F88 VA: 0x35E7F88
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E7F8C Offset: 0x35E3F8C VA: 0x35E7F8C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E7F94 Offset: 0x35E3F94 VA: 0x35E7F94 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E7F9C Offset: 0x35E3F9C VA: 0x35E7F9C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E8114 Offset: 0x35E4114 VA: 0x35E8114 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
