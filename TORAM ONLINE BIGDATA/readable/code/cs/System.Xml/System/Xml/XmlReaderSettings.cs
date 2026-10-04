// Assembly: System.Xml.dll
// Namespace: System.Xml
public sealed class XmlReaderSettings // TypeDefIndex: 13328
{
	// Fields
	private bool useAsync; // 0x10
	private XmlNameTable nameTable; // 0x18
	private XmlResolver xmlResolver; // 0x20
	private int lineNumberOffset; // 0x28
	private int linePositionOffset; // 0x2C
	private ConformanceLevel conformanceLevel; // 0x30
	private bool checkCharacters; // 0x34
	private long maxCharactersInDocument; // 0x38
	private long maxCharactersFromEntities; // 0x40
	private bool ignoreWhitespace; // 0x48
	private bool ignorePIs; // 0x49
	private bool ignoreComments; // 0x4A
	private DtdProcessing dtdProcessing; // 0x4C
	private ValidationType validationType; // 0x50
	private XmlSchemaValidationFlags validationFlags; // 0x54
	private XmlSchemaSet schemas; // 0x58
	private ValidationEventHandler valEventHandler; // 0x60
	private bool closeInput; // 0x68
	private bool isReadOnly; // 0x69
	[CompilerGenerated]
	private bool <IsXmlResolverSet>k__BackingField; // 0x6A
	private static Nullable<bool> s_enableLegacyXmlSettings; // 0x0

	// Properties
	public bool Async { get; set; }
	public XmlNameTable NameTable { get; set; }
	internal bool IsXmlResolverSet { get; set; }
	public XmlResolver XmlResolver { set; }
	public int LineNumberOffset { get; set; }
	public int LinePositionOffset { get; set; }
	public ConformanceLevel ConformanceLevel { get; set; }
	public bool CheckCharacters { get; set; }
	public long MaxCharactersInDocument { get; set; }
	public long MaxCharactersFromEntities { get; set; }
	public bool IgnoreWhitespace { get; set; }
	public bool IgnoreProcessingInstructions { get; set; }
	public bool IgnoreComments { get; set; }
	public DtdProcessing DtdProcessing { get; set; }
	public bool CloseInput { get; set; }
	public ValidationType ValidationType { get; set; }
	public XmlSchemaValidationFlags ValidationFlags { get; set; }
	public XmlSchemaSet Schemas { get; set; }
	internal bool ReadOnly { set; }

	// Methods

	// RVA: 0x3389F80 Offset: 0x3385F80 VA: 0x3389F80
	public void .ctor() { }

	// RVA: 0x3393B38 Offset: 0x338FB38 VA: 0x3393B38
	public bool get_Async() { }

	// RVA: 0x3389FA0 Offset: 0x3385FA0 VA: 0x3389FA0
	public void set_Async(bool value) { }

	// RVA: 0x3393BF4 Offset: 0x338FBF4 VA: 0x3393BF4
	public XmlNameTable get_NameTable() { }

	// RVA: 0x3393BFC Offset: 0x338FBFC VA: 0x3393BFC
	public void set_NameTable(XmlNameTable value) { }

	[CompilerGenerated]
	// RVA: 0x3393C60 Offset: 0x338FC60 VA: 0x3393C60
	internal bool get_IsXmlResolverSet() { }

	[CompilerGenerated]
	// RVA: 0x3393C68 Offset: 0x338FC68 VA: 0x3393C68
	internal void set_IsXmlResolverSet(bool value) { }

	// RVA: 0x3393C74 Offset: 0x338FC74 VA: 0x3393C74
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x3393CE4 Offset: 0x338FCE4 VA: 0x3393CE4
	internal XmlResolver GetXmlResolver() { }

	// RVA: 0x3393CEC Offset: 0x338FCEC VA: 0x3393CEC
	internal XmlResolver GetXmlResolver_CheckConfig() { }

	// RVA: 0x3393D1C Offset: 0x338FD1C VA: 0x3393D1C
	public int get_LineNumberOffset() { }

	// RVA: 0x3393D24 Offset: 0x338FD24 VA: 0x3393D24
	public void set_LineNumberOffset(int value) { }

	// RVA: 0x3393D80 Offset: 0x338FD80 VA: 0x3393D80
	public int get_LinePositionOffset() { }

	// RVA: 0x3393D88 Offset: 0x338FD88 VA: 0x3393D88
	public void set_LinePositionOffset(int value) { }

	// RVA: 0x3393DE4 Offset: 0x338FDE4 VA: 0x3393DE4
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0x3393DEC Offset: 0x338FDEC VA: 0x3393DEC
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0x3393E98 Offset: 0x338FE98 VA: 0x3393E98
	public bool get_CheckCharacters() { }

