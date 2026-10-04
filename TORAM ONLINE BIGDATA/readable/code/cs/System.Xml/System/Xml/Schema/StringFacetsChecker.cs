// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class StringFacetsChecker : FacetsChecker // TypeDefIndex: 13695
{
	// Fields
	private static Regex languagePattern; // 0x0

	// Properties
	private static Regex LanguagePattern { get; }

	// Methods

	// RVA: 0x343C5BC Offset: 0x34385BC VA: 0x343C5BC
	private static Regex get_LanguagePattern() { }

	// RVA: 0x343C66C Offset: 0x343866C VA: 0x343C66C Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x343C6CC Offset: 0x34386CC VA: 0x343C6CC Slot: 13
	internal override Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0x342F184 Offset: 0x342B184 VA: 0x342F184
	internal Exception CheckValueFacets(string value, XmlSchemaDatatype datatype, bool verifyUri) { }

	// RVA: 0x343CAF8 Offset: 0x3438AF8 VA: 0x343CAF8 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x343C91C Offset: 0x343891C VA: 0x343C91C
	private bool MatchEnumeration(string value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x343C6D4 Offset: 0x34386D4 VA: 0x343C6D4
	private Exception CheckBuiltInFacets(string s, XmlTypeCode typeCode, bool verifyUri) { }

	// RVA: 0x3426E48 Offset: 0x3422E48 VA: 0x3426E48
	public void .ctor() { }
}
