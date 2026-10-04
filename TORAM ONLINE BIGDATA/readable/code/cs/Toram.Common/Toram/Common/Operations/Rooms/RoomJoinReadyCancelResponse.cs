// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms
public class RoomJoinReadyCancelResponse : PacketBase // TypeDefIndex: 11751
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

	// RVA: 0x3741E40 Offset: 0x373DE40 VA: 0x3741E40
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3741E48 Offset: 0x373DE48 VA: 0x3741E48
	public RoomSetting get_RoomSetting() { }

	[CompilerGenerated]
	// RVA: 0x3741E50 Offset: 0x373DE50 VA: 0x3741E50
	public void set_RoomSetting(RoomSetting value) { }

	[CompilerGenerated]
	// RVA: 0x3741E58 Offset: 0x373DE58 VA: 0x3741E58
	public RoomGroupSetting get_GroupSetting() { }

	[CompilerGenerated]
	// RVA: 0x3741E60 Offset: 0x373DE60 VA: 0x3741E60
	public void set_GroupSetting(RoomGroupSetting value) { }

	[CompilerGenerated]
	// RVA: 0x3741E68 Offset: 0x373DE68 VA: 0x3741E68
	public RoomGroupMemberStateData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x3741E70 Offset: 0x373DE70 VA: 0x3741E70
	public void set_Members(RoomGroupMemberStateData[] value) { }

	// RVA: 0x3741E78 Offset: 0x373DE78 VA: 0x3741E78
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37420E0 Offset: 0x373E0E0 VA: 0x37420E0
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37421C4 Offset: 0x373E1C4 VA: 0x37421C4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37421CC Offset: 0x373E1CC VA: 0x37421CC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3742264 Offset: 0x373E264 VA: 0x3742264 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
