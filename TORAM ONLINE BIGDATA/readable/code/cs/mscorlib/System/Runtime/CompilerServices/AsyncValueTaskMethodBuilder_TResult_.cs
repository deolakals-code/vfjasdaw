// Assembly: mscorlib.dll
// Namespace: System.Runtime.CompilerServices
public struct AsyncValueTaskMethodBuilder<TResult> // TypeDefIndex: 10488
{
	// Fields
	private AsyncTaskMethodBuilder<TResult> _methodBuilder; // 0x0
	private TResult _result; // 0x0
	private bool _haveResult; // 0x0
	private bool _useBuilder; // 0x0

	// Properties
	public ValueTask<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static AsyncValueTaskMethodBuilder<TResult> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B50C5C Offset: 0x2B4CC5C VA: 0x2B50C5C
	|-AsyncValueTaskMethodBuilder<int>.Create
	|
	|-RVA: 0x2B50EE8 Offset: 0x2B4CEE8 VA: 0x2B50EE8
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.Create
	*/

	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26790E0 Offset: 0x26750E0 VA: 0x26790E0
	|-AsyncValueTaskMethodBuilder<int>.Start<Stream.<<ReadAsync>g__FinishReadAsync|44_0>d>
	|
	|-RVA: 0x2679228 Offset: 0x2675228 VA: 0x2679228
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.Start<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B50C68 Offset: 0x2B4CC68 VA: 0x2B50C68
	|-AsyncValueTaskMethodBuilder<int>.SetStateMachine
	|
	|-RVA: 0x2B50FC0 Offset: 0x2B4CFC0 VA: 0x2B50FC0
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetStateMachine
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B50CDC Offset: 0x2B4CCDC VA: 0x2B50CDC
	|-AsyncValueTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0x2B510B0 Offset: 0x2B4D0B0 VA: 0x2B510B0
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetResult
	*/

	// RVA: -1 Offset: -1
	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B50D6C Offset: 0x2B4CD6C VA: 0x2B50D6C
	|-AsyncValueTaskMethodBuilder<int>.SetException
	|
	|-RVA: 0x2B5132C Offset: 0x2B4D32C VA: 0x2B5132C
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetException
	*/

	// RVA: -1 Offset: -1
	public ValueTask<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B50DE4 Offset: 0x2B4CDE4 VA: 0x2B50DE4
	|-AsyncValueTaskMethodBuilder<int>.get_Task
	|
	|-RVA: 0x2B5141C Offset: 0x2B4D41C VA: 0x2B5141C
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.get_Task
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2679058 Offset: 0x2675058 VA: 0x2679058
	|-AsyncValueTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, Stream.<<ReadAsync>g__FinishReadAsync|44_0>d>
	|
	|-RVA: 0x2679148 Offset: 0x2675148 VA: 0x2679148
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.AwaitUnsafeOnCompleted<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}
