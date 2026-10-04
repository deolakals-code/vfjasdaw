// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class ValidatingReaderNodeData // TypeDefIndex: 13310
{
	// Fields
	private string localName; // 0x10
	private string namespaceUri; // 0x18
	private string prefix; // 0x20
	private string nameWPrefix; // 0x28
	private string rawValue; // 0x30
	private string originalStringValue; // 0x38
	private int depth; // 0x40
	private AttributePSVIInfo attributePSVIInfo; // 0x48
	private XmlNodeType nodeType; // 0x50
	private int lineNo; // 0x54
	private int linePos; // 0x58

	// Properties
	public string LocalName { get; set; }
	public string Namespace { get; set; }
	public string Prefix { get; set; }
	public int Depth { get; set; }
	public string RawValue { get; set; }
	public string OriginalStringValue { get; }
	public XmlNodeType NodeType { get; set; }
	public AttributePSVIInfo AttInfo { get; set; }
	public int LineNumber { get; }
	public int LinePosition { get; }

	// Methods

	// RVA: 0x33894AC Offset: 0x33854AC VA: 0x33894AC
	public void .ctor() { }

	// RVA: 0x33895A4 Offset: 0x33855A4 VA: 0x33895A4
	public void .ctor(XmlNodeType nodeType) { }

	// RVA: 0x33895D0 Offset: 0x33855D0 VA: 0x33895D0
	public string get_LocalName() { }

	// RVA: 0x33895D8 Offset: 0x33855D8 VA: 0x33895D8
	public void set_LocalName(string value) { }

	// RVA: 0x33895E0 Offset: 0x33855E0 VA: 0x33895E0
	public string get_Namespace() { }

	// RVA: 0x33895E8 Offset: 0x33855E8 VA: 0x33895E8
	public void set_Namespace(string value) { }

	// RVA: 0x33895F0 Offset: 0x33855F0 VA: 0x33895F0
	public string get_Prefix() { }

	// RVA: 0x33895F8 Offset: 0x33855F8 VA: 0x33895F8
	public void set_Prefix(string value) { }

	// RVA: 0x3389600 Offset: 0x3385600 VA: 0x3389600
	public string GetAtomizedNameWPrefix(XmlNameTable nameTable) { }

	// RVA: 0x33896A4 Offset: 0x33856A4 VA: 0x33896A4
	public int get_Depth() { }

	// RVA: 0x33896AC Offset: 0x33856AC VA: 0x33896AC
	public void set_Depth(int value) { }

	// RVA: 0x33896B4 Offset: 0x33856B4 VA: 0x33896B4
	public string get_RawValue() { }

	// RVA: 0x33896BC Offset: 0x33856BC VA: 0x33896BC
	public void set_RawValue(string value) { }

	// RVA: 0x33896C4 Offset: 0x33856C4 VA: 0x33896C4
	public string get_OriginalStringValue() { }

	// RVA: 0x33896CC Offset: 0x33856CC VA: 0x33896CC
	public XmlNodeType get_NodeType() { }

	// RVA: 0x33896D4 Offset: 0x33856D4 VA: 0x33896D4
	public void set_NodeType(XmlNodeType value) { }

	// RVA: 0x33896DC Offset: 0x33856DC VA: 0x33896DC
	public AttributePSVIInfo get_AttInfo() { }

	// RVA: 0x33896E4 Offset: 0x33856E4 VA: 0x33896E4
	public void set_AttInfo(AttributePSVIInfo value) { }

	// RVA: 0x33896EC Offset: 0x33856EC VA: 0x33896EC
	public int get_LineNumber() { }

	// RVA: 0x33896F4 Offset: 0x33856F4 VA: 0x33896F4
	public int get_LinePosition() { }

	// RVA: 0x33894CC Offset: 0x33854CC VA: 0x33894CC
	internal void Clear(XmlNodeType nodeType) { }

	// RVA: 0x33896FC Offset: 0x33856FC VA: 0x33896FC
	internal void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0x3389704 Offset: 0x3385704 VA: 0x3389704
	internal void SetLineInfo(IXmlLineInfo lineInfo) { }

	// RVA: 0x338980C Offset: 0x338580C VA: 0x338980C
	internal void SetItemData(string localName, string prefix, string ns, int depth) { }

	// RVA: 0x33898B4 Offset: 0x33858B4 VA: 0x33898B4
	internal void SetItemData(string value) { }

	// RVA: 0x33898E4 Offset: 0x33858E4 VA: 0x33898E4
	internal void SetItemData(string value, string originalStringValue) { }
}
