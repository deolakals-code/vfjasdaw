// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ValueTypeCopyInstruction : Instruction // TypeDefIndex: 15583
{
	// Fields
	public static readonly ValueTypeCopyInstruction Instruction; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3170020 Offset: 0x316C020 VA: 0x3170020 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3170028 Offset: 0x316C028 VA: 0x3170028 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3170030 Offset: 0x316C030 VA: 0x3170030 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3170070 Offset: 0x316C070 VA: 0x3170070 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x31700B4 Offset: 0x316C0B4 VA: 0x31700B4
	public void .ctor() { }

	// RVA: 0x31700BC Offset: 0x316C0BC VA: 0x31700BC
	private static void .cctor() { }
}
