// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb
public class OrbServicePriceResponse : OperationResponseBase // TypeDefIndex: 11821
{
	// Fields
	[CompilerGenerated]
	private byte <ServiceType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <OrbPrice>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 232)]
	public byte ServiceType { get; set; }
	[PacketParameter(Code = 229)]
	public int OrbPrice { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x375183C Offset: 0x374D83C VA: 0x375183C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3751844 Offset: 0x374D844 VA: 0x3751844
	public byte get_ServiceType() { }

	[CompilerGenerated]
	// RVA: 0x375184C Offset: 0x374D84C VA: 0x375184C
	public void set_ServiceType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3751854 Offset: 0x374D854 VA: 0x3751854
	public int get_OrbPrice() { }

	[CompilerGenerated]
	// RVA: 0x375185C Offset: 0x374D85C VA: 0x375185C
	public void set_OrbPrice(int value) { }

	// RVA: 0x3751864 Offset: 0x374D864 VA: 0x3751864 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x375186C Offset: 0x374D86C VA: 0x375186C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3751874 Offset: 0x374D874 VA: 0x3751874 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37519EC Offset: 0x374D9EC VA: 0x37519EC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
