// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Datatype_unsignedInt : Datatype_unsignedLong // TypeDefIndex: 13675
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

	// RVA: 0x3431D94 Offset: 0x342DD94 VA: 0x3431D94 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x3431DEC Offset: 0x342DDEC VA: 0x3431DEC Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3431DF4 Offset: 0x342DDF4 VA: 0x3431DF4 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x3431E88 Offset: 0x342DE88 VA: 0x3431E88 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x3431EE0 Offset: 0x342DEE0 VA: 0x3431EE0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x3431F38 Offset: 0x342DF38 VA: 0x3431F38 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3427B90 Offset: 0x3423B90 VA: 0x3427B90
	public void .ctor() { }

	// RVA: 0x343208C Offset: 0x342E08C VA: 0x343208C
	private static void .cctor() { }
}
