// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class EnterTryCatchFinallyInstruction : IndexedBranchInstruction // TypeDefIndex: 15399
{
	// Fields
	private readonly bool _hasFinally; // 0x14
	private TryCatchFinallyHandler _tryHandler; // 0x18

	// Properties
	internal TryCatchFinallyHandler Handler { get; }
	public override int ProducedContinuations { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3149468 Offset: 0x3145468 VA: 0x3149468
	internal void SetTryHandler(TryCatchFinallyHandler tryHandler) { }

	// RVA: 0x3149470 Offset: 0x3145470 VA: 0x3149470
	internal TryCatchFinallyHandler get_Handler() { }

	// RVA: 0x3149478 Offset: 0x3145478 VA: 0x3149478 Slot: 7
	public override int get_ProducedContinuations() { }

	// RVA: 0x3149480 Offset: 0x3145480 VA: 0x3149480
	private void .ctor(int targetIndex, bool hasFinally) { }

	// RVA: 0x31494B0 Offset: 0x31454B0 VA: 0x31494B0
	internal static EnterTryCatchFinallyInstruction CreateTryFinally(int labelIndex) { }

	// RVA: 0x3149514 Offset: 0x3145514 VA: 0x3149514
	internal static EnterTryCatchFinallyInstruction CreateTryCatch() { }

	// RVA: 0x3149574 Offset: 0x3145574 VA: 0x3149574 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3149A24 Offset: 0x3145A24 VA: 0x3149A24 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3149A90 Offset: 0x3145A90 VA: 0x3149A90 Slot: 3
	public override string ToString() { }
}
