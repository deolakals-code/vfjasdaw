// Assembly: mscorlib.dll
// Namespace: System.IO
[ComVisible(True)]
public class FileStream : Stream // TypeDefIndex: 10738
{
	// Fields
	private static byte[] buf_recycle; // 0x0
	private static readonly object buf_recycle_lock; // 0x8
	private byte[] buf; // 0x28
	private string name; // 0x30
	private SafeFileHandle safeHandle; // 0x38
	private bool isExposed; // 0x40
	private long append_startpos; // 0x48
	private FileAccess access; // 0x50
	private bool owner; // 0x54
	private bool async; // 0x55
	private bool canseek; // 0x56
	private bool anonymous; // 0x57
	private bool buf_dirty; // 0x58
	private int buf_size; // 0x5C
	private int buf_length; // 0x60
	private int buf_offset; // 0x64
	private long buf_start; // 0x68

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public virtual string Name { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public virtual SafeFileHandle SafeFileHandle { get; }

	// Methods

	// RVA: 0x2F53B0C Offset: 0x2F4FB0C VA: 0x2F53B0C
	internal void .ctor(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	// RVA: 0x2F53F98 Offset: 0x2F4FF98 VA: 0x2F53F98
	public void .ctor(string path, FileMode mode) { }

	// RVA: 0x2F546E8 Offset: 0x2F506E8 VA: 0x2F546E8
	public void .ctor(string path, FileMode mode, FileAccess access) { }

	// RVA: 0x2F5472C Offset: 0x2F5072C VA: 0x2F5472C
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share) { }

	// RVA: 0x2F54750 Offset: 0x2F50750 VA: 0x2F54750
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize) { }

	// RVA: 0x2F54770 Offset: 0x2F50770 VA: 0x2F54770
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync) { }

	// RVA: 0x2F54798 Offset: 0x2F50798 VA: 0x2F54798
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options) { }

	// RVA: 0x2F547B8 Offset: 0x2F507B8 VA: 0x2F547B8
	public void .ctor(SafeFileHandle handle, FileAccess access) { }

	// RVA: 0x2F547C4 Offset: 0x2F507C4 VA: 0x2F547C4
	public void .ctor(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync) { }

	// RVA: 0x2F54714 Offset: 0x2F50714 VA: 0x2F54714
	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool isAsync, bool anonymous) { }

	// RVA: 0x2F53FCC Offset: 0x2F4FFCC VA: 0x2F53FCC
	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool anonymous, FileOptions options) { }

	// RVA: 0x2F53CB4 Offset: 0x2F4FCB4 VA: 0x2F53CB4
	private void Init(SafeFileHandle safeHandle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	// RVA: 0x2F56178 Offset: 0x2F52178 VA: 0x2F56178 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x2F5618C Offset: 0x2F5218C VA: 0x2F5618C Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x2F561A0 Offset: 0x2F521A0 VA: 0x2F561A0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x2F561A8 Offset: 0x2F521A8 VA: 0x2F561A8 Slot: 37
	public virtual string get_Name() { }

	// RVA: 0x2F561B0 Offset: 0x2F521B0 VA: 0x2F561B0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x2F56454 Offset: 0x2F52454 VA: 0x2F56454 Slot: 12
	public override long get_Position() { }

	// RVA: 0x2F565BC Offset: 0x2F525BC VA: 0x2F565BC Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x2F56648 Offset: 0x2F52648 VA: 0x2F56648 Slot: 38
	public virtual SafeFileHandle get_SafeFileHandle() { }

	// RVA: 0x2F56000 Offset: 0x2F52000 VA: 0x2F56000
	private void ExposeHandle() { }

	// RVA: 0x2F56804 Offset: 0x2F52804 VA: 0x2F56804 Slot: 33
	public override int ReadByte() { }

	// RVA: 0x2F56A94 Offset: 0x2F52A94 VA: 0x2F56A94 Slot: 36
	public override void WriteByte(byte value) { }

	// RVA: 0x2F56BE8 Offset: 0x2F52BE8 VA: 0x2F56BE8 Slot: 31
	public override int Read([In] [Out] byte[] array, int offset, int count) { }

	// RVA: 0x2F56E34 Offset: 0x2F52E34 VA: 0x2F56E34
	private int ReadInternal(byte[] dest, int offset, int count) { }

	// RVA: 0x2F56F88 Offset: 0x2F52F88 VA: 0x2F56F88 Slot: 21
	public override IAsyncResult BeginRead(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	// RVA: 0x2F57370 Offset: 0x2F53370 VA: 0x2F57370 Slot: 22
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x2F574F4 Offset: 0x2F534F4 VA: 0x2F574F4 Slot: 34
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x2F57718 Offset: 0x2F53718 VA: 0x2F57718
	private void WriteInternal(byte[] src, int offset, int count) { }

	// RVA: 0x2F57AA4 Offset: 0x2F53AA4 VA: 0x2F57AA4 Slot: 25
	public override IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	// RVA: 0x2F57FC8 Offset: 0x2F53FC8 VA: 0x2F57FC8 Slot: 26
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x2F58134 Offset: 0x2F54134 VA: 0x2F58134 Slot: 29
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2F58384 Offset: 0x2F54384 VA: 0x2F58384 Slot: 30
	public override void SetLength(long value) { }

	// RVA: 0x2F586C4 Offset: 0x2F546C4 VA: 0x2F586C4 Slot: 20
	public override void Flush() { }

	// RVA: 0x2F58738 Offset: 0x2F54738 VA: 0x2F58738 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2F587DC Offset: 0x2F547DC VA: 0x2F587DC Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2F58B2C Offset: 0x2F54B2C VA: 0x2F58B2C Slot: 23
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x2F58B30 Offset: 0x2F54B30 VA: 0x2F58B30 Slot: 27
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x2F56ED0 Offset: 0x2F52ED0 VA: 0x2F56ED0
	private int ReadSegment(byte[] dest, int dest_offset, int count) { }

	// RVA: 0x2F57A2C Offset: 0x2F53A2C VA: 0x2F57A2C
	private int WriteSegment(byte[] src, int src_offset, int count) { }

	// RVA: 0x2F56684 Offset: 0x2F52684 VA: 0x2F56684
	private void FlushBuffer() { }

	// RVA: 0x2F5630C Offset: 0x2F5230C VA: 0x2F5630C
	private void FlushBufferIfDirty() { }

	// RVA: 0x2F56A64 Offset: 0x2F52A64 VA: 0x2F56A64
	private void RefillBuffer() { }

	// RVA: 0x2F56944 Offset: 0x2F52944 VA: 0x2F56944
	private int ReadData(SafeHandle safeHandle, byte[] buf, int offset, int count) { }

	// RVA: 0x2F55D40 Offset: 0x2F51D40 VA: 0x2F55D40
	private void InitBuffer(int size, bool isZeroSize) { }

	// RVA: 0x2F5544C Offset: 0x2F5144C VA: 0x2F5544C
	private string GetSecureFileName(string filename) { }

	// RVA: 0x2F54F10 Offset: 0x2F50F10 VA: 0x2F54F10
	private string GetSecureFileName(string filename, bool full) { }

	// RVA: 0x2F58C8C Offset: 0x2F54C8C VA: 0x2F58C8C
	private static void .cctor() { }
}
