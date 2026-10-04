// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IWorkerThread // TypeDefIndex: 5597
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract CustomYieldInstruction AddTask(ITask task);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void AddMainThreadAction(Action action);
}
