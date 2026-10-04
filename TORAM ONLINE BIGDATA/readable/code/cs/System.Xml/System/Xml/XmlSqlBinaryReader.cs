// Assembly: System.Xml.dll
// Namespace: System.Xml
internal sealed class XmlSqlBinaryReader : XmlReader, IXmlNamespaceResolver // TypeDefIndex: 13270
{
	// Fields
	internal static readonly Type TypeOfObject; // 0x0
	internal static readonly Type TypeOfString; // 0x8
	private static Type[] TokenTypeMap; // 0x10
	private static byte[] XsdKatmaiTimeScaleToValueLengthMap; // 0x18
	private static ReadState[] ScanState2ReadState; // 0x20
	private Stream inStrm; // 0x10
	private byte[] data; // 0x18
	private int pos; // 0x20
	private int mark; // 0x24
	private int end; // 0x28
	private long offset; // 0x30
	private bool eof; // 0x38
	private bool sniffed; // 0x39
	private bool isEmpty; // 0x3A
	private int docState; // 0x3C
	private XmlSqlBinaryReader.SymbolTables symbolTables; // 0x40
	private XmlNameTable xnt; // 0x60
	private bool xntFromSettings; // 0x68
	private string xml; // 0x70
	private string xmlns; // 0x78
	private string nsxmlns; // 0x80
	private string baseUri; // 0x88
	private XmlSqlBinaryReader.ScanState state; // 0x90
	private XmlNodeType nodetype; // 0x94
	private BinXmlToken token; // 0x98
	private int attrIndex; // 0x9C
	private XmlSqlBinaryReader.QName qnameOther; // 0xA0
	private XmlSqlBinaryReader.QName qnameElement; // 0xB8
	private XmlNodeType parentNodeType; // 0xD0
	private XmlSqlBinaryReader.ElemInfo[] elementStack; // 0xD8
	private int elemDepth; // 0xE0
	private XmlSqlBinaryReader.AttrInfo[] attributes; // 0xE8
	private int[] attrHashTbl; // 0xF0
	private int attrCount; // 0xF8
	private int posAfterAttrs; // 0xFC
	private bool xmlspacePreserve; // 0x100
	private int tokLen; // 0x104
	private int tokDataPos; // 0x108
	private bool hasTypedValue; // 0x10C
	private Type valueType; // 0x110
	private string stringValue; // 0x118
	private Dictionary<string, XmlSqlBinaryReader.NamespaceDecl> namespaces; // 0x120
	private XmlSqlBinaryReader.NestedBinXml prevNameInfo; // 0x128
	private XmlReader textXmlReader; // 0x130
	private bool closeInput; // 0x138
	private bool checkCharacters; // 0x139
	private bool ignoreWhitespace; // 0x13A
	private bool ignorePIs; // 0x13B
	private bool ignoreComments; // 0x13C
	private DtdProcessing dtdProcessing; // 0x140
	private SecureStringHasher hasher; // 0x148
	private XmlCharType xmlCharType; // 0x150
	private Encoding unicode; // 0x158
	private byte version; // 0x160

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override Type ValueType { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override XmlNameTable NameTable { get; }
	public override ReadState ReadState { get; }

	// Methods

	// RVA: 0x32AE274 Offset: 0x32AA274 VA: 0x32AE274
	public void .ctor(Stream stream, byte[] data, int len, string baseUri, bool closeInput, XmlReaderSettings settings) { }

	// RVA: 0x32AF610 Offset: 0x32AB610 VA: 0x32AF610 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x32AF72C Offset: 0x32AB72C VA: 0x32AF72C Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x32AF734 Offset: 0x32AB734 VA: 0x32AF734 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x32AF73C Offset: 0x32AB73C VA: 0x32AF73C Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x32AF744 Offset: 0x32AB744 VA: 0x32AF744 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x32AF74C Offset: 0x32AB74C VA: 0x32AF74C Slot: 11
	public override string get_Value() { }

	// RVA: 0x32B0438 Offset: 0x32AC438 VA: 0x32B0438 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x32B04DC Offset: 0x32AC4DC VA: 0x32B04DC Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x32B04E4 Offset: 0x32AC4E4 VA: 0x32B04E4 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x32B0508 Offset: 0x32AC508 VA: 0x32B0508 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x32B0588 Offset: 0x32AC588 VA: 0x32B0588 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x32B0648 Offset: 0x32AC648 VA: 0x32B0648 Slot: 20
	public override Type get_ValueType() { }

	// RVA: 0x32B0650 Offset: 0x32AC650 VA: 0x32B0650 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x32B06A4 Offset: 0x32AC6A4 VA: 0x32B06A4 Slot: 23
	public override string GetAttribute(string name, string ns) { }

	// RVA: 0x32B0854 Offset: 0x32AC854 VA: 0x32B0854 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x32B09A0 Offset: 0x32AC9A0 VA: 0x32B09A0 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x32B0A30 Offset: 0x32ACA30 VA: 0x32B0A30 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x32B0BA8 Offset: 0x32ACBA8 VA: 0x32B0BA8 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x32B0C4C Offset: 0x32ACC4C VA: 0x32B0C4C Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x32B0CC4 Offset: 0x32ACCC4 VA: 0x32B0CC4 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x32B0D48 Offset: 0x32ACD48 VA: 0x32B0D48 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x32B0E18 Offset: 0x32ACE18 VA: 0x32B0E18 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x32B0E28 Offset: 0x32ACE28 VA: 0x32B0E28 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x32B117C Offset: 0x32AD17C VA: 0x32B117C Slot: 33
	public override void Close() { }

	// RVA: 0x32B121C Offset: 0x32AD21C VA: 0x32B121C Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x32B1224 Offset: 0x32AD224 VA: 0x32B1224 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x32B12D8 Offset: 0x32AD2D8 VA: 0x32B12D8 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x32B1310 Offset: 0x32AD310 VA: 0x32B1310 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x32B1390 Offset: 0x32AD390 VA: 0x32B1390 Slot: 31
	public override bool Read() { }

	// RVA: 0x32B1DC0 Offset: 0x32ADDC0 VA: 0x32B1DC0 Slot: 53
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x32B2168 Offset: 0x32AE168 VA: 0x32B2168 Slot: 55
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x32B2304 Offset: 0x32AE304 VA: 0x32B2304
	private void VerifyVersion(int requiredVersion, BinXmlToken token) { }

	// RVA: 0x32AE914 Offset: 0x32AA914 VA: 0x32AE914
	private void AddInitNamespace(string prefix, string uri) { }

	// RVA: 0x32B2414 Offset: 0x32AE414 VA: 0x32B2414
	private void AddName() { }

	// RVA: 0x32B2600 Offset: 0x32AE600 VA: 0x32B2600
	private void AddQName() { }

	// RVA: 0x32B2978 Offset: 0x32AE978 VA: 0x32B2978
	private void NameFlush() { }

	// RVA: 0x32B29C8 Offset: 0x32AE9C8 VA: 0x32B29C8
	private void SkipExtn() { }

	// RVA: 0x32B2A9C Offset: 0x32AEA9C VA: 0x32B2A9C
	private int ReadQNameRef() { }

	// RVA: 0x32B28A8 Offset: 0x32AE8A8 VA: 0x32B28A8
	private int ReadNameRef() { }

	// RVA: 0x32B2B28 Offset: 0x32AEB28 VA: 0x32B2B28
	private bool FillAllowEOF() { }

	// RVA: 0x32B2D6C Offset: 0x32AED6C VA: 0x32B2D6C
	private void Fill_(int require) { }

	// RVA: 0x32B2A80 Offset: 0x32AEA80 VA: 0x32B2A80
	private void Fill(int require) { }

	// RVA: 0x32B2E58 Offset: 0x32AEE58 VA: 0x32B2E58
	private byte ReadByte() { }

	// RVA: 0x32B2EB4 Offset: 0x32AEEB4 VA: 0x32B2EB4
	private ushort ReadUShort() { }

	// RVA: 0x32B2A54 Offset: 0x32AEA54 VA: 0x32B2A54
	private int ParseMB32() { }

	// RVA: 0x32B2F28 Offset: 0x32AEF28 VA: 0x32B2F28
	private int ParseMB32_(byte b) { }

	// RVA: 0x32B2FC0 Offset: 0x32AEFC0 VA: 0x32B2FC0
	private int ParseMB32(int pos) { }

	// RVA: 0x32B30AC Offset: 0x32AF0AC VA: 0x32B30AC
	private int ParseMB64() { }

	// RVA: 0x32B30D8 Offset: 0x32AF0D8 VA: 0x32B30D8
	private BinXmlToken PeekToken() { }

	// RVA: 0x32B3140 Offset: 0x32AF140 VA: 0x32B3140
	private BinXmlToken ReadToken() { }

	// RVA: 0x32B31B0 Offset: 0x32AF1B0 VA: 0x32B31B0
	private BinXmlToken NextToken2(BinXmlToken token) { }

	// RVA: 0x32B3228 Offset: 0x32AF228 VA: 0x32B3228
	private BinXmlToken NextToken1() { }

	// RVA: 0x32B32A0 Offset: 0x32AF2A0 VA: 0x32B32A0
	private BinXmlToken NextToken() { }

	// RVA: 0x32B3304 Offset: 0x32AF304 VA: 0x32B3304
	private BinXmlToken PeekNextToken() { }

	// RVA: 0x32B0F9C Offset: 0x32ACF9C VA: 0x32B0F9C
	private BinXmlToken RescanNextToken() { }

	// RVA: 0x32B253C Offset: 0x32AE53C VA: 0x32B253C
	private string ParseText() { }

	// RVA: 0x32B332C Offset: 0x32AF32C VA: 0x32B332C
	private int ScanText(out int start) { }

	// RVA: 0x32AF878 Offset: 0x32AB878 VA: 0x32AF878
	private string GetString(int pos, int cch) { }

	// RVA: 0x32B33E4 Offset: 0x32AF3E4 VA: 0x32B33E4
	private string GetStringAligned(byte[] data, int offset, int cch) { }

	// RVA: 0x32B0314 Offset: 0x32AC314 VA: 0x32B0314
	private string GetAttributeText(int i) { }

	// RVA: 0x32B07CC Offset: 0x32AC7CC VA: 0x32B07CC
	private int LocateAttribute(string name, string ns) { }

	// RVA: 0x32B08C0 Offset: 0x32AC8C0 VA: 0x32B08C0
	private int LocateAttribute(string name) { }

	// RVA: 0x32B0AC8 Offset: 0x32ACAC8 VA: 0x32B0AC8
	private void PositionOnAttribute(int i) { }

	// RVA: 0x32B34B0 Offset: 0x32AF4B0 VA: 0x32B34B0
	private void GrowElements() { }

	// RVA: 0x32B3540 Offset: 0x32AF540 VA: 0x32B3540
	private void GrowAttributes() { }

	// RVA: 0x32B35D0 Offset: 0x32AF5D0 VA: 0x32B35D0
	private void ClearAttributes() { }

	// RVA: 0x32B35E0 Offset: 0x32AF5E0 VA: 0x32B35E0
	private void PushNamespace(string prefix, string ns, bool implied) { }

	// RVA: 0x32B38FC Offset: 0x32AF8FC VA: 0x32B38FC
	private void PopNamespaces(XmlSqlBinaryReader.NamespaceDecl firstInScopeChain) { }

	// RVA: 0x32B39C8 Offset: 0x32AF9C8 VA: 0x32B39C8
	private void GenerateImpliedXmlnsAttrs() { }

	// RVA: 0x32B1558 Offset: 0x32AD558 VA: 0x32B1558
	private bool ReadInit(bool skipXmlDecl) { }

	// RVA: 0x32B3BE4 Offset: 0x32AFBE4 VA: 0x32B3BE4
	private void ScanAttributes() { }

	// RVA: 0x32B43D0 Offset: 0x32B03D0 VA: 0x32B43D0
	private void SimpleCheckForDuplicateAttributes() { }

	// RVA: 0x32B453C Offset: 0x32B053C VA: 0x32B453C
	private void HashCheckForDuplicateAttributes() { }

	// RVA: 0x32AFAF4 Offset: 0x32ABAF4 VA: 0x32AFAF4
	private string XmlDeclValue() { }

	// RVA: 0x32AF9E4 Offset: 0x32AB9E4 VA: 0x32AF9E4
	private string CDATAValue() { }

	// RVA: 0x32B48B0 Offset: 0x32B08B0 VA: 0x32B48B0
	private void FinishCDATA() { }

	// RVA: 0x32B4954 Offset: 0x32B0954 VA: 0x32B4954
	private void FinishEndElement() { }

	// RVA: 0x32B1A70 Offset: 0x32ADA70 VA: 0x32B1A70
	private bool ReadDoc() { }

	// RVA: 0x32B5594 Offset: 0x32B1594 VA: 0x32B5594
	private void ImplReadData(BinXmlToken tokenType) { }

	// RVA: 0x32B49DC Offset: 0x32B09DC VA: 0x32B49DC
	private void ImplReadElement() { }

	// RVA: 0x32B4C84 Offset: 0x32B0C84 VA: 0x32B4C84
	private void ImplReadEndElement() { }

	// RVA: 0x32B4D64 Offset: 0x32B0D64 VA: 0x32B4D64
	private void ImplReadDoctype() { }

	// RVA: 0x32B5054 Offset: 0x32B1054 VA: 0x32B5054
	private void ImplReadPI() { }

	// RVA: 0x32B50C0 Offset: 0x32B10C0 VA: 0x32B50C0
	private void ImplReadComment() { }

	// RVA: 0x32B50EC Offset: 0x32B10EC VA: 0x32B50EC
	private void ImplReadCDATA() { }

	// RVA: 0x32B5120 Offset: 0x32B1120 VA: 0x32B5120
	private void ImplReadNest() { }

	// RVA: 0x32B51D0 Offset: 0x32B11D0 VA: 0x32B51D0
	private void ImplReadEndNest() { }

	// RVA: 0x32B5220 Offset: 0x32B1220 VA: 0x32B5220
	private void ImplReadXmlText() { }

	// RVA: 0x32B5820 Offset: 0x32B1820 VA: 0x32B5820
	private void UpdateFromTextReader() { }

	// RVA: 0x32B0AAC Offset: 0x32ACAAC VA: 0x32B0AAC
	private bool UpdateFromTextReader(bool needUpdate) { }

	// RVA: 0x32B5714 Offset: 0x32B1714 VA: 0x32B5714
	private void CheckAllowContent() { }

	// RVA: 0x32AE9EC Offset: 0x32AA9EC VA: 0x32AE9EC
	private void GenerateTokenTypeMap() { }

	// RVA: 0x32B1090 Offset: 0x32AD090 VA: 0x32B1090
	private Type GetValueType(BinXmlToken token) { }

	// RVA: 0x32B1084 Offset: 0x32AD084 VA: 0x32B1084
	private void ReScanOverValue(BinXmlToken token) { }

	// RVA: 0x32B4224 Offset: 0x32B0224 VA: 0x32B4224
	private XmlNodeType ScanOverValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0x32B5B54 Offset: 0x32B1B54 VA: 0x32B5B54
	private XmlNodeType ScanOverAnyValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0x32B58F8 Offset: 0x32B18F8 VA: 0x32B58F8
	private XmlNodeType CheckText(bool attr) { }

	// RVA: 0x32B5ABC Offset: 0x32B1ABC VA: 0x32B5ABC
	private XmlNodeType CheckTextIsWS() { }

	// RVA: 0x32B5F5C Offset: 0x32B1F5C VA: 0x32B5F5C
	private void CheckValueTokenBounds() { }

	// RVA: 0x32B5E74 Offset: 0x32B1E74 VA: 0x32B5E74
	private int GetXsdKatmaiTokenLength(BinXmlToken token) { }

	// RVA: 0x32B5FBC Offset: 0x32B1FBC VA: 0x32B5FBC
	private int XsdKatmaiTimeScaleToValueLength(byte scale) { }

	// RVA: 0x32B6090 Offset: 0x32B2090 VA: 0x32B6090
	private long ValueAsLong() { }

	// RVA: 0x32B68B0 Offset: 0x32B28B0 VA: 0x32B68B0
	private ulong ValueAsULong() { }

	// RVA: 0x32B66CC Offset: 0x32B26CC VA: 0x32B66CC
	private Decimal ValueAsDecimal() { }

	// RVA: 0x32B6598 Offset: 0x32B2598 VA: 0x32B6598
	private double ValueAsDouble() { }

	// RVA: 0x32B6A4C Offset: 0x32B2A4C VA: 0x32B6A4C
	private string ValueAsDateTimeString() { }

	// RVA: 0x32AFC34 Offset: 0x32ABC34 VA: 0x32AFC34
	private string ValueAsString(BinXmlToken token) { }

	// RVA: 0x32B6288 Offset: 0x32B2288 VA: 0x32B6288
	private short GetInt16(int pos) { }

	// RVA: 0x32B6410 Offset: 0x32B2410 VA: 0x32B6410
	private ushort GetUInt16(int pos) { }

	// RVA: 0x32B62CC Offset: 0x32B22CC VA: 0x32B62CC
	private int GetInt32(int pos) { }

	// RVA: 0x32B6454 Offset: 0x32B2454 VA: 0x32B6454
	private uint GetUInt32(int pos) { }

	// RVA: 0x32B6340 Offset: 0x32B2340 VA: 0x32B6340
	private long GetInt64(int pos) { }

	// RVA: 0x32B64C8 Offset: 0x32B24C8 VA: 0x32B64C8
	private ulong GetUInt64(int pos) { }

	// RVA: 0x32B6900 Offset: 0x32B2900 VA: 0x32B6900
	private float GetSingle(int offset) { }

	// RVA: 0x32B6978 Offset: 0x32B2978 VA: 0x32B6978
	private double GetDouble(int offset) { }

	// RVA: 0x32B233C Offset: 0x32AE33C VA: 0x32B233C
	private Exception ThrowUnexpectedToken(BinXmlToken token) { }

	// RVA: 0x32B2DE4 Offset: 0x32AEDE4 VA: 0x32B2DE4
	private Exception ThrowXmlException(string res) { }

	// RVA: 0x32B4138 Offset: 0x32B0138 VA: 0x32B4138
	private Exception ThrowXmlException(string res, string arg1, string arg2) { }

	// RVA: 0x32B434C Offset: 0x32B034C VA: 0x32B434C
	private Exception ThrowNotSupported(string res) { }

	// RVA: 0x32B6D70 Offset: 0x32B2D70 VA: 0x32B6D70
	private static void .cctor() { }
}
