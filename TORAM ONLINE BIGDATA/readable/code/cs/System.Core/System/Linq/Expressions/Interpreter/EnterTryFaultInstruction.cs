// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class EnterTryFaultInstruction : IndexedBranchInstruction // TypeDefIndex: 15400
{
	// Fields
	private TryFaultHandler _tryHandler; // 0x18

	// Properties
	public override string InstructionName { get; }
	public override int ProducedContinuations { get; }
	internal TryFaultHandler Handler { get; }

	// Methods

	// RVA: 0x3149B30 Offset: 0x3145B30 VA: 0x3149B30
	internal void .ctor(int targetIndex) { }

	// RVA: 0x3149B58 Offset: 0x3145B58 VA: 0x3149B58 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3149B98 Offset: 0x3145B98 VA: 0x3149B98 Slot: 7
	public override int get_ProducedContinuations() { }

	// RVA: 0x3149BA0 Offset: 0x3145BA0 VA: 0x3149BA0
	internal TryFaultHandler get_Handler() { }

	// RVA: 0x3149BA8 Offset: 0x3145BA8 VA: 0x3149BA8
	internal void SetTryHandler(TryFaultHandler tryHandler) { }

	// RVA: 0x3149BB0 Offset: 0x3145BB0 VA: 0x3149BB0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}
