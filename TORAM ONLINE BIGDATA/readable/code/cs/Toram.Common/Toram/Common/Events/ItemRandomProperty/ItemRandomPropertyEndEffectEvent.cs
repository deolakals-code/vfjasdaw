// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.ItemRandomProperty
public class ItemRandomPropertyEndEffectEvent : EventSubBase // TypeDefIndex: 12652
{
	// Fields
	[CompilerGenerated]
	private byte <EquipType>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <PropertyId>k__BackingField; // 0x22

	// Properties
	public byte EquipType { get; set; }
	public short PropertyId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x363A248 Offset: 0x3636248 VA: 0x363A248
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x363A250 Offset: 0x3636250 VA: 0x363A250
	public byte get_EquipType() { }

	[CompilerGenerated]
	// RVA: 0x363A258 Offset: 0x3636258 VA: 0x363A258
	public void set_EquipType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363A260 Offset: 0x3636260 VA: 0x363A260
	public short get_PropertyId() { }

	[CompilerGenerated]
	// RVA: 0x363A268 Offset: 0x3636268 VA: 0x363A268
	public void set_PropertyId(short value) { }

	// RVA: 0x363A270 Offset: 0x3636270 VA: 0x363A270 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363A278 Offset: 0x3636278 VA: 0x363A278 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x363A280 Offset: 0x3636280 VA: 0x363A280 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x363A358 Offset: 0x3636358 VA: 0x363A358 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
