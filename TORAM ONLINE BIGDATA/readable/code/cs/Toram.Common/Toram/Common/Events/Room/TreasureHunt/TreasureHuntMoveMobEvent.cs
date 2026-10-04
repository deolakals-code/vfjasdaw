// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.TreasureHunt
public class TreasureHuntMoveMobEvent : EventSubBase // TypeDefIndex: 12794
{
	// Fields
	[CompilerGenerated]
	private MobData[] <MobList>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 89)]
	public MobData[] MobList { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x365AA88 Offset: 0x3656A88 VA: 0x365AA88
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x365AA90 Offset: 0x3656A90 VA: 0x365AA90
	public MobData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x365AA98 Offset: 0x3656A98 VA: 0x365AA98
	public void set_MobList(MobData[] value) { }

	// RVA: 0x365AAA0 Offset: 0x3656AA0 VA: 0x365AAA0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x365AAA8 Offset: 0x3656AA8 VA: 0x365AAA8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x365AAB0 Offset: 0x3656AB0 VA: 0x365AAB0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x365AB44 Offset: 0x3656B44 VA: 0x365AB44 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
