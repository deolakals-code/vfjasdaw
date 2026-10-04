// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Defence
public class DefenceTargetChangeMobEvent : EventSubBase // TypeDefIndex: 12776
{
	// Fields
	[CompilerGenerated]
	private DefenceMobData <MobData>k__BackingField; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	[PacketClass(Code = 76, IsOptional = True)]
	public DefenceMobData MobData { get; set; }

	// Methods

	// RVA: 0x365669C Offset: 0x365269C VA: 0x365669C
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x36566A4 Offset: 0x36526A4 VA: 0x36566A4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36566AC Offset: 0x36526AC VA: 0x36566AC Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x36566B4 Offset: 0x36526B4 VA: 0x36566B4
	public DefenceMobData get_MobData() { }

	[CompilerGenerated]
	// RVA: 0x36566BC Offset: 0x36526BC VA: 0x36566BC
	public void set_MobData(DefenceMobData value) { }

	// RVA: 0x36566C4 Offset: 0x36526C4 VA: 0x36566C4
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36567E4 Offset: 0x36527E4 VA: 0x36567E4
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3656860 Offset: 0x3652860 VA: 0x3656860 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36568F8 Offset: 0x36528F8 VA: 0x36568F8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
