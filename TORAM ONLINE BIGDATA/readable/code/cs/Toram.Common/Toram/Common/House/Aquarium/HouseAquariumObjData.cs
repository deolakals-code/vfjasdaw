// Assembly: Toram.Common.dll
// Namespace: Toram.Common.House.Aquarium
public class HouseAquariumObjData : BinaryBase // TypeDefIndex: 12600
{
	// Fields
	[CompilerGenerated]
	private int <ObjId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <Coodinate>k__BackingField; // 0x20

	// Properties
	public int ObjId { get; set; }
	public byte Coodinate { get; set; }
	public byte CoodinateX { get; }
	public byte CoodinateZ { get; }

	// Methods

	// RVA: 0x362DE94 Offset: 0x3629E94 VA: 0x362DE94
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x362DE9C Offset: 0x3629E9C VA: 0x362DE9C
	public int get_ObjId() { }

	[CompilerGenerated]
	// RVA: 0x362DEA4 Offset: 0x3629EA4 VA: 0x362DEA4
	public void set_ObjId(int value) { }

	[CompilerGenerated]
	// RVA: 0x362DEAC Offset: 0x3629EAC VA: 0x362DEAC
	public byte get_Coodinate() { }

	[CompilerGenerated]
	// RVA: 0x362DEB4 Offset: 0x3629EB4 VA: 0x362DEB4
	public void set_Coodinate(byte value) { }

	// RVA: 0x362DEBC Offset: 0x3629EBC VA: 0x362DEBC
	public byte get_CoodinateX() { }

	// RVA: 0x362DEC8 Offset: 0x3629EC8 VA: 0x362DEC8
	public byte get_CoodinateZ() { }

	// RVA: 0x362DED4 Offset: 0x3629ED4 VA: 0x362DED4 Slot: 3
	public override string ToString() { }

	// RVA: 0x362DFB4 Offset: 0x3629FB4 VA: 0x362DFB4 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x362DFF0 Offset: 0x3629FF0 VA: 0x362DFF0 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
