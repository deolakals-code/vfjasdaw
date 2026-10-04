// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.BCollaboration.Operations
public class BCollaborationRoomLobbyJoinCancelResponse : OperationResponseBase // TypeDefIndex: 13069
{
	// Fields
	[CompilerGenerated]
	private RoomLobbySetting <Setting>k__BackingField; // 0x20
	[CompilerGenerated]
	private RoomMemberData[] <Members>k__BackingField; // 0x28

	// Properties
	public RoomLobbySetting Setting { get; set; }
	public RoomMemberData[] Members { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x369C608 Offset: 0x3698608 VA: 0x369C608
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x369C610 Offset: 0x3698610 VA: 0x369C610
	public RoomLobbySetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x369C618 Offset: 0x3698618 VA: 0x369C618
	public void set_Setting(RoomLobbySetting value) { }

	[CompilerGenerated]
	// RVA: 0x369C620 Offset: 0x3698620 VA: 0x369C620
	public RoomMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x369C628 Offset: 0x3698628 VA: 0x369C628
	public void set_Members(RoomMemberData[] value) { }

	// RVA: 0x369C630 Offset: 0x3698630 VA: 0x369C630 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x369C638 Offset: 0x3698638 VA: 0x369C638 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x369C640 Offset: 0x3698640 VA: 0x369C640 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x369C874 Offset: 0x3698874 VA: 0x369C874 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
