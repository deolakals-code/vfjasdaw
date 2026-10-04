// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class NamespaceListNode : SyntaxTreeNode // TypeDefIndex: 13601
{
	// Fields
	protected NamespaceList namespaceList; // 0x10
	protected object particle; // 0x18

	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x341CF80 Offset: 0x3418F80 VA: 0x341CF80
	public void .ctor(NamespaceList namespaceList, object particle) { }

	// RVA: 0x341CFC4 Offset: 0x3418FC4 VA: 0x341CFC4 Slot: 8
	public virtual ICollection GetResolvedSymbols(SymbolsDictionary symbols) { }

	// RVA: 0x341CFE4 Offset: 0x3418FE4 VA: 0x341CFE4 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x341D4B4 Offset: 0x34194B4 VA: 0x341D4B4 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x341D4EC Offset: 0x34194EC VA: 0x341D4EC Slot: 6
	public override bool get_IsNullable() { }
}
