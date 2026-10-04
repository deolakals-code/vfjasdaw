// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.GameEvents
public class GameEventChangeField : OperationRequestBase // TypeDefIndex: 11619
{
	// Fields
	[CompilerGenerated]
	private byte <EventType>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <CameraRot>k__BackingField; // 0x32
	[CompilerGenerated]
	private Dictionary<byte, object> <Parameters>k__BackingField; // 0x38

	// Properties
	public byte EventType { get; set; }
	public short[] Position { get; set; }
	public short Rotation { get; set; }
	public short CameraRot { get; set; }
	public Dictionary<byte, object> Parameters { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372664C Offset: 0x372264C VA: 0x372664C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3726654 Offset: 0x3722654 VA: 0x3726654
	public byte get_EventType() { }

	[CompilerGenerated]
	// RVA: 0x372665C Offset: 0x372265C VA: 0x372665C
	public void set_EventType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3726664 Offset: 0x3722664 VA: 0x3726664
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x372666C Offset: 0x372266C VA: 0x372666C
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x3726674 Offset: 0x3722674 VA: 0x3726674
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x372667C Offset: 0x372267C VA: 0x372667C
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x3726684 Offset: 0x3722684 VA: 0x3726684
	public short get_CameraRot() { }

	[CompilerGenerated]
	// RVA: 0x372668C Offset: 0x372268C VA: 0x372668C
	public void set_CameraRot(short value) { }

	[CompilerGenerated]
	// RVA: 0x3726694 Offset: 0x3722694 VA: 0x3726694
	public Dictionary<byte, object> get_Parameters() { }

	[CompilerGenerated]
	// RVA: 0x372669C Offset: 0x372269C VA: 0x372669C
	public void set_Parameters(Dictionary<byte, object> value) { }

	// RVA: 0x37266A4 Offset: 0x37226A4 VA: 0x37266A4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37266AC Offset: 0x37226AC VA: 0x37266AC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37266B4 Offset: 0x37226B4 VA: 0x37266B4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37269D4 Offset: 0x37229D4 VA: 0x37269D4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
