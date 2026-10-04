// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Lobby
public class RoomLobbyStateResponse : OperationResponseBase // TypeDefIndex: 11779
{
	// Fields
	[CompilerGenerated]
	private RoomLobbySetting <Setting>k__BackingField; // 0x20
	[CompilerGenerated]
	private RoomMemberData[] <Members>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <AdminId>k__BackingField; // 0x30

	// Properties
	public RoomLobbySetting Setting { get; set; }
	public RoomMemberData[] Members { get; set; }
	public int AdminId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3748DCC Offset: 0x3744DCC VA: 0x3748DCC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3748DD4 Offset: 0x3744DD4 VA: 0x3748DD4
	public RoomLobbySetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x3748DDC Offset: 0x3744DDC VA: 0x3748DDC
	public void set_Setting(RoomLobbySetting value) { }

	[CompilerGenerated]
	// RVA: 0x3748DE4 Offset: 0x3744DE4 VA: 0x3748DE4
	public RoomMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x3748DEC Offset: 0x3744DEC VA: 0x3748DEC
	public void set_Members(RoomMemberData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3748DF4 Offset: 0x3744DF4 VA: 0x3748DF4
	public int get_AdminId() { }

	[CompilerGenerated]
	// RVA: 0x3748DFC Offset: 0x3744DFC VA: 0x3748DFC
	public void set_AdminId(int value) { }

	// RVA: 0x3748E04 Offset: 0x3744E04 VA: 0x3748E04 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3748E0C Offset: 0x3744E0C VA: 0x3748E0C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3748E14 Offset: 0x3744E14 VA: 0x3748E14 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37490C0 Offset: 0x37450C0 VA: 0x37490C0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
