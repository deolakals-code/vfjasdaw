// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Datatype_List : Datatype_anySimpleType // TypeDefIndex: 13624
{
	// Fields
	private DatatypeImplementation itemType; // 0x38
	private int minListSize; // 0x40

	// Properties
	public override Type ValueType { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override Type ListValueType { get; }
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x342A588 Offset: 0x3426588 VA: 0x342A588 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x34295EC Offset: 0x34255EC VA: 0x34295EC
	internal void .ctor(DatatypeImplementation type, int minListSize) { }

	// RVA: 0x342A824 Offset: 0x3426824 VA: 0x342A824 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x342AAD4 Offset: 0x3426AD4 VA: 0x342AAD4 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x342AAE4 Offset: 0x3426AE4 VA: 0x342AAE4 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x342AB04 Offset: 0x3426B04 VA: 0x342AB04 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x342AB28 Offset: 0x3426B28 VA: 0x342AB28 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x342AB80 Offset: 0x3426B80 VA: 0x342AB80 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x342ABA0 Offset: 0x3426BA0 VA: 0x342ABA0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x342ABA8 Offset: 0x3426BA8 VA: 0x342ABA8 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	// RVA: 0x342B1B8 Offset: 0x34271B8 VA: 0x342B1B8 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }
}
