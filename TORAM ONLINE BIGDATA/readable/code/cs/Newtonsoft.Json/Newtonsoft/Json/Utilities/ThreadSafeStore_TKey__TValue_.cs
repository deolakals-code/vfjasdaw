// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
[Nullable(0)]
[NullableContext(1)]
internal class ThreadSafeStore<TKey, TValue> // TypeDefIndex: 15965
{
	// Fields
	private readonly ConcurrentDictionary<TKey, TValue> _concurrentStore; // 0x0
	private readonly Func<TKey, TValue> _creator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<TKey, TValue> creator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB6378 Offset: 0x2CB2378 VA: 0x2CB6378
	|-ThreadSafeStore<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x2CB645C Offset: 0x2CB245C VA: 0x2CB645C
	|-ThreadSafeStore<object, object>..ctor
	|
	|-RVA: 0x2CB6540 Offset: 0x2CB2540 VA: 0x2CB6540
	|-ThreadSafeStore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public TValue Get(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB6430 Offset: 0x2CB2430 VA: 0x2CB6430
	|-ThreadSafeStore<StructMultiKey<object, object>, object>.Get
	|
	|-RVA: 0x2CB6514 Offset: 0x2CB2514 VA: 0x2CB6514
	|-ThreadSafeStore<object, object>.Get
	|
	|-RVA: 0x2CB65FC Offset: 0x2CB25FC VA: 0x2CB65FC
	|-ThreadSafeStore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Get
	*/
}
