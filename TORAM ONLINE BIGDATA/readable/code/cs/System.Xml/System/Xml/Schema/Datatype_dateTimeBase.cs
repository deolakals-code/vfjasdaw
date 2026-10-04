// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Datatype_dateTimeBase : Datatype_anySimpleType // TypeDefIndex: 13637
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private XsdDateTimeFlags dateTimeFlags; // 0x38

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x342DE04 Offset: 0x3429E04 VA: 0x342DE04 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x342DE10 Offset: 0x3429E10 VA: 0x342DE10 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x342DE68 Offset: 0x3429E68 VA: 0x342DE68 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x342DE70 Offset: 0x3429E70 VA: 0x342DE70
	internal void .ctor(XsdDateTimeFlags dateTimeFlags) { }

	// RVA: 0x342DED8 Offset: 0x3429ED8 VA: 0x342DED8 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x342DF30 Offset: 0x3429F30 VA: 0x342DF30 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x342DF88 Offset: 0x3429F88 VA: 0x342DF88 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x342DF90 Offset: 0x3429F90 VA: 0x342DF90 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x342DF98 Offset: 0x3429F98 VA: 0x342DF98 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x342E0E0 Offset: 0x342A0E0 VA: 0x342E0E0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x342E430 Offset: 0x342A430 VA: 0x342E430
	private static void .cctor() { }
}
