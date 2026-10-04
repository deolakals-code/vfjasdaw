// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
internal sealed class TailStream : Stream // TypeDefIndex: 10127
{
	// Fields
	private byte[] _Buffer; // 0x28
	private int _BufferSize; // 0x30
	private int _BufferIndex; // 0x34
	private bool _BufferFull; // 0x38

	// Properties
	public byte[] Buffer { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x2EB11CC Offset: 0x2EAD1CC VA: 0x2EB11CC
	public void .ctor(int bufferSize) { }

	// RVA: 0x2EB152C Offset: 0x2EAD52C VA: 0x2EB152C
	public void Clear() { }

	// RVA: 0x2EB153C Offset: 0x2EAD53C VA: 0x2EB153C Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2EB13CC Offset: 0x2EAD3CC VA: 0x2EB13CC
	public byte[] get_Buffer() { }

	// RVA: 0x2EB1610 Offset: 0x2EAD610 VA: 0x2EB1610 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x2EB1618 Offset: 0x2EAD618 VA: 0x2EB1618 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x2EB1620 Offset: 0x2EAD620 VA: 0x2EB1620 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x2EB1630 Offset: 0x2EAD630 VA: 0x2EB1630 Slot: 11
	public override long get_Length() { }

	// RVA: 0x2EB1688 Offset: 0x2EAD688 VA: 0x2EB1688 Slot: 12
	public override long get_Position() { }

	// RVA: 0x2EB16E0 Offset: 0x2EAD6E0 VA: 0x2EB16E0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x2EB1738 Offset: 0x2EAD738 VA: 0x2EB1738 Slot: 20
	public override void Flush() { }

	// RVA: 0x2EB173C Offset: 0x2EAD73C VA: 0x2EB173C Slot: 29
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2EB1794 Offset: 0x2EAD794 VA: 0x2EB1794 Slot: 30
	public override void SetLength(long value) { }

	// RVA: 0x2EB17EC Offset: 0x2EAD7EC VA: 0x2EB17EC Slot: 31
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x2EB1844 Offset: 0x2EAD844 VA: 0x2EB1844 Slot: 34
	public override void Write(byte[] buffer, int offset, int count) { }
}
