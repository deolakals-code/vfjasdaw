// Assembly: mscorlib.dll
// Namespace: 
private sealed class Timer.Scheduler // TypeDefIndex: 9937
{
	// Fields
	private static readonly Timer.Scheduler instance; // 0x0
	private bool needReSort; // 0x10
	private List<Timer> list; // 0x18
	private long current_next_run; // 0x20
	private ManualResetEvent changed; // 0x28

	// Properties
	public static Timer.Scheduler Instance { get; }

	// Methods

	// RVA: 0x3057860 Offset: 0x3053860 VA: 0x3057860
	private void InitScheduler() { }

	// RVA: 0x3057968 Offset: 0x3053968 VA: 0x3057968
	private void WakeupScheduler() { }

	// RVA: 0x3057984 Offset: 0x3053984 VA: 0x3057984
	private void SchedulerThread() { }

	// RVA: 0x3057E3C Offset: 0x3053E3C VA: 0x3057E3C
	public static Timer.Scheduler get_Instance() { }

	// RVA: 0x3057E94 Offset: 0x3053E94 VA: 0x3057E94
	private void .ctor() { }

	// RVA: 0x30574F8 Offset: 0x30534F8 VA: 0x30574F8
	public void Remove(Timer timer) { }

	// RVA: 0x30575C8 Offset: 0x30535C8 VA: 0x30575C8
	public void Change(Timer timer, long new_next_run) { }

	// RVA: 0x3057F6C Offset: 0x3053F6C VA: 0x3057F6C
	private void Add(Timer timer) { }

	// RVA: 0x3057F3C Offset: 0x3053F3C VA: 0x3057F3C
	private void InternalRemove(Timer timer) { }

	// RVA: 0x3058064 Offset: 0x3054064 VA: 0x3058064
	private static void TimerCB(object o) { }

	// RVA: 0x30580DC Offset: 0x30540DC VA: 0x30580DC
	private void FireTimer(Timer timer) { }

	// RVA: 0x3057AB4 Offset: 0x3053AB4 VA: 0x3057AB4
	private int RunSchedulerLoop() { }

	// RVA: 0x30581A0 Offset: 0x30541A0 VA: 0x30581A0
	private static void .cctor() { }
}
