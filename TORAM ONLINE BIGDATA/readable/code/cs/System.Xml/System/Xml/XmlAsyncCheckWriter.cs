// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class XmlAsyncCheckWriter : XmlWriter // TypeDefIndex: 13318
{
	// Fields
	private readonly XmlWriter coreWriter; // 0x18
	private Task lastTask; // 0x20

	// Properties
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0x338B318 Offset: 0x3387318 VA: 0x338B318
	public void .ctor(XmlWriter writer) { }

	// RVA: 0x338B3A4 Offset: 0x33873A4 VA: 0x338B3A4
	private void CheckAsync() { }

	// RVA: 0x338B420 Offset: 0x3387420 VA: 0x338B420 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x338B448 Offset: 0x3387448 VA: 0x338B448 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x338B480 Offset: 0x3387480 VA: 0x338B480 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x338B4A8 Offset: 0x33874A8 VA: 0x338B4A8 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x338B500 Offset: 0x3387500 VA: 0x338B500 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x338B550 Offset: 0x3387550 VA: 0x338B550 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x338B578 Offset: 0x3387578 VA: 0x338B578 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x338B5A0 Offset: 0x33875A0 VA: 0x338B5A0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x338B5F0 Offset: 0x33875F0 VA: 0x338B5F0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x338B61C Offset: 0x338761C VA: 0x338B61C Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x338B658 Offset: 0x3387658 VA: 0x338B658 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x338B694 Offset: 0x3387694 VA: 0x338B694 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x338B6D8 Offset: 0x33876D8 VA: 0x338B6D8 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x338B714 Offset: 0x3387714 VA: 0x338B714 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x338B750 Offset: 0x3387750 VA: 0x338B750 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x338B78C Offset: 0x338778C VA: 0x338B78C Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x338B7C8 Offset: 0x33877C8 VA: 0x338B7C8 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x338B80C Offset: 0x338780C VA: 0x338B80C Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x338B860 Offset: 0x3387860 VA: 0x338B860 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x338B8B4 Offset: 0x33878B4 VA: 0x338B8B4 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x338B8F0 Offset: 0x33878F0 VA: 0x338B8F0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x338B944 Offset: 0x3387944 VA: 0x338B944 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x338B998 Offset: 0x3387998 VA: 0x338B998 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x338B9C4 Offset: 0x33879C4 VA: 0x338B9C4 Slot: 28
	public override void Close() { }

	// RVA: 0x338B9F0 Offset: 0x33879F0 VA: 0x338B9F0 Slot: 29
	public override void Flush() { }

	// RVA: 0x338BA1C Offset: 0x3387A1C VA: 0x338BA1C Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x338BA58 Offset: 0x3387A58 VA: 0x338BA58 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0x338BA94 Offset: 0x3387A94 VA: 0x338BA94 Slot: 32
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x338BAD8 Offset: 0x3387AD8 VA: 0x338BAD8 Slot: 33
	public override void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x338BB1C Offset: 0x3387B1C VA: 0x338BB1C Slot: 34
	protected override void Dispose(bool disposing) { }
}
