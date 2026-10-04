// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class TypeIsInstruction : Instruction // TypeDefIndex: 15716
{
	// Fields
	private readonly Type _type; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x317E7D4 Offset: 0x317A7D4 VA: 0x317E7D4
	internal void .ctor(Type type) { }

	// RVA: 0x317E804 Offset: 0x317A804 VA: 0x317E804 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x317E80C Offset: 0x317A80C VA: 0x317E80C Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x317E814 Offset: 0x317A814 VA: 0x317E814 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x317E854 Offset: 0x317A854 VA: 0x317E854 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x317E8B4 Offset: 0x317A8B4 VA: 0x317E8B4 Slot: 3
	public override string ToString() { }
}
