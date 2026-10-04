// Assembly: System.dll
// Namespace: System.Net
internal class LazyAsyncResult : IAsyncResult // TypeDefIndex: 14425
{
	// Fields
	[ThreadStatic]
	private static LazyAsyncResult.ThreadContext t_ThreadContext; // 0x80000000
	private object m_AsyncObject; // 0x10
	private object m_AsyncState; // 0x18
	private AsyncCallback m_AsyncCallback; // 0x20
	private object m_Result; // 0x28
	private int m_IntCompleted; // 0x30
	private bool m_EndCalled; // 0x34
	private bool m_UserEvent; // 0x35
	private object m_Event; // 0x38

	// Properties
	private static LazyAsyncResult.ThreadContext CurrentThreadContext { get; }
	internal object AsyncObject { get; }
	public object AsyncState { get; }
	protected AsyncCallback AsyncCallback { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	public bool IsCompleted { get; }
	internal bool InternalPeekCompleted { get; }
	internal bool EndCalled { get; set; }

	// Methods

	// RVA: 0x34F6554 Offset: 0x34F2554 VA: 0x34F6554
	private static LazyAsyncResult.ThreadContext get_CurrentThreadContext() { }

	// RVA: 0x34E671C Offset: 0x34E271C VA: 0x34E671C
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x34F65F0 Offset: 0x34F25F0 VA: 0x34F65F0
	internal object get_AsyncObject() { }

	// RVA: 0x34F65F8 Offset: 0x34F25F8 VA: 0x34F65F8 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x34F6600 Offset: 0x34F2600 VA: 0x34F6600
	protected AsyncCallback get_AsyncCallback() { }

	// RVA: 0x34F6608 Offset: 0x34F2608 VA: 0x34F6608 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x34F66A4 Offset: 0x34F26A4 VA: 0x34F66A4
	private bool LazilyCreateEvent(out ManualResetEvent waitHandle) { }

	// RVA: 0x34F6874 Offset: 0x34F2874 VA: 0x34F6874 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x34E6558 Offset: 0x34E2558 VA: 0x34E6558 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x34E9E60 Offset: 0x34E5E60 VA: 0x34E9E60
	internal bool get_InternalPeekCompleted() { }

	// RVA: 0x34F68A4 Offset: 0x34F28A4 VA: 0x34F68A4
	internal bool get_EndCalled() { }

	// RVA: 0x34F68AC Offset: 0x34F28AC VA: 0x34F68AC
	internal void set_EndCalled(bool value) { }

	// RVA: 0x34F68B8 Offset: 0x34F28B8 VA: 0x34F68B8
	protected void ProtectedInvokeCallback(object result, IntPtr userToken) { }

	// RVA: 0x34E6550 Offset: 0x34E2550 VA: 0x34E6550
	internal void InvokeCallback(object result) { }

	// RVA: 0x34E9E70 Offset: 0x34E5E70 VA: 0x34E9E70
	internal void InvokeCallback() { }

	// RVA: 0x34F6AA8 Offset: 0x34F2AA8 VA: 0x34F6AA8 Slot: 8
	protected virtual void Complete(IntPtr userToken) { }

	// RVA: 0x34F6C30 Offset: 0x34F2C30 VA: 0x34F6C30
	private void WorkerThreadComplete(object state) { }

	// RVA: 0x34F6CDC Offset: 0x34F2CDC VA: 0x34F6CDC Slot: 9
	protected virtual void Cleanup() { }

	// RVA: 0x34E6978 Offset: 0x34E2978 VA: 0x34E6978
	internal object InternalWaitForCompletion() { }

	// RVA: 0x34F6CE0 Offset: 0x34F2CE0 VA: 0x34F6CE0
	private object WaitForCompletion(bool snap) { }
}
