// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class LeafNode : SyntaxTreeNode // TypeDefIndex: 13600
{
	// Fields
	private int pos; // 0x10

	// Properties
	public int Pos { get; set; }
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x341CEFC Offset: 0x3418EFC VA: 0x341CEFC
	public void .ctor(int pos) { }

	// RVA: 0x341CF24 Offset: 0x3418F24 VA: 0x341CF24
	public int get_Pos() { }

	// RVA: 0x341CF2C Offset: 0x3418F2C VA: 0x341CF2C
	public void set_Pos(int value) { }

	// RVA: 0x341CF34 Offset: 0x3418F34 VA: 0x341CF34 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x341CF38 Offset: 0x3418F38 VA: 0x341CF38 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x341CF78 Offset: 0x3418F78 VA: 0x341CF78 Slot: 6
	public override bool get_IsNullable() { }
}
