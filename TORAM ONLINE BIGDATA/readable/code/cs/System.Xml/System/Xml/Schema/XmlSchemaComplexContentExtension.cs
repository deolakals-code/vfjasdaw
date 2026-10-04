// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaComplexContentExtension : XmlSchemaContent // TypeDefIndex: 13765
{
	// Fields
	private XmlSchemaParticle particle; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName baseTypeName; // 0x68

	// Properties
	[Xml("base")]
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	public XmlSchemaParticle Particle { get; set; }
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x33349DC Offset: 0x33309DC VA: 0x33349DC
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x33349E4 Offset: 0x33309E4 VA: 0x33349E4
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x3334A84 Offset: 0x3330A84 VA: 0x3334A84
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x3334A8C Offset: 0x3330A8C VA: 0x3334A8C
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x3334A94 Offset: 0x3330A94 VA: 0x3334A94
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x3334A9C Offset: 0x3330A9C VA: 0x3334A9C
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x3334AA4 Offset: 0x3330AA4 VA: 0x3334AA4
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x3334AAC Offset: 0x3330AAC VA: 0x3334AAC
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x3334AB4 Offset: 0x3330AB4 VA: 0x3334AB4
	public void .ctor() { }
}
