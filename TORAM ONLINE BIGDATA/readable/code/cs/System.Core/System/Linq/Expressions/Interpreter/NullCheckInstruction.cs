// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class NullCheckInstruction : Instruction // TypeDefIndex: 15670
{
	// Fields
	public static readonly Instruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x31783D4 Offset: 0x31743D4 VA: 0x31783D4
	private void .ctor() { }

	// RVA: 0x31783DC Offset: 0x31743DC VA: 0x31783DC Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x31783E4 Offset: 0x31743E4 VA: 0x31783E4 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x31783EC Offset: 0x31743EC VA: 0x31783EC Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x317842C Offset: 0x317442C VA: 0x317842C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3178488 Offset: 0x3174488 VA: 0x3178488
	private static void .cctor() { }
}
