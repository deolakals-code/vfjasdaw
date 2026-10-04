// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class QueryOutputWriter : XmlRawWriter // TypeDefIndex: 13299
{
	// Fields
	private XmlRawWriter wrapped; // 0x28
	private bool inCDataSection; // 0x30
	private Dictionary<XmlQualifiedName, int> lookupCDataElems; // 0x38
	private BitStack bitsCData; // 0x40
	private XmlQualifiedName qnameCData; // 0x48
	private bool outputDocType; // 0x50
	private bool checkWellFormedDoc; // 0x51
	private bool hasDocElem; // 0x52
	private bool inAttr; // 0x53
	private string systemId; // 0x58
	private string publicId; // 0x60
	private int depth; // 0x68

	// Properties
	internal override IXmlNamespaceResolver NamespaceResolver { set; }
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x3387C80 Offset: 0x3383C80 VA: 0x3387C80
	public void .ctor(XmlRawWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x3387F94 Offset: 0x3383F94 VA: 0x3387F94 Slot: 35
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x3387FD8 Offset: 0x3383FD8 VA: 0x3387FD8 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x3387FFC Offset: 0x3383FFC VA: 0x3387FFC Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x3388020 Offset: 0x3384020 VA: 0x3388020 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x3388058 Offset: 0x3384058 VA: 0x3388058 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x3388220 Offset: 0x3384220 VA: 0x3388220 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x3388280 Offset: 0x3384280 VA: 0x3388280 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x33882E0 Offset: 0x33842E0 VA: 0x33882E0 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x3388304 Offset: 0x3384304 VA: 0x3388304 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x3388330 Offset: 0x3384330 VA: 0x3388330 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x338835C Offset: 0x338435C VA: 0x338835C Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x3388380 Offset: 0x3384380 VA: 0x3388380 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x33883A4 Offset: 0x33843A4 VA: 0x33883A4 Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x33883C8 Offset: 0x33843C8 VA: 0x33883C8 Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x33883EC Offset: 0x33843EC VA: 0x33883EC Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x3388410 Offset: 0x3384410 VA: 0x3388410 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x338843C Offset: 0x338443C VA: 0x338843C Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x3388468 Offset: 0x3384468 VA: 0x3388468 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x3388514 Offset: 0x3384514 VA: 0x3388514 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x3388580 Offset: 0x3384580 VA: 0x3388580 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x3388630 Offset: 0x3384630 VA: 0x3388630 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x338865C Offset: 0x338465C VA: 0x338865C Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x3388688 Offset: 0x3384688 VA: 0x3388688 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x33886B4 Offset: 0x33846B4 VA: 0x33886B4 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x3388764 Offset: 0x3384764 VA: 0x3388764 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x33887D0 Offset: 0x33847D0 VA: 0x33887D0 Slot: 28
	public override void Close() { }

	// RVA: 0x3388874 Offset: 0x3384874 VA: 0x3388874 Slot: 29
	public override void Flush() { }

	// RVA: 0x33884D4 Offset: 0x33844D4 VA: 0x33884D4
	private bool StartCDataSection() { }

	// RVA: 0x3388218 Offset: 0x3384218 VA: 0x3388218
	private void EndCDataSection() { }
}
