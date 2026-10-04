// Assembly: mscorlib.dll
// Namespace: 
private sealed class SemaphoreSlim.TaskNode : Task<bool>, IThreadPoolWorkItem // TypeDefIndex: 9891
{
	// Fields
	internal SemaphoreSlim.TaskNode Prev; // 0x58
	internal SemaphoreSlim.TaskNode Next; // 0x60

	// Methods

	// RVA: 0x304C7DC Offset: 0x30487DC VA: 0x304C7DC
	internal void .ctor() { }

	// RVA: 0x304CFAC Offset: 0x3048FAC VA: 0x304CFAC Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x304CFF8 Offset: 0x3048FF8 VA: 0x304CFF8 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }
}
