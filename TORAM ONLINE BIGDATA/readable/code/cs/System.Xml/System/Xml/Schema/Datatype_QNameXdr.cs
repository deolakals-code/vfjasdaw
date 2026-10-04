// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Datatype_QNameXdr : Datatype_anySimpleType // TypeDefIndex: 13681
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override XmlTokenizedType TokenizedType { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x3433098 Offset: 0x342F098 VA: 0x3433098 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x34330A0 Offset: 0x342F0A0 VA: 0x34330A0 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x343330C Offset: 0x342F30C VA: 0x343330C Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x3433364 Offset: 0x342F364 VA: 0x3433364 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x3427934 Offset: 0x3423934 VA: 0x3427934
	public void .ctor() { }

	// RVA: 0x34333BC Offset: 0x342F3BC VA: 0x34333BC
	private static void .cctor() { }
}
