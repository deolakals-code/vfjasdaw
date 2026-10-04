// Assembly: System.dll
// Namespace: System.Net
internal static class TimerThread // TypeDefIndex: 14435
{
	// Fields
	private static LinkedList<WeakReference> s_Queues; // 0x0
	private static LinkedList<WeakReference> s_NewQueues; // 0x8
	private static int s_ThreadState; // 0x10
	private static AutoResetEvent s_ThreadReadyEvent; // 0x18
	private static ManualResetEvent s_ThreadShutdownEvent; // 0x20
	private static WaitHandle[] s_ThreadEvents; // 0x28
	private static int s_CacheScanIteration; // 0x30
	private static Hashtable s_QueuesCache; // 0x38

	// Methods

	// RVA: 0x34F702C Offset: 0x34F302C VA: 0x34F702C
	private static void .cctor() { }

	// RVA: 0x34F3D44 Offset: 0x34EFD44 VA: 0x34F3D44
	internal static TimerThread.Queue CreateQueue(int durationMilliseconds) { }

	// RVA: 0x34EAE44 Offset: 0x34E6E44 VA: 0x34EAE44
	internal static TimerThread.Queue GetOrCreateQueue(int durationMilliseconds) { }

	// RVA: 0x34F72F8 Offset: 0x34F32F8 VA: 0x34F72F8
	private static void Prod() { }

	// RVA: 0x34F7408 Offset: 0x34F3408 VA: 0x34F7408
	private static void ThreadProc() { }

	// RVA: 0x34F7BF4 Offset: 0x34F3BF4 VA: 0x34F7BF4
	private static void StopTimerThread() { }

	// RVA: 0x34F7BD0 Offset: 0x34F3BD0 VA: 0x34F7BD0
	private static bool IsTickBetween(int start, int end, int comparand) { }

	// RVA: 0x34F7C70 Offset: 0x34F3C70 VA: 0x34F7C70
	private static void OnDomainUnload(object sender, EventArgs e) { }
}
