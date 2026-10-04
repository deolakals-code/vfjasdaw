// Assembly: mscorlib.dll
// Namespace: 
private sealed class ConcurrentDictionary.Tables<TKey, TValue> // TypeDefIndex: 10909
{
	// Fields
	internal readonly ConcurrentDictionary.Node<TKey, TValue>[] _buckets; // 0x0
	internal readonly object[] _locks; // 0x0
	internal int[] _countPerLock; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ConcurrentDictionary.Node<TKey, TValue>[] buckets, object[] locks, int[] countPerLock) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA4104 Offset: 0x2CA0104 VA: 0x2CA4104
	|-ConcurrentDictionary.Tables<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x2CA4168 Offset: 0x2CA0168 VA: 0x2CA4168
	|-ConcurrentDictionary.Tables<object, object>..ctor
	|
	|-RVA: 0x2CA41CC Offset: 0x2CA01CC VA: 0x2CA41CC
	|-ConcurrentDictionary.Tables<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}
