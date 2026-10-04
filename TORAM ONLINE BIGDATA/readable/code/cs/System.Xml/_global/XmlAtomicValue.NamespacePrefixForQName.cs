// Assembly: System.Xml.dll
// Namespace: 
private class XmlAtomicValue.NamespacePrefixForQName : IXmlNamespaceResolver // TypeDefIndex: 13747
{
	// Fields
	public string prefix; // 0x10
	public string ns; // 0x18

	// Methods

	// RVA: 0x332FAE4 Offset: 0x332BAE4 VA: 0x332FAE4
	public void .ctor(string prefix, string ns) { }

	// RVA: 0x333078C Offset: 0x332C78C VA: 0x333078C Slot: 5
	public string LookupNamespace(string prefix) { }

	// RVA: 0x33307C0 Offset: 0x332C7C0 VA: 0x33307C0 Slot: 6
	public string LookupPrefix(string namespaceName) { }

	// RVA: 0x33307EC Offset: 0x332C7EC VA: 0x33307EC Slot: 4
	public IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }
}
