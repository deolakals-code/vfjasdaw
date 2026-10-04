// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Market
public class MarketPurchaseResponse : OperationResponseBase // TypeDefIndex: 11922
{
	// Fields
	[CompilerGenerated]
	private byte <MarketType>k__BackingField; // 0x20
	[CompilerGenerated]
	private long <MarketId>k__BackingField; // 0x28
	[CompilerGenerated]
	private MarketData <PurchaseProduct>k__BackingField; // 0x30
	[CompilerGenerated]
	private MarketResultData <ResultData>k__BackingField; // 0x38
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x40

	// Properties
	[PacketParameter(Code = 245)]
	public byte MarketType { get; set; }
	[PacketParameter(Code = 200)]
	public long MarketId { get; set; }
	[PacketParameter(Code = 199, IsOptional = True)]
	public MarketData PurchaseProduct { get; set; }
	[PacketClass(Code = 84, IsOptional = True)]
	public MarketResultData ResultData { get; set; }
	[PacketParameter(Code = 81)]
	public short ReturnCode { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3766130 Offset: 0x3762130 VA: 0x3766130
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3766138 Offset: 0x3762138 VA: 0x3766138
	public byte get_MarketType() { }

	[CompilerGenerated]
	// RVA: 0x3766140 Offset: 0x3762140 VA: 0x3766140
	public void set_MarketType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3766148 Offset: 0x3762148 VA: 0x3766148
	public long get_MarketId() { }

	[CompilerGenerated]
	// RVA: 0x3766150 Offset: 0x3762150 VA: 0x3766150
	public void set_MarketId(long value) { }

	[CompilerGenerated]
	// RVA: 0x3766158 Offset: 0x3762158 VA: 0x3766158
	public MarketData get_PurchaseProduct() { }

	[CompilerGenerated]
	// RVA: 0x3766160 Offset: 0x3762160 VA: 0x3766160
	public void set_PurchaseProduct(MarketData value) { }

	[CompilerGenerated]
	// RVA: 0x3766168 Offset: 0x3762168 VA: 0x3766168
	public MarketResultData get_ResultData() { }

	[CompilerGenerated]
	// RVA: 0x3766170 Offset: 0x3762170 VA: 0x3766170
	public void set_ResultData(MarketResultData value) { }

	[CompilerGenerated]
	// RVA: 0x3766178 Offset: 0x3762178 VA: 0x3766178
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x3766180 Offset: 0x3762180 VA: 0x3766180
	public void set_ReturnCode(short value) { }

	// RVA: 0x3766188 Offset: 0x3762188 VA: 0x3766188
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3766368 Offset: 0x3762368 VA: 0x3766368
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3766410 Offset: 0x3762410 VA: 0x3766410 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3766418 Offset: 0x3762418 VA: 0x3766418 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3766420 Offset: 0x3762420 VA: 0x3766420 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3766600 Offset: 0x3762600 VA: 0x3766600 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
