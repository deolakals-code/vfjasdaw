// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal class ByRefMethodInfoCallInstruction : MethodInfoCallInstruction // TypeDefIndex: 15391
{
	// Fields
	private readonly ByRefUpdater[] _byrefArgs; // 0x20

	// Properties
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x3148020 Offset: 0x3144020 VA: 0x3148020
	internal void .ctor(MethodInfo target, int argumentCount, ByRefUpdater[] byrefArgs) { }

	// RVA: 0x3148074 Offset: 0x3144074 VA: 0x3148074 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3148124 Offset: 0x3144124 VA: 0x3148124 Slot: 8
	public sealed override int Run(InterpretedFrame frame) { }
}
