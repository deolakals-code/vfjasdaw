// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
[DebuggerTypeProxy(typeof(TaskScheduler.SystemThreadingTasks_TaskSchedulerDebugView))]
[DebuggerDisplay("Id={Id}")]
public abstract class TaskScheduler // TypeDefIndex: 9997
{
	// Fields
	private static ConditionalWeakTable<TaskScheduler, object> s_activeTaskSchedulers; // 0x0
	private static readonly TaskScheduler s_defaultTaskScheduler; // 0x8
	internal static int s_taskSchedulerIdCounter; // 0x10
	private int m_taskSchedulerId; // 0x10
	private static EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException; // 0x18
	private static readonly Lock _unobservedTaskExceptionLockObject; // 0x20

	// Properties
	internal virtual bool RequiresAtomicStartTransition { get; }
	public static TaskScheduler Default { get; }
	public static TaskScheduler Current { get; }
	internal static TaskScheduler InternalCurrent { get; }
	public int Id { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected internal abstract void QueueTask(Task task);

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued);

	// RVA: 0x305ECD0 Offset: 0x305ACD0 VA: 0x305ECD0
	internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x306421C Offset: 0x306021C VA: 0x306421C Slot: 6
	protected internal virtual bool TryDequeue(Task task) { }

	// RVA: 0x3064224 Offset: 0x3060224 VA: 0x3064224 Slot: 7
	internal virtual void NotifyWorkItemProgress() { }

	// RVA: 0x3064228 Offset: 0x3060228 VA: 0x3064228 Slot: 8
	internal virtual bool get_RequiresAtomicStartTransition() { }

	// RVA: 0x3064230 Offset: 0x3060230 VA: 0x3064230
	protected void .ctor() { }

	// RVA: 0x3064238 Offset: 0x3060238 VA: 0x3064238
	public static TaskScheduler get_Default() { }

	// RVA: 0x305F698 Offset: 0x305B698 VA: 0x305F698
	public static TaskScheduler get_Current() { }

	// RVA: 0x305E32C Offset: 0x305A32C VA: 0x305E32C
	internal static TaskScheduler get_InternalCurrent() { }

	// RVA: 0x3064290 Offset: 0x3060290 VA: 0x3064290
	public static TaskScheduler FromCurrentSynchronizationContext() { }

	// RVA: 0x305EEC4 Offset: 0x305AEC4 VA: 0x305EEC4
	public int get_Id() { }

	// RVA: 0x306439C Offset: 0x306039C VA: 0x306439C
	protected bool TryExecuteTask(Task task) { }

	// RVA: 0x3063384 Offset: 0x305F384 VA: 0x3063384
	internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea) { }

	// RVA: 0x3064410 Offset: 0x3060410 VA: 0x3064410
	private static void .cctor() { }
}
