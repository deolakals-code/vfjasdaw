// Assembly: System.dll
// Namespace: System.Net.Sockets
public class SocketAsyncEventArgs : EventArgs, IDisposable // TypeDefIndex: 14589
{
	// Fields
	private bool disposed; // 0x10
	internal int in_progress; // 0x14
	private EndPoint remote_ep; // 0x18
	private Socket current_socket; // 0x20
	internal SocketAsyncResult socket_async_result; // 0x28
	[CompilerGenerated]
	private Socket <AcceptSocket>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <BytesTransferred>k__BackingField; // 0x38
	[CompilerGenerated]
	private SocketAsyncOperation <LastOperation>k__BackingField; // 0x3C
	[CompilerGenerated]
	private SocketError <SocketError>k__BackingField; // 0x40
	[CompilerGenerated]
	private SocketFlags <SocketFlags>k__BackingField; // 0x44
	[CompilerGenerated]
	private object <UserToken>k__BackingField; // 0x48
	[CompilerGenerated]
	private EventHandler<SocketAsyncEventArgs> Completed; // 0x50
	private Memory<byte> _buffer; // 0x58
	private int _offset; // 0x68
	private int _count; // 0x6C
	private bool _bufferIsExplicitArray; // 0x70
	private IList<ArraySegment<byte>> _bufferList; // 0x78

	// Properties
	public Socket AcceptSocket { get; set; }
	public int BytesTransferred { get; set; }
	private SocketAsyncOperation LastOperation { set; }
	public EndPoint RemoteEndPoint { set; }
	public SocketError SocketError { get; set; }
	public SocketFlags SocketFlags { set; }
	public object UserToken { get; set; }
	internal Socket CurrentSocket { get; }
	public Memory<byte> MemoryBuffer { get; }
	public int Offset { get; }
	public int Count { get; }
	public IList<ArraySegment<byte>> BufferList { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x345F4D4 Offset: 0x345B4D4 VA: 0x345F4D4
	public Socket get_AcceptSocket() { }

	[CompilerGenerated]
	// RVA: 0x345F4DC Offset: 0x345B4DC VA: 0x345F4DC
	public void set_AcceptSocket(Socket value) { }

	[CompilerGenerated]
	// RVA: 0x345F4E4 Offset: 0x345B4E4 VA: 0x345F4E4
	public int get_BytesTransferred() { }

	[CompilerGenerated]
	// RVA: 0x345F4EC Offset: 0x345B4EC VA: 0x345F4EC
	private void set_BytesTransferred(int value) { }

	[CompilerGenerated]
	// RVA: 0x345F4F4 Offset: 0x345B4F4 VA: 0x345F4F4
	private void set_LastOperation(SocketAsyncOperation value) { }

	// RVA: 0x345F4FC Offset: 0x345B4FC VA: 0x345F4FC
	public void set_RemoteEndPoint(EndPoint value) { }

	[CompilerGenerated]
	// RVA: 0x345F504 Offset: 0x345B504 VA: 0x345F504
	public SocketError get_SocketError() { }

	[CompilerGenerated]
	// RVA: 0x345F50C Offset: 0x345B50C VA: 0x345F50C
	public void set_SocketError(SocketError value) { }

	[CompilerGenerated]
	// RVA: 0x345F514 Offset: 0x345B514 VA: 0x345F514
	public void set_SocketFlags(SocketFlags value) { }

	[CompilerGenerated]
	// RVA: 0x345F51C Offset: 0x345B51C VA: 0x345F51C
	public object get_UserToken() { }

	[CompilerGenerated]
	// RVA: 0x345F524 Offset: 0x345B524 VA: 0x345F524
	public void set_UserToken(object value) { }

	// RVA: 0x3459874 Offset: 0x3455874 VA: 0x3459874
	internal void .ctor(bool flowExecutionContext) { }

	// RVA: 0x345F534 Offset: 0x345B534 VA: 0x345F534 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x345F544 Offset: 0x345B544 VA: 0x345F544
	private void Dispose(bool disposing) { }

	// RVA: 0x345F558 Offset: 0x345B558 VA: 0x345F558 Slot: 4
	public void Dispose() { }

	// RVA: 0x3458FDC Offset: 0x3454FDC VA: 0x3458FDC
	internal void SetBytesTransferred(int value) { }

	// RVA: 0x345F5BC Offset: 0x345B5BC VA: 0x345F5BC
	internal Socket get_CurrentSocket() { }

	// RVA: 0x345F5C4 Offset: 0x345B5C4 VA: 0x345F5C4
	internal void SetCurrentSocket(Socket socket) { }

	// RVA: 0x3458F1C Offset: 0x3454F1C VA: 0x3458F1C
	internal void SetLastOperation(SocketAsyncOperation op) { }

	// RVA: 0x345F5CC Offset: 0x345B5CC VA: 0x345F5CC
	internal void Complete_internal() { }

	// RVA: 0x345F5F4 Offset: 0x345B5F4 VA: 0x345F5F4 Slot: 5
	protected virtual void OnCompleted(SocketAsyncEventArgs e) { }

	// RVA: 0x345F61C Offset: 0x345B61C VA: 0x345F61C
	public Memory<byte> get_MemoryBuffer() { }

	// RVA: 0x345F628 Offset: 0x345B628 VA: 0x345F628
	public int get_Offset() { }

	// RVA: 0x345F630 Offset: 0x345B630 VA: 0x345F630
	public int get_Count() { }

	// RVA: 0x345F638 Offset: 0x345B638 VA: 0x345F638
	public IList<ArraySegment<byte>> get_BufferList() { }

	// RVA: 0x3450B80 Offset: 0x344CB80 VA: 0x3450B80
	public void SetBuffer(Memory<byte> buffer) { }
}
