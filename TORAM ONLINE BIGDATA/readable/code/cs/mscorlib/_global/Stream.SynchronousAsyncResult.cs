// Assembly: mscorlib.dll
// Namespace: 
private sealed class Stream.SynchronousAsyncResult : IAsyncResult // TypeDefIndex: 10726
{
	// Fields
	private readonly object _stateObject; // 0x10
	private readonly bool _isWrite; // 0x18
	private ManualResetEvent _waitHandle; // 0x20
	private ExceptionDispatchInfo _exceptionInfo; // 0x28
	private bool _endXxxCalled; // 0x30
	private int _bytesRead; // 0x34

	// Properties
	public bool IsCompleted { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public object AsyncState { get; }
	public bool CompletedSynchronously { get; }

	// Methods

	// RVA: 0x2F4E578 Offset: 0x2F4A578 VA: 0x2F4E578
	internal void .ctor(int bytesRead, object asyncStateObject) { }

	// RVA: 0x2F4E86C Offset: 0x2F4A86C VA: 0x2F4E86C
	internal void .ctor(object asyncStateObject) { }

	// RVA: 0x2F4E5B0 Offset: 0x2F4A5B0 VA: 0x2F4E5B0
	internal void .ctor(Exception ex, object asyncStateObject, bool isWrite) { }

	// RVA: 0x2F4F228 Offset: 0x2F4B228 VA: 0x2F4F228 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x2F4F230 Offset: 0x2F4B230 VA: 0x2F4F230 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x2F4F328 Offset: 0x2F4B328 VA: 0x2F4F328 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x2F4F330 Offset: 0x2F4B330 VA: 0x2F4F330 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x2F4F338 Offset: 0x2F4B338 VA: 0x2F4F338
	internal void ThrowIfError() { }

	// RVA: 0x2F4E618 Offset: 0x2F4A618 VA: 0x2F4E618
	internal static int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x2F4E8AC Offset: 0x2F4A8AC VA: 0x2F4E8AC
	internal static void EndWrite(IAsyncResult asyncResult) { }
}
