// Assembly: System.Xml.Linq.dll
// Namespace: System.Xml.Linq
internal struct ElementWriter // TypeDefIndex: 17519
{
	// Fields
	private XmlWriter _writer; // 0x0
	private NamespaceResolver _resolver; // 0x8

	// Methods

	// RVA: 0x32C0828 Offset: 0x32BC828 VA: 0x32C0828
	public void .ctor(XmlWriter writer) { }

	// RVA: 0x32C0848 Offset: 0x32BC848 VA: 0x32C0848
	public void WriteElement(XElement e) { }

	// RVA: 0x32C1D08 Offset: 0x32BDD08 VA: 0x32C1D08
	private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

	// RVA: 0x32C1A28 Offset: 0x32BDA28 VA: 0x32C1A28
	private void PushAncestors(XElement e) { }

	// RVA: 0x32C1FE8 Offset: 0x32BDFE8 VA: 0x32C1FE8
	private void PushElement(XElement e) { }

	// RVA: 0x32C1CB0 Offset: 0x32BDCB0 VA: 0x32C1CB0
	private void WriteEndElement() { }

	// RVA: 0x32C1CDC Offset: 0x32BDCDC VA: 0x32C1CDC
	private void WriteFullEndElement() { }

	// RVA: 0x32C1B50 Offset: 0x32BDB50 VA: 0x32C1B50
	private void WriteStartElement(XElement e) { }
}
