// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MultiWorkerThread.ThreadManager // TypeDefIndex: 5607
{
	// Fields
	private Queue<ITask> taskList; // 0x10
	private Thread thread; // 0x18
	private IWorkerThread parent; // 0x20
	private bool disposed; // 0x28
	private List<Thread> allThreadLog; // 0x30

	// Properties
	public bool IsSleep { get; }
	public int TaskCount { get; }

	// Methods

	// RVA: 0x17A6644 Offset: 0x17A2644 VA: 0x17A6644
	public bool get_IsSleep() { }

	// RVA: 0x17A621C Offset: 0x17A221C VA: 0x17A621C
	public int get_TaskCount() { }

	// RVA: 0x17A5920 Offset: 0x17A1920 VA: 0x17A5920
	public void .ctor(IWorkerThread parent) { }

	// RVA: 0x17A6264 Offset: 0x17A2264 VA: 0x17A6264
	public void SetTask(ITask task) { }

	// RVA: 0x17A5A98 Offset: 0x17A1A98 VA: 0x17A5A98
	public void Dispose() { }

	// RVA: 0x17A665C Offset: 0x17A265C VA: 0x17A665C
	private void ThreadMethod() { }
}
