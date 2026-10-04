// Assembly: mscorlib.dll
// Namespace: System.Threading
internal sealed class ThreadPoolWorkQueueThreadLocals // TypeDefIndex: 9923
{
	// Fields
	[ThreadStatic]
	public static ThreadPoolWorkQueueThreadLocals threadLocals; // 0x80000000
	public readonly ThreadPoolWorkQueue workQueue; // 0x10
	public readonly ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue; // 0x18
	public readonly Random random; // 0x20

	// Methods

	// RVA: 0x3053E68 Offset: 0x304FE68 VA: 0x3053E68
	public void .ctor(ThreadPoolWorkQueue tpq) { }

	// RVA: 0x3053FA8 Offset: 0x304FFA8 VA: 0x3053FA8
	private void CleanUp() { }

	// RVA: 0x305407C Offset: 0x305007C VA: 0x305407C Slot: 1
	protected override void Finalize() { }
}
