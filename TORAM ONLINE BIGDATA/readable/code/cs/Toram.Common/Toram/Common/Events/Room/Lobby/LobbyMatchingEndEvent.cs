// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Lobby
public class LobbyMatchingEndEvent : EventSubBase // TypeDefIndex: 12769
{
	// Fields
	[CompilerGenerated]
	private RoomMemberData[] <Members>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsTimeout>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public RoomMemberData[] Members { get; set; }
	public bool IsTimeout { get; set; }

	// Methods

	// RVA: 0x3654F7C Offset: 0x3650F7C VA: 0x3654F7C
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3654F84 Offset: 0x3650F84 VA: 0x3654F84 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3654F8C Offset: 0x3650F8C VA: 0x3654F8C Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3654F94 Offset: 0x3650F94 VA: 0x3654F94
	public RoomMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x3654F9C Offset: 0x3650F9C VA: 0x3654F9C
	public void set_Members(RoomMemberData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3654FA4 Offset: 0x3650FA4 VA: 0x3654FA4
	public bool get_IsTimeout() { }

	[CompilerGenerated]
	// RVA: 0x3654FAC Offset: 0x3650FAC VA: 0x3654FAC
	public void set_IsTimeout(bool value) { }

	// RVA: 0x3654FB8 Offset: 0x3650FB8 VA: 0x3654FB8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36551B0 Offset: 0x36511B0 VA: 0x36551B0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
