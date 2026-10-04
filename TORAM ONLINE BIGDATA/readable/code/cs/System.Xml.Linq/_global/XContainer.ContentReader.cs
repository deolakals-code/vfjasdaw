// Assembly: System.Xml.Linq.dll
// Namespace: 
private sealed class XContainer.ContentReader // TypeDefIndex: 17506
{
	// Fields
	private readonly NamespaceCache _eCache; // 0x10
	private readonly NamespaceCache _aCache; // 0x20
	private readonly IXmlLineInfo _lineInfo; // 0x30
	private XContainer _currentContainer; // 0x38
	private string _baseUri; // 0x40

	// Methods

	// RVA: 0x32BD9B4 Offset: 0x32B99B4 VA: 0x32BD9B4
	public void .ctor(XContainer rootContainer) { }

	// RVA: 0x32BE0D0 Offset: 0x32BA0D0 VA: 0x32BE0D0
	public void .ctor(XContainer rootContainer, XmlReader r, LoadOptions o) { }

	// RVA: 0x32BD9E4 Offset: 0x32B99E4 VA: 0x32BD9E4
	public bool ReadContentFrom(XContainer rootContainer, XmlReader r) { }

	// RVA: 0x32BE198 Offset: 0x32BA198 VA: 0x32BE198
	public bool ReadContentFrom(XContainer rootContainer, XmlReader r, LoadOptions o) { }
}
