// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class AssignLocalToClosureInstruction : LocalAccessInstruction // TypeDefIndex: 15582
{
	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x316FEC0 Offset: 0x316BEC0 VA: 0x316FEC0
	internal void .ctor(int index) { }

	// RVA: 0x316FEE8 Offset: 0x316BEE8 VA: 0x316FEE8 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x316FEF0 Offset: 0x316BEF0 VA: 0x316FEF0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x316FEF8 Offset: 0x316BEF8 VA: 0x316FEF8 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x316FF38 Offset: 0x316BF38 VA: 0x316FF38 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}
