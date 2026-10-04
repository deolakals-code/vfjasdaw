// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class XmlMiscConverter : XmlBaseConverter // TypeDefIndex: 13848
{
	// Methods

	// RVA: 0x335E48C Offset: 0x335A48C VA: 0x335E48C
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x335E4F4 Offset: 0x335A4F4 VA: 0x335E4F4
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x335E54C Offset: 0x335A54C VA: 0x335E54C Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x335EBC4 Offset: 0x335ABC4 VA: 0x335EBC4 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x335F22C Offset: 0x335B22C VA: 0x335F22C Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x335EA88 Offset: 0x335AA88 VA: 0x335EA88
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x335F0C8 Offset: 0x335B0C8 VA: 0x335F0C8
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}
