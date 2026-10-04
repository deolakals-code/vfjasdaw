// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Datatype_uuid : Datatype_anySimpleType // TypeDefIndex: 13685
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x3433FE0 Offset: 0x342FFE0 VA: 0x3433FE0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x3434038 Offset: 0x3430038 VA: 0x3434038 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x3434090 Offset: 0x3430090 VA: 0x3434090 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x3434098 Offset: 0x3430098 VA: 0x3434098 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x3434134 Offset: 0x3430134 VA: 0x3434134 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x3434304 Offset: 0x3430304 VA: 0x3434304 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3427C8C Offset: 0x3423C8C VA: 0x3427C8C
	public void .ctor() { }

	// RVA: 0x34343D0 Offset: 0x34303D0 VA: 0x34343D0
	private static void .cctor() { }
}
