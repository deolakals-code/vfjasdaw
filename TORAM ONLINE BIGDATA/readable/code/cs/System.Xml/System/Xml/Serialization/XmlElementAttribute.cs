// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
[Usage(10624, AllowMultiple = True)]
public class XmlElementAttribute : Attribute // TypeDefIndex: 13517
{
	// Fields
	private string dataType; // 0x10
	private string elementName; // 0x18
	private XmlSchemaForm form; // 0x20
	private string ns; // 0x28
	private bool isNullable; // 0x30
	private Type type; // 0x38
	private int order; // 0x40

	// Properties
	public string DataType { get; }
	public string ElementName { get; }
	public XmlSchemaForm Form { get; }
	public string Namespace { get; }
	public bool IsNullable { get; }
	public int Order { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x33F27E4 Offset: 0x33EE7E4 VA: 0x33F27E4
	public void .ctor(string elementName) { }

	// RVA: 0x33F281C Offset: 0x33EE81C VA: 0x33F281C
	public void .ctor(string elementName, Type type) { }

	// RVA: 0x33F2868 Offset: 0x33EE868 VA: 0x33F2868
	public string get_DataType() { }

	// RVA: 0x33F28BC Offset: 0x33EE8BC VA: 0x33F28BC
	public string get_ElementName() { }

	// RVA: 0x33F2910 Offset: 0x33EE910 VA: 0x33F2910
	public XmlSchemaForm get_Form() { }

	// RVA: 0x33F2918 Offset: 0x33EE918 VA: 0x33F2918
	public string get_Namespace() { }

	// RVA: 0x33F2920 Offset: 0x33EE920 VA: 0x33F2920
	public bool get_IsNullable() { }

	// RVA: 0x33F2928 Offset: 0x33EE928 VA: 0x33F2928
	public int get_Order() { }

	// RVA: 0x33F2930 Offset: 0x33EE930 VA: 0x33F2930
	public Type get_Type() { }

	// RVA: 0x33F2938 Offset: 0x33EE938 VA: 0x33F2938
	internal void AddKeyHash(StringBuilder sb) { }
}
