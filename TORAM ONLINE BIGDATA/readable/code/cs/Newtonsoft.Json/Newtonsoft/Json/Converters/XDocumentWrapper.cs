// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(1)]
internal class XDocumentWrapper : XContainerWrapper, IXmlDocument, IXmlNode // TypeDefIndex: 16092
{
	// Properties
	private XDocument Document { get; }
	public override List<IXmlNode> ChildNodes { get; }
	protected override bool HasChildNodes { get; }
	[Nullable(2)]
	public IXmlElement DocumentElement { get; }

	// Methods

	// RVA: 0x30E1CD4 Offset: 0x30DDCD4 VA: 0x30E1CD4
	private XDocument get_Document() { }

	// RVA: 0x30E1D4C Offset: 0x30DDD4C VA: 0x30E1D4C
	public void .ctor(XDocument document) { }

	// RVA: 0x30E1DAC Offset: 0x30DDDAC VA: 0x30E1DAC Slot: 15
	public override List<IXmlNode> get_ChildNodes() { }

	// RVA: 0x30E2338 Offset: 0x30DE338 VA: 0x30E2338 Slot: 21
	protected override bool get_HasChildNodes() { }

	// RVA: 0x30E239C Offset: 0x30DE39C VA: 0x30E239C Slot: 22
	public IXmlNode CreateComment(string text) { }

	// RVA: 0x30E2438 Offset: 0x30DE438 VA: 0x30E2438 Slot: 23
	public IXmlNode CreateTextNode(string text) { }

	// RVA: 0x30E24D4 Offset: 0x30DE4D4 VA: 0x30E24D4 Slot: 24
	public IXmlNode CreateCDataSection(string data) { }

	// RVA: 0x30E2570 Offset: 0x30DE570 VA: 0x30E2570 Slot: 25
	public IXmlNode CreateWhitespace(string text) { }

	// RVA: 0x30E260C Offset: 0x30DE60C VA: 0x30E260C Slot: 26
	public IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0x30E26A8 Offset: 0x30DE6A8 VA: 0x30E26A8 Slot: 27
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	[NullableContext(2)]
	// RVA: 0x30E274C Offset: 0x30DE74C VA: 0x30E274C Slot: 28
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x30E27F8 Offset: 0x30DE7F8 VA: 0x30E27F8 Slot: 29
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0x30E28CC Offset: 0x30DE8CC VA: 0x30E28CC Slot: 30
	public IXmlElement CreateElement(string elementName) { }

	// RVA: 0x30E29AC Offset: 0x30DE9AC VA: 0x30E29AC Slot: 31
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0x30E2A6C Offset: 0x30DEA6C VA: 0x30E2A6C Slot: 32
	public IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0x30E2B54 Offset: 0x30DEB54 VA: 0x30E2B54 Slot: 33
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	[NullableContext(2)]
	// RVA: 0x30E2C24 Offset: 0x30DEC24 VA: 0x30E2C24 Slot: 34
	public IXmlElement get_DocumentElement() { }

	// RVA: 0x30E2CCC Offset: 0x30DECCC VA: 0x30E2CCC Slot: 19
	public override IXmlNode AppendChild(IXmlNode newChild) { }
}
