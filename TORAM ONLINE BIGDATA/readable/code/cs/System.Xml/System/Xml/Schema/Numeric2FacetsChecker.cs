// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Numeric2FacetsChecker : FacetsChecker // TypeDefIndex: 13692
{
	// Methods

	// RVA: 0x343B560 Offset: 0x3437560 VA: 0x343B560 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x343B5C0 Offset: 0x34375C0 VA: 0x343B5C0 Slot: 11
	internal override Exception CheckValueFacets(double value, XmlSchemaDatatype datatype) { }

	// RVA: 0x343B93C Offset: 0x343793C VA: 0x343B93C Slot: 12
	internal override Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	// RVA: 0x343B94C Offset: 0x343794C VA: 0x343B94C Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x343B878 Offset: 0x3437878 VA: 0x343B878
	private bool MatchEnumeration(double value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0x3426E50 Offset: 0x3422E50 VA: 0x3426E50
	public void .ctor() { }
}
