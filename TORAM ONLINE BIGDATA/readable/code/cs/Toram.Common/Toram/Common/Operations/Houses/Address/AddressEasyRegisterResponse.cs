// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Address
public class AddressEasyRegisterResponse : OperationResponseBase // TypeDefIndex: 12286
{
	// Fields
	[CompilerGenerated]
	private int <Address>k__BackingField; // 0x20

	// Properties
	public int Address { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35EC7A4 Offset: 0x35E87A4 VA: 0x35EC7A4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35EC7AC Offset: 0x35E87AC VA: 0x35EC7AC
	public int get_Address() { }

	[CompilerGenerated]
	// RVA: 0x35EC7B4 Offset: 0x35E87B4 VA: 0x35EC7B4
	public void set_Address(int value) { }

	// RVA: 0x35EC7BC Offset: 0x35E87BC VA: 0x35EC7BC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35EC7C4 Offset: 0x35E87C4 VA: 0x35EC7C4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35EC7CC Offset: 0x35E87CC VA: 0x35EC7CC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35EC8EC Offset: 0x35E88EC VA: 0x35EC8EC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
