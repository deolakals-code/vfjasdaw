// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Market
public class MarketSalesAcquisition : OperationRequestBase // TypeDefIndex: 11923
{
	// Fields
	[CompilerGenerated]
	private byte <SaleId>k__BackingField; // 0x20
	[CompilerGenerated]
	private long <MarketId>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 200)]
	public byte SaleId { get; set; }
	[PacketParameter(Code = 88)]
	public long MarketId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x376672C Offset: 0x376272C VA: 0x376672C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3766734 Offset: 0x3762734 VA: 0x3766734
	public byte get_SaleId() { }

	[CompilerGenerated]
	// RVA: 0x376673C Offset: 0x376273C VA: 0x376673C
	public void set_SaleId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3766744 Offset: 0x3762744 VA: 0x3766744
	public long get_MarketId() { }

	[CompilerGenerated]
	// RVA: 0x376674C Offset: 0x376274C VA: 0x376674C
	public void set_MarketId(long value) { }

	// RVA: 0x3766754 Offset: 0x3762754 VA: 0x3766754 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376675C Offset: 0x376275C VA: 0x376675C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3766764 Offset: 0x3762764 VA: 0x3766764 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37668DC Offset: 0x37628DC VA: 0x37668DC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
