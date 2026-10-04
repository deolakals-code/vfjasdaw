// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms
public class LeaveRoom : PacketBase // TypeDefIndex: 11741
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
	public override byte Code { get; }

	// Methods

	// RVA: 0x373FA98 Offset: 0x373BA98 VA: 0x373FA98
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x373FAA0 Offset: 0x373BAA0 VA: 0x373FAA0
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x373FAA8 Offset: 0x373BAA8 VA: 0x373FAA8
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x373FAB0 Offset: 0x373BAB0 VA: 0x373FAB0
	public byte get_RoomType() { }

	[CompilerGenerated]
	// RVA: 0x373FAB8 Offset: 0x373BAB8 VA: 0x373FAB8
	public void set_RoomType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x373FAC0 Offset: 0x373BAC0 VA: 0x373FAC0
	public byte get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x373FAC8 Offset: 0x373BAC8 VA: 0x373FAC8
	public void set_RoomId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x373FAD0 Offset: 0x373BAD0 VA: 0x373FAD0
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x373FAD8 Offset: 0x373BAD8 VA: 0x373FAD8
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x373FAE0 Offset: 0x373BAE0 VA: 0x373FAE0
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x373FAE8 Offset: 0x373BAE8 VA: 0x373FAE8
	public void set_Rotation(short value) { }

	// RVA: 0x373FAF0 Offset: 0x373BAF0 VA: 0x373FAF0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x373FAF8 Offset: 0x373BAF8 VA: 0x373FAF8 Slot: 3
	public override string ToString() { }

	// RVA: 0x373FD18 Offset: 0x373BD18 VA: 0x373FD18 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x374001C Offset: 0x373C01C VA: 0x374001C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
