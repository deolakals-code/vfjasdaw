// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Market
public class MarketExhibit : OperationRequestBase // TypeDefIndex: 11912
{
	// Fields
	[CompilerGenerated]
	private byte <SaleId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <MarketType>k__BackingField; // 0x21
	[CompilerGenerated]
	private int <Price>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Fee>k__BackingField; // 0x28
	[CompilerGenerated]
	private ItemSelectData <SelectItem>k__BackingField; // 0x30
	[CompilerGenerated]
	private long <StarGemUuid>k__BackingField; // 0x38

	// Properties
	public byte SaleId { get; set; }
	public byte MarketType { get; set; }
	public int Price { get; set; }
	public int Fee { get; set; }
	public ItemSelectData SelectItem { get; set; }
	public long StarGemUuid { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3763D10 Offset: 0x375FD10 VA: 0x3763D10
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3763D18 Offset: 0x375FD18 VA: 0x3763D18
	public byte get_SaleId() { }

	[CompilerGenerated]
	// RVA: 0x3763D20 Offset: 0x375FD20 VA: 0x3763D20
	public void set_SaleId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3763D28 Offset: 0x375FD28 VA: 0x3763D28
	public byte get_MarketType() { }

	[CompilerGenerated]
	// RVA: 0x3763D30 Offset: 0x375FD30 VA: 0x3763D30
	public void set_MarketType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3763D38 Offset: 0x375FD38 VA: 0x3763D38
	public int get_Price() { }

	[CompilerGenerated]
	// RVA: 0x3763D40 Offset: 0x375FD40 VA: 0x3763D40
	public void set_Price(int value) { }

	[CompilerGenerated]
	// RVA: 0x3763D48 Offset: 0x375FD48 VA: 0x3763D48
	public int get_Fee() { }

	[CompilerGenerated]
	// RVA: 0x3763D50 Offset: 0x375FD50 VA: 0x3763D50
	public void set_Fee(int value) { }

	[CompilerGenerated]
	// RVA: 0x3763D58 Offset: 0x375FD58 VA: 0x3763D58
	public ItemSelectData get_SelectItem() { }

	[CompilerGenerated]
	// RVA: 0x3763D60 Offset: 0x375FD60 VA: 0x3763D60
	public void set_SelectItem(ItemSelectData value) { }

	[CompilerGenerated]
	// RVA: 0x3763D68 Offset: 0x375FD68 VA: 0x3763D68
	public long get_StarGemUuid() { }

	[CompilerGenerated]
	// RVA: 0x3763D70 Offset: 0x375FD70 VA: 0x3763D70
	public void set_StarGemUuid(long value) { }

	// RVA: 0x3763D78 Offset: 0x375FD78 VA: 0x3763D78 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3763D80 Offset: 0x375FD80 VA: 0x3763D80 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3763D88 Offset: 0x375FD88 VA: 0x3763D88 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37640CC Offset: 0x37600CC VA: 0x37640CC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
