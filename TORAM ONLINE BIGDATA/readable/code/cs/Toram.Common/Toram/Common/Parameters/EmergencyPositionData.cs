// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Parameters
public class EmergencyPositionData : UnityHashBase // TypeDefIndex: 11115
{
	// Fields
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <RoomType>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <RoomId>k__BackingField; // 0x21
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	[UnityHash(Code = 60, IsOptional = True)]
	public int FieldId { get; set; }
	public byte RoomType { get; set; }
	public byte RoomId { get; set; }
	public short[] Position { get; set; }

	// Methods

	// RVA: 0x35BE204 Offset: 0x35BA204 VA: 0x35BE204
	public void .ctor() { }

	// RVA: 0x35BE20C Offset: 0x35BA20C VA: 0x35BE20C
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x35BE214 Offset: 0x35BA214 VA: 0x35BE214 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x35BE21C Offset: 0x35BA21C VA: 0x35BE21C Slot: 7
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x35BE224 Offset: 0x35BA224 VA: 0x35BE224
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35BE22C Offset: 0x35BA22C VA: 0x35BE22C Slot: 8
	public byte get_RoomType() { }

	[CompilerGenerated]
	// RVA: 0x35BE234 Offset: 0x35BA234 VA: 0x35BE234
	public void set_RoomType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35BE23C Offset: 0x35BA23C VA: 0x35BE23C Slot: 9
	public byte get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x35BE244 Offset: 0x35BA244 VA: 0x35BE244
	public void set_RoomId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35BE24C Offset: 0x35BA24C VA: 0x35BE24C Slot: 10
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x35BE254 Offset: 0x35BA254 VA: 0x35BE254
	public void set_Position(short[] value) { }

	// RVA: 0x35BE25C Offset: 0x35BA25C VA: 0x35BE25C Slot: 3
	public override string ToString() { }

	// RVA: 0x35BE548 Offset: 0x35BA548 VA: 0x35BE548 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x35BE8C0 Offset: 0x35BA8C0 VA: 0x35BE8C0 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
