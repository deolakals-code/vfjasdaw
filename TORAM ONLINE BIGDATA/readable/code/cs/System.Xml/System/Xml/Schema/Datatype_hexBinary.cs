// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Datatype_hexBinary : Datatype_anySimpleType // TypeDefIndex: 13650
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

	// RVA: 0x342E53C Offset: 0x342A53C VA: 0x342E53C Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x342E548 Offset: 0x342A548 VA: 0x342E548 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x342E5A0 Offset: 0x342A5A0 VA: 0x342E5A0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x342E5A8 Offset: 0x342A5A8 VA: 0x342E5A8 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x342E600 Offset: 0x342A600 VA: 0x342E600 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x342E658 Offset: 0x342A658 VA: 0x342E658 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x342E660 Offset: 0x342A660 VA: 0x342E660 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x342E668 Offset: 0x342A668 VA: 0x342E668 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x342E710 Offset: 0x342A710 VA: 0x342E710 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3427610 Offset: 0x3423610 VA: 0x3427610
	public void .ctor() { }

	// RVA: 0x342E8D0 Offset: 0x342A8D0 VA: 0x342E8D0
	private static void .cctor() { }
}
