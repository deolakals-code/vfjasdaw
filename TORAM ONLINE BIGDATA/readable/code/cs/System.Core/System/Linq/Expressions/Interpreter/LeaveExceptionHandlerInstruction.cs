// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LeaveExceptionHandlerInstruction : IndexedBranchInstruction // TypeDefIndex: 15408
{
	// Fields
	private static readonly LeaveExceptionHandlerInstruction[] s_cache; // 0x0
	private readonly bool _hasValue; // 0x14

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x314A6A8 Offset: 0x31466A8 VA: 0x314A6A8
	private void .ctor(int labelIndex, bool hasValue) { }

	// RVA: 0x314A6D8 Offset: 0x31466D8 VA: 0x314A6D8 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x314A718 Offset: 0x3146718 VA: 0x314A718 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x314A720 Offset: 0x3146720 VA: 0x314A720 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x314A728 Offset: 0x3146728 VA: 0x314A728
	internal static LeaveExceptionHandlerInstruction Create(int labelIndex, bool hasValue) { }

	// RVA: 0x314A84C Offset: 0x314684C VA: 0x314A84C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x314A870 Offset: 0x3146870 VA: 0x314A870
	private static void .cctor() { }
}
