// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal abstract class SyntaxTreeNode // TypeDefIndex: 13599
{
	// Properties
	public abstract bool IsNullable { get; }
	public virtual bool IsRangeNode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsNullable();

	// RVA: 0x341CEEC Offset: 0x3418EEC VA: 0x341CEEC Slot: 7
	public virtual bool get_IsRangeNode() { }

	// RVA: 0x341CEF4 Offset: 0x3418EF4 VA: 0x341CEF4
	protected void .ctor() { }
}
