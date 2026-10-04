// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Address
public class AddressSearchResponse : OperationResponseBase // TypeDefIndex: 12287
{
	// Fields
	[CompilerGenerated]
	private int <HouseId>k__BackingField; // 0x20

	// Properties
	public int HouseId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35EC98C Offset: 0x35E898C VA: 0x35EC98C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35EC994 Offset: 0x35E8994 VA: 0x35EC994
	public int get_HouseId() { }

	[CompilerGenerated]
	// RVA: 0x35EC99C Offset: 0x35E899C VA: 0x35EC99C
	public void set_HouseId(int value) { }

	// RVA: 0x35EC9A4 Offset: 0x35E89A4 VA: 0x35EC9A4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35EC9AC Offset: 0x35E89AC VA: 0x35EC9AC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35EC9B4 Offset: 0x35E89B4 VA: 0x35EC9B4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35ECAD4 Offset: 0x35E8AD4 VA: 0x35ECAD4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
