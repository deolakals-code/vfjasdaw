// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb
public class OrbServicePrice : OperationRequestBase // TypeDefIndex: 11819
{
	// Fields
	[CompilerGenerated]
	private byte <ServiceType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Value>k__BackingField; // 0x24

	// Properties
	public byte ServiceType { get; set; }
	public int Value { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3751344 Offset: 0x374D344 VA: 0x3751344
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x375134C Offset: 0x374D34C VA: 0x375134C
	public byte get_ServiceType() { }

	[CompilerGenerated]
	// RVA: 0x3751354 Offset: 0x374D354 VA: 0x3751354
	public void set_ServiceType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x375135C Offset: 0x374D35C VA: 0x375135C
	public int get_Value() { }

	[CompilerGenerated]
	// RVA: 0x3751364 Offset: 0x374D364 VA: 0x3751364
	public void set_Value(int value) { }

	// RVA: 0x375136C Offset: 0x374D36C VA: 0x375136C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3751374 Offset: 0x374D374 VA: 0x3751374 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x375137C Offset: 0x374D37C VA: 0x375137C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37514F4 Offset: 0x374D4F4 VA: 0x37514F4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
