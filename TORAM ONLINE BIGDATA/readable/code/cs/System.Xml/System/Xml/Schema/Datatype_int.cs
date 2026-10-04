// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Datatype_int : Datatype_long // TypeDefIndex: 13670
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x34309C8 Offset: 0x342C9C8 VA: 0x34309C8 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x3430A20 Offset: 0x342CA20 VA: 0x3430A20 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3430A28 Offset: 0x342CA28 VA: 0x3430A28 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x3430ABC Offset: 0x342CABC VA: 0x3430ABC Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x3430B14 Offset: 0x342CB14 VA: 0x3430B14 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x3430B6C Offset: 0x342CB6C VA: 0x3430B6C Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x342766C Offset: 0x342366C VA: 0x342766C
	public void .ctor() { }

	// RVA: 0x3430CC0 Offset: 0x342CCC0 VA: 0x3430CC0
	private static void .cctor() { }
}
