// Assembly: System.dll
// Namespace: 
[CompilerGenerated]
private struct HttpWebRequest.<MyGetResponseAsync>d__243 : IAsyncStateMachine // TypeDefIndex: 14486
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<HttpWebResponse> <>t__builder; // 0x8
	public HttpWebRequest <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private WebCompletionSource <completion>5__2; // 0x30
	private WebOperation <operation>5__3; // 0x38
	private WebException <throwMe>5__4; // 0x40
	private HttpWebResponse <response>5__5; // 0x48
	private WebResponseStream <stream>5__6; // 0x50
	private bool <redirect>5__7; // 0x58
	private bool <mustReadAll>5__8; // 0x59
	private WebOperation <ntlm>5__9; // 0x60
	private BufferOffsetSize <writeBuffer>5__10; // 0x68
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebRequestStream> <>u__1; // 0x70
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x80
	private TaskAwaiter<WebResponseStream> <>u__3; // 0x90
	[TupleElementNames(new[] { "response", "redirect", "mustReadAll", "writeBuffer", "ntlm" })]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>> <>u__4; // 0x98

	// Methods

	// RVA: 0x350FFD4 Offset: 0x350BFD4 VA: 0x350FFD4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x35110B4 Offset: 0x350D0B4 VA: 0x35110B4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}
