// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
[CLSCompliant(False)]
public class _ItemDiscardResponse : OperationResponseBase // TypeDefIndex: 12142
{
	// Fields
	[CompilerGenerated]
	private ItemDatav2[] <ItemList>k__BackingField; // 0x20

	// Properties
	public ItemDatav2[] ItemList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x378FC54 Offset: 0x378BC54 VA: 0x378FC54
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x378FC5C Offset: 0x378BC5C VA: 0x378FC5C
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x378FC64 Offset: 0x378BC64 VA: 0x378FC64
	public void set_ItemList(ItemDatav2[] value) { }

	// RVA: 0x378FC6C Offset: 0x378BC6C VA: 0x378FC6C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x378FC74 Offset: 0x378BC74 VA: 0x378FC74 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x378FC7C Offset: 0x378BC7C VA: 0x378FC7C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x378FD24 Offset: 0x378BD24 VA: 0x378FD24 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
