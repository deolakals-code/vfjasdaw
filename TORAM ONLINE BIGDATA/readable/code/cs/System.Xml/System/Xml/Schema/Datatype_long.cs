// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Datatype_long : Datatype_integer // TypeDefIndex: 13669
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	internal override bool HasValueFacets { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x3430544 Offset: 0x342C544 VA: 0x3430544 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x343059C Offset: 0x342C59C VA: 0x343059C Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x34305A4 Offset: 0x342C5A4 VA: 0x34305A4 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x34305AC Offset: 0x342C5AC VA: 0x34305AC Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x3430640 Offset: 0x342C640 VA: 0x3430640 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x3430698 Offset: 0x342C698 VA: 0x3430698 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x34306F0 Offset: 0x342C6F0 VA: 0x34306F0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3427718 Offset: 0x3423718 VA: 0x3427718
	public void .ctor() { }

	// RVA: 0x3430844 Offset: 0x342C844 VA: 0x3430844
	private static void .cctor() { }
}
