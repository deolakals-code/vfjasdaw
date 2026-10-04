// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Datatype_NOTATION : Datatype_anySimpleType // TypeDefIndex: 13665
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

	// RVA: 0x342FA8C Offset: 0x342BA8C VA: 0x342FA8C Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x342FA98 Offset: 0x342BA98 VA: 0x342FA98 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x342FAF0 Offset: 0x342BAF0 VA: 0x342FAF0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x342FAF8 Offset: 0x342BAF8 VA: 0x342FAF8 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x342FB00 Offset: 0x342BB00 VA: 0x342FB00 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x342FB08 Offset: 0x342BB08 VA: 0x342FB08 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x342FB60 Offset: 0x342BB60 VA: 0x342FB60 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x342FBB8 Offset: 0x342BBB8 VA: 0x342FBB8 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x342FBC0 Offset: 0x342BBC0 VA: 0x342FBC0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x342FE10 Offset: 0x342BE10 VA: 0x342FE10 Slot: 22
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x3427838 Offset: 0x3423838 VA: 0x3427838
	public void .ctor() { }

	// RVA: 0x343001C Offset: 0x342C01C VA: 0x343001C
	private static void .cctor() { }
}
