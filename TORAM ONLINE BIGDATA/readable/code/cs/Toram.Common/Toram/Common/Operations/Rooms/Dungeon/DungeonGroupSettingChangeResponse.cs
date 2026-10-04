// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Dungeon
public class DungeonGroupSettingChangeResponse : PacketBase // TypeDefIndex: 11766
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private RoomSetting <RoomSetting>k__BackingField; // 0x28
	[CompilerGenerated]
	private RoomGroupSetting <GroupSetting>k__BackingField; // 0x30
	[CompilerGenerated]
	private RoomGroupMemberStateData[] <Members>k__BackingField; // 0x38

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 55, IsOptional = True)]
	public byte ArchetypeType { get; set; }
	[PacketClass(Code = 187, IsOptional = True)]
	public RoomSetting RoomSetting { get; set; }
	[PacketClass(Code = 188, IsOptional = True)]
	public RoomGroupSetting GroupSetting { get; set; }
	[PacketClass(Code = 95, IsOptional = True)]
	public RoomGroupMemberStateData[] Members { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3745F60 Offset: 0x3741F60 VA: 0x3745F60
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3745F68 Offset: 0x3741F68 VA: 0x3745F68
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3745F70 Offset: 0x3741F70 VA: 0x3745F70
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3745F78 Offset: 0x3741F78 VA: 0x3745F78
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3745F80 Offset: 0x3741F80 VA: 0x3745F80
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3745F88 Offset: 0x3741F88 VA: 0x3745F88
	public RoomSetting get_RoomSetting() { }

	[CompilerGenerated]
	// RVA: 0x3745F90 Offset: 0x3741F90 VA: 0x3745F90
	public void set_RoomSetting(RoomSetting value) { }

	[CompilerGenerated]
	// RVA: 0x3745F98 Offset: 0x3741F98 VA: 0x3745F98
	public RoomGroupSetting get_GroupSetting() { }

	[CompilerGenerated]
	// RVA: 0x3745FA0 Offset: 0x3741FA0 VA: 0x3745FA0
	public void set_GroupSetting(RoomGroupSetting value) { }

	[CompilerGenerated]
	// RVA: 0x3745FA8 Offset: 0x3741FA8 VA: 0x3745FA8
	public RoomGroupMemberStateData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x3745FB0 Offset: 0x3741FB0 VA: 0x3745FB0
	public void set_Members(RoomGroupMemberStateData[] value) { }

	// RVA: 0x3745FB8 Offset: 0x3741FB8 VA: 0x3745FB8
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3746220 Offset: 0x3742220 VA: 0x3746220
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3746304 Offset: 0x3742304 VA: 0x3746304 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374630C Offset: 0x374230C VA: 0x374630C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37464C0 Offset: 0x37424C0 VA: 0x37464C0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
