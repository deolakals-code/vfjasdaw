// Assembly: mscorlib.dll
// Namespace: System.IO
[Serializable]
public class StreamReader : TextReader // TypeDefIndex: 10700
{
	// Fields
	public static readonly StreamReader Null; // 0x0
	private Stream _stream; // 0x18
	private Encoding _encoding; // 0x20
	private Decoder _decoder; // 0x28
	private byte[] _byteBuffer; // 0x30
	private char[] _charBuffer; // 0x38
	private int _charPos; // 0x40
	private int _charLen; // 0x44
	private int _byteLen; // 0x48
	private int _bytePos; // 0x4C
	private int _maxCharsPerBuffer; // 0x50
	private bool _detectEncoding; // 0x54
	private bool _checkPreamble; // 0x55
	private bool _isBlocked; // 0x56
	private bool _closable; // 0x57
	private Task _asyncReadTask; // 0x58

	// Properties
	public virtual Encoding CurrentEncoding { get; }
	public virtual Stream BaseStream { get; }
	internal bool LeaveOpen { get; }

	// Methods

	// RVA: 0x2F43744 Offset: 0x2F3F744 VA: 0x2F43744
	private void CheckAsyncTaskInProgress() { }

	// RVA: 0x2F437A8 Offset: 0x2F3F7A8 VA: 0x2F437A8
	private static void ThrowAsyncIOInProgress() { }

	// RVA: 0x2F437F4 Offset: 0x2F3F7F4 VA: 0x2F437F4
	internal void .ctor() { }

	// RVA: 0x2F438C0 Offset: 0x2F3F8C0 VA: 0x2F438C0
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x2F438D0 Offset: 0x2F3F8D0 VA: 0x2F438D0
	public void .ctor(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x2F43C50 Offset: 0x2F3FC50 VA: 0x2F43C50
	public void .ctor(string path) { }

	// RVA: 0x2F43C88 Offset: 0x2F3FC88 VA: 0x2F43C88
	public void .ctor(string path, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x2F43CC4 Offset: 0x2F3FCC4 VA: 0x2F43CC4
	public void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }

	// RVA: 0x2F43AE8 Offset: 0x2F3FAE8 VA: 0x2F43AE8
	private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x2F43F00 Offset: 0x2F3FF00 VA: 0x2F43F00
	internal void Init(Stream stream) { }

	// RVA: 0x2F43F24 Offset: 0x2F3FF24 VA: 0x2F43F24 Slot: 7
	public override void Close() { }

	// RVA: 0x2F43F34 Offset: 0x2F3FF34 VA: 0x2F43F34 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2F43FDC Offset: 0x2F3FFDC VA: 0x2F43FDC Slot: 14
	public virtual Encoding get_CurrentEncoding() { }

	// RVA: 0x2F43FE4 Offset: 0x2F3FFE4 VA: 0x2F43FE4 Slot: 15
	public virtual Stream get_BaseStream() { }

	// RVA: 0x2F43FCC Offset: 0x2F3FFCC VA: 0x2F43FCC
	internal bool get_LeaveOpen() { }

	// RVA: 0x2F43FEC Offset: 0x2F3FFEC VA: 0x2F43FEC Slot: 9
	public override int Peek() { }

	// RVA: 0x2F440B0 Offset: 0x2F400B0 VA: 0x2F440B0 Slot: 10
	public override int Read() { }

	// RVA: 0x2F44174 Offset: 0x2F40174 VA: 0x2F44174 Slot: 11
	public override int Read(char[] buffer, int index, int count) { }

	// RVA: 0x2F44300 Offset: 0x2F40300 VA: 0x2F44300
	private int ReadSpan(Span<char> buffer) { }

	// RVA: 0x2F44828 Offset: 0x2F40828 VA: 0x2F44828 Slot: 12
	public override string ReadToEnd() { }

	// RVA: 0x2F44940 Offset: 0x2F40940 VA: 0x2F44940
	private void CompressBuffer(int n) { }

	// RVA: 0x2F44984 Offset: 0x2F40984 VA: 0x2F44984
	private void DetectEncoding() { }

	// RVA: 0x2F44C88 Offset: 0x2F40C88 VA: 0x2F44C88
	private bool IsPreamble() { }

	// RVA: 0x2F44DA0 Offset: 0x2F40DA0 VA: 0x2F44DA0 Slot: 16
	internal virtual int ReadBuffer() { }

	// RVA: 0x2F44518 Offset: 0x2F40518 VA: 0x2F44518
	private int ReadBuffer(Span<char> userBuffer, out bool readToUserBuffer) { }

	// RVA: 0x2F44F0C Offset: 0x2F40F0C VA: 0x2F44F0C Slot: 13
	public override string ReadLine() { }

	// RVA: 0x2F45168 Offset: 0x2F41168 VA: 0x2F45168
	internal bool DataAvailable() { }

	// RVA: 0x2F45178 Offset: 0x2F41178 VA: 0x2F45178
	private static void .cctor() { }
}
