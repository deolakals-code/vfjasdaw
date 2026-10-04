// Assembly: System.Xml.dll
// Namespace: System.Xml
[Obsolete("Use XmlReader created by XmlReader.Create() method using appropriate XmlReaderSettings instead. https://go.microsoft.com/fwlink/?linkid=14202")]
public class XmlValidatingReader : XmlReader // TypeDefIndex: 13357
{
	// Fields
	private XmlValidatingReaderImpl impl; // 0x10

	// Properties
	public override XmlNodeType NodeType { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public bool Namespaces { get; }

	// Methods

	// RVA: 0x33A0074 Offset: 0x339C074 VA: 0x33A0074 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x33A0094 Offset: 0x339C094 VA: 0x33A0094 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x33A00B4 Offset: 0x339C0B4 VA: 0x33A00B4 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x33A00D4 Offset: 0x339C0D4 VA: 0x33A00D4 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x33A00F4 Offset: 0x339C0F4 VA: 0x33A00F4 Slot: 11
	public override string get_Value() { }

	// RVA: 0x33A0114 Offset: 0x339C114 VA: 0x33A0114 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x33A0134 Offset: 0x339C134 VA: 0x33A0134 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x33A0158 Offset: 0x339C158 VA: 0x33A0158 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x33A017C Offset: 0x339C17C VA: 0x33A017C Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x33A01A0 Offset: 0x339C1A0 VA: 0x33A01A0 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x33A01C4 Offset: 0x339C1C4 VA: 0x33A01C4 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x33A01E8 Offset: 0x339C1E8 VA: 0x33A01E8 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x33A020C Offset: 0x339C20C VA: 0x33A020C Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x33A0230 Offset: 0x339C230 VA: 0x33A0230 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x33A0254 Offset: 0x339C254 VA: 0x33A0254 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x33A0278 Offset: 0x339C278 VA: 0x33A0278 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x33A029C Offset: 0x339C29C VA: 0x33A029C Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x33A02C0 Offset: 0x339C2C0 VA: 0x33A02C0 Slot: 31
	public override bool Read() { }

	// RVA: 0x33A02E4 Offset: 0x339C2E4 VA: 0x33A02E4 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x33A0308 Offset: 0x339C308 VA: 0x33A0308 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x33A032C Offset: 0x339C32C VA: 0x33A032C Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x33A0350 Offset: 0x339C350 VA: 0x33A0350 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x33A0388 Offset: 0x339C388 VA: 0x33A0388 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x33A03AC Offset: 0x339C3AC VA: 0x33A03AC
	public bool get_Namespaces() { }
}
