// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithNS : XmlAsyncCheckReader, IXmlNamespaceResolver // TypeDefIndex: 13314
{
	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x20

	// Methods

	// RVA: 0x3389C98 Offset: 0x3385C98 VA: 0x3389C98
	public void .ctor(XmlReader reader) { }

	// RVA: 0x338A8B8 Offset: 0x33868B8 VA: 0x338A8B8 Slot: 53
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x338A960 Offset: 0x3386960 VA: 0x338A960 Slot: 54
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x338AA0C Offset: 0x3386A0C VA: 0x338AA0C Slot: 55
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }
}
