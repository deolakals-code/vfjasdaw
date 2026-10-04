// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class BranchFalseInstruction : OffsetInstruction // TypeDefIndex: 15393
{
	// Fields
	private static Instruction[] s_cache; // 0x0

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x3148818 Offset: 0x3144818 VA: 0x3148818 Slot: 11
	public override Instruction[] get_Cache() { }

	// RVA: 0x31488AC Offset: 0x31448AC VA: 0x31488AC Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x31488EC Offset: 0x31448EC VA: 0x31488EC Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x31488F4 Offset: 0x31448F4 VA: 0x31488F4 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3148984 Offset: 0x3144984 VA: 0x3148984
	public void .ctor() { }
}
