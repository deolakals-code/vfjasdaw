// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class EnterExceptionFilterInstruction : Instruction // TypeDefIndex: 15405
{
	// Fields
	internal static readonly EnterExceptionFilterInstruction Instance; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x314A40C Offset: 0x314640C VA: 0x314A40C
	private void .ctor() { }

	// RVA: 0x314A414 Offset: 0x3146414 VA: 0x314A414 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x314A454 Offset: 0x3146454 VA: 0x314A454 Slot: 5
	public override int get_ProducedStack() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x314A45C Offset: 0x314645C VA: 0x314A45C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x314A464 Offset: 0x3146464 VA: 0x314A464
	private static void .cctor() { }
}
