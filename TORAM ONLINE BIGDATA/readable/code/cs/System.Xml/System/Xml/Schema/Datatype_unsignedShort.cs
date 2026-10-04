// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Datatype_unsignedShort : Datatype_unsignedInt // TypeDefIndex: 13676
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

	// RVA: 0x3432228 Offset: 0x342E228 VA: 0x3432228 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x3432280 Offset: 0x342E280 VA: 0x3432280 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3432288 Offset: 0x342E288 VA: 0x3432288 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x343231C Offset: 0x342E31C VA: 0x343231C Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x3432374 Offset: 0x342E374 VA: 0x3432374 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x34323CC Offset: 0x342E3CC VA: 0x34323CC Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3427C38 Offset: 0x3423C38 VA: 0x3427C38
	public void .ctor() { }

	// RVA: 0x3432520 Offset: 0x342E520 VA: 0x3432520
	private static void .cctor() { }
}
