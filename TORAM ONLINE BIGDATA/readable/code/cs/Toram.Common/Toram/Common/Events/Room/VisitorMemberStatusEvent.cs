// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room
public class VisitorMemberStatusEvent : PacketBase // TypeDefIndex: 12746
{
	// Fields
	[CompilerGenerated]
	private RoomMemberStatusData[] <Members>k__BackingField; // 0x20

	// Properties
	public RoomMemberStatusData[] Members { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x364FC78 Offset: 0x364BC78 VA: 0x364FC78
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x364FC80 Offset: 0x364BC80 VA: 0x364FC80
	public RoomMemberStatusData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x364FC88 Offset: 0x364BC88 VA: 0x364FC88
	public void set_Members(RoomMemberStatusData[] value) { }

	// RVA: 0x364FC90 Offset: 0x364BC90 VA: 0x364FC90 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364FC98 Offset: 0x364BC98 VA: 0x364FC98 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x364FE10 Offset: 0x364BE10 VA: 0x364FE10 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
