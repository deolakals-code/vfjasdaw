// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Datatype_char : Datatype_anySimpleType // TypeDefIndex: 13683
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x3433498 Offset: 0x342F498 VA: 0x3433498 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x34334F0 Offset: 0x342F4F0 VA: 0x34334F0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x3433548 Offset: 0x342F548 VA: 0x3433548 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x3433550 Offset: 0x342F550 VA: 0x3433550 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x34335F4 Offset: 0x342F5F4 VA: 0x34335F4 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x34337C4 Offset: 0x342F7C4 VA: 0x34337C4 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3427010 Offset: 0x3423010 VA: 0x3427010
	public void .ctor() { }

	// RVA: 0x3433888 Offset: 0x342F888 VA: 0x3433888
	private static void .cctor() { }
}
