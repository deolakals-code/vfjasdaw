// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal class ByRefNewInstruction : NewInstruction // TypeDefIndex: 15634
{
	// Fields
	private readonly ByRefUpdater[] _byrefArgs; // 0x20

	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3175800 Offset: 0x3171800 VA: 0x3175800
	internal void .ctor(ConstructorInfo target, int argumentCount, ByRefUpdater[] byrefArgs) { }

	// RVA: 0x3175854 Offset: 0x3171854 VA: 0x3175854 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3175894 Offset: 0x3171894 VA: 0x3175894 Slot: 8
	public sealed override int Run(InterpretedFrame frame) { }
}
