// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Warp
public class ChangeField : PacketBase // TypeDefIndex: 11930
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
	private short <CameraRot>k__BackingField; // 0x3A
	[CompilerGenerated]
	private EmergencyPositionData <EmergencyPositionData>k__BackingField; // 0x40

	// Properties
	public override byte Code { get; }
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
	[PacketParameter(Code = 135, IsOptional = True)]
	public short CameraRot { get; set; }
	[PacketClass(Code = 107, IsOptional = True)]
	public EmergencyPositionData EmergencyPositionData { get; set; }

	// Methods

	// RVA: 0x3767E44 Offset: 0x3763E44 VA: 0x3767E44
	public void .ctor() { }

	// RVA: 0x3767E4C Offset: 0x3763E4C VA: 0x3767E4C Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3767E54 Offset: 0x3763E54 VA: 0x3767E54
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3767E5C Offset: 0x3763E5C VA: 0x3767E5C
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3767E64 Offset: 0x3763E64 VA: 0x3767E64
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3767E6C Offset: 0x3763E6C VA: 0x3767E6C
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3767E74 Offset: 0x3763E74 VA: 0x3767E74
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x3767E7C Offset: 0x3763E7C VA: 0x3767E7C
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3767E84 Offset: 0x3763E84 VA: 0x3767E84
	public byte get_RoomType() { }

	[CompilerGenerated]
	// RVA: 0x3767E8C Offset: 0x3763E8C VA: 0x3767E8C
	public void set_RoomType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3767E94 Offset: 0x3763E94 VA: 0x3767E94
	public byte get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x3767E9C Offset: 0x3763E9C VA: 0x3767E9C
	public void set_RoomId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3767EA4 Offset: 0x3763EA4 VA: 0x3767EA4
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x3767EAC Offset: 0x3763EAC VA: 0x3767EAC
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x3767EB4 Offset: 0x3763EB4 VA: 0x3767EB4
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x3767EBC Offset: 0x3763EBC VA: 0x3767EBC
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x3767EC4 Offset: 0x3763EC4 VA: 0x3767EC4
	public short get_CameraRot() { }

	[CompilerGenerated]
	// RVA: 0x3767ECC Offset: 0x3763ECC VA: 0x3767ECC
	public void set_CameraRot(short value) { }

	[CompilerGenerated]
	// RVA: 0x3767ED4 Offset: 0x3763ED4 VA: 0x3767ED4
	public EmergencyPositionData get_EmergencyPositionData() { }

	[CompilerGenerated]
	// RVA: 0x3767EDC Offset: 0x3763EDC VA: 0x3767EDC
	public void set_EmergencyPositionData(EmergencyPositionData value) { }

	// RVA: 0x3767EE4 Offset: 0x3763EE4 VA: 0x3767EE4
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3768004 Offset: 0x3764004 VA: 0x3768004
	private void GetClass(Dictionary<byte, object> dictionary) { }

	// RVA: 0x3768080 Offset: 0x3764080 VA: 0x3768080 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3768478 Offset: 0x3764478 VA: 0x3768478 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
