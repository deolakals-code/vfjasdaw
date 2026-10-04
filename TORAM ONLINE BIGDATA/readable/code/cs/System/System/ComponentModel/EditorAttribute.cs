// Assembly: System.dll
// Namespace: System.ComponentModel
[Usage(32767, AllowMultiple = True, Inherited = True)]
public sealed class EditorAttribute : Attribute // TypeDefIndex: 14200
{
	// Fields
	private string _typeId; // 0x10
	[CompilerGenerated]
	private readonly string <EditorBaseTypeName>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <EditorTypeName>k__BackingField; // 0x20

	// Properties
	public string EditorBaseTypeName { get; }
	public string EditorTypeName { get; }
	public override object TypeId { get; }

	// Methods

	// RVA: 0x34A8564 Offset: 0x34A4564 VA: 0x34A8564
	public void .ctor(string typeName, string baseTypeName) { }

	[CompilerGenerated]
	// RVA: 0x34A860C Offset: 0x34A460C VA: 0x34A860C
	public string get_EditorBaseTypeName() { }

	[CompilerGenerated]
	// RVA: 0x34A8614 Offset: 0x34A4614 VA: 0x34A8614
	public string get_EditorTypeName() { }

	// RVA: 0x34A861C Offset: 0x34A461C VA: 0x34A861C Slot: 4
	public override object get_TypeId() { }

	// RVA: 0x34A86BC Offset: 0x34A46BC VA: 0x34A86BC Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x34A8760 Offset: 0x34A4760 VA: 0x34A8760 Slot: 2
	public override int GetHashCode() { }
}
