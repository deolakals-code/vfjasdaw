// Assembly: mscorlib.dll
// Namespace: System.IO
[Serializable]
public class StreamWriter : TextWriter // TypeDefIndex: 10701
{
	// Fields
	public static readonly StreamWriter Null; // 0x0
	private Stream _stream; // 0x30
	private Encoding _encoding; // 0x38
	private Encoder _encoder; // 0x40
	private byte[] _byteBuffer; // 0x48
	private char[] _charBuffer; // 0x50
	private int _charPos; // 0x58
	private int _charLen; // 0x5C
	private bool _autoFlush; // 0x60
	private bool _haveWrittenPreamble; // 0x61
	private bool _closable; // 0x62
	private Task _asyncWriteTask; // 0x68

	// Properties
	private static Encoding UTF8NoBOM { get; }
	public virtual bool AutoFlush { set; }
	public virtual Stream BaseStream { get; }
	internal bool LeaveOpen { get; }
	public override Encoding Encoding { get; }

	// Methods

	// RVA: 0x2F45360 Offset: 0x2F41360 VA: 0x2F45360
	private void CheckAsyncTaskInProgress() { }

	// RVA: 0x2F453C4 Offset: 0x2F413C4 VA: 0x2F453C4
	private static void ThrowAsyncIOInProgress() { }

	// RVA: 0x2F45410 Offset: 0x2F41410 VA: 0x2F45410
	private static Encoding get_UTF8NoBOM() { }

	// RVA: 0x2F45460 Offset: 0x2F41460 VA: 0x2F45460
	internal void .ctor() { }

	// RVA: 0x2F455C8 Offset: 0x2F415C8 VA: 0x2F455C8
	public void .ctor(Stream stream) { }

	// RVA: 0x2F45844 Offset: 0x2F41844 VA: 0x2F45844
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x2F4563C Offset: 0x2F4163C VA: 0x2F4563C
	public void .ctor(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen) { }

	// RVA: 0x2F459D0 Offset: 0x2F419D0 VA: 0x2F459D0
	public void .ctor(string path, bool append) { }

	// RVA: 0x2F45A48 Offset: 0x2F41A48 VA: 0x2F45A48
	public void .ctor(string path, bool append, Encoding encoding, int bufferSize) { }

	// RVA: 0x2F45850 Offset: 0x2F41850 VA: 0x2F45850
	private void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen) { }

	// RVA: 0x2F45D24 Offset: 0x2F41D24 VA: 0x2F45D24 Slot: 8
	public override void Close() { }

	// RVA: 0x2F45D90 Offset: 0x2F41D90 VA: 0x2F45D90 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2F45FA0 Offset: 0x2F41FA0 VA: 0x2F45FA0 Slot: 10
	public override void Flush() { }

	// RVA: 0x2F45E24 Offset: 0x2F41E24 VA: 0x2F45E24
	private void Flush(bool flushStream, bool flushEncoder) { }

	// RVA: 0x2F45FC0 Offset: 0x2F41FC0 VA: 0x2F45FC0 Slot: 19
	public virtual void set_AutoFlush(bool value) { }

	// RVA: 0x2F46004 Offset: 0x2F42004 VA: 0x2F46004 Slot: 20
	public virtual Stream get_BaseStream() { }

	// RVA: 0x2F4600C Offset: 0x2F4200C VA: 0x2F4600C
	internal bool get_LeaveOpen() { }

	// RVA: 0x2F4601C Offset: 0x2F4201C VA: 0x2F4601C Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x2F46024 Offset: 0x2F42024 VA: 0x2F46024 Slot: 13
	public override void Write(char value) { }

	// RVA: 0x2F460B0 Offset: 0x2F420B0 VA: 0x2F460B0 Slot: 14
	public override void Write(char[] buffer) { }

	// RVA: 0x2F46124 Offset: 0x2F42124 VA: 0x2F46124 Slot: 15
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x2F46300 Offset: 0x2F42300 VA: 0x2F46300
	private void WriteSpan(ReadOnlySpan<char> buffer, bool appendNewLine) { }

	// RVA: 0x2F465C4 Offset: 0x2F425C4 VA: 0x2F465C4 Slot: 16
	public override void Write(string value) { }

	// RVA: 0x2F46634 Offset: 0x2F42634 VA: 0x2F46634 Slot: 18
	public override void WriteLine(string value) { }

	// RVA: 0x2F466A8 Offset: 0x2F426A8 VA: 0x2F466A8
	private static void .cctor() { }
}
