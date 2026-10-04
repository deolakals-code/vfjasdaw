// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LeaveExceptionFilterInstruction : Instruction // TypeDefIndex: 15406
{
	// Fields
	internal static readonly LeaveExceptionFilterInstruction Instance; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x314A4CC Offset: 0x31464CC VA: 0x314A4CC
	private void .ctor() { }

	// RVA: 0x314A4D4 Offset: 0x31464D4 VA: 0x314A4D4 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x314A514 Offset: 0x3146514 VA: 0x314A514 Slot: 4
	public override int get_ConsumedStack() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x314A51C Offset: 0x314651C VA: 0x314A51C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x314A524 Offset: 0x3146524 VA: 0x314A524
	private static void .cctor() { }
}
