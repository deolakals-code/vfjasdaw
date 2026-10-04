// Assembly: System.dll
// Namespace: System.Net
internal class FtpDataStream : Stream, ICloseEx // TypeDefIndex: 14372
{
	// Fields
	private FtpWebRequest _request; // 0x28
	private NetworkStream _networkStream; // 0x30
	private bool _writeable; // 0x38
	private bool _readable; // 0x39
	private bool _isFullyRead; // 0x3A
	private bool _closing; // 0x3B

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }

	// Methods

	// RVA: 0x34E19A8 Offset: 0x34DD9A8 VA: 0x34E19A8
	internal void .ctor(NetworkStream networkStream, FtpWebRequest request, TriState writeOnly) { }

	// RVA: 0x34E5994 Offset: 0x34E1994 VA: 0x34E5994 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x34E5B1C Offset: 0x34E1B1C VA: 0x34E5B1C Slot: 37
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x34E5F0C Offset: 0x34E1F0C VA: 0x34E5F0C
	private void CheckError() { }

	// RVA: 0x34E5F4C Offset: 0x34E1F4C VA: 0x34E5F4C Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x34E5F54 Offset: 0x34E1F54 VA: 0x34E5F54 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x34E5F74 Offset: 0x34E1F74 VA: 0x34E5F74 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x34E5F7C Offset: 0x34E1F7C VA: 0x34E5F7C Slot: 11
	public override long get_Length() { }

	// RVA: 0x34E5F9C Offset: 0x34E1F9C VA: 0x34E5F9C Slot: 12
	public override long get_Position() { }

	// RVA: 0x34E5FBC Offset: 0x34E1FBC VA: 0x34E5FBC Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x34E5FE0 Offset: 0x34E1FE0 VA: 0x34E5FE0 Slot: 29
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x34E60AC Offset: 0x34E20AC VA: 0x34E60AC Slot: 31
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x34E61B0 Offset: 0x34E21B0 VA: 0x34E61B0 Slot: 34
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x34E6288 Offset: 0x34E2288 VA: 0x34E6288
	private void AsyncReadCallback(IAsyncResult ar) { }

	// RVA: 0x34E6588 Offset: 0x34E2588 VA: 0x34E6588 Slot: 21
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x34E67D8 Offset: 0x34E27D8 VA: 0x34E67D8 Slot: 22
	public override int EndRead(IAsyncResult ar) { }

	// RVA: 0x34E6980 Offset: 0x34E2980 VA: 0x34E6980 Slot: 25
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x34E6A74 Offset: 0x34E2A74 VA: 0x34E6A74 Slot: 26
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x34E6B14 Offset: 0x34E2B14 VA: 0x34E6B14 Slot: 20
	public override void Flush() { }

	// RVA: 0x34E6B38 Offset: 0x34E2B38 VA: 0x34E6B38 Slot: 30
	public override void SetLength(long value) { }

	// RVA: 0x34E6B5C Offset: 0x34E2B5C VA: 0x34E6B5C Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x34E6B7C Offset: 0x34E2B7C VA: 0x34E6B7C Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x34E6BA0 Offset: 0x34E2BA0 VA: 0x34E6BA0 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x34E6BC4 Offset: 0x34E2BC4 VA: 0x34E6BC4 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x34E6BE8 Offset: 0x34E2BE8 VA: 0x34E6BE8 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x34E6C0C Offset: 0x34E2C0C VA: 0x34E6C0C
	internal void SetSocketTimeoutOption(int timeout) { }
}
