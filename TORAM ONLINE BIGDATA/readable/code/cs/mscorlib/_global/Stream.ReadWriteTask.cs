// Assembly: mscorlib.dll
// Namespace: 
private sealed class Stream.ReadWriteTask : Task<int>, ITaskCompletionAction // TypeDefIndex: 10723
{
	// Fields
	internal readonly bool _isRead; // 0x54
	internal readonly bool _apm; // 0x55
	internal Stream _stream; // 0x58
	internal byte[] _buffer; // 0x60
	internal readonly int _offset; // 0x68
	internal readonly int _count; // 0x6C
	private AsyncCallback _callback; // 0x70
	private ExecutionContext _context; // 0x78
	private static ContextCallback s_invokeAsyncCallback; // 0x0

	// Properties
	private bool System.Threading.Tasks.ITaskCompletionAction.InvokeMayRunArbitraryCode { get; }

	// Methods

	// RVA: 0x2F4EA70 Offset: 0x2F4AA70 VA: 0x2F4EA70
	internal void ClearBeginState() { }

	// RVA: 0x2F4C6C4 Offset: 0x2F486C4 VA: 0x2F4C6C4
	public void .ctor(bool isRead, bool apm, Func<object, int> function, object state, Stream stream, byte[] buffer, int offset, int count, AsyncCallback callback) { }

	// RVA: 0x2F4EA98 Offset: 0x2F4AA98 VA: 0x2F4EA98
	private static void InvokeAsyncCallback(object completedTask) { }

	// RVA: 0x2F4EB20 Offset: 0x2F4AB20 VA: 0x2F4EB20 Slot: 14
	private void System.Threading.Tasks.ITaskCompletionAction.Invoke(Task completingTask) { }

	// RVA: 0x2F4EC64 Offset: 0x2F4AC64 VA: 0x2F4EC64 Slot: 15
	private bool System.Threading.Tasks.ITaskCompletionAction.get_InvokeMayRunArbitraryCode() { }
}
