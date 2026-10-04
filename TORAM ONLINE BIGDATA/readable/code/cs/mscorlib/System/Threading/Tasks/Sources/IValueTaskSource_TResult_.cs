// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks.Sources
public interface IValueTaskSource<TResult> // TypeDefIndex: 10011
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ValueTaskSourceStatus GetStatus(short token);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueTaskSource<__Il2CppFullySharedGenericType>.GetStatus
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueTaskSource<__Il2CppFullySharedGenericType>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract TResult GetResult(short token);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueTaskSource<__Il2CppFullySharedGenericType>.GetResult
	*/
}
