// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses
public class HouseCoordinate : OperationRequestBase // TypeDefIndex: 12165
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Uid>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <ObjId>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <ParentUid>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <Position>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <Rotation>k__BackingField; // 0x34

	// Properties
	[PacketClass(Code = 245)]
	public byte Type { get; set; }
	[PacketClass(Code = 184)]
	public int Uid { get; set; }
	[PacketClass(Code = 91, IsOptional = True)]
	public int ObjId { get; set; }
	[PacketClass(Code = 19, IsOptional = True)]
	public int ParentUid { get; set; }
	[PacketClass(Code = 54, IsOptional = True)]
	public int Position { get; set; }
	[PacketClass(Code = 65, IsOptional = True)]
	public byte Rotation { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3793910 Offset: 0x378F910 VA: 0x3793910
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3793918 Offset: 0x378F918 VA: 0x3793918
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3793920 Offset: 0x378F920 VA: 0x3793920
	public void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3793928 Offset: 0x378F928 VA: 0x3793928
	public int get_Uid() { }

	[CompilerGenerated]
	// RVA: 0x3793930 Offset: 0x378F930 VA: 0x3793930
	public void set_Uid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3793938 Offset: 0x378F938 VA: 0x3793938
	public int get_ObjId() { }

	[CompilerGenerated]
	// RVA: 0x3793940 Offset: 0x378F940 VA: 0x3793940
	public void set_ObjId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3793948 Offset: 0x378F948 VA: 0x3793948
	public int get_ParentUid() { }

	[CompilerGenerated]
	// RVA: 0x3793950 Offset: 0x378F950 VA: 0x3793950
	public void set_ParentUid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3793958 Offset: 0x378F958 VA: 0x3793958
	public int get_Position() { }

	[CompilerGenerated]
	// RVA: 0x3793960 Offset: 0x378F960 VA: 0x3793960
	public void set_Position(int value) { }

	[CompilerGenerated]
	// RVA: 0x3793968 Offset: 0x378F968 VA: 0x3793968
	public byte get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x3793970 Offset: 0x378F970 VA: 0x3793970
	public void set_Rotation(byte value) { }

	// RVA: 0x3793978 Offset: 0x378F978 VA: 0x3793978 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3793980 Offset: 0x378F980 VA: 0x3793980 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3793988 Offset: 0x378F988 VA: 0x3793988 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3793C94 Offset: 0x378FC94 VA: 0x3793C94 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
