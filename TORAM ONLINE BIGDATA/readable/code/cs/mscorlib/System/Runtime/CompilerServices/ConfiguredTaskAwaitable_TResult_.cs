// Assembly: mscorlib.dll
// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct ConfiguredTaskAwaitable<TResult> // TypeDefIndex: 10523
{
	// Fields
	private readonly ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> m_configuredTaskAwaiter; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<TResult> task, bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC4AEC Offset: 0x2DC0AEC VA: 0x2DC4AEC
	|-ConfiguredTaskAwaitable<Nullable<int>>..ctor
	|
	|-RVA: 0x2DC4B64 Offset: 0x2DC0B64 VA: 0x2DC4B64
	|-ConfiguredTaskAwaitable<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x2DC4BDC Offset: 0x2DC0BDC VA: 0x2DC4BDC
	|-ConfiguredTaskAwaitable<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x2DC4C54 Offset: 0x2DC0C54 VA: 0x2DC4C54
	|-ConfiguredTaskAwaitable<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x2DC4CCC Offset: 0x2DC0CCC VA: 0x2DC4CCC
	|-ConfiguredTaskAwaitable<bool>..ctor
	|
	|-RVA: 0x2DC4D44 Offset: 0x2DC0D44 VA: 0x2DC4D44
	|-ConfiguredTaskAwaitable<int>..ctor
	|
	|-RVA: 0x2DC4DBC Offset: 0x2DC0DBC VA: 0x2DC4DBC
	|-ConfiguredTaskAwaitable<Int32Enum>..ctor
	|
	|-RVA: 0x2DC4E34 Offset: 0x2DC0E34 VA: 0x2DC4E34
	|-ConfiguredTaskAwaitable<object>..ctor
	|
	|-RVA: 0x2DC4EAC Offset: 0x2DC0EAC VA: 0x2DC4EAC
	|-ConfiguredTaskAwaitable<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0x2DC4F24 Offset: 0x2DC0F24 VA: 0x2DC4F24
	|-ConfiguredTaskAwaitable<VoidTaskResult>..ctor
	|
	|-RVA: 0x2DC4F9C Offset: 0x2DC0F9C VA: 0x2DC4F9C
	|-ConfiguredTaskAwaitable<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC4B58 Offset: 0x2DC0B58 VA: 0x2DC4B58
	|-ConfiguredTaskAwaitable<Nullable<int>>.GetAwaiter
	|
	|-RVA: 0x2DC4BD0 Offset: 0x2DC0BD0 VA: 0x2DC4BD0
	|-ConfiguredTaskAwaitable<ValueTuple<bool, object>>.GetAwaiter
	|
	|-RVA: 0x2DC4C48 Offset: 0x2DC0C48 VA: 0x2DC4C48
	|-ConfiguredTaskAwaitable<ValueTuple<object, object, int>>.GetAwaiter
	|
	|-RVA: 0x2DC4CC0 Offset: 0x2DC0CC0 VA: 0x2DC4CC0
	|-ConfiguredTaskAwaitable<ValueTuple<object, bool, bool, object, object>>.GetAwaiter
	|
	|-RVA: 0x2DC4D38 Offset: 0x2DC0D38 VA: 0x2DC4D38
	|-ConfiguredTaskAwaitable<bool>.GetAwaiter
	|
	|-RVA: 0x2DC4DB0 Offset: 0x2DC0DB0 VA: 0x2DC4DB0
	|-ConfiguredTaskAwaitable<int>.GetAwaiter
	|
	|-RVA: 0x2DC4E28 Offset: 0x2DC0E28 VA: 0x2DC4E28
	|-ConfiguredTaskAwaitable<Int32Enum>.GetAwaiter
	|
	|-RVA: 0x2DC4EA0 Offset: 0x2DC0EA0 VA: 0x2DC4EA0
	|-ConfiguredTaskAwaitable<object>.GetAwaiter
	|
	|-RVA: 0x2DC4F18 Offset: 0x2DC0F18 VA: 0x2DC4F18
	|-ConfiguredTaskAwaitable<SerializableProjectConfiguration>.GetAwaiter
	|
	|-RVA: 0x2DC4F90 Offset: 0x2DC0F90 VA: 0x2DC4F90
	|-ConfiguredTaskAwaitable<VoidTaskResult>.GetAwaiter
	|
	|-RVA: 0x2DC5008 Offset: 0x2DC1008 VA: 0x2DC5008
	|-ConfiguredTaskAwaitable<__Il2CppFullySharedGenericType>.GetAwaiter
	*/
}
