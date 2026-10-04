// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class BagCapacityEvent : PacketBase // TypeDefIndex: 12620
{
	// Fields
	[CompilerGenerated]
	private short[] <InventoryCapacity>k__BackingField; // 0x20

	// Properties
	public short[] InventoryCapacity { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3632A88 Offset: 0x362EA88 VA: 0x3632A88
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3632A90 Offset: 0x362EA90 VA: 0x3632A90
	public short[] get_InventoryCapacity() { }

	[CompilerGenerated]
	// RVA: 0x3632A98 Offset: 0x362EA98 VA: 0x3632A98
	public void set_InventoryCapacity(short[] value) { }

	// RVA: 0x3632AA0 Offset: 0x362EAA0 VA: 0x3632AA0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3632AA8 Offset: 0x362EAA8 VA: 0x3632AA8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3632C00 Offset: 0x362EC00 VA: 0x3632C00 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
