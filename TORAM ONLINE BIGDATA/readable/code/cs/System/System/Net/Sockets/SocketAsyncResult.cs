// Assembly: System.dll
// Namespace: System.Net.Sockets
internal sealed class SocketAsyncResult : IOAsyncResult // TypeDefIndex: 14591
{
	// Fields
	public Socket socket; // 0x30
	public SocketOperation operation; // 0x38
	private Exception DelayedException; // 0x40
	public EndPoint EndPoint; // 0x48
	public Memory<byte> Buffer; // 0x50
	public int Offset; // 0x60
	public int Size; // 0x64
	public SocketFlags SockFlags; // 0x68
	public Socket AcceptSocket; // 0x70
	public IPAddress[] Addresses; // 0x78
	public int Port; // 0x80
	public IList<ArraySegment<byte>> Buffers; // 0x88
	public bool ReuseSocket; // 0x90
	public int CurrentAddress; // 0x94
	public Socket AcceptedSocket; // 0x98
	public int Total; // 0xA0
	internal int error; // 0xA4
	public int EndCalled; // 0xA8

	// Properties
	public IntPtr Handle { get; }
	public SocketError ErrorCode { get; }

	// Methods

	// RVA: 0x345521C Offset: 0x345121C VA: 0x345521C
	public IntPtr get_Handle() { }

	// RVA: 0x345F52C Offset: 0x345B52C VA: 0x345F52C
	public void .ctor() { }

	// RVA: 0x3458D48 Offset: 0x3454D48 VA: 0x3458D48
	public void Init(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x34551D8 Offset: 0x34511D8 VA: 0x34551D8
	public void .ctor(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x3457980 Offset: 0x3453980 VA: 0x3457980
	public SocketError get_ErrorCode() { }

	// RVA: 0x3455600 Offset: 0x3451600 VA: 0x3455600
	public void CheckIfThrowDelayedException() { }

	// RVA: 0x345F640 Offset: 0x345B640 VA: 0x345F640 Slot: 8
	internal override void CompleteDisposed() { }

	// RVA: 0x345C46C Offset: 0x345846C VA: 0x345C46C
	public void Complete() { }

	// RVA: 0x3456D40 Offset: 0x3452D40 VA: 0x3456D40
	public void Complete(bool synch) { }

	// RVA: 0x34587C8 Offset: 0x34547C8 VA: 0x34587C8
	public void Complete(int total) { }

	// RVA: 0x3456D10 Offset: 0x3452D10 VA: 0x3456D10
	public void Complete(Exception e, bool synch) { }

	// RVA: 0x34587AC Offset: 0x34547AC VA: 0x34587AC
	public void Complete(Exception e) { }

	// RVA: 0x345BC90 Offset: 0x3457C90 VA: 0x345BC90
	public void Complete(Socket s) { }

	// RVA: 0x345BEF8 Offset: 0x3457EF8 VA: 0x345BEF8
	public void Complete(Socket s, int total) { }
}
