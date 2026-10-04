// Assembly: mscorlib.dll
// Namespace: 
[CompilerGenerated]
private struct CryptoStream.<WriteAsyncCore>d__49 : IAsyncStateMachine // TypeDefIndex: 10094
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public int count; // 0x20
	public int offset; // 0x24
	public CryptoStream <>4__this; // 0x28
	public byte[] buffer; // 0x30
	public bool useAsync; // 0x38
	public CancellationToken cancellationToken; // 0x40
	private int <bytesToWrite>5__2; // 0x48
	private int <currentInputIndex>5__3; // 0x4C
	private int <numOutputBytes>5__4; // 0x50
	private ValueTaskAwaiter <>u__1; // 0x58
	private int <numWholeBlocksInBytes>5__5; // 0x68
	private byte[] <tempOutputBuffer>5__6; // 0x70

	// Methods

	// RVA: 0x2EAB340 Offset: 0x2EA7340 VA: 0x2EAB340 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x2EAC95C Offset: 0x2EA895C VA: 0x2EAC95C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}
