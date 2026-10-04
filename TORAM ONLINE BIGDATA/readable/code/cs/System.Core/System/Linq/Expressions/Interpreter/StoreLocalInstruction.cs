// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class StoreLocalInstruction : LocalAccessInstruction, IBoxableInstruction // TypeDefIndex: 15579
{
	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x316F9FC Offset: 0x316B9FC VA: 0x316F9FC
	internal void .ctor(int index) { }

	// RVA: 0x316FA24 Offset: 0x316BA24 VA: 0x316FA24 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x316FA2C Offset: 0x316BA2C VA: 0x316FA2C Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x316FA6C Offset: 0x316BA6C VA: 0x316FA6C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x316FAEC Offset: 0x316BAEC VA: 0x316FAEC Slot: 11
	public Instruction BoxIfIndexMatches(int index) { }
}
