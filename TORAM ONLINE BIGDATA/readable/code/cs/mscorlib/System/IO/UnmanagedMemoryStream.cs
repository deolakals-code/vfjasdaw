// Assembly: mscorlib.dll
// Namespace: System.IO
public class UnmanagedMemoryStream : Stream // TypeDefIndex: 10708
{
	// Fields
	private SafeBuffer _buffer; // 0x28
	private byte* _mem; // 0x30
	private long _length; // 0x38
	private long _capacity; // 0x40
	private long _position; // 0x48
	private long _offset; // 0x50
	private FileAccess _access; // 0x58
	internal bool _isOpen; // 0x5C
	private Task<int> _lastReadTask; // 0x60

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	[CLSCompliant(False)]
	public byte* PositionPointer { get; }

	// Methods

	// RVA: 0x2F42ED8 Offset: 0x2F3EED8 VA: 0x2F42ED8
	protected void .ctor() { }

	[CLSCompliant(False)]
	// RVA: 0x2F477C4 Offset: 0x2F437C4 VA: 0x2F477C4
	public void .ctor(byte* pointer, long length, long capacity, FileAccess access) { }

	[CLSCompliant(False)]
	// RVA: 0x2F42F3C Offset: 0x2F3EF3C VA: 0x2F42F3C
	protected void Initialize(byte* pointer, long length, long capacity, FileAccess access) { }

	// RVA: 0x2F47854 Offset: 0x2F43854 VA: 0x2F47854 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x2F47870 Offset: 0x2F43870 VA: 0x2F47870 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x2F47878 Offset: 0x2F43878 VA: 0x2F47878 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x2F43730 Offset: 0x2F3F730 VA: 0x2F43730 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2F47894 Offset: 0x2F43894 VA: 0x2F47894
	private void EnsureNotClosed() { }

	// RVA: 0x2F478C8 Offset: 0x2F438C8 VA: 0x2F478C8
	private void EnsureReadable() { }

	// RVA: 0x2F47904 Offset: 0x2F43904 VA: 0x2F47904
	private void EnsureWriteable() { }

	// RVA: 0x2F47940 Offset: 0x2F43940 VA: 0x2F47940 Slot: 20
	public override void Flush() { }

	// RVA: 0x2F47944 Offset: 0x2F43944 VA: 0x2F47944 Slot: 11
	public override long get_Length() { }

	// RVA: 0x2F47960 Offset: 0x2F43960 VA: 0x2F47960 Slot: 12
	public override long get_Position() { }

	// RVA: 0x2F479A8 Offset: 0x2F439A8 VA: 0x2F479A8 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x2F47A4C Offset: 0x2F43A4C VA: 0x2F47A4C
	public byte* get_PositionPointer() { }

	// RVA: 0x2F47B04 Offset: 0x2F43B04 VA: 0x2F47B04 Slot: 31
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x2F47C8C Offset: 0x2F43C8C VA: 0x2F47C8C Slot: 32
	public override int Read(Span<byte> buffer) { }

	// RVA: 0x2F4312C Offset: 0x2F3F12C VA: 0x2F4312C
	internal int ReadCore(Span<byte> buffer) { }

	// RVA: 0x2F47D70 Offset: 0x2F43D70 VA: 0x2F47D70 Slot: 23
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x2F480AC Offset: 0x2F440AC VA: 0x2F480AC Slot: 24
	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x2F483EC Offset: 0x2F443EC VA: 0x2F483EC Slot: 33
	public override int ReadByte() { }

	// RVA: 0x2F4854C Offset: 0x2F4454C VA: 0x2F4854C Slot: 29
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x2F48654 Offset: 0x2F44654 VA: 0x2F48654 Slot: 30
	public override void SetLength(long value) { }

	// RVA: 0x2F487D8 Offset: 0x2F447D8 VA: 0x2F487D8 Slot: 34
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2F4898C Offset: 0x2F4498C VA: 0x2F4898C Slot: 35
	public override void Write(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x2F43354 Offset: 0x2F3F354 VA: 0x2F43354
	internal void WriteCore(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x2F48A70 Offset: 0x2F44A70 VA: 0x2F48A70 Slot: 27
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x2F48D4C Offset: 0x2F44D4C VA: 0x2F48D4C Slot: 28
	public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x2F49008 Offset: 0x2F45008 VA: 0x2F49008 Slot: 36
	public override void WriteByte(byte value) { }
}
