// Assembly: mscorlib.dll
// Namespace: System.Threading
public static class ThreadPool // TypeDefIndex: 9927
{
	// Properties
	internal static bool IsThreadPoolThread { get; }

	// Methods

	// RVA: 0x3054484 Offset: 0x3050484 VA: 0x3054484
	private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack) { }

	// RVA: 0x3054790 Offset: 0x3050790 VA: 0x3054790
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	// RVA: 0x3054740 Offset: 0x3050740 VA: 0x3054740
	public static bool QueueUserWorkItem(WaitCallback callBack, object state) { }

	// RVA: 0x30549DC Offset: 0x30509DC VA: 0x30549DC
	public static bool QueueUserWorkItem(WaitCallback callBack) { }

	// RVA: 0x3054768 Offset: 0x3050768 VA: 0x3054768
	public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state) { }

	// RVA: -1 Offset: -1
	public static bool QueueUserWorkItem<TState>(Action<TState> callBack, TState state, bool preferLocal) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F6920 Offset: 0x26F2920 VA: 0x26F6920
	|-ThreadPool.QueueUserWorkItem<object>
	|
	|-RVA: 0x26F6A54 Offset: 0x26F2A54 VA: 0x26F6A54
	|-ThreadPool.QueueUserWorkItem<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x30548C0 Offset: 0x30508C0 VA: 0x30548C0
	private static bool QueueUserWorkItemHelper(WaitCallback callBack, object state, ref StackCrawlMark stackMark, bool compressStack, bool forceGlobal = True) { }

	// RVA: 0x3054A9C Offset: 0x3050A9C VA: 0x3054A9C
	internal static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal) { }

	// RVA: 0x3054B1C Offset: 0x3050B1C VA: 0x3054B1C
	internal static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem) { }

	// RVA: 0x3054BBC Offset: 0x3050BBC VA: 0x3054BBC
	internal static bool RequestWorkerThread() { }

	// RVA: 0x3054A08 Offset: 0x3050A08 VA: 0x3054A08
	private static void EnsureVMInitialized() { }

	// RVA: 0x3054BC4 Offset: 0x3050BC4 VA: 0x3054BC4
	internal static bool NotifyWorkItemComplete() { }

	// RVA: 0x3054BC8 Offset: 0x3050BC8 VA: 0x3054BC8
	internal static void ReportThreadStatus(bool isWorking) { }

	// RVA: 0x3054BD0 Offset: 0x3050BD0 VA: 0x3054BD0
	internal static void NotifyWorkItemProgress() { }

	// RVA: 0x3054BE0 Offset: 0x3050BE0 VA: 0x3054BE0
	internal static void NotifyWorkItemProgressNative() { }

	// RVA: 0x3054BE4 Offset: 0x3050BE4 VA: 0x3054BE4
	internal static void NotifyWorkItemQueued() { }

	// RVA: 0x3054BC0 Offset: 0x3050BC0 VA: 0x3054BC0
	private static void InitializeVMTp(ref bool enableWorkerTracking) { }

	// RVA: 0x3054BE8 Offset: 0x3050BE8 VA: 0x3054BE8
	internal static bool get_IsThreadPoolThread() { }
}
