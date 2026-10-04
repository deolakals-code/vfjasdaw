// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaSimpleContentRestriction : XmlSchemaContent // TypeDefIndex: 13823
{
	// Fields
	private XmlQualifiedName baseTypeName; // 0x50
	private XmlSchemaSimpleType baseType; // 0x58
	private XmlSchemaObjectCollection facets; // 0x60
	private XmlSchemaObjectCollection attributes; // 0x68
	private XmlSchemaAnyAttribute anyAttribute; // 0x70

	// Properties
	[Xml("base")]
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaSimpleType BaseType { get; set; }
	[XmlElement("maxLength", typeof(XmlSchemaMaxLengthFacet))]
	[XmlElement("maxInclusive", typeof(XmlSchemaMaxInclusiveFacet))]
	[XmlElement("maxExclusive", typeof(XmlSchemaMaxExclusiveFacet))]
	[XmlElement("minInclusive", typeof(XmlSchemaMinInclusiveFacet))]
	[XmlElement("minExclusive", typeof(XmlSchemaMinExclusiveFacet))]
	[XmlElement("totalDigits", typeof(XmlSchemaTotalDigitsFacet))]
	[XmlElement("fractionDigits", typeof(XmlSchemaFractionDigitsFacet))]
	[XmlElement("whiteSpace", typeof(XmlSchemaWhiteSpaceFacet))]
	[XmlElement("minLength", typeof(XmlSchemaMinLengthFacet))]
	[XmlElement("enumeration", typeof(XmlSchemaEnumerationFacet))]
	[XmlElement("pattern", typeof(XmlSchemaPatternFacet))]
	[XmlElement("length", typeof(XmlSchemaLengthFacet))]
	public XmlSchemaObjectCollection Facets { get; }
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x3343144 Offset: 0x333F144 VA: 0x3343144
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x334314C Offset: 0x333F14C VA: 0x334314C
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x33431EC Offset: 0x333F1EC VA: 0x33431EC
	public XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0x33431F4 Offset: 0x333F1F4 VA: 0x33431F4
	public void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x33431FC Offset: 0x333F1FC VA: 0x33431FC
	public XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0x3343204 Offset: 0x333F204 VA: 0x3343204
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x334320C Offset: 0x333F20C VA: 0x334320C
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x3343214 Offset: 0x333F214 VA: 0x3343214
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x334321C Offset: 0x333F21C VA: 0x334321C
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x3343224 Offset: 0x333F224 VA: 0x3343224
	public void .ctor() { }
}
