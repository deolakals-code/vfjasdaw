// Assembly: mscorlib.dll
// Namespace: System
public interface IAsyncResult // TypeDefIndex: 9607
{
	// Properties
	public abstract bool IsCompleted { get; }
	public abstract WaitHandle AsyncWaitHandle { get; }
	public abstract object AsyncState { get; }
	public abstract bool CompletedSynchronously { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsCompleted();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract WaitHandle get_AsyncWaitHandle();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object get_AsyncState();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_CompletedSynchronously();
}
