// Assembly: mscorlib.dll
// Namespace: System.Threading
internal sealed class ThreadPoolWorkQueue // TypeDefIndex: 9922
{
	// Fields
	internal ThreadPoolWorkQueue.QueueSegment queueHead; // 0x10
	internal ThreadPoolWorkQueue.QueueSegment queueTail; // 0x18
	internal static ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue> allThreadQueues; // 0x0
	private int numOutstandingThreadRequests; // 0x20

	// Methods

	// RVA: 0x3051F7C Offset: 0x304DF7C VA: 0x3051F7C
	public void .ctor() { }

	// RVA: 0x3052060 Offset: 0x304E060 VA: 0x3052060
	public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue() { }

	// RVA: 0x30520F0 Offset: 0x304E0F0 VA: 0x30520F0
	internal void EnsureThreadRequested() { }

	// RVA: 0x3052190 Offset: 0x304E190 VA: 0x3052190
	internal void MarkThreadRequestSatisfied() { }

	// RVA: 0x30521DC Offset: 0x304E1DC VA: 0x30521DC
	public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal) { }

	// RVA: 0x30528B0 Offset: 0x304E8B0 VA: 0x30528B0
	internal bool LocalFindAndPop(IThreadPoolWorkItem callback) { }

	// RVA: 0x3052C4C Offset: 0x304EC4C VA: 0x3052C4C
	public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal) { }

	// RVA: 0x30532E4 Offset: 0x304F2E4 VA: 0x30532E4
	internal static bool Dispatch() { }

	// RVA: 0x3053750 Offset: 0x304F750 VA: 0x3053750
	private static void .cctor() { }
}
