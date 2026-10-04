// Assembly: mscorlib.dll
// Namespace: System.Threading
internal struct ExecutionContextSwitcher // TypeDefIndex: 9898
{
	// Fields
	internal ExecutionContext.Reader outerEC; // 0x0
	internal bool outerECBelongsToScope; // 0x8
	internal object hecsw; // 0x10
	internal Thread thread; // 0x18

	// Methods

	[ReliabilityContract(3, 1)]
	[HandleProcessCorruptedStateExceptions]
	// RVA: 0x304E8FC Offset: 0x304A8FC VA: 0x304E8FC
	internal bool UndoNoThrow() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x304E984 Offset: 0x304A984 VA: 0x304E984
	internal void Undo() { }
}
