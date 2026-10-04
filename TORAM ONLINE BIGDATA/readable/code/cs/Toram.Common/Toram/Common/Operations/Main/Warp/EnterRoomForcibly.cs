// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Warp
public class EnterRoomForcibly : PacketBase // TypeDefIndex: 11933
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <RoomType>k__BackingField; // 0x2C
	[CompilerGenerated]
	private byte <RoomId>k__BackingField; // 0x2D
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x38
	[CompilerGenerated]
	private EmergencyPositionData <EmergencyPositionData>k__BackingField; // 0x40
	[CompilerGenerated]
	private short <AreaLevel>k__BackingField; // 0x48

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 60)]
	public int FieldId { get; set; }
	[PacketParameter(Code = 105, IsOptional = True)]
	public byte RoomType { get; set; }
	[PacketParameter(Code = 106, IsOptional = True)]
	public byte RoomId { get; set; }
	[PacketParameter(Code = 54, IsOptional = True)]
	public short[] Position { get; set; }
	[PacketParameter(Code = 65, IsOptional = True)]
	public short Rotation { get; set; }
	[PacketClass(Code = 107, IsOptional = True)]
	public EmergencyPositionData EmergencyPositionData { get; set; }
	[PacketParameter(Code = 240, IsOptional = True)]
	public short AreaLevel { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3769060 Offset: 0x3765060 VA: 0x3769060
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3769068 Offset: 0x3765068 VA: 0x3769068
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3769070 Offset: 0x3765070 VA: 0x3769070
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3769078 Offset: 0x3765078 VA: 0x3769078
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3769080 Offset: 0x3765080 VA: 0x3769080
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3769088 Offset: 0x3765088 VA: 0x3769088
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x3769090 Offset: 0x3765090 VA: 0x3769090
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3769098 Offset: 0x3765098 VA: 0x3769098
	public byte get_RoomType() { }

	[CompilerGenerated]
	// RVA: 0x37690A0 Offset: 0x37650A0 VA: 0x37690A0
	public void set_RoomType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37690A8 Offset: 0x37650A8 VA: 0x37690A8
	public byte get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x37690B0 Offset: 0x37650B0 VA: 0x37690B0
	public void set_RoomId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37690B8 Offset: 0x37650B8 VA: 0x37690B8
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x37690C0 Offset: 0x37650C0 VA: 0x37690C0
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x37690C8 Offset: 0x37650C8 VA: 0x37690C8
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x37690D0 Offset: 0x37650D0 VA: 0x37690D0
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x37690D8 Offset: 0x37650D8 VA: 0x37690D8
	public EmergencyPositionData get_EmergencyPositionData() { }

	[CompilerGenerated]
	// RVA: 0x37690E0 Offset: 0x37650E0 VA: 0x37690E0
	public void set_EmergencyPositionData(EmergencyPositionData value) { }

	[CompilerGenerated]
	// RVA: 0x37690E8 Offset: 0x37650E8 VA: 0x37690E8
	public short get_AreaLevel() { }

	[CompilerGenerated]
	// RVA: 0x37690F0 Offset: 0x37650F0 VA: 0x37690F0
	public void set_AreaLevel(short value) { }

	// RVA: 0x37690F8 Offset: 0x37650F8 VA: 0x37690F8
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3769218 Offset: 0x3765218 VA: 0x3769218
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3769294 Offset: 0x3765294 VA: 0x3769294 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376929C Offset: 0x376529C VA: 0x376929C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x376969C Offset: 0x376569C VA: 0x376969C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
