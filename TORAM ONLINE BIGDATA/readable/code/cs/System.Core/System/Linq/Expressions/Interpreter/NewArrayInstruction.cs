// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class NewArrayInstruction : Instruction // TypeDefIndex: 15381
{
	// Fields
	private readonly Type _elementType; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x31464D8 Offset: 0x31424D8 VA: 0x31464D8
	internal void .ctor(Type elementType) { }

	// RVA: 0x3146508 Offset: 0x3142508 VA: 0x3146508 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3146510 Offset: 0x3142510 VA: 0x3146510 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3146518 Offset: 0x3142518 VA: 0x3146518 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3146558 Offset: 0x3142558 VA: 0x3146558 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}
