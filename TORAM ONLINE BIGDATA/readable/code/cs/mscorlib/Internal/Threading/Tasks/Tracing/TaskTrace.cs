// Assembly: mscorlib.dll
// Namespace: Internal.Threading.Tasks.Tracing
internal static class TaskTrace // TypeDefIndex: 9500
{
	// Fields
	private static TaskTraceCallbacks s_callbacks; // 0x0

	// Properties
	public static bool Enabled { get; }

	// Methods

	// RVA: 0x2E7FD9C Offset: 0x2E7BD9C VA: 0x2E7FD9C
	public static bool get_Enabled() { }

	// RVA: 0x2E7FDFC Offset: 0x2E7BDFC VA: 0x2E7FDFC
	public static void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

	// RVA: 0x2E7FE80 Offset: 0x2E7BE80 VA: 0x2E7FE80
	public static void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

	// RVA: 0x2E7FF04 Offset: 0x2E7BF04 VA: 0x2E7FF04
	public static void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

	// RVA: 0x2E7FF88 Offset: 0x2E7BF88 VA: 0x2E7FF88
	public static void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions) { }
}
