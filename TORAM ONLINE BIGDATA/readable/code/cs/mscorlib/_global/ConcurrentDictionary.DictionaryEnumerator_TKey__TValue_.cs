// Assembly: mscorlib.dll
// Namespace: 
[Serializable]
private sealed class ConcurrentDictionary.DictionaryEnumerator<TKey, TValue> : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 10911
{
	// Fields
	private IEnumerator<KeyValuePair<TKey, TValue>> _enumerator; // 0x0

	// Properties
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }
	public object Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ConcurrentDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCB464 Offset: 0x2DC7464 VA: 0x2DCB464
	|-ConcurrentDictionary.DictionaryEnumerator<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x2DCB934 Offset: 0x2DC7934 VA: 0x2DCB934
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>..ctor
	|
	|-RVA: 0x2DCBD9C Offset: 0x2DC7D9C VA: 0x2DCBD9C
	|-ConcurrentDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public DictionaryEntry get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCB4B4 Offset: 0x2DC74B4 VA: 0x2DCB4B4
	|-ConcurrentDictionary.DictionaryEnumerator<StructMultiKey<object, object>, object>.get_Entry
	|
	|-RVA: 0x2DCB984 Offset: 0x2DC7984 VA: 0x2DCB984
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.get_Entry
	|
	|-RVA: 0x2DCBDF0 Offset: 0x2DC7DF0 VA: 0x2DCBDF0
	|-ConcurrentDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Entry
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public object get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCB618 Offset: 0x2DC7618 VA: 0x2DCB618
	|-ConcurrentDictionary.DictionaryEnumerator<StructMultiKey<object, object>, object>.get_Key
	|
	|-RVA: 0x2DCBAC4 Offset: 0x2DC7AC4 VA: 0x2DCBAC4
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.get_Key
	|
	|-RVA: 0x2DCC0B4 Offset: 0x2DC80B4 VA: 0x2DCC0B4
	|-ConcurrentDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public object get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCB6D8 Offset: 0x2DC76D8 VA: 0x2DCB6D8
	|-ConcurrentDictionary.DictionaryEnumerator<StructMultiKey<object, object>, object>.get_Value
	|
	|-RVA: 0x2DCBB4C Offset: 0x2DC7B4C VA: 0x2DCBB4C
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.get_Value
	|
	|-RVA: 0x2DCC248 Offset: 0x2DC8248 VA: 0x2DCC248
	|-ConcurrentDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public object get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCB774 Offset: 0x2DC7774 VA: 0x2DCB774
	|-ConcurrentDictionary.DictionaryEnumerator<StructMultiKey<object, object>, object>.get_Current
	|
	|-RVA: 0x2DCBBDC Offset: 0x2DC7BDC VA: 0x2DCBBDC
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.get_Current
	|
	|-RVA: 0x2DCC3DC Offset: 0x2DC83DC VA: 0x2DCC3DC
	|-ConcurrentDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCB7F0 Offset: 0x2DC77F0 VA: 0x2DCB7F0
	|-ConcurrentDictionary.DictionaryEnumerator<StructMultiKey<object, object>, object>.MoveNext
	|
	|-RVA: 0x2DCBC58 Offset: 0x2DC7C58 VA: 0x2DCBC58
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.MoveNext
	|
	|-RVA: 0x2DCC45C Offset: 0x2DC845C VA: 0x2DCC45C
	|-ConcurrentDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCB890 Offset: 0x2DC7890 VA: 0x2DCB890
	|-ConcurrentDictionary.DictionaryEnumerator<StructMultiKey<object, object>, object>.Reset
	|
	|-RVA: 0x2DCBCF8 Offset: 0x2DC7CF8 VA: 0x2DCBCF8
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.Reset
	|
	|-RVA: 0x2DCC4FC Offset: 0x2DC84FC VA: 0x2DCC4FC
	|-ConcurrentDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Reset
	*/
}
