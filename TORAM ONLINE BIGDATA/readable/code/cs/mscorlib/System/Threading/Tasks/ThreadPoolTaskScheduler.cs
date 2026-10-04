// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
internal sealed class ThreadPoolTaskScheduler : TaskScheduler // TypeDefIndex: 10002
{
	// Fields
	private static readonly ParameterizedThreadStart s_longRunningThreadWork; // 0x0

	// Properties
	internal override bool RequiresAtomicStartTransition { get; }

	// Methods

	// RVA: 0x30644C4 Offset: 0x30604C4 VA: 0x30644C4
	internal void .ctor() { }

	// RVA: 0x30647AC Offset: 0x30607AC VA: 0x30647AC Slot: 4
	protected internal override void QueueTask(Task task) { }

	// RVA: 0x3064974 Offset: 0x3060974 VA: 0x3064974 Slot: 5
	protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x3064A54 Offset: 0x3060A54 VA: 0x3064A54 Slot: 6
	protected internal override bool TryDequeue(Task task) { }

	// RVA: 0x3064A5C Offset: 0x3060A5C VA: 0x3064A5C Slot: 7
	internal override void NotifyWorkItemProgress() { }

	// RVA: 0x3064A6C Offset: 0x3060A6C VA: 0x3064A6C Slot: 8
	internal override bool get_RequiresAtomicStartTransition() { }

	// RVA: 0x3064A74 Offset: 0x3060A74 VA: 0x3064A74
	private static void .cctor() { }
}
