// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal class BranchInstruction : OffsetInstruction // TypeDefIndex: 15396
{
	// Fields
	private static Instruction[][][] s_caches; // 0x0
	internal readonly bool _hasResult; // 0x14
	internal readonly bool _hasValue; // 0x15

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x3148C38 Offset: 0x3144C38 VA: 0x3148C38 Slot: 11
	public override Instruction[] get_Cache() { }

	// RVA: 0x3148E90 Offset: 0x3144E90 VA: 0x3148E90
	internal void .ctor() { }

	// RVA: 0x3148EB4 Offset: 0x3144EB4 VA: 0x3148EB4
	public void .ctor(bool hasResult, bool hasValue) { }

	// RVA: 0x3148EEC Offset: 0x3144EEC VA: 0x3148EEC Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3148F2C Offset: 0x3144F2C VA: 0x3148F2C Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3148F34 Offset: 0x3144F34 VA: 0x3148F34 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3148F3C Offset: 0x3144F3C VA: 0x3148F3C Slot: 8
	public override int Run(InterpretedFrame frame) { }
}
