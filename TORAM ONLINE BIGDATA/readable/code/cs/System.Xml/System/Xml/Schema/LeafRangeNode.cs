// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal sealed class LeafRangeNode : LeafNode // TypeDefIndex: 13609
{
	// Fields
	private Decimal min; // 0x18
	private Decimal max; // 0x28
	private BitSet nextIteration; // 0x38

	// Properties
	public Decimal Max { get; }
	public Decimal Min { get; }
	public BitSet NextIteration { get; set; }
	public override bool IsRangeNode { get; }

	// Methods

	// RVA: 0x341E1B8 Offset: 0x341A1B8 VA: 0x341E1B8
	public void .ctor(Decimal min, Decimal max) { }

	// RVA: 0x341E200 Offset: 0x341A200 VA: 0x341E200
	public void .ctor(int pos, Decimal min, Decimal max) { }

	// RVA: 0x341E250 Offset: 0x341A250 VA: 0x341E250
	public Decimal get_Max() { }

	// RVA: 0x341E25C Offset: 0x341A25C VA: 0x341E25C
	public Decimal get_Min() { }

	// RVA: 0x341E268 Offset: 0x341A268 VA: 0x341E268
	public BitSet get_NextIteration() { }

	// RVA: 0x341E270 Offset: 0x341A270 VA: 0x341E270
	public void set_NextIteration(BitSet value) { }

	// RVA: 0x341E278 Offset: 0x341A278 VA: 0x341E278 Slot: 7
	public override bool get_IsRangeNode() { }

	// RVA: 0x341E280 Offset: 0x341A280 VA: 0x341E280 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }
}
