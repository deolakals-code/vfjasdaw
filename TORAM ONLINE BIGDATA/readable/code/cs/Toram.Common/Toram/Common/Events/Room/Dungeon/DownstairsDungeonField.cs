// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Dungeon
public class DownstairsDungeonField : PacketBase // TypeDefIndex: 12754
{
	// Fields
	[CompilerGenerated]
	private int <RandamSeed>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <FloorDepth>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <Day>k__BackingField; // 0x26
	[CompilerGenerated]
	private Dictionary<byte, byte> <TrapList>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte[] <ItemBoxList>k__BackingField; // 0x30
	[CompilerGenerated]
	private MobResponseData[] <MobList>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte[] <RoomChipIdList>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte <FloorEventType>k__BackingField; // 0x48

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 233)]
	public int RandamSeed { get; set; }
	[PacketParameter(Code = 240)]
	public short FloorDepth { get; set; }
	[PacketParameter(Code = 239)]
	public byte Day { get; set; }
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

	// RVA: 0x36513C8 Offset: 0x364D3C8 VA: 0x36513C8
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x36513D0 Offset: 0x364D3D0 VA: 0x36513D0 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x36513D8 Offset: 0x364D3D8 VA: 0x36513D8
	public int get_RandamSeed() { }

	[CompilerGenerated]
	// RVA: 0x36513E0 Offset: 0x364D3E0 VA: 0x36513E0
	public void set_RandamSeed(int value) { }

	[CompilerGenerated]
	// RVA: 0x36513E8 Offset: 0x364D3E8 VA: 0x36513E8
	public short get_FloorDepth() { }

	[CompilerGenerated]
	// RVA: 0x36513F0 Offset: 0x364D3F0 VA: 0x36513F0
	public void set_FloorDepth(short value) { }

	[CompilerGenerated]
	// RVA: 0x36513F8 Offset: 0x364D3F8 VA: 0x36513F8
	public byte get_Day() { }

	[CompilerGenerated]
	// RVA: 0x3651400 Offset: 0x364D400 VA: 0x3651400
	public void set_Day(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3651408 Offset: 0x364D408 VA: 0x3651408
	public Dictionary<byte, byte> get_TrapList() { }

	[CompilerGenerated]
	// RVA: 0x3651410 Offset: 0x364D410 VA: 0x3651410
	public void set_TrapList(Dictionary<byte, byte> value) { }

	[CompilerGenerated]
	// RVA: 0x3651418 Offset: 0x364D418 VA: 0x3651418
	public byte[] get_ItemBoxList() { }

	[CompilerGenerated]
	// RVA: 0x3651420 Offset: 0x364D420 VA: 0x3651420
	public void set_ItemBoxList(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x3651428 Offset: 0x364D428 VA: 0x3651428
	public MobResponseData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x3651430 Offset: 0x364D430 VA: 0x3651430
	public void set_MobList(MobResponseData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3651438 Offset: 0x364D438 VA: 0x3651438
	public byte[] get_RoomChipIdList() { }

	[CompilerGenerated]
	// RVA: 0x3651440 Offset: 0x364D440 VA: 0x3651440
	public void set_RoomChipIdList(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x3651448 Offset: 0x364D448 VA: 0x3651448
	public byte get_FloorEventType() { }

	[CompilerGenerated]
	// RVA: 0x3651450 Offset: 0x364D450 VA: 0x3651450
	public void set_FloorEventType(byte value) { }

	// RVA: 0x3651458 Offset: 0x364D458 VA: 0x3651458 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36518AC Offset: 0x364D8AC VA: 0x36518AC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
