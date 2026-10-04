// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
internal class StandardTaskContinuation : TaskContinuation // TypeDefIndex: 9987
{
	// Fields
	internal readonly Task m_task; // 0x10
	internal readonly TaskContinuationOptions m_options; // 0x18
	private readonly TaskScheduler m_taskScheduler; // 0x20

	// Methods

	// RVA: 0x305FD38 Offset: 0x305BD38 VA: 0x305FD38
	internal void .ctor(Task task, TaskContinuationOptions options, TaskScheduler scheduler) { }

	// RVA: 0x3061F88 Offset: 0x305DF88 VA: 0x3061F88 Slot: 4
	internal override void Run(Task completedTask, bool bCanInlineContinuationTask) { }
}
