// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.WaveRaid
public class CheckWaveRaidRoomResponse : OperationResponseBase // TypeDefIndex: 11788
{
	// Fields
	[CompilerGenerated]
	private RoomLobbySetting <Setting>k__BackingField; // 0x20
	[CompilerGenerated]
	private RoomMemberData[] <Members>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 29, IsOptional = True)]
	public RoomLobbySetting Setting { get; set; }
	[PacketParameter(Code = 5, IsOptional = True)]
	public RoomMemberData[] Members { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x374B7F4 Offset: 0x37477F4 VA: 0x374B7F4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x374B7FC Offset: 0x37477FC VA: 0x374B7FC
	public RoomLobbySetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x374B804 Offset: 0x3747804 VA: 0x374B804
	public void set_Setting(RoomLobbySetting value) { }

	[CompilerGenerated]
	// RVA: 0x374B80C Offset: 0x374780C VA: 0x374B80C
	public RoomMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x374B814 Offset: 0x3747814 VA: 0x374B814
	public void set_Members(RoomMemberData[] value) { }

	// RVA: 0x374B81C Offset: 0x374781C VA: 0x374B81C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374B824 Offset: 0x3747824 VA: 0x374B824 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x374B82C Offset: 0x374782C VA: 0x374B82C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x374BA60 Offset: 0x3747A60 VA: 0x374BA60 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
