// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Lobby
public class LobbyMatchingCountdownResetEvent : EventSubBase // TypeDefIndex: 12767
{
	// Fields
	[CompilerGenerated]
	private RoomMemberData[] <Members>k__BackingField; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public RoomMemberData[] Members { get; set; }

	// Methods

	// RVA: 0x3654B30 Offset: 0x3650B30 VA: 0x3654B30
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3654B38 Offset: 0x3650B38 VA: 0x3654B38 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3654B40 Offset: 0x3650B40 VA: 0x3654B40 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3654B48 Offset: 0x3650B48 VA: 0x3654B48
	public RoomMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x3654B50 Offset: 0x3650B50 VA: 0x3654B50
	public void set_Members(RoomMemberData[] value) { }

	// RVA: 0x3654B58 Offset: 0x3650B58 VA: 0x3654B58 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3654CD0 Offset: 0x3650CD0 VA: 0x3654CD0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
