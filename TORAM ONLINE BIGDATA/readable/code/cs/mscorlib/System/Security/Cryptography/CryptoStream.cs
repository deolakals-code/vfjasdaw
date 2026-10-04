// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
public class CryptoStream : Stream, IDisposable // TypeDefIndex: 10096
{
	// Fields
	private readonly Stream _stream; // 0x28
	private readonly ICryptoTransform _transform; // 0x30
	private readonly CryptoStreamMode _transformMode; // 0x38
	private byte[] _inputBuffer; // 0x40
	private int _inputBufferIndex; // 0x48
	private int _inputBlockSize; // 0x4C
	private byte[] _outputBuffer; // 0x50
	private int _outputBufferIndex; // 0x58
	private int _outputBlockSize; // 0x5C
	private bool _canRead; // 0x60
	private bool _canWrite; // 0x61
	private bool _finalBlockTransformed; // 0x62
	private SemaphoreSlim _lazyAsyncActiveSemaphore; // 0x68
	private readonly bool _leaveOpen; // 0x70

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public bool HasFlushedFinalBlock { get; }
	private SemaphoreSlim AsyncActiveSemaphore { get; }

	// Methods

	// RVA: 0x2EA83EC Offset: 0x2EA43EC VA: 0x2EA83EC
	public void .ctor(Stream stream, ICryptoTransform transform, CryptoStreamMode mode) { }

	// RVA: 0x2EA83F4 Offset: 0x2EA43F4 VA: 0x2EA83F4
	public void .ctor(Stream stream, ICryptoTransform transform, CryptoStreamMode mode, bool leaveOpen) { }

	// RVA: 0x2EA8754 Offset: 0x2EA4754 VA: 0x2EA8754 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x2EA875C Offset: 0x2EA475C VA: 0x2EA875C Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x2EA8764 Offset: 0x2EA4764 VA: 0x2EA8764 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x2EA876C Offset: 0x2EA476C VA: 0x2EA876C Slot: 11
	public override long get_Length() { }

	// RVA: 0x2EA87B8 Offset: 0x2EA47B8 VA: 0x2EA87B8 Slot: 12
	public override long get_Position() { }

	// RVA: 0x2EA8804 Offset: 0x2EA4804 VA: 0x2EA8804 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x2EA8850 Offset: 0x2EA4850 VA: 0x2EA8850
	public bool get_HasFlushedFinalBlock() { }

	// RVA: 0x2EA8858 Offset: 0x2EA4858 VA: 0x2EA8858
	public void FlushFinalBlock() { }

	// RVA: 0x2EA8A84 Offset: 0x2EA4A84 VA: 0x2EA8A84 Slot: 20
	public override void Flush() { }

	// RVA: 0x2EA8A88 Offset: 0x2EA4A88 VA: 0x2EA8A88 Slot: 29
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2EA8AD4 Offset: 0x2EA4AD4 VA: 0x2EA8AD4 Slot: 30
	public override void SetLength(long value) { }

	// RVA: 0x2EA8B20 Offset: 0x2EA4B20 VA: 0x2EA8B20 Slot: 23
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x2EA8E00 Offset: 0x2EA4E00 VA: 0x2EA8E00 Slot: 21
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x2EA8EB4 Offset: 0x2EA4EB4 VA: 0x2EA8EB4 Slot: 22
	public override int EndRead(IAsyncResult asyncResult) { }

	[AsyncStateMachine(typeof(CryptoStream.<ReadAsyncInternal>d__37))]
	// RVA: 0x2EA8CA0 Offset: 0x2EA4CA0 VA: 0x2EA8CA0
	private Task<int> ReadAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x2EA8EFC Offset: 0x2EA4EFC VA: 0x2EA8EFC Slot: 33
	public override int ReadByte() { }

	// RVA: 0x2EA8F78 Offset: 0x2EA4F78 VA: 0x2EA8F78 Slot: 36
	public override void WriteByte(byte value) { }

	// RVA: 0x2EA8FCC Offset: 0x2EA4FCC VA: 0x2EA8FCC Slot: 31
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x2EA8B68 Offset: 0x2EA4B68 VA: 0x2EA8B68
	private void CheckReadArguments(byte[] buffer, int offset, int count) { }

	[AsyncStateMachine(typeof(CryptoStream.<ReadAsyncCore>d__42))]
	// RVA: 0x2EA908C Offset: 0x2EA508C VA: 0x2EA908C
	private Task<int> ReadAsyncCore(byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync) { }

	// RVA: 0x2EA9204 Offset: 0x2EA5204 VA: 0x2EA9204 Slot: 27
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x2EA94B4 Offset: 0x2EA54B4 VA: 0x2EA94B4 Slot: 25
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x2EA9568 Offset: 0x2EA5568 VA: 0x2EA9568 Slot: 26
	public override void EndWrite(IAsyncResult asyncResult) { }

	[AsyncStateMachine(typeof(CryptoStream.<WriteAsyncInternal>d__46))]
	// RVA: 0x2EA9384 Offset: 0x2EA5384 VA: 0x2EA9384
	private Task WriteAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x2EA9574 Offset: 0x2EA5574 VA: 0x2EA9574 Slot: 34
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2EA924C Offset: 0x2EA524C VA: 0x2EA924C
	private void CheckWriteArguments(byte[] buffer, int offset, int count) { }

	[AsyncStateMachine(typeof(CryptoStream.<WriteAsyncCore>d__49))]
	// RVA: 0x2EA95E0 Offset: 0x2EA55E0 VA: 0x2EA95E0
	private Task WriteAsyncCore(byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync) { }

	// RVA: 0x2EA9730 Offset: 0x2EA5730 VA: 0x2EA9730
	public void Clear() { }

	// RVA: 0x2EA9740 Offset: 0x2EA5740 VA: 0x2EA9740 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2EA85E0 Offset: 0x2EA45E0 VA: 0x2EA85E0
	private void InitializeBuffer() { }

	// RVA: 0x2EA97F0 Offset: 0x2EA57F0 VA: 0x2EA97F0
	private SemaphoreSlim get_AsyncActiveSemaphore() { }
}
