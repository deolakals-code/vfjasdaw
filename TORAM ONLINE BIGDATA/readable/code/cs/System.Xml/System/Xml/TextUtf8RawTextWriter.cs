// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class TextUtf8RawTextWriter : XmlUtf8RawTextWriter // TypeDefIndex: 13309
{
	// Properties
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x33893E8 Offset: 0x33853E8 VA: 0x33893E8
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x33893F0 Offset: 0x33853F0 VA: 0x33893F0 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x33893F4 Offset: 0x33853F4 VA: 0x33893F4 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x33893F8 Offset: 0x33853F8 VA: 0x33893F8 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x33893FC Offset: 0x33853FC VA: 0x33893FC Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x3389400 Offset: 0x3385400 VA: 0x3389400 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x3389404 Offset: 0x3385404 VA: 0x3389404 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x3389408 Offset: 0x3385408 VA: 0x3389408 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x338940C Offset: 0x338540C VA: 0x338940C Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x3389418 Offset: 0x3385418 VA: 0x3389418 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x3389420 Offset: 0x3385420 VA: 0x3389420 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x3389424 Offset: 0x3385424 VA: 0x3389424 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x338942C Offset: 0x338542C VA: 0x338942C Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x3389434 Offset: 0x3385434 VA: 0x3389434 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x3389438 Offset: 0x3385438 VA: 0x3389438 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x338943C Offset: 0x338543C VA: 0x338943C Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x3389440 Offset: 0x3385440 VA: 0x3389440 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x3389444 Offset: 0x3385444 VA: 0x3389444 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x3389448 Offset: 0x3385448 VA: 0x3389448 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x338945C Offset: 0x338545C VA: 0x338945C Slot: 20
	public override void WriteString(string textBlock) { }

	// RVA: 0x3389470 Offset: 0x3385470 VA: 0x3389470 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x3389484 Offset: 0x3385484 VA: 0x3389484 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x3389498 Offset: 0x3385498 VA: 0x3389498 Slot: 24
	public override void WriteRaw(string data) { }
}
