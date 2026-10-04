// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Market
public class MarketSalesResultResponse : OperationResponseBase // TypeDefIndex: 11924
{
	// Fields
	[CompilerGenerated]
	private MarketResultData <ResultData>k__BackingField; // 0x20
	[CompilerGenerated]
	private SalesData[] <SalesList>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x30

	// Properties
	[PacketClass(Code = 84, IsOptional = True)]
	public MarketResultData ResultData { get; set; }
	[PacketClass(Code = 213, IsOptional = True)]
	public SalesData[] SalesList { get; set; }
	[PacketParameter(Code = 81, IsOptional = True)]
	public short ReturnCode { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37669C0 Offset: 0x37629C0 VA: 0x37669C0
	public void .ctor() { }

	// RVA: 0x37669C8 Offset: 0x37629C8 VA: 0x37669C8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37669D0 Offset: 0x37629D0 VA: 0x37669D0
	public MarketResultData get_ResultData() { }

	[CompilerGenerated]
	// RVA: 0x37669D8 Offset: 0x37629D8 VA: 0x37669D8
	public void set_ResultData(MarketResultData value) { }

	[CompilerGenerated]
	// RVA: 0x37669E0 Offset: 0x37629E0 VA: 0x37669E0
	public SalesData[] get_SalesList() { }

	[CompilerGenerated]
	// RVA: 0x37669E8 Offset: 0x37629E8 VA: 0x37669E8
	public void set_SalesList(SalesData[] value) { }

	[CompilerGenerated]
	// RVA: 0x37669F0 Offset: 0x37629F0 VA: 0x37669F0
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x37669F8 Offset: 0x37629F8 VA: 0x37669F8
	public void set_ReturnCode(short value) { }

	// RVA: 0x3766A00 Offset: 0x3762A00 VA: 0x3766A00
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3766BBC Offset: 0x3762BBC VA: 0x3766BBC
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3766C74 Offset: 0x3762C74 VA: 0x3766C74 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3766C7C Offset: 0x3762C7C VA: 0x3766C7C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3766C84 Offset: 0x3762C84 VA: 0x3766C84 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3766DE0 Offset: 0x3762DE0 VA: 0x3766DE0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
