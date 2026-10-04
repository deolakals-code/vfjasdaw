// Assembly: System.dll
// Namespace: System.Net
internal class NetworkStreamWrapper : Stream // TypeDefIndex: 14383
{
	// Fields
	private TcpClient _client; // 0x28
	private NetworkStream _networkStream; // 0x30

	// Properties
	protected bool UsingSecureStream { get; }
	internal IPAddress ServerAddress { get; }
	internal Socket Socket { get; }
	internal NetworkStream NetworkStream { get; set; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x34DE900 Offset: 0x34DA900 VA: 0x34DE900
	internal void .ctor(TcpClient client) { }

	// RVA: 0x34E1AC4 Offset: 0x34DDAC4 VA: 0x34E1AC4
	protected bool get_UsingSecureStream() { }

	// RVA: 0x34E1248 Offset: 0x34DD248 VA: 0x34E1248
	internal IPAddress get_ServerAddress() { }

	// RVA: 0x34E30BC Offset: 0x34DF0BC VA: 0x34E30BC
	internal Socket get_Socket() { }

	// RVA: 0x34ED940 Offset: 0x34E9940 VA: 0x34ED940
	internal NetworkStream get_NetworkStream() { }

	// RVA: 0x34ED948 Offset: 0x34E9948 VA: 0x34ED948
	internal void set_NetworkStream(NetworkStream value) { }

	// RVA: 0x34ED950 Offset: 0x34E9950 VA: 0x34ED950 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x34ED970 Offset: 0x34E9970 VA: 0x34ED970 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x34ED990 Offset: 0x34E9990 VA: 0x34ED990 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x34ED9B0 Offset: 0x34E99B0 VA: 0x34ED9B0 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x34ED9D0 Offset: 0x34E99D0 VA: 0x34ED9D0 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x34ED9F4 Offset: 0x34E99F4 VA: 0x34ED9F4 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x34EDA18 Offset: 0x34E9A18 VA: 0x34EDA18 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x34EDA3C Offset: 0x34E9A3C VA: 0x34EDA3C Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x34EDA60 Offset: 0x34E9A60 VA: 0x34EDA60 Slot: 11
	public override long get_Length() { }

	// RVA: 0x34EDA80 Offset: 0x34E9A80 VA: 0x34EDA80 Slot: 12
	public override long get_Position() { }

	// RVA: 0x34EDAA0 Offset: 0x34E9AA0 VA: 0x34EDAA0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x34EDAC4 Offset: 0x34E9AC4 VA: 0x34EDAC4 Slot: 29
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x34EDAE8 Offset: 0x34E9AE8 VA: 0x34EDAE8 Slot: 31
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x34EDB0C Offset: 0x34E9B0C VA: 0x34EDB0C Slot: 34
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x34EDB30 Offset: 0x34E9B30 VA: 0x34EDB30 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x34E00C0 Offset: 0x34DC0C0 VA: 0x34E00C0
	internal void CloseSocket() { }

	// RVA: 0x34DEB84 Offset: 0x34DAB84 VA: 0x34DEB84
	public void Close(int timeout) { }

	// RVA: 0x34EDBDC Offset: 0x34E9BDC VA: 0x34EDBDC Slot: 21
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x34EDC00 Offset: 0x34E9C00 VA: 0x34EDC00 Slot: 22
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x34EDC24 Offset: 0x34E9C24 VA: 0x34EDC24 Slot: 23
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x34EDC48 Offset: 0x34E9C48 VA: 0x34EDC48 Slot: 25
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x34EDC6C Offset: 0x34E9C6C VA: 0x34EDC6C Slot: 26
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x34EDC90 Offset: 0x34E9C90 VA: 0x34EDC90 Slot: 27
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x34EDCB4 Offset: 0x34E9CB4 VA: 0x34EDCB4 Slot: 20
	public override void Flush() { }

	// RVA: 0x34EDCD8 Offset: 0x34E9CD8 VA: 0x34EDCD8 Slot: 30
	public override void SetLength(long value) { }

	// RVA: 0x34EA4AC Offset: 0x34E64AC VA: 0x34EA4AC
	internal void SetSocketTimeoutOption(int timeout) { }
}
