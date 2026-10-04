// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal sealed class ConstraintStruct // TypeDefIndex: 13588
{
	// Fields
	internal CompiledIdentityConstraint constraint; // 0x10
	internal SelectorActiveAxis axisSelector; // 0x18
	internal ArrayList axisFields; // 0x20
	internal Hashtable qualifiedTable; // 0x28
	internal Hashtable keyrefTable; // 0x30
	private int tableDim; // 0x38

	// Properties
	internal int TableDim { get; }

	// Methods

	// RVA: 0x3419D90 Offset: 0x3415D90 VA: 0x3419D90
	internal int get_TableDim() { }

	// RVA: 0x3419D98 Offset: 0x3415D98 VA: 0x3419D98
	internal void .ctor(CompiledIdentityConstraint constraint) { }
}
