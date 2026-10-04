// Assembly: System.Xml.dll
// Namespace: 
private class DatatypeImplementation.SchemaDatatypeMap : IComparable // TypeDefIndex: 13622
{
	// Fields
	private string name; // 0x10
	private DatatypeImplementation type; // 0x18
	private int parentIndex; // 0x20

	// Properties
	public string Name { get; }
	public int ParentIndex { get; }

	// Methods

	// RVA: 0x3427E98 Offset: 0x3423E98 VA: 0x3427E98
	internal void .ctor(string name, DatatypeImplementation type) { }

	// RVA: 0x3427EDC Offset: 0x3423EDC VA: 0x3427EDC
	internal void .ctor(string name, DatatypeImplementation type, int parentIndex) { }

	// RVA: 0x342A4F0 Offset: 0x34264F0 VA: 0x342A4F0
	public static DatatypeImplementation op_Explicit(DatatypeImplementation.SchemaDatatypeMap sdm) { }

	// RVA: 0x342A508 Offset: 0x3426508 VA: 0x342A508
	public string get_Name() { }

	// RVA: 0x342A510 Offset: 0x3426510 VA: 0x342A510
	public int get_ParentIndex() { }

	// RVA: 0x342A518 Offset: 0x3426518 VA: 0x342A518 Slot: 4
	public int CompareTo(object obj) { }
}
