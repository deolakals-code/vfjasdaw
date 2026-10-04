// Assembly: System.Xml.dll
// Namespace: System.Xml
[EditorBrowsable(1)]
public class XmlTextWriter : XmlWriter // TypeDefIndex: 13354
{
	// Fields
	private TextWriter textWriter; // 0x18
	private XmlTextEncoder xmlEncoder; // 0x20
	private Encoding encoding; // 0x28
	private Formatting formatting; // 0x30
	private bool indented; // 0x34
	private int indentation; // 0x38
	private char indentChar; // 0x3C
	private XmlTextWriter.TagInfo[] stack; // 0x40
	private int top; // 0x48
	private XmlTextWriter.State[] stateTable; // 0x50
	private XmlTextWriter.State currentState; // 0x58
	private XmlTextWriter.Token lastToken; // 0x5C
	private XmlTextWriterBase64Encoder base64Encoder; // 0x60
	private char quoteChar; // 0x68
	private char curQuoteChar; // 0x6A
	private bool namespaces; // 0x6C
	private XmlTextWriter.SpecialAttr specialAttr; // 0x70
	private string prefixForXmlNs; // 0x78
	private bool flush; // 0x80
	private XmlTextWriter.Namespace[] nsStack; // 0x88
	private int nsTop; // 0x90
	private Dictionary<string, int> nsHashtable; // 0x98
	private bool useNsHashtable; // 0xA0
	private XmlCharType xmlCharType; // 0xA8
	private static string[] stateName; // 0x0
	private static string[] tokenName; // 0x8
	private static readonly XmlTextWriter.State[] stateTableDefault; // 0x10
	private static readonly XmlTextWriter.State[] stateTableDocument; // 0x18

	// Properties
	public Stream BaseStream { get; }
	public bool Namespaces { set; }
	public Formatting Formatting { set; }
	public char QuoteChar { set; }
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0x33977B8 Offset: 0x33937B8 VA: 0x33977B8
	internal void .ctor() { }

	// RVA: 0x33979A4 Offset: 0x33939A4 VA: 0x33979A4
	public void .ctor(Stream w, Encoding encoding) { }

	// RVA: 0x3397AA4 Offset: 0x3393AA4 VA: 0x3397AA4
	public void .ctor(string filename, Encoding encoding) { }

	// RVA: 0x3397B24 Offset: 0x3393B24 VA: 0x3397B24
	public void .ctor(TextWriter w) { }

	// RVA: 0x3397BE4 Offset: 0x3393BE4 VA: 0x3397BE4
	public Stream get_BaseStream() { }

	// RVA: 0x3397C80 Offset: 0x3393C80 VA: 0x3397C80
	public void set_Namespaces(bool value) { }

	// RVA: 0x3397CF4 Offset: 0x3393CF4 VA: 0x3397CF4
	public void set_Formatting(Formatting value) { }

	// RVA: 0x3397D08 Offset: 0x3393D08 VA: 0x3397D08
	public void set_QuoteChar(char value) { }

	// RVA: 0x3397D94 Offset: 0x3393D94 VA: 0x3397D94 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x3398138 Offset: 0x3394138 VA: 0x3398138 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x339814C Offset: 0x339414C VA: 0x339814C Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x3398364 Offset: 0x3394364 VA: 0x3398364 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x3398E48 Offset: 0x3394E48 VA: 0x3398E48 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x33998FC Offset: 0x33958FC VA: 0x33998FC Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x3399BE0 Offset: 0x3395BE0 VA: 0x3399BE0 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x3399BE8 Offset: 0x3395BE8 VA: 0x3399BE8 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x339A4D4 Offset: 0x33964D4 VA: 0x339A4D4 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x339A574 Offset: 0x3396574 VA: 0x339A574 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x339A738 Offset: 0x3396738 VA: 0x339A738 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x339A938 Offset: 0x3396938 VA: 0x339A938 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x339AC64 Offset: 0x3396C64 VA: 0x339AC64 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x339AD30 Offset: 0x3396D30 VA: 0x339AD30 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x339ADF0 Offset: 0x3396DF0 VA: 0x339ADF0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x339AF5C Offset: 0x3396F5C VA: 0x339AF5C Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x339B028 Offset: 0x3397028 VA: 0x339B028 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x339B0F0 Offset: 0x33970F0 VA: 0x339B0F0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x339B1C8 Offset: 0x33971C8 VA: 0x339B1C8 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x339B2A0 Offset: 0x33972A0 VA: 0x339B2A0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x339B360 Offset: 0x3397360 VA: 0x339B360 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x339B4B8 Offset: 0x33974B8 VA: 0x339B4B8 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x339B588 Offset: 0x3397588 VA: 0x339B588 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x339B5AC Offset: 0x33975AC VA: 0x339B5AC Slot: 28
	public override void Close() { }

