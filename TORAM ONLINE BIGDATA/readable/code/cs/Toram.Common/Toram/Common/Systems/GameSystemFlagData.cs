// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Systems
public class GameSystemFlagData : BinaryBase // TypeDefIndex: 11245
{
	// Fields
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <Flag>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Value>k__BackingField; // 0x24

	// Properties
	public int Id { get; set; }
	public bool Flag { get; set; }
	public int Value { get; set; }

	// Methods

	// RVA: 0x36CE974 Offset: 0x36CA974 VA: 0x36CE974
	public void .ctor() { }

	// RVA: 0x36CE97C Offset: 0x36CA97C VA: 0x36CE97C
	public void .ctor(int id, bool flag, int value) { }

	[CompilerGenerated]
	// RVA: 0x36CE9C0 Offset: 0x36CA9C0 VA: 0x36CE9C0
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x36CE9C8 Offset: 0x36CA9C8 VA: 0x36CE9C8
	private void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x36CE9D0 Offset: 0x36CA9D0 VA: 0x36CE9D0
	public bool get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x36CE9D8 Offset: 0x36CA9D8 VA: 0x36CE9D8
	private void set_Flag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x36CE9E4 Offset: 0x36CA9E4 VA: 0x36CE9E4
	public int get_Value() { }

	[CompilerGenerated]
	// RVA: 0x36CE9EC Offset: 0x36CA9EC VA: 0x36CE9EC
	private void set_Value(int value) { }

	// RVA: 0x36CE9F4 Offset: 0x36CA9F4 VA: 0x36CE9F4 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36CEB18 Offset: 0x36CAB18 VA: 0x36CEB18 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
