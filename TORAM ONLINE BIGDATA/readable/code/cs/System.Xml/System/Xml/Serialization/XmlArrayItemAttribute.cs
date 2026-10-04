// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
[Usage(10624, AllowMultiple = True)]
public class XmlArrayItemAttribute : Attribute // TypeDefIndex: 13510
{
	// Fields
	private string dataType; // 0x10
	private string elementName; // 0x18
	private XmlSchemaForm form; // 0x20
	private string ns; // 0x28
	private bool isNullable; // 0x30
	private bool isNullableSpecified; // 0x31
	private int nestingLevel; // 0x34
	private Type type; // 0x38

	// Properties
	public string DataType { get; }
	public string ElementName { get; }
	public XmlSchemaForm Form { get; }
	public string Namespace { get; }
	public bool IsNullable { get; }
	internal bool IsNullableSpecified { get; }
	public Type Type { get; }
	public int NestingLevel { get; }

	// Methods

	// RVA: 0x33EE4D0 Offset: 0x33EA4D0 VA: 0x33EE4D0
	public string get_DataType() { }

	// RVA: 0x33EE524 Offset: 0x33EA524 VA: 0x33EE524
	public string get_ElementName() { }

	// RVA: 0x33EE578 Offset: 0x33EA578 VA: 0x33EE578
	public XmlSchemaForm get_Form() { }

	// RVA: 0x33EE580 Offset: 0x33EA580 VA: 0x33EE580
	public string get_Namespace() { }

	// RVA: 0x33EE588 Offset: 0x33EA588 VA: 0x33EE588
	public bool get_IsNullable() { }

	// RVA: 0x33EE590 Offset: 0x33EA590 VA: 0x33EE590
	internal bool get_IsNullableSpecified() { }

	// RVA: 0x33EE598 Offset: 0x33EA598 VA: 0x33EE598
	public Type get_Type() { }

	// RVA: 0x33EE5A0 Offset: 0x33EA5A0 VA: 0x33EE5A0
	public int get_NestingLevel() { }

	// RVA: 0x33EE5A8 Offset: 0x33EA5A8 VA: 0x33EE5A8
	internal void AddKeyHash(StringBuilder sb) { }
}
