// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms.Defences
public class DefenceCrystalData : BinaryBase // TypeDefIndex: 11316
{
	// Fields
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x1C
	[CompilerGenerated]
	private short[] <Coordinate>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Hp>k__BackingField; // 0x28

	// Properties
	[BinaryParameter]
	public int Id { get; set; }
	[BinaryParameter]
	public short[] Coordinate { get; set; }
	[BinaryParameter]
	public short Hp { get; set; }

	// Methods

	// RVA: 0x36DEAC8 Offset: 0x36DAAC8 VA: 0x36DEAC8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36DEAD0 Offset: 0x36DAAD0 VA: 0x36DEAD0
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x36DEAD8 Offset: 0x36DAAD8 VA: 0x36DEAD8
	protected void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x36DEAE0 Offset: 0x36DAAE0 VA: 0x36DEAE0
	public short[] get_Coordinate() { }

	[CompilerGenerated]
	// RVA: 0x36DEAE8 Offset: 0x36DAAE8 VA: 0x36DEAE8
	protected void set_Coordinate(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36DEAF0 Offset: 0x36DAAF0 VA: 0x36DEAF0
	public short get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x36DEAF8 Offset: 0x36DAAF8 VA: 0x36DEAF8
	protected void set_Hp(short value) { }

	// RVA: 0x36DEB00 Offset: 0x36DAB00 VA: 0x36DEB00 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36DECB4 Offset: 0x36DACB4 VA: 0x36DECB4 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
