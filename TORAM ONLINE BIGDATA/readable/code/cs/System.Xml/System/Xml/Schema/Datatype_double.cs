// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Datatype_double : Datatype_anySimpleType // TypeDefIndex: 13632
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

	// RVA: 0x342CC78 Offset: 0x3428C78 VA: 0x342CC78 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x342CC84 Offset: 0x3428C84 VA: 0x342CC84 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x342CCDC Offset: 0x3428CDC VA: 0x342CCDC Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x342CCE4 Offset: 0x3428CE4 VA: 0x342CCE4 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x342CD3C Offset: 0x3428D3C VA: 0x342CD3C Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x342CD94 Offset: 0x3428D94 VA: 0x342CD94 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x342CD9C Offset: 0x3428D9C VA: 0x342CD9C Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x342CDA4 Offset: 0x3428DA4 VA: 0x342CDA4 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x342CE38 Offset: 0x3428E38 VA: 0x342CE38 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3427270 Offset: 0x3423270 VA: 0x3427270
	public void .ctor() { }

	// RVA: 0x342CF8C Offset: 0x3428F8C VA: 0x342CF8C
	private static void .cctor() { }
}
