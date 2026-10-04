// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Npcs
public class NpcEquipData : BinaryBase // TypeDefIndex: 11154
{
	// Fields
	[CompilerGenerated]
	private byte <Weapon>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <SubWeapon>k__BackingField; // 0x1A
	[CompilerGenerated]
	private short[] <CapId>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <CapVal>k__BackingField; // 0x28

	// Properties
	[BinaryParameter]
	public byte Weapon { get; set; }
	[BinaryParameter]
	public byte SubWeapon { get; set; }
	[BinaryParameter]
	public short[] CapId { get; set; }
	[BinaryParameter]
	public short[] CapVal { get; set; }

	// Methods

	// RVA: 0x35CA990 Offset: 0x35C6990 VA: 0x35CA990
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x35CAE84 Offset: 0x35C6E84 VA: 0x35CAE84
	public byte get_Weapon() { }

	[CompilerGenerated]
	// RVA: 0x35CAE8C Offset: 0x35C6E8C VA: 0x35CAE8C
	protected void set_Weapon(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35CAE94 Offset: 0x35C6E94 VA: 0x35CAE94
	public byte get_SubWeapon() { }

	[CompilerGenerated]
	// RVA: 0x35CAE9C Offset: 0x35C6E9C VA: 0x35CAE9C
	protected void set_SubWeapon(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35CAEA4 Offset: 0x35C6EA4 VA: 0x35CAEA4
	public short[] get_CapId() { }

	[CompilerGenerated]
	// RVA: 0x35CAEAC Offset: 0x35C6EAC VA: 0x35CAEAC
	protected void set_CapId(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x35CAEB4 Offset: 0x35C6EB4 VA: 0x35CAEB4
	public short[] get_CapVal() { }

	[CompilerGenerated]
	// RVA: 0x35CAEBC Offset: 0x35C6EBC VA: 0x35CAEBC
	protected void set_CapVal(short[] value) { }

	// RVA: 0x35CAEC4 Offset: 0x35C6EC4 VA: 0x35CAEC4
	protected void Init() { }

	// RVA: 0x35CAF38 Offset: 0x35C6F38 VA: 0x35CAF38 Slot: 3
	public override string ToString() { }

	// RVA: 0x35CAFD8 Offset: 0x35C6FD8 VA: 0x35CAFD8 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35CB178 Offset: 0x35C7178 VA: 0x35CB178 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
