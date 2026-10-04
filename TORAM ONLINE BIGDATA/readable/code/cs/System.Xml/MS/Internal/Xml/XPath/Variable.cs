// Assembly: System.Xml.dll
// Namespace: MS.Internal.Xml.XPath
internal class Variable : AstNode // TypeDefIndex: 13884
{
	// Fields
	private string _localname; // 0x10
	private string _prefix; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x3382D70 Offset: 0x337ED70 VA: 0x3382D70
	public void .ctor(string name, string prefix) { }

	// RVA: 0x3382DB4 Offset: 0x337EDB4 VA: 0x3382DB4 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x3382DBC Offset: 0x337EDBC VA: 0x3382DBC Slot: 5
	public override XPathResultType get_ReturnType() { }
}
