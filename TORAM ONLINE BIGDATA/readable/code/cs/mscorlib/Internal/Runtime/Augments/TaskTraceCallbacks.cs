// Assembly: mscorlib.dll
// Namespace: Internal.Runtime.Augments
internal abstract class TaskTraceCallbacks // TypeDefIndex: 9502
{
	// Properties
	public abstract bool Enabled { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_Enabled();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions);
}
