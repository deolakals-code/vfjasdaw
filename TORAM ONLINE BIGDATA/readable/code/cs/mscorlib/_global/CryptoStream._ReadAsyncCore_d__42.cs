// Assembly: mscorlib.dll
// Namespace: 
[CompilerGenerated]
private struct CryptoStream.<ReadAsyncCore>d__42 : IAsyncStateMachine // TypeDefIndex: 10092
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public int count; // 0x20
	public int offset; // 0x24
	public CryptoStream <>4__this; // 0x28
	public byte[] buffer; // 0x30
	public bool useAsync; // 0x38
	public CancellationToken cancellationToken; // 0x40
	private int <bytesToDeliver>5__2; // 0x48
	private int <currentOutputIndex>5__3; // 0x4C
	private int <numWholeBlocksInBytes>5__4; // 0x50
	private byte[] <tempInputBuffer>5__5; // 0x58
	private byte[] <tempOutputBuffer>5__6; // 0x60
	private ValueTaskAwaiter<int> <>u__1; // 0x68

	// Methods

	// RVA: 0x2EA9DD8 Offset: 0x2EA5DD8 VA: 0x2EA9DD8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x2EAAE8C Offset: 0x2EA6E8C VA: 0x2EAAE8C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}
