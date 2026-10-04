// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.BCollaboration.Operations
public class BCollaborationRoomMatchingStartResponse : OperationResponseBase // TypeDefIndex: 13073
{
	// Fields
	[CompilerGenerated]
	private bool <IsMatched>k__BackingField; // 0x20
	[CompilerGenerated]
	private RoomLobbySetting <Setting>k__BackingField; // 0x28
	[CompilerGenerated]
	private RoomMemberData[] <Members>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 141)]
	public bool IsMatched { get; set; }
	[PacketParameter(Code = 187)]
	public RoomLobbySetting Setting { get; set; }
	[PacketParameter(Code = 95)]
	public RoomMemberData[] Members { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x369CFC0 Offset: 0x3698FC0 VA: 0x369CFC0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x369CFC8 Offset: 0x3698FC8 VA: 0x369CFC8
	public bool get_IsMatched() { }

	[CompilerGenerated]
	// RVA: 0x369CFD0 Offset: 0x3698FD0 VA: 0x369CFD0
	public void set_IsMatched(bool value) { }

	[CompilerGenerated]
	// RVA: 0x369CFDC Offset: 0x3698FDC VA: 0x369CFDC
	public RoomLobbySetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x369CFE4 Offset: 0x3698FE4 VA: 0x369CFE4
	public void set_Setting(RoomLobbySetting value) { }

	[CompilerGenerated]
	// RVA: 0x369CFEC Offset: 0x3698FEC VA: 0x369CFEC
	public RoomMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x369CFF4 Offset: 0x3698FF4 VA: 0x369CFF4
	public void set_Members(RoomMemberData[] value) { }

	// RVA: 0x369CFFC Offset: 0x3698FFC VA: 0x369CFFC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x369D004 Offset: 0x3699004 VA: 0x369D004 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x369D00C Offset: 0x369900C VA: 0x369D00C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x369D244 Offset: 0x3699244 VA: 0x369D244 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
