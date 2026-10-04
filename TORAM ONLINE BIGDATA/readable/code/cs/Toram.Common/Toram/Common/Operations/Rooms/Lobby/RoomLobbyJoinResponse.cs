// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Lobby
public class RoomLobbyJoinResponse : OperationResponseBase // TypeDefIndex: 11776
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

	// RVA: 0x3748614 Offset: 0x3744614 VA: 0x3748614
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x374861C Offset: 0x374461C VA: 0x374861C
	public RoomLobbySetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x3748624 Offset: 0x3744624 VA: 0x3748624
	public void set_Setting(RoomLobbySetting value) { }

	[CompilerGenerated]
	// RVA: 0x374862C Offset: 0x374462C VA: 0x374862C
	public RoomMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x3748634 Offset: 0x3744634 VA: 0x3748634
	public void set_Members(RoomMemberData[] value) { }

	// RVA: 0x374863C Offset: 0x374463C VA: 0x374863C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3748644 Offset: 0x3744644 VA: 0x3748644 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x374864C Offset: 0x374464C VA: 0x374864C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3748880 Offset: 0x3744880 VA: 0x3748880 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
