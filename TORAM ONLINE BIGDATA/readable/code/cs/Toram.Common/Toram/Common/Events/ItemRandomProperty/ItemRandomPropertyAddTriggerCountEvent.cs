// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.ItemRandomProperty
public class ItemRandomPropertyAddTriggerCountEvent : EventSubBase // TypeDefIndex: 12651
{
	// Fields
	[CompilerGenerated]
	private byte <EquipType>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <PropertyId>k__BackingField; // 0x22
	[CompilerGenerated]
	private short <TriggerCount>k__BackingField; // 0x24

	// Properties
	public byte EquipType { get; set; }
	public short PropertyId { get; set; }
	public short TriggerCount { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3639F34 Offset: 0x3635F34 VA: 0x3639F34
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3639F3C Offset: 0x3635F3C VA: 0x3639F3C
	public byte get_EquipType() { }

	[CompilerGenerated]
	// RVA: 0x3639F44 Offset: 0x3635F44 VA: 0x3639F44
	public void set_EquipType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3639F4C Offset: 0x3635F4C VA: 0x3639F4C
	public short get_PropertyId() { }

	[CompilerGenerated]
	// RVA: 0x3639F54 Offset: 0x3635F54 VA: 0x3639F54
	public void set_PropertyId(short value) { }

	[CompilerGenerated]
	// RVA: 0x3639F5C Offset: 0x3635F5C VA: 0x3639F5C
	public short get_TriggerCount() { }

	[CompilerGenerated]
	// RVA: 0x3639F64 Offset: 0x3635F64 VA: 0x3639F64
	public void set_TriggerCount(short value) { }

	// RVA: 0x3639F6C Offset: 0x3635F6C VA: 0x3639F6C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3639F74 Offset: 0x3635F74 VA: 0x3639F74 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3639F7C Offset: 0x3635F7C VA: 0x3639F7C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x363A084 Offset: 0x3636084 VA: 0x363A084 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
