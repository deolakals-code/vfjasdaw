// Assembly: System.Xml.dll
// Namespace: MS.Internal.Xml.XPath
internal class Axis : AstNode // TypeDefIndex: 13875
{
	// Fields
	private Axis.AxisType _axisType; // 0x10
	private AstNode _input; // 0x18
	private string _prefix; // 0x20
	private string _name; // 0x28
	private XPathNodeType _nodeType; // 0x30
	protected bool abbrAxis; // 0x34
	private string _urn; // 0x38

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }
	public AstNode Input { get; set; }
	public string Prefix { get; }
	public string Name { get; }
	public XPathNodeType NodeType { get; }
	public Axis.AxisType TypeOfAxis { get; }
	public bool AbbrAxis { get; }
	public string Urn { get; set; }

	// Methods

	// RVA: 0x3382590 Offset: 0x337E590 VA: 0x3382590
	public void .ctor(Axis.AxisType axisType, AstNode input, string prefix, string name, XPathNodeType nodetype) { }

	// RVA: 0x3382658 Offset: 0x337E658 VA: 0x3382658
	public void .ctor(Axis.AxisType axisType, AstNode input) { }

	// RVA: 0x33826D4 Offset: 0x337E6D4 VA: 0x33826D4 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x33826DC Offset: 0x337E6DC VA: 0x33826DC Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x33826E4 Offset: 0x337E6E4 VA: 0x33826E4
	public AstNode get_Input() { }

	// RVA: 0x33826EC Offset: 0x337E6EC VA: 0x33826EC
	public void set_Input(AstNode value) { }

	// RVA: 0x33826F4 Offset: 0x337E6F4 VA: 0x33826F4
	public string get_Prefix() { }

	// RVA: 0x33826FC Offset: 0x337E6FC VA: 0x33826FC
	public string get_Name() { }

	// RVA: 0x3382704 Offset: 0x337E704 VA: 0x3382704
	public XPathNodeType get_NodeType() { }

	// RVA: 0x338270C Offset: 0x337E70C VA: 0x338270C
	public Axis.AxisType get_TypeOfAxis() { }

	// RVA: 0x3382714 Offset: 0x337E714 VA: 0x3382714
	public bool get_AbbrAxis() { }

	// RVA: 0x338271C Offset: 0x337E71C VA: 0x338271C
	public string get_Urn() { }

	// RVA: 0x3382724 Offset: 0x337E724 VA: 0x3382724
	public void set_Urn(string value) { }
}
