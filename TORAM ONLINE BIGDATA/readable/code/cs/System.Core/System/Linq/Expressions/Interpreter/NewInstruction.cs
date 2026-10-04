// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal class NewInstruction : Instruction // TypeDefIndex: 15633
{
	// Fields
	protected readonly ConstructorInfo _constructor; // 0x10
	protected readonly int _argumentCount; // 0x18

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3175318 Offset: 0x3171318 VA: 0x3175318
	public void .ctor(ConstructorInfo constructor, int argumentCount) { }

	// RVA: 0x3175354 Offset: 0x3171354 VA: 0x3175354 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x317535C Offset: 0x317135C VA: 0x317535C Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3175364 Offset: 0x3171364 VA: 0x3175364 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x31753A4 Offset: 0x31713A4 VA: 0x31753A4 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x31754FC Offset: 0x31714FC VA: 0x31754FC
	protected object[] GetArgs(InterpretedFrame frame, int first) { }

	// RVA: 0x3175690 Offset: 0x3171690 VA: 0x3175690 Slot: 3
	public override string ToString() { }
}
