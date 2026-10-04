// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Partners
public class PartnerJoin : OperationRequestBase // TypeDefIndex: 11476
{
	// Fields
	[CompilerGenerated]
	private byte <ParameterNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <StanceType>k__BackingField; // 0x21

	// Properties
	public byte ParameterNo { get; set; }
	public byte StanceType { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371002C Offset: 0x370C02C VA: 0x371002C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3710034 Offset: 0x370C034 VA: 0x3710034
	public byte get_ParameterNo() { }

	[CompilerGenerated]
	// RVA: 0x371003C Offset: 0x370C03C VA: 0x371003C
	public void set_ParameterNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3710044 Offset: 0x370C044 VA: 0x3710044
	public byte get_StanceType() { }

	[CompilerGenerated]
	// RVA: 0x371004C Offset: 0x370C04C VA: 0x371004C
	public void set_StanceType(byte value) { }

	// RVA: 0x3710054 Offset: 0x370C054 VA: 0x3710054 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371005C Offset: 0x370C05C VA: 0x371005C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3710064 Offset: 0x370C064 VA: 0x3710064 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37101D0 Offset: 0x370C1D0 VA: 0x37101D0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
