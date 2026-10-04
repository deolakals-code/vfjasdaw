// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Datatype_base64Binary : Datatype_anySimpleType // TypeDefIndex: 13651
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

	// RVA: 0x342E9A4 Offset: 0x342A9A4 VA: 0x342E9A4 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x342E9B0 Offset: 0x342A9B0 VA: 0x342E9B0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x342EA08 Offset: 0x342AA08 VA: 0x342EA08 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x342EA10 Offset: 0x342AA10 VA: 0x342EA10 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x342EA68 Offset: 0x342AA68 VA: 0x342EA68 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x342EAC0 Offset: 0x342AAC0 VA: 0x342EAC0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x342EAC8 Offset: 0x342AAC8 VA: 0x342EAC8 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x342EAD0 Offset: 0x342AAD0 VA: 0x342EAD0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x342EB78 Offset: 0x342AB78 VA: 0x342EB78 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3426F14 Offset: 0x3422F14 VA: 0x3426F14
	public void .ctor() { }

	// RVA: 0x342ED34 Offset: 0x342AD34 VA: 0x342ED34
	private static void .cctor() { }
}
