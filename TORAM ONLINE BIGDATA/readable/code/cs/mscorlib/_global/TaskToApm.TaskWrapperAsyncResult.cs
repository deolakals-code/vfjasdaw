// Assembly: mscorlib.dll
// Namespace: 
private sealed class TaskToApm.TaskWrapperAsyncResult : IAsyncResult // TypeDefIndex: 9947
{
	// Fields
	internal readonly Task Task; // 0x10
	private readonly object _state; // 0x18
	private readonly bool _completedSynchronously; // 0x20

	// Properties
	private object System.IAsyncResult.AsyncState { get; }
	private bool System.IAsyncResult.CompletedSynchronously { get; }
	private bool System.IAsyncResult.IsCompleted { get; }
	private WaitHandle System.IAsyncResult.AsyncWaitHandle { get; }

	// Methods

	// RVA: 0x305875C Offset: 0x305475C VA: 0x305875C
	internal void .ctor(Task task, object state, bool completedSynchronously) { }

	// RVA: 0x3058A20 Offset: 0x3054A20 VA: 0x3058A20 Slot: 6
	private object System.IAsyncResult.get_AsyncState() { }

	// RVA: 0x3058A28 Offset: 0x3054A28 VA: 0x3058A28 Slot: 7
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x3058A30 Offset: 0x3054A30 VA: 0x3058A30 Slot: 4
	private bool System.IAsyncResult.get_IsCompleted() { }

	// RVA: 0x3058A48 Offset: 0x3054A48 VA: 0x3058A48 Slot: 5
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }
}