	// RVA: 0x3393EA0 Offset: 0x338FEA0 VA: 0x3393EA0
	public void set_CheckCharacters(bool value) { }

	// RVA: 0x3393F00 Offset: 0x338FF00 VA: 0x3393F00
	public long get_MaxCharactersInDocument() { }

	// RVA: 0x3393F08 Offset: 0x338FF08 VA: 0x3393F08
	public void set_MaxCharactersInDocument(long value) { }

	// RVA: 0x3393FB0 Offset: 0x338FFB0 VA: 0x3393FB0
	public long get_MaxCharactersFromEntities() { }

	// RVA: 0x3393FB8 Offset: 0x338FFB8 VA: 0x3393FB8
	public void set_MaxCharactersFromEntities(long value) { }

	// RVA: 0x3394060 Offset: 0x3390060 VA: 0x3394060
	public bool get_IgnoreWhitespace() { }

	// RVA: 0x3394068 Offset: 0x3390068 VA: 0x3394068
	public void set_IgnoreWhitespace(bool value) { }

	// RVA: 0x33940C8 Offset: 0x33900C8 VA: 0x33940C8
	public bool get_IgnoreProcessingInstructions() { }

	// RVA: 0x33940D0 Offset: 0x33900D0 VA: 0x33940D0
	public void set_IgnoreProcessingInstructions(bool value) { }

	// RVA: 0x3394130 Offset: 0x3390130 VA: 0x3394130
	public bool get_IgnoreComments() { }

	// RVA: 0x3394138 Offset: 0x3390138 VA: 0x3394138
	public void set_IgnoreComments(bool value) { }

	// RVA: 0x3394198 Offset: 0x3390198 VA: 0x3394198
	public DtdProcessing get_DtdProcessing() { }

	// RVA: 0x33941A0 Offset: 0x33901A0 VA: 0x33941A0
	public void set_DtdProcessing(DtdProcessing value) { }

	// RVA: 0x339424C Offset: 0x339024C VA: 0x339424C
	public bool get_CloseInput() { }

	// RVA: 0x3394254 Offset: 0x3390254 VA: 0x3394254
	public void set_CloseInput(bool value) { }

	// RVA: 0x33942B4 Offset: 0x33902B4 VA: 0x33942B4
	public ValidationType get_ValidationType() { }

	// RVA: 0x33942BC Offset: 0x33902BC VA: 0x33942BC
	public void set_ValidationType(ValidationType value) { }

	// RVA: 0x3394368 Offset: 0x3390368 VA: 0x3394368
	public XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0x3394370 Offset: 0x3390370 VA: 0x3394370
	public void set_ValidationFlags(XmlSchemaValidationFlags value) { }

	// RVA: 0x339441C Offset: 0x339041C VA: 0x339441C
	public XmlSchemaSet get_Schemas() { }

	// RVA: 0x339448C Offset: 0x339048C VA: 0x339448C
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0x3389F18 Offset: 0x3385F18 VA: 0x3389F18
	public XmlReaderSettings Clone() { }

	// RVA: 0x33944F0 Offset: 0x33904F0 VA: 0x33944F0
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0x33932E8 Offset: 0x338F2E8 VA: 0x33932E8
	internal XmlReader CreateReader(Stream input, Uri baseUri, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0x339351C Offset: 0x338F51C VA: 0x339351C
	internal XmlReader CreateReader(TextReader input, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0x33944F8 Offset: 0x33904F8 VA: 0x33944F8
	internal void set_ReadOnly(bool value) { }

	// RVA: 0x3393B40 Offset: 0x338FB40 VA: 0x3393B40
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0x3393B30 Offset: 0x338FB30 VA: 0x3393B30
	private void Initialize() { }

	// RVA: 0x3394504 Offset: 0x3390504 VA: 0x3394504
	private void Initialize(XmlResolver resolver) { }

	// RVA: 0x33946A8 Offset: 0x33906A8 VA: 0x33946A8
	private static XmlResolver CreateDefaultResolver() { }

	// RVA: 0x33939D8 Offset: 0x338F9D8 VA: 0x33939D8
	internal XmlReader AddValidation(XmlReader reader) { }

	// RVA: 0x33946FC Offset: 0x33906FC VA: 0x33946FC
	private XmlValidatingReaderImpl CreateDtdValidatingReader(XmlReader baseReader) { }

	// RVA: 0x33945B4 Offset: 0x33905B4 VA: 0x33945B4
	internal static bool EnableLegacyXmlSettings() { }
}
