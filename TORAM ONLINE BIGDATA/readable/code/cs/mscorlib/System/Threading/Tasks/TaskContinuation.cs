// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
internal abstract class TaskContinuation // TypeDefIndex: 9986
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void Run(Task completedTask, bool bCanInlineContinuationTask);

	// RVA: 0x3061E40 Offset: 0x305DE40 VA: 0x3061E40
	protected static void InlineIfPossibleOrElseQueue(Task task, bool needsProtection) { }

	// RVA: 0x3061F80 Offset: 0x305DF80 VA: 0x3061F80
	protected void .ctor() { }
}
