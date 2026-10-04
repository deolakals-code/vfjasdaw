// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ArrayByRefUpdater : ByRefUpdater // TypeDefIndex: 15564
{
	// Fields
	private readonly LocalDefinition _array; // 0x18
	private readonly LocalDefinition _index; // 0x28

	// Methods

	// RVA: 0x316B8F4 Offset: 0x31678F4 VA: 0x316B8F4
	public void .ctor(LocalDefinition array, LocalDefinition index, int argumentIndex) { }

	// RVA: 0x316B960 Offset: 0x3167960 VA: 0x316B960 Slot: 4
	public override void Update(InterpretedFrame frame, object value) { }

	// RVA: 0x316BA6C Offset: 0x3167A6C VA: 0x316BA6C Slot: 5
	public override void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}
