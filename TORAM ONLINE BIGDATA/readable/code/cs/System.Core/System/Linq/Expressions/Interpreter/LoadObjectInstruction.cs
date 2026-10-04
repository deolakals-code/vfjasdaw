// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadObjectInstruction : Instruction // TypeDefIndex: 15695
{
	// Fields
	private readonly object _value; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x317C100 Offset: 0x3178100 VA: 0x317C100
	internal void .ctor(object value) { }

	// RVA: 0x317C130 Offset: 0x3178130 VA: 0x317C130 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x317C138 Offset: 0x3178138 VA: 0x317C138 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x317C178 Offset: 0x3178178 VA: 0x317C178 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x317C1F4 Offset: 0x31781F4 VA: 0x317C1F4 Slot: 3
	public override string ToString() { }
}
