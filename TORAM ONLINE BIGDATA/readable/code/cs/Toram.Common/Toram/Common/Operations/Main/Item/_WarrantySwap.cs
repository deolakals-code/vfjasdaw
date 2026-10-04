// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
[CLSCompliant(False)]
public class _WarrantySwap : OperationRequestBase // TypeDefIndex: 12147
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

	// RVA: 0x3790870 Offset: 0x378C870 VA: 0x3790870
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3790878 Offset: 0x378C878 VA: 0x3790878
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x3790880 Offset: 0x378C880 VA: 0x3790880
	public void set_ItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3790888 Offset: 0x378C888 VA: 0x3790888
	public byte get_ItemIndex() { }

	[CompilerGenerated]
	// RVA: 0x3790890 Offset: 0x378C890 VA: 0x3790890
	public void set_ItemIndex(byte value) { }

	// RVA: 0x3790898 Offset: 0x378C898 VA: 0x3790898 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37908A0 Offset: 0x378C8A0 VA: 0x37908A0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37908A8 Offset: 0x378C8A8 VA: 0x37908A8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3790984 Offset: 0x378C984 VA: 0x3790984 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
