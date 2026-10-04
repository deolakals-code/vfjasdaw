// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Dungeon
public class CheckDungeonRoomResponse : PacketBase // TypeDefIndex: 11764
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <MaxMagicGauge>k__BackingField; // 0x26
	[CompilerGenerated]
	private short <GuildFloorDepth>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <PlayerFloorDepth>k__BackingField; // 0x2A
	[CompilerGenerated]
	private TimeSpan <RemainingTime>k__BackingField; // 0x30
	[CompilerGenerated]
	private RoomSetting <RoomSetting>k__BackingField; // 0x38
	[CompilerGenerated]
	private RoomGroupSetting <GroupSetting>k__BackingField; // 0x40
	[CompilerGenerated]
	private RoomGroupMemberStateData[] <Members>k__BackingField; // 0x48

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 205)]
	public short MaxMagicGauge { get; set; }
	[PacketParameter(Code = 240)]
	public short GuildFloorDepth { get; set; }
	[PacketParameter(Code = 29)]
	public short PlayerFloorDepth { get; set; }
	[PacketParameter(Code = 172)]
	public TimeSpan RemainingTime { get; set; }
	[PacketClass(Code = 187, IsOptional = True)]
	public RoomSetting RoomSetting { get; set; }
	[PacketClass(Code = 188, IsOptional = True)]
	public RoomGroupSetting GroupSetting { get; set; }
	[PacketClass(Code = 95, IsOptional = True)]
	public RoomGroupMemberStateData[] Members { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3745308 Offset: 0x3741308 VA: 0x3745308
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3745310 Offset: 0x3741310 VA: 0x3745310
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3745318 Offset: 0x3741318 VA: 0x3745318
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3745320 Offset: 0x3741320 VA: 0x3745320
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3745328 Offset: 0x3741328 VA: 0x3745328
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3745330 Offset: 0x3741330 VA: 0x3745330
	public short get_MaxMagicGauge() { }

	[CompilerGenerated]
	// RVA: 0x3745338 Offset: 0x3741338 VA: 0x3745338
	public void set_MaxMagicGauge(short value) { }

	[CompilerGenerated]
	// RVA: 0x3745340 Offset: 0x3741340 VA: 0x3745340
	public short get_GuildFloorDepth() { }

	[CompilerGenerated]
	// RVA: 0x3745348 Offset: 0x3741348 VA: 0x3745348
	public void set_GuildFloorDepth(short value) { }

	[CompilerGenerated]
	// RVA: 0x3745350 Offset: 0x3741350 VA: 0x3745350
	public short get_PlayerFloorDepth() { }

	[CompilerGenerated]
	// RVA: 0x3745358 Offset: 0x3741358 VA: 0x3745358
	public void set_PlayerFloorDepth(short value) { }

	[CompilerGenerated]
	// RVA: 0x3745360 Offset: 0x3741360 VA: 0x3745360
	public TimeSpan get_RemainingTime() { }

	[CompilerGenerated]
	// RVA: 0x3745368 Offset: 0x3741368 VA: 0x3745368
	public void set_RemainingTime(TimeSpan value) { }

	[CompilerGenerated]
	// RVA: 0x3745370 Offset: 0x3741370 VA: 0x3745370
	public RoomSetting get_RoomSetting() { }

	[CompilerGenerated]
	// RVA: 0x3745378 Offset: 0x3741378 VA: 0x3745378
	public void set_RoomSetting(RoomSetting value) { }

	[CompilerGenerated]
	// RVA: 0x3745380 Offset: 0x3741380 VA: 0x3745380
	public RoomGroupSetting get_GroupSetting() { }

	[CompilerGenerated]
	// RVA: 0x3745388 Offset: 0x3741388 VA: 0x3745388
	public void set_GroupSetting(RoomGroupSetting value) { }

	[CompilerGenerated]
	// RVA: 0x3745390 Offset: 0x3741390 VA: 0x3745390
	public RoomGroupMemberStateData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x3745398 Offset: 0x3741398 VA: 0x3745398
	public void set_Members(RoomGroupMemberStateData[] value) { }

	// RVA: 0x37453A0 Offset: 0x37413A0 VA: 0x37453A0
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3745608 Offset: 0x3741608 VA: 0x3745608
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37456EC Offset: 0x37416EC VA: 0x37456EC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37456F4 Offset: 0x37416F4 VA: 0x37456F4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37459EC Offset: 0x37419EC VA: 0x37459EC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
