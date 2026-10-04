// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Datatype_union : Datatype_anySimpleType // TypeDefIndex: 13625
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private XmlSchemaSimpleType[] types; // 0x38

	// Properties
	public override Type ValueType { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override FacetsChecker FacetsChecker { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	internal XmlSchemaSimpleType[] BaseMemberTypes { get; }

	// Methods

	// RVA: 0x342B5F8 Offset: 0x34275F8 VA: 0x342B5F8 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x3429728 Offset: 0x3425728 VA: 0x3429728
	internal void .ctor(XmlSchemaSimpleType[] types) { }

	// RVA: 0x342B604 Offset: 0x3427604 VA: 0x342B604 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x342B708 Offset: 0x3427708 VA: 0x342B708 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x342B760 Offset: 0x3427760 VA: 0x342B760 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x342B768 Offset: 0x3427768 VA: 0x342B768 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x342B7C0 Offset: 0x34277C0 VA: 0x342B7C0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x342B818 Offset: 0x3427818 VA: 0x342B818 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x342B820 Offset: 0x3427820 VA: 0x342B820
	internal XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x3429570 Offset: 0x3425570 VA: 0x3429570
	internal bool HasAtomicMembers() { }

	// RVA: 0x34299AC Offset: 0x34259AC VA: 0x34299AC
	internal bool IsUnionBaseOf(DatatypeImplementation derivedType) { }

	// RVA: 0x342B828 Offset: 0x3427828 VA: 0x342B828 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x342BA2C Offset: 0x3427A2C VA: 0x342BA2C Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x342BEDC Offset: 0x3427EDC VA: 0x342BEDC
	private static void .cctor() { }
}
