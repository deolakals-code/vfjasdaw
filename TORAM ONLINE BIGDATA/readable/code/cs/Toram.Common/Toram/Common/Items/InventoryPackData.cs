// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Items
public class InventoryPackData : PacketBase // TypeDefIndex: 12498
{
	// Fields
	[CompilerGenerated]
	private CollectItemDatav2[] <Collects>k__BackingField; // 0x20
	[CompilerGenerated]
	private ConsumeItemDatav2[] <Consumes>k__BackingField; // 0x28
	[CompilerGenerated]
	private EquipItemDatav2[] <Equips>k__BackingField; // 0x30

	// Properties
	public CollectItemDatav2[] Collects { get; set; }
	public ConsumeItemDatav2[] Consumes { get; set; }
	public EquipItemDatav2[] Equips { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3611A2C Offset: 0x360DA2C VA: 0x3611A2C
	public void .ctor() { }

	// RVA: 0x3611A34 Offset: 0x360DA34 VA: 0x3611A34
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3611A3C Offset: 0x360DA3C VA: 0x3611A3C
	public CollectItemDatav2[] get_Collects() { }

	[CompilerGenerated]
	// RVA: 0x3611A44 Offset: 0x360DA44 VA: 0x3611A44
	public void set_Collects(CollectItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x3611A4C Offset: 0x360DA4C VA: 0x3611A4C
	public ConsumeItemDatav2[] get_Consumes() { }

	[CompilerGenerated]
	// RVA: 0x3611A54 Offset: 0x360DA54 VA: 0x3611A54
	public void set_Consumes(ConsumeItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x3611A5C Offset: 0x360DA5C VA: 0x3611A5C
	public EquipItemDatav2[] get_Equips() { }

	[CompilerGenerated]
	// RVA: 0x3611A64 Offset: 0x360DA64 VA: 0x3611A64
	public void set_Equips(EquipItemDatav2[] value) { }

	// RVA: 0x3611A6C Offset: 0x360DA6C VA: 0x3611A6C
	private byte[] GetSummerizeBinary() { }

	// RVA: 0x3611EE0 Offset: 0x360DEE0 VA: 0x3611EE0
	private void SetSummerizeItem(byte[] bin) { }

	// RVA: -1 Offset: -1
	public T[] GetItemArray<T>(byte[] binary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C5AF0 Offset: 0x26C1AF0 VA: 0x26C5AF0
	|-InventoryPackData.GetItemArray<object>
	*/

	// RVA: 0x3612158 Offset: 0x360E158 VA: 0x3612158 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3612160 Offset: 0x360E160 VA: 0x3612160 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x36122D0 Offset: 0x360E2D0 VA: 0x36122D0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
