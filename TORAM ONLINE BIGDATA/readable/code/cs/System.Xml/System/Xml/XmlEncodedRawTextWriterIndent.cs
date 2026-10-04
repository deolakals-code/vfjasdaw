// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class XmlEncodedRawTextWriterIndent : XmlEncodedRawTextWriter // TypeDefIndex: 13321
{
	// Fields
	protected int indentLevel; // 0xC0
	protected bool newLineOnAttributes; // 0xC4
	protected string indentChars; // 0xC8
	protected bool mixedContent; // 0xD0
	private BitStack mixedContentStack; // 0xD8
	protected ConformanceLevel conformanceLevel; // 0xE0

	// Methods

	// RVA: 0x33900CC Offset: 0x338C0CC VA: 0x33900CC
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x3390218 Offset: 0x338C218 VA: 0x3390218
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x3390240 Offset: 0x338C240 VA: 0x3390240 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x33902E8 Offset: 0x338C2E8 VA: 0x33902E8 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x3390354 Offset: 0x338C354 VA: 0x3390354 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x33903A4 Offset: 0x338C3A4 VA: 0x33903A4 Slot: 39
	internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x33903AC Offset: 0x338C3AC VA: 0x33903AC Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x339042C Offset: 0x338C42C VA: 0x339042C Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x33904AC Offset: 0x338C4AC VA: 0x33904AC Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x33904E8 Offset: 0x338C4E8 VA: 0x33904E8 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x33904F4 Offset: 0x338C4F4 VA: 0x33904F4 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x3390534 Offset: 0x338C534 VA: 0x3390534 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x339057C Offset: 0x338C57C VA: 0x339057C Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x3390588 Offset: 0x338C588 VA: 0x3390588 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x3390594 Offset: 0x338C594 VA: 0x3390594 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x33905A0 Offset: 0x338C5A0 VA: 0x33905A0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x33905AC Offset: 0x338C5AC VA: 0x33905AC Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x33905B8 Offset: 0x338C5B8 VA: 0x33905B8 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x33905C4 Offset: 0x338C5C4 VA: 0x33905C4 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x33905D0 Offset: 0x338C5D0 VA: 0x33905D0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x33905DC Offset: 0x338C5DC VA: 0x33905DC Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x33900F4 Offset: 0x338C0F4 VA: 0x33900F4
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x33902A0 Offset: 0x338C2A0 VA: 0x33902A0
	private void WriteIndent() { }
}
