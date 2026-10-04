// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class NewArrayInitInstruction : Instruction // TypeDefIndex: 15380
{
	// Fields
	private readonly Type _elementType; // 0x10
	private readonly int _elementCount; // 0x18

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x31463C4 Offset: 0x31423C4 VA: 0x31463C4
	internal void .ctor(Type elementType, int elementCount) { }

	// RVA: 0x3146400 Offset: 0x3142400 VA: 0x3146400 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3146408 Offset: 0x3142408 VA: 0x3146408 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3146410 Offset: 0x3142410 VA: 0x3146410 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3146450 Offset: 0x3142450 VA: 0x3146450 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}
