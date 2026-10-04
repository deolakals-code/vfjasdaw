// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class XmlUtf8RawTextWriterIndent : XmlUtf8RawTextWriter // TypeDefIndex: 13356
{
	// Fields
	protected int indentLevel; // 0x90
	protected bool newLineOnAttributes; // 0x94
	protected string indentChars; // 0x98
	protected bool mixedContent; // 0xA0
	private BitStack mixedContentStack; // 0xA8
	protected ConformanceLevel conformanceLevel; // 0xB0

	// Methods

	// RVA: 0x339FB7C Offset: 0x339BB7C VA: 0x339FB7C
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x339FCC8 Offset: 0x339BCC8 VA: 0x339FCC8 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x339FD70 Offset: 0x339BD70 VA: 0x339FD70 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x339FDDC Offset: 0x339BDDC VA: 0x339FDDC Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x339FE2C Offset: 0x339BE2C VA: 0x339FE2C Slot: 39
	internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x339FE34 Offset: 0x339BE34 VA: 0x339FE34 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x339FEB4 Offset: 0x339BEB4 VA: 0x339FEB4 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x339FF34 Offset: 0x339BF34 VA: 0x339FF34 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x339FF70 Offset: 0x339BF70 VA: 0x339FF70 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x339FF7C Offset: 0x339BF7C VA: 0x339FF7C Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x339FFBC Offset: 0x339BFBC VA: 0x339FFBC Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x33A0004 Offset: 0x339C004 VA: 0x33A0004 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x33A0010 Offset: 0x339C010 VA: 0x33A0010 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x33A001C Offset: 0x339C01C VA: 0x33A001C Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x33A0028 Offset: 0x339C028 VA: 0x33A0028 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x33A0034 Offset: 0x339C034 VA: 0x33A0034 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x33A0040 Offset: 0x339C040 VA: 0x33A0040 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x33A004C Offset: 0x339C04C VA: 0x33A004C Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x33A0058 Offset: 0x339C058 VA: 0x33A0058 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x33A0064 Offset: 0x339C064 VA: 0x33A0064 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x339FBA4 Offset: 0x339BBA4 VA: 0x339FBA4
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x339FD28 Offset: 0x339BD28 VA: 0x339FD28
	private void WriteIndent() { }
}
