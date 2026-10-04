// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb
public class OrbServiceBuy : OperationRequestBase // TypeDefIndex: 11816
{
	// Fields
	[CompilerGenerated]
	private byte <ServiceType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x24
	[CompilerGenerated]
	private Dictionary<object, object> <ServiceParam>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 232)]
	public byte ServiceType { get; set; }
	[PacketParameter(Code = 229)]
	public int Orb { get; set; }
	[PacketParameter(Code = 18, IsOptional = True)]
	public Dictionary<object, object> ServiceParam { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3750AFC Offset: 0x374CAFC VA: 0x3750AFC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3750B04 Offset: 0x374CB04 VA: 0x3750B04
	public byte get_ServiceType() { }

	[CompilerGenerated]
	// RVA: 0x3750B0C Offset: 0x374CB0C VA: 0x3750B0C
	public void set_ServiceType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3750B14 Offset: 0x374CB14 VA: 0x3750B14
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x3750B1C Offset: 0x374CB1C VA: 0x3750B1C
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x3750B24 Offset: 0x374CB24 VA: 0x3750B24
	public Dictionary<object, object> get_ServiceParam() { }

	[CompilerGenerated]
	// RVA: 0x3750B2C Offset: 0x374CB2C VA: 0x3750B2C
	public void set_ServiceParam(Dictionary<object, object> value) { }

	// RVA: 0x3750B34 Offset: 0x374CB34 VA: 0x3750B34 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3750B3C Offset: 0x374CB3C VA: 0x3750B3C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3750B44 Offset: 0x374CB44 VA: 0x3750B44 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3750D5C Offset: 0x374CD5C VA: 0x3750D5C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
