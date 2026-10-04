// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class HtmlUtf8RawTextWriterIndent : HtmlUtf8RawTextWriter // TypeDefIndex: 13283
{
	// Fields
	private int indentLevel; // 0xBC
	private int endBlockPos; // 0xC0
	private string indentChars; // 0xC8
	private bool newLineOnAttributes; // 0xD0

	// Methods

	// RVA: 0x33875DC Offset: 0x33835DC VA: 0x33875DC
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x3387648 Offset: 0x3383648 VA: 0x3387648 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x3387668 Offset: 0x3383668 VA: 0x3387668 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x338798C Offset: 0x338398C VA: 0x338798C Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x3387A04 Offset: 0x3383A04 VA: 0x3387A04 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x3387AA0 Offset: 0x3383AA0 VA: 0x3387AA0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x3387B18 Offset: 0x3383B18 VA: 0x3387B18 Slot: 48
	protected override void FlushBuffer() { }

	// RVA: 0x3387608 Offset: 0x3383608 VA: 0x3387608
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x338793C Offset: 0x338393C VA: 0x338793C
	private void WriteIndent() { }
}
