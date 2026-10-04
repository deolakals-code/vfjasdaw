// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal abstract class InteriorNode : SyntaxTreeNode // TypeDefIndex: 13602
{
	// Fields
	private SyntaxTreeNode leftChild; // 0x10
	private SyntaxTreeNode rightChild; // 0x18

	// Properties
	public SyntaxTreeNode LeftChild { get; set; }
	public SyntaxTreeNode RightChild { get; set; }

	// Methods

	// RVA: 0x341D524 Offset: 0x3419524 VA: 0x341D524
	public SyntaxTreeNode get_LeftChild() { }

	// RVA: 0x341D52C Offset: 0x341952C VA: 0x341D52C
	public void set_LeftChild(SyntaxTreeNode value) { }

	// RVA: 0x341D534 Offset: 0x3419534 VA: 0x341D534
	public SyntaxTreeNode get_RightChild() { }

	// RVA: 0x341D53C Offset: 0x341953C VA: 0x341D53C
	public void set_RightChild(SyntaxTreeNode value) { }

	// RVA: 0x341D544 Offset: 0x3419544 VA: 0x341D544
	protected void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x341D72C Offset: 0x341972C VA: 0x341D72C Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x341D790 Offset: 0x3419790 VA: 0x341D790
	protected void .ctor() { }
}
