// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Cultivation
public class CultivationWatering : OperationRequestBase // TypeDefIndex: 12205
{
	// Fields
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Index>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 200)]
	public int Id { get; set; }
	[PacketParameter(Code = 153)]
	public short Index { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E09A8 Offset: 0x35DC9A8 VA: 0x35E09A8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35E09B0 Offset: 0x35DC9B0 VA: 0x35E09B0
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x35E09B8 Offset: 0x35DC9B8 VA: 0x35E09B8
	public void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x35E09C0 Offset: 0x35DC9C0 VA: 0x35E09C0
	public short get_Index() { }

	[CompilerGenerated]
	// RVA: 0x35E09C8 Offset: 0x35DC9C8 VA: 0x35E09C8
	public void set_Index(short value) { }

	// RVA: 0x35E09D0 Offset: 0x35DC9D0 VA: 0x35E09D0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E09D8 Offset: 0x35DC9D8 VA: 0x35E09D8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E09E0 Offset: 0x35DC9E0 VA: 0x35E09E0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E0B58 Offset: 0x35DCB58 VA: 0x35E0B58 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
