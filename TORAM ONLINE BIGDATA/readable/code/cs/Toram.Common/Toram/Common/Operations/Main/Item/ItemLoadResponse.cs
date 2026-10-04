// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
public class ItemLoadResponse : OperationResponseBase // TypeDefIndex: 12132
{
	// Fields
	[CompilerGenerated]
	private InventoryPackData <Inventory>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <InventoryCapacity>k__BackingField; // 0x28

	// Properties
	public InventoryPackData Inventory { get; set; }
	public short[] InventoryCapacity { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x378E18C Offset: 0x378A18C VA: 0x378E18C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x378E194 Offset: 0x378A194 VA: 0x378E194
	public InventoryPackData get_Inventory() { }

	[CompilerGenerated]
	// RVA: 0x378E19C Offset: 0x378A19C VA: 0x378E19C
	public void set_Inventory(InventoryPackData value) { }

	[CompilerGenerated]
	// RVA: 0x378E1A4 Offset: 0x378A1A4 VA: 0x378E1A4
	public short[] get_InventoryCapacity() { }

	[CompilerGenerated]
	// RVA: 0x378E1AC Offset: 0x378A1AC VA: 0x378E1AC
	public void set_InventoryCapacity(short[] value) { }

	// RVA: 0x378E1B4 Offset: 0x378A1B4 VA: 0x378E1B4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x378E1BC Offset: 0x378A1BC VA: 0x378E1BC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x378E1C4 Offset: 0x378A1C4 VA: 0x378E1C4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x378E264 Offset: 0x378A264 VA: 0x378E264 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
