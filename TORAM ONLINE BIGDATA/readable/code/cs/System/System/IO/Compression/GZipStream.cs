// Assembly: System.dll
// Namespace: System.IO.Compression
public class GZipStream : Stream // TypeDefIndex: 14340
{
	// Fields
	private DeflateStream _deflateStream; // 0x28

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x34D6728 Offset: 0x34D2728 VA: 0x34D6728
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x34D6730 Offset: 0x34D2730 VA: 0x34D6730
	public void .ctor(Stream stream, CompressionMode mode, bool leaveOpen) { }

	// RVA: 0x34D67F4 Offset: 0x34D27F4 VA: 0x34D67F4 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x34D680C Offset: 0x34D280C VA: 0x34D680C Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x34D6824 Offset: 0x34D2824 VA: 0x34D6824 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x34D683C Offset: 0x34D283C VA: 0x34D683C Slot: 11
	public override long get_Length() { }

	// RVA: 0x34D6888 Offset: 0x34D2888 VA: 0x34D6888 Slot: 12
	public override long get_Position() { }

	// RVA: 0x34D68D4 Offset: 0x34D28D4 VA: 0x34D68D4 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x34D6920 Offset: 0x34D2920 VA: 0x34D6920 Slot: 20
	public override void Flush() { }

	// RVA: 0x34D695C Offset: 0x34D295C VA: 0x34D695C Slot: 29
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x34D69A8 Offset: 0x34D29A8 VA: 0x34D69A8 Slot: 30
	public override void SetLength(long value) { }

	// RVA: 0x34D69F4 Offset: 0x34D29F4 VA: 0x34D69F4 Slot: 33
	public override int ReadByte() { }

	// RVA: 0x34D6A18 Offset: 0x34D2A18 VA: 0x34D6A18 Slot: 21
	public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x34D6ACC Offset: 0x34D2ACC VA: 0x34D6ACC Slot: 22
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x34D6B14 Offset: 0x34D2B14 VA: 0x34D6B14 Slot: 31
	public override int Read(byte[] array, int offset, int count) { }

	// RVA: 0x34D6B38 Offset: 0x34D2B38 VA: 0x34D6B38 Slot: 32
	public override int Read(Span<byte> buffer) { }

	// RVA: 0x34D6D3C Offset: 0x34D2D3C VA: 0x34D6D3C Slot: 25
	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x34D6DF0 Offset: 0x34D2DF0 VA: 0x34D6DF0 Slot: 26
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x34D6DFC Offset: 0x34D2DFC VA: 0x34D6DFC Slot: 34
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x34D6E20 Offset: 0x34D2E20 VA: 0x34D6E20 Slot: 35
	public override void Write(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x34D6F90 Offset: 0x34D2F90 VA: 0x34D6F90 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x34D7064 Offset: 0x34D3064 VA: 0x34D7064 Slot: 23
	public override Task<int> ReadAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x34D7088 Offset: 0x34D3088 VA: 0x34D7088 Slot: 24
	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x34D7168 Offset: 0x34D3168 VA: 0x34D7168 Slot: 27
	public override Task WriteAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x34D718C Offset: 0x34D318C VA: 0x34D718C Slot: 28
	public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x34D6944 Offset: 0x34D2944 VA: 0x34D6944
	private void CheckDeflateStream() { }

	// RVA: 0x34D726C Offset: 0x34D326C VA: 0x34D726C
	private static void ThrowStreamClosedException() { }
}
