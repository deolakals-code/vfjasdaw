// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Market
public class MarketPurchaseCheck : OperationRequestBase // TypeDefIndex: 11921
{
	// Fields
	[CompilerGenerated]
	private byte <MarketType>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x21
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <ViewType>k__BackingField; // 0x28
	[CompilerGenerated]
	private long <MarketId>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <TariffRate>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <AutoLockFlag>k__BackingField; // 0x3C

	// Properties
	public byte MarketType { get; set; }
	public byte Type { get; set; }
	public int Id { get; set; }
	public byte ViewType { get; set; }
	public long MarketId { get; set; }
	public byte TariffRate { get; set; }
	public int AutoLockFlag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3765BC0 Offset: 0x3761BC0 VA: 0x3765BC0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3765BC8 Offset: 0x3761BC8 VA: 0x3765BC8
	public byte get_MarketType() { }

	[CompilerGenerated]
	// RVA: 0x3765BD0 Offset: 0x3761BD0 VA: 0x3765BD0
	public void set_MarketType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3765BD8 Offset: 0x3761BD8 VA: 0x3765BD8
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3765BE0 Offset: 0x3761BE0 VA: 0x3765BE0
	public void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3765BE8 Offset: 0x3761BE8 VA: 0x3765BE8
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x3765BF0 Offset: 0x3761BF0 VA: 0x3765BF0
	public void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x3765BF8 Offset: 0x3761BF8 VA: 0x3765BF8
	public byte get_ViewType() { }

	[CompilerGenerated]
	// RVA: 0x3765C00 Offset: 0x3761C00 VA: 0x3765C00
	public void set_ViewType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3765C08 Offset: 0x3761C08 VA: 0x3765C08
	public long get_MarketId() { }

	[CompilerGenerated]
	// RVA: 0x3765C10 Offset: 0x3761C10 VA: 0x3765C10
	public void set_MarketId(long value) { }

	[CompilerGenerated]
	// RVA: 0x3765C18 Offset: 0x3761C18 VA: 0x3765C18
	public byte get_TariffRate() { }

	[CompilerGenerated]
	// RVA: 0x3765C20 Offset: 0x3761C20 VA: 0x3765C20
	public void set_TariffRate(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3765C28 Offset: 0x3761C28 VA: 0x3765C28
	public int get_AutoLockFlag() { }

	[CompilerGenerated]
	// RVA: 0x3765C30 Offset: 0x3761C30 VA: 0x3765C30
	public void set_AutoLockFlag(int value) { }

	// RVA: 0x3765C38 Offset: 0x3761C38 VA: 0x3765C38 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3765C40 Offset: 0x3761C40 VA: 0x3765C40 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3765C48 Offset: 0x3761C48 VA: 0x3765C48 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3765F64 Offset: 0x3761F64 VA: 0x3765F64 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
