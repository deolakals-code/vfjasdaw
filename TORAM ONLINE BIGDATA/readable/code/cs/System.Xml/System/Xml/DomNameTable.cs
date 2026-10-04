// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class DomNameTable // TypeDefIndex: 13386
{
	// Fields
	private XmlName[] entries; // 0x10
	private int count; // 0x18
	private int mask; // 0x1C
	private XmlDocument ownerDocument; // 0x20
	private XmlNameTable nameTable; // 0x28

	// Methods

	// RVA: 0x33B0348 Offset: 0x33AC348 VA: 0x33B0348
	public void .ctor(XmlDocument document) { }

	// RVA: 0x33B0408 Offset: 0x33AC408 VA: 0x33B0408
	public XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x33B0570 Offset: 0x33AC570 VA: 0x33B0570
	public XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x33B07E8 Offset: 0x33AC7E8 VA: 0x33B07E8
	private void Grow() { }
}
