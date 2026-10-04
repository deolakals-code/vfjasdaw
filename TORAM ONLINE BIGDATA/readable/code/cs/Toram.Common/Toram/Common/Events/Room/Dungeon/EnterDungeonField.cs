// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Dungeon
public class EnterDungeonField : PacketBase // TypeDefIndex: 12757
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <Rate>k__BackingField; // 0x25
	[CompilerGenerated]
	private short <AvatarLevel>k__BackingField; // 0x26
	[CompilerGenerated]
	private int <RandamSeed>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <Day>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <FloorDepth>k__BackingField; // 0x30
	[CompilerGenerated]
	private Dictionary<byte, byte> <TrapList>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte[] <ItemBoxList>k__BackingField; // 0x40
	[CompilerGenerated]
	private MobResponseData[] <MobList>k__BackingField; // 0x48
	[CompilerGenerated]
	private byte[] <RoomChipIdList>k__BackingField; // 0x50
	[CompilerGenerated]
	private byte <FloorEventType>k__BackingField; // 0x58

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 43, IsOptional = True)]
	public byte Flag { get; set; }
	[PacketParameter(Code = 47)]
	public byte Rate { get; set; }
	[PacketParameter(Code = 29)]
	public short AvatarLevel { get; set; }
	[PacketParameter(Code = 233)]
	public int RandamSeed { get; set; }
	[PacketParameter(Code = 239)]
	public byte Day { get; set; }
	[PacketParameter(Code = 240)]
	public int FloorDepth { get; set; }
	[PacketParameter(Code = 235, IsOptional = True)]
	public Dictionary<byte, byte> TrapList { get; set; }
	[PacketParameter(Code = 237, IsOptional = True)]
	public byte[] ItemBoxList { get; set; }
	[PacketClass(Code = 89, IsOptional = True)]
	public MobResponseData[] MobList { get; set; }
	[PacketParameter(Code = 241, IsOptional = True)]
	public byte[] RoomChipIdList { get; set; }
	[PacketParameter(Code = 44)]
	public byte FloorEventType { get; set; }

	// Methods

	// RVA: 0x3652090 Offset: 0x364E090 VA: 0x3652090
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3652098 Offset: 0x364E098 VA: 0x3652098 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x36520A0 Offset: 0x364E0A0 VA: 0x36520A0
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x36520A8 Offset: 0x364E0A8 VA: 0x36520A8
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36520B0 Offset: 0x364E0B0 VA: 0x36520B0
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x36520B8 Offset: 0x364E0B8 VA: 0x36520B8
	public void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36520C0 Offset: 0x364E0C0 VA: 0x36520C0
	public byte get_Rate() { }

	[CompilerGenerated]
	// RVA: 0x36520C8 Offset: 0x364E0C8 VA: 0x36520C8
	public void set_Rate(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36520D0 Offset: 0x364E0D0 VA: 0x36520D0
	public short get_AvatarLevel() { }

	[CompilerGenerated]
	// RVA: 0x36520D8 Offset: 0x364E0D8 VA: 0x36520D8
	public void set_AvatarLevel(short value) { }

	[CompilerGenerated]
	// RVA: 0x36520E0 Offset: 0x364E0E0 VA: 0x36520E0
	public int get_RandamSeed() { }

	[CompilerGenerated]
	// RVA: 0x36520E8 Offset: 0x364E0E8 VA: 0x36520E8
	public void set_RandamSeed(int value) { }

	[CompilerGenerated]
	// RVA: 0x36520F0 Offset: 0x364E0F0 VA: 0x36520F0
	public byte get_Day() { }

	[CompilerGenerated]
	// RVA: 0x36520F8 Offset: 0x364E0F8 VA: 0x36520F8
	public void set_Day(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3652100 Offset: 0x364E100 VA: 0x3652100
	public int get_FloorDepth() { }

	[CompilerGenerated]
	// RVA: 0x3652108 Offset: 0x364E108 VA: 0x3652108
	public void set_FloorDepth(int value) { }

	[CompilerGenerated]
	// RVA: 0x3652110 Offset: 0x364E110 VA: 0x3652110
	public Dictionary<byte, byte> get_TrapList() { }

	[CompilerGenerated]
	// RVA: 0x3652118 Offset: 0x364E118 VA: 0x3652118
	public void set_TrapList(Dictionary<byte, byte> value) { }

	[CompilerGenerated]
	// RVA: 0x3652120 Offset: 0x364E120 VA: 0x3652120
	public byte[] get_ItemBoxList() { }

	[CompilerGenerated]
	// RVA: 0x3652128 Offset: 0x364E128 VA: 0x3652128
	public void set_ItemBoxList(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x3652130 Offset: 0x364E130 VA: 0x3652130
	public MobResponseData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x3652138 Offset: 0x364E138 VA: 0x3652138
	public void set_MobList(MobResponseData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3652140 Offset: 0x364E140 VA: 0x3652140
	public byte[] get_RoomChipIdList() { }

	[CompilerGenerated]
	// RVA: 0x3652148 Offset: 0x364E148 VA: 0x3652148
	public void set_RoomChipIdList(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x3652150 Offset: 0x364E150 VA: 0x3652150
	public byte get_FloorEventType() { }

	[CompilerGenerated]
	// RVA: 0x3652158 Offset: 0x364E158 VA: 0x3652158
	public void set_FloorEventType(byte value) { }

	// RVA: 0x3652160 Offset: 0x364E160 VA: 0x3652160 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36526DC Offset: 0x364E6DC VA: 0x36526DC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
