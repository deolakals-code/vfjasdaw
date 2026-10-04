// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Numeric10FacetsChecker : FacetsChecker // TypeDefIndex: 13691
{
	// Fields
	private static readonly char[] signs; // 0x0
	private Decimal maxValue; // 0x10
	private Decimal minValue; // 0x20

	// Methods

	// RVA: 0x342D574 Offset: 0x3429574 VA: 0x342D574
	internal void .ctor(Decimal minVal, Decimal maxVal) { }

	// RVA: 0x343AB3C Offset: 0x3436B3C VA: 0x343AB3C Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x343ABAC Offset: 0x3436BAC VA: 0x343ABAC Slot: 6
	internal override Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0x343B298 Offset: 0x3437298 VA: 0x343B298 Slot: 7
	internal override Exception CheckValueFacets(long value, XmlSchemaDatatype datatype) { }

	// RVA: 0x343B324 Offset: 0x3437324 VA: 0x343B324 Slot: 8
	internal override Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0x343B3B0 Offset: 0x34373B0 VA: 0x343B3B0 Slot: 9
	internal override Exception CheckValueFacets(short value, XmlSchemaDatatype datatype) { }

	// RVA: 0x343B43C Offset: 0x343743C VA: 0x343B43C Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x343B174 Offset: 0x3437174 VA: 0x343B174
	internal bool MatchEnumeration(Decimal value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0x3433C04 Offset: 0x342FC04 VA: 0x3433C04
	internal Exception CheckTotalAndFractionDigits(Decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction) { }

	// RVA: 0x343B4C0 Offset: 0x34374C0 VA: 0x343B4C0
	private static void .cctor() { }
}
