// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class DupInstruction : Instruction // TypeDefIndex: 15698
{
	// Fields
	internal static readonly DupInstruction Instance; // 0x0

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x317C64C Offset: 0x317864C VA: 0x317C64C
	private void .ctor() { }

	// RVA: 0x317C654 Offset: 0x3178654 VA: 0x317C654 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x317C65C Offset: 0x317865C VA: 0x317C65C Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x317C69C Offset: 0x317869C VA: 0x317C69C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x317C6C0 Offset: 0x31786C0 VA: 0x317C6C0
	private static void .cctor() { }
}
