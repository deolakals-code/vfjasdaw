// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadFieldInstruction : FieldInstruction // TypeDefIndex: 15469
{
	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x314F798 Offset: 0x314B798 VA: 0x314F798
	public void .ctor(FieldInfo field) { }

	// RVA: 0x314F7C8 Offset: 0x314B7C8 VA: 0x314F7C8 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x314F808 Offset: 0x314B808 VA: 0x314F808 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x314F810 Offset: 0x314B810 VA: 0x314F810 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x314F818 Offset: 0x314B818 VA: 0x314F818 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}
