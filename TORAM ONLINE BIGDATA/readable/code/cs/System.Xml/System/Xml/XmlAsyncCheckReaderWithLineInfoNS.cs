// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfoNS : XmlAsyncCheckReaderWithLineInfo, IXmlNamespaceResolver // TypeDefIndex: 13316
{
	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x28

	// Methods

	// RVA: 0x3389B48 Offset: 0x3385B48 VA: 0x3389B48
	public void .ctor(XmlReader reader) { }

	// RVA: 0x338ACA0 Offset: 0x3386CA0 VA: 0x338ACA0 Slot: 59
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x338AD48 Offset: 0x3386D48 VA: 0x338AD48 Slot: 60
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x338ADF4 Offset: 0x3386DF4 VA: 0x338ADF4 Slot: 61
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }
}
