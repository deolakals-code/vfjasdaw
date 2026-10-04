// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class AssignLocalInstruction : LocalAccessInstruction, IBoxableInstruction // TypeDefIndex: 15578
{
	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x316F88C Offset: 0x316B88C VA: 0x316F88C
	internal void .ctor(int index) { }

	// RVA: 0x316F8B4 Offset: 0x316B8B4 VA: 0x316F8B4 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x316F8BC Offset: 0x316B8BC VA: 0x316F8BC Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x316F8C4 Offset: 0x316B8C4 VA: 0x316F8C4 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x316F904 Offset: 0x316B904 VA: 0x316F904 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x316F984 Offset: 0x316B984 VA: 0x316F984 Slot: 11
	public Instruction BoxIfIndexMatches(int index) { }
}
