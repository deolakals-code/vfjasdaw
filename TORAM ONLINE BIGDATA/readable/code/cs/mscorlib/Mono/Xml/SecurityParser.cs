// Assembly: mscorlib.dll
// Namespace: Mono.Xml
internal class SecurityParser : SmallXmlParser, SmallXmlParser.IContentHandler // TypeDefIndex: 9447
{
	// Fields
	private SecurityElement root; // 0x68
	private SecurityElement current; // 0x70
	private Stack stack; // 0x78

	// Methods

	// RVA: 0x2E66264 Offset: 0x2E62264 VA: 0x2E66264
	public void .ctor() { }

	// RVA: 0x2E66414 Offset: 0x2E62414 VA: 0x2E66414
	public void LoadXml(string xml) { }

	// RVA: 0x2E66690 Offset: 0x2E62690 VA: 0x2E66690
	public SecurityElement ToXml() { }

	// RVA: 0x2E66698 Offset: 0x2E62698 VA: 0x2E66698 Slot: 4
	public void OnStartParsing(SmallXmlParser parser) { }

	// RVA: 0x2E6669C Offset: 0x2E6269C VA: 0x2E6669C Slot: 8
	public void OnProcessingInstruction(string name, string text) { }

	// RVA: 0x2E666A0 Offset: 0x2E626A0 VA: 0x2E666A0 Slot: 10
	public void OnIgnorableWhitespace(string s) { }

	// RVA: 0x2E666A4 Offset: 0x2E626A4 VA: 0x2E666A4 Slot: 6
	public void OnStartElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x2E66944 Offset: 0x2E62944 VA: 0x2E66944 Slot: 7
	public void OnEndElement(string name) { }

	// RVA: 0x2E669DC Offset: 0x2E629DC VA: 0x2E669DC Slot: 9
	public void OnChars(string ch) { }

	// RVA: 0x2E66A5C Offset: 0x2E62A5C VA: 0x2E66A5C Slot: 5
	public void OnEndParsing(SmallXmlParser parser) { }
}
