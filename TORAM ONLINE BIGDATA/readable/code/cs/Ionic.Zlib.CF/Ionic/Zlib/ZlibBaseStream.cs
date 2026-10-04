// Assembly: Ionic.Zlib.CF.dll
// Namespace: Ionic.Zlib
internal class ZlibBaseStream : Stream // TypeDefIndex: 17182
{
	// Fields
	protected internal ZlibCodec _z; // 0x28
	protected internal ZlibBaseStream.StreamMode _streamMode; // 0x30
	protected internal FlushType _flushMode; // 0x34
	protected internal ZlibStreamFlavor _flavor; // 0x38
	protected internal CompressionMode _compressionMode; // 0x3C
	protected internal CompressionLevel _level; // 0x40
	protected internal bool _leaveOpen; // 0x44
	protected internal byte[] _workingBuffer; // 0x48
	protected internal int _bufferSize; // 0x50
	protected internal byte[] _buf1; // 0x58
	protected internal Stream _stream; // 0x60
	protected internal CompressionStrategy Strategy; // 0x68
	private CRC32 crc; // 0x70
	protected internal string _GzipFileName; // 0x78
	protected internal string _GzipComment; // 0x80
	protected internal DateTime _GzipMtime; // 0x88
	protected internal int _gzipHeaderByteCount; // 0x90
	private bool nomoreinput; // 0x94

	// Properties
	internal int Crc32 { get; }
	protected internal bool _wantCompress { get; }
	private ZlibCodec z { get; }
	private byte[] workingBuffer { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x2E39FE4 Offset: 0x2E35FE4 VA: 0x2E39FE4
	internal int get_Crc32() { }

	// RVA: 0x2E39DB0 Offset: 0x2E35DB0 VA: 0x2E39DB0
	public void .ctor(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen) { }

	// RVA: 0x2E3A454 Offset: 0x2E36454 VA: 0x2E3A454
	protected internal bool get__wantCompress() { }

	// RVA: 0x2E3F7AC Offset: 0x2E3B7AC VA: 0x2E3F7AC
	private ZlibCodec get_z() { }

	// RVA: 0x2E3F878 Offset: 0x2E3B878 VA: 0x2E3F878
	private byte[] get_workingBuffer() { }

	// RVA: 0x2E3F8E4 Offset: 0x2E3B8E4 VA: 0x2E3F8E4 Slot: 34
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2E3FB34 Offset: 0x2E3BB34 VA: 0x2E3FB34
	private void finish() { }

	// RVA: 0x2E40088 Offset: 0x2E3C088 VA: 0x2E40088
	private void end() { }

	// RVA: 0x2E400EC Offset: 0x2E3C0EC VA: 0x2E400EC Slot: 18
	public override void Close() { }

	// RVA: 0x2E401E8 Offset: 0x2E3C1E8 VA: 0x2E401E8 Slot: 20
	public override void Flush() { }

	// RVA: 0x2E4020C Offset: 0x2E3C20C VA: 0x2E4020C Slot: 29
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2E40244 Offset: 0x2E3C244 VA: 0x2E40244 Slot: 30
	public override void SetLength(long value) { }

	// RVA: 0x2E40268 Offset: 0x2E3C268 VA: 0x2E40268
	private string ReadZeroTerminatedString() { }

	// RVA: 0x2E40454 Offset: 0x2E3C454 VA: 0x2E40454
	private int _ReadAndValidateGzipHeader() { }

	// RVA: 0x2E40778 Offset: 0x2E3C778 VA: 0x2E40778 Slot: 31
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x2E40BD0 Offset: 0x2E3CBD0 VA: 0x2E40BD0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x2E40BF0 Offset: 0x2E3CBF0 VA: 0x2E40BF0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x2E40C10 Offset: 0x2E3CC10 VA: 0x2E40C10 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x2E40C30 Offset: 0x2E3CC30 VA: 0x2E40C30 Slot: 11
	public override long get_Length() { }

	// RVA: 0x2E40C50 Offset: 0x2E3CC50 VA: 0x2E40C50 Slot: 12
	public override long get_Position() { }

	// RVA: 0x2E40C88 Offset: 0x2E3CC88 VA: 0x2E40C88 Slot: 13
	public override void set_Position(long value) { }
}
