// Assembly: mscorlib.dll
// Namespace: System.IO
internal class FileStreamAsyncResult : IAsyncResult // TypeDefIndex: 10739
{
	// Fields
	private object state; // 0x10
	private bool completed; // 0x18
	private ManualResetEvent wh; // 0x20
	private AsyncCallback cb; // 0x28
	private bool completedSynch; // 0x30
	public int Count; // 0x34
	public int OriginalCount; // 0x38
	public int BytesRead; // 0x3C
	private AsyncCallback realcb; // 0x40

	// Properties
	public object AsyncState { get; }
	public bool CompletedSynchronously { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x2F57D6C Offset: 0x2F53D6C VA: 0x2F57D6C
	public void .ctor(AsyncCallback cb, object state) { }

	// RVA: 0x2F58D28 Offset: 0x2F54D28 VA: 0x2F58D28
	private static void CBWrapper(IAsyncResult ares) { }

	// RVA: 0x2F58DBC Offset: 0x2F54DBC VA: 0x2F58DBC Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x2F58DC4 Offset: 0x2F54DC4 VA: 0x2F58DC4 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x2F58DCC Offset: 0x2F54DCC VA: 0x2F58DCC Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x2F58DD4 Offset: 0x2F54DD4 VA: 0x2F58DD4 Slot: 4
	public bool get_IsCompleted() { }
}
