// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class OffsetInstruction : Instruction // TypeDefIndex: 15392
{
	// Fields
	protected int _offset; // 0x10

	// Properties
	public abstract Instruction[] Cache { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Instruction[] get_Cache();

	// RVA: 0x31485D4 Offset: 0x31445D4 VA: 0x31485D4
	public Instruction Fixup(int offset) { }

	// RVA: 0x3148674 Offset: 0x3144674 VA: 0x3148674 Slot: 10
	public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects) { }

	// RVA: 0x314873C Offset: 0x314473C VA: 0x314873C Slot: 3
	public override string ToString() { }

	// RVA: 0x3148808 Offset: 0x3144808 VA: 0x3148808
	protected void .ctor() { }
}
