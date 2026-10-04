// Assembly: System.Xml.dll
// Namespace: MS.Internal.Xml.XPath
internal class Filter : AstNode // TypeDefIndex: 13876
{
	// Fields
	private AstNode _input; // 0x10
	private AstNode _condition; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x338272C Offset: 0x337E72C VA: 0x338272C
	public void .ctor(AstNode input, AstNode condition) { }

	// RVA: 0x3382770 Offset: 0x337E770 VA: 0x3382770 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x3382778 Offset: 0x337E778 VA: 0x3382778 Slot: 5
	public override XPathResultType get_ReturnType() { }
}
