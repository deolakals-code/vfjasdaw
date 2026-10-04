// Assembly: mscorlib.dll
// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct TaskAwaiter<TResult> : ICriticalNotifyCompletion // TypeDefIndex: 10519
{
	// Fields
	private readonly Task<TResult> m_task; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<TResult> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5560 Offset: 0x2CA1560 VA: 0x2CA5560
	|-TaskAwaiter<Nullable<int>>..ctor
	|
	|-RVA: 0x2CA55E0 Offset: 0x2CA15E0 VA: 0x2CA55E0
	|-TaskAwaiter<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x2CA5660 Offset: 0x2CA1660 VA: 0x2CA5660
	|-TaskAwaiter<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x2CA56F0 Offset: 0x2CA16F0 VA: 0x2CA56F0
	|-TaskAwaiter<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x2CA5778 Offset: 0x2CA1778 VA: 0x2CA5778
	|-TaskAwaiter<bool>..ctor
	|
	|-RVA: 0x2CA57F8 Offset: 0x2CA17F8 VA: 0x2CA57F8
	|-TaskAwaiter<int>..ctor
	|
	|-RVA: 0x2CA5878 Offset: 0x2CA1878 VA: 0x2CA5878
	|-TaskAwaiter<Int32Enum>..ctor
	|
	|-RVA: 0x2CA58F8 Offset: 0x2CA18F8 VA: 0x2CA58F8
	|-TaskAwaiter<object>..ctor
	|
	|-RVA: 0x2CA5978 Offset: 0x2CA1978 VA: 0x2CA5978
	|-TaskAwaiter<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0x2CA59F8 Offset: 0x2CA19F8 VA: 0x2CA59F8
	|-TaskAwaiter<VoidTaskResult>..ctor
	|
	|-RVA: 0x2CA5A78 Offset: 0x2CA1A78 VA: 0x2CA5A78
	|-TaskAwaiter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5568 Offset: 0x2CA1568 VA: 0x2CA5568
	|-TaskAwaiter<Nullable<int>>.get_IsCompleted
	|
	|-RVA: 0x2CA55E8 Offset: 0x2CA15E8 VA: 0x2CA55E8
	|-TaskAwaiter<ValueTuple<bool, object>>.get_IsCompleted
	|
	|-RVA: 0x2CA5668 Offset: 0x2CA1668 VA: 0x2CA5668
	|-TaskAwaiter<ValueTuple<object, object, int>>.get_IsCompleted
	|
	|-RVA: 0x2CA56F8 Offset: 0x2CA16F8 VA: 0x2CA56F8
	|-TaskAwaiter<ValueTuple<object, bool, bool, object, object>>.get_IsCompleted
	|
	|-RVA: 0x2CA5780 Offset: 0x2CA1780 VA: 0x2CA5780
	|-TaskAwaiter<bool>.get_IsCompleted
	|
	|-RVA: 0x2CA5800 Offset: 0x2CA1800 VA: 0x2CA5800
	|-TaskAwaiter<int>.get_IsCompleted
	|
	|-RVA: 0x2CA5880 Offset: 0x2CA1880 VA: 0x2CA5880
	|-TaskAwaiter<Int32Enum>.get_IsCompleted
	|
	|-RVA: 0x2CA5900 Offset: 0x2CA1900 VA: 0x2CA5900
	|-TaskAwaiter<object>.get_IsCompleted
	|
	|-RVA: 0x2CA5980 Offset: 0x2CA1980 VA: 0x2CA5980
	|-TaskAwaiter<SerializableProjectConfiguration>.get_IsCompleted
	|
	|-RVA: 0x2CA5A00 Offset: 0x2CA1A00 VA: 0x2CA5A00
	|-TaskAwaiter<VoidTaskResult>.get_IsCompleted
	|
	|-RVA: 0x2CA5A80 Offset: 0x2CA1A80 VA: 0x2CA5A80
	|-TaskAwaiter<__Il2CppFullySharedGenericType>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5584 Offset: 0x2CA1584 VA: 0x2CA5584
	|-TaskAwaiter<Nullable<int>>.UnsafeOnCompleted
	|
	|-RVA: 0x2CA5604 Offset: 0x2CA1604 VA: 0x2CA5604
	|-TaskAwaiter<ValueTuple<bool, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x2CA5684 Offset: 0x2CA1684 VA: 0x2CA5684
	|-TaskAwaiter<ValueTuple<object, object, int>>.UnsafeOnCompleted
	|
	|-RVA: 0x2CA5714 Offset: 0x2CA1714 VA: 0x2CA5714
	|-TaskAwaiter<ValueTuple<object, bool, bool, object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x2CA579C Offset: 0x2CA179C VA: 0x2CA579C
	|-TaskAwaiter<bool>.UnsafeOnCompleted
	|
	|-RVA: 0x2CA581C Offset: 0x2CA181C VA: 0x2CA581C
	|-TaskAwaiter<int>.UnsafeOnCompleted
	|
	|-RVA: 0x2CA589C Offset: 0x2CA189C VA: 0x2CA589C
	|-TaskAwaiter<Int32Enum>.UnsafeOnCompleted
	|
	|-RVA: 0x2CA591C Offset: 0x2CA191C VA: 0x2CA591C
	|-TaskAwaiter<object>.UnsafeOnCompleted
	|
	|-RVA: 0x2CA599C Offset: 0x2CA199C VA: 0x2CA599C
	|-TaskAwaiter<SerializableProjectConfiguration>.UnsafeOnCompleted
	|
	|-RVA: 0x2CA5A1C Offset: 0x2CA1A1C VA: 0x2CA5A1C
	|-TaskAwaiter<VoidTaskResult>.UnsafeOnCompleted
	|
	|-RVA: 0x2CA5A9C Offset: 0x2CA1A9C VA: 0x2CA5A9C
	|-TaskAwaiter<__Il2CppFullySharedGenericType>.UnsafeOnCompleted
	*/

	[StackTraceHidden]
	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5598 Offset: 0x2CA1598 VA: 0x2CA5598
	|-TaskAwaiter<Nullable<int>>.GetResult
	|
	|-RVA: 0x2CA5618 Offset: 0x2CA1618 VA: 0x2CA5618
	|-TaskAwaiter<ValueTuple<bool, object>>.GetResult
	|
	|-RVA: 0x2CA5698 Offset: 0x2CA1698 VA: 0x2CA5698
	|-TaskAwaiter<ValueTuple<object, object, int>>.GetResult
	|
	|-RVA: 0x2CA5728 Offset: 0x2CA1728 VA: 0x2CA5728
	|-TaskAwaiter<ValueTuple<object, bool, bool, object, object>>.GetResult
	|
	|-RVA: 0x2CA57B0 Offset: 0x2CA17B0 VA: 0x2CA57B0
	|-TaskAwaiter<bool>.GetResult
	|
	|-RVA: 0x2CA5830 Offset: 0x2CA1830 VA: 0x2CA5830
	|-TaskAwaiter<int>.GetResult
	|
	|-RVA: 0x2CA58B0 Offset: 0x2CA18B0 VA: 0x2CA58B0
	|-TaskAwaiter<Int32Enum>.GetResult
	|
	|-RVA: 0x2CA5930 Offset: 0x2CA1930 VA: 0x2CA5930
	|-TaskAwaiter<object>.GetResult
	|
	|-RVA: 0x2CA59B0 Offset: 0x2CA19B0 VA: 0x2CA59B0
	|-TaskAwaiter<SerializableProjectConfiguration>.GetResult
	|
	|-RVA: 0x2CA5A30 Offset: 0x2CA1A30 VA: 0x2CA5A30
	|-TaskAwaiter<VoidTaskResult>.GetResult
	|
	|-RVA: 0x2CA5AB0 Offset: 0x2CA1AB0 VA: 0x2CA5AB0
	|-TaskAwaiter<__Il2CppFullySharedGenericType>.GetResult
	*/
}
