// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms.Defences
public class DefenceMapChip : BinaryBase // TypeDefIndex: 11319
{
	// Fields
	[CompilerGenerated]
	private int <X>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <Y>k__BackingField; // 0x20
	[CompilerGenerated]
	private DefenceMapKind <MapKind>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <Gate>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <RoomId>k__BackingField; // 0x2C
	[CompilerGenerated]
	private byte <RoomFlag>k__BackingField; // 0x30
	[CompilerGenerated]
	private Dictionary<DefencePoint2, byte> <Guide>k__BackingField; // 0x38
	[CompilerGenerated]
	private Dictionary<DefencePoint2, byte> <Distance>k__BackingField; // 0x40

	// Properties
	[BinaryParameter]
	public int X { get; set; }
	[BinaryParameter]
	public int Y { get; set; }
	[BinaryParameter]
	public DefenceMapKind MapKind { get; set; }
	[BinaryParameter]
	public byte Gate { get; set; }
	[BinaryParameter]
	public int RoomId { get; set; }
	[BinaryParameter]
	public byte RoomFlag { get; set; }
	[BinaryParameter]
	public Dictionary<DefencePoint2, byte> Guide { get; set; }
	[BinaryParameter]
	public Dictionary<DefencePoint2, byte> Distance { get; set; }

	// Methods

	// RVA: 0x36DF0CC Offset: 0x36DB0CC VA: 0x36DF0CC
	public void .ctor() { }

	// RVA: 0x36DF178 Offset: 0x36DB178 VA: 0x36DF178
	public void .ctor(MemoryStream ms) { }

	[CompilerGenerated]
	// RVA: 0x36DF180 Offset: 0x36DB180 VA: 0x36DF180
	public int get_X() { }

	[CompilerGenerated]
	// RVA: 0x36DF188 Offset: 0x36DB188 VA: 0x36DF188
	public void set_X(int value) { }

	[CompilerGenerated]
	// RVA: 0x36DF190 Offset: 0x36DB190 VA: 0x36DF190
	public int get_Y() { }

	[CompilerGenerated]
	// RVA: 0x36DF198 Offset: 0x36DB198 VA: 0x36DF198
	public void set_Y(int value) { }

	[CompilerGenerated]
	// RVA: 0x36DF1A0 Offset: 0x36DB1A0 VA: 0x36DF1A0
	public DefenceMapKind get_MapKind() { }

	[CompilerGenerated]
	// RVA: 0x36DF1A8 Offset: 0x36DB1A8 VA: 0x36DF1A8
	public void set_MapKind(DefenceMapKind value) { }

	[CompilerGenerated]
	// RVA: 0x36DF1B0 Offset: 0x36DB1B0 VA: 0x36DF1B0
	public byte get_Gate() { }

	[CompilerGenerated]
	// RVA: 0x36DF1B8 Offset: 0x36DB1B8 VA: 0x36DF1B8
	public void set_Gate(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36DF1C0 Offset: 0x36DB1C0 VA: 0x36DF1C0
	public int get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x36DF1C8 Offset: 0x36DB1C8 VA: 0x36DF1C8
	public void set_RoomId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36DF1D0 Offset: 0x36DB1D0 VA: 0x36DF1D0
	public byte get_RoomFlag() { }

	[CompilerGenerated]
	// RVA: 0x36DF1D8 Offset: 0x36DB1D8 VA: 0x36DF1D8
	public void set_RoomFlag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36DF1E0 Offset: 0x36DB1E0 VA: 0x36DF1E0
	public Dictionary<DefencePoint2, byte> get_Guide() { }

	[CompilerGenerated]
	// RVA: 0x36DF1E8 Offset: 0x36DB1E8 VA: 0x36DF1E8
	public void set_Guide(Dictionary<DefencePoint2, byte> value) { }

	[CompilerGenerated]
	// RVA: 0x36DF1F0 Offset: 0x36DB1F0 VA: 0x36DF1F0
	public Dictionary<DefencePoint2, byte> get_Distance() { }

	[CompilerGenerated]
	// RVA: 0x36DF1F8 Offset: 0x36DB1F8 VA: 0x36DF1F8
	public void set_Distance(Dictionary<DefencePoint2, byte> value) { }

	// RVA: 0x36DF200 Offset: 0x36DB200 VA: 0x36DF200 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36DF5BC Offset: 0x36DB5BC VA: 0x36DF5BC Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
