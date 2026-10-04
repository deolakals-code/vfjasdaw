// Assembly: System.Xml.dll
// Namespace: System.Xml
public sealed class XmlWriterSettings // TypeDefIndex: 13379
{
	// Fields
	private bool useAsync; // 0x10
	private Encoding encoding; // 0x18
	private bool omitXmlDecl; // 0x20
	private NewLineHandling newLineHandling; // 0x24
	private string newLineChars; // 0x28
	private TriState indent; // 0x30
	private string indentChars; // 0x38
	private bool newLineOnAttributes; // 0x40
	private bool closeOutput; // 0x41
	private NamespaceHandling namespaceHandling; // 0x44
	private ConformanceLevel conformanceLevel; // 0x48
	private bool checkCharacters; // 0x4C
	private bool writeEndDocumentOnClose; // 0x4D
	private XmlOutputMethod outputMethod; // 0x50
	private List<XmlQualifiedName> cdataSections; // 0x58
	private bool doNotEscapeUriAttributes; // 0x60
	private bool mergeCDataSections; // 0x61
	private string mediaType; // 0x68
	private string docTypeSystem; // 0x70
	private string docTypePublic; // 0x78
	private XmlStandalone standalone; // 0x80
	private bool autoXmlDecl; // 0x84
	private bool isReadOnly; // 0x85

	// Properties
	public bool Async { get; }
	public Encoding Encoding { get; }
	public bool OmitXmlDeclaration { get; set; }
	public NewLineHandling NewLineHandling { get; }
	public string NewLineChars { get; }
	public bool Indent { get; set; }
	public string IndentChars { get; }
	public bool NewLineOnAttributes { get; }
	public bool CloseOutput { get; }
	public ConformanceLevel ConformanceLevel { get; set; }
	public bool CheckCharacters { get; }
	public NamespaceHandling NamespaceHandling { get; set; }
	public bool WriteEndDocumentOnClose { get; }
	public XmlOutputMethod OutputMethod { get; set; }
	internal List<XmlQualifiedName> CDataSectionElements { get; }
	public bool DoNotEscapeUriAttributes { get; }
	internal bool MergeCDataSections { get; }
	internal string MediaType { get; }
	internal string DocTypeSystem { get; }
	internal string DocTypePublic { get; }
	internal XmlStandalone Standalone { get; }
	internal bool AutoXmlDeclaration { get; }
	internal TriState IndentInternal { get; }
	internal bool IsQuerySpecific { get; }
	internal bool ReadOnly { set; }

	// Methods

	// RVA: 0x33AA050 Offset: 0x33A6050 VA: 0x33AA050
	public void .ctor() { }

	// RVA: 0x33AA9F4 Offset: 0x33A69F4 VA: 0x33AA9F4
	public bool get_Async() { }

	// RVA: 0x33AA9FC Offset: 0x33A69FC VA: 0x33AA9FC
	public Encoding get_Encoding() { }

	// RVA: 0x33AAA04 Offset: 0x33A6A04 VA: 0x33AAA04
	public bool get_OmitXmlDeclaration() { }

	// RVA: 0x33AAA0C Offset: 0x33A6A0C VA: 0x33AAA0C
	public void set_OmitXmlDeclaration(bool value) { }

	// RVA: 0x33AAB20 Offset: 0x33A6B20 VA: 0x33AAB20
	public NewLineHandling get_NewLineHandling() { }

	// RVA: 0x33AAB28 Offset: 0x33A6B28 VA: 0x33AAB28
	public string get_NewLineChars() { }

	// RVA: 0x33AAB30 Offset: 0x33A6B30 VA: 0x33AAB30
	public bool get_Indent() { }

	// RVA: 0x33AAB40 Offset: 0x33A6B40 VA: 0x33AAB40
	public void set_Indent(bool value) { }

	// RVA: 0x33AABA8 Offset: 0x33A6BA8 VA: 0x33AABA8
	public string get_IndentChars() { }

