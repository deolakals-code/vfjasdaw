// Assembly: System.dll
// Namespace: System.Net
internal class WebCompletionSource<T> // TypeDefIndex: 14511
{
	// Fields
	private TaskCompletionSource<WebCompletionSource.Result<T>> completion; // 0x0
	private WebCompletionSource.Result<T> currentResult; // 0x0

	// Properties
	internal WebCompletionSource.Result<T> CurrentResult { get; }
	internal Task Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(bool runAsync = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D6B09C Offset: 0x2D6709C VA: 0x2D6B09C
	|-WebCompletionSource<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x2D6B5C8 Offset: 0x2D675C8 VA: 0x2D6B5C8
	|-WebCompletionSource<object>..ctor
	|
	|-RVA: 0x2D6BAEC Offset: 0x2D67AEC VA: 0x2D6BAEC
	|-WebCompletionSource<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal WebCompletionSource.Result<T> get_CurrentResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D6B118 Offset: 0x2D67118 VA: 0x2D6B118
	|-WebCompletionSource<ValueTuple<bool, object>>.get_CurrentResult
	|
	|-RVA: 0x2D6B644 Offset: 0x2D67644 VA: 0x2D6B644
	|-WebCompletionSource<object>.get_CurrentResult
	|
	|-RVA: 0x2D6BB6C Offset: 0x2D67B6C VA: 0x2D6BB6C
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.get_CurrentResult
	*/

	// RVA: -1 Offset: -1
	internal Task get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D6B120 Offset: 0x2D67120 VA: 0x2D6B120
	|-WebCompletionSource<ValueTuple<bool, object>>.get_Task
	|
	|-RVA: 0x2D6B64C Offset: 0x2D6764C VA: 0x2D6B64C
	|-WebCompletionSource<object>.get_Task
	|
	|-RVA: 0x2D6BB74 Offset: 0x2D67B74 VA: 0x2D6BB74
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.get_Task
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCompleted(T argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D6B13C Offset: 0x2D6713C VA: 0x2D6B13C
	|-WebCompletionSource<ValueTuple<bool, object>>.TrySetCompleted
	|
	|-RVA: 0x2D6B668 Offset: 0x2D67668 VA: 0x2D6B668
	|-WebCompletionSource<object>.TrySetCompleted
	|
	|-RVA: 0x2D6BB9C Offset: 0x2D67B9C VA: 0x2D6BB9C
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.TrySetCompleted
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D6B1F0 Offset: 0x2D671F0 VA: 0x2D6B1F0
	|-WebCompletionSource<ValueTuple<bool, object>>.TrySetCompleted
	|
	|-RVA: 0x2D6B714 Offset: 0x2D67714 VA: 0x2D6B714
	|-WebCompletionSource<object>.TrySetCompleted
	|
	|-RVA: 0x2D6BCE0 Offset: 0x2D67CE0 VA: 0x2D6BCE0
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.TrySetCompleted
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCanceled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D6B290 Offset: 0x2D67290 VA: 0x2D6B290
	|-WebCompletionSource<ValueTuple<bool, object>>.TrySetCanceled
	|
	|-RVA: 0x2D6B7B4 Offset: 0x2D677B4 VA: 0x2D6B7B4
	|-WebCompletionSource<object>.TrySetCanceled
	|
	|-RVA: 0x2D6BDA4 Offset: 0x2D67DA4 VA: 0x2D6BDA4
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCanceled(OperationCanceledException error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D6B304 Offset: 0x2D67304 VA: 0x2D6B304
	|-WebCompletionSource<ValueTuple<bool, object>>.TrySetCanceled
	|
	|-RVA: 0x2D6B828 Offset: 0x2D67828 VA: 0x2D6B828
	|-WebCompletionSource<object>.TrySetCanceled
	|
	|-RVA: 0x2D6BE1C Offset: 0x2D67E1C VA: 0x2D6BE1C
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public bool TrySetException(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D6B3C0 Offset: 0x2D673C0 VA: 0x2D6B3C0
	|-WebCompletionSource<ValueTuple<bool, object>>.TrySetException
	|
	|-RVA: 0x2D6B8E4 Offset: 0x2D678E4 VA: 0x2D6B8E4
	|-WebCompletionSource<object>.TrySetException
	|
	|-RVA: 0x2D6BEF8 Offset: 0x2D67EF8 VA: 0x2D6BEF8
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.TrySetException
	*/

	// RVA: -1 Offset: -1
	public void ThrowOnError() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D6B47C Offset: 0x2D6747C VA: 0x2D6B47C
	|-WebCompletionSource<ValueTuple<bool, object>>.ThrowOnError
	|
	|-RVA: 0x2D6B9A0 Offset: 0x2D679A0 VA: 0x2D6B9A0
	|-WebCompletionSource<object>.ThrowOnError
	|
	|-RVA: 0x2D6BFD4 Offset: 0x2D67FD4 VA: 0x2D6BFD4
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.ThrowOnError
	*/

	[AsyncStateMachine(typeof(WebCompletionSource.<WaitForCompletion>d__15<T>))]
	// RVA: -1 Offset: -1
	public Task<T> WaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D6B4F4 Offset: 0x2D674F4 VA: 0x2D6B4F4
	|-WebCompletionSource<ValueTuple<bool, object>>.WaitForCompletion
	|
	|-RVA: 0x2D6BA18 Offset: 0x2D67A18 VA: 0x2D6BA18
	|-WebCompletionSource<object>.WaitForCompletion
	|
	|-RVA: 0x2D6C08C Offset: 0x2D6808C VA: 0x2D6C08C
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.WaitForCompletion
	*/
}
