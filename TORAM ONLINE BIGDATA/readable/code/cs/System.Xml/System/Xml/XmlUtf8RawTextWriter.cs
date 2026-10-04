// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class XmlUtf8RawTextWriter : XmlRawWriter // TypeDefIndex: 13355
{
	// Fields
	private readonly bool useAsync; // 0x28
	protected byte[] bufBytes; // 0x30
	protected Stream stream; // 0x38
	protected Encoding encoding; // 0x40
	protected XmlCharType xmlCharType; // 0x48
	protected int bufPos; // 0x50
	protected int textPos; // 0x54
	protected int contentPos; // 0x58
	protected int cdataPos; // 0x5C
	protected int attrEndPos; // 0x60
	protected int bufLen; // 0x64
	protected bool writeToNull; // 0x68
	protected bool hadDoubleBracket; // 0x69
	protected bool inAttributeValue; // 0x6A
	protected NewLineHandling newLineHandling; // 0x6C
	protected bool closeOutput; // 0x70
	protected bool omitXmlDeclaration; // 0x71
	protected string newLineChars; // 0x78
	protected bool checkCharacters; // 0x80
	protected XmlStandalone standalone; // 0x84
	protected XmlOutputMethod outputMethod; // 0x88
	protected bool autoXmlDeclaration; // 0x8C
	protected bool mergeCDataSections; // 0x8D

	// Properties
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x339C88C Offset: 0x339888C VA: 0x339C88C
	protected void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x339CCD8 Offset: 0x3398CD8 VA: 0x339CCD8
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x339CE40 Offset: 0x3398E40 VA: 0x339CE40 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x339CFD0 Offset: 0x3398FD0 VA: 0x339CFD0 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x339D048 Offset: 0x3399048 VA: 0x339D048 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x339D238 Offset: 0x3399238 VA: 0x339D238 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x339D2DC Offset: 0x33992DC VA: 0x339D2DC Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x339D324 Offset: 0x3399324 VA: 0x339D324 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x339D47C Offset: 0x339947C VA: 0x339D47C Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x339D570 Offset: 0x3399570 VA: 0x339D570 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x339D67C Offset: 0x339967C VA: 0x339D67C Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x339D6C8 Offset: 0x33996C8 VA: 0x339D6C8 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x339D71C Offset: 0x339971C VA: 0x339D71C Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x339D724 Offset: 0x3399724 VA: 0x339D724 Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x339D818 Offset: 0x3399818 VA: 0x339D818 Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x339D864 Offset: 0x3399864 VA: 0x339D864 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x339DDF4 Offset: 0x3399DF4 VA: 0x339DDF4 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x339E278 Offset: 0x339A278 VA: 0x339E278 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x339E3A0 Offset: 0x339A3A0 VA: 0x339E3A0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x339E440 Offset: 0x339A440 VA: 0x339E440 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x339E60C Offset: 0x339A60C VA: 0x339E60C Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x339EBFC Offset: 0x339ABFC VA: 0x339EBFC Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x339EC4C Offset: 0x339AC4C VA: 0x339EC4C Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x339ED98 Offset: 0x339AD98 VA: 0x339ED98 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x339EDD8 Offset: 0x339ADD8 VA: 0x339EDD8 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x339F058 Offset: 0x339B058 VA: 0x339F058 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x339F0A0 Offset: 0x339B0A0 VA: 0x339F0A0 Slot: 28
	public override void Close() { }

	// RVA: 0x339F208 Offset: 0x339B208 VA: 0x339F208 Slot: 29
	public override void Flush() { }

	// RVA: 0x339F244 Offset: 0x339B244 VA: 0x339F244 Slot: 48
	protected virtual void FlushBuffer() { }

	// RVA: 0x339F204 Offset: 0x339B204 VA: 0x339F204
	private void FlushEncoder() { }

	// RVA: 0x339E65C Offset: 0x339A65C VA: 0x339E65C
	protected void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x339E944 Offset: 0x339A944 VA: 0x339E944
	protected void WriteElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x339CF94 Offset: 0x3398F94 VA: 0x339CF94
	protected void RawText(string s) { }

	// RVA: 0x339F754 Offset: 0x339B754 VA: 0x339F754
	protected void RawText(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x339EE18 Offset: 0x339AE18 VA: 0x339EE18
	protected void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x339DF4C Offset: 0x3399F4C VA: 0x339DF4C
	protected void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x339DAC0 Offset: 0x3399AC0 VA: 0x339DAC0
	protected void WriteCDataSection(string text) { }

	// RVA: 0x339F914 Offset: 0x339B914 VA: 0x339F914
	private static bool IsSurrogateByte(byte b) { }

	// RVA: 0x339F47C Offset: 0x339B47C VA: 0x339F47C
	private static byte* EncodeSurrogate(char* pSrc, char* pSrcEnd, byte* pDst) { }

	// RVA: 0x339F60C Offset: 0x339B60C VA: 0x339F60C
	private byte* InvalidXmlChar(int ch, byte* pDst, bool entitize) { }

	// RVA: 0x339F9D0 Offset: 0x339B9D0 VA: 0x339F9D0
	internal void EncodeChar(ref char* pSrc, char* pSrcEnd, ref byte* pDst) { }

	// RVA: 0x339F6C0 Offset: 0x339B6C0 VA: 0x339F6C0
	internal static byte* EncodeMultibyteUTF8(int ch, byte* pDst) { }

	// RVA: 0x339FAAC Offset: 0x339BAAC VA: 0x339FAAC
	internal static void CharToUTF8(ref char* pSrc, char* pSrcEnd, ref byte* pDst) { }

	// RVA: 0x339F700 Offset: 0x339B700 VA: 0x339F700
	protected byte* WriteNewLine(byte* pDst) { }

	// RVA: 0x339F3DC Offset: 0x339B3DC VA: 0x339F3DC
	protected static byte* LtEntity(byte* pDst) { }

	// RVA: 0x339F3EC Offset: 0x339B3EC VA: 0x339F3EC
	protected static byte* GtEntity(byte* pDst) { }

	// RVA: 0x339F3BC Offset: 0x339B3BC VA: 0x339F3BC
	protected static byte* AmpEntity(byte* pDst) { }

	// RVA: 0x339F3FC Offset: 0x339B3FC VA: 0x339F3FC
	protected static byte* QuoteEntity(byte* pDst) { }

	// RVA: 0x339F41C Offset: 0x339B41C VA: 0x339F41C
	protected static byte* TabEntity(byte* pDst) { }

	// RVA: 0x339F45C Offset: 0x339B45C VA: 0x339F45C
	protected static byte* LineFeedEntity(byte* pDst) { }

	// RVA: 0x339F43C Offset: 0x339B43C VA: 0x339F43C
	protected static byte* CarriageReturnEntity(byte* pDst) { }

	// RVA: 0x339F924 Offset: 0x339B924 VA: 0x339F924
	private static byte* CharEntity(byte* pDst, char ch) { }

	// RVA: 0x339F8EC Offset: 0x339B8EC VA: 0x339F8EC
	protected static byte* RawStartCData(byte* pDst) { }

	// RVA: 0x339F8D0 Offset: 0x339B8D0 VA: 0x339F8D0
	protected static byte* RawEndCData(byte* pDst) { }

	// RVA: 0x339C98C Offset: 0x339898C VA: 0x339C98C
	protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace) { }
}
