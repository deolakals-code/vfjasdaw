// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms
public class RoomStateResponse : PacketBase // TypeDefIndex: 11759
{
	// Fields
	[CompilerGenerated]
	private RoomSetting <RoomSetting>k__BackingField; // 0x20
	[CompilerGenerated]
	private RoomGroupSetting <GroupSetting>k__BackingField; // 0x28
	[CompilerGenerated]
	private RoomGroupMemberStateData[] <Members>k__BackingField; // 0x30

	// Properties
	[PacketClass(Code = 187, IsOptional = True)]
	public RoomSetting RoomSetting { get; set; }
	[PacketClass(Code = 188, IsOptional = True)]
	public RoomGroupSetting GroupSetting { get; set; }
	[PacketClass(Code = 95, IsOptional = True)]
	public RoomGroupMemberStateData[] Members { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37439A8 Offset: 0x373F9A8 VA: 0x37439A8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37439B0 Offset: 0x373F9B0 VA: 0x37439B0
	public RoomSetting get_RoomSetting() { }

	[CompilerGenerated]
	// RVA: 0x37439B8 Offset: 0x373F9B8 VA: 0x37439B8
	public void set_RoomSetting(RoomSetting value) { }

	[CompilerGenerated]
	// RVA: 0x37439C0 Offset: 0x373F9C0 VA: 0x37439C0
	public RoomGroupSetting get_GroupSetting() { }

	[CompilerGenerated]
	// RVA: 0x37439C8 Offset: 0x373F9C8 VA: 0x37439C8
	public void set_GroupSetting(RoomGroupSetting value) { }

	[CompilerGenerated]
	// RVA: 0x37439D0 Offset: 0x373F9D0 VA: 0x37439D0
	public RoomGroupMemberStateData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x37439D8 Offset: 0x373F9D8 VA: 0x37439D8
	public void set_Members(RoomGroupMemberStateData[] value) { }

	// RVA: 0x37439E0 Offset: 0x373F9E0 VA: 0x37439E0
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3743C48 Offset: 0x373FC48 VA: 0x3743C48
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3743D2C Offset: 0x373FD2C VA: 0x3743D2C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3743D34 Offset: 0x373FD34 VA: 0x3743D34 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3743DCC Offset: 0x373FDCC VA: 0x3743DCC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