	// RVA: 0x33AABB0 Offset: 0x33A6BB0 VA: 0x33AABB0
	public bool get_NewLineOnAttributes() { }

	// RVA: 0x33AABB8 Offset: 0x33A6BB8 VA: 0x33AABB8
	public bool get_CloseOutput() { }

	// RVA: 0x33AABC0 Offset: 0x33A6BC0 VA: 0x33AABC0
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0x33AABC8 Offset: 0x33A6BC8 VA: 0x33AABC8
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0x33AAC74 Offset: 0x33A6C74 VA: 0x33AAC74
	public bool get_CheckCharacters() { }

	// RVA: 0x33AAC7C Offset: 0x33A6C7C VA: 0x33AAC7C
	public NamespaceHandling get_NamespaceHandling() { }

	// RVA: 0x33AAC84 Offset: 0x33A6C84 VA: 0x33AAC84
	public void set_NamespaceHandling(NamespaceHandling value) { }

	// RVA: 0x33AAD30 Offset: 0x33A6D30 VA: 0x33AAD30
	public bool get_WriteEndDocumentOnClose() { }

	// RVA: 0x33AAD38 Offset: 0x33A6D38 VA: 0x33AAD38
	public XmlOutputMethod get_OutputMethod() { }

	// RVA: 0x33AAD40 Offset: 0x33A6D40 VA: 0x33AAD40
	internal void set_OutputMethod(XmlOutputMethod value) { }

	// RVA: 0x33AAD48 Offset: 0x33A6D48 VA: 0x33AAD48
	public XmlWriterSettings Clone() { }

	// RVA: 0x33AAE1C Offset: 0x33A6E1C VA: 0x33AAE1C
	internal List<XmlQualifiedName> get_CDataSectionElements() { }

	// RVA: 0x33AAE24 Offset: 0x33A6E24 VA: 0x33AAE24
	public bool get_DoNotEscapeUriAttributes() { }

	// RVA: 0x33AAE2C Offset: 0x33A6E2C VA: 0x33AAE2C
	internal bool get_MergeCDataSections() { }

	// RVA: 0x33AAE34 Offset: 0x33A6E34 VA: 0x33AAE34
	internal string get_MediaType() { }

	// RVA: 0x33AAE3C Offset: 0x33A6E3C VA: 0x33AAE3C
	internal string get_DocTypeSystem() { }

	// RVA: 0x33AAE44 Offset: 0x33A6E44 VA: 0x33AAE44
	internal string get_DocTypePublic() { }

	// RVA: 0x33AAE4C Offset: 0x33A6E4C VA: 0x33AAE4C
	internal XmlStandalone get_Standalone() { }

	// RVA: 0x33AAE54 Offset: 0x33A6E54 VA: 0x33AAE54
	internal bool get_AutoXmlDeclaration() { }

	// RVA: 0x33AAE5C Offset: 0x33A6E5C VA: 0x33AAE5C
	internal TriState get_IndentInternal() { }

	// RVA: 0x33AAE64 Offset: 0x33A6E64 VA: 0x33AAE64
	internal bool get_IsQuerySpecific() { }

	// RVA: 0x33AA0E0 Offset: 0x33A60E0 VA: 0x33AA0E0
	internal XmlWriter CreateWriter(Stream output) { }

	// RVA: 0x33AA5C0 Offset: 0x33A65C0 VA: 0x33AA5C0
	internal XmlWriter CreateWriter(TextWriter output) { }

	// RVA: 0x33AAED4 Offset: 0x33A6ED4 VA: 0x33AAED4
	internal void set_ReadOnly(bool value) { }

	// RVA: 0x33AAA6C Offset: 0x33A6A6C VA: 0x33AAA6C
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0x33AA8C4 Offset: 0x33A68C4 VA: 0x33AA8C4
	private void Initialize() { }
}
