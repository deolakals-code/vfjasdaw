// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Market
public class MarketExhibitCancelResponse : OperationResponseBase // TypeDefIndex: 11914
{
	// Fields
	[CompilerGenerated]
	private byte <SalesId>k__BackingField; // 0x20
	[CompilerGenerated]
	private SalesData[] <SalesList>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 200)]
	public byte SalesId { get; set; }
	[PacketClass(Code = 213, IsOptional = True)]
	public SalesData[] SalesList { get; set; }
	[PacketParameter(Code = 81)]
	public short ReturnCode { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37644FC Offset: 0x37604FC VA: 0x37644FC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3764504 Offset: 0x3760504 VA: 0x3764504
	public byte get_SalesId() { }

	[CompilerGenerated]
	// RVA: 0x376450C Offset: 0x376050C VA: 0x376450C
	public void set_SalesId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3764514 Offset: 0x3760514 VA: 0x3764514
	public SalesData[] get_SalesList() { }

	[CompilerGenerated]
	// RVA: 0x376451C Offset: 0x376051C VA: 0x376451C
	public void set_SalesList(SalesData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3764524 Offset: 0x3760524 VA: 0x3764524
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x376452C Offset: 0x376052C VA: 0x376452C
	public void set_ReturnCode(short value) { }

	// RVA: 0x3764534 Offset: 0x3760534 VA: 0x3764534
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3764634 Offset: 0x3760634 VA: 0x3764634
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37646C0 Offset: 0x37606C0 VA: 0x37646C0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37646C8 Offset: 0x37606C8 VA: 0x37646C8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37646D0 Offset: 0x37606D0 VA: 0x37646D0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3764858 Offset: 0x3760858 VA: 0x3764858 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
