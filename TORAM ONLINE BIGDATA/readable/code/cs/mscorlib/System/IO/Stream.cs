// Assembly: mscorlib.dll
// Namespace: System.IO
[Serializable]
public abstract class Stream : MarshalByRefObject, IDisposable // TypeDefIndex: 10730
{
	// Fields
	public static readonly Stream Null; // 0x0
	private const int DefaultCopyBufferSize = 81920;
	private Stream.ReadWriteTask _activeReadWriteTask; // 0x18
	private SemaphoreSlim _asyncActiveSemaphore; // 0x20

	// Properties
	public abstract bool CanRead { get; }
	public abstract bool CanSeek { get; }
	public virtual bool CanTimeout { get; }
	public abstract bool CanWrite { get; }
	public abstract long Length { get; }
	public abstract long Position { get; set; }
	public virtual int ReadTimeout { get; set; }
	public virtual int WriteTimeout { get; set; }

	// Methods

	// RVA: 0x2F4C1EC Offset: 0x2F481EC VA: 0x2F4C1EC
	internal SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_CanRead();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_CanSeek();

	// RVA: 0x2F4C2E4 Offset: 0x2F482E4 VA: 0x2F4C2E4 Slot: 9
	public virtual bool get_CanTimeout() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool get_CanWrite();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract long get_Length();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract long get_Position();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void set_Position(long value);

	// RVA: 0x2F4C2EC Offset: 0x2F482EC VA: 0x2F4C2EC Slot: 14
	public virtual int get_ReadTimeout() { }

	// RVA: 0x2F4C338 Offset: 0x2F48338 VA: 0x2F4C338 Slot: 15
	public virtual void set_ReadTimeout(int value) { }

	// RVA: 0x2F4C384 Offset: 0x2F48384 VA: 0x2F4C384 Slot: 16
	public virtual int get_WriteTimeout() { }

	// RVA: 0x2F4C3D0 Offset: 0x2F483D0 VA: 0x2F4C3D0 Slot: 17
	public virtual void set_WriteTimeout(int value) { }

	// RVA: 0x2F4C41C Offset: 0x2F4841C VA: 0x2F4C41C Slot: 18
	public virtual void Close() { }

	// RVA: 0x2F4C48C Offset: 0x2F4848C VA: 0x2F4C48C Slot: 6
	public void Dispose() { }

	// RVA: 0x2F4C49C Offset: 0x2F4849C VA: 0x2F4C49C Slot: 19
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void Flush();

	// RVA: 0x2F4C4A0 Offset: 0x2F484A0 VA: 0x2F4C4A0 Slot: 21
	public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x2F4C4C0 Offset: 0x2F484C0 VA: 0x2F4C4C0
	internal IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm) { }

	// RVA: 0x2F4CA98 Offset: 0x2F48A98 VA: 0x2F4CA98 Slot: 22
	public virtual int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x2F4CC58 Offset: 0x2F48C58 VA: 0x2F4CC58
	public Task<int> ReadAsync(byte[] buffer, int offset, int count) { }

	// RVA: 0x2F4CCEC Offset: 0x2F48CEC VA: 0x2F4CCEC Slot: 23
	public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x2F4CFAC Offset: 0x2F48FAC VA: 0x2F4CFAC Slot: 24
	public virtual ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x2F4CDCC Offset: 0x2F48DCC VA: 0x2F4CDCC
	private Task<int> BeginEndReadAsync(byte[] buffer, int offset, int count) { }

	// RVA: 0x2F4D3CC Offset: 0x2F493CC VA: 0x2F4D3CC Slot: 25
	public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x2F4D3EC Offset: 0x2F493EC VA: 0x2F4D3EC
	internal IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm) { }

	// RVA: 0x2F4C848 Offset: 0x2F48848 VA: 0x2F4C848
	private void RunReadWriteTaskWhenReady(Task asyncWaiter, Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x2F4C9D0 Offset: 0x2F489D0 VA: 0x2F4C9D0
	private void RunReadWriteTask(Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x2F4D5F0 Offset: 0x2F495F0 VA: 0x2F4D5F0
	private void FinishTrackingAsyncOperation() { }

	// RVA: 0x2F4D620 Offset: 0x2F49620 VA: 0x2F4D620 Slot: 26
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x2F4D7D0 Offset: 0x2F497D0 VA: 0x2F4D7D0
	public Task WriteAsync(byte[] buffer, int offset, int count) { }

	// RVA: 0x2F4D864 Offset: 0x2F49864 VA: 0x2F4D864 Slot: 27
	public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x2F4DB10 Offset: 0x2F49B10 VA: 0x2F4DB10 Slot: 28
	public virtual ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(Stream.<FinishWriteAsync>d__57))]
	// RVA: 0x2F4DDC8 Offset: 0x2F49DC8 VA: 0x2F4DDC8
	private Task FinishWriteAsync(Task writeTask, byte[] localBuffer) { }

	// RVA: 0x2F4D930 Offset: 0x2F49930 VA: 0x2F4D930
	private Task BeginEndWriteAsync(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract long Seek(long offset, SeekOrigin origin);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void SetLength(long value);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract int Read(byte[] buffer, int offset, int count);

	// RVA: 0x2F4DEC8 Offset: 0x2F49EC8 VA: 0x2F4DEC8 Slot: 32
	public virtual int Read(Span<byte> buffer) { }

	// RVA: 0x2F4E124 Offset: 0x2F4A124 VA: 0x2F4E124 Slot: 33
	public virtual int ReadByte() { }

	// RVA: -1 Offset: -1 Slot: 34
	public abstract void Write(byte[] buffer, int offset, int count);

	// RVA: 0x2F4E1B8 Offset: 0x2F4A1B8 VA: 0x2F4E1B8 Slot: 35
	public virtual void Write(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x2F4E380 Offset: 0x2F4A380 VA: 0x2F4E380 Slot: 36
	public virtual void WriteByte(byte value) { }

	// RVA: 0x2F4E40C Offset: 0x2F4A40C VA: 0x2F4E40C
	internal IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x2F4E614 Offset: 0x2F4A614 VA: 0x2F4E614
	internal static int BlockingEndRead(IAsyncResult asyncResult) { }

	// RVA: 0x2F4E700 Offset: 0x2F4A700 VA: 0x2F4E700
	internal IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x2F4E8A8 Offset: 0x2F4A8A8 VA: 0x2F4E8A8
	internal static void BlockingEndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x2F4D3C4 Offset: 0x2F493C4 VA: 0x2F4D3C4
	private bool HasOverriddenBeginEndRead() { }

	// RVA: 0x2F4DEC0 Offset: 0x2F49EC0 VA: 0x2F4DEC0
	private bool HasOverriddenBeginEndWrite() { }

	// RVA: 0x2F4E998 Offset: 0x2F4A998 VA: 0x2F4E998
	protected void .ctor() { }

	// RVA: 0x2F4E9A0 Offset: 0x2F4A9A0 VA: 0x2F4E9A0
	private static void .cctor() { }

	[CompilerGenerated]
	[AsyncStateMachine(typeof(Stream.<<ReadAsync>g__FinishReadAsync|44_0>d))]
	// RVA: 0x2F4D250 Offset: 0x2F49250 VA: 0x2F4D250
	internal static ValueTask<int> <ReadAsync>g__FinishReadAsync|44_0(Task<int> readTask, byte[] localBuffer, Memory<byte> localDestination) { }
}
