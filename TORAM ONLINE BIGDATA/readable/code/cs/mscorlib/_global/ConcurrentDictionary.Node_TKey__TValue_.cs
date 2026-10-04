// Assembly: mscorlib.dll
// Namespace: 
[Serializable]
private sealed class ConcurrentDictionary.Node<TKey, TValue> // TypeDefIndex: 10910
{
	// Fields
	internal readonly TKey _key; // 0x0
	internal TValue _value; // 0x0
	internal ConcurrentDictionary.Node<TKey, TValue> _next; // 0x0
	internal readonly int _hashcode; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(TKey key, TValue value, int hashcode, ConcurrentDictionary.Node<TKey, TValue> next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB38C4 Offset: 0x2BAF8C4 VA: 0x2BB38C4
	|-ConcurrentDictionary.Node<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x2BB3944 Offset: 0x2BAF944 VA: 0x2BB3944
	|-ConcurrentDictionary.Node<object, object>..ctor
	|
	|-RVA: 0x2BB39B4 Offset: 0x2BAF9B4 VA: 0x2BB39B4
	|-ConcurrentDictionary.Node<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}
