// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Warp
public class FieldWarpList : PacketBase // TypeDefIndex: 11934
{
	// Fields
	[CompilerGenerated]
	private short <WarpListId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <NextFieldId>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <NextLocationId>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <RoomType>k__BackingField; // 0x2A
	[CompilerGenerated]
	private byte <RoomId>k__BackingField; // 0x2B
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 10)]
	public short WarpListId { get; set; }
	[PacketParameter(Code = 11)]
	public int NextFieldId { get; set; }
	[PacketParameter(Code = 12)]
	public short NextLocationId { get; set; }
	[PacketParameter(Code = 13, IsOptional = True)]
	public byte RoomType { get; set; }
	[PacketParameter(Code = 14, IsOptional = True)]
	public byte RoomId { get; set; }
	[PacketParameter(Code = 15)]
	public short[] Position { get; set; }

	// Methods

	// RVA: 0x37698BC Offset: 0x37658BC VA: 0x37698BC
	public void .ctor() { }

	// RVA: 0x37698C4 Offset: 0x37658C4 VA: 0x37698C4 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x37698CC Offset: 0x37658CC VA: 0x37698CC
	public short get_WarpListId() { }

	[CompilerGenerated]
	// RVA: 0x37698D4 Offset: 0x37658D4 VA: 0x37698D4
	public void set_WarpListId(short value) { }

	[CompilerGenerated]
	// RVA: 0x37698DC Offset: 0x37658DC VA: 0x37698DC
	public int get_NextFieldId() { }

	[CompilerGenerated]
	// RVA: 0x37698E4 Offset: 0x37658E4 VA: 0x37698E4
	public void set_NextFieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x37698EC Offset: 0x37658EC VA: 0x37698EC
	public short get_NextLocationId() { }

	[CompilerGenerated]
	// RVA: 0x37698F4 Offset: 0x37658F4 VA: 0x37698F4
	public void set_NextLocationId(short value) { }

	[CompilerGenerated]
	// RVA: 0x37698FC Offset: 0x37658FC VA: 0x37698FC
	public byte get_RoomType() { }

	[CompilerGenerated]
	// RVA: 0x3769904 Offset: 0x3765904 VA: 0x3769904
	public void set_RoomType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x376990C Offset: 0x376590C VA: 0x376990C
	public byte get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x3769914 Offset: 0x3765914 VA: 0x3769914
	public void set_RoomId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x376991C Offset: 0x376591C VA: 0x376991C
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x3769924 Offset: 0x3765924 VA: 0x3769924
	public void set_Position(short[] value) { }

	// RVA: 0x376992C Offset: 0x376592C VA: 0x376992C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3769C54 Offset: 0x3765C54 VA: 0x3769C54 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
