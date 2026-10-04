// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
internal sealed class TaskSchedulerAwaitTaskContinuation : AwaitTaskContinuation // TypeDefIndex: 9991
{
	// Fields
	private readonly TaskScheduler m_scheduler; // 0x20

	// Methods

	// RVA: 0x305E3D0 Offset: 0x305A3D0 VA: 0x305E3D0
	internal void .ctor(TaskScheduler scheduler, Action action, bool flowExecutionContext) { }

	// RVA: 0x30627E0 Offset: 0x305E7E0 VA: 0x30627E0 Slot: 4
	internal sealed override void Run(Task ignored, bool canInlineContinuationTask) { }
}
