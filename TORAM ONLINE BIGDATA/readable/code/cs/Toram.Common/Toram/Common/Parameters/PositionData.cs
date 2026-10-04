// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Parameters
public class PositionData : UnityHashBase // TypeDefIndex: 11125
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
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <CameraRot>k__BackingField; // 0x32

	// Properties
	[UnityHash(Code = 60, IsOptional = True)]
	public int FieldId { get; set; }
	[UnityHash(Code = 105, IsOptional = True)]
	public byte RoomType { get; set; }
	[UnityHash(Code = 106, IsOptional = True)]
	public byte RoomId { get; set; }
	[UnityHash(Code = 54, IsOptional = True)]
	public short[] Position { get; set; }
	[UnityHash(Code = 65, IsOptional = True)]
	public short Rotation { get; set; }
	[UnityHash(Code = 135, IsOptional = True)]
	public short CameraRot { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35C1370 Offset: 0x35BD370 VA: 0x35C1370
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35C1378 Offset: 0x35BD378 VA: 0x35C1378 Slot: 7
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x35C1380 Offset: 0x35BD380 VA: 0x35C1380
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35C1388 Offset: 0x35BD388 VA: 0x35C1388 Slot: 8
	public byte get_RoomType() { }

	[CompilerGenerated]
	// RVA: 0x35C1390 Offset: 0x35BD390 VA: 0x35C1390
	public void set_RoomType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35C1398 Offset: 0x35BD398 VA: 0x35C1398 Slot: 9
	public byte get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x35C13A0 Offset: 0x35BD3A0 VA: 0x35C13A0
	public void set_RoomId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35C13A8 Offset: 0x35BD3A8 VA: 0x35C13A8 Slot: 10
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x35C13B0 Offset: 0x35BD3B0 VA: 0x35C13B0
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x35C13B8 Offset: 0x35BD3B8 VA: 0x35C13B8
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x35C13C0 Offset: 0x35BD3C0 VA: 0x35C13C0
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x35C13C8 Offset: 0x35BD3C8 VA: 0x35C13C8
	public short get_CameraRot() { }

	[CompilerGenerated]
	// RVA: 0x35C13D0 Offset: 0x35BD3D0 VA: 0x35C13D0
	public void set_CameraRot(short value) { }

	// RVA: 0x35C13D8 Offset: 0x35BD3D8 VA: 0x35C13D8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35C13E0 Offset: 0x35BD3E0 VA: 0x35C13E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x35C1748 Offset: 0x35BD748 VA: 0x35C1748 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x35C1C0C Offset: 0x35BDC0C VA: 0x35C1C0C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
