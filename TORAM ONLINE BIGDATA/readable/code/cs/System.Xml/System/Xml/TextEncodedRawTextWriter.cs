// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class TextEncodedRawTextWriter : XmlEncodedRawTextWriter // TypeDefIndex: 13308
{
	// Properties
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x3388E58 Offset: 0x3384E58 VA: 0x3388E58
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x3388F58 Offset: 0x3384F58 VA: 0x3388F58
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x3389264 Offset: 0x3385264 VA: 0x3389264 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x3389268 Offset: 0x3385268 VA: 0x3389268 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x338926C Offset: 0x338526C VA: 0x338926C Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x3389270 Offset: 0x3385270 VA: 0x3389270 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x3389274 Offset: 0x3385274 VA: 0x3389274 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x3389278 Offset: 0x3385278 VA: 0x3389278 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x338927C Offset: 0x338527C VA: 0x338927C Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x3389280 Offset: 0x3385280 VA: 0x3389280 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x338928C Offset: 0x338528C VA: 0x338928C Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x3389294 Offset: 0x3385294 VA: 0x3389294 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x3389298 Offset: 0x3385298 VA: 0x3389298 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x33892A0 Offset: 0x33852A0 VA: 0x33892A0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x3389308 Offset: 0x3385308 VA: 0x3389308 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x338930C Offset: 0x338530C VA: 0x338930C Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x3389310 Offset: 0x3385310 VA: 0x3389310 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x3389314 Offset: 0x3385314 VA: 0x3389314 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x3389318 Offset: 0x3385318 VA: 0x3389318 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x338931C Offset: 0x338531C VA: 0x338931C Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x338932C Offset: 0x338532C VA: 0x338932C Slot: 20
	public override void WriteString(string textBlock) { }

	// RVA: 0x338933C Offset: 0x338533C VA: 0x338933C Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x33893C8 Offset: 0x33853C8 VA: 0x33893C8 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x33893D8 Offset: 0x33853D8 VA: 0x33893D8 Slot: 24
	public override void WriteRaw(string data) { }
}
