// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Datatype_byte : Datatype_short // TypeDefIndex: 13672
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

	// RVA: 0x34312C0 Offset: 0x342D2C0 VA: 0x34312C0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x3431318 Offset: 0x342D318 VA: 0x3431318 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3431320 Offset: 0x342D320 VA: 0x3431320 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x34313B4 Offset: 0x342D3B4 VA: 0x34313B4 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x343140C Offset: 0x342D40C VA: 0x343140C Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x3431464 Offset: 0x342D464 VA: 0x3431464 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3426FBC Offset: 0x3422FBC VA: 0x3426FBC
	public void .ctor() { }

	// RVA: 0x34315B8 Offset: 0x342D5B8 VA: 0x34315B8
	private static void .cctor() { }
}
