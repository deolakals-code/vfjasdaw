// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
[CLSCompliant(False)]
public class _WarrantyDiscard : OperationRequestBase // TypeDefIndex: 12145
{
	// Fields
	[CompilerGenerated]
	private int <ItemId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ItemIndex>k__BackingField; // 0x24

	// Properties
	public int ItemId { get; set; }
	public byte ItemIndex { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37903FC Offset: 0x378C3FC VA: 0x37903FC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3790404 Offset: 0x378C404 VA: 0x3790404
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x379040C Offset: 0x378C40C VA: 0x379040C
	public void set_ItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3790414 Offset: 0x378C414 VA: 0x3790414
	public byte get_ItemIndex() { }

	[CompilerGenerated]
	// RVA: 0x379041C Offset: 0x378C41C VA: 0x379041C
	public void set_ItemIndex(byte value) { }

	// RVA: 0x3790424 Offset: 0x378C424 VA: 0x3790424 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x379042C Offset: 0x378C42C VA: 0x379042C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3790434 Offset: 0x378C434 VA: 0x3790434 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3790510 Offset: 0x378C510 VA: 0x3790510 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
