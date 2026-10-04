// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class NewArrayBoundsInstruction : Instruction // TypeDefIndex: 15382
{
	// Fields
	private readonly Type _elementType; // 0x10
	private readonly int _rank; // 0x18

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x314669C Offset: 0x314269C VA: 0x314669C
	internal void .ctor(Type elementType, int rank) { }

	// RVA: 0x31466D8 Offset: 0x31426D8 VA: 0x31466D8 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x31466E0 Offset: 0x31426E0 VA: 0x31466E0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x31466E8 Offset: 0x31426E8 VA: 0x31466E8 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3146728 Offset: 0x3142728 VA: 0x3146728 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}
