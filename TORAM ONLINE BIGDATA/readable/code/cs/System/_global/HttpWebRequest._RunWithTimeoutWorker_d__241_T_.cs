// Assembly: System.dll
// Namespace: 
[CompilerGenerated]
private struct HttpWebRequest.<RunWithTimeoutWorker>d__241<T> : IAsyncStateMachine // TypeDefIndex: 14485
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<T> <>t__builder; // 0x0
	public Task<T> workerTask; // 0x0
	public int timeout; // 0x0
	public CancellationTokenSource cts; // 0x0
	public Action abort; // 0x0
	public Func<bool> aborted; // 0x0
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2821E3C Offset: 0x281DE3C VA: 0x2821E3C
	|-HttpWebRequest.<RunWithTimeoutWorker>d__241<int>.MoveNext
	|
	|-RVA: 0x2822680 Offset: 0x281E680 VA: 0x2822680
	|-HttpWebRequest.<RunWithTimeoutWorker>d__241<object>.MoveNext
	|
	|-RVA: 0x2822EC4 Offset: 0x281EEC4 VA: 0x2822EC4
	|-HttpWebRequest.<RunWithTimeoutWorker>d__241<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2822608 Offset: 0x281E608 VA: 0x2822608
	|-HttpWebRequest.<RunWithTimeoutWorker>d__241<int>.SetStateMachine
	|
	|-RVA: 0x2822E4C Offset: 0x281EE4C VA: 0x2822E4C
	|-HttpWebRequest.<RunWithTimeoutWorker>d__241<object>.SetStateMachine
	|
	|-RVA: 0x28238E0 Offset: 0x281F8E0 VA: 0x28238E0
	|-HttpWebRequest.<RunWithTimeoutWorker>d__241<__Il2CppFullySharedGenericType>.SetStateMachine
	*/
}
