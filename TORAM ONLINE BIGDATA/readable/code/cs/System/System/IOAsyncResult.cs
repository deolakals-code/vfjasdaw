// Assembly: System.dll
// Namespace: System
internal abstract class IOAsyncResult : IAsyncResult // TypeDefIndex: 14056
{
	// Fields
	private AsyncCallback async_callback; // 0x10
	private object async_state; // 0x18
	private ManualResetEvent wait_handle; // 0x20
	private bool completed_synchronously; // 0x28
	private bool completed; // 0x29

	// Properties
	public AsyncCallback AsyncCallback { get; }
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; set; }
	public bool IsCompleted { get; set; }

	// Methods

	// RVA: 0x3468E14 Offset: 0x3464E14 VA: 0x3468E14
	protected void .ctor() { }

	// RVA: 0x3468E1C Offset: 0x3464E1C VA: 0x3468E1C
	protected void Init(AsyncCallback async_callback, object async_state) { }

	// RVA: 0x3468E6C Offset: 0x3464E6C VA: 0x3468E6C
	protected void .ctor(AsyncCallback async_callback, object async_state) { }

	// RVA: 0x3468EB0 Offset: 0x3464EB0 VA: 0x3468EB0
	public AsyncCallback get_AsyncCallback() { }

	// RVA: 0x3468EB8 Offset: 0x3464EB8 VA: 0x3468EB8 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x3468EC0 Offset: 0x3464EC0 VA: 0x3468EC0 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x3468FE4 Offset: 0x3464FE4 VA: 0x3468FE4 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x3468FEC Offset: 0x3464FEC VA: 0x3468FEC
	protected void set_CompletedSynchronously(bool value) { }

	// RVA: 0x3468FF8 Offset: 0x3464FF8 VA: 0x3468FF8 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x3469000 Offset: 0x3465000 VA: 0x3469000
	protected void set_IsCompleted(bool value) { }

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void CompleteDisposed();
}
