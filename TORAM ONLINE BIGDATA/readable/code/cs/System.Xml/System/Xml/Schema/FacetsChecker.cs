// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal abstract class FacetsChecker // TypeDefIndex: 13690
{
	// Methods

	// RVA: 0x3436B74 Offset: 0x3432B74 VA: 0x3436B74 Slot: 4
	internal virtual Exception CheckLexicalFacets(ref string parseString, XmlSchemaDatatype datatype) { }

	// RVA: 0x3436E0C Offset: 0x3432E0C VA: 0x3436E0C Slot: 5
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3436E14 Offset: 0x3432E14 VA: 0x3436E14 Slot: 6
	internal virtual Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3436E1C Offset: 0x3432E1C VA: 0x3436E1C Slot: 7
	internal virtual Exception CheckValueFacets(long value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3436E24 Offset: 0x3432E24 VA: 0x3436E24 Slot: 8
	internal virtual Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3436E2C Offset: 0x3432E2C VA: 0x3436E2C Slot: 9
	internal virtual Exception CheckValueFacets(short value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3436E34 Offset: 0x3432E34 VA: 0x3436E34 Slot: 10
	internal virtual Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3436E3C Offset: 0x3432E3C VA: 0x3436E3C Slot: 11
	internal virtual Exception CheckValueFacets(double value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3436E44 Offset: 0x3432E44 VA: 0x3436E44 Slot: 12
	internal virtual Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3436E4C Offset: 0x3432E4C VA: 0x3436E4C Slot: 13
	internal virtual Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3436E54 Offset: 0x3432E54 VA: 0x3436E54 Slot: 14
	internal virtual Exception CheckValueFacets(byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3436E5C Offset: 0x3432E5C VA: 0x3436E5C Slot: 15
	internal virtual Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3436E64 Offset: 0x3432E64 VA: 0x3436E64 Slot: 16
	internal virtual Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3436BB8 Offset: 0x3432BB8 VA: 0x3436BB8
	internal void CheckWhitespaceFacets(ref string s, XmlSchemaDatatype datatype) { }

	// RVA: 0x3436CB0 Offset: 0x3432CB0 VA: 0x3436CB0
	internal Exception CheckPatternFacets(RestrictionFacets restriction, string value) { }

	// RVA: 0x3436E6C Offset: 0x3432E6C VA: 0x3436E6C Slot: 17
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x3436E74 Offset: 0x3432E74 VA: 0x3436E74 Slot: 18
	internal virtual RestrictionFacets ConstructRestriction(DatatypeImplementation datatype, XmlSchemaObjectCollection facets, XmlNameTable nameTable) { }

	// RVA: 0x3439920 Offset: 0x3435920 VA: 0x3439920
	internal static Decimal Power(int x, int y) { }

	// RVA: 0x3439A4C Offset: 0x3435A4C VA: 0x3439A4C
	protected void .ctor() { }
}
