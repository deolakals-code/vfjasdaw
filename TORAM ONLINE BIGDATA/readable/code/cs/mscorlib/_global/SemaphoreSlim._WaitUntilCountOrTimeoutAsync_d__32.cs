// Assembly: mscorlib.dll
// Namespace: 
[CompilerGenerated]
private struct SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32 : IAsyncStateMachine // TypeDefIndex: 9892
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public SemaphoreSlim.TaskNode asyncWaiter; // 0x28
	public int millisecondsTimeout; // 0x30
	public SemaphoreSlim <>4__this; // 0x38
	private CancellationTokenSource <cts>5__2; // 0x40
	private object <>7__wrap2; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task> <>u__1; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__2; // 0x60

	// Methods

	// RVA: 0x304CFFC Offset: 0x3048FFC VA: 0x304CFFC Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x304D888 Offset: 0x3049888 VA: 0x304D888 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}
