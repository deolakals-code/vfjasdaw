// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.TreasureHunt
public class TreasureHuntPopMobEvent : EventSubBase // TypeDefIndex: 12795
{
	// Fields
	[CompilerGenerated]
	private TreasureHuntMobData[] <MobList>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 89)]
	public TreasureHuntMobData[] MobList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x365AC98 Offset: 0x3656C98 VA: 0x365AC98
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x365ACA0 Offset: 0x3656CA0 VA: 0x365ACA0
	public TreasureHuntMobData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x365ACA8 Offset: 0x3656CA8 VA: 0x365ACA8
	public void set_MobList(TreasureHuntMobData[] value) { }

	// RVA: 0x365ACB0 Offset: 0x3656CB0 VA: 0x365ACB0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x365ACB8 Offset: 0x3656CB8 VA: 0x365ACB8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x365ACC0 Offset: 0x3656CC0 VA: 0x365ACC0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x365AD54 Offset: 0x3656D54 VA: 0x365AD54 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
