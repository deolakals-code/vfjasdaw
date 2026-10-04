// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses
public class HouseEnter : OperationRequestBase // TypeDefIndex: 12173
{
	// Fields
	[CompilerGenerated]
	private byte <EditState>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <EnterType>k__BackingField; // 0x21
	[CompilerGenerated]
	private int <HouseId>k__BackingField; // 0x24

	// Properties
	public byte EditState { get; set; }
	public byte EnterType { get; set; }
	public int HouseId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3795590 Offset: 0x3791590 VA: 0x3795590
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3795598 Offset: 0x3791598 VA: 0x3795598
	public byte get_EditState() { }

	[CompilerGenerated]
	// RVA: 0x37955A0 Offset: 0x37915A0 VA: 0x37955A0
	public void set_EditState(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37955A8 Offset: 0x37915A8 VA: 0x37955A8
	public byte get_EnterType() { }

	[CompilerGenerated]
	// RVA: 0x37955B0 Offset: 0x37915B0 VA: 0x37955B0
	public void set_EnterType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37955B8 Offset: 0x37915B8 VA: 0x37955B8
	public int get_HouseId() { }

	[CompilerGenerated]
	// RVA: 0x37955C0 Offset: 0x37915C0 VA: 0x37955C0
	public void set_HouseId(int value) { }

	// RVA: 0x37955C8 Offset: 0x37915C8 VA: 0x37955C8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37955D0 Offset: 0x37915D0 VA: 0x37955D0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37955D8 Offset: 0x37915D8 VA: 0x37955D8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3795764 Offset: 0x3791764 VA: 0x3795764 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