	// RVA: 0x339B6E4 Offset: 0x33976E4 VA: 0x339B6E4 Slot: 29
	public override void Flush() { }

	// RVA: 0x339B704 Offset: 0x3397704 VA: 0x339B704 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x3397D9C Offset: 0x3393D9C VA: 0x3397D9C
	private void StartDocument(int standalone) { }

	// RVA: 0x339894C Offset: 0x339494C VA: 0x339894C
	private void AutoComplete(XmlTextWriter.Token token) { }

	// RVA: 0x3398310 Offset: 0x3394310 VA: 0x3398310
	private void AutoCompleteAll() { }

	// RVA: 0x3399904 Offset: 0x3395904 VA: 0x3399904
	private void InternalWriteEndElement(bool longFormat) { }

	// RVA: 0x339B920 Offset: 0x3397920 VA: 0x339B920
	private void WriteEndStartTag(bool empty) { }

	// RVA: 0x339B8D4 Offset: 0x33978D4 VA: 0x339B8D4
	private void WriteEndAttributeQuote() { }

	// RVA: 0x339B804 Offset: 0x3397804 VA: 0x339B804
	private void Indent(bool beforeEndElement) { }

	// RVA: 0x3399544 Offset: 0x3395544 VA: 0x3399544
	private void PushNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x339BF80 Offset: 0x3397F80 VA: 0x339BF80
	private void AddNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x339C198 Offset: 0x3398198 VA: 0x339C198
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x339BC90 Offset: 0x3397C90 VA: 0x339BC90
	private void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x339A3C0 Offset: 0x33963C0 VA: 0x339A3C0
	private string GeneratePrefix() { }

	// RVA: 0x339AB68 Offset: 0x3396B68 VA: 0x339AB68
	private void InternalWriteProcessingInstruction(string name, string text) { }

	// RVA: 0x3399398 Offset: 0x3395398 VA: 0x3399398
	private int LookupNamespace(string prefix) { }

	// RVA: 0x339A294 Offset: 0x3396294 VA: 0x339A294
	private int LookupNamespaceInCurrentScope(string prefix) { }

	// RVA: 0x3399474 Offset: 0x3395474 VA: 0x3399474
	private string FindPrefix(string ns) { }

	// RVA: 0x3398794 Offset: 0x3394794 VA: 0x3398794
	private void ValidateName(string name, bool isNCName) { }

	// RVA: 0x339BD64 Offset: 0x3397D64 VA: 0x339BD64
	private void HandleSpecialAttribute() { }

	// RVA: 0x339979C Offset: 0x339579C VA: 0x339979C
	private void VerifyPrefixXml(string prefix, string ns) { }

	// RVA: 0x33992B8 Offset: 0x33952B8 VA: 0x33992B8
	private void PushStack() { }

	// RVA: 0x339BC6C Offset: 0x3397C6C VA: 0x339BC6C
	private void FlushEncoders() { }

	// RVA: 0x339C280 Offset: 0x3398280 VA: 0x339C280
	private static void .cctor() { }
}
