// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms.TreasureHunt
public class TreasureHuntMapPointData : BinaryBase // TypeDefIndex: 11331
{
	// Fields
	[CompilerGenerated]
	private byte <Id>k__BackingField; // 0x19
	[CompilerGenerated]
	private short[] <Coordinate>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Rot>k__BackingField; // 0x28

	// Properties
	public byte Id { get; set; }
	public short[] Coordinate { get; set; }
	public short Rot { get; set; }

	// Methods

	// RVA: 0x36EB99C Offset: 0x36E799C VA: 0x36EB99C
	public void .ctor() { }

	// RVA: 0x36EB9A4 Offset: 0x36E79A4 VA: 0x36EB9A4
	public void .ctor(MemoryStream ms) { }

	[CompilerGenerated]
	// RVA: 0x36EB9AC Offset: 0x36E79AC VA: 0x36EB9AC
	public byte get_Id() { }

	[CompilerGenerated]
	// RVA: 0x36EB9B4 Offset: 0x36E79B4 VA: 0x36EB9B4
	public void set_Id(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36EB9BC Offset: 0x36E79BC VA: 0x36EB9BC
	public short[] get_Coordinate() { }

	[CompilerGenerated]
	// RVA: 0x36EB9C4 Offset: 0x36E79C4 VA: 0x36EB9C4
	public void set_Coordinate(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36EB9CC Offset: 0x36E79CC VA: 0x36EB9CC
	public short get_Rot() { }

	[CompilerGenerated]
	// RVA: 0x36EB9D4 Offset: 0x36E79D4 VA: 0x36EB9D4
	public void set_Rot(short value) { }

	// RVA: 0x36EB9DC Offset: 0x36E79DC VA: 0x36EB9DC Slot: 3
	public override string ToString() { }

	// RVA: 0x36EBC50 Offset: 0x36E7C50 VA: 0x36EBC50 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36EBCFC Offset: 0x36E7CFC VA: 0x36EBCFC Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
