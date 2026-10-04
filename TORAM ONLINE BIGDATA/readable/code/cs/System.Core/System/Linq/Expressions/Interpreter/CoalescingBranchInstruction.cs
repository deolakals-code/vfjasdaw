// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class CoalescingBranchInstruction : OffsetInstruction // TypeDefIndex: 15395
{
	// Fields
	private static Instruction[] s_cache; // 0x0

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x3148B10 Offset: 0x3144B10 VA: 0x3148B10 Slot: 11
	public override Instruction[] get_Cache() { }

	// RVA: 0x3148BA4 Offset: 0x3144BA4 VA: 0x3148BA4 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3148BE4 Offset: 0x3144BE4 VA: 0x3148BE4 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3148BEC Offset: 0x3144BEC VA: 0x3148BEC Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3148BF4 Offset: 0x3144BF4 VA: 0x3148BF4 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3148C28 Offset: 0x3144C28 VA: 0x3148C28
	public void .ctor() { }
}
