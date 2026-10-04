// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class XmlEncodedRawTextWriter : XmlRawWriter // TypeDefIndex: 13320
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
	protected int bufBytesUsed; // 0x6C
	protected char[] bufChars; // 0x70
	protected Encoder encoder; // 0x78
	protected TextWriter writer; // 0x80
	protected bool trackTextContent; // 0x88
	protected bool inTextContent; // 0x89
	private int lastMarkPos; // 0x8C
	private int[] textContentMarks; // 0x90
	private CharEntityEncoderFallback charEntityFallback; // 0x98
	protected NewLineHandling newLineHandling; // 0xA0
	protected bool closeOutput; // 0xA4
	protected bool omitXmlDeclaration; // 0xA5
	protected string newLineChars; // 0xA8
	protected bool checkCharacters; // 0xB0
	protected XmlStandalone standalone; // 0xB4
	protected XmlOutputMethod outputMethod; // 0xB8
	protected bool autoXmlDeclaration; // 0xBC
	protected bool mergeCDataSections; // 0xBD

	// Properties
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x338CE70 Offset: 0x3388E70 VA: 0x338CE70
	protected void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x3388E5C Offset: 0x3384E5C VA: 0x3388E5C
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x3388F5C Offset: 0x3384F5C VA: 0x3388F5C
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x338D2BC Offset: 0x33892BC VA: 0x338D2BC Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x338D4DC Offset: 0x33894DC VA: 0x338D4DC Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x338D554 Offset: 0x3389554 VA: 0x338D554 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x338D740 Offset: 0x3389740 VA: 0x338D740 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x338D808 Offset: 0x3389808 VA: 0x338D808 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x338D84C Offset: 0x338984C VA: 0x338D84C Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x338D9BC Offset: 0x33899BC VA: 0x338D9BC Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x338DAC4 Offset: 0x3389AC4 VA: 0x338DAC4 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x338DBE4 Offset: 0x3389BE4 VA: 0x338DBE4 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x338DC4C Offset: 0x3389C4C VA: 0x338DC4C Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x338DCA0 Offset: 0x3389CA0 VA: 0x338DCA0 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x338DCA8 Offset: 0x3389CA8 VA: 0x338DCA8 Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x338DDCC Offset: 0x3389DCC VA: 0x338DDCC Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x338DE34 Offset: 0x3389E34 VA: 0x338DE34 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x338E330 Offset: 0x338A330 VA: 0x338E330 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x338E764 Offset: 0x338A764 VA: 0x338E764 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x338E890 Offset: 0x338A890 VA: 0x338E890 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x338E95C Offset: 0x338A95C VA: 0x338E95C Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x338EB20 Offset: 0x338AB20 VA: 0x338EB20 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x338F118 Offset: 0x338B118 VA: 0x338F118 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x338F184 Offset: 0x338B184 VA: 0x338F184 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x338F2C8 Offset: 0x338B2C8 VA: 0x338F2C8 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x338934C Offset: 0x338534C VA: 0x338934C Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x33892A4 Offset: 0x33852A4 VA: 0x33892A4 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x338F568 Offset: 0x338B568 VA: 0x338F568 Slot: 28
	public override void Close() { }

	// RVA: 0x338F680 Offset: 0x338B680 VA: 0x338F680 Slot: 29
	public override void Flush() { }

	// RVA: 0x338F6D8 Offset: 0x338B6D8 VA: 0x338F6D8 Slot: 48
	protected virtual void FlushBuffer() { }

	// RVA: 0x338F8E0 Offset: 0x338B8E0 VA: 0x338F8E0
	private void EncodeChars(int startOffset, int endOffset, bool writeAllToStream) { }

	// RVA: 0x338F5E4 Offset: 0x338B5E4 VA: 0x338F5E4
	private void FlushEncoder() { }

	// RVA: 0x338EB8C Offset: 0x338AB8C VA: 0x338EB8C
	protected void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x338EE74 Offset: 0x338AE74 VA: 0x338EE74
	protected void WriteElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x338D4A0 Offset: 0x33894A0 VA: 0x338D4A0
	protected void RawText(string s) { }

	// RVA: 0x338FD30 Offset: 0x338BD30 VA: 0x338FD30
	protected void RawText(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x338F350 Offset: 0x338B350 VA: 0x338F350
	protected void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x338E45C Offset: 0x338A45C VA: 0x338E45C
	protected void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x338E014 Offset: 0x338A014 VA: 0x338E014
	protected void WriteCDataSection(string text) { }

	// RVA: 0x338FB10 Offset: 0x338BB10 VA: 0x338FB10
	private static char* EncodeSurrogate(char* pSrc, char* pSrcEnd, char* pDst) { }

	// RVA: 0x338FC68 Offset: 0x338BC68 VA: 0x338FC68
	private char* InvalidXmlChar(int ch, char* pDst, bool entitize) { }

	// RVA: 0x338FFA0 Offset: 0x338BFA0 VA: 0x338FFA0
	internal void EncodeChar(ref char* pSrc, char* pSrcEnd, ref char* pDst) { }

	// RVA: 0x338D42C Offset: 0x338942C VA: 0x338D42C
	protected void ChangeTextContentMark(bool value) { }

	// RVA: 0x3390044 Offset: 0x338C044 VA: 0x3390044
	private void GrowTextContentMarks() { }

	// RVA: 0x338FCD4 Offset: 0x338BCD4 VA: 0x338FCD4
	protected char* WriteNewLine(char* pDst) { }

	// RVA: 0x338FA3C Offset: 0x338BA3C VA: 0x338FA3C
	protected static char* LtEntity(char* pDst) { }

	// RVA: 0x338FA54 Offset: 0x338BA54 VA: 0x338FA54
	protected static char* GtEntity(char* pDst) { }

	// RVA: 0x338FA14 Offset: 0x338BA14 VA: 0x338FA14
	protected static char* AmpEntity(char* pDst) { }

	// RVA: 0x338FA6C Offset: 0x338BA6C VA: 0x338FA6C
	protected static char* QuoteEntity(char* pDst) { }

	// RVA: 0x338FA98 Offset: 0x338BA98 VA: 0x338FA98
	protected static char* TabEntity(char* pDst) { }

	// RVA: 0x338FAE8 Offset: 0x338BAE8 VA: 0x338FAE8
	protected static char* LineFeedEntity(char* pDst) { }

	// RVA: 0x338FAC0 Offset: 0x338BAC0 VA: 0x338FAC0
	protected static char* CarriageReturnEntity(char* pDst) { }

	// RVA: 0x338FEF0 Offset: 0x338BEF0 VA: 0x338FEF0
	private static char* CharEntity(char* pDst, char ch) { }

	// RVA: 0x338FEB8 Offset: 0x338BEB8 VA: 0x338FEB8
	protected static char* RawStartCData(char* pDst) { }

	// RVA: 0x338FE98 Offset: 0x338BE98 VA: 0x338FE98
	protected static char* RawEndCData(char* pDst) { }

	// RVA: 0x338CF70 Offset: 0x3388F70 VA: 0x338CF70
	protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace) { }
}
