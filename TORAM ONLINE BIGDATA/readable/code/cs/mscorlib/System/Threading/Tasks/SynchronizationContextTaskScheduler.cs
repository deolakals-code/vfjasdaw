// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
internal sealed class SynchronizationContextTaskScheduler : TaskScheduler // TypeDefIndex: 9999
{
	// Fields
	private SynchronizationContext m_synchronizationContext; // 0x18
	private static readonly SendOrPostCallback s_postCallback; // 0x0

	// Methods

	// RVA: 0x30642E0 Offset: 0x30602E0 VA: 0x30642E0
	internal void .ctor() { }

	// RVA: 0x306451C Offset: 0x306051C VA: 0x306451C Slot: 4
	protected internal override void QueueTask(Task task) { }

	// RVA: 0x30645A0 Offset: 0x30605A0 VA: 0x30645A0 Slot: 5
	protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x30645E8 Offset: 0x30605E8 VA: 0x30645E8
	private static void .cctor() { }
}
