// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class XmlAutoDetectWriter : XmlRawWriter // TypeDefIndex: 13319
{
	// Fields
	private XmlRawWriter wrapped; // 0x28
	private OnRemoveWriter onRemove; // 0x30
	private XmlWriterSettings writerSettings; // 0x38
	private XmlEventCache eventCache; // 0x40
	private TextWriter textWriter; // 0x48
	private Stream strm; // 0x50

	// Properties
	internal override IXmlNamespaceResolver NamespaceResolver { set; }
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x338BB40 Offset: 0x3387B40 VA: 0x338BB40
	private void .ctor(XmlWriterSettings writerSettings) { }

	// RVA: 0x338BC60 Offset: 0x3387C60 VA: 0x338BC60
	public void .ctor(TextWriter textWriter, XmlWriterSettings writerSettings) { }

	// RVA: 0x338BC90 Offset: 0x3387C90 VA: 0x338BC90
	public void .ctor(Stream strm, XmlWriterSettings writerSettings) { }

	// RVA: 0x338BCC0 Offset: 0x3387CC0 VA: 0x338BCC0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x338BD38 Offset: 0x3387D38 VA: 0x338BD38 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x338C014 Offset: 0x3388014 VA: 0x338C014 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x338C074 Offset: 0x3388074 VA: 0x338C074 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x338C098 Offset: 0x3388098 VA: 0x338C098 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x338C13C Offset: 0x338813C VA: 0x338C13C Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x338C16C Offset: 0x338816C VA: 0x338C16C Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x338C19C Offset: 0x338819C VA: 0x338C19C Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x338C1CC Offset: 0x33881CC VA: 0x338C1CC Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x338C214 Offset: 0x3388214 VA: 0x338C214 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x338C244 Offset: 0x3388244 VA: 0x338C244 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x338C274 Offset: 0x3388274 VA: 0x338C274 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x338C2BC Offset: 0x33882BC VA: 0x338C2BC Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x338C308 Offset: 0x3388308 VA: 0x338C308 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x338C354 Offset: 0x3388354 VA: 0x338C354 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x338C3A8 Offset: 0x33883A8 VA: 0x338C3A8 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x338C40C Offset: 0x338840C VA: 0x338C40C Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x338C470 Offset: 0x3388470 VA: 0x338C470 Slot: 28
	public override void Close() { }

	// RVA: 0x338C4AC Offset: 0x33884AC VA: 0x338C4AC Slot: 29
	public override void Flush() { }

	// RVA: 0x338C4E8 Offset: 0x33884E8 VA: 0x338C4E8 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0x338C534 Offset: 0x3388534 VA: 0x338C534 Slot: 35
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x338C584 Offset: 0x3388584 VA: 0x338C584 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x338C5D0 Offset: 0x33885D0 VA: 0x338C5D0 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x338C61C Offset: 0x338861C VA: 0x338C61C Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x338C640 Offset: 0x3388640 VA: 0x338C640 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x338C664 Offset: 0x3388664 VA: 0x338C664 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x338C688 Offset: 0x3388688 VA: 0x338C688 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x338C6DC Offset: 0x33886DC VA: 0x338C6DC Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x338C700 Offset: 0x3388700 VA: 0x338C700 Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x338C74C Offset: 0x338874C VA: 0x338C74C Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x338BDB8 Offset: 0x3387DB8 VA: 0x338BDB8
	private static bool IsHtmlTag(string tagName) { }

	// RVA: 0x338BD28 Offset: 0x3387D28 VA: 0x338BD28
	private void EnsureWrappedWriter(XmlOutputMethod outMethod) { }

	// RVA: 0x338C0E0 Offset: 0x33880E0 VA: 0x338C0E0
	private bool TextBlockCreatesWriter(string textBlock) { }

	// RVA: 0x338BECC Offset: 0x3387ECC VA: 0x338BECC
	private void CreateWrappedWriter(XmlOutputMethod outMethod) { }
}
