// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class AssignLocalBoxedInstruction : LocalAccessInstruction // TypeDefIndex: 15580
{
	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x316FB64 Offset: 0x316BB64 VA: 0x316FB64
	internal void .ctor(int index) { }

	// RVA: 0x316FB8C Offset: 0x316BB8C VA: 0x316FB8C Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x316FB94 Offset: 0x316BB94 VA: 0x316FB94 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x316FB9C Offset: 0x316BB9C VA: 0x316FB9C Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x316FBDC Offset: 0x316BBDC VA: 0x316FBDC Slot: 8
	public override int Run(InterpretedFrame frame) { }
}
