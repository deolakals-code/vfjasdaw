// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(1)]
internal class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument, IXmlNode // TypeDefIndex: 16080
{
	// Fields
	private readonly XmlDocument _document; // 0x28

	// Properties
	[Nullable(2)]
	public IXmlElement DocumentElement { get; }

	// Methods

	// RVA: 0x30E02AC Offset: 0x30DC2AC VA: 0x30E02AC
	public void .ctor(XmlDocument document) { }

	// RVA: 0x30E031C Offset: 0x30DC31C VA: 0x30E031C Slot: 15
	public IXmlNode CreateComment(string data) { }

	// RVA: 0x30E03B0 Offset: 0x30DC3B0 VA: 0x30E03B0 Slot: 16
	public IXmlNode CreateTextNode(string text) { }

	// RVA: 0x30E0444 Offset: 0x30DC444 VA: 0x30E0444 Slot: 17
	public IXmlNode CreateCDataSection(string data) { }

	// RVA: 0x30E04D8 Offset: 0x30DC4D8 VA: 0x30E04D8 Slot: 18
	public IXmlNode CreateWhitespace(string text) { }

	// RVA: 0x30E056C Offset: 0x30DC56C VA: 0x30E056C Slot: 19
	public IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0x30E0600 Offset: 0x30DC600 VA: 0x30E0600 Slot: 20
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	[NullableContext(2)]
	// RVA: 0x30E06DC Offset: 0x30DC6DC VA: 0x30E06DC Slot: 21
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x30E07BC Offset: 0x30DC7BC VA: 0x30E07BC Slot: 22
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0x30E0860 Offset: 0x30DC860 VA: 0x30E0860 Slot: 23
	public IXmlElement CreateElement(string elementName) { }

	// RVA: 0x30E091C Offset: 0x30DC91C VA: 0x30E091C Slot: 24
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0x30E09A8 Offset: 0x30DC9A8 VA: 0x30E09A8 Slot: 25
	public IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0x30E0A7C Offset: 0x30DCA7C VA: 0x30E0A7C Slot: 26
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	[NullableContext(2)]
	// RVA: 0x30E0B38 Offset: 0x30DCB38 VA: 0x30E0B38 Slot: 27
	public IXmlElement get_DocumentElement() { }
}
