// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaSimpleContentExtension : XmlSchemaContent // TypeDefIndex: 13822
{
	// Fields
	private XmlSchemaObjectCollection attributes; // 0x50
	private XmlSchemaAnyAttribute anyAttribute; // 0x58
	private XmlQualifiedName baseTypeName; // 0x60

	// Properties
	[Xml("base")]
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x3342FCC Offset: 0x333EFCC VA: 0x3342FCC
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x3342FD4 Offset: 0x333EFD4 VA: 0x3342FD4
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x3343074 Offset: 0x333F074 VA: 0x3343074
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x334307C Offset: 0x333F07C VA: 0x334307C
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x3343084 Offset: 0x333F084 VA: 0x3343084
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x334308C Offset: 0x333F08C VA: 0x334308C
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x3343094 Offset: 0x333F094 VA: 0x3343094
	public void .ctor() { }
}
