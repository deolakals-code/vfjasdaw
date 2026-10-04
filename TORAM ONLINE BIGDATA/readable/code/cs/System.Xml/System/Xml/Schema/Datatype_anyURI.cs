// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Datatype_anyURI : Datatype_anySimpleType // TypeDefIndex: 13652
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override bool HasValueFacets { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x342EE08 Offset: 0x342AE08 VA: 0x342EE08 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x342EE14 Offset: 0x342AE14 VA: 0x342EE14 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x342EE6C Offset: 0x342AE6C VA: 0x342EE6C Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x342EE74 Offset: 0x342AE74 VA: 0x342EE74 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x342EECC Offset: 0x342AECC VA: 0x342EECC Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x342EED4 Offset: 0x342AED4 VA: 0x342EED4 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x342EF2C Offset: 0x342AF2C VA: 0x342EF2C Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x342EF34 Offset: 0x342AF34 VA: 0x342EF34 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x342EF3C Offset: 0x342AF3C VA: 0x342EF3C Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x342F000 Offset: 0x342B000 VA: 0x342F000 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3426EC0 Offset: 0x3422EC0 VA: 0x3426EC0
	public void .ctor() { }

	// RVA: 0x342F3B8 Offset: 0x342B3B8 VA: 0x342F3B8
	private static void .cctor() { }
}
