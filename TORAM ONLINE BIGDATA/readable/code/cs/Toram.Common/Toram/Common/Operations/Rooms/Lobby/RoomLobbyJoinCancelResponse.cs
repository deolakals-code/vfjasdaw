// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Lobby
public class RoomLobbyJoinCancelResponse : OperationResponseBase // TypeDefIndex: 11775
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

	// RVA: 0x37482E4 Offset: 0x37442E4 VA: 0x37482E4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37482EC Offset: 0x37442EC VA: 0x37482EC
	public RoomLobbySetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x37482F4 Offset: 0x37442F4 VA: 0x37482F4
	public void set_Setting(RoomLobbySetting value) { }

	[CompilerGenerated]
	// RVA: 0x37482FC Offset: 0x37442FC VA: 0x37482FC
	public RoomMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x3748304 Offset: 0x3744304 VA: 0x3748304
	public void set_Members(RoomMemberData[] value) { }

	// RVA: 0x374830C Offset: 0x374430C VA: 0x374830C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3748314 Offset: 0x3744314 VA: 0x3748314 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x374831C Offset: 0x374431C VA: 0x374831C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3748550 Offset: 0x3744550 VA: 0x3748550 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
