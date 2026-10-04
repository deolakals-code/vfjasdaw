// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Datatype_boolean : Datatype_anySimpleType // TypeDefIndex: 13630
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

	// RVA: 0x342C4D0 Offset: 0x34284D0 VA: 0x342C4D0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x342C4DC Offset: 0x34284DC VA: 0x342C4DC Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x342C534 Offset: 0x3428534 VA: 0x342C534 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x342C53C Offset: 0x342853C VA: 0x342C53C Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x342C594 Offset: 0x3428594 VA: 0x342C594 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x342C5EC Offset: 0x34285EC VA: 0x342C5EC Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x342C5F4 Offset: 0x34285F4 VA: 0x342C5F4 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x342C5FC Offset: 0x34285FC VA: 0x342C5FC Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x342C6A0 Offset: 0x34286A0 VA: 0x342C6A0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3426F68 Offset: 0x3422F68 VA: 0x3426F68
	public void .ctor() { }

	// RVA: 0x342C7BC Offset: 0x34287BC VA: 0x342C7BC
	private static void .cctor() { }
}
