// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class DataTextWriter : XmlWriter // TypeDefIndex: 14796
{
	// Fields
	private XmlWriter _xmltextWriter; // 0x18

	// Properties
	internal Stream BaseStream { get; }
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0x3244940 Offset: 0x3240940 VA: 0x3244940
	internal static XmlWriter CreateWriter(XmlWriter xw) { }

	// RVA: 0x3246FE4 Offset: 0x3242FE4 VA: 0x3246FE4
	private void .ctor(XmlWriter w) { }

	// RVA: 0x3247014 Offset: 0x3243014 VA: 0x3247014
	internal Stream get_BaseStream() { }

	// RVA: 0x32470A8 Offset: 0x32430A8 VA: 0x32470A8 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x32470C8 Offset: 0x32430C8 VA: 0x32470C8 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x32470EC Offset: 0x32430EC VA: 0x32470EC Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x324710C Offset: 0x324310C VA: 0x324710C Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x324712C Offset: 0x324312C VA: 0x324712C Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x324714C Offset: 0x324314C VA: 0x324714C Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x324716C Offset: 0x324316C VA: 0x324716C Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x324718C Offset: 0x324318C VA: 0x324718C Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x32471AC Offset: 0x32431AC VA: 0x32471AC Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x32471D0 Offset: 0x32431D0 VA: 0x32471D0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x32471F4 Offset: 0x32431F4 VA: 0x32471F4 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x3247218 Offset: 0x3243218 VA: 0x3247218 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x324723C Offset: 0x324323C VA: 0x324723C Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x3247260 Offset: 0x3243260 VA: 0x3247260 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x3247284 Offset: 0x3243284 VA: 0x3247284 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x32472A8 Offset: 0x32432A8 VA: 0x32472A8 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x32472CC Offset: 0x32432CC VA: 0x32472CC Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x32472F0 Offset: 0x32432F0 VA: 0x32472F0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x3247314 Offset: 0x3243314 VA: 0x3247314 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x3247338 Offset: 0x3243338 VA: 0x3247338 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x324735C Offset: 0x324335C VA: 0x324735C Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x3247380 Offset: 0x3243380 VA: 0x3247380 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x32473A4 Offset: 0x32433A4 VA: 0x32473A4 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x32473C8 Offset: 0x32433C8 VA: 0x32473C8 Slot: 28
	public override void Close() { }

	// RVA: 0x32473EC Offset: 0x32433EC VA: 0x32473EC Slot: 29
	public override void Flush() { }

	// RVA: 0x3247410 Offset: 0x3243410 VA: 0x3247410 Slot: 30
	public override string LookupPrefix(string ns) { }
}
