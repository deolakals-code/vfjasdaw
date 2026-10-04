// Assembly: System.dll
// Namespace: System.Net.Sockets
public class NetworkStream : Stream // TypeDefIndex: 14560
{
	// Fields
	private readonly Socket _streamSocket; // 0x28
	private readonly bool _ownsSocket; // 0x30
	private bool _readable; // 0x31
	private bool _writeable; // 0x32
	private int _closeTimeout; // 0x34
	private bool _cleanedUp; // 0x38
	private int _currentReadTimeout; // 0x3C
	private int _currentWriteTimeout; // 0x40

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }
	internal Socket InternalSocket { get; }

	// Methods

	// RVA: 0x344D354 Offset: 0x3449354 VA: 0x344D354
	public void .ctor(Socket socket) { }

	// RVA: 0x344D510 Offset: 0x3449510 VA: 0x344D510
	public void .ctor(Socket socket, bool ownsSocket) { }

	// RVA: 0x344D360 Offset: 0x3449360 VA: 0x344D360
	public void .ctor(Socket socket, FileAccess access, bool ownsSocket) { }

	// RVA: 0x344D51C Offset: 0x344951C VA: 0x344D51C Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x344D524 Offset: 0x3449524 VA: 0x344D524 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x344D52C Offset: 0x344952C VA: 0x344D52C Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x344D534 Offset: 0x3449534 VA: 0x344D534 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x344D53C Offset: 0x344953C VA: 0x344D53C Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x344D75C Offset: 0x344975C VA: 0x344D75C Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x344D9A4 Offset: 0x34499A4 VA: 0x344D9A4 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x344DA2C Offset: 0x3449A2C VA: 0x344DA2C Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x344DAB0 Offset: 0x3449AB0 VA: 0x344DAB0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x344DAFC Offset: 0x3449AFC VA: 0x344DAFC Slot: 12
	public override long get_Position() { }

	// RVA: 0x344DB48 Offset: 0x3449B48 VA: 0x344DB48 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x344DB94 Offset: 0x3449B94 VA: 0x344DB94 Slot: 29
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x344DBE0 Offset: 0x3449BE0 VA: 0x344DBE0 Slot: 31
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x344DF28 Offset: 0x3449F28 VA: 0x344DF28 Slot: 32
	public override int Read(Span<byte> destination) { }

	// RVA: 0x344E284 Offset: 0x344A284 VA: 0x344E284 Slot: 33
	public override int ReadByte() { }

	// RVA: 0x344E2E8 Offset: 0x344A2E8 VA: 0x344E2E8 Slot: 34
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x344E630 Offset: 0x344A630 VA: 0x344E630 Slot: 35
	public override void Write(ReadOnlySpan<byte> source) { }

	// RVA: 0x344E910 Offset: 0x344A910 VA: 0x344E910 Slot: 36
	public override void WriteByte(byte value) { }

	// RVA: 0x344E968 Offset: 0x344A968 VA: 0x344E968
	public void Close(int timeout) { }

	// RVA: 0x344E9CC Offset: 0x344A9CC VA: 0x344E9CC Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x344EAD4 Offset: 0x344AAD4 VA: 0x344EAD4 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x344EB78 Offset: 0x344AB78 VA: 0x344EB78 Slot: 21
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x344EEF0 Offset: 0x344AEF0 VA: 0x344EEF0 Slot: 22
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x344F154 Offset: 0x344B154 VA: 0x344F154 Slot: 25
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x344F4CC Offset: 0x344B4CC VA: 0x344F4CC Slot: 26
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x344F730 Offset: 0x344B730 VA: 0x344F730 Slot: 23
	public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x344FDC0 Offset: 0x344BDC0 VA: 0x344FDC0 Slot: 24
	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x3450004 Offset: 0x344C004 VA: 0x3450004 Slot: 27
	public override Task WriteAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x34506A4 Offset: 0x344C6A4 VA: 0x34506A4 Slot: 28
	public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x34508E4 Offset: 0x344C8E4 VA: 0x34508E4 Slot: 20
	public override void Flush() { }

	// RVA: 0x34508E8 Offset: 0x344C8E8 VA: 0x34508E8 Slot: 30
	public override void SetLength(long value) { }

	// RVA: 0x344D7E0 Offset: 0x34497E0 VA: 0x344D7E0
	internal void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent) { }

	// RVA: 0x3450A70 Offset: 0x344CA70 VA: 0x3450A70
	internal Socket get_InternalSocket() { }
}
