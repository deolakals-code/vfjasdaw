// Assembly: System.dll
// Namespace: 
[CompilerGenerated]
private struct WebConnectionTunnel.<ReadHeaders>d__43 : IAsyncStateMachine // TypeDefIndex: 14522
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, byte[], int>> <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public Stream stream; // 0x28
	public WebConnectionTunnel <>4__this; // 0x30
	private byte[] <retBuffer>5__2; // 0x38
	private int <status>5__3; // 0x40
	private byte[] <buffer>5__4; // 0x48
	private MemoryStream <ms>5__5; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x58

	// Methods

	// RVA: 0x351F1E0 Offset: 0x351B1E0 VA: 0x351F1E0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x351FAF8 Offset: 0x351BAF8 VA: 0x351FAF8 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}
