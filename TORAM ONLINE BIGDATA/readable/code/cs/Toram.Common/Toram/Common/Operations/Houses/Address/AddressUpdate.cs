// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Address
public class AddressUpdate : OperationRequestBase // TypeDefIndex: 12284
{
	// Fields
	[CompilerGenerated]
	private int <Address>k__BackingField; // 0x20

	// Properties
	public int Address { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35EC594 Offset: 0x35E8594 VA: 0x35EC594
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35EC59C Offset: 0x35E859C VA: 0x35EC59C
	public int get_Address() { }

	[CompilerGenerated]
	// RVA: 0x35EC5A4 Offset: 0x35E85A4 VA: 0x35EC5A4
	public void set_Address(int value) { }

	// RVA: 0x35EC5AC Offset: 0x35E85AC VA: 0x35EC5AC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35EC5B4 Offset: 0x35E85B4 VA: 0x35EC5B4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35EC5BC Offset: 0x35E85BC VA: 0x35EC5BC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35EC6DC Offset: 0x35E86DC VA: 0x35EC6DC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
