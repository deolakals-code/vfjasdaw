// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.BCollaboration.Operations
public class BCollaborationCheckRoomResponse : OperationResponseBase // TypeDefIndex: 13066
{
	// Fields
	[CompilerGenerated]
	private RoomLobbySetting <Setting>k__BackingField; // 0x20
	[CompilerGenerated]
	private RoomMemberData[] <Members>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <NextResetTimeLeft>k__BackingField; // 0x30

	// Properties
	public RoomLobbySetting Setting { get; set; }
	public RoomMemberData[] Members { get; set; }
	public int NextResetTimeLeft { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x369BE34 Offset: 0x3697E34 VA: 0x369BE34
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x369BE3C Offset: 0x3697E3C VA: 0x369BE3C
	public RoomLobbySetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x369BE44 Offset: 0x3697E44 VA: 0x369BE44
	public void set_Setting(RoomLobbySetting value) { }

	[CompilerGenerated]
	// RVA: 0x369BE4C Offset: 0x3697E4C VA: 0x369BE4C
	public RoomMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x369BE54 Offset: 0x3697E54 VA: 0x369BE54
	public void set_Members(RoomMemberData[] value) { }

	[CompilerGenerated]
	// RVA: 0x369BE5C Offset: 0x3697E5C VA: 0x369BE5C
	public int get_NextResetTimeLeft() { }

	[CompilerGenerated]
	// RVA: 0x369BE64 Offset: 0x3697E64 VA: 0x369BE64
	public void set_NextResetTimeLeft(int value) { }

	// RVA: 0x369BE6C Offset: 0x3697E6C VA: 0x369BE6C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x369BE74 Offset: 0x3697E74 VA: 0x369BE74 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x369BE7C Offset: 0x3697E7C VA: 0x369BE7C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x369C100 Offset: 0x3698100 VA: 0x369C100 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
