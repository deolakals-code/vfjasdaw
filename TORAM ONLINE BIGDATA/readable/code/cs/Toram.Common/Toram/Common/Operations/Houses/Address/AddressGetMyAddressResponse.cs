// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Address
public class AddressGetMyAddressResponse : OperationResponseBase // TypeDefIndex: 12282
{
	// Fields
	[CompilerGenerated]
	private int <Address>k__BackingField; // 0x20

	// Properties
	public int Address { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35EC1C4 Offset: 0x35E81C4 VA: 0x35EC1C4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35EC1CC Offset: 0x35E81CC VA: 0x35EC1CC
	public int get_Address() { }

	[CompilerGenerated]
	// RVA: 0x35EC1D4 Offset: 0x35E81D4 VA: 0x35EC1D4
	public void set_Address(int value) { }

	// RVA: 0x35EC1DC Offset: 0x35E81DC VA: 0x35EC1DC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35EC1E4 Offset: 0x35E81E4 VA: 0x35EC1E4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35EC1EC Offset: 0x35E81EC VA: 0x35EC1EC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35EC30C Offset: 0x35E830C VA: 0x35EC30C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
