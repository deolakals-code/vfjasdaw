// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses
public class HouseCoordinateResponse : OperationResponseBase // TypeDefIndex: 12168
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

	// RVA: 0x3794198 Offset: 0x3790198 VA: 0x3794198
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37941A0 Offset: 0x37901A0 VA: 0x37941A0
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x37941A8 Offset: 0x37901A8 VA: 0x37941A8
	public void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37941B0 Offset: 0x37901B0 VA: 0x37941B0
	public int get_Uid() { }

	[CompilerGenerated]
	// RVA: 0x37941B8 Offset: 0x37901B8 VA: 0x37941B8
	public void set_Uid(int value) { }

	[CompilerGenerated]
	// RVA: 0x37941C0 Offset: 0x37901C0 VA: 0x37941C0
	public int get_ObjId() { }

	[CompilerGenerated]
	// RVA: 0x37941C8 Offset: 0x37901C8 VA: 0x37941C8
	public void set_ObjId(int value) { }

	[CompilerGenerated]
	// RVA: 0x37941D0 Offset: 0x37901D0 VA: 0x37941D0
	public int get_ParentUid() { }

	[CompilerGenerated]
	// RVA: 0x37941D8 Offset: 0x37901D8 VA: 0x37941D8
	public void set_ParentUid(int value) { }

	[CompilerGenerated]
	// RVA: 0x37941E0 Offset: 0x37901E0 VA: 0x37941E0
	public int get_Position() { }

	[CompilerGenerated]
	// RVA: 0x37941E8 Offset: 0x37901E8 VA: 0x37941E8
	public void set_Position(int value) { }

	[CompilerGenerated]
	// RVA: 0x37941F0 Offset: 0x37901F0 VA: 0x37941F0
	public byte get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x37941F8 Offset: 0x37901F8 VA: 0x37941F8
	public void set_Rotation(byte value) { }

	// RVA: 0x3794200 Offset: 0x3790200 VA: 0x3794200 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3794208 Offset: 0x3790208 VA: 0x3794208 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3794210 Offset: 0x3790210 VA: 0x3794210 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x379451C Offset: 0x379051C VA: 0x379451C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
