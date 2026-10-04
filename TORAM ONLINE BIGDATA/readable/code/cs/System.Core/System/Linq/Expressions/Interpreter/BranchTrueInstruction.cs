// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class BranchTrueInstruction : OffsetInstruction // TypeDefIndex: 15394
{
	// Fields
	private static Instruction[] s_cache; // 0x0

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x3148994 Offset: 0x3144994 VA: 0x3148994 Slot: 11
	public override Instruction[] get_Cache() { }

	// RVA: 0x3148A28 Offset: 0x3144A28 VA: 0x3148A28 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3148A68 Offset: 0x3144A68 VA: 0x3148A68 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3148A70 Offset: 0x3144A70 VA: 0x3148A70 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3148B00 Offset: 0x3144B00 VA: 0x3148B00
	public void .ctor() { }
}
