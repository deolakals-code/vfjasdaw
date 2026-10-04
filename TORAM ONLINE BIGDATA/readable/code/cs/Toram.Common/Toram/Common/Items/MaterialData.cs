// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Items
public class MaterialData : BinaryBase // TypeDefIndex: 12508
{
	// Fields
	[CompilerGenerated]
	private byte <MaterialId>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <MaterialLv>k__BackingField; // 0x1A
	[CompilerGenerated]
	private int <Point>k__BackingField; // 0x1C

	// Properties
	[BinaryParameter]
	public byte MaterialId { get; set; }
	[BinaryParameter]
	public byte MaterialLv { get; set; }
	[BinaryParameter]
	public int Point { get; set; }

	// Methods

	// RVA: 0x36150D8 Offset: 0x36110D8 VA: 0x36150D8
	public void .ctor() { }

	// RVA: 0x36150E0 Offset: 0x36110E0 VA: 0x36150E0
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x36150E8 Offset: 0x36110E8 VA: 0x36150E8
	public byte get_MaterialId() { }

	[CompilerGenerated]
	// RVA: 0x36150F0 Offset: 0x36110F0 VA: 0x36150F0
	public void set_MaterialId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36150F8 Offset: 0x36110F8 VA: 0x36150F8
	public byte get_MaterialLv() { }

	[CompilerGenerated]
	// RVA: 0x3615100 Offset: 0x3611100 VA: 0x3615100
	public void set_MaterialLv(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3615108 Offset: 0x3611108 VA: 0x3615108
	public int get_Point() { }

	[CompilerGenerated]
	// RVA: 0x3615110 Offset: 0x3611110 VA: 0x3615110
	public void set_Point(int value) { }

	// RVA: 0x3615118 Offset: 0x3611118 VA: 0x3615118 Slot: 3
	public override string ToString() { }

	// RVA: 0x36151F0 Offset: 0x36111F0 VA: 0x36151F0 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x3615310 Offset: 0x3611310 VA: 0x3615310 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
