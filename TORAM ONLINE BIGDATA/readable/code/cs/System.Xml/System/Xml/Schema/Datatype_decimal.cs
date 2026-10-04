// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Datatype_decimal : Datatype_anySimpleType // TypeDefIndex: 13633
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x342D060 Offset: 0x3429060 VA: 0x342D060 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x342D06C Offset: 0x342906C VA: 0x342D06C Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x342D0C4 Offset: 0x34290C4 VA: 0x342D0C4 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x342D0CC Offset: 0x34290CC VA: 0x342D0CC Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x342D124 Offset: 0x3429124 VA: 0x342D124 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x342D17C Offset: 0x342917C VA: 0x342D17C Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x342D184 Offset: 0x3429184 VA: 0x342D184 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x342D18C Offset: 0x342918C VA: 0x342D18C Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x342D258 Offset: 0x3429258 VA: 0x342D258 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x342721C Offset: 0x342321C VA: 0x342721C
	public void .ctor() { }

	// RVA: 0x342D3D0 Offset: 0x34293D0 VA: 0x342D3D0
	private static void .cctor() { }
}
