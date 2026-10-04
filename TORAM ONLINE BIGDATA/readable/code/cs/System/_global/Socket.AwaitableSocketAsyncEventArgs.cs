// Assembly: System.dll
// Namespace: 
internal sealed class Socket.AwaitableSocketAsyncEventArgs : SocketAsyncEventArgs, IValueTaskSource, IValueTaskSource<int> // TypeDefIndex: 14565
{
	// Fields
	internal static readonly Socket.AwaitableSocketAsyncEventArgs Reserved; // 0x0
	private static readonly Action<object> s_completedSentinel; // 0x8
	private static readonly Action<object> s_availableSentinel; // 0x10
	private Action<object> _continuation; // 0x80
	private ExecutionContext _executionContext; // 0x88
	private object _scheduler; // 0x90
	private short _token; // 0x98
	[CompilerGenerated]
	private bool <WrapExceptionsInIOExceptions>k__BackingField; // 0x9A

	// Properties
	public bool WrapExceptionsInIOExceptions { get; set; }

	// Methods

	// RVA: 0x3459804 Offset: 0x3455804 VA: 0x3459804
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x345990C Offset: 0x345590C VA: 0x345990C
	public bool get_WrapExceptionsInIOExceptions() { }

	[CompilerGenerated]
	// RVA: 0x3459914 Offset: 0x3455914 VA: 0x3459914
	public void set_WrapExceptionsInIOExceptions(bool value) { }

	// RVA: 0x3450B04 Offset: 0x344CB04 VA: 0x3450B04
	public bool Reserve() { }

	// RVA: 0x3459920 Offset: 0x3455920 VA: 0x3459920
	private void Release() { }

	// RVA: 0x345999C Offset: 0x345599C VA: 0x345999C Slot: 5
	protected override void OnCompleted(SocketAsyncEventArgs _) { }

	// RVA: 0x3450C78 Offset: 0x344CC78 VA: 0x3450C78
	public ValueTask<int> ReceiveAsync(Socket socket) { }

	// RVA: 0x3451118 Offset: 0x344D118 VA: 0x3451118
	public ValueTask SendAsyncForNetworkStream(Socket socket) { }

	// RVA: 0x3459FA8 Offset: 0x3455FA8 VA: 0x3459FA8 Slot: 9
	public ValueTaskSourceStatus GetStatus(short token) { }

	// RVA: 0x345A088 Offset: 0x3456088 VA: 0x345A088 Slot: 10
	public void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags) { }

	// RVA: 0x3459BCC Offset: 0x3455BCC VA: 0x3459BCC
	private void InvokeContinuation(Action<object> continuation, object state, bool forceAsync) { }

	// RVA: 0x345A324 Offset: 0x3456324 VA: 0x345A324 Slot: 11
	public int GetResult(short token) { }

	// RVA: 0x345A390 Offset: 0x3456390 VA: 0x345A390 Slot: 8
	private void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(short token) { }

	// RVA: 0x345A03C Offset: 0x345603C VA: 0x345A03C
	private void ThrowIncorrectTokenException() { }

	// RVA: 0x345A2D8 Offset: 0x34562D8 VA: 0x345A2D8
	private void ThrowMultipleContinuationsException() { }

	// RVA: 0x345A36C Offset: 0x345636C VA: 0x345A36C
	private void ThrowException(SocketError error) { }

	// RVA: 0x3459EBC Offset: 0x3455EBC VA: 0x3459EBC
	private Exception CreateException(SocketError error) { }

	// RVA: 0x345A3D0 Offset: 0x34563D0 VA: 0x345A3D0
	private static void .cctor() { }
}
