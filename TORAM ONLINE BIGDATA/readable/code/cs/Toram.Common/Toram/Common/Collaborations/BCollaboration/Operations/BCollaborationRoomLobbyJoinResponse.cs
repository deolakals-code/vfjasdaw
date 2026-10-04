// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.BCollaboration.Operations
public class BCollaborationRoomLobbyJoinResponse : OperationResponseBase // TypeDefIndex: 13070
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

	// RVA: 0x369C938 Offset: 0x3698938 VA: 0x369C938
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x369C940 Offset: 0x3698940 VA: 0x369C940
	public RoomLobbySetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x369C948 Offset: 0x3698948 VA: 0x369C948
	public void set_Setting(RoomLobbySetting value) { }

	[CompilerGenerated]
	// RVA: 0x369C950 Offset: 0x3698950 VA: 0x369C950
	public RoomMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x369C958 Offset: 0x3698958 VA: 0x369C958
	public void set_Members(RoomMemberData[] value) { }

	// RVA: 0x369C960 Offset: 0x3698960 VA: 0x369C960 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x369C968 Offset: 0x3698968 VA: 0x369C968 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x369C970 Offset: 0x3698970 VA: 0x369C970 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x369CBA4 Offset: 0x3698BA4 VA: 0x369CBA4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
