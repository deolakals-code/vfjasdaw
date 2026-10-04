// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Items
public class WarrantyItemPackData : PacketBase // TypeDefIndex: 12504
{
	// Fields
	[CompilerGenerated]
	private WarrantyItemDatav2[] <Items>k__BackingField; // 0x20

	// Properties
	public WarrantyItemDatav2[] Items { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3614F2C Offset: 0x3610F2C VA: 0x3614F2C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3614F34 Offset: 0x3610F34 VA: 0x3614F34
	public WarrantyItemDatav2[] get_Items() { }

	[CompilerGenerated]
	// RVA: 0x3614F3C Offset: 0x3610F3C VA: 0x3614F3C
	public void set_Items(WarrantyItemDatav2[] value) { }

	// RVA: 0x3614F44 Offset: 0x3610F44 VA: 0x3614F44 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3614F4C Offset: 0x3610F4C VA: 0x3614F4C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3614FEC Offset: 0x3610FEC VA: 0x3614FEC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
