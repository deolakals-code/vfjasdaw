// Assembly: mscorlib.dll
// Namespace: 
internal sealed class TaskFactory.CompleteOnInvokePromise : Task<Task>, ITaskCompletionAction // TypeDefIndex: 9994
{
	// Fields
	private IList<Task> _tasks; // 0x58

	// Properties
	public bool InvokeMayRunArbitraryCode { get; }

	// Methods

	// RVA: 0x3063EA8 Offset: 0x305FEA8 VA: 0x3063EA8
	public void .ctor(IList<Task> tasks) { }

	// RVA: 0x3063FC8 Offset: 0x305FFC8 VA: 0x3063FC8 Slot: 14
	public void Invoke(Task completingTask) { }

	// RVA: 0x3064214 Offset: 0x3060214 VA: 0x3064214 Slot: 15
	public bool get_InvokeMayRunArbitraryCode() { }
}
