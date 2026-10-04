// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Warp
public class EmergencyChangeField : PacketBase // TypeDefIndex: 11932
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
	[PacketClass(Code = 107, IsOptional = True)]
	public EmergencyPositionData EmergencyPositionData { get; set; }

	// Methods

	// RVA: 0x37688AC Offset: 0x37648AC VA: 0x37688AC
	public void .ctor() { }

	// RVA: 0x37688B4 Offset: 0x37648B4 VA: 0x37688B4 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x37688BC Offset: 0x37648BC VA: 0x37688BC
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x37688C4 Offset: 0x37648C4 VA: 0x37688C4
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x37688CC Offset: 0x37648CC VA: 0x37688CC
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x37688D4 Offset: 0x37648D4 VA: 0x37688D4
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37688DC Offset: 0x37648DC VA: 0x37688DC
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x37688E4 Offset: 0x37648E4 VA: 0x37688E4
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x37688EC Offset: 0x37648EC VA: 0x37688EC
	public byte get_RoomType() { }

	[CompilerGenerated]
	// RVA: 0x37688F4 Offset: 0x37648F4 VA: 0x37688F4
	public void set_RoomType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37688FC Offset: 0x37648FC VA: 0x37688FC
	public byte get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x3768904 Offset: 0x3764904 VA: 0x3768904
	public void set_RoomId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x376890C Offset: 0x376490C VA: 0x376890C
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x3768914 Offset: 0x3764914 VA: 0x3768914
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x376891C Offset: 0x376491C VA: 0x376891C
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x3768924 Offset: 0x3764924 VA: 0x3768924
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x376892C Offset: 0x376492C VA: 0x376892C
	public EmergencyPositionData get_EmergencyPositionData() { }

	[CompilerGenerated]
	// RVA: 0x3768934 Offset: 0x3764934 VA: 0x3768934
	public void set_EmergencyPositionData(EmergencyPositionData value) { }

	// RVA: 0x376893C Offset: 0x376493C VA: 0x376893C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3768A5C Offset: 0x3764A5C VA: 0x3768A5C
	private void GetClass(Dictionary<byte, object> dictionary) { }

	// RVA: 0x3768AD8 Offset: 0x3764AD8 VA: 0x3768AD8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3768E6C Offset: 0x3764E6C VA: 0x3768E6C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
