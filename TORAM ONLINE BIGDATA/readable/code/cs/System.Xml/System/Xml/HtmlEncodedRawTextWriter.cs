// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class HtmlEncodedRawTextWriter : XmlEncodedRawTextWriter // TypeDefIndex: 13279
{
	// Fields
	protected ByteStack elementScope; // 0xC0
	protected ElementProperties currentElementProperties; // 0xC8
	private AttributeProperties currentAttributeProperties; // 0xCC
	private bool endsWithAmpersand; // 0xD0
	private byte[] uriEscapingBuffer; // 0xD8
	private string mediaType; // 0xE0
	private bool doNotEscapeUriAttributes; // 0xE8
	protected static TernaryTreeReadOnly elementPropertySearch; // 0x0
	protected static TernaryTreeReadOnly attributePropertySearch; // 0x8

	// Methods

	// RVA: 0x32B7CAC Offset: 0x32B3CAC VA: 0x32B7CAC
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x32B7E84 Offset: 0x32B3E84 VA: 0x32B7E84
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x32B7EB0 Offset: 0x32B3EB0 VA: 0x32B7EB0 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x32B7EB4 Offset: 0x32B3EB4 VA: 0x32B7EB4 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x32B7EB8 Offset: 0x32B3EB8 VA: 0x32B7EB8 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x32B8100 Offset: 0x32B4100 VA: 0x32B8100 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x32B822C Offset: 0x32B422C VA: 0x32B822C Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x32B839C Offset: 0x32B439C VA: 0x32B839C Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x32B84A0 Offset: 0x32B44A0 VA: 0x32B84A0 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x32B85A4 Offset: 0x32B45A4 VA: 0x32B85A4 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x32B8728 Offset: 0x32B4728 VA: 0x32B8728 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x32B884C Offset: 0x32B484C VA: 0x32B884C Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x32B8980 Offset: 0x32B4980 VA: 0x32B8980 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x32B8A4C Offset: 0x32B4A4C VA: 0x32B8A4C Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x32B8AA4 Offset: 0x32B4AA4 VA: 0x32B8AA4 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x32B8AFC Offset: 0x32B4AFC VA: 0x32B8AFC Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x32B8B54 Offset: 0x32B4B54 VA: 0x32B8B54 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x32B7CD8 Offset: 0x32B3CD8 VA: 0x32B7CD8
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x32B8280 Offset: 0x32B4280 VA: 0x32B8280
	protected void WriteMetaElement() { }

	// RVA: 0x32B8A34 Offset: 0x32B4A34 VA: 0x32B8A34
	protected void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x32B89F0 Offset: 0x32B49F0 VA: 0x32B89F0
	protected void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x32B8F1C Offset: 0x32B4F1C VA: 0x32B8F1C
	private void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x32B8BE4 Offset: 0x32B4BE4 VA: 0x32B8BE4
	private void WriteUriAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x32B87B8 Offset: 0x32B47B8 VA: 0x32B87B8
	private void OutputRestAmps() { }
}
