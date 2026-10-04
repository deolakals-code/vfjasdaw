// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class EnterExceptionHandlerInstruction : Instruction // TypeDefIndex: 15407
{
	// Fields
	internal static readonly EnterExceptionHandlerInstruction Void; // 0x0
	internal static readonly EnterExceptionHandlerInstruction NonVoid; // 0x8
	private readonly bool _hasValue; // 0x10

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x314A58C Offset: 0x314658C VA: 0x314A58C
	private void .ctor(bool hasValue) { }

	// RVA: 0x314A5B4 Offset: 0x31465B4 VA: 0x314A5B4 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x314A5F4 Offset: 0x31465F4 VA: 0x314A5F4 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x314A5FC Offset: 0x31465FC VA: 0x314A5FC Slot: 5
	public override int get_ProducedStack() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x314A604 Offset: 0x3146604 VA: 0x314A604 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x314A60C Offset: 0x314660C VA: 0x314A60C
	private static void .cctor() { }
}
