// Assembly: mscorlib.dll
// Namespace: 
[CompilerGenerated]
private struct Stream.<<ReadAsync>g__FinishReadAsync|44_0>d : IAsyncStateMachine // TypeDefIndex: 10729
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder<int> <>t__builder; // 0x8
	public Task<int> readTask; // 0x28
	public byte[] localBuffer; // 0x30
	public Memory<byte> localDestination; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x48

	// Methods

	// RVA: 0x2F4FC80 Offset: 0x2F4BC80 VA: 0x2F4FC80 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x2F50008 Offset: 0x2F4C008 VA: 0x2F50008 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}
