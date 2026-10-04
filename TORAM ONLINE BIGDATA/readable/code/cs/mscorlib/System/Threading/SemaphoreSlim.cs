// Assembly: mscorlib.dll
// Namespace: System.Threading
[ComVisible(False)]
[DebuggerDisplay("Current Count = {m_currentCount}")]
public class SemaphoreSlim : IDisposable // TypeDefIndex: 9893
{
	// Fields
	private int m_currentCount; // 0x10
	private readonly int m_maxCount; // 0x14
	private int m_waitCount; // 0x18
	private object m_lockObj; // 0x20
	private ManualResetEvent m_waitHandle; // 0x28
	private SemaphoreSlim.TaskNode m_asyncHead; // 0x30
	private SemaphoreSlim.TaskNode m_asyncTail; // 0x38
	private static readonly Task<bool> s_trueTask; // 0x0
	private static readonly Task<bool> s_falseTask; // 0x8
	private const int NO_MAXIMUM = 2147483647;
	private static Action<object> s_cancellationTokenCanceledEventHandler; // 0x10

	// Methods

	// RVA: 0x304BA34 Offset: 0x3047A34 VA: 0x304BA34
	public void .ctor(int initialCount, int maxCount) { }

	// RVA: 0x304BBCC Offset: 0x3047BCC VA: 0x304BBCC
	public void Wait() { }

	// RVA: 0x304BBD8 Offset: 0x3047BD8 VA: 0x304BBD8
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x304C498 Offset: 0x3048498 VA: 0x304C498
	private bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken) { }

	// RVA: 0x304C5C0 Offset: 0x30485C0 VA: 0x304C5C0
	public Task WaitAsync() { }

	// RVA: 0x304C174 Offset: 0x3048174 VA: 0x304C174
	public Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x304C5CC Offset: 0x30485CC VA: 0x304C5CC
	private SemaphoreSlim.TaskNode CreateAndAddAsyncWaiter() { }

	// RVA: 0x304C824 Offset: 0x3048824 VA: 0x304C824
	private bool RemoveAsyncWaiter(SemaphoreSlim.TaskNode task) { }

	[AsyncStateMachine(typeof(SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32))]
	// RVA: 0x304C67C Offset: 0x304867C VA: 0x304C67C
	private Task<bool> WaitUntilCountOrTimeoutAsync(SemaphoreSlim.TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x304C90C Offset: 0x304890C VA: 0x304C90C
	public int Release() { }

	// RVA: 0x304C914 Offset: 0x3048914 VA: 0x304C914
	public int Release(int releaseCount) { }

	// RVA: 0x304CC4C Offset: 0x3048C4C VA: 0x304CC4C
	private static void QueueWaiterTask(SemaphoreSlim.TaskNode waiterTask) { }

	// RVA: 0x304CC58 Offset: 0x3048C58 VA: 0x304CC58 Slot: 4
	public void Dispose() { }

	// RVA: 0x304CCC4 Offset: 0x3048CC4 VA: 0x304CCC4 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x304CD5C Offset: 0x3048D5C VA: 0x304CD5C
	private static void CancellationTokenCanceledEventHandler(object obj) { }

	// RVA: 0x304C0F8 Offset: 0x30480F8 VA: 0x304C0F8
	private void CheckDispose() { }

	// RVA: 0x304BBC4 Offset: 0x3047BC4 VA: 0x304BBC4
	private static string GetResourceString(string str) { }

	// RVA: 0x304CE6C Offset: 0x3048E6C VA: 0x304CE6C
	private static void .cctor() { }
}
