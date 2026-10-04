// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class PopInstruction : Instruction // TypeDefIndex: 15697
{
	// Fields
	internal static readonly PopInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x317C570 Offset: 0x3178570 VA: 0x317C570
	private void .ctor() { }

	// RVA: 0x317C578 Offset: 0x3178578 VA: 0x317C578 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x317C580 Offset: 0x3178580 VA: 0x317C580 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x317C5C0 Offset: 0x31785C0 VA: 0x317C5C0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x317C5E4 Offset: 0x31785E4 VA: 0x317C5E4
	private static void .cctor() { }
}
