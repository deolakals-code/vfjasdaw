// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal sealed class Parser // TypeDefIndex: 13708
{
	// Fields
	private SchemaType schemaType; // 0x10
	private XmlNameTable nameTable; // 0x18
	private SchemaNames schemaNames; // 0x20
	private ValidationEventHandler eventHandler; // 0x28
	private XmlNamespaceManager namespaceManager; // 0x30
	private XmlReader reader; // 0x38
	private PositionInfo positionInfo; // 0x40
	private bool isProcessNamespaces; // 0x48
	private int schemaXmlDepth; // 0x4C
	private int markupDepth; // 0x50
	private SchemaBuilder builder; // 0x58
	private XmlSchema schema; // 0x60
	private SchemaInfo xdrSchema; // 0x68
	private XmlResolver xmlResolver; // 0x70
	private XmlDocument dummyDocument; // 0x78
	private bool processMarkup; // 0x80
	private XmlNode parentNode; // 0x88
	private XmlNamespaceManager annotationNSManager; // 0x90
	private string xmlns; // 0x98
	private XmlCharType xmlCharType; // 0xA0

	// Properties
	public XmlSchema XmlSchema { get; }
	internal XmlResolver XmlResolver { set; }
	public SchemaInfo XdrSchema { get; }

	// Methods

	// RVA: 0x32E3790 Offset: 0x32DF790 VA: 0x32E3790
	public void .ctor(SchemaType schemaType, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x32E388C Offset: 0x32DF88C VA: 0x32E388C
	public SchemaType Parse(XmlReader reader, string targetNamespace) { }

	// RVA: 0x32E38DC Offset: 0x32DF8DC VA: 0x32E38DC
	public void StartParsing(XmlReader reader, string targetNamespace) { }

	// RVA: 0x32E43C8 Offset: 0x32E03C8 VA: 0x32E43C8
	private bool CheckSchemaRoot(SchemaType rootType, out string code) { }

	// RVA: 0x32E44EC Offset: 0x32E04EC VA: 0x32E44EC
	public SchemaType FinishParsing() { }

	// RVA: 0x32E44F4 Offset: 0x32E04F4 VA: 0x32E44F4
	public XmlSchema get_XmlSchema() { }

	// RVA: 0x32E44FC Offset: 0x32E04FC VA: 0x32E44FC
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x32E4504 Offset: 0x32E0504 VA: 0x32E4504
	public SchemaInfo get_XdrSchema() { }

	// RVA: 0x32E3D14 Offset: 0x32DFD14 VA: 0x32E3D14
	public bool ParseReaderNode() { }

	// RVA: 0x32E450C Offset: 0x32E050C VA: 0x32E450C
	private void ProcessAppInfoDocMarkup(bool root) { }

	// RVA: 0x32E4740 Offset: 0x32E0740 VA: 0x32E4740
	private XmlElement LoadElementNode(bool root) { }

	// RVA: 0x32E4CA0 Offset: 0x32E0CA0 VA: 0x32E4CA0
	private XmlAttribute CreateXmlNsAttribute(string prefix, string value) { }

	// RVA: 0x32E4B2C Offset: 0x32E0B2C VA: 0x32E4B2C
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0x32E4DBC Offset: 0x32E0DBC VA: 0x32E4DBC
	private XmlEntityReference LoadEntityReferenceInAttribute() { }
}
