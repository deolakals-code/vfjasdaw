// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
[DefaultMember("Item")]
internal class KeySequence // TypeDefIndex: 13594
{
	// Fields
	private TypedObject[] ks; // 0x10
	private int dim; // 0x18
	private int hashcode; // 0x1C
	private int posline; // 0x20
	private int poscol; // 0x24

	// Properties
	public int PosLine { get; }
	public int PosCol { get; }
	public object Item { get; set; }

	// Methods

	// RVA: 0x341A3B4 Offset: 0x34163B4 VA: 0x341A3B4
	internal void .ctor(int dim, int line, int col) { }

	// RVA: 0x341AE78 Offset: 0x3416E78 VA: 0x341AE78
	public int get_PosLine() { }

	// RVA: 0x341AE80 Offset: 0x3416E80 VA: 0x341AE80
	public int get_PosCol() { }

	// RVA: 0x341AE88 Offset: 0x3416E88 VA: 0x341AE88
	public object get_Item(int index) { }

	// RVA: 0x341AEB8 Offset: 0x3416EB8 VA: 0x341AEB8
	public void set_Item(int index, object value) { }

	// RVA: 0x341AFB4 Offset: 0x3416FB4 VA: 0x341AFB4
	internal bool IsQualified() { }

	// RVA: 0x341B014 Offset: 0x3417014 VA: 0x341B014 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x341B388 Offset: 0x3417388 VA: 0x341B388 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x341B478 Offset: 0x3417478 VA: 0x341B478 Slot: 3
	public override string ToString() { }
}
