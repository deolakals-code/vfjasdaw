// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms.Wave
public class WaveTargetData : BinaryBase // TypeDefIndex: 11303
{
	// Fields
	[CompilerGenerated]
	private int <ModelId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private short <MapDataId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <HP>k__BackingField; // 0x24
	[CompilerGenerated]
	private short[] <Coordinate>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x30

	// Properties
	[BinaryParameter]
	public int ModelId { get; set; }
	[BinaryParameter]
	public short MapDataId { get; set; }
	[BinaryParameter]
	public int HP { get; set; }
	[BinaryParameter]
	public short[] Coordinate { get; set; }
	[BinaryParameter]
	public byte Flag { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x36DB960 Offset: 0x36D7960 VA: 0x36DB960
	public int get_ModelId() { }

	[CompilerGenerated]
	// RVA: 0x36DB968 Offset: 0x36D7968 VA: 0x36DB968
	public void set_ModelId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36DB970 Offset: 0x36D7970 VA: 0x36DB970
	public short get_MapDataId() { }

	[CompilerGenerated]
	// RVA: 0x36DB978 Offset: 0x36D7978 VA: 0x36DB978
	public void set_MapDataId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36DB980 Offset: 0x36D7980 VA: 0x36DB980
	public int get_HP() { }

	[CompilerGenerated]
	// RVA: 0x36DB988 Offset: 0x36D7988 VA: 0x36DB988
	public void set_HP(int value) { }

	[CompilerGenerated]
	// RVA: 0x36DB990 Offset: 0x36D7990 VA: 0x36DB990
	public short[] get_Coordinate() { }

	[CompilerGenerated]
	// RVA: 0x36DB998 Offset: 0x36D7998 VA: 0x36DB998
	public void set_Coordinate(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36DB9A0 Offset: 0x36D79A0 VA: 0x36DB9A0
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x36DB9A8 Offset: 0x36D79A8 VA: 0x36DB9A8
	public void set_Flag(byte value) { }

	// RVA: 0x36DB9B0 Offset: 0x36D79B0 VA: 0x36DB9B0
	public void .ctor() { }

	// RVA: 0x36DB9B8 Offset: 0x36D79B8 VA: 0x36DB9B8
	public void .ctor(byte[] binary) { }

	// RVA: 0x36DB9C0 Offset: 0x36D79C0 VA: 0x36DB9C0
	public void .ctor(MemoryStream ms) { }

	// RVA: 0x36DB9C8 Offset: 0x36D79C8 VA: 0x36DB9C8 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36DBBD4 Offset: 0x36D7BD4 VA: 0x36DBBD4 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
