// Assembly: mscorlib.dll
// Namespace: 
private sealed class Stream.NullStream : Stream // TypeDefIndex: 10724
{
	// Fields
	private static readonly Task<int> s_zeroTask; // 0x0

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x2F4EA18 Offset: 0x2F4AA18 VA: 0x2F4EA18
	internal void .ctor() { }

	// RVA: 0x2F4EC6C Offset: 0x2F4AC6C VA: 0x2F4EC6C Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x2F4EC74 Offset: 0x2F4AC74 VA: 0x2F4EC74 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x2F4EC7C Offset: 0x2F4AC7C VA: 0x2F4EC7C Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x2F4EC84 Offset: 0x2F4AC84 VA: 0x2F4EC84 Slot: 11
	public override long get_Length() { }

	// RVA: 0x2F4EC8C Offset: 0x2F4AC8C VA: 0x2F4EC8C Slot: 12
	public override long get_Position() { }

	// RVA: 0x2F4EC94 Offset: 0x2F4AC94 VA: 0x2F4EC94 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x2F4EC98 Offset: 0x2F4AC98 VA: 0x2F4EC98 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2F4EC9C Offset: 0x2F4AC9C VA: 0x2F4EC9C Slot: 20
	public override void Flush() { }

	// RVA: 0x2F4ECA0 Offset: 0x2F4ACA0 VA: 0x2F4ECA0 Slot: 21
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x2F4ED2C Offset: 0x2F4AD2C VA: 0x2F4ED2C Slot: 22
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x2F4EDCC Offset: 0x2F4ADCC VA: 0x2F4EDCC Slot: 25
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x2F4EE58 Offset: 0x2F4AE58 VA: 0x2F4EE58 Slot: 26
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x2F4EEF8 Offset: 0x2F4AEF8 VA: 0x2F4EEF8 Slot: 31
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x2F4EF00 Offset: 0x2F4AF00 VA: 0x2F4EF00 Slot: 32
	public override int Read(Span<byte> buffer) { }

	// RVA: 0x2F4EF08 Offset: 0x2F4AF08 VA: 0x2F4EF08 Slot: 23
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x2F4EF60 Offset: 0x2F4AF60 VA: 0x2F4EF60 Slot: 24
	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x2F4EFB4 Offset: 0x2F4AFB4 VA: 0x2F4EFB4 Slot: 33
	public override int ReadByte() { }

	// RVA: 0x2F4EFBC Offset: 0x2F4AFBC VA: 0x2F4EFBC Slot: 34
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2F4EFC0 Offset: 0x2F4AFC0 VA: 0x2F4EFC0 Slot: 35
	public override void Write(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x2F4EFC4 Offset: 0x2F4AFC4 VA: 0x2F4EFC4 Slot: 27
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x2F4F0A8 Offset: 0x2F4B0A8 VA: 0x2F4F0A8 Slot: 28
	public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x2F4F180 Offset: 0x2F4B180 VA: 0x2F4F180 Slot: 36
	public override void WriteByte(byte value) { }

	// RVA: 0x2F4F184 Offset: 0x2F4B184 VA: 0x2F4F184 Slot: 29
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2F4F18C Offset: 0x2F4B18C VA: 0x2F4F18C Slot: 30
	public override void SetLength(long length) { }

	// RVA: 0x2F4F190 Offset: 0x2F4B190 VA: 0x2F4F190
	private static void .cctor() { }
}
