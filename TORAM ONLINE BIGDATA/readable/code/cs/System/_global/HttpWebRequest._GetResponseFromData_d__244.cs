// Assembly: System.dll
// Namespace: 
[CompilerGenerated]
private struct HttpWebRequest.<GetResponseFromData>d__244 : IAsyncStateMachine // TypeDefIndex: 14487
{
	// Fields
	public int <>1__state; // 0x0
	[TupleElementNames(new[] { "response", "redirect", "mustReadAll", "writeBuffer", "ntlm" })]
	public AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>> <>t__builder; // 0x8
	public HttpWebRequest <>4__this; // 0x20
	public WebResponseStream stream; // 0x28
	public CancellationToken cancellationToken; // 0x30
	private HttpWebResponse <response>5__2; // 0x38
	private WebException <throwMe>5__3; // 0x40
	private bool <redirect>5__4; // 0x48
	private bool <mustReadAll>5__5; // 0x49
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<BufferOffsetSize> <>u__2; // 0x60

	// Methods

	// RVA: 0x3511130 Offset: 0x350D130 VA: 0x3511130 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3511E04 Offset: 0x350DE04 VA: 0x3511E04 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}
