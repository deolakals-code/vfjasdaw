// Assembly: System.dll
// Namespace: 
[CompilerGenerated]
private struct WebResponseStream.<ReadAllAsync>d__48 : IAsyncStateMachine // TypeDefIndex: 14540
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebResponseStream <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public bool resending; // 0x30
	private WebCompletionSource <completion>5__2; // 0x38
	private CancellationTokenSource <timeoutCts>5__3; // 0x40
	private Task <timeoutTask>5__4; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task> <>u__1; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<byte[]> <>u__2; // 0x60

	// Methods

	// RVA: 0x344B534 Offset: 0x3447534 VA: 0x344B534 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x344BFB8 Offset: 0x3447FB8 VA: 0x344BFB8 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}
