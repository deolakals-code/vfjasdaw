// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Warp
public class FieldWarpPoint : PacketBase // TypeDefIndex: 11935
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <RoomType>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <RoomId>k__BackingField; // 0x25
	[CompilerGenerated]
	private byte <PointId>k__BackingField; // 0x26
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private EmergencyPositionData <EmergencyPositionData>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 105, IsOptional = True)]
	public byte RoomType { get; set; }
	[PacketParameter(Code = 106, IsOptional = True)]
	public byte RoomId { get; set; }
	[PacketParameter(Code = 133, IsOptional = True)]
	public byte PointId { get; set; }
	[PacketParameter(Code = 54, IsOptional = True)]
	public short[] Position { get; set; }
	[PacketClass(Code = 107, IsOptional = True)]
	public EmergencyPositionData EmergencyPositionData { get; set; }

	// Methods

	// RVA: 0x3769E18 Offset: 0x3765E18 VA: 0x3769E18
	public void .ctor() { }

	// RVA: 0x3769E20 Offset: 0x3765E20 VA: 0x3769E20 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3769E28 Offset: 0x3765E28 VA: 0x3769E28
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3769E30 Offset: 0x3765E30 VA: 0x3769E30
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3769E38 Offset: 0x3765E38 VA: 0x3769E38
	public byte get_RoomType() { }

	[CompilerGenerated]
	// RVA: 0x3769E40 Offset: 0x3765E40 VA: 0x3769E40
	public void set_RoomType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3769E48 Offset: 0x3765E48 VA: 0x3769E48
	public byte get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x3769E50 Offset: 0x3765E50 VA: 0x3769E50
	public void set_RoomId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3769E58 Offset: 0x3765E58 VA: 0x3769E58
	public byte get_PointId() { }

	[CompilerGenerated]
	// RVA: 0x3769E60 Offset: 0x3765E60 VA: 0x3769E60
	public void set_PointId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3769E68 Offset: 0x3765E68 VA: 0x3769E68
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x3769E70 Offset: 0x3765E70 VA: 0x3769E70
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x3769E78 Offset: 0x3765E78 VA: 0x3769E78
	public EmergencyPositionData get_EmergencyPositionData() { }

	[CompilerGenerated]
	// RVA: 0x3769E80 Offset: 0x3765E80 VA: 0x3769E80
	public void set_EmergencyPositionData(EmergencyPositionData value) { }

	// RVA: 0x3769E88 Offset: 0x3765E88 VA: 0x3769E88
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3769FA8 Offset: 0x3765FA8 VA: 0x3769FA8
	private void GetClass(Dictionary<byte, object> dictionary) { }

	// RVA: 0x376A024 Offset: 0x3766024 VA: 0x376A024 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x376A324 Offset: 0x3766324 VA: 0x376A324 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
