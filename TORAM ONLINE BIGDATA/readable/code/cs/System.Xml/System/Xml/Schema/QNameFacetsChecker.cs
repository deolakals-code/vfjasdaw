// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class QNameFacetsChecker : FacetsChecker // TypeDefIndex: 13696
{
	// Methods

	// RVA: 0x32D72D8 Offset: 0x32D32D8 VA: 0x32D72D8 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x32D7404 Offset: 0x32D3404 VA: 0x32D7404 Slot: 16
	internal override Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	// RVA: 0x32D76F8 Offset: 0x32D36F8 VA: 0x32D76F8 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x32D75E4 Offset: 0x32D35E4 VA: 0x32D75E4
	private bool MatchEnumeration(XmlQualifiedName value, ArrayList enumeration) { }

	// RVA: 0x32D780C Offset: 0x32D380C VA: 0x32D780C
	public void .ctor() { }
}
