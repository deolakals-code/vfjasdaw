// Assembly: System.Xml.dll
// Namespace: 
private struct XmlWellFormedWriter.ElementScope // TypeDefIndex: 13364
{
	// Fields
	internal int prevNSTop; // 0x0
	internal string prefix; // 0x8
	internal string localName; // 0x10
	internal string namespaceUri; // 0x18
	internal XmlSpace xmlSpace; // 0x20
	internal string xmlLang; // 0x28

	// Methods

	// RVA: 0x33A21F0 Offset: 0x339E1F0 VA: 0x33A21F0
	internal void Set(string prefix, string localName, string namespaceUri, int prevNSTop) { }

	// RVA: 0x33A39A8 Offset: 0x339F9A8 VA: 0x33A39A8
	internal void WriteEndElement(XmlRawWriter rawWriter) { }

	// RVA: 0x33A3C90 Offset: 0x339FC90 VA: 0x33A3C90
	internal void WriteFullEndElement(XmlRawWriter rawWriter) { }
}
