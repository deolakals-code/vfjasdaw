// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.BCollaboration.Operations
public class BCollaborationRoomLobbyStateResponse : OperationResponseBase // TypeDefIndex: 13071
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

	// RVA: 0x369CC68 Offset: 0x3698C68 VA: 0x369CC68
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x369CC70 Offset: 0x3698C70 VA: 0x369CC70
	public RoomLobbySetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x369CC78 Offset: 0x3698C78 VA: 0x369CC78
	public void set_Setting(RoomLobbySetting value) { }

	[CompilerGenerated]
	// RVA: 0x369CC80 Offset: 0x3698C80 VA: 0x369CC80
	public RoomMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x369CC88 Offset: 0x3698C88 VA: 0x369CC88
	public void set_Members(RoomMemberData[] value) { }

	// RVA: 0x369CC90 Offset: 0x3698C90 VA: 0x369CC90 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x369CC98 Offset: 0x3698C98 VA: 0x369CC98 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x369CCA0 Offset: 0x3698CA0 VA: 0x369CCA0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x369CED4 Offset: 0x3698ED4 VA: 0x369CED4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
