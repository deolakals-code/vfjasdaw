// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms
public class RoomStartEntry : PacketBase // TypeDefIndex: 11757
{
	// Fields
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <RoomType>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <RoomId>k__BackingField; // 0x25
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x30
	[CompilerGenerated]
	private EmergencyPositionData <EmergencyPositionData>k__BackingField; // 0x38
	[CompilerGenerated]
	private RoomGroupSetting <GroupSetting>k__BackingField; // 0x40
	[CompilerGenerated]
	private int[] <SupportItemList>k__BackingField; // 0x48
	[CompilerGenerated]
	private int[] <SupportOrbItemList>k__BackingField; // 0x50

	// Properties
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
	[PacketClass(Code = 188, IsOptional = True)]
	public RoomGroupSetting GroupSetting { get; set; }
	[PacketParameter(Code = 148, IsOptional = True)]
	public int[] SupportItemList { get; set; }
	[PacketParameter(Code = 207, IsOptional = True)]
	public int[] SupportOrbItemList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3742DEC Offset: 0x373EDEC VA: 0x3742DEC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3742DF4 Offset: 0x373EDF4 VA: 0x3742DF4
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x3742DFC Offset: 0x373EDFC VA: 0x3742DFC
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3742E04 Offset: 0x373EE04 VA: 0x3742E04
	public byte get_RoomType() { }

	[CompilerGenerated]
	// RVA: 0x3742E0C Offset: 0x373EE0C VA: 0x3742E0C
	public void set_RoomType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3742E14 Offset: 0x373EE14 VA: 0x3742E14
	public byte get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x3742E1C Offset: 0x373EE1C VA: 0x3742E1C
	public void set_RoomId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3742E24 Offset: 0x373EE24 VA: 0x3742E24
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x3742E2C Offset: 0x373EE2C VA: 0x3742E2C
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x3742E34 Offset: 0x373EE34 VA: 0x3742E34
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x3742E3C Offset: 0x373EE3C VA: 0x3742E3C
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x3742E44 Offset: 0x373EE44 VA: 0x3742E44
	public EmergencyPositionData get_EmergencyPositionData() { }

	[CompilerGenerated]
	// RVA: 0x3742E4C Offset: 0x373EE4C VA: 0x3742E4C
	public void set_EmergencyPositionData(EmergencyPositionData value) { }

	[CompilerGenerated]
	// RVA: 0x3742E54 Offset: 0x373EE54 VA: 0x3742E54
	public RoomGroupSetting get_GroupSetting() { }

	[CompilerGenerated]
	// RVA: 0x3742E5C Offset: 0x373EE5C VA: 0x3742E5C
	public void set_GroupSetting(RoomGroupSetting value) { }

	[CompilerGenerated]
	// RVA: 0x3742E64 Offset: 0x373EE64 VA: 0x3742E64
	public int[] get_SupportItemList() { }

	[CompilerGenerated]
	// RVA: 0x3742E6C Offset: 0x373EE6C VA: 0x3742E6C
	public void set_SupportItemList(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x3742E74 Offset: 0x373EE74 VA: 0x3742E74
	public int[] get_SupportOrbItemList() { }

	[CompilerGenerated]
	// RVA: 0x3742E7C Offset: 0x373EE7C VA: 0x3742E7C
	public void set_SupportOrbItemList(int[] value) { }

	// RVA: 0x3742E84 Offset: 0x373EE84 VA: 0x3742E84
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3743064 Offset: 0x373F064 VA: 0x3743064
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x374310C Offset: 0x373F10C VA: 0x374310C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3743114 Offset: 0x373F114 VA: 0x3743114 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x374351C Offset: 0x373F51C VA: 0x374351C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
