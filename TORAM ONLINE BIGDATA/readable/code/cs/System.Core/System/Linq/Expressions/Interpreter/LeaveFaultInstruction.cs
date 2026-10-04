// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LeaveFaultInstruction : Instruction // TypeDefIndex: 15404
{
	// Fields
	internal static readonly Instruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ConsumedContinuations { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x314A328 Offset: 0x3146328 VA: 0x314A328
	private void .ctor() { }

	// RVA: 0x314A330 Offset: 0x3146330 VA: 0x314A330 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x314A338 Offset: 0x3146338 VA: 0x314A338 Slot: 6
	public override int get_ConsumedContinuations() { }

	// RVA: 0x314A340 Offset: 0x3146340 VA: 0x314A340 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x314A380 Offset: 0x3146380 VA: 0x314A380 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x314A3A4 Offset: 0x31463A4 VA: 0x314A3A4
	private static void .cctor() { }
}
