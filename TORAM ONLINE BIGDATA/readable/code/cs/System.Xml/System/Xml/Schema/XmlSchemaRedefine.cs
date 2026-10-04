// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaRedefine : XmlSchemaExternal // TypeDefIndex: 13818
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x68
	private XmlSchemaObjectTable attributeGroups; // 0x70
	private XmlSchemaObjectTable types; // 0x78
	private XmlSchemaObjectTable groups; // 0x80

	// Properties
	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	[XmlElement("group", typeof(XmlSchemaGroup))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroup))]
	public XmlSchemaObjectCollection Items { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable AttributeGroups { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable SchemaTypes { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable Groups { get; }

	// Methods

	// RVA: 0x333B1E8 Offset: 0x33371E8 VA: 0x333B1E8
	public void .ctor() { }

	// RVA: 0x333B2DC Offset: 0x33372DC VA: 0x333B2DC
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x333B2E4 Offset: 0x33372E4 VA: 0x333B2E4
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x333B2EC Offset: 0x33372EC VA: 0x333B2EC
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x333B2F4 Offset: 0x33372F4 VA: 0x333B2F4
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x333B2FC Offset: 0x33372FC VA: 0x333B2FC Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }
}
