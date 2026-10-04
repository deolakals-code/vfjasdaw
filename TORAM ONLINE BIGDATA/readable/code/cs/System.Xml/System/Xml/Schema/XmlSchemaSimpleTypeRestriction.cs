// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaSimpleTypeRestriction : XmlSchemaSimpleTypeContent // TypeDefIndex: 13827
{
	// Fields
	private XmlQualifiedName baseTypeName; // 0x50
	private XmlSchemaSimpleType baseType; // 0x58
	private XmlSchemaObjectCollection facets; // 0x60

	// Properties
	[Xml("base")]
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaSimpleType BaseType { get; set; }
	[XmlElement("minInclusive", typeof(XmlSchemaMinInclusiveFacet))]
	[XmlElement("whiteSpace", typeof(XmlSchemaWhiteSpaceFacet))]
	[XmlElement("pattern", typeof(XmlSchemaPatternFacet))]
	[XmlElement("enumeration", typeof(XmlSchemaEnumerationFacet))]
	[XmlElement("minExclusive", typeof(XmlSchemaMinExclusiveFacet))]
	[XmlElement("maxExclusive", typeof(XmlSchemaMaxExclusiveFacet))]
	[XmlElement("minLength", typeof(XmlSchemaMinLengthFacet))]
	[XmlElement("maxInclusive", typeof(XmlSchemaMaxInclusiveFacet))]
	[XmlElement("length", typeof(XmlSchemaLengthFacet))]
	[XmlElement("totalDigits", typeof(XmlSchemaTotalDigitsFacet))]
	[XmlElement("fractionDigits", typeof(XmlSchemaFractionDigitsFacet))]
	[XmlElement("maxLength", typeof(XmlSchemaMaxLengthFacet))]
	public XmlSchemaObjectCollection Facets { get; }

	// Methods

	// RVA: 0x3343680 Offset: 0x333F680 VA: 0x3343680
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x3343688 Offset: 0x333F688 VA: 0x3343688
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x3343728 Offset: 0x333F728 VA: 0x3343728
	public XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0x3343730 Offset: 0x333F730 VA: 0x3343730
	public void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x3343738 Offset: 0x333F738 VA: 0x3343738
	public XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0x3343740 Offset: 0x333F740 VA: 0x3343740 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x33437F0 Offset: 0x333F7F0 VA: 0x33437F0
	public void .ctor() { }
}
