// Assembly: System.Xml.dll
// Namespace: MS.Internal.Xml.XPath
internal class Function : AstNode // TypeDefIndex: 13878
{
	// Fields
	private Function.FunctionType _functionType; // 0x10
	private List<AstNode> _argumentList; // 0x18
	private string _name; // 0x20
	private string _prefix; // 0x28
	internal static XPathResultType[] ReturnTypes; // 0x0

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x3382780 Offset: 0x337E780 VA: 0x3382780
	public void .ctor(Function.FunctionType ftype, List<AstNode> argumentList) { }

	// RVA: 0x3382820 Offset: 0x337E820 VA: 0x3382820
	public void .ctor(string prefix, string name, List<AstNode> argumentList) { }

	// RVA: 0x33828E8 Offset: 0x337E8E8 VA: 0x33828E8
	public void .ctor(Function.FunctionType ftype, AstNode arg) { }

	// RVA: 0x3382A0C Offset: 0x337EA0C VA: 0x3382A0C Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x3382A14 Offset: 0x337EA14 VA: 0x3382A14 Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x3382A94 Offset: 0x337EA94 VA: 0x3382A94
	private static void .cctor() { }
}
