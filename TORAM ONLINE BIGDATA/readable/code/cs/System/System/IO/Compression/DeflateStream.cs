// Assembly: System.dll
// Namespace: System.IO.Compression
public class DeflateStream : Stream // TypeDefIndex: 14343
{
	// Fields
	private Stream base_stream; // 0x28
	private CompressionMode mode; // 0x30
	private bool leaveOpen; // 0x34
	private bool disposed; // 0x35
	private DeflateStreamNative native; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x34D72BC Offset: 0x34D32BC VA: 0x34D72BC
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x34D67E8 Offset: 0x34D27E8 VA: 0x34D67E8
	internal void .ctor(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits) { }

	// RVA: 0x34D72C8 Offset: 0x34D32C8 VA: 0x34D72C8
	internal void .ctor(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip) { }

	// RVA: 0x34D75B4 Offset: 0x34D35B4 VA: 0x34D75B4 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x34D7658 Offset: 0x34D3658 VA: 0x34D7658 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x34D783C Offset: 0x34D383C VA: 0x34D783C
	private int ReadInternal(byte[] array, int offset, int count) { }

	// RVA: 0x34D7160 Offset: 0x34D3160 VA: 0x34D7160
	internal ValueTask<int> ReadAsyncMemory(Memory<byte> destination, CancellationToken cancellationToken) { }

	// RVA: 0x34D6C24 Offset: 0x34D2C24 VA: 0x34D6C24
	internal int ReadCore(Span<byte> destination) { }

	// RVA: 0x34D78FC Offset: 0x34D38FC VA: 0x34D78FC Slot: 31
	public override int Read(byte[] array, int offset, int count) { }

	// RVA: 0x34D7ACC Offset: 0x34D3ACC VA: 0x34D7ACC
	private void WriteInternal(byte[] array, int offset, int count) { }

	// RVA: 0x34D7264 Offset: 0x34D3264 VA: 0x34D7264
	internal ValueTask WriteAsyncMemory(ReadOnlyMemory<byte> source, CancellationToken cancellationToken) { }

	// RVA: 0x34D6F0C Offset: 0x34D2F0C VA: 0x34D6F0C
	internal void WriteCore(ReadOnlySpan<byte> source) { }

	// RVA: 0x34D7B7C Offset: 0x34D3B7C VA: 0x34D7B7C Slot: 34
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x34D7D58 Offset: 0x34D3D58 VA: 0x34D7D58 Slot: 20
	public override void Flush() { }

	// RVA: 0x34D7E5C Offset: 0x34D3E5C VA: 0x34D7E5C Slot: 21
	public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x34D821C Offset: 0x34D421C VA: 0x34D821C Slot: 25
	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x34D85DC Offset: 0x34D45DC VA: 0x34D85DC Slot: 22
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x34D8740 Offset: 0x34D4740 VA: 0x34D8740 Slot: 26
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x34D888C Offset: 0x34D488C VA: 0x34D888C Slot: 29
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x34D88C4 Offset: 0x34D48C4 VA: 0x34D88C4 Slot: 30
	public override void SetLength(long value) { }

	// RVA: 0x34D88FC Offset: 0x34D48FC VA: 0x34D88FC Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x34D8938 Offset: 0x34D4938 VA: 0x34D8938 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x34D8940 Offset: 0x34D4940 VA: 0x34D8940 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x34D8980 Offset: 0x34D4980 VA: 0x34D8980 Slot: 11
	public override long get_Length() { }

	// RVA: 0x34D89B8 Offset: 0x34D49B8 VA: 0x34D89B8 Slot: 12
	public override long get_Position() { }

	// RVA: 0x34D89F0 Offset: 0x34D49F0 VA: 0x34D89F0 Slot: 13
	public override void set_Position(long value) { }
}
