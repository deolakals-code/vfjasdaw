// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class RuntimeVariablesInstruction : Instruction // TypeDefIndex: 15593
{
	// Fields
	private readonly int _count; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3170CB8 Offset: 0x316CCB8 VA: 0x3170CB8
	public void .ctor(int count) { }

	// RVA: 0x3170CE0 Offset: 0x316CCE0 VA: 0x3170CE0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3170CE8 Offset: 0x316CCE8 VA: 0x3170CE8 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3170CF0 Offset: 0x316CCF0 VA: 0x3170CF0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3170D30 Offset: 0x316CD30 VA: 0x3170D30 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}
