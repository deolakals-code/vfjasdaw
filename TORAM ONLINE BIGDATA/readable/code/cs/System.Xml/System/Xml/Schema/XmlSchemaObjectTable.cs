// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
[DefaultMember("Item")]
public class XmlSchemaObjectTable // TypeDefIndex: 13814
{
	// Fields
	private Dictionary<XmlQualifiedName, XmlSchemaObject> table; // 0x10
	private List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x18

	// Properties
	public int Count { get; }
	public XmlSchemaObject Item { get; }
	public ICollection Values { get; }

	// Methods

	// RVA: 0x33393B4 Offset: 0x33353B4 VA: 0x33393B4
	internal void .ctor() { }

	// RVA: 0x3339490 Offset: 0x3335490 VA: 0x3339490
	internal void Add(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x33395D8 Offset: 0x33355D8 VA: 0x33395D8
	internal void Insert(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x3339798 Offset: 0x3335798 VA: 0x3339798
	internal void Replace(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x33398A8 Offset: 0x33358A8 VA: 0x33398A8
	internal void Clear() { }

	// RVA: 0x333993C Offset: 0x333593C VA: 0x333993C
	internal void Remove(XmlQualifiedName name) { }

	// RVA: 0x33396FC Offset: 0x33356FC VA: 0x33396FC
	private int FindIndexByValue(XmlSchemaObject xso) { }

	// RVA: 0x3339A0C Offset: 0x3335A0C VA: 0x3339A0C
	public int get_Count() { }

	// RVA: 0x3339A5C Offset: 0x3335A5C VA: 0x3339A5C
	public bool Contains(XmlQualifiedName name) { }

	// RVA: 0x3339AB4 Offset: 0x3335AB4 VA: 0x3339AB4
	public XmlSchemaObject get_Item(XmlQualifiedName name) { }

	// RVA: 0x3339B2C Offset: 0x3335B2C VA: 0x3339B2C
	public ICollection get_Values() { }

	// RVA: 0x3339C08 Offset: 0x3335C08 VA: 0x3339C08
	public IDictionaryEnumerator GetEnumerator() { }
}
