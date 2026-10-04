// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Market
public class MarketExhibitResponse : OperationResponseBase // TypeDefIndex: 11915
{
	// Fields
	[CompilerGenerated]
	private byte <SalesId>k__BackingField; // 0x20
	[CompilerGenerated]
	private SalesData[] <SalesList>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 200)]
	public byte SalesId { get; set; }
	[PacketClass(Code = 213, IsOptional = True)]
	public SalesData[] SalesList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3764940 Offset: 0x3760940 VA: 0x3764940
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3764948 Offset: 0x3760948 VA: 0x3764948
	public byte get_SalesId() { }

	[CompilerGenerated]
	// RVA: 0x3764950 Offset: 0x3760950 VA: 0x3764950
	public void set_SalesId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3764958 Offset: 0x3760958 VA: 0x3764958
	public SalesData[] get_SalesList() { }

	[CompilerGenerated]
	// RVA: 0x3764960 Offset: 0x3760960 VA: 0x3764960
	public void set_SalesList(SalesData[] value) { }

	// RVA: 0x3764968 Offset: 0x3760968 VA: 0x3764968
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3764A68 Offset: 0x3760A68 VA: 0x3764A68
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3764AF4 Offset: 0x3760AF4 VA: 0x3764AF4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3764AFC Offset: 0x3760AFC VA: 0x3764AFC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3764B04 Offset: 0x3760B04 VA: 0x3764B04 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3764C34 Offset: 0x3760C34 VA: 0x3764C34 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
