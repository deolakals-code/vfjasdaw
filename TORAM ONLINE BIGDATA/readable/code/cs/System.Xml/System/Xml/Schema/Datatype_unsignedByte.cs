// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Datatype_unsignedByte : Datatype_unsignedShort // TypeDefIndex: 13677
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

	// RVA: 0x34326BC Offset: 0x342E6BC VA: 0x34326BC Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x3432714 Offset: 0x342E714 VA: 0x3432714 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x343271C Offset: 0x342E71C VA: 0x343271C Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x34327B0 Offset: 0x342E7B0 VA: 0x34327B0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x3432808 Offset: 0x342E808 VA: 0x3432808 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x3432860 Offset: 0x342E860 VA: 0x3432860 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3427B3C Offset: 0x3423B3C VA: 0x3427B3C
	public void .ctor() { }

	// RVA: 0x34329B4 Offset: 0x342E9B4 VA: 0x34329B4
	private static void .cctor() { }
}
