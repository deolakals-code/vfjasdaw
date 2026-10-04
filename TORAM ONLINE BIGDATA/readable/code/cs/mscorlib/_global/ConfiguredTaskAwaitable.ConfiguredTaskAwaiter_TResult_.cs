// Assembly: mscorlib.dll
// Namespace: 
[IsReadOnly]
public struct ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> : ICriticalNotifyCompletion // TypeDefIndex: 10522
{
	// Fields
	private readonly Task<TResult> m_task; // 0x0
	private readonly bool m_continueOnCapturedContext; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<TResult> task, bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC5014 Offset: 0x2DC1014 VA: 0x2DC5014
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>..ctor
	|
	|-RVA: 0x2DC50B8 Offset: 0x2DC10B8 VA: 0x2DC50B8
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x2DC515C Offset: 0x2DC115C VA: 0x2DC515C
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x2DC5210 Offset: 0x2DC1210 VA: 0x2DC5210
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x2DC52BC Offset: 0x2DC12BC VA: 0x2DC52BC
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>..ctor
	|
	|-RVA: 0x2DC5360 Offset: 0x2DC1360 VA: 0x2DC5360
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>..ctor
	|
	|-RVA: 0x2DC5404 Offset: 0x2DC1404 VA: 0x2DC5404
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Int32Enum>..ctor
	|
	|-RVA: 0x2DC54A8 Offset: 0x2DC14A8 VA: 0x2DC54A8
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>..ctor
	|
	|-RVA: 0x2DC554C Offset: 0x2DC154C VA: 0x2DC554C
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0x2DC55F0 Offset: 0x2DC15F0 VA: 0x2DC55F0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>..ctor
	|
	|-RVA: 0x2DC5694 Offset: 0x2DC1694 VA: 0x2DC5694
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC503C Offset: 0x2DC103C VA: 0x2DC503C
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.get_IsCompleted
	|
	|-RVA: 0x2DC50E0 Offset: 0x2DC10E0 VA: 0x2DC50E0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<bool, object>>.get_IsCompleted
	|
	|-RVA: 0x2DC5184 Offset: 0x2DC1184 VA: 0x2DC5184
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>.get_IsCompleted
	|
	|-RVA: 0x2DC5238 Offset: 0x2DC1238 VA: 0x2DC5238
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>.get_IsCompleted
	|
	|-RVA: 0x2DC52E4 Offset: 0x2DC12E4 VA: 0x2DC52E4
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.get_IsCompleted
	|
	|-RVA: 0x2DC5388 Offset: 0x2DC1388 VA: 0x2DC5388
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.get_IsCompleted
	|
	|-RVA: 0x2DC542C Offset: 0x2DC142C VA: 0x2DC542C
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Int32Enum>.get_IsCompleted
	|
	|-RVA: 0x2DC54D0 Offset: 0x2DC14D0 VA: 0x2DC54D0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.get_IsCompleted
	|
	|-RVA: 0x2DC5574 Offset: 0x2DC1574 VA: 0x2DC5574
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SerializableProjectConfiguration>.get_IsCompleted
	|
	|-RVA: 0x2DC5618 Offset: 0x2DC1618 VA: 0x2DC5618
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.get_IsCompleted
	|
	|-RVA: 0x2DC56BC Offset: 0x2DC16BC VA: 0x2DC56BC
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<__Il2CppFullySharedGenericType>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC5058 Offset: 0x2DC1058 VA: 0x2DC5058
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DC50FC Offset: 0x2DC10FC VA: 0x2DC50FC
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<bool, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DC51A0 Offset: 0x2DC11A0 VA: 0x2DC51A0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DC5254 Offset: 0x2DC1254 VA: 0x2DC5254
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DC5300 Offset: 0x2DC1300 VA: 0x2DC5300
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.UnsafeOnCompleted
	|
	|-RVA: 0x2DC53A4 Offset: 0x2DC13A4 VA: 0x2DC53A4
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.UnsafeOnCompleted
	|
	|-RVA: 0x2DC5448 Offset: 0x2DC1448 VA: 0x2DC5448
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Int32Enum>.UnsafeOnCompleted
	|
	|-RVA: 0x2DC54EC Offset: 0x2DC14EC VA: 0x2DC54EC
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.UnsafeOnCompleted
	|
	|-RVA: 0x2DC5590 Offset: 0x2DC1590 VA: 0x2DC5590
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SerializableProjectConfiguration>.UnsafeOnCompleted
	|
	|-RVA: 0x2DC5634 Offset: 0x2DC1634 VA: 0x2DC5634
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.UnsafeOnCompleted
	|
	|-RVA: 0x2DC56D8 Offset: 0x2DC16D8 VA: 0x2DC56D8
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<__Il2CppFullySharedGenericType>.UnsafeOnCompleted
	*/

	[StackTraceHidden]
	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC5070 Offset: 0x2DC1070 VA: 0x2DC5070
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.GetResult
	|
	|-RVA: 0x2DC5114 Offset: 0x2DC1114 VA: 0x2DC5114
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<bool, object>>.GetResult
	|
	|-RVA: 0x2DC51B8 Offset: 0x2DC11B8 VA: 0x2DC51B8
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>.GetResult
	|
	|-RVA: 0x2DC526C Offset: 0x2DC126C VA: 0x2DC526C
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>.GetResult
	|
	|-RVA: 0x2DC5318 Offset: 0x2DC1318 VA: 0x2DC5318
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.GetResult
	|
	|-RVA: 0x2DC53BC Offset: 0x2DC13BC VA: 0x2DC53BC
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.GetResult
	|
	|-RVA: 0x2DC5460 Offset: 0x2DC1460 VA: 0x2DC5460
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Int32Enum>.GetResult
	|
	|-RVA: 0x2DC5504 Offset: 0x2DC1504 VA: 0x2DC5504
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.GetResult
	|
	|-RVA: 0x2DC55A8 Offset: 0x2DC15A8 VA: 0x2DC55A8
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SerializableProjectConfiguration>.GetResult
	|
	|-RVA: 0x2DC564C Offset: 0x2DC164C VA: 0x2DC564C
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.GetResult
	|
	|-RVA: 0x2DC56F0 Offset: 0x2DC16F0 VA: 0x2DC56F0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<__Il2CppFullySharedGenericType>.GetResult
	*/
}
