// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
internal interface ITaskCompletionAction // TypeDefIndex: 9979
{
	// Properties
	public abstract bool InvokeMayRunArbitraryCode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Invoke(Task completingTask);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_InvokeMayRunArbitraryCode();
}
