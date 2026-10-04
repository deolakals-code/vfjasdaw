// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Datatype_QName : Datatype_anySimpleType // TypeDefIndex: 13653
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x342F48C Offset: 0x342B48C VA: 0x342F48C Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x342F498 Offset: 0x342B498 VA: 0x342F498 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x342F4F0 Offset: 0x342B4F0 VA: 0x342F4F0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x342F4F8 Offset: 0x342B4F8 VA: 0x342F4F8 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x342F500 Offset: 0x342B500 VA: 0x342F500 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x342F508 Offset: 0x342B508 VA: 0x342F508 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x342F560 Offset: 0x342B560 VA: 0x342F560 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x342F5B8 Offset: 0x342B5B8 VA: 0x342F5B8 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x342F5C0 Offset: 0x342B5C0 VA: 0x342F5C0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x34278E0 Offset: 0x34238E0 VA: 0x34278E0
	public void .ctor() { }

	// RVA: 0x342F810 Offset: 0x342B810 VA: 0x342F810
	private static void .cctor() { }
}
