// Assembly: mscorlib.dll
// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct ValueTaskAwaiter<TResult> : ICriticalNotifyCompletion // TypeDefIndex: 10516
{
	// Fields
	private readonly ValueTask<TResult> _value; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ValueTask<TResult> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D04A38 Offset: 0x2D00A38 VA: 0x2D04A38
	|-ValueTaskAwaiter<int>..ctor
	|
	|-RVA: 0x2D04CB0 Offset: 0x2D00CB0 VA: 0x2D04CB0
	|-ValueTaskAwaiter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D04A44 Offset: 0x2D00A44 VA: 0x2D04A44
	|-ValueTaskAwaiter<int>.get_IsCompleted
	|
	|-RVA: 0x2D04D8C Offset: 0x2D00D8C VA: 0x2D04D8C
	|-ValueTaskAwaiter<__Il2CppFullySharedGenericType>.get_IsCompleted
	*/

	[StackTraceHidden]
	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D04A78 Offset: 0x2D00A78 VA: 0x2D04A78
	|-ValueTaskAwaiter<int>.GetResult
	|
	|-RVA: 0x2D04E34 Offset: 0x2D00E34 VA: 0x2D04E34
	|-ValueTaskAwaiter<__Il2CppFullySharedGenericType>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D04AAC Offset: 0x2D00AAC VA: 0x2D04AAC
	|-ValueTaskAwaiter<int>.UnsafeOnCompleted
	|
	|-RVA: 0x2D04F8C Offset: 0x2D00F8C VA: 0x2D04F8C
	|-ValueTaskAwaiter<__Il2CppFullySharedGenericType>.UnsafeOnCompleted
	*/
}
