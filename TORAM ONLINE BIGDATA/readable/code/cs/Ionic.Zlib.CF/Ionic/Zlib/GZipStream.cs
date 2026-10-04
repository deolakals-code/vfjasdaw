// Assembly: Ionic.Zlib.CF.dll
// Namespace: Ionic.Zlib
public class GZipStream : Stream // TypeDefIndex: 17162
{
	// Fields
	public Nullable<DateTime> LastModified; // 0x28
	private int _headerByteCount; // 0x38
	internal ZlibBaseStream _baseStream; // 0x40
	private bool _disposed; // 0x48
	private bool _firstReadDone; // 0x49
	private string _FileName; // 0x50
	private string _Comment; // 0x58
	private int _Crc32; // 0x60
	internal static readonly DateTime _unixEpoch; // 0x0
	internal static readonly Encoding iso8859dash1; // 0x8

	// Properties
	public string Comment { get; set; }
	public string FileName { get; set; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x2E39AC0 Offset: 0x2E35AC0 VA: 0x2E39AC0
	public string get_Comment() { }

	// RVA: 0x2E39AC8 Offset: 0x2E35AC8 VA: 0x2E39AC8
	public void set_Comment(string value) { }

	// RVA: 0x2E39B28 Offset: 0x2E35B28 VA: 0x2E39B28
	public string get_FileName() { }

	// RVA: 0x2E39B30 Offset: 0x2E35B30 VA: 0x2E39B30
	public void set_FileName(string value) { }

	// RVA: 0x2E39CE4 Offset: 0x2E35CE4 VA: 0x2E39CE4
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x2E39CF0 Offset: 0x2E35CF0 VA: 0x2E39CF0
	public void .ctor(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen) { }

	// RVA: 0x2E39EF0 Offset: 0x2E35EF0 VA: 0x2E39EF0 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2E39FF8 Offset: 0x2E35FF8 VA: 0x2E39FF8 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x2E3A070 Offset: 0x2E36070 VA: 0x2E3A070 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x2E3A078 Offset: 0x2E36078 VA: 0x2E3A078 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x2E3A0F0 Offset: 0x2E360F0 VA: 0x2E3A0F0 Slot: 20
	public override void Flush() { }

	// RVA: 0x2E3A164 Offset: 0x2E36164 VA: 0x2E3A164 Slot: 11
	public override long get_Length() { }

	// RVA: 0x2E3A19C Offset: 0x2E3619C VA: 0x2E3A19C Slot: 12
	public override long get_Position() { }

	// RVA: 0x2E3A1FC Offset: 0x2E361FC VA: 0x2E3A1FC Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x2E3A234 Offset: 0x2E36234 VA: 0x2E3A234 Slot: 31
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x2E3A2F8 Offset: 0x2E362F8 VA: 0x2E3A2F8 Slot: 29
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2E3A330 Offset: 0x2E36330 VA: 0x2E3A330 Slot: 30
	public override void SetLength(long value) { }

	// RVA: 0x2E3A368 Offset: 0x2E36368 VA: 0x2E3A368 Slot: 34
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2E3A464 Offset: 0x2E36464 VA: 0x2E3A464
	private int EmitHeader() { }

	// RVA: 0x2E3A834 Offset: 0x2E36834 VA: 0x2E3A834
	private static void .cctor() { }
}
