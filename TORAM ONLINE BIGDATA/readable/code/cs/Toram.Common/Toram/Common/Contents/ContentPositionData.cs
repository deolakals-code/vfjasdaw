// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Contents
public class ContentPositionData : BinaryBase // TypeDefIndex: 11204
{
	// Fields
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <CameraRot>k__BackingField; // 0x2A

	// Properties
	public short[] Position { get; set; }
	public short Rotation { get; set; }
	public short CameraRot { get; set; }

	// Methods

	// RVA: 0x35D7EB0 Offset: 0x35D3EB0 VA: 0x35D7EB0
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x35D7EB8 Offset: 0x35D3EB8 VA: 0x35D7EB8
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x35D7EC0 Offset: 0x35D3EC0 VA: 0x35D7EC0
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x35D7EC8 Offset: 0x35D3EC8 VA: 0x35D7EC8
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x35D7ED0 Offset: 0x35D3ED0 VA: 0x35D7ED0
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x35D7ED8 Offset: 0x35D3ED8 VA: 0x35D7ED8
	public short get_CameraRot() { }

	[CompilerGenerated]
	// RVA: 0x35D7EE0 Offset: 0x35D3EE0 VA: 0x35D7EE0
	public void set_CameraRot(short value) { }

	// RVA: 0x35D7EE8 Offset: 0x35D3EE8 VA: 0x35D7EE8 Slot: 3
	public override string ToString() { }

	// RVA: 0x35D7FE4 Offset: 0x35D3FE4 VA: 0x35D7FE4 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35D8030 Offset: 0x35D4030 VA: 0x35D8030 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
