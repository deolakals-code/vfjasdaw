// Assembly: System.Xml.dll
// Namespace: MS.Internal.Xml.XPath
internal class Operand : AstNode // TypeDefIndex: 13880
{
	// Fields
	private XPathResultType _type; // 0x10
	private object _val; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x3382B74 Offset: 0x337EB74 VA: 0x3382B74
	public void .ctor(string val) { }

	// RVA: 0x3382BAC Offset: 0x337EBAC VA: 0x3382BAC
	public void .ctor(double val) { }

	// RVA: 0x3382C28 Offset: 0x337EC28 VA: 0x3382C28 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x3382C30 Offset: 0x337EC30 VA: 0x3382C30 Slot: 5
	public override XPathResultType get_ReturnType() { }
}
