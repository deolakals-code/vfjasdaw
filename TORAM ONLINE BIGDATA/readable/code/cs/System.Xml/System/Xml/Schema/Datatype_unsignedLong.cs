// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Datatype_unsignedLong : Datatype_nonNegativeInteger // TypeDefIndex: 13674
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

	// RVA: 0x34318BC Offset: 0x342D8BC VA: 0x34318BC Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x3431914 Offset: 0x342D914 VA: 0x3431914 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x343191C Offset: 0x342D91C VA: 0x343191C Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x34319B0 Offset: 0x342D9B0 VA: 0x34319B0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x3431A08 Offset: 0x342DA08 VA: 0x3431A08 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x3431A60 Offset: 0x342DA60 VA: 0x3431A60 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3427BE4 Offset: 0x3423BE4 VA: 0x3427BE4
	public void .ctor() { }

	// RVA: 0x3431BF8 Offset: 0x342DBF8 VA: 0x3431BF8
	private static void .cctor() { }
}
