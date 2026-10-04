// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class XmlUnionConverter : XmlBaseConverter // TypeDefIndex: 13854
{
	// Fields
	private XmlValueConverter[] converters; // 0x28
	private bool hasAtomicMember; // 0x30
	private bool hasListMember; // 0x31

	// Methods

	// RVA: 0x336BFEC Offset: 0x3367FEC VA: 0x336BFEC
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x336C24C Offset: 0x336824C VA: 0x336C24C
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x336C2A4 Offset: 0x33682A4 VA: 0x336C2A4 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}
