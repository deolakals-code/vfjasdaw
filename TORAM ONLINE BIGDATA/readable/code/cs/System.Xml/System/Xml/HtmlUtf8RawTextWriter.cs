// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class HtmlUtf8RawTextWriter : XmlUtf8RawTextWriter // TypeDefIndex: 13282
{
	// Fields
	protected ByteStack elementScope; // 0x90
	protected ElementProperties currentElementProperties; // 0x98
	private AttributeProperties currentAttributeProperties; // 0x9C
	private bool endsWithAmpersand; // 0xA0
	private byte[] uriEscapingBuffer; // 0xA8
	private string mediaType; // 0xB0
	private bool doNotEscapeUriAttributes; // 0xB8
	protected static TernaryTreeReadOnly elementPropertySearch; // 0x0
	protected static TernaryTreeReadOnly attributePropertySearch; // 0x8

	// Methods

	// RVA: 0x32B9700 Offset: 0x32B5700 VA: 0x32B9700
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x32B98D8 Offset: 0x32B58D8 VA: 0x32B98D8 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x32B98DC Offset: 0x32B58DC VA: 0x32B98DC Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x32B98E0 Offset: 0x32B58E0 VA: 0x32B98E0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x32B9B28 Offset: 0x32B5B28 VA: 0x32B9B28 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x32B9C34 Offset: 0x32B5C34 VA: 0x32B9C34 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x32B9DA8 Offset: 0x32B5DA8 VA: 0x32B9DA8 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x32B9E8C Offset: 0x32B5E8C VA: 0x32B9E8C Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x32B9F70 Offset: 0x32B5F70 VA: 0x32B9F70 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x32BA0E4 Offset: 0x32B60E4 VA: 0x32BA0E4 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x32BA214 Offset: 0x32B6214 VA: 0x32BA214 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x32BA334 Offset: 0x32B6334 VA: 0x32BA334 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x32BA3E0 Offset: 0x32B63E0 VA: 0x32BA3E0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x32BA438 Offset: 0x32B6438 VA: 0x32BA438 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x32BA490 Offset: 0x32B6490 VA: 0x32BA490 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x32BA4E8 Offset: 0x32B64E8 VA: 0x32BA4E8 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x32B972C Offset: 0x32B572C VA: 0x32B972C
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x32B9C8C Offset: 0x32B5C8C VA: 0x32B9C8C
	protected void WriteMetaElement() { }

	// RVA: 0x32BA3C8 Offset: 0x32B63C8 VA: 0x32BA3C8
	protected void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x32BA384 Offset: 0x32B6384 VA: 0x32BA384
	protected void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x32BA848 Offset: 0x32B6848 VA: 0x32BA848
	private void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x32BA52C Offset: 0x32B652C VA: 0x32BA52C
	private void WriteUriAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x32BA150 Offset: 0x32B6150 VA: 0x32BA150
	private void OutputRestAmps() { }
}
