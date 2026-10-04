// Assembly: System.Xml.dll
// Namespace: System.Xml
internal abstract class XmlRawWriter : XmlWriter // TypeDefIndex: 13326
{
	// Fields
	protected XmlRawWriterBase64Encoder base64Encoder; // 0x18
	protected IXmlNamespaceResolver resolver; // 0x20

	// Properties
	public override WriteState WriteState { get; }
	internal virtual IXmlNamespaceResolver NamespaceResolver { set; }
	internal virtual bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x33915AC Offset: 0x338D5AC VA: 0x33915AC Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x3391604 Offset: 0x338D604 VA: 0x3391604 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x339165C Offset: 0x338D65C VA: 0x339165C Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x33916B4 Offset: 0x338D6B4 VA: 0x33916B4 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x33916B8 Offset: 0x338D6B8 VA: 0x33916B8 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x3391710 Offset: 0x338D710 VA: 0x3391710 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x33905E8 Offset: 0x338C5E8 VA: 0x33905E8 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x3391768 Offset: 0x338D768 VA: 0x3391768 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x33917C0 Offset: 0x338D7C0 VA: 0x33917C0 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x3391818 Offset: 0x338D818 VA: 0x3391818 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x3391828 Offset: 0x338D828 VA: 0x3391828 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x33918BC Offset: 0x338D8BC VA: 0x33918BC Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x3391960 Offset: 0x338D960 VA: 0x3391960 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x3391970 Offset: 0x338D970 VA: 0x3391970 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x33919A0 Offset: 0x338D9A0 VA: 0x33919A0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x33919D0 Offset: 0x338D9D0 VA: 0x33919D0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x33919E0 Offset: 0x338D9E0 VA: 0x33919E0 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0x33919F0 Offset: 0x338D9F0 VA: 0x33919F0 Slot: 32
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x3391A48 Offset: 0x338DA48 VA: 0x3391A48 Slot: 33
	public override void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x3391AA0 Offset: 0x338DAA0 VA: 0x3391AA0 Slot: 35
	internal virtual void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x3391AA8 Offset: 0x338DAA8 VA: 0x3391AA8 Slot: 36
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x3391AAC Offset: 0x338DAAC VA: 0x3391AAC Slot: 37
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

	// RVA: -1 Offset: -1 Slot: 38
	internal abstract void StartElementContent();

	// RVA: 0x3391AB0 Offset: 0x338DAB0 VA: 0x3391AB0 Slot: 39
	internal virtual void OnRootElement(ConformanceLevel conformanceLevel) { }

	// RVA: -1 Offset: -1 Slot: 40
	internal abstract void WriteEndElement(string prefix, string localName, string ns);

	// RVA: 0x3391AB4 Offset: 0x338DAB4 VA: 0x3391AB4 Slot: 41
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: -1 Offset: -1 Slot: 42
	internal abstract void WriteNamespaceDeclaration(string prefix, string ns);

	// RVA: 0x3391AC4 Offset: 0x338DAC4 VA: 0x3391AC4 Slot: 43
	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x3391ACC Offset: 0x338DACC VA: 0x3391ACC Slot: 44
	internal virtual void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x3391B04 Offset: 0x338DB04 VA: 0x3391B04 Slot: 45
	internal virtual void WriteEndNamespaceDeclaration() { }

	// RVA: 0x3391B3C Offset: 0x338DB3C VA: 0x3391B3C Slot: 46
	internal virtual void WriteEndBase64() { }

	// RVA: 0x3391B58 Offset: 0x338DB58 VA: 0x3391B58 Slot: 47
	internal virtual void Close(WriteState currentState) { }

	// RVA: 0x3387F8C Offset: 0x3383F8C VA: 0x3387F8C
	protected void .ctor() { }
}
