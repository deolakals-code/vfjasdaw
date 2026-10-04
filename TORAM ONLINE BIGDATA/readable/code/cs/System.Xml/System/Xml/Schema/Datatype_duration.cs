// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Datatype_duration : Datatype_anySimpleType // TypeDefIndex: 13634
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x342D5B4 Offset: 0x34295B4 VA: 0x342D5B4 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x342D5C0 Offset: 0x34295C0 VA: 0x342D5C0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x342D618 Offset: 0x3429618 VA: 0x342D618 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x342D620 Offset: 0x3429620 VA: 0x342D620 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x342D678 Offset: 0x3429678 VA: 0x342D678 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x342D6D0 Offset: 0x34296D0 VA: 0x342D6D0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x342D6D8 Offset: 0x34296D8 VA: 0x342D6D8 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x342D6E0 Offset: 0x34296E0 VA: 0x342D6E0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x342D784 Offset: 0x3429784 VA: 0x342D784 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3427318 Offset: 0x3423318 VA: 0x3427318
	public void .ctor() { }

	// RVA: 0x342D960 Offset: 0x3429960 VA: 0x342D960
	private static void .cctor() { }
}
