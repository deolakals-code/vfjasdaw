// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class Instruction // TypeDefIndex: 15505
{
	// Properties
	public virtual int ConsumedStack { get; }
	public virtual int ProducedStack { get; }
	public virtual int ConsumedContinuations { get; }
	public virtual int ProducedContinuations { get; }
	public int StackBalance { get; }
	public int ContinuationsBalance { get; }
	public abstract string InstructionName { get; }

	// Methods

	// RVA: 0x315318C Offset: 0x314F18C VA: 0x315318C Slot: 4
	public virtual int get_ConsumedStack() { }

	// RVA: 0x3153194 Offset: 0x314F194 VA: 0x3153194 Slot: 5
	public virtual int get_ProducedStack() { }

	// RVA: 0x315319C Offset: 0x314F19C VA: 0x315319C Slot: 6
	public virtual int get_ConsumedContinuations() { }

	// RVA: 0x31531A4 Offset: 0x314F1A4 VA: 0x31531A4 Slot: 7
	public virtual int get_ProducedContinuations() { }

	// RVA: 0x31531AC Offset: 0x314F1AC VA: 0x31531AC
	public int get_StackBalance() { }

	// RVA: 0x31531E8 Offset: 0x314F1E8 VA: 0x31531E8
	public int get_ContinuationsBalance() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int Run(InterpretedFrame frame);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_InstructionName();

	// RVA: 0x3153224 Offset: 0x314F224 VA: 0x3153224 Slot: 3
	public override string ToString() { }

	// RVA: 0x315327C Offset: 0x314F27C VA: 0x315327C Slot: 10
	public virtual string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects) { }

	// RVA: 0x314F874 Offset: 0x314B874 VA: 0x314F874
	protected static void NullCheck(object o) { }

	// RVA: 0x314F634 Offset: 0x314B634 VA: 0x314F634
	protected void .ctor() { }
}
