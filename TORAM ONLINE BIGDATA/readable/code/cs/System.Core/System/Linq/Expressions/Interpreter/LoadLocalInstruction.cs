// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadLocalInstruction : LocalAccessInstruction, IBoxableInstruction // TypeDefIndex: 15574
{
	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x316F298 Offset: 0x316B298 VA: 0x316F298
	internal void .ctor(int index) { }

	// RVA: 0x316F2C0 Offset: 0x316B2C0 VA: 0x316F2C0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x316F2C8 Offset: 0x316B2C8 VA: 0x316F2C8 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x316F308 Offset: 0x316B308 VA: 0x316F308 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x316F398 Offset: 0x316B398 VA: 0x316F398 Slot: 11
	public Instruction BoxIfIndexMatches(int index) { }
}
