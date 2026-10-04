// Assembly: System.Xml.dll
// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathScanner // TypeDefIndex: 13888
{
	// Fields
	private string _xpathExpr; // 0x10
	private int _xpathExprIndex; // 0x18
	private XPathScanner.LexKind _kind; // 0x1C
	private char _currentChar; // 0x20
	private string _name; // 0x28
	private string _prefix; // 0x30
	private string _stringValue; // 0x38
	private double _numberValue; // 0x40
	private bool _canBeFunction; // 0x48
	private XmlCharType _xmlCharType; // 0x50

	// Properties
	public string SourceText { get; }
	private char CurrentChar { get; }
	public XPathScanner.LexKind Kind { get; }
	public string Name { get; }
	public string Prefix { get; }
	public string StringValue { get; }
	public double NumberValue { get; }
	public bool CanBeFunction { get; }

	// Methods

	// RVA: 0x3382EE8 Offset: 0x337EEE8 VA: 0x3382EE8
	public void .ctor(string xpathExpr) { }

	// RVA: 0x33861C0 Offset: 0x33821C0 VA: 0x33861C0
	public string get_SourceText() { }

	// RVA: 0x33861C8 Offset: 0x33821C8 VA: 0x33861C8
	private char get_CurrentChar() { }

	// RVA: 0x3386160 Offset: 0x3382160 VA: 0x3386160
	private bool NextChar() { }

	// RVA: 0x33861D0 Offset: 0x33821D0 VA: 0x33861D0
	public XPathScanner.LexKind get_Kind() { }

	// RVA: 0x33861D8 Offset: 0x33821D8 VA: 0x33861D8
	public string get_Name() { }

	// RVA: 0x33861E0 Offset: 0x33821E0 VA: 0x33861E0
	public string get_Prefix() { }

	// RVA: 0x33861E8 Offset: 0x33821E8 VA: 0x33861E8
	public string get_StringValue() { }

	// RVA: 0x33861F0 Offset: 0x33821F0 VA: 0x33861F0
	public double get_NumberValue() { }

	// RVA: 0x33861F8 Offset: 0x33821F8 VA: 0x33861F8
	public bool get_CanBeFunction() { }

	// RVA: 0x3386200 Offset: 0x3382200 VA: 0x3386200
	private void SkipSpace() { }

	// RVA: 0x3384BB4 Offset: 0x3380BB4 VA: 0x3384BB4
	public bool NextLex() { }

	// RVA: 0x338639C Offset: 0x338239C VA: 0x338639C
	private double ScanNumber() { }

	// RVA: 0x338623C Offset: 0x338223C VA: 0x338623C
	private double ScanFraction() { }

	// RVA: 0x33862EC Offset: 0x33822EC VA: 0x33862EC
	private string ScanString() { }

	// RVA: 0x3386474 Offset: 0x3382474 VA: 0x3386474
	private string ScanName() { }
}
