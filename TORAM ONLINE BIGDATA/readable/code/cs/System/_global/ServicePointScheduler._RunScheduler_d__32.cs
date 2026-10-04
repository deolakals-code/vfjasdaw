// Assembly: System.dll
// Namespace: 
[CompilerGenerated]
private struct ServicePointScheduler.<RunScheduler>d__32 : IAsyncStateMachine // TypeDefIndex: 14505
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public ServicePointScheduler <>4__this; // 0x20
	private ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>[] <operationArray>5__2; // 0x28
	private ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>[] <idleArray>5__3; // 0x30
	private List<Task> <taskList>5__4; // 0x38
	private Task<bool> <schedulerTask>5__5; // 0x40
	private bool <finalCleanup>5__6; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task> <>u__1; // 0x50

	// Methods

	// RVA: 0x3518E3C Offset: 0x3514E3C VA: 0x3518E3C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3519A10 Offset: 0x3515A10 VA: 0x3519A10 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}
