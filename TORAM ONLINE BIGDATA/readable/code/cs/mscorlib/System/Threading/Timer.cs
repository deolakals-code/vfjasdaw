// Assembly: mscorlib.dll
// Namespace: System.Threading
[ComVisible(True)]
public sealed class Timer : MarshalByRefObject, IDisposable // TypeDefIndex: 9938
{
	// Fields
	private TimerCallback callback; // 0x18
	private object state; // 0x20
	private long due_time_ms; // 0x28
	private long period_ms; // 0x30
	private long next_run; // 0x38
	private bool disposed; // 0x40
	private bool is_dead; // 0x41
	private bool is_added; // 0x42
	private const long MaxValue = 4294967294;

	// Properties
	private static Timer.Scheduler scheduler { get; }

	// Methods

	// RVA: 0x3056FD4 Offset: 0x3052FD4 VA: 0x3056FD4
	private static Timer.Scheduler get_scheduler() { }

	// RVA: 0x305705C Offset: 0x305305C VA: 0x305705C
	public void .ctor(TimerCallback callback, object state, int dueTime, int period) { }

	// RVA: 0x305714C Offset: 0x305314C VA: 0x305714C
	public void .ctor(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x30570A8 Offset: 0x30530A8 VA: 0x30570A8
	private void Init(TimerCallback callback, object state, long dueTime, long period) { }

	// RVA: 0x30573E8 Offset: 0x30533E8 VA: 0x30573E8
	public bool Change(int dueTime, int period) { }

	// RVA: 0x3057408 Offset: 0x3053408 VA: 0x3057408
	public bool Change(TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x30574C0 Offset: 0x30534C0 VA: 0x30574C0 Slot: 6
	public void Dispose() { }

	// RVA: 0x3057220 Offset: 0x3053220 VA: 0x3057220
	private bool Change(long dueTime, long period, bool first) { }

	// RVA: 0x3057754 Offset: 0x3053754 VA: 0x3057754
	internal void KeepRootedWhileScheduled() { }

	// RVA: 0x30575C4 Offset: 0x30535C4 VA: 0x30575C4
	private static long GetTimeMonotonic() { }
}
