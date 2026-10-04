// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class XmlWellFormedWriter : XmlWriter // TypeDefIndex: 13373
{
	// Fields
	private XmlWriter writer; // 0x18
	private XmlRawWriter rawWriter; // 0x20
	private IXmlNamespaceResolver predefinedNamespaces; // 0x28
	private XmlWellFormedWriter.Namespace[] nsStack; // 0x30
	private int nsTop; // 0x38
	private Dictionary<string, int> nsHashtable; // 0x40
	private bool useNsHashtable; // 0x48
	private XmlWellFormedWriter.ElementScope[] elemScopeStack; // 0x50
	private int elemTop; // 0x58
	private XmlWellFormedWriter.AttrName[] attrStack; // 0x60
	private int attrCount; // 0x68
	private Dictionary<string, int> attrHashTable; // 0x70
	private XmlWellFormedWriter.SpecialAttribute specAttr; // 0x78
	private XmlWellFormedWriter.AttributeValueCache attrValueCache; // 0x80
	private string curDeclPrefix; // 0x88
	private XmlWellFormedWriter.State[] stateTable; // 0x90
	private XmlWellFormedWriter.State currentState; // 0x98
	private bool checkCharacters; // 0x9C
	private bool omitDuplNamespaces; // 0x9D
	private bool writeEndDocumentOnClose; // 0x9E
	private ConformanceLevel conformanceLevel; // 0xA0
	private bool dtdWritten; // 0xA4
	private bool xmlDeclFollows; // 0xA5
	private XmlCharType xmlCharType; // 0xA8
	private SecureStringHasher hasher; // 0xB0
	internal static readonly string[] stateName; // 0x0
	internal static readonly string[] tokenName; // 0x8
	private static WriteState[] state2WriteState; // 0x10
	private static readonly XmlWellFormedWriter.State[] StateTableDocument; // 0x18
	private static readonly XmlWellFormedWriter.State[] StateTableAuto; // 0x20

	// Properties
	public override WriteState WriteState { get; }
	internal XmlRawWriter RawWriter { get; }
	private bool SaveAttrValue { get; }
	private bool InBase64 { get; }
	private bool IsClosedOrErrorState { get; }

	// Methods

	// RVA: 0x33A1C50 Offset: 0x339DC50 VA: 0x33A1C50
	internal void .ctor(XmlWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x33A2250 Offset: 0x339E250 VA: 0x33A2250 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x33A22E4 Offset: 0x339E2E4 VA: 0x33A22E4 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x33A24A0 Offset: 0x339E4A0 VA: 0x33A24A0 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x33A24BC Offset: 0x339E4BC VA: 0x33A24BC Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x33A2910 Offset: 0x339E910 VA: 0x33A2910 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x33A2DCC Offset: 0x339EDCC VA: 0x33A2DCC Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x33A37C4 Offset: 0x339F7C4 VA: 0x33A37C4 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x33A3AAC Offset: 0x339FAAC VA: 0x33A3AAC Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x33A3CC0 Offset: 0x339FCC0 VA: 0x33A3CC0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x33A48D4 Offset: 0x33A08D4 VA: 0x33A48D4 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x33A5620 Offset: 0x33A1620 VA: 0x33A5620 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x33A5724 Offset: 0x33A1724 VA: 0x33A5724 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x33A5828 Offset: 0x33A1828 VA: 0x33A5828 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x33A5ACC Offset: 0x33A1ACC VA: 0x33A5ACC Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x33A5C40 Offset: 0x33A1C40 VA: 0x33A5C40 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x33A5DE4 Offset: 0x33A1DE4 VA: 0x33A5DE4 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x33A5F8C Offset: 0x33A1F8C VA: 0x33A5F8C Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x33A6144 Offset: 0x33A2144 VA: 0x33A6144 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x33A6238 Offset: 0x33A2238 VA: 0x33A6238 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x33A6498 Offset: 0x33A2498 VA: 0x33A6498 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x33A66F8 Offset: 0x33A26F8 VA: 0x33A66F8 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x33A67EC Offset: 0x33A27EC VA: 0x33A67EC Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x33A6A1C Offset: 0x33A2A1C VA: 0x33A6A1C Slot: 28
	public override void Close() { }

	// RVA: 0x33A6C00 Offset: 0x33A2C00 VA: 0x33A6C00 Slot: 29
	public override void Flush() { }

	// RVA: 0x33A6CB4 Offset: 0x33A2CB4 VA: 0x33A6CB4 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x33A6F30 Offset: 0x33A2F30 VA: 0x33A6F30 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0x33A7034 Offset: 0x33A3034 VA: 0x33A7034 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x33A7170 Offset: 0x33A3170 VA: 0x33A7170
	internal XmlRawWriter get_RawWriter() { }

	// RVA: 0x33A5C30 Offset: 0x33A1C30 VA: 0x33A5C30
	private bool get_SaveAttrValue() { }

	// RVA: 0x33A6BD8 Offset: 0x33A2BD8 VA: 0x33A6BD8
	private bool get_InBase64() { }

	// RVA: 0x33A4388 Offset: 0x33A0388 VA: 0x33A4388
	private void SetSpecialAttribute(XmlWellFormedWriter.SpecialAttribute special) { }

	// RVA: 0x33A22EC Offset: 0x339E2EC VA: 0x33A22EC
	private void WriteStartDocumentImpl(XmlStandalone standalone) { }

	// RVA: 0x33A7178 Offset: 0x33A3178 VA: 0x33A7178
	private void StartFragment() { }

	// RVA: 0x33A33C8 Offset: 0x339F3C8 VA: 0x33A33C8
	private void PushNamespaceImplicit(string prefix, string ns) { }

	// RVA: 0x33A5168 Offset: 0x33A1168 VA: 0x33A5168
	private bool PushNamespaceExplicit(string prefix, string ns) { }

	// RVA: 0x33A7260 Offset: 0x33A3260 VA: 0x33A7260
	private void AddNamespace(string prefix, string ns, XmlWellFormedWriter.NamespaceKind kind) { }

	// RVA: 0x33A7528 Offset: 0x33A3528 VA: 0x33A7528
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x33A7184 Offset: 0x33A3184 VA: 0x33A7184
	private int LookupNamespaceIndex(string prefix) { }

	// RVA: 0x33A39D8 Offset: 0x339F9D8 VA: 0x33A39D8
	private void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x33A7418 Offset: 0x33A3418 VA: 0x33A7418
	private static XmlException DupAttrException(string prefix, string localName) { }

	// RVA: 0x33A260C Offset: 0x339E60C VA: 0x33A260C
	private void AdvanceState(XmlWellFormedWriter.Token token) { }

	// RVA: 0x33A788C Offset: 0x33A388C VA: 0x33A788C
	private void StartElementContent() { }

	// RVA: 0x33A7610 Offset: 0x33A3610 VA: 0x33A7610
	private static string GetStateName(XmlWellFormedWriter.State state) { }

	// RVA: 0x33A3288 Offset: 0x339F288 VA: 0x33A3288
	internal string LookupNamespace(string prefix) { }

	// RVA: 0x33A455C Offset: 0x33A055C VA: 0x33A455C
	private string LookupLocalNamespace(string prefix) { }

	// RVA: 0x33A4428 Offset: 0x33A0428 VA: 0x33A4428
	private string GeneratePrefix() { }

	// RVA: 0x33A3188 Offset: 0x339F188 VA: 0x33A3188
	private void CheckNCName(string ncname) { }

	// RVA: 0x33A7A90 Offset: 0x33A3A90 VA: 0x33A7A90
	private static Exception InvalidCharsException(string name, int badCharIndex) { }

	// RVA: 0x33A76B0 Offset: 0x33A36B0 VA: 0x33A76B0
	private void ThrowInvalidStateTransition(XmlWellFormedWriter.Token token, XmlWellFormedWriter.State currentState) { }

	// RVA: 0x33A7160 Offset: 0x33A3160 VA: 0x33A7160
	private bool get_IsClosedOrErrorState() { }

	// RVA: 0x33A462C Offset: 0x33A062C VA: 0x33A462C
	private void AddAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x33A7BD4 Offset: 0x33A3BD4 VA: 0x33A7BD4
	private void AddToAttrHashTable(int attributeIndex) { }

	// RVA: 0x33A7D08 Offset: 0x33A3D08 VA: 0x33A7D08
	private static void .cctor() { }
}
