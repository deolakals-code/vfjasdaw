// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
[DebuggerTypeProxy(typeof(SystemThreadingTasks_TaskDebugView))]
[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}")]
public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable // TypeDefIndex: 9971
{
	// Fields
	internal static int s_taskIdCounter; // 0x0
	private int m_taskId; // 0x10
	internal Delegate m_action; // 0x18
	internal object m_stateObject; // 0x20
	internal TaskScheduler m_taskScheduler; // 0x28
	internal readonly Task m_parent; // 0x30
	internal int m_stateFlags; // 0x38
	private const int OptionsMask = 65535;
	internal const int TASK_STATE_STARTED = 65536;
	internal const int TASK_STATE_DELEGATE_INVOKED = 131072;
	internal const int TASK_STATE_DISPOSED = 262144;
	internal const int TASK_STATE_EXCEPTIONOBSERVEDBYPARENT = 524288;
	internal const int TASK_STATE_CANCELLATIONACKNOWLEDGED = 1048576;
	internal const int TASK_STATE_FAULTED = 2097152;
	internal const int TASK_STATE_CANCELED = 4194304;
	internal const int TASK_STATE_WAITING_ON_CHILDREN = 8388608;
	internal const int TASK_STATE_RAN_TO_COMPLETION = 16777216;
	internal const int TASK_STATE_WAITINGFORACTIVATION = 33554432;
	internal const int TASK_STATE_COMPLETION_RESERVED = 67108864;
	internal const int TASK_STATE_THREAD_WAS_ABORTED = 134217728;
	internal const int TASK_STATE_WAIT_COMPLETION_NOTIFICATION = 268435456;
	private const int TASK_STATE_COMPLETED_MASK = 23068672;
	private const int CANCELLATION_REQUESTED = 1;
	private object m_continuationObject; // 0x40
	private static readonly object s_taskCompletionSentinel; // 0x8
	internal static bool s_asyncDebuggingEnabled; // 0x10
	internal Task.ContingentProperties m_contingentProperties; // 0x48
	private static readonly Action<object> s_taskCancelCallback; // 0x18
	[ThreadStatic]
	internal static Task t_currentTask; // 0x80000000
	[ThreadStatic]
	private static StackGuard t_stackGuard; // 0x80000008
	private static readonly Func<Task.ContingentProperties> s_createContingentProperties; // 0x20
	[CompilerGenerated]
	private static readonly TaskFactory <Factory>k__BackingField; // 0x28
	[CompilerGenerated]
	private static readonly Task <CompletedTask>k__BackingField; // 0x30
	private static readonly Predicate<Task> s_IsExceptionObservedByParentPredicate; // 0x38
	private static ContextCallback s_ecCallback; // 0x40
	private static readonly Predicate<object> s_IsTaskContinuationNullPredicate; // 0x48
	private static readonly Dictionary<int, Task> s_currentActiveTasks; // 0x50
	private static readonly object s_activeTasksLock; // 0x58

	// Properties
	internal TaskCreationOptions Options { get; }
	internal bool IsWaitNotificationEnabledOrNotRanToCompletion { get; }
	internal virtual bool ShouldNotifyDebuggerOfWaitCompletion { get; }
	internal bool IsWaitNotificationEnabled { get; }
	public int Id { get; }
	internal static Task InternalCurrent { get; }
	internal static StackGuard CurrentStackGuard { get; }
	public AggregateException Exception { get; }
	public TaskStatus Status { get; }
	public bool IsCanceled { get; }
	internal bool IsCancellationRequested { get; }
	internal CancellationToken CancellationToken { get; }
	internal bool IsCancellationAcknowledged { get; }
	public bool IsCompleted { get; }
	public bool IsCompletedSuccessfully { get; }
	public TaskCreationOptions CreationOptions { get; }
	private WaitHandle System.IAsyncResult.AsyncWaitHandle { get; }
	public object AsyncState { get; }
	private bool System.IAsyncResult.CompletedSynchronously { get; }
	internal TaskScheduler ExecutingTaskScheduler { get; }
	public static TaskFactory Factory { get; }
	public static Task CompletedTask { get; }
	internal ManualResetEventSlim CompletedEvent { get; }
	internal bool ExceptionRecorded { get; }
	public bool IsFaulted { get; }
	internal ExecutionContext CapturedContext { get; set; }
	internal bool IsExceptionObservedByParent { get; }
	internal bool IsDelegateInvoked { get; }

	// Methods

	// RVA: 0x305A058 Offset: 0x3056058 VA: 0x305A058
	internal void .ctor(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct) { }

	// RVA: 0x305A14C Offset: 0x305614C VA: 0x305A14C
	internal void .ctor() { }

	// RVA: 0x305A174 Offset: 0x3056174 VA: 0x305A174
	internal void .ctor(object state, TaskCreationOptions creationOptions, bool promiseStyle) { }

	// RVA: 0x305A444 Offset: 0x3056444 VA: 0x305A444
	internal void .ctor(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x305A29C Offset: 0x305629C VA: 0x305A29C
	internal void TaskConstructorCore(Delegate action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x305A59C Offset: 0x305659C VA: 0x305A59C
	private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation) { }

	// RVA: 0x305ABE0 Offset: 0x3056BE0 VA: 0x305ABE0
	private static void TaskCancelCallback(object o) { }

	// RVA: 0x30599BC Offset: 0x30559BC VA: 0x30599BC
	internal bool TrySetCanceled(CancellationToken tokenToRecord) { }

	// RVA: 0x30590BC Offset: 0x30550BC VA: 0x30590BC
	internal bool TrySetCanceled(CancellationToken tokenToRecord, object cancellationException) { }

	// RVA: 0x30599C4 Offset: 0x30559C4 VA: 0x30599C4
	internal bool TrySetException(object exceptionObject) { }

	// RVA: 0x305A96C Offset: 0x305696C VA: 0x305A96C
	internal TaskCreationOptions get_Options() { }

	// RVA: 0x305B2C4 Offset: 0x30572C4 VA: 0x305B2C4
	internal static TaskCreationOptions OptionsMethod(int flags) { }

	// RVA: 0x305AF18 Offset: 0x3056F18 VA: 0x305AF18
	internal bool AtomicStateUpdate(int newBits, int illegalBits) { }

	// RVA: 0x305B2CC Offset: 0x30572CC VA: 0x305B2CC
	internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags) { }

	// RVA: 0x305B3A4 Offset: 0x30573A4 VA: 0x305B3A4
	internal void SetNotificationForWaitCompletion(bool enabled) { }

	// RVA: 0x305B478 Offset: 0x3057478 VA: 0x305B478
	internal bool NotifyDebuggerOfWaitCompletionIfNecessary() { }

	// RVA: 0x305B508 Offset: 0x3057508 VA: 0x305B508
	internal bool get_IsWaitNotificationEnabledOrNotRanToCompletion() { }

	// RVA: 0x305B530 Offset: 0x3057530 VA: 0x305B530 Slot: 11
	internal virtual bool get_ShouldNotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x305B4C8 Offset: 0x30574C8 VA: 0x305B4C8
	internal bool get_IsWaitNotificationEnabled() { }

	// RVA: 0x305B4E0 Offset: 0x30574E0 VA: 0x305B4E0
	private void NotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x305B548 Offset: 0x3057548 VA: 0x305B548
	internal bool MarkStarted() { }

	// RVA: 0x305A528 Offset: 0x3056528 VA: 0x305A528
	internal void AddNewChild() { }

	// RVA: 0x305AB98 Offset: 0x3056B98 VA: 0x305AB98
	internal void DisregardChild() { }

	// RVA: 0x305B554 Offset: 0x3057554 VA: 0x305B554
	internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions) { }

	// RVA: 0x3059D08 Offset: 0x3055D08 VA: 0x3059D08
	public int get_Id() { }

	// RVA: 0x305B868 Offset: 0x3057868 VA: 0x305B868
	internal static Task get_InternalCurrent() { }

	// RVA: 0x305B8C0 Offset: 0x30578C0 VA: 0x305B8C0
	internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions) { }

	// RVA: 0x305B95C Offset: 0x305795C VA: 0x305B95C
	internal static StackGuard get_CurrentStackGuard() { }

	// RVA: 0x305BA1C Offset: 0x3057A1C VA: 0x305BA1C
	public AggregateException get_Exception() { }

	// RVA: 0x305BBC8 Offset: 0x3057BC8 VA: 0x305BBC8
	public TaskStatus get_Status() { }

	// RVA: 0x305BC28 Offset: 0x3057C28 VA: 0x305BC28
	public bool get_IsCanceled() { }

	// RVA: 0x305BC48 Offset: 0x3057C48 VA: 0x305BC48
	internal bool get_IsCancellationRequested() { }

	// RVA: 0x305A92C Offset: 0x305692C VA: 0x305A92C
	internal Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection) { }

	// RVA: 0x305BCD8 Offset: 0x3057CD8 VA: 0x305BCD8
	private Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection) { }

	// RVA: 0x305846C Offset: 0x305446C VA: 0x305846C
	internal CancellationToken get_CancellationToken() { }

	// RVA: 0x305BDC0 Offset: 0x3057DC0 VA: 0x305BDC0
	internal bool get_IsCancellationAcknowledged() { }

	// RVA: 0x30586F8 Offset: 0x30546F8 VA: 0x30586F8 Slot: 6
	public bool get_IsCompleted() { }

	// RVA: 0x305BDD8 Offset: 0x3057DD8 VA: 0x305BDD8
	private static bool IsCompletedMethod(int flags) { }

	// RVA: 0x305BDE8 Offset: 0x3057DE8 VA: 0x305BDE8
	public bool get_IsCompletedSuccessfully() { }

	// RVA: 0x305A514 Offset: 0x3056514 VA: 0x305A514
	public TaskCreationOptions get_CreationOptions() { }

	// RVA: 0x305BE10 Offset: 0x3057E10 VA: 0x305BE10 Slot: 7
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

	// RVA: 0x305BF8C Offset: 0x3057F8C VA: 0x305BF8C Slot: 8
	public object get_AsyncState() { }

	// RVA: 0x305BF94 Offset: 0x3057F94 VA: 0x305BF94 Slot: 9
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x305BF9C Offset: 0x3057F9C VA: 0x305BF9C
	internal TaskScheduler get_ExecutingTaskScheduler() { }

	[CompilerGenerated]
	// RVA: 0x305BFA4 Offset: 0x3057FA4 VA: 0x305BFA4
	public static TaskFactory get_Factory() { }

	[CompilerGenerated]
	// RVA: 0x305BFFC Offset: 0x3057FFC VA: 0x305BFFC
	public static Task get_CompletedTask() { }

	// RVA: 0x305BE94 Offset: 0x3057E94 VA: 0x305BE94
	internal ManualResetEventSlim get_CompletedEvent() { }

	// RVA: 0x305C054 Offset: 0x3058054 VA: 0x305C054
	internal bool get_ExceptionRecorded() { }

	// RVA: 0x305BA58 Offset: 0x3057A58 VA: 0x305BA58
	public bool get_IsFaulted() { }

	// RVA: 0x305C0C4 Offset: 0x30580C4 VA: 0x305C0C4
	internal ExecutionContext get_CapturedContext() { }

	// RVA: 0x305A87C Offset: 0x305687C VA: 0x305A87C
	internal void set_CapturedContext(ExecutionContext value) { }

	// RVA: 0x305C134 Offset: 0x3058134 VA: 0x305C134 Slot: 10
	public void Dispose() { }

	// RVA: 0x305C1A0 Offset: 0x30581A0 VA: 0x305C1A0 Slot: 12
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x305B65C Offset: 0x305765C VA: 0x305B65C
	internal void ScheduleAndStart(bool needsProtection) { }

	// RVA: 0x305B134 Offset: 0x3057134 VA: 0x305B134
	internal void AddException(object exceptionObject) { }

	// RVA: 0x305C304 Offset: 0x3058304 VA: 0x305C304
	internal void AddException(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x305BA70 Offset: 0x3057A70 VA: 0x305BA70
	private AggregateException GetExceptions(bool includeTaskCanceledExceptions) { }

	// RVA: 0x305C6AC Offset: 0x30586AC VA: 0x305C6AC
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x305C850 Offset: 0x3058850 VA: 0x305C850
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x305C880 Offset: 0x3058880 VA: 0x305C880
	internal void ThrowIfExceptional(bool includeTaskCanceledExceptions) { }

	// RVA: 0x305C8C8 Offset: 0x30588C8 VA: 0x305C8C8
	internal void UpdateExceptionObservedStatus() { }

	// RVA: 0x305C99C Offset: 0x305899C VA: 0x305C99C
	internal bool get_IsExceptionObservedByParent() { }

	// RVA: 0x305C9B4 Offset: 0x30589B4 VA: 0x305C9B4
	internal bool get_IsDelegateInvoked() { }

	// RVA: 0x305B13C Offset: 0x305713C VA: 0x305B13C
	internal void Finish(bool bUserDelegateExecuted) { }

	// RVA: 0x305C9CC Offset: 0x30589CC VA: 0x305C9CC
	internal void FinishStageTwo() { }

	// RVA: 0x305D1DC Offset: 0x30591DC VA: 0x305D1DC
	internal void FinishStageThree() { }

	// RVA: 0x305D23C Offset: 0x305923C VA: 0x305D23C
	internal void ProcessChildCompletion(Task childTask) { }

	// RVA: 0x305CC54 Offset: 0x3058C54 VA: 0x305CC54
	internal void AddExceptionsFromChildren() { }

	// RVA: 0x305DACC Offset: 0x3059ACC VA: 0x305DACC
	private void Execute() { }

	// RVA: 0x305DC80 Offset: 0x3059C80 VA: 0x305DC80 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x305DC88 Offset: 0x3059C88 VA: 0x305DC88
	internal bool ExecuteEntry(bool bPreventDoubleExecution) { }

	// RVA: 0x305DF94 Offset: 0x3059F94 VA: 0x305DF94
	private static void ExecutionContextCallback(object obj) { }

	// RVA: 0x305E00C Offset: 0x305A00C VA: 0x305E00C Slot: 13
	internal virtual void InnerInvoke() { }

	// RVA: 0x305DB78 Offset: 0x3059B78 VA: 0x305DB78
	private void HandleException(Exception unhandledException) { }

	// RVA: 0x30589C4 Offset: 0x30549C4 VA: 0x30589C4
	public TaskAwaiter GetAwaiter() { }

	// RVA: 0x30589EC Offset: 0x30549EC VA: 0x30589EC
	public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	// RVA: 0x305E0EC Offset: 0x305A0EC VA: 0x305E0EC
	internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext) { }

	// RVA: 0x305E4FC Offset: 0x305A4FC VA: 0x305E4FC
	public void Wait() { }

	// RVA: 0x305E508 Offset: 0x305A508 VA: 0x305E508
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x305EC00 Offset: 0x305AC00 VA: 0x305EC00
	private bool WrappedTryRunInline() { }

	// RVA: 0x305E658 Offset: 0x305A658 VA: 0x305E658
	internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x305EF58 Offset: 0x305AF58 VA: 0x305EF58
	private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x305F104 Offset: 0x305B104 VA: 0x305F104
	private bool SpinWait(int millisecondsTimeout) { }

	// RVA: 0x305A9C8 Offset: 0x30569C8 VA: 0x305A9C8
	internal bool InternalCancel(bool bCancelNonExecutingOnly) { }

	// RVA: 0x305F314 Offset: 0x305B314 VA: 0x305F314
	internal void RecordInternalCancellationRequest() { }

	// RVA: 0x305F35C Offset: 0x305B35C VA: 0x305F35C
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord) { }

	// RVA: 0x305AFD8 Offset: 0x3056FD8 VA: 0x305AFD8
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException) { }

	// RVA: 0x305B014 Offset: 0x3057014 VA: 0x305B014
	internal void CancellationCleanupLogic() { }

	// RVA: 0x305E0C0 Offset: 0x305A0C0 VA: 0x305E0C0
	private void SetCancellationAcknowledged() { }

	// RVA: 0x305D3F0 Offset: 0x30593F0 VA: 0x305D3F0
	internal void FinishContinuations() { }

	// RVA: 0x305F5D0 Offset: 0x305B5D0 VA: 0x305F5D0
	private void LogFinishCompletionNotification() { }

	// RVA: 0x305F624 Offset: 0x305B624 VA: 0x305F624
	public Task ContinueWith(Action<Task> continuationAction) { }

	// RVA: 0x305F738 Offset: 0x305B738 VA: 0x305F738
	private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }

	// RVA: 0x305FBC4 Offset: 0x305BBC4 VA: 0x305FBC4
	public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	// RVA: 0x305FBD8 Offset: 0x305BBD8 VA: 0x305FBD8
	private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }

	// RVA: -1 Offset: -1
	public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F4098 Offset: 0x26F0098 VA: 0x26F4098
	|-Task.ContinueWith<object>
	|
	|-RVA: 0x26F4118 Offset: 0x26F0118 VA: 0x26F4118
	|-Task.ContinueWith<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F419C Offset: 0x26F019C VA: 0x26F419C
	|-Task.ContinueWith<object>
	|
	|-RVA: 0x26F42F8 Offset: 0x26F02F8 VA: 0x26F42F8
	|-Task.ContinueWith<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x305F88C Offset: 0x305B88C VA: 0x305F88C
	internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions) { }

	// RVA: 0x305FA68 Offset: 0x305BA68 VA: 0x305FA68
	internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options) { }

	// RVA: 0x305FE7C Offset: 0x305BE7C VA: 0x305FE7C
	internal void AddCompletionAction(ITaskCompletionAction action) { }

	// RVA: 0x305F240 Offset: 0x305B240 VA: 0x305F240
	private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers) { }

	// RVA: 0x305FE84 Offset: 0x305BE84 VA: 0x305FE84
	private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers) { }

	// RVA: 0x305E408 Offset: 0x305A408 VA: 0x305E408
	private bool AddTaskContinuation(object tc, bool addBeforeOthers) { }

	// RVA: 0x305ACD0 Offset: 0x3056CD0 VA: 0x305ACD0
	internal void RemoveContinuation(object continuationObject) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromResult<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F4FD0 Offset: 0x26F0FD0 VA: 0x26F4FD0
	|-Task.FromResult<bool>
	|
	|-RVA: 0x26F502C Offset: 0x26F102C VA: 0x26F502C
	|-Task.FromResult<int>
	|
	|-RVA: 0x26F5088 Offset: 0x26F1088 VA: 0x26F5088
	|-Task.FromResult<object>
	|
	|-RVA: 0x26F50E4 Offset: 0x26F10E4 VA: 0x26F50E4
	|-Task.FromResult<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x3059114 Offset: 0x3055114 VA: 0x3059114
	public static Task FromException(Exception exception) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromException<TResult>(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F4DBC Offset: 0x26F0DBC VA: 0x26F4DBC
	|-Task.FromException<int>
	|
	|-RVA: 0x26F4E6C Offset: 0x26F0E6C VA: 0x26F4E6C
	|-Task.FromException<VoidTaskResult>
	|
	|-RVA: 0x26F4F1C Offset: 0x26F0F1C VA: 0x26F4F1C
	|-Task.FromException<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x306018C Offset: 0x305C18C VA: 0x306018C
	internal static Task FromCancellation(CancellationToken cancellationToken) { }

	// RVA: 0x3059578 Offset: 0x3055578 VA: 0x3059578
	public static Task FromCanceled(CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F4654 Offset: 0x26F0654 VA: 0x26F4654
	|-Task.FromCancellation<bool>
	|
	|-RVA: 0x26F4738 Offset: 0x26F0738 VA: 0x26F4738
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x26F48D0 Offset: 0x26F08D0 VA: 0x26F48D0
	|-Task.FromCancellation<Int32Enum>
	|
	|-RVA: 0x26F49B4 Offset: 0x26F09B4 VA: 0x26F49B4
	|-Task.FromCancellation<object>
	|
	|-RVA: 0x26F4B4C Offset: 0x26F0B4C VA: 0x26F4B4C
	|-Task.FromCancellation<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> FromCanceled<TResult>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F4524 Offset: 0x26F0524 VA: 0x26F4524
	|-Task.FromCanceled<int>
	|
	|-RVA: 0x26F4588 Offset: 0x26F0588 VA: 0x26F4588
	|-Task.FromCanceled<Int32Enum>
	|
	|-RVA: 0x26F45EC Offset: 0x26F05EC VA: 0x26F45EC
	|-Task.FromCanceled<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F481C Offset: 0x26F081C VA: 0x26F481C
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x26F4A98 Offset: 0x26F0A98 VA: 0x26F4A98
	|-Task.FromCancellation<VoidTaskResult>
	|
	|-RVA: 0x26F4D04 Offset: 0x26F0D04 VA: 0x26F4D04
	|-Task.FromCancellation<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x306026C Offset: 0x305C26C VA: 0x306026C
	public static Task Run(Action action) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<TResult> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F51DC Offset: 0x26F11DC VA: 0x26F51DC
	|-Task.Run<int>
	|
	|-RVA: 0x26F5294 Offset: 0x26F1294 VA: 0x26F5294
	|-Task.Run<Int32Enum>
	|
	|-RVA: 0x26F534C Offset: 0x26F134C VA: 0x26F534C
	|-Task.Run<object>
	|
	|-RVA: 0x26F546C Offset: 0x26F146C VA: 0x26F546C
	|-Task.Run<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x306033C Offset: 0x305C33C VA: 0x306033C
	public static Task Run(Func<Task> function) { }

	// RVA: 0x3060394 Offset: 0x305C394 VA: 0x3060394
	public static Task Run(Func<Task> function, CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<Task<TResult>> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F5404 Offset: 0x26F1404 VA: 0x26F5404
	|-Task.Run<object>
	|
	|-RVA: 0x26F5528 Offset: 0x26F1528 VA: 0x26F5528
	|-Task.Run<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F5594 Offset: 0x26F1594 VA: 0x26F5594
	|-Task.Run<object>
	|
	|-RVA: 0x26F57B0 Offset: 0x26F17B0 VA: 0x26F57B0
	|-Task.Run<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x30605C8 Offset: 0x305C5C8 VA: 0x30605C8
	public static Task Delay(int millisecondsDelay) { }

	// RVA: 0x3060620 Offset: 0x305C620 VA: 0x3060620
	public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken) { }

	// RVA: 0x3060AF8 Offset: 0x305CAF8 VA: 0x3060AF8
	public static Task<Task> WhenAny(Task[] tasks) { }

	// RVA: 0x3060EC4 Offset: 0x305CEC4 VA: 0x3060EC4
	public static Task<Task> WhenAny(IEnumerable<Task> tasks) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> CreateUnwrapPromise<TResult>(Task outerTask, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F4458 Offset: 0x26F0458 VA: 0x26F4458
	|-Task.CreateUnwrapPromise<Int32Enum>
	|
	|-RVA: 0x26F44BC Offset: 0x26F04BC VA: 0x26F44BC
	|-Task.CreateUnwrapPromise<__Il2CppFullySharedGenericType>
	*/

	[FriendAccessAllowed]
	// RVA: 0x3061338 Offset: 0x305D338 VA: 0x3061338
	internal static bool AddToActiveTasks(Task task) { }

	[FriendAccessAllowed]
	// RVA: 0x3061498 Offset: 0x305D498 VA: 0x3061498
	internal static void RemoveFromActiveTasks(int taskId) { }

	// RVA: 0x30615D8 Offset: 0x305D5D8 VA: 0x30615D8 Slot: 5
	public void MarkAborted(ThreadAbortException e) { }

	// RVA: 0x305DDA0 Offset: 0x3059DA0 VA: 0x305DDA0
	private void ExecuteWithThreadLocal(ref Task currentTaskSlot) { }

	// RVA: 0x30615E8 Offset: 0x305D5E8 VA: 0x30615E8
	private static void .cctor() { }
}
