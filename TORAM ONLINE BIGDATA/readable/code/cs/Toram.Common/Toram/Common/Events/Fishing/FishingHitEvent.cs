// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Fishing
public class FishingHitEvent : EventSubBase // TypeDefIndex: 12704
{
	// Fields
	[CompilerGenerated]
	private byte <RodIndex>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Durability>k__BackingField; // 0x21
	[CompilerGenerated]
	private byte <ChummingCount>k__BackingField; // 0x22

	// Properties
	[PacketParameter(Code = 62)]
	public byte RodIndex { get; set; }
	[PacketParameter(Code = 10)]
	public byte Durability { get; set; }
	[PacketParameter(Code = 11)]
	public byte ChummingCount { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36451FC Offset: 0x36411FC VA: 0x36451FC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3645204 Offset: 0x3641204 VA: 0x3645204
	public byte get_RodIndex() { }

	[CompilerGenerated]
	// RVA: 0x364520C Offset: 0x364120C VA: 0x364520C
	public void set_RodIndex(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3645214 Offset: 0x3641214 VA: 0x3645214
	public byte get_Durability() { }

	[CompilerGenerated]
	// RVA: 0x364521C Offset: 0x364121C VA: 0x364521C
	public void set_Durability(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3645224 Offset: 0x3641224 VA: 0x3645224
	public byte get_ChummingCount() { }

	[CompilerGenerated]
	// RVA: 0x364522C Offset: 0x364122C VA: 0x364522C
	public void set_ChummingCount(byte value) { }

	// RVA: 0x3645234 Offset: 0x3641234 VA: 0x3645234 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364523C Offset: 0x364123C VA: 0x364523C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3645244 Offset: 0x3641244 VA: 0x3645244 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x364533C Offset: 0x364133C VA: 0x364533C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
