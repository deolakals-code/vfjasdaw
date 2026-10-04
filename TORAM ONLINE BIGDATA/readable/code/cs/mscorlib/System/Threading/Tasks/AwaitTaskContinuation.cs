// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
internal class AwaitTaskContinuation : TaskContinuation, IThreadPoolWorkItem // TypeDefIndex: 9992
{
	// Fields
	private readonly ExecutionContext m_capturedContext; // 0x10
	protected readonly Action m_action; // 0x18
	private static ContextCallback s_invokeActionCallback; // 0x0

	// Properties
	internal static bool IsValidLocationForInlining { get; }

	// Methods

	// RVA: 0x3062120 Offset: 0x305E120 VA: 0x3062120
	internal void .ctor(Action action, bool flowExecutionContext) { }

	// RVA: 0x3062B48 Offset: 0x305EB48 VA: 0x3062B48
	protected Task CreateTask(Action<object> action, object state, TaskScheduler scheduler) { }

	// RVA: 0x3062A24 Offset: 0x305EA24 VA: 0x3062A24 Slot: 4
	internal override void Run(Task ignored, bool canInlineContinuationTask) { }

	// RVA: 0x3062D88 Offset: 0x305ED88 VA: 0x3062D88
	internal static bool get_IsValidLocationForInlining() { }

	// RVA: 0x3062EBC Offset: 0x305EEBC VA: 0x3062EBC Slot: 5
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x3062FF0 Offset: 0x305EFF0 VA: 0x3062FF0
	private static void InvokeAction(object state) { }

	// RVA: 0x306305C Offset: 0x305F05C VA: 0x306305C
	protected static ContextCallback GetInvokeActionCallback() { }

	// RVA: 0x3062338 Offset: 0x305E338 VA: 0x3062338
	protected void RunCallback(ContextCallback callback, object state, ref Task currentTask) { }

	// RVA: 0x305F400 Offset: 0x305B400 VA: 0x305F400
	internal static void RunOrScheduleAction(Action action, bool allowInlining, ref Task currentTask) { }

	// RVA: 0x305E49C Offset: 0x305A49C VA: 0x305E49C
	internal static void UnsafeScheduleAction(Action action) { }

	// RVA: 0x3062D30 Offset: 0x305ED30 VA: 0x3062D30
	protected static void ThrowAsyncIfNecessary(Exception exc) { }

	// RVA: 0x306310C Offset: 0x305F10C VA: 0x306310C Slot: 6
	public void MarkAborted(ThreadAbortException e) { }
}
