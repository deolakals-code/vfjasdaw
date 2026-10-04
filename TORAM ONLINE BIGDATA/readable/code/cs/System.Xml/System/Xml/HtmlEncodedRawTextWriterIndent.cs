// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class HtmlEncodedRawTextWriterIndent : HtmlEncodedRawTextWriter // TypeDefIndex: 13280
{
	// Fields
	private int indentLevel; // 0xEC
	private int endBlockPos; // 0xF0
	private string indentChars; // 0xF8
	private bool newLineOnAttributes; // 0x100

	// Methods

	// RVA: 0x32B9194 Offset: 0x32B5194 VA: 0x32B9194
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x32B920C Offset: 0x32B520C VA: 0x32B920C
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x32B9244 Offset: 0x32B5244 VA: 0x32B9244 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x32B9260 Offset: 0x32B5260 VA: 0x32B9260 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x32B9474 Offset: 0x32B5474 VA: 0x32B9474 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x32B94E4 Offset: 0x32B54E4 VA: 0x32B94E4 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x32B957C Offset: 0x32B557C VA: 0x32B957C Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x32B95F0 Offset: 0x32B55F0 VA: 0x32B95F0 Slot: 48
	protected override void FlushBuffer() { }

	// RVA: 0x32B91CC Offset: 0x32B51CC VA: 0x32B91CC
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x32B9424 Offset: 0x32B5424 VA: 0x32B9424
	private void WriteIndent() { }
}
