// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
internal sealed class CompletionActionInvoker : IThreadPoolWorkItem // TypeDefIndex: 9972
{
	// Fields
	private readonly ITaskCompletionAction m_action; // 0x10
	private readonly Task m_completingTask; // 0x18

	// Methods

	// RVA: 0x305F58C Offset: 0x305B58C VA: 0x305F58C
	internal void .ctor(ITaskCompletionAction action, Task completingTask) { }

	// RVA: 0x3061C64 Offset: 0x305DC64 VA: 0x3061C64 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x3061D0C Offset: 0x305DD0C VA: 0x3061D0C Slot: 5
	public void MarkAborted(ThreadAbortException e) { }
}
