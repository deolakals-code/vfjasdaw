// Assembly: mscorlib.dll
// Namespace: System.Threading
public class CancellationTokenSource : IDisposable // TypeDefIndex: 9882
{
	// Fields
	internal static readonly CancellationTokenSource s_canceledSource; // 0x0
	internal static readonly CancellationTokenSource s_neverCanceledSource; // 0x8
	private static readonly int s_nLists; // 0x10
	private ManualResetEvent _kernelEvent; // 0x10
	private SparselyPopulatedArray<CancellationCallbackInfo>[] _registeredCallbacksLists; // 0x18
	private const int CannotBeCanceled = 0;
	private const int NotCanceledState = 1;
	private const int NotifyingState = 2;
	private const int NotifyingCompleteState = 3;
	private int _state; // 0x20
	private int _threadIDExecutingCallbacks; // 0x24
	private bool _disposed; // 0x28
	private CancellationCallbackInfo _executingCallback; // 0x30
	private Timer _timer; // 0x38
	private static readonly TimerCallback s_timerCallback; // 0x18

	// Properties
	public bool IsCancellationRequested { get; }
	internal bool IsCancellationCompleted { get; }
	internal bool IsDisposed { get; }
	internal int ThreadIDExecutingCallbacks { get; set; }
	public CancellationToken Token { get; }
	internal CancellationCallbackInfo ExecutingCallback { get; }

	// Methods

	// RVA: 0x30479D0 Offset: 0x30439D0 VA: 0x30479D0
	public bool get_IsCancellationRequested() { }

	// RVA: 0x3049E8C Offset: 0x3045E8C VA: 0x3049E8C
	internal bool get_IsCancellationCompleted() { }

	// RVA: 0x304A0E4 Offset: 0x30460E4 VA: 0x304A0E4
	internal bool get_IsDisposed() { }

	// RVA: 0x3049EA8 Offset: 0x3045EA8 VA: 0x3049EA8
	internal int get_ThreadIDExecutingCallbacks() { }

	// RVA: 0x304A0EC Offset: 0x30460EC VA: 0x304A0EC
	internal void set_ThreadIDExecutingCallbacks(int value) { }

	// RVA: 0x304A110 Offset: 0x3046110 VA: 0x304A110
	public CancellationToken get_Token() { }

	// RVA: 0x304A194 Offset: 0x3046194 VA: 0x304A194
	internal CancellationCallbackInfo get_ExecutingCallback() { }

	// RVA: 0x304A1AC Offset: 0x30461AC VA: 0x304A1AC
	public void .ctor() { }

	// RVA: 0x304A1E0 Offset: 0x30461E0 VA: 0x304A1E0
	public void Cancel() { }

	// RVA: 0x304A1FC Offset: 0x30461FC VA: 0x304A1FC
	public void Cancel(bool throwOnFirstException) { }

	// RVA: 0x304A2D4 Offset: 0x30462D4 VA: 0x304A2D4
	public void CancelAfter(int millisecondsDelay) { }

	// RVA: 0x304A4BC Offset: 0x30464BC VA: 0x304A4BC
	private static void TimerCallbackLogic(object obj) { }

	// RVA: 0x304A5D4 Offset: 0x30465D4 VA: 0x304A5D4 Slot: 4
	public void Dispose() { }

	// RVA: 0x304A640 Offset: 0x3046640 VA: 0x304A640 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x304A140 Offset: 0x3046140 VA: 0x304A140
	internal void ThrowIfDisposed() { }

	// RVA: 0x304A6DC Offset: 0x30466DC VA: 0x304A6DC
	private static void ThrowObjectDisposedException() { }

	// RVA: 0x3047DEC Offset: 0x3043DEC VA: 0x3047DEC
	internal CancellationTokenRegistration InternalRegister(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext) { }

	// RVA: 0x304A224 Offset: 0x3046224 VA: 0x304A224
	private void NotifyCancellation(bool throwOnFirstException) { }

	// RVA: 0x304A7CC Offset: 0x30467CC VA: 0x304A7CC
	private void ExecuteCallbackHandlers(bool throwOnFirstException) { }

	// RVA: 0x304AD8C Offset: 0x3046D8C VA: 0x304AD8C
	private void CancellationCallbackCoreWork_OnSyncContext(object obj) { }

	// RVA: 0x304ACD0 Offset: 0x3046CD0 VA: 0x304ACD0
	private void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args) { }

	// RVA: 0x304AF08 Offset: 0x3046F08 VA: 0x304AF08
	public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2) { }

	// RVA: 0x304B258 Offset: 0x3047258 VA: 0x304B258
	internal static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token) { }

	// RVA: 0x3049EC0 Offset: 0x3045EC0 VA: 0x3049EC0
	internal void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo) { }

	// RVA: 0x304B324 Offset: 0x3047324 VA: 0x304B324
	private static void .cctor() { }
}
