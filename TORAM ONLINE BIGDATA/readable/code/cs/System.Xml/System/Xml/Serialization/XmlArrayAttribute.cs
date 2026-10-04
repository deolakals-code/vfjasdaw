// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
[Usage(10624, AllowMultiple = False)]
public class XmlArrayAttribute : Attribute // TypeDefIndex: 13509
{
	// Fields
	private string elementName; // 0x10
	private XmlSchemaForm form; // 0x18
	private bool isNullable; // 0x1C
	private string ns; // 0x20
	private int order; // 0x28

	// Properties
	public string ElementName { get; }
	public XmlSchemaForm Form { get; }
	public bool IsNullable { get; }
	public string Namespace { get; }
	public int Order { get; }

	// Methods

	// RVA: 0x33EE33C Offset: 0x33EA33C VA: 0x33EE33C
	public string get_ElementName() { }

	// RVA: 0x33EE390 Offset: 0x33EA390 VA: 0x33EE390
	public XmlSchemaForm get_Form() { }

	// RVA: 0x33EE398 Offset: 0x33EA398 VA: 0x33EE398
	public bool get_IsNullable() { }

	// RVA: 0x33EE3A0 Offset: 0x33EA3A0 VA: 0x33EE3A0
	public string get_Namespace() { }

	// RVA: 0x33EE3A8 Offset: 0x33EA3A8 VA: 0x33EE3A8
	public int get_Order() { }

	// RVA: 0x33EE3B0 Offset: 0x33EA3B0 VA: 0x33EE3B0
	internal void AddKeyHash(StringBuilder sb) { }
}
