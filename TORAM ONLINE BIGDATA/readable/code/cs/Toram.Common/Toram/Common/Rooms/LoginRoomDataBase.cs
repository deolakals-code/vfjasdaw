// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms
public abstract class LoginRoomDataBase : UnityHashBase // TypeDefIndex: 11288
{
	// Fields
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <RoomId>k__BackingField; // 0x20

	// Properties
	[UnityHash(Code = 60)]
	public int FieldId { get; set; }
	[UnityHash(Code = 106)]
	public byte RoomId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36D7D74 Offset: 0x36D3D74 VA: 0x36D7D74
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36D7D7C Offset: 0x36D3D7C VA: 0x36D7D7C
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x36D7D84 Offset: 0x36D3D84 VA: 0x36D7D84
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36D7D8C Offset: 0x36D3D8C VA: 0x36D7D8C
	public byte get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x36D7D94 Offset: 0x36D3D94 VA: 0x36D7D94
	public void set_RoomId(byte value) { }

	// RVA: 0x36D7D9C Offset: 0x36D3D9C VA: 0x36D7D9C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36D7DA4 Offset: 0x36D3DA4 VA: 0x36D7DA4 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36D7F50 Offset: 0x36D3F50 VA: 0x36D7F50 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
