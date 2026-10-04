// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LeaveFinallyInstruction : Instruction // TypeDefIndex: 15402
{
	// Fields
	internal static readonly Instruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x314A000 Offset: 0x3146000 VA: 0x314A000
	private void .ctor() { }

	// RVA: 0x314A008 Offset: 0x3146008 VA: 0x314A008 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x314A010 Offset: 0x3146010 VA: 0x314A010 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x314A050 Offset: 0x3146050 VA: 0x314A050 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x314A098 Offset: 0x3146098 VA: 0x314A098
	private static void .cctor() { }
}
