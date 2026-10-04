// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Datatype_short : Datatype_int // TypeDefIndex: 13671
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

	// RVA: 0x3430E44 Offset: 0x342CE44 VA: 0x3430E44 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x3430E9C Offset: 0x342CE9C VA: 0x3430E9C Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3430EA4 Offset: 0x342CEA4 VA: 0x3430EA4 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x3430F38 Offset: 0x342CF38 VA: 0x3430F38 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x3430F90 Offset: 0x342CF90 VA: 0x3430F90 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x3430FE8 Offset: 0x342CFE8 VA: 0x3430FE8 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3427988 Offset: 0x3423988 VA: 0x3427988
	public void .ctor() { }

	// RVA: 0x343113C Offset: 0x342D13C VA: 0x343113C
	private static void .cctor() { }
}
