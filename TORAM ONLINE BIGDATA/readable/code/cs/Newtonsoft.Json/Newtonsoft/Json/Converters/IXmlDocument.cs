// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
internal interface IXmlDocument : IXmlNode // TypeDefIndex: 16085
{
	// Properties
	[Nullable(2)]
	public abstract IXmlElement DocumentElement { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IXmlNode CreateComment(string text);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IXmlNode CreateTextNode(string text);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IXmlNode CreateCDataSection(string data);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IXmlNode CreateWhitespace(string text);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IXmlNode CreateSignificantWhitespace(string text);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IXmlNode CreateProcessingInstruction(string target, string data);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IXmlElement CreateElement(string elementName);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IXmlElement CreateElement(string qualifiedName, string namespaceUri);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IXmlNode CreateAttribute(string name, string value);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 12
	public abstract IXmlElement get_DocumentElement();
}
