// Assembly: System.Xml.dll
// Namespace: System.Xml
internal sealed class XmlEventCache : XmlRawWriter // TypeDefIndex: 13324
{
	// Fields
	private List<XmlEventCache.XmlEvent[]> pages; // 0x28
	private XmlEventCache.XmlEvent[] pageCurr; // 0x30
	private int pageSize; // 0x38
	private bool hasRootNode; // 0x3C
	private StringConcat singleText; // 0x40
	private string baseUri; // 0x78

	// Methods

	// RVA: 0x338BC24 Offset: 0x3387C24 VA: 0x338BC24
	public void .ctor(string baseUri, bool hasRootNode) { }

	// RVA: 0x338C770 Offset: 0x3388770 VA: 0x338C770
	public void EndEvents() { }

	// RVA: 0x338C784 Offset: 0x3388784 VA: 0x338C784
	public void EventsToWriter(XmlWriter writer) { }

	// RVA: 0x33906DC Offset: 0x338C6DC VA: 0x33906DC Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x3390770 Offset: 0x338C770 VA: 0x3390770 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x33907F0 Offset: 0x338C7F0 VA: 0x33907F0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x3390804 Offset: 0x338C804 VA: 0x3390804 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x339080C Offset: 0x338C80C VA: 0x339080C Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x339086C Offset: 0x338C86C VA: 0x339086C Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x3390878 Offset: 0x338C878 VA: 0x3390878 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x33908FC Offset: 0x338C8FC VA: 0x33908FC Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x3390908 Offset: 0x338C908 VA: 0x3390908 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x339092C Offset: 0x338C92C VA: 0x339092C Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x339095C Offset: 0x338C95C VA: 0x339095C Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x339098C Offset: 0x338C98C VA: 0x339098C Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x3390998 Offset: 0x338C998 VA: 0x3390998 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x33909A4 Offset: 0x338C9A4 VA: 0x33909A4 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x3390A64 Offset: 0x338CA64 VA: 0x3390A64 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x3390AF0 Offset: 0x338CAF0 VA: 0x3390AF0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x3390BD0 Offset: 0x338CBD0 VA: 0x3390BD0 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x3390BFC Offset: 0x338CBFC VA: 0x3390BFC Slot: 28
	public override void Close() { }

	// RVA: 0x3390C04 Offset: 0x338CC04 VA: 0x3390C04 Slot: 29
	public override void Flush() { }

	// RVA: 0x3390C0C Offset: 0x338CC0C VA: 0x3390C0C Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0x3390C1C Offset: 0x338CC1C VA: 0x3390C1C Slot: 34
	protected override void Dispose(bool disposing) { }

	// RVA: 0x3390CCC Offset: 0x338CCCC VA: 0x3390CCC Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x3390D38 Offset: 0x338CD38 VA: 0x3390D38 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x3390D44 Offset: 0x338CD44 VA: 0x3390D44 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x3390D4C Offset: 0x338CD4C VA: 0x3390D4C Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x3390D60 Offset: 0x338CD60 VA: 0x3390D60 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x3390D74 Offset: 0x338CD74 VA: 0x3390D74 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x3390D84 Offset: 0x338CD84 VA: 0x3390D84 Slot: 46
	internal override void WriteEndBase64() { }

	// RVA: 0x3390694 Offset: 0x338C694 VA: 0x3390694
	private void AddEvent(XmlEventCache.XmlEventType eventType) { }

	// RVA: 0x3390818 Offset: 0x338C818 VA: 0x3390818
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1) { }

	// RVA: 0x3390888 Offset: 0x338C888 VA: 0x3390888
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2) { }

	// RVA: 0x3390784 Offset: 0x338C784 VA: 0x3390784
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3) { }

	// RVA: 0x33906F4 Offset: 0x338C6F4 VA: 0x33906F4
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o) { }

	// RVA: 0x3390A10 Offset: 0x338CA10 VA: 0x3390A10
	private void AddEvent(XmlEventCache.XmlEventType eventType, object o) { }

	// RVA: 0x3390D8C Offset: 0x338CD8C VA: 0x3390D8C
	private int NewEvent() { }

	// RVA: 0x3390B1C Offset: 0x338CB1C VA: 0x3390B1C
	private static byte[] ToBytes(byte[] buffer, int index, int count) { }
}
