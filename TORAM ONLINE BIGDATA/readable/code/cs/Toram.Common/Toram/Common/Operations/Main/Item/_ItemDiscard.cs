// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
[CLSCompliant(False)]
public class _ItemDiscard : OperationRequestBase // TypeDefIndex: 12141
{
	// Fields
	[CompilerGenerated]
	private ItemSelectData <SelectItem>k__BackingField; // 0x20

	// Properties
	public ItemSelectData SelectItem { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x378FA08 Offset: 0x378BA08 VA: 0x378FA08
	public void .ctor() { }

	// RVA: 0x378FA10 Offset: 0x378BA10 VA: 0x378FA10
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x378FA18 Offset: 0x378BA18 VA: 0x378FA18
	public ItemSelectData get_SelectItem() { }

	[CompilerGenerated]
	// RVA: 0x378FA20 Offset: 0x378BA20 VA: 0x378FA20
	public void set_SelectItem(ItemSelectData value) { }

	// RVA: 0x378FA28 Offset: 0x378BA28 VA: 0x378FA28 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x378FA30 Offset: 0x378BA30 VA: 0x378FA30 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x378FA38 Offset: 0x378BA38 VA: 0x378FA38 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x378FAC0 Offset: 0x378BAC0 VA: 0x378FAC0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
