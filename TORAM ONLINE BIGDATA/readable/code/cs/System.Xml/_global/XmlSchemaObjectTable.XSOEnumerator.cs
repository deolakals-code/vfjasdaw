// Assembly: System.Xml.dll
// Namespace: 
internal class XmlSchemaObjectTable.XSOEnumerator : IEnumerator // TypeDefIndex: 13812
{
	// Fields
	private List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x10
	private XmlSchemaObjectTable.EnumeratorType enumType; // 0x18
	protected int currentIndex; // 0x1C
	protected int size; // 0x20
	protected XmlQualifiedName currentKey; // 0x28
	protected XmlSchemaObject currentValue; // 0x30

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x333A004 Offset: 0x3336004 VA: 0x333A004
	internal void .ctor(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, XmlSchemaObjectTable.EnumeratorType enumType) { }

	// RVA: 0x333A054 Offset: 0x3336054 VA: 0x333A054 Slot: 5
	public object get_Current() { }

	// RVA: 0x333A20C Offset: 0x333620C VA: 0x333A20C Slot: 4
	public bool MoveNext() { }

	// RVA: 0x333A2DC Offset: 0x33362DC VA: 0x333A2DC Slot: 6
	public void Reset() { }
}
