// Assembly: System.Xml.dll
// Namespace: MS.Internal.Xml.XPath
internal class Operator : AstNode // TypeDefIndex: 13882
{
	// Fields
	private static Operator.Op[] s_invertOp; // 0x0
	private Operator.Op _opType; // 0x10
	private AstNode _opnd1; // 0x18
	private AstNode _opnd2; // 0x20

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x3382C38 Offset: 0x337EC38 VA: 0x3382C38
	public void .ctor(Operator.Op op, AstNode opnd1, AstNode opnd2) { }

	// RVA: 0x3382C8C Offset: 0x337EC8C VA: 0x3382C8C Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x3382C94 Offset: 0x337EC94 VA: 0x3382C94 Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x3382CB8 Offset: 0x337ECB8 VA: 0x3382CB8
	private static void .cctor() { }
}
