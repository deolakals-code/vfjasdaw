// Assembly: mscorlib.dll
// Namespace: System.Threading
internal sealed class QueueUserWorkItemCallback : IThreadPoolWorkItem // TypeDefIndex: 9925
{
	// Fields
	private WaitCallback callback; // 0x10
	private ExecutionContext context; // 0x18
	private object state; // 0x20
	internal static ContextCallback ccb; // 0x0

	// Methods

	// RVA: 0x3054198 Offset: 0x3050198 VA: 0x3054198
	internal void .ctor(WaitCallback waitCallback, object stateObj, bool compressStack, ref StackCrawlMark stackMark) { }

	// RVA: 0x3054284 Offset: 0x3050284 VA: 0x3054284 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x3054368 Offset: 0x3050368 VA: 0x3054368 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x305436C Offset: 0x305036C VA: 0x305436C
	private static void WaitCallback_Context(object state) { }

	// RVA: 0x30543E4 Offset: 0x30503E4 VA: 0x30543E4
	private static void .cctor() { }
}
