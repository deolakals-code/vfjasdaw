// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class DurationFacetsChecker : FacetsChecker // TypeDefIndex: 13693
{
	// Methods

	// RVA: 0x343B9C4 Offset: 0x34379C4 VA: 0x343B9C4 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x343BAD8 Offset: 0x3437AD8 VA: 0x343BAD8 Slot: 15
	internal override Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x343BF50 Offset: 0x3437F50 VA: 0x343BF50 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x343BE38 Offset: 0x3437E38 VA: 0x343BE38
	private bool MatchEnumeration(TimeSpan value, ArrayList enumeration) { }

	// RVA: 0x3426E60 Offset: 0x3422E60 VA: 0x3426E60
	public void .ctor() { }
}
