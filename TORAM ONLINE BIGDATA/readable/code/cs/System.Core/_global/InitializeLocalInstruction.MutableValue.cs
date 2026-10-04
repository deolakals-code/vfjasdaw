// Assembly: System.Core.dll
// Namespace: 
internal sealed class InitializeLocalInstruction.MutableValue : InitializeLocalInstruction, IBoxableInstruction // TypeDefIndex: 15590
{
	// Fields
	private readonly Type _type; // 0x18

	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x317089C Offset: 0x316C89C VA: 0x317089C
	internal void .ctor(int index, Type type) { }

	// RVA: 0x31708D4 Offset: 0x316C8D4 VA: 0x31708D4 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x31709F8 Offset: 0x316C9F8 VA: 0x31709F8 Slot: 11
	public Instruction BoxIfIndexMatches(int index) { }

	// RVA: 0x3170AB8 Offset: 0x316CAB8 VA: 0x3170AB8 Slot: 9
	public override string get_InstructionName() { }
}
