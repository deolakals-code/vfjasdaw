// Assembly: System.Xml.dll
// Namespace: System.Xml
[DefaultMember("Item")]
internal class XmlAsyncCheckReader : XmlReader // TypeDefIndex: 13313
{
	// Fields
	private readonly XmlReader coreReader; // 0x10
	private Task lastTask; // 0x18

	// Properties
	internal XmlReader CoreReader { get; }
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override Type ValueType { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public override bool CanResolveEntity { get; }
	public override bool CanReadValueChunk { get; }
	public override bool HasAttributes { get; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x3389914 Offset: 0x3385914 VA: 0x3389914
	internal XmlReader get_CoreReader() { }

	// RVA: 0x338991C Offset: 0x338591C VA: 0x338991C
	public static XmlAsyncCheckReader CreateAsyncCheckWrapper(XmlReader reader) { }

	// RVA: 0x3389D40 Offset: 0x3385D40 VA: 0x3389D40
	public void .ctor(XmlReader reader) { }

	// RVA: 0x3389DF8 Offset: 0x3385DF8 VA: 0x3389DF8
	private void CheckAsync() { }

	// RVA: 0x3389E74 Offset: 0x3385E74 VA: 0x3389E74 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x338A000 Offset: 0x3386000 VA: 0x338A000 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x338A028 Offset: 0x3386028 VA: 0x338A028 Slot: 7
	public override string get_Name() { }

	// RVA: 0x338A050 Offset: 0x3386050 VA: 0x338A050 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x338A078 Offset: 0x3386078 VA: 0x338A078 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x338A0A0 Offset: 0x33860A0 VA: 0x338A0A0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x338A0C8 Offset: 0x33860C8 VA: 0x338A0C8 Slot: 11
	public override string get_Value() { }

	// RVA: 0x338A0F0 Offset: 0x33860F0 VA: 0x338A0F0 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x338A118 Offset: 0x3386118 VA: 0x338A118 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x338A144 Offset: 0x3386144 VA: 0x338A144 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x338A170 Offset: 0x3386170 VA: 0x338A170 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x338A19C Offset: 0x338619C VA: 0x338A19C Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0x338A1C8 Offset: 0x33861C8 VA: 0x338A1C8 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x338A1F4 Offset: 0x33861F4 VA: 0x338A1F4 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x338A220 Offset: 0x3386220 VA: 0x338A220 Slot: 19
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x338A24C Offset: 0x338624C VA: 0x338A24C Slot: 20
	public override Type get_ValueType() { }

	// RVA: 0x338A278 Offset: 0x3386278 VA: 0x338A278 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x338A2A4 Offset: 0x33862A4 VA: 0x338A2A4 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x338A2E0 Offset: 0x33862E0 VA: 0x338A2E0 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x338A324 Offset: 0x3386324 VA: 0x338A324 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x338A360 Offset: 0x3386360 VA: 0x338A360 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x338A39C Offset: 0x338639C VA: 0x338A39C Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x338A3D8 Offset: 0x33863D8 VA: 0x338A3D8 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x338A404 Offset: 0x3386404 VA: 0x338A404 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x338A430 Offset: 0x3386430 VA: 0x338A430 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x338A45C Offset: 0x338645C VA: 0x338A45C Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x338A488 Offset: 0x3386488 VA: 0x338A488 Slot: 31
	public override bool Read() { }

	// RVA: 0x338A4B4 Offset: 0x33864B4 VA: 0x338A4B4 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x338A4E0 Offset: 0x33864E0 VA: 0x338A4E0 Slot: 33
	public override void Close() { }

	// RVA: 0x338A50C Offset: 0x338650C VA: 0x338A50C Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x338A538 Offset: 0x3386538 VA: 0x338A538 Slot: 35
	public override void Skip() { }

	// RVA: 0x338A564 Offset: 0x3386564 VA: 0x338A564 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x338A590 Offset: 0x3386590 VA: 0x338A590 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x338A5CC Offset: 0x33865CC VA: 0x338A5CC Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0x338A5F8 Offset: 0x33865F8 VA: 0x338A5F8 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x338A624 Offset: 0x3386624 VA: 0x338A624 Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x338A650 Offset: 0x3386650 VA: 0x338A650 Slot: 41
	public override int ReadValueChunk(char[] buffer, int index, int count) { }

	// RVA: 0x338A6A4 Offset: 0x33866A4 VA: 0x338A6A4 Slot: 42
	public override string ReadString() { }

	// RVA: 0x338A6D0 Offset: 0x33866D0 VA: 0x338A6D0 Slot: 43
	public override XmlNodeType MoveToContent() { }

	// RVA: 0x338A6FC Offset: 0x33866FC VA: 0x338A6FC Slot: 44
	public override void ReadStartElement() { }

	// RVA: 0x338A728 Offset: 0x3386728 VA: 0x338A728 Slot: 45
	public override string ReadElementString() { }

	// RVA: 0x338A754 Offset: 0x3386754 VA: 0x338A754 Slot: 46
	public override void ReadEndElement() { }

	// RVA: 0x338A780 Offset: 0x3386780 VA: 0x338A780 Slot: 47
	public override bool IsStartElement(string localname, string ns) { }

	// RVA: 0x338A7C4 Offset: 0x33867C4 VA: 0x338A7C4 Slot: 48
	public override string ReadInnerXml() { }

	// RVA: 0x338A7F0 Offset: 0x33867F0 VA: 0x338A7F0 Slot: 49
	public override bool get_HasAttributes() { }

	// RVA: 0x338A81C Offset: 0x338681C VA: 0x338A81C Slot: 50
	protected override void Dispose(bool disposing) { }

	// RVA: 0x338A860 Offset: 0x3386860 VA: 0x338A860 Slot: 51
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x338A88C Offset: 0x338688C VA: 0x338A88C Slot: 52
	internal override IDtdInfo get_DtdInfo() { }
}
