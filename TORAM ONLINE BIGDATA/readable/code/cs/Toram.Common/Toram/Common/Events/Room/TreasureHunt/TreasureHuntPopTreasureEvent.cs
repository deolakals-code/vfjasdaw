// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.TreasureHunt
public class TreasureHuntPopTreasureEvent : EventSubBase // TypeDefIndex: 12796
{
	// Fields
	[CompilerGenerated]
	private TreasureHuntTreasureData[] <TreasureList>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 213)]
	public TreasureHuntTreasureData[] TreasureList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x365AEA8 Offset: 0x3656EA8 VA: 0x365AEA8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x365AEB0 Offset: 0x3656EB0 VA: 0x365AEB0
	public TreasureHuntTreasureData[] get_TreasureList() { }

	[CompilerGenerated]
	// RVA: 0x365AEB8 Offset: 0x3656EB8 VA: 0x365AEB8
	public void set_TreasureList(TreasureHuntTreasureData[] value) { }

	// RVA: 0x365AEC0 Offset: 0x3656EC0 VA: 0x365AEC0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x365AEC8 Offset: 0x3656EC8 VA: 0x365AEC8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x365AED0 Offset: 0x3656ED0 VA: 0x365AED0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x365AF64 Offset: 0x3656F64 VA: 0x365AF64 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
