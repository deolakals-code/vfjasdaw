// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Datatype_float : Datatype_anySimpleType // TypeDefIndex: 13631
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

	// RVA: 0x342C890 Offset: 0x3428890 VA: 0x342C890 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x342C89C Offset: 0x342889C VA: 0x342C89C Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x342C8F4 Offset: 0x34288F4 VA: 0x342C8F4 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x342C8FC Offset: 0x34288FC VA: 0x342C8FC Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x342C954 Offset: 0x3428954 VA: 0x342C954 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x342C9AC Offset: 0x34289AC VA: 0x342C9AC Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x342C9B4 Offset: 0x34289B4 VA: 0x342C9B4 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x342C9BC Offset: 0x34289BC VA: 0x342C9BC Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x342CA50 Offset: 0x3428A50 VA: 0x342CA50 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3427568 Offset: 0x3423568 VA: 0x3427568
	public void .ctor() { }

	// RVA: 0x342CBA4 Offset: 0x3428BA4 VA: 0x342CBA4
	private static void .cctor() { }
}
