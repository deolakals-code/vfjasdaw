// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class DateTimeFacetsChecker : FacetsChecker // TypeDefIndex: 13694
{
	// Methods

	// RVA: 0x343BFC8 Offset: 0x3437FC8 VA: 0x343BFC8 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x343C02C Offset: 0x343802C VA: 0x343C02C Slot: 10
	internal override Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x343C560 Offset: 0x3438560 VA: 0x343C560 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x343C420 Offset: 0x3438420 VA: 0x343C420
	private bool MatchEnumeration(DateTime value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x3426E58 Offset: 0x3422E58 VA: 0x3426E58
	public void .ctor() { }
}
