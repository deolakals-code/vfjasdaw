// Assembly: System.Xml.dll
// Namespace: MS.Internal.Xml.XPath
internal abstract class AstNode // TypeDefIndex: 13873
{
	// Properties
	public abstract AstNode.AstType Type { get; }
	public abstract XPathResultType ReturnType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract AstNode.AstType get_Type();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract XPathResultType get_ReturnType();

	// RVA: 0x3382588 Offset: 0x337E588 VA: 0x3382588
	protected void .ctor() { }
}
