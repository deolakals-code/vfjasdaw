// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
[Usage(10624)]
public class XmlAttributeAttribute : Attribute // TypeDefIndex: 13512
{
	// Fields
	private string attributeName; // 0x10
	private string dataType; // 0x18
	private Type type; // 0x20
	private XmlSchemaForm form; // 0x28
	private string ns; // 0x30

	// Properties
	public string AttributeName { get; }
	public string DataType { get; set; }
	public XmlSchemaForm Form { get; }
	public string Namespace { get; }

	// Methods

	// RVA: 0x33EE998 Offset: 0x33EA998 VA: 0x33EE998
	public void .ctor(string attributeName) { }

	// RVA: 0x33EE9C8 Offset: 0x33EA9C8 VA: 0x33EE9C8
	public string get_AttributeName() { }

	// RVA: 0x33EEA1C Offset: 0x33EAA1C VA: 0x33EEA1C
	public string get_DataType() { }

	// RVA: 0x33EEA70 Offset: 0x33EAA70 VA: 0x33EEA70
	public void set_DataType(string value) { }

	// RVA: 0x33EEA78 Offset: 0x33EAA78 VA: 0x33EEA78
	public XmlSchemaForm get_Form() { }

	// RVA: 0x33EEA80 Offset: 0x33EAA80 VA: 0x33EEA80
	public string get_Namespace() { }

	// RVA: 0x33EEA88 Offset: 0x33EAA88 VA: 0x33EEA88
	internal void AddKeyHash(StringBuilder sb) { }
}
