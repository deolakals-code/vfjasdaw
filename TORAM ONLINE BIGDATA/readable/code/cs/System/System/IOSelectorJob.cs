// Assembly: System.dll
// Namespace: System
internal class IOSelectorJob : IThreadPoolWorkItem // TypeDefIndex: 14057
{
	// Fields
	private IOOperation operation; // 0x10
	private IOAsyncCallback callback; // 0x18
	private IOAsyncResult state; // 0x20

	// Methods

	// RVA: 0x34690D8 Offset: 0x34650D8 VA: 0x34690D8
	public void .ctor(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state) { }

	// RVA: 0x346912C Offset: 0x346512C VA: 0x346912C Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x3469154 Offset: 0x3465154 VA: 0x3469154 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x3469158 Offset: 0x3465158 VA: 0x3469158
	public void MarkDisposed() { }
}
