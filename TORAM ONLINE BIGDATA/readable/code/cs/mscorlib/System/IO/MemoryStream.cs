// Assembly: mscorlib.dll
// Namespace: System.IO
[Serializable]
public class MemoryStream : Stream // TypeDefIndex: 10694
{
	// Fields
	private byte[] _buffer; // 0x28
	private int _origin; // 0x30
	private int _position; // 0x34
	private int _length; // 0x38
	private int _capacity; // 0x3C
	private bool _expandable; // 0x40
	private bool _writable; // 0x41
	private bool _exposable; // 0x42
	private bool _isOpen; // 0x43
	private Task<int> _lastReadTask; // 0x48

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public virtual int Capacity { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x2F3FFA4 Offset: 0x2F3BFA4 VA: 0x2F3FFA4
	public void .ctor() { }

	// RVA: 0x2F3FFAC Offset: 0x2F3BFAC VA: 0x2F3FFAC
	public void .ctor(int capacity) { }

	// RVA: 0x2F40124 Offset: 0x2F3C124 VA: 0x2F40124
	public void .ctor(byte[] buffer) { }

	// RVA: 0x2F4012C Offset: 0x2F3C12C VA: 0x2F4012C
	public void .ctor(byte[] buffer, bool writable) { }

	// RVA: 0x2F40224 Offset: 0x2F3C224 VA: 0x2F40224
	public void .ctor(byte[] buffer, int index, int count) { }

	// RVA: 0x2F40230 Offset: 0x2F3C230 VA: 0x2F40230
	public void .ctor(byte[] buffer, int index, int count, bool writable, bool publiclyVisible) { }

	// RVA: 0x2F40404 Offset: 0x2F3C404 VA: 0x2F40404 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x2F4040C Offset: 0x2F3C40C VA: 0x2F4040C Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x2F40414 Offset: 0x2F3C414 VA: 0x2F40414 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x2F4041C Offset: 0x2F3C41C VA: 0x2F4041C
	private void EnsureNotClosed() { }

	// RVA: 0x2F40450 Offset: 0x2F3C450 VA: 0x2F40450
	private void EnsureWriteable() { }

	// RVA: 0x2F4048C Offset: 0x2F3C48C VA: 0x2F4048C Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2F40548 Offset: 0x2F3C548 VA: 0x2F40548
	private bool EnsureCapacity(int value) { }

	// RVA: 0x2F405FC Offset: 0x2F3C5FC VA: 0x2F405FC Slot: 20
	public override void Flush() { }

	// RVA: 0x2F40600 Offset: 0x2F3C600 VA: 0x2F40600 Slot: 37
	public virtual byte[] GetBuffer() { }

	// RVA: 0x2F40660 Offset: 0x2F3C660 VA: 0x2F40660
	internal byte[] InternalGetBuffer() { }

	// RVA: 0x2F40668 Offset: 0x2F3C668 VA: 0x2F40668
	internal int InternalGetPosition() { }

	// RVA: 0x2F40670 Offset: 0x2F3C670 VA: 0x2F40670
	internal int InternalReadInt32() { }

	// RVA: 0x2F40728 Offset: 0x2F3C728 VA: 0x2F40728
	internal int InternalEmulateRead(int count) { }

	// RVA: 0x2F40764 Offset: 0x2F3C764 VA: 0x2F40764 Slot: 38
	public virtual int get_Capacity() { }

	// RVA: 0x2F40784 Offset: 0x2F3C784 VA: 0x2F40784 Slot: 39
	public virtual void set_Capacity(int value) { }

	// RVA: 0x2F40910 Offset: 0x2F3C910 VA: 0x2F40910 Slot: 11
	public override long get_Length() { }

	// RVA: 0x2F40934 Offset: 0x2F3C934 VA: 0x2F40934 Slot: 12
	public override long get_Position() { }

	// RVA: 0x2F40954 Offset: 0x2F3C954 VA: 0x2F40954 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x2F40A1C Offset: 0x2F3CA1C VA: 0x2F40A1C Slot: 31
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x2F40C00 Offset: 0x2F3CC00 VA: 0x2F40C00 Slot: 32
	public override int Read(Span<byte> buffer) { }

	// RVA: 0x2F40DD0 Offset: 0x2F3CDD0 VA: 0x2F40DD0 Slot: 23
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x2F41164 Offset: 0x2F3D164 VA: 0x2F41164 Slot: 24
	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x2F414E8 Offset: 0x2F3D4E8 VA: 0x2F414E8 Slot: 33
	public override int ReadByte() { }

	// RVA: 0x2F41540 Offset: 0x2F3D540 VA: 0x2F41540 Slot: 29
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x2F4168C Offset: 0x2F3D68C VA: 0x2F4168C Slot: 30
	public override void SetLength(long value) { }

	// RVA: 0x2F41768 Offset: 0x2F3D768 VA: 0x2F41768 Slot: 40
	public virtual byte[] ToArray() { }

	// RVA: 0x2F41854 Offset: 0x2F3D854 VA: 0x2F41854 Slot: 34
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2F41AD8 Offset: 0x2F3DAD8 VA: 0x2F41AD8 Slot: 35
	public override void Write(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x2F41D04 Offset: 0x2F3DD04 VA: 0x2F41D04 Slot: 27
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x2F42038 Offset: 0x2F3E038 VA: 0x2F42038 Slot: 28
	public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x2F42338 Offset: 0x2F3E338 VA: 0x2F42338 Slot: 36
	public override void WriteByte(byte value) { }
}
