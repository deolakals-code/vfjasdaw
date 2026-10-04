// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaComplexContentRestriction : XmlSchemaContent // TypeDefIndex: 13766
{
	// Fields
	private XmlSchemaParticle particle; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName baseTypeName; // 0x68

	// Properties
	[Xml("base")]
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	public XmlSchemaParticle Particle { get; set; }
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x3334B6C Offset: 0x3330B6C VA: 0x3334B6C
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x3334B74 Offset: 0x3330B74 VA: 0x3334B74
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x3334C14 Offset: 0x3330C14 VA: 0x3334C14
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x3334C1C Offset: 0x3330C1C VA: 0x3334C1C
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x3334C24 Offset: 0x3330C24 VA: 0x3334C24
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x3334C2C Offset: 0x3330C2C VA: 0x3334C2C
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x3334C34 Offset: 0x3330C34 VA: 0x3334C34
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x3334C3C Offset: 0x3330C3C VA: 0x3334C3C
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x3334C44 Offset: 0x3330C44 VA: 0x3334C44
	public void .ctor() { }
}
