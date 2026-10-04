// Assembly: mscorlib.dll
// Namespace: 
[Serializable]
private struct ReadOnlyDictionary.DictionaryEnumerator<TKey, TValue> : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 10918
{
	// Fields
	private readonly IDictionary<TKey, TValue> _dictionary; // 0x0
	private IEnumerator<KeyValuePair<TKey, TValue>> _enumerator; // 0x0

	// Properties
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }
	public object Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCC5A0 Offset: 0x2DC85A0 VA: 0x2DCC5A0
	|-ReadOnlyDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public DictionaryEntry get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCC65C Offset: 0x2DC865C VA: 0x2DCC65C
	|-ReadOnlyDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Entry
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public object get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCCA34 Offset: 0x2DC8A34 VA: 0x2DCCA34
	|-ReadOnlyDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public object get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCCC64 Offset: 0x2DC8C64 VA: 0x2DCCC64
	|-ReadOnlyDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public object get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCCE94 Offset: 0x2DC8E94 VA: 0x2DCCE94
	|-ReadOnlyDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCCF4C Offset: 0x2DC8F4C VA: 0x2DCCF4C
	|-ReadOnlyDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCCFEC Offset: 0x2DC8FEC VA: 0x2DCCFEC
	|-ReadOnlyDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Reset
	*/
}
