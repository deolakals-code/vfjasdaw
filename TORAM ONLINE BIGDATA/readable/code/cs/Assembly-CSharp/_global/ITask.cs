// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface ITask : IDisposable // TypeDefIndex: 5596
{
	// Properties
	public abstract CustomYieldInstruction YieldInstruction { get; }
	public abstract Action ThreadAction { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract CustomYieldInstruction get_YieldInstruction();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Action get_ThreadAction();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetWorkerThread(IWorkerThread thread);
}
