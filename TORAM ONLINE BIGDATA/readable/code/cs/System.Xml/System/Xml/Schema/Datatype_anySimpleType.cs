// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Datatype_anySimpleType : DatatypeImplementation // TypeDefIndex: 13626
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override Type ValueType { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override Type ListValueType { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x342BFB0 Offset: 0x3427FB0 VA: 0x342BFB0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x342C008 Offset: 0x3428008 VA: 0x342C008 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x342C060 Offset: 0x3428060 VA: 0x342C060 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x342C0B8 Offset: 0x34280B8 VA: 0x342C0B8 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x342C0C0 Offset: 0x34280C0 VA: 0x342C0C0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x342C118 Offset: 0x3428118 VA: 0x342C118 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x342C120 Offset: 0x3428120 VA: 0x342C120 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x342C128 Offset: 0x3428128 VA: 0x342C128 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x342C130 Offset: 0x3428130 VA: 0x342C130 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x342C18C Offset: 0x342818C VA: 0x342C18C Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3426E68 Offset: 0x3422E68 VA: 0x3426E68
	public void .ctor() { }

	// RVA: 0x342C1BC Offset: 0x34281BC VA: 0x342C1BC
	private static void .cctor() { }
}
