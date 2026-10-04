// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Shop
public class EnhanceEquipment : OperationRequestBase // TypeDefIndex: 11706
{
	// Fields
	[CompilerGenerated]
	private int <ItemUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <ItemPropertyS>k__BackingField; // 0x28
	[CompilerGenerated]
	private short[] <itemPropertyValue>k__BackingField; // 0x30

	// Properties
	public int ItemUuid { get; set; }
	public short[] ItemPropertyS { get; set; }
	public short[] itemPropertyValue { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3736AE4 Offset: 0x3732AE4 VA: 0x3736AE4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3736AEC Offset: 0x3732AEC VA: 0x3736AEC
	public int get_ItemUuid() { }

	[CompilerGenerated]
	// RVA: 0x3736AF4 Offset: 0x3732AF4 VA: 0x3736AF4
	public void set_ItemUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3736AFC Offset: 0x3732AFC VA: 0x3736AFC
	public short[] get_ItemPropertyS() { }

	[CompilerGenerated]
	// RVA: 0x3736B04 Offset: 0x3732B04 VA: 0x3736B04
	public void set_ItemPropertyS(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x3736B0C Offset: 0x3732B0C VA: 0x3736B0C
	public short[] get_itemPropertyValue() { }

	[CompilerGenerated]
	// RVA: 0x3736B14 Offset: 0x3732B14 VA: 0x3736B14
	public void set_itemPropertyValue(short[] value) { }

	// RVA: 0x3736B1C Offset: 0x3732B1C VA: 0x3736B1C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3736B24 Offset: 0x3732B24 VA: 0x3736B24 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3736B2C Offset: 0x3732B2C VA: 0x3736B2C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3736BFC Offset: 0x3732BFC VA: 0x3736BFC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
