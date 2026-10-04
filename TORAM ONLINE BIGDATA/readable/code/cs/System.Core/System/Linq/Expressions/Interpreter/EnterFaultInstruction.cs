// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class EnterFaultInstruction : IndexedBranchInstruction // TypeDefIndex: 15403
{
	// Fields
	private static readonly EnterFaultInstruction[] s_cache; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x314A100 Offset: 0x3146100 VA: 0x314A100
	private void .ctor(int labelIndex) { }

	// RVA: 0x314A128 Offset: 0x3146128 VA: 0x314A128 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x314A168 Offset: 0x3146168 VA: 0x314A168 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x314A170 Offset: 0x3146170 VA: 0x314A170
	internal static EnterFaultInstruction Create(int labelIndex) { }

	// RVA: 0x314A26C Offset: 0x314626C VA: 0x314A26C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x314A2B4 Offset: 0x31462B4 VA: 0x314A2B4
	private static void .cctor() { }
}
