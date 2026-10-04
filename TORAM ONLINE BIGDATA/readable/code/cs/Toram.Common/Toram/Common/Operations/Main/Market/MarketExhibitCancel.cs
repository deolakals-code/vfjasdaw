// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Market
public class MarketExhibitCancel : OperationRequestBase // TypeDefIndex: 11913
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

	// RVA: 0x3764268 Offset: 0x3760268 VA: 0x3764268
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3764270 Offset: 0x3760270 VA: 0x3764270
	public byte get_SaleId() { }

	[CompilerGenerated]
	// RVA: 0x3764278 Offset: 0x3760278 VA: 0x3764278
	public void set_SaleId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3764280 Offset: 0x3760280 VA: 0x3764280
	public long get_MarketId() { }

	[CompilerGenerated]
	// RVA: 0x3764288 Offset: 0x3760288 VA: 0x3764288
	public void set_MarketId(long value) { }

	// RVA: 0x3764290 Offset: 0x3760290 VA: 0x3764290 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3764298 Offset: 0x3760298 VA: 0x3764298 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37642A0 Offset: 0x37602A0 VA: 0x37642A0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3764418 Offset: 0x3760418 VA: 0x3764418 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
