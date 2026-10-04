// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FurnitureCoordinateData // TypeDefIndex: 1964
{
	// Fields
	public readonly int Uid; // 0x10
	[CompilerGenerated]
	private int <ObjId>k__BackingField; // 0x14
	[CompilerGenerated]
	private int <ParentUid>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <ChipPosition>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <Rotation>k__BackingField; // 0x20

	// Properties
	public int ObjId { get; set; }
	public int ParentUid { get; set; }
	public int ChipPosition { get; set; }
	public byte Rotation { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2114014 Offset: 0x2110014 VA: 0x2114014
	public int get_ObjId() { }

	[CompilerGenerated]
	// RVA: 0x211401C Offset: 0x211001C VA: 0x211401C
	private void set_ObjId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2114024 Offset: 0x2110024 VA: 0x2114024
	public int get_ParentUid() { }

	[CompilerGenerated]
	// RVA: 0x211402C Offset: 0x211002C VA: 0x211402C
	private void set_ParentUid(int value) { }

	[CompilerGenerated]
	// RVA: 0x2114034 Offset: 0x2110034 VA: 0x2114034
	public int get_ChipPosition() { }

	[CompilerGenerated]
	// RVA: 0x211403C Offset: 0x211003C VA: 0x211403C
	private void set_ChipPosition(int value) { }

	[CompilerGenerated]
	// RVA: 0x2114044 Offset: 0x2110044 VA: 0x2114044
	public byte get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x211404C Offset: 0x211004C VA: 0x211404C
	private void set_Rotation(byte value) { }

	// RVA: 0x2114054 Offset: 0x2110054 VA: 0x2114054
	public void .ctor(int uid, int objId) { }

	// RVA: 0x2114080 Offset: 0x2110080 VA: 0x2114080
	public void UpdateData(int parentUid, int chipPosition, byte rotation) { }

	// RVA: 0x211408C Offset: 0x211008C VA: 0x211408C
	public void UpdateObjId(int objId) { }

	// RVA: 0x2114094 Offset: 0x2110094 VA: 0x2114094
	internal bool IsHouseObjType(HouseObjType type) { }
}
