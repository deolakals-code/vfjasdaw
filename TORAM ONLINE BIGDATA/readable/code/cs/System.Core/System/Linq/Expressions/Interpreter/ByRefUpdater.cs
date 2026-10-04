// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class ByRefUpdater // TypeDefIndex: 15562
{
	// Fields
	public readonly int ArgumentIndex; // 0x10

	// Methods

	// RVA: 0x316B68C Offset: 0x316768C VA: 0x316B68C
	public void .ctor(int argumentIndex) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Update(InterpretedFrame frame, object value);

	// RVA: 0x316B6B4 Offset: 0x31676B4 VA: 0x316B6B4 Slot: 5
	public virtual void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}
